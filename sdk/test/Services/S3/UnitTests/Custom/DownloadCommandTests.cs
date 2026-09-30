using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for the single-object <see cref="DownloadCommand"/> (the non-multipart
    /// TransferUtility.Download / DownloadAsync path).
    /// </summary>
    [TestClass]
    public class DownloadCommandTests
    {
        private string _testDirectory;
        private Mock<IAmazonS3> _mockS3Client;

        [TestInitialize]
        public void Setup()
        {
            _testDirectory = Path.Combine(Path.GetTempPath(), "DownloadCommandTests_" + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(_testDirectory);

            _mockS3Client = new Mock<IAmazonS3>();
            _mockS3Client.Setup(c => c.Config).Returns(new AmazonS3Config { BufferSize = 8192 });
        }

        [TestCleanup]
        public void Cleanup()
        {
            try
            {
                if (Directory.Exists(_testDirectory))
                    Directory.Delete(_testDirectory, true);
            }
            catch { /* best effort cleanup */ }
        }

        /// <summary>
        /// Regression test for https://github.com/aws/aws-sdk-net/issues/4525.
        ///
        /// Previously DownloadCommand.ExecuteAsync called WaitBeforeRetry(retries)
        /// unconditionally at the bottom of the retry loop. On a successful first
        /// attempt retries == 0, so it slept GetRetryDelay(0) == 100ms (a blocking
        /// Thread.Sleep) on EVERY successful download. A successful download must
        /// return promptly with no fixed backoff floor.
        ///
        /// The mocked GetObject returns instantly, so real elapsed time should be a
        /// few milliseconds. We assert it stays comfortably under the old 100ms floor.
        /// </summary>
        [TestMethod]
        public async Task ExecuteAsync_SuccessfulDownload_DoesNotSleepBeforeReturning()
        {
            // Arrange
            const long fileSize = 16;
            var filePath = Path.Combine(_testDirectory, "tiny.txt");
            SetupGetObject("tiny.txt", fileSize);

            var request = new TransferUtilityDownloadRequest
            {
                BucketName = "test-bucket",
                Key = "tiny.txt",
                FilePath = filePath
            };
            var command = new DownloadCommand(_mockS3Client.Object, request);

            // Act
            var stopwatch = Stopwatch.StartNew();
            var response = await command.ExecuteAsync(CancellationToken.None);
            stopwatch.Stop();

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(filePath), "Downloaded file should exist");
            Assert.AreEqual(fileSize, new FileInfo(filePath).Length);

            // The old bug added a hard 100ms floor. Allow generous headroom for slow
            // CI hosts while still failing if a ~100ms fixed sleep is reintroduced.
            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 75,
                $"Successful download should not incur a fixed backoff sleep. Elapsed: {stopwatch.ElapsedMilliseconds}ms");

            // GetObject should be called exactly once for a clean success (no retry).
            _mockS3Client.Verify(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        private void SetupGetObject(string key, long fileSize)
        {
            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Returns((GetObjectRequest req, CancellationToken ct) =>
                {
                    var data = new byte[fileSize];
                    for (int i = 0; i < data.Length; i++) data[i] = (byte)(i % 256);
                    return Task.FromResult(new GetObjectResponse
                    {
                        BucketName = req.BucketName,
                        Key = req.Key,
                        ContentLength = fileSize,
                        ResponseStream = new MemoryStream(data),
                        ETag = "\"test-etag\""
                    });
                });
        }
    }
}
