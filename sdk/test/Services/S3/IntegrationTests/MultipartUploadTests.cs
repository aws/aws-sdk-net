using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class MultipartUploadTests
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        public MultipartUploadTests(SharedS3ObjectBucketFixture sharedBucket)
        {
            _client = sharedBucket.Client;
            _bucketName = sharedBucket.BucketName;
            _testId = System.Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// Test so that no regression happens like the one reported below.
        /// https://github.com/aws/aws-sdk-net/issues/3971 
        /// </summary>
        [Fact]
        public async Task TestInitiateMultipartUploadWithNoACL()
        {
            var initMpuResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
            {
                BucketName = _bucketName,
                Key = _testId + "-test-mpu",
                StorageClass = S3StorageClass.Standard,
                CannedACL = S3CannedACL.NoACL
            });
            Assert.Equal(initMpuResponse.HttpStatusCode, HttpStatusCode.OK);
            
            if (initMpuResponse.UploadId != null)
            {
                await _client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = _testId + "-test-mpu",
                    UploadId = initMpuResponse.UploadId
                });
            }
        }
    }
}
