using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Abstract base class for TransferUtility integration tests.
    /// </summary>
    public abstract class TransferUtilityTestBase
    {
        protected static string octetStreamContentType = "application/octet-stream";
        protected static string plainTextContentType = "text/plain";

        protected const string testContent = "This is the content body!";
        protected const string testFile = "PutObjectFile.txt";

        protected readonly AmazonS3Client _client;
        protected readonly string _bucketName;
        protected readonly string _basePath;
        protected readonly string _fullPath;
        protected readonly string _testId;
        protected readonly TransferUtility _transfer;

        protected TransferUtilityTestBase(TransferUtilityFixture fixture)
        {
            _client = fixture.Client;
            _transfer = fixture.Transfer;
            _bucketName = fixture.BucketName;
            _testId = Guid.NewGuid().ToString("N");

            // Each test class instance gets its own isolated sub-directory to avoid parallel file conflicts
            _basePath = Path.Combine(fixture.BasePath, "TransferUtilityTests", _testId);
            Directory.CreateDirectory(_basePath);

            _fullPath = Path.Combine(_basePath, testFile);
            File.WriteAllText(_fullPath, testContent);
        }

        protected void TestDownloadedFile(string downloadPath)
        {
            var fileExists = File.Exists(downloadPath);
            Assert.True(fileExists);
            var fileContent = File.ReadAllText(downloadPath);
            Assert.Equal(testContent, fileContent);
        }

        protected async Task UploadWithLifecycleEvents(string fileName, long size,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            await UploadWithLifecycleEventsAndBucket(fileName, size, _bucketName, initiatedValidator, completedValidator, failedValidator);
        }

        protected async Task UploadWithLifecycleEventsAndBucket(string fileName, long size, string targetBucketName,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            var key = fileName;
            var path = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(path, size);
            
            var request = new TransferUtilityUploadRequest
            {
                BucketName = targetBucketName,
                FilePath = path,
                Key = key,
                ContentType = octetStreamContentType
            };

            if (initiatedValidator != null) request.UploadInitiatedEvent += initiatedValidator.OnEventFired;
            if (completedValidator != null) request.UploadCompletedEvent += completedValidator.OnEventFired;
            if (failedValidator != null) request.UploadFailedEvent += failedValidator.OnEventFired;
            await _transfer.UploadAsync(request);
        }

        protected async Task UploadUnseekableStreamWithLifecycleEvents(long size,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            await UploadUnseekableStreamWithLifecycleEventsAndBucket(size, _bucketName, initiatedValidator, completedValidator, failedValidator);
        }

        protected async Task UploadUnseekableStreamWithLifecycleEventsAndBucket(long size, string targetBucketName,
            TransferLifecycleEventValidator<UploadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadFailedEventArgs> failedValidator)
        {
            var fileName = UtilityMethods.GenerateName(@"UnseekableStreamUpload\File");
            var key = fileName;
            var path = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(path, size);

            var stream = GenerateUnseekableStreamFromFile(path);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = targetBucketName,
                InputStream = stream,
                Key = key,
                ContentType = octetStreamContentType
            };

            if (initiatedValidator != null) request.UploadInitiatedEvent += initiatedValidator.OnEventFired;
            if (completedValidator != null) request.UploadCompletedEvent += completedValidator.OnEventFired;
            if (failedValidator != null) request.UploadFailedEvent += failedValidator.OnEventFired;
            await _transfer.UploadAsync(request);
        }

        protected async Task DownloadWithLifecycleEvents(string fileName, long size,
            TransferLifecycleEventValidator<DownloadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<DownloadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<DownloadFailedEventArgs> failedValidator)
        {
            var key = fileName;
            var originalFilePath = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, size);
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = originalFilePath
            });
            var downloadedFilePath = originalFilePath + ".download";
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                FilePath = downloadedFilePath,
                Key = key
            };

            if (initiatedValidator != null) request.DownloadInitiatedEvent += initiatedValidator.OnEventFired;
            if (completedValidator != null) request.DownloadCompletedEvent += completedValidator.OnEventFired;
            if (failedValidator != null) request.DownloadFailedEvent += failedValidator.OnEventFired;

            await _transfer.DownloadAsync(request);
        }

        protected async Task DownloadWithLifecycleEventsAndKey(string fileName, string keyToDownload,
            TransferLifecycleEventValidator<DownloadInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<DownloadCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<DownloadFailedEventArgs> failedValidator)
        {
            var downloadedFilePath = Path.Combine(_basePath, fileName + ".download");

            var request = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                FilePath = downloadedFilePath,
                Key = keyToDownload
            };

            if (initiatedValidator != null) request.DownloadInitiatedEvent += initiatedValidator.OnEventFired;
            if (completedValidator != null) request.DownloadCompletedEvent += completedValidator.OnEventFired;
            if (failedValidator != null) request.DownloadFailedEvent += failedValidator.OnEventFired;

            await _transfer.DownloadAsync(request);
        }

        protected async Task Upload(string fileName, long size, TransferProgressValidator<UploadProgressArgs> progressValidator)
        {
            var key = fileName;
            await _client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = _bucketName,
                Key = key
            });

            var path = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(path, size);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = key,
                ContentType = octetStreamContentType
            };

            if (progressValidator != null)
            {
                request.UploadProgressEvent += progressValidator.OnProgressEvent;
            }

            await _transfer.UploadAsync(request);

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });
            Assert.Equal(octetStreamContentType, metadata.Headers.ContentType);
            Assert.Equal(size, metadata.ContentLength);
            await TransferUtilityTestHelpers.ValidateFileContents(_bucketName, key, path);
        }

        protected async Task Download(string fileName, long size, TransferProgressValidator<WriteObjectProgressArgs> progressValidator)
        {
            var key = fileName;
            var originalFilePath = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, size);

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = originalFilePath
            });

            var downloadedFilePath = originalFilePath + ".dn";
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                FilePath = downloadedFilePath,
                Key = key
            };
            if (progressValidator != null)
            {
                request.WriteObjectProgressEvent += progressValidator.OnProgressEvent;
            }

            await _transfer.DownloadAsync(request);

            UtilityMethods.CompareFiles(originalFilePath, downloadedFilePath);
        }

        protected async Task<DirectoryInfo> UploadDirectory(long size,
             DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, bool validate = true)
        {
            var directory = TransferUtilityTestHelpers.CreateTestDirectory(size);
            var keyPrefix = directory.Name;
            var directoryPath = directory.FullName;

            var concurrentTu = new TransferUtility(_client, new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            });

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = directoryPath,
                KeyPrefix = keyPrefix,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
            };

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

            await concurrentTu.UploadDirectoryAsync(request);
            Assert.Equal(5, files.Count);

            if (validate)
            {
                await TransferUtilityTestHelpers.ValidateDirectoryContents(_bucketName, keyPrefix, directory, plainTextContentType);
            }

            return directory;
        }

        protected async Task DownloadDirectory(DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator, bool concurrent = true)
        {
            var directory = await UploadDirectory(1 * TransferUtilityTestHelpers.MEG_SIZE, null, false);
            var directoryPath = directory.FullName;
            var keyPrefix = directory.Name;
            Directory.Delete(directoryPath, true);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                LocalDirectory = directoryPath,
                S3Directory = keyPrefix
            };

            if (progressValidator != null)
            {
                request.DownloadedDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            await _transfer.DownloadDirectoryAsync(request);

            await TransferUtilityTestHelpers.ValidateDirectoryContents(_bucketName, keyPrefix, directory);
        }

        protected async Task<DirectoryInfo> DownloadDirectoryWithDisableSlashCorrectionForS3Directory(int numberOfTestFiles, DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator)
        {
            var keyPrefix = DateTime.UtcNow.ToString("yyyy-MM-dd");
            var directory = await UploadDirectoryWithKeyPrefix(1 * TransferUtilityTestHelpers.KILO_SIZE, null, keyPrefix, numberOfTestFiles, false);
            var directoryPath = directory.FullName;
            Directory.Delete(directoryPath, true);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                LocalDirectory = directoryPath,
                S3Directory = keyPrefix,
                DisableSlashCorrection = true
            };

            if (progressValidator != null)
            {
                request.DownloadedDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            await _transfer.DownloadDirectoryAsync(request);

            return directory;
        }

        protected async Task<DirectoryInfo> UploadDirectoryWithKeyPrefix(long size, DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, string keyPrefix, int numberOfTestFiles, bool validate = true)
        {
            var directory = TransferUtilityTestHelpers.CreateTestDirectoryWithFilePrefix(size, keyPrefix, numberOfTestFiles);
            var directoryPath = directory.FullName;
            var concurrentTu = new TransferUtility(_client, new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            });
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = directoryPath,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
            };

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

            await _transfer.UploadDirectoryAsync(request);

            if (validate)
            {
                await TransferUtilityTestHelpers.ValidateDirectoryContents(_bucketName, string.Empty, directory, plainTextContentType);
            }

            return directory;
        }

        protected async Task ValidateDirectoryContentTypes(string bucketName, string keyPrefix, DirectoryInfo directory)
        {
            var expectedContentTypes = new Dictionary<string, string>
            {
                { ".html", "text/html" },
                { ".css", "text/css" },
                { ".js", "application/x-javascript" },
                { ".json", "application/json" },
                { ".txt", "text/plain" },
                { ".xml", "text/xml" },
                { ".pdf", "application/pdf" },
                { ".svg", "image/svg+xml" }
            };

            var files = directory.GetFiles("*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var filePath = file.FullName;
                var relativePath = filePath.Substring(directory.FullName.Length + 1);
                var key = (!string.IsNullOrEmpty(keyPrefix) ? keyPrefix + "/" : string.Empty) + relativePath.Replace("\\", "/");

                var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key
                });

                var extension = Path.GetExtension(file.Name).ToLowerInvariant();
                var expectedContentType = expectedContentTypes[extension];

                Assert.Equal(expectedContentType, metadata.Headers.ContentType);
            }
        }

        protected DirectoryInfo CreateMixedFileTypeTestDirectory()
        {
            var directoryPath = TransferUtilityTestHelpers.GenerateDirectoryPath("MixedFileTypeTest");

            var testFiles = new Dictionary<string, string>
            {
                { "test.html", "<html><body>Test HTML</body></html>" },
                { "test.css", "body { color: red; }" },
                { "test.js", "console.log('test');" },
                { "test.json", "{ \"test\": \"value\" }" },
                { "test.txt", "Plain text content" },
                { "test.xml", "<?xml version=\"1.0\"?><root>test</root>" },
                { "test.pdf", "PDF content placeholder" },
                { "test.svg", "<svg><rect width=\"100\" height=\"100\"/></svg>" }
            };

            foreach (var file in testFiles)
            {
                var filePath = Path.Combine(directoryPath, file.Key);
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                File.WriteAllText(filePath, file.Value);
            }

            return new DirectoryInfo(directoryPath);
        }

        protected UnseekableStream GenerateUnseekableStreamFromFile(string filePath)
        {
            try
            {
                var fileBytes = File.ReadAllBytes(filePath);
                return new UnseekableStream(fileBytes)
                {
                    Position = 0
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while generating the stream: {ex.Message}");
                throw;
            }
        }
    }
}
