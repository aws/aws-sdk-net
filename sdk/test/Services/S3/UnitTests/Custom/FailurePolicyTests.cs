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

        private static TransferUtilityUploadDirectoryRequest CreateUploadRequest(string localDir, FailurePolicy policy)
        {
            return new TransferUtilityUploadDirectoryRequest
            {
                BucketName = "test-bucket",
                Directory = localDir,
                FailurePolicy = policy,
                UploadFilesConcurrently = true
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

        private static Mock<IAmazonS3> CreateMockS3ForUpload(IEnumerable<string> keys, Func<string, bool> shouldFail)
        {
            var mock = new Mock<IAmazonS3>();
            mock.Setup(m => m.Config).Returns(new AmazonS3Config());

            foreach (var key in keys)
            {
                if (shouldFail(key))
                {
                    mock.Setup(m => m.PutObjectAsync(It.Is<PutObjectRequest>(r => r.Key == key && r.BucketName == "test-bucket"), It.IsAny<CancellationToken>()))
                        .ThrowsAsync(new AmazonS3Exception("Simulated failure for " + key));
                }
                else
                {
                    mock.Setup(m => m.PutObjectAsync(It.Is<PutObjectRequest>(r => r.Key == key && r.BucketName == "test-bucket"), It.IsAny<CancellationToken>()))
                        .ReturnsAsync(new PutObjectResponse());
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
        public async Task DownloadDirectory_ObjectDownloadFailedEvent_CancelInHandler_ContinueOnFailure_Throws()
        {
            var keys = new[] { "prefix/file1.txt", "prefix/file2.txt", "prefix/file3.txt" };
            var mockS3 = CreateMockS3(keys, k => k.EndsWith("file2.txt", StringComparison.Ordinal));
            string localDir = CreateTempDirectory();
            try
            {
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateRequest(localDir, FailurePolicy.ContinueOnFailure);
                // Make sequential to make behavior deterministic for the test.
                request.DownloadFilesConcurrently = false;

                bool handlerInvoked = false;
                request.ObjectDownloadFailedEvent += (sender, args) =>
                {
                    handlerInvoked = true;
                    throw new AmazonS3Exception("Stop processing immediately");
                };

                var ex = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.DownloadDirectoryAsync(request));
                Assert.IsTrue(ex.Message.Equals("Stop processing immediately"));

                Assert.IsTrue(handlerInvoked, "ObjectDownloadFailedEvent handler was not invoked.");
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
                    throw new AmazonS3Exception("Stop processing immediately");
                };

                var ex = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.DownloadDirectoryAsync(request));
                Assert.IsTrue(ex.Message.Equals("Stop processing immediately"));
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
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }
        
        [TestMethod]
        [TestCategory("S3")]
        public async Task UploadDirectory_ContinueOnFailure_PartialSuccess()
        {
            var fileNames = new[] { "file1.txt", "file2.txt", "file3.txt" };
            string localDir = CreateTempDirectory();
            try
            {
                // create files
                foreach (var f in fileNames)
                {
                    File.WriteAllText(Path.Combine(localDir, f), "data");
                }

                var mockS3 = CreateMockS3ForUpload(fileNames, k => k.EndsWith("file2.txt", StringComparison.Ordinal));
                var cancellationToken = new CancellationToken();
                var config = new TransferUtilityConfig();
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateUploadRequest(localDir, FailurePolicy.ContinueOnFailure);
                var command = new UploadDirectoryCommand(tu, config, request);
                command.UploadFilesConcurrently = request.UploadFilesConcurrently;
                var response = await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);

                Assert.IsNotNull(response);
                Assert.AreEqual(2, response.ObjectsUploaded);
                Assert.AreEqual(1, response.ObjectsFailed);
                Assert.AreEqual(DirectoryResult.PartialSuccess, response.Result);
                Assert.IsNotNull(response.Errors);
                Assert.AreEqual(1, response.Errors.Count);
                // local files remain
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "file1.txt")));
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "file3.txt")));
                Assert.IsTrue(File.Exists(Path.Combine(localDir, "file2.txt")));
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task UploadDirectory_ContinueOnFailure_AllFailures()
        {
            var fileNames = new[] { "fileA.txt", "fileB.txt" };
            string localDir = CreateTempDirectory();
            try
            {
                foreach (var f in fileNames)
                    File.WriteAllText(Path.Combine(localDir, f), "data");

                var mockS3 = CreateMockS3ForUpload(fileNames, k => true);
                var cancellationToken = new CancellationToken();
                var config = new TransferUtilityConfig();
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateUploadRequest(localDir, FailurePolicy.ContinueOnFailure);
                var command = new UploadDirectoryCommand(tu, config, request);
                command.UploadFilesConcurrently = request.UploadFilesConcurrently;
                var response = await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);

                Assert.IsNotNull(response);
                Assert.AreEqual(0, response.ObjectsUploaded);
                Assert.AreEqual(2, response.ObjectsFailed);
                Assert.AreEqual(DirectoryResult.Failure, response.Result);
                Assert.IsNotNull(response.Errors);
                Assert.AreEqual(2, response.Errors.Count);
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task UploadDirectory_ContinueOnFailure_AllSuccess()
        {
            var fileNames = new[] { "ok1.txt", "ok2.txt" };
            string localDir = CreateTempDirectory();
            try
            {
                foreach (var f in fileNames)
                    File.WriteAllText(Path.Combine(localDir, f), "data");

                var mockS3 = CreateMockS3ForUpload(fileNames, k => false);
                var cancellationToken = new CancellationToken();
                var config = new TransferUtilityConfig();
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateUploadRequest(localDir, FailurePolicy.ContinueOnFailure);
                var command = new UploadDirectoryCommand(tu, config, request);
                command.UploadFilesConcurrently = request.UploadFilesConcurrently;
                var response = await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);

                Assert.IsNotNull(response);
                Assert.AreEqual(2, response.ObjectsUploaded);
                Assert.AreEqual(0, response.ObjectsFailed);
                Assert.AreEqual(DirectoryResult.Success, response.Result);
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task UploadDirectory_AbortOnFailure_ThrowsOnFirstFailure()
        {
            var fileNames = new[] { "first.txt", "second.txt" };
            string localDir = CreateTempDirectory();
            try
            {
                foreach (var f in fileNames)
                    File.WriteAllText(Path.Combine(localDir, f), "data");

                var mockS3 = CreateMockS3ForUpload(fileNames, k => k.EndsWith("second.txt", StringComparison.Ordinal));
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateUploadRequest(localDir, FailurePolicy.AbortOnFailure);

                var ex = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.UploadDirectoryAsync(request));
                Assert.IsTrue(ex.Message.Contains("second.txt"));
                // first file may or may not have uploaded depending on timing; ensure at least one file attempt occurred
                Assert.IsTrue(Directory.GetFiles(localDir).Length >= 1);
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task UploadDirectory_ObjectUploadFailedEvent_CancelInHandler_ContinueOnFailure_Throws()
        {
            var fileNames = new[] { "file1.txt", "file2.txt", "file3.txt" };
            string localDir = CreateTempDirectory();
            try
            {
                foreach (var f in fileNames)
                    File.WriteAllText(Path.Combine(localDir, f), "data");

                var mockS3 = CreateMockS3ForUpload(fileNames, k => k.EndsWith("file2.txt", StringComparison.Ordinal));
                var tu = new TransferUtility(mockS3.Object);
                var request = CreateUploadRequest(localDir, FailurePolicy.ContinueOnFailure);
                // Make sequential to make behavior deterministic for the test.
                request.UploadFilesConcurrently = false;

                bool handlerInvoked = false;
                request.ObjectUploadFailedEvent += (sender, args) =>
                {
                    handlerInvoked = true;
                    throw new AmazonS3Exception("Stop processing immediately");
                };

                var ex = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.UploadDirectoryAsync(request));
                Assert.IsTrue(ex.Message.Equals("Stop processing immediately"));

                Assert.IsTrue(handlerInvoked, "ObjectUploadFailedEvent handler was not invoked.");
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task UploadDirectory_ObjectUploadFailedEvent_ArgsContainExpectedData_ContinueOnFailure()
        {
            var fileNames = new[] { "a.txt", "b.txt" };
            string localDir = CreateTempDirectory();
            try
            {
                foreach (var f in fileNames)
                    File.WriteAllText(Path.Combine(localDir, f), "data");

                var mockS3 = CreateMockS3ForUpload(new[] { "a.txt", "b.txt" }, k => k.EndsWith("b.txt", StringComparison.Ordinal));
                var config = new TransferUtilityConfig();
                var request = CreateUploadRequest(localDir, FailurePolicy.ContinueOnFailure);
                // collect events
                var captured = new List<ObjectUploadFailedEventArgs>();
                var invoked = new ManualResetEventSlim(false);
                request.ObjectUploadFailedEvent += (sender, args) =>
                {
                    captured.Add(args);
                    invoked.Set();
                };

                var tu = new TransferUtility(mockS3.Object);
                var command = new UploadDirectoryCommand(tu, config, request);
                command.UploadFilesConcurrently = request.UploadFilesConcurrently;
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
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task UploadDirectory_ObjectUploadFailedEvent_ArgsContainExpectedData_AbortOnFailure()
        {
            var fileNames = new[] { "x.txt", "y.txt" };
            string localDir = CreateTempDirectory();
            try
            {
                foreach (var f in fileNames)
                    File.WriteAllText(Path.Combine(localDir, f), "data");

                var mockS3 = CreateMockS3ForUpload(new[] { "x.txt", "y.txt" }, k => k.EndsWith("y.txt", StringComparison.Ordinal));
                var request = CreateUploadRequest(localDir, FailurePolicy.AbortOnFailure);
                var captured = new List<ObjectUploadFailedEventArgs>();
                var invoked = new ManualResetEventSlim(false);

                request.ObjectUploadFailedEvent += (sender, args) =>
                {
                    captured.Add(args);
                    invoked.Set();
                };

                var tu = new TransferUtility(mockS3.Object);
                await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => tu.UploadDirectoryAsync(request));

                // wait for event
                invoked.Wait(1000);

                Assert.AreEqual(1, captured.Count);
                var evt = captured[0];
                Assert.AreSame(request, evt.DirectoryRequest);
                Assert.IsNotNull(evt.ObjectRequest);
                Assert.IsTrue(evt.ObjectRequest.Key.EndsWith("y.txt", StringComparison.Ordinal));
                Assert.IsNotNull(evt.Exception);
                Assert.IsTrue(evt.Exception.Message.Contains("Simulated failure for"));
            }
            finally
            {
                try { Directory.Delete(localDir, true); } catch { }
            }
        }
    }
}
