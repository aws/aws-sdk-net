using Amazon.Cloud9;
using Amazon.Cloud9.Model;
using System.ComponentModel;
using Xunit;

namespace AWSSDK.SmokeTests.Cloud9
{
    [Trait("Category", "SmokeTests")]
    [Trait("Category", "Cloud9")]
    public class SmokeTest
    {
        IAmazonCloud9 cloud9Client;
        public SmokeTest()
        {
            cloud9Client = new AmazonCloud9Client(Amazon.RegionEndpoint.USEast1);
        }

        [Fact]
        public void ListEnvironmentSmokeTest()
        {
#if BCL
            var response = cloud9Client.ListEnvironments(new ListEnvironmentsRequest
            {
            });
#elif CORECLR
            var response = cloud9Client.ListEnvironmentsAsync(new ListEnvironmentsRequest
            {
            }).Result;
#endif
            Assert.NotNull(response);
        }
    }
}
