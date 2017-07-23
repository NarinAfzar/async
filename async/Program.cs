using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace async
{
    class Program
    {
        static void Main(string[] args)
        {

           TestAsync();
            
            Console.ReadKey();

            const string url = "http://www.safar724.com";
            DownLoadHtmlAsync(url);
            Console.ReadLine();
        }

        private static  async Task DownLoadHtmlAsync(string url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            var webResponse = await httpWebRequest.GetResponseAsync();
            using (var responseStream = webResponse.GetResponseStream())
            {
                var buffer = new byte[2048];
                var bytesRead = 0;
                while ((bytesRead = await responseStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                }
            }
        }

        private static  async Task TestAsync()
        {
           Console.WriteLine($"Result={await StopRun()}");
           
        }

        private static async Task<int> StopRun()
        {
            System.Threading.Thread.Sleep(4000);
            return 10;
        }
    }
}
