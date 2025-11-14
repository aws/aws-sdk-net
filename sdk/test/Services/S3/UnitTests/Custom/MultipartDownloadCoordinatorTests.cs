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

        [TestMethod]
        public async Task StartDownloadsAsync_TracksActualBytesNotApproximation()
        {
            // Arrange - Setup 3 parts with different sizes to verify actual byte tracking
            var part1Size = 8 * 1024 * 1024;      // 8MB
            var part2Size = 8 * 1024 * 1024;      // 8MB
            var part3Size = 4 * 1024 * 1024;      // 4MB (last part is smaller!)
            var totalObjectSize = 20 * 1024 * 1024; // 20MB total
            var totalParts = 3;
            var targetPartSize = 8 * 1024 * 1024;  // Standard part size
            
            // Create mock responses with actual variable sizes
            var part1Response = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: part1Size,
                partsCount: totalParts,
                contentRange: $"bytes 0-{part1Size - 1}/{totalObjectSize}",
                eTag: "test-etag");
            
            var part2Response = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: part2Size,
                partsCount: totalParts,
                contentRange: $"bytes {part1Size}-{part1Size + part2Size - 1}/{totalObjectSize}",
                eTag: "test-etag");
            
            var part3Response = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: part3Size,  // Last part is smaller!
                partsCount: totalParts,
                contentRange: $"bytes {part1Size + part2Size}-{totalObjectSize - 1}/{totalObjectSize}",
                eTag: "test-etag");
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    return callCount switch
                    {
                        1 => Task.FromResult(part2Response.Object),
                        2 => Task.FromResult(part3Response.Object),
                        _ => throw new InvalidOperationException("Unexpected call")
                    };
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: targetPartSize,
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            // Track reported bytes to verify accurate accumulation
            var reportedBytesDownloaded = new List<long>();
            var reportedCompletedParts = new List<int>();
            
            coordinator.ProgressChanged += (sender, args) =>
            {
                reportedBytesDownloaded.Add(args.BytesDownloaded);
                reportedCompletedParts.Add(args.CompletedParts);
            };
            
            // Create buffered first part
            var buffer = ArrayPool<byte>.Shared.Rent(part1Size);
            var bufferedFirstPart = StreamPartBuffer.FromArrayPoolBuffer(1, buffer, part1Size);
            
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = totalParts,
                ObjectSize = totalObjectSize,
                SinglePartResponse = null,
                InitialResponse = part1Response.Object,
                BufferedFirstPart = bufferedFirstPart
            };
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);

            // Assert - verify ACTUAL bytes accumulated correctly (not approximation!)
            Assert.AreEqual(3, reportedBytesDownloaded.Count, "Should have 3 progress reports");
            
            // Part 1 (buffered): 8MB
            Assert.AreEqual(part1Size, reportedBytesDownloaded[0], 
                "Part 1: Should report actual 8MB");
            Assert.AreEqual(1, reportedCompletedParts[0]);
            
            // Part 2: 8MB + 8MB = 16MB accumulated
            Assert.AreEqual(part1Size + part2Size, reportedBytesDownloaded[1], 
                "Part 2: Should report accumulated 16MB");
            Assert.AreEqual(2, reportedCompletedParts[1]);
            
            // Part 3 (smaller last part): 8MB + 8MB + 4MB = 20MB accumulated
            Assert.AreEqual(part1Size + part2Size + part3Size, reportedBytesDownloaded[2], 
                "Part 3: Should report accumulated 20MB (actual total, not 24MB approximation!)");
            Assert.AreEqual(3, reportedCompletedParts[2]);
            
            // Verify we reached exactly the total object size (not an approximation)
            Assert.AreEqual(totalObjectSize, reportedBytesDownloaded[2],
                "Final reported bytes should match exact object size");
            
            // OLD BROKEN CODE would have reported: 8MB, 16MB, 24MB (wrong - uses partNum * targetPartSize)
            // NEW FIXED CODE correctly reports: 8MB, 16MB, 20MB (correct - uses actual accumulated bytes)
        }

        #endregion

        #region Validation Tests

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task Validation_ContentRange_MissingHeader_ThrowsException()
        {
            // Arrange - RANGE strategy with missing ContentRange in response
            var totalObjectSize = 20 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            // First part response for discovery (with ContentRange)
            var firstPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "test-etag");
            
            // Second part response WITHOUT ContentRange (invalid!)
            var secondPartResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: partSize,
                partsCount: null,
                contentRange: null,  // Missing ContentRange!
                eTag: "test-etag");
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    return callCount == 1
                        ? Task.FromResult(firstPartResponse.Object)
                        : Task.FromResult(secondPartResponse.Object);
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act - should throw when validating part 2's missing ContentRange
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task Validation_ContentRange_InvalidFormat_ThrowsException()
        {
            // Arrange - RANGE strategy with malformed ContentRange
            var totalObjectSize = 20 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            var firstPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "test-etag");
            
            // Second part with invalid ContentRange format
            var secondPartResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: partSize,
                partsCount: null,
                contentRange: "invalid-format-no-slash",  // Invalid format!
                eTag: "test-etag");
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    return callCount == 1
                        ? Task.FromResult(firstPartResponse.Object)
                        : Task.FromResult(secondPartResponse.Object);
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act - should throw when validating malformed ContentRange
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task Validation_ContentRange_UnparseableRange_ThrowsException()
        {
            // Arrange - RANGE strategy with unparseable range values
            var totalObjectSize = 20 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            var firstPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "test-etag");
            
            // Second part with unparseable range (letters instead of numbers)
            var secondPartResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: partSize,
                partsCount: null,
                contentRange: "bytes abc-xyz/20971520",  // Unparseable!
                eTag: "test-etag");
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    return callCount == 1
                        ? Task.FromResult(firstPartResponse.Object)
                        : Task.FromResult(secondPartResponse.Object);
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act - should throw when parsing invalid range values
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task Validation_ContentRange_RangeMismatch_ThrowsException()
        {
            // Arrange - RANGE strategy where response range doesn't match request
            var totalObjectSize = 20 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            var firstPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "test-etag");
            
            // Second part with WRONG range (should be 8388608-16777215, but returns 0-8388607)
            var secondPartResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: partSize,
                partsCount: null,
                contentRange: $"bytes 0-{partSize - 1}/{totalObjectSize}",  // Wrong range!
                eTag: "test-etag");
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    return callCount == 1
                        ? Task.FromResult(firstPartResponse.Object)
                        : Task.FromResult(secondPartResponse.Object);
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act - should throw with detailed mismatch message
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task Validation_ETag_Mismatch_ThrowsException()
        {
            // Arrange - ETag changes between discovery and download (object modified)
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            // Discovery returns one ETag
            var firstPartResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                partSize, totalParts, totalObjectSize, "original-etag");
            
            // Part 2 download returns DIFFERENT ETag (object was modified!)
            var secondPartResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                contentLength: partSize,
                partsCount: totalParts,
                contentRange: $"bytes {partSize}-{2 * partSize - 1}/{totalObjectSize}",
                eTag: "modified-etag");  // Different ETag!
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    return callCount == 1
                        ? Task.FromResult(firstPartResponse.Object)
                        : Task.FromResult(secondPartResponse.Object);
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act - should throw when ETag mismatch detected
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);
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
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act - should succeed with matching ETags
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);

            // Assert - no exception thrown
        }

        [TestMethod]
        public async Task Validation_ContentRange_ValidRange_Succeeds()
        {
            // Arrange - RANGE strategy with correct ContentRange
            var totalObjectSize = 20 * 1024 * 1024;
            var partSize = 8 * 1024 * 1024;
            
            // Both parts have correct ranges
            var firstPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "test-etag");
            
            var secondPartResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                partSize, 2 * partSize - 1, totalObjectSize, "test-etag");
            
            int callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    return callCount == 1
                        ? Task.FromResult(firstPartResponse.Object)
                        : Task.FromResult(secondPartResponse.Object);
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadCoordinator(mockClient.Object, request, config);
            
            var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(CancellationToken.None);
            
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            // Act - should succeed with valid ranges
            await coordinator.StartDownloadsAsync(discoveryResult, mockBufferManager.Object, CancellationToken.None);

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
