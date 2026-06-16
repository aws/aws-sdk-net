using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class VersioningTests : IClassFixture<S3BucketFixture>, IAsyncLifetime
    {
        private const string content = "Test content";
        private const string key = "test.txt";

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public VersioningTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
        }

        public async ValueTask InitializeAsync()
        {
            // Enable versioning once for the class-level bucket
            await _client.PutBucketVersioningAsync(new PutBucketVersioningRequest
            {
                BucketName = _bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

            await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketVersioningAsync(new GetBucketVersioningRequest
                {
                    BucketName = _bucketName
                });
                return res.VersioningConfig?.Status == VersionStatus.Enabled ? res : null;
            });
        }

        public ValueTask DisposeAsync() => new ValueTask();

        [Fact]
        public async Task TestVersionBucketName()
        {
            var count = 5;
            for (int i = 0; i < count; i++)
            {
                await _client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    ContentBody = content
                });
            }
                        
            var response = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.ListVersionsAsync(_bucketName);                
                return res.Versions?.Count == count ? res : null;
            });

            Assert.Equal(count, response.Versions.Count);
            foreach (var version in response.Versions)
            {
                Assert.Equal(_bucketName, version.BucketName);
                Assert.Equal(key, version.Key);
            }
        }
    }
}
