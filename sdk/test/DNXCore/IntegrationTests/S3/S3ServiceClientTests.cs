using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Amazon;

using Amazon.S3;
using Amazon.S3.Model;

using Xunit;


namespace Amazon.DNXCore.IntegrationTests.S3
{
    public class S3ServiceClientTests
    {
        [Fact]
        public async Task TestS3PutWithBodyProperty()
        {
            using (var s3Client = new AmazonS3Client(RegionEndpoint.USEast1))
            {
                var bucketName = "aws-sdk-net-" + DateTime.Now.Ticks;
                await s3Client.PutBucketAsync(new PutBucketRequest { BucketName = bucketName });

                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    ContentBody = "Hello World",
                    Key = "test.txt"
                };
                var putObjectResponse = await s3Client.PutObjectAsync(putObjectRequest);

                var getObjectRequest = new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = "test.txt",
                    EtagToMatch = putObjectResponse.ETag
                };
                using (var getObjectResponse = await s3Client.GetObjectAsync(getObjectRequest))
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.Equal(putObjectRequest.ContentBody, content);
                }

                await s3Client.DeleteObjectAsync(new DeleteObjectRequest { BucketName = bucketName, Key = "test.txt" });
                await s3Client.DeleteBucketAsync(new DeleteBucketRequest { BucketName = bucketName });                
            }
        }
    }
}
