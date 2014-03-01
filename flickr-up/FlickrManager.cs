using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlickrNet;

namespace flickr_up
{
    public class FlickrManager
    {
        public static Flickr GetInstance()
        {
            return new Flickr(Config.APIKey, Config.Secret);
        }

        public static Flickr GetAuthInstance()
        {
            Flickr f = new Flickr(Config.APIKey, Config.Secret);
            f.OAuthAccessToken = Config.OAuthToken.Token;
            f.OAuthAccessTokenSecret = Config.OAuthToken.TokenSecret;
            return f;
        }
    }
}
