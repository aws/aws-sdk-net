using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Comprehensive concurrency tests for FilePartDataHandler to validate that concurrent file writes
    /// using FileShare.Write and different offsets don't cause data corruption.
    /// 
    /// Each test verifies every byte matches expected patterns after concurrent writes complete.
    /// </summary>
    [TestClass]
    public class FilePartDataHandlerConcurrencyTests
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

        #region Helper Methods

        /// <summary>
        /// Executes a concurrent write test with the specified parameters and returns the final file data.
        /// </summary>
        /// <param name="fileName">Name of the file to create</param>
        /// <param name="partSize">Size of each part in bytes</param>
        /// <param name="partCount">Number of parts to write</param>
        /// <param name="writeOrder">Optional custom write order. If null, writes parts sequentially (1,2,3...)</param>
        /// <returns>The final file data as byte array</returns>
        private async Task<byte[]> ExecuteConcurrentWriteTest(
            string fileName,
            int partSize,
            int partCount,
            int[] writeOrder = null)
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, fileName);
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: partSize,
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);

            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            // Determine write order (default to sequential if not specified)
            var order = writeOrder ?? Enumerable.Range(1, partCount).ToArray();

            // Act - Create and execute all write tasks concurrently
            var tasks = new Task[partCount];
            for (int i = 0; i < partCount; i++)
            {
                var partNum = order[i];
                var offset = (partNum - 1) * partSize;
                var partData = MultipartDownloadTestHelpers.GeneratePartSpecificData(partSize, partNum);

                var response = new GetObjectResponse
                {
                    ContentLength = partData.Length,
                    ResponseStream = new MemoryStream(partData),
                    ContentRange = $"bytes {offset}-{offset + partSize - 1}/{partCount * partSize}"
                };

                tasks[i] = handler.ProcessPartAsync(partNum, response, CancellationToken.None);
            }

            await Task.WhenAll(tasks);
            handler.OnDownloadComplete(null);

            // Return the final file data for verification
            Assert.IsTrue(File.Exists(destinationPath), "Destination file should exist");
            return File.ReadAllBytes(destinationPath);
        }

        /// <summary>
        /// Executes a concurrent write test with varying part sizes and returns the final file data.
        /// </summary>
        private async Task<byte[]> ExecuteVaryingSizeTest(
            string fileName,
            (int PartNum, int Size, int Offset)[] partDefinitions,
            int[] writeOrder = null)
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, fileName);
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: destinationPath);
            var handler = new FilePartDataHandler(config);

            await handler.PrepareAsync(new DownloadDiscoveryResult(), CancellationToken.None);

            var totalSize = partDefinitions.Sum(p => p.Size);
            var order = writeOrder ?? Enumerable.Range(0, partDefinitions.Length).ToArray();

            // Act - Write parts with varying sizes
            var tasks = new Task[partDefinitions.Length];
            for (int i = 0; i < order.Length; i++)
            {
                var partIdx = order[i];
                var part = partDefinitions[partIdx];
                var partData = MultipartDownloadTestHelpers.GeneratePartSpecificData(part.Size, part.PartNum);

                var response = new GetObjectResponse
                {
                    ContentLength = partData.Length,
                    ResponseStream = new MemoryStream(partData),
                    ContentRange = $"bytes {part.Offset}-{part.Offset + part.Size - 1}/{totalSize}"
                };

                tasks[i] = handler.ProcessPartAsync(part.PartNum, response, CancellationToken.None);
            }

            await Task.WhenAll(tasks);
            handler.OnDownloadComplete(null);

            Assert.IsTrue(File.Exists(destinationPath));
            return File.ReadAllBytes(destinationPath);
        }

        /// <summary>
        /// Verifies that every byte in the file matches the expected pattern for uniform part sizes.
        /// </summary>
        private void VerifyAllBytes(byte[] fileData, int partSize, int partCount)
        {
            Assert.AreEqual(partCount * partSize, fileData.Length, "File size mismatch");

            for (int i = 0; i < partCount; i++)
            {
                var expectedData = MultipartDownloadTestHelpers.GeneratePartSpecificData(partSize, i + 1);
                var actualData = fileData.Skip(i * partSize).Take(partSize).ToArray();
                CollectionAssert.AreEqual(expectedData, actualData, $"Part {i + 1} data corrupted");
            }
        }

        /// <summary>
        /// Verifies that every byte in the file matches the expected pattern for varying part sizes.
        /// </summary>
        private void VerifyVaryingSizeBytes(byte[] fileData, (int PartNum, int Size, int Offset)[] partDefinitions)
        {
            var totalSize = partDefinitions.Sum(p => p.Size);
            Assert.AreEqual(totalSize, fileData.Length, "File size mismatch");

            foreach (var part in partDefinitions)
            {
                var expectedData = MultipartDownloadTestHelpers.GeneratePartSpecificData(part.Size, part.PartNum);
                var actualData = fileData.Skip(part.Offset).Take(part.Size).ToArray();
                CollectionAssert.AreEqual(expectedData, actualData,
                    $"Part {part.PartNum} (size {part.Size} at offset {part.Offset}) corrupted");
            }
        }

        #endregion

        #region Sequential Order Tests

        [TestMethod]
        public async Task ConcurrentWrites_SequentialOrder_VerifyEveryByte()
        {
            // Act - Write parts in sequential order (1, 2, 3, 4, 5) concurrently
            var partSize = 4096; // 4KB per part
            var partCount = 5;
            var fileData = await ExecuteConcurrentWriteTest("sequential.dat", partSize, partCount);

            // Assert - Verify temp files cleaned up and every byte matches expected pattern
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            Assert.AreEqual(0, tempFiles.Length, "Temp files should be cleaned up after commit");
            
            VerifyAllBytes(fileData, partSize, partCount);
        }

        [TestMethod]
        public async Task ConcurrentWrites_SequentialOrder_LargeParts_VerifyEveryByte()
        {
            // Act - Write large parts concurrently in sequential order
            var partSize = 1024 * 1024; // 1MB per part
            var partCount = 3;
            var fileData = await ExecuteConcurrentWriteTest("sequential-large.dat", partSize, partCount);

            // Assert - Verify every byte
            VerifyAllBytes(fileData, partSize, partCount);
        }

        #endregion

        #region Reverse Order Tests

        [TestMethod]
        public async Task ConcurrentWrites_ReverseOrder_VerifyEveryByte()
        {
            // Act - Write parts in reverse order (5, 4, 3, 2, 1) concurrently
            var partSize = 4096; // 4KB per part
            var partCount = 5;
            var reverseOrder = Enumerable.Range(1, partCount).Reverse().ToArray();
            var fileData = await ExecuteConcurrentWriteTest("reverse.dat", partSize, partCount, reverseOrder);

            // Assert - Verify every byte matches expected pattern
            VerifyAllBytes(fileData, partSize, partCount);
        }

        [TestMethod]
        public async Task ConcurrentWrites_ReverseOrder_LargeParts_VerifyEveryByte()
        {
            // Act - Write large parts in reverse order concurrently
            var partSize = 1024 * 1024; // 1MB per part
            var partCount = 3;
            var reverseOrder = Enumerable.Range(1, partCount).Reverse().ToArray();
            var fileData = await ExecuteConcurrentWriteTest("reverse-large.dat", partSize, partCount, reverseOrder);

            // Assert - Verify every byte
            VerifyAllBytes(fileData, partSize, partCount);
        }

        #endregion

        #region Random Order Tests

        [TestMethod]
        public async Task ConcurrentWrites_RandomOrder_VerifyEveryByte()
        {
            // Act - Write parts in random order (3, 1, 7, 2, 5, 8, 4, 6) concurrently
            var partSize = 4096; // 4KB per part
            var partCount = 8;
            var randomOrder = new[] { 3, 1, 7, 2, 5, 8, 4, 6 };
            var fileData = await ExecuteConcurrentWriteTest("random.dat", partSize, partCount, randomOrder);

            // Assert - Verify every byte matches expected pattern
            VerifyAllBytes(fileData, partSize, partCount);
        }

        [TestMethod]
        public async Task ConcurrentWrites_ComplexRandomOrder_VerifyEveryByte()
        {
            // Act - Write parts in complex random order concurrently
            var partSize = 8192; // 8KB per part
            var partCount = 12;
            var randomOrder = new[] { 7, 2, 11, 4, 1, 9, 12, 3, 6, 10, 5, 8 };
            var fileData = await ExecuteConcurrentWriteTest("complex-random.dat", partSize, partCount, randomOrder);

            // Assert - Verify every byte
            VerifyAllBytes(fileData, partSize, partCount);
        }

        #endregion

        #region High Concurrency Tests

        [TestMethod]
        public async Task ConcurrentWrites_TwentyParts_VerifyEveryByte()
        {
            // Act - Write 20 parts concurrently in random order
            var partSize = 4096; // 4KB per part
            var partCount = 20;
            var randomOrder = Enumerable.Range(1, partCount).OrderBy(x => Guid.NewGuid()).ToArray();
            var fileData = await ExecuteConcurrentWriteTest("twenty-parts.dat", partSize, partCount, randomOrder);

            // Assert - Verify every byte across all 20 parts
            VerifyAllBytes(fileData, partSize, partCount);
        }

        [TestMethod]
        public async Task ConcurrentWrites_FiftyParts_VerifyEveryByte()
        {
            // Act - Write 50 parts concurrently in random order
            var partSize = 2048; // 2KB per part (smaller to keep test fast)
            var partCount = 50;
            var randomOrder = Enumerable.Range(1, partCount).OrderBy(x => Guid.NewGuid()).ToArray();
            var fileData = await ExecuteConcurrentWriteTest("fifty-parts.dat", partSize, partCount, randomOrder);

            // Assert - Verify every byte across all 50 parts
            VerifyAllBytes(fileData, partSize, partCount);
        }

        [TestMethod]
        public async Task ConcurrentWrites_HighConcurrency_StressTest_VerifyEveryByte()
        {
            // Act - Write all parts concurrently with maximum parallelism (stress test)
            var partSize = 4096; // 4KB per part
            var partCount = 30;
            var randomOrder = Enumerable.Range(1, partCount).OrderBy(x => Guid.NewGuid()).ToArray();
            var fileData = await ExecuteConcurrentWriteTest("stress-test.dat", partSize, partCount, randomOrder);

            // Assert - Verify every byte even under high contention
            VerifyAllBytes(fileData, partSize, partCount);
        }

        #endregion

        #region Varying Part Size Tests

        [TestMethod]
        public async Task ConcurrentWrites_VaryingPartSizes_VerifyEveryByte()
        {
            // Act - Write parts with varying sizes (1KB, 4KB, 8KB, 2KB, 16KB) concurrently
            var partSizes = new[] { 1024, 4096, 8192, 2048, 16384 };
            var offset = 0;
            var partDefinitions = partSizes.Select((size, i) =>
            {
                var part = (PartNum: i + 1, Size: size, Offset: offset);
                offset += size;
                return part;
            }).ToArray();

            var fileData = await ExecuteVaryingSizeTest("varying-sizes.dat", partDefinitions);

            // Assert - Verify every byte with varying sizes
            VerifyVaryingSizeBytes(fileData, partDefinitions);
        }

        [TestMethod]
        public async Task ConcurrentWrites_VaryingSizesRandomOrder_VerifyEveryByte()
        {
            // Act - Write varying size parts in random order
            var partDefinitions = new[]
            {
                (PartNum: 1, Size: 2048, Offset: 0),
                (PartNum: 2, Size: 8192, Offset: 2048),
                (PartNum: 3, Size: 4096, Offset: 10240),
                (PartNum: 4, Size: 16384, Offset: 14336),
                (PartNum: 5, Size: 1024, Offset: 30720)
            };
            var randomOrder = Enumerable.Range(0, partDefinitions.Length).OrderBy(x => Guid.NewGuid()).ToArray();
            var fileData = await ExecuteVaryingSizeTest("varying-sizes-random.dat", partDefinitions, randomOrder);

            // Assert - Verify every byte across varying sizes
            VerifyVaryingSizeBytes(fileData, partDefinitions);
        }

        #endregion

        #region Mixed Scenario Tests

        [TestMethod]
        public async Task ConcurrentWrites_MixedScenario_SmallAndLargeParts_VerifyEveryByte()
        {
            // Act - Write mixed size parts (100 bytes, 1MB, 500 bytes, 2MB, 1KB) in random order
            var partDefinitions = new[]
            {
                (PartNum: 1, Size: 100, Offset: 0),
                (PartNum: 2, Size: 1024 * 1024, Offset: 100),
                (PartNum: 3, Size: 500, Offset: 100 + 1024 * 1024),
                (PartNum: 4, Size: 2 * 1024 * 1024, Offset: 100 + 1024 * 1024 + 500),
                (PartNum: 5, Size: 1024, Offset: 100 + 1024 * 1024 + 500 + 2 * 1024 * 1024)
            };
            var randomOrder = Enumerable.Range(0, partDefinitions.Length).OrderBy(x => Guid.NewGuid()).ToArray();
            var fileData = await ExecuteVaryingSizeTest("mixed-scenario.dat", partDefinitions, randomOrder);

            // Assert - Verify every byte in mixed scenario
            VerifyVaryingSizeBytes(fileData, partDefinitions);
        }

        #endregion
    }
}
