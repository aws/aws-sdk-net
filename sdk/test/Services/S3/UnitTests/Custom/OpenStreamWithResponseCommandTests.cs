using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class OpenStreamWithResponseCommandTests
    {
        #region ExecuteAsync Tests - Success

        [TestMethod]
        public async Task ExecuteAsync_CreatesBufferedMultipartStream()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            Assert.IsInstanceOfType(response.ResponseStream, typeof(BufferedMultipartStream));
        }

        [TestMethod]
        public async Task ExecuteAsync_CallsInitializeAsync()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            var stream = (BufferedMultipartStream)response.ResponseStream;
            Assert.IsNotNull(stream.DiscoveryResult); // Indicates initialization occurred
        }

        [TestMethod]
        public async Task ExecuteAsync_ReturnsResponse()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsInstanceOfType(response, typeof(TransferUtilityOpenStreamResponse));
        }

        [TestMethod]
        public async Task ExecuteAsync_SetsResponseStream()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response.ResponseStream);
            Assert.IsTrue(response.ResponseStream.CanRead);
        }

        #endregion

        #region ExecuteAsync Tests - Response Mapping

        [TestMethod]
        public async Task ExecuteAsync_MapsMetadataFromInitialResponse()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponseWithEncryption(
                contentLength: 1024,
                partsCount: null,
                contentRange: null,
                eTag: "test-etag-123",
                testData: testData,
                includeHeaders: true,
                serverSideEncryptionMethod: ServerSideEncryptionMethod.AES256,
                serverSideEncryptionKeyManagementServiceKeyId: "test-kms-key");
            
            // Add custom headers
            mockResponse.Headers["Content-Language"] = "en-US";
            mockResponse.Headers["Cache-Control"] = "max-age=3600";
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("test-etag-123", response.ETag);
            Assert.IsNotNull(response.Headers);
            Assert.AreEqual(ServerSideEncryptionMethod.AES256, response.ServerSideEncryptionMethod);
            Assert.AreEqual("test-kms-key", response.ServerSideEncryptionKeyManagementServiceKeyId);
        }

        [TestMethod]
        public async Task ExecuteAsync_SinglePart_MapsFromSinglePartResponse()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(
                objectSize: 2048,
                eTag: "single-part-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("single-part-etag", response.ETag);
        }

        [TestMethod]
        public async Task ExecuteAsync_Multipart_MapsFromInitialResponse()
        {
            // Arrange
            var totalObjectSize = 50 * 1024 * 1024;
            var partSize = 10 * 1024 * 1024;
            var totalParts = 5;
            
            // Use CreateMockS3ClientForMultipart to properly mock all parts
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "multipart-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("multipart-etag", response.ETag);
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        #endregion

        #region ContentLength and ContentRange Validation Tests

        [TestMethod]
        public async Task ExecuteAsync_SinglePart_SetsCorrectContentLengthAndRange()
        {
            // Arrange
            var objectSize = 2048;
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(
                objectSize: objectSize,
                eTag: "single-part-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert - SEP Part GET Step 7 / Ranged GET Step 9
            Assert.AreEqual(objectSize, response.Headers.ContentLength, 
                "ContentLength should equal total object size");
            Assert.AreEqual($"bytes 0-{objectSize - 1}/{objectSize}", response.ContentRange,
                "ContentRange should be bytes 0-(ContentLength-1)/ContentLength");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipartPartStrategy_SetsCorrectContentLengthAndRange()
        {
            // Arrange
            var totalParts = 5;
            var partSize = 10 * 1024 * 1024; // 10MB per part
            var totalObjectSize = (long)totalParts * partSize; // 50MB total
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "multipart-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert - SEP Part GET Step 7
            Assert.AreEqual(totalObjectSize, response.Headers.ContentLength,
                "ContentLength should equal total object size, not first part size");
            Assert.AreEqual($"bytes 0-{totalObjectSize - 1}/{totalObjectSize}", response.ContentRange,
                "ContentRange should be bytes 0-(ContentLength-1)/ContentLength for entire object");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipartRangeStrategy_SetsCorrectContentLengthAndRange()
        {
            // Arrange
            var totalObjectSize = 25 * 1024 * 1024; // 25MB total
            var partSize = 8 * 1024 * 1024; // 8MB per part
            var totalParts = (int)Math.Ceiling((double)totalObjectSize / partSize); // 4 parts
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "range-multipart-etag", usePartStrategy: false);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert - SEP Ranged GET Step 9
            Assert.AreEqual(totalObjectSize, response.Headers.ContentLength,
                "ContentLength should equal total object size, not first range size");
            Assert.AreEqual($"bytes 0-{totalObjectSize - 1}/{totalObjectSize}", response.ContentRange,
                "ContentRange should be bytes 0-(ContentLength-1)/ContentLength for entire object");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_ZeroByteObject_ContentRangeIsNull()
        {
            // Arrange - Mock a 0-byte object
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(
                objectSize: 0,
                eTag: "empty-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert - S3 returns null ContentRange for 0-byte objects
            Assert.AreEqual(0, response.Headers.ContentLength, 
                "ContentLength should be 0 for empty object");
            Assert.IsNull(response.ContentRange, 
                "ContentRange should be null for 0-byte objects (matching S3 behavior)");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        #endregion

        #region Integration Tests

        [TestMethod]
        public async Task ExecuteAsync_EndToEnd_SinglePart()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: 512,
                partsCount: null,
                contentRange: null,
                eTag: "single-etag",
                testData: testData);
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            
            // Verify we can read from the stream
            var buffer = new byte[256];
            var bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);
            Assert.AreEqual(256, bytesRead);
            
            // Verify data matches
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, buffer, 0, 256));
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_EndToEnd_Multipart()
        {
            // Arrange
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "multi-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            Assert.IsInstanceOfType(response.ResponseStream, typeof(BufferedMultipartStream));
            
            var stream = (BufferedMultipartStream)response.ResponseStream;
            Assert.AreEqual(totalParts, stream.DiscoveryResult.TotalParts);
            Assert.AreEqual(totalObjectSize, stream.DiscoveryResult.ObjectSize);
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        #endregion

        #region MaxInMemoryParts Tests

        [TestMethod]
        public async Task ExecuteAsync_UsesRequestMaxInMemoryParts()
        {
            // Arrange
            var customMaxParts = 256;
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            request.MaxInMemoryParts = customMaxParts;
            
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            // Stream should be created successfully with request's MaxInMemoryParts value
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_WithDefaultMaxInMemoryParts_WorksCorrectly()
        {
            // Arrange - Use default MaxInMemoryParts from request (1024)
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(2048, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            // Don't explicitly set MaxInMemoryParts - should use default of 1024
            
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            
            // Should work with default value
            var buffer = new byte[1024];
            var bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);
            Assert.IsTrue(bytesRead > 0, "Should successfully read with default MaxInMemoryParts");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [DataTestMethod]
        [DataRow(1, DisplayName = "Minimum (1 part)")]
        [DataRow(128, DisplayName = "Small (128 parts)")]
        [DataRow(1024, DisplayName = "Default (1024 parts)")]
        [DataRow(2048, DisplayName = "Large (2048 parts)")]
        public async Task ExecuteAsync_WithVariousMaxInMemoryParts_CreatesStreamSuccessfully(
            int maxInMemoryParts)
        {
            // Arrange
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            request.MaxInMemoryParts = maxInMemoryParts;
            
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            Assert.IsInstanceOfType(response.ResponseStream, typeof(BufferedMultipartStream));
            
            // Verify stream works
            var stream = (BufferedMultipartStream)response.ResponseStream;
            Assert.IsNotNull(stream.DiscoveryResult);
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipartWithCustomMaxInMemoryParts_IntegrationTest()
        {
            // Arrange - Larger multipart download with custom memory limit
            var customMaxParts = 64; // Lower memory limit for this test
            var totalParts = 10;
            var partSize = 5 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "multipart-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: partSize);
            request.MaxInMemoryParts = customMaxParts;
            
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 3 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            
            var stream = (BufferedMultipartStream)response.ResponseStream;
            Assert.AreEqual(totalParts, stream.DiscoveryResult.TotalParts);
            
            // Verify we can read from the stream with custom MaxInMemoryParts
            var buffer = new byte[1024 * 1024]; // 1MB buffer
            var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            Assert.IsTrue(bytesRead > 0, 
                $"Should successfully read multipart download with MaxInMemoryParts={customMaxParts}");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        #endregion

        #region ChunkBufferSize Tests

        [TestMethod]
        public async Task ExecuteAsync_WithChunkBufferSize_PassedToStream()
        {
            // Arrange
            var customChunkSize = 32 * 1024; // 32KB
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            request.ChunkBufferSize = customChunkSize;
            
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            // Stream should be created successfully with request's ChunkBufferSize value
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_WithNullChunkBufferSize_UsesDefaultChunkSize()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(2048, "test-etag");
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            // Don't set ChunkBufferSize - should use default
            Assert.IsNull(request.ChunkBufferSize, "ChunkBufferSize should default to null");
            
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            
            // Should work with default chunk size
            var buffer = new byte[1024];
            var bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);
            Assert.IsTrue(bytesRead > 0, "Should successfully read with default chunk size");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [DataTestMethod]
        [DataRow(16 * 1024, DisplayName = "Small (16KB)")]
        [DataRow(64 * 1024, DisplayName = "Medium (64KB)")]
        [DataRow(128 * 1024, DisplayName = "Large (128KB)")]
        [DataRow(256 * 1024, DisplayName = "Extra Large (256KB)")]
        public async Task ExecuteAsync_WithVariousChunkBufferSizes_CreatesStreamSuccessfully(
            int chunkBufferSize)
        {
            // Arrange
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            request.ChunkBufferSize = chunkBufferSize;
            
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            Assert.IsInstanceOfType(response.ResponseStream, typeof(BufferedMultipartStream));
            
            // Verify stream works with custom chunk size
            var stream = (BufferedMultipartStream)response.ResponseStream;
            Assert.IsNotNull(stream.DiscoveryResult);
            
            // Verify we can read from the stream
            var buffer = new byte[chunkBufferSize];
            var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            Assert.IsTrue(bytesRead > 0, 
                $"Should successfully read with ChunkBufferSize={chunkBufferSize}");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipartWithCustomChunkBufferSize_IntegrationTest()
        {
            // Arrange - Larger multipart download with custom chunk size
            var customChunkSize = 32 * 1024; // 32KB chunks
            var totalParts = 5;
            var partSize = 10 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "multipart-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: partSize);
            request.ChunkBufferSize = customChunkSize;
            
            var config = new TransferUtilityConfig { ConcurrentServiceRequests = 2 };
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.ResponseStream);
            
            var stream = (BufferedMultipartStream)response.ResponseStream;
            Assert.AreEqual(totalParts, stream.DiscoveryResult.TotalParts);
            
            // Verify we can read from the stream with custom chunk size
            var buffer = new byte[customChunkSize * 2]; // Read 2 chunks worth
            var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            Assert.IsTrue(bytesRead > 0, 
                $"Should successfully read multipart download with ChunkBufferSize={customChunkSize}");
            
            // Cleanup
            response.ResponseStream.Dispose();
        }

        #endregion
    }
}
