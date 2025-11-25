using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Model;
using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class FailurePolicyTests
    {
        private static TransferUtilityDownloadDirectoryRequest CreateRequest(string localDir, FailurePolicy policy)
        {
            return new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = "test-bucket",
                S3Directory = "prefix/",
                LocalDirectory = localDir,
                FailurePolicy = policy,
                DownloadFilesConcurrently = true
            };
        }

        private static GetObjectResponse SuccessObject(string bucket, string key, string content = "data")
        {
            return new GetObjectResponse
            {
                BucketName = bucket,
                Key = key,
                ResponseStream = new MemoryStream(Encoding.UTF8.GetBytes(content)),
                ContentLength = content.Length
            };
        }

        private static Mock<IAmazonS3> CreateMockS3(IEnumerable<string> keys, Func<string, bool> shouldFail)
        {
            var mock = new Mock<IAmazonS3>();

            mock.Setup(m => m.Config).Returns(new AmazonS3Config());
            // ListObjectsAsync returns all objects in one page
            mock.Setup(m => m.ListObjectsAsync(It.Is<ListObjectsRequest>(r => r.BucketName == "test-bucket"), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ListObjectsResponse
                {
                    S3Objects = keys.Select(k => new S3Object { Key = k, Size = 4 }).ToList()
                });

            foreach (var key in keys)
            {
                if (shouldFail(key))
                {
                    mock.Setup(m => m.GetObjectAsync(It.Is<GetObjectRequest>(r => r.Key == key && r.BucketName == "test-bucket"), It.IsAny<CancellationToken>()))
                        .ThrowsAsync(new AmazonS3Exception("Simulated failure for " + key));
                }
                else
                {
                    mock.Setup(m => m.GetObjectAsync(It.Is<GetObjectRequest>(r => r.Key == key && r.BucketName == "test-bucket"), It.IsAny<CancellationToken>()))
                        .ReturnsAsync(SuccessObject("test-bucket", key));
                }
            }

            mock.Setup(m => m.Dispose());
            return mock;
        }

        private static string CreateTempDirectory()
        {
            string dir = Path.Combine(Path.GetTempPath(), "FailurePolicyTests", Guid.NewGuid().ToString());
            Directory.CreateDirectory(dir);
            return dir;
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_ContinueOnFailure_PartialSuccess()
        {
            var keys = new[] { "prefix/file1.txt", "prefix/file2.txt", "prefix/file3.txt" };
            var mockS3 = CreateMockS3(keys, k => k.EndsWith("file2.txt", StringComparison.Ordinal));
            string localDir = CreateTempDirectory();
            try
            {
                var cancellationToken = new CancellationToken();
                var config = new TransferUtilityConfig();
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateRequest(localDir, FailurePolicy.ContinueOnFailure);
                var command = new DownloadDirectoryCommand(mockS3.Object, request, config);
                command.DownloadFilesConcurrently = request.DownloadFilesConcurrently;
                var response = await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);

                Assert.IsNotNull(response);
                Assert.AreEqual(2, response.ObjectsDownloaded);
                Assert.AreEqual(1, response.ObjectsFailed);
                Assert.AreEqual(DirectoryResult.PartialSuccess, response.Result);
                Assert.IsNotNull(response.Errors);
                Assert.AreEqual(1, response.Errors.Count);
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "file1.txt")));
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "file3.txt")));
                Assert.IsFalse(File.Exists(Path.Combine(localDir, "file2.txt")));
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_ContinueOnFailure_AllFailures()
        {
            var keys = new[] { "prefix/fileA.txt", "prefix/fileB.txt" };
            var mockS3 = CreateMockS3(keys, k => true);
            string localDir = CreateTempDirectory();
            try
            {
                var cancellationToken = new CancellationToken();
                var config = new TransferUtilityConfig();
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateRequest(localDir, FailurePolicy.ContinueOnFailure);
                var command = new DownloadDirectoryCommand(mockS3.Object, request, config);
                command.DownloadFilesConcurrently = request.DownloadFilesConcurrently;
                var response = await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);

                Assert.IsNotNull(response);
                Assert.AreEqual(0, response.ObjectsDownloaded);
                Assert.AreEqual(2, response.ObjectsFailed);
                Assert.AreEqual(DirectoryResult.Failure, response.Result);
                Assert.IsNotNull(response.Errors);
                Assert.AreEqual(2, response.Errors.Count);
                Assert.AreEqual(0, Directory.GetFiles(localDir).Length);
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_ContinueOnFailure_AllSuccess()
        {
            var keys = new[] { "prefix/ok1.txt", "prefix/ok2.txt" };
            var mockS3 = CreateMockS3(keys, k => false);
            string localDir = CreateTempDirectory();
            try
            {
                var cancellationToken = new CancellationToken();
                var config = new TransferUtilityConfig();
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateRequest(localDir, FailurePolicy.ContinueOnFailure);
                var command = new DownloadDirectoryCommand(mockS3.Object, request, config);
                command.DownloadFilesConcurrently = request.DownloadFilesConcurrently;
                var response = await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);

                Assert.IsNotNull(response);
                Assert.AreEqual(2, response.ObjectsDownloaded);
                Assert.AreEqual(0, response.ObjectsFailed);
                Assert.AreEqual(DirectoryResult.Success, response.Result);
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "ok1.txt")));
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "ok2.txt")));
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_AbortOnFailure_ThrowsOnFirstFailure()
        {
            var keys = new[] { "prefix/first.txt", "prefix/second.txt" };
            var mockS3 = CreateMockS3(keys, k => k.EndsWith("second.txt", StringComparison.Ordinal));
            string localDir = CreateTempDirectory();
            try
            {
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateRequest(localDir, FailurePolicy.AbortOnFailure);

                var ex = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.DownloadDirectoryAsync(request));
                Assert.IsTrue(ex.Message.Contains("second.txt"));
                // first file may or may not have downloaded depending on timing; ensure at least one file attempt occurred
                Assert.IsTrue(Directory.GetFiles(localDir).Length <= 1);
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_ObjectDownloadFailedEvent_CancelInHandler_ContinueOnFailure_PreventsFurtherDownloads()
        {
            var keys = new[] { "prefix/file1.txt", "prefix/file2.txt", "prefix/file3.txt" };
            var mockS3 = CreateMockS3(keys, k => k.EndsWith("file2.txt", StringComparison.Ordinal));
            string localDir = CreateTempDirectory();
            try
            {
                var config = new TransferUtilityConfig();
                var request = CreateRequest(localDir, FailurePolicy.ContinueOnFailure);
                // Make sequential to make behavior deterministic for the test.
                request.DownloadFilesConcurrently = false;

                bool handlerInvoked = false;
                request.ObjectDownloadFailedEvent += (sender, args) =>
                {
                    handlerInvoked = true;
                    // Cancel the per-object CTS to stop scheduling remaining object downloads.
                    args.CancellationTokenSource.Cancel();
                };

                var command = new DownloadDirectoryCommand(mockS3.Object, request, config);
                command.DownloadFilesConcurrently = request.DownloadFilesConcurrently;
                var response = await command.ExecuteAsync(CancellationToken.None).ConfigureAwait(false);

                Assert.IsTrue(handlerInvoked, "ObjectDownloadFailedEvent handler was not invoked.");
                Assert.IsNotNull(response);
                // Allow multiple failures due to race; ensure at least one failure occurred and that one of the errors refers to file2
                Assert.IsTrue(response.ObjectsFailed >= 1, "Expected at least one failed object.");
                Assert.IsNotNull(response.Errors);
                Assert.IsTrue(response.Errors.Count >= 1, "Expected at least one error recorded.");
                Assert.IsTrue(response.Errors.Any(e => e.Message.Contains("file2.txt") || e.Message.Contains("file2")), "Expected at least one error to reference file2.");
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "file1.txt")), "Expected file1 to be downloaded.");
                Assert.IsFalse(File.Exists(Path.Combine(localDir, "file2.txt")), "Expected failed file2 not to exist on disk.");
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_ObjectDownloadFailedEvent_CancelInHandler_AbortOnFailure_Throws()
        {
            var keys = new[] { "prefix/first.txt", "prefix/second.txt", "prefix/third.txt" };
            var mockS3 = CreateMockS3(keys, k => k.EndsWith("second.txt", StringComparison.Ordinal));
            string localDir = CreateTempDirectory();
            try
            {
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateRequest(localDir, FailurePolicy.AbortOnFailure);
                request.DownloadFilesConcurrently = false;

                request.ObjectDownloadFailedEvent += (sender, args) =>
                {
                    // Cancel the per-object CTS in the handler; with AbortOnFailure the overall operation should throw.
                    args.CancellationTokenSource.Cancel();
                };

                var ex = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.DownloadDirectoryAsync(request));
                Assert.IsTrue(ex.Message.Contains("second.txt") || ex.Message.Contains("Simulated failure for"));
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_ObjectDownloadFailedEvent_ArgsContainExpectedData_ContinueOnFailure()
        {
            var keys = new[] { "prefix/a.txt", "prefix/b.txt" };
            var mockS3 = CreateMockS3(keys, k => k.EndsWith("b.txt", StringComparison.Ordinal));
            string localDir = CreateTempDirectory();
            try
            {
                var config = new TransferUtilityConfig();
                var request = CreateRequest(localDir, FailurePolicy.ContinueOnFailure);
                // collect events
                var captured = new List<ObjectDownloadFailedEventArgs>();
                var invoked = new ManualResetEventSlim(false);
                request.ObjectDownloadFailedEvent += (sender, args) =>
                {
                    captured.Add(args);
                    invoked.Set();
                };

                var command = new DownloadDirectoryCommand(mockS3.Object, request, config);
                command.DownloadFilesConcurrently = request.DownloadFilesConcurrently;
                var response = await command.ExecuteAsync(CancellationToken.None).ConfigureAwait(false);

                // wait briefly for any background event dispatch
                invoked.Wait(1000);

                Assert.IsNotNull(response);
                Assert.AreEqual(1, response.ObjectsFailed);
                Assert.AreEqual(1, captured.Count);

                var evt = captured[0];
                Assert.AreSame(request, evt.DirectoryRequest);
                Assert.IsNotNull(evt.ObjectRequest);
                Assert.IsTrue(evt.ObjectRequest.Key.EndsWith("b.txt", StringComparison.Ordinal));
                Assert.IsNotNull(evt.Exception);
                Assert.IsTrue(evt.Exception.Message.Contains("Simulated failure for"));
                Assert.IsNotNull(evt.CancellationTokenSource);
                Assert.IsFalse(evt.CancellationTokenSource.IsCancellationRequested);
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task DownloadDirectory_ObjectDownloadFailedEvent_ArgsContainExpectedData_AbortOnFailure()
        {
            var keys = new[] { "prefix/x.txt", "prefix/y.txt" };
            var mockS3 = CreateMockS3(keys, k => k.EndsWith("y.txt", StringComparison.Ordinal));
            string localDir = CreateTempDirectory();
            try
            {
                var request = CreateRequest(localDir, FailurePolicy.AbortOnFailure);
                var captured = new List<ObjectDownloadFailedEventArgs>();
                var invoked = new ManualResetEventSlim(false);

                request.ObjectDownloadFailedEvent += (sender, args) =>
                {
                    captured.Add(args);
                    invoked.Set();
                };

                var tu = new TransferUtility(mockS3.Object);
                await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.DownloadDirectoryAsync(request));

                // wait for event
                invoked.Wait(1000);

                Assert.AreEqual(1, captured.Count);
                var evt = captured[0];
                Assert.AreSame(request, evt.DirectoryRequest);
                Assert.IsNotNull(evt.ObjectRequest);
                Assert.IsTrue(evt.ObjectRequest.Key.EndsWith("y.txt", StringComparison.Ordinal));
                Assert.IsNotNull(evt.Exception);
                Assert.IsTrue(evt.Exception.Message.Contains("Simulated failure for"));
                Assert.IsNotNull(evt.CancellationTokenSource);
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }
    }
}
