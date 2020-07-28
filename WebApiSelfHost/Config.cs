using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiSelfHost
{
    public class Config
    {
        public static string DatabaseServer { get; set; } = ConfigurationManager.AppSettings["DatabaseServer"];
        public static string Database { get; set; } = ConfigurationManager.AppSettings["Database"];
        public static string UserID { get; set; } = ConfigurationManager.AppSettings["UserID"];
        public static string Password { get; set; } = ConfigurationManager.AppSettings["Password"];
        public static string Port { get; set; } = ConfigurationManager.AppSettings["Port"];
        public static string Charset { get; set; } = ConfigurationManager.AppSettings["Charset"];
        public static string ServiceAPI { get; set; } = ConfigurationManager.AppSettings["ServiceAPI"];
        public static string JsonVersion { get; set; } = ConfigurationManager.AppSettings["JsonVersion"];
        public static string Key { get; set; } = "866585558226OPKE8EFE9873";
    }
}
