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
        private String APIKey = "apikey";
        private String Secret = "secret";
        private OAuthRequestToken RequestToken;

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flickr flickr = new Flickr(APIKey, Secret);

            // what's "oob" ?
            // I have tried "flickr-up", then error. hmm...
            RequestToken = flickr.OAuthGetRequestToken("oob");

            String uri = flickr.OAuthCalculateAuthorizationUrl(RequestToken.Token, AuthLevel.Write);
            System.Diagnostics.Process.Start(uri);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String verify = txtVerifier.Text;
            if (String.IsNullOrEmpty(verify))
            {
                MessageBox.Show("認証コードを入力してください");
                return;
            }

            Flickr flickr = new Flickr(APIKey, Secret);
            try
            {
                var Accsesstoken = flickr.OAuthGetAccessToken(RequestToken, verify);
                txtResult.AppendText("ok");
                txtResult.AppendText(Accsesstoken.FullName);

            }
            catch(FlickrApiException ex)
            {
                txtResult.AppendText(ex.ToString());
            }
        }

    }
}
