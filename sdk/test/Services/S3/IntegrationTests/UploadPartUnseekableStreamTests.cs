using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class UploadPartUnseekableStreamTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _keyPrefix;

        public UploadPartUnseekableStreamTests(S3BucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
            _keyPrefix = $"unseekable-stream-partupload-{Guid.NewGuid():N}/";
        }

        [Theory]
        // Forward-only stream (no Length): PartSize must equal the exact byte count.
        [InlineData(true, true, null, false, true)]
        [InlineData(true, false, null, false, true)]
        [InlineData(false, true, null, false, true)]
        [InlineData(false, false, null, false, true)]
        [InlineData(false, true, "OBhNnw==", false, true)]
        [InlineData(false, false, "OBhNnw==", false, true)]
        // Non-seekable stream that still reports Length: a nominal PartSize larger
        // than the data should be capped to the stream's actual length (short last part).
        [InlineData(true, true, null, true, true)]
        [InlineData(false, false, null, true, true)]
        [InlineData(false, false, "OBhNnw==", true, true)]
        // Non-seekable stream that reports Length with no PartSize: the reported length is used.
        [InlineData(false, false, null, true, false)]
        public async Task UploadPartWithUnseekableStream(bool disableDefaultChecksumValidation, bool useChunkEncoding, string checksumCRC32, bool streamReportsLength, bool setPartSize)
        {
            var data = Encoding.UTF8.GetBytes("Hello, S3!");
            var stream = new NonSeekableStream(data, streamReportsLength);

            // When a PartSize is set on a length-reporting stream, make it oversized to verify
            // it is capped to the actual length; a forward-only stream needs the exact size.
            long? partSize = setPartSize ? (streamReportsLength ? data.Length + 100 : data.Length) : (long?)null;
            var key = _keyPrefix + $"checksum-{Guid.NewGuid():N}.txt";

            var initiateResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            try
            {
                var uploadPartResponse = await _client.UploadPartAsync(new UploadPartRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initiateResponse.UploadId,
                    PartNumber = 1,
                    PartSize = partSize,
                    InputStream = stream,
                    DisablePayloadSigning = true,
                    DisableDefaultChecksumValidation = disableDefaultChecksumValidation,
                    UseChunkEncoding = useChunkEncoding,
                    ChecksumCRC32 = checksumCRC32,
                    IsLastPart = true,
                });

                var completeRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initiateResponse.UploadId
                };
                completeRequest.AddPartETags(uploadPartResponse);

                await _client.CompleteMultipartUploadAsync(completeRequest);
            }
            catch
            {
                await _client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initiateResponse.UploadId
                });
                throw;
            }

            using (var getResponse = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            }))
            using (var reader = new StreamReader(getResponse.ResponseStream))
            {
                var content = reader.ReadToEnd();
                Assert.Equal("Hello, S3!", content);
            }
        }

        [Fact]
        public async Task UploadPartWithUnseekableStreamAndPayloadSigningThrows()
        {
            var data = Encoding.UTF8.GetBytes("Hello, S3!");
            var stream = new NonSeekableStream(data, reportsLength: false);
            var key = _keyPrefix + "should-fail.txt";

            var initiateResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            try
            {
                await Assert.ThrowsAnyAsync<InvalidOperationException>(async () =>
                {
                    await _client.UploadPartAsync(new UploadPartRequest
                    {
                        BucketName = _bucketName,
                        Key = key,
                        UploadId = initiateResponse.UploadId,
                        PartNumber = 1,
                        PartSize = data.Length,
                        InputStream = stream,
                        DisablePayloadSigning = false,
                    });
                });
            }
            finally
            {
                await _client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initiateResponse.UploadId
                });
            }
        }

        [Fact]
        public async Task UploadPartWithUnseekableStreamAndNoPartSizeThrows()
        {
            var data = Encoding.UTF8.GetBytes("Hello, S3!");
            var stream = new NonSeekableStream(data, reportsLength: false);
            var key = _keyPrefix + "no-partsize.txt";

            var initiateResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            try
            {
                await Assert.ThrowsAsync<AmazonS3Exception>(async () =>
                {
                    await _client.UploadPartAsync(new UploadPartRequest
                    {
                        BucketName = _bucketName,
                        Key = key,
                        UploadId = initiateResponse.UploadId,
                        PartNumber = 1,
                        InputStream = stream,
                        DisablePayloadSigning = true,
                        // PartSize intentionally not set
                    });
                });
            }
            finally
            {
                await _client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initiateResponse.UploadId
                });
            }
        }

    }
}
