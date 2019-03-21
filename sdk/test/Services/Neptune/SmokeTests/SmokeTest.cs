using Amazon.Neptune;
using Amazon.Neptune.Model;
using Xunit;

namespace AWSSDK.SmokeTests.Neptune
{
    [Trait("Category", "SmokeTests")]
    [Trait("Category", "Neptune")]
    public class SmokeTest
    {
        IAmazonNeptune neptuneServiceClient;
        public SmokeTest()
        {
            neptuneServiceClient = new AmazonNeptuneClient(Amazon.RegionEndpoint.USEast1);
        }

        [Fact]
        public void DescribeDbInstancesTest()
        {
#if BCL
            var response = neptuneServiceClient.DescribeDBInstances(new DescribeDBInstancesRequest
            {
            });
#elif NETSTANDARD
            var response = neptuneServiceClient.DescribeDBInstancesAsync(new DescribeDBInstancesRequest
            {
            }).Result;
#endif
            Assert.NotNull(response);
        }
    }
}
