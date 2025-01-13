using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Amazon;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class S3ExpressTests : TestBase<AmazonS3Client>
    {
        public static readonly int megSize = (int)Math.Pow(2, 20);
        private const string content = "Test content";
        private static string bucketName;
        private static List<string> keys = new List<string>
        {
            "a/b/c",
            "a/b/d",
            "a/e",
            "a/f",
            "a/g\rh",
            "a/g\ni",
            "a/g&j",
        };

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateS3ExpressBucketWithWait(Client, "use1-az5");

            foreach (var key in keys)
            {
                Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = content
                });
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ListDirectoryBuckets_ShouldReturnTheCreatedS3ExpressBucket()
        {
            var response = Client.ListDirectoryBuckets(new ListDirectoryBucketsRequest
            {
                MaxDirectoryBuckets = 100,
            });
            Assert.IsTrue(response.Buckets.Count >= 1);

            Assert.IsTrue(response.Buckets.Any(b => b.BucketName == bucketName));
        }


        [TestMethod]
        [TestCategory("S3")]
        public void ListBuckets_ShouldNotContainS3ExpressBucket()
        {
            var response = Client.ListBuckets();
            Assert.IsFalse(response.Buckets.Any(b => b.BucketName == bucketName));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Test_S3Express_BucketPolicy()
        {
            IAmazonSecurityTokenService stsClient = new AmazonSecurityTokenServiceClient();
            var accountId = stsClient.GetCallerIdentity(new GetCallerIdentityRequest()).Account;

            var policyId = Guid.NewGuid().ToString();

            var policy = string.Format(@"{{
                ""Statement"":[
                    {{
                        ""Sid"": ""{0}"",
                        ""Effect"": ""Allow"",
                        ""Resource"": ""arn:aws:s3express:us-east-1:{1}:bucket/{2}"",
                        ""Principal"": {{""AWS"": [""{1}""]}},
                        ""Action"": [""s3express:CreateSession""]
                    }}]
                }}", policyId, accountId, bucketName);


            var putRequest = new PutBucketPolicyRequest
            {
                BucketName = bucketName,
                Policy = policy
            };

            Client.PutBucketPolicy(putRequest);

            var getBucketPolicyResponse = Client.GetBucketPolicy(bucketName);

            Assert.IsTrue(getBucketPolicyResponse.Policy.Contains(policyId));

            Client.DeleteBucketPolicy(bucketName);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void ListObjects_ShouldContainBucketName()
        {
            var response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName
            });

            foreach (var s3object in response.S3Objects)
            {
                if (!keys.Contains(s3object.Key))
                    continue;

                var res = Client.GetObject(bucketName, s3object.Key);
                StreamReader reader = new StreamReader(res.ResponseStream);
                var objectContent = reader.ReadToEnd();
                Assert.AreEqual(objectContent, content);
            }

            Assert.IsTrue(response.S3Objects.Count >= keys.Count);

            foreach (var s3Object in response.S3Objects)
            {
                Assert.AreEqual(s3Object.BucketName, bucketName);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Test_HeadObject_NoVersionIdExists()
        {
            foreach (var key in keys)
            {
                var response = Client.GetObjectMetadata(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key,
                });

                Assert.AreEqual(null, response.VersionId);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Test_CopyObject_BetweenS3ExpressBuckets()
        {
            var newObjectKey = "Test Object 123";

            var destinationbucketName = S3TestUtils.CreateS3ExpressBucketWithWait(Client, "use1-az5");

            Client.CopyObject(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = keys[0],
                DestinationBucket = destinationbucketName,
                DestinationKey = newObjectKey,
            });

            var response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = destinationbucketName
            });

            Assert.IsTrue(response.S3Objects.Count == 1);
            Assert.IsTrue(response.S3Objects.Any(s3Object => s3Object.Key == newObjectKey));

            var getObjectResponse = Client.GetObject(destinationbucketName, newObjectKey);
            StreamReader reader = new StreamReader(getObjectResponse.ResponseStream);
            var objectContent = reader.ReadToEnd();
            Assert.AreEqual(objectContent, content);


            Client.DeleteObject(new DeleteObjectRequest
            {
                BucketName = destinationbucketName,
                Key = newObjectKey
            });

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = destinationbucketName
            });

            if (AWSConfigs.InitializeCollections)
                Assert.IsTrue(response.S3Objects.Count == 0);
            else
                Assert.IsNull(response.S3Objects);

            Client.DeleteBucket(destinationbucketName);

            var listDirectoryBucketsResponse = Client.ListDirectoryBuckets(new ListDirectoryBucketsRequest());
            Assert.IsFalse(listDirectoryBucketsResponse.Buckets.Any(b => b.BucketName == destinationbucketName));
        }

        [TestMethod]
        [TestCategory("S3")]
        [Ignore]
        public void Test_CopyObject_BetweenRegularBucket_And_S3ExpressBucket()
        {
            var oldObjectKey = "Test Object 123";
            var newObjectKey = "New Test Object 123";
            var newObjectContent = "New Test Content";

            // Create regular bucket
            var newRegularBucket = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}";

            Client.PutBucket(newRegularBucket);
            S3TestUtils.WaitForBucket(Client, newRegularBucket);


            // Copy object from S3Express bucket to regular bucket
            Client.CopyObject(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = keys[0],
                DestinationBucket = newRegularBucket,
                DestinationKey = oldObjectKey,
            });

            var listObjectsResponse = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = newRegularBucket
            });

            Assert.IsTrue(listObjectsResponse.S3Objects.Count == 1);
            Assert.IsTrue(listObjectsResponse.S3Objects.Any(s3Object => s3Object.Key == oldObjectKey));

            var getObjectResponse = Client.GetObject(newRegularBucket, oldObjectKey);
            StreamReader reader = new StreamReader(getObjectResponse.ResponseStream);
            var objectContent = reader.ReadToEnd();
            Assert.AreEqual(objectContent, content);

            Client.DeleteObject(new DeleteObjectRequest
            {
                BucketName = newRegularBucket,
                Key = oldObjectKey
            });

            listObjectsResponse = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = newRegularBucket
            });

            if (AWSConfigs.InitializeCollections)
                Assert.IsTrue(listObjectsResponse.S3Objects.Count == 0);
            else
                Assert.IsNull(listObjectsResponse.S3Objects);


            // Add new object to regular bucket
            Client.PutObject(new PutObjectRequest
            {
                BucketName = newRegularBucket,
                Key = newObjectKey,
                ContentBody = newObjectContent
            });

            // Copy object from S3Express bucket to regular bucket
            Client.CopyObject(new CopyObjectRequest
            {
                SourceBucket = newRegularBucket,
                SourceKey = newObjectKey,
                DestinationBucket = bucketName,
                DestinationKey = newObjectKey,
            });

            listObjectsResponse = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName
            });

            Assert.IsTrue(listObjectsResponse.S3Objects.Any(s3Object => s3Object.Key == newObjectKey));

            getObjectResponse = Client.GetObject(bucketName, newObjectKey);
            reader = new StreamReader(getObjectResponse.ResponseStream);
            objectContent = reader.ReadToEnd();
            Assert.AreEqual(objectContent, newObjectContent);



            //Cleanup created objects and bucket
            Client.DeleteObject(new DeleteObjectRequest
            {
                BucketName = newRegularBucket,
                Key = newObjectKey
            });

            Client.DeleteObject(new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = newObjectKey
            });

            Client.DeleteBucket(newRegularBucket);

            var listBucketsResponse = Client.ListBuckets(new ListBucketsRequest());
            Assert.IsFalse(listBucketsResponse.Buckets.Any(b => b.BucketName == newRegularBucket));
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Test_MultipartUpload()
        {
            var random = new Random();

            var nextRandom = random.Next();
            var filePath = Path.Combine(Path.GetTempPath(), "multi-" + nextRandom + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retrieved-" + nextRandom + ".txt");
            var totalSize = megSize * 15;

            UtilityMethods.GenerateFile(filePath, totalSize);
            var key = "key-" + random.Next();

            Stream inputStream = File.OpenRead(filePath);
            try
            {
                InitiateMultipartUploadRequest initRequest = new InitiateMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentType = "text/html",
                };

                InitiateMultipartUploadResponse initResponse = Client.InitiateMultipartUpload(initRequest);

                // Upload part 1
                UploadPartRequest uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * megSize,
                    InputStream = inputStream,
                };

                UploadPartResponse up1Response = Client.UploadPart(uploadRequest);

                // Upload part 2
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * megSize,
                    InputStream = inputStream,
                };

                UploadPartResponse up2Response = Client.UploadPart(uploadRequest);

                // Upload part 3
                uploadRequest = new UploadPartRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream,
                    IsLastPart = true
                };

                UploadPartResponse up3Response = Client.UploadPart(uploadRequest);

                ListPartsRequest listPartRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };

                ListPartsResponse listPartResponse = Client.ListParts(listPartRequest);
                Assert.AreEqual(3, listPartResponse.Parts.Count);
                Assert.AreEqual(up1Response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.AreEqual(up1Response.ETag, listPartResponse.Parts[0].ETag);
                Assert.AreEqual(up2Response.PartNumber, listPartResponse.Parts[1].PartNumber);
                Assert.AreEqual(up2Response.ETag, listPartResponse.Parts[1].ETag);
                Assert.AreEqual(up3Response.PartNumber, listPartResponse.Parts[2].PartNumber);
                Assert.AreEqual(up3Response.ETag, listPartResponse.Parts[2].ETag);

                listPartRequest.MaxParts = 1;
                listPartResponse = Client.ListParts(listPartRequest);
                Assert.AreEqual(1, listPartResponse.Parts.Count);

                // Complete the response
                CompleteMultipartUploadRequest compRequest = new CompleteMultipartUploadRequest()
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(up1Response, up2Response, up3Response);

                CompleteMultipartUploadResponse compResponse = Client.CompleteMultipartUpload(compRequest);

                // Currently failing because it returns bucketName without S3Express's section.
                // S3Express team is aware of this bug and planning to fix it.
                // Assert.AreEqual(bucketName, compResponse.BucketName);

                Assert.IsNotNull(compResponse.ETag);
                Assert.AreEqual(key, compResponse.Key);
                Assert.IsNotNull(compResponse.Location);

                // Get the file back from S3 and make sure it is still the same.
                GetObjectRequest getRequest = new GetObjectRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };

                GetObjectResponse getResponse = Client.GetObject(getRequest);
                getResponse.WriteResponseStreamToFile(retrievedFilepath);

                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                GetObjectMetadataRequest metaDataRequest = new GetObjectMetadataRequest()
                {
                    BucketName = bucketName,
                    Key = key
                };
                GetObjectMetadataResponse metaDataResponse = Client.GetObjectMetadata(metaDataRequest);
                Assert.AreEqual("text/html", metaDataResponse.Headers.ContentType);


                var key2 = "key-" + random.Next();


                //Start�another�multipart�upload to test CopyPart
                InitiateMultipartUploadResponse initResponse2 = Client.InitiateMultipartUpload(new InitiateMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key2,
                });

                CopyPartRequest request = new CopyPartRequest
                {
                    DestinationBucket = bucketName,
                    DestinationKey = key2,
                    SourceBucket = bucketName,
                    SourceKey = key,
                    UploadId = initResponse2.UploadId,
                    PartNumber = 1,
                };
                CopyPartResponse response = Client.CopyPart(request);

                //ETag
                Assert.IsNotNull(response.ETag);
                Assert.IsTrue((response.ETag != null) && (response.ETag.Length > 0));

                //PartNumber
                Assert.IsTrue(response.PartNumber == 1);


                listPartRequest = new ListPartsRequest()
                {
                    BucketName = bucketName,
                    Key = key2,
                    UploadId = initResponse2.UploadId
                };


                listPartResponse = Client.ListParts(listPartRequest);
                Assert.AreEqual(1, listPartResponse.Parts.Count);
                Assert.AreEqual(response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.AreEqual(response.ETag, listPartResponse.Parts[0].ETag);

                Client.AbortMultipartUpload(new AbortMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key2,
                    UploadId = initResponse2.UploadId
                });

                Client.DeleteObject(new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });

            }
            finally
            {
                inputStream.Close();
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (File.Exists(retrievedFilepath))
                    File.Delete(retrievedFilepath);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Test_TransferUtility()
        {
            var random = new Random();

            var key = "key-" + random.Next() + ".txt";
            var filePath = Path.Combine(Path.GetTempPath(), key);

            var retrievedFilepath = filePath + ".download";
            var totalSize = megSize * 15;

            UtilityMethods.GenerateFile(filePath, totalSize);

            try
            {
                using (var tu = new TransferUtility(Client))
                {
                    tu.Upload(filePath, bucketName);

                    var getObjectMetadataResponse = Client.GetObjectMetadata(new GetObjectMetadataRequest
                    {
                        BucketName = bucketName,
                        Key = key
                    });
                    Assert.IsTrue(getObjectMetadataResponse.ETag.Length > 0);

                    var downloadRequest = new TransferUtilityDownloadRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        FilePath = retrievedFilepath
                    };
                    tu.Download(downloadRequest);

                    var fileExists = File.Exists(retrievedFilepath);
                    Assert.IsTrue(fileExists);
                    var fileContent = File.ReadAllText(retrievedFilepath);
                    var testContent = File.ReadAllText(filePath);
                    Assert.AreEqual(testContent, fileContent);
                }

                Client.DeleteObject(new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
            }
            finally
            {
                if (File.Exists(filePath))
                    File.Delete(filePath);
                if (File.Exists(retrievedFilepath))
                    File.Delete(retrievedFilepath);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void Test_TransferUtility_Directory()
        {
            var size = 1 * megSize;
            var random = new Random();

            var key = "key-" + random.Next();
            var directoryPath = Path.Combine(Path.GetTempPath(), key);

            for (int i = 0; i < 5; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.GenerateFile(filePath, size);
            }

            var retrievedDirectoryPath = directoryPath + "download";

            try
            {
                var directory = new DirectoryInfo(directoryPath);
                var retrievedDirectory = new DirectoryInfo(retrievedDirectoryPath);

                using (var tu = new TransferUtility(Client))
                {
                    var uploadDirectoryRequest = new TransferUtilityUploadDirectoryRequest
                    {
                        BucketName = bucketName,
                        Directory = directoryPath,
                        KeyPrefix = directory.Name,
                        SearchPattern = "*",
                        SearchOption = SearchOption.AllDirectories,
                    };

                    HashSet<string> files = new HashSet<string>();
                    uploadDirectoryRequest.UploadDirectoryProgressEvent += (s, e) => files.Add(e.CurrentFile);

                    tu.UploadDirectory(uploadDirectoryRequest);

                    Assert.AreEqual(5, files.Count);

                    var transferUtility = new TransferUtility(Client);
                    var request = new TransferUtilityDownloadDirectoryRequest
                    {
                        BucketName = bucketName,
                        LocalDirectory = retrievedDirectoryPath,
                        S3Directory = directory.Name
                    };

                    transferUtility.DownloadDirectory(request);

                    var oldFiles = directory.GetFiles("*", SearchOption.AllDirectories);
                    var retrievedFiles = retrievedDirectory.GetFiles("*", SearchOption.AllDirectories);

                    foreach (var file in oldFiles)
                    {
                        var retrievedFile = retrievedFiles.FirstOrDefault(e => e.Name == file.Name);
                        Assert.IsTrue(retrievedFile != null);

                        var fileExists = File.Exists(retrievedFile.FullName);
                        Assert.IsTrue(fileExists);

                        var retrievedContent = File.ReadAllText(retrievedFile.FullName);
                        var fileContent = File.ReadAllText(file.FullName);
                        Assert.AreEqual(retrievedContent, fileContent);
                    }
                }
            }
            finally
            {
                if (Directory.Exists(directoryPath))
                    Directory.Delete(directoryPath, true);
                if (File.Exists(retrievedDirectoryPath))
                    Directory.Delete(retrievedDirectoryPath, true);
            }
        }
    }
}