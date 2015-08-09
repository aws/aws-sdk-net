using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon;
using Amazon.Runtime;

using Amazon.SQS;
using Amazon.SQS.Model;

using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    public class SQSTests
    {
        [Fact]
        public async Task ListQueues()
        {
            var credentials = FallbackCredentialsFactory.GetCredentials();

            using (var client = new AmazonSQSClient(credentials, RegionEndpoint.USEast1))
            {
                var request = new ListQueuesRequest();
                var response = await client.ListQueuesAsync(request);
                Assert.NotNull(response.ResponseMetadata.Metadata);
                Assert.NotNull(response.QueueUrls);
            }
        }
    }
}
