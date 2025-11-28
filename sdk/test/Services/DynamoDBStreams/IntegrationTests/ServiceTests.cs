using Amazon.DynamoDBStreams;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDBStreams
{
    [TestClass]
    public partial class DynamoDBStreamsTests : TestBase<AmazonDynamoDBStreamsClient>
    {
        [TestMethod]
        [TestCategory("DynamoDBStreams")]
        public async Task TestDynamoDBStreamWithServiceURL()
        {
            var config = new AmazonDynamoDBStreamsConfig
            {
                ServiceURL = "https://streams.dynamodb.us-east-1.amazonaws.com/"
            };

            using (var client = new AmazonDynamoDBStreamsClient(config))
            {
                var response = await client.ListStreamsAsync();
                Assert.IsNotNull(response.Streams);
            }
        }
    }
}
