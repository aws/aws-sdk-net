using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Buffers;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for BufferedDataSource class.
    /// Tests reading from pre-buffered StreamPartBuffer data.
    /// </summary>
    [TestClass]
    public class BufferedDataSourceTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidPartBuffer_CreatesDataSource()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);

            // Act
            var dataSource = new BufferedDataSource(partBuffer);

            // Assert
            Assert.IsNotNull(dataSource);
            Assert.AreEqual(1, dataSource.PartNumber);
            Assert.IsFalse(dataSource.IsComplete);

            // Cleanup
            dataSource.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullPartBuffer_ThrowsArgumentNullException()
        {
            // Act
            var dataSource = new BufferedDataSource(null);

            // Assert - ExpectedException
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void PartNumber_ReturnsPartBufferPartNumber()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(5, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);

            try
            {
                // Act & Assert
                Assert.AreEqual(5, dataSource.PartNumber);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public void IsComplete_WhenNoRemainingBytes_ReturnsTrue()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            partBuffer.CurrentPosition = 512; // Move to end
            var dataSource = new BufferedDataSource(partBuffer);

            try
            {
                // Act & Assert
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public void IsComplete_WhenRemainingBytes_ReturnsFalse()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);

            try
            {
                // Act & Assert
                Assert.IsFalse(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Happy Path

        [TestMethod]
        public async Task ReadAsync_ReadsDataFromPartBuffer()
        {
            // Arrange
            byte[] testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            Buffer.BlockCopy(testData, 0, testBuffer, 0, 512);
            
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            
            byte[] readBuffer = new byte[512];

            try
            {
                // Act
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(512, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, readBuffer, 0, 512));
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_WithPartialRead_ReturnsRequestedBytes()
        {
            // Arrange
            byte[] testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            Buffer.BlockCopy(testData, 0, testBuffer, 0, 512);
            
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            
            byte[] readBuffer = new byte[256];

            try
            {
                // Act
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, 256, CancellationToken.None);

                // Assert
                Assert.AreEqual(256, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, readBuffer, 0, 256));
                Assert.IsFalse(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_WithFullRead_ReadsAllRemainingBytes()
        {
            // Arrange
            byte[] testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            Buffer.BlockCopy(testData, 0, testBuffer, 0, 512);
            
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            
            byte[] readBuffer = new byte[1024]; // Larger than available

            try
            {
                // Act
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, 1024, CancellationToken.None);

                // Assert
                Assert.AreEqual(512, bytesRead); // Only 512 available
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, readBuffer, 0, 512));
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_WhenComplete_ReturnsZero()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            partBuffer.CurrentPosition = 512; // Move to end
            var dataSource = new BufferedDataSource(partBuffer);
            
            byte[] readBuffer = new byte[256];

            try
            {
                // Act
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, 256, CancellationToken.None);

                // Assert
                Assert.AreEqual(0, bytesRead);
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Parameter Validation

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task ReadAsync_WithNullBuffer_ThrowsArgumentNullException()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);

            try
            {
                // Act
                await dataSource.ReadAsync(null, 0, 100, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeOffset_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            byte[] readBuffer = new byte[256];

            try
            {
                // Act
                await dataSource.ReadAsync(readBuffer, -1, 100, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeCount_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            byte[] readBuffer = new byte[256];

            try
            {
                // Act
                await dataSource.ReadAsync(readBuffer, 0, -1, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task ReadAsync_WithOffsetCountExceedingBounds_ThrowsArgumentException()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            byte[] readBuffer = new byte[256];

            try
            {
                // Act - offset + count > buffer.Length
                await dataSource.ReadAsync(readBuffer, 100, 200, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Multiple Reads

        [TestMethod]
        public async Task ReadAsync_MultipleReads_ConsumesAllData()
        {
            // Arrange
            byte[] testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            Buffer.BlockCopy(testData, 0, testBuffer, 0, 512);
            
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            
            byte[] readBuffer1 = new byte[256];
            byte[] readBuffer2 = new byte[256];

            try
            {
                // Act - Read in two chunks
                int bytesRead1 = await dataSource.ReadAsync(readBuffer1, 0, 256, CancellationToken.None);
                int bytesRead2 = await dataSource.ReadAsync(readBuffer2, 0, 256, CancellationToken.None);

                // Assert
                Assert.AreEqual(256, bytesRead1);
                Assert.AreEqual(256, bytesRead2);
                Assert.IsTrue(dataSource.IsComplete);
                
                // Verify data correctness
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, readBuffer1, 0, 256));
                
                // Extract second segment manually for .NET Framework compatibility
                byte[] secondSegment = new byte[256];
                Buffer.BlockCopy(testData, 256, secondSegment, 0, 256);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(
                    secondSegment, 
                    readBuffer2, 
                    0, 
                    256));
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_ReadingToEnd_ReturnsZeroOnSubsequentReads()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            
            byte[] readBuffer = new byte[512];

            try
            {
                // Act - Read all data
                int bytesRead1 = await dataSource.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                
                // Try to read again
                int bytesRead2 = await dataSource.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(512, bytesRead1);
                Assert.AreEqual(0, bytesRead2);
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region Error Handling Tests

        [TestMethod]
        public async Task ReadAsync_WhenExceptionDuringRead_MarksBufferConsumed()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            
            // Create a buffer that will cause BlockCopy to fail (null destination)
            byte[] readBuffer = null;

            try
            {
                // Act & Assert - Should throw ArgumentNullException
                await Assert.ThrowsExceptionAsync<ArgumentNullException>(async () =>
                {
                    await dataSource.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                });

                // Verify buffer was marked as consumed (position set to Length)
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_DisposesUnderlyingPartBuffer()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);

            // Act
            dataSource.Dispose();

            // Assert - The underlying part buffer should be disposed (ArrayPoolBuffer nulled)
            Assert.IsNull(partBuffer.ArrayPoolBuffer);
        }

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);

            // Act - Dispose multiple times
            dataSource.Dispose();
            dataSource.Dispose();
            dataSource.Dispose();

            // Assert - Should not throw
            Assert.IsNull(partBuffer.ArrayPoolBuffer);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public async Task ReadAsync_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(1024);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            var dataSource = new BufferedDataSource(partBuffer);
            byte[] readBuffer = new byte[256];

            // Dispose the data source
            dataSource.Dispose();

            // Act - Try to read after disposal
            await dataSource.ReadAsync(readBuffer, 0, 256, CancellationToken.None);

            // Assert - ExpectedException
        }

        #endregion
    }
}
