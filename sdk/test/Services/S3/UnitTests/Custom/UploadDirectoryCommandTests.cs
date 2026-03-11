using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class UploadDirectoryCommandTests
    {
        private string _testDirectory;
        private Mock<IAmazonS3> _mockS3Client;
        private TransferUtilityConfig _config;

        [TestInitialize]
        public void Setup()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), "UploadDirectoryCommandTests_" + Guid.NewGuid().ToString("N").Substring(0, 8));
            Directory.CreateDirectory(_testDirectory);

            // Create some test files
            File.WriteAllBytes(Path.Combine(_testDirectory, "file1.dat"), GenerateTestData(1024));
            File.WriteAllBytes(Path.Combine(_testDirectory, "file2.dat"), GenerateTestData(1024));
            File.WriteAllBytes(Path.Combine(_testDirectory, "file3.dat"), GenerateTestData(1024));
            File.WriteAllBytes(Path.Combine(_testDirectory, "file4.dat"), GenerateTestData(1024));
            File.WriteAllBytes(Path.Combine(_testDirectory, "file5.dat"), GenerateTestData(1024));

            _mockS3Client = new Mock<IAmazonS3>();
            _config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 4
            };

            var s3Config = new AmazonS3Config
            {
                BufferSize = 8192,
            };
            _mockS3Client.Setup(c => c.Config).Returns(s3Config);
        }

        [TestCleanup]
        public void Cleanup()
        {
            if (Directory.Exists(_testDirectory))
            {
                try
                {
                    Directory.Delete(_testDirectory, true);
                }
                catch
                {
                    // Ignore cleanup errors in tests
                }
            }
        }

        #region Concurrency Control Tests

        /// <summary>
        /// Tests that ConcurrentServiceRequests setting actually limits concurrent file uploads.
        /// Expected: Max 2 concurrent uploads (ConcurrentServiceRequests = 2)
        /// </summary>
        [TestMethod]
        public async Task ExecuteAsync_ConcurrentServiceRequests_RespectsLimit()
        {
            // Arrange
            var request = CreateUploadDirectoryRequest();
            request.UploadFilesConcurrently = true;

            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 2
            };

            var currentConcurrentUploads = 0;
            var maxObservedConcurrency = 0;
            var concurrencyLock = new object();

            // Map filenames to sizes
            var files = Directory.GetFiles(_testDirectory).ToDictionary(Path.GetFileName, f => new FileInfo(f).Length);

            // Mock PutObjectAsync to track concurrency
            _mockS3Client.Setup(c => c.PutObjectAsync(
                It.IsAny<PutObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Returns(async (PutObjectRequest req, CancellationToken ct) =>
                {
                    lock (concurrencyLock)
                    {
                        currentConcurrentUploads++;
                        maxObservedConcurrency = Math.Max(maxObservedConcurrency, currentConcurrentUploads);
                    }

                    try
                    {
                        await Task.Delay(100, ct);
                        var fileName = Path.GetFileName(req.FilePath);
                        var fileSize = files[fileName];
                        return new PutObjectResponse
                        {
                            ETag = "\"test-etag\"",
                            HttpStatusCode = System.Net.HttpStatusCode.OK,
                        };
                    }
                    finally
                    {
                        lock (concurrencyLock)
                        {
                            currentConcurrentUploads--;
                        }
                    }
                });

            var utility = new TransferUtility(_mockS3Client.Object, config);
            var command = new UploadDirectoryCommand(utility, config, request);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(2, config.ConcurrentServiceRequests, "Test setup verification");
            Assert.IsTrue(maxObservedConcurrency <= config.ConcurrentServiceRequests,
                $"Max concurrent uploads ({maxObservedConcurrency}) should not exceed ConcurrentServiceRequests ({config.ConcurrentServiceRequests})");
        }

        /// <summary>
        /// Tests that sequential mode (UploadFilesConcurrently = false) uploads only one file at a time.
        /// Expected: Max 1 concurrent upload (sequential mode)
        /// </summary>
        [TestMethod]
        public async Task ExecuteAsync_SequentialMode_UploadsOneAtATime()
        {
            // Arrange
            var request = CreateUploadDirectoryRequest();
            request.UploadFilesConcurrently = false;

            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10
            };

            var currentConcurrentUploads = 0;
            var maxObservedConcurrency = 0;
            var concurrencyLock = new object();

            var files = Directory.GetFiles(_testDirectory).Take(3).ToDictionary(Path.GetFileName, f => new FileInfo(f).Length);

            // Mock PutObjectAsync to track concurrency
            _mockS3Client.Setup(c => c.PutObjectAsync(
                It.IsAny<PutObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Returns(async (PutObjectRequest req, CancellationToken ct) =>
                {
                    lock (concurrencyLock)
                    {
                        currentConcurrentUploads++;
                        maxObservedConcurrency = Math.Max(maxObservedConcurrency, currentConcurrentUploads);
                    }

                    try
                    {
                        await Task.Delay(50, ct);
                        return new PutObjectResponse
                        {
                            ETag = "\"test-etag\"",
                            HttpStatusCode = System.Net.HttpStatusCode.OK,
                        };
                    }
                    finally
                    {
                        lock (concurrencyLock)
                        {
                            currentConcurrentUploads--;
                        }
                    }
                });

            var utility = new TransferUtility(_mockS3Client.Object, config);
            var command = new UploadDirectoryCommand(utility, config, request);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, maxObservedConcurrency,
                $"Sequential mode should only upload 1 file at a time, but observed {maxObservedConcurrency}");
        }

        #endregion

        #region Helper Methods

        private TransferUtilityUploadDirectoryRequest CreateUploadDirectoryRequest(
            string bucketName = "test-bucket",
            string s3Directory = "prefix",
            string localDirectory = null)
        {
            localDirectory = localDirectory ?? _testDirectory;

            return new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                KeyPrefix = s3Directory,
                Directory = localDirectory
            };
        }

        private byte[] GenerateTestData(int size)
        {
            var data = new byte[size];
            var random = new Random(42); // Fixed seed for reproducible tests
            random.NextBytes(data);
            return data;
        }

        #endregion
    }
}
