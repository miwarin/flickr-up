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
        public const String APIKey = "apikey";
        public const String Secret = "secret";
        
        public static Flickr GetInstance()
        {
            return new Flickr(APIKey, Secret);
        }

        public static Flickr GetAuthInstance()
        {
            Flickr f = new Flickr(APIKey, Secret);
            f.OAuthAccessToken = Config.OAuthToken.Token;
            f.OAuthAccessTokenSecret = Config.OAuthToken.TokenSecret;
            return f;
        }
    }
}
