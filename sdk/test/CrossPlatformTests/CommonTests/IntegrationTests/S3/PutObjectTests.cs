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
        private string filePath = string.Empty;

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
                filePath = file.Path;
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

        [Test]
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
                Assert.IsTrue(response.ETag.Length > 0);
            });
        }
    }

    //public class NonRewindableStream : MemoryStream
    //{
    //    public override bool CanSeek
    //    {
    //        get
    //        {
    //            return false;
    //        }
    //    }
    //}
}
