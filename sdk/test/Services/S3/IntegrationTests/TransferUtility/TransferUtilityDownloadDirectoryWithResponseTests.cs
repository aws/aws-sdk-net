using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityDownloadDirectoryWithResponseTests : TransferUtilityTestBase
    {
        private static readonly long MB = 1024 * 1024;
        private static readonly long KB = 1024;

        public TransferUtilityDownloadDirectoryWithResponseTests(TransferUtilityFixture fixture) : base(fixture) { }

        [Fact]
        public async Task DownloadDirectoryWithResponse_BasicDownload_ReturnsCorrectResponse()
        {
            var keyPrefix = UtilityMethods.GenerateName("basic-download");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            var fileCount = 5;
            
            await UploadTestDirectory(keyPrefix, 2 * MB, fileCount);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsDownloaded);
            
            var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
            Assert.Equal(fileCount, downloadedFiles.Length);
            
            VerifyNoTempFilesExist(downloadPath);
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_EmptyDirectory_ReturnsZeroObjectsDownloaded()
        {
            var keyPrefix = UtilityMethods.GenerateName("empty-directory");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(0, response.ObjectsDownloaded);
            
            if (Directory.Exists(downloadPath))
            {
                var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
                Assert.Equal(0, downloadedFiles.Length);
            }
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_WithProgressTracking_FiresProgressEvents()
        {
            var keyPrefix = UtilityMethods.GenerateName("progress-tracking");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            var fileCount = 3;
            
            await UploadTestDirectory(keyPrefix, 1 * MB, fileCount);

            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            var progressLock = new object();

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath
            };
            
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsDownloaded);
            Assert.True(progressEvents.Count > 0);
            
            var finalEvent = progressEvents.Last();
            Assert.Equal(fileCount, finalEvent.NumberOfFilesDownloaded);
            Assert.Equal(fileCount, finalEvent.TotalNumberOfFiles);
            Assert.Equal(finalEvent.TransferredBytes, finalEvent.TotalBytes);
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_SequentialMode_IncludesCurrentFileDetails()
        {
            var keyPrefix = UtilityMethods.GenerateName("sequential-progress");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            
            await UploadTestDirectory(keyPrefix, 1 * MB, 3);

            var progressEvents = new List<DownloadDirectoryProgressArgs>();

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath,
                DownloadFilesConcurrently = false
            };
            
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(3, response.ObjectsDownloaded);
            
            var eventsWithFile = progressEvents.Where(e => e.CurrentFile != null).ToList();
            Assert.True(eventsWithFile.Count > 0);
            
            foreach (var evt in eventsWithFile)
            {
                Assert.NotNull(evt.CurrentFile);
                Assert.True(evt.TotalNumberOfBytesForCurrentFile > 0);
            }
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_ConcurrentMode_OmitsCurrentFileDetails()
        {
            var keyPrefix = UtilityMethods.GenerateName("concurrent-progress");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            
            await UploadTestDirectory(keyPrefix, 1 * MB, 4);

            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            var progressLock = new object();

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath,
                DownloadFilesConcurrently = true
            };
            
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(4, response.ObjectsDownloaded);
            Assert.True(progressEvents.Count > 0);
            
            foreach (var evt in progressEvents)
            {
                Assert.Null(evt.CurrentFile);
                Assert.Equal(0, evt.TransferredBytesForCurrentFile);
                Assert.Equal(0, evt.TotalNumberOfBytesForCurrentFile);
            }
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_WithMultipartFiles_DownloadsSuccessfully()
        {
            var keyPrefix = UtilityMethods.GenerateName("multipart-directory");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            var fileCount = 3;
            
            await UploadTestDirectory(keyPrefix, 17 * MB, fileCount);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsDownloaded);
            
            var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
            Assert.Equal(fileCount, downloadedFiles.Length);
            
            foreach (var file in downloadedFiles)
            {
                var fileInfo = new FileInfo(file);
                Assert.Equal(17 * MB, fileInfo.Length);
            }
            
            VerifyNoTempFilesExist(downloadPath);
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_NestedDirectories_PreservesStructure()
        {
            var keyPrefix = UtilityMethods.GenerateName("nested-structure");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            
            var nestedFiles = new Dictionary<string, long>
            {
                { "level1/file1.txt", 1 * MB },
                { "level1/level2/file2.txt", 2 * MB },
                { "level1/level2/level3/file3.txt", 3 * MB }
            };
            
            await UploadTestFilesWithStructure(keyPrefix, nestedFiles);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(nestedFiles.Count, response.ObjectsDownloaded);
            
            foreach (var kvp in nestedFiles)
            {
                var expectedPath = Path.Combine(downloadPath, kvp.Key.Replace('/', Path.DirectorySeparatorChar));
                Assert.True(File.Exists(expectedPath));
                
                var fileInfo = new FileInfo(expectedPath);
                Assert.Equal(kvp.Value, fileInfo.Length);
            }
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_ConcurrentMode_DownloadsAllFiles()
        {
            var keyPrefix = UtilityMethods.GenerateName("concurrent-download");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            var fileCount = 10;
            
            await UploadTestDirectory(keyPrefix, 2 * MB, fileCount);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath,
                DownloadFilesConcurrently = true
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsDownloaded);
            
            var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
            Assert.Equal(fileCount, downloadedFiles.Length);
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_SequentialMode_DownloadsAllFiles()
        {
            var keyPrefix = UtilityMethods.GenerateName("sequential-download");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            var fileCount = 5;
            
            await UploadTestDirectory(keyPrefix, 1 * MB, fileCount);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath,
                DownloadFilesConcurrently = false
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsDownloaded);
            
            var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
            Assert.Equal(fileCount, downloadedFiles.Length);
        }

        [Fact]
        public async Task DownloadDirectoryWithResponse_MixedFileSizes_DownloadsAll()
        {
            var keyPrefix = UtilityMethods.GenerateName("mixed-sizes");
            var downloadPath = Path.Combine(_basePath, keyPrefix + "-download");
            
            var mixedFiles = new Dictionary<string, long>
            {
                { "tiny.txt", 100 },
                { "small.txt", 512 * KB },
                { "medium.txt", 2 * MB },
                { "large.txt", 17 * MB }
            };
            
            await UploadTestFilesWithStructure(keyPrefix, mixedFiles);

            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = keyPrefix,
                LocalDirectory = downloadPath
            };
            
            var response = await _transfer.DownloadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(mixedFiles.Count, response.ObjectsDownloaded);
            
            foreach (var kvp in mixedFiles)
            {
                var filePath = Path.Combine(downloadPath, kvp.Key);
                Assert.True(File.Exists(filePath));
                
                var fileInfo = new FileInfo(filePath);
                Assert.Equal(kvp.Value, fileInfo.Length);
            }
        }

        private async Task UploadTestDirectory(string keyPrefix, long fileSize, int fileCount)
        {
            var tempUploadDir = Path.Combine(Path.GetTempPath(), "upload-" + Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempUploadDir);
            
            try
            {
                for (int i = 0; i < fileCount; i++)
                {
                    var fileName = $"file{i}.dat";
                    var localPath = Path.Combine(tempUploadDir, fileName);
                    UtilityMethods.GenerateFile(localPath, fileSize);
                }
                
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = _bucketName,
                    Directory = tempUploadDir,
                    KeyPrefix = keyPrefix,
                    SearchPattern = "*.dat",
                    SearchOption = SearchOption.AllDirectories
                };
                
                await _transfer.UploadDirectoryAsync(request);
            }
            finally
            {
                if (Directory.Exists(tempUploadDir))
                {
                    try { Directory.Delete(tempUploadDir, recursive: true); } catch { }
                }
            }
        }

        private async Task UploadTestFilesWithStructure(string keyPrefix, Dictionary<string, long> files)
        {
            var tempUploadDir = Path.Combine(Path.GetTempPath(), "upload-struct-" + Guid.NewGuid().ToString());
            
            try
            {
                foreach (var kvp in files)
                {
                    var localPath = Path.Combine(tempUploadDir, kvp.Key.Replace('/', Path.DirectorySeparatorChar));
                    var directory = Path.GetDirectoryName(localPath);
                    
                    if (!string.IsNullOrEmpty(directory))
                        Directory.CreateDirectory(directory);
                    
                    UtilityMethods.GenerateFile(localPath, kvp.Value);
                }
                
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = _bucketName,
                    Directory = tempUploadDir,
                    KeyPrefix = keyPrefix,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories
                };
                
                await _transfer.UploadDirectoryAsync(request);
            }
            finally
            {
                if (Directory.Exists(tempUploadDir))
                {
                    try { Directory.Delete(tempUploadDir, recursive: true); } catch { }
                }
            }
        }

        private static void VerifyNoTempFilesExist(string directoryPath)
        {
            if (Directory.Exists(directoryPath))
            {
                var tempFiles = Directory.GetFiles(directoryPath, "*.s3tmp.*", SearchOption.AllDirectories);
                Assert.Equal(0, tempFiles.Length);
            }
        }
    }
}
