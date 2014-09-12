using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.StorageGateway;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class StorageGateway : TestBase<AmazonStorageGatewayClient>
    {

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("StorageGateway")]
        public void TestListGateways()
        {
            var response = Client.ListGateways();

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

        [TestMethod]
        [TestCategory("StorageGateway")]
        public void TestDescribeTapeArchives()
        {
            var response = Client.DescribeTapeArchives();
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
