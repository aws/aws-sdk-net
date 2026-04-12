using Amazon;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.Util;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3Control
{
    [Trait("Category", "S3Control")]
    public class PublicAccessBlockTests : TestBase<AmazonS3ControlClient>, IAsyncLifetime
    {
        private string accountId;
        private AmazonS3ControlClient client;

        public async ValueTask InitializeAsync()
        {
            var response = await new AmazonSecurityTokenServiceClient().GetCallerIdentityAsync(new GetCallerIdentityRequest());
            accountId = response.Account;
            client = new AmazonS3ControlClient(RegionEndpoint.USEast1);
        }

        public ValueTask DisposeAsync()
        {
            BaseClean();
            return default;
        }

        [Fact]
        public async Task TestPublicAccessBlock()
        {
            await client.PutPublicAccessBlockAsync(new PutPublicAccessBlockRequest
            {
                AccountId = accountId,
                PublicAccessBlockConfiguration = new PublicAccessBlockConfiguration
                {
                    BlockPublicPolicy = false
                }
            });

            var response = await client.GetPublicAccessBlockAsync(new GetPublicAccessBlockRequest
            {
                AccountId = accountId
            });

            Assert.True(response.ResponseMetadata.Metadata.ContainsKey(HeaderKeys.XAmzId2Header));
            Assert.False(response.PublicAccessBlockConfiguration.BlockPublicPolicy.Value);
            
            await client.DeletePublicAccessBlockAsync(new DeletePublicAccessBlockRequest
            {
                AccountId = accountId
            });
        }

#if NETFRAMEWORK
        [Fact]
        public async Task TestPublicAccessBlockException()
        {
            var exception = await Assert.ThrowsAsync<AmazonS3ControlException>(async () =>
            {
                await client.PutPublicAccessBlockAsync(new PutPublicAccessBlockRequest
                {
                    AccountId = "0000",
                    PublicAccessBlockConfiguration = new PublicAccessBlockConfiguration
                    {
                        BlockPublicPolicy = false
                    }
                });
            });

            Assert.False(string.IsNullOrEmpty(exception.AmazonId2));
        }
#endif
    }
}
