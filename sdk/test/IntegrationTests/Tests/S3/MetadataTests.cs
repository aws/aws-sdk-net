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
            { "date", DateTime.Now.ToFileTime().ToString() },
            { "test", "true" }
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
            StreamWriter writer = File.CreateText("PutObjectFile.txt");
            writer.Write("This is some sample text.!!");
            writer.Close();

            bucketName = S3TestUtils.CreateBucket(Client);
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
            // Test simple PutObject upload
            var key = "contentBodyPut" + random.Next();
            PutObjectRequest putObjectRequest = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = "This is the content body!",
            };

            SetMetadataAndHeaders(putObjectRequest);
            Client.PutObject(putObjectRequest);
            ValidateObjectMetadataAndHeaders(key);

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

        [TestMethod]
        [TestCategory("S3")]
        public void TestDirectoryUploads()
        {
            var directoryName = UtilityMethods.GenerateName("UploadDirectoryTest");
            var progressValidator = new TransferUtilityTests.DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            TransferUtilityTests.ConfigureProgressValidator(progressValidator);

            keysToValidate.Clear();
            UploadDirectory(directoryName, 10 * TransferUtilityTests.MEG_SIZE, progressValidator, validate: true);
            progressValidator.AssertOnCompletion();

            foreach (var key in keysToValidate)
                ValidateObjectMetadataAndHeaders(key);
        }

        void UploadDirectory(string directoryName, long size,
            TransferUtilityTests.DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator, bool validate = true)
        {
            var directoryPath = Path.Combine(basePath, directoryName);

            for (int i = 0; i < 5; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.GenerateFile(filePath, size);
            }

            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            };
            var transferUtility = new TransferUtility(Client, config);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath,
                KeyPrefix = directoryName,
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
                TransferUtilityTests.ValidateDirectoryContents(bucketName, directoryName, directoryPath);
        }

        private static void ValidateObjectMetadataAndHeaders(string key)
        {
            using (var response = Client.GetObject(bucketName, key))
            {
                ValidateMetadataAndHeaders(response);
            }
        }

        private static void SetMetadataAndHeaders(TransferUtilityUploadRequest request)
        {
            SetMetadata(request.Metadata);
            SetHeaders(request.Headers);
        }
        private static void SetMetadataAndHeaders(PutObjectRequest request)
        {
            SetMetadata(request.Metadata);
            SetHeaders(request.Headers);
        }
        private static void SetMetadata(MetadataCollection mc)
        {
            foreach (var kvp in metadata)
                mc[kvp.Key] = kvp.Value;
        }
        private static void SetHeaders(HeadersCollection hc)
        {
            foreach (var kvp in headers)
                hc[kvp.Key] = kvp.Value;
        }
        private static void ValidateMetadataAndHeaders(GetObjectResponse response)
        {
            foreach (var kvp in metadata)
            {
                var name = kvp.Key;
                var expectedValue = kvp.Value;
                var actualValue = response.Metadata[name];
                Assert.AreEqual(expectedValue, actualValue);
            }

            foreach (var kvp in headers)
            {
                var name = kvp.Key;
                var expectedValue = kvp.Value;
                var actualValue = response.Headers[name];
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
