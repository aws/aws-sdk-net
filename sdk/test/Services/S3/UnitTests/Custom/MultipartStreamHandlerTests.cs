using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for MultipartStreamHandler class.
    /// Tests stream handler functionality that coordinates with buffer manager for sequential reading.
    /// </summary>
    [TestClass]
    public class MultipartStreamHandlerTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidPartBufferManager_CreatesHandler()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            var handler = new MultipartStreamHandler(mockBufferManager.Object);

            // Assert
            Assert.IsNotNull(handler);

            // Cleanup
            handler.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullPartBufferManager_ThrowsArgumentNullException()
        {
            // Act
            var handler = new MultipartStreamHandler(null);

            // Assert - ExpectedException
        }

        #endregion

        #region ReadAsync - Happy Path Tests

        [TestMethod]
        public async Task ReadAsync_DelegatesToPartBufferManager()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(512);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                int bytesRead = await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(512, bytesRead);
                mockBufferManager.Verify(m => m.ReadPartAsync(1, buffer, 0, 512, CancellationToken.None), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_ReturnsCorrectByteCount()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(256);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                int bytesRead = await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(256, bytesRead);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_WhenEndOfStream_ReturnsZero()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(5);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(0);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                int bytesRead = await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(0, bytesRead);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_PassesCancellationTokenCorrectly()
        {
            // Arrange
            var cts = new CancellationTokenSource();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(512);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                await handler.ReadAsync(buffer, 0, 512, cts.Token);

                // Assert
                mockBufferManager.Verify(m => m.ReadPartAsync(
                    It.IsAny<int>(),
                    It.IsAny<byte[]>(),
                    It.IsAny<int>(),
                    It.IsAny<int>(),
                    cts.Token), Times.Once);
            }
            finally
            {
                handler.Dispose();
                cts.Dispose();
            }
        }

        #endregion

        #region ReadAsync - Parameter Validation Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task ReadAsync_WithNullBuffer_ThrowsArgumentNullException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);

            try
            {
                // Act
                await handler.ReadAsync(null, 0, 512, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeOffset_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                await handler.ReadAsync(buffer, -1, 512, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeCount_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                await handler.ReadAsync(buffer, 0, -1, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task ReadAsync_WithOffsetCountExceedingBounds_ThrowsArgumentException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[512];

            try
            {
                // Act - offset + count > buffer.Length
                await handler.ReadAsync(buffer, 400, 200, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region ReadAsync - Delegation Tests

        [TestMethod]
        public async Task ReadAsync_UsesNextExpectedPartNumber()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(3);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(512);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);

                // Assert - Should use part number 3
                mockBufferManager.Verify(m => m.ReadPartAsync(3, buffer, 0, 512, CancellationToken.None), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_PassesBufferParametersCorrectly()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(300);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act
                await handler.ReadAsync(buffer, 100, 300, CancellationToken.None);

                // Assert
                mockBufferManager.Verify(m => m.ReadPartAsync(1, buffer, 100, 300, CancellationToken.None), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_MultipleCalls_UsesUpdatedPartNumbers()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var partNumberSequence = new[] { 1, 2, 3 };
            var callCount = 0;
            
            mockBufferManager.Setup(m => m.NextExpectedPartNumber)
                .Returns(() => partNumberSequence[callCount]);
            
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(512)
                .Callback(() => callCount++);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act - Multiple reads
                await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);
                await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);
                await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);

                // Assert - Should have called with parts 1, 2, and 3
                mockBufferManager.Verify(m => m.ReadPartAsync(1, buffer, 0, 512, CancellationToken.None), Times.Once);
                mockBufferManager.Verify(m => m.ReadPartAsync(2, buffer, 0, 512, CancellationToken.None), Times.Once);
                mockBufferManager.Verify(m => m.ReadPartAsync(3, buffer, 0, 512, CancellationToken.None), Times.Once);
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion

        #region ReadAsync - Error Handling Tests

        [TestMethod]
        public async Task ReadAsync_WhenPartBufferManagerThrows_PropagatesException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ThrowsAsync(new InvalidOperationException("Test exception"));

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act & Assert
                await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
                {
                    await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);
                });
            }
            finally
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_WithCancellation_PropagatesOperationCanceledException()
        {
            // Arrange
            var cts = new CancellationTokenSource();
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(m => m.NextExpectedPartNumber).Returns(1);
            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ThrowsAsync(new OperationCanceledException());

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act & Assert
                await Assert.ThrowsExceptionAsync<OperationCanceledException>(async () =>
                {
                    await handler.ReadAsync(buffer, 0, 512, cts.Token);
                });
            }
            finally
            {
                handler.Dispose();
                cts.Dispose();
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_MarksHandlerAsDisposed()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);

            // Act
            handler.Dispose();

            // Assert - Further operations should throw ObjectDisposedException
            byte[] buffer = new byte[1024];
            Assert.ThrowsExceptionAsync<ObjectDisposedException>(async () =>
            {
                await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);
            }).Wait();
        }

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);

            // Act - Dispose multiple times
            handler.Dispose();
            handler.Dispose();
            handler.Dispose();

            // Assert - Should not throw
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public async Task ReadAsync_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            // Dispose the handler
            handler.Dispose();

            // Act - Try to read after disposal
            await handler.ReadAsync(buffer, 0, 512, CancellationToken.None);

            // Assert - ExpectedException
        }

        [TestMethod]
        public void Dispose_DoesNotDisposePartBufferManager()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var handler = new MultipartStreamHandler(mockBufferManager.Object);

            // Act
            handler.Dispose();

            // Assert - PartBufferManager.Dispose should NOT be called
            // (it's owned by the coordinator, not the handler)
            mockBufferManager.Verify(m => m.Dispose(), Times.Never);
        }

        #endregion

        #region Integration-Style Tests

        [TestMethod]
        public async Task ReadAsync_CompleteReadSequence_WorksCorrectly()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var partNumbers = new[] { 1, 1, 2, 2, 3 };
            var bytesReturned = new[] { 512, 488, 512, 488, 0 }; // Partial reads, then EOF
            var callIndex = 0;

            mockBufferManager.Setup(m => m.NextExpectedPartNumber)
                .Returns(() => partNumbers[callIndex]);

            mockBufferManager.Setup(m => m.ReadPartAsync(
                It.IsAny<int>(),
                It.IsAny<byte[]>(),
                It.IsAny<int>(),
                It.IsAny<int>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => bytesReturned[callIndex++]);

            var handler = new MultipartStreamHandler(mockBufferManager.Object);
            byte[] buffer = new byte[1024];

            try
            {
                // Act & Assert - Simulate reading entire stream
                int bytesRead1 = await handler.ReadAsync(buffer, 0, 1024, CancellationToken.None);
                Assert.AreEqual(512, bytesRead1);

                int bytesRead2 = await handler.ReadAsync(buffer, 0, 1024, CancellationToken.None);
                Assert.AreEqual(488, bytesRead2);

                int bytesRead3 = await handler.ReadAsync(buffer, 0, 1024, CancellationToken.None);
                Assert.AreEqual(512, bytesRead3);

                int bytesRead4 = await handler.ReadAsync(buffer, 0, 1024, CancellationToken.None);
                Assert.AreEqual(488, bytesRead4);

                int bytesRead5 = await handler.ReadAsync(buffer, 0, 1024, CancellationToken.None);
                Assert.AreEqual(0, bytesRead5); // EOF
            }
            finally
            {
                handler.Dispose();
            }
        }

        #endregion
    }
}
