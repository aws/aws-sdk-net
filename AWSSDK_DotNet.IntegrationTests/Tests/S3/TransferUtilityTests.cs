using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class TransferUtilityTests : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);
        public static readonly long KILO_SIZE = (int)Math.Pow(2, 10);

        private static string basePath = @"c:\temp\test\transferutility\";
        private static string bucketName;
        private static string octetStreamContentType = "application/octet-stream";


        [ClassInitialize()]
        public static void ClassInitialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucket(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
            Directory.Delete(basePath, true);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void SimpleUploadTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\SmallFile");
            Upload(fileName, 10 * MEG_SIZE, null);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void SimpleUploadProgressTest()
        {
            var context = SynchronizationContext.Current;
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\SmallFile");
            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.AreEqual(p.FilePath, Path.Combine(basePath, fileName));
                }
            };
            Upload(fileName, 10 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }


        [TestMethod]
        [TestCategory("S3")]
        public void MultipartUploadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\File");
            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                ValidateProgressInterval = false,
                Validate = (p) =>
                {
                    Assert.AreEqual(p.FilePath, Path.Combine(basePath, fileName));
                }
            };
            Upload(fileName, 20 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        void Upload(string fileName, long size, 
            TransferProgressValidator<UploadProgressArgs> progressValidator, AmazonS3Client client = null)
        {
            var key = fileName;
            Client.DeleteObject(new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key
            });

            var path = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(path, size);
            var config = new TransferUtilityConfig
            {
                //ConcurrentServiceRequests = 1,
                //MinSizeBeforePartUpload = MEG_SIZE
            };
            var transferUtility = client != null ? new TransferUtility(client, config)
                : new TransferUtility(Client, config);
            var request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = path,
                Key = key,
                ContentType = octetStreamContentType
            };

            if (progressValidator != null)
            {
                request.UploadProgressEvent += progressValidator.OnProgressEvent;
            }

            transferUtility.Upload(request);

            var metadata = Client.GetObjectMetadata(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });
            Console.WriteLine("Expected Size: {0} , Actual Size {1}", size, metadata.ContentLength);
            Assert.AreEqual(octetStreamContentType, metadata.Headers.ContentType);
            Assert.AreEqual(size, metadata.ContentLength);
            ValidateFileContents(bucketName, key, path);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void UploadDirectoryWithProgressTracker()
        {
            var directoryName = UtilityMethods.GenerateName("UploadDirectoryTest");
            var progressValidator = new DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            ConfigureProgressValidator(progressValidator);

            UploadDirectory(directoryName, 10 * MEG_SIZE, progressValidator, true, false);
            progressValidator.AssertOnCompletion();
        }

        void UploadDirectory(string directoryName, long size, 
             DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, bool validate = true, bool concurrent = true)
        {
            var directoryPath = Path.Combine(basePath, directoryName);

            for (int i = 0; i < 5; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                //MultipartUploadTests.UtilityMethods.GenerateFile(filePath, (i % 2 == 0) ? size : size / 2);
                UtilityMethods.GenerateFile(filePath, size);
            }

            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            };
            var transferUtility = new TransferUtility(Client, config);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath,
                KeyPrefix = directoryName,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,                
            };

            //if (concurrent)
            //    request.UploadFilesConcurrently = true;

            if (progressValidator != null)
            {
                request.UploadDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            HashSet<string> files = new HashSet<string>();
            request.UploadDirectoryProgressEvent += (s, e) =>
            {
                files.Add(e.CurrentFile);
                Console.WriteLine("Progress callback = " + e.ToString());
            };

            transferUtility.UploadDirectory(request);

            Assert.AreEqual(5, files.Count);

            if (validate)
                ValidateDirectoryContents(bucketName, directoryName, directoryPath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DownloadDirectoryProgressTest()
        {
            var directoryName = UtilityMethods.GenerateName(@"DownloadDirectoryTest");
            var progressValidator = new DirectoryProgressValidator<DownloadDirectoryProgressArgs>();
            ConfigureProgressValidator(progressValidator);

            DownloadDirectory(directoryName, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        void DownloadDirectory(string directoryName, 
            DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator, bool concurrent = true)
        {
            var directoryPath = Path.Combine(basePath, directoryName);
            UploadDirectory(directoryName,
                20 * MEG_SIZE, null, false);
            Directory.Delete(directoryPath, true);

            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = bucketName,
                LocalDirectory = directoryPath,
                S3Directory = directoryName
            };

            if (progressValidator != null)
                request.DownloadedDirectoryProgressEvent += progressValidator.OnProgressEvent;

            transferUtility.DownloadDirectory(request);
            ValidateDirectoryContents(bucketName, directoryName, directoryPath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DownloadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName(@"DownloadTest\File");
            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.AreEqual(p.BucketName, bucketName);
                    Assert.AreEqual(p.Key, fileName);
                    Assert.IsNotNull(p.FilePath);
                    Assert.IsTrue(p.FilePath.Contains(fileName));
                }
            };
            Download(fileName, 10 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        void Download(string fileName, long size, TransferProgressValidator<WriteObjectProgressArgs> progressValidator)
        {
            var key = fileName;
            var originalFilePath = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, size);

            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = originalFilePath
            });

            var downloadedFilePath = originalFilePath + ".dn";

            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                FilePath = downloadedFilePath,
                Key = key
            };
            if (progressValidator != null)
            {
                request.WriteObjectProgressEvent += progressValidator.OnProgressEvent;
            }
            transferUtility.Download(request);

            UtilityMethods.CompareFiles(originalFilePath, downloadedFilePath);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void OpenStreamTest()
        {
            var fileName = UtilityMethods.GenerateName(@"OpenStreamTest\File");
            var key = fileName;
            var originalFilePath = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, 2 * MEG_SIZE);
            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = originalFilePath
            });

            var transferUtility = new TransferUtility(Client);
            var stream = transferUtility.OpenStream(bucketName, key);
            Assert.IsNotNull(stream);
            Assert.IsTrue(stream.CanRead);
            stream.Close();
        }

