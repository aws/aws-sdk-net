using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class KMSTests : TestBase<AmazonS3Client>
    {
        private const string key = "foo.txt";
        private const string testContents = "Test contents";
        private static string largeTestContents = new string('@', (int)(TransferUtilityTests.MEG_SIZE * 19));
        private static string fileContents = "Test file contents";
        private static string bucketName;
        private static string tempDirectory;

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext testContext)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            tempDirectory = Path.Combine(Path.GetTempPath(), "S3KMSTests-" + Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempDirectory);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            if (Directory.Exists(tempDirectory))
            {
                Directory.Delete(tempDirectory, recursive: true);
            }

            BaseClean();
        }

        [TestMethod]
        public async Task GetObjectFromDefaultEndpointBeforeDNSResolution()
        {
            var usWest2Client = new AmazonS3Client(RegionEndpoint.USWest2);
            var defaultEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });
            
            var bucketName = await S3TestUtils.CreateBucketWithWaitAsync(usWest2Client);
            try
            {
                await usWest2Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
                });

                using (var response = await defaultEndpointClient.GetObjectAsync(bucketName, key))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = await reader.ReadToEndAsync();
                    Assert.AreEqual(testContents, data);
                }
            }
            finally
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(usWest2Client, bucketName);
                usWest2Client.Dispose();
                defaultEndpointClient.Dispose();
            }
        }

        [TestMethod]
        public async Task GetObjectFromDefaultEndpointBeforeDNSResolutionWithDoubleEncryption()
        {
            var usEast2Client = new AmazonS3Client(RegionEndpoint.USEast2);
            var defaultEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            var bucketName = await S3TestUtils.CreateBucketWithWaitAsync(usEast2Client);
            try
            {
                await usEast2Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMSDSSE
                });

                using (var response = await defaultEndpointClient.GetObjectAsync(bucketName, key))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = await reader.ReadToEndAsync();
                    Assert.AreEqual(testContents, data);
                }
            }
            finally
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(usEast2Client, bucketName);
                usEast2Client.Dispose();
                defaultEndpointClient.Dispose();
            }
        }

        [TestMethod]
        public async Task TestKmsOverHttp()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = Client.Config.RegionEndpoint,
                UseHttp = true
            };

            using (var client = new AmazonS3Client(config))
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
                };
                await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => client.PutObjectAsync(putObjectRequest));
            }
        }

        [TestMethod]
        public async Task DefaultKeyTests()
        {
            await TestSseKms(keyId: null, ServerSideEncryptionMethod.AWSKMS);
            await TestPresignedUrls(keyId: null, ServerSideEncryptionMethod.AWSKMS);
        }

        [TestMethod]
        public async Task KmsDsseTest()
        {
            await TestSseKms(null, ServerSideEncryptionMethod.AWSKMSDSSE);
        }

        [TestMethod]
        public async Task TestKmsDssePresignedUrls()
        {
            await TestPresignedUrls(null, ServerSideEncryptionMethod.AWSKMSDSSE);
        }

        public async Task TestPresignedUrls(string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            await VerifyPresignedPut(key, keyId, serverSideEncryptionMethod);
            await VerifyObjectWithTransferUtility();
            await TestPresignedGet(key, keyId);

            var key2 = key + "Copy2";
            var copyResponse = await Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = key,
                DestinationBucket = bucketName,
                DestinationKey = key2
            });
            Assert.IsNotNull(copyResponse);

            var usedKeyId = copyResponse.ServerSideEncryptionKeyManagementServiceKeyId;
            Assert.IsNull(usedKeyId);
        }

        private async Task TestSseKms(string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var putObjectResponse = await Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = testContents,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId
            });
            Assert.IsNotNull(putObjectResponse.ServerSideEncryptionKeyManagementServiceKeyId);

            var usedKeyId = putObjectResponse.ServerSideEncryptionKeyManagementServiceKeyId;
            VerifyKeyId(keyId, usedKeyId);
            await VerifyObject(key, usedKeyId, serverSideEncryptionMethod);
            await VerifyObjectWithTransferUtility();
            await TestCopyPart(key, keyId, serverSideEncryptionMethod);

            var key2 = key + "Copy";
            var copyResponse = await Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = key,
                DestinationBucket = bucketName,
                DestinationKey = key2,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId
            });
            Assert.IsNotNull(copyResponse);

            usedKeyId = copyResponse.ServerSideEncryptionKeyManagementServiceKeyId;
            VerifyKeyId(keyId, usedKeyId);
            await VerifyObject(key2, usedKeyId, serverSideEncryptionMethod);

            var utility = new TransferUtility(Client);
            await utility.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId,
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes(testContents))
            });
            await VerifyObject(key, keyId, serverSideEncryptionMethod);

            await utility.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId,
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes(largeTestContents))
            });
            await VerifyObject(key, keyId, serverSideEncryptionMethod);
            await TestUploadDirectory(keyId, serverSideEncryptionMethod);
        }

        private async Task TestUploadDirectory(string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var directoryName = UtilityMethods.GenerateName("UploadDirectoryTest");
            var directoryPath = Path.Combine(tempDirectory, directoryName);
            for (int i = 0; i < 5; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.WriteFile(filePath, fileContents);
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
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId
            };

            HashSet<string> keys = new HashSet<string>();
            request.UploadDirectoryFileRequestEvent += (s, e) =>
            {
                keys.Add(e.UploadRequest.Key);
            };
            await transferUtility.UploadDirectoryAsync(request);
            Assert.AreEqual(5, keys.Count);

            foreach (var key in keys)
            {
                await VerifyObject(key, keyId, serverSideEncryptionMethod);
            }
        }

        private async Task TestPresignedGet(string key, string keyId)
        {
            var url = Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = key,
                Expires = DateTime.UtcNow.AddMinutes(5)
            });

            var webRequest = WebRequest.Create(url);
            using (var response = await webRequest.GetResponseAsync())
            {
                var usedKeyId = response.Headers[HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader];
                VerifyKeyId(keyId, usedKeyId);

                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    var data = await reader.ReadToEndAsync();
                    VerifyContents(data);
                }
            }
        }

        private async Task VerifyPresignedPut(string key, string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var url = Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = key,
                Verb = HttpVerb.PUT,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId,
                Expires = DateTime.UtcNow.AddMinutes(5)
            });

            string usedKeyId = null;
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    usedKeyId = await RetrieveUsedKeyId(keyId, url, serverSideEncryptionMethod);
                    break;
                }
                catch { }
            }

            Assert.IsNotNull(usedKeyId);
            VerifyKeyId(keyId, usedKeyId);
            await VerifyObject(key, usedKeyId, serverSideEncryptionMethod);
        }

        private async Task TestCopyPart(string key, string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            string dstKey = "dstObject";
            string srcKey = key;
            string srcVersionID;
            string srcETag;
            DateTime srcTimeStamp;
            string uploadID = null;

            try
            {
                // Get the srcObjectTimestamp
                var gomr = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = srcKey
                });
                srcTimeStamp = gomr.LastModified.Value;
                srcVersionID = gomr.VersionId;
                srcETag = gomr.ETag;

                var imur = await Client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = dstKey,
                    ServerSideEncryptionMethod = serverSideEncryptionMethod,
                    ServerSideEncryptionKeyManagementServiceKeyId = keyId
                });
                Assert.AreEqual(serverSideEncryptionMethod, imur.ServerSideEncryptionMethod);
                var usedKeyId = imur.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);
                uploadID = imur.UploadId;

                var response = await Client.CopyPartAsync(new CopyPartRequest
                {
                    DestinationBucket = bucketName,
                    DestinationKey = dstKey,
                    SourceBucket = bucketName,
                    SourceKey = srcKey,
                    UploadId = uploadID,
                    PartNumber = 1,
                });
                Assert.AreEqual(serverSideEncryptionMethod, response.ServerSideEncryptionMethod);
                usedKeyId = response.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);

                Assert.IsNotNull(response.ETag);
                Assert.IsTrue((response.ETag != null) && (response.ETag.Length > 0));
                Assert.IsNotNull(response.LastModified);
                Assert.AreNotEqual(DateTime.MinValue, response.LastModified);
                Assert.IsTrue(response.PartNumber == 1);

                var completeRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = dstKey,
                    UploadId = uploadID
                };
                completeRequest.AddPartETags(response);

                var completeResponse = await Client.CompleteMultipartUploadAsync(completeRequest);
                Assert.AreEqual(serverSideEncryptionMethod, completeResponse.ServerSideEncryptionMethod);
                usedKeyId = completeResponse.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);
            }
            finally
            {
                if (uploadID != null)
                {
                    await Client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                    {
                        BucketName = bucketName,
                        Key = dstKey,
                        UploadId = uploadID
                    });
                }
            }
        }

        private async Task<string> RetrieveUsedKeyId(string keyId, string url, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var webRequest = WebRequest.Create(url);
            webRequest.Method = "PUT";

            if (keyId != null)
            {
                webRequest.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, keyId);
            }
            webRequest.Headers.Add(HeaderKeys.XAmzServerSideEncryptionHeader, serverSideEncryptionMethod.Value);

            using (var stream = await webRequest.GetRequestStreamAsync())
            using (var writer = new StreamWriter(stream))
            {
                await writer.WriteAsync(testContents);
            }

            string usedKeyId;
            using (var response = await webRequest.GetResponseAsync())
            {
                usedKeyId = response.Headers[HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader];
            }
            return usedKeyId;
        }

        private async Task VerifyObject(string key, string usedKeyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var metadata = await Client.GetObjectMetadataAsync(bucketName, key);
            if (usedKeyId != null)
            {
                Assert.IsTrue(metadata.ServerSideEncryptionKeyManagementServiceKeyId.IndexOf(usedKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            using (var response = await Client.GetObjectAsync(bucketName, key))
            {
                Assert.AreEqual(serverSideEncryptionMethod, response.ServerSideEncryptionMethod);
                Assert.IsNotNull(response.ServerSideEncryptionKeyManagementServiceKeyId);
                if (usedKeyId != null)
                {
                    Assert.IsTrue(response.ServerSideEncryptionKeyManagementServiceKeyId.IndexOf(usedKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = await reader.ReadToEndAsync();
                    VerifyContents(data);
                }
            }
        }

        private async Task VerifyObjectWithTransferUtility()
        {
            var transferUtility = new TransferUtility(Client);
            var filePath = Path.GetFullPath("downloadedFile.txt");
            await transferUtility.DownloadAsync(new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            });

            var fileContents = File.ReadAllText(filePath);
            VerifyContents(fileContents);
        }

        private static void VerifyContents(string contents)
        {
            if (contents.Length == testContents.Length)
                Assert.IsTrue(string.Equals(testContents, contents, StringComparison.Ordinal));
            else if (contents.Length == largeTestContents.Length)
                Assert.IsTrue(string.Equals(largeTestContents, contents, StringComparison.Ordinal));
            else
                Assert.IsTrue(string.Equals(fileContents, contents, StringComparison.Ordinal));
        }

        private static void VerifyKeyId(string suppliedKeyId, string returnedKeyId)
        {
            if (suppliedKeyId != null)
            {
                var index = returnedKeyId.IndexOf(suppliedKeyId, StringComparison.OrdinalIgnoreCase);
                Assert.IsTrue(index >= 0);
            }
        }
    }
}
