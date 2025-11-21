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
    public class BufferedMultipartStreamTests
    {
        #region Test Constants

        private const int EMPTY_OBJECT_SIZE = 0;
        private const int SMALL_OBJECT_SIZE = 512;
        private const int MEDIUM_OBJECT_SIZE = 1024;
        private const int LARGE_OBJECT_SIZE = 4096;
        private const int VERY_LARGE_OBJECT_SIZE = 50 * 1024 * 1024;
        private const int DEFAULT_PART_SIZE = 5 * 1024 * 1024;
        private const int SMALL_CHUNK_SIZE = 128;
        private const int MEDIUM_CHUNK_SIZE = 256;
        private const int LARGE_CHUNK_SIZE = 512;

        #endregion

        #region Test Setup Fields

        private Mock<IDownloadManager> _mockCoordinator;
        private Mock<IPartBufferManager> _mockBufferManager;
        private BufferedDownloadConfiguration _config;

        #endregion

        #region Test Initialization

        [TestInitialize]
        public void Setup()
        {
            _mockCoordinator = new Mock<IDownloadManager>();
            _mockBufferManager = new Mock<IPartBufferManager>();
            _config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
        }

        #endregion

        #region Helper Methods

        private BufferedMultipartStream CreateStream()
        {
            return new BufferedMultipartStream(_mockCoordinator.Object, _mockBufferManager.Object, _config);
        }

        private async Task<BufferedMultipartStream> CreateInitializedStreamAsync(
            long objectSize = MEDIUM_OBJECT_SIZE,
            int totalParts = 1)
        {
            var mockResponse = totalParts == 1
                ? MultipartDownloadTestHelpers.CreateSinglePartResponse(objectSize)
                : new GetObjectResponse();

            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = totalParts,
                ObjectSize = objectSize,
                InitialResponse = mockResponse
            };

            _mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);
            _mockCoordinator.Setup(x => x.StartDownloadsAsync(It.IsAny<DownloadDiscoveryResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var stream = CreateStream();
            await stream.InitializeAsync(CancellationToken.None);
            return stream;
        }

        #endregion

        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidDependencies_CreatesStream()
        {
            // Act
            var stream = CreateStream();

            // Assert
            Assert.IsNotNull(stream);
            Assert.IsTrue(stream.CanRead);
            Assert.IsFalse(stream.CanSeek);
            Assert.IsFalse(stream.CanWrite);
        }

        [DataTestMethod]
        [DataRow(null, "bufferManager", "config", DisplayName = "Null Coordinator")]
        [DataRow("coordinator", null, "config", DisplayName = "Null Buffer Manager")]
        [DataRow("coordinator", "bufferManager", null, DisplayName = "Null Config")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullParameter_ThrowsArgumentNullException(
            string coordinatorKey, string bufferManagerKey, string configKey)
        {
            // Arrange
            var coordinator = coordinatorKey != null ? _mockCoordinator.Object : null;
            var bufferManager = bufferManagerKey != null ? _mockBufferManager.Object : null;
            var config = configKey != null ? _config : null;

            // Act
            var stream = new BufferedMultipartStream(coordinator, bufferManager, config);
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
            Assert.IsNull(stream.DiscoveryResult); // Not initialized yet
        }

        [DataTestMethod]
        [DataRow(null, "request", "config", DisplayName = "Null S3 Client")]
        [DataRow("client", null, "config", DisplayName = "Null Request")]
        [DataRow("client", "request", null, DisplayName = "Null Transfer Config")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Create_WithNullParameter_ThrowsArgumentNullException(
            string clientKey, string requestKey, string configKey)
        {
            // Arrange
            var client = clientKey != null ? MultipartDownloadTestHelpers.CreateMockS3Client().Object : null;
            var request = requestKey != null ? MultipartDownloadTestHelpers.CreateOpenStreamRequest() : null;
            var config = configKey != null ? new TransferUtilityConfig() : null;

            // Act
            var stream = BufferedMultipartStream.Create(client, request, config);
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

            var mockCoordinator = new Mock<IDownloadManager>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
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

            var mockCoordinator = new Mock<IDownloadManager>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);
            mockCoordinator.Setup(x => x.StartDownloadsAsync(It.IsAny<DownloadDiscoveryResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
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

            var mockCoordinator = new Mock<IDownloadManager>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);
            mockCoordinator.Setup(x => x.StartDownloadsAsync(It.IsAny<DownloadDiscoveryResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
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

            var mockCoordinator = new Mock<IDownloadManager>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);
            mockCoordinator.Setup(x => x.StartDownloadsAsync(It.IsAny<DownloadDiscoveryResult>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
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

            var mockCoordinator = new Mock<IDownloadManager>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
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

            var mockCoordinator = new Mock<IDownloadManager>();
            mockCoordinator.Setup(x => x.DiscoverDownloadStrategyAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(discoveryResult);

            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
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
            var mockCoordinator = new Mock<IDownloadManager>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
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
            var mockCoordinator = new Mock<IDownloadManager>();
            var mockBufferManager = new Mock<IPartBufferManager>();
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var stream = new BufferedMultipartStream(mockCoordinator.Object, mockBufferManager.Object, config);

            stream.Dispose();
            var buffer = new byte[1024];

            // Act
            await stream.ReadAsync(buffer, 0, buffer.Length);
        }

        #endregion

        #region ReadAsync Tests - Parameter Validation

        [TestMethod]
        public async Task ReadAsync_WithNullBuffer_ThrowsArgumentNullException()
        {
            // Arrange
            var stream = await CreateInitializedStreamAsync();

            // Act & Assert
            await Assert.ThrowsExceptionAsync<ArgumentNullException>(
                async () => await stream.ReadAsync(null, 0, MEDIUM_OBJECT_SIZE));

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_WithNegativeOffset_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var stream = await CreateInitializedStreamAsync();
            var buffer = new byte[MEDIUM_OBJECT_SIZE];

            // Act & Assert
            await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(
                async () => await stream.ReadAsync(buffer, -1, MEDIUM_OBJECT_SIZE));

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_WithNegativeCount_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var stream = await CreateInitializedStreamAsync();
            var buffer = new byte[MEDIUM_OBJECT_SIZE];

            // Act & Assert
            await Assert.ThrowsExceptionAsync<ArgumentOutOfRangeException>(
                async () => await stream.ReadAsync(buffer, 0, -1));

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_WithOffsetCountExceedingBounds_ThrowsArgumentException()
        {
            // Arrange
            var stream = await CreateInitializedStreamAsync();
            var buffer = new byte[MEDIUM_OBJECT_SIZE];

            // Act & Assert
            await Assert.ThrowsExceptionAsync<ArgumentException>(
                async () => await stream.ReadAsync(buffer, 100, 1000)); // 100 + 1000 > 1024

            // Cleanup
            stream.Dispose();
        }

        #endregion

        #region Stream Property Tests

        [TestMethod]
        public void StreamCapabilities_HaveCorrectValues()
        {
            // Arrange
            var stream = CreateStream();

            // Act & Assert
            Assert.IsTrue(stream.CanRead, "Stream should be readable");
            Assert.IsFalse(stream.CanSeek, "Stream should not be seekable");
            Assert.IsFalse(stream.CanWrite, "Stream should not be writable");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Length_BeforeInitialization_ThrowsInvalidOperationException()
        {
            // Arrange
            var stream = CreateStream();

            // Act
            _ = stream.Length;
        }

        [TestMethod]
        public async Task Length_AfterInitialization_ReturnsObjectSize()
        {
            // Arrange
            var objectSize = MEDIUM_OBJECT_SIZE;
            var stream = await CreateInitializedStreamAsync(objectSize: objectSize);

            // Act
            var length = stream.Length;

            // Assert
            Assert.AreEqual(objectSize, length, "Length should return ObjectSize from discovery result");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task Length_ForLargeObject_ReturnsCorrectSize()
        {
            // Arrange
            var objectSize = VERY_LARGE_OBJECT_SIZE;
            var stream = await CreateInitializedStreamAsync(objectSize: objectSize, totalParts: 10);

            // Act
            var length = stream.Length;

            // Assert
            Assert.AreEqual(objectSize, length, "Length should return correct size for large objects");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Position_BeforeInitialization_ThrowsInvalidOperationException()
        {
            // Arrange
            var stream = CreateStream();

            // Act
            _ = stream.Position;
        }

        [TestMethod]
        public async Task Position_AfterInitialization_ReturnsZero()
        {
            // Arrange
            var stream = await CreateInitializedStreamAsync();

            // Act
            var position = stream.Position;

            // Assert
            Assert.AreEqual(0, position, "Position should be 0 before any reads");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task Position_AfterSingleRead_ReturnsCorrectValue()
        {
            // Arrange
            var objectSize = MEDIUM_OBJECT_SIZE;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            await stream.InitializeAsync(CancellationToken.None);

            // Act
            var buffer = new byte[SMALL_CHUNK_SIZE];
            var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            var position = stream.Position;

            // Assert
            Assert.AreEqual(bytesRead, position, "Position should equal bytes read");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task Position_AfterMultipleReads_AccumulatesCorrectly()
        {
            // Arrange
            var objectSize = MEDIUM_OBJECT_SIZE;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Perform multiple reads
            var buffer = new byte[SMALL_CHUNK_SIZE];
            var totalBytesRead = 0;
            
            var read1 = await stream.ReadAsync(buffer, 0, buffer.Length);
            totalBytesRead += read1;
            Assert.AreEqual(totalBytesRead, stream.Position, "Position should match after first read");
            
            var read2 = await stream.ReadAsync(buffer, 0, buffer.Length);
            totalBytesRead += read2;
            Assert.AreEqual(totalBytesRead, stream.Position, "Position should accumulate after second read");
            
            var read3 = await stream.ReadAsync(buffer, 0, buffer.Length);
            totalBytesRead += read3;
            Assert.AreEqual(totalBytesRead, stream.Position, "Position should accumulate after third read");

            // Assert
            Assert.IsTrue(totalBytesRead > 0, "Should have read some data");
            Assert.AreEqual(totalBytesRead, stream.Position, "Position should equal total bytes read");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task Position_AtEndOfStream_EqualsLength()
        {
            // Arrange
            var objectSize = SMALL_OBJECT_SIZE;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read entire stream
            var buffer = new byte[objectSize];
            await stream.ReadAsync(buffer, 0, buffer.Length);

            // Assert
            Assert.AreEqual(stream.Length, stream.Position, 
                "Position should equal Length after reading entire stream");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task Position_WithZeroByteRead_DoesNotChange()
        {
            // Arrange
            var objectSize = SMALL_OBJECT_SIZE;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read entire stream, then try to read again
            var buffer = new byte[objectSize];
            await stream.ReadAsync(buffer, 0, buffer.Length);
            var positionAfterFullRead = stream.Position;
            
            // Try to read past end
            await stream.ReadAsync(buffer, 0, buffer.Length);
            var positionAfterSecondRead = stream.Position;

            // Assert
            Assert.AreEqual(positionAfterFullRead, positionAfterSecondRead,
                "Position should not change when read returns 0 bytes");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task Position_SynchronousRead_UpdatesCorrectly()
        {
            // Arrange
            var objectSize = MEDIUM_OBJECT_SIZE;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Use synchronous Read method
            var buffer = new byte[SMALL_CHUNK_SIZE];
            var bytesRead = stream.Read(buffer, 0, buffer.Length);

            // Assert
            Assert.AreEqual(bytesRead, stream.Position, 
                "Position should update correctly for synchronous Read");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task Position_LengthAndPosition_ProvideProgressTracking()
        {
            // Arrange
            var objectSize = LARGE_OBJECT_SIZE;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            await stream.InitializeAsync(CancellationToken.None);

            // Act & Assert - Verify progress calculation
            var buffer = new byte[MEDIUM_CHUNK_SIZE];
            var totalBytesRead = 0;

            while (true)
            {
                var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                if (bytesRead == 0) break;

                totalBytesRead += bytesRead;

                // Verify progress can be calculated
                var progressPercentage = (double)stream.Position / stream.Length * 100;
                Assert.IsTrue(progressPercentage >= 0 && progressPercentage <= 100,
                    "Progress percentage should be between 0 and 100");
                Assert.AreEqual(totalBytesRead, stream.Position,
                    "Position should track total bytes read");
            }

            // Final verification
            Assert.AreEqual(objectSize, totalBytesRead, "Should read entire object");
            Assert.AreEqual(100.0, (double)stream.Position / stream.Length * 100,
                "Progress should be 100% at completion");

            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public async Task Position_Setter_ThrowsNotSupportedException()
        {
            // Arrange
            var stream = await CreateInitializedStreamAsync();

            // Act
            stream.Position = 100;
        }

        #endregion

        #region Unsupported Operation Tests

        [DataTestMethod]
        [DataRow("Seek", DisplayName = "Seek Operation")]
        [DataRow("SetLength", DisplayName = "SetLength Operation")]
        [DataRow("Write", DisplayName = "Write Operation")]
        public void UnsupportedOperations_ThrowNotSupportedException(string operation)
        {
            // Arrange
            var stream = CreateStream();
            var buffer = new byte[MEDIUM_OBJECT_SIZE];

            // Act & Assert
            Assert.ThrowsException<NotSupportedException>(() =>
            {
                switch (operation)
                {
                    case "Seek":
                        stream.Seek(0, SeekOrigin.Begin);
                        break;
                    case "SetLength":
                        stream.SetLength(MEDIUM_OBJECT_SIZE);
                        break;
                    case "Write":
                        stream.Write(buffer, 0, buffer.Length);
                        break;
                }
            });
        }

        #endregion

        #region Flush Tests

        [TestMethod]
        public void Flush_DoesNotThrow()
        {
            // Arrange
            var stream = CreateStream();

            // Act
            stream.Flush(); // Should not throw

            // Assert - no exception
        }

        [TestMethod]
        public async Task FlushAsync_Completes()
        {
            // Arrange
            var stream = CreateStream();

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
            var stream = CreateStream();
            var buffer = new byte[MEDIUM_OBJECT_SIZE];

            // Act
            stream.Read(buffer, 0, buffer.Length);
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var stream = CreateStream();

            // Act
            stream.Dispose();
            stream.Dispose(); // Second call should not throw

            // Assert - no exception
        }

        [TestMethod]
        public void Dispose_SuppressesExceptions()
        {
            // Arrange
            _mockCoordinator.Setup(x => x.Dispose()).Throws<InvalidOperationException>();
            _mockBufferManager.Setup(x => x.Dispose()).Throws<InvalidOperationException>();

            var stream = CreateStream();

            // Act
            stream.Dispose(); // Should not propagate exceptions

            // Assert - no exception thrown
        }

        #endregion

        #region Stream Reading Behavior Tests - Empty Object

        [TestMethod]
        public async Task ReadAsync_EmptyObject_ReturnsZero()
        {
            // Arrange - Empty object (0 bytes)
            var testData = new byte[0];
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(0, null, null, "empty-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client((req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act
            var buffer = new byte[1024];
            var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            // Assert
            Assert.AreEqual(0, bytesRead, "Empty object should return 0 bytes");
            
            // Cleanup
            stream.Dispose();
        }

        #endregion

        #region Stream Reading Behavior Tests - Multiple Consecutive Reads

        [TestMethod]
        public async Task ReadAsync_MultipleSmallReads_ReturnsAllData()
        {
            // Arrange - 1KB object, read in 256-byte chunks
            var objectSize = 1024;
            var chunkSize = 256;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read in multiple small chunks
            var allData = new System.Collections.Generic.List<byte>();
            var buffer = new byte[chunkSize];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                allData.AddRange(buffer.Take(bytesRead));
            }

            // Assert
            Assert.AreEqual(objectSize, allData.Count, "Should read entire object");
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, allData.ToArray(), 0, objectSize),
                "Data should match original");
            
            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_VaryingBufferSizes_ReturnsCorrectData()
        {
            // Arrange - 2KB object
            var objectSize = 2048;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read with varying buffer sizes
            var allData = new System.Collections.Generic.List<byte>();
            
            // First read: 512 bytes
            var buffer1 = new byte[512];
            var read1 = await stream.ReadAsync(buffer1, 0, buffer1.Length);
            allData.AddRange(buffer1.Take(read1));
            
            // Second read: 1KB
            var buffer2 = new byte[1024];
            var read2 = await stream.ReadAsync(buffer2, 0, buffer2.Length);
            allData.AddRange(buffer2.Take(read2));
            
            // Third read: 256 bytes
            var buffer3 = new byte[256];
            var read3 = await stream.ReadAsync(buffer3, 0, buffer3.Length);
            allData.AddRange(buffer3.Take(read3));
            
            // Fourth read: Remaining data
            var buffer4 = new byte[1024];
            var read4 = await stream.ReadAsync(buffer4, 0, buffer4.Length);
            allData.AddRange(buffer4.Take(read4));

            // Assert
            Assert.AreEqual(objectSize, allData.Count, "Should read entire object");
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, allData.ToArray(), 0, objectSize),
                "Data should match original");
            
            // Cleanup
            stream.Dispose();
        }

        #endregion

        #region Stream Reading Behavior Tests - End of Stream

        [TestMethod]
        public async Task ReadAsync_PastEndOfStream_ReturnsZero()
        {
            // Arrange - Small object
            var objectSize = 512;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read entire stream
            var buffer = new byte[objectSize];
            var firstRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            
            // Try to read again after reaching end
            var secondRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            // Assert
            Assert.AreEqual(objectSize, firstRead, "First read should return all data");
            Assert.AreEqual(0, secondRead, "Reading past end should return 0");
            
            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_MultipleReadsAtEnd_ConsistentlyReturnsZero()
        {
            // Arrange
            var objectSize = 256;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read entire stream
            var buffer = new byte[objectSize];
            await stream.ReadAsync(buffer, 0, buffer.Length);
            
            // Try multiple reads after end
            var read1 = await stream.ReadAsync(buffer, 0, buffer.Length);
            var read2 = await stream.ReadAsync(buffer, 0, buffer.Length);
            var read3 = await stream.ReadAsync(buffer, 0, buffer.Length);

            // Assert
            Assert.AreEqual(0, read1, "First read past end should return 0");
            Assert.AreEqual(0, read2, "Second read past end should return 0");
            Assert.AreEqual(0, read3, "Third read past end should return 0");
            
            // Cleanup
            stream.Dispose();
        }

        #endregion

        #region Stream Reading Behavior Tests - Buffer Sizes

        [TestMethod]
        public async Task ReadAsync_BufferLargerThanData_ReturnsAvailableData()
        {
            // Arrange - Small object, large buffer
            var objectSize = 512;
            var bufferSize = 2048; // Buffer larger than data
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act
            var buffer = new byte[bufferSize];
            var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            // Assert
            Assert.AreEqual(objectSize, bytesRead, "Should return only available data, not buffer size");
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, buffer, 0, objectSize),
                "Data should match original");
            
            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_SmallBuffer_RequiresMultipleReads()
        {
            // Arrange - Larger object, very small buffer
            var objectSize = 4096;
            var bufferSize = 128; // Very small buffer
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read entire object with small buffer
            var allData = new System.Collections.Generic.List<byte>();
            var buffer = new byte[bufferSize];
            int bytesRead;
            int readCount = 0;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                allData.AddRange(buffer.Take(bytesRead));
                readCount++;
            }

            // Assert
            Assert.AreEqual(objectSize, allData.Count, "Should read entire object");
            Assert.IsTrue(readCount >= objectSize / bufferSize, 
                "Should require multiple reads with small buffer");
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, allData.ToArray(), 0, objectSize),
                "Data should match original");
            
            // Cleanup
            stream.Dispose();
        }

        #endregion

        #region Stream Reading Behavior Tests - Multipart Edge Cases

        [TestMethod]
        public async Task ReadAsync_ExactPartBoundary_ReadsCorrectly()
        {
            // Arrange - Object size exactly equals 2 parts
            var partSize = 5 * 1024 * 1024; // 5MB
            var totalParts = 2;
            var objectSize = partSize * totalParts; // 10MB exactly
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, objectSize, "boundary-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: partSize);
            var transferConfig = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read across part boundary
            var bufferSize = (int)(partSize + 1024); // Read across boundary
            var buffer = new byte[bufferSize];
            var bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            // Assert
            Assert.IsTrue(bytesRead > 0, "Should successfully read across part boundary");
            Assert.AreEqual(Math.Min(bufferSize, objectSize), bytesRead, 
                "Should read requested amount or remaining data");
            
            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_NonAlignedPartBoundary_ReadsCorrectly()
        {
            // Arrange - Object size not aligned to part boundaries
            var partSize = 5 * 1024 * 1024; // 5MB
            var remainder = 2 * 1024 * 1024; // 2MB
            var objectSize = (2 * partSize) + remainder; // 12MB (2 full parts + 2MB)
            var totalParts = 3;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, objectSize, "non-aligned-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: partSize);
            var transferConfig = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read in chunks that don't align with part boundaries
            var bufferSize = (int)(3 * 1024 * 1024); // 3MB chunks
            var allData = new System.Collections.Generic.List<byte>();
            var buffer = new byte[bufferSize];
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                allData.AddRange(buffer.Take(bytesRead));
            }

            // Assert
            Assert.AreEqual(objectSize, allData.Count, 
                "Should read entire object despite non-aligned boundaries");
            
            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_BufferLargerThanPartSize_HandlesCorrectly()
        {
            // Arrange - Buffer larger than part size
            var partSize = 5 * 1024 * 1024; // 5MB parts
            var bufferSize = (int)(8 * 1024 * 1024); // 8MB buffer (larger than part)
            var objectSize = 15 * 1024 * 1024; // 15MB total
            var totalParts = 3;
            
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3ClientForMultipart(
                totalParts, partSize, objectSize, "large-buffer-etag", usePartStrategy: true);
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest(partSize: partSize);
            var transferConfig = new TransferUtilityConfig { ConcurrentServiceRequests = 1 };
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read with buffer larger than part size
            var buffer = new byte[bufferSize];
            var firstRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            // Assert
            Assert.IsTrue(firstRead > 0, "Should successfully read with large buffer");
            Assert.IsTrue(firstRead <= bufferSize, "Should not read more than buffer size");
            
            // Cleanup
            stream.Dispose();
        }

        #endregion

        #region Stream Reading Behavior Tests - Partial Reads

        [TestMethod]
        public async Task ReadAsync_PartialBufferFill_ReturnsAvailableData()
        {
            // Arrange - Request more data than available
            var objectSize = 1024;
            var requestedSize = 2048; // Request more than available
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act
            var buffer = new byte[requestedSize];
            var bytesRead = await stream.ReadAsync(buffer, 0, requestedSize);

            // Assert
            Assert.AreEqual(objectSize, bytesRead, 
                "Should return available data, not requested amount");
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, buffer, 0, objectSize),
                "Data should match original");
            
            // Cleanup
            stream.Dispose();
        }

        [TestMethod]
        public async Task ReadAsync_ReadIntoMiddleOfBuffer_PositionsCorrectly()
        {
            // Arrange
            var objectSize = 512;
            var testData = MultipartDownloadTestHelpers.GenerateTestData(objectSize, 0);
            var mockResponse = MultipartDownloadTestHelpers.CreateMockGetObjectResponse(
                objectSize, null, null, "test-etag", testData);
            var mockClient = MultipartDownloadTestHelpers.CreateMockS3Client(
                (req, ct) => Task.FromResult(mockResponse));
            
            var request = MultipartDownloadTestHelpers.CreateOpenStreamRequest();
            var transferConfig = new TransferUtilityConfig();
            var stream = BufferedMultipartStream.Create(mockClient.Object, request, transferConfig);
            
            await stream.InitializeAsync(CancellationToken.None);

            // Act - Read into middle of buffer
            var buffer = new byte[1024];
            var offset = 256;
            var count = 512;
            var bytesRead = await stream.ReadAsync(buffer, offset, count);

            // Assert
            Assert.AreEqual(objectSize, bytesRead, "Should read available data");
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, buffer, offset, objectSize),
                "Data should be at correct offset in buffer");
            
            // Cleanup
            stream.Dispose();
        }

        #endregion
    }
}
