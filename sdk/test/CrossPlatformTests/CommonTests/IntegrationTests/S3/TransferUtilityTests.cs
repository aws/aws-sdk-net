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
    public class TransferUtilityTest : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);

        private Random random = new Random();
        private static string bucketName;
        private const string testContent = "This is the content body!";
        private const string testFile = "PutObjectFile.txt";
        private string fullPath;

        [OneTimeSetUp]
        public void Initialize()
        {
            RunAsSync(async () =>
            {
                try
                {
                    IFile file = await this.BaseFolder.CreateFileAsync
                        (testFile, CreationCollisionOption.ReplaceExisting);
                    await file.WriteAllTextAsync(testContent);
                    fullPath = file.Path;
                    bucketName = await UtilityMethods.CreateBucketAsync(Client);
                }
                catch(Exception e)
                {
                    Console.WriteError("Error with init: {0}", e.ToString());
                }
            });
        }

        [OneTimeTearDown]
        public void ClassCleanup()
        {
            RunAsSync(async () =>
                await UtilityMethods.DeleteBucketWithObjectsAsync(Client, bucketName));
            this.Dispose();
        }        

        [Test(TestOf = typeof(AmazonS3Client))]
        public void SimpleUpload()
        {
            RunAsSync(async () =>
            {
                var fileExists = await this.BaseFolder.CheckExistsAsync(fullPath);
                Console.WriteLine("File {0} exists = {1}", fullPath, fileExists);

                using(var tu = new Amazon.S3.Transfer.TransferUtility(Client))
                {
                    await tu.UploadAsync(fullPath, bucketName);
                }

                var response = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = testFile
                });

                Console.WriteLine("S3 generated ETag: {0}", response.ETag);
                Assert.IsTrue(response.ETag.Length > 0);
            });
        }
    }
}
