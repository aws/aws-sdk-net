using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for StreamConfiguration class.
    /// Tests configuration validation and parameter handling.
    /// </summary>
    [TestClass]
    public class StreamConfigurationTests
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
            var config = new StreamConfiguration(concurrentRequests, maxInMemoryParts, bufferSize, targetPartSize);

            // Assert
            Assert.AreEqual(concurrentRequests, config.ConcurrentServiceRequests);
            Assert.AreEqual(maxInMemoryParts, config.MaxInMemoryParts);
            Assert.AreEqual(bufferSize, config.BufferSize);
            Assert.AreEqual(targetPartSize, config.TargetPartSizeBytes);
        }

        [TestMethod]
        public void Constructor_WithCustomPartSize_UsesProvidedValue()
        {
            // Arrange
            long expectedPartSize = 10 * 1024 * 1024; // 10MB

            // Act
            var config = new StreamConfiguration(10, 5, 8192, expectedPartSize);

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
            var config = new StreamConfiguration(largeValue, largeValue, largeValue, largePartSize);

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
            var config = new StreamConfiguration(1, 1, 1, partSize);

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
        public void Validate_WithNegativeConcurrentRequests_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(-1, 5, 8192, 8 * 1024 * 1024);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Validate_WithZeroConcurrentRequests_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(0, 5, 8192, 8 * 1024 * 1024);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Validate_WithNegativeMaxInMemoryParts_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(10, -1, 8192, 8 * 1024 * 1024);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Validate_WithZeroMaxInMemoryParts_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(10, 0, 8192, 8 * 1024 * 1024);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Validate_WithNegativeTargetPartSize_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(10, 5, 8192, -1L);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Validate_WithZeroTargetPartSize_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(10, 5, 8192, 0L);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Validate_WithNegativeBufferSize_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(10, 5, -1, 8 * 1024 * 1024);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Validate_WithZeroBufferSize_ThrowsException()
        {
            // Arrange
            var config = new StreamConfiguration(10, 5, 0, 8 * 1024 * 1024);

            // Act
            config.Validate();

            // Assert - ExpectedException
        }

        [TestMethod]
        public void Validate_WithValidConfiguration_DoesNotThrow()
        {
            // Arrange
            var config = new StreamConfiguration(10, 5, 8192, 8 * 1024 * 1024);

            // Act & Assert - Should not throw
            config.Validate();
        }

        #endregion
    }
}
