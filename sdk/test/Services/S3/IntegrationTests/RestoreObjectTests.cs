using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class RestoreObjectTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        public RestoreObjectTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
            _testId = System.Guid.NewGuid().ToString("N");
        }

        [Fact]
        public async Task TestRestoreObject()
        {
            var keyName = _testId + "-test-restore-object";

            // Put object with Glacier storage class
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = keyName,
                ContentBody = "Test content for restore",
                StorageClass = S3StorageClass.Glacier
            });

            // Restore the object
            var response = await _client.RestoreObjectAsync(new RestoreObjectRequest
            {
                BucketName = _bucketName,
                Key = keyName,
                Days = 1
            });
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.Accepted, response.HttpStatusCode);
        }

        [Fact]
        public async Task TestRestoreObjectWithTier()
        {
            var keyName = _testId + "-test-restore-object-tier";

            // Put object with Glacier storage class
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = keyName,
                ContentBody = "Test content for restore",
                StorageClass = S3StorageClass.Glacier
            });

            // Restore the object
            // note: S3 does not accept RetrievalTier + Days combination for some reason. S3 expects the tier that is wrapped in
            // glacier job parameters when doing a barebones restore with tier and days set.
            // https://github.com/aws/aws-sdk/issues/246
            var response = await _client.RestoreObjectAsync(new RestoreObjectRequest
            {
                BucketName = _bucketName,
                Key = keyName,
                Days = 1,
                Tier = GlacierJobTier.Standard
            });
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.Accepted, response.HttpStatusCode);
        }
    }
}
