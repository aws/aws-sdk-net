// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Amazon.S3;
// using Amazon.S3.Model;
// using Amazon.S3.Transfer;
// using Amazon.S3.Util;
// using AWSSDK_DotNet.IntegrationTests.Utils;

// namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
// {
//     /// <summary>
//     /// Integration tests for TransferUtility.DownloadDirectoryWithResponseAsync functionality.
//     /// These tests verify end-to-end functionality with actual S3 operations and directory I/O.
//     /// 
//     /// These integration tests focus on:
//     /// - Basic directory downloads with response object
//     /// - Progress tracking with response
//     /// - Multipart downloads in directory context
//     /// - Concurrent vs sequential downloads
//     /// - Nested directory structures
//     /// - Response validation
//     /// </summary>
//     [TestClass]
//     public class TransferUtilityDownloadDirectoryWithResponseTests : TestBase<AmazonS3Client>
//     {
//         private static readonly long MB = 1024 * 1024;
//         private static readonly long KB = 1024;
//         private static string bucketName;
//         private static string tempDirectory;

//         [ClassInitialize()]
//         public static void ClassInitialize(TestContext testContext)
//         {
//             bucketName = S3TestUtils.CreateBucketWithWait(Client);
//             tempDirectory = Path.Combine(Path.GetTempPath(), "S3DownloadDirectoryTests-" + Guid.NewGuid().ToString());
//             Directory.CreateDirectory(tempDirectory);
//         }

//         [ClassCleanup]
//         public static void ClassCleanup()
//         {
//             AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            
//             // Clean up temp directory
//             if (Directory.Exists(tempDirectory))
//             {
//                 try
//                 {
//                     Directory.Delete(tempDirectory, recursive: true);
//                 }
//                 catch
//                 {
//                     // Best effort cleanup
//                 }
//             }
            
//             BaseClean();
//         }

//         [TestCleanup]
//         public void TestCleanup()
//         {
//             // Clean up any test directories after each test
//             if (Directory.Exists(tempDirectory))
//             {
//                 foreach (var subDir in Directory.GetDirectories(tempDirectory))
//                 {
//                     try
//                     {
//                         Directory.Delete(subDir, recursive: true);
//                     }
//                     catch
//                     {
//                         // Best effort cleanup
//                     }
//                 }
//             }
//         }

//         #region Basic Download Tests

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_BasicDownload_ReturnsCorrectResponse()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("basic-download");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
//             var fileCount = 5;
            
//             // Upload test directory
//             await UploadTestDirectory(keyPrefix, 2 * MB, fileCount);

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response, "Response should not be null");
//             Assert.AreEqual(fileCount, response.ObjectsDownloaded, "ObjectsDownloaded should match file count");
            
//             // Verify all files were downloaded
//             var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
//             Assert.AreEqual(fileCount, downloadedFiles.Length, "Downloaded file count should match");
            
//             // Verify no temp files remain
//             VerifyNoTempFilesExist(downloadPath);
//         }

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_EmptyDirectory_ReturnsZeroObjectsDownloaded()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("empty-directory");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");

//             // Act - Download non-existent directory
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response, "Response should not be null");
//             Assert.AreEqual(0, response.ObjectsDownloaded, "ObjectsDownloaded should be 0 for empty directory");
            
//             // Directory may or may not exist, but should have no files
//             if (Directory.Exists(downloadPath))
//             {
//                 var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
//                 Assert.AreEqual(0, downloadedFiles.Length, "No files should be downloaded");
//             }
//         }

//         #endregion

//         #region Progress Tracking Tests

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_WithProgressTracking_FiresProgressEvents()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("progress-tracking");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
//             var fileCount = 3;
            
//             await UploadTestDirectory(keyPrefix, 5 * MB, fileCount);

//             var progressEvents = new List<DownloadDirectoryProgressArgs>();
//             var progressLock = new object();

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath
//             };
            
