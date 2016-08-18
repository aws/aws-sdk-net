using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

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
        public async Task ListDistributions()
        {
            var response = await Client.ListDistributionsAsync();
            Assert.NotNull(response.DistributionList);
        }

        [Fact]
        [Trait(CategoryAttribute,"CloudFront")]
        public async Task OriginTests()
        {
            var createRequest = new CreateCloudFrontOriginAccessIdentityRequest()
            {
                CloudFrontOriginAccessIdentityConfig = new CloudFrontOriginAccessIdentityConfig()
                {
                    CallerReference = Guid.NewGuid().ToString(),
                    Comment = UtilityMethods.SDK_TEST_PREFIX
                }
            };
            var createResponse = await Client.CreateCloudFrontOriginAccessIdentityAsync(createRequest);
            Assert.NotNull(createResponse.ETag);
            Assert.NotNull(createResponse.CloudFrontOriginAccessIdentity.Id);
            string etag = createResponse.ETag;
            try
            {
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
                var updateResponse = await Client.UpdateCloudFrontOriginAccessIdentityAsync(updateRequest);
                Assert.NotNull(updateResponse.ETag);
                etag = updateResponse.ETag;
                Assert.NotNull(updateResponse.CloudFrontOriginAccessIdentity.CloudFrontOriginAccessIdentityConfig.Comment);

                var listResponse = await Client.ListCloudFrontOriginAccessIdentitiesAsync();
                Assert.True(listResponse.CloudFrontOriginAccessIdentityList.Items.Count > 0);
            }
            finally
            {
                var deleteRequest = new DeleteCloudFrontOriginAccessIdentityRequest()
                {
                    Id = createResponse.CloudFrontOriginAccessIdentity.Id,
                    IfMatch = etag
                };
                var deleteResponse = await Client.DeleteCloudFrontOriginAccessIdentityAsync(deleteRequest);
                Assert.NotNull(deleteResponse.ResponseMetadata.RequestId);
            }
        }
    }
}
