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

        public PutObjectTest()
        {
            Console.WriteLine("Initializing PutObjectTest");


            filePath = Path.Combine(BaseDirectoryPath, "PutObjectFile.txt");
            File.WriteAllText(filePath,
                "This is some sample text.!!");
            bucketName = UtilityMethods.CreateBucketAsync(Client, "PutObjectTest").Result;

            //RunAsSync(async () =>
            //{
            //    IFile file = await this.BaseFolder.CreateFileAsync
            //        ("PutObjectFile.txt", CreationCollisionOption.ReplaceExisting);
            //    await file.WriteAllTextAsync("This is some sample text.!!");
            //    bucketName = await UtilityMethods.CreateBucketAsync(Client);
            //    filePath = file.Path;
            //});
            Console.WriteLine("Done initializing PutObjectTest");
        }
        
        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("Cleaning up PutObjectTest");
            RunAsSync(async () =>
            {
                try
                {
                    await UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception while trying to delete bucket {0}: {1}", bucketName, e);
                }
            });
            //this.Dispose();
            Console.WriteLine("Done cleaning up PutObjectTest");
            base.Dispose(disposing);
        }

        // This test may fail on Silverlight, due to HTTP caching
        [Fact]
        public void SimpleTest()
        {
            RunAsSync(async () =>
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
            });
        }

        [Fact]
        public void TestHttpErrorResponseUnmarshalling()
        {
            RunAsSync(async () =>
            {
                try
                {
                    await Client.PutObjectAsync(new PutObjectRequest
                    {
                        BucketName = UtilityMethods.GenerateName("NonExistentBucket"),
                        Key = "1",
                        ContentBody = "TestContent"
                    });
                }
                catch (AmazonS3Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine(exception.ErrorCode);
                    Console.WriteLine(exception.StatusCode);

                    Assert.True(exception.Message.Contains("The specified bucket does not exist"));
                    Assert.Equal("NoSuchBucket", exception.ErrorCode);
                    Assert.Equal(HttpStatusCode.NotFound, exception.StatusCode);
                }
            });
        }

        [Fact]
        public void SimplePutObjectTest()
        {
            RunAsSync(async () =>
            {
                PutObjectRequest request = new PutObjectRequest()
                {
                    BucketName = bucketName,
                    Key = "contentBodyPut" + random.Next(),
                    ContentBody = testContent,
                    CannedACL = S3CannedACL.AuthenticatedRead
                };
                PutObjectResponse response = await Client.PutObjectAsync(request);

                Console.WriteLine("S3 generated ETag: {0}", response.ETag);
                Assert.True(response.ETag.Length > 0);
            });
        }

        [Fact]
        public void SimplePathPutObjectTest()
        {
            RunAsSync(async () =>
            {
                PutObjectRequest request = new PutObjectRequest()
                {
                    BucketName = bucketName,
                    FilePath = filePath,
                    CannedACL = S3CannedACL.AuthenticatedRead
                };
                PutObjectResponse response = await Client.PutObjectAsync(request);

                Console.WriteLine("S3 generated ETag: {0}", response.ETag);
                Assert.True(response.ETag.Length > 0);
            });
        }
    }
}
