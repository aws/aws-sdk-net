using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.Util;
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
    public class ObjectLockConfigurationTestsFixture : S3ClientFixture
    {
        public string BucketName { get; private set; }

        public override async ValueTask InitializeAsync()
        {
            await base.InitializeAsync();
            BucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, new PutBucketRequest
            {
                ObjectLockEnabledForBucket = true,
            });

            await Client.PutObjectLockConfigurationAsync(new PutObjectLockConfigurationRequest
            {
                BucketName = BucketName,
                RequestPayer = RequestPayer.Requester,
                ObjectLockConfiguration = new ObjectLockConfiguration
                {
                    ObjectLockEnabled = ObjectLockEnabled.Enabled,
                    Rule = new ObjectLockRule
                    {
                        DefaultRetention = new DefaultRetention
                        {
                            Days = 1,
                            Mode = ObjectLockRetentionMode.Governance
                        }
                    }
                }
            });
        }

        public override async ValueTask DisposeAsync()
        {
            if (BucketName != null)
            {
                // AmazonS3Util.DeleteS3BucketWithObjectsAsync does not bypass governance retention,
                // so we must delete all object versions with BypassGovernanceRetention=true first.
                await S3TestUtils.DeleteObjects(Client, BucketName, bypassGovernanceRetention: true);
                await Client.DeleteBucketAsync(BucketName);
            }
            await base.DisposeAsync();
        }
    }

    [Trait("Category", "S3")]
    public class ObjectLockConfigurationTests : IClassFixture<ObjectLockConfigurationTestsFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private readonly string _testId;

        private static readonly Dictionary<string, string> headers = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "Content-Type", "text/html" },
            { "Content-Disposition", "attachment; filename=\"fname.ext\"" }
        };

        public ObjectLockConfigurationTests(ObjectLockConfigurationTestsFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
            _testId = Guid.NewGuid().ToString("N");
        }

        public async Task<string> PutObject(DateTime? retainUntilDate = null)
        {
            var key = _testId + "-contentBodyPut";
            var content = "This is the content body!";
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = content,
                MD5Digest = AWSSDKUtils.GenerateChecksumForContent(content, true),
            };

            if (retainUntilDate.HasValue)
            {
                putObjectRequest.ObjectLockMode = ObjectLockMode.Governance;
                putObjectRequest.ObjectLockRetainUntilDate = retainUntilDate.Value;
            }
            
            foreach (var kvp in headers)
            {
                putObjectRequest.Headers[kvp.Key] = kvp.Value;
            }                

            await _client.PutObjectAsync(putObjectRequest);
            return key;
        }

        public async Task DeleteObject(string key)
        {
            var deleteResponse = await _client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                RequestPayer = RequestPayer.Requester,
                BypassGovernanceRetention = true
            });
            Assert.Equal(HttpStatusCode.NoContent, deleteResponse.HttpStatusCode);
        }

        public async Task DeleteObjects(List<KeyVersion> objects)
        {
            var deleteResponse = await _client.DeleteObjectsAsync(new DeleteObjectsRequest
            {
                BucketName = _bucketName,
                Objects = objects,
                RequestPayer = RequestPayer.Requester,
                BypassGovernanceRetention = true
            });
            Assert.Equal(HttpStatusCode.OK, deleteResponse.HttpStatusCode);
        }

        public async Task PutObjectLegalHold(string key, ObjectLockLegalHoldStatus status)
        {
            var putResponse = await _client.PutObjectLegalHoldAsync(new PutObjectLegalHoldRequest
            {
                BucketName = _bucketName,
                LegalHold = new ObjectLockLegalHold
                {
                    Status = status
                },
                RequestPayer = RequestPayer.Requester,
                Key = key
            });
            Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);

            var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetObjectLegalHoldAsync(new GetObjectLegalHoldRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    RequestPayer = RequestPayer.Requester
                });
                return res.LegalHold?.Status == status ? res : null;
            });
            Assert.Equal(HttpStatusCode.OK, getResponse.HttpStatusCode);
            Assert.Equal(status, getResponse.LegalHold.Status);
        }
        
        [Fact]
        public async Task TestObjectRetention_SetCompliance()
        {
            var date = DateTime.UtcNow.AddMinutes(15);
            var key = await PutObject();

            try
            {
                var putResponse = await _client.PutObjectRetentionAsync(new PutObjectRetentionRequest
                {
                    BucketName = _bucketName,
                    BypassGovernanceRetention = true,
                    Retention = new ObjectLockRetention
                    {
                        Mode = ObjectLockRetentionMode.Governance,
                        RetainUntilDate = date
                    },
                    RequestPayer = RequestPayer.Requester,
                    Key = key
                });
                Assert.Equal(HttpStatusCode.OK, putResponse.HttpStatusCode);

                var getResponse = await _client.GetObjectRetentionAsync(new GetObjectRetentionRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    RequestPayer = RequestPayer.Requester
                });
                Assert.Equal(HttpStatusCode.OK, getResponse.HttpStatusCode);
                Assert.Equal(ObjectLockRetentionMode.Governance, getResponse.Retention.Mode);
                Assert.Equal(date.ToString(), getResponse.Retention.RetainUntilDate.ToString());
            }
            finally
            {
                await DeleteObject(key);
            }
        }

        [Fact]
        public async Task TestObjectLockRetainUntilDate()
        {
            var date = DateTime.UtcNow.AddMinutes(15);
            var key = await PutObject(date);

            try
            {                
                var getResponse = await _client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    RequestPayer = RequestPayer.Requester
                });
                Assert.Equal(HttpStatusCode.OK, getResponse.HttpStatusCode);
                Assert.Equal(date.ToUniversalTime().ToString(), getResponse.ObjectLockRetainUntilDate.ToString());                
            }
            finally
            {
                await DeleteObject(key);
            }
        }

        [Fact]
        public async Task TestObjectLegalHold_SetUnset()
        {
            var key = await PutObject();

            try
            {
                await PutObjectLegalHold(key, ObjectLockLegalHoldStatus.On);
                await PutObjectLegalHold(key, ObjectLockLegalHoldStatus.Off);
            }
            finally
            {
                await DeleteObject(key);
            }
        }

        [Fact]
        public async Task TestMultipleObjectDeleteWithBypass()
        {
            var objects = new List<KeyVersion>();
                            
            try
            {
                for (var i = 0; i < 3; i++)
                {
                    objects.Add(new KeyVersion
                    {
                        Key = await PutObject()
                    });
                }
            }
            finally
            {
                await DeleteObjects(objects);
            }
        }

        [Fact]
        public async Task TestUploadFileWithTransferUtility()
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(_client, transferConfig);
            var content = new string('a', 7000000);
            var key = UtilityMethods.GenerateName(nameof(ObjectLockConfigurationTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");

            // NOTE: In ObjectLockMode.Compliance mode, a protected object version can't be deleted by any user, including the root user.
            var desiredObjectLockLegalHoldStatus = ObjectLockLegalHoldStatus.Off;
            var desiredObjectLockMode = ObjectLockMode.Governance;
            var desiredObjectLockRetainUntilDate = DateTime.UtcNow.Date.AddDays(5);

            using (var writer = File.CreateText(filePath))
            {
                await writer.WriteAsync(content);
            }

            await transfer.UploadAsync(new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath,
                ObjectLockLegalHoldStatus = desiredObjectLockLegalHoldStatus,
                ObjectLockMode = desiredObjectLockMode,
                ObjectLockRetainUntilDate = desiredObjectLockRetainUntilDate
            });

            using (var getResponse = await _client.GetObjectAsync(_bucketName, key))
            {
                var getBody = await new StreamReader(getResponse.ResponseStream).ReadToEndAsync();
                Assert.Equal(content, getBody);
                Assert.Equal(desiredObjectLockLegalHoldStatus, getResponse.ObjectLockLegalHoldStatus);
                Assert.Equal(desiredObjectLockMode, getResponse.ObjectLockMode);
                Assert.Equal(desiredObjectLockRetainUntilDate.Date, getResponse.ObjectLockRetainUntilDate.Value.ToUniversalTime().Date);
            }
        }
    }
}
