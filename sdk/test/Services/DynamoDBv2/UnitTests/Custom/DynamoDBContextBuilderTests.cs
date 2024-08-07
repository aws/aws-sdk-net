using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.DynamoDBv2.NetFramework.Custom
{
    [TestClass]
    public class DynamoDBContextBuilderTests
    {
        [TestMethod]
        public void SetClientAndRegion_ThrowsException()
        {
            var  ddbClient = new AmazonDynamoDBClient();

            Assert.ThrowsException<AmazonDynamoDBException>(() =>
            {
                var context = new DynamoDBContextBuilder()
                    .SetDynamoDBClient(ddbClient)
                    .SetAWSRegion(RegionEndpoint.USWest2)
                    .Build();
            });
        }
    }
}
