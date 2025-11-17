using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class FilePartDataHandlerTests
    {
        private string _testDirectory;

        [TestInitialize]
        public void Setup()
        {
            _testDirectory = MultipartDownloadTestHelpers.CreateTempDirectory();
        }

        [TestCleanup]
        public void Cleanup()
        {
            MultipartDownloadTestHelpers.CleanupTempDirectory(_testDirectory);
        }

        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidConfig_CreatesHandler()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));

            // Act
            var handler = new FilePartDataHandler(config);

            // Assert
            Assert.IsNotNull(handler);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullConfig_ThrowsArgumentNullException()
        {
            // Act
            var handler = new FilePartDataHandler(null);
        }

        #endregion

        #region PrepareAsync Tests

        [TestMethod]
        public async Task PrepareAsync_CreatesTempFile()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            var discoveryResult = new DownloadDiscoveryResult
            {
                TotalParts = 1,
                ObjectSize = 1024
            };

            // Act
            await handler.PrepareAsync(discoveryResult, CancellationToken.None);

            // Assert - Check temp file exists with .s3tmp. pattern
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            Assert.AreEqual(1, tempFiles.Length);
            Assert.IsTrue(File.Exists(tempFiles[0]));
        }

        [TestMethod]
        public async Task PrepareAsync_TempFileFollowsPattern()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "myfile.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            var discoveryResult = new DownloadDiscoveryResult();

            // Act
            await handler.PrepareAsync(discoveryResult, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "myfile.dat.s3tmp.*");
            Assert.AreEqual(1, tempFiles.Length);
        }

        [TestMethod]
        public async Task PrepareAsync_ReturnsCompletedTask()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);
            var discoveryResult = new DownloadDiscoveryResult();

            // Act
            var task = handler.PrepareAsync(discoveryResult, CancellationToken.None);

            // Assert
            Assert.IsTrue(task.IsCompleted);
            await task;
        }

        #endregion

        #region ProcessPartAsync Tests - Basic Functionality

        [TestMethod]
        public async Task ProcessPartAsync_WritesDataToFile()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-1023/1024"
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            Assert.AreEqual(1, tempFiles.Length);
            
            var writtenData = File.ReadAllBytes(tempFiles[0]);
            CollectionAssert.AreEqual(partData, writtenData);
        }

        [TestMethod]
        public async Task ProcessPartAsync_WritesAtCorrectOffset()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Write part 2 (offset 1024)
            var part2Data = MultipartDownloadTestHelpers.GenerateTestData(1024, 1024);
            var response = new GetObjectResponse
            {
                ContentLength = part2Data.Length,
                ResponseStream = new MemoryStream(part2Data),
                ContentRange = "bytes 1024-2047/2048"
            };

            // Act
            await handler.ProcessPartAsync(2, response, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            var fileData = File.ReadAllBytes(tempFiles[0]);
            
            // Verify data is at offset 1024
            var actualPart2Data = fileData.Skip(1024).Take(1024).ToArray();
            CollectionAssert.AreEqual(part2Data, actualPart2Data);
        }

        #endregion

        #region ProcessPartAsync Tests - Offset Calculation

        [TestMethod]
        public async Task ProcessPartAsync_ParsesContentRangeForOffset()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 8388608-8388707/33555032" // Offset 8MB
            };

            // Act
            await handler.ProcessPartAsync(2, response, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            var fileData = File.ReadAllBytes(tempFiles[0]);
            
            // Verify data is at offset 8388608
            var actualData = fileData.Skip(8388608).Take(100).ToArray();
            CollectionAssert.AreEqual(partData, actualData);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ProcessPartAsync_MissingContentRange_ThrowsInvalidOperationException()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1000,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = null // Missing ContentRange should throw
            };

            // Act - Should throw InvalidOperationException
            await handler.ProcessPartAsync(3, response, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ProcessPartAsync_InvalidContentRange_ThrowsInvalidOperationException()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1000,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "invalid-format" // Invalid ContentRange should throw
            };

            // Act - Should throw InvalidOperationException
            await handler.ProcessPartAsync(2, response, CancellationToken.None);
        }

        #endregion

        #region ProcessPartAsync Tests - Data Integrity

        [TestMethod]
        public async Task ProcessPartAsync_PreservesDataIntegrity()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.CreateMixedPattern(10240, 42);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-10239/10240"
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            var writtenData = File.ReadAllBytes(tempFiles[0]);
            CollectionAssert.AreEqual(partData, writtenData);
        }

        [TestMethod]
        public async Task ProcessPartAsync_HandlesZeroByteResponse()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var response = new GetObjectResponse
            {
                ContentLength = 0,
                ResponseStream = new MemoryStream(Array.Empty<byte>()),
                ContentRange = "bytes 0-0/0"
            };

            // Act & Assert - Should not throw
            await handler.ProcessPartAsync(1, response, CancellationToken.None);
        }

        [TestMethod]
        public async Task ProcessPartAsync_HandlesSmallPart()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(100, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-99/100"
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            var writtenData = File.ReadAllBytes(tempFiles[0]);
            CollectionAssert.AreEqual(partData, writtenData);
        }

        [TestMethod]
        public async Task ProcessPartAsync_HandlesLargePart()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partSize = 16 * 1024 * 1024; // 16MB
            var partData = MultipartDownloadTestHelpers.GenerateTestData(partSize, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = $"bytes 0-{partSize - 1}/{partSize}"
            };

            // Act
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(tempFiles[0], partSize));
        }

        [TestMethod]
        public async Task ProcessPartAsync_MultipleWritesPreserveAllData()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Write part 1
            var part1Data = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var response1 = new GetObjectResponse
            {
                ContentLength = part1Data.Length,
                ResponseStream = new MemoryStream(part1Data),
                ContentRange = "bytes 0-1023/2048"
            };
            await handler.ProcessPartAsync(1, response1, CancellationToken.None);

            // Write part 2
            var part2Data = MultipartDownloadTestHelpers.GenerateTestData(1024, 1024);
            var response2 = new GetObjectResponse
            {
                ContentLength = part2Data.Length,
                ResponseStream = new MemoryStream(part2Data),
                ContentRange = "bytes 1024-2047/2048"
            };
            await handler.ProcessPartAsync(2, response2, CancellationToken.None);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            var fileData = File.ReadAllBytes(tempFiles[0]);
            
            var actualPart1 = fileData.Take(1024).ToArray();
            var actualPart2 = fileData.Skip(1024).Take(1024).ToArray();
            
            CollectionAssert.AreEqual(part1Data, actualPart1);
            CollectionAssert.AreEqual(part2Data, actualPart2);
        }

        #endregion

        #region ProcessPartAsync Tests - Concurrent Writes

        [TestMethod]
        public async Task ProcessPartAsync_SupportsConcurrentWrites()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Create multiple parts
            var part1Data = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var part2Data = MultipartDownloadTestHelpers.GenerateTestData(1024, 1024);
            var part3Data = MultipartDownloadTestHelpers.GenerateTestData(1024, 2048);

            var response1 = new GetObjectResponse
            {
                ContentLength = part1Data.Length,
                ResponseStream = new MemoryStream(part1Data),
                ContentRange = "bytes 0-1023/3072"
            };
            var response2 = new GetObjectResponse
            {
                ContentLength = part2Data.Length,
                ResponseStream = new MemoryStream(part2Data),
                ContentRange = "bytes 1024-2047/3072"
            };
            var response3 = new GetObjectResponse
            {
                ContentLength = part3Data.Length,
                ResponseStream = new MemoryStream(part3Data),
                ContentRange = "bytes 2048-3071/3072"
            };

            // Act - Write all parts concurrently
            var tasks = new[]
            {
                handler.ProcessPartAsync(1, response1, CancellationToken.None),
                handler.ProcessPartAsync(2, response2, CancellationToken.None),
                handler.ProcessPartAsync(3, response3, CancellationToken.None)
            };
            await Task.WhenAll(tasks);

            // Assert
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            var fileData = File.ReadAllBytes(tempFiles[0]);
            
            var actualPart1 = fileData.Take(1024).ToArray();
            var actualPart2 = fileData.Skip(1024).Take(1024).ToArray();
            var actualPart3 = fileData.Skip(2048).Take(1024).ToArray();
            
            CollectionAssert.AreEqual(part1Data, actualPart1);
            CollectionAssert.AreEqual(part2Data, actualPart2);
            CollectionAssert.AreEqual(part3Data, actualPart3);
        }

        [TestMethod]
        public async Task ProcessPartAsync_ConcurrentWritesDontInterfere()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Create 10 parts with distinct patterns
            var tasks = new Task[10];
            for (int i = 0; i < 10; i++)
            {
                var partNum = i + 1;
                var offset = i * 1024;
                var partData = MultipartDownloadTestHelpers.GeneratePartSpecificData(1024, partNum);
                
                var response = new GetObjectResponse
                {
                    ContentLength = partData.Length,
                    ResponseStream = new MemoryStream(partData),
                    ContentRange = $"bytes {offset}-{offset + 1023}/10240"
                };
                
                tasks[i] = handler.ProcessPartAsync(partNum, response, CancellationToken.None);
            }

            // Act
            await Task.WhenAll(tasks);

            // Assert - Each part should have its distinct pattern
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            var fileData = File.ReadAllBytes(tempFiles[0]);
            
            for (int i = 0; i < 10; i++)
            {
                var expectedData = MultipartDownloadTestHelpers.GeneratePartSpecificData(1024, i + 1);
                var actualData = fileData.Skip(i * 1024).Take(1024).ToArray();
                CollectionAssert.AreEqual(expectedData, actualData, $"Part {i + 1} data mismatch");
            }
        }

        #endregion

        #region ProcessPartAsync Tests - Error Handling

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ProcessPartAsync_WithoutPrepare_ThrowsInvalidOperationException()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-1023/1024"
            };

            // Act - Without calling PrepareAsync first
            await handler.ProcessPartAsync(1, response, CancellationToken.None);
        }

        #endregion

        #region ProcessPartAsync Tests - Cancellation

        [TestMethod]
        [ExpectedException(typeof(TaskCanceledException))]
        public async Task ProcessPartAsync_WithCancelledToken_ThrowsTaskCanceledException()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-1023/1024"
            };

            var cts = new CancellationTokenSource();
            cts.Cancel();

            // Act
            await handler.ProcessPartAsync(1, response, cts.Token);
        }

        #endregion

        #region WaitForCapacityAsync Tests

        [TestMethod]
        public async Task WaitForCapacityAsync_ReturnsImmediately()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);

            // Act
            var task = handler.WaitForCapacityAsync(CancellationToken.None);

            // Assert
            Assert.IsTrue(task.IsCompleted);
            await task;
        }

        [TestMethod]
        public async Task WaitForCapacityAsync_CanBeCalledMultipleTimes()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);

            // Act & Assert
            await handler.WaitForCapacityAsync(CancellationToken.None);
            await handler.WaitForCapacityAsync(CancellationToken.None);
            await handler.WaitForCapacityAsync(CancellationToken.None);
        }

        #endregion

        #region ReleaseCapacity Tests

        [TestMethod]
        public void ReleaseCapacity_DoesNotThrow()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);

            // Act & Assert
            handler.ReleaseCapacity();
        }

        [TestMethod]
        public void ReleaseCapacity_CanBeCalledMultipleTimes()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);

            // Act & Assert
            handler.ReleaseCapacity();
            handler.ReleaseCapacity();
            handler.ReleaseCapacity();
        }

        #endregion

        #region OnDownloadComplete Tests - Success Path

        [TestMethod]
        public async Task OnDownloadComplete_WithSuccess_CommitsTempFile()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "final.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-1023/1024"
            };
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            // Act
            handler.OnDownloadComplete(null); // null = success

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.AreEqual(0, Directory.GetFiles(_testDirectory, "*.s3tmp.*").Length);
            
            var finalData = File.ReadAllBytes(destinationPath);
            CollectionAssert.AreEqual(partData, finalData);
        }

        [TestMethod]
        public async Task OnDownloadComplete_WithSuccess_DestinationContainsAllData()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "complete.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Write 3 parts
            for (int i = 0; i < 3; i++)
            {
                var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, i * 1024);
                var response = new GetObjectResponse
                {
                    ContentLength = partData.Length,
                    ResponseStream = new MemoryStream(partData),
                    ContentRange = $"bytes {i * 1024}-{(i + 1) * 1024 - 1}/3072"
                };
                await handler.ProcessPartAsync(i + 1, response, CancellationToken.None);
            }

            // Act
            handler.OnDownloadComplete(null);

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyMultipartFileContents(
                destinationPath, 3, 1024, 0));
        }

        #endregion

        #region OnDownloadComplete Tests - Failure Path

        [TestMethod]
        public async Task OnDownloadComplete_WithFailure_CleansTempFile()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "failed.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Act
            handler.OnDownloadComplete(new Exception("Download failed"));

            // Assert
            Assert.IsFalse(File.Exists(destinationPath));
            Assert.AreEqual(0, Directory.GetFiles(_testDirectory, "*.s3tmp.*").Length);
        }

        [TestMethod]
        public async Task OnDownloadComplete_WithDifferentExceptions_AllHandledCorrectly()
        {
            // Test with OperationCanceledException
            var destinationPath1 = Path.Combine(_testDirectory, "cancelled.dat");
            var config1 = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath1);
            var handler1 = new FilePartDataHandler(config1);
            await handler1.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);
            handler1.OnDownloadComplete(new OperationCanceledException());
            Assert.IsFalse(File.Exists(destinationPath1));

            // Test with IOException
            var destinationPath2 = Path.Combine(_testDirectory, "ioerror.dat");
            var config2 = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath2);
            var handler2 = new FilePartDataHandler(config2);
            await handler2.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);
            handler2.OnDownloadComplete(new IOException("IO error"));
            Assert.IsFalse(File.Exists(destinationPath2));
        }

        #endregion

        #region Dispose Tests

        [TestMethod]
        public async Task Dispose_CleansUpUncommittedFile()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "disposed.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Act
            handler.Dispose();

            // Assert - Temp file should be cleaned up, destination should not exist
            Assert.AreEqual(0, Directory.GetFiles(_testDirectory, "*.s3tmp.*").Length);
            Assert.IsFalse(File.Exists(destinationPath));
        }

        [TestMethod]
        public async Task Dispose_AfterCommit_DoesNotDeleteDestination()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "committed.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);
            
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-1023/1024"
            };
            await handler.ProcessPartAsync(1, response, CancellationToken.None);
            
            handler.OnDownloadComplete(null); // Commit

            // Act
            handler.Dispose();

            // Assert - Destination should still exist
            Assert.IsTrue(File.Exists(destinationPath));
            var finalData = File.ReadAllBytes(destinationPath);
            CollectionAssert.AreEqual(partData, finalData);
        }

        [TestMethod]
        public void Dispose_CanBeCalledMultipleTimes()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);

            // Act & Assert - Multiple calls should not throw
            handler.Dispose();
            handler.Dispose();
            handler.Dispose();
        }

        [TestMethod]
        public async Task Dispose_WithoutPrepare_DoesNotThrow()
        {
            // Arrange
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: Path.Combine(_testDirectory, "test.dat"));
            var handler = new FilePartDataHandler(config);

            // Act & Assert - Should not throw even if PrepareAsync was never called
            handler.Dispose();
        }

        #endregion

        #region Integration Tests

        [TestMethod]
        public async Task Integration_CompleteWorkflow_ProducesCorrectFile()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "integration.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);

            // Act - Simulate complete download workflow
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Download 5 parts
            for (int i = 0; i < 5; i++)
            {
                var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, i * 1024);
                var response = new GetObjectResponse
                {
                    ContentLength = partData.Length,
                    ResponseStream = new MemoryStream(partData),
                    ContentRange = $"bytes {i * 1024}-{(i + 1) * 1024 - 1}/5120"
                };
                await handler.ProcessPartAsync(i + 1, response, CancellationToken.None);
            }

            handler.OnDownloadComplete(null);
            handler.Dispose();

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyMultipartFileContents(
                destinationPath, 5, 1024, 0));
            Assert.AreEqual(0, Directory.GetFiles(_testDirectory, "*.s3tmp.*").Length);
        }

        [TestMethod]
        public async Task Integration_ParallelDownload_ProducesCorrectFile()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "parallel.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);

            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Act - Download parts in parallel (reverse order to test offset handling)
            var tasks = new Task[5];
            for (int i = 4; i >= 0; i--)
            {
                var partNum = i + 1;
                var offset = i * 1024;
                var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, offset);
                var response = new GetObjectResponse
                {
                    ContentLength = partData.Length,
                    ResponseStream = new MemoryStream(partData),
                    ContentRange = $"bytes {offset}-{offset + 1023}/5120"
                };
                tasks[4 - i] = handler.ProcessPartAsync(partNum, response, CancellationToken.None);
            }
            await Task.WhenAll(tasks);

            handler.OnDownloadComplete(null);
            handler.Dispose();

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyMultipartFileContents(
                destinationPath, 5, 1024, 0));
        }

        [TestMethod]
        public async Task Integration_FailedDownload_CleansUpProperly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "failed-integration.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);

            // Act
            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var partData = MultipartDownloadTestHelpers.GenerateTestData(1024, 0);
            var response = new GetObjectResponse
            {
                ContentLength = partData.Length,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-1023/1024"
            };
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            handler.OnDownloadComplete(new Exception("Simulated failure"));
            handler.Dispose();

            // Assert - No files should remain
            Assert.IsFalse(File.Exists(destinationPath));
            Assert.AreEqual(0, Directory.GetFiles(_testDirectory, "*.s3tmp.*").Length);
        }

        [TestMethod]
        public async Task Integration_LargeFileDownload_HandlesCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "large-integration.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: 1024 * 1024, // 1MB parts
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);

            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Act - Download 3 parts of 1MB each
            for (int i = 0; i < 3; i++)
            {
                var partSize = 1024 * 1024;
                var offset = i * partSize;
                var partData = MultipartDownloadTestHelpers.GenerateTestData(partSize, offset);
                var response = new GetObjectResponse
                {
                    ContentLength = partData.Length,
                    ResponseStream = new MemoryStream(partData),
                    ContentRange = $"bytes {offset}-{offset + partSize - 1}/{3 * partSize}"
                };
                await handler.ProcessPartAsync(i + 1, response, CancellationToken.None);
            }

            handler.OnDownloadComplete(null);
            handler.Dispose();

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            var expectedSize = 3 * 1024 * 1024;
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(destinationPath, expectedSize));
        }

        [TestMethod]
        public async Task Integration_SingleByteFile_HandlesCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "single-byte.dat");
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);

            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Act - Download single byte
            var partData = new byte[] { 0x42 };
            var response = new GetObjectResponse
            {
                ContentLength = 1,
                ResponseStream = new MemoryStream(partData),
                ContentRange = "bytes 0-0/1"
            };
            await handler.ProcessPartAsync(1, response, CancellationToken.None);

            handler.OnDownloadComplete(null);
            handler.Dispose();

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            var fileData = File.ReadAllBytes(destinationPath);
            Assert.AreEqual(1, fileData.Length);
            Assert.AreEqual(0x42, fileData[0]);
        }

        #endregion
    }
}
