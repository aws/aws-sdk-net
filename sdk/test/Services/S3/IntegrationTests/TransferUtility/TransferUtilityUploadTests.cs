using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityUploadTests : TransferUtilityTestBase
    {
        public TransferUtilityUploadTests(TransferUtilityFixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task SimpleUploadTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\SmallFile");
            await Upload(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, null);
        }

        [Fact]
        public async Task SimpleUploadProgressTest()
        {
            var context = SynchronizationContext.Current;
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\SmallFile");
            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                Validate = (p) =>
                {
                    Assert.Equal(p.FilePath, Path.Combine(_basePath, fileName));
                }
            };

            await Upload(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, progressValidator);
            await progressValidator.AssertOnCompletionAsync();
        }

        [Fact]
        public async Task SimpleUploadInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\InitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.True(args.TotalBytes > 0);
                    Assert.Equal(2 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task SimpleUploadCompletedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\CompletedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                    Assert.Equal(2 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.True(!string.IsNullOrEmpty(args.Response.ETag));
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task SimpleUploadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\FailedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.True(args.TotalBytes > 0);
                    Assert.Equal(1 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                    Assert.True(args.TransferredBytes <= args.TotalBytes);
                }
            };
            
            var invalidBucketName = "invalid-bucket-name-" + Guid.NewGuid().ToString();
            
            try
            {
                await UploadWithLifecycleEventsAndBucket(fileName, 1 * TransferUtilityTestHelpers.MEG_SIZE, invalidBucketName, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for invalid bucket");
            }
            catch (AmazonS3Exception)
            {
                eventValidator.AssertEventFired();
            }
        }

        [Fact]
        public async Task SimpleUploadCompleteLifecycleTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\CompleteLifecycle");
            var initiatedValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(2 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                    Assert.Equal(2 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 2 * TransferUtilityTestHelpers.MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [Fact]
        public async Task SimpleUpload()
        {
            await _transfer.UploadAsync(_fullPath, _bucketName);
            var response = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = testFile
            });
            Assert.True(response.ETag.Length > 0);

            var downloadPath = _fullPath + ".download";
            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                Key = testFile,
                FilePath = downloadPath
            };
            await _transfer.DownloadAsync(downloadRequest);
            TestDownloadedFile(downloadPath);

            // empty out file, except for 1 byte
            File.WriteAllText(downloadPath, testContent.Substring(0, 1));
            Assert.True(File.Exists(downloadPath));

            await _transfer.DownloadAsync(downloadRequest);
            TestDownloadedFile(downloadPath);
        }

        [Fact]
        public async Task SimpleUploadWithPrecalculatedChecksum()
        {
            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32Hash(File.ReadAllBytes(_fullPath));

            await _transfer.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = testFile,
                FilePath = _fullPath,
                ChecksumCRC32 = precalculatedChecksum,
            });
        }

        [Fact]
        public async Task LargeUploadWithPrecalculatedValues()
        {
            var fileName = UtilityMethods.GenerateName();
            var fullFilePath = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(fullFilePath, 20 * TransferUtilityTestHelpers.MEG_SIZE);

            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32CHash(File.ReadAllBytes(fullFilePath));
            var precalculatedObjectSize = new FileInfo(fullFilePath).Length;

            await _transfer.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = fileName,
                FilePath = fullFilePath,
                ChecksumCRC32C = precalculatedChecksum,
                MpuObjectSize = precalculatedObjectSize,
            });
        }

        [Theory]
        [InlineData(6, null, "SmallFile", false, false)]
        [InlineData(4, null, "SmallerThanMinPart", false, false)]
        [InlineData(5, null, "EqualToMinPartSize", false, false)]
        [InlineData(5, 8192, "EqualToPartBufferSize", false, false)]
        [InlineData(5, 1, "BetweenMinPartSizeAndPartBufferSize", false, false)]
        [InlineData(0, null, "EmptyFileFromDisk", false, false)]
        [InlineData(0, null, "EmptyStreamDirect", false, true)]
        [InlineData(6, null, "WithMetadataAndHeaders", true, false)]
        public async Task UploadUnseekableStreamTest(long sizeInMbs, int? padding, string name, bool includeHeaders, bool useZeroLengthConstructor)
        {
            var fileName = UtilityMethods.GenerateName(name);
            var path = Path.Combine(_basePath, fileName);

            var fileSize = sizeInMbs * TransferUtilityTestHelpers.MEG_SIZE;
            if (padding.HasValue)
            {
                fileSize += padding.Value;
            }

            Stream stream;
            if (useZeroLengthConstructor)
            {
                stream = new UnseekableStream(setZeroLengthStream: true);
            }
            else
            {
                UtilityMethods.GenerateFile(path, fileSize);
                stream = GenerateUnseekableStreamFromFile(path);
            }

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = fileName,
                InputStream = stream,
                PartSize = 5 * TransferUtilityTestHelpers.MEG_SIZE,
            };

            if (includeHeaders)
            {
                uploadRequest.Metadata.Add("testmetadata", "testmetadatavalue");
                uploadRequest.Headers["Content-Disposition"] = "attachment; filename=\"" + fileName + "\"";
            }

            await _transfer.UploadAsync(uploadRequest);

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = fileName
            });
            Assert.Equal(fileSize, metadata.ContentLength);

            if (includeHeaders)
            {
                Assert.True(metadata.Metadata.Count > 0);
                Assert.Equal("testmetadatavalue", metadata.Metadata["testmetadata"]);
                Assert.True(metadata.Headers.Count > 0);
                Assert.Equal("attachment; filename=\"" + fileName + "\"", metadata.Headers["Content-Disposition"]);
            }

            if (fileSize > 0)
            {
                var downloadPath = path + ".download";
                await _transfer.DownloadAsync(new TransferUtilityDownloadRequest
                {
                    BucketName = _bucketName,
                    Key = fileName,
                    FilePath = downloadPath
                });
                UtilityMethods.CompareFiles(path, downloadPath);
            }
        }

        [Fact]
        public async Task SimpleUploadProgressTotalBytesTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadProgressTotalBytes\TestFile");
            var filePath = Path.Combine(_basePath, fileName);
            var fileSize = 2 * TransferUtilityTestHelpers.MEG_SIZE;
            UtilityMethods.GenerateFile(filePath, fileSize);

            var progressValidator = new TransferProgressValidator<UploadProgressArgs>
            {
                Validate = (progress) =>
                {
                    Assert.True(progress.TotalBytes > 0, "TotalBytes should be greater than 0");
                    Assert.Equal(fileSize, progress.TotalBytes);
                    Assert.Equal(filePath, progress.FilePath);
                }
            };

            var transferConfig = new TransferUtilityConfig
            {
                MinSizeBeforePartUpload = 20 * TransferUtilityTestHelpers.MEG_SIZE,
            };

            using (var fileTransferUtility = new TransferUtility(_client, transferConfig))
            {
                var request = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    FilePath = filePath,
                    Key = fileName
                };

                request.UploadProgressEvent += progressValidator.OnProgressEvent;
                await fileTransferUtility.UploadAsync(request);
                await progressValidator.AssertOnCompletionAsync();
            }
        }

        [Fact]
        public async Task UploadAsyncCancellationTest()
        {
            var fileName = UtilityMethods.GenerateName(@"SimpleUploadTest\CancellationTest");
            var path = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(path, 10 * TransferUtilityTestHelpers.MEG_SIZE);

            TransferUtilityUploadRequest uploadRequest = new TransferUtilityUploadRequest()
            {
                BucketName = _bucketName,
                Key = fileName,
                FilePath = path
            };

            var tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Task uploadTask = null;
            try
            {
                uploadTask = _transfer.UploadAsync(uploadRequest, token);
                tokenSource.CancelAfter(100);
                await uploadTask;
            }
            catch (OperationCanceledException)
            {
                Assert.True(uploadTask.IsCanceled);
                return;
            }
            Assert.Fail("An OperationCanceledException was not thrown.");
        }
    }
}
