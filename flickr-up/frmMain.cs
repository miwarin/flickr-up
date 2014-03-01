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

namespace flickr_up
{
    public partial class frmMain : Form
    {
        private OAuthRequestToken RequestToken;

        public frmMain()
        {
            InitializeComponent();
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

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            String Photofile = txtPhotoPath.Text;
            String Title = "it's upload trial.";
            String Desc = txtDescription.Text;
            String Tags = txtTags.Text;
            Boolean IsPrivate = false;

            Flickr f = FlickrManager.GetAuthInstance();
            f.OnUploadProgress += new EventHandler<FlickrNet.UploadProgressEventArgs>(Flickr_OnUploadProgress);
            String photo_id = f.UploadPicture(Photofile, Title, Desc, Tags, IsPrivate, false, false);
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
            txtResult.AppendText("photo upload complete.\n");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
