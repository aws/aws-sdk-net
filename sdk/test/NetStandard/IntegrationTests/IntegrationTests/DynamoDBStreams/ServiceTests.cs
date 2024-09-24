using System;
using System.Text;
using Amazon.DynamoDBStreams;
using Amazon.DynamoDBStreams.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
namespace Amazon.DNXCore.IntegrationTests.DynamoDBStreams
{
    public partial class DynamoDBStreamsTests {
        [Fact]
        [Trait("Category", "DynamoDBStreams")]
        public async Task TestDynamoDBStreamWithServiceURL()
        {
            var config = new AmazonDynamoDBStreamsConfig();
            config.ServiceURL = "https://streams.dynamodb.us-east-1.amazonaws.com/";
            using(var client = new AmazonDynamoDBStreamsClient(config))
            {
                var response = await client.ListStreamsAsync();
                Assert.NotNull(response.Streams);
            }
        }
    }
}

