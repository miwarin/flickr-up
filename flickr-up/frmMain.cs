using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlickrNet;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace flickr_up
{
    public partial class frmMain : Form
    {

        class PhotoLocal
        {
            public PhotoLocal(String path, String title)
            {
                this.Path = path;
                this.Title = title;
            }
            public String Path { get; set; }
            public String Title { get; set; }
        }

        private OAuthRequestToken RequestToken;

        public frmMain()
        {
            InitializeComponent();
            SetupWindow();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            Flickr flickr = FlickrManager.GetInstance();

            // what's "oob" ?
            // I have tried "flickr-up", then error. hmm...
            RequestToken = flickr.OAuthGetRequestToken("oob");

            String uri = flickr.OAuthCalculateAuthorizationUrl(RequestToken.Token, AuthLevel.Write);
            System.Diagnostics.Process.Start(uri);
        }

        private void btnAuthComplete_Click(object sender, EventArgs e)
        {
            String verify = txtVerifier.Text;
            if (String.IsNullOrEmpty(verify))
            {
                MessageBox.Show("認証コードを入力してください");
                return;
            }

            Flickr flickr = FlickrManager.GetInstance();
            try
            {
                var Accsesstoken = flickr.OAuthGetAccessToken(RequestToken, verify);
                txtResult.AppendText("ok\n");
                txtResult.AppendText(Accsesstoken.FullName + "\n");
                Config.OAuthToken = Accsesstoken;
            }
            catch(FlickrApiException ex)
            {
                txtResult.AppendText(ex.ToString());
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<PhotoLocal> PhotofileList = GetPhotoPathList(txtPhotoPath.Text);
            if (PhotofileList == null || PhotofileList.Count == 0)
            {
                MessageBox.Show("画像フォルダを指定してください");
                return;
            }

            String Desc = txtDescription.Text;
            String Tags = txtTags.Text;
            String Sets = txtSets.Text;
            Boolean IsPrivate = false;
            List<String> PhotoID = new List<String>();
            int resize = 100;

            try
            {
                resize = Convert.ToInt32(txtResize.Text);
            }
            catch(FormatException ex)
            {
                txtResize.AppendText(ex.Message);
            }

            if(Directory.Exists(Config.WorkDirectory) == false)
            {
                Directory.CreateDirectory(Config.WorkDirectory);
            }


            Flickr f = FlickrManager.GetAuthInstance();
            f.OnUploadProgress += new EventHandler<FlickrNet.UploadProgressEventArgs>(Flickr_OnUploadProgress);

            foreach (PhotoLocal photofile in PhotofileList)
            {
                //txtResult.AppendText(photofile.Title + " ...\n");
                Console.WriteLine(photofile.Title + " ...");
                
                String srcimg = photofile.Path;
                String dstimg = System.IO.Path.Combine(
                    Config.WorkDirectory, 
                    Path.GetFileNameWithoutExtension(srcimg) + ".JPG");

                Resize(srcimg, dstimg, resize);

                PhotoID.Add(f.UploadPicture(dstimg, photofile.Title, Desc, Tags, IsPrivate, false, false));
            }

            if (String.IsNullOrEmpty(Sets) == true)
            {
                return;
            }

            //txtResult.AppendText(String.Format("Create Sets: {0} ...\n", Sets));
            Console.Write(String.Format("Create Sets: {0} ...\n", Sets));

            int StartIndex = 0;
            String PhotosetID;

            PhotosetID = GetPhotoSetID(Sets);
            if (PhotosetID == "")
            {
                Photoset photoset = f.PhotosetsCreate(Sets, PhotoID[0]);
                PhotosetID = photoset.PhotosetId;
                StartIndex++;
            }

            if (StartIndex >= PhotoID.Count)
            {
                return;
            }

            for (int i = StartIndex; i < PhotoID.Count; i++)
            {
                f.PhotosetsAddPhoto(PhotosetID, PhotoID[i]);
            }
        }

        private void Resize(String srcimg, String dstimg, int resize)
        {
            ProcessStartInfo psi = new ProcessStartInfo();

            psi.FileName = Config.IMConvertPath;
            psi.RedirectStandardInput = false;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.Arguments = String.Format("-verbose -resize {0}% {1} {2}", resize, srcimg, dstimg);
            Process p = Process.Start(psi);
            //string results = p.StandardOutput.ReadToEnd();
            string results = p.StandardError.ReadToEnd();
            p.WaitForExit();
            Console.WriteLine(results);
            //txtResult.AppendText(results + "\n");
        }


        private void Flickr_OnUploadProgress(object sender, FlickrNet.UploadProgressEventArgs e)
        {
            bgWorker.ReportProgress(e.ProcessPercentage);
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgbarUpload.Value = e.ProgressPercentage;
        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            txtResult.AppendText("写真アップロード完了.\n");
        }

        private void txtPhotoPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtPhotoPath.Text = files[0];
        }

        private void txtPhotoPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private List<PhotoLocal> GetPhotoPathList(String PhotoDir)
        {
            List<PhotoLocal> list = new List<PhotoLocal>();

            if (Directory.Exists(PhotoDir) == false)
            {
                return null;
            }

            string[] files = Directory.GetFiles(PhotoDir);
            foreach(String file in files)
            {
                //String ext = Path.GetExtension(file).ToLower();
                //if(ext == ".jpg")
                {
                    String title = Path.GetFileNameWithoutExtension(file);
                    PhotoLocal p = new PhotoLocal(file, title);
                    list.Add(p);
                }
            }

            return list;
        }

        private String GetPhotoSetID(String Sets)
        {
            Flickr f = FlickrManager.GetAuthInstance();
            PhotosetCollection photosets = f.PhotosetsGetList();

            foreach (Photoset pset in photosets)
            {
                if (Sets == pset.Title)
                {
                    return pset.PhotosetId;
                }
                Console.WriteLine(pset.Title);
            }
            return "";
        }

        private void txtPhotoPath_TextChanged(object sender, EventArgs e)
        {
            Config.PhotoDirectory = txtPhotoPath.Text;
        }

        private void txtIMConvertPath_TextChanged(object sender, EventArgs e)
        {
            Config.IMConvertPath = txtIMConvertPath.Text;
        }

        private void txtAPIKey_TextChanged(object sender, EventArgs e)
        {
            Config.APIKey = txtAPIKey.Text;
        }

        private void txtSecret_TextChanged(object sender, EventArgs e)
        {
            Config.Secret = txtSecret.Text;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void SetupWindow()
        {
            txtSecret.Text = Config.Secret;
            txtPhotoPath.Text = Config.PhotoDirectory;
            txtIMConvertPath.Text = Config.IMConvertPath;
            txtWorkDirectory.Text = Config.WorkDirectory;
            txtResize.Text = String.Format("{0}", Config.Resize);
            txtAPIKey.Text = Config.APIKey;
            txtSecret.Text = Config.Secret;
        }

        private void txtIMConvertPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtIMConvertPath.Text = files[0];
        }

        private void txtIMConvertPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtResize_TextChanged(object sender, EventArgs e)
        {
            int resize = 100;

            try
            {
                resize = Convert.ToInt32(txtResize.Text);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Config.Resize = resize;
        }

        private void txtWorkDirectory_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtWorkDirectory.Text = files[0];
        }

        private void txtWorkDirectory_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtWorkDirectory_TextChanged(object sender, EventArgs e)
        {
            Config.WorkDirectory = txtWorkDirectory.Text;
        }


    }
}
