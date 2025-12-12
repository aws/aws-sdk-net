using Amazon.S3.Transfer.Internal;
using Amazon.S3.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using System.Collections.Generic;
using System.Buffers;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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

                await manager.WaitForBufferSpaceAsync(CancellationToken.None);

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
                manager.AddBuffer((IPartDataSource)null);

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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(partBuffer1);

                // Add Part 2 (100 bytes) 
                byte[] testData2 = MultipartDownloadTestHelpers.GenerateTestData(100, 100);
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(100);
                Buffer.BlockCopy(testData2, 0, testBuffer2, 0, 100);
                var partBuffer2 = new StreamPartBuffer(2, testBuffer2, 100);
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                    await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(partBuffer1);

                // Read part 1 completely
                byte[] readBuffer = new byte[100];
                await manager.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                // Assert - Should advance to part 2
                Assert.AreEqual(2, manager.NextExpectedPartNumber);

                // Add part 2
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(100);
                var partBuffer2 = new StreamPartBuffer(2, testBuffer2, 100);
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(partBuffer1);

                // Add part 2 with data
                byte[] testData2 = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(100);
                Buffer.BlockCopy(testData2, 0, testBuffer2, 0, 100);
                var partBuffer2 = new StreamPartBuffer(2, testBuffer2, 100);
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
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

        #region AddBufferAsync(IPartDataSource) Tests

        [TestMethod]
        public async Task AddBufferAsync_IPartDataSource_WithStreamingDataSource_AddsSuccessfully()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Create a StreamingDataSource
                var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
                var response = new GetObjectResponse
                {
                    ContentLength = 512,
                    ResponseStream = new MemoryStream(testData)
                };
                var streamingSource = new StreamingDataSource(1, response);

                // Act
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(streamingSource);

                // Assert - Should be able to read from part 1
                byte[] readBuffer = new byte[512];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                Assert.AreEqual(512, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, readBuffer, 0, 512));
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task AddBufferAsync_IPartDataSource_WithBufferedDataSource_AddsSuccessfully()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Create a BufferedDataSource
                byte[] testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
                byte[] testBuffer = ArrayPool<byte>.Shared.Rent(512);
                Buffer.BlockCopy(testData, 0, testBuffer, 0, 512);
                var partBuffer = new StreamPartBuffer(1, testBuffer, 512);
                var bufferedSource = new BufferedDataSource(partBuffer);

                // Act
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(bufferedSource);

                // Assert - Should be able to read from part 1
                byte[] readBuffer = new byte[512];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);
                Assert.AreEqual(512, bytesRead);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData, readBuffer, 0, 512));
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddBufferAsync_IPartDataSource_WithNull_ThrowsArgumentNullException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Act
                manager.AddBuffer((IPartDataSource)null);

                // Assert - ExpectedException
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task AddBufferAsync_IPartDataSource_SignalsPartAvailable()
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

                // Create and add streaming data source
                var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
                var response = new GetObjectResponse
                {
                    ContentLength = 512,
                    ResponseStream = new MemoryStream(testData)
                };
                var streamingSource = new StreamingDataSource(1, response);

                // Act
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(streamingSource);

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

        #region ReadAsync Tests - StreamingDataSource Integration

        [TestMethod]
        public async Task ReadAsync_FromStreamingDataSource_ReadsCorrectly()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Create streaming data source
                var testData = MultipartDownloadTestHelpers.GenerateTestData(1000, 0);
                var response = new GetObjectResponse
                {
                    ContentLength = 1000,
                    ResponseStream = new MemoryStream(testData)
                };
                var streamingSource = new StreamingDataSource(1, response);
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(streamingSource);

                // Act - Read in multiple chunks
                byte[] readBuffer = new byte[400];
                int bytesRead1 = await manager.ReadAsync(readBuffer, 0, 400, CancellationToken.None);
                
                int bytesRead2 = await manager.ReadAsync(readBuffer, 0, 400, CancellationToken.None);
                
                int bytesRead3 = await manager.ReadAsync(readBuffer, 0, 200, CancellationToken.None);

                // Assert
                Assert.AreEqual(400, bytesRead1);
                Assert.AreEqual(400, bytesRead2);
                Assert.AreEqual(200, bytesRead3);
                Assert.AreEqual(2, manager.NextExpectedPartNumber);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_FromMixedSources_ReadsSequentially()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add streaming source for part 1
                var testData1 = MultipartDownloadTestHelpers.GenerateTestData(500, 0);
                var response1 = new GetObjectResponse
                {
                    ContentLength = 500,
                    ResponseStream = new MemoryStream(testData1)
                };
                var streamingSource = new StreamingDataSource(1, response1);
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer((IPartDataSource)streamingSource);

                // Add buffered source for part 2
                var testData2 = MultipartDownloadTestHelpers.GenerateTestData(500, 500);
                byte[] testBuffer2 = ArrayPool<byte>.Shared.Rent(500);
                Buffer.BlockCopy(testData2, 0, testBuffer2, 0, 500);
                var partBuffer2 = new StreamPartBuffer(2, testBuffer2, 500);
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(partBuffer2);

                // Act - Read across both parts
                byte[] readBuffer = new byte[750];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 750, CancellationToken.None);

                // Assert
                Assert.AreEqual(750, bytesRead);
                
                // Verify first 500 bytes from streaming source
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(testData1, readBuffer, 0, 500));
                
                // Verify next 250 bytes from buffered source
                byte[] expectedData2 = new byte[250];
                Array.Copy(testData2, 0, expectedData2, 0, 250);
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyDataMatch(expectedData2, readBuffer, 500, 250));
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_StreamingDataSource_DisposesAfterCompletion()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Create streaming data source
                var testData = MultipartDownloadTestHelpers.GenerateTestData(512, 0);
                var response = new GetObjectResponse
                {
                    ContentLength = 512,
                    ResponseStream = new MemoryStream(testData)
                };
                var streamingSource = new StreamingDataSource(1, response);
                await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                manager.AddBuffer(streamingSource);

                // Act - Read all data
                byte[] readBuffer = new byte[512];
                await manager.ReadAsync(readBuffer, 0, 512, CancellationToken.None);

                // Assert - StreamingDataSource should be disposed after reading
                // This is verified internally by PartBufferManager
                Assert.AreEqual(2, manager.NextExpectedPartNumber);
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReadAsync_MultipleStreamingSources_ReadsSequentially()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            try
            {
                // Add 3 streaming sources
                for (int i = 1; i <= 3; i++)
                {
                    var testData = MultipartDownloadTestHelpers.GeneratePartSpecificData(300, i);
                    var response = new GetObjectResponse
                    {
                        ContentLength = 300,
                        ResponseStream = new MemoryStream(testData)
                    };
                    var streamingSource = new StreamingDataSource(i, response);
                    await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                    manager.AddBuffer(streamingSource);
                }

                // Act - Read across all parts
                byte[] readBuffer = new byte[900];
                int bytesRead = await manager.ReadAsync(readBuffer, 0, 900, CancellationToken.None);

                // Assert
                Assert.AreEqual(900, bytesRead);
                Assert.AreEqual(4, manager.NextExpectedPartNumber);
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

        #region Thread Safety Tests - Memory Visibility

        [TestMethod]
        public async Task NextExpectedPartNumber_ConcurrentReads_SeeConsistentValue()
        {
            // This test verifies that the volatile keyword on _nextExpectedPartNumber
            // prevents memory visibility issues when multiple producer threads
            // read the value while the consumer thread updates it.
            //
            // Without volatile, producer threads may see stale cached values,
            // causing incorrect stream-vs-buffer decisions.
            //
            // The test simulates BufferedPartDataHandler.ProcessPartAsync's pattern:
            // Multiple download threads checking "partNumber == NextExpectedPartNumber"
            // while the consumer thread increments NextExpectedPartNumber.

            // Arrange
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration();
            var manager = new PartBufferManager(config);

            const int NumReaderThreads = 8;
            const int NumIncrements = 100;
            
            var readErrors = new System.Collections.Concurrent.ConcurrentBag<string>();
            var startSignal = new ManualResetEventSlim(false);
            var stopSignal = new ManualResetEventSlim(false);

            try
            {
                // Start multiple reader threads that continuously read NextExpectedPartNumber
                var readerTasks = new Task[NumReaderThreads];
                for (int i = 0; i < NumReaderThreads; i++)
                {
                    int threadId = i;
                    readerTasks[i] = Task.Run(() =>
                    {
                        // Wait for start signal
                        startSignal.Wait();

                        int lastSeenValue = 0;
                        
                        // Aggressively read the value until stopped
                        while (!stopSignal.IsSet)
                        {
                            int currentValue = manager.NextExpectedPartNumber;
                            
                            // Verify we never see a value less than what we saw before
                            // (This would indicate stale cached reads)
                            if (currentValue < lastSeenValue)
                            {
                                readErrors.Add($"Thread {threadId} saw value go backwards: {lastSeenValue} -> {currentValue}");
                            }
                            
                            lastSeenValue = currentValue;
                            
                            // Spin to create cache pressure
                            Thread.SpinWait(10);
                        }
                    });
                }

                // Start all reader threads simultaneously
                startSignal.Set();

                // Give threads time to start reading
                await Task.Delay(10);

                // Simulate consumer thread incrementing NextExpectedPartNumber
                // by adding and reading parts sequentially
                for (int partNum = 1; partNum <= NumIncrements; partNum++)
                {
                    // Wait for buffer space before adding part
                    await manager.WaitForBufferSpaceAsync(CancellationToken.None);

                    // Add part
                    byte[] testBuffer = ArrayPool<byte>.Shared.Rent(100);
                    var partBuffer = new StreamPartBuffer(partNum, testBuffer, 100);
                    manager.AddBuffer(partBuffer);

                    // Read part completely to trigger increment
                    byte[] readBuffer = new byte[100];
                    await manager.ReadAsync(readBuffer, 0, 100, CancellationToken.None);

                    // NextExpectedPartNumber should now be partNum + 1
                    
                    // Small spin to create timing variance
                    Thread.SpinWait(5);
                }

                // Stop reader threads
                stopSignal.Set();

                // Wait for all readers to finish
                await Task.WhenAll(readerTasks);

                // Assert - No reader should have seen inconsistent values
                if (readErrors.Count > 0)
                {
                    var errorMessage = $"Memory visibility issues detected:\n{string.Join("\n", readErrors.Take(10))}";
                    if (readErrors.Count > 10)
                    {
                        errorMessage += $"\n... and {readErrors.Count - 10} more errors";
                    }
                    Assert.Fail(errorMessage);
                }

                // Verify final value is correct
                Assert.AreEqual(NumIncrements + 1, manager.NextExpectedPartNumber);
            }
            finally
            {
                stopSignal.Set(); // Ensure threads stop even on failure
                manager.Dispose();
                startSignal.Dispose();
                stopSignal.Dispose();
            }
        }

        #endregion

        #region Semaphore MaxCount Tests

        [TestMethod]
        public async Task WaitForBufferSpaceAsync_WithMaxCount_DoesNotExceedConfiguredLimit()
        {
            // This test verifies the fix for the double release bug.
            // Before the fix: SemaphoreSlim without maxCount allowed unlimited Release() calls,
            // which could corrupt the semaphore state and allow more concurrent operations than configured.
            // After the fix: maxCount parameter prevents exceeding MaxInMemoryParts limit.

            // Arrange
            const int maxInMemoryParts = 3;
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: maxInMemoryParts);
            var manager = new PartBufferManager(config);

            try
            {
                // Acquire all available slots
                for (int i = 0; i < maxInMemoryParts; i++)
                {
                    await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                }

                // Release all acquired slots
                for (int i = 0; i < maxInMemoryParts; i++)
                {
                    manager.ReleaseBufferSpace();
                }

                // Attempt to release beyond maxCount (should throw)
                Assert.ThrowsException<SemaphoreFullException>(() =>
                {
                    manager.ReleaseBufferSpace();
                }, "Releasing beyond maxCount should throw SemaphoreFullException");

                // Attempt one more release to confirm protection is consistent
                Assert.ThrowsException<SemaphoreFullException>(() =>
                {
                    manager.ReleaseBufferSpace();
                }, "Second excessive release should also throw SemaphoreFullException");

                // Act - Try to acquire slots again
                var acquiredSlots = 0;
                for (int i = 0; i < maxInMemoryParts + 2; i++)
                {
                    var waitTask = manager.WaitForBufferSpaceAsync(CancellationToken.None);
                    if (await Task.WhenAny(waitTask, Task.Delay(100)) == waitTask)
                    {
                        acquiredSlots++;
                    }
                    else
                    {
                        break; // Task didn't complete, no more slots available
                    }
                }

                // Assert - Should only be able to acquire maxInMemoryParts slots, not more
                // With maxCount fix: Can only acquire 3 slots (respects limit)
                // Without maxCount fix: Could acquire 5 slots (2 extra from double releases)
                Assert.AreEqual(maxInMemoryParts, acquiredSlots,
                    $"Semaphore should respect maxCount={maxInMemoryParts} limit despite excessive releases");
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task ReleaseBufferSpace_ExcessiveReleases_MaintainsSemaphoreIntegrity()
        {
            // This test verifies that excessive Release() calls don't corrupt semaphore state.
            // The maxCount parameter ensures CurrentCount never exceeds MaxInMemoryParts.

            // Arrange
            const int maxInMemoryParts = 5;
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: maxInMemoryParts);
            var manager = new PartBufferManager(config);

            try
            {
                // Acquire half the slots
                for (int i = 0; i < maxInMemoryParts / 2; i++)
                {
                    await manager.WaitForBufferSpaceAsync(CancellationToken.None);
                }

                // Release the acquired slots
                for (int i = 0; i < maxInMemoryParts / 2; i++)
                {
                    manager.ReleaseBufferSpace();
                }

                // Now semaphore should be at full capacity (maxInMemoryParts)
                // Attempt to release beyond maxCount - each should throw
                var excessiveReleaseCount = 0;
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        manager.ReleaseBufferSpace();
                        Assert.Fail($"Release #{i + 1} beyond maxCount should have thrown SemaphoreFullException");
                    }
                    catch (SemaphoreFullException)
                    {
                        excessiveReleaseCount++;
                    }
                }

                // Assert - All excessive releases should have thrown
                Assert.AreEqual(5, excessiveReleaseCount, "All excessive releases should throw SemaphoreFullException");

                // Act - Count how many slots are now available
                var availableSlots = 0;
                for (int i = 0; i < maxInMemoryParts * 2; i++)
                {
                    var waitTask = manager.WaitForBufferSpaceAsync(CancellationToken.None);
                    if (waitTask.IsCompleted)
                    {
                        availableSlots++;
                        await waitTask;
                    }
                    else
                    {
                        break;
                    }
                }

                // Assert - Should never exceed maxInMemoryParts
                Assert.IsTrue(availableSlots <= maxInMemoryParts,
                    $"Available slots ({availableSlots}) should not exceed maxInMemoryParts ({maxInMemoryParts})");
            }
            finally
            {
                manager.Dispose();
            }
        }

        [TestMethod]
        public async Task BufferCapacity_ConcurrentOperations_RespectsMaxCountLimit()
        {
            // This test simulates the real-world scenario where multiple parts are being
            // processed concurrently, verifying that the maxCount parameter prevents
            // exceeding the configured buffer capacity limit.

            // Arrange
            const int maxInMemoryParts = 4;
            const int totalParts = 10;
            var config = MultipartDownloadTestHelpers.CreateBufferedDownloadConfiguration(maxInMemoryParts: maxInMemoryParts);
            var manager = new PartBufferManager(config);

            try
            {
                var activeParts = 0;
                var maxActiveParts = 0;
                var lockObj = new object();

                // Simulate concurrent part processing
                var tasks = new List<Task>();
                for (int partNum = 1; partNum <= totalParts; partNum++)
                {
                    int capturedPartNum = partNum;
                    tasks.Add(Task.Run(async () =>
                    {
                        // Wait for buffer space (enforces maxInMemoryParts limit)
                        await manager.WaitForBufferSpaceAsync(CancellationToken.None);

                        lock (lockObj)
                        {
                            activeParts++;
                            if (activeParts > maxActiveParts)
                            {
                                maxActiveParts = activeParts;
                            }
                        }

                        // Simulate buffering the part
                        byte[] testBuffer = ArrayPool<byte>.Shared.Rent(100);
                        var partBuffer = new StreamPartBuffer(capturedPartNum, testBuffer, 100);
                        manager.AddBuffer(partBuffer);

                        // Simulate some processing time
                        await Task.Delay(10);

                        // Consumer reads the part (happens asynchronously in real scenario)
                        // For this test, we'll manually release after a delay
                        await Task.Delay(20);
                        
                        lock (lockObj)
                        {
                            activeParts--;
                        }

                        // Release is normally done by consumer after reading part
                        manager.ReleaseBufferSpace();
                    }));
                }

                // Wait for all parts to be processed
                await Task.WhenAll(tasks);

                // Assert - Should never have exceeded maxInMemoryParts
                Assert.IsTrue(maxActiveParts <= maxInMemoryParts,
                    $"Maximum concurrent buffered parts ({maxActiveParts}) exceeded configured limit ({maxInMemoryParts})");
            }
            finally
            {
                manager.Dispose();
            }
        }

        #endregion
    }
}
