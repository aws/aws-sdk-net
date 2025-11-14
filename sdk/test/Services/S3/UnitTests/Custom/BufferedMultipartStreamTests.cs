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
    public class BufferedMultipartStreamTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidDependencies_CreatesStream()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();

            // Act
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Assert
            Assert.IsNotNull(stream);
            Assert.IsTrue(stream.CanRead);
            Assert.IsFalse(stream.CanSeek);
            Assert.IsFalse(stream.CanWrite);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullCoordinator_ThrowsArgumentNullException()
        {
            // Arrange
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();

            // Act
            var stream = new BufferedMultipartStream(null, mockBufferManager.Object, config);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullPartBufferManager_ThrowsArgumentNullException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();

            // Act
            var stream = new BufferedMultipartStream(mockCoordinator.Object, null, config);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullConfig_ThrowsArgumentNullException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();

            // Act
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, null);
        }

        #endregion

        #region Factory Method Tests

        [TestMethod]
        public void Create_WithValidParameters_CreatesStream()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();

            // Act
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);

            // Assert
            Assert.IsNotNull(stream);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Create_WithNullS3Client_ThrowsArgumentNullException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();

            // Act
            var stream = BufferedMultipartStream.Create(null, request, transferConfig);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Create_WithNullRequest_ThrowsArgumentNullException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var transferConfig = new TransferUtilityConfig();

            // Act
            var stream = BufferedMultipartStream.Create(mockClient.Object, null, transferConfig);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Create_WithNullTransferConfig_ThrowsArgumentNullException()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();

            // Act
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, null);
        }

        [TestMethod]
        public void Create_CreatesDefaultDependencies()
        {
            // Arrange
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client();
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();

            // Act
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);

            // Assert
            Assert.IsNotNull(stream);
            Assert.IsNull(stream.DiscoveryResult); // Not initialized yet
        }

        #endregion

        #region InitializeAsync Tests - Single Part

        [TestMethod]
        public async Task InitializeAsync_SinglePart_UsesSinglePartHandler()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = mockResponse
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            await stream.InitializeAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(stream.DiscoveryResult);
            Assert.AreEqual(1, stream.DiscoveryResult.TotalParts);
        }

        [TestMethod]
        public async Task InitializeAsync_SinglePart_CallsStartDownloads()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = mockResponse
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);
            mockCoordinator.Setup(x => x.StartDownloadsAsync(It.IsAny<DownloadDiscoveryResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            await stream.InitializeAsync(CancellationToken.None);

            // Assert
            mockCoordinator.Verify(
                x => x.StartDownloadsAsync(discoveryResult, It.IsAny<CancellationToken>()),
                Times.Once);
        }

        #endregion

        #region InitializeAsync Tests - Multipart

        [TestMethod]
        public async Task InitializeAsync_Multipart_UsesMultipartHandler()
        {
            // Arrange
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 5,
                ObjectSize = 50 * 1024 * 1024,
                InitialResponse = new GetObjectResponse()
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);
            mockCoordinator.Setup(x => x.StartDownloadsAsync(It.IsAny<DownloadDiscoveryResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            await stream.InitializeAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(5, stream.DiscoveryResult.TotalParts);
        }

        [TestMethod]
        public async Task InitializeAsync_Multipart_StartsDownloads()
        {
            // Arrange
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 5,
                ObjectSize = 50 * 1024 * 1024,
                InitialResponse = new GetObjectResponse()
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);
            mockCoordinator.Setup(x => x.StartDownloadsAsync(It.IsAny<DownloadDiscoveryResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            await stream.InitializeAsync(CancellationToken.None);

            // Assert
            mockCoordinator.Verify(
                x => x.StartDownloadsAsync(discoveryResult, It.IsAny<CancellationToken>()),
                Times.Once);
        }

        #endregion

        #region InitializeAsync Tests - State Management

        [TestMethod]
        public async Task InitializeAsync_SetsDiscoveryResult()
        {
            // Arrange
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024)
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            await stream.InitializeAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(stream.DiscoveryResult);
            Assert.AreEqual(discoveryResult, stream.DiscoveryResult);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task InitializeAsync_CalledTwice_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = mockResponse
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            await stream.InitializeAsync(CancellationToken.None);
            await stream.InitializeAsync(CancellationToken.None); // Second call should throw
        }

        #endregion

        #region ReadAsync Tests

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ReadAsync_BeforeInitialize_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            var buffer = new byte[1024];

            // Act
            await stream.ReadAsync(buffer, 0, buffer.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public async Task ReadAsync_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            stream.Dispose();
            var buffer = new byte[1024];

            // Act
            await stream.ReadAsync(buffer, 0, buffer.Length);
        }

        #endregion

        #region ReadAsync Tests - Parameter Validation

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task ReadAsync_WithNullBuffer_ThrowsArgumentNullException()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = mockResponse
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            await stream.InitializeAsync(CancellationToken.None);

            // Act
            await stream.ReadAsync(null, 0, 1024);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeOffset_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = mockResponse
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            await stream.InitializeAsync(CancellationToken.None);

            var buffer = new byte[1024];

            // Act
            await stream.ReadAsync(buffer, -1, 1024);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeCount_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = mockResponse
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            await stream.InitializeAsync(CancellationToken.None);

            var buffer = new byte[1024];

            // Act
            await stream.ReadAsync(buffer, 0, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task ReadAsync_WithOffsetCountExceedingBounds_ThrowsArgumentException()
        {
            // Arrange
            var mockResponse = MultipartDownloadTestHelpers.CreateSinglePartResponse(1024);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024,
                InitialResponse = mockResponse
            };

            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            await stream.InitializeAsync(CancellationToken.None);

            var buffer = new byte[1024];

            // Act
            await stream.ReadAsync(buffer, 100, 1000); // 100 + 1000 > 1024
        }

        #endregion

        #region Stream Property Tests

        [TestMethod]
        public void CanRead_ReturnsTrue()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act & Assert
            Assert.IsTrue(stream.CanRead);
        }

        [TestMethod]
        public void CanSeek_ReturnsFalse()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act & Assert
            Assert.IsFalse(stream.CanSeek);
        }

        [TestMethod]
        public void CanWrite_ReturnsFalse()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act & Assert
            Assert.IsFalse(stream.CanWrite);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Length_ThrowsNotSupportedException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            var length = stream.Length;
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Position_Get_ThrowsNotSupportedException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            var position = stream.Position;
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Position_Set_ThrowsNotSupportedException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            stream.Position = 100;
        }

        #endregion

        #region Unsupported Operation Tests

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Seek_ThrowsNotSupportedException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            stream.Seek(0, SeekOrigin.Begin);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void SetLength_ThrowsNotSupportedException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            stream.SetLength(1024);
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Write_ThrowsNotSupportedException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            var buffer = new byte[1024];

            // Act
            stream.Write(buffer, 0, buffer.Length);
        }

        #endregion

        #region Flush Tests

        [TestMethod]
        public void Flush_DoesNotThrow()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            stream.Flush(); // Should not throw

            // Assert - no exception
        }

        [TestMethod]
        public async Task FlushAsync_Completes()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            await stream.FlushAsync(CancellationToken.None); // Should complete without error

            // Assert - no exception
        }

        #endregion

        #region Synchronous Read Tests

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Read_BeforeInitialize_ThrowsInvalidOperationException()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            var buffer = new byte[1024];

            // Act
            stream.Read(buffer, 0, buffer.Length);
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            stream.Dispose();
            stream.Dispose(); // Second call should not throw

            // Assert - no exception
        }

        [TestMethod]
        public void Dispose_SuppressesExceptions()
        {
            // Arrange
            var mockCoordinator = new Mock<IDownloadCoordinator>();
            mockCoordinator.Setup(x => x.Dispose()).Throws<InvalidOperationException>();

            var mockBufferManager = new Mock<IPartBufferManager>();
            mockBufferManager.Setup(x => x.Dispose()).Throws<InvalidOperationException>();

            var config = MultipartDownloadTestHelpers.CreateStreamConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            // Act
            stream.Dispose(); // Should not propagate exceptions

            // Assert - no exception thrown
        }

        #endregion
    }
}
