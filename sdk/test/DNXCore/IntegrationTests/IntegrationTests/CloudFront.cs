using System;
using System.Collections.Generic;
using System.Threading;

using Amazon.CloudFront;
using Amazon.CloudFront.Model;
using Amazon.S3.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class CloudFront : TestBase<AmazonCloudFrontClient>
    {
        [Fact]
        [Trait(CategoryAttribute,"CloudFront")]
        public void ListDistributions()
        {
            var response = Client.ListDistributionsAsync().Result;
            Assert.NotNull(response.DistributionList);
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFront")]
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
            Assert.NotNull(createResponse.ETag);
            Assert.NotNull(createResponse.CloudFrontOriginAccessIdentity.Id);

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
            Assert.NotNull(updateResponse.ETag);
            Assert.NotNull(updateResponse.CloudFrontOriginAccessIdentity.CloudFrontOriginAccessIdentityConfig.Comment);


            var listResponse = Client.ListCloudFrontOriginAccessIdentitiesAsync().Result;
            Assert.True(listResponse.CloudFrontOriginAccessIdentityList.Items.Count > 0);

            var deleteRequest = new DeleteCloudFrontOriginAccessIdentityRequest()
            {
                Id = createResponse.CloudFrontOriginAccessIdentity.Id,
                IfMatch = updateResponse.ETag
            };
            var deleteResponse = Client.DeleteCloudFrontOriginAccessIdentityAsync(deleteRequest).Result;
            Assert.NotNull(deleteResponse.ResponseMetadata.RequestId);
        }
    }
}
