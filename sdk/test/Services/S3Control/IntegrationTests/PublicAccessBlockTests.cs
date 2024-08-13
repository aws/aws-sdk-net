using Amazon;
using Amazon.S3Control;
using Amazon.S3Control.Model;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Amazon.Util;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3Control
{
    [TestClass]
    public class PublicAccessBlockTests : TestBase<AmazonS3ControlClient>
    {
        private string accountId;

        private AmazonS3ControlClient client;

        [TestInitialize]
        public void Initialize()
        {
            accountId = new AmazonSecurityTokenServiceClient().GetCallerIdentity(new GetCallerIdentityRequest()).Account;
            client = new AmazonS3ControlClient(RegionEndpoint.USEast1);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3Control")]
        public void TestPublicAccessBlock()
        {
            client.PutPublicAccessBlock(new PutPublicAccessBlockRequest
            {
                AccountId = accountId,
                PublicAccessBlockConfiguration = new PublicAccessBlockConfiguration()
                {
                    BlockPublicPolicy = false
                }
            });
            var response = client.GetPublicAccessBlock(new GetPublicAccessBlockRequest()
            {
                AccountId = accountId
            });
            Assert.IsTrue(response.ResponseMetadata.Metadata.ContainsKey(HeaderKeys.XAmzId2Header));
            Assert.IsFalse(response.PublicAccessBlockConfiguration.BlockPublicPolicy.Value);
            client.DeletePublicAccessBlock(new DeletePublicAccessBlockRequest()
            {
                AccountId = accountId
            });
        }

        [TestMethod]
        [TestCategory("S3Control")]
        public void TestPublicAccessBlockException()
        {
            var exception = Assert.ThrowsException<AmazonS3ControlException>(() =>
            {
                client.PutPublicAccessBlock(new PutPublicAccessBlockRequest
                {
                    AccountId = "0000",
                    PublicAccessBlockConfiguration = new PublicAccessBlockConfiguration()
                    {
                        BlockPublicPolicy = false
                    }
                });
            });
            Assert.IsFalse(String.IsNullOrEmpty(exception.AmazonId2));
        }
    }
}