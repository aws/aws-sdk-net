using Amazon.DynamoDBStreams;
using AWSSDK_DotNet.IntegrationTests.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.DynamoDBStreams
{
    [TestClass]
    public partial class DynamoDBStreamsTests : TestBase<AmazonDynamoDBStreamsClient>
    {
        [TestMethod]
        [TestCategory("DynamoDBStreams")]
        public void TestDynamoDBStreamWithServiceURL()
        {
            var config = new AmazonDynamoDBStreamsConfig();
            config.ServiceURL = "https://streams.dynamodb.us-east-1.amazonaws.com/";
            using (var client = new AmazonDynamoDBStreamsClient(config))
            {
                var response = client.ListStreams();
                Assert.IsNotNull(response.Streams);
            }
        }
    }
    
}
