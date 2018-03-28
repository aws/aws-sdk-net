using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Amazon.S3;

using Amazon.DNXCore.IntegrationTests;
using Amazon.S3.Model;
using System.Net;
using System.Threading;
using System.IO;

namespace Amazon.DNXCore.IntegrationTests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    
    public class PutObjectTest : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private Random random = new Random();
        private static string bucketName;
        private const string testContent = "This is the content body!";
        private string filePath = string.Empty;
        private const string testKey = "test-key.json.gz";

        public PutObjectTest()
        {
            filePath = Path.Combine(Path.GetTempPath(), "PutObjectFile.txt");
            File.WriteAllText(filePath, "This is some sample text.!!");
            bucketName = UtilityMethods.CreateBucketAsync(Client, "PutObjectTest").Result;
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
            Assert.NotNull(objects);
            var count = objects.Count;

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
            Assert.NotNull(objects);
            Assert.Equal(count, objects.Count);
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
            Assert.False(headers.Keys.Contains("Content-Encoding", StringComparer.OrdinalIgnoreCase));
            Assert.Null(headers.ContentEncoding);
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
                Key = DateTime.Now.ToFileTime() + testKey,
                ContentBody = testContent
            };
            return request;
        }
    }
}
