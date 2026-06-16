using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class MetadataTests : IClassFixture<S3BucketFixture>, IAsyncLifetime
    {
        private const string tempFile = "tempFile.txt";
        private static readonly long smallFileSize = TransferUtilityTestHelpers.KILO_SIZE * 100;
        private static readonly long largeFileSize = TransferUtilityTestHelpers.MEG_SIZE * 6;

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        private static readonly Dictionary<string, string> metadata = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "date", DateTime.UtcNow.ToFileTime().ToString() },
            { "test", "true" },
            { "null-value", null },
            { "aaa", "aaa" },
            { "a-a-a", "adada" },
            { "a|a|a", "apapa" },
            { "a^a^a", "acaca" },
            { "a_a_a", "apapa" },
            { "a~a~a", "apapa" }
        };
        private static readonly Dictionary<string, string> unicodeMetadata = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "test", "test" },
            { "test2", "£" },
            { "test3", "no non ascii characters %" },
            { "test4", "1 non ascii character £ %" }
        };
        private static readonly Dictionary<string, string> headers = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "Content-Type", "text/html" },
            { "Content-Disposition", "attachment; filename=\"fname.ext\"" }
        };

        public MetadataTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
            _testId = Guid.NewGuid().ToString("N");
        }

        public async ValueTask InitializeAsync()
        {
            // Enable versioning once for the class-level bucket
            await _client.PutBucketVersioningAsync(new PutBucketVersioningRequest
            {
                BucketName = _bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });
        }

        public ValueTask DisposeAsync() => new ValueTask();

        [Fact]
        public async Task TestSingleUploads()
        {
            var key = _testId + "-contentBodyPut";
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };

            SetMetadataAndHeaders(putObjectRequest);
            await _client.PutObjectAsync(putObjectRequest);
            await ValidateObjectMetadataAndHeaders(key);

            using (var tu = new TransferUtility(_client, new TransferUtilityConfig { MinSizeBeforePartUpload = 5_000_000 }))
            {
                // Test small TransferUtility upload
                key = _testId + "-transferUtilitySmall";
                UtilityMethods.GenerateFile(tempFile, smallFileSize);
                var smallRequest = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    FilePath = tempFile
                };
                SetMetadataAndHeaders(smallRequest);
                await tu.UploadAsync(smallRequest);
                await ValidateObjectMetadataAndHeaders(key);

                // Test large TransferUtility upload
                // disable clock skew testing, this is a multithreaded operation
                using (RetryUtilities.DisableClockSkewCorrection())
                {
                    key = _testId + "-transferUtilityLarge";
                    UtilityMethods.GenerateFile(tempFile, largeFileSize);
                    var largeRequest = new TransferUtilityUploadRequest
                    {
                        BucketName = _bucketName,
                        Key = key,
                        FilePath = tempFile
                    };
                    SetMetadataAndHeaders(largeRequest);
                    
                    await tu.UploadAsync(largeRequest);
                    await ValidateObjectMetadataAndHeaders(key);
                }
            }
        }

        /// <summary>
        /// Ensure that when escaped, a SigV4 request with unicode metadata succeeds.
        /// </summary>
        [Fact]
        public async Task TestSingleUploadWithUnicodeMetadata()
        {
            try
            {
                AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = true;

                var key = _testId + "-contentBodyPut";
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    ContentBody = "This is the content body!",
                };

                SetMetadataAndHeaders(putObjectRequest, true);
                await _client.PutObjectAsync(putObjectRequest);
                await ValidateObjectMetadataAndHeaders(key, true);
            }
            finally
            {
                AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = false;
            }
        }

        [Fact]
        public async Task TestDirectoryUploads()
        {
            var progressValidator = new DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            TransferUtilityTestHelpers.ConfigureProgressValidator(progressValidator);

            var keysToValidate = new List<string>();
            await UploadDirectory(1 * TransferUtilityTestHelpers.MEG_SIZE, progressValidator, keysToValidate, validate: true);
            await progressValidator.AssertOnCompletionAsync();

            foreach (var key in keysToValidate)
            {
                await ValidateObjectMetadataAndHeaders(key);
            }
        }

        [Fact]
        public async Task TestSingleUploadWithSpacesInMetadata()
        {
            string metadataName = "document";
            string metadataValue = " A  B  C  ";
            var key = _testId + "-contentBodyPut";

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };
            putObjectRequest.Metadata[metadataName] = metadataValue;
            await _client.PutObjectAsync(putObjectRequest);

            using (var response = await _client.GetObjectAsync(_bucketName, key))
            {
                Assert.Equal(metadataValue.Trim(), response.Metadata[metadataName]);
            }

            using (var tu = new TransferUtility(_client, new TransferUtilityConfig { MinSizeBeforePartUpload = 5_000_000 }))
            {
                // Test small TransferUtility upload
                key = _testId + "-transferUtilitySmall";
                UtilityMethods.GenerateFile(tempFile, smallFileSize);
                var smallRequest = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    FilePath = tempFile
                };
                smallRequest.Metadata[metadataName] = metadataValue;
                await tu.UploadAsync(smallRequest);
                
                using (var response = await _client.GetObjectAsync(_bucketName, key))
                {
                    Assert.Equal(metadataValue.Trim(), response.Metadata[metadataName]);
                }

                // Test large TransferUtility upload
                // disable clock skew testing, this is a multithreaded operation
                using (RetryUtilities.DisableClockSkewCorrection())
                {
                    key = _testId + "-transferUtilityLarge";
                    UtilityMethods.GenerateFile(tempFile, largeFileSize);
                    var largeRequest = new TransferUtilityUploadRequest
                    {
                        BucketName = _bucketName,
                        Key = key,
                        FilePath = tempFile
                    };
                    largeRequest.Metadata[metadataName] = metadataValue;
                    await tu.UploadAsync(largeRequest);
                    
                    using (var response = await _client.GetObjectAsync(_bucketName, key))
                    {
                        Assert.Equal(metadataValue.Trim(), response.Metadata[metadataName]);
                    }
                }
            }
        }

        [Fact]
        public async Task GetObjectMetadataTest()
        {
            string key = _testId + "-" + Guid.NewGuid().ToString() + ".txt";
            var putObjectResponse = await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = "Hello world!",
            });

            var responseExpires = DateTime.UtcNow.AddDays(2);
            var getObjectMetadataResponse = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key,
                ResponseExpires = responseExpires,
                ResponseContentType = "text/plain",
                VersionId = putObjectResponse.VersionId,
            });
            Assert.Equal(HttpStatusCode.OK, getObjectMetadataResponse.HttpStatusCode);
            Assert.False(string.IsNullOrEmpty(getObjectMetadataResponse.ExpiresString));

            var actualExpires = DateTime.Parse(getObjectMetadataResponse.ExpiresString).ToUniversalTime();
            Assert.Equal(responseExpires.Date, actualExpires.Date);
            Assert.False(string.IsNullOrEmpty(getObjectMetadataResponse.VersionId));
        }
        
        async Task UploadDirectory(
            long size,
            DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator,
            List<string> keysToValidate,
            bool validate = true
        )
        {
            var directory = TransferUtilityTestHelpers.CreateTestDirectory(size);
            var directoryPath = directory.FullName;
            var keyPrefix = directory.Name;

            var transferUtility = new TransferUtility(_client, new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            });

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = directoryPath,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
            };

            if (progressValidator != null)
            {
                request.UploadDirectoryProgressEvent += progressValidator.OnProgressEvent;
            }

            var files = new HashSet<string>();
            request.UploadDirectoryProgressEvent += (s, e) =>
            {
                files.Add(e.CurrentFile);
                Console.WriteLine("Progress callback = " + e.ToString());
            };

            request.UploadDirectoryFileRequestEvent += (s, e) =>
            {
                var uploadRequest = e.UploadRequest;
                var key = uploadRequest.Key;
                keysToValidate.Add(key);
                SetMetadataAndHeaders(uploadRequest);
            };

            await transferUtility.UploadDirectoryAsync(request);
            Assert.Equal(5, files.Count);

            if (validate)
            {
                await TransferUtilityTestHelpers.ValidateDirectoryContents(_bucketName, keyPrefix, directory);
            }
        }

        private async Task ValidateObjectMetadataAndHeaders(string key, bool unicode = false)
        {
            using (var response = await _client.GetObjectAsync(_bucketName, key))
            {
                ValidateMetadataAndHeaders(response, unicode);
            }
        }

        private static void SetMetadataAndHeaders(TransferUtilityUploadRequest request)
        {
            SetMetadata(request.Metadata);
            SetHeaders(request.Headers);
        }

        private static void SetMetadataAndHeaders(PutObjectRequest request, bool unicode = false)
        {
            SetMetadata(request.Metadata, unicode);
            SetHeaders(request.Headers);
        }

        private static void SetMetadata(MetadataCollection mc, bool unicode = false)
        {
            foreach (var kvp in unicode ? unicodeMetadata : metadata)
            {
                mc[kvp.Key] = kvp.Value;
            }
        }
        
        private static void SetHeaders(HeadersCollection hc)
        {
            foreach (var kvp in headers)
            {
                hc[kvp.Key] = kvp.Value;
            }
        }

        private static void ValidateMetadataAndHeaders(GetObjectResponse response, bool unicode = false)
        {
            foreach (var kvp in unicode ? unicodeMetadata : metadata)
            {
                var name = kvp.Key;
                var expectedValue = kvp.Value ?? "";   // putting a null value comes back as an empty string
                var actualValue = response.Metadata[name];
                Assert.Equal(expectedValue, actualValue);
            }

            foreach (var kvp in headers)
            {
                var name = kvp.Key;
                var expectedValue = (kvp.Value == null) ? "" : kvp.Value;
                var actualValue = response.Headers[name];
                Assert.Equal(expectedValue, actualValue);
            }
        }
    }
}
