using System;
using Amazon;
using Amazon.ElasticFileSystem;
using Amazon.ElasticFileSystem.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ElasticFileSystem : TestBase<AmazonElasticFileSystemClient>
    {
        [TestMethod]
        [TestCategory("ElasticFileSystem")]
        public void TestDescribeFileSystems()
        {
            var efsClient = new AmazonElasticFileSystemClient(RegionEndpoint.USWest2);
            var response = efsClient.DescribeFileSystems(new DescribeFileSystemsRequest());
            Assert.IsNotNull(response);
        }
    }
}
