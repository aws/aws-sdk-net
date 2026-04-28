using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityUploadDirectoryWithResponseTests : TransferUtilityTestBase
    {
        private static readonly long MB = 1024 * 1024;
        private static readonly long KB = 1024;

        public TransferUtilityUploadDirectoryWithResponseTests(TransferUtilityFixture fixture) : base(fixture) { }

        [Fact]
        public async Task UploadDirectoryWithResponse_BasicUpload_ReturnsCorrectResponse()
        {
            var keyPrefix = UtilityMethods.GenerateName("basic-upload");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            var fileCount = 5;
            
            CreateLocalTestDirectory(uploadPath, 2 * MB, fileCount);

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsUploaded);
            Assert.Equal(0, response.ObjectsFailed);
            Assert.Equal(DirectoryResult.Success, response.Result);
            
            await VerifyObjectsInS3(keyPrefix, fileCount);
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_EmptyDirectory_ReturnsZeroObjectsUploaded()
        {
            var keyPrefix = UtilityMethods.GenerateName("empty-directory");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            Directory.CreateDirectory(uploadPath);

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(0, response.ObjectsUploaded);
            Assert.Equal(0, response.ObjectsFailed);
            Assert.Equal(DirectoryResult.Success, response.Result);
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_WithProgressTracking_FiresProgressEvents()
        {
            var keyPrefix = UtilityMethods.GenerateName("progress-tracking");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            var fileCount = 3;
            
            CreateLocalTestDirectory(uploadPath, 1 * MB, fileCount);

            var progressEvents = new List<UploadDirectoryProgressArgs>();
            var progressLock = new object();

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            request.UploadDirectoryProgressEvent += (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsUploaded);
            Assert.True(progressEvents.Count > 0);
            
            var finalEvent = progressEvents.Last();
            Assert.Equal(fileCount, finalEvent.NumberOfFilesUploaded);
            Assert.Equal(fileCount, finalEvent.TotalNumberOfFiles);
            Assert.Equal(finalEvent.TransferredBytes, finalEvent.TotalBytes);
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_WithLifecycleEvents_FiresInitiatedAndCompleted()
        {
            var keyPrefix = UtilityMethods.GenerateName("lifecycle-events");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            var fileCount = 3;
            
            CreateLocalTestDirectory(uploadPath, 2 * MB, fileCount);

            bool initiatedFired = false;
            bool completedFired = false;
            UploadDirectoryInitiatedEventArgs initiatedArgs = null;
            UploadDirectoryCompletedEventArgs completedArgs = null;

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            request.UploadDirectoryInitiatedEvent += (sender, args) =>
            {
                initiatedFired = true;
                initiatedArgs = args;
            };
            
            request.UploadDirectoryCompletedEvent += (sender, args) =>
            {
                completedFired = true;
                completedArgs = args;
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.True(initiatedFired);
            Assert.True(completedFired);
            
            Assert.NotNull(initiatedArgs);
            Assert.Equal(fileCount, initiatedArgs.TotalFiles);
            Assert.True(initiatedArgs.TotalBytes > 0);
            
            Assert.NotNull(completedArgs);
            Assert.Equal(fileCount, completedArgs.TransferredFiles);
            Assert.Equal(fileCount, completedArgs.TotalFiles);
            Assert.Equal(completedArgs.Response, response);
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_SequentialMode_IncludesCurrentFileDetails()
        {
            var keyPrefix = UtilityMethods.GenerateName("sequential-progress");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            
            CreateLocalTestDirectory(uploadPath, 1 * MB, 3);

            var progressEvents = new List<UploadDirectoryProgressArgs>();

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = false
            };
            
            request.UploadDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(3, response.ObjectsUploaded);
            
            var eventsWithFile = progressEvents.Where(e => e.CurrentFile != null).ToList();
            Assert.True(eventsWithFile.Count > 0);
            
            foreach (var evt in eventsWithFile)
            {
                Assert.NotNull(evt.CurrentFile);
                Assert.True(evt.TotalNumberOfBytesForCurrentFile > 0);
            }
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_ConcurrentMode_OmitsCurrentFileDetails()
        {
            var keyPrefix = UtilityMethods.GenerateName("concurrent-progress");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            
            CreateLocalTestDirectory(uploadPath, 1 * MB, 4);

            var progressEvents = new List<UploadDirectoryProgressArgs>();
            var progressLock = new object();

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = true
            };
            
            request.UploadDirectoryProgressEvent += (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(4, response.ObjectsUploaded);
            Assert.True(progressEvents.Count > 0);
            
            foreach (var evt in progressEvents)
            {
                Assert.Null(evt.CurrentFile);
                Assert.Equal(0, evt.TransferredBytesForCurrentFile);
                Assert.Equal(0, evt.TotalNumberOfBytesForCurrentFile);
            }
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_WithMultipartFiles_UploadsSuccessfully()
        {
            var keyPrefix = UtilityMethods.GenerateName("multipart-directory");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            var fileCount = 3;
            
            CreateLocalTestDirectory(uploadPath, 17 * MB, fileCount);

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsUploaded);
            Assert.Equal(0, response.ObjectsFailed);
            Assert.Equal(DirectoryResult.Success, response.Result);
            
            await VerifyObjectsInS3WithSize(keyPrefix, fileCount, 17 * MB);
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_NestedDirectories_PreservesStructure()
        {
            var keyPrefix = UtilityMethods.GenerateName("nested-structure");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            
            var nestedFiles = new Dictionary<string, long>
            {
                { "level1/file1.txt", 1 * MB },
                { "level1/level2/file2.txt", 2 * MB },
                { "level1/level2/level3/file3.txt", 3 * MB }
            };
            
            CreateLocalTestDirectoryWithStructure(uploadPath, nestedFiles);

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(nestedFiles.Count, response.ObjectsUploaded);
            Assert.Equal(0, response.ObjectsFailed);
            
            foreach (var kvp in nestedFiles)
            {
                var expectedKey = keyPrefix + "/" + kvp.Key.Replace('\\', '/');
                await VerifyObjectExistsInS3(expectedKey, kvp.Value);
            }
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_ConcurrentMode_UploadsAllFiles()
        {
            var keyPrefix = UtilityMethods.GenerateName("concurrent-upload");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            var fileCount = 10;
            
            CreateLocalTestDirectory(uploadPath, 2 * MB, fileCount);

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = true
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsUploaded);
            Assert.Equal(0, response.ObjectsFailed);
            
            await VerifyObjectsInS3(keyPrefix, fileCount);
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_SequentialMode_UploadsAllFiles()
        {
            var keyPrefix = UtilityMethods.GenerateName("sequential-upload");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            var fileCount = 5;
            
            CreateLocalTestDirectory(uploadPath, 1 * MB, fileCount);

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = false
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(fileCount, response.ObjectsUploaded);
            Assert.Equal(0, response.ObjectsFailed);
            
            await VerifyObjectsInS3(keyPrefix, fileCount);
        }

        [Fact]
        public async Task UploadDirectoryWithResponse_MixedFileSizes_UploadsAll()
        {
            var keyPrefix = UtilityMethods.GenerateName("mixed-sizes");
            var uploadPath = Path.Combine(_basePath, keyPrefix + "-upload");
            
            var mixedFiles = new Dictionary<string, long>
            {
                { "tiny.txt", 100 },
                { "small.txt", 512 * KB },
                { "medium.txt", 2 * MB },
                { "large.txt", 17 * MB }
            };
            
            CreateLocalTestDirectoryWithStructure(uploadPath, mixedFiles);

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await _transfer.UploadDirectoryWithResponseAsync(request);

            Assert.NotNull(response);
            Assert.Equal(mixedFiles.Count, response.ObjectsUploaded);
            Assert.Equal(0, response.ObjectsFailed);
            
            foreach (var kvp in mixedFiles)
            {
                var s3Key = keyPrefix + "/" + kvp.Key;
                await VerifyObjectExistsInS3(s3Key, kvp.Value);
            }
        }

        private static void CreateLocalTestDirectory(string directoryPath, long fileSize, int fileCount)
        {
            Directory.CreateDirectory(directoryPath);
            
            for (int i = 0; i < fileCount; i++)
            {
                var fileName = $"file{i}.dat";
                var filePath = Path.Combine(directoryPath, fileName);
                UtilityMethods.GenerateFile(filePath, fileSize);
            }
        }

        private static void CreateLocalTestDirectoryWithStructure(string directoryPath, Dictionary<string, long> files)
        {
            foreach (var kvp in files)
            {
                var filePath = Path.Combine(directoryPath, kvp.Key.Replace('/', Path.DirectorySeparatorChar));
                var directory = Path.GetDirectoryName(filePath);
                
                if (!string.IsNullOrEmpty(directory))
                    Directory.CreateDirectory(directory);
                
                UtilityMethods.GenerateFile(filePath, kvp.Value);
            }
        }

        private async Task VerifyObjectsInS3(string keyPrefix, int expectedCount)
        {
            var listRequest = new ListObjectsV2Request
            {
                BucketName = _bucketName,
                Prefix = keyPrefix + "/"
            };
            
            var listResponse = await _client.ListObjectsV2Async(listRequest);
            
            var actualObjects = listResponse.S3Objects
                .Where(s3o => !s3o.Key.EndsWith("/", StringComparison.Ordinal))
                .ToList();
            
            Assert.Equal(expectedCount, actualObjects.Count);
        }

        private async Task VerifyObjectsInS3WithSize(string keyPrefix, int expectedCount, long expectedSize)
        {
            var listRequest = new ListObjectsV2Request
            {
                BucketName = _bucketName,
                Prefix = keyPrefix + "/"
            };
            
            var listResponse = await _client.ListObjectsV2Async(listRequest);
            
            var actualObjects = listResponse.S3Objects
                .Where(s3o => !s3o.Key.EndsWith("/", StringComparison.Ordinal))
                .ToList();
            
            Assert.Equal(expectedCount, actualObjects.Count);
            
            foreach (var s3Object in actualObjects)
            {
                Assert.Equal(expectedSize, s3Object.Size);
            }
        }

        private async Task VerifyObjectExistsInS3(string key, long expectedSize)
        {
            var getRequest = new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            };
            
            var metadata = await _client.GetObjectMetadataAsync(getRequest);
            
            Assert.NotNull(metadata);
            Assert.Equal(expectedSize, metadata.ContentLength);
        }
    }
}
