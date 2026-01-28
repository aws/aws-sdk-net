using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for TransferUtility.UploadDirectoryWithResponseAsync functionality.
    /// These tests verify end-to-end functionality with actual S3 operations and directory I/O.
    /// 
    /// These integration tests focus on:
    /// - Basic directory uploads with response object
    /// - Progress tracking with response
    /// - Multipart uploads in directory context
    /// - Concurrent vs sequential uploads
    /// - Nested directory structures
    /// - Response validation
    /// </summary>
    [TestClass]
    [TestCategory("S3")]
    public class TransferUtilityUploadDirectoryWithResponseTests : TestBase<AmazonS3Client>
    {
        private static readonly long MB = 1024 * 1024;
        private static readonly long KB = 1024;
        private static string bucketName;
        private static string tempDirectory;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            tempDirectory = Path.Combine(Path.GetTempPath(), "S3UploadDirectoryTests-" + Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDirectory);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            
            // Clean up temp directory
            if (Directory.Exists(tempDirectory))
            {
                try
                {
                    Directory.Delete(tempDirectory, recursive: true);
                }
                catch
                {
                    // Best effort cleanup
                }
            }
            
            BaseClean();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up any test directories after each test
            if (Directory.Exists(tempDirectory))
            {
                foreach (var subDir in Directory.GetDirectories(tempDirectory))
                {
                    try
                    {
                        Directory.Delete(subDir, recursive: true);
                    }
                    catch
                    {
                        // Best effort cleanup
                    }
                }
            }
        }

        #region Basic Upload Tests

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_BasicUpload_ReturnsCorrectResponse()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("basic-upload");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            var fileCount = 5;
            
            CreateLocalTestDirectory(uploadPath, 2 * MB, fileCount);

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            Assert.AreEqual(fileCount, response.ObjectsUploaded, "ObjectsUploaded should match file count");
            Assert.AreEqual(0, response.ObjectsFailed, "ObjectsFailed should be 0");
            Assert.AreEqual(DirectoryResult.Success, response.Result, "Result should be Success");
            
            // Verify all files were uploaded to S3
            await VerifyObjectsInS3(keyPrefix, fileCount);
        }

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_EmptyDirectory_ReturnsZeroObjectsUploaded()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("empty-directory");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            Directory.CreateDirectory(uploadPath);

            // Act - Upload empty directory
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            Assert.AreEqual(0, response.ObjectsUploaded, "ObjectsUploaded should be 0 for empty directory");
            Assert.AreEqual(0, response.ObjectsFailed, "ObjectsFailed should be 0");
            Assert.AreEqual(DirectoryResult.Success, response.Result, "Result should be Success");
        }

        #endregion

        #region Progress Tracking Tests

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_WithProgressTracking_FiresProgressEvents()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("progress-tracking");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            var fileCount = 3;
            
            CreateLocalTestDirectory(uploadPath, 5 * MB, fileCount);

            var progressEvents = new List<UploadDirectoryProgressArgs>();
            var progressLock = new object();

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
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
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            Assert.AreEqual(fileCount, response.ObjectsUploaded);
            Assert.IsTrue(progressEvents.Count > 0, "Progress events should have fired");
            
            // Verify final progress event
            var finalEvent = progressEvents.Last();
            Assert.AreEqual(fileCount, finalEvent.NumberOfFilesUploaded);
            Assert.AreEqual(fileCount, finalEvent.TotalNumberOfFiles);
            Assert.AreEqual(finalEvent.TransferredBytes, finalEvent.TotalBytes);
        }

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_WithLifecycleEvents_FiresInitiatedAndCompleted()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("lifecycle-events");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            var fileCount = 3;
            
            CreateLocalTestDirectory(uploadPath, 2 * MB, fileCount);

            bool initiatedFired = false;
            bool completedFired = false;
            UploadDirectoryInitiatedEventArgs initiatedArgs = null;
            UploadDirectoryCompletedEventArgs completedArgs = null;

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
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
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsTrue(initiatedFired, "Initiated event should have fired");
            Assert.IsTrue(completedFired, "Completed event should have fired");
            
            Assert.IsNotNull(initiatedArgs);
            Assert.AreEqual(fileCount, initiatedArgs.TotalFiles);
            Assert.IsTrue(initiatedArgs.TotalBytes > 0);
            
            Assert.IsNotNull(completedArgs);
            Assert.AreEqual(fileCount, completedArgs.TransferredFiles);
            Assert.AreEqual(fileCount, completedArgs.TotalFiles);
            Assert.AreEqual(completedArgs.Response, response);
        }

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_SequentialMode_IncludesCurrentFileDetails()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("sequential-progress");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            
            CreateLocalTestDirectory(uploadPath, 3 * MB, 3);

            var progressEvents = new List<UploadDirectoryProgressArgs>();

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = false // Sequential mode
            };
            
            request.UploadDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(3, response.ObjectsUploaded);
            
            // In sequential mode, should have CurrentFile populated
            var eventsWithFile = progressEvents.Where(e => e.CurrentFile != null).ToList();
            Assert.IsTrue(eventsWithFile.Count > 0, "Should have events with CurrentFile populated");
            
            foreach (var evt in eventsWithFile)
            {
                Assert.IsNotNull(evt.CurrentFile);
                Assert.IsTrue(evt.TotalNumberOfBytesForCurrentFile > 0);
            }
        }

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_ConcurrentMode_OmitsCurrentFileDetails()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("concurrent-progress");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            
            CreateLocalTestDirectory(uploadPath, 3 * MB, 4);

            var progressEvents = new List<UploadDirectoryProgressArgs>();
            var progressLock = new object();

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = true // Concurrent mode
            };
            
            request.UploadDirectoryProgressEvent += (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(4, response.ObjectsUploaded);
            Assert.IsTrue(progressEvents.Count > 0);
            
            // In concurrent mode, CurrentFile should be null
            foreach (var evt in progressEvents)
            {
                Assert.IsNull(evt.CurrentFile, "CurrentFile should be null in concurrent mode");
                Assert.AreEqual(0, evt.TransferredBytesForCurrentFile);
                Assert.AreEqual(0, evt.TotalNumberOfBytesForCurrentFile);
            }
        }

        #endregion

        #region Multipart Upload Tests

        [TestMethod]
        [TestCategory("UploadDirectory")]
        [TestCategory("Multipart")]
        public async Task UploadDirectoryWithResponse_WithMultipartFiles_UploadsSuccessfully()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("multipart-directory");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            var fileCount = 3;
            
            // Create directory with large files to trigger multipart (>16MB threshold)
            CreateLocalTestDirectory(uploadPath, 20 * MB, fileCount);

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(fileCount, response.ObjectsUploaded);
            Assert.AreEqual(0, response.ObjectsFailed);
            Assert.AreEqual(DirectoryResult.Success, response.Result);
            
            // Verify all files uploaded with correct sizes
            await VerifyObjectsInS3WithSize(keyPrefix, fileCount, 20 * MB);
        }

        #endregion

        #region Nested Directory Tests

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_NestedDirectories_PreservesStructure()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("nested-structure");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            
            // Create nested directory structure
            var nestedFiles = new Dictionary<string, long>
            {
                { "level1/file1.txt", 1 * MB },
                { "level1/level2/file2.txt", 2 * MB },
                { "level1/level2/level3/file3.txt", 3 * MB }
            };
            
            CreateLocalTestDirectoryWithStructure(uploadPath, nestedFiles);

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(nestedFiles.Count, response.ObjectsUploaded);
            Assert.AreEqual(0, response.ObjectsFailed);
            
            // Verify S3 keys have proper structure
            foreach (var kvp in nestedFiles)
            {
                var expectedKey = keyPrefix + "/" + kvp.Key.Replace('\\', '/');
                await VerifyObjectExistsInS3(expectedKey, kvp.Value);
            }
        }

        #endregion

        #region Concurrent vs Sequential Tests

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_ConcurrentMode_UploadsAllFiles()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("concurrent-upload");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            var fileCount = 10;
            
            CreateLocalTestDirectory(uploadPath, 2 * MB, fileCount);

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = true
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(fileCount, response.ObjectsUploaded);
            Assert.AreEqual(0, response.ObjectsFailed);
            
            await VerifyObjectsInS3(keyPrefix, fileCount);
        }

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_SequentialMode_UploadsAllFiles()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("sequential-upload");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            var fileCount = 5;
            
            CreateLocalTestDirectory(uploadPath, 3 * MB, fileCount);

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
                UploadFilesConcurrently = false
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(fileCount, response.ObjectsUploaded);
            Assert.AreEqual(0, response.ObjectsFailed);
            
            await VerifyObjectsInS3(keyPrefix, fileCount);
        }

        #endregion

        #region Mixed File Size Tests

        [TestMethod]
        [TestCategory("UploadDirectory")]
        public async Task UploadDirectoryWithResponse_MixedFileSizes_UploadsAll()
        {
            // Arrange
            var keyPrefix = UtilityMethods.GenerateName("mixed-sizes");
            var uploadPath = Path.Combine(tempDirectory, keyPrefix + "-upload");
            
            var mixedFiles = new Dictionary<string, long>
            {
                { "tiny.txt", 100 },                // 100 bytes
                { "small.txt", 512 * KB },          // 512 KB
                { "medium.txt", 5 * MB },           // 5 MB
                { "large.txt", 20 * MB }            // 20 MB (multipart)
            };
            
            CreateLocalTestDirectoryWithStructure(uploadPath, mixedFiles);

            // Act
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = uploadPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            
            var response = await transferUtility.UploadDirectoryWithResponseAsync(request);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(mixedFiles.Count, response.ObjectsUploaded);
            Assert.AreEqual(0, response.ObjectsFailed);
            
            // Verify each file's size in S3
            foreach (var kvp in mixedFiles)
            {
                var s3Key = keyPrefix + "/" + kvp.Key;
                await VerifyObjectExistsInS3(s3Key, kvp.Value);
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Creates a local test directory with specified number of files.
        /// </summary>
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

        /// <summary>
        /// Creates a local test directory with specific file structure.
        /// </summary>
        private static void CreateLocalTestDirectoryWithStructure(string directoryPath, Dictionary<string, long> files)
        {
            foreach (var kvp in files)
            {
                var filePath = Path.Combine(directoryPath, kvp.Key.Replace('/', Path.DirectorySeparatorChar));
                var directory = Path.GetDirectoryName(filePath);
                
                if (!string.IsNullOrEmpty(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                
                UtilityMethods.GenerateFile(filePath, kvp.Value);
            }
        }

        /// <summary>
        /// Verifies that the expected number of objects exist in S3 under the given prefix.
        /// </summary>
        private static async Task VerifyObjectsInS3(string keyPrefix, int expectedCount)
        {
            var listRequest = new ListObjectsV2Request
            {
                BucketName = bucketName,
                Prefix = keyPrefix + "/"
            };
            
            var listResponse = await Client.ListObjectsV2Async(listRequest);
            
            // Filter out directory markers
            var actualObjects = listResponse.S3Objects
                .Where(s3o => !s3o.Key.EndsWith("/", StringComparison.Ordinal))
                .ToList();
            
            Assert.AreEqual(expectedCount, actualObjects.Count, 
                $"Expected {expectedCount} objects in S3 under prefix '{keyPrefix}', found {actualObjects.Count}");
        }

        /// <summary>
        /// Verifies that the expected number of objects exist in S3 with the specified size.
        /// </summary>
        private static async Task VerifyObjectsInS3WithSize(string keyPrefix, int expectedCount, long expectedSize)
        {
            var listRequest = new ListObjectsV2Request
            {
                BucketName = bucketName,
                Prefix = keyPrefix + "/"
            };
            
            var listResponse = await Client.ListObjectsV2Async(listRequest);
            
            var actualObjects = listResponse.S3Objects
                .Where(s3o => !s3o.Key.EndsWith("/", StringComparison.Ordinal))
                .ToList();
            
            Assert.AreEqual(expectedCount, actualObjects.Count);
            
            foreach (var s3Object in actualObjects)
            {
                Assert.AreEqual(expectedSize, s3Object.Size, 
                    $"Object {s3Object.Key} should be {expectedSize} bytes");
            }
        }

        /// <summary>
        /// Verifies that a specific object exists in S3 with the expected size.
        /// </summary>
        private static async Task VerifyObjectExistsInS3(string key, long expectedSize)
        {
            var getRequest = new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            };
            
            var metadata = await Client.GetObjectMetadataAsync(getRequest);
            
            Assert.IsNotNull(metadata, $"Object should exist in S3: {key}");
            Assert.AreEqual(expectedSize, metadata.ContentLength, 
                $"Object {key} should be {expectedSize} bytes");
        }

        #endregion
    }
}
