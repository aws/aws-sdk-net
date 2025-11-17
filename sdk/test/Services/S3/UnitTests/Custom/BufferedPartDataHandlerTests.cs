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
    public class BufferedPartDataHandlerTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesHandler()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();

            // Act
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Assert
            Assert.IsNotNull(handler);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullBufferManager_ThrowsArgumentNullException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();

            // Act
            var handler = new BufferedPartDataHandler(null, config);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullConfig_ThrowsArgumentNullException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, null);
        }

        #endregion

        #region ProcessPartAsync Tests - Basic Functionality

        [TestMethod]
        public async Task ProcessPartAsync_BuffersPartData()
        {
            // Arrange
            var partSize = 8 * 1024 * 1024; // 8MB
            var partData = new byte[partSize];
            new Random().NextBytes(partData);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = partSize,
                ResponseStream = new MemoryStream(partData)
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert - should add buffer to manager
            mockBufferManager.Verify(
                x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()),
                Times.Once);
        }

        [TestMethod]
        public async Task ProcessPartAsync_ReadsExactContentLength()
        {
            // Arrange
            var partSize = 1024;
            var partData = new byte[partSize];
            new Random().NextBytes(partData);

            StreamPartBuffer capturedBuffer = null;
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Callback<StreamPartBuffer, CancellationToken>((buffer, ct) => capturedBuffer = buffer)
                .Returns(Task.CompletedTask);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = partSize,
                ResponseStream = new MemoryStream(partData)
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert
            Assert.IsNotNull(capturedBuffer);
            Assert.AreEqual(partSize, capturedBuffer.Length);
            Assert.AreEqual(1, capturedBuffer.PartNumber);
        }

        [TestMethod]
        public async Task ProcessPartAsync_HandlesSmallPart()
        {
            // Arrange
            var partSize = 100; // Very small
            var partData = new byte[partSize];
            new Random().NextBytes(partData);

            StreamPartBuffer capturedBuffer = null;
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Callback<StreamPartBuffer, CancellationToken>((buffer, ct) => capturedBuffer = buffer)
                .Returns(Task.CompletedTask);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = partSize,
                ResponseStream = new MemoryStream(partData)
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert
            Assert.IsNotNull(capturedBuffer);
            Assert.AreEqual(partSize, capturedBuffer.Length);
        }

        [TestMethod]
        public async Task ProcessPartAsync_HandlesLargePart()
        {
            // Arrange
            var partSize = 16 * 1024 * 1024; // 16MB
            var partData = new byte[partSize];
            new Random().NextBytes(partData);

            StreamPartBuffer capturedBuffer = null;
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Callback<StreamPartBuffer, CancellationToken>((buffer, ct) => capturedBuffer = buffer)
                .Returns(Task.CompletedTask);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = partSize,
                ResponseStream = new MemoryStream(partData)
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert
            Assert.IsNotNull(capturedBuffer);
            Assert.AreEqual(partSize, capturedBuffer.Length);
        }

        #endregion


        #region ProcessPartAsync Tests - Data Integrity

        [TestMethod]
        public async Task ProcessPartAsync_PreservesDataIntegrity()
        {
            // Arrange
            var partSize = 1024 * 1024; // 1MB
            var partData = new byte[partSize];
            new Random(42).NextBytes(partData); // Seeded for reproducibility

            StreamPartBuffer capturedBuffer = null;
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Callback<StreamPartBuffer, CancellationToken>((buffer, ct) => capturedBuffer = buffer)
                .Returns(Task.CompletedTask);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = partSize,
                ResponseStream = new MemoryStream(partData)
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert - verify data matches exactly
            Assert.IsNotNull(capturedBuffer);
            var bufferedData = new byte[capturedBuffer.Length];
            Buffer.BlockCopy(capturedBuffer.ArrayPoolBuffer, 0, bufferedData, 0, capturedBuffer.Length);

            CollectionAssert.AreEqual(partData, bufferedData);
        }

        [TestMethod]
        public async Task ProcessPartAsync_HandlesZeroByteResponse()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = 0,
                ResponseStream = new MemoryStream(Array.Empty<byte>())
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert - should handle empty response gracefully
            mockBufferManager.Verify(
                x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()),
                Times.Once);
        }

        [TestMethod]
        public async Task ProcessPartAsync_WithUnexpectedEOF_ThrowsIOException()
        {
            // Arrange
            var expectedBytes = 1024 * 1024; // 1MB expected
            var actualBytes = 512 * 1024; // 512KB available (premature EOF)
            var partData = new byte[actualBytes];
            new Random().NextBytes(partData);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Create a response that promises more bytes than it delivers
            var response = new GetObjectResponse
            {
                ContentLength = expectedBytes, // Promise 1MB
                ResponseStream = new MemoryStream(partData), // Only deliver 512KB
                ResponseMetadata = new Amazon.Runtime.ResponseMetadata()
            };

            // Act & Assert
            var exception = await Assert.ThrowsExceptionAsync<Amazon.S3.Model.StreamSizeMismatchException>(
                async () => await handler.ProcessPartAsync(1, response, CancellationToken.None));

            // Verify exception message contains key information
            StringAssert.Contains(exception.Message, expectedBytes.ToString());
            StringAssert.Contains(exception.Message, actualBytes.ToString());
        }

        [TestMethod]
        public async Task ProcessPartAsync_WithUnexpectedEOF_DoesNotBufferPartialData()
        {
            // Arrange
            var expectedBytes = 1024 * 1024; // 1MB expected
            var actualBytes = 512 * 1024; // 512KB available (premature EOF)
            var partData = new byte[actualBytes];
            new Random().NextBytes(partData);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = expectedBytes,
                ResponseStream = new MemoryStream(partData),
                ResponseMetadata = new Amazon.Runtime.ResponseMetadata()
            };

            // Act
            try
            {
                await handler.ProcessPartAsync(1, response, CancellationToken.None);
                Assert.Fail("Expected StreamSizeMismatchException was not thrown");
            }
            catch (Amazon.S3.Model.StreamSizeMismatchException)
            {
                // Expected
            }

            // Assert - should NOT have added any buffer to manager since download failed
            mockBufferManager.Verify(
                x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()),
                Times.Never);
        }

        #endregion

        #region ProcessPartAsync Tests - Cancellation

        [TestMethod]
        [ExpectedException(typeof(TaskCanceledException))]
        public async Task ProcessPartAsync_WithCancelledToken_ThrowsTaskCanceledException()
        {
            // Arrange
            var partSize = 8 * 1024 * 1024;
            var partData = new byte[partSize];

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = partSize,
                ResponseStream = new MemoryStream(partData)
            };

            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            await handler.ProcessPartAsync(1, response, cts.Token);
        }

        [TestMethod]
        public async Task ProcessPartAsync_PassesCancellationTokenToBufferManager()
        {
            // Arrange
            var partSize = 1024;
            var partData = new byte[partSize];

            CancellationToken capturedToken = default;
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.AddBufferAsync(It.IsAny<StreamPartBuffer>(), It.IsAny<CancellationToken>()))
                .Callback<StreamPartBuffer, CancellationToken>((buffer, ct) => capturedToken = ct)
                .Returns(Task.CompletedTask);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var response = new GetObjectResponse
            {
                ContentLength = partSize,
                ResponseStream = new MemoryStream(partData)
            };

            var cts = new CancellationTokenSource();

            // Act
            await handler.ProcessPartAsync(1, response, cts.Token);

            // Assert
            Assert.AreEqual(cts.Token, capturedToken);
        }

        #endregion

        #region WaitForCapacityAsync Tests

        [TestMethod]
        public async Task WaitForCapacityAsync_DelegatesToBufferManager()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            await handler.WaitForCapacityAsync(CancellationToken.None);

            // Assert
            mockBufferManager.Verify(
                x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()),
                Times.Once);
        }

        [TestMethod]
        public async Task WaitForCapacityAsync_PassesCancellationToken()
        {
            // Arrange
            CancellationToken capturedToken = default;
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .Callback<CancellationToken>(ct => capturedToken = ct)
                .Returns(Task.CompletedTask);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var cts = new CancellationTokenSource();

            // Act
            await handler.WaitForCapacityAsync(cts.Token);

            // Assert
            Assert.AreEqual(cts.Token, capturedToken);
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task WaitForCapacityAsync_WhenCancelled_ThrowsOperationCanceledException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.WaitForBufferSpaceAsync(It.IsAny<CancellationToken>()))
                .ThrowsAsync(new OperationCanceledException());

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            await handler.WaitForCapacityAsync(cts.Token);
        }

        #endregion

        #region ReleaseCapacity Tests

        [TestMethod]
        public void ReleaseCapacity_DelegatesToBufferManager()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            handler.ReleaseCapacity();

            // Assert
            mockBufferManager.Verify(x => x.ReleaseBufferSpace(), Times.Once);
        }

        [TestMethod]
        public void ReleaseCapacity_CanBeCalledMultipleTimes()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            handler.ReleaseCapacity();
            handler.ReleaseCapacity();
            handler.ReleaseCapacity();

            // Assert
            mockBufferManager.Verify(x => x.ReleaseBufferSpace(), Times.Exactly(3));
        }

        #endregion

        #region OnDownloadComplete Tests

        [TestMethod]
        public void OnDownloadComplete_WithNullException_DelegatesToBufferManager()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            handler.OnDownloadComplete(null);

            // Assert
            mockBufferManager.Verify(
                x => x.MarkDownloadComplete(null),
                Times.Once);
        }

        [TestMethod]
        public void OnDownloadComplete_WithException_PassesExceptionToBufferManager()
        {
            // Arrange
            var testException = new InvalidOperationException("Test error");
            Exception capturedEx = null;

            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.MarkDownloadComplete(It.IsAny<Exception>()))
                .Callback<Exception>(ex => capturedEx = ex);

            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            handler.OnDownloadComplete(testException);

            // Assert
            Assert.AreEqual(testException, capturedEx);
        }

        [TestMethod]
        public void OnDownloadComplete_WithCancelledException_PassesToBufferManager()
        {
            // Arrange
            var testException = new OperationCanceledException();

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            handler.OnDownloadComplete(testException);

            // Assert
            mockBufferManager.Verify(
                x => x.MarkDownloadComplete(It.Is<OperationCanceledException>(e => e == testException)),
                Times.Once);
        }

        [TestMethod]
        public void OnDownloadComplete_CanBeCalledMultipleTimes()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act - calling multiple times should work
            handler.OnDownloadComplete(null);
            handler.OnDownloadComplete(new Exception("test"));
            handler.OnDownloadComplete(null);

            // Assert
            mockBufferManager.Verify(
                x => x.MarkDownloadComplete(It.IsAny<Exception>()),
                Times.Exactly(3));
        }

        #endregion

        #region Dispose Tests

        [TestMethod]
        public void Dispose_DoesNotDisposeBufferManager()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            handler.Dispose();

            // Assert - BufferManager is owned by caller, should not be disposed
            mockBufferManager.Verify(x => x.Dispose(), Times.Never);
        }

        [TestMethod]
        public void Dispose_CanBeCalledMultipleTimes()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var handler = new BufferedPartDataHandler(mockBufferManager.Object, config);

            // Act
            handler.Dispose();
            handler.Dispose(); // Should not throw

            // Assert - no exception
        }

        #endregion
    }
}
