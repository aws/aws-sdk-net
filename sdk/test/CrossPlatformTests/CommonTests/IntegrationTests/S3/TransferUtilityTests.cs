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
        private string relativePath;

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
                    relativePath = UtilityMethods.GetRelativePath(fullPath);
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
        [Category("S3")]
        public void SimpleUpload()
        {
            RunAsSync(async () =>
            {
                var client = Client;
                using (var tu = new Amazon.S3.Transfer.TransferUtility(client))
                {
                    await tu.UploadAsync(relativePath, bucketName);

                    var response = await client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                    {
                        BucketName = bucketName,
                        Key = testFile
                    });
                    Assert.IsTrue(response.ETag.Length > 0);

                    var downloadPath = relativePath + ".download";
                    var downloadRequest = new Amazon.S3.Transfer.TransferUtilityDownloadRequest
                    {
                        BucketName = bucketName,
                        Key = testFile,
                        FilePath = downloadPath
                    };
                    var fileExists = await this.BaseFolder.CheckExistsAsync(downloadPath);
                    Assert.IsTrue(fileExists == ExistenceCheckResult.NotFound);
                    await tu.DownloadAsync(downloadRequest);
                    await TestDownloadedFile(downloadPath);

                    // empty out file, except for 1 byte
                    var file = await this.BaseFolder.GetFileAsync(downloadPath);
                    await file.WriteAllTextAsync(testContent.Substring(0, 1));
                    await tu.DownloadAsync(downloadRequest);
                    await TestDownloadedFile(downloadPath);
                }
            });
        }

        private async Task TestDownloadedFile(string downloadPath)
        {
            ExistenceCheckResult fileExists;
            fileExists = await this.BaseFolder.CheckExistsAsync(downloadPath);
            Assert.IsTrue(fileExists == ExistenceCheckResult.FileExists);
            var file = await this.BaseFolder.GetFileAsync(downloadPath);
            Assert.IsNotNull(file);
            var fileContent = await file.ReadAllTextAsync();
            Assert.AreEqual(testContent, fileContent);
        }
    }
}
