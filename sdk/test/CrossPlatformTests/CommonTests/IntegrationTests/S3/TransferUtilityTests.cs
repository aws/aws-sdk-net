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
                    var folder = PCLStorage.FileSystem.Current.GetFileFromPathAsync(fullPath).Result;
                    Console.WriteLine($"{folder.Path}");

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
        public void SimpleUploadWithFilepath()
        {
            RunAsSync(async () =>
            {
                var client = Client;
                using (var tu = new Amazon.S3.Transfer.TransferUtility(client))
                {
                    await tu.UploadAsync(fullPath, bucketName);
                    await VerifyUploadResponse(client);
                    await TestDownloadedFile(fullPath, tu);
                }
            });
        }

        [Test(TestOf = typeof(AmazonS3Client))]
        [Category("S3")]
        public void SimpleUploadWithFilepathAndKey()
        {
            
            RunAsSync(async () =>
            {
                try
                {
                    var client = Client;
                    using (var tu = new Amazon.S3.Transfer.TransferUtility(client))
                    {
                        string key = System.Guid.NewGuid().ToString();
                        await tu.UploadAsync(fullPath, bucketName, key);
                        await VerifyUploadResponse(client, key);
                        await TestDownloadedFile(fullPath, tu, key);
                    }
                }
                catch(Exception e)
                {
                    throw e; 
                }

            });
        }

        [Test(TestOf = typeof(AmazonS3Client))]
        [Category("S3")]
        public void SimpleUploadWithStream()
        {
            RunAsSync(async () =>
            {
                try
                {
                    var client = Client;                    
                    using (var tu = new Amazon.S3.Transfer.TransferUtility(client))
                    {
                        Stream filestream = this.BaseFolder.GetFileAsync(fullPath).Result.OpenAsync(FileAccess.Read).Result ;
                        string key = System.Guid.NewGuid().ToString();
                        await tu.UploadAsync(fullPath, bucketName, key);
                        await VerifyUploadResponse(client, key);
                        await TestDownloadedFile(fullPath, tu, key);
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            });
        }

        [Test(TestOf = typeof(AmazonS3Client))]
        [Category("S3")]
        public void SimpleUploadWithRequest()
        {
            RunAsSync(async () =>
            {
                try
                {
                    var client = Client;
                    using (var tu = new Amazon.S3.Transfer.TransferUtility(client))
                    {
                        string key = System.Guid.NewGuid().ToString();

                        Amazon.S3.Transfer.TransferUtilityUploadRequest request = new Amazon.S3.Transfer.TransferUtilityUploadRequest
                        {
                            BucketName = bucketName,
                            FilePath = fullPath,
                            StorageClass = S3StorageClass.ReducedRedundancy,
                            PartSize = 6291456, // 6 MB.
                            Key = key,
                            CannedACL = S3CannedACL.PublicRead
                        };
                        Stream filestream = this.BaseFolder.GetFileAsync(fullPath).Result.OpenAsync(FileAccess.Read).Result;
                        await tu.UploadAsync(fullPath, bucketName, key);
                        await VerifyUploadResponse(client, key);
                        await TestDownloadedFile(fullPath, tu, key);
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            });
        }

        private async Task VerifyUploadResponse(AmazonS3Client client, string key = null)
        {
            if (key == null)
            {
                key = testFile;
            }
            var response = await client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });
            Assert.IsTrue(response.ETag.Length > 0);
        }

        private async Task TestDownloadedFile(string fullPath, Amazon.S3.Transfer.TransferUtility tu, string key = null)
        {
            if (key == null)
            {
                key = testFile;
            }
            var downloadPath = fullPath + ".download";
            var downloadRequest = new Amazon.S3.Transfer.TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = downloadPath
            };
            var fileExists = await this.BaseFolder.CheckExistsAsync(downloadPath);
            if(fileExists == ExistenceCheckResult.FileExists)
            {
                this.BaseFolder.GetFileAsync(downloadPath).Result.DeleteAsync().Wait();
            }

            fileExists = await this.BaseFolder.CheckExistsAsync(downloadPath);
            Assert.IsTrue(fileExists == ExistenceCheckResult.NotFound);
            await tu.DownloadAsync(downloadRequest);
            await VerifyDownloadedFile(downloadPath);

            // empty out file, except for 1 byte
            var file = await this.BaseFolder.GetFileAsync(downloadPath);
            await file.WriteAllTextAsync(testContent.Substring(0, 1));
            await tu.DownloadAsync(downloadRequest);
            await VerifyDownloadedFile(downloadPath);
        }
        private async Task VerifyDownloadedFile(string downloadPath)
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
