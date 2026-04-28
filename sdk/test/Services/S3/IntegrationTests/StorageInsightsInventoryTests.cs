using Amazon.S3;
using Amazon.S3.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class StorageInsightsInventoryTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public StorageInsightsInventoryTests(S3BucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        [Fact]
        public async Task BucketAnalyticsConfigurationsTestWithSigV4()
        {
            var putBucketInventoryConfigurationRequest = new PutBucketInventoryConfigurationRequest
            {
                BucketName = _bucketName,
                InventoryId = "configId",
                InventoryConfiguration = new InventoryConfiguration
                {
                    Destination = new InventoryDestination
                    {
                        S3BucketDestination = new InventoryS3BucketDestination
                        {
                            AccountId = "599169622985",
                            BucketName = "arn:aws:s3:::" + _bucketName,
                            InventoryFormat = InventoryFormat.CSV,
                            Prefix = "prefix"
                        }
                    },
                    IsEnabled = true,
                    InventoryFilter = new InventoryFilter
                    {
                        InventoryFilterPredicate = new InventoryPrefixPredicate("string")
                    },
                    InventoryId = "configId",
                    IncludedObjectVersions = InventoryIncludedObjectVersions.All,
                    InventoryOptionalFields = new List<InventoryOptionalField>
                    {
                        InventoryOptionalField.Size,
                        InventoryOptionalField.LastModifiedDate,
                        InventoryOptionalField.StorageClass,
                        InventoryOptionalField.ETag,
                        InventoryOptionalField.IsMultipartUploaded,
                        InventoryOptionalField.ReplicationStatus,
                        InventoryOptionalField.EncryptionStatus,
                        InventoryOptionalField.ObjectLockRetainUntilDate,
                        InventoryOptionalField.ObjectLockMode,
                        InventoryOptionalField.ObjectLockLegalHoldStatus,
                    },
                    Schedule = new InventorySchedule
                    {
                        Frequency = InventoryFrequency.Daily
                    }
                }
            };

            var putBucketInventoryConfigurationResponse = await _client.PutBucketInventoryConfigurationAsync(putBucketInventoryConfigurationRequest);

            var getBucketInventoryConfigurationRequest = new GetBucketInventoryConfigurationRequest
            {
                BucketName = _bucketName,
                InventoryId = "configId"
            };

            var getBucketInventoryConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketInventoryConfigurationAsync(getBucketInventoryConfigurationRequest);
                return res.InventoryConfiguration?.InventoryId == putBucketInventoryConfigurationRequest.InventoryConfiguration.InventoryId ? res : null;
            });

            var getInventoryConfiguration = getBucketInventoryConfigurationResponse.InventoryConfiguration;
            var putInventoryConfiguration = putBucketInventoryConfigurationRequest.InventoryConfiguration;
            GetBucketInventoryAndValidate(getInventoryConfiguration, putInventoryConfiguration);
            await DeleteInventoryAndValidate();
        }
        
        private static void GetBucketInventoryAndValidate(InventoryConfiguration getInventoryConfiguration, InventoryConfiguration putInventoryConfiguration)
        {
            Assert.Equal(getInventoryConfiguration.InventoryId, putInventoryConfiguration.InventoryId);
            Assert.True(getInventoryConfiguration.IsEnabled.Value);
            Assert.Equal(getInventoryConfiguration.Schedule.Frequency, putInventoryConfiguration.Schedule.Frequency);
            Assert.Equal(((InventoryPrefixPredicate)getInventoryConfiguration.InventoryFilter.InventoryFilterPredicate).Prefix, "string");
            Assert.Equal(getInventoryConfiguration.IncludedObjectVersions, putInventoryConfiguration.IncludedObjectVersions);
            Assert.Equal(getInventoryConfiguration.InventoryOptionalFields, putInventoryConfiguration.InventoryOptionalFields);
        }

        private async Task DeleteInventoryAndValidate()
        {
            await _client.DeleteBucketInventoryConfigurationAsync(new DeleteBucketInventoryConfigurationRequest
            {
                BucketName = _bucketName,
                InventoryId = "configId"
            });

            var response = await _client.ListObjectsAsync(new ListObjectsRequest
            {
                BucketName = _bucketName
            });

            var successFlag = true;
            if (response.S3Objects != null && response.S3Objects.Count > 0)
            {
                successFlag = false;
            }

            Assert.True(successFlag);
        }
    }
}
