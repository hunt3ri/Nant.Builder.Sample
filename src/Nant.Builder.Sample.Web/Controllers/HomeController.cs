using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nant.Builder.Sample.Services;

namespace Nant.Builder.Sample.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private readonly RssService _rssService;

        public HomeController()
        {
            _rssService = new RssService(); 
        }
        
        public ActionResult Index()
        {
            var feed = _rssService.GetFeed("http://feeds.bbci.co.uk/news/rss.xml");
            return View(feed);
        }

    }
}
