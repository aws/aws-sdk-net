using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon.S3.Transfer;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class MetadataTests : TestBase<AmazonS3Client>
    {
        private Random random = new Random();
        private static string bucketName;
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
        private const string tempFile = "tempFile.txt";
        private static long smallFileSize = TransferUtilityTests.KILO_SIZE * 100;
        private static long largeFileSize = TransferUtilityTests.MEG_SIZE * 20;
        private static string basePath = Path.GetFullPath(@"\transferutility\");

        private static List<string> keysToValidate = new List<string>();

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            if (Directory.Exists(basePath))
                Directory.Delete(basePath, true);

            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSingleUploads()
        {
            TestSingleUploadsHelper(Client);
        }

        public void TestSingleUploadsHelper(AmazonS3Client client)
        {
            // Test simple PutObject upload
            var key = "contentBodyPut" + random.Next();
            PutObjectRequest putObjectRequest = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };

            SetMetadataAndHeaders(putObjectRequest);
            client.PutObject(putObjectRequest);
            ValidateObjectMetadataAndHeaders(key);

            using (var tu = new TransferUtility(client))
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
                tu.Upload(smallRequest);
                ValidateObjectMetadataAndHeaders(key);

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
                    tu.Upload(largeRequest);
                    ValidateObjectMetadataAndHeaders(key);
                }
            }
        }

        /// <summary>
        /// Ensure that when escaped, a SigV4 request with unicode metadata succeeds.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestSingleUploadWithUnicodeMetadata()
        {
            TestSingleUploadWithUnicodeMetadataHelper(Client);
        }

        public void TestSingleUploadWithUnicodeMetadataHelper(AmazonS3Client client)
        {
            // Test simple PutObject upload
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = true;
            var key = "contentBodyPut" + random.Next();
            PutObjectRequest putObjectRequest = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };
            GetObjectRequest getObjectRequest = new GetObjectRequest()
            {
                BucketName = bucketName,
                Key = key
            };

            SetMetadataAndHeaders(putObjectRequest, true);
            client.PutObject(putObjectRequest);
            ValidateObjectMetadataAndHeaders(key, true);
            AWSConfigsS3.EnableUnicodeEncodingForObjectMetadata = false;
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestDirectoryUploads()
        {
            var progressValidator = new TransferUtilityTests.DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            TransferUtilityTests.ConfigureProgressValidator(progressValidator);

            keysToValidate.Clear();
            UploadDirectory(10 * TransferUtilityTests.MEG_SIZE, progressValidator, validate: true);
            progressValidator.AssertOnCompletion();

            foreach (var key in keysToValidate)
                ValidateObjectMetadataAndHeaders(key);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestSingleUploadWithSpacesInMetadata()
        {
            string metadataName = "document";
            string metadataValue = " A  B  C  ";
            // Test simple PutObject upload
            var key = "contentBodyPut" + random.Next();
            PutObjectRequest putObjectRequest = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };

            putObjectRequest.Metadata[metadataName] = metadataValue;

            Client.PutObject(putObjectRequest);
            using (var response = Client.GetObject(bucketName, key)) // Validate metadata
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

                tu.Upload(smallRequest);
                using (var response = Client.GetObject(bucketName, key)) // Validate metadata
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

                    tu.Upload(largeRequest);
                    using (var response = Client.GetObject(bucketName, key)) // Validate metadata
                    {
                        Assert.AreEqual(metadataValue.Trim(), response.Metadata[metadataName]);
                    }
                }
            }
        }

        void UploadDirectory(long size,
            TransferUtilityTests.DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, bool validate = true)
        {
            var directory = TransferUtilityTests.CreateTestDirectory(size);
            var directoryPath = directory.FullName;
            var keyPrefix = directory.Name;

            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            };
            var transferUtility = new TransferUtility(Client, config);
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

            HashSet<string> files = new HashSet<string>();
            request.UploadDirectoryProgressEvent += (s, e) =>
            {
                files.Add(e.CurrentFile);
                Console.WriteLine("Progress callback = " + e.ToString());
            };
            request.UploadDirectoryFileRequestEvent += (s, e) =>
            {
                var uploadRequest =e.UploadRequest;
                var key = uploadRequest.Key;
                keysToValidate.Add(key);
                SetMetadataAndHeaders(uploadRequest);
            };

            transferUtility.UploadDirectory(request);

            Assert.AreEqual(5, files.Count);

            if (validate)
                TransferUtilityTests.ValidateDirectoryContents(Client, bucketName, keyPrefix, directory);
        }

        private static void ValidateObjectMetadataAndHeaders(string key, bool unicode = false)
        {
            using (var response = Client.GetObject(bucketName, key))
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
                mc[kvp.Key] = kvp.Value;
        }
        private static void SetHeaders(HeadersCollection hc)
        {
            foreach (var kvp in headers)
                hc[kvp.Key] = kvp.Value;
        }
        private static void ValidateMetadataAndHeaders(GetObjectResponse response, bool unicode = false)
        {
            foreach (var kvp in unicode ? unicodeMetadata : metadata)
            {
                var name = kvp.Key;
                var expectedValue = (kvp.Value == null) ? "" : kvp.Value;   // putting a null value comes back as an empty string
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
