using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;

using Amazon;

using Amazon.S3;
using Amazon.S3.Model;

using Xunit;
using Amazon.Runtime;

namespace Amazon.DNXCore.IntegrationTests.S3
{
    public class S3ServiceClientTests : TestBase<AmazonS3Client>
    {
        private string bucketName;

        public S3ServiceClientTests()
        {
            bucketName = UtilityMethods.CreateBucketAsync(Client, "s3serviceclienttest").Result;
        }

        protected override void Dispose(bool disposing)
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName).Wait();
            base.Dispose(disposing);
        }

        [Fact]
        public async Task TestS3PutWithBodyProperty()
        {
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = "Hello World",
                Key = "test.txt"
            };
            var putObjectResponse = await Client.PutObjectAsync(putObjectRequest);

            var getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = "test.txt",
                EtagToMatch = putObjectResponse.ETag
            };
            using (var getObjectResponse = await Client.GetObjectAsync(getObjectRequest))
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var content = reader.ReadToEnd();
                Assert.Equal(putObjectRequest.ContentBody, content);
            }
        }

#if NET8_0_OR_GREATER
        [Fact]
        public async Task TestDisableCanonicalization()
        {
            string key = $"/path/../{Guid.NewGuid().ToString()}.txt";

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                ContentBody = "Hello World",
                Key = key
            };
            var putObjectResponse = await Client.PutObjectAsync(putObjectRequest);

            var getObjectRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };
            using (var getObjectResponse = await Client.GetObjectAsync(getObjectRequest))
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var content = reader.ReadToEnd();
                Assert.Equal(putObjectRequest.ContentBody, content);
            }

            var presignedUrlRequest = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = key,
                Verb = HttpVerb.GET,
                Expires = DateTime.UtcNow.AddDays(1)
            };

            var presignedUrl = Client.GetPreSignedURL(presignedUrlRequest);
            using var httpClient = new HttpClient();
            var uri = new Uri(presignedUrl, new UriCreationOptions { DangerousDisablePathAndQueryCanonicalization = true });
            var presignedData = await httpClient.GetStringAsync(uri);
            Assert.Equal(putObjectRequest.ContentBody, presignedData);

            var deleteRequest = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key
            };
            await Client.DeleteObjectAsync(deleteRequest);
        }
#endif
    }
}
