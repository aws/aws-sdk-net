using Amazon.TimestreamQuery;
using Amazon.TimestreamQuery.Model;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    public class TimestreamQuery : TestBase<AmazonTimestreamQueryClient>
    {
        [Fact]
        [Trait(CategoryAttribute, "TimestreamQuery")]
        public async Task SkipsEndpointDiscoveryWithServiceUrl()
        {
            // Timestream is built using a cellular architecture, and the actual service URL is determined using
            // endpoint discovery (see https://docs.aws.amazon.com/timestream/latest/developerguide/Using.API.html for details).

            // This test validates that when a custom service URL is specified (which is the case when using
            // VPC endpoints for example), the SDK will not attempt to retrieve endpoints dynamically.

            // This is necessary because the "DescribeEndpoints" API (the first step in endpoint discovery) is
            // only available via the regional endpoints, and it fails when being accessed through a VPC endpoint (preventing
            // customers from using the service altogether).
            var describeResponse = await Client.DescribeEndpointsAsync(new DescribeEndpointsRequest());
            Assert.Equal(HttpStatusCode.OK, describeResponse.HttpStatusCode);
            Assert.NotEmpty(describeResponse.Endpoints);

            var customEndpoint = describeResponse.Endpoints.First();
            var config = new AmazonTimestreamQueryConfig
            {
                ServiceURL = $"https://{customEndpoint.Address}"
            };

            using (var customClient = new AmazonTimestreamQueryClient(config))
            {
                var listResponse = await customClient.ListScheduledQueriesAsync(new ListScheduledQueriesRequest());
                Assert.Equal(HttpStatusCode.OK, listResponse.HttpStatusCode);
            }
        }
    }
}
