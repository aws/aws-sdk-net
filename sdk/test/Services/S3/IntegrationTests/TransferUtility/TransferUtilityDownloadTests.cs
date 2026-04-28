using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityDownloadTests : TransferUtilityTestBase
    {
        public TransferUtilityDownloadTests(TransferUtilityFixture fixture) : base(fixture)
        {
        }

        [Fact(Skip = "Pending fix from https://github.com/aws/aws-sdk-net/pull/4196 to be applied to non-MPU uploads")]
        public async Task DownloadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName(@"DownloadTest\File");
            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.Equal(p.BucketName, _bucketName);
                    Assert.Equal(p.Key, fileName);
                    Assert.NotNull(p.FilePath);
                    Assert.True(p.FilePath.Contains(fileName));
                }
            };

            await Download(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, progressValidator);
            await progressValidator.AssertOnCompletionAsync();
        }

        [Fact]
        public async Task DownloadProgressZeroLengthFileTest()
        {
            var fileName = UtilityMethods.GenerateName(@"DownloadTest\File");
            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.Equal(p.BucketName, _bucketName);
                    Assert.Equal(p.Key, fileName);
                    Assert.NotNull(p.FilePath);
                    Assert.True(p.FilePath.Contains(fileName));
                    Assert.Equal(p.TotalBytes, 0);
                    Assert.Equal(p.TransferredBytes, 0);
                    Assert.Equal(p.PercentDone, 100);
                }
            };

            await Download(fileName, 0, progressValidator);
            await progressValidator.AssertOnCompletionAsync();
        }

        [Fact]
        public async Task SimpleDownloadInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\InitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<DownloadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName + ".download"));
                }
            };
            
            await DownloadWithLifecycleEvents(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task SimpleDownloadCompletedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\CompletedEvent");
            var eventValidator = new TransferLifecycleEventValidator<DownloadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                    Assert.Equal(2 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.True(!string.IsNullOrEmpty(args.Response.ETag));
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName + ".download"));
                }
            };

            await DownloadWithLifecycleEvents(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task SimpleDownloadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\FailedEvent");
            var eventValidator = new TransferLifecycleEventValidator<DownloadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName + ".download"));
                    Assert.Equal(-1, args.TotalBytes);
                    Assert.Equal(0, args.TransferredBytes);
                }
            };
            
            var nonExistentKey = "non-existent-key-" + Guid.NewGuid().ToString();
            
            try
            {
                await DownloadWithLifecycleEventsAndKey(fileName, nonExistentKey, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for non-existent key");
            }
            catch (AmazonS3Exception)
            {
                eventValidator.AssertEventFired();
            }
        }

        [Fact]
        public async Task SimpleDownloadCompleteLifecycleTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleDownloadTest\CompleteLifecycle");
            var initiatedValidator = new TransferLifecycleEventValidator<DownloadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName + ".download"));
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<DownloadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                    Assert.Equal(2 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName + ".download"));
                }
            };

            await DownloadWithLifecycleEvents(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [Fact]
        public async Task MultipartDownloadProgressTest()
        {
            var fileName = UtilityMethods.GenerateName("MultipartDownloadProgress");
            var originalFilePath = Path.Combine(_basePath, fileName);
            var downloadedFilePath = originalFilePath + ".dn";
            
            UtilityMethods.GenerateFile(originalFilePath, 20 * TransferUtilityTestHelpers.MEG_SIZE);
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = fileName,
                FilePath = originalFilePath
            });

            int inProgressEventCount = 0;
            int completedEventCount = 0;
            long lastTransferredBytes = 0;

            var progressValidator = new TransferProgressValidator<WriteObjectProgressArgs>
            {
                ValidateProgressInterval = true,
                Validate = (p) =>
                {
                    Assert.Equal(_bucketName, p.BucketName);
                    Assert.Equal(fileName, p.Key);
                    Assert.NotNull(p.FilePath);
                    Assert.True(p.TransferredBytes >= lastTransferredBytes);
                    
                    if (p.IsCompleted)
                    {
                        completedEventCount++;
                        Assert.Equal(p.TotalBytes, p.TransferredBytes);
                    }
                    else
                    {
                        inProgressEventCount++;
                        Assert.True(p.TransferredBytes < p.TotalBytes);
                    }
                    
                    lastTransferredBytes = p.TransferredBytes;
                }
            };

            var request = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                FilePath = downloadedFilePath,
                Key = fileName
            };
            request.WriteObjectProgressEvent += progressValidator.OnProgressEvent;

            var response = await _transfer.DownloadWithResponseAsync(request);
            Assert.NotNull(response);

            await progressValidator.AssertOnCompletionAsync();
            
            Assert.True(inProgressEventCount > 0, $"Expected in-progress events to fire during multipart download, but got {inProgressEventCount}");
            Assert.Equal(1, completedEventCount);
            UtilityMethods.CompareFiles(originalFilePath, downloadedFilePath);
        }

        [Fact]
        public async Task MultipartDownloadInitiatedCompletedEventsTest()
        {
            var fileName = UtilityMethods.GenerateName("MultipartDownloadEvents");
            var originalFilePath = Path.Combine(_basePath, fileName);
            var downloadedFilePath = originalFilePath + ".dn";
            long expectedSize = 20 * TransferUtilityTestHelpers.MEG_SIZE;
            
            UtilityMethods.GenerateFile(originalFilePath, expectedSize);
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = fileName,
                FilePath = originalFilePath
            });

            bool initiatedEventFired = false;
            bool completedEventFired = false;
            
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                FilePath = downloadedFilePath,
                Key = fileName
            };
            
            request.DownloadInitiatedEvent += (s, e) =>
            {
                Assert.False(initiatedEventFired, "Initiated event should fire only once");
                initiatedEventFired = true;
                Assert.Equal(fileName, e.Request.Key);
            };
            
            request.DownloadCompletedEvent += (s, e) =>
            {
                Assert.False(completedEventFired, "Completed event should fire only once");
                completedEventFired = true;
                Assert.Equal(expectedSize, e.TotalBytes);
                Assert.Equal(expectedSize, e.TransferredBytes);
            };

            var response = await _transfer.DownloadWithResponseAsync(request);
            Assert.NotNull(response);

            Assert.True(initiatedEventFired, "Initiated event should have fired");
            Assert.True(completedEventFired, "Completed event should have fired");
        }

        [Fact]
        public async Task MultipartDownloadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName("MultipartDownloadFailed");
            var downloadedFilePath = Path.Combine(_basePath, fileName + ".dn");
            bool failedEventFired = false;
            
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                FilePath = downloadedFilePath,
                Key = "non-existent-key-" + Guid.NewGuid()
            };
            
            request.DownloadFailedEvent += (s, e) =>
            {
                failedEventFired = true;
                Assert.NotNull(e.FilePath);
            };

            try
            {
                await _transfer.DownloadWithResponseAsync(request);

                Assert.Fail("Expected an exception to be thrown for non-existent key");
            }
            catch (AmazonS3Exception)
            {
                Assert.True(failedEventFired, "Failed event should have fired");
            }
        }

        [Fact]
        public async Task OpenStreamTest()
        {
            var fileName = UtilityMethods.GenerateName(@"OpenStreamTest\File");
            var key = fileName;
            var originalFilePath = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(originalFilePath, 2 * TransferUtilityTestHelpers.MEG_SIZE);

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = originalFilePath
            });

            var stream = await _transfer.OpenStreamAsync(_bucketName, key);
            Assert.NotNull(stream);
            Assert.True(stream.CanRead);
            stream.Close();
        }

        /// <summary>
        /// Partial download resumption support can erroneously trigger retry with
        /// byte range of 0 to Long.MaxValue if a zero length object is the first object
        /// to be download to a new folder path - S3 then yields an invalid byte range 
        /// error on the retry.
        /// Test ensures the fix, to test that the folder path exists before trying to
        /// access it, so we don't trigger a retry.
        /// </summary>
        [Fact]
        public async Task TestZeroLengthDownloadToNonExistingPath()
        {
            var objectKey = "folder1/folder2/empty_file.txt";
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = objectKey,
                ContentBody = ""
            });

            var filename = UtilityMethods.GenerateName(objectKey.Replace('/', '\\'));
            var filePath = Path.Combine(_basePath, filename);

            await _transfer.DownloadAsync(new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                FilePath = filePath,
                Key = objectKey
            });

            Assert.True(File.Exists(filePath));
        }
    }
}
