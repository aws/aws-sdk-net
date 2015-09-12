

using Amazon.StorageGateway;
using Amazon.DNXCore.IntegrationTests;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class StorageGateway : TestBase<AmazonStorageGatewayClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"StorageGateway")]
        public void TestListGateways()
        {
            var response = Client.ListGatewaysAsync().Result;

            Assert.NotNull(response);
            Assert.NotNull(response.Gateways);

            // test a/c may not have any gateways but if some are returned, make
            // sure they marshalled ok
            if (response.Gateways.Count > 0)
            {
                foreach (var gi in response.Gateways)
                {
                    Assert.False(string.IsNullOrEmpty(gi.GatewayARN));
                }
            }
        }

        [Fact]
        [Trait(CategoryAttribute,"StorageGateway")]
        public void TestDescribeTapeArchives()
        {
            var response = Client.DescribeTapeArchivesAsync().Result;
            Assert.NotNull(response);
            Assert.NotNull(response.TapeArchives);

            // test a/c may not have any archives but if some are returned, make
            // sure they marshalled ok
            if (response.TapeArchives.Count > 0)
            {
                foreach (var ta in response.TapeArchives)
                {
                    Assert.False(string.IsNullOrEmpty(ta.TapeARN));
                }
            }
        }
    }
}
