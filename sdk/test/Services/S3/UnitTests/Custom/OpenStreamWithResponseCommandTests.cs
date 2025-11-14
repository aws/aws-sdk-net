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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
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
            var headers = new HeadersCollection();
            headers["Content-Language"] = "en-US";
            headers["Cache-Control"] = "max-age=3600";
            
            var mockResponse = new Mock<GetObjectResponse>();
            mockResponse.Setup(x => x.ContentLength).Returns(1024);
            mockResponse.Setup(x => x.PartsCount).Returns((int?)null);
            mockResponse.Setup(x => x.ContentRange).Returns((string)null);
            mockResponse.Setup(x => x.ETag).Returns("test-etag-123");
            mockResponse.Setup(x => x.Headers).Returns(headers);
            mockResponse.Setup(x => x.ResponseStream).Returns(new MemoryStream(new byte[1024]));
            mockResponse.Setup(x => x.Metadata).Returns(new MetadataCollection());
            mockResponse.Setup(x => x.ServerSideEncryptionMethod).Returns(ServerSideEncryptionMethod.AES256);
            mockResponse.Setup(x => x.ServerSideEncryptionCustomerMethod).Returns(ServerSideEncryptionCustomerMethod.None);
            mockResponse.Setup(x => x.ServerSideEncryptionKeyManagementServiceKeyId).Returns("test-kms-key");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse.Object));
            
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
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
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                partSize, totalParts, totalObjectSize, "multipart-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = new TransferUtilityConfig();
            var command = new OpenStreamWithResponseCommand(mockClient.Object, request, config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual("multipart-etag", response.ETag);
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
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
    }
}
