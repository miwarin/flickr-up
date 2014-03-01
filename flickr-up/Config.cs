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
