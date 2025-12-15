using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for ChunkedBufferStream class.
    /// Tests ArrayPool-based chunked buffer management and Stream interface compliance.
    /// </summary>
    [TestClass]
    public class ChunkedBufferStreamTests
    {
        #region Creation and Mode Tests

        [TestMethod]
        public void Constructor_InitializesInWriteMode()
        {
            // Arrange & Act
            using (var stream = new ChunkedBufferStream())
            {
                // Assert
                Assert.IsTrue(stream.CanWrite);
                Assert.IsFalse(stream.CanRead);
                Assert.IsFalse(stream.CanSeek);
                Assert.AreEqual(0, stream.Length);
                Assert.AreEqual(0, stream.Position);
            }
        }

        [TestMethod]
        public void SwitchToReadMode_TransitionsCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = Encoding.UTF8.GetBytes("Test data for read mode");
                stream.Write(testData, 0, testData.Length);

                // Act
                stream.SwitchToReadMode();

                // Assert
                Assert.IsTrue(stream.CanRead);
                Assert.IsFalse(stream.CanWrite);
                Assert.IsFalse(stream.CanSeek);
                Assert.AreEqual(0, stream.Position); // Position reset to 0
                Assert.AreEqual(testData.Length, stream.Length);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SwitchToReadMode_CalledTwice_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                stream.SwitchToReadMode();

                // Act - Should throw
                stream.SwitchToReadMode();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Write_AfterSwitchToReadMode_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                stream.SwitchToReadMode();
                byte[] testData = new byte[100];

                // Act - Should throw
                stream.Write(testData, 0, testData.Length);
            }
        }

        #endregion

        #region Write Operation Tests

        [TestMethod]
        public void Write_SingleChunk_WritesCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = new byte[1024];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)(i % 256);

                // Act
                stream.Write(testData, 0, testData.Length);

                // Assert
                Assert.AreEqual(testData.Length, stream.Length);
                Assert.AreEqual(testData.Length, stream.Position);

                // Verify data by reading back
                stream.SwitchToReadMode();
                byte[] readBuffer = new byte[testData.Length];
                int bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);

                Assert.AreEqual(testData.Length, bytesRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public void Write_MultipleChunks_WritesCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Write 200KB of data (spans multiple 80KB chunks)
                int totalSize = 200 * 1024;
                byte[] testData = new byte[totalSize];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)(i % 256);

                // Act
                stream.Write(testData, 0, testData.Length);

                // Assert
                Assert.AreEqual(totalSize, stream.Length);

                // Verify data by reading back
                stream.SwitchToReadMode();
                byte[] readBuffer = new byte[totalSize];
                int bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);

                Assert.AreEqual(totalSize, bytesRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public void Write_AtChunkBoundary_WritesCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Write exactly 80KB (one chunk size)
                int chunkSize = 81920; // 80KB
                byte[] testData = new byte[chunkSize];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)(i % 256);

                // Act
                stream.Write(testData, 0, testData.Length);

                // Assert
                Assert.AreEqual(chunkSize, stream.Length);

                // Write one more byte to trigger next chunk
                byte[] oneByte = new byte[] { 42 };
                stream.Write(oneByte, 0, 1);
                Assert.AreEqual(chunkSize + 1, stream.Length);

                // Verify data
                stream.SwitchToReadMode();
                byte[] readBuffer = new byte[chunkSize + 1];
                int bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);

                Assert.AreEqual(chunkSize + 1, bytesRead);
                for (int i = 0; i < chunkSize; i++)
                    Assert.AreEqual(testData[i], readBuffer[i]);
                Assert.AreEqual(42, readBuffer[chunkSize]);
            }
        }

        [TestMethod]
        public async Task WriteAsync_DelegatesToWrite()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = Encoding.UTF8.GetBytes("Test async write");

                // Act
                await stream.WriteAsync(testData, 0, testData.Length, CancellationToken.None);

                // Assert
                Assert.AreEqual(testData.Length, stream.Length);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Write_NullBuffer_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Act - Should throw
                stream.Write(null, 0, 100);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Write_NegativeOffset_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] buffer = new byte[100];

                // Act - Should throw
                stream.Write(buffer, -1, 50);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Write_NegativeCount_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] buffer = new byte[100];

                // Act - Should throw
                stream.Write(buffer, 0, -1);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Write_OffsetAndCountExceedBufferBounds_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] buffer = new byte[100];

                // Act - Should throw
                stream.Write(buffer, 50, 60); // 50 + 60 = 110 > 100
            }
        }

        #endregion

        #region Read Operation Tests

        [TestMethod]
        public void Read_SingleChunk_ReadsCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = new byte[1024];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)(i % 256);

                stream.Write(testData, 0, testData.Length);
                stream.SwitchToReadMode();

                // Act
                byte[] readBuffer = new byte[testData.Length];
                int bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);

                // Assert
                Assert.AreEqual(testData.Length, bytesRead);
                CollectionAssert.AreEqual(testData, readBuffer);
                Assert.AreEqual(testData.Length, stream.Position);
            }
        }

        [TestMethod]
        public void Read_AcrossMultipleChunks_ReadsCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Write 200KB spanning multiple chunks
                int totalSize = 200 * 1024;
                byte[] testData = new byte[totalSize];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)(i % 256);

                stream.Write(testData, 0, testData.Length);
                stream.SwitchToReadMode();

                // Act - Read in one go
                byte[] readBuffer = new byte[totalSize];
                int bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);

                // Assert
                Assert.AreEqual(totalSize, bytesRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public void Read_InMultipleChunks_ReadsCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = new byte[10000];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)(i % 256);

                stream.Write(testData, 0, testData.Length);
                stream.SwitchToReadMode();

                // Act - Read in multiple smaller reads
                byte[] readBuffer = new byte[testData.Length];
                int totalRead = 0;
                int chunkSize = 1000;

                while (totalRead < testData.Length)
                {
                    int bytesRead = stream.Read(readBuffer, totalRead, Math.Min(chunkSize, testData.Length - totalRead));
                    totalRead += bytesRead;
                }

                // Assert
                Assert.AreEqual(testData.Length, totalRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        public void Read_AtEndOfStream_ReturnsZero()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = new byte[100];
                stream.Write(testData, 0, testData.Length);
                stream.SwitchToReadMode();

                // Read all data
                byte[] readBuffer = new byte[100];
                stream.Read(readBuffer, 0, 100);

                // Act - Try to read more
                int bytesRead = stream.Read(readBuffer, 0, 100);

                // Assert
                Assert.AreEqual(0, bytesRead);
                Assert.AreEqual(100, stream.Position);
            }
        }

        [TestMethod]
        public void Read_PartialData_ReadsAvailableBytes()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = new byte[50];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)i;

                stream.Write(testData, 0, testData.Length);
                stream.SwitchToReadMode();

                // Act - Try to read more than available
                byte[] readBuffer = new byte[100];
                int bytesRead = stream.Read(readBuffer, 0, 100);

                // Assert - Should only read 50 bytes
                Assert.AreEqual(50, bytesRead);
                for (int i = 0; i < 50; i++)
                    Assert.AreEqual(testData[i], readBuffer[i]);
            }
        }

        [TestMethod]
        public async Task ReadAsync_DelegatesToRead()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = Encoding.UTF8.GetBytes("Test async read");
                stream.Write(testData, 0, testData.Length);
                stream.SwitchToReadMode();

                // Act
                byte[] readBuffer = new byte[testData.Length];
                int bytesRead = await stream.ReadAsync(readBuffer, 0, readBuffer.Length, CancellationToken.None);

                // Assert
                Assert.AreEqual(testData.Length, bytesRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Read_NullBuffer_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                stream.SwitchToReadMode();

                // Act - Should throw
                stream.Read(null, 0, 100);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Read_NegativeOffset_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                stream.SwitchToReadMode();
                byte[] buffer = new byte[100];

                // Act - Should throw
                stream.Read(buffer, -1, 50);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Read_NegativeCount_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                stream.SwitchToReadMode();
                byte[] buffer = new byte[100];

                // Act - Should throw
                stream.Read(buffer, 0, -1);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Read_OffsetAndCountExceedBufferBounds_ThrowsException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                stream.SwitchToReadMode();
                byte[] buffer = new byte[100];

                // Act - Should throw
                stream.Read(buffer, 50, 60); // 50 + 60 = 110 > 100
            }
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void CanRead_ReflectsCurrentMode()
        {
            // Arrange & Act
            using (var stream = new ChunkedBufferStream())
            {
                // Assert - In write mode
                Assert.IsFalse(stream.CanRead);

                // Switch to read mode
                stream.SwitchToReadMode();
                Assert.IsTrue(stream.CanRead);
            }
        }

        [TestMethod]
        public void CanWrite_ReflectsCurrentMode()
        {
            // Arrange & Act
            using (var stream = new ChunkedBufferStream())
            {
                // Assert - In write mode
                Assert.IsTrue(stream.CanWrite);

                // Switch to read mode
                stream.SwitchToReadMode();
                Assert.IsFalse(stream.CanWrite);
            }
        }

        [TestMethod]
        public void CanSeek_AlwaysReturnsFalse()
        {
            // Arrange & Act
            using (var stream = new ChunkedBufferStream())
            {
                // Assert - In write mode
                Assert.IsFalse(stream.CanSeek);

                // Switch to read mode
                stream.SwitchToReadMode();
                Assert.IsFalse(stream.CanSeek);
            }
        }

        [TestMethod]
        public void Length_ReturnsCorrectValue()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Assert - Initially zero
                Assert.AreEqual(0, stream.Length);

                // Write some data
                byte[] testData = new byte[5000];
                stream.Write(testData, 0, testData.Length);

                // Assert - After writing
                Assert.AreEqual(5000, stream.Length);

                // Switch to read mode
                stream.SwitchToReadMode();

                // Assert - Length unchanged
                Assert.AreEqual(5000, stream.Length);
            }
        }

        [TestMethod]
        public void Position_GetReturnsCorrectValue()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = new byte[1000];
                stream.Write(testData, 0, testData.Length);

                // Assert - Position at end after write
                Assert.AreEqual(1000, stream.Position);

                // Switch to read mode
                stream.SwitchToReadMode();

                // Assert - Position reset to 0
                Assert.AreEqual(0, stream.Position);

                // Read some data
                byte[] readBuffer = new byte[300];
                stream.Read(readBuffer, 0, 300);

                // Assert - Position updated after read
                Assert.AreEqual(300, stream.Position);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Position_Set_ThrowsNotSupportedException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Act - Should throw
                stream.Position = 100;
            }
        }

        #endregion

        #region Not Supported Operations

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void Seek_ThrowsNotSupportedException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Act - Should throw
                stream.Seek(0, SeekOrigin.Begin);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NotSupportedException))]
        public void SetLength_ThrowsNotSupportedException()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Act - Should throw
                stream.SetLength(1000);
            }
        }

        [TestMethod]
        public void Flush_DoesNotThrow()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                byte[] testData = new byte[100];
                stream.Write(testData, 0, testData.Length);

                // Act - Should not throw
                stream.Flush();

                // Assert - No-op, just verify it doesn't throw
                Assert.AreEqual(100, stream.Length);
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_ReturnsChunksToArrayPool()
        {
            // Arrange
            var stream = new ChunkedBufferStream();
            byte[] testData = new byte[100000]; // Enough to allocate chunks
            stream.Write(testData, 0, testData.Length);

            // Act
            stream.Dispose();

            // Assert - Accessing properties should throw ObjectDisposedException
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
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var stream = new ChunkedBufferStream();
            byte[] testData = new byte[1000];
            stream.Write(testData, 0, testData.Length);

            // Act - Dispose multiple times
            stream.Dispose();
            stream.Dispose();
            stream.Dispose();

            // Assert - Should not throw
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void Write_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var stream = new ChunkedBufferStream();
            stream.Dispose();

            // Act - Should throw
            byte[] testData = new byte[100];
            stream.Write(testData, 0, testData.Length);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void Read_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var stream = new ChunkedBufferStream();
            stream.SwitchToReadMode();
            stream.Dispose();

            // Act - Should throw
            byte[] buffer = new byte[100];
            stream.Read(buffer, 0, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void Length_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var stream = new ChunkedBufferStream();
            stream.Dispose();

            // Act - Should throw
            var length = stream.Length;
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void Position_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var stream = new ChunkedBufferStream();
            stream.Dispose();

            // Act - Should throw
            var position = stream.Position;
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void SwitchToReadMode_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var stream = new ChunkedBufferStream();
            stream.Dispose();

            // Act - Should throw
            stream.SwitchToReadMode();
        }

        #endregion

        #region Edge Cases

        [TestMethod]
        public void EmptyStream_SwitchToReadMode_WorksCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Act - Don't write any data, just switch to read mode
                stream.SwitchToReadMode();

                // Assert
                Assert.AreEqual(0, stream.Length);
                Assert.AreEqual(0, stream.Position);
                Assert.IsTrue(stream.CanRead);

                // Read should return 0
                byte[] buffer = new byte[100];
                int bytesRead = stream.Read(buffer, 0, 100);
                Assert.AreEqual(0, bytesRead);
            }
        }

        [TestMethod]
        public void Write_AtExactChunkBoundaries_HandlesCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                int chunkSize = 81920; // 80KB

                // Write exactly 2 chunks
                byte[] chunk1 = new byte[chunkSize];
                byte[] chunk2 = new byte[chunkSize];

                for (int i = 0; i < chunkSize; i++)
                {
                    chunk1[i] = 1;
                    chunk2[i] = 2;
                }

                // Act
                stream.Write(chunk1, 0, chunkSize);
                stream.Write(chunk2, 0, chunkSize);

                // Assert
                Assert.AreEqual(chunkSize * 2, stream.Length);

                // Verify data
                stream.SwitchToReadMode();
                byte[] readBuffer = new byte[chunkSize * 2];
                int bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);

                Assert.AreEqual(chunkSize * 2, bytesRead);
                
                // Verify first chunk
                for (int i = 0; i < chunkSize; i++)
                    Assert.AreEqual(1, readBuffer[i]);
                
                // Verify second chunk
                for (int i = chunkSize; i < chunkSize * 2; i++)
                    Assert.AreEqual(2, readBuffer[i]);
            }
        }

        [TestMethod]
        public void Read_AtChunkBoundary_HandlesCorrectly()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                int chunkSize = 81920; // 80KB
                
                // Write 2.5 chunks worth of data
                byte[] testData = new byte[chunkSize * 2 + chunkSize / 2];
                for (int i = 0; i < testData.Length; i++)
                    testData[i] = (byte)(i % 256);

                stream.Write(testData, 0, testData.Length);
                stream.SwitchToReadMode();

                // Act - Read exactly one chunk
                byte[] readBuffer1 = new byte[chunkSize];
                int bytesRead1 = stream.Read(readBuffer1, 0, chunkSize);

                // Act - Read next chunk
                byte[] readBuffer2 = new byte[chunkSize];
                int bytesRead2 = stream.Read(readBuffer2, 0, chunkSize);

                // Act - Read remaining
                byte[] readBuffer3 = new byte[chunkSize];
                int bytesRead3 = stream.Read(readBuffer3, 0, chunkSize);

                // Assert
                Assert.AreEqual(chunkSize, bytesRead1);
                Assert.AreEqual(chunkSize, bytesRead2);
                Assert.AreEqual(chunkSize / 2, bytesRead3);

                // Verify data integrity
                for (int i = 0; i < chunkSize; i++)
                    Assert.AreEqual((byte)(i % 256), readBuffer1[i]);
                
                for (int i = 0; i < chunkSize; i++)
                    Assert.AreEqual((byte)((chunkSize + i) % 256), readBuffer2[i]);
                
                for (int i = 0; i < chunkSize / 2; i++)
                    Assert.AreEqual((byte)((chunkSize * 2 + i) % 256), readBuffer3[i]);
            }
        }

        [TestMethod]
        public void LargeData_HandlesMultipleChunks()
        {
            // Arrange
            using (var stream = new ChunkedBufferStream())
            {
                // Write 500KB of data (spans ~6 chunks)
                int totalSize = 500 * 1024;
                byte[] testData = new byte[totalSize];
                var random = new Random(42); // Fixed seed for reproducibility
                random.NextBytes(testData);

                // Act - Write
                stream.Write(testData, 0, testData.Length);

                // Assert - Length
                Assert.AreEqual(totalSize, stream.Length);

                // Act - Read back
                stream.SwitchToReadMode();
                byte[] readBuffer = new byte[totalSize];
                int bytesRead = stream.Read(readBuffer, 0, totalSize);

                // Assert - Data integrity
                Assert.AreEqual(totalSize, bytesRead);
                CollectionAssert.AreEqual(testData, readBuffer);
            }
        }

        #endregion
    }
}
