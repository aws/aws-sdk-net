using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Buffers;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for StreamPartBuffer class.
    /// Tests ArrayPool buffer management and position tracking.
    /// </summary>
    [TestClass]
    public class StreamPartBufferTests
    {
        #region Creation Tests

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesBuffer()
        {
            // Arrange
            int partNumber = 1;
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            int actualLength = 512;

            try
            {
                // Act
                var partBuffer = new StreamPartBuffer(partNumber, testBuffer, actualLength);

                // Assert
                Assert.AreEqual(partNumber, partBuffer.PartNumber);
                Assert.AreSame(testBuffer, partBuffer.ArrayPoolBuffer);
                Assert.AreEqual(actualLength, partBuffer.Length);
                Assert.AreEqual(0, partBuffer.CurrentPosition);
                Assert.AreEqual(actualLength, partBuffer.RemainingBytes);
            }
            finally
            {
                // Note: Buffer ownership transferred to partBuffer, will be returned on dispose
            }
        }

        [TestMethod]
        public void FromArrayPoolBuffer_CreatesBuffer()
        {
            // Arrange
            int partNumber = 2;
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(2048);
            int actualLength = 1024;

            try
            {
                // Act
                var partBuffer = StreamPartBuffer.FromArrayPoolBuffer(partNumber, testBuffer, actualLength);

                // Assert
                Assert.AreEqual(partNumber, partBuffer.PartNumber);
                Assert.AreSame(testBuffer, partBuffer.ArrayPoolBuffer);
                Assert.AreEqual(actualLength, partBuffer.Length);
                Assert.AreEqual(0, partBuffer.CurrentPosition);
            }
            finally
            {
                // Note: Buffer ownership transferred to partBuffer
            }
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void RemainingBytes_ReturnsCorrectValue()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            try
            {
                // Act & Assert - At start
                Assert.AreEqual(500, partBuffer.RemainingBytes);

                // Act & Assert - After reading some bytes
                partBuffer.CurrentPosition = 100;
                Assert.AreEqual(400, partBuffer.RemainingBytes);

                // Act & Assert - At end
                partBuffer.CurrentPosition = 500;
                Assert.AreEqual(0, partBuffer.RemainingBytes);
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        [TestMethod]
        public void Length_ReturnsCorrectValue()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(2048);
            int actualLength = 1000;
            var partBuffer = new StreamPartBuffer(1, testBuffer, actualLength);

            try
            {
                // Act & Assert
                Assert.AreEqual(actualLength, partBuffer.Length);
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        [TestMethod]
        public void CurrentPosition_CanBeUpdated()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            try
            {
                // Act
                partBuffer.CurrentPosition = 250;

                // Assert
                Assert.AreEqual(250, partBuffer.CurrentPosition);
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        #endregion

        #region Reading Position Tests

        [TestMethod]
        public void CurrentPosition_AfterReading_UpdatesCorrectly()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            try
            {
                // Simulate reading 100 bytes
                partBuffer.CurrentPosition += 100;
                Assert.AreEqual(100, partBuffer.CurrentPosition);
                Assert.AreEqual(400, partBuffer.RemainingBytes);

                // Simulate reading another 150 bytes
                partBuffer.CurrentPosition += 150;
                Assert.AreEqual(250, partBuffer.CurrentPosition);
                Assert.AreEqual(250, partBuffer.RemainingBytes);
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        [TestMethod]
        public void RemainingBytes_WhenFullyRead_ReturnsZero()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            try
            {
                // Act - Read all bytes
                partBuffer.CurrentPosition = 500;

                // Assert
                Assert.AreEqual(0, partBuffer.RemainingBytes);
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_ReturnsBufferToArrayPool()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            // Act
            partBuffer.Dispose();

            // Assert - Buffer should be returned (verified by checking it's nulled)
            Assert.IsNull(partBuffer.ArrayPoolBuffer);
        }

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            // Act - Dispose multiple times
            partBuffer.Dispose();
            partBuffer.Dispose();
            partBuffer.Dispose();

            // Assert - Should not throw
            Assert.IsNull(partBuffer.ArrayPoolBuffer);
        }

        [TestMethod]
        public void Dispose_SetsArrayPoolBufferToNull()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            // Act
            partBuffer.Dispose();

            // Assert
            Assert.IsNull(partBuffer.ArrayPoolBuffer);
        }

        #endregion

        #region Edge Cases

        [TestMethod]
        public void Constructor_WithEmptyBuffer_HandlesCorrectly()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 0);

            try
            {
                // Assert
                Assert.AreEqual(0, partBuffer.Length);
                Assert.AreEqual(0, partBuffer.RemainingBytes);
                Assert.AreEqual(0, partBuffer.CurrentPosition);
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        [TestMethod]
        public void RemainingBytes_WhenPositionBeyondLength_ReturnsZero()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 500);

            try
            {
                // Act - Position beyond actual length
                partBuffer.CurrentPosition = 600;

                // Assert - RemainingBytes uses Math.Max(0, ...) to prevent negative
                Assert.AreEqual(0, partBuffer.RemainingBytes);
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        #endregion

        #region ToString Tests

        [TestMethod]
        public void ToString_ReturnsExpectedFormat()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(3, testBuffer, 500);

            try
            {
                partBuffer.CurrentPosition = 100;

                // Act
                string result = partBuffer.ToString();

                // Assert - Verify format contains key information
                Assert.IsTrue(result.Contains("Part=3"));
                Assert.IsTrue(result.Contains("500 bytes"));
                Assert.IsTrue(result.Contains("pos=100"));
                Assert.IsTrue(result.Contains("remaining=400"));
            }
            finally
            {
                partBuffer.Dispose();
            }
        }

        #endregion
    }
}
