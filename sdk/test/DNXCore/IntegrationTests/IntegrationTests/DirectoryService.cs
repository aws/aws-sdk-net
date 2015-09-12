using System;
using Amazon.DirectoryService;
using Amazon.DirectoryService.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class DirectoryService : TestBase<AmazonDirectoryServiceClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"DirectoryService")]
        public void TestGetDirectoryLimits()
        {
            var response = Client.GetDirectoryLimitsAsync().Result;
            Assert.NotNull(response);
            Assert.True(response.DirectoryLimits.ConnectedDirectoriesLimit > 0);
        }
    }
}