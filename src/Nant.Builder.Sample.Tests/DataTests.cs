using Nant.Builder.Sample.Data;
using NUnit.Framework;

namespace Nant.Builder.Sample.Tests
{
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void CreateDbTest()
        {
            var test = new Database();
            test.CreateDb();
        }
    }
}
