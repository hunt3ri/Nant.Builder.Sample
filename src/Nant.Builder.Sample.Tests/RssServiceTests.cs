using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Nant.Builder.Sample.Services;

namespace Nant.Builder.Sample.Tests
{
	[TestFixture]
	public class RssServiceTests
	{
		[Test]
		public void GetFeed_Should_Return_Some_Items()
		{
			// Arrange

			var rssService = new RssService();

			// Act

			var feed = rssService.GetFeed("http://feeds.bbci.co.uk/news/rss.xml");

			// Assert

			Assert.That(feed.Channel.Items.Count(), Is.GreaterThan(0));

		}
	}
}
