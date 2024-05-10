using Amazon.DNXCore.IntegrationTests.Common;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests.S3
{
    public class TransferUtilityTests : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);
        public static readonly long KILO_SIZE = (int)Math.Pow(2, 10);

        private const string TEST_CONTENT = "This is the content body!";
        private const string TEST_FILENAME = "PutObjectFile.txt";
        private const string OCTET_STREAM_CONTENT_TYPE = "application/octet-stream";

        private string testBucketName;
        private string basePath;
        private string testFilePath;
        
        public TransferUtilityTests()
        {
            testBucketName = UtilityMethods.CreateBucketAsync(Client, "TransferUtilityTests").Result;

            basePath = Path.Combine(Path.GetTempPath(), "test", "transferutility");
            Directory.CreateDirectory(basePath);

            testFilePath = Path.Combine(basePath, TEST_FILENAME);
            File.WriteAllText(testFilePath, TEST_CONTENT);
        }

        protected override void Dispose(bool disposing)
        {
            UtilityMethods.DeleteBucketWithObjectsAsync(Client, testBucketName).Wait();
            try
            {
                Directory.Delete(basePath, true);
            }
            catch (DirectoryNotFoundException) { };
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public Task SimpleUploadTest()
        {
            var fileName = UtilityMethods.GenerateName(Path.Combine("SimpleUploadTest","SmallFile"));
            return UploadAsync(fileName, 10 * MEG_SIZE, null);
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task SimpleUploadProgressTest()
        {
            var context = SynchronizationContext.Current;
            var fileName = UtilityMethods.GenerateName(Path.Combine("SimpleUploadTest","SmallFile"));
            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.Equal(p.FilePath, Path.Combine(basePath, fileName));
                }
            };
            await UploadAsync(fileName, 10 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public void SimpleUpload()
        {
            var client = Client;
            using (var tu = new Amazon.S3.Transfer.TransferUtility(client))
            {
                tu.Upload(testFilePath, testBucketName);

                var response = WaitUtils.WaitForComplete(
                    () =>
                    {
                        return client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                        {
                            BucketName = testBucketName,
                            Key = TEST_FILENAME
                        }).Result;
                    });
                Assert.True(response.ETag.Length > 0);

                var downloadPath = testFilePath + ".download";
                var downloadRequest = new Amazon.S3.Transfer.TransferUtilityDownloadRequest
                {
                    BucketName = testBucketName,
                    Key = TEST_FILENAME,
                    FilePath = downloadPath
                };
                tu.Download(downloadRequest);
                TestDownloadedFile(downloadPath);

                // empty out file, except for 1 byte
                File.WriteAllText(downloadPath, TEST_CONTENT.Substring(0,1));
                Assert.True(File.Exists(downloadPath));
                tu.Download(downloadRequest);
                TestDownloadedFile(downloadPath);
            }
        }

        private void TestDownloadedFile(string downloadPath)
        {
            var fileExists = File.Exists(downloadPath);
            Assert.True(fileExists);
            var fileContent = File.ReadAllText(downloadPath);
            Assert.Equal(TEST_CONTENT, fileContent);
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task MultipartUploadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName(Path.Combine("MultipartUploadTest","File"));
            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                ValidateProgressInterval = false,
                Validate = (p) =>
                {
                    Assert.Equal(p.FilePath, Path.Combine(basePath, fileName));
                }
            };
            await UploadAsync(fileName, 20 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        private async Task UploadAsync(string fileName, long size, TransferProgressValidator<UploadProgressArgs> progressValidator, AmazonS3Client client = null)
        {
            var key = fileName;
            await Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = testBucketName,
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
                BucketName = testBucketName,
                FilePath = path,
                Key = key,
                ContentType = OCTET_STREAM_CONTENT_TYPE
            };

            if (progressValidator != null)
            {
                request.UploadProgressEvent += progressValidator.OnProgressEvent;
            }

            transferUtility.Upload(request);

            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = testBucketName,
                Key = key
            });
            Console.WriteLine("Expected Size: {0} , Actual Size {1}", size, metadata.ContentLength);
            Assert.Equal(OCTET_STREAM_CONTENT_TYPE, metadata.Headers.ContentType);
            Assert.Equal(size, metadata.ContentLength);
            await ValidateFileContentsAsync(testBucketName, key, path);
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task UploadDirectoryWithProgressTracker()
        {
            var directoryName = UtilityMethods.GenerateName("UploadDirectoryTest");
            var progressValidator = new DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            ConfigureProgressValidator(progressValidator);

            await UploadDirectoryAsync(directoryName, 10 * MEG_SIZE, progressValidator, true, false);
            progressValidator.AssertOnCompletion();
        }

        private Task UploadDirectoryAsync(string directoryName, long size, 
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
                BucketName = testBucketName,
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

            Assert.Equal(5, files.Count);

            if (validate)
                return ValidateDirectoryContents(testBucketName, directoryName, directoryPath);
            else
                return Task.FromResult<object>(null);
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task DownloadDirectoryProgressTest()
        {
            // disable clock skew testing, this is a multithreaded test
            var directoryName = UtilityMethods.GenerateName(@"DownloadDirectoryTest");
            var progressValidator = new DirectoryProgressValidator<DownloadDirectoryProgressArgs>();
            ConfigureProgressValidator(progressValidator);

            await DownloadDirectoryAsync(directoryName, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        private async Task DownloadDirectoryAsync(string directoryName, DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator, bool concurrent = true)
        {
            var directoryPath = Path.Combine(basePath, directoryName);
            await UploadDirectoryAsync(directoryName,
                20 * MEG_SIZE, null, false);
            Directory.Delete(directoryPath, true);

            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = testBucketName,
                LocalDirectory = directoryPath,
                S3Directory = directoryName
            };

            if (progressValidator != null)
                request.DownloadedDirectoryProgressEvent += progressValidator.OnProgressEvent;

            transferUtility.DownloadDirectory(request);
            await ValidateDirectoryContents(testBucketName, directoryName, directoryPath);
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task DownloadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName(Path.Combine("DownloadTest","File"));
            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.Equal(p.BucketName, testBucketName);
                    Assert.Equal(p.Key, fileName);
                    Assert.NotNull(p.FilePath);
                    Assert.Contains(fileName, p.FilePath);
                }
            };
            await DownloadAsync(fileName, 10 * MEG_SIZE, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task DownloadProgressZeroLengthFileTest()
        {
            var fileName = UtilityMethods.GenerateName(Path.Combine("DownloadTest", "File"));
            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.Equal(p.BucketName, testBucketName);
                    Assert.Equal(p.Key, fileName);
                    Assert.NotNull(p.FilePath);
                    Assert.Contains(fileName, p.FilePath);
                    Assert.Equal(0, p.TotalBytes);
                    Assert.Equal(0, p.TransferredBytes);
                    Assert.Equal(100, p.PercentDone);
                }
            };
            await DownloadAsync(fileName, 0, progressValidator);
            progressValidator.AssertOnCompletion();
        }

        async Task DownloadAsync(string fileName, long size, TransferProgressValidator<WriteObjectProgressArgs> progressValidator)
        {
            var key = fileName;
            var originalFilePath = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, size);

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = testBucketName,
                Key = key,
                FilePath = originalFilePath
            });

            var downloadedFilePath = originalFilePath + ".dn";

            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = testBucketName,
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

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task OpenStreamTest()
        {
            var fileName = UtilityMethods.GenerateName(Path.Combine("OpenStreamTest","File"));
            var key = fileName;
            var originalFilePath = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, 2 * MEG_SIZE);
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = testBucketName,
                Key = key,
                FilePath = originalFilePath
            });

            using (var transferUtility = new TransferUtility(Client))
            using (var stream = transferUtility.OpenStream(testBucketName, key))
            {
                Assert.NotNull(stream);
                Assert.True(stream.CanRead);
            }
        }

        /// <summary>
        /// Partial download resumption support can erroneously trigger retry with
        /// byte range of 0 to Long.MaxValue if a zero length object is the first object
        /// to be download to a new folder path - S3 then yields an invalid byte range 
        /// error on the retry.
        /// Test ensures the fix, to test that the folder path exists before trying to
        /// access it, so we don't trigger a retry.
        /// </summary>
        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task TestZeroLengthDownloadToNonExistingPath()
        {
            var objectKey = Path.Combine("folder1", "folder2", "empty_file.txt");

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = testBucketName,
                Key = objectKey,
                ContentBody = ""
            });

            var filename = UtilityMethods.GenerateName(objectKey);
            var filePath = Path.Combine(basePath, filename);
            var transferUtility = new TransferUtility(Client);
            transferUtility.Download(new TransferUtilityDownloadRequest
            {
                BucketName = testBucketName,
                FilePath = filePath,
                Key = objectKey
            });

            Assert.True(File.Exists(filePath));
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public void UploadAsyncCancellationTest()
        {
            var fileName = UtilityMethods.GenerateName(Path.Combine("SimpleUploadTest", "CancellationTest"));
            var path = Path.Combine(basePath, fileName);
            UtilityMethods.GenerateFile(path, 20 * MEG_SIZE);

            TransferUtilityUploadRequest uploadRequest = new TransferUtilityUploadRequest()
            {
                BucketName = testBucketName,
                Key = fileName,
                FilePath = path
            };

            var tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            System.Threading.Tasks.Task uploadTask = null;
            using (var transferUtility = new TransferUtility(Client))
            {
                uploadTask = transferUtility.UploadAsync(uploadRequest, token);
                tokenSource.CancelAfter(100);
                Assert.Throws<TaskCanceledException>(
                    () =>
                    {
                        try
                        {
                            uploadTask.Wait();
                        }
                        catch(AggregateException e)
                        {
                            throw e.InnerException;
                        }
                    });
            }
        }

        [Fact]
        [Trait(CategoryAttribute, "S3")]
        public async Task UploadDirectoryWithTagsTest()
        {
            for(int i = 1; i < 4; i++)
            {
                UtilityMethods.GenerateFile(Path.Combine(basePath, "tempfile-" + i), MEG_SIZE /i);
            }

            var uploadRequest = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = testBucketName,
                Directory = basePath,
                TagSet = new List<Tag>
                {
                    new Tag
                    {
                        Key = "hello",
                        Value = "world"
                    }
                }
            };

            using (var transferUtility = new TransferUtility(Client))
            {
                await transferUtility.UploadDirectoryAsync(uploadRequest);
            }

            var objects = (await Client.ListObjectsAsync(new ListObjectsRequest
            {
                BucketName = testBucketName
            })).S3Objects;

            foreach(var obj in objects)
            {
                var tags = (await Client.GetObjectTaggingAsync(new GetObjectTaggingRequest
                {
                    BucketName = testBucketName,
                    Key = obj.Key
                })).Tagging;

                Assert.Single(tags);
                Assert.Equal("hello", tags[0].Key);
                Assert.Equal("world", tags[0].Value);
            }
        }

        public static void ConfigureProgressValidator(DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                if (lastProgress != null)
                {
                    Assert.True(progress.NumberOfFilesDownloaded >= lastProgress.NumberOfFilesDownloaded);
                    Assert.True(progress.TransferredBytes >= lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesDownloaded == lastProgress.NumberOfFilesDownloaded)
                    {
                        Assert.True(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                }

                if (progress.NumberOfFilesDownloaded == progress.TotalNumberOfFiles)
                {
                    Assert.Equal(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.WriteLine(progress.ToString());
            };
        }

        public static void ConfigureProgressValidator(DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                Assert.False(string.IsNullOrEmpty(progress.CurrentFile));
                Assert.True(progress.TotalNumberOfBytesForCurrentFile > 0);
                Assert.True(progress.TransferredBytesForCurrentFile > 0);

                if (lastProgress != null)
                {
                    Assert.True(progress.NumberOfFilesUploaded >= lastProgress.NumberOfFilesUploaded);
                    Assert.True(progress.TransferredBytes > lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesUploaded == lastProgress.NumberOfFilesUploaded)
                    {
                        Assert.True(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                    else
                    {
                        Assert.Equal(progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                    }
                }

                if (progress.NumberOfFilesUploaded == progress.TotalNumberOfFiles)
                {
                    Assert.Equal(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.Write("\t{0} : {1}/{2}\t", progress.CurrentFile,
                    progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                Console.WriteLine(progress.ToString());
            };
        }

        private Task ValidateFileContentsAsync(string bucketName, string key, string path)
        {
            // test assumes we used a known extension and added it to the file key
            var ext = Path.GetExtension(key);
            return ValidateFileContentsAsync(bucketName, key, path, AmazonS3Util.MimeTypeFromExtension(ext));
        }

        private async Task ValidateFileContentsAsync(string bucketName, string key, string path, string contentType)
        {
            var downloadPath = path + ".chk";
            for (int retries = 0; retries < 5; retries++)
            {
                try
                {
                    var request = new GetObjectRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                    };
                    using (var response = await Client.GetObjectAsync(request))
                    {
                        //Assert.AreEqual(contentType, response.Headers.ContentType);
                        await response.WriteResponseStreamToFileAsync(downloadPath, false, CancellationToken.None);
                    }
                }
                catch(AmazonS3Exception e)
                {
                    if (e.StatusCode != HttpStatusCode.NotFound || retries == 5)
                        throw;
                }
            }
            UtilityMethods.CompareFiles(path, downloadPath);
        }

        private async Task ValidateDirectoryContents(string bucketName, string rootDirectoryName, string directoryPath)
        {
            string[] filePaths = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
            foreach (var filePath in filePaths)
            {
                // Get key based on separators of current platform.  If it's windows, replace any windows style
                // separators with the unix style separators that S3 is expecting.
                var key = filePath.Substring(directoryPath.LastIndexOf(Path.DirectorySeparatorChar) + 1).Replace("\\", "/");
                await ValidateFileContentsAsync(bucketName, key, filePath);
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
                Assert.True(this.IsProgressEventComplete, "IsProgressEventComplete is false");
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
                    Assert.False(progress.PercentDone > 100, "Progress percent done cannot be greater than 100%");
                    Assert.False(this.IsProgressEventComplete, "A progress event was received after completion.");

                    if (progress.TransferredBytes == progress.TotalBytes)
                    {
                        Assert.Equal(100, progress.PercentDone);
                        this.IsProgressEventComplete = true;
                    }

                    if (this.LastProgressEventValue != null)
                    {
                        if (progress.PercentDone < this.LastProgressEventValue.PercentDone)
                            Console.WriteLine("Progress Event : --------------------------");

                        Assert.True(progress.PercentDone >= this.LastProgressEventValue.PercentDone);
                        Assert.True(progress.TransferredBytes > this.LastProgressEventValue.TransferredBytes);

                        if (progress.TransferredBytes < progress.TotalBytes)
                        {
                            if (progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes < 100 * KILO_SIZE)
                                Console.WriteLine("Progress Event : *******Part Uploaded********");

                            if (this.ValidateProgressInterval)
                            {
                                // When TransferUtility uploads using multipart upload, the TransferredBytes
                                // will be less than the interval for last chunk of each upload part request.
                                Assert.True(progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes >= 100 * KILO_SIZE);
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
