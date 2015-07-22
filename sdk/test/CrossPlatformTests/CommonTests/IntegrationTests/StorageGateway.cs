

using Amazon.StorageGateway;
using CommonTests.Framework;
using NUnit.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class StorageGateway : TestBase<AmazonStorageGatewayClient>
    {

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [Test]
        [Category("StorageGateway")]
        public void TestListGateways()
        {
            var response = Client.ListGatewaysAsync().Result;

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Gateways);

            // test a/c may not have any gateways but if some are returned, make
            // sure they marshalled ok
            if (response.Gateways.Count > 0)
            {
                foreach (var gi in response.Gateways)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(gi.GatewayARN));
                }
            }
        }

        [Test]
        [Category("StorageGateway")]
        public void TestDescribeTapeArchives()
        {
            var response = Client.DescribeTapeArchivesAsync().Result;
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.TapeArchives);

            // test a/c may not have any archives but if some are returned, make
            // sure they marshalled ok
            if (response.TapeArchives.Count > 0)
            {
                foreach (var ta in response.TapeArchives)
                {
                    Assert.IsFalse(string.IsNullOrEmpty(ta.TapeARN));
                }
            }
        }
    }
}
