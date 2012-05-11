using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argotic.Syndication;

namespace Nant.Builder.Sample.Services
{
    public class RssService
    {
        public void Test()
        {
            RssFeed feed = RssFeed.Create(new Uri("http://feeds.bbci.co.uk/news/rss.xml"));
        }
    }
}
