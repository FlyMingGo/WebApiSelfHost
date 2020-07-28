using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiSelfHost.Model;

namespace WebApiSelfHost
{
    public class SignatureHelper
    {
        public static string GenSignature(CommonReq request)
        {
            string key = Config.Key;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string str = string.Format("method={0}&requesttoken={1}&timestamp={2}&version={3}&{4}&key={5}",
                        request.method, request.requesttoken, request.timestamp, request.version, date, key);
            string encrypted = DecryptAndEncryptionHelper.MD5Encrypt(str);
            return encrypted;
        }
    }
}
