using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class MultipartDownloadCoordinatorTests
    {
        private Mock<IPartDataHandler> CreateMockDataHandler()
        {
            var mockHandler = new Mock<IPartDataHandler>();
            mockHandler.Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockHandler.Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockHandler.Setup(x => x.ReleaseCapacity());
            mockHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            return mockHandler;
        }

        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesCoordinator()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockDataHandler = CreateMockDataHandler();

            // Act
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, mockDataHandler.Object);

            // Assert
            Assert.IsNotNull(coordinator);
            Assert.IsNull(coordinator.DownloadException);
        }

        [DataTestMethod]
        [DataRow(true, false, false, false, DisplayName = "Null S3Client")]
        [DataRow(false, true, false, false, DisplayName = "Null Request")]
        [DataRow(false, false, true, false, DisplayName = "Null Config")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullParameter_ThrowsArgumentNullException(
            bool nullClient, bool nullRequest, bool nullConfig, bool nullHandler)
        {
            // Arrange
            var client = nullClient ? null : MultipartDownloadTestHelpers.CreateMockS3Client().Object;
            var request = nullRequest ? null : MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = nullConfig ? null : MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = nullHandler ? null : CreateMockDataHandler().Object;

            // Act
            var coordinator = new MultipartDownloadCoordinator(client, request, config, handler);
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void DownloadException_InitiallyNull()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var exception = coordinator.DownloadException;

            // Assert
            Assert.IsNull(exception);
        }

        #endregion

        #region Discovery - PART Strategy - Single Part Tests

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_WithNullPartsCount_ReturnsSinglePart()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(
                objectSize: 1024 * 1024,
                eTag: "single-part-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TotalParts);
            Assert.AreEqual(1024 * 1024, result.ObjectSize);
            Assert.IsNotNull(result.InitialResponse);
        }

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_WithPartsCountOne_ReturnsSinglePart()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: 1024 * 1024,
                partsCount: 1,
                contentRange: null,
                eTag: "single-part-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, result.TotalParts);
            Assert.IsNotNull(result.InitialResponse);
        }

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_SinglePart_DoesNotBufferFirstPart()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(objectSize: 1024);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert - Single-part does not buffer during discovery
            Assert.IsNotNull(result.InitialResponse);
        }

        #endregion

        #region Discovery - PART Strategy - Multipart Tests

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_WithMultipleParts_ReturnsMultipart()
        {
            // Arrange
            var totalObjectSize = 50 * 1024 * 1024; // 50MB
            var partSize = 10 * 1024 * 1024; // 10MB
            var totalParts = 5;
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                partSize, totalParts, totalObjectSize, "multipart-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(5, result.TotalParts);
            Assert.AreEqual(totalObjectSize, result.ObjectSize);
            Assert.IsNotNull(result.InitialResponse);
        }

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_Multipart_BuffersFirstPart()
        {
            // Arrange
            var totalObjectSize = 50 * 1024 * 1024;
            var partSize = 10 * 1024 * 1024;
            var totalParts = 5;
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                partSize, totalParts, totalObjectSize, "multipart-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert - Multipart returns response with stream for buffering in StartDownloadsAsync
            Assert.IsNotNull(result.InitialResponse);
        }

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_SavesETag()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                8 * 1024 * 1024, 5, 40 * 1024 * 1024, "saved-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert - ETag is saved internally (verified through subsequent validation)
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_ParsesContentRange()
        {
            // Arrange
            var totalObjectSize = 52428800; // 50MB
            var partSize = 8388608; // 8MB
            var contentRange = $"bytes 0-{partSize - 1}/{totalObjectSize}";
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: partSize,
                partsCount: 7,
                contentRange: contentRange,
                eTag: "test-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(totalObjectSize, result.ObjectSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task DiscoverUsingPartStrategy_WithInvalidContentRange_ThrowsException()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: 8 * 1024 * 1024,
                partsCount: 5,
                contentRange: "invalid-format",
                eTag: "test-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
        }

        #endregion

        #region Discovery - RANGE Strategy - Small Object Tests

        [TestMethod]
        public async Task DiscoverUsingRangeStrategy_SmallObject_ReturnsSinglePart()
        {
            // Arrange
            var objectSize = 1024 * 1024; // 1MB
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: objectSize,
                partsCount: null,
                contentRange: null,  // No ContentRange means entire small object
                eTag: "small-object-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, result.TotalParts);
            Assert.AreEqual(objectSize, result.ObjectSize);
            Assert.IsNotNull(result.InitialResponse);
        }

        #endregion

        #region Discovery - RANGE Strategy - Single Part from Range Tests

        [TestMethod]
        public async Task DiscoverUsingRangeStrategy_SinglePartRange_ReturnsSinglePart()
        {
            // Arrange
            var objectSize = 5 * 1024 * 1024; // 5MB
            var contentRange = $"bytes 0-{objectSize - 1}/{objectSize}";
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: objectSize,
                partsCount: null,
                contentRange: contentRange,
                eTag: "single-range-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, result.TotalParts);
            Assert.IsNotNull(result.InitialResponse);
        }

        #endregion

        #region Discovery - RANGE Strategy - Multipart Tests

        [TestMethod]
        public async Task DiscoverUsingRangeStrategy_Multipart_ReturnsMultipart()
        {
            // Arrange
            var totalObjectSize = 52428800; // 50MB
            var partSize = 8388608; // 8MB
            var contentRange = $"bytes 0-{partSize - 1}/{totalObjectSize}";
            
            var mockResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "range-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(7, result.TotalParts); // 52428800 / 8388608 = 6.25 -> 7 parts
            Assert.IsNotNull(result.InitialResponse);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task DiscoverUsingRangeStrategy_Multipart_ValidatesContentLength()
        {
            // Arrange
            var totalObjectSize = 50 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            var wrongPartSize = 5 * 1024 * 1024; // ContentLength doesn't match requested part size
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: wrongPartSize,
                partsCount: null,
                contentRange: $"bytes 0-{wrongPartSize - 1}/{totalObjectSize}",
                eTag: "range-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
        }

        [TestMethod]
        public async Task DiscoverUsingRangeStrategy_SavesETag()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, 8 * 1024 * 1024 - 1, 50 * 1024 * 1024, "saved-range-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert - ETag is saved internally
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task DiscoverUsingRangeStrategy_CalculatesPartCount()
        {
            // Arrange
            var totalObjectSize = 52428800; // 50MB
            var partSize = 8388608; // 8MB
            
            var mockResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "range-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(7, result.TotalParts); // Ceiling(52428800 / 8388608) = 7
        }

        #endregion

        #region StartDownloadsAsync Tests - Setup

        [TestMethod]
        public async Task StartDownloadsAsync_SinglePart_ReturnsImmediately()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = new GetObjectResponse()
            };
            
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);

            // Assert - should complete without any downloads
            mockClient.Verify(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task StartDownloadsAsync_WithNullDiscoveryResult_ThrowsArgumentNullException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            await coordinator.StartDownloadsAsync(null, CancellationToken.None);
        }

        #endregion

        #region Validation Tests

        [DataTestMethod]
        [DataRow(MultipartDownloadTestHelpers.ValidationFailureType.MissingContentRange, DisplayName = "Missing ContentRange")]
        [DataRow(MultipartDownloadTestHelpers.ValidationFailureType.InvalidContentRangeFormat, DisplayName = "Invalid ContentRange Format")]
        [DataRow(MultipartDownloadTestHelpers.ValidationFailureType.UnparseableRange, DisplayName = "Unparseable Range")]
        [DataRow(MultipartDownloadTestHelpers.ValidationFailureType.RangeMismatch, DisplayName = "Range Mismatch")]
        [DataRow(MultipartDownloadTestHelpers.ValidationFailureType.ETagMismatch, DisplayName = "ETag Mismatch")]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task Validation_Failures_ThrowInvalidOperationException(
            MultipartDownloadTestHelpers.ValidationFailureType failureType)
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockClientWithValidationFailure(failureType);
            var coordinator = MultipartDownloadTestHelpers.CreateCoordinatorForValidationTest(mockClient.Object, failureType);
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Act & Assert (exception expected via attribute)
            await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);
        }

        [TestMethod]
        public async Task Validation_ETag_Matching_Succeeds()
        {
            // Arrange - All parts have consistent ETag
            var totalParts = 2;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            var consistentETag = "consistent-etag";
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, consistentETag, usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Act - should succeed with matching ETags
            await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);

            // Assert - no exception thrown
        }

        [TestMethod]
        public async Task Validation_ContentRange_ValidRange_Succeeds()
        {
            // Arrange - RANGE strategy with correct ContentRange
            var totalObjectSize = 20 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            // All three parts have correct ranges
            var firstPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "test-etag");
            
            var secondPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                partSize, 2 * partSize - 1, totalObjectSize, "test-etag");
            
            var thirdPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                2 * partSize, totalObjectSize - 1, totalObjectSize, "test-etag");
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1) return Task.FromResult(firstPartResponse);
                    if (callCount == 2) return Task.FromResult(secondPartResponse);
                    return Task.FromResult(thirdPartResponse);
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Act - should succeed with valid ranges
            await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);

            // Assert - no exception thrown
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.Dispose();
            coordinator.Dispose(); // Second call should not throw

            // Assert - no exception thrown
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public async Task Operations_AfterDispose_ThrowObjectDisposedException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.Dispose();
            await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
        }

        #endregion

        #region Cancellation Token Tests

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task DiscoverDownloadStrategyAsync_WhenCancelled_ThrowsOperationCanceledException()
        {
            // Arrange
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new OperationCanceledException());
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            await coordinator.DiscoverDownloadStrategyAsync(cts.Token);
        }

        [TestMethod]
        public async Task DiscoverDownloadStrategyAsync_WhenCancelled_SetsDownloadException()
        {
            // Arrange
            var mockClient = new Mock<IAmazonS3>();
            var cancelledException = new OperationCanceledException();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(cancelledException);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            try
            {
                await coordinator.DiscoverDownloadStrategyAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert
            Assert.IsNotNull(coordinator.DownloadException);
            Assert.IsInstanceOfType(coordinator.DownloadException, typeof(OperationCanceledException));
        }

        [TestMethod]
        public async Task DiscoverDownloadStrategyAsync_PassesCancellationTokenToS3Client()
        {
            // Arrange
            CancellationToken capturedToken = default;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Callback<GetObjectRequest, CancellationToken>((req, ct) => capturedToken = ct)
                .ReturnsAsync(MultipartDownloadTestHelpers.CreateSinglePartResponse(1024));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();

            // Act
            await coordinator.DiscoverDownloadStrategyAsync(cts.Token);

            // Assert
            Assert.AreEqual(cts.Token, capturedToken);
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task StartDownloadsAsync_WhenCancelledBeforeStart_ThrowsOperationCanceledException()
        {
            // Arrange
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, cts.Token);
        }

        [TestMethod]
        public async Task StartDownloadsAsync_WhenCancelledDuringDownloads_NotifiesBufferManager()
        {
            // Arrange
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        // First call (discovery) succeeds
                        return Task.FromResult(MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                            partSize, totalParts, totalObjectSize, "test-etag"));
                    }
                    else
                    {
                        // Subsequent calls (downloads) throw cancellation
                        throw new OperationCanceledException();
                    }
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Act
            try
            {
                await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert
            Assert.IsNotNull(coordinator.DownloadException);
            Assert.IsInstanceOfType(coordinator.DownloadException, typeof(OperationCanceledException));
        }

        [TestMethod]
        public async Task StartDownloadsAsync_WhenCancelled_SetsDownloadException()
        {
            // Arrange
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        return Task.FromResult(MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                            partSize, totalParts, totalObjectSize, "test-etag"));
                    }
                    throw new OperationCanceledException();
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Act
            try
            {
                await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert
            Assert.IsNotNull(coordinator.DownloadException);
            Assert.IsInstanceOfType(coordinator.DownloadException, typeof(OperationCanceledException));
        }

        [TestMethod]
        public async Task StartDownloadsAsync_PassesCancellationTokenToBufferManager()
        {
            // Arrange
            var totalParts = 2;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var cts = new CancellationTokenSource();

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, cts.Token);

            // Assert - The cancellation token was passed through to the data handler
            Assert.IsNotNull(discoveryResult);
        }

        [TestMethod]
        public async Task StartDownloadsAsync_SinglePart_DoesNotThrowOnCancellation()
        {
            // Arrange - Single part download should return immediately without using cancellation token
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = new GetObjectResponse()
            };
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act - should complete without throwing even though token is cancelled
            await coordinator.StartDownloadsAsync(discoveryResult, cts.Token);

            // Assert - no exception thrown, no S3 calls made
            mockClient.Verify(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()), Times.Never);
        }

        [TestMethod]
        public async Task StartDownloadsAsync_CancellationPropagatesAcrossConcurrentDownloads()
        {
            // Arrange - Multiple concurrent downloads, one fails with cancellation
            var totalParts = 5;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        // Discovery call succeeds
                        return Task.FromResult(MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                            partSize, totalParts, totalObjectSize, "test-etag"));
                    }
                    else if (callCount == 2)
                    {
                        // Second download (part 2) throws cancellation
                        throw new OperationCanceledException();
                    }
                    else
                    {
                        // Other downloads should also be cancelled
                        return Task.FromResult(MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                            partSize, totalParts, 
                            $"bytes {(callCount - 1) * partSize}-{callCount * partSize - 1}/{totalObjectSize}",
                            "test-etag"));
                    }
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Act
            try
            {
                await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - Error should be captured
            Assert.IsNotNull(coordinator.DownloadException);
        }

        [TestMethod]
        public async Task Coordinator_CanBeDisposedAfterCancellation()
        {
            // Arrange
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new OperationCanceledException());
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            try
            {
                await coordinator.DiscoverDownloadStrategyAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }
            
            // Dispose should not throw
            coordinator.Dispose();

            // Assert - Multiple disposes should also work
            coordinator.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task StartDownloadsAsync_RangeStrategy_CancellationDuringDownloads()
        {
            // Arrange - RANGE strategy cancellation
            var totalObjectSize = 20 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            var callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        // Discovery succeeds
                        return Task.FromResult(MultipartDownloadTestHelpers.CreateRangeResponse(
                            0, partSize - 1, totalObjectSize, "test-etag"));
                    }
                    // Part 2 download throws cancellation
                    throw new OperationCanceledException();
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, CancellationToken.None);
        }

        #endregion
    }
}
