using System;
using Amazon.DirectoryService;
using Amazon.DirectoryService.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class DirectoryService : TestBase<AmazonDirectoryServiceClient>
    {
        [Test]
        [Category("DirectoryService")]
        public void TestGetDirectoryLimits()
        {
            var response = Client.GetDirectoryLimitsAsync().Result;
            Assert.IsNotNull(response);
            Assert.IsTrue(response.DirectoryLimits.ConnectedDirectoriesLimit > 0);
        }
    }
}