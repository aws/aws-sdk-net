using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for ChunkedPartDataSource class.
    /// Tests IPartDataSource implementation wrapping ChunkedBufferStream.
    /// </summary>
    [TestClass]
    public class ChunkedPartDataSourceTests
    {
        #region Creation Tests

        [TestMethod]
        public void Constructor_WithValidStream_CreatesDataSource()
        {
            // Arrange
            byte[] testData = Encoding.UTF8.GetBytes("Test data for part");
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            // Act
            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Assert
                Assert.AreEqual(1, dataSource.PartNumber);
                Assert.IsFalse(dataSource.IsComplete);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullStream_ThrowsException()
        {
            // Act - Should throw
            var dataSource = new ChunkedPartDataSource(1, null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Constructor_WithStreamNotInReadMode_ThrowsException()
        {
            // Arrange
            byte[] testData = Encoding.UTF8.GetBytes("Test data");
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            // Don't call SwitchToReadMode()

            // Act - Should throw
            var dataSource = new ChunkedPartDataSource(1, stream);
        }

        [TestMethod]
        public void Constructor_SetsPartNumberCorrectly()
        {
            // Arrange
            var stream = new ChunkedBufferStream(1024);
            stream.SwitchToReadMode();

            // Act
            using (var dataSource = new ChunkedPartDataSource(5, stream))
            {
                // Assert
                Assert.AreEqual(5, dataSource.PartNumber);
            }
        }

        #endregion

        #region ReadAsync Tests

        [TestMethod]
        public async Task ReadAsync_DelegatesToUnderlyingStream()
        {
            // Arrange
            byte[] testData = Encoding.UTF8.GetBytes("Test data for reading");
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Act
                byte[] readBuffer = new byte[testData.Length];
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, readBuffer.Length, CancellationToken.None);

                // Assert
                Assert.AreEqual(testData.Length, bytesRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public async Task ReadAsync_ReturnsCorrectByteCount()
        {
            // Arrange
            byte[] testData = new byte[1000];
            var stream = new ChunkedBufferStream(testData.Length);
            for (int i = 0; i < testData.Length; i++)
                testData[i] = (byte)(i % 256);

            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Act
                byte[] readBuffer = new byte[500];
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, 500, CancellationToken.None);

                // Assert
                Assert.AreEqual(500, bytesRead);
                for (int i = 0; i < 500; i++)
                    Assert.AreEqual(testData[i], readBuffer[i]);
            }
        }

        [TestMethod]
        public async Task ReadAsync_HandlesPartialReads()
        {
            // Arrange
            byte[] testData = new byte[100];
            var stream = new ChunkedBufferStream(testData.Length);
            for (int i = 0; i < testData.Length; i++)
                testData[i] = (byte)i;

            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Act - Try to read more than available
                byte[] readBuffer = new byte[200];
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, 200, CancellationToken.None);

                // Assert - Should only read 100 bytes
                Assert.AreEqual(100, bytesRead);
                for (int i = 0; i < 100; i++)
                    Assert.AreEqual(testData[i], readBuffer[i]);
            }
        }

        [TestMethod]
        public async Task ReadAsync_RespectsCancellationToken()
        {
            // Arrange
            byte[] testData = Encoding.UTF8.GetBytes("Test cancellation");
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                var cts = new CancellationTokenSource();
                cts.Cancel(); // Cancel immediately

                // Act & Assert
                byte[] readBuffer = new byte[100];
                try
                {
                    await dataSource.ReadAsync(readBuffer, 0, 100, cts.Token);
                    Assert.Fail("Expected OperationCanceledException");
                }
                catch (OperationCanceledException)
                {
                    // Expected
                }
            }
        }

        [TestMethod]
        public async Task ReadAsync_WorksWithVariousBufferSizes()
        {
            // Arrange
            int totalSize = 10000;
            var stream = new ChunkedBufferStream(totalSize);
            byte[] testData = new byte[totalSize];
            for (int i = 0; i < totalSize; i++)
                testData[i] = (byte)(i % 256);

            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Act - Read in varying chunk sizes
                byte[] readBuffer = new byte[totalSize];
                int totalRead = 0;
                int[] chunkSizes = { 100, 500, 1000, 2000, 6400 }; // Various sizes

                foreach (int chunkSize in chunkSizes)
                {
                    int bytesRead = await dataSource.ReadAsync(readBuffer, totalRead, chunkSize, CancellationToken.None);
                    totalRead += bytesRead;
                }

                // Assert
                Assert.AreEqual(totalSize, totalRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public async Task ReadAsync_ReturnsZeroAtEndOfStream()
        {
            // Arrange
            byte[] testData = new byte[100];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Read all data
                byte[] readBuffer = new byte[100];
                await dataSource.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Act - Try to read more
                int bytesRead = await dataSource.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert
                Assert.AreEqual(0, bytesRead);
            }
        }

        #endregion

        #region IsComplete Property Tests

        [TestMethod]
        public void IsComplete_ReturnsFalse_WhenDataRemains()
        {
            // Arrange
            byte[] testData = new byte[1000];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Assert
                Assert.IsFalse(dataSource.IsComplete);
            }
        }

        [TestMethod]
        public async Task IsComplete_ReturnsTrue_WhenFullyConsumed()
        {
            // Arrange
            byte[] testData = new byte[100];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Act - Read all data
                byte[] readBuffer = new byte[100];
                await dataSource.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert
                Assert.IsTrue(dataSource.IsComplete);
            }
        }

        [TestMethod]
        public async Task IsComplete_UpdatesCorrectly_AsDataIsRead()
        {
            // Arrange
            byte[] testData = new byte[300];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Assert - Initially not complete
                Assert.IsFalse(dataSource.IsComplete);

                // Act - Read partial data
                byte[] readBuffer = new byte[100];
                await dataSource.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert - Still not complete
                Assert.IsFalse(dataSource.IsComplete);

                // Act - Read more data
                await dataSource.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert - Still not complete
                Assert.IsFalse(dataSource.IsComplete);

                // Act - Read remaining data
                await dataSource.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert - Now complete
                Assert.IsTrue(dataSource.IsComplete);
            }
        }

        [TestMethod]
        public void IsComplete_ReturnsTrue_ForEmptyStream()
        {
            // Arrange
            var stream = new ChunkedBufferStream(1024);
            stream.SwitchToReadMode(); // Empty stream

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Assert - Empty stream is considered "complete" since Position == Length (both 0)
                Assert.IsTrue(dataSource.IsComplete);
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_ReleasesUnderlyingStream()
        {
            // Arrange
            byte[] testData = new byte[1000];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            var dataSource = new ChunkedPartDataSource(1, stream);

            // Act
            dataSource.Dispose();

            // Assert - Stream should be disposed, accessing it should throw
            try
            {
                var length = stream.Length;
                Assert.Fail("Expected ObjectDisposedException");
            }
            catch (ObjectDisposedException)
            {
                // Expected
            }
        }

        [TestMethod]
        public void Dispose_MultipleCalls_AreSafe()
        {
            // Arrange
            byte[] testData = new byte[1000];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            var dataSource = new ChunkedPartDataSource(1, stream);

            // Act - Dispose multiple times
            dataSource.Dispose();
            dataSource.Dispose();
            dataSource.Dispose();

            // Assert - Should not throw
        }

        [TestMethod]
        public void Dispose_ReturnsChunksToArrayPool()
        {
            // Arrange
            // Write enough data to allocate multiple chunks
            byte[] testData = new byte[200 * 1024]; // 200KB
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            var dataSource = new ChunkedPartDataSource(1, stream);

            // Act
            dataSource.Dispose();

            // Assert - Stream disposed, chunks returned to pool
            // We can't directly verify ArrayPool state, but we can verify disposal
            try
            {
                var length = stream.Length;
                Assert.Fail("Expected ObjectDisposedException");
            }
            catch (ObjectDisposedException)
            {
                // Expected - confirms disposal happened
            }
        }

        #endregion

        #region ToString Tests

        [TestMethod]
        public void ToString_ReturnsExpectedFormat()
        {
            // Arrange
            byte[] testData = new byte[1500];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(3, stream))
            {
                // Act
                string result = dataSource.ToString();

                // Assert - Verify format contains key information
                Assert.IsTrue(result.Contains("Part=3"));
                Assert.IsTrue(result.Contains("1500 bytes"));
                Assert.IsTrue(result.Contains("Position=0"));
            }
        }

        [TestMethod]
        public async Task ToString_ReflectsCurrentPosition()
        {
            // Arrange
            byte[] testData = new byte[1000];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(2, stream))
            {
                // Read 300 bytes
                byte[] readBuffer = new byte[300];
                await dataSource.ReadAsync(readBuffer, 0, 300, CancellationToken.None);

                // Act
                string result = dataSource.ToString();

                // Assert - Position should be reflected
                Assert.IsTrue(result.Contains("Part=2"));
                Assert.IsTrue(result.Contains("1000 bytes"));
                Assert.IsTrue(result.Contains("Position=300"));
            }
        }

        #endregion

        #region Integration Tests

        [TestMethod]
        public async Task FullReadCycle_FromCreationToDisposal()
        {
            // Arrange
            int totalSize = 100 * 1024; // 100KB
            var stream = new ChunkedBufferStream(totalSize);
            byte[] testData = new byte[totalSize];
            for (int i = 0; i < totalSize; i++)
                testData[i] = (byte)(i % 256);

            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            var dataSource = new ChunkedPartDataSource(1, stream);

            try
            {
                // Act - Read all data in chunks
                byte[] readBuffer = new byte[totalSize];
                int totalRead = 0;
                int chunkSize = 8192; // 8KB chunks

                while (!dataSource.IsComplete)
                {
                    int bytesRead = await dataSource.ReadAsync(
                        readBuffer, 
                        totalRead, 
                        Math.Min(chunkSize, totalSize - totalRead), 
                        CancellationToken.None);
                    
                    if (bytesRead == 0)
                        break;

                    totalRead += bytesRead;
                }

                // Assert
                Assert.AreEqual(totalSize, totalRead);
                Assert.IsTrue(dataSource.IsComplete);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
            finally
            {
                // Cleanup
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task SequentialReading_HandlesCorrectly()
        {
            // Arrange
            byte[] testData = new byte[5000];
            var stream = new ChunkedBufferStream(testData.Length);
            for (int i = 0; i < testData.Length; i++)
                testData[i] = (byte)(i % 256);

            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Act - Sequential reads with different sizes
                byte[] readBuffer = new byte[5000];
                int offset = 0;

                // Read 1000 bytes
                int read1 = await dataSource.ReadAsync(readBuffer, offset, 1000, CancellationToken.None);
                offset += read1;

                // Read 2000 bytes
                int read2 = await dataSource.ReadAsync(readBuffer, offset, 2000, CancellationToken.None);
                offset += read2;

                // Read remaining
                int read3 = await dataSource.ReadAsync(readBuffer, offset, 2000, CancellationToken.None);
                offset += read3;

                // Assert
                Assert.AreEqual(1000, read1);
                Assert.AreEqual(2000, read2);
                Assert.AreEqual(2000, read3);
                Assert.AreEqual(5000, offset);
                Assert.IsTrue(dataSource.IsComplete);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public async Task LargePartData_HandlesMultipleChunks()
        {
            // Arrange
            // Write 300KB spanning multiple 80KB chunks
            int totalSize = 300 * 1024;
            var stream = new ChunkedBufferStream(totalSize);
            byte[] testData = new byte[totalSize];
            var random = new Random(42); // Fixed seed for reproducibility
            random.NextBytes(testData);

            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(1, stream))
            {
                // Act - Read in 64KB chunks
                byte[] readBuffer = new byte[totalSize];
                int totalRead = 0;
                int chunkSize = 64 * 1024;

                while (totalRead < totalSize)
                {
                    int bytesRead = await dataSource.ReadAsync(
                        readBuffer, 
                        totalRead, 
                        Math.Min(chunkSize, totalSize - totalRead), 
                        CancellationToken.None);
                    
                    if (bytesRead == 0)
                        break;

                    totalRead += bytesRead;
                }

                // Assert
                Assert.AreEqual(totalSize, totalRead);
                Assert.IsTrue(dataSource.IsComplete);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public void PartNumber_RemainsConstant()
        {
            // Arrange
            byte[] testData = new byte[1000];
            var stream = new ChunkedBufferStream(testData.Length);
            stream.Write(testData, 0, testData.Length);
            stream.SwitchToReadMode();

            using (var dataSource = new ChunkedPartDataSource(7, stream))
            {
                // Assert - Check multiple times
                Assert.AreEqual(7, dataSource.PartNumber);
                Assert.AreEqual(7, dataSource.PartNumber);
                Assert.AreEqual(7, dataSource.PartNumber);
            }
        }

        #endregion
    }
}
