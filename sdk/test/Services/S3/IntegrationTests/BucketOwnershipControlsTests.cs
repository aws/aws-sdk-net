using Amazon.S3;
using Amazon.S3.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class BucketOwnershipControlsTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public BucketOwnershipControlsTests(S3BucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        [Fact]
        public async Task TestGetBucketOwnershipControls_ObjectWriter()
        {
            await PutAndGetBucketOwnershipControls(ObjectOwnership.ObjectWriter);
        }

        [Fact]
        public async Task TestGetBucketOwnershipControls_BucketOwnerPreferred()
        {
            await PutAndGetBucketOwnershipControls(ObjectOwnership.BucketOwnerPreferred);
        }

        [Fact]
        public async Task TestDeleteBucketOwnershipControls()
        {
            await PutAndGetBucketOwnershipControls(ObjectOwnership.BucketOwnerPreferred);

            await _client.DeleteBucketOwnershipControlsAsync(new DeleteBucketOwnershipControlsRequest
            {
                BucketName = _bucketName
            });

            await Assert.ThrowsAsync<AmazonS3Exception>(() =>
                _client.GetBucketOwnershipControlsAsync(new GetBucketOwnershipControlsRequest
                {
                    BucketName = _bucketName
                })
            );
        }

        private async Task PutAndGetBucketOwnershipControls(ObjectOwnership objectOwnership)
        {
            await _client.PutBucketOwnershipControlsAsync(new PutBucketOwnershipControlsRequest
            {
                BucketName = _bucketName,
                OwnershipControls = new OwnershipControls
                {
                    Rules = new List<OwnershipControlsRule> { new OwnershipControlsRule { ObjectOwnership = objectOwnership } }
                }
            });

            var getResponse = await _client.GetBucketOwnershipControlsAsync(new GetBucketOwnershipControlsRequest
            {
                BucketName = _bucketName
            });
            Assert.NotNull(getResponse.OwnershipControls);
            Assert.Equal(1, getResponse.OwnershipControls.Rules.Count());
            Assert.Equal(objectOwnership, getResponse.OwnershipControls.Rules[0].ObjectOwnership);
        }
    }
}
