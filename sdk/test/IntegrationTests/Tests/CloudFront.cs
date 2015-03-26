using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Tests;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.CloudFront;
using Amazon.CloudFront.Model;
using Amazon.S3.Model;
using Amazon.IdentityManagement.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class CloudFront : TestBase<AmazonCloudFrontClient>
    {
        [TestMethod]
        [TestCategory("CloudFront")]
        public void ListDistributions()
        {
            var response = Client.ListDistributions();
            Assert.IsNotNull(response.DistributionList);
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void OriginTests()
        {
            var createRequest = new CreateCloudFrontOriginAccessIdentityRequest()
            {
                CloudFrontOriginAccessIdentityConfig = new CloudFrontOriginAccessIdentityConfig()
                {
                    CallerReference = Guid.NewGuid().ToString(),
                    Comment = UtilityMethods.SDK_TEST_PREFIX
                }
            };
            var createResponse = Client.CreateCloudFrontOriginAccessIdentity(createRequest);
            Assert.IsNotNull(createResponse.ETag);
            Assert.IsNotNull(createResponse.CloudFrontOriginAccessIdentity.Id);

            var updateRequest = new UpdateCloudFrontOriginAccessIdentityRequest()
            {
                CloudFrontOriginAccessIdentityConfig = new CloudFrontOriginAccessIdentityConfig()
                {
                    CallerReference = createRequest.CloudFrontOriginAccessIdentityConfig.CallerReference,
                    Comment = UtilityMethods.SDK_TEST_PREFIX + "update"
                },
                Id = createResponse.CloudFrontOriginAccessIdentity.Id,
                IfMatch = createResponse.ETag
            };
            var updateResponse = Client.UpdateCloudFrontOriginAccessIdentity(updateRequest);
            Assert.IsNotNull(updateResponse.ETag);
            Assert.IsNotNull(updateResponse.CloudFrontOriginAccessIdentity.CloudFrontOriginAccessIdentityConfig.Comment);


            var listResponse = Client.ListCloudFrontOriginAccessIdentities();
            Assert.IsTrue(listResponse.CloudFrontOriginAccessIdentityList.Items.Count > 0);

            var deleteRequest = new DeleteCloudFrontOriginAccessIdentityRequest()
            {
                Id = createResponse.CloudFrontOriginAccessIdentity.Id,
                IfMatch = updateResponse.ETag
            };
            var deleteResponse = Client.DeleteCloudFrontOriginAccessIdentity(deleteRequest);
            Assert.IsNotNull(deleteResponse.ResponseMetadata.RequestId);
        }
    }
}
