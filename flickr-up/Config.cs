using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;

namespace flickr_up
{
    public class Config
    {
        public static String APIKey
        {
            get
            {
                return Properties.Settings.Default.APIKey;
            }
            set
            {
                Properties.Settings.Default.APIKey = value;
                Properties.Settings.Default.Save();
            }
        }

        public static String Secret
        {
            get
            {
                return Properties.Settings.Default.Secret;
            }
            set
            {
                Properties.Settings.Default.Secret = value;
                Properties.Settings.Default.Save();
            }
        }

        public static String PhotoDirectory
        {
            get
            {
                return Properties.Settings.Default.PhotoDirectory;
            }
            set
            {
                Properties.Settings.Default.PhotoDirectory = value;
                Properties.Settings.Default.Save();
            }
        }

        public static String IrfanviewPath
        {
            get
            {
                return Properties.Settings.Default.IrfanviewPath;
            }
            set
            {
                Properties.Settings.Default.IrfanviewPath = value;
                Properties.Settings.Default.Save();
            }
        }

        public static String WorkDirectory
        {
            get
            {
                return Properties.Settings.Default.WorkDirectory;
            }
            set
            {
                Properties.Settings.Default.WorkDirectory = value;
                Properties.Settings.Default.Save();
            }
        }

        public static int Resize
        {
            get
            {
                return Properties.Settings.Default.Resize;
            }
            set
            {
                Properties.Settings.Default.Resize = value;
                Properties.Settings.Default.Save();
            }
        }


        public static OAuthAccessToken OAuthToken
        {
            get
            {
                return Properties.Settings.Default.OAuthToken;
            }
            set
            {
                Properties.Settings.Default.OAuthToken = value;
                Properties.Settings.Default.Save();
            }
        }

    }
}
