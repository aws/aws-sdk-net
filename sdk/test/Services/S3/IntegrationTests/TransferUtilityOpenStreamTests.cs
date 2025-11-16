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
            // Object must be > 16MB to trigger multipart upload (AWS SDK default threshold)
            var objectSize = 20 * MB;
            var partSize = 8 * MB;
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
                Assert.IsNotNull(response, "Response should not be null");
                Assert.IsNotNull(response.ResponseStream, "ResponseStream should not be null");
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.AreEqual(expectedChecksum, actualChecksum, "Downloaded data checksum should match");
                Assert.AreEqual(objectSize, downloadedBytes.Length, "Downloaded size should match");
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
