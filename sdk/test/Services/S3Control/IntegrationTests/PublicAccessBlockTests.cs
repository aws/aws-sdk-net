using Amazon;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3Control
{
    [TestClass]
    [TestCategory("S3Control")]
    public class PublicAccessBlockTests : TestBase<AmazonS3ControlClient>
    {
        private string accountId;
        private AmazonS3ControlClient client;

        [TestInitialize]
        public async Task Initialize()
        {
            var response = await new AmazonSecurityTokenServiceClient().GetCallerIdentityAsync(new GetCallerIdentityRequest());
            accountId = response.Account;
            client = new AmazonS3ControlClient(RegionEndpoint.USEast1);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BaseClean();
        }

        [TestMethod]
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

            Assert.IsTrue(response.ResponseMetadata.Metadata.ContainsKey(HeaderKeys.XAmzId2Header));
            Assert.IsFalse(response.PublicAccessBlockConfiguration.BlockPublicPolicy.Value);
            
            await client.DeletePublicAccessBlockAsync(new DeletePublicAccessBlockRequest
            {
                AccountId = accountId
            });
        }

        [TestMethod]
        public async Task TestPublicAccessBlockException()
        {
            var exception = await Assert.ThrowsExceptionAsync<AmazonS3ControlException>(async () =>
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

            Assert.IsFalse(string.IsNullOrEmpty(exception.AmazonId2));
        }
    }
}