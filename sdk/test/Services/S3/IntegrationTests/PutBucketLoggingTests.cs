using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class PutBucketLoggingTests : IClassFixture<S3PublicAclBucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public PutBucketLoggingTests(S3PublicAclBucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        [Fact]
        public async Task TestPutBucketLogging()
        {
            var grantList = new List<S3Grant>
            {
                new S3Grant
                {
                    Grantee = new S3Grantee() { URI = "http://acs.amazonaws.com/groups/s3/LogDelivery" },
                    Permission = S3Permission.READ
                }
            };

            var response = await _client.PutBucketLoggingAsync(new PutBucketLoggingRequest
            {
                BucketName = _bucketName,
                LoggingConfig = new S3BucketLoggingConfig
                {
                    TargetBucketName = _bucketName,
                    Grants = grantList
                }
            });
            Assert.NotNull(response);
        }
    }
}
