using System;
using System.Collections.Generic;
using System.Threading;

using Amazon.CloudFront;
using Amazon.CloudFront.Model;
using Amazon.S3.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class CloudFront : TestBase<AmazonCloudFrontClient>
    {
        [Test]
        [Category("CloudFront")]
        public void ListDistributions()
        {
            var response = Client.ListDistributionsAsync().Result;
            Assert.IsNotNull(response.DistributionList);
        }

        [Test]
        [Category("CloudFront")]
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
            var createResponse = Client.CreateCloudFrontOriginAccessIdentityAsync(createRequest).Result;
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
            var updateResponse = Client.UpdateCloudFrontOriginAccessIdentityAsync(updateRequest).Result;
            Assert.IsNotNull(updateResponse.ETag);
            Assert.IsNotNull(updateResponse.CloudFrontOriginAccessIdentity.CloudFrontOriginAccessIdentityConfig.Comment);


            var listResponse = Client.ListCloudFrontOriginAccessIdentitiesAsync().Result;
            Assert.IsTrue(listResponse.CloudFrontOriginAccessIdentityList.Items.Count > 0);

            var deleteRequest = new DeleteCloudFrontOriginAccessIdentityRequest()
            {
                Id = createResponse.CloudFrontOriginAccessIdentity.Id,
                IfMatch = updateResponse.ETag
            };
            var deleteResponse = Client.DeleteCloudFrontOriginAccessIdentityAsync(deleteRequest).Result;
            Assert.IsNotNull(deleteResponse.ResponseMetadata.RequestId);
        }
    }
}
