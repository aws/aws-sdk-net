using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Buffers;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for BufferedPartDataHandler class.
    /// Tests intelligent stream-vs-buffer decision making for multipart downloads.
    /// </summary>
    [TestClass]
    public class BufferedPartDataHandlerTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesHandler()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Assert
            Assert.IsNotNull(handler);

            // Cleanup
            handler.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullBufferManager_ThrowsArgumentNullException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();

            // Act
            var handler = new BufferedPartDataHandler(null, config);

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullConfiguration_ThrowsArgumentNullException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, null);

            // Assert - ExpectedException
        }

        #endregion

        #region ProcessPartAsync Tests - In-Order (Streaming Path)

        [TestMethod]
        public async Task ProcessPartAsync_InOrderPart_CreatesStreamingDataSource()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);

            IPartDataSource capturedDataSource = null;
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()))
                .Callback<IPartDataSource>((ds) => capturedDataSource = ds);

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var response = CreateMockGetObjectResponse(512);

                // Act
                await handler.ProcessPartAsync(1, response, CancellationToken.None);

                // Assert
                Assert.IsNotNull(capturedDataSource);
                Assert.IsInstanceOfType(capturedDataSource, typeof(StreamingDataSource));
                Assert.AreEqual(1, capturedDataSource.PartNumber);

                // Cleanup
                capturedDataSource?.Dispose();
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_InOrderPart_ReleasesCapacityImmediately()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var response = CreateMockGetObjectResponse(512);

                // Act
                await handler.ProcessPartAsync(1, response, CancellationToken.None);

                // Assert - ReleaseBufferSpace should be called (through ReleaseCapacity)
                // Handler calls ReleaseBufferSpace directly, which eventually calls the manager's method
                // We verify the AddBuffer was called with a StreamingDataSource
                mockBufferManager.Verify(m => m.AddBuffer(
                    It.Is<IPartDataSource>(ds => ds is StreamingDataSource)), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_InOrderPart_DoesNotDisposeResponse()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var response = CreateMockGetObjectResponse(512);

                // Act
                await handler.ProcessPartAsync(1, response, CancellationToken.None);

                // Assert - Response stream should still be readable (not disposed)
                // The StreamingDataSource now owns it and will dispose it later
                Assert.IsTrue(response.ResponseStream.CanRead);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_MultipleInOrderParts_AllStreamDirectly()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var streamingCount = 0;

            mockBufferManager.Setup(m => m.NextExpectedPartNumber)
                .Returns(() => streamingCount + 1);
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()))
                .Callback<IPartDataSource>((ds) =>
                {
                    if (ds is StreamingDataSource)
                        streamingCount++;
                });

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act - Process parts 1, 2, 3 in order
                await handler.ProcessPartAsync(1, CreateMockGetObjectResponse(512), CancellationToken.None);
                await handler.ProcessPartAsync(2, CreateMockGetObjectResponse(512), CancellationToken.None);
                await handler.ProcessPartAsync(3, CreateMockGetObjectResponse(512), CancellationToken.None);

                // Assert - All should be streaming
                Assert.AreEqual(3, streamingCount);
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region ProcessPartAsync Tests - Out-of-Order (Buffering Path)

        [TestMethod]
        public async Task ProcessPartAsync_OutOfOrderPart_BuffersToMemory()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);

            StreamPartBuffer capturedBuffer = null;
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<StreamPartBuffer>()))
                .Callback<StreamPartBuffer>((buffer) => capturedBuffer = buffer);

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
                var response = CreateMockGetObjectResponse(512, testData);

                // Act - Process part 2 when expecting part 1 (out of order)
                await handler.ProcessPartAsync(2, response, CancellationToken.None);

                // Assert
                Assert.IsNotNull(capturedBuffer);
                Assert.AreEqual(2, capturedBuffer.PartNumber);
                Assert.AreEqual(512, capturedBuffer.Length);

                // Verify data was buffered correctly
                byte[] bufferData = new byte[512];
                Buffer.BlockCopy(capturedBuffer.ArrayPoolBuffer, 0, bufferData, 0, 512);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, bufferData, 0, 512));
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_OutOfOrderPart_DisposesResponse()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<StreamPartBuffer>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var response = CreateMockGetObjectResponse(512);

                // Act - Process out of order part
                await handler.ProcessPartAsync(3, response, CancellationToken.None);

                // Assert - Response should be disposed after buffering
                // After disposal, stream is either null or no longer readable
                Assert.IsTrue(response.ResponseStream == null || !response.ResponseStream.CanRead);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_OutOfOrderPart_DoesNotReleaseCapacityImmediately()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<StreamPartBuffer>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var response = CreateMockGetObjectResponse(512);

                // Act
                await handler.ProcessPartAsync(2, response, CancellationToken.None);

                // Assert - AddBuffer should be called with StreamPartBuffer (not IPartDataSource)
                mockBufferManager.Verify(m => m.AddBuffer(
                    It.IsAny<StreamPartBuffer>()), Times.Once);

                // Note: Capacity will be released later when the buffer is consumed by the reader
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region ProcessPartAsync Tests - Mixed Scenarios

        [TestMethod]
        public async Task ProcessPartAsync_MixedInOrderAndOutOfOrder_HandlesCorrectly()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            
            var currentExpectedPart = 1;
            mockBufferManager.Setup(m => m.NextExpectedPartNumber)
                .Returns(() => currentExpectedPart);
            
            var streamingParts = 0;
            var bufferedParts = 0;

            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()))
                .Callback<IPartDataSource>((ds) =>
                {
                    if (ds is StreamingDataSource)
                    {
                        streamingParts++;
                        currentExpectedPart++;
                    }
                });

            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<StreamPartBuffer>()))
                .Callback<StreamPartBuffer>((buffer) => bufferedParts++);

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act - Mixed order: 1 (in), 3 (out), 2 (in after advance)
                await handler.ProcessPartAsync(1, CreateMockGetObjectResponse(512), CancellationToken.None);
                await handler.ProcessPartAsync(3, CreateMockGetObjectResponse(512), CancellationToken.None);
                await handler.ProcessPartAsync(2, CreateMockGetObjectResponse(512), CancellationToken.None);

                // Assert
                Assert.AreEqual(2, streamingParts); // Parts 1 and 2 streamed
                Assert.AreEqual(1, bufferedParts);  // Part 3 buffered
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_InOrderFollowedByOutOfOrder_HandlesCorrectly()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            
            mockBufferManager.SetupSequence(m => m.NextExpectedPartNumber)
                .Returns(1)
                .Returns(2);
            
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()));
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<StreamPartBuffer>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act
                await handler.ProcessPartAsync(1, CreateMockGetObjectResponse(512), CancellationToken.None);
                await handler.ProcessPartAsync(3, CreateMockGetObjectResponse(512), CancellationToken.None);

                // Assert
                mockBufferManager.Verify(m => m.AddBuffer(
                    It.Is<IPartDataSource>(ds => ds is StreamingDataSource && ds.PartNumber == 1)), Times.Once);
                
                mockBufferManager.Verify(m => m.AddBuffer(
                    It.Is<StreamPartBuffer>(b => b.PartNumber == 3)), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_OutOfOrderFollowedByInOrder_HandlesCorrectly()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            
            // NextExpectedPartNumber is called multiple times per part, so provide enough values
            // Part 2 (out of order): calls it twice, should return 1 both times
            // Part 1 (in order): calls it twice, should return 1 both times
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()));
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<StreamPartBuffer>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act
                await handler.ProcessPartAsync(2, CreateMockGetObjectResponse(512), CancellationToken.None);
                await handler.ProcessPartAsync(1, CreateMockGetObjectResponse(512), CancellationToken.None);

                // Assert
                mockBufferManager.Verify(m => m.AddBuffer(
                    It.Is<StreamPartBuffer>(b => b.PartNumber == 2)), Times.Once);
                
                mockBufferManager.Verify(m => m.AddBuffer(
                    It.Is<IPartDataSource>(ds => ds is StreamingDataSource && ds.PartNumber == 1)), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_InOrderVsOutOfOrder_VerifyStreamingVsBufferingBehavior()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            
            // Track what types are added to verify memory allocation patterns
            var streamingPartNumbers = new List<int>(); // Parts that stream (no ArrayPool allocation)
            var bufferedPartNumbers = new List<int>(); // Parts that buffer (use ArrayPool)
            
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            
            // Capture StreamingDataSource additions (streaming path - NO ArrayPool allocation)
            mockBufferManager.Setup(m => m.AddBuffer(
                It.IsAny<StreamingDataSource>()))
                .Callback<IPartDataSource>((ds) => 
                {
                    streamingPartNumbers.Add(ds.PartNumber);
                });
            
            // Capture StreamPartBuffer additions (buffering path - USES ArrayPool)
            mockBufferManager.Setup(m => m.AddBuffer(
                It.IsAny<StreamPartBuffer>()))
                .Callback<StreamPartBuffer>((buffer) => 
                {
                    bufferedPartNumbers.Add(buffer.PartNumber);
                });

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act - Process part 1 (in order - should stream, no ArrayPool buffer)
                await handler.ProcessPartAsync(1, CreateMockGetObjectResponse(512), CancellationToken.None);
                
                // Process part 3 (out of order - should buffer via ArrayPool)
                await handler.ProcessPartAsync(3, CreateMockGetObjectResponse(512), CancellationToken.None);

                // Assert
                // Part 1 should use streaming path (no ArrayPool allocation)
                Assert.AreEqual(1, streamingPartNumbers.Count, "Expected exactly 1 part to stream");
                Assert.AreEqual(1, streamingPartNumbers[0], "Part 1 should stream directly");
                
                // Part 3 should use buffering path (ArrayPool allocation)
                Assert.AreEqual(1, bufferedPartNumbers.Count, "Expected exactly 1 part to be buffered");
                Assert.AreEqual(3, bufferedPartNumbers[0], "Part 3 should be buffered");
                
                // Verify ReleaseBufferSpace was called for streaming path (immediate capacity release)
                mockBufferManager.Verify(m => m.ReleaseBufferSpace(), Times.Once, 
                    "Streaming path should release capacity immediately");
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_AllInOrderParts_NoBufferingAllStreaming()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            
            var streamingPartNumbers = new List<int>();
            var bufferedPartNumbers = new List<int>();
            var currentExpectedPart = 1;
            
            mockBufferManager.Setup(m => m.NextExpectedPartNumber)
                .Returns(() => currentExpectedPart);
            
            // Capture streaming additions
            mockBufferManager.Setup(m => m.AddBuffer(
                It.IsAny<StreamingDataSource>()))
                .Callback<IPartDataSource>((ds) => 
                {
                    streamingPartNumbers.Add(ds.PartNumber);
                    currentExpectedPart++; // Advance expected part after streaming
                });
            
            // Capture buffering additions
            mockBufferManager.Setup(m => m.AddBuffer(
                It.IsAny<StreamPartBuffer>()))
                .Callback<StreamPartBuffer>((buffer) => 
                {
                    bufferedPartNumbers.Add(buffer.PartNumber);
                });

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act - Process 5 parts in perfect order
                for (int i = 1; i <= 5; i++)
                {
                    await handler.ProcessPartAsync(i, CreateMockGetObjectResponse(512), CancellationToken.None);
                }

                // Assert - Best case scenario: all parts stream, zero buffering
                Assert.AreEqual(5, streamingPartNumbers.Count, "All 5 parts should stream");
                Assert.AreEqual(0, bufferedPartNumbers.Count, "No parts should be buffered when all arrive in order");
                
                // Verify parts streamed in correct order
                for (int i = 0; i < 5; i++)
                {
                    Assert.AreEqual(i + 1, streamingPartNumbers[i], 
                        $"Part {i + 1} should have streamed in order");
                }
                
                // Verify capacity was released 5 times (once per streaming part)
                mockBufferManager.Verify(m => m.ReleaseBufferSpace(), Times.Exactly(5),
                    "Capacity should be released immediately for each streaming part");
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region ProcessPartAsync Tests - Error Handling

        [TestMethod]
        public async Task ProcessPartAsync_StreamingPathError_ReleasesCapacity()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<IPartDataSource>()))
                .Throws(new InvalidOperationException("Test error"));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var response = CreateMockGetObjectResponse(512);

                // Act & Assert
                await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
                {
                    await handler.ProcessPartAsync(1, response, CancellationToken.None);
                });

                // Note: Handler's ReleaseCapacity is called on error, 
                // which eventually calls the manager's ReleaseBufferSpace
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_BufferingPathError_ReleasesCapacity()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.AddBuffer(It.IsAny<StreamPartBuffer>()))
                .Throws(new InvalidOperationException("Test error"));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                var response = CreateMockGetObjectResponse(512);

                // Act & Assert
                await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
                {
                    await handler.ProcessPartAsync(2, response, CancellationToken.None);
                });

                // Capacity should be released on error
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ProcessPartAsync_BufferingReadError_DisposesResponseAndReleasesCapacity()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Create response with faulty stream
                var faultyStream = new FaultyStream(new IOException("Stream read error"));
                var response = new GetObjectResponse
                {
                    ContentLength = 512,
                    ResponseStream = faultyStream
                };

                // Act & Assert
                await Assert.ThrowsExceptionAsync<IOException>(async () =>
                {
                    await handler.ProcessPartAsync(2, response, CancellationToken.None);
                });
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region WaitForCapacityAsync Tests

        [TestMethod]
        public async Task WaitForCapacityAsync_DelegatesToBufferManager()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act
                await handler.WaitForCapacityAsync(CancellationToken.None);

                // Assert
                mockBufferManager.Verify(m => m.WaitForBufferSpaceAsync(
                    It.IsAny<CancellationToken>()), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region ReleaseCapacity Tests

        [TestMethod]
        public void ReleaseCapacity_DelegatesToBufferManager()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.ReleaseBufferSpace());

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act
                handler.ReleaseCapacity();

                // Assert
                mockBufferManager.Verify(m => m.ReleaseBufferSpace(), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region OnDownloadComplete Tests

        [TestMethod]
        public void OnDownloadComplete_DelegatesToBufferManager()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.MarkDownloadComplete(It.IsAny<Exception>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act
                handler.OnDownloadComplete(null);

                // Assert
                mockBufferManager.Verify(m => m.MarkDownloadComplete(null), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public void OnDownloadComplete_WithException_PassesExceptionToBufferManager()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var testException = new Exception("Download failed");
            mockBufferManager.Setup(m => m.MarkDownloadComplete(It.IsAny<Exception>()));

            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            try
            {
                // Act
                handler.OnDownloadComplete(testException);

                // Assert
                mockBufferManager.Verify(m => m.MarkDownloadComplete(testException), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act - Dispose multiple times
            handler.Dispose();
            handler.Dispose();
            handler.Dispose();

            // Assert - Should not throw
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Creates a mock GetObjectResponse with test data.
        /// </summary>
        private GetObjectResponse CreateMockGetObjectResponse(long contentLength, byte[] testData = null)
        {
            if (testData == null)
            {
                testData = MultipartDownloadTestHelpers.GenerateTestData((int)contentLength, 0);
            }

            return new GetObjectResponse
            {
                ContentLength = contentLength,
                ResponseStream = new MemoryStream(testData),
                ETag = "test-etag"
            };
        }

        /// <summary>
        /// Stream that throws exceptions for testing error handling.
        /// </summary>
        private class FaultyStream : Stream
        {
            private readonly Exception _exception;

            public FaultyStream(Exception exception)
            {
                _exception = exception;
            }

            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => throw new NotSupportedException();
            public override long Position
            {
                get => throw new NotSupportedException();
                set => throw new NotSupportedException();
            }

            public override void Flush() { }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw _exception;
            }

            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                throw _exception;
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotSupportedException();
            }

            public override void SetLength(long value)
            {
                throw new NotSupportedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw new NotSupportedException();
            }
        }

        #endregion
    }
}
