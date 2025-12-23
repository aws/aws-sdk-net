using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for BufferedDownloadConfiguration class.
    /// Tests configuration validation and parameter handling.
    /// </summary>
    [TestClass]
    public class BufferedDownloadConfigurationTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesConfiguration()
        {
            // Arrange
            int concurrentRequests = 10;
            int maxInMemoryParts = 5;
            int bufferSize = 8192;
            long targetPartSize = 8 * 1024 * 1024; // 8MB

            // Act
            var config = new BufferedDownloadConfiguration(concurrentRequests, maxInMemoryParts, bufferSize, targetPartSize);

            // Assert
            Assert.AreEqual(concurrentRequests, config.ConcurrentServiceRequests);
            Assert.AreEqual(maxInMemoryParts, config.MaxInMemoryParts);
            Assert.AreEqual(bufferSize, config.BufferSize);
            Assert.AreEqual(targetPartSize, config.TargetPartSizeBytes);
            Assert.IsNull(config.ChunkBufferSize); // Default should be null
        }

        [TestMethod]
        public void Constructor_WithChunkBufferSize_SetsProperty()
        {
            // Arrange
            int concurrentRequests = 10;
            int maxInMemoryParts = 5;
            int bufferSize = 8192;
            long targetPartSize = 8 * 1024 * 1024; // 8MB
            int chunkBufferSize = 32 * 1024; // 32KB

            // Act
            var config = new BufferedDownloadConfiguration(concurrentRequests, maxInMemoryParts, bufferSize, targetPartSize, chunkBufferSize);

            // Assert
            Assert.AreEqual(concurrentRequests, config.ConcurrentServiceRequests);
            Assert.AreEqual(maxInMemoryParts, config.MaxInMemoryParts);
            Assert.AreEqual(bufferSize, config.BufferSize);
            Assert.AreEqual(targetPartSize, config.TargetPartSizeBytes);
            Assert.AreEqual(chunkBufferSize, config.ChunkBufferSize);
        }

        [TestMethod]
        public void Constructor_WithNullChunkBufferSize_LeavesPropertyNull()
        {
            // Arrange
            int concurrentRequests = 10;
            int maxInMemoryParts = 5;
            int bufferSize = 8192;
            long targetPartSize = 8 * 1024 * 1024; // 8MB

            // Act
            var config = new BufferedDownloadConfiguration(concurrentRequests, maxInMemoryParts, bufferSize, targetPartSize, null);

            // Assert
            Assert.IsNull(config.ChunkBufferSize);
        }

        [TestMethod]
        public void Constructor_WithSmallChunkBufferSize_AcceptsValue()
        {
            // Arrange
            int chunkBufferSize = 16 * 1024; // 16KB

            // Act
            var config = new BufferedDownloadConfiguration(10, 5, 8192, 8 * 1024 * 1024, chunkBufferSize);

            // Assert
            Assert.AreEqual(chunkBufferSize, config.ChunkBufferSize);
        }

        [TestMethod]
        public void Constructor_WithLargeChunkBufferSize_AcceptsValue()
        {
            // Arrange
            int chunkBufferSize = 128 * 1024; // 128KB

            // Act
            var config = new BufferedDownloadConfiguration(10, 5, 8192, 8 * 1024 * 1024, chunkBufferSize);

            // Assert
            Assert.AreEqual(chunkBufferSize, config.ChunkBufferSize);
        }

        [TestMethod]
        public void Constructor_WithCustomPartSize_UsesProvidedValue()
        {
            // Arrange
            long expectedPartSize = 10 * 1024 * 1024; // 10MB

            // Act
            var config = new BufferedDownloadConfiguration(10, 5, 8192, expectedPartSize);

            // Assert
            Assert.AreEqual(expectedPartSize, config.TargetPartSizeBytes);
        }

        [TestMethod]
        public void Constructor_WithVeryLargeValues_HandlesCorrectly()
        {
            // Arrange
            int largeValue = int.MaxValue;
            long largePartSize = long.MaxValue / 2;

            // Act
            var config = new BufferedDownloadConfiguration(largeValue, largeValue, largeValue, largePartSize);

            // Assert
            Assert.AreEqual(largeValue, config.ConcurrentServiceRequests);
            Assert.AreEqual(largeValue, config.MaxInMemoryParts);
            Assert.AreEqual(largeValue, config.BufferSize);
            Assert.AreEqual(largePartSize, config.TargetPartSizeBytes);
        }

        [TestMethod]
        public void Constructor_With8MBPartSize_StoresCorrectValue()
        {
            // Arrange
            long partSize = 8 * 1024 * 1024; // 8MB

            // Act
            var config = new BufferedDownloadConfiguration(1, 1, 1, partSize);

            // Assert
            Assert.AreEqual(1, config.ConcurrentServiceRequests);
            Assert.AreEqual(1, config.MaxInMemoryParts);
            Assert.AreEqual(1, config.BufferSize);
            Assert.AreEqual(partSize, config.TargetPartSizeBytes);
        }

        #endregion

        #region Validation Tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithNegativeConcurrentRequests_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(-1, 5, 8192, 8 * 1024 * 1024);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithZeroConcurrentRequests_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(0, 5, 8192, 8 * 1024 * 1024);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithNegativeMaxInMemoryParts_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(10, -1, 8192, 8 * 1024 * 1024);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithZeroMaxInMemoryParts_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(10, 0, 8192, 8 * 1024 * 1024);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithNegativeTargetPartSize_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(10, 5, 8192, -1L);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithZeroTargetPartSize_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(10, 5, 8192, 0L);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithNegativeBufferSize_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(10, 5, -1, 8 * 1024 * 1024);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithZeroBufferSize_ThrowsException()
        {
            // Act & Assert - ExpectedException
            var config = new BufferedDownloadConfiguration(10, 5, 0, 8 * 1024 * 1024);
        }

        #endregion
    }
}