#if ASYNC_AWAIT

        [TestMethod]
        [TestCategory("S3")]
        public async System.Threading.Tasks.Task UploadAsyncCancellationTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\CancellationTest");
            var path = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(path, 20 * MEG_SIZE);

            TransferUtilityUploadRequest uploadRequest = new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                Key = fileName,
                FilePath = path
            };

            var tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            System.Threading.Tasks.Task uploadTask = null;
            using (var transferUtility = new TransferUtility(Client))
            {
                try
                {
                    uploadTask = transferUtility.UploadAsync(uploadRequest, token);
                    tokenSource.CancelAfter(100);
                    await uploadTask;
                }
                catch (OperationCanceledException)
                {
                    Assert.IsTrue(uploadTask.IsCanceled);
                    return;
                }
            }
            Assert.Fail("An OperationCanceledException was not thrown.");
        }
#endif

        public static void ConfigureProgressValidator(DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                if (lastProgress != null)
                {
                    Assert.IsTrue(progress.NumberOfFilesDownloaded >= lastProgress.NumberOfFilesDownloaded);
                    Assert.IsTrue(progress.TransferredBytes > lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesDownloaded == lastProgress.NumberOfFilesDownloaded)
                    {
                        Assert.IsTrue(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                }

                if (progress.NumberOfFilesDownloaded == progress.TotalNumberOfFiles)
                {
                    Assert.AreEqual(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.WriteLine(progress.ToString());
            };
        }

        public static void ConfigureProgressValidator(DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                Assert.IsFalse(string.IsNullOrEmpty(progress.CurrentFile));
                Assert.IsTrue(progress.TotalNumberOfBytesForCurrentFile > 0);
                Assert.IsTrue(progress.TransferredBytesForCurrentFile > 0);

                if (lastProgress != null)
                {
                    Assert.IsTrue(progress.NumberOfFilesUploaded >= lastProgress.NumberOfFilesUploaded);
                    Assert.IsTrue(progress.TransferredBytes > lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesUploaded == lastProgress.NumberOfFilesUploaded)
                    {
                        Assert.IsTrue(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                    else
                    {
                        Assert.AreEqual(progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                    }
                }

                if (progress.NumberOfFilesUploaded == progress.TotalNumberOfFiles)
                {
                    Assert.AreEqual(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.Write("\t{0} : {1}/{2}\t", progress.CurrentFile,
                    progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                Console.WriteLine(progress.ToString());
            };
        }

        public static void ValidateFileContents(string bucketName, string key, string path)
        {
            // test assumes we used a known extension and added it to the file key
            var ext = Path.GetExtension(key);
            ValidateFileContents(bucketName, key, path, AmazonS3Util.MimeTypeFromExtension(ext));
        }

        public static void ValidateFileContents(string bucketName, string key, string path, string contentType)
        {
            var downloadPath = path + ".chk";
            for (int retries = 0; retries < 5; retries++)
            {
                try
                {
                    var response = Client.GetObject(new GetObjectRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                    });
                    //Assert.AreEqual(contentType, response.Headers.ContentType);
                    response.WriteResponseStreamToFile(downloadPath);
                    UtilityMethods.CompareFiles(path, downloadPath);
                }
                catch(AmazonS3Exception e)
                {
                    if (e.StatusCode != HttpStatusCode.NotFound || retries == 5)
                        throw;
                }
            }
        }

        public static void ValidateDirectoryContents(string bucketName, string rootDirectoryName, string directoryPath)
        {
            string[] filePaths = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
            foreach (var filePath in filePaths)
            {
                var key = filePath.Substring(directoryPath.LastIndexOf("\\") + 1);
                ValidateFileContents(bucketName, key.Replace("\\", "/"), filePath);
            }
        }

        public abstract class ProgressValidator<T>
        {
            public T LastProgressEventValue { get; set; }

            public bool IsProgressEventComplete { get; set; }

            public Exception ProgressEventException { get; set; }

            public void AssertOnCompletion()
            {
                if (this.ProgressEventException != null)
                    throw this.ProgressEventException;

                // Add some time for the background thread to finish before checking the complete
                for (int retries = 1; retries < 5 && !this.IsProgressEventComplete; retries++)
                {
                    Thread.Sleep(1000 * retries);
                }
                Assert.IsTrue(this.IsProgressEventComplete, "IsProgressEventComplete is false");
            }
        }

        class TransferProgressValidator<T> : ProgressValidator<T> where T : TransferProgressArgs
        {
            //private MethodInfo memberInfo = null;

            public Action<T> Validate { get; set; }

            public bool ValidateProgressInterval { get; set; }

            public TransferProgressValidator()
            {
                this.ValidateProgressInterval = true;
            }

            public void OnProgressEvent(object sender, T progress)
            {
                try
                {
                    Console.WriteLine("Progress Event : {0}%\t{1}/{2}", progress.PercentDone, progress.TransferredBytes, progress.TotalBytes);
                    Assert.IsFalse(progress.PercentDone > 100, "Progress percent done cannot be greater than 100%");
                    if (this.IsProgressEventComplete)
                        Assert.Fail("A progress event was received after completion.");

                    if (progress.TransferredBytes == progress.TotalBytes)
                    {
                        Assert.AreEqual(progress.PercentDone, 100);
                        this.IsProgressEventComplete = true;
                    }

                    if (this.LastProgressEventValue != null)
                    {
                        if (progress.PercentDone < this.LastProgressEventValue.PercentDone)
                            Console.WriteLine("Progress Event : --------------------------");

                        Assert.IsTrue(progress.PercentDone >= this.LastProgressEventValue.PercentDone);
                        Assert.IsTrue(progress.TransferredBytes > this.LastProgressEventValue.TransferredBytes);

                        if (progress.TransferredBytes < progress.TotalBytes)
                        {
                            if (progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes < 100 * KILO_SIZE)
                                Console.WriteLine("Progress Event : *******Part Uploaded********");

                            if (this.ValidateProgressInterval)
                            {
                                // When TransferUtility uploads using multipart upload, the TransferredBytes
                                // will be less than the interval for last chunk of each upload part request.
                                Assert.IsTrue(progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes >= 100 * KILO_SIZE);
                            }
                        }
                    }

                    Validate(progress);
                    this.LastProgressEventValue = progress;
                }
                catch (Exception ex)
                {
                    this.ProgressEventException = ex;
                    Console.WriteLine("Exception caught: {0}", ex.Message);
                    throw;
                }
            }
        }

        public class DirectoryProgressValidator<T> : ProgressValidator<T>
        {
            public Action<T, T> Validate { get; set; }

            public void OnProgressEvent(object sender, T progress)
            {
                try
                {
                    Validate(progress, this.LastProgressEventValue);
                }
                catch (Exception ex)
                {
                    this.ProgressEventException = ex;
                    Console.WriteLine("Exception caught: {0}", ex.Message);
                    throw;
                }
                finally
                {
                    this.LastProgressEventValue = progress;
                }
            }
        }
    }
}
