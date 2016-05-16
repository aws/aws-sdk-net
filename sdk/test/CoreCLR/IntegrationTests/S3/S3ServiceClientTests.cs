using System;
using System.Collections.Generic;
using System.IO;
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
        [Fact]

        public async Task TestS3PutWithBodyProperty()
        {
            var bucketName = "aws-sdk-net-TestS3PutWithBodyProperty-" + DateTime.Now.Ticks;
            await Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName });

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

            await Client.DeleteObjectAsync(new DeleteObjectRequest { BucketName = bucketName, Key = "test.txt" });
            await Client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = bucketName });

        }
    }
}
