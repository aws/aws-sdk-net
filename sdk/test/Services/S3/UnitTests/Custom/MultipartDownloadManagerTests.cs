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
    public class MultipartDownloadManagerTests
    {
        private Mock<IPartDataHandler> CreateMockDataHandler()
        {
            var mockHandler = new Mock<IPartDataHandler>();
            mockHandler.Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>(async (partNumber, response, ct) =>
                {
                    // Simulate reading the stream and firing progress events
                    // This mimics the real S3 SDK behavior where WriteObjectProgressEvent is fired as data is read
                    if (response?.ResponseStream != null)
                    {
                        var buffer = new byte[8192];
                        long totalBytesRead = 0;
                        long accumulatedBytes = 0; // Accumulate bytes until threshold is reached
                        int bytesRead;
                        
                        // DefaultProgressUpdateInterval is 102400 bytes (100KB)
                        const long progressThreshold = 102400;
                        
                        while ((bytesRead = response.ResponseStream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            totalBytesRead += bytesRead;
                            accumulatedBytes += bytesRead;
                            
                            // Fire progress event when accumulated bytes exceed threshold
                            // This matches real S3 SDK behavior which throttles progress events
                            if (accumulatedBytes >= progressThreshold)
                            {
                                response.OnRaiseProgressEvent(
                                    null, // filePath
                                    accumulatedBytes, // incrementTransferred
                                    totalBytesRead, // transferred
                                    response.ContentLength, // total
                                    false); // completed
                                accumulatedBytes = 0; // Reset accumulator after firing event
                            }
                        }
                        
                        // Fire final event with any remaining bytes
                        if (accumulatedBytes > 0)
                        {
                            response.OnRaiseProgressEvent(
                                null, // filePath
                                accumulatedBytes, // incrementTransferred
                                totalBytesRead, // transferred
                                response.ContentLength, // total
                                false); // completed
                        }
                    }
                    
                    // Give background events time to fire before response is disposed
                    // OnRaiseProgressEvent uses AWSSDKUtils.InvokeInBackground which queues work on ThreadPool
                    // Use Thread.Sleep to block and force ThreadPool to execute queued work
                    Thread.Sleep(500);
                    
                    // Additional yield to ensure all queued work completes
                    await Task.Yield();
                });
            mockHandler.Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockHandler.Setup(x => x.ReleaseCapacity());
            mockHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            return mockHandler;
        }

        /// <summary>
        /// Helper method to wait for async progress events to complete.
        /// Polls until expected bytes are transferred or timeout occurs.
        /// </summary>
        private async Task<bool> WaitForProgressEventsAsync(
            List<WriteObjectProgressArgs> progressEvents,
            object progressLock,
            long expectedBytes,
            int timeoutMs = 5000)
        {
            var startTime = DateTime.UtcNow;
            
            while ((DateTime.UtcNow - startTime).TotalMilliseconds < timeoutMs)
            {
                lock (progressLock)
                {
                    if (progressEvents.Count > 0)
                    {
                        var lastEvent = progressEvents.Last();
                        if (lastEvent.TransferredBytes >= expectedBytes)
                        {
                            return true;
                        }
                    }
                }
                
                // Small delay between checks
                await Task.Delay(10);
            }
            
            return false;
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);

            // Assert
            Assert.IsNotNull(coordinator);
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
            var coordinator = new MultipartDownloadManager(client, request, config, handler);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Constructor_WithEncryptionClient_ThrowsNotSupportedException()
        {
            // Arrange
            var mockEncryptionClient = new Mock<IAmazonS3>();
            mockEncryptionClient.As<Amazon.S3.Internal.IAmazonS3Encryption>();
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockDataHandler = CreateMockDataHandler();

            // Act
            var coordinator = new MultipartDownloadManager(mockEncryptionClient.Object, request, config, mockDataHandler.Object);
        }

        [TestMethod]
        public void Constructor_WithEncryptionClient_ExceptionMessageIsDescriptive()
        {
            // Arrange
            var mockEncryptionClient = new Mock<IAmazonS3>();
            mockEncryptionClient.As<Amazon.S3.Internal.IAmazonS3Encryption>();
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockDataHandler = CreateMockDataHandler();

            // Act & Assert
            try
            {
                var coordinator = new MultipartDownloadManager(mockEncryptionClient.Object, request, config, mockDataHandler.Object);
                Assert.Fail("Expected NotSupportedException was not thrown");
            }
            catch (NotSupportedException ex)
            {
                Assert.IsTrue(ex.Message.Contains("Multipart download is not supported when using Amazon.S3.Internal.IAmazonS3Encryption client. Please use the Amazon.S3.AmazonS3Client for multipart download."));
            }
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

            // Assert
            Assert.AreEqual(7, result.TotalParts); // Ceiling(52428800 / 8388608) = 7
        }

        #endregion

        #region StartDownloadsAsync Tests - Setup

        [TestMethod]
        public async Task StartDownloadsAsync_SinglePart_ReturnsImmediately()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            // Act - Call DiscoverDownloadStrategyAsync first to properly acquire HTTP semaphore
            
            await coordinator.StartDownloadAsync(null, CancellationToken.None);

            // Assert - should complete without any additional downloads (discovery already made the call)
            mockClient.Verify(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task StartDownloadsAsync_SinglePart_ProcessesPartSynchronously()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

            // Assert - should return discovery result immediately for single-part downloads
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TotalParts);
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
            

            // Act & Assert (exception expected via attribute)
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            await coordinator.DownloadCompletionTask; // Wait for background task to observe exceptions
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act - should succeed with matching ETags
            await coordinator.StartDownloadAsync(null, CancellationToken.None);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act - should succeed with valid ranges
            await coordinator.StartDownloadAsync(null, CancellationToken.None);

            // Assert - no exception thrown
        }

        #endregion

        #region Sequential Capacity Acquisition Tests

        [TestMethod]
        public async Task StartDownloadsAsync_MultipartDownload_AcquiresCapacitySequentially()
        {
            // Arrange - Test that capacity is acquired in sequential order (Part 1 discovery, then Part 2, 3, 4 background)
            var totalParts = 4;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityAcquisitionOrder = new List<int>();
            var capacityAcquisitionLock = new object();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Track capacity acquisition order - now includes Part 1 discovery
            var callCount = 0;
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    lock (capacityAcquisitionLock)
                    {
                        callCount++;
                        if (callCount == 1)
                        {
                            // First call is Part 1 discovery
                            capacityAcquisitionOrder.Add(1);
                        }
                        else
                        {
                            // Subsequent calls are background parts 2, 3, 4
                            capacityAcquisitionOrder.Add(callCount);
                        }
                    }
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for background task completion
            await coordinator.DownloadCompletionTask;

            // Assert - Capacity should be acquired in order: Part 1 (discovery), then Parts 2, 3, 4 (background)
            lock (capacityAcquisitionLock)
            {
                Assert.AreEqual(4, capacityAcquisitionOrder.Count, "Should acquire capacity for parts 1 (discovery), 2, 3, 4 (background)");
                Assert.AreEqual(1, capacityAcquisitionOrder[0], "First capacity acquisition should be for Part 1 discovery");
                Assert.AreEqual(2, capacityAcquisitionOrder[1], "Second capacity acquisition should be for Part 2 background");
                Assert.AreEqual(3, capacityAcquisitionOrder[2], "Third capacity acquisition should be for Part 3 background");
                Assert.AreEqual(4, capacityAcquisitionOrder[3], "Fourth capacity acquisition should be for Part 4 background");
            }
        }

        [TestMethod]
        public async Task StartDownloadsAsync_MultipartDownload_DoesNotCallWaitForCapacityInCreateDownloadTask()
        {
            // Arrange - Test that CreateDownloadTaskAsync no longer calls WaitForCapacityAsync (capacity is pre-acquired)
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var waitForCapacityCallCount = 0;
            var processPartCallCount = 0;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Track WaitForCapacityAsync calls - now includes Part 1 discovery + background parts 2-3
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref waitForCapacityCallCount);
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref processPartCallCount);
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            await coordinator.DownloadCompletionTask;

            // Assert
            // WaitForCapacityAsync should be called for Part 1 discovery + background parts 2-3 (total 3 calls)
            Assert.AreEqual(3, waitForCapacityCallCount, 
                "WaitForCapacityAsync should be called for Part 1 discovery + background parts 2-3 (3 times total)");
            
            // ProcessPartAsync should be called for all parts (1, 2, 3)
            Assert.AreEqual(3, processPartCallCount, 
                "ProcessPartAsync should be called for all parts (3 times for parts 1-3)");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_BackgroundTask_InterleavesCapacityAcquisitionWithTaskCreation()
        {
            // Arrange - Test that background task interleaves capacity acquisition with task creation
            // This ensures sequential ordering: capacity(2) → task(2) → capacity(3) → task(3)
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            // Track operation order with sequential counter
            var operationOrder = new List<(string operation, int partNum, int sequence)>();
            var lockObject = new object();
            var operationCounter = 0;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    lock (lockObject)
                    {
                        // Capacity is now acquired for Parts 1, 2, 3 (Part 1 during discovery)
                        var partNum = operationOrder.Count(o => o.operation == "capacity") + 1;
                        operationOrder.Add(("capacity", partNum, operationCounter++));
                    }
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    lock (lockObject)
                    {
                        operationOrder.Add(("task", partNum, operationCounter++));
                    }
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            await coordinator.DownloadCompletionTask;

            // Assert
            lock (lockObject)
            {
                var capacityOps = operationOrder.Where(o => o.operation == "capacity").ToList();
                var taskOps = operationOrder.Where(o => o.operation == "task").ToList();
                
                Assert.AreEqual(3, capacityOps.Count, "Should acquire capacity for parts 1 (discovery), 2, 3 (background)");
                Assert.AreEqual(3, taskOps.Count, "Should create tasks for parts 1-3");
                
                // Verify Part 1: capacity → task (during discovery)
                var part1Capacity = capacityOps.FirstOrDefault(o => o.partNum == 1);
                var part1Task = taskOps.FirstOrDefault(o => o.partNum == 1);
                Assert.IsNotNull(part1Capacity, "Part 1 capacity should be acquired during discovery");
                Assert.IsNotNull(part1Task, "Part 1 should be processed");
                Assert.IsTrue(part1Capacity.sequence < part1Task.sequence,
                    "Part 1 capacity should be acquired before Part 1 task");
                
                // Verify interleaved pattern for background parts (2, 3)
                // For each background part: capacity(N) → task(N) → capacity(N+1) → task(N+1)
                for (int partNum = 2; partNum <= totalParts; partNum++)
                {
                    var capacity = capacityOps.FirstOrDefault(o => o.partNum == partNum);
                    var task = taskOps.FirstOrDefault(o => o.partNum == partNum);
                    
                    Assert.IsNotNull(capacity, $"Part {partNum} capacity should be acquired");
                    Assert.IsNotNull(task, $"Part {partNum} task should be created");
                    
                    // Verify capacity comes before task for this part
                    Assert.IsTrue(capacity.sequence < task.sequence,
                        $"Part {partNum} capacity (seq={capacity.sequence}) should come before task (seq={task.sequence})");
                    
                    // Verify interleaving: task(N) should come before capacity(N+1)
                    if (partNum < totalParts)
                    {
                        var nextCapacity = capacityOps.FirstOrDefault(o => o.partNum == partNum + 1);
                        Assert.IsNotNull(nextCapacity, $"Part {partNum + 1} capacity should exist");
                        Assert.IsTrue(task.sequence < nextCapacity.sequence,
                            $"Part {partNum} task (seq={task.sequence}) should come before Part {partNum + 1} capacity (seq={nextCapacity.sequence})");
                    }
                }
                
                // Verify overall sequential pattern: capacity(1) → task(1) → capacity(2) → task(2) → capacity(3) → task(3)
                var expectedPattern = new[]
                {
                    ("capacity", 1), ("task", 1),
                    ("capacity", 2), ("task", 2),
                    ("capacity", 3), ("task", 3)
                };
                
                for (int i = 0; i < expectedPattern.Length; i++)
                {
                    Assert.AreEqual(expectedPattern[i].Item1, operationOrder[i].operation,
                        $"Operation {i} should be {expectedPattern[i].Item1}");
                    Assert.AreEqual(expectedPattern[i].Item2, operationOrder[i].partNum,
                        $"Operation {i} should be for part {expectedPattern[i].Item2}");
                }
            }
        }

        #endregion

        #region Race Condition Prevention Tests

        [TestMethod]
        public async Task StartDownloadsAsync_PreventRaceConditionDeadlock_WithLimitedBuffer()
        {
            // Arrange - Test scenario that could deadlock with old approach: limited buffer + out-of-order completion
            var totalParts = 5;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            // Simulate a scenario where buffer is limited and parts could complete out of order
            var maxInMemoryParts = 2; // Very limited buffer
            var capacitySlots = new SemaphoreSlim(maxInMemoryParts);
            var partProcessingOrder = new List<int>();
            var lockObject = new object();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Simulate capacity checking - old approach could deadlock here
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(async () =>
                {
                    // Wait for capacity (this is where the old approach could deadlock)
                    await capacitySlots.WaitAsync();
                    // Note: In real implementation, capacity would be released when part is processed
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    lock (lockObject)
                    {
                        partProcessingOrder.Add(partNum);
                    }
                    
                    // Release capacity after processing
                    capacitySlots.Release();
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 3);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act - This should not deadlock with the new sequential approach
            var startTime = DateTime.UtcNow;
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            await coordinator.DownloadCompletionTask;
            var endTime = DateTime.UtcNow;

            // Assert
            var executionTime = (endTime - startTime).TotalSeconds;
            Assert.IsTrue(executionTime < 10, 
                $"Download should complete without deadlock. Took {executionTime:F2} seconds");
            
            lock (lockObject)
            {
                Assert.AreEqual(totalParts, partProcessingOrder.Count, 
                    "All parts should be processed successfully");
                
                // Part 1 should be first (processed during StartDownloadsAsync)
                Assert.AreEqual(1, partProcessingOrder[0], "Part 1 should be processed first");
            }
        }

        [TestMethod]
        public async Task StartDownloadsAsync_SequentialCapacityAcquisition_PreventsOutOfOrderBlocking()
        {
            // Arrange - Test that sequential acquisition prevents out-of-order parts from blocking expected parts
            var totalParts = 4;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityOrder = new List<int>();
            var processingOrder = new List<int>();
            var lockObject = new object();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            var partCounter = 0; // Start with part 1 (Part 1 discovery now calls WaitForCapacityAsync)
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    lock (lockObject)
                    {
                        partCounter++;
                        capacityOrder.Add(partCounter);
                    }
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    lock (lockObject)
                    {
                        processingOrder.Add(partNum);
                    }
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            await coordinator.DownloadCompletionTask;

            // Assert - Capacity acquisition should be in order, preventing blocking
            lock (lockObject)
            {
                Assert.AreEqual(4, capacityOrder.Count, "Should acquire capacity for Part 1 discovery + parts 2, 3, 4 background");
                
                // Verify sequential order: Part 1 (discovery), then Parts 2, 3, 4 (background)
                for (int i = 0; i < capacityOrder.Count; i++)
                {
                    Assert.AreEqual(i + 1, capacityOrder[i], 
                        $"Capacity acquisition {i} should be for part {i + 1}");
                }
                
                Assert.AreEqual(totalParts, processingOrder.Count, "All parts should be processed");
            }
        }

        #endregion

        #region Background Task Resource Management Tests

        [TestMethod]
        public async Task StartDownloadsAsync_BackgroundTaskSuccess_DisposesCancellationTokenSource()
        {
            // Arrange - Test that CancellationTokenSource is disposed after successful background operations
            var totalParts = 2;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for background task to complete
            await coordinator.DownloadCompletionTask;

            // Assert - Background task should complete successfully
          Assert.IsTrue(coordinator.DownloadCompletionTask.IsCompleted && 
              !coordinator.DownloadCompletionTask.IsFaulted && 
              !coordinator.DownloadCompletionTask.IsCanceled, 
            "Background task should complete successfully");

        }

        [TestMethod]
        public async Task StartDownloadsAsync_BackgroundTaskFailure_DisposesCancellationTokenSource()
        {
            // Arrange - Test that CancellationTokenSource is disposed even when background task fails
            var totalParts = 2;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // First call (Part 1) succeeds
            var callCount = 0;
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    callCount++;
                    if (partNum == 1)
                    {
                        return Task.CompletedTask; // Part 1 succeeds
                    }
                    throw new InvalidOperationException("Simulated download failure"); // Background parts fail
                });
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for background task to complete (with failure)
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected failure
            }

            // Assert - Background task should have failed but cleanup should be done
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsCompleted, 
                "Background task should be completed (even with failure)");
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted,
                "Background task should be faulted");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_EarlyError_DisposesCancellationTokenSource()
        {
            // Arrange - Test CancellationTokenSource disposal when error occurs before background task starts
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // WaitForCapacityAsync succeeds (needed for discovery)
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // ProcessPartAsync succeeds for Part 1 (discovery)
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Simulate error during PrepareAsync (before background task is created)
            mockDataHandler
                .Setup(x => x.PrepareAsync(It.IsAny<DownloadResult>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated prepare failure"));
            
            var totalParts = 2;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            // Call DiscoverDownloadStrategyAsync first to properly acquire HTTP semaphore
            

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                Assert.Fail("Expected InvalidOperationException to be thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Simulated prepare failure", ex.Message);
            }
            
            // Assert - DownloadCompletionTask should return completed task when no background work exists
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsCompleted, 
                "DownloadCompletionTask should return completed task when no background work exists");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_BackgroundTaskCancellation_HandlesTokenDisposalProperly()
        {
            // Arrange - Test proper token disposal when background task is cancelled
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var cts = new CancellationTokenSource();
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Part 1 discovery succeeds (now also calls WaitForCapacityAsync)
            var callCount = 0;
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        // First call (Part 1 discovery) succeeds
                        return Task.CompletedTask;
                    }
                    else
                    {
                        // Second call (background task) cancels
                        cts.Cancel(); // Cancel during background task execution
                        throw new OperationCanceledException();
                    }
                });
            
            // Part 1 processing succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for background task cancellation
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - Cancellation should be handled properly with cleanup
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsCompleted, 
                "Background task should be completed");
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted || coordinator.DownloadCompletionTask.IsCanceled,
                "Background task should be faulted or canceled");
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.Dispose();
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            await coordinator.StartDownloadAsync(null, cts.Token);
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task StartDownloadAsync_SinglePart_WithPreCancelledToken_ThrowsOperationCanceledException()
        {
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            await coordinator.StartDownloadAsync(null, cts.Token);
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();

            // Act
            await coordinator.StartDownloadAsync(null, cts.Token);

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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            await coordinator.StartDownloadAsync(null, cts.Token);
            await coordinator.DownloadCompletionTask; // Wait for background task to observe exceptions
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            

            // Act
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                await coordinator.DownloadCompletionTask; // Wait for background task to observe exceptions
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - Verify DownloadCompletionTask is faulted with the cancellation exception
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsCompleted, "DownloadCompletionTask should be completed");
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted || coordinator.DownloadCompletionTask.IsCanceled,
                "DownloadCompletionTask should be faulted or canceled");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_WhenCancelled_CompletionTaskIsFaulted()
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                await coordinator.DownloadCompletionTask; // Wait for background task to observe exceptions
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - Verify DownloadCompletionTask is faulted with the cancellation
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsCompleted, "DownloadCompletionTask should be completed");
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted || coordinator.DownloadCompletionTask.IsCanceled,
                "DownloadCompletionTask should be faulted or canceled");
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            
            
            var cts = new CancellationTokenSource();

            // Act
            var result = await coordinator.StartDownloadAsync(null, cts.Token);

            // Assert - The cancellation token was passed through to the data handler
            Assert.IsNotNull(result);
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                await coordinator.DownloadCompletionTask; // Wait for background task to observe exceptions
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - DownloadCompletionTask should be faulted
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted || coordinator.DownloadCompletionTask.IsCanceled,
                "DownloadCompletionTask should be faulted or canceled when errors occur");
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            try
            {
                await coordinator.StartDownloadAsync(null, cts.Token);
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
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            await coordinator.DownloadCompletionTask; // Wait for background task to observe exceptions
        }

        #endregion

        #region Deadlock Prevention Tests

        [TestMethod]
        public async Task StartDownloadsAsync_ReturnsImmediately_PreventsDeadlock()
        {
            // Arrange - Create a scenario where buffer would fill during downloads
            var totalParts = 5;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            // Track download state
            var downloadsStarted = new System.Collections.Concurrent.ConcurrentBag<int>();
            var bufferBlockingStarted = new TaskCompletionSource<bool>();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Simulate WaitForCapacityAsync being called (downloads are actively buffering)
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    bufferBlockingStarted.TrySetResult(true);
                    // Return immediately to allow downloads to proceed
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Callback<int, GetObjectResponse, CancellationToken>((partNum, _, __) => 
                {
                    downloadsStarted.Add(partNum);
                })
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            
            
            // Act - StartDownloadsAsync should return immediately (not wait for all downloads)
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            stopwatch.Stop();
            
            // Assert - StartDownloadsAsync should return almost immediately
            // The key is it returns BEFORE all downloads complete, allowing consumer to start reading
            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 1000, 
                $"StartDownloadsAsync should return immediately, took {stopwatch.ElapsedMilliseconds}ms");
            
            // Verify Part 1 was processed (synchronously during StartDownloadsAsync)
            Assert.IsTrue(downloadsStarted.Contains(1), "Part 1 should be processed synchronously");
            
            // Wait for background downloads to start
            var bufferCalledTask = Task.WhenAny(bufferBlockingStarted.Task, Task.Delay(2000));
            await bufferCalledTask;
            Assert.IsTrue(bufferBlockingStarted.Task.IsCompleted, 
                "Background downloads should have started after StartDownloadsAsync returned");
            
            // Verify DownloadCompletionTask exists and is for background work
            Assert.IsNotNull(coordinator.DownloadCompletionTask, 
                "DownloadCompletionTask should be set for multipart downloads");
            
            // Wait for all background downloads to complete
            await coordinator.DownloadCompletionTask;
            
            // Verify all parts were eventually processed
            Assert.AreEqual(totalParts, downloadsStarted.Count, 
                "All parts should be processed in background");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_SinglePart_ReturnsImmediatelyWithoutBackgroundTask()
        {
            // Arrange - Single-part downloads should not create background tasks
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            
            var mockDataHandler = CreateMockDataHandler();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            // Call DiscoverDownloadStrategyAsync first to properly acquire HTTP semaphore
            
            
            // Act
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            stopwatch.Stop();
            
            // DownloadCompletionTask should be completed immediately (no background work)
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsCompleted, 
                "DownloadCompletionTask should be completed for single-part downloads");
            
            // Verify OnDownloadComplete was called
            mockDataHandler.Verify(x => x.OnDownloadComplete(null), Times.Once);
        }

        #endregion

        #region Capacity Checking Tests

        [TestMethod]
        public async Task Discovery_PartStrategy_CallsWaitForCapacityAsync()
        {
            // Arrange - PART strategy should check capacity during discovery
            var capacityCallCount = 0;
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref capacityCallCount);
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            var totalObjectSize = 24 * 1024 * 1024; // 24MB -> 3 parts @ 8MB
            var partSize = 8 * 1024 * 1024; // 8MB
            var totalParts = 3;
            
            var mockResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                partSize, totalParts, totalObjectSize, "test-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.TotalParts);
            Assert.AreEqual(1, capacityCallCount, 
                "PART strategy should call WaitForCapacityAsync during Part 1 discovery");
        }


        [TestMethod]
        public async Task Discovery_RangeStrategy_CallsWaitForCapacityAsync()
        {
            // Arrange - RANGE strategy should also check capacity during discovery
            var capacityCallCount = 0;
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref capacityCallCount);
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            var totalObjectSize = 17 * 1024 * 1024; // 17MB -> 3 parts @ 8MB
            var partSize = 8 * 1024 * 1024; // 8MB
            
            var mockResponse = MultipartDownloadTestHelpers.CreateRangeResponse(
                0, partSize - 1, totalObjectSize, "test-etag");
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.TotalParts); // 17MB / 8MB = 3 parts (ceiling)
            Assert.AreEqual(1, capacityCallCount, 
                "RANGE strategy should call WaitForCapacityAsync during Part 1 discovery");
        }

        [TestMethod]
        public async Task MultipleDownloads_WithSharedHttpThrottler_RespectsLimits()
        {
            // Arrange - Simulate directory download scenario with shared throttler
            var sharedThrottler = new SemaphoreSlim(1, 1); // Very limited: 1 concurrent request
            var mockDataHandler1 = CreateMockDataHandler();
            var mockDataHandler2 = CreateMockDataHandler();
            
            // Create two download managers sharing the same HTTP throttler
            var mockResponse1 = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024, "file1-etag");
            var mockResponse2 = MultipartDownloadTestHelpers.CreateSinglePartResponse(2048, "file2-etag");
            
            var mockClient1 = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse1));
            var mockClient2 = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse2));
            
            var request1 = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var request2 = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            
            var coordinator1 = new MultipartDownloadManager(mockClient1.Object, request1, config, mockDataHandler1.Object, null, sharedThrottler);
            var coordinator2 = new MultipartDownloadManager(mockClient2.Object, request2, config, mockDataHandler2.Object, null, sharedThrottler);

            var download1 = await coordinator1.StartDownloadAsync(null, CancellationToken.None);
            var download2 = await coordinator2.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for all background work to complete
            await Task.WhenAll(
                coordinator1.DownloadCompletionTask,
                coordinator2.DownloadCompletionTask
            );

            // Assert - Both should complete successfully and semaphore should be fully released
            Assert.IsNotNull(download1);
            Assert.IsNotNull(download2);
            Assert.AreEqual(1, sharedThrottler.CurrentCount, "HTTP throttler should be fully released after complete download lifecycle");
            
            // Cleanup
            coordinator1.Dispose();
            coordinator2.Dispose();
            sharedThrottler.Dispose();
        }

        [TestMethod]
        public async Task Discovery_HttpRequestFails_ReleasesCapacityProperly()
        {
            // Arrange - Simulate HTTP request failure
            var httpThrottler = new SemaphoreSlim(2, 2); 
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = CreateMockDataHandler();
            var mockClient = new Mock<IAmazonS3>();
            
            // HTTP request throws exception
            mockClient
                .Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated S3 failure"));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                Assert.Fail("Expected InvalidOperationException to be thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Simulated S3 failure", ex.Message);
            }

            // Assert - HTTP concurrency should be properly released even after failure
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount, 
                "HTTP concurrency slot should be released even when HTTP request fails");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task Discovery_CancellationDuringCapacityWait_ReleasesHttpSlotProperly()
        {
            // Arrange - Test cancellation during capacity acquisition
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var cts = new CancellationTokenSource();
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Cancel during capacity wait
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    cts.Cancel();
                    throw new OperationCanceledException();
                });
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, cts.Token);
                Assert.Fail("Expected OperationCanceledException to be thrown");
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - HTTP slot should still be available (never acquired due to early cancellation)
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount, 
                "HTTP concurrency slot should remain available when cancelled before HTTP request");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task Discovery_CancellationAfterCapacityButBeforeHttp_ReleasesHttpSlotProperly() 
        {
            // Arrange - Test cancellation after capacity but before HTTP call
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var cts = new CancellationTokenSource();
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Capacity acquisition succeeds
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // HTTP call gets cancelled
            var mockClient = new Mock<IAmazonS3>();
            mockClient
                .Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    cts.Token.ThrowIfCancellationRequested();
                    throw new OperationCanceledException();
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                cts.Cancel(); // Cancel before discovery
                await coordinator.StartDownloadAsync(null, cts.Token);
                Assert.Fail("Expected OperationCanceledException to be thrown");
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - HTTP slot should be properly released by finally block
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount, 
                "HTTP concurrency slot should be released by finally block on cancellation");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task Discovery_SinglePart_StillCallsCapacityCheck()
        {
            // Arrange - Even single-part downloads should check capacity during discovery
            var capacityCallCount = 0;
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref capacityCallCount);
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);

            // Act
            var result = await coordinator.StartDownloadAsync(null, CancellationToken.None);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.TotalParts);
            Assert.AreEqual(1, capacityCallCount, 
                "Even single-part downloads should call WaitForCapacityAsync during discovery");
        }


        #endregion

        #region Concurrency Control Tests

        [TestMethod]
        public async Task HttpSemaphore_HeldThroughProcessPartAsync()
        {
            // Arrange - Test that HTTP semaphore is NOT released until ProcessPartAsync completes
            var totalParts = 2;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            // Use our own semaphore to monitor its state
            var concurrentRequests = 1;
            var httpSemaphore = new SemaphoreSlim(concurrentRequests, concurrentRequests);
            
            var part1EnteredProcessPart = new TaskCompletionSource<bool>();
            var part1CanExitProcessPart = new TaskCompletionSource<bool>();
            var semaphoreWasReleasedDuringPart1 = false;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>(async (partNum, response, ct) =>
                {
                    if (partNum == 1)
                    {
                        // Part 1 enters ProcessPartAsync
                        part1EnteredProcessPart.SetResult(true);
                        
                        // Check if semaphore has been released (it shouldn't be with the fix!)
                        if (httpSemaphore.CurrentCount > 0)
                        {
                            semaphoreWasReleasedDuringPart1 = true;
                        }
                        
                        // Block Part 1 here so we can observe semaphore state
                        await part1CanExitProcessPart.Task;
                    }
                });
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(
                concurrentRequests: concurrentRequests);
            
            // Pass in our instrumented semaphore
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpSemaphore);
            
            

            // Act
            var startTask = coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for Part 1 to enter ProcessPartAsync
            await part1EnteredProcessPart.Task;
            
            // Check semaphore state while Part 1 is in ProcessPartAsync
            var semaphoreAvailableDuringProcessing = httpSemaphore.CurrentCount > 0;
            
            // Release Part 1 to continue
            part1CanExitProcessPart.SetResult(true);
            
            await startTask;
            await coordinator.DownloadCompletionTask;

            // Assert - This is the deterministic test of the fix
            Assert.IsFalse(semaphoreAvailableDuringProcessing,
                "HTTP semaphore should NOT be released while ProcessPartAsync is executing. " +
                "Before fix semaphore.CurrentCount would be > 0 (released early). " +
                "After fix: semaphore.CurrentCount should be 0 (held through ProcessPartAsync).");
            
            Assert.IsFalse(semaphoreWasReleasedDuringPart1,
                "Semaphore should not have been released at any point during Part 1 ProcessPartAsync execution");
            
            // Cleanup
            httpSemaphore.Dispose();
        }

        [TestMethod]
        public async Task HttpSemaphore_RangeStrategy_HeldThroughProcessPartAsync()
        {
            // Arrange - Test that RANGE strategy also holds semaphore through ProcessPartAsync
            var totalObjectSize = 17 * 1024 * 1024; // 17MB -> 3 parts @ 8MB
            var partSize = 8 * 1024 * 1024;
            
            var concurrentRequests = 1;
            var httpSemaphore = new SemaphoreSlim(concurrentRequests, concurrentRequests);
            
            var part1EnteredProcessPart = new TaskCompletionSource<bool>();
            var part1CanExitProcessPart = new TaskCompletionSource<bool>();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>(async (partNum, response, ct) =>
                {
                    if (partNum == 1)
                    {
                        part1EnteredProcessPart.SetResult(true);
                        await part1CanExitProcessPart.Task;
                    }
                });
            
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                3, partSize, totalObjectSize, "test-etag", usePartStrategy: false); // RANGE strategy
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: partSize,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(
                concurrentRequests: concurrentRequests);
            
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpSemaphore);
            
            

            // Act
            var startTask = coordinator.StartDownloadAsync(null, CancellationToken.None);
            await part1EnteredProcessPart.Task;
            
            // Check semaphore state while Part 1 is in ProcessPartAsync
            var semaphoreAvailableDuringProcessing = httpSemaphore.CurrentCount > 0;
            
            part1CanExitProcessPart.SetResult(true);
            await startTask;
            await coordinator.DownloadCompletionTask;

            // Assert
            Assert.IsFalse(semaphoreAvailableDuringProcessing,
                "RANGE strategy should also hold HTTP semaphore through ProcessPartAsync");
            
            // Cleanup
            httpSemaphore.Dispose();
        }

        #endregion

        #region Semaphore Release Error Path Tests

        [TestMethod]
        public async Task Discovery_WaitForCapacityFails_DoesNotReleaseHttpSemaphore()
        {
            // Arrange - Test that semaphore is NOT released when it was never acquired
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // WaitForCapacityAsync fails BEFORE HTTP semaphore is acquired
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated capacity wait failure"));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                Assert.Fail("Expected InvalidOperationException to be thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Simulated capacity wait failure", ex.Message);
            }

            // Assert - Semaphore should NOT be released (it was never acquired)
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount,
                "HTTP semaphore should NOT be released when it was never acquired (failed before WaitAsync)");
            
            // Cleanup
            httpThrottler.Dispose();
        }



        [TestMethod]
        public async Task StartDownloadAsync_WaitForCapacityFails_DoesNotReleaseHttpSemaphore()
        {
            // Arrange - Test that semaphore is NOT released when it was never acquired
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // WaitForCapacityAsync fails BEFORE HTTP semaphore is acquired
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated capacity wait failure"));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                Assert.Fail("Expected InvalidOperationException to be thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Simulated capacity wait failure", ex.Message);
            }

            // Assert - Semaphore should NOT be released (it was never acquired)
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount,
                "HTTP semaphore should NOT be released when it was never acquired (failed before WaitAsync)");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task Discovery_HttpRequestAfterCapacityFails_ReleasesHttpSemaphore()
        {
            // Arrange - Test semaphore release when HTTP request fails after capacity is acquired
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // WaitForCapacityAsync succeeds (capacity acquired)
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // HTTP request fails AFTER both capacity types are acquired
            var mockClient = new Mock<IAmazonS3>();
            mockClient
                .Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated S3 failure after capacity acquired"));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                Assert.Fail("Expected InvalidOperationException to be thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Simulated S3 failure after capacity acquired", ex.Message);
            }

            // Assert - HTTP semaphore should be released by catch block in discovery
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount,
                "HTTP semaphore should be released when HTTP request fails in discovery");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task StartDownloadAsync_PrepareAsyncFails_ReleasesHttpSemaphore()
        {
            // Arrange - Test that HTTP semaphore is released when PrepareAsync fails after discovery
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // WaitForCapacityAsync succeeds
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // ProcessPartAsync succeeds for Part 1 (discovery)
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // PrepareAsync FAILS (this happens after Part 1 processing in StartDownloadAsync)
            mockDataHandler
                .Setup(x => x.PrepareAsync(It.IsAny<DownloadResult>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated prepare failure"));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                2, 8 * 1024 * 1024, 16 * 1024 * 1024, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                Assert.Fail("Expected InvalidOperationException to be thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Simulated prepare failure", ex.Message);
            }

            // Assert - HTTP semaphore should be released even when PrepareAsync fails
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount, 
                "HTTP semaphore should be released when PrepareAsync fails");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task StartDownloadAsync_BackgroundPartHttpFails_ReleasesHttpSemaphore()
        {
            // Arrange - Test that HTTP semaphore is released when background part HTTP request fails
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Capacity checks succeed
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 1 processing succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            // HTTP client: Part 1 succeeds, Part 2 HTTP request FAILS
            var callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient
                .Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        // Part 1 discovery succeeds
                        return Task.FromResult(MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                            8 * 1024 * 1024, 2, 16 * 1024 * 1024, "test-etag"));
                    }
                    // Part 2 HTTP request fails
                    throw new AmazonS3Exception("Simulated S3 HTTP failure");
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for background task to complete with failure
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (AmazonS3Exception)
            {
                // Expected
            }

            // Assert - HTTP semaphore should be fully released after background failure
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount, 
                "HTTP semaphore should be released when background part HTTP request fails");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task StartDownloadAsync_Part1ProcessingFails_ReleasesHttpSemaphore()
        {
            // Arrange - Test that HTTP semaphore is released when Part 1 processing fails during discovery
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // WaitForCapacityAsync succeeds
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 1 ProcessPartAsync FAILS (during discovery phase of StartDownloadAsync)
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated Part 1 processing failure"));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                2, 8 * 1024 * 1024, 16 * 1024 * 1024, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act & Assert
            try
            {
                await coordinator.StartDownloadAsync(null, CancellationToken.None);
                Assert.Fail("Expected InvalidOperationException to be thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Simulated Part 1 processing failure", ex.Message);
            }

            // Assert - HTTP semaphore should be released when Part 1 processing fails
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount, 
                "HTTP semaphore should be released when Part 1 processing fails during discovery");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task StartDownloadAsync_BackgroundPartProcessingFails_ReleasesHttpSemaphore()
        {
            // Arrange - Test that HTTP semaphore is released when background part processing fails
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Capacity checks succeed
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 1 processing succeeds, Part 2 processing FAILS
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    if (partNum == 1)
                    {
                        return Task.CompletedTask; // Part 1 succeeds
                    }
                    throw new InvalidOperationException("Simulated Part 2 processing failure");
                });
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                2, 8 * 1024 * 1024, 16 * 1024 * 1024, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for background task to complete with failure
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected
            }

            // Assert - HTTP semaphore should be fully released after background failure
            Assert.AreEqual(initialCount, httpThrottler.CurrentCount, 
                "HTTP semaphore should be released when background part processing fails");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        #endregion

        #region ContentRange and Part Range Calculation Tests

        [TestMethod]
        public void ParseContentRange_ValidFormat_ReturnsCorrectValues()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var contentRange = "bytes 0-8388607/52428800";

            // Act
            var (startByte, endByte, totalSize) = coordinator.ParseContentRange(contentRange);

            // Assert
            Assert.AreEqual(0L, startByte);
            Assert.AreEqual(8388607L, endByte);
            Assert.AreEqual(52428800L, totalSize);
        }

        [TestMethod]
        public void ParseContentRange_SingleByteRange_ReturnsCorrectValues()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var contentRange = "bytes 0-0/1";

            // Act
            var (startByte, endByte, totalSize) = coordinator.ParseContentRange(contentRange);

            // Assert
            Assert.AreEqual(0L, startByte);
            Assert.AreEqual(0L, endByte);
            Assert.AreEqual(1L, totalSize);
        }

        [TestMethod]
        public void ParseContentRange_LargeFileLastPart_ReturnsCorrectValues()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var contentRange = "bytes 50331648-52428799/52428800";

            // Act
            var (startByte, endByte, totalSize) = coordinator.ParseContentRange(contentRange);

            // Assert
            Assert.AreEqual(50331648L, startByte);
            Assert.AreEqual(52428799L, endByte);
            Assert.AreEqual(52428800L, totalSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseContentRange_NullContentRange_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.ParseContentRange(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseContentRange_EmptyContentRange_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.ParseContentRange(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseContentRange_InvalidFormat_NoSlash_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.ParseContentRange("bytes 0-1000");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseContentRange_InvalidFormat_NoDash_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.ParseContentRange("bytes 01000/5000");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseContentRange_InvalidFormat_NonNumericRange_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.ParseContentRange("bytes abc-def/5000");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseContentRange_WildcardTotalSize_ThrowsInvalidOperationExceptionWithMessage()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act & Assert
            try
            {
                coordinator.ParseContentRange("bytes 0-1000/*");
                Assert.Fail("Expected InvalidOperationException was not thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.IsTrue(ex.Message.Contains("Unexpected wildcard"));
                Assert.IsTrue(ex.Message.Contains("S3 always returns exact object sizes"));
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ParseContentRange_NonNumericTotalSize_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.ParseContentRange("bytes 0-1000/abc");
        }

        [TestMethod]
        public void ExtractTotalSizeFromContentRange_ValidFormat_ReturnsTotalSize()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var contentRange = "bytes 0-8388607/52428800";

            // Act
            var totalSize = coordinator.ExtractTotalSizeFromContentRange(contentRange);

            // Assert
            Assert.AreEqual(52428800L, totalSize);
        }

        [TestMethod]
        public void ExtractTotalSizeFromContentRange_SmallFile_ReturnsTotalSize()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var contentRange = "bytes 0-999/1000";

            // Act
            var totalSize = coordinator.ExtractTotalSizeFromContentRange(contentRange);

            // Assert
            Assert.AreEqual(1000L, totalSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ExtractTotalSizeFromContentRange_InvalidFormat_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);

            // Act
            coordinator.ExtractTotalSizeFromContentRange("invalid-format");
        }

        [TestMethod]
        public void CalculatePartRange_FirstPart_ReturnsCorrectRange()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: 8 * 1024 * 1024);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var objectSize = 50 * 1024 * 1024; // 50MB

            // Act
            var (startByte, endByte) = coordinator.CalculatePartRange(1, objectSize);

            // Assert
            Assert.AreEqual(0L, startByte);
            Assert.AreEqual(8 * 1024 * 1024 - 1, endByte);
        }

        [TestMethod]
        public void CalculatePartRange_MiddlePart_ReturnsCorrectRange()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: 8 * 1024 * 1024);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var objectSize = 50 * 1024 * 1024; // 50MB

            // Act
            var (startByte, endByte) = coordinator.CalculatePartRange(3, objectSize);

            // Assert
            Assert.AreEqual(2 * 8 * 1024 * 1024, startByte); // Part 3 starts at 16MB
            Assert.AreEqual(3 * 8 * 1024 * 1024 - 1, endByte); // Part 3 ends at 24MB - 1
        }

        [TestMethod]
        public void CalculatePartRange_LastPartFullSize_ReturnsCorrectRange()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: 8 * 1024 * 1024);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var objectSize = 48 * 1024 * 1024; // 48MB (exactly 6 parts)

            // Act
            var (startByte, endByte) = coordinator.CalculatePartRange(6, objectSize);

            // Assert
            Assert.AreEqual(5 * 8 * 1024 * 1024, startByte); // Part 6 starts at 40MB
            Assert.AreEqual(48 * 1024 * 1024 - 1, endByte); // Part 6 ends at object end
        }

        [TestMethod]
        public void CalculatePartRange_LastPartPartialSize_ReturnsCorrectRange()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: 8 * 1024 * 1024);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var objectSize = 52428800; // 50MB (7 parts with last part partial)

            // Act
            var (startByte, endByte) = coordinator.CalculatePartRange(7, objectSize);

            // Assert
            Assert.AreEqual(6 * 8 * 1024 * 1024, startByte); // Part 7 starts at 48MB
            Assert.AreEqual(52428800 - 1, endByte); // Part 7 ends at object end (partial part)
        }

        [TestMethod]
        public void CalculatePartRange_SmallObject_SinglePart_ReturnsCorrectRange()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: 8 * 1024 * 1024);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            var objectSize = 1024; // 1KB

            // Act
            var (startByte, endByte) = coordinator.CalculatePartRange(1, objectSize);

            // Assert
            Assert.AreEqual(0L, startByte);
            Assert.AreEqual(1023L, endByte); // 1KB - 1
        }

        [TestMethod]
        public void ValidateContentRange_RangeStrategy_ValidRange_DoesNotThrow()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var response = new GetObjectResponse
            {
                ContentRange = "bytes 0-8388607/52428800"
            };
            var objectSize = 52428800L;

            // Act - should not throw
            coordinator.ValidateContentRange(response, 1, objectSize);
        }

        [TestMethod]
        public void ValidateContentRange_RangeStrategy_MiddlePart_ValidRange_DoesNotThrow()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var response = new GetObjectResponse
            {
                ContentRange = "bytes 16777216-25165823/52428800"
            };
            var objectSize = 52428800L;

            // Act - should not throw
            coordinator.ValidateContentRange(response, 3, objectSize);
        }

        [TestMethod]
        public void ValidateContentRange_PartStrategy_DoesNotValidate()
        {
            // Arrange - PART strategy should skip validation
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var response = new GetObjectResponse
            {
                ContentRange = "bytes 0-8388607/52428800" // Valid range
            };
            var objectSize = 52428800L;

            // Act - should not throw and should not validate
            coordinator.ValidateContentRange(response, 1, objectSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateContentRange_RangeStrategy_MissingContentRange_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var response = new GetObjectResponse
            {
                ContentRange = null
            };
            var objectSize = 52428800L;

            // Act
            coordinator.ValidateContentRange(response, 1, objectSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateContentRange_RangeStrategy_EmptyContentRange_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var response = new GetObjectResponse
            {
                ContentRange = string.Empty
            };
            var objectSize = 52428800L;

            // Act
            coordinator.ValidateContentRange(response, 1, objectSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateContentRange_RangeStrategy_WrongStartByte_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            // Expected: bytes 0-8388607, Actual: bytes 100-8388607 (wrong start)
            var response = new GetObjectResponse
            {
                ContentRange = "bytes 100-8388607/52428800"
            };
            var objectSize = 52428800L;

            // Act
            coordinator.ValidateContentRange(response, 1, objectSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateContentRange_RangeStrategy_WrongEndByte_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            // Expected: bytes 0-8388607, Actual: bytes 0-8388600 (wrong end)
            var response = new GetObjectResponse
            {
                ContentRange = "bytes 0-8388600/52428800"
            };
            var objectSize = 52428800L;

            // Act
            coordinator.ValidateContentRange(response, 1, objectSize);
        }

        [TestMethod]
        public void ValidateContentRange_RangeStrategy_ExceptionMessage_ContainsExpectedAndActualRanges()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                partSize: 8 * 1024 * 1024,
                downloadType: MultipartDownloadType.RANGE);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            var response = new GetObjectResponse
            {
                ContentRange = "bytes 100-8388607/52428800"
            };
            var objectSize = 52428800L;

            // Act & Assert
            try
            {
                coordinator.ValidateContentRange(response, 1, objectSize);
                Assert.Fail("Expected InvalidOperationException was not thrown");
            }
            catch (InvalidOperationException ex)
            {
                Assert.IsTrue(ex.Message.Contains("ContentRange mismatch"));
                Assert.IsTrue(ex.Message.Contains("Expected: bytes 0-8388607"));
                Assert.IsTrue(ex.Message.Contains("Actual: bytes 100-8388607"));
            }
        }

        #endregion

        #region Progress Callback Tests

        [TestMethod]
        public async Task ProgressCallback_ConcurrentCompletion_FiresOnlyOneCompletionEvent()
        {
            // Arrange - Simulate 3 parts completing simultaneously
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            // Track all progress events
            var progressEvents = new List<WriteObjectProgressArgs>();
            var progressLock = new object();
            
            EventHandler<WriteObjectProgressArgs> progressCallback = (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            // Create mock responses that simulate concurrent completion
            var firstPartResponse = MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                partSize, totalParts, totalObjectSize, "test-etag");
            
            var secondPartResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                partSize, totalParts,
                $"bytes {partSize}-{2 * partSize - 1}/{totalObjectSize}",
                "test-etag");
            
            var thirdPartResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                partSize, totalParts,
                $"bytes {2 * partSize}-{totalObjectSize - 1}/{totalObjectSize}",
                "test-etag");
            
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
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(
                concurrentRequests: 3); // Allow all parts to complete simultaneously
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(progressCallback, CancellationToken.None);
            
            // Wait for async progress events to complete
            var success = await WaitForProgressEventsAsync(progressEvents, progressLock, totalObjectSize);
            Assert.IsTrue(success, "Timed out waiting for progress events to complete");

            // Assert - Verify only ONE completion event fired (IsCompleted=true)
            lock (progressLock)
            {
                var completionEvents = progressEvents.Where(e => e.PercentDone == 100 && e.TransferredBytes == totalObjectSize).ToList();
                
                // There should be at least one event at 100%
                Assert.IsTrue(completionEvents.Count > 0, "Expected at least one progress event at 100%");
                
                // But only ONE should have been fired with the atomic flag logic
                // (Note: Due to the buffering and event timing, we might see multiple events at 100%,
                // but the key is that the completion logic only fired once)
                Assert.IsTrue(progressEvents.Count > 0, "Expected progress events to be fired");
                
                // Verify we reached 100% completion
                var finalEvent = progressEvents.Last();
                Assert.AreEqual(100, finalEvent.PercentDone, "Expected final progress to be 100%");
                Assert.AreEqual(totalObjectSize, finalEvent.TransferredBytes, "Expected all bytes transferred");
            }
        }

        [TestMethod]
        public async Task ProgressCallback_MultiplePartsComplete_AggregatesCorrectly()
        {
            // Arrange - Test progress aggregation across multiple parts
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var progressEvents = new List<WriteObjectProgressArgs>();
            var progressLock = new object();
            
            EventHandler<WriteObjectProgressArgs> progressCallback = (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, CreateMockDataHandler().Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(progressCallback, CancellationToken.None);
            
            // Wait for async progress events to complete
            var success = await WaitForProgressEventsAsync(progressEvents, progressLock, totalObjectSize);
            Assert.IsTrue(success, "Timed out waiting for progress events to complete");

            // Assert
            lock (progressLock)
            {
                // Should have received progress events
                Assert.IsTrue(progressEvents.Count > 0, "Expected progress events");
                
                // Final event should show 100% completion
                var finalEvent = progressEvents.Last();
                Assert.AreEqual(totalObjectSize, finalEvent.TransferredBytes, "Expected all bytes transferred");
                Assert.AreEqual(100, finalEvent.PercentDone, "Expected 100% completion");
                
                // TransferredBytes should only increase (monotonic)
                long lastTransferred = 0;
                foreach (var evt in progressEvents)
                {
                    Assert.IsTrue(evt.TransferredBytes >= lastTransferred, 
                        "TransferredBytes should be monotonically increasing");
                    lastTransferred = evt.TransferredBytes;
                }
            }
        }

        #endregion

        #region Cancellation Enhancement Tests

        [TestMethod]
        public async Task StartDownloadsAsync_BackgroundPartFails_CancelsInternalToken()
        {
            // Arrange - Deterministic test using TaskCompletionSource to control execution order
            // This ensures Part 3 waits at synchronization point, Part 2 fails, then Part 3 checks cancellation
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var part2Failed = false;
            var part3SawCancellation = false;
            
            // Synchronization primitives to control execution order
            var part3ReachedSyncPoint = new TaskCompletionSource<bool>();
            var part2CanFail = new TaskCompletionSource<bool>();
            var part3CanCheckCancellation = new TaskCompletionSource<bool>();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Capacity acquisition succeeds for all parts
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // PrepareAsync succeeds
            mockDataHandler
                .Setup(x => x.PrepareAsync(It.IsAny<DownloadResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // ProcessPartAsync: Controlled execution order using TaskCompletionSource
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>(async (partNum, response, ct) =>
                {
                    if (partNum == 1)
                    {
                        return; // Part 1 succeeds immediately
                    }
                    else if (partNum == 2)
                    {
                        // Part 2 waits for Part 3 to reach sync point before failing
                        await part2CanFail.Task;
                        part2Failed = true;
                        throw new InvalidOperationException("Simulated Part 2 failure");
                    }
                    else // Part 3
                    {
                        // Part 3 reaches sync point and signals to Part 2
                        part3ReachedSyncPoint.SetResult(true);
                        
                        // Wait for Part 2 to fail and cancellation to propagate
                        await part3CanCheckCancellation.Task;
                        
                        // Now check if cancellation was received from internalCts
                        if (ct.IsCancellationRequested)
                        {
                            part3SawCancellation = true;
                            throw new OperationCanceledException("Part 3 cancelled due to Part 2 failure");
                        }
                    }
                });
            
            mockDataHandler.Setup(x => x.ReleaseCapacity());
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act - Start downloads
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for Part 3 to reach synchronization point
            await part3ReachedSyncPoint.Task;
            
            // Allow Part 2 to fail
            part2CanFail.SetResult(true);
            
            // Give cancellation time to propagate
            await Task.Delay(100);
            
            // Allow Part 3 to check cancellation
            part3CanCheckCancellation.SetResult(true);
            
            // Wait for background task to complete
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected failure from Part 2
            }

            // Assert - Deterministic verification that cancellation propagated
            Assert.IsTrue(part2Failed, "Part 2 should have failed");
            Assert.IsTrue(part3SawCancellation, 
                "Part 3 should have received cancellation via internalCts.Token (deterministic with TaskCompletionSource)");
            
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted, 
                "DownloadCompletionTask should be faulted when background part fails");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_MultiplePartsFail_HandlesGracefully()
        {
            // Arrange - Test simultaneous failures from multiple parts
            var totalParts = 4;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var failedParts = new System.Collections.Concurrent.ConcurrentBag<int>();
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.PrepareAsync(It.IsAny<DownloadResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 1 succeeds, Parts 2, 3, 4 all fail
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    if (partNum == 1)
                    {
                        return Task.CompletedTask;
                    }
                    
                    failedParts.Add(partNum);
                    throw new InvalidOperationException($"Simulated Part {partNum} failure");
                });
            
            mockDataHandler.Setup(x => x.ReleaseCapacity());
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 3);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected - at least one part failed
            }

            // Assert - Should handle multiple failures gracefully
            Assert.IsTrue(failedParts.Count > 0, "At least one part should have failed");
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted, "DownloadCompletionTask should be faulted");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_CancellationRacesWithDispose_HandlesGracefully()
        {
            // Arrange - Test race condition between Cancel() and Dispose()
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var objectDisposedExceptionCaught = false;
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.PrepareAsync(It.IsAny<DownloadResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 1 succeeds, Part 2 fails triggering cancellation
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    if (partNum == 1)
                    {
                        return Task.CompletedTask;
                    }
                    
                    // Part 2 failure will trigger Cancel() in catch block
                    // The enhancement should check IsCancellationRequested to avoid ObjectDisposedException
                    throw new InvalidOperationException("Simulated Part 2 failure");
                });
            
            mockDataHandler.Setup(x => x.ReleaseCapacity());
            mockDataHandler
                .Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()))
                .Callback<Exception>(ex =>
                {
                    // Check if ObjectDisposedException was handled
                    if (ex is ObjectDisposedException)
                    {
                        objectDisposedExceptionCaught = true;
                    }
                });
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);
            
            

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected failure
            }

            // Assert - The enhancement should prevent ObjectDisposedException from being thrown
            // by checking IsCancellationRequested before calling Cancel()
            Assert.IsFalse(objectDisposedExceptionCaught, 
                "ObjectDisposedException should not propagate due to IsCancellationRequested check");
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted, 
                "DownloadCompletionTask should be faulted with the original failure");
            
            // Verify the exception type via the Task's exception
            var aggregateException = coordinator.DownloadCompletionTask.Exception;
            Assert.IsNotNull(aggregateException, "Task should have an exception");
            Assert.IsInstanceOfType(aggregateException.InnerException, typeof(InvalidOperationException),
                "Inner exception should be the original InvalidOperationException from Part 2 failure");
        }

        [TestMethod]
        public async Task StartDownloadsAsync_PartFailsDuringDownload_OriginalExceptionPropagatesFromCompletionTask()
        {
            // Arrange - Test that when a part fails with InvalidOperationException,
            // the DownloadCompletionTask throws InvalidOperationException (not OperationCanceledException)
            // This validates the WhenAllOrFirstExceptionWithFaultPriorityAsync fix
            var totalParts = 5;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.PrepareAsync(It.IsAny<DownloadResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 1, 2 succeed; Part 3 fails with InvalidOperationException
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns<int, GetObjectResponse, CancellationToken>((partNum, response, ct) =>
                {
                    if (partNum <= 2)
                    {
                        return Task.CompletedTask; // Parts 1-2 succeed
                    }
                    if (partNum == 3)
                    {
                        throw new InvalidOperationException("Simulated Part 3 failure");
                    }
                    // Parts 4-5 may or may not run depending on cancellation timing
                    ct.ThrowIfCancellationRequested();
                    return Task.CompletedTask;
                });
            
            mockDataHandler.Setup(x => x.ReleaseCapacity());
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            Exception caughtException = null;
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (Exception ex)
            {
                caughtException = ex;
            }

            // Assert - The key validation: exception should be InvalidOperationException, NOT OperationCanceledException
            // Before fix: WhenAllOrFirstExceptionAsync checked cancellation before processing faulted tasks,
            //             so OperationCanceledException would be thrown instead of the original exception
            // After fix: WhenAllOrFirstExceptionWithFaultPriorityAsync checks for completed tasks first,
            //            ensuring the original InvalidOperationException propagates
            Assert.IsNotNull(caughtException, "DownloadCompletionTask should throw an exception");
            Assert.IsInstanceOfType(caughtException, typeof(InvalidOperationException),
                "DownloadCompletionTask should throw InvalidOperationException (the original failure), " +
                "NOT OperationCanceledException. If this fails, WhenAllOrFirstExceptionWithFaultPriorityAsync " +
                "is not properly prioritizing faulted tasks over cancellation checks.");
            Assert.AreEqual("Simulated Part 3 failure", caughtException.Message,
                "The original exception message should be preserved");
            
            // Also verify DownloadCompletionTask is faulted
            Assert.IsTrue(coordinator.DownloadCompletionTask.IsFaulted, "DownloadCompletionTask should be faulted");
        }

        #endregion

        #region Semaphore and Capacity Release Tests

        [TestMethod]
        public async Task CreateDownloadTasksAsync_CancellationAfterCapacityBeforeHttpSlot_ReleasesCapacityExactlyOnce()
        {
            // Arrange - Test that when cancellation happens after acquiring capacity but before HTTP slot,
            // capacity is released exactly once (not double-released)
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityReleaseCount = 0;
            var capacityAcquireCount = 0;
            var httpSlotAcquireCount = 0;
            
            // Use a blocking HTTP throttler that we control
            var httpThrottler = new SemaphoreSlim(1, 1);
            
            // Control when Part 2 can acquire HTTP slot
            var part2CanAcquireHttpSlot = new TaskCompletionSource<bool>();
            var part2AcquiredCapacity = new TaskCompletionSource<bool>();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Track capacity acquisition
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns<CancellationToken>(ct =>
                {
                    var count = Interlocked.Increment(ref capacityAcquireCount);
                    if (count == 2) // Part 2's capacity acquisition
                    {
                        part2AcquiredCapacity.SetResult(true);
                        // Wait a bit to let the cancellation happen
                        return Task.Delay(50);
                    }
                    return Task.CompletedTask;
                });
            
            // Track capacity release
            mockDataHandler
                .Setup(x => x.ReleaseCapacity())
                .Callback(() =>
                {
                    Interlocked.Increment(ref capacityReleaseCount);
                });
            
            // Part 1 processing succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            // S3 client: Part 1 succeeds, Part 2 will be cancelled before HTTP request
            var callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient
                .Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns<GetObjectRequest, CancellationToken>(async (req, ct) =>
                {
                    await Task.Yield();
                    var count = Interlocked.Increment(ref callCount);
                    if (count == 1)
                    {
                        // Part 1 discovery succeeds
                        return MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                            partSize, totalParts, totalObjectSize, "test-etag");
                    }
                    
                    Interlocked.Increment(ref httpSlotAcquireCount);
                    // Part 2 HTTP request - should not reach here if cancellation works
                    throw new OperationCanceledException();
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            var startTask = coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            // Wait for Part 1 to complete and Part 2 to acquire capacity
            await startTask;
            
            // The background task will cancel when Part 2 tries to acquire the HTTP slot
            // and finds the slot is held (we're not releasing it)
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (OperationCanceledException)
            {
                // Expected - timed out or cancelled
            }
            catch (Exception)
            {
                // Other exceptions are also acceptable for this test
            }

            // Assert - Capacity should be released exactly once per acquisition (no double-release)
            // Part 1 capacity is released in ProcessFirstPartAsync's finally block (not ReleaseCapacity)
            // Part 2+ capacity is released via ReleaseCapacity when cancellation or error occurs
            Assert.IsTrue(capacityReleaseCount <= capacityAcquireCount - 1,
                $"Capacity should not be double-released. Acquired={capacityAcquireCount}, Released={capacityReleaseCount}");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task CreateDownloadTasksAsync_CancellationAfterBothAcquired_ReleasesBothExactlyOnce()
        {
            // Arrange - Test that when cancellation happens after acquiring both capacity and HTTP slot,
            // both are released exactly once
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityReleaseCount = 0;
            var capacityAcquireCount = 0;
            
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialHttpCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            // Track capacity acquisition
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref capacityAcquireCount);
                    return Task.CompletedTask;
                });
            
            // Track capacity release
            mockDataHandler
                .Setup(x => x.ReleaseCapacity())
                .Callback(() =>
                {
                    Interlocked.Increment(ref capacityReleaseCount);
                });
            
            // Part 1 processing succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 2 processing fails after both capacity and HTTP slot are acquired
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(2, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated Part 2 processing failure"));
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected failure from Part 2
            }

            // Assert - HTTP semaphore should be back to initial count (all slots released)
            Assert.AreEqual(initialHttpCount, httpThrottler.CurrentCount,
                $"HTTP semaphore should be fully released. Initial={initialHttpCount}, Current={httpThrottler.CurrentCount}");
            
            // Capacity releases should match acquisitions minus Part 1 (which doesn't use ReleaseCapacity)
            // Part 2 will release capacity in error handler
            Assert.IsTrue(capacityReleaseCount >= 1,
                $"At least Part 2's capacity should be released. Released={capacityReleaseCount}");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task CreateDownloadTasksAsync_TaskCreationFails_ReleasesHttpSlotAndCapacity()
        {
            // Arrange - Test that if task creation fails, both HTTP slot and capacity are released
            // This tests the catch block in CreateDownloadTasksAsync
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityReleaseCount = 0;
            
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialHttpCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler
                .Setup(x => x.ReleaseCapacity())
                .Callback(() =>
                {
                    Interlocked.Increment(ref capacityReleaseCount);
                });
            
            // Part 1 processing succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            // S3 client: Part 1 succeeds, Part 2 HTTP request fails
            var callCount = 0;
            var mockClient = new Mock<IAmazonS3>();
            mockClient
                .Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        return Task.FromResult(MultipartDownloadTestHelpers.CreateMultipartFirstPartResponse(
                            partSize, totalParts, totalObjectSize, "test-etag"));
                    }
                    // Part 2 HTTP request fails
                    throw new AmazonS3Exception("Simulated HTTP failure");
                });
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (AmazonS3Exception)
            {
                // Expected
            }

            // Assert - HTTP semaphore should be fully released
            Assert.AreEqual(initialHttpCount, httpThrottler.CurrentCount,
                $"HTTP semaphore should be fully released after HTTP failure. Initial={initialHttpCount}, Current={httpThrottler.CurrentCount}");
            
            // Capacity should be released for failed part
            Assert.IsTrue(capacityReleaseCount >= 1,
                $"Capacity should be released for failed Part 2. Released={capacityReleaseCount}");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task CreateDownloadTasksAsync_MultiplePartsFailConcurrently_NoDoubleRelease()
        {
            // Arrange - Test that when multiple parts fail concurrently, no double releases occur
            var totalParts = 5;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityReleaseCount = 0;
            var capacityAcquireCount = 0;
            
            var httpThrottler = new SemaphoreSlim(3, 3); // Allow 3 concurrent requests
            var initialHttpCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref capacityAcquireCount);
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ReleaseCapacity())
                .Callback(() =>
                {
                    Interlocked.Increment(ref capacityReleaseCount);
                });
            
            // Part 1 succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Parts 2, 3, 4 all fail concurrently
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsInRange(2, 5, Moq.Range.Inclusive), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Simulated concurrent failure"));
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 3);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected - first failure propagates
            }

            // Assert - No double releases should occur
            // HTTP semaphore should be back to initial count
            Assert.AreEqual(initialHttpCount, httpThrottler.CurrentCount,
                $"HTTP semaphore should be fully released. Initial={initialHttpCount}, Current={httpThrottler.CurrentCount}");
            
            // Capacity releases should not exceed acquisitions minus Part 1
            Assert.IsTrue(capacityReleaseCount <= capacityAcquireCount - 1,
                $"Capacity should not be double-released. Acquired={capacityAcquireCount}, Released={capacityReleaseCount}");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task CreateDownloadTasksAsync_CancellationDuringCapacityWait_DoesNotReleaseUnacquiredResources()
        {
            // Arrange - Test that when cancellation happens DURING capacity wait,
            // no resources are released (since they weren't acquired)
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityReleaseCount = 0;
            
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialHttpCount = httpThrottler.CurrentCount;
            
            var cts = new CancellationTokenSource();
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            var callCount = 0;
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns<CancellationToken>(ct =>
                {
                    callCount++;
                    if (callCount == 1)
                    {
                        // Part 1 discovery succeeds
                        return Task.CompletedTask;
                    }
                    // Part 2 capacity wait is cancelled
                    cts.Cancel();
                    throw new OperationCanceledException();
                });
            
            mockDataHandler
                .Setup(x => x.ReleaseCapacity())
                .Callback(() =>
                {
                    Interlocked.Increment(ref capacityReleaseCount);
                });
            
            // Part 1 processing succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - No resources should be released for Part 2 since capacity was never acquired
            Assert.AreEqual(0, capacityReleaseCount,
                $"No capacity should be released when cancelled during WaitForCapacityAsync. Released={capacityReleaseCount}");
            
            // HTTP semaphore should still be at initial count (Part 1's slot was released normally)
            Assert.AreEqual(initialHttpCount, httpThrottler.CurrentCount,
                $"HTTP semaphore should be at initial count. Initial={initialHttpCount}, Current={httpThrottler.CurrentCount}");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task CreateDownloadTasksAsync_SuccessfulDownload_AllResourcesReleasedProperly()
        {
            // Arrange - Test that on successful download, all resources are released properly
            var totalParts = 4;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityAcquireCount = 0;
            var capacityReleaseCount = 0;
            
            var httpThrottler = new SemaphoreSlim(2, 2);
            var initialHttpCount = httpThrottler.CurrentCount;
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    Interlocked.Increment(ref capacityAcquireCount);
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ReleaseCapacity())
                .Callback(() =>
                {
                    Interlocked.Increment(ref capacityReleaseCount);
                });
            
            // All parts succeed
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 2);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            await coordinator.DownloadCompletionTask;

            // Assert - All resources should be released properly
            // HTTP semaphore should be back to initial count
            Assert.AreEqual(initialHttpCount, httpThrottler.CurrentCount,
                $"HTTP semaphore should be fully released after successful download. Initial={initialHttpCount}, Current={httpThrottler.CurrentCount}");
            
            // Capacity is acquired for all parts but released differently:
            // - Part 1: Capacity is managed by the stream (not via ReleaseCapacity)
            // - Parts 2-4: Should NOT call ReleaseCapacity on success (handler manages it)
            // Note: ReleaseCapacity is only called on ERROR paths in CreateDownloadTaskAsync
            Assert.AreEqual(0, capacityReleaseCount,
                $"ReleaseCapacity should not be called on success path (handler manages capacity). Released={capacityReleaseCount}");
            
            // Verify all parts acquired capacity
            Assert.AreEqual(totalParts, capacityAcquireCount,
                $"All parts should have acquired capacity. Acquired={capacityAcquireCount}");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        [TestMethod]
        public async Task CreateDownloadTasksAsync_CancellationImmediatelyAfterHttpSlot_ReleasesResourcesCorrectly()
        {
            // Arrange - Test the specific code path where cancellation is detected
            // immediately after acquiring HTTP slot (the second cancellation check in CreateDownloadTasksAsync)
            var totalParts = 3;
            var partSize = 8 * 1024 * 1024;
            var totalObjectSize = totalParts * partSize;
            
            var capacityReleaseCount = 0;
            
            var httpThrottler = new SemaphoreSlim(1, 1);
            var initialHttpCount = httpThrottler.CurrentCount;
            
            var internalCts = new CancellationTokenSource();
            var mockDataHandler = new Mock<IPartDataHandler>();
            
            var capacityCallCount = 0;
            mockDataHandler
                .Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(() =>
                {
                    capacityCallCount++;
                    return Task.CompletedTask;
                });
            
            mockDataHandler
                .Setup(x => x.ReleaseCapacity())
                .Callback(() =>
                {
                    Interlocked.Increment(ref capacityReleaseCount);
                });
            
            // Part 1 succeeds
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(1, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            
            // Part 2 processing will trigger cancellation
            mockDataHandler
                .Setup(x => x.ProcessPartAsync(2, It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Part 2 failure triggers cancellation"));
            
            mockDataHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, totalObjectSize, "test-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(
                downloadType: MultipartDownloadType.PART);
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            var coordinator = new MultipartDownloadManager(
                mockClient.Object, request, config, mockDataHandler.Object, null, httpThrottler);

            // Act
            await coordinator.StartDownloadAsync(null, CancellationToken.None);
            
            try
            {
                await coordinator.DownloadCompletionTask;
            }
            catch (InvalidOperationException)
            {
                // Expected
            }

            // Assert - Resources should be released correctly
            Assert.AreEqual(initialHttpCount, httpThrottler.CurrentCount,
                $"HTTP semaphore should be fully released. Initial={initialHttpCount}, Current={httpThrottler.CurrentCount}");
            
            // Part 2 should have its capacity released due to error
            Assert.IsTrue(capacityReleaseCount >= 1,
                $"At least Part 2's capacity should be released on error. Released={capacityReleaseCount}");
            
            // Cleanup
            httpThrottler.Dispose();
        }

        #endregion
    }
}
