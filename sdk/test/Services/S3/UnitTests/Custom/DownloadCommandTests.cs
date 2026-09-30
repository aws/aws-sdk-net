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
        private const string TestBucket = "test-bucket";

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
        /// This test is intentionally TIMING-SENSITIVE (tagged accordingly): the only
        /// externally observable symptom of the old bug is wall-clock time. To keep it
        /// robust we AMORTIZE across many downloads and warm up first: the old bug added
        /// a FIXED ~100ms per call, so N downloads cost >= N*100ms, while the mocked work
        /// is a few ms each. The budget below (a generous per-call average still well
        /// below the 100ms floor) fails decisively if a fixed sleep is reintroduced, and
        /// one-off GC/scheduling/AV/file-IO pauses are absorbed by the average. The
        /// deterministic, non-timing guarantee (exactly one GetObject, no retry) is
        /// asserted separately in
        /// ExecuteAsync_SuccessfulDownload_IssuesSingleGetObjectWithNoRetry, so a rare
        /// timing flake here never hides a real behavioral regression.
        /// </summary>
        [TestMethod]
        [TestCategory("TimingSensitive")]
        public async Task ExecuteAsync_SuccessfulDownload_DoesNotSleepBeforeReturning()
        {
            // Arrange
            const int fileSize = 16;
            const int iterations = 10;
            // Per-call average budget, comfortably below the old 100ms/call floor but
            // loose enough to absorb CI noise (GC, AV scanning, file IO, scheduling).
            const int perCallBudgetMs = 60;

            // Warm up once so JIT of the download path is not counted in the measured loop.
            await RunSingleDownloadAsync("tiny-warmup.txt", fileSize);

            // Act
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                await RunSingleDownloadAsync($"tiny-{i}.txt", fileSize);
            }
            stopwatch.Stop();

            // Assert
            // The old bug added a fixed ~100ms floor per call => >= 1000ms for 10 calls.
            Assert.IsTrue(stopwatch.ElapsedMilliseconds < iterations * perCallBudgetMs,
                $"Successful downloads should not incur a fixed backoff sleep. " +
                $"Elapsed for {iterations} downloads: {stopwatch.ElapsedMilliseconds}ms " +
                $"(budget {iterations * perCallBudgetMs}ms; would be >= {iterations * 100}ms " +
                $"with the old 100ms-per-call sleep).");
        }

        /// <summary>
        /// Deterministic (non-timing) companion to the regression above: a clean,
        /// successful download must issue exactly one GetObject call and no retry.
        /// </summary>
        [TestMethod]
        public async Task ExecuteAsync_SuccessfulDownload_IssuesSingleGetObjectWithNoRetry()
        {
            // Arrange
            const int fileSize = 16;
            const string key = "tiny.txt";
            var filePath = Path.Combine(_testDirectory, key);
            SetupGetObject(key, fileSize);

            var request = new TransferUtilityDownloadRequest
            {
                BucketName = TestBucket,
                Key = key,
                FilePath = filePath
            };
            var command = new DownloadCommand(_mockS3Client.Object, request);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(filePath), "Downloaded file should exist");
            Assert.AreEqual(fileSize, new FileInfo(filePath).Length);

            // Exactly one GetObject for the expected bucket/key, with no retry.
            _mockS3Client.Verify(c => c.GetObjectAsync(
                It.Is<GetObjectRequest>(r => r.BucketName == TestBucket && r.Key == key),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        /// <summary>
        /// When the operation is cancelled, DownloadCommand must surface an
        /// OperationCanceledException rather than wrapping it in an
        /// AmazonServiceException. This guards the fix for #4525 where the retry
        /// backoff became a cancellable await: a cancellation thrown from an awaited
        /// call must not be reclassified by the generic retry catch.
        /// </summary>
        [TestMethod]
        public async Task ExecuteAsync_CancelledDuringGetObject_PropagatesOperationCanceledException()
        {
            // Arrange
            var cts = new CancellationTokenSource();
            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Returns((GetObjectRequest req, CancellationToken ct) =>
                {
                    cts.Cancel();
                    ct.ThrowIfCancellationRequested();
                    return Task.FromResult(new GetObjectResponse());
                });

            var request = new TransferUtilityDownloadRequest
            {
                BucketName = TestBucket,
                Key = "tiny.txt",
                FilePath = Path.Combine(_testDirectory, "tiny.txt")
            };
            var command = new DownloadCommand(_mockS3Client.Object, request);

            // Act & Assert
            try
            {
                await command.ExecuteAsync(cts.Token);
                Assert.Fail("Expected an OperationCanceledException to be thrown");
            }
            catch (OperationCanceledException)
            {
                // Expected: cancellation propagates (TaskCanceledException derives from
                // OperationCanceledException) and is NOT wrapped in AmazonServiceException.
            }
            catch (Exception ex)
            {
                Assert.Fail($"Expected OperationCanceledException but got {ex.GetType().Name}: {ex.Message}");
            }
        }

        private async Task RunSingleDownloadAsync(string key, int fileSize)
        {
            SetupGetObject(key, fileSize);
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = TestBucket,
                Key = key,
                FilePath = Path.Combine(_testDirectory, key)
            };
            var command = new DownloadCommand(_mockS3Client.Object, request);
            await command.ExecuteAsync(CancellationToken.None);
        }

        private void SetupGetObject(string key, int fileSize)
        {
            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.Is<GetObjectRequest>(r => r.BucketName == TestBucket && r.Key == key),
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
