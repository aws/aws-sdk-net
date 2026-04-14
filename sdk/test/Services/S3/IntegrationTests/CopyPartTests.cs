using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class CopyPartTests : IAsyncLifetime
    {
        private const string testContent = "This is the content body!";
        private const string testKeyWithSlash = "/sourceTestKey.txt";

        private AmazonS3Client _client;
        private string _bucketName;

        public async ValueTask InitializeAsync()
        {
            _client = new AmazonS3Client();
            AWSSDK_DotNet.IntegrationTests.Utils.RetryUtilities.ConfigureClient(_client);
            _bucketName = await S3TestUtils.CreateBucketWithWaitAsync(_client);

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = testKeyWithSlash,
                ContentBody = testContent
            });
        }

        public async ValueTask DisposeAsync()
        {
            if (_bucketName != null && _client != null)
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_client, _bucketName);
            _client?.Dispose();
        }

        [Fact]
        public async Task TestCopyPartWithLeadingSlash()
        {
            var destinationKeyWithSlash = "/destinationTestKey.txt";
            string uploadId = null;

            try
            {
                var multiPartUploadResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = destinationKeyWithSlash,
                });

                uploadId = multiPartUploadResponse.UploadId;
                var copyPartResponse = await _client.CopyPartAsync(new CopyPartRequest
                {
                    DestinationBucket = _bucketName,
                    DestinationKey = destinationKeyWithSlash,
                    
                    SourceBucket = _bucketName,
                    SourceKey = testKeyWithSlash,

                    UploadId = uploadId,
                    PartNumber = 1,
                });
                Assert.NotNull(copyPartResponse.ETag);
                Assert.True(copyPartResponse.ETag != null && copyPartResponse.ETag.Length > 0);
                Assert.True(copyPartResponse.PartNumber == 1);

                var completeUploadRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = destinationKeyWithSlash,
                    UploadId = uploadId,
                };
                completeUploadRequest.AddPartETags(copyPartResponse);

                var completeUploadResponse = await _client.CompleteMultipartUploadAsync(completeUploadRequest);
                Assert.Equal(HttpStatusCode.OK, completeUploadResponse.HttpStatusCode);

                var getObjectResponse = await _client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = destinationKeyWithSlash
                });

                using (getObjectResponse.ResponseStream)
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var actualText = await reader.ReadToEndAsync();
                    Assert.Equal(testContent, actualText);
                }
            }
            finally
            {
                if (uploadId != null)
                {
                    await _client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                    {
                        BucketName = _bucketName,
                        Key = destinationKeyWithSlash,
                        UploadId = uploadId
                    });
                }
            }
        }
    }
}
