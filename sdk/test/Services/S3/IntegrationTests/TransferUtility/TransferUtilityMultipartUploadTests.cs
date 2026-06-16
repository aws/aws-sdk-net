using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityMultipartUploadTests : TransferUtilityTestBase
    {
        public TransferUtilityMultipartUploadTests(TransferUtilityFixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task MultipartUploadProgressTest()
        {
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\File");
                var progressValidator = new TransferProgressValidator<UploadProgressArgs>
                {
                    ValidateProgressInterval = false,
                    Validate = (p) =>
                    {
                        Assert.Equal(p.FilePath, Path.Combine(_basePath, fileName));
                    }
                };

                await Upload(fileName, 17 * TransferUtilityTestHelpers.MEG_SIZE, progressValidator);
                await progressValidator.AssertOnCompletionAsync();
            }
        }

        [Fact]
        public async Task MultipartUploadInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\InitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.True(args.TotalBytes > 0);
                    Assert.Equal(17 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 17 * TransferUtilityTestHelpers.MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task MultipartUploadCompletedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\CompletedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                    Assert.Equal(17 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.True(!string.IsNullOrEmpty(args.Response.ETag));
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 17 * TransferUtilityTestHelpers.MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task MultipartUploadFailedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\FailedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.True(args.TotalBytes > 0);
                    Assert.Equal(17 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                    Assert.True(args.TransferredBytes <= args.TotalBytes);
                }
            };
            
            var invalidBucketName = "invalid-bucket-name-" + Guid.NewGuid().ToString();
            
            try
            {
                await UploadWithLifecycleEventsAndBucket(fileName, 17 * TransferUtilityTestHelpers.MEG_SIZE, invalidBucketName, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for invalid bucket");
            }
            catch (AmazonS3Exception)
            {
                eventValidator.AssertEventFired();
            }
        }

        [Fact]
        public async Task MultipartUploadCompleteLifecycleTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\CompleteLifecycle");
            var initiatedValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(17 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
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
                    Assert.Equal(17 * TransferUtilityTestHelpers.MEG_SIZE, args.TotalBytes);
                    Assert.Equal(args.FilePath, Path.Combine(_basePath, fileName));
                }
            };

            await UploadWithLifecycleEvents(fileName, 17 * TransferUtilityTestHelpers.MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [Fact]
        public async Task MultipartUploadUnseekableStreamInitiatedEventTest()
        {
            var fileName = UtilityMethods.GenerateName(@"MultipartUploadTest\UnseekableStreamInitiatedEvent");
            var eventValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(-1, args.TotalBytes);
                }
            };

            await UploadUnseekableStreamWithLifecycleEvents(6 * TransferUtilityTestHelpers.MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task MultipartUploadUnseekableStreamCompletedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(-1, args.TotalBytes);
                    Assert.Equal(0, args.TransferredBytes);
                }
            };

            await UploadUnseekableStreamWithLifecycleEvents(6 * TransferUtilityTestHelpers.MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task MultipartUploadUnseekableStreamFailedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(-1, args.TotalBytes);
                }
            };
            
            var invalidBucketName = "invalid-bucket-name-" + Guid.NewGuid().ToString();
            
            try
            {
                await UploadUnseekableStreamWithLifecycleEventsAndBucket(6 * TransferUtilityTestHelpers.MEG_SIZE, invalidBucketName, null, null, eventValidator);
                Assert.Fail("Expected an exception to be thrown for invalid bucket");
            }
            catch (AmazonS3Exception)
            {
                eventValidator.AssertEventFired();
            }
        }

        [Fact]
        public async Task MultipartUploadUnseekableStreamCompleteLifecycleTest()
        {            
            var initiatedValidator = new TransferLifecycleEventValidator<UploadInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(-1, args.TotalBytes);
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<UploadCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(-1, args.TotalBytes);
                    Assert.Equal(0, args.TransferredBytes);
                }
            };

            await UploadUnseekableStreamWithLifecycleEvents(6 * TransferUtilityTestHelpers.MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        [Fact]
        public async Task MultipartGetNumberTest()
        {
            string key = _testId + "-SomeTest";
            await Upload(key, 17 * TransferUtilityTestHelpers.MEG_SIZE, null);

            try
            {
                var objectMetadataResponse = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    PartNumber = 1,
                });
                Assert.True(objectMetadataResponse.PartsCount > 1);

                int? count = objectMetadataResponse.PartsCount;
                for (int i = 1; i <= count; i++)
                {
                    var objectResponse = await _client.GetObjectAsync(new GetObjectRequest
                    {
                        BucketName = _bucketName,
                        Key = key,
                        PartNumber = i
                    });
                    Assert.Equal(objectResponse.PartsCount, count);
                }
            }
            finally
            {
                await _client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key
                });
            }
        }

        [Fact]
        public async Task MultipartValidatePartSize8MbTest()
        {
            string key = _testId + "-MultipartValidatePartSizeTest";
            await Upload(key, 17 * TransferUtilityTestHelpers.MEG_SIZE, null);
            
            var objectMetadataResponse = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key,
                PartNumber = 1,
            });
            Assert.Equal(3, objectMetadataResponse.PartsCount);
            Assert.Equal(8 * TransferUtilityTestHelpers.MEG_SIZE, objectMetadataResponse.ContentLength);
        }

        [Fact]
        public async Task TestMultipartUploadWithSetContentTypeNotOverwritten()
        {
            var fileName = UtilityMethods.GenerateName(@"SetContentType");
            var path = Path.Combine(_basePath, fileName);
            UtilityMethods.GenerateFile(path, 17 * TransferUtilityTestHelpers.MEG_SIZE);

            await _transfer.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = "test-content-type",
                ContentType = MediaTypeNames.Text.Plain,
                Headers =
                {
                    ContentEncoding = "gzip",
                },
            });

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            { 
                BucketName = _bucketName,
                Key = "test-content-type" 
            });
            Assert.Equal(MediaTypeNames.Text.Plain, metadata.Headers.ContentType);
        }
    }
}
