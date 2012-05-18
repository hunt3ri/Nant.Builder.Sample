using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Argotic.Syndication;

namespace Nant.Builder.Sample.Services
{
    public class RssService
    {
        public RssFeed GetFeed(string feedAddress)
        {
            RssFeed feed = RssFeed.Create(new Uri(feedAddress));

            return feed;
        }
    }
}
