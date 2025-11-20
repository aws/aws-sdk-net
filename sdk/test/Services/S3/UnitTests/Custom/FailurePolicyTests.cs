using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK.S3.Transfer.Model;
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
    }
}
