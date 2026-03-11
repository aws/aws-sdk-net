using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for StreamingDataSource class.
    /// Tests direct streaming from GetObjectResponse without buffering.
    /// </summary>
    [TestClass]
    public class StreamingDataSourceTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidResponse_CreatesDataSource()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);

            // Act
            var dataSource = new StreamingDataSource(1, response);

            // Assert
            Assert.IsNotNull(dataSource);
            Assert.AreEqual(1, dataSource.PartNumber);
            Assert.IsFalse(dataSource.IsComplete);

            // Cleanup
            dataSource.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullResponse_ThrowsArgumentNullException()
        {
            // Act
            var dataSource = new StreamingDataSource(1, null);

            // Assert - ExpectedException
        }

        [TestMethod]
        public void Constructor_SetsPartNumberCorrectly()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);

            // Act
            var dataSource = new StreamingDataSource(5, response);

            // Assert
            Assert.AreEqual(5, dataSource.PartNumber);

            // Cleanup
            dataSource.Dispose();
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void PartNumber_ReturnsConstructorValue()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(3, response);

            try
            {
                // Act & Assert
                Assert.AreEqual(3, dataSource.PartNumber);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public void IsComplete_InitiallyFalse()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);

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

        [TestMethod]
        public async Task IsComplete_BecomesTrue_AfterFullRead()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            var response = CreateMockGetObjectResponse(512, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read all data
                byte[] buffer = new byte[512];
                await dataSource.ReadAsync(buffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task IsComplete_BecomesTrue_WhenExpectedBytesReached()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(1000, 0);
            var response = CreateMockGetObjectResponse(1000, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read in chunks
                byte[] buffer = new byte[400];
                await dataSource.ReadAsync(buffer, 0, 400, CancellationToken.None);
                await dataSource.ReadAsync(buffer, 0, 400, CancellationToken.None);
                await dataSource.ReadAsync(buffer, 0, 200, CancellationToken.None);

                // Assert
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Basic Functionality

        [TestMethod]
        public async Task ReadAsync_ReadsDataFromResponseStream()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            var response = CreateMockGetObjectResponse(512, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act
                byte[] buffer = new byte[512];
                int bytesRead = await dataSource.ReadAsync(buffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(512, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, buffer, 0, 512));
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_SupportsPartialReads()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(1000, 0);
            var response = CreateMockGetObjectResponse(1000, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read first 300 bytes
                byte[] buffer = new byte[300];
                int bytesRead = await dataSource.ReadAsync(buffer, 0, 300, CancellationToken.None);

                // Assert
                Assert.AreEqual(300, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, buffer, 0, 300));
                Assert.IsFalse(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_SupportsMultipleSequentialReads()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(1000, 0);
            var response = CreateMockGetObjectResponse(1000, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read in chunks
                byte[] buffer1 = new byte[400];
                int bytesRead1 = await dataSource.ReadAsync(buffer1, 0, 400, CancellationToken.None);

                byte[] buffer2 = new byte[400];
                int bytesRead2 = await dataSource.ReadAsync(buffer2, 0, 400, CancellationToken.None);

                byte[] buffer3 = new byte[200];
                int bytesRead3 = await dataSource.ReadAsync(buffer3, 0, 200, CancellationToken.None);

                // Assert
                Assert.AreEqual(400, bytesRead1);
                Assert.AreEqual(400, bytesRead2);
                Assert.AreEqual(200, bytesRead3);
                Assert.IsTrue(dataSource.IsComplete);

                // Verify data correctness
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(
                    testData, buffer1, 0, 400));
                
                byte[] expectedData2 = new byte[400];
                Array.Copy(testData, 400, expectedData2, 0, 400);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(
                    expectedData2, buffer2, 0, 400));
                
                byte[] expectedData3 = new byte[200];
                Array.Copy(testData, 800, expectedData3, 0, 200);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(
                    expectedData3, buffer3, 0, 200));
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_WithOffset_ReadsIntoBufferCorrectly()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(300, 0);
            var response = CreateMockGetObjectResponse(300, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read into buffer with offset
                byte[] buffer = new byte[500];
                int bytesRead = await dataSource.ReadAsync(buffer, 100, 300, CancellationToken.None);

                // Assert
                Assert.AreEqual(300, bytesRead);
                
                // Verify data was written at correct offset
                for (int i = 0; i < 300; i++)
                {
                    Assert.AreEqual(testData[i], buffer[100 + i]);
                }
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
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act
                await dataSource.ReadAsync(null, 0, 512, CancellationToken.None);

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
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);
            byte[] buffer = new byte[512];

            try
            {
                // Act
                await dataSource.ReadAsync(buffer, -1, 512, CancellationToken.None);

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
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);
            byte[] buffer = new byte[512];

            try
            {
                // Act
                await dataSource.ReadAsync(buffer, 0, -1, CancellationToken.None);

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
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);
            byte[] buffer = new byte[512];

            try
            {
                // Act - offset + count exceeds buffer length
                await dataSource.ReadAsync(buffer, 400, 200, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Completion Detection

        [TestMethod]
        public async Task ReadAsync_ReturnsZero_WhenStreamExhausted()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
            var response = CreateMockGetObjectResponse(100, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read all data
                byte[] buffer1 = new byte[100];
                int bytesRead1 = await dataSource.ReadAsync(buffer1, 0, 100, CancellationToken.None);

                // Try to read more
                byte[] buffer2 = new byte[100];
                int bytesRead2 = await dataSource.ReadAsync(buffer2, 0, 100, CancellationToken.None);

                // Assert
                Assert.AreEqual(100, bytesRead1);
                Assert.AreEqual(0, bytesRead2);
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_AfterComplete_ReturnsZero()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
            var response = CreateMockGetObjectResponse(512, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read all data to completion
                byte[] buffer1 = new byte[512];
                await dataSource.ReadAsync(buffer1, 0, 512, CancellationToken.None);

                Assert.IsTrue(dataSource.IsComplete);

                // Try to read again after completion
                byte[] buffer2 = new byte[100];
                int bytesRead = await dataSource.ReadAsync(buffer2, 0, 100, CancellationToken.None);

                // Assert
                Assert.AreEqual(0, bytesRead);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_MarksComplete_WhenExpectedBytesReached()
        {
            // Arrange - Create response with specific ContentLength
            var testData = MultipartDownloadTestHelpers.GenerateTestData(1000, 0);
            var response = CreateMockGetObjectResponse(1000, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act - Read exactly expected bytes
                byte[] buffer = new byte[1000];
                int bytesRead = await dataSource.ReadAsync(buffer, 0, 1000, CancellationToken.None);

                // Assert
                Assert.AreEqual(1000, bytesRead);
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Progress Tracking

        [TestMethod]
        public async Task ReadAsync_TracksProgressCorrectly()
        {
            // Arrange
            var testData = MultipartDownloadTestHelpers.GenerateTestData(1000, 0);
            var response = CreateMockGetObjectResponse(1000, testData);
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act & Assert - Track progress through multiple reads
                Assert.IsFalse(dataSource.IsComplete);

                byte[] buffer = new byte[300];
                await dataSource.ReadAsync(buffer, 0, 300, CancellationToken.None);
                Assert.IsFalse(dataSource.IsComplete); // 300/1000

                await dataSource.ReadAsync(buffer, 0, 300, CancellationToken.None);
                Assert.IsFalse(dataSource.IsComplete); // 600/1000

                await dataSource.ReadAsync(buffer, 0, 300, CancellationToken.None);
                Assert.IsFalse(dataSource.IsComplete); // 900/1000

                await dataSource.ReadAsync(buffer, 0, 100, CancellationToken.None);
                Assert.IsTrue(dataSource.IsComplete); // 1000/1000
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Error Handling

        [TestMethod]
        public async Task ReadAsync_OnStreamError_MarksComplete()
        {
            // Arrange - Create a response with a stream that throws
            var errorStream = new FaultyStream(new IOException("Stream read error"));
            var response = new GetObjectResponse
            {
                ContentLength = 512,
                ResponseStream = errorStream
            };
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act & Assert
                byte[] buffer = new byte[512];
                await Assert.ThrowsExceptionAsync<IOException>(async () =>
                {
                    await dataSource.ReadAsync(buffer, 0, 512, CancellationToken.None);
                });

                // Should mark as complete on error
                Assert.IsTrue(dataSource.IsComplete);
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_PropagatesStreamExceptions()
        {
            // Arrange
            var errorStream = new FaultyStream(new InvalidOperationException("Test error"));
            var response = new GetObjectResponse
            {
                ContentLength = 512,
                ResponseStream = errorStream
            };
            var dataSource = new StreamingDataSource(1, response);

            try
            {
                // Act & Assert
                byte[] buffer = new byte[512];
                await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
                {
                    await dataSource.ReadAsync(buffer, 0, 512, CancellationToken.None);
                });
            }
            finally
            {
                dataSource.Dispose();
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_ReleasesResponse()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);

            // Act
            dataSource.Dispose();

            // Assert - Response stream should be disposed
            // After disposal, stream is either null or no longer readable
            Assert.IsTrue(response.ResponseStream == null || !response.ResponseStream.CanRead);
        }

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);

            // Act - Dispose multiple times
            dataSource.Dispose();
            dataSource.Dispose();
            dataSource.Dispose();

            // Assert - Should not throw
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public async Task ReadAsync_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);
            dataSource.Dispose();

            // Act
            byte[] buffer = new byte[512];
            await dataSource.ReadAsync(buffer, 0, 512, CancellationToken.None);

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void PartNumber_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);
            dataSource.Dispose();

            // Act
            var partNumber = dataSource.PartNumber;

            // Assert - ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void IsComplete_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var response = CreateMockGetObjectResponse(512);
            var dataSource = new StreamingDataSource(1, response);
            dataSource.Dispose();

            // Act
            var isComplete = dataSource.IsComplete;

            // Assert - ExpectedException
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Creates a mock GetObjectResponse with test data.
        /// </summary>
        private GetObjectResponse CreateMockGetObjectResponse(long contentLength, byte[] testData = null)
        {
            if (testData == null)
            {
                testData = MultipartDownloadTestHelpers.GenerateTestData((int)contentLength, 0);
            }

            return new GetObjectResponse
            {
                ContentLength = contentLength,
                ResponseStream = new MemoryStream(testData),
                ETag = "test-etag"
            };
        }

        /// <summary>
        /// Stream that throws exceptions for testing error handling.
        /// </summary>
        private class FaultyStream : Stream
        {
            private readonly Exception _exception;

            public FaultyStream(Exception exception)
            {
                _exception = exception;
            }

            public override bool CanRead => true;
            public override bool CanSeek => false;
            public override bool CanWrite => false;
            public override long Length => throw new NotSupportedException();
            public override long Position
            {
                get => throw new NotSupportedException();
                set => throw new NotSupportedException();
            }

            public override void Flush() { }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw _exception;
            }

            public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
            {
                throw _exception;
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw new NotSupportedException();
            }

            public override void SetLength(long value)
            {
                throw new NotSupportedException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw new NotSupportedException();
            }
        }

        #endregion
    }
}
