using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Buffers;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for PartBufferManager class.
    /// Tests buffer management, sequential access, and cross-part boundary reading.
    /// </summary>
    [TestClass]
    public class PartBufferManagerTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidConfiguration_CreatesManager()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();

            // Act
            var manager = new PartBufferManager(config);

            // Assert
            Assert.IsNotNull(manager);
            Assert.AreEqual(1, manager.NextExpectedPartNumber);

            // Cleanup
            manager.Dispose();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullConfiguration_ThrowsArgumentNullException()
        {
            // Act
            var manager = new PartBufferManager(null);

            // Assert - ExpectedException
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void NextExpectedPartNumber_StartsAtOne()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Act & Assert
                Assert.AreEqual(1, manager.NextExpectedPartNumber);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task NextExpectedPartNumber_IncrementsAfterPartComplete()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add part 1
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                manager.AddBuffer(partBuffer);

                // Read part 1 completely
                byte[] readBuffer = new byte[512];
                await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Act & Assert - Should advance to part 2
                Assert.AreEqual(2, manager.NextExpectedPartNumber);
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region WaitForBufferSpaceAsync Tests

        [TestMethod]
        public async Task WaitForBufferSpaceAsync_InitialState_AllowsImmediateAccess()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: 5);
            var manager = new PartBufferManager(config);

            try
            {
                // Act - Should complete immediately
                var task = manager.WaitForBufferSpaceAsync(CancellationToken.None);
                
                // Assert
                Assert.IsTrue(task.IsCompleted);
                await task; // Should not throw
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task WaitForBufferSpaceAsync_WhenMaxPartsReached_Blocks()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: 2);
            var manager = new PartBufferManager(config);

            try
            {
                // Fill up to max parts
                for (int i = 1; i <= 2; i++)
                {
                    await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                    byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                    var partBuffer = new StreamPartBuffer(i, testBuffer, 512);
                    manager.AddBuffer(partBuffer);
                }

                // Act - Try to wait for space (should block)
                var waitTask = manager.WaitForBufferSpaceAsync(CancellationToken.None);

                // Give a small delay to ensure it would block
                await Task.Delay(50);

                // Assert - Should not have completed
                Assert.IsFalse(waitTask.IsCompleted);

                // Cleanup - release space to unblock
                manager.ReleaseBufferSpace();
                await waitTask;
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task WaitForBufferSpaceAsync_AfterRelease_AllowsAccess()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: 1);
            var manager = new PartBufferManager(config);

            try
            {
                // Take the one available slot
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                manager.AddBuffer(partBuffer);

                // Release space
                manager.ReleaseBufferSpace();

                // Act - Should be able to wait again
                var waitTask = manager.WaitForBufferSpaceAsync(CancellationToken.None);

                // Assert
                Assert.IsTrue(waitTask.IsCompleted);
                await waitTask;
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task WaitForBufferSpaceAsync_WithCancellation_ThrowsOperationCanceledException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: 1);
            var manager = new PartBufferManager(config);
            var cts = new CancellationTokenSource();

            try
            {
                // Take the one available slot
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);

                // Cancel immediately
                cts.Cancel();

                // Act & Assert
                // Use try-catch to accept both OperationCanceledException and TaskCanceledException
                // (TaskCanceledException derives from OperationCanceledException)
                try
                {
                    await manager.WaitForBufferSpaceAsync(cts.Token);
                    Assert.Fail("Expected OperationCanceledException was not thrown");
                }
                catch (OperationCanceledException ex)
                {
                    // Success - accepts both OperationCanceledException and derived types like TaskCanceledException
                    Assert.AreEqual(cts.Token, ex.CancellationToken, "CancellationToken should match the provided token");
                }
            }
            finally
            {
                manager.Dispose();
                cts.Dispose();
            }
        }

        #endregion

        #region AddBuffer Tests

        [TestMethod]
        public async Task AddBuffer_CreatesBufferedDataSource()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);

                // Act
                manager.AddBuffer(partBuffer);

                // Assert - Should be able to read from part 1
                byte[] readBuffer = new byte[512];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                Assert.AreEqual(512, bytesRead);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddBuffer_WithNullBuffer_ThrowsArgumentNullException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Act
                manager.AddBuffer(null);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task AddBuffer_SignalsPartAvailable()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Start reading before part is available
                var readTask = Task.Run(async () =>
                {
                    byte[] readBuffer = new byte[512];
                    return await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                });

                // Give read task time to start waiting
                await Task.Delay(50);

                // Add the part
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                manager.AddBuffer(partBuffer);

                // Assert - Read should complete
                int bytesRead = await readTask;
                Assert.AreEqual(512, bytesRead);
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region AddDataSource Tests

        [TestMethod]
        public async Task AddDataSource_AddsToCollection()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                var dataSource = new BufferedDataSource(partBuffer);

                // Act
                manager.AddDataSource(dataSource);

                // Assert - Should be able to read from part 1
                byte[] readBuffer = new byte[512];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                Assert.AreEqual(512, bytesRead);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddDataSource_WithNullDataSource_ThrowsArgumentNullException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Act
                manager.AddDataSource(null);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddDataSource_WithDuplicatePartNumber_ThrowsInvalidOperationException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add part 1
                byte[] testBuffer1 = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer1 = new StreamPartBuffer(1, testBuffer1, 512);
                var dataSource1 = new BufferedDataSource(partBuffer1);
                manager.AddDataSource(dataSource1);

                // Try to add duplicate part 1
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer2 = new StreamPartBuffer(1, testBuffer2, 512);
                var dataSource2 = new BufferedDataSource(partBuffer2);

                // Act
                manager.AddDataSource(dataSource2);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Sequential Access

        [TestMethod]
        public async Task ReadAsync_ReadsDataSequentially()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                byte[] testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                Buffer.BlockCopy(testData, 0, testBuffer, 0, 512);
                
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                manager.AddBuffer(partBuffer);

                // Act
                byte[] readBuffer = new byte[512];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(512, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, readBuffer, 0, 512));
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_AdvancesNextExpectedPartNumber()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add part 1
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                manager.AddBuffer(partBuffer);

                // Read part 1 completely
                byte[] readBuffer = new byte[512];
                await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(2, manager.NextExpectedPartNumber);
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Parameter Validation

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task ReadAsync_WithNullBuffer_ThrowsArgumentNullException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Act
                await manager.ReadAsync(null, 0, 512, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeOffset_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            byte[] readBuffer = new byte[512];

            try
            {
                // Act
                await manager.ReadAsync(readBuffer, -1, 512, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async Task ReadAsync_WithNegativeCount_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            byte[] readBuffer = new byte[512];

            try
            {
                // Act
                await manager.ReadAsync(readBuffer, 0, -1, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task ReadAsync_WithOffsetCountExceedingBounds_ThrowsArgumentException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            byte[] readBuffer = new byte[512];

            try
            {
                // Act
                await manager.ReadAsync(readBuffer, 400, 200, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Waiting

        [TestMethod]
        public async Task ReadAsync_WaitsForPartAvailability()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Start reading before part is available
                var readTask = Task.Run(async () =>
                {
                    byte[] readBuffer = new byte[512];
                    return await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                });

                // Give read task time to start waiting
                await Task.Delay(100);
                Assert.IsFalse(readTask.IsCompleted);

                // Add the part asynchronously
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                manager.AddBuffer(partBuffer);

                // Assert - Read should complete
                int bytesRead = await readTask;
                Assert.AreEqual(512, bytesRead);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_WhenDownloadComplete_ReturnsZero()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Mark download as complete
                manager.MarkDownloadComplete(null);

                // Act
                byte[] readBuffer = new byte[512];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Assert
                Assert.AreEqual(0, bytesRead);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ReadAsync_WhenDownloadFailed_ThrowsException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Mark download as failed
                var testException = new Exception("Download failed");
                manager.MarkDownloadComplete(testException);

                // Act
                byte[] readBuffer = new byte[512];
                await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region ReadAsync Tests - Cross-Part Boundary Reading

        [TestMethod]
        public async Task ReadAsync_ReadingAcrossPartBoundary_FillsBuffer()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add Part 1 (100 bytes)
                byte[] testData1 = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
                byte[] testBuffer1 = ArrayPool<byte>.Shared.Rent(100);
                Buffer.BlockCopy(testData1, 0, testBuffer1, 0, 100);
                var partBuffer1 = new StreamPartBuffer(1, testBuffer1, 100);
                manager.AddBuffer(partBuffer1);

                // Add Part 2 (100 bytes) 
                byte[] testData2 = MultipartDownloadTestHelpers.GenerateTestData(100, 100);
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(100);
                Buffer.BlockCopy(testData2, 0, testBuffer2, 0, 100);
                var partBuffer2 = new StreamPartBuffer(2, testBuffer2, 100);
                manager.AddBuffer(partBuffer2);

                // Act - Request 150 bytes (spans both parts)
                byte[] readBuffer = new byte[150];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 150, CancellationToken.None);

                // Assert
                Assert.AreEqual(150, bytesRead);
                
                // Verify first 100 bytes from part 1
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData1, readBuffer, 0, 100));
                
                // Verify next 50 bytes from part 2
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData2, readBuffer, 100, 50));
                
                // Should still be on part 2 (not complete yet, 50 bytes remaining)
                Assert.AreEqual(2, manager.NextExpectedPartNumber);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_MultiplePartsInSingleRead_AdvancesCorrectly()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add 3 small parts (50 bytes each)
                for (int i = 1; i <= 3; i++)
                {
                    byte[] testData = MultipartDownloadTestHelpers.GeneratePartSpecificData(50, i);
                    byte[] testBuffer = ArrayPool<byte>.Shared.Rent(50);
                    Buffer.BlockCopy(testData, 0, testBuffer, 0, 50);
                    var partBuffer = new StreamPartBuffer(i, testBuffer, 50);
                    manager.AddBuffer(partBuffer);
                }

                // Act - Read 150 bytes (all 3 parts)
                byte[] readBuffer = new byte[150];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 150, CancellationToken.None);

                // Assert
                Assert.AreEqual(150, bytesRead);
                Assert.AreEqual(4, manager.NextExpectedPartNumber); // Advanced to part 4
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_PartCompletes_AdvancesToNextPart()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add part 1
                byte[] testBuffer1 = ArrayPool<byte>.Shared.Rent(100);
                var partBuffer1 = new StreamPartBuffer(1, testBuffer1, 100);
                manager.AddBuffer(partBuffer1);

                // Read part 1 completely
                byte[] readBuffer = new byte[100];
                await manager.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert - Should advance to part 2
                Assert.AreEqual(2, manager.NextExpectedPartNumber);

                // Add part 2
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(100);
                var partBuffer2 = new StreamPartBuffer(2, testBuffer2, 100);
                manager.AddBuffer(partBuffer2);

                // Read part 2
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert
                Assert.AreEqual(100, bytesRead);
                Assert.AreEqual(3, manager.NextExpectedPartNumber);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_EmptyPart_ContinuesToNextPart()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add empty part 1
                byte[] testBuffer1 = ArrayPool<byte>.Shared.Rent(100);
                var partBuffer1 = new StreamPartBuffer(1, testBuffer1, 0); // 0 bytes
                manager.AddBuffer(partBuffer1);

                // Add part 2 with data
                byte[] testData2 = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(100);
                Buffer.BlockCopy(testData2, 0, testBuffer2, 0, 100);
                var partBuffer2 = new StreamPartBuffer(2, testBuffer2, 100);
                manager.AddBuffer(partBuffer2);

                // Act - Try to read 100 bytes starting from part 1
                byte[] readBuffer = new byte[100];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert - Should skip empty part 1 and read from part 2
                Assert.AreEqual(100, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData2, readBuffer, 0, 100));
                Assert.AreEqual(3, manager.NextExpectedPartNumber); // Advanced past both parts
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region ReleaseBufferSpace Tests

        [TestMethod]
        public void ReleaseBufferSpace_IncreasesAvailableSlots()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: 1);
            var manager = new PartBufferManager(config);

            try
            {
                // Take the slot
                var task1 = manager.WaitForBufferSpaceAsync(CancellationToken.None);
                Assert.IsTrue(task1.IsCompleted);

                // Try to take another (should block)
                var task2 = manager.WaitForBufferSpaceAsync(CancellationToken.None);
                Assert.IsFalse(task2.IsCompleted); // Would block

                // Act - Release space
                manager.ReleaseBufferSpace();

                // Wait briefly for the release to take effect
                Task.Delay(50).Wait();

                // Assert - Second wait should now complete
                Assert.IsTrue(task2.IsCompleted || task2.Wait(100));
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public void ReleaseBufferSpace_AfterDispose_ThrowsObjectDisposedException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            manager.Dispose();

            // Act
            manager.ReleaseBufferSpace();

            // Assert - ExpectedException
        }

        #endregion

        #region MarkDownloadComplete Tests

        [TestMethod]
        public async Task MarkDownloadComplete_WithNullException_SignalsSuccess()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Act
                manager.MarkDownloadComplete(null);

                // Assert - Reading should return 0 (EOF)
                byte[] readBuffer = new byte[512];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                Assert.AreEqual(0, bytesRead);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task MarkDownloadComplete_WithException_StoresException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            var testException = new Exception("Test exception");

            try
            {
                // Act
                manager.MarkDownloadComplete(testException);

                // Assert - Reading should throw
                byte[] readBuffer = new byte[512];
                var ex = await Assert.ThrowsExceptionAsync<InvalidOperationException>(async () =>
                {
                    await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                });

                Assert.IsNotNull(ex.InnerException);
                Assert.AreEqual(testException, ex.InnerException);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task MarkDownloadComplete_SignalsWaitingReads()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Start reading before download is complete
                var readTask = Task.Run(async () =>
                {
                    byte[] readBuffer = new byte[512];
                    return await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                });

                // Give read task time to start waiting
                await Task.Delay(100);
                Assert.IsFalse(readTask.IsCompleted);

                // Mark download complete
                manager.MarkDownloadComplete(null);

                // Assert - Read should complete with 0 bytes
                int bytesRead = await readTask;
                Assert.AreEqual(0, bytesRead);
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion

        #region Disposal Tests

        [TestMethod]
        public void Dispose_DisposesAllDataSources()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            manager.AddBuffer(partBuffer);

            // Act
            manager.Dispose();

            // Assert - The underlying part buffer should be disposed
            Assert.IsNull(partBuffer.ArrayPoolBuffer);
        }

        [TestMethod]
        public void Dispose_ClearsCollection()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            
            byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
            var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
            manager.AddBuffer(partBuffer);

            // Act
            manager.Dispose();

            // Assert - Should not throw (collection cleared)
            // Further operations should throw ObjectDisposedException
        }

        [TestMethod]
        public void Dispose_MultipleCalls_IsIdempotent()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            // Act - Dispose multiple times
            manager.Dispose();
            manager.Dispose();
            manager.Dispose();

            // Assert - Should not throw
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDisposedException))]
        public async Task Operations_AfterDispose_ThrowObjectDisposedException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);
            manager.Dispose();

            // Act
            await manager.WaitForBufferSpaceAsync(CancellationToken.None);

            // Assert - ExpectedException
        }

        #endregion
    }
}
