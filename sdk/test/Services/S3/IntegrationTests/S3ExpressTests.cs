using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class S3ExpressTests : TestBase<AmazonS3Client>
    {
        private static readonly int megSize = (int)Math.Pow(2, 20);
        private const string content = "Test content";
        private static string bucketName;
        private static readonly AmazonS3Client _usEast1Client = new AmazonS3Client(RegionEndpoint.USEast1);

        private static readonly List<string> keys = new List<string>
        {
            "a/b/c",
            "a/b/d",
            "a/e",
            "a/f",
            "a/g\rh",
            "a/g\ni",
            "a/g&j",
        };

        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {
            bucketName = await S3TestUtils.CreateS3ExpressBucketWithWaitAsync(_usEast1Client, "use1-az5");

            foreach (var key in keys)
            {
                await _usEast1Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = content
                });
            }
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_usEast1Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        public async Task ListDirectoryBuckets_ShouldReturnTheCreatedS3ExpressBucket()
        {
            var response = await _usEast1Client.ListDirectoryBucketsAsync(new ListDirectoryBucketsRequest
            {
                MaxDirectoryBuckets = 100,
            });
            Assert.IsTrue(response.Buckets.Count >= 1);
            Assert.IsTrue(response.Buckets.Any(b => b.BucketName == bucketName));
        }

        [TestMethod]
        public async Task ListBuckets_ShouldNotContainS3ExpressBucket()
        {
            var response = await _usEast1Client.ListBucketsAsync();
            Assert.IsFalse(response.Buckets.Any(b => b.BucketName == bucketName));
        }

        [TestMethod]
        public async Task Test_S3Express_BucketPolicy()
        {
            var stsClient = new AmazonSecurityTokenServiceClient();
            var accountId = (await stsClient.GetCallerIdentityAsync(new GetCallerIdentityRequest())).Account;
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
            
            await _usEast1Client.PutBucketPolicyAsync(new PutBucketPolicyRequest
            {
                BucketName = bucketName,
                Policy = policy
            });

            var getBucketPolicyResponse = await _usEast1Client.GetBucketPolicyAsync(bucketName);
            Assert.IsTrue(getBucketPolicyResponse.Policy.Contains(policyId));
            await _usEast1Client.DeleteBucketPolicyAsync(bucketName);
        }

        [TestMethod]
        public async Task ListObjects_ShouldContainBucketName()
        {
            var response = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = bucketName
            });

            foreach (var s3object in response.S3Objects)
            {
                if (!keys.Contains(s3object.Key))
                {
                    continue;
                }

                var res = await _usEast1Client.GetObjectAsync(bucketName, s3object.Key);
                var reader = new StreamReader(res.ResponseStream);
                var objectContent = await reader.ReadToEndAsync();
                Assert.AreEqual(objectContent, content);
            }

            Assert.IsTrue(response.S3Objects.Count >= keys.Count);
            foreach (var s3Object in response.S3Objects)
            {
                Assert.AreEqual(s3Object.BucketName, bucketName);
            }
        }

        [TestMethod]
        public async Task Test_HeadObject_NoVersionIdExists()
        {
            foreach (var key in keys)
            {
                var response = await _usEast1Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key,
                });

                Assert.AreEqual(null, response.VersionId);
            }
        }

        [TestMethod]
        public async Task Test_CopyObject_BetweenS3ExpressBuckets()
        {
            var newObjectKey = "Test Object 123";
            var destinationbucketName = await S3TestUtils.CreateS3ExpressBucketWithWaitAsync(_usEast1Client, "use1-az5");

            await _usEast1Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = keys[0],
                DestinationBucket = destinationbucketName,
                DestinationKey = newObjectKey,
            });

            var response = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = destinationbucketName
            });
            Assert.IsTrue(response.S3Objects.Count == 1);
            Assert.IsTrue(response.S3Objects.Any(s3Object => s3Object.Key == newObjectKey));

            var getObjectResponse = await _usEast1Client.GetObjectAsync(destinationbucketName, newObjectKey);
            var reader = new StreamReader(getObjectResponse.ResponseStream);
            var objectContent = await reader.ReadToEndAsync();
            Assert.AreEqual(objectContent, content);

            await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = destinationbucketName,
                Key = newObjectKey
            });

            response = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = destinationbucketName
            });

            if (AWSConfigs.InitializeCollections)
                Assert.IsTrue(response.S3Objects.Count == 0);
            else
                Assert.IsNull(response.S3Objects);

            await _usEast1Client.DeleteBucketAsync(destinationbucketName);
            var listDirectoryBucketsResponse = await _usEast1Client.ListDirectoryBucketsAsync(new ListDirectoryBucketsRequest());
            Assert.IsFalse(listDirectoryBucketsResponse.Buckets.Any(b => b.BucketName == destinationbucketName));
        }

        [TestMethod]
        public async Task Test_CopyObject_BetweenRegularBucket_And_S3ExpressBucket()
        {
            var oldObjectKey = "Test Object 123";
            var newObjectKey = "New Test Object 123";
            var newObjectContent = "New Test Content";

            // Create regular bucket
            var newRegularBucket = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}";
            await _usEast1Client.PutBucketAsync(newRegularBucket);

            // Copy object from S3Express bucket to regular bucket
            await _usEast1Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = bucketName,
                SourceKey = keys[0],
                DestinationBucket = newRegularBucket,
                DestinationKey = oldObjectKey,
            });

            var listObjectsResponse = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = newRegularBucket
            });
            Assert.IsTrue(listObjectsResponse.S3Objects.Count == 1);
            Assert.IsTrue(listObjectsResponse.S3Objects.Any(s3Object => s3Object.Key == oldObjectKey));

            var getObjectResponse = await _usEast1Client.GetObjectAsync(newRegularBucket, oldObjectKey);
            var reader = new StreamReader(getObjectResponse.ResponseStream);
            var objectContent = await reader.ReadToEndAsync();
            Assert.AreEqual(objectContent, content);

            await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = newRegularBucket,
                Key = oldObjectKey
            });

            listObjectsResponse = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = newRegularBucket
            });

            if (AWSConfigs.InitializeCollections)
                Assert.IsTrue(listObjectsResponse.S3Objects.Count == 0);
            else
                Assert.IsNull(listObjectsResponse.S3Objects);

            // Add new object to regular bucket
            await _usEast1Client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = newRegularBucket,
                Key = newObjectKey,
                ContentBody = newObjectContent
            });

            // Copy object from S3Express bucket to regular bucket
            await _usEast1Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = newRegularBucket,
                SourceKey = newObjectKey,
                DestinationBucket = bucketName,
                DestinationKey = newObjectKey,
            });

            listObjectsResponse = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = bucketName
            });
            Assert.IsTrue(listObjectsResponse.S3Objects.Any(s3Object => s3Object.Key == newObjectKey));

            getObjectResponse = await _usEast1Client.GetObjectAsync(bucketName, newObjectKey);
            reader = new StreamReader(getObjectResponse.ResponseStream);
            objectContent = await reader.ReadToEndAsync();
            Assert.AreEqual(objectContent, newObjectContent);

            // Cleanup created objects and bucket
            await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = newRegularBucket,
                Key = newObjectKey
            });
            await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = newObjectKey
            });
            await _usEast1Client.DeleteBucketAsync(newRegularBucket);

            var listBucketsResponse = await _usEast1Client.ListBucketsAsync(new ListBucketsRequest());
            Assert.IsFalse(listBucketsResponse.Buckets.Any(b => b.BucketName == newRegularBucket));
        }

        [TestMethod]
        public async Task Test_MultipartUpload()
        {
            var random = new Random();
            var nextRandom = random.Next();
            var filePath = Path.Combine(Path.GetTempPath(), "multi-" + nextRandom + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retrieved-" + nextRandom + ".txt");
            var totalSize = megSize * 15;

            UtilityMethods.GenerateFile(filePath, totalSize);
            var key = "key-" + random.Next();

            var inputStream = File.OpenRead(filePath);
            try
            {
                var initRequest = new InitiateMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentType = "text/html",
                };
                var initResponse = await Client.InitiateMultipartUploadAsync(initRequest);
                
                var uploadRequest = new UploadPartRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * megSize,
                    InputStream = inputStream,
                };
                var up1Response = await Client.UploadPartAsync(uploadRequest);

                uploadRequest = new UploadPartRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * megSize,
                    InputStream = inputStream,
                };
                var up2Response = await Client.UploadPartAsync(uploadRequest);

                uploadRequest = new UploadPartRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream,
                    IsLastPart = true
                };
                var up3Response = await Client.UploadPartAsync(uploadRequest);

                var listPartRequest = new ListPartsRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                var listPartResponse = await Client.ListPartsAsync(listPartRequest);
                Assert.AreEqual(3, listPartResponse.Parts.Count);
                Assert.AreEqual(up1Response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.AreEqual(up1Response.ETag, listPartResponse.Parts[0].ETag);
                Assert.AreEqual(up2Response.PartNumber, listPartResponse.Parts[1].PartNumber);
                Assert.AreEqual(up2Response.ETag, listPartResponse.Parts[1].ETag);
                Assert.AreEqual(up3Response.PartNumber, listPartResponse.Parts[2].PartNumber);
                Assert.AreEqual(up3Response.ETag, listPartResponse.Parts[2].ETag);

                listPartRequest.MaxParts = 1;
                listPartResponse = await Client.ListPartsAsync(listPartRequest);
                Assert.AreEqual(1, listPartResponse.Parts.Count);

                var compRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(up1Response, up2Response, up3Response);
                var compResponse = await Client.CompleteMultipartUploadAsync(compRequest);
                Assert.IsNotNull(compResponse.ETag);
                Assert.AreEqual(key, compResponse.Key);
                Assert.IsNotNull(compResponse.Location);

                // Get the file back from S3 and make sure it is still the same.
                var getResponse = await Client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
                await getResponse.WriteResponseStreamToFileAsync(retrievedFilepath, append: false, cancellationToken: default);
                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                var metaDataResponse = await Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
                Assert.AreEqual("text/html", metaDataResponse.Headers.ContentType);

                var key2 = "key-" + random.Next();
                var initResponse2 = await Client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key2,
                });

                var response = await Client.CopyPartAsync(new CopyPartRequest
                {
                    DestinationBucket = bucketName,
                    DestinationKey = key2,
                    SourceBucket = bucketName,
                    SourceKey = key,
                    UploadId = initResponse2.UploadId,
                    PartNumber = 1,
                });
                Assert.IsNotNull(response.ETag);
                Assert.IsTrue((response.ETag != null) && (response.ETag.Length > 0));
                Assert.IsTrue(response.PartNumber == 1);

                listPartRequest = new ListPartsRequest
                {
                    BucketName = bucketName,
                    Key = key2,
                    UploadId = initResponse2.UploadId
                };
                listPartResponse = await Client.ListPartsAsync(listPartRequest);
                Assert.AreEqual(1, listPartResponse.Parts.Count);
                Assert.AreEqual(response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.AreEqual(response.ETag, listPartResponse.Parts[0].ETag);

                await Client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key2,
                    UploadId = initResponse2.UploadId
                });

                await Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
            }
            finally
            {
                inputStream.Close();
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                if (File.Exists(retrievedFilepath))
                {
                    File.Delete(retrievedFilepath);
                }
            }
        }

        [TestMethod]
        public async Task Test_TransferUtility()
        {
            var random = new Random();
            var key = "key-" + random.Next() + ".txt";
            var filePath = Path.Combine(Path.GetTempPath(), key);
            var retrievedFilepath = filePath + ".download";
            UtilityMethods.GenerateFile(filePath, megSize * 15);

            try
            {
                using (var tu = new TransferUtility(_usEast1Client))
                {
                    await tu.UploadAsync(filePath, bucketName);

                    var getObjectMetadataResponse = await _usEast1Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                    {
                        BucketName = bucketName,
                        Key = key
                    });
                    Assert.IsTrue(getObjectMetadataResponse.ETag.Length > 0);

                    await tu.DownloadAsync(new TransferUtilityDownloadRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        FilePath = retrievedFilepath
                    });

                    var fileExists = File.Exists(retrievedFilepath);
                    Assert.IsTrue(fileExists);

                    var fileContent = File.ReadAllText(retrievedFilepath);
                    var testContent = File.ReadAllText(filePath);
                    Assert.AreEqual(testContent, fileContent);
                }

                await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
            }
            finally
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                if (File.Exists(retrievedFilepath))
                {
                    File.Delete(retrievedFilepath);
                }
            }
        }

        [TestMethod]
        public async Task Test_TransferUtility_Precalculated()
        {
            var random = new Random();
            var key = "key-" + random.Next() + ".txt";
            var filePath = Path.Combine(Path.GetTempPath(), key);
            var totalSize = megSize * 20;

            UtilityMethods.GenerateFile(filePath, totalSize);
            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32CHash(File.ReadAllBytes(filePath));

            try
            {
                using (var tu = new TransferUtility(Client))
                {
                    await tu.UploadAsync(new TransferUtilityUploadRequest
                    {
                        BucketName = bucketName,
                        Key = key,
                        FilePath = filePath,
                        ChecksumCRC32C = precalculatedChecksum,
                    });

                    var getObjectResponse = await Client.GetObjectAsync(new GetObjectRequest
                    {
                        BucketName = bucketName,
                        Key = key
                    });
                    Assert.IsNotNull(getObjectResponse.ChecksumCRC32C);
                }

                await Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
            }
            finally
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
        }
    }
}