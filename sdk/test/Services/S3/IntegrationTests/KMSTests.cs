using System;
using System.Linq;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.S3.Transfer;
using System.Security.Cryptography;
using System.Net;
using Amazon.Runtime;
using Amazon;
using System.Collections.Generic;
using Amazon.Util;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class KMSTests : TestBase<AmazonS3Client>
    {
        private const string key = "foo.txt";
        private const string testContents = "Test contents";
        private static string largeTestContents = new string('@', (int)(TransferUtilityTests.MEG_SIZE * 19));
        private static string fileContents = "Test file contents";
        private const string profile = "trent";
        private static string basePath = @"c:\temp\test\transferutility\";

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectFromNonDefaultEndpoint()
        {
            var client = new AmazonS3Client(RegionEndpoint.USWest2);
            var bucketName = S3TestUtils.CreateBucketWithWait(client);
            try
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
                };
                client.PutObject(putObjectRequest);

                using (var response = client.GetObject(bucketName, key))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = reader.ReadToEnd();
                    Assert.AreEqual(testContents, data);
                }
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
                client.Dispose();
            }
        }
        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectFromNonDefaultEndpointWithDoubleEncryption()
        {
            var client = new AmazonS3Client(RegionEndpoint.USEast2);
            var bucketName = S3TestUtils.CreateBucketWithWait(client);
            try
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMSDSSE
                };
                client.PutObject(putObjectRequest);
                using (var response = client.GetObject(bucketName, key))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = reader.ReadToEnd();
                    Assert.AreEqual(testContents, data);
                }

            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
                client.Dispose();
            }
        }
        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectFromDefaultEndpointBeforeDNSResolution()
        {
            var client = new AmazonS3Client(RegionEndpoint.USWest2);
            var defaultEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });
            
            var bucketName = S3TestUtils.CreateBucketWithWait(client);
            try
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
                };
                client.PutObject(putObjectRequest);

                using (var response = defaultEndpointClient.GetObject(bucketName, key))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = reader.ReadToEnd();
                    Assert.AreEqual(testContents, data);
                }
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
                client.Dispose();
                defaultEndpointClient.Dispose();
            }
        }
        [TestMethod]
        [TestCategory("S3")]
        public void GetObjectFromDefaultEndpointBeforeDNSResolutionWithDoubleEncryption()
        {
            var client = new AmazonS3Client(RegionEndpoint.USEast2);
            var defaultEndpointClient = new AmazonS3Client(new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                USEast1RegionalEndpointValue = S3UsEast1RegionalEndpointValue.Legacy,
            });

            var bucketName = S3TestUtils.CreateBucketWithWait(client);
            try
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMSDSSE
                };
                client.PutObject(putObjectRequest);

                using (var response = defaultEndpointClient.GetObject(bucketName, key))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = reader.ReadToEnd();
                    Assert.AreEqual(testContents, data);
                }
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
                client.Dispose();
                defaultEndpointClient.Dispose();
            }
        }

        // To run this test set bucketName to a valid bucket name.
        //[TestMethod]
        //[TestCategory("S3")]
        public void GetObjectFromDefaultEndpointAfterDNSResolution()
        {
            var client = new AmazonS3Client(RegionEndpoint.USWest2);
            var defaultEndpointClient = new AmazonS3Client(RegionEndpoint.USEast1);

            // Set to a valid bucket name.
            string bucketName = null;
            try
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
                };
                client.PutObject(putObjectRequest);

                using (var response = defaultEndpointClient.GetObject(bucketName, key))
                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = reader.ReadToEnd();
                    Assert.AreEqual(testContents, data);
                }
            }
            finally
            {
                client.Dispose();
                defaultEndpointClient.Dispose();
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestKmsOverHttp()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = AWSConfigs.RegionEndpoint,
                UseHttp = true
            };
            using(var client = new AmazonS3Client(config))
            {
                var bucketName = S3TestUtils.CreateBucketWithWait(client);
                try
                {
                    var putObjectRequest = new PutObjectRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        ContentBody = testContents,
                        ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
                    };
                    Action action = () =>
                    {
                        client.PutObject(putObjectRequest);
                    };

                    AssertExtensions.ExpectException(action, typeof(AmazonS3Exception));
                }
                finally
                {
                    AmazonS3Util.DeleteS3BucketWithObjects(client, bucketName);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DefaultKeyTests()
        {
            TestSseKms(keyId: null, ServerSideEncryptionMethod.AWSKMS);
            TestPresignedUrls(keyId: null, ServerSideEncryptionMethod.AWSKMS);

        }
        [TestMethod]
        [TestCategory("S3")]
        public void KmsDsseTest()
        {
            TestSseKms(null, ServerSideEncryptionMethod.AWSKMSDSSE);

        }
        [TestMethod]
        [TestCategory("S3")]
        public void TestKmsDssePresignedUrls()
        {
            TestPresignedUrls(null, ServerSideEncryptionMethod.AWSKMSDSSE);
        }


        // This test is disabled because it creates resources that cannot be removed, KMS keys.
        //[TestMethod]
        [TestCategory("S3")]
        public void SpecificKeyTests()
        {
            var keyId = KeyManagementService.Client.CreateKey(new Amazon.KeyManagementService.Model.CreateKeyRequest
            {
                KeyUsage = Amazon.KeyManagementService.KeyUsageType.ENCRYPT_DECRYPT,
                Description = ".NET SDK S3 Test Key"
            }).KeyMetadata.KeyId;

            TestSseKms(keyId, ServerSideEncryptionMethod.AWSKMS);
            TestPresignedUrls(keyId, ServerSideEncryptionMethod.AWSKMS);
        }

        // https://github.com/aws/aws-sdk-net/issues/200 (and 197), 3rd-party
        // storage providers compatible with S3 should not be included
        // in the test to use Signature V4
        [TestMethod]
        [TestCategory("S3")]
        public void TestNonS3EndpointDetection()
        {
            string[] thirdPartyProviderUriExamples =
            {
                "http://storage.googleapis.com",
                "http://bucket.storage.googleapis.com",
                "http://s3.mycompany.com",
                "http://storage.s3.company.com"
            };

            string[] s3UriExamples =
            {
                "http://s3.amazonaws.com",
                "http://s3-external-1.amazonaws.com",
                "http://s3-us-west-2.amazonaws.com",
                "http://bucketname.s3-us-west-2.amazonaws.com",
                "http://s3.eu-central-1.amazonaws.com",
                "http://bucketname.s3.eu-central-1.amazonaws.com",
                "http://s3.cn-north-1.amazonaws.com.cn",
            };

            foreach (var uri in thirdPartyProviderUriExamples)
            {
                Assert.IsFalse(AmazonS3Uri.IsAmazonS3Endpoint(uri));    
            }

            foreach (var uri in s3UriExamples)
            {
                Assert.IsTrue(AmazonS3Uri.IsAmazonS3Endpoint(uri));
            }
        }

        public void TestPresignedUrls(string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            using (var newClient = new AmazonS3Client())
            {
                var bucketName = S3TestUtils.CreateBucketWithWait(newClient);
                try
                {
                    VerifyPresignedPut(bucketName, key, keyId, serverSideEncryptionMethod);
                    VerifyObjectWithTransferUtility(bucketName);
                    TestPresignedGet(bucketName, key, keyId);

                    var key2 = key + "Copy2";
                    var copyResponse = newClient.CopyObject(new CopyObjectRequest
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
                finally
                {
                    AmazonS3Util.DeleteS3BucketWithObjects(newClient, bucketName);
                }
            }
        }

        private void TestSseKms(string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var bucketName = S3TestUtils.CreateBucketWithWait(Client);
            try
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = serverSideEncryptionMethod
                };
                putObjectRequest.ServerSideEncryptionKeyManagementServiceKeyId = keyId;
                var putObjectResponse = Client.PutObject(putObjectRequest);
                Assert.IsNotNull(putObjectResponse.ServerSideEncryptionKeyManagementServiceKeyId);
                var usedKeyId = putObjectResponse.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);
                VerifyObject(bucketName, key, usedKeyId, serverSideEncryptionMethod);
                VerifyObjectWithTransferUtility(bucketName);

                TestCopyPart(bucketName, key, keyId, serverSideEncryptionMethod);

                var key2 = key + "Copy";
                var copyResponse = Client.CopyObject(new CopyObjectRequest
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
                VerifyObject(bucketName, key2, usedKeyId, serverSideEncryptionMethod);

                TransferUtility utility = new TransferUtility(Client);
                var smallUploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ServerSideEncryptionMethod = serverSideEncryptionMethod,
                    ServerSideEncryptionKeyManagementServiceKeyId = keyId,
                    InputStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(testContents))
                };
                utility.Upload(smallUploadRequest);
                VerifyObject(bucketName, key, keyId, serverSideEncryptionMethod);

                var largeUploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ServerSideEncryptionMethod = serverSideEncryptionMethod,
                    ServerSideEncryptionKeyManagementServiceKeyId = keyId,
                    InputStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(largeTestContents))
                };
                utility.Upload(largeUploadRequest);
                VerifyObject(bucketName, key, keyId, serverSideEncryptionMethod);

                TestUploadDirectory(bucketName, keyId, serverSideEncryptionMethod);
            }
            finally
            {
                AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            }
        }

        private void TestUploadDirectory(string bucketName, string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var directoryName = UtilityMethods.GenerateName("UploadDirectoryTest");

            var directoryPath = Path.Combine(basePath, directoryName);
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
            transferUtility.UploadDirectory(request);
            Assert.AreEqual(5, keys.Count);

            foreach (var key in keys)
                VerifyObject(bucketName, key, keyId, serverSideEncryptionMethod);
        }
        private void TestPresignedGet(string bucketName, string key, string keyId)
        {
            GetPreSignedUrlRequest getPresignedUrlRequest = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = key,
                Expires = DateTime.UtcNow.AddMinutes(5)
            };
            var url = Client.GetPreSignedURL(getPresignedUrlRequest);
            var webRequest = HttpWebRequest.Create(url);

            using (var response = webRequest.GetResponse())
            {
                var usedKeyId = response.Headers[HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader];
                VerifyKeyId(keyId, usedKeyId);

                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    var data = reader.ReadToEnd();
                    VerifyContents(data);
                }
            }
        }
        private void VerifyPresignedPut(string bucketName, string key, string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            GetPreSignedUrlRequest getPresignedUrlRequest = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = key,
                Verb = HttpVerb.PUT,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId,
                Expires = DateTime.UtcNow.AddMinutes(5)
            };
            var url = Client.GetPreSignedURL(getPresignedUrlRequest);

            string usedKeyId = null;
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    usedKeyId = VerifyPresignedPut(keyId, url, serverSideEncryptionMethod);
                    break;
                }
                catch
                {}
            }

            Assert.IsNotNull(usedKeyId);
            VerifyKeyId(keyId, usedKeyId);
            VerifyObject(bucketName, key, usedKeyId, serverSideEncryptionMethod);
        }
        private void TestCopyPart(string bucketName, string key, string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            string dstKey = "dstObject";
            string srcKey = key;
            string srcVersionID;
            string srcETag;
            DateTime srcTimeStamp;
            string uploadID = null;

            try
            {
                //Get the srcObjectTimestamp
                GetObjectMetadataResponse gomr = Client.GetObjectMetadata(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = srcKey
                });
                srcTimeStamp = gomr.LastModified.Value;
                srcVersionID = gomr.VersionId;
                srcETag = gomr.ETag;

                //Start the multipart upload
                InitiateMultipartUploadResponse imur = Client.InitiateMultipartUpload(new InitiateMultipartUploadRequest
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

                CopyPartRequest request = new CopyPartRequest
                {
                    DestinationBucket = bucketName,
                    DestinationKey = dstKey,
                    SourceBucket = bucketName,
                    SourceKey = srcKey,
                    UploadId = uploadID,
                    PartNumber = 1,
                };
                CopyPartResponse response = Client.CopyPart(request);
                Assert.AreEqual(serverSideEncryptionMethod, response.ServerSideEncryptionMethod);
                usedKeyId = response.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);

                //ETag
                Assert.IsNotNull(response.ETag);
                Assert.IsTrue((response.ETag != null) && (response.ETag.Length > 0));

                //LastModified
                Assert.IsNotNull(response.LastModified);
                Assert.AreNotEqual(DateTime.MinValue, response.LastModified);

                //PartNumber
                Assert.IsTrue(response.PartNumber == 1);

                var completeRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = dstKey,
                    UploadId = uploadID
                };
                completeRequest.AddPartETags(response);

                var completeResponse = Client.CompleteMultipartUpload(completeRequest);
                Assert.AreEqual(serverSideEncryptionMethod, completeResponse.ServerSideEncryptionMethod);
                usedKeyId = completeResponse.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);
            }
            finally
            {
                //abort the multipart upload
                if (uploadID != null)
                {
                    Client.AbortMultipartUpload(new AbortMultipartUploadRequest
                    {
                        BucketName = bucketName,
                        Key = dstKey,
                        UploadId = uploadID
                    });
                }
            }
        }

        private string VerifyPresignedPut(string keyId, string url, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var webRequest = HttpWebRequest.Create(url);
            webRequest.Method = "PUT";

            if (keyId != null)
                webRequest.Headers.Add(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, keyId);
            webRequest.Headers.Add(HeaderKeys.XAmzServerSideEncryptionHeader, serverSideEncryptionMethod.Value);

            using (var stream = webRequest.GetRequestStream())
            using (var writer = new StreamWriter(stream))
            {
                writer.Write(testContents);
            }

            string usedKeyId;
            using (var response = webRequest.GetResponse())
            {
                usedKeyId = response.Headers[HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader];
            }
            return usedKeyId;
        }
        private void VerifyObject(string bucketName, string key, string usedKeyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var metadata = Client.GetObjectMetadata(bucketName, key);
            if (usedKeyId != null)
                Assert.IsTrue(metadata.ServerSideEncryptionKeyManagementServiceKeyId.IndexOf(usedKeyId, StringComparison.OrdinalIgnoreCase) >= 0);

            using (var response = Client.GetObject(bucketName, key))
            {
                Assert.AreEqual(serverSideEncryptionMethod, response.ServerSideEncryptionMethod);
                Assert.IsNotNull(response.ServerSideEncryptionKeyManagementServiceKeyId);
                if (usedKeyId != null)
                    Assert.IsTrue(response.ServerSideEncryptionKeyManagementServiceKeyId.IndexOf(usedKeyId, StringComparison.OrdinalIgnoreCase) >= 0);

                using (var reader = new StreamReader(response.ResponseStream))
                {
                    var data = reader.ReadToEnd();
                    VerifyContents(data);
                }
            }
        }
        private void VerifyObjectWithTransferUtility(string bucketName)
        {
            var transferUtility = new TransferUtility(Client);
            var filePath = Path.GetFullPath("downloadedFile.txt");
            transferUtility.Download(new TransferUtilityDownloadRequest
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
