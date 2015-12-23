using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Amazon.S3;
using PCLStorage;
using CommonTests.Framework;
using Amazon.S3.Model;
using System.Net;
using System.Threading;
using System.IO;

namespace CommonTests.IntegrationTests.S3
{
    /// <summary>
    /// Summary description for PutObjectTest
    /// </summary>
    [TestFixture]
    public class PutObjectTest : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private Random random = new Random();
        private static string bucketName;
        private const string testContent = "This is the content body!";
        private string fullPath = string.Empty;
        private string relativePath = string.Empty;

        [OneTimeSetUp]
        public void Initialize()
        {
            Console.WriteLine("Initializing PutObjectTest");
            RunAsSync(async () =>
            {
                IFile file = await this.BaseFolder.CreateFileAsync
                    ("PutObjectFile.txt", CreationCollisionOption.ReplaceExisting);
                await file.WriteAllTextAsync("This is some sample text.!!");
                bucketName = await UtilityMethods.CreateBucketAsync(Client);
                fullPath = file.Path;
                relativePath = UtilityMethods.GetRelativePath(fullPath);
            });
            Console.WriteLine("Done initializing PutObjectTest");
        }

        [OneTimeTearDown]
        public void ClassCleanup()
        {
            Console.WriteLine("Cleaning up PutObjectTest");
            RunAsSync(async () =>
            {
                try
                {
                    await UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName);
                }
                catch(Exception e)
                {
                    Console.WriteError("Exception while trying to delete bucket {0}: {1}", bucketName, e);
                }
            });
            //this.Dispose();
            Console.WriteLine("Done cleaning up PutObjectTest");
        }        

        // This test may fail on Silverlight, due to HTTP caching
        //[Test]
        [Category("S3")]
        public void SimpleTest()
        {
            RunAsSync(async () =>
            {
                var versioning = await Client.GetBucketVersioningAsync(bucketName);
                var status = versioning.VersioningConfig.Status;
                Assert.AreEqual(VersionStatus.Off, status);

                var response = await Client.ListObjectsAsync(bucketName);
                var objects = response.S3Objects;
                Assert.IsNotNull(objects);
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
                Assert.IsNotNull(etag);

                response = await Client.ListObjectsAsync(bucketName);
                objects = response.S3Objects;
                Assert.IsNotNull(objects);
                Assert.AreEqual(count + 1, objects.Count);

                var metadataResult = await Client.GetObjectMetadataAsync(bucketName, key);
                Assert.AreEqual(etag, metadataResult.ETag);

                await Client.DeleteObjectAsync(bucketName, key);

                objects = (await Client.ListObjectsAsync(bucketName)).S3Objects;
                Assert.IsNotNull(objects);
                Assert.AreEqual(count, objects.Count);
            });
        }

        [Test]
        [Category("S3")]
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

                    Assert.IsTrue(exception.Message.Contains("The specified bucket does not exist"));
                    Assert.AreEqual("NoSuchBucket", exception.ErrorCode);
                    Assert.AreEqual(HttpStatusCode.NotFound, exception.StatusCode);
                }
            });
        }

        [Test]
        [Category("S3")]
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
                Assert.IsTrue(response.ETag.Length > 0);
            });
        }

        [Test]
        [Category("S3")]
        public void SimplePathPutObjectTest()
        {
            RunAsSync(async () =>
            {
                PutObjectRequest request = new PutObjectRequest()
                {
                    BucketName = bucketName,
                    FilePath = relativePath,
                    CannedACL = S3CannedACL.AuthenticatedRead
                };
                PutObjectResponse response = await Client.PutObjectAsync(request);

                Console.WriteLine("S3 generated ETag: {0}", response.ETag);
                Assert.IsTrue(response.ETag.Length > 0);
            });
        }
    }
}
