using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    public class S3ExpressTestsFixture : S3ClientFixture
    {
        public string BucketName { get; private set; }

        public static readonly List<string> Keys = new List<string>
        {
            "a/b/c",
            "a/b/d",
            "a/e",
            "a/f",
            "a/g\rh",
            "a/g\ni",
            "a/g&j",
        };

        public const string ContentBody = "Test content";

        public override async ValueTask InitializeAsync()
        {
            Client = new AmazonS3Client(RegionEndpoint.USEast1);
            BucketName = await S3TestUtils.CreateS3ExpressBucketWithWaitAsync(Client, "use1-az5");

            foreach (var key in Keys)
            {
                await Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = BucketName,
                    Key = key,
                    ContentBody = ContentBody
                });
            }
        }

        public override async ValueTask DisposeAsync()
        {
            if (BucketName != null)
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, BucketName);
            await base.DisposeAsync();
        }
    }

    [Trait("Category", "S3")]
    public class S3ExpressTests : IClassFixture<S3ExpressTestsFixture>
    {
        private static readonly int megSize = (int)Math.Pow(2, 20);
        private readonly string _bucketName;
        private readonly AmazonS3Client _usEast1Client;

        public S3ExpressTests(S3ExpressTestsFixture fixture)
        {
            _usEast1Client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        [Fact]
        public async Task ListDirectoryBuckets_ShouldReturnTheCreatedS3ExpressBucket()
        {
            var response = await _usEast1Client.ListDirectoryBucketsAsync(new ListDirectoryBucketsRequest
            {
                MaxDirectoryBuckets = 100,
            });
            Assert.True(response.Buckets.Count >= 1);
            Assert.True(response.Buckets.Any(b => b.BucketName == _bucketName));
        }

        [Fact]
        public async Task ListBuckets_ShouldNotContainS3ExpressBucket()
        {
            var response = await _usEast1Client.ListBucketsAsync();
            Assert.False(response.Buckets.Any(b => b.BucketName == _bucketName));
        }

        [Fact]
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
                }}", policyId, accountId, _bucketName);
            
            await _usEast1Client.PutBucketPolicyAsync(new PutBucketPolicyRequest
            {
                BucketName = _bucketName,
                Policy = policy
            });

            var getBucketPolicyResponse = await _usEast1Client.GetBucketPolicyAsync(_bucketName);
            Assert.True(getBucketPolicyResponse.Policy.Contains(policyId));
            await _usEast1Client.DeleteBucketPolicyAsync(_bucketName);
        }

        [Fact]
        public async Task ListObjects_ShouldContainBucketName()
        {
            var response = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = _bucketName
            });

            foreach (var s3object in response.S3Objects)
            {
                if (!S3ExpressTestsFixture.Keys.Contains(s3object.Key))
                {
                    continue;
                }

                var res = await _usEast1Client.GetObjectAsync(_bucketName, s3object.Key);
                var reader = new StreamReader(res.ResponseStream);
                var objectContent = await reader.ReadToEndAsync();
                Assert.Equal(objectContent, S3ExpressTestsFixture.ContentBody);
            }

            Assert.True(response.S3Objects.Count >= S3ExpressTestsFixture.Keys.Count);
            foreach (var s3Object in response.S3Objects)
            {
                Assert.Equal(s3Object.BucketName, _bucketName);
            }
        }

        [Fact]
        public async Task Test_HeadObject_NoVersionIdExists()
        {
            foreach (var key in S3ExpressTestsFixture.Keys)
            {
                var response = await _usEast1Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                });

                Assert.Equal(null, response.VersionId);
            }
        }

        [Fact]
        public async Task Test_CopyObject_BetweenS3ExpressBuckets()
        {
            var newObjectKey = "Test Object 123";
            var destinationbucketName = await S3TestUtils.CreateS3ExpressBucketWithWaitAsync(_usEast1Client, "use1-az5");

            await _usEast1Client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = _bucketName,
                SourceKey = S3ExpressTestsFixture.Keys[0],
                DestinationBucket = destinationbucketName,
                DestinationKey = newObjectKey,
            });

            var response = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
            {
                BucketName = destinationbucketName
            });
            Assert.True(response.S3Objects.Count == 1);
            Assert.True(response.S3Objects.Any(s3Object => s3Object.Key == newObjectKey));

            var getObjectResponse = await _usEast1Client.GetObjectAsync(destinationbucketName, newObjectKey);
            var reader = new StreamReader(getObjectResponse.ResponseStream);
            var objectContent = await reader.ReadToEndAsync();
            Assert.Equal(objectContent, S3ExpressTestsFixture.ContentBody);

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
                Assert.True(response.S3Objects.Count == 0);
            else
                Assert.Null(response.S3Objects);

            await _usEast1Client.DeleteBucketAsync(destinationbucketName);
            var listDirectoryBucketsResponse = await _usEast1Client.ListDirectoryBucketsAsync(new ListDirectoryBucketsRequest());
            Assert.False(listDirectoryBucketsResponse.Buckets.Any(b => b.BucketName == destinationbucketName));
        }

        [Fact]
        public async Task Test_CopyObject_BetweenRegularBucket_And_S3ExpressBucket()
        {
            var oldObjectKey = "Test Object 123";
            var newObjectKey = "New Test Object 123";
            var newObjectContent = "New Test content";

            // Create regular bucket
            var newRegularBucket = $"{UtilityMethods.SDK_TEST_PREFIX + DateTime.UtcNow.Ticks}";
            await _usEast1Client.PutBucketAsync(newRegularBucket);
            await S3TestUtils.WaitForBucketAsync(_usEast1Client, newRegularBucket);

            try
            {
                // Copy object from S3Express bucket to regular bucket
                await _usEast1Client.CopyObjectAsync(new CopyObjectRequest
                {
                    SourceBucket = _bucketName,
                    SourceKey = S3ExpressTestsFixture.Keys[0],
                    DestinationBucket = newRegularBucket,
                    DestinationKey = oldObjectKey,
                });

                var listObjectsResponse = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
                {
                    BucketName = newRegularBucket
                });
                Assert.True(listObjectsResponse.S3Objects.Count == 1);
                Assert.True(listObjectsResponse.S3Objects.Any(s3Object => s3Object.Key == oldObjectKey));

                var getObjectResponse = await _usEast1Client.GetObjectAsync(newRegularBucket, oldObjectKey);
                var reader = new StreamReader(getObjectResponse.ResponseStream);
                var objectContent = await reader.ReadToEndAsync();
                Assert.Equal(objectContent, S3ExpressTestsFixture.ContentBody);

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
                    Assert.True(listObjectsResponse.S3Objects.Count == 0);
                else
                    Assert.Null(listObjectsResponse.S3Objects);

                // Add new object to regular bucket
                await _usEast1Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = newRegularBucket,
                    Key = newObjectKey,
                    ContentBody = newObjectContent
                });

                // Copy object from regular bucket to S3Express bucket
                await _usEast1Client.CopyObjectAsync(new CopyObjectRequest
                {
                    SourceBucket = newRegularBucket,
                    SourceKey = newObjectKey,
                    DestinationBucket = _bucketName,
                    DestinationKey = newObjectKey,
                });

                listObjectsResponse = await _usEast1Client.ListObjectsV2Async(new ListObjectsV2Request
                {
                    BucketName = _bucketName
                });
                Assert.True(listObjectsResponse.S3Objects.Any(s3Object => s3Object.Key == newObjectKey));

                getObjectResponse = await _usEast1Client.GetObjectAsync(_bucketName, newObjectKey);
                reader = new StreamReader(getObjectResponse.ResponseStream);
                objectContent = await reader.ReadToEndAsync();
                Assert.Equal(objectContent, newObjectContent);

                // Cleanup created objects
                await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = newRegularBucket,
                    Key = newObjectKey
                });

                await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = _bucketName,
                    Key = newObjectKey
                });
            }
            finally
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(_usEast1Client, newRegularBucket);

                var listBucketsResponse = await _usEast1Client.ListBucketsAsync(new ListBucketsRequest());
                Assert.False(listBucketsResponse.Buckets.Any(b => b.BucketName == newRegularBucket));
            }
        }

        [Fact]
        public async Task Test_MultipartUpload()
        {
            var guid = Guid.NewGuid().ToString("N");
            var filePath = Path.Combine(Path.GetTempPath(), "multi-" + guid + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retrieved-" + guid + ".txt");
            var totalSize = megSize * 15;

            UtilityMethods.GenerateFile(filePath, totalSize);
            var key = "key-" + guid;

            var inputStream = File.OpenRead(filePath);
            try
            {
                var initRequest = new InitiateMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    ContentType = "text/html",
                };
                var initResponse = await _usEast1Client.InitiateMultipartUploadAsync(initRequest);
                
                var uploadRequest = new UploadPartRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * megSize,
                    InputStream = inputStream,
                };
                var up1Response = await _usEast1Client.UploadPartAsync(uploadRequest);

                uploadRequest = new UploadPartRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * megSize,
                    InputStream = inputStream,
                };
                var up2Response = await _usEast1Client.UploadPartAsync(uploadRequest);

                uploadRequest = new UploadPartRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream,
                    IsLastPart = true
                };
                var up3Response = await _usEast1Client.UploadPartAsync(uploadRequest);

                var listPartRequest = new ListPartsRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                var listPartResponse = await _usEast1Client.ListPartsAsync(listPartRequest);
                Assert.Equal(3, listPartResponse.Parts.Count);
                Assert.Equal(up1Response.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.Equal(up1Response.ETag, listPartResponse.Parts[0].ETag);
                Assert.Equal(up2Response.PartNumber, listPartResponse.Parts[1].PartNumber);
                Assert.Equal(up2Response.ETag, listPartResponse.Parts[1].ETag);
                Assert.Equal(up3Response.PartNumber, listPartResponse.Parts[2].PartNumber);
                Assert.Equal(up3Response.ETag, listPartResponse.Parts[2].ETag);

                listPartRequest.MaxParts = 1;
                listPartResponse = await _usEast1Client.ListPartsAsync(listPartRequest);
                Assert.Equal(1, listPartResponse.Parts.Count);

                var compRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETags(up1Response, up2Response, up3Response);
                var compResponse = await _usEast1Client.CompleteMultipartUploadAsync(compRequest);
                Assert.NotNull(compResponse.ETag);
                Assert.Equal(key, compResponse.Key);
                Assert.NotNull(compResponse.Location);

                // Get the file back from S3 and make sure it is still the same.
                var getResponse = await _usEast1Client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key
                });
                await getResponse.WriteResponseStreamToFileAsync(retrievedFilepath, append: false, cancellationToken: default);
                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                var metaDataResponse = await _usEast1Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = _bucketName,
                    Key = key
                });
                Assert.Equal("text/html", metaDataResponse.Headers.ContentType);

                var key2 = UtilityMethods.GenerateName("key-");
                var initResponse2 = await _usEast1Client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key2,
                });

                var copyPartResponse = await _usEast1Client.CopyPartAsync(new CopyPartRequest
                {
                    DestinationBucket = _bucketName,
                    DestinationKey = key2,
                    SourceBucket = _bucketName,
                    SourceKey = key,
                    UploadId = initResponse2.UploadId,
                    PartNumber = 1,
                });
                Assert.NotNull(copyPartResponse.ETag);
                Assert.True((copyPartResponse.ETag != null) && (copyPartResponse.ETag.Length > 0));
                Assert.True(copyPartResponse.PartNumber == 1);

                listPartRequest = new ListPartsRequest
                {
                    BucketName = _bucketName,
                    Key = key2,
                    UploadId = initResponse2.UploadId
                };
                listPartResponse = await _usEast1Client.ListPartsAsync(listPartRequest);
                Assert.Equal(1, listPartResponse.Parts.Count);
                Assert.Equal(copyPartResponse.PartNumber, listPartResponse.Parts[0].PartNumber);
                Assert.Equal(copyPartResponse.ETag, listPartResponse.Parts[0].ETag);

                await _usEast1Client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key2,
                    UploadId = initResponse2.UploadId
                });

                await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key
                });
            }
            finally
            {
                inputStream.Close();
                if (File.Exists(filePath)) File.Delete(filePath);
                if (File.Exists(retrievedFilepath)) File.Delete(retrievedFilepath);
            }
        }

        [Fact]
        public async Task Test_TransferUtility()
        {
            var key = "key-" + Guid.NewGuid().ToString("N") + ".txt";
            var filePath = Path.Combine(Path.GetTempPath(), key);
            var retrievedFilepath = filePath + ".download";
            UtilityMethods.GenerateFile(filePath, megSize * 15);

            try
            {
                using (var tu = new TransferUtility(_usEast1Client))
                {
                    await tu.UploadAsync(filePath, _bucketName);

                    var getObjectMetadataResponse = await _usEast1Client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                    {
                        BucketName = _bucketName,
                        Key = key
                    });
                    Assert.True(getObjectMetadataResponse.ETag.Length > 0);

                    await tu.DownloadAsync(new TransferUtilityDownloadRequest
                    {
                        BucketName = _bucketName,
                        Key = key,
                        FilePath = retrievedFilepath
                    });

                    var fileExists = File.Exists(retrievedFilepath);
                    Assert.True(fileExists);

                    var fileContent = File.ReadAllText(retrievedFilepath);
                    var testContent = File.ReadAllText(filePath);
                    Assert.Equal(testContent, fileContent);
                }

                await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key
                });
            }
            finally
            {
                if (File.Exists(filePath)) File.Delete(filePath);
                if (File.Exists(retrievedFilepath)) File.Delete(retrievedFilepath);
            }
        }

        [Fact]
        public async Task Test_TransferUtility_Precalculated()
        {
            var key = "key-" + Guid.NewGuid().ToString("N") + ".txt";
            var filePath = Path.Combine(Path.GetTempPath(), key);
            var totalSize = megSize * 20;

            UtilityMethods.GenerateFile(filePath, totalSize);
            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32CHash(File.ReadAllBytes(filePath));

            try
            {
                using (var tu = new TransferUtility(_usEast1Client))
                {
                    await tu.UploadAsync(new TransferUtilityUploadRequest
                    {
                        BucketName = _bucketName,
                        Key = key,
                        FilePath = filePath,
                        ChecksumCRC32C = precalculatedChecksum,
                    });

                    var getObjectResponse = await _usEast1Client.GetObjectAsync(new GetObjectRequest
                    {
                        BucketName = _bucketName,
                        Key = key
                    });
                    Assert.NotNull(getObjectResponse.ChecksumCRC32C);
                }

                await _usEast1Client.DeleteObjectAsync(new DeleteObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key
                });
            }
            finally
            {
                if (File.Exists(filePath)) File.Delete(filePath);
            }
        }
    }
}

