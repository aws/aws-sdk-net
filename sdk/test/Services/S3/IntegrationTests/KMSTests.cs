using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class KMSTests : IClassFixture<S3BucketFixture>
    {
        private const string key = "foo.txt";
        private const string testContents = "Test contents";
        private static string largeTestContents => new string('@', 6_000_000);
        private static string fileContents = "Test file contents";

        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _tempDirectory;

        public KMSTests(S3BucketFixture bucket)
        {
            _client = bucket.Client;
            _bucketName = bucket.BucketName;
            _tempDirectory = Path.Combine(Path.GetTempPath(), "S3KMSTests-" + Guid.NewGuid().ToString());
            Directory.CreateDirectory(_tempDirectory);
        }

        [Fact]
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
                    Assert.Equal(testContents, data);
                }
            }
            finally
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(usWest2Client, bucketName);
                usWest2Client.Dispose();
                defaultEndpointClient.Dispose();
            }
        }

        [Fact]
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
                    Assert.Equal(testContents, data);
                }
            }
            finally
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(usEast2Client, bucketName);
                usEast2Client.Dispose();
                defaultEndpointClient.Dispose();
            }
        }

        [Fact]
        public async Task TestKmsOverHttp()
        {
            var config = new AmazonS3Config
            {
                RegionEndpoint = _client.Config.RegionEndpoint,
                UseHttp = true
            };

            using (var client = new AmazonS3Client(config))
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    ContentBody = testContents,
                    ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
                };
                await Assert.ThrowsAsync<AmazonS3Exception>(() => client.PutObjectAsync(putObjectRequest));
            }
        }

        [Fact]
        public async Task DefaultKeyTests()
        {
            await TestSseKms(keyId: null, ServerSideEncryptionMethod.AWSKMS);
            await TestPresignedUrls(keyId: null, ServerSideEncryptionMethod.AWSKMS);
        }

        [Fact]
        public async Task KmsDsseTest()
        {
            await TestSseKms(null, ServerSideEncryptionMethod.AWSKMSDSSE);
        }

        [Fact]
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
            var copyResponse = await _client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = _bucketName,
                SourceKey = key,
                DestinationBucket = _bucketName,
                DestinationKey = key2
            });
            Assert.NotNull(copyResponse);

            var usedKeyId = copyResponse.ServerSideEncryptionKeyManagementServiceKeyId;
            Assert.Null(usedKeyId);
        }

        private async Task TestSseKms(string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var putObjectResponse = await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = testContents,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId
            });
            Assert.NotNull(putObjectResponse.ServerSideEncryptionKeyManagementServiceKeyId);

            var usedKeyId = putObjectResponse.ServerSideEncryptionKeyManagementServiceKeyId;
            VerifyKeyId(keyId, usedKeyId);
            await VerifyObject(key, usedKeyId, serverSideEncryptionMethod);
            await VerifyObjectWithTransferUtility();
            await TestCopyPart(key, keyId, serverSideEncryptionMethod);

            var key2 = key + "Copy";
            var copyResponse = await _client.CopyObjectAsync(new CopyObjectRequest
            {
                SourceBucket = _bucketName,
                SourceKey = key,
                DestinationBucket = _bucketName,
                DestinationKey = key2,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId
            });
            Assert.NotNull(copyResponse);

            usedKeyId = copyResponse.ServerSideEncryptionKeyManagementServiceKeyId;
            VerifyKeyId(keyId, usedKeyId);
            await VerifyObject(key2, usedKeyId, serverSideEncryptionMethod);

            var utility = new TransferUtility(_client, new TransferUtilityConfig { MinSizeBeforePartUpload = 5_000_000 });
            await utility.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = keyId,
                InputStream = new MemoryStream(Encoding.UTF8.GetBytes(testContents))
            });
            await VerifyObject(key, keyId, serverSideEncryptionMethod);

            await utility.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
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
            var directoryPath = Path.Combine(_tempDirectory, directoryName);
            for (int i = 0; i < 5; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.WriteFile(filePath, fileContents);
            }

            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10,
            };
            var transferUtility = new TransferUtility(_client, config);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
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
            Assert.Equal(5, keys.Count);

            foreach (var k in keys)
            {
                await VerifyObject(k, keyId, serverSideEncryptionMethod);
            }
        }

        private static readonly HttpClient _httpClient = new HttpClient();

        private async Task TestPresignedGet(string key, string keyId)
        {
            var url = _client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = _bucketName,
                Key = key,
                Expires = DateTime.UtcNow.AddMinutes(5)
            });

            using (var response = await _httpClient.GetAsync(url))
            {
                var usedKeyId = response.Headers.Contains(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader)
                    ? string.Join(",", response.Headers.GetValues(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader))
                    : null;
                VerifyKeyId(keyId, usedKeyId);

                var data = await response.Content.ReadAsStringAsync();
                VerifyContents(data);
            }
        }

        private async Task VerifyPresignedPut(string key, string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var url = _client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = _bucketName,
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

            Assert.NotNull(usedKeyId);
            VerifyKeyId(keyId, usedKeyId);
            await VerifyObject(key, usedKeyId, serverSideEncryptionMethod);
        }

        private async Task TestCopyPart(string key, string keyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            string dstKey = "dstObject";
            string srcKey = key;
            string uploadID = null;

            try
            {
                var gomr = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = _bucketName,
                    Key = srcKey
                });

                var imur = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = dstKey,
                    ServerSideEncryptionMethod = serverSideEncryptionMethod,
                    ServerSideEncryptionKeyManagementServiceKeyId = keyId
                });
                Assert.Equal(serverSideEncryptionMethod, imur.ServerSideEncryptionMethod);
                var usedKeyId = imur.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);
                uploadID = imur.UploadId;

                var response = await _client.CopyPartAsync(new CopyPartRequest
                {
                    DestinationBucket = _bucketName,
                    DestinationKey = dstKey,
                    SourceBucket = _bucketName,
                    SourceKey = srcKey,
                    UploadId = uploadID,
                    PartNumber = 1,
                });
                Assert.Equal(serverSideEncryptionMethod, response.ServerSideEncryptionMethod);
                usedKeyId = response.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);

                Assert.NotNull(response.ETag);
                Assert.True((response.ETag != null) && (response.ETag.Length > 0));
                Assert.NotNull(response.LastModified);
                Assert.NotEqual(DateTime.MinValue, response.LastModified);
                Assert.True(response.PartNumber == 1);

                var completeRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = _bucketName,
                    Key = dstKey,
                    UploadId = uploadID
                };
                completeRequest.AddPartETags(response);

                var completeResponse = await _client.CompleteMultipartUploadAsync(completeRequest);
                Assert.Equal(serverSideEncryptionMethod, completeResponse.ServerSideEncryptionMethod);
                usedKeyId = completeResponse.ServerSideEncryptionKeyManagementServiceKeyId;
                VerifyKeyId(keyId, usedKeyId);
            }
            finally
            {
                if (uploadID != null)
                {
                    await _client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest
                    {
                        BucketName = _bucketName,
                        Key = dstKey,
                        UploadId = uploadID
                    });
                }
            }
        }

        private async Task<string> RetrieveUsedKeyId(string keyId, string url, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            using (var request = new HttpRequestMessage(HttpMethod.Put, url))
            {
                if (keyId != null)
                    request.Headers.TryAddWithoutValidation(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader, keyId);
                request.Headers.TryAddWithoutValidation(HeaderKeys.XAmzServerSideEncryptionHeader, serverSideEncryptionMethod.Value);
                request.Content = new StringContent(testContents);

                using (var response = await _httpClient.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    return response.Headers.Contains(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader)
                        ? string.Join(",", response.Headers.GetValues(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader))
                        : null;
                }
            }
        }

        private async Task VerifyObject(string key, string usedKeyId, ServerSideEncryptionMethod serverSideEncryptionMethod)
        {
            var metadata = await _client.GetObjectMetadataAsync(_bucketName, key);
            if (usedKeyId != null)
            {
                Assert.True(metadata.ServerSideEncryptionKeyManagementServiceKeyId.IndexOf(usedKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            using (var response = await _client.GetObjectAsync(_bucketName, key))
            {
                Assert.Equal(serverSideEncryptionMethod, response.ServerSideEncryptionMethod);
                Assert.NotNull(response.ServerSideEncryptionKeyManagementServiceKeyId);
                if (usedKeyId != null)
                {
                    Assert.True(response.ServerSideEncryptionKeyManagementServiceKeyId.IndexOf(usedKeyId, StringComparison.OrdinalIgnoreCase) >= 0);
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
            var transferUtility = new TransferUtility(_client);
            var filePath = Path.Combine(_tempDirectory, "downloadedFile.txt");
            await transferUtility.DownloadAsync(new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath
            });

            var fileContentsRead = File.ReadAllText(filePath);
            VerifyContents(fileContentsRead);
        }

        private static void VerifyContents(string contents)
        {
            if (contents.Length == testContents.Length)
                Assert.True(string.Equals(testContents, contents, StringComparison.Ordinal));
            else if (contents.Length == largeTestContents.Length)
                Assert.True(string.Equals(largeTestContents, contents, StringComparison.Ordinal));
            else
                Assert.True(string.Equals(fileContents, contents, StringComparison.Ordinal));
        }

        private static void VerifyKeyId(string suppliedKeyId, string returnedKeyId)
        {
            if (suppliedKeyId != null)
            {
                var index = returnedKeyId.IndexOf(suppliedKeyId, StringComparison.OrdinalIgnoreCase);
                Assert.True(index >= 0);
            }
        }
    }
}
