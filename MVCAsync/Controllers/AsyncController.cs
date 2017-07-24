using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace MVCAsync.Controllers
{
    public class AsyncController : Controller
    {
        // GET: Async
        public ActionResult Sync()
        {
            return View();
        }

        DownloadData(string url)
        {
            var httpClinet = new HttpClient();
            var httpResponseMessage = httpClinet.GetAsync(url).Result;
            httpResponseMessage.EnsureSuccessStatusCode();
            httpResponseMessage.Content.ReadAsAsync<IEnumerable<Video>>().Result;
        }

    }
}