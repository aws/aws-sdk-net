using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
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
        /// Deterministic (non-timing) behavioral guard for the #4525 fix: a clean,
        /// successful download must issue exactly one GetObject call and no retry.
        /// (A separate timing-based test was intentionally omitted — the only externally
        /// observable symptom of the old fixed 100ms sleep is wall-clock time, which is
        /// too brittle to assert reliably in CI.)
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