//             request.DownloadedDirectoryProgressEvent += (sender, args) =>
//             {
//                 lock (progressLock)
//                 {
//                     progressEvents.Add(args);
//                 }
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response, "Response should not be null");
//             Assert.AreEqual(fileCount, response.ObjectsDownloaded);
//             Assert.IsTrue(progressEvents.Count > 0, "Progress events should have fired");
            
//             // Verify final progress event
//             var finalEvent = progressEvents.Last();
//             Assert.AreEqual(fileCount, finalEvent.NumberOfFilesDownloaded);
//             Assert.AreEqual(fileCount, finalEvent.TotalNumberOfFiles);
//             Assert.AreEqual(finalEvent.TransferredBytes, finalEvent.TotalBytes);
//         }

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_SequentialMode_IncludesCurrentFileDetails()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("sequential-progress");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
            
//             await UploadTestDirectory(keyPrefix, 3 * MB, 3);

//             var progressEvents = new List<DownloadDirectoryProgressArgs>();

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath,
//                 DownloadFilesConcurrently = false // Sequential mode
//             };
            
//             request.DownloadedDirectoryProgressEvent += (sender, args) =>
//             {
//                 progressEvents.Add(args);
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response);
//             Assert.AreEqual(3, response.ObjectsDownloaded);
            
//             // In sequential mode, should have CurrentFile populated
//             var eventsWithFile = progressEvents.Where(e => e.CurrentFile != null).ToList();
//             Assert.IsTrue(eventsWithFile.Count > 0, "Should have events with CurrentFile populated");
            
//             foreach (var evt in eventsWithFile)
//             {
//                 Assert.IsNotNull(evt.CurrentFile);
//                 Assert.IsTrue(evt.TotalNumberOfBytesForCurrentFile > 0);
//             }
//         }

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_ConcurrentMode_OmitsCurrentFileDetails()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("concurrent-progress");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
            
//             await UploadTestDirectory(keyPrefix, 3 * MB, 4);

//             var progressEvents = new List<DownloadDirectoryProgressArgs>();
//             var progressLock = new object();

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath,
//                 DownloadFilesConcurrently = true // Concurrent mode
//             };
            
//             request.DownloadedDirectoryProgressEvent += (sender, args) =>
//             {
//                 lock (progressLock)
//                 {
//                     progressEvents.Add(args);
//                 }
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response);
//             Assert.AreEqual(4, response.ObjectsDownloaded);
//             Assert.IsTrue(progressEvents.Count > 0);
            
//             // In concurrent mode, CurrentFile should be null
//             foreach (var evt in progressEvents)
//             {
//                 Assert.IsNull(evt.CurrentFile, "CurrentFile should be null in concurrent mode");
//                 Assert.AreEqual(0, evt.TransferredBytesForCurrentFile);
//                 Assert.AreEqual(0, evt.TotalNumberOfBytesForCurrentFile);
//             }
//         }

//         #endregion

//         #region Multipart Download Tests

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         [TestCategory("Multipart")]
//         public async Task DownloadDirectoryWithResponse_WithMultipartFiles_DownloadsSuccessfully()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("multipart-directory");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
//             var fileCount = 3;
            
//             // Upload directory with large files to trigger multipart (>16MB threshold)
//             await UploadTestDirectory(keyPrefix, 20 * MB, fileCount);

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response);
//             Assert.AreEqual(fileCount, response.ObjectsDownloaded);
            
//             // Verify all files downloaded with correct sizes
//             var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
//             Assert.AreEqual(fileCount, downloadedFiles.Length);
            
//             foreach (var file in downloadedFiles)
//             {
//                 var fileInfo = new FileInfo(file);
//                 Assert.AreEqual(20 * MB, fileInfo.Length, $"File {file} should be 20MB");
//             }
            
//             VerifyNoTempFilesExist(downloadPath);
//         }

//         #endregion

//         #region Nested Directory Tests

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_NestedDirectories_PreservesStructure()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("nested-structure");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
            
