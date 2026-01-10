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
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for TransferUtility.DownloadWithResponseAsync functionality.
    /// These tests verify end-to-end functionality with actual S3 operations and file I/O.
    /// 
    /// Most test scenarios (buffer sizes, part boundaries, error handling) are covered 
    /// in unit tests with mocked dependencies for faster execution.
    /// 
    /// These integration tests focus on:
    /// - Basic single-part downloads to files
    /// - Basic multipart downloads to files
    /// - Real S3 metadata preservation
    /// - File handling (temp files, atomic writes, cleanup)
    /// - Checksum validation
    /// </summary>
    [TestClass]
    public class TransferUtilityDownloadWithResponseTests : TestBase<AmazonS3Client>
    {
        private static readonly long MB = 1024 * 1024;
        private static string bucketName;
        private static string tempDirectory;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            tempDirectory = Path.Combine(Path.GetTempPath(), "S3DownloadTests-" + Guid.NewGuid().ToString());
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
            // Clean up any test files after each test
            if (Directory.Exists(tempDirectory))
            {
                foreach (var file in Directory.GetFiles(tempDirectory))
                {
                    try
                    {
                        File.Delete(file);
                    }
                    catch
                    {
                        // Best effort cleanup
                    }
                }
            }
        }

        #region Single-Part Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        public async Task DownloadWithResponse_SinglePart_SmallObject()
        {
            // Arrange
            var objectSize = 2 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);
            var downloadPath = Path.Combine(tempDirectory, key);

            // Act
            var transferUtility = new TransferUtility(Client);
            var response = await transferUtility.DownloadWithResponseAsync(downloadPath, bucketName, key);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            ValidateResponse(response, objectSize);
            
            // Verify file was written
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.AreEqual(expectedChecksum, downloadedChecksum, "Downloaded data checksum should match");
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.AreEqual(objectSize, fileInfo.Length, "Downloaded file size should match");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        public async Task DownloadWithResponse_SinglePart_EmptyObject()
        {
            // Arrange
            var key = UtilityMethods.GenerateName("empty-object");
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = ""
            });
            var downloadPath = Path.Combine(tempDirectory, key);

            // Act
            var transferUtility = new TransferUtility(Client);
            var response = await transferUtility.DownloadWithResponseAsync(downloadPath, bucketName, key);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            Assert.AreEqual(0, response.Headers.ContentLength, "Content length should be 0");
            
            // Verify ContentRange is null for 0-byte objects (matches S3 behavior)
            Assert.IsNull(response.ContentRange, 
                "ContentRange should be null for 0-byte objects (matching S3 behavior)");
            
            // Verify empty file was written
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            var fileInfo = new FileInfo(downloadPath);
            Assert.AreEqual(0, fileInfo.Length, "Downloaded file should be empty");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
        }

        #endregion

        #region Multipart Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        [TestCategory("Multipart")]
        public async Task DownloadWithResponse_Multipart_BasicDownload()
        {
            // Arrange - Simple multipart download to verify end-to-end S3 integration
            var objectSize = 20 * MB;
            var partSize = 8 * MB;
            var key = UtilityMethods.GenerateName("multipart-download-test");
            var uploadPath = Path.Combine(Path.GetTempPath(), key + "-upload");
            var downloadPath = Path.Combine(tempDirectory, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(uploadPath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = uploadPath,
                PartSize = partSize
            };
            
            var transferUtility = new TransferUtility(Client);
            await transferUtility.UploadAsync(uploadRequest);

            // Verify object is multipart by checking PartsCount
            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart to test multipart download");

            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = downloadPath,
                PartSize = partSize
            };

            // Act
            var response = await transferUtility.DownloadWithResponseAsync(downloadRequest);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            ValidateResponse(response, objectSize);
            
            // Verify file was written correctly
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.AreEqual(expectedChecksum, downloadedChecksum, "Downloaded data checksum should match");
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.AreEqual(objectSize, fileInfo.Length, "Downloaded file size should match");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
            
            // Cleanup upload file
            File.Delete(uploadPath);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        public async Task DownloadWithResponse_RangeStrategy_SmallSinglePartObject()
        {
            // Arrange - Small object that fits in single part, but using RANGE strategy
            // This tests that ContentRange header is present even for single-part downloads
            // when using RANGE strategy (S3 includes ContentRange when Range header is sent)
            var objectSize = 2 * MB; // Less than default 8MB part size
            var key = UtilityMethods.GenerateName("range-single-part-test");
            var uploadPath = Path.Combine(Path.GetTempPath(), key + "-upload");
            var downloadPath = Path.Combine(tempDirectory, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(uploadPath);
            
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = uploadPath
            });

            // Act - Download with RANGE strategy even though only 1 part needed
            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = downloadPath,
                MultipartDownloadType = MultipartDownloadType.RANGE,
                PartSize = 8 * MB  // Larger than file, so only 1 part needed
            };

            var transferUtility = new TransferUtility(Client);
            var response = await transferUtility.DownloadWithResponseAsync(downloadRequest);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            ValidateResponse(response, objectSize);
            
            // Verify ContentRange is present (because RANGE strategy uses Range headers)
            Assert.IsNotNull(response.ContentRange, 
                "ContentRange should be present when using RANGE strategy, even for single-part downloads");
            Assert.IsTrue(response.ContentRange.StartsWith("bytes "), 
                "ContentRange should have correct format");
            
            // Verify file was written correctly
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.AreEqual(expectedChecksum, downloadedChecksum, 
                "Downloaded data checksum should match (RANGE strategy, single part)");
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.AreEqual(objectSize, fileInfo.Length, 
                "Downloaded file size should match (RANGE strategy, single part)");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
            
            // Cleanup upload file
            File.Delete(uploadPath);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        [TestCategory("Multipart")]
        public async Task DownloadWithResponse_Multipart_RangeDownload()
        {
            // Arrange - Test RANGE-based multipart download with custom part size
            var objectSize = 20 * MB;
            var uploadPartSize = 8 * MB;  // Upload with 8MB parts
            var downloadPartSize = 6 * MB;  // Download with different 6MB parts
            var key = UtilityMethods.GenerateName("multipart-range-test");
            var uploadPath = Path.Combine(Path.GetTempPath(), key + "-upload");
            var downloadPath = Path.Combine(tempDirectory, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(uploadPath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = uploadPath,
                PartSize = uploadPartSize
            };
            
            var transferUtility = new TransferUtility(Client);
            await transferUtility.UploadAsync(uploadRequest);

            // Verify object is multipart
            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart to test multipart download");

            // Act - Download using RANGE strategy with different part size
            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = downloadPath,
                MultipartDownloadType = MultipartDownloadType.RANGE,
                PartSize = downloadPartSize
            };

            var response = await transferUtility.DownloadWithResponseAsync(downloadRequest);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            ValidateResponse(response, objectSize);
            
            // Verify file was written correctly
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.AreEqual(expectedChecksum, downloadedChecksum, 
                "Downloaded data checksum should match (RANGE strategy)");
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.AreEqual(objectSize, fileInfo.Length, 
                "Downloaded file size should match (RANGE strategy)");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
            
            // Cleanup upload file
            File.Delete(uploadPath);
        }

        #endregion

        #region Checksum Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        [TestCategory("Checksum")]
        public async Task DownloadWithResponse_MultipartObjectWithChecksums_NullsCompositeChecksums()
        {
            // Arrange - Upload a multipart object with checksums
            var objectSize = 20 * MB;
            var key = UtilityMethods.GenerateName("composite-checksum-test");
            var uploadPath = Path.Combine(Path.GetTempPath(), key + "-upload");
            var downloadPath = Path.Combine(tempDirectory, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);

            // Upload with checksum algorithm to create composite checksum
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = uploadPath,
                ChecksumAlgorithm = ChecksumAlgorithm.CRC32,
                PartSize = 8 * MB
            };

            var uploadUtility = new TransferUtility(Client);
            await uploadUtility.UploadAsync(uploadRequest);

            // Verify object is multipart by checking PartsCount
            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart to test composite checksums");

            // Act - Download with ChecksumMode enabled
            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = downloadPath,
                ChecksumMode = ChecksumMode.ENABLED
            };

            var response = await uploadUtility.DownloadWithResponseAsync(downloadRequest);

            // Assert - Verify ChecksumType is COMPOSITE
            Assert.AreEqual(ChecksumType.COMPOSITE, response.ChecksumType, 
                "ChecksumType should be COMPOSITE for multipart objects");

            // Per spec: "If ChecksumType is COMPOSITE, set all checksum value members to null 
            // as the checksum value returned from a part GET request is not the composite 
            // checksum for the entire object"
            Assert.IsNull(response.ChecksumCRC32, "ChecksumCRC32 should be null for composite checksums");
            Assert.IsNull(response.ChecksumCRC32C, "ChecksumCRC32C should be null for composite checksums");
            Assert.IsNull(response.ChecksumCRC64NVME, "ChecksumCRC64NVME should be null for composite checksums");
            Assert.IsNull(response.ChecksumSHA1, "ChecksumSHA1 should be null for composite checksums");
            Assert.IsNull(response.ChecksumSHA256, "ChecksumSHA256 should be null for composite checksums");

            // Verify other response properties are still populated correctly
            Assert.IsNotNull(response.ETag, "ETag should still be populated");
            Assert.IsTrue(response.Headers.ContentLength > 0, "ContentLength should be populated");
            
            // Verify file was written correctly
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            var fileInfo = new FileInfo(downloadPath);
            Assert.AreEqual(objectSize, fileInfo.Length, "Downloaded file size should match");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
            
            // Cleanup upload file
            File.Delete(uploadPath);
        }

        #endregion

        #region Metadata Validation Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        [TestCategory("Metadata")]
        public async Task DownloadWithResponse_PreservesMetadata()
        {
            // Arrange
            var objectSize = 10 * MB;
            var key = UtilityMethods.GenerateName("metadata-test");
            var uploadPath = Path.Combine(Path.GetTempPath(), key + "-upload");
            var downloadPath = Path.Combine(tempDirectory, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);

            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = uploadPath,
                ContentType = "application/octet-stream"
            };
            putRequest.Metadata.Add("test-key", "test-value");
            putRequest.Metadata.Add("custom-header", "custom-value");

            await Client.PutObjectAsync(putRequest);

            // Act
            var transferUtility = new TransferUtility(Client);
            var response = await transferUtility.DownloadWithResponseAsync(downloadPath, bucketName, key);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            Assert.AreEqual("application/octet-stream", response.Headers.ContentType);
            
            // S3 automatically prefixes user-defined metadata with "x-amz-meta-"
            Assert.IsTrue(response.Metadata.Keys.Contains("x-amz-meta-test-key"), 
                "Metadata should contain 'x-amz-meta-test-key'");
            Assert.AreEqual("test-value", response.Metadata["x-amz-meta-test-key"]);
            
            Assert.IsTrue(response.Metadata.Keys.Contains("x-amz-meta-custom-header"),
                "Metadata should contain 'x-amz-meta-custom-header'");
            Assert.AreEqual("custom-value", response.Metadata["x-amz-meta-custom-header"]);
            
            // Verify file was written
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
            
            // Cleanup upload file
            File.Delete(uploadPath);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        [TestCategory("Metadata")]
        public async Task DownloadWithResponse_PreservesETag()
        {
            // Arrange
            var objectSize = 15 * MB;
            var key = UtilityMethods.GenerateName("etag-test");
            var uploadPath = Path.Combine(Path.GetTempPath(), key + "-upload");
            var downloadPath = Path.Combine(tempDirectory, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = uploadPath
            });

            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });
            var expectedETag = metadata.ETag;

            // Act
            var transferUtility = new TransferUtility(Client);
            var response = await transferUtility.DownloadWithResponseAsync(downloadPath, bucketName, key);

            // Assert
            Assert.IsNotNull(response.ETag, "ETag should not be null");
            Assert.AreEqual(expectedETag, response.ETag, "ETag should match");
            
            // Verify file was written
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
            
            // Cleanup upload file
            File.Delete(uploadPath);
        }

        #endregion

        #region File Handling Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        [TestCategory("FileHandling")]
        public async Task DownloadWithResponse_CreatesDirectoryIfNeeded()
        {
            // Arrange
            var objectSize = 5 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);
            
            // Create a nested directory path that doesn't exist
            var nestedDir = Path.Combine(tempDirectory, "level1", "level2", "level3");
            var downloadPath = Path.Combine(nestedDir, key);
            
            Assert.IsFalse(Directory.Exists(nestedDir), "Nested directory should not exist initially");

            // Act
            var transferUtility = new TransferUtility(Client);
            var response = await transferUtility.DownloadWithResponseAsync(downloadPath, bucketName, key);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            Assert.IsTrue(Directory.Exists(nestedDir), "Nested directory should be created");
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist in nested directory");
            
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.AreEqual(expectedChecksum, downloadedChecksum, "Downloaded data checksum should match");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("Download")]
        [TestCategory("FileHandling")]
        public async Task DownloadWithResponse_OverwritesExistingFile()
        {
            // Arrange
            var objectSize = 5 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);
            var downloadPath = Path.Combine(tempDirectory, key);
            
            // Create an existing file with different content
            var existingContent = new byte[1024];
            new Random().NextBytes(existingContent);
            File.WriteAllBytes(downloadPath, existingContent);
            
            var existingChecksum = CalculateFileChecksum(downloadPath);
            Assert.AreNotEqual(expectedChecksum, existingChecksum, "Existing file should have different content");

            // Act
            var transferUtility = new TransferUtility(Client);
            var response = await transferUtility.DownloadWithResponseAsync(downloadPath, bucketName, key);

            // Assert
            Assert.IsNotNull(response, "Response should not be null");
            Assert.IsTrue(File.Exists(downloadPath), "Downloaded file should exist");
            
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.AreEqual(expectedChecksum, downloadedChecksum, "Downloaded file should have new content");
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.AreEqual(objectSize, fileInfo.Length, "Downloaded file size should match new content");
            
            // Verify no temp files remain
            VerifyNoTempFilesExist(downloadPath);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Creates a test object in S3 with the specified size and returns its key and checksum.
        /// </summary>
        private static async Task<(string key, string checksum)> CreateTestObjectWithChecksum(long objectSize)
        {
            var key = UtilityMethods.GenerateName("download-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            // Calculate checksum before upload
            var checksum = CalculateFileChecksum(filePath);
            
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            });
            
            // Cleanup temp upload file
            File.Delete(filePath);
            
            return (key, checksum);
        }

        /// <summary>
        /// Calculates the MD5 checksum of a file.
        /// </summary>
        private static string CalculateFileChecksum(string filePath)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            using (var stream = File.OpenRead(filePath))
            {
                var hash = md5.ComputeHash(stream);
                return Convert.ToBase64String(hash);
            }
        }

        /// <summary>
        /// Validates that the response contains expected values.
        /// </summary>
        private static void ValidateResponse(TransferUtilityDownloadResponse response, long expectedSize)
        {
            Assert.IsNotNull(response.Headers, "Headers should not be null");
            Assert.AreEqual(expectedSize, response.Headers.ContentLength, "Content length should match");
            Assert.IsNotNull(response.ETag, "ETag should not be null");
        }

        /// <summary>
        /// Verifies that no temporary files remain after download completion.
        /// Temp files use the pattern: {originalPath}.s3tmp.{8-char-id}
        /// </summary>
        private static void VerifyNoTempFilesExist(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            var fileName = Path.GetFileName(filePath);
            
            if (Directory.Exists(directory))
            {
                var tempFiles = Directory.GetFiles(directory, fileName + ".s3tmp.*");
                Assert.AreEqual(0, tempFiles.Length, 
                    $"No temporary files should remain. Found: {string.Join(", ", tempFiles)}");
            }
        }

        #endregion
    }
}
