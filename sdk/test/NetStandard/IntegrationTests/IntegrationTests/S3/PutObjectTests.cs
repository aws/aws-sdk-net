using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>

    public class PutObjectTest : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private Random random = new Random();
        private string bucketName;
        private const string testContent = "This is the content body!";
        private string filePath = string.Empty;
        private const string testKey = "test-key.json.gz";

        public PutObjectTest()
        {
            filePath = Path.Combine(Path.GetTempPath(), "PutObjectFile.txt");
            File.WriteAllText(filePath, "This is some sample text.!!");
            bucketName = UtilityMethods.CreateBucketAsync(Client, "PutObjectTest", true).Result;
        }

        protected override void Dispose(bool disposing)
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName).Wait();

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            base.Dispose(disposing);
        }

        // This test may fail on Silverlight, due to HTTP caching
        [Fact]
        public async Task SimpleTest()
        {
            var versioning = await Client.GetBucketVersioningAsync(bucketName);
            var status = versioning.VersioningConfig.Status;
            Assert.Equal(VersionStatus.Off, status);

            var objects = (await Client.ListObjectsAsync(bucketName)).S3Objects;
            var count = objects == null ? 0 : objects.Count;

            var key = "test.txt";
            var contents = "Sample content";
            var putResult = await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = contents
            });
            var etag = putResult.ETag;
            Assert.NotNull(etag);

            objects = (await Client.ListObjectsAsync(bucketName)).S3Objects;
            Assert.NotNull(objects);
            Assert.Equal(count + 1, objects.Count);

            var metadataResult = await Client.GetObjectMetadataAsync(bucketName, key);
            Assert.Equal(etag, metadataResult.ETag);

            await Client.DeleteObjectAsync(bucketName, key);

            objects = (await Client.ListObjectsAsync(bucketName)).S3Objects;
            Assert.Equal(count, objects == null ? 0 : objects.Count);
        }

        [Fact]
        public async Task TestHttpErrorResponseUnmarshalling()
        {
            await Assert.ThrowsAsync<AmazonS3Exception>(() =>
                Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = UtilityMethods.GenerateName("NonExistentBucket"),
                    Key = "1",
                    ContentBody = "TestContent"
                })
            );
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task SimplePutObjectTest(bool useChunkEncoding)
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = "contentBodyPut" + random.Next(),
                ContentBody = testContent,
                CannedACL = S3CannedACL.AuthenticatedRead,
                UseChunkEncoding = useChunkEncoding
            };
            PutObjectResponse response = await Client.PutObjectAsync(request);

            Console.WriteLine("S3 generated ETag: {0}", response.ETag);
            Assert.True(response.ETag.Length > 0);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task SimplePathPutObjectTest(bool useChunkEncoding)
        {
            PutObjectRequest request = new PutObjectRequest()
            {
                BucketName = bucketName,
                FilePath = filePath,
                CannedACL = S3CannedACL.AuthenticatedRead,
                UseChunkEncoding = useChunkEncoding
            };
            PutObjectResponse response = await Client.PutObjectAsync(request);

            Console.WriteLine("S3 generated ETag: {0}", response.ETag);
            Assert.True(response.ETag.Length > 0);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task GzipTest(bool useChunkEncoding)
        {
            var request = CreatePutObjectRequest();
            request.UseChunkEncoding = useChunkEncoding;
            request.Headers.ContentEncoding = "gzip";

            await TestPutAndGet(request);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task PutObjectWithContentEncoding(bool useChunkEncoding)
        {
            var request = CreatePutObjectRequest();
            request.UseChunkEncoding = useChunkEncoding;
            request.Headers.ContentEncoding = "gzip";
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.Equal("disposition", headers.ContentDisposition);
            Assert.Equal("gzip", headers.ContentEncoding);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task PutObjectWithContentEncodingIdentity(bool useChunkEncoding)
        {
            var request = CreatePutObjectRequest();
            request.UseChunkEncoding = useChunkEncoding;
            request.Headers.ContentEncoding = "identity";
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.Equal("disposition", headers.ContentDisposition);
            Assert.Equal("identity", headers.ContentEncoding);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task PutObjectWithoutContentEncoding(bool useChunkEncoding)
        {
            var request = CreatePutObjectRequest();
            request.UseChunkEncoding = useChunkEncoding;
            request.Headers.ContentDisposition = "disposition";

            var headers = await TestPutAndGet(request);
            Assert.Equal("disposition", headers.ContentDisposition);
            Assert.DoesNotContain("Content-Encoding", headers.Keys, StringComparer.OrdinalIgnoreCase);
            Assert.Null(headers.ContentEncoding);
        }

        /// <summary>
        /// Reported in https://github.com/aws/aws-sdk-net/issues/3941
        /// </summary>
        [Fact]
        public async Task HandlesFileStreamWithoutAutoReset()
        {
            var tempFilePath = Path.GetTempFileName();
            try
            {
                using (var writeFs = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
                {
                    var data = new byte[]
                    {
                        0x01, 0x00, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x01, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                        0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                    };

                    await writeFs.WriteAsync(data, 0, data.Length);
                }

                using var fileStream = File.Open(tempFilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                using var reader = new BinaryReader(fileStream);

                fileStream.Position = 10;
                var compression = reader.ReadInt16();
                
                fileStream.Seek(8, SeekOrigin.Current);
                var bIsLast = reader.ReadBoolean();
                
                fileStream.Seek(4, SeekOrigin.Current);

                var putRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = "upload-test/0D-0",
                    ContentType = "application/octet-stream",
                    InputStream = fileStream,
                    AutoResetStreamPosition = false,
                };
                putRequest.Metadata.Add("compression", compression.ToString());
                putRequest.Metadata.Add("islast", bIsLast ? "T" : "F");

                var putResponse = await Client.PutObjectAsync(putRequest);
                Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);

                var getResponse = await Client.GetObjectMetadataAsync(bucketName, putRequest.Key);
                Assert.Equal(HttpStatusCode.OK, getResponse.HttpStatusCode);
                Assert.NotNull(getResponse.Metadata);
                Assert.True(getResponse.Metadata.Count > 0);
            }
            finally
            {
                if (File.Exists(tempFilePath))
                {
                    File.Delete(tempFilePath);
                }
            }
        }

        /// <summary>
        /// Reported in https://github.com/aws/aws-sdk-net/issues/3629
        /// </summary>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public async Task TestResetStreamPosition(bool useChunkEncoding)
        {
            var memoryStream = new MemoryStream();
            long offset;

            using (var writer = new StreamWriter(memoryStream, Encoding.UTF8, 1024, leaveOpen: true))
            {
                writer.AutoFlush = true;
                await writer.WriteAsync("Hello");
                offset = memoryStream.Position;
                await writer.WriteAsync("World");
                await writer.FlushAsync();
            }

            memoryStream.Seek(offset, SeekOrigin.Begin);

            var putRequest = new PutObjectRequest
            {
                CannedACL = S3CannedACL.NoACL,
                BucketName = bucketName,
                Key = "test-file.txt",
                AutoResetStreamPosition = false,
                AutoCloseStream = !memoryStream.CanSeek,
                InputStream = memoryStream.CanSeek ? memoryStream : AmazonS3Util.MakeStreamSeekable(memoryStream),
                UseChunkEncoding = useChunkEncoding,
            };

            var putResponse = await Client.PutObjectAsync(putRequest);
            Assert.True(putResponse.HttpStatusCode == HttpStatusCode.OK);

            var getResponse = await Client.GetObjectAsync(bucketName, "test-file.txt");
            using (var reader = new StreamReader(getResponse.ResponseStream))
            {
                var content = await reader.ReadToEndAsync();
                Assert.Equal("World", content);
            }
        }

        [Theory]
        [InlineData(true, true, true, false)]
        [InlineData(true, true, false, true)]
        [InlineData(true, false, true, true)]
        [InlineData(true, false, false, true)]
        [InlineData(false, true, true, false)]
        [InlineData(false, true, false, true)]
        [InlineData(false, false, true, false)]
        [InlineData(false, false, false, false)]
        public async Task PutObjectAddsAwsChunkedWhenNeeded(
            bool useChunkedEncoding, 
            bool disablePayloadSigning,
            bool disableDefaultChecksumValidation,
            bool isContentEncodingHeaderExpected
        )
        {
            // S3 stores the resulting object without the aws-chunked value in the content-encoding header,
            // so we'll use a custom HTTP client to actually inspect the headers before the request is sent.
            var customHttpClientFactory = new CustomHttpClientFactory
            {
                ShouldHaveContentEncoding = isContentEncodingHeaderExpected,
            };

            var customClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = Client.Config.RegionEndpoint,
                HttpClientFactory = customHttpClientFactory,
            });

            var putRequest = CreatePutObjectRequest();
            putRequest.UseChunkEncoding = useChunkedEncoding;
            putRequest.DisablePayloadSigning = disablePayloadSigning;
            putRequest.DisableDefaultChecksumValidation = disableDefaultChecksumValidation;

            // If the request succeeded, we can assume S3 handled the Content-Encoding correctly.
            // There are other tests in this class that verify custom values set by customers are returned
            // on future GetObject calls.
            var putResponse = await customClient.PutObjectAsync(putRequest);
            Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);
        }

        private async Task<HeadersCollection> TestPutAndGet(PutObjectRequest request)
        {
            await Client.PutObjectAsync(request);

            var key = request.Key;

            using (var response = await Client.GetObjectAsync(bucketName, key))
            using (var reader = new StreamReader(response.ResponseStream))
            {
                var contents = reader.ReadToEnd();
                Assert.Equal(testContent, contents);
            }
            using (var response = await Client.GetObjectAsync(bucketName, key))
            {
                await response.WriteResponseStreamToFileAsync(key, false, CancellationToken.None);

                var contents = File.ReadAllText(key);
                Assert.Equal(testContent, contents);
            }

            var metadata = await Client.GetObjectMetadataAsync(bucketName, key);
            return metadata.Headers;
        }
        private PutObjectRequest CreatePutObjectRequest()
        {
            var request = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = DateTime.UtcNow.ToFileTime() + testKey,
                ContentBody = testContent
            };
            return request;
        }

        private class CustomHttpClientFactory : HttpClientFactory
        {
            public bool ShouldHaveContentEncoding { get; set; }

            public override HttpClient CreateHttpClient(IClientConfig clientConfig)
            {
                var handler = new InspectingHandler(new HttpClientHandler())
                {
                    ShouldHaveContentEncoding = ShouldHaveContentEncoding,
                };

                return new HttpClient(handler);
            }
        }

        private class InspectingHandler : DelegatingHandler
        {
            public bool ShouldHaveContentEncoding { get; set; }

            public InspectingHandler(HttpMessageHandler innerHandler) : base(innerHandler) { }

            protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                // Regardless of whether chunked encoding was used, the SDK will always set Content-Length.
                Assert.True(request.Content?.Headers.ContentLength.HasValue);

                // Content-Length and Transfer-Encoding are mutually exclusive, so also check the SDK is not
                // setting both headers as that would cause S3 to throw an error.
                Assert.False(request.Headers.TransferEncodingChunked.GetValueOrDefault());

                if (ShouldHaveContentEncoding)
                {
                    Assert.True(request.Content?.Headers.ContentEncoding.Contains("aws-chunked"));
                    Assert.True(request.Headers.Contains("x-amz-decoded-content-length"));
                }
                else
                {
                    Assert.False(request.Content?.Headers.ContentEncoding.Contains("aws-chunked"));
                    Assert.False(request.Headers.Contains("x-amz-decoded-content-length"));
                }

                return base.SendAsync(request, cancellationToken);
            }
        }
    }
}
