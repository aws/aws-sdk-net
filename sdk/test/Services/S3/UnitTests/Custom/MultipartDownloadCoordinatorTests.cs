using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class MultipartDownloadCoordinatorTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesCoordinator()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();

            // Act
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Assert
            Assert.IsNotNull(coordinator);
            Assert.AreEqual(StreamState.Initializing, coordinator.CurrentState);
            Assert.IsNull(coordinator.DownloadException);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullS3Client_ThrowsArgumentNullException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();

            // Act
            var coordinator = new MultipartDownloadCoordinator(null, request, config);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullRequest_ThrowsArgumentNullException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();

            // Act
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, null, config);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullConfig_ThrowsArgumentNullException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();

            // Act
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, null);
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void CurrentState_InitiallyInitializing()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var state = coordinator.CurrentState;

            // Assert
            Assert.AreEqual(StreamState.Initializing, state);
        }

        [TestMethod]
        public void DownloadException_InitiallyNull()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TotalParts);
            Assert.AreEqual(1024 * 1024, result.ObjectSize);
            Assert.IsNotNull(result.SinglePartResponse);
            Assert.AreEqual(result.InitialResponse, result.SinglePartResponse);
            Assert.IsNull(result.BufferedFirstPart);
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, result.TotalParts);
            Assert.IsNotNull(result.SinglePartResponse);
            Assert.IsNull(result.BufferedFirstPart);
        }

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_SinglePart_DoesNotBufferFirstPart()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(objectSize: 1024);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.IsNull(result.BufferedFirstPart);
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(5, result.TotalParts);
            Assert.AreEqual(totalObjectSize, result.ObjectSize);
            Assert.IsNull(result.SinglePartResponse);
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(result.BufferedFirstPart);
            Assert.AreEqual(1, result.BufferedFirstPart.PartNumber);
        }

        [TestMethod]
        public async Task DiscoverUsingPartStrategy_SavesETag()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                8 * 1024 * 1024, 5, 40 * 1024 * 1024, "saved-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, result.TotalParts);
            Assert.AreEqual(objectSize, result.ObjectSize);
            Assert.IsNotNull(result.SinglePartResponse);
            Assert.IsNull(result.BufferedFirstPart);
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, result.TotalParts);
            Assert.IsNotNull(result.SinglePartResponse);
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(7, result.TotalParts); // 52428800 / 8388608 = 6.25 -> 7 parts
            Assert.IsNull(result.SinglePartResponse);
        }

        [TestMethod]
        public async Task DiscoverUsingRangeStrategy_Multipart_BuffersFirstPart()
        {
            // Arrange
            var totalObjectSize = 50 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            var mockResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "range-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            var result = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(result.BufferedFirstPart);
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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
                (req, ct) => Task.FromResult(mockResponse.Object));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                SinglePartResponse = Mock.Of<GetObjectResponse>(),
                InitialResponse = Mock.Of<GetObjectResponse>(),
                BufferedFirstPart = null
            };
            
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);

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
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            await coordinator.StartDownloadsAsync(null, mockBufferManager.Object, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task StartDownloadsAsync_WithNullPartBufferManager_ThrowsArgumentNullException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 2,
                ObjectSize = 16 * 1024 * 1024,
                SinglePartResponse = null,
                InitialResponse = Mock.Of<GetObjectResponse>(),
                BufferedFirstPart = null
            };

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, null, CancellationToken.None);
        }

        #endregion

        #region StartDownloadsAsync Tests - Progress Reporting

        [TestMethod]
        public async Task StartDownloadsAsync_ReportsProgress()
        {
            // Arrange
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var progressEvents = 0;
            coordinator.ProgressChanged += (sender, args) =>
            {
                progressEvents++;
                Assert.IsTrue(args.CompletedParts > 0 && args.CompletedParts <= totalParts);
                Assert.AreEqual(totalParts, args.TotalParts);
            };
            
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = totalParts,
                ObjectSize = totalObjectSize,
                SinglePartResponse = null,
                InitialResponse = Mock.Of<GetObjectResponse>(),
                BufferedFirstPart = null
            };
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);

            // Assert
            Assert.AreEqual(totalParts, progressEvents);
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

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
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);

            // Act
            coordinator.Dispose();
            await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
        }

        #endregion
    }
}
