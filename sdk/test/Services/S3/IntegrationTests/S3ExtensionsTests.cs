using Amazon.S3;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    public class S3ExtensionsTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public S3ExtensionsTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
        }

        [Fact]
        public async Task EnsureBucketExists()
        {
            IAmazonS3 s3Client = _client;
            await s3Client.EnsureBucketExistsAsync(_bucketName);
        }
    }
}