//             // Upload nested directory structure
//             var nestedFiles = new Dictionary<string, long>
//             {
//                 { "level1/file1.txt", 1 * MB },
//                 { "level1/level2/file2.txt", 2 * MB },
//                 { "level1/level2/level3/file3.txt", 3 * MB }
//             };
            
//             await UploadTestFilesWithStructure(keyPrefix, nestedFiles);

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response);
//             Assert.AreEqual(nestedFiles.Count, response.ObjectsDownloaded);
            
//             // Verify directory structure
//             foreach (var kvp in nestedFiles)
//             {
//                 var expectedPath = Path.Combine(downloadPath, kvp.Key.Replace('/', Path.DirectorySeparatorChar));
//                 Assert.IsTrue(File.Exists(expectedPath), $"File should exist: {expectedPath}");
                
//                 var fileInfo = new FileInfo(expectedPath);
//                 Assert.AreEqual(kvp.Value, fileInfo.Length, $"File size should match: {expectedPath}");
//             }
//         }

//         #endregion

//         #region Concurrent vs Sequential Tests

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_ConcurrentMode_DownloadsAllFiles()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("concurrent-download");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
//             var fileCount = 10;
            
//             await UploadTestDirectory(keyPrefix, 2 * MB, fileCount);

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath,
//                 DownloadFilesConcurrently = true
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response);
//             Assert.AreEqual(fileCount, response.ObjectsDownloaded);
            
//             var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
//             Assert.AreEqual(fileCount, downloadedFiles.Length);
//         }

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_SequentialMode_DownloadsAllFiles()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("sequential-download");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
//             var fileCount = 5;
            
//             await UploadTestDirectory(keyPrefix, 3 * MB, fileCount);

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath,
//                 DownloadFilesConcurrently = false
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response);
//             Assert.AreEqual(fileCount, response.ObjectsDownloaded);
            
//             var downloadedFiles = Directory.GetFiles(downloadPath, "*", SearchOption.AllDirectories);
//             Assert.AreEqual(fileCount, downloadedFiles.Length);
//         }

//         #endregion

//         #region Mixed File Size Tests

//         [TestMethod]
//         [TestCategory("S3")]
//         [TestCategory("DownloadDirectory")]
//         public async Task DownloadDirectoryWithResponse_MixedFileSizes_DownloadsAll()
//         {
//             // Arrange
//             var keyPrefix = UtilityMethods.GenerateName("mixed-sizes");
//             var downloadPath = Path.Combine(tempDirectory, keyPrefix + "-download");
            
//             var mixedFiles = new Dictionary<string, long>
//             {
//                 { "tiny.txt", 100 },                // 100 bytes
//                 { "small.txt", 512 * KB },          // 512 KB
//                 { "medium.txt", 5 * MB },           // 5 MB
//                 { "large.txt", 20 * MB }            // 20 MB (multipart)
//             };
            
//             await UploadTestFilesWithStructure(keyPrefix, mixedFiles);

//             // Act
//             var transferUtility = new TransferUtility(Client);
//             var request = new TransferUtilityDownloadDirectoryRequest
//             {
//                 BucketName = bucketName,
//                 S3Directory = keyPrefix,
//                 LocalDirectory = downloadPath
//             };
            
//             var response = await transferUtility.DownloadDirectoryWithResponseAsync(request);

//             // Assert
//             Assert.IsNotNull(response);
//             Assert.AreEqual(mixedFiles.Count, response.ObjectsDownloaded);
            
//             // Verify each file's size
//             foreach (var kvp in mixedFiles)
//             {
//                 var filePath = Path.Combine(downloadPath, kvp.Key);
//                 Assert.IsTrue(File.Exists(filePath), $"File should exist: {filePath}");
                
//                 var fileInfo = new FileInfo(filePath);
//                 Assert.AreEqual(kvp.Value, fileInfo.Length, $"File size should match: {filePath}");
//             }
//         }

//         #endregion

//         #region Helper Methods

