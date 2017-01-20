using System;
using System.Threading.Tasks;
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
        public async Task TestGetDirectoryLimits()
        {
            var response = await Client.GetDirectoryLimitsAsync();
            Assert.NotNull(response);
            Assert.True(response.DirectoryLimits.ConnectedDirectoriesLimit > 0);
        }
    }
}