using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class MetadataTests : TestBase<AmazonS3Client>
    {
        private readonly Random random = new Random();
        private static string bucketName;
        private const string tempFile = "tempFile.txt";
        private static readonly long smallFileSize = TransferUtilityTests.KILO_SIZE * 100;
        private static readonly long largeFileSize = TransferUtilityTests.MEG_SIZE * 20;
        private static readonly List<string> keysToValidate = new List<string>();

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

        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            await Client.PutBucketVersioningAsync(new PutBucketVersioningRequest 
            {
                BucketName = bucketName ,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        public async Task TestSingleUploads()
        {
            var key = "contentBodyPut" + random.Next();
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };

            SetMetadataAndHeaders(putObjectRequest);
            await Client.PutObjectAsync(putObjectRequest);
            await ValidateObjectMetadataAndHeaders(key);

            using (var tu = new TransferUtility(Client))
            {
                // Test small TransferUtility upload
                key = "transferUtilitySmall" + random.Next();
                UtilityMethods.GenerateFile(tempFile, smallFileSize);
                var smallRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
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
                    key = "transferUtilityLarge" + random.Next();
                    UtilityMethods.GenerateFile(tempFile, largeFileSize);
                    var largeRequest = new TransferUtilityUploadRequest
                    {
                        BucketName = bucketName,
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
        [TestMethod]
        public async Task TestSingleUploadWithUnicodeMetadata()
        {
            try
            {
                AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = true;

                var key = "contentBodyPut" + random.Next();
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = "This is the content body!",
                };

                SetMetadataAndHeaders(putObjectRequest, true);
                await Client.PutObjectAsync(putObjectRequest);
                await ValidateObjectMetadataAndHeaders(key, true);
            }
            finally
            {
                AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = false;
            }
        }

        [TestMethod]
        public async Task TestDirectoryUploads()
        {
            var progressValidator = new TransferUtilityTests.DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            TransferUtilityTests.ConfigureProgressValidator(progressValidator);

            keysToValidate.Clear();
            await UploadDirectory(10 * TransferUtilityTests.MEG_SIZE, progressValidator, validate: true);
            progressValidator.AssertOnCompletion();

            foreach (var key in keysToValidate)
            {
                await ValidateObjectMetadataAndHeaders(key);
            }
        }

        [TestMethod]
        public async Task TestSingleUploadWithSpacesInMetadata()
        {
            string metadataName = "document";
            string metadataValue = " A  B  C  ";
            var key = "contentBodyPut" + random.Next();

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };
            putObjectRequest.Metadata[metadataName] = metadataValue;
            await Client.PutObjectAsync(putObjectRequest);

            using (var response = await Client.GetObjectAsync(bucketName, key))
            {
                Assert.AreEqual(metadataValue.Trim(), response.Metadata[metadataName]);
            }

            using (var tu = new TransferUtility(Client))
            {
                // Test small TransferUtility upload
                key = "transferUtilitySmall" + random.Next();
                UtilityMethods.GenerateFile(tempFile, smallFileSize);
                var smallRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    FilePath = tempFile
                };
                smallRequest.Metadata[metadataName] = metadataValue;
                await tu.UploadAsync(smallRequest);
                
                using (var response = await Client.GetObjectAsync(bucketName, key))
                {
                    Assert.AreEqual(metadataValue.Trim(), response.Metadata[metadataName]);
                }

                // Test large TransferUtility upload
                // disable clock skew testing, this is a multithreaded operation
                using (RetryUtilities.DisableClockSkewCorrection())
                {
                    key = "transferUtilityLarge" + random.Next();
                    UtilityMethods.GenerateFile(tempFile, largeFileSize);
                    var largeRequest = new TransferUtilityUploadRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        FilePath = tempFile
                    };
                    largeRequest.Metadata[metadataName] = metadataValue;
                    await tu.UploadAsync(largeRequest);
                    
                    using (var response = await Client.GetObjectAsync(bucketName, key))
                    {
                        Assert.AreEqual(metadataValue.Trim(), response.Metadata[metadataName]);
                    }
                }
            }
        }

        [TestMethod]
        public async Task GetObjectMetadataTest()
        {
            string key = Guid.NewGuid().ToString() + ".txt";
            var putObjectResponse = await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "Hello world!",
            });

            var responseExpires = DateTime.UtcNow.AddDays(2);
            var getObjectMetadataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = bucketName,
                Key = key,
                ResponseExpires = responseExpires,
                ResponseContentType = "text/plain",
                VersionId = putObjectResponse.VersionId,
            });
            Assert.AreEqual(HttpStatusCode.OK, getObjectMetadataResponse.HttpStatusCode);
            Assert.IsFalse(string.IsNullOrEmpty(getObjectMetadataResponse.ExpiresString));

            var actualExpires = DateTime.Parse(getObjectMetadataResponse.ExpiresString).ToUniversalTime();
            Assert.AreEqual(responseExpires.Date, actualExpires.Date);
            Assert.IsFalse(string.IsNullOrEmpty(getObjectMetadataResponse.VersionId));
        }
        
        async Task UploadDirectory(
            long size,
            TransferUtilityTests.DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, 
            bool validate = true
        )
        {
            var directory = TransferUtilityTests.CreateTestDirectory(size);
            var directoryPath = directory.FullName;
            var keyPrefix = directory.Name;

            var transferUtility = new TransferUtility(Client, new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            });

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
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
            Assert.AreEqual(5, files.Count);

            if (validate)
            {
                TransferUtilityTests.ValidateDirectoryContents(Client, bucketName, keyPrefix, directory);
            }
        }

        private static async Task ValidateObjectMetadataAndHeaders(string key, bool unicode = false)
        {
            using (var response = await Client.GetObjectAsync(bucketName, key))
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
                Assert.AreEqual(expectedValue, actualValue);
            }

            foreach (var kvp in headers)
            {
                var name = kvp.Key;
                var expectedValue = (kvp.Value == null) ? "" : kvp.Value;
                var actualValue = response.Headers[name];
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
