using System;
using System.IO;
using System.Net;
using System.Text;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = string.Format("{0}/api/Hello", System.Configuration.ConfigurationManager.ConnectionStrings["API"]);
            string response = CallAPI(url);

            Console.WriteLine(response);
            Console.ReadKey();
        }

        public static string CallAPI(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "GET";
            webRequest.ContentType = "application/x-www-form-urlencoded";

            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webResponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webResponse.Close();
            return result;
        }
    }
}