//         /// <summary>
//         /// Uploads a test directory with specified number of files using TransferUtility.UploadDirectory
//         /// </summary>
//         private static async Task UploadTestDirectory(string keyPrefix, long fileSize, int fileCount)
//         {
//             // Create local temp directory structure
//             var tempUploadDir = Path.Combine(Path.GetTempPath(), "upload-" + Guid.NewGuid().ToString());
//             Directory.CreateDirectory(tempUploadDir);
            
//             try
//             {
//                 // Generate files locally
//                 for (int i = 0; i < fileCount; i++)
//                 {
//                     var fileName = $"file{i}.dat";
//                     var localPath = Path.Combine(tempUploadDir, fileName);
//                     UtilityMethods.GenerateFile(localPath, fileSize);
//                 }
                
//                 // Upload entire directory using TransferUtility
//                 var transferUtility = new TransferUtility(Client);
//                 var request = new TransferUtilityUploadDirectoryRequest
//                 {
//                     BucketName = bucketName,
//                     Directory = tempUploadDir,
//                     KeyPrefix = keyPrefix,
//                     SearchPattern = "*.dat",  // Only match test data files, not system files
//                     SearchOption = SearchOption.AllDirectories
//                 };
                
//                 await transferUtility.UploadDirectoryAsync(request);
//             }
//             finally
//             {
//                 // Cleanup temp directory
//                 if (Directory.Exists(tempUploadDir))
//                 {
//                     try
//                     {
//                         Directory.Delete(tempUploadDir, recursive: true);
//                     }
//                     catch
//                     {
//                         // Best effort cleanup
//                     }
//                 }
//             }
//         }

//         /// <summary>
//         /// Uploads test files with specific structure using TransferUtility.UploadDirectory
//         /// </summary>
//         private static async Task UploadTestFilesWithStructure(string keyPrefix, Dictionary<string, long> files)
//         {
//             // Create local temp directory structure
//             var tempUploadDir = Path.Combine(Path.GetTempPath(), "upload-struct-" + Guid.NewGuid().ToString());
            
//             try
//             {
//                 // Generate files with directory structure locally
//                 foreach (var kvp in files)
//                 {
//                     var localPath = Path.Combine(tempUploadDir, kvp.Key.Replace('/', Path.DirectorySeparatorChar));
//                     var directory = Path.GetDirectoryName(localPath);
                    
//                     if (!string.IsNullOrEmpty(directory))
//                     {
//                         Directory.CreateDirectory(directory);
//                     }
                    
//                     UtilityMethods.GenerateFile(localPath, kvp.Value);
//                 }
                
//                 // Upload entire directory using TransferUtility
//                 var transferUtility = new TransferUtility(Client);
//                 var request = new TransferUtilityUploadDirectoryRequest
//                 {
//                     BucketName = bucketName,
//                     Directory = tempUploadDir,
//                     KeyPrefix = keyPrefix,
//                     SearchPattern = "*",
//                     SearchOption = SearchOption.AllDirectories
//                 };
                
//                 await transferUtility.UploadDirectoryAsync(request);
//             }
//             finally
//             {
//                 // Cleanup temp directory
//                 if (Directory.Exists(tempUploadDir))
//                 {
//                     try
//                     {
//                         Directory.Delete(tempUploadDir, recursive: true);
//                     }
//                     catch
//                     {
//                         // Best effort cleanup
//                     }
//                 }
//             }
//         }

//         /// <summary>
//         /// Verifies that no temporary files remain after download completion.
//         /// Temp files use the pattern: {originalPath}.s3tmp.{8-char-id}
//         /// </summary>
//         private static void VerifyNoTempFilesExist(string directoryPath)
//         {
//             if (Directory.Exists(directoryPath))
//             {
//                 var tempFiles = Directory.GetFiles(directoryPath, "*.s3tmp.*", SearchOption.AllDirectories);
//                 Assert.AreEqual(0, tempFiles.Length, 
//                     $"No temporary files should remain. Found: {string.Join(", ", tempFiles)}");
//             }
//         }

//         #endregion
//     }
// }
