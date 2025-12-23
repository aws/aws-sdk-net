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
    /// Integration tests for TransferUtility.OpenStreamWithResponse functionality.
    /// These tests verify end-to-end functionality with actual S3 operations.
    /// 
    /// Most test scenarios (buffer sizes, part boundaries, stream behavior) are covered 
    /// in BufferedMultipartStreamTests.cs with mocked dependencies for faster execution.
    /// 
    /// These integration tests focus on:
    /// - Basic single-part downloads
    /// - Basic multipart downloads
    /// - Real S3 metadata preservation
    /// </summary>
    [TestClass]
    public class TransferUtilityOpenStreamTests : TestBase<AmazonS3Client>
    {
        private static readonly long MB = 1024 * 1024;
        private static string bucketName;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        #region Single-Part Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        public async Task OpenStream_SinglePart_SmallObject()
        {
            // Arrange
            var objectSize = 2 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);

            // Act
            var transferUtility = new TransferUtility(Client);
            using (var response = await transferUtility.OpenStreamWithResponseAsync(bucketName, key))
            {
                // Assert
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseStream);
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(1 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, "Downloaded data checksum should match");
                Assert.AreEqual(objectSize, downloadedBytes.Length, "Downloaded size should match");
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        public async Task OpenStream_SinglePart_EmptyObject()
        {
            // Arrange
            var key = UtilityMethods.GenerateName("empty-object");
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = ""
            });

            // Act
            var transferUtility = new TransferUtility(Client);
            using (var response = await transferUtility.OpenStreamWithResponseAsync(bucketName, key))
            {
                // Assert
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseStream);
                Assert.AreEqual(0, response.Headers.ContentLength);
                
                var buffer = new byte[1024];
                var bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);
                Assert.AreEqual(0, bytesRead, "Should read 0 bytes from empty object");
            }
        }

        #endregion

        #region Multipart Test

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Multipart")]
        public async Task OpenStream_Multipart_BasicDownload()
        {
            // Arrange - Simple multipart download to verify end-to-end S3 integration
            var objectSize = 20 * MB;
            var partSize = 8 * MB;
            var key = UtilityMethods.GenerateName("openstream-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
                PartSize = partSize  // Force multipart upload with explicit part size
            };
            
            var transferUtility = new TransferUtility(Client);
            await transferUtility.UploadAsync(uploadRequest);

            // Verify object is multipart by checking PartsCount
            // Note: PartsCount is only returned when PartNumber is specified in the request
            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart to test multipart download");

            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                PartSize = partSize
            };

            // Act
            using (var response = await transferUtility.OpenStreamWithResponseAsync(request))
            {
                // Assert
                Assert.IsNotNull(response, "Response should not be null");
                Assert.IsNotNull(response.ResponseStream, "ResponseStream should not be null");
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, "Downloaded data checksum should match");
                Assert.AreEqual(objectSize, downloadedBytes.Length, "Downloaded size should match");
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Multipart")]
        public async Task OpenStream_Multipart_RangeDownload()
        {
            // Arrange - Test RANGE-based multipart download with custom part size
            var objectSize = 20 * MB;
            var uploadPartSize = 8 * MB;  // Upload with 8MB parts
            var downloadPartSize = 6 * MB;  // Download with different 6MB parts to test RANGE strategy
            var key = UtilityMethods.GenerateName("openstream-range-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
                PartSize = uploadPartSize  // Force multipart upload
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
            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                MultipartDownloadType = MultipartDownloadType.RANGE,
                PartSize = downloadPartSize  // Use different part size than upload
            };

            using (var response = await transferUtility.OpenStreamWithResponseAsync(request))
            {
                // Assert
                Assert.IsNotNull(response, "Response should not be null");
                Assert.IsNotNull(response.ResponseStream, "ResponseStream should not be null");
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, 
                    "Downloaded data checksum should match (RANGE strategy)");
                Assert.AreEqual(objectSize, downloadedBytes.Length, 
                    "Downloaded size should match (RANGE strategy)");
            }
        }

        #endregion

        #region Checksum Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Checksum")]
        public async Task OpenStream_MultipartObjectWithChecksums_NullsCompositeChecksums()
        {
            // Arrange - Upload a multipart object with checksums
            // Object must be > 16MB to trigger multipart upload with checksums
            var objectSize = 20 * MB;
            var key = UtilityMethods.GenerateName("composite-checksum-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);

            // Upload with checksum algorithm to create composite checksum
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
                ChecksumAlgorithm = ChecksumAlgorithm.CRC32,
                PartSize = 8 * MB
            };

            var uploadUtility = new TransferUtility(Client);
            await uploadUtility.UploadAsync(uploadRequest);

            // Verify object is multipart by checking PartsCount
            // Note: PartsCount is only returned when PartNumber is specified in the request
            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart to test composite checksums");

            // Act - Download with ChecksumMode enabled
            var openStreamRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                ChecksumMode = ChecksumMode.ENABLED
            };

            using (var response = await uploadUtility.OpenStreamWithResponseAsync(openStreamRequest))
            {
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
                Assert.IsNotNull(response.ResponseStream, "ResponseStream should be available");

                // Verify we can still read the stream
                var buffer = new byte[1024];
                var bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);
                Assert.IsTrue(bytesRead > 0, "Should be able to read from stream despite null checksums");
            }
        }

        #endregion

        #region Metadata Validation Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Metadata")]
        public async Task OpenStream_PreservesMetadata()
        {
            // Arrange
            var objectSize = 10 * MB;
            var key = UtilityMethods.GenerateName("metadata-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);

            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
                ContentType = "application/octet-stream"
            };
            putRequest.Metadata.Add("test-key", "test-value");
            putRequest.Metadata.Add("custom-header", "custom-value");

            await Client.PutObjectAsync(putRequest);

            // Act
            var transferUtility = new TransferUtility(Client);
            using (var response = await transferUtility.OpenStreamWithResponseAsync(bucketName, key))
            {
                // Assert
                Assert.IsNotNull(response);
                Assert.AreEqual("application/octet-stream", response.Headers.ContentType);
                
                // S3 automatically prefixes user-defined metadata with "x-amz-meta-"
                Assert.IsTrue(response.Metadata.Keys.Contains("x-amz-meta-test-key"), 
                    "Metadata should contain 'x-amz-meta-test-key'");
                Assert.AreEqual("test-value", response.Metadata["x-amz-meta-test-key"]);
                
                Assert.IsTrue(response.Metadata.Keys.Contains("x-amz-meta-custom-header"),
                    "Metadata should contain 'x-amz-meta-custom-header'");
                Assert.AreEqual("custom-value", response.Metadata["x-amz-meta-custom-header"]);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Metadata")]
        public async Task OpenStream_PreservesETag()
        {
            // Arrange
            var objectSize = 15 * MB;
            var key = UtilityMethods.GenerateName("etag-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);

            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            });

            var metadata = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key
            });
            var expectedETag = metadata.ETag;

            // Act
            var transferUtility = new TransferUtility(Client);
            using (var response = await transferUtility.OpenStreamWithResponseAsync(bucketName, key))
            {
                // Assert
                Assert.IsNotNull(response.ETag);
                Assert.AreEqual(expectedETag, response.ETag);
            }
        }

        #endregion

        #region MaxInMemoryParts Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("MaxInMemoryParts")]
        [TestCategory("Multipart")]
        public async Task OpenStream_WithCustomMaxInMemoryParts_DownloadsSuccessfully()
        {
            // Arrange - Upload as multipart to test MaxInMemoryParts buffering
            var objectSize = 32 * MB;
            var uploadPartSize = 8 * MB;  // Force multipart upload with 4 parts
            var downloadPartSize = 8 * MB;
            var maxInMemoryParts = 2;  // Only buffer 2 parts in memory at once
            var key = UtilityMethods.GenerateName("maxinmemory-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
                PartSize = uploadPartSize  // Force multipart upload
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
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart to test MaxInMemoryParts");

            var downloadRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                PartSize = downloadPartSize,
                MaxInMemoryParts = maxInMemoryParts
            };

            // Act
            using (var response = await transferUtility.OpenStreamWithResponseAsync(downloadRequest))
            {
                // Assert
                Assert.IsNotNull(response, "Response should not be null");
                Assert.IsNotNull(response.ResponseStream, "ResponseStream should not be null");
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, 
                    "Downloaded data checksum should match with custom MaxInMemoryParts");
                Assert.AreEqual(objectSize, downloadedBytes.Length, 
                    "Downloaded size should match with custom MaxInMemoryParts");
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("MaxInMemoryParts")]
        [TestCategory("Multipart")]
        public async Task OpenStream_WithDefaultMaxInMemoryParts_DownloadsSuccessfully()
        {
            // Arrange - Upload as multipart, download without specifying MaxInMemoryParts
            var objectSize = 24 * MB;
            var uploadPartSize = 8 * MB;
            var downloadPartSize = 8 * MB;
            var key = UtilityMethods.GenerateName("default-maxinmemory-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
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
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart");

            var downloadRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                PartSize = downloadPartSize
                // MaxInMemoryParts not specified - should use default (1024)
            };

            // Act
            using (var response = await transferUtility.OpenStreamWithResponseAsync(downloadRequest))
            {
                // Assert
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseStream);
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, 
                    "Downloaded data checksum should match with default MaxInMemoryParts");
                Assert.AreEqual(objectSize, downloadedBytes.Length, 
                    "Downloaded size should match with default MaxInMemoryParts");
            }
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("MaxInMemoryParts")]
        [TestCategory("Multipart")]
        [DataRow(1, DisplayName = "MaxInMemoryParts = 1 (minimal buffering)")]
        [DataRow(2, DisplayName = "MaxInMemoryParts = 2")]
        [DataRow(4, DisplayName = "MaxInMemoryParts = 4")]
        [DataRow(10, DisplayName = "MaxInMemoryParts = 10")]
        public async Task OpenStream_WithVariousMaxInMemoryParts_DownloadsSuccessfully(int maxInMemoryParts)
        {
            // Arrange - Upload as multipart, test various MaxInMemoryParts values
            var objectSize = 24 * MB;
            var uploadPartSize = 8 * MB;  // Creates 3 parts
            var downloadPartSize = 8 * MB;
            var key = UtilityMethods.GenerateName($"maxinmemory-{maxInMemoryParts}-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
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
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart");

            var downloadRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                PartSize = downloadPartSize,
                MaxInMemoryParts = maxInMemoryParts
            };

            // Act
            using (var response = await transferUtility.OpenStreamWithResponseAsync(downloadRequest))
            {
                // Assert
                Assert.IsNotNull(response, $"Response should not be null with MaxInMemoryParts={maxInMemoryParts}");
                Assert.IsNotNull(response.ResponseStream, 
                    $"ResponseStream should not be null with MaxInMemoryParts={maxInMemoryParts}");

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, 
                    $"Downloaded data checksum should match with MaxInMemoryParts={maxInMemoryParts}");
                Assert.AreEqual(objectSize, downloadedBytes.Length, 
                    $"Downloaded size should match with MaxInMemoryParts={maxInMemoryParts}");
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("MaxInMemoryParts")]
        [TestCategory("Multipart")]
        public async Task OpenStream_LargeObjectWithSmallMaxInMemoryParts_DownloadsSuccessfully()
        {
            // Arrange - Test memory-constrained scenario with large object
            // This simulates downloading a large file while limiting memory usage
            var objectSize = 40 * MB;
            var uploadPartSize = 8 * MB;  // Creates 5 parts
            var downloadPartSize = 8 * MB;
            var maxInMemoryParts = 2;  // Only buffer 2 parts (16MB) instead of all 5 (40MB)
            var key = UtilityMethods.GenerateName("large-maxinmemory-test");
            var filePath = Path.Combine(Path.GetTempPath(), key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            // Calculate checksum before upload
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            // Upload using TransferUtility to ensure multipart upload
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath,
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
            Assert.IsTrue(metadata.PartsCount > 1, "Object should be multipart");

            var downloadRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                PartSize = downloadPartSize,
                MaxInMemoryParts = maxInMemoryParts
            };

            // Act
            using (var response = await transferUtility.OpenStreamWithResponseAsync(downloadRequest))
            {
                // Assert
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseStream);
                ValidateHeaders(response, objectSize);

                // Read in smaller chunks to simulate streaming consumption
                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(1 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, 
                    "Large object should download correctly with limited MaxInMemoryParts");
                Assert.AreEqual(objectSize, downloadedBytes.Length, 
                    "Downloaded size should match for large object with limited MaxInMemoryParts");
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Creates a test object in S3 with the specified size and returns its key and checksum.
        /// </summary>
        private static async Task<(string key, string checksum)> CreateTestObjectWithChecksum(long objectSize)
        {
            var key = UtilityMethods.GenerateName("openstream-test");
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
        /// Validates that the response headers contain expected values.
        /// </summary>
        private static void ValidateHeaders(TransferUtilityOpenStreamResponse response, long expectedSize)
        {
            Assert.IsNotNull(response.Headers, "Headers should not be null");
            Assert.AreEqual(expectedSize, response.Headers.ContentLength, "Content length should match");
            Assert.IsNotNull(response.ETag, "ETag should not be null");
        }

        /// <summary>
        /// Reads a stream completely into a byte array using the specified buffer size.
        /// </summary>
        private static async Task<byte[]> ReadStreamToByteArray(Stream stream, long totalSize, int bufferSize)
        {
            var result = new byte[totalSize];
            var buffer = new byte[bufferSize];
            long totalRead = 0;
            
            int bytesRead;
            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                Array.Copy(buffer, 0, result, totalRead, bytesRead);
                totalRead += bytesRead;
            }
            
            Assert.AreEqual(totalSize, totalRead, "Should read expected number of bytes");
            return result;
        }

        /// <summary>
        /// Calculates the MD5 checksum of a byte array.
        /// </summary>
        private static string CalculateChecksum(byte[] data)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }
        }

        #endregion
    }
}
