using System;
using Amazon.DirectoryService;
using Amazon.DirectoryService.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class DirectoryService : TestBase<AmazonDirectoryServiceClient>
    {
        [TestMethod]
        [TestCategory("DirectoryService")]
        public void TestGetDirectoryLimits()
        {
            var response = Client.GetDirectoryLimits();
            Assert.IsNotNull(response);
            Assert.IsTrue(response.DirectoryLimits.ConnectedDirectoriesLimit > 0);
        }
    }
}