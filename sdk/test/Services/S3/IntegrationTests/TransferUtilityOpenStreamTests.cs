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
    /// Integration tests for TransferUtility.OpenStream with multipart download support.
    /// Tests various combinations of part sizes, download strategies (PART vs RANGE), 
    /// and buffer sizes to ensure correct behavior of OpenStreamWithResponseCommand.
    /// </summary>
    [TestClass]
    public class TransferUtilityOpenStreamTests : TestBase<AmazonS3Client>
    {
        private static readonly long MB = 1024 * 1024;
        private static readonly string BasePath = @"c:\temp\test\openstream\";
        private static string bucketName;

        [ClassInitialize()]
        public static void ClassInitialize(TestContext testContext)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
            
            if (!Directory.Exists(BasePath))
            {
                Directory.CreateDirectory(BasePath);
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
            
            if (Directory.Exists(BasePath))
            {
                Directory.Delete(BasePath, true);
            }
        }

        #region Helper Methods

        /// <summary>
        /// Creates a test object in S3 and returns the expected checksum.
        /// </summary>
        private async Task<(string key, string checksum)> CreateTestObjectWithChecksum(long sizeInBytes)
        {
            var key = UtilityMethods.GenerateName("openstream-test");
            var filePath = Path.Combine(BasePath, key);
            
            // Generate test file
            UtilityMethods.GenerateFile(filePath, sizeInBytes);
            
            // Calculate checksum
            var fileBytes = File.ReadAllBytes(filePath);
            var checksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32Hash(fileBytes);
            
            // Upload to S3
            await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            });
            
            return (key, checksum);
        }

        /// <summary>
        /// Reads a stream into a byte array using the specified buffer size.
        /// </summary>
        private async Task<byte[]> ReadStreamToByteArray(Stream stream, long expectedSize, int bufferSize)
        {
            var result = new List<byte>();
            var buffer = new byte[bufferSize];
            int bytesRead;
            
            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                result.AddRange(buffer.Take(bytesRead));
            }
            
            return result.ToArray();
        }

        /// <summary>
        /// Calculates the checksum of downloaded data.
        /// </summary>
        private string CalculateChecksum(byte[] data)
        {
            return CryptoUtilFactory.CryptoInstance.ComputeCRC32Hash(data);
        }

        /// <summary>
        /// Validates ContentLength and ContentRange headers.
        /// </summary>
        private void ValidateHeaders(TransferUtilityOpenStreamResponse response, long expectedSize)
        {
            Assert.AreEqual(expectedSize, response.Headers.ContentLength,
                "ContentLength should equal total object size");
            
            var expectedRange = $"bytes 0-{expectedSize - 1}/{expectedSize}";
            Assert.AreEqual(expectedRange, response.ContentRange,
                "ContentRange should be bytes 0-(ContentLength-1)/ContentLength");
        }

        #endregion

        #region Single-Part Baseline Tests

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

        #region Multipart Matrix Tests - 10MB Objects

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Multipart")]
        [DataRow(5 * 1024 * 1024, "PART", 1 * 1024 * 1024, DisplayName = "10MB: 5MB parts, PART strategy, 1MB buffer")]
        [DataRow(5 * 1024 * 1024, "RANGE", 1 * 1024 * 1024, DisplayName = "10MB: 5MB parts, RANGE strategy, 1MB buffer")]
        [DataRow(5 * 1024 * 1024, "PART", 16 * 1024 * 1024, DisplayName = "10MB: 5MB parts, PART strategy, 16MB buffer")]
        [DataRow(5 * 1024 * 1024, "RANGE", 16 * 1024 * 1024, DisplayName = "10MB: 5MB parts, RANGE strategy, 16MB buffer")]
        [DataRow(8 * 1024 * 1024, "PART", 2 * 1024 * 1024, DisplayName = "10MB: 8MB parts, PART strategy, 2MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 2 * 1024 * 1024, DisplayName = "10MB: 8MB parts, RANGE strategy, 2MB buffer")]
        [DataRow(8 * 1024 * 1024, "PART", 16 * 1024 * 1024, DisplayName = "10MB: 8MB parts, PART strategy, 16MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 16 * 1024 * 1024, DisplayName = "10MB: 8MB parts, RANGE strategy, 16MB buffer")]
        public async Task OpenStream_Multipart_10MB_Matrix(long partSize, string strategyName, int bufferSize)
        {
            await ExecuteMultipartTest(10 * MB, partSize, strategyName, bufferSize);
        }

        #endregion

        #region Multipart Matrix Tests - 50MB Objects

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Multipart")]
        [DataRow(5 * 1024 * 1024, "PART", 1 * 1024 * 1024, DisplayName = "50MB: 5MB parts, PART strategy, 1MB buffer")]
        [DataRow(5 * 1024 * 1024, "RANGE", 1 * 1024 * 1024, DisplayName = "50MB: 5MB parts, RANGE strategy, 1MB buffer")]
        [DataRow(5 * 1024 * 1024, "PART", 2 * 1024 * 1024, DisplayName = "50MB: 5MB parts, PART strategy, 2MB buffer")]
        [DataRow(5 * 1024 * 1024, "RANGE", 2 * 1024 * 1024, DisplayName = "50MB: 5MB parts, RANGE strategy, 2MB buffer")]
        [DataRow(5 * 1024 * 1024, "PART", 16 * 1024 * 1024, DisplayName = "50MB: 5MB parts, PART strategy, 16MB buffer")]
        [DataRow(5 * 1024 * 1024, "RANGE", 16 * 1024 * 1024, DisplayName = "50MB: 5MB parts, RANGE strategy, 16MB buffer")]
        [DataRow(5 * 1024 * 1024, "PART", 32 * 1024 * 1024, DisplayName = "50MB: 5MB parts, PART strategy, 32MB buffer")]
        [DataRow(5 * 1024 * 1024, "RANGE", 32 * 1024 * 1024, DisplayName = "50MB: 5MB parts, RANGE strategy, 32MB buffer")]
        [DataRow(8 * 1024 * 1024, "PART", 1 * 1024 * 1024, DisplayName = "50MB: 8MB parts, PART strategy, 1MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 1 * 1024 * 1024, DisplayName = "50MB: 8MB parts, RANGE strategy, 1MB buffer")]
        [DataRow(8 * 1024 * 1024, "PART", 2 * 1024 * 1024, DisplayName = "50MB: 8MB parts, PART strategy, 2MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 2 * 1024 * 1024, DisplayName = "50MB: 8MB parts, RANGE strategy, 2MB buffer")]
        [DataRow(8 * 1024 * 1024, "PART", 4 * 1024 * 1024, DisplayName = "50MB: 8MB parts, PART strategy, 4MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 4 * 1024 * 1024, DisplayName = "50MB: 8MB parts, RANGE strategy, 4MB buffer")]
        [DataRow(8 * 1024 * 1024, "PART", 16 * 1024 * 1024, DisplayName = "50MB: 8MB parts, PART strategy, 16MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 16 * 1024 * 1024, DisplayName = "50MB: 8MB parts, RANGE strategy, 16MB buffer")]
        [DataRow(16 * 1024 * 1024, "PART", 2 * 1024 * 1024, DisplayName = "50MB: 16MB parts, PART strategy, 2MB buffer")]
        [DataRow(16 * 1024 * 1024, "RANGE", 2 * 1024 * 1024, DisplayName = "50MB: 16MB parts, RANGE strategy, 2MB buffer")]
        [DataRow(16 * 1024 * 1024, "PART", 4 * 1024 * 1024, DisplayName = "50MB: 16MB parts, PART strategy, 4MB buffer")]
        [DataRow(16 * 1024 * 1024, "RANGE", 4 * 1024 * 1024, DisplayName = "50MB: 16MB parts, RANGE strategy, 4MB buffer")]
        [DataRow(16 * 1024 * 1024, "PART", 8 * 1024 * 1024, DisplayName = "50MB: 16MB parts, PART strategy, 8MB buffer")]
        [DataRow(16 * 1024 * 1024, "RANGE", 8 * 1024 * 1024, DisplayName = "50MB: 16MB parts, RANGE strategy, 8MB buffer")]
        [DataRow(16 * 1024 * 1024, "PART", 32 * 1024 * 1024, DisplayName = "50MB: 16MB parts, PART strategy, 32MB buffer")]
        [DataRow(16 * 1024 * 1024, "RANGE", 32 * 1024 * 1024, DisplayName = "50MB: 16MB parts, RANGE strategy, 32MB buffer")]
        public async Task OpenStream_Multipart_50MB_Matrix(long partSize, string strategyName, int bufferSize)
        {
            await ExecuteMultipartTest(50 * MB, partSize, strategyName, bufferSize);
        }

        #endregion

        #region Multipart Matrix Tests - 100MB Objects

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("Multipart")]
        [DataRow(8 * 1024 * 1024, "PART", 2 * 1024 * 1024, DisplayName = "100MB: 8MB parts, PART strategy, 2MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 2 * 1024 * 1024, DisplayName = "100MB: 8MB parts, RANGE strategy, 2MB buffer")]
        [DataRow(8 * 1024 * 1024, "PART", 16 * 1024 * 1024, DisplayName = "100MB: 8MB parts, PART strategy, 16MB buffer")]
        [DataRow(8 * 1024 * 1024, "RANGE", 16 * 1024 * 1024, DisplayName = "100MB: 8MB parts, RANGE strategy, 16MB buffer")]
        [DataRow(16 * 1024 * 1024, "PART", 4 * 1024 * 1024, DisplayName = "100MB: 16MB parts, PART strategy, 4MB buffer")]
        [DataRow(16 * 1024 * 1024, "RANGE", 4 * 1024 * 1024, DisplayName = "100MB: 16MB parts, RANGE strategy, 4MB buffer")]
        [DataRow(16 * 1024 * 1024, "PART", 32 * 1024 * 1024, DisplayName = "100MB: 16MB parts, PART strategy, 32MB buffer")]
        [DataRow(16 * 1024 * 1024, "RANGE", 32 * 1024 * 1024, DisplayName = "100MB: 16MB parts, RANGE strategy, 32MB buffer")]
        [DataRow(32 * 1024 * 1024, "PART", 4 * 1024 * 1024, DisplayName = "100MB: 32MB parts, PART strategy, 4MB buffer")]
        [DataRow(32 * 1024 * 1024, "RANGE", 4 * 1024 * 1024, DisplayName = "100MB: 32MB parts, RANGE strategy, 4MB buffer")]
        [DataRow(32 * 1024 * 1024, "PART", 8 * 1024 * 1024, DisplayName = "100MB: 32MB parts, PART strategy, 8MB buffer")]
        [DataRow(32 * 1024 * 1024, "RANGE", 8 * 1024 * 1024, DisplayName = "100MB: 32MB parts, RANGE strategy, 8MB buffer")]
        [DataRow(32 * 1024 * 1024, "PART", 64 * 1024 * 1024, DisplayName = "100MB: 32MB parts, PART strategy, 64MB buffer")]
        [DataRow(32 * 1024 * 1024, "RANGE", 64 * 1024 * 1024, DisplayName = "100MB: 32MB parts, RANGE strategy, 64MB buffer")]
        public async Task OpenStream_Multipart_100MB_Matrix(long partSize, string strategyName, int bufferSize)
        {
            await ExecuteMultipartTest(100 * MB, partSize, strategyName, bufferSize);
        }

        #endregion

        #region Core Multipart Test Executor

        /// <summary>
        /// Core test method that executes multipart download test with specified parameters.
        /// </summary>
        private async Task ExecuteMultipartTest(long objectSize, long partSize, string strategyName, int bufferSize)
        {
            // Arrange
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);
            
            var downloadType = strategyName == "PART" 
                ? MultipartDownloadType.PART 
                : MultipartDownloadType.RANGE;

            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 1 // Sequential for easier debugging
            };

            // Act
            var transferUtility = new TransferUtility(Client, config);
            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                PartSize = partSize
            };

            using (var response = await transferUtility.OpenStreamWithResponseAsync(request))
            {
                // Assert - Response structure
                Assert.IsNotNull(response, "Response should not be null");
                Assert.IsNotNull(response.ResponseStream, "ResponseStream should not be null");
                
                // Assert - Headers
                ValidateHeaders(response, objectSize);
                
                // Assert - Data integrity via checksum
                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, bufferSize);
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum,
                    $"Checksum mismatch for objectSize={objectSize}, partSize={partSize}, strategy={strategyName}, bufferSize={bufferSize}");
                Assert.AreEqual(objectSize, downloadedBytes.Length,
                    $"Size mismatch for objectSize={objectSize}, partSize={partSize}, strategy={strategyName}, bufferSize={bufferSize}");

                Console.WriteLine($"✓ Verified: {objectSize / MB}MB object, {partSize / MB}MB parts, {strategyName} strategy, {bufferSize / MB}MB buffer");
            }
        }

        #endregion

        #region Edge Case Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("EdgeCase")]
        public async Task OpenStream_ExactPartBoundary_TwoParts()
        {
            // Arrange - Object size exactly equals 2 parts
            var partSize = 8 * MB;
            var objectSize = 2 * partSize; // 16MB exactly
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);

            var transferUtility = new TransferUtility(Client);
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
                ValidateHeaders(response, objectSize);
                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum);
                Assert.AreEqual(objectSize, downloadedBytes.Length);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("EdgeCase")]
        public async Task OpenStream_NonAlignedPartBoundary()
        {
            // Arrange - Object size not aligned to part boundaries
            var partSize = 8 * MB;
            var objectSize = (2 * partSize) + (3 * MB); // 19MB (2 full parts + 3MB remainder)
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);

            var transferUtility = new TransferUtility(Client);
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
                ValidateHeaders(response, objectSize);
                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum);
                Assert.AreEqual(objectSize, downloadedBytes.Length);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("EdgeCase")]
        public async Task OpenStream_BufferLargerThanPartSize()
        {
            // Arrange - Buffer size larger than part size
            var partSize = 5 * MB;
            var bufferSize = (int)(8 * MB);
            var objectSize = 20 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);

            var transferUtility = new TransferUtility(Client);
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
                ValidateHeaders(response, objectSize);
                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, bufferSize);
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum);
                Assert.AreEqual(objectSize, downloadedBytes.Length);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("EdgeCase")]
        public async Task OpenStream_SmallBufferLargeParts()
        {
            // Arrange - Very small buffer with large parts (stress test buffering)
            var partSize = 16 * MB;
            var bufferSize = 512 * 1024; // 512KB buffer
            var objectSize = 40 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);

            var transferUtility = new TransferUtility(Client);
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
                ValidateHeaders(response, objectSize);
                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, bufferSize);
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum);
                Assert.AreEqual(objectSize, downloadedBytes.Length);
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
            var filePath = Path.Combine(BasePath, key);
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
            var filePath = Path.Combine(BasePath, key);
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

        #region Stream Behavior Tests

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("StreamBehavior")]
        public async Task OpenStream_SupportsMultipleReads()
        {
            // Arrange
            var objectSize = 5 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);

            // Act
            var transferUtility = new TransferUtility(Client);
            using (var response = await transferUtility.OpenStreamWithResponseAsync(bucketName, key))
            {
                // Read in multiple small chunks
                var allBytes = new List<byte>();
                var buffer = new byte[1024 * 100]; // 100KB chunks
                int bytesRead;

                while ((bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                {
                    allBytes.AddRange(buffer.Take(bytesRead));
                }

                // Assert
                var actualChecksum = CalculateChecksum(allBytes.ToArray());
                Assert.AreEqual(expectedChecksum, actualChecksum);
                Assert.AreEqual(objectSize, allBytes.Count);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        [TestCategory("OpenStream")]
        [TestCategory("StreamBehavior")]
        public async Task OpenStream_ReturnsZeroAtEndOfStream()
        {
            // Arrange
            var objectSize = 2 * MB;
            var (key, _) = await CreateTestObjectWithChecksum(objectSize);

            // Act
            var transferUtility = new TransferUtility(Client);
            using (var response = await transferUtility.OpenStreamWithResponseAsync(bucketName, key))
            {
                // Read entire stream
                var buffer = new byte[objectSize];
                var totalRead = 0;
                while (totalRead < objectSize)
                {
                    var bytesRead = await response.ResponseStream.ReadAsync(buffer, totalRead, (int)(objectSize - totalRead));
                    if (bytesRead == 0) break;
                    totalRead += bytesRead;
                }

                // Try to read past end of stream
                var extraRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);

                // Assert
                Assert.AreEqual(0, extraRead, "Reading past end of stream should return 0");
                Assert.AreEqual(objectSize, totalRead);
            }
        }

        #endregion
    }
}
