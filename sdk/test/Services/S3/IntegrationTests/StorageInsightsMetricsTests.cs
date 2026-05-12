using Amazon.S3;
using Amazon.S3.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class StorageInsightsMetricsTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;
        private const string accessPointArn = "arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint";

        public StorageInsightsMetricsTests(S3BucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        [Fact]
        public async Task BucketAnalyticsConfigurationsTestWithSigV4()
        {
            await BucketMetricsConfigurationsAndFilterTest();
            await BucketMetricsConfigurationsPrefixFilterTest();
            await BucketMetricsConfigurationsTagFilterTest();
            await BucketMetricsConfigurationAccessPointArnFilterTest();
        }

        public async Task BucketMetricsConfigurationsTagFilterTest()
        {
            var putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest
            {
                BucketName = _bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter
                    {
                        MetricsFilterPredicate = new MetricsTagPredicate(new Tag
                        {
                            Key = "tagK",
                            Value = "tagV"
                        })
                    }
                }
            };

            var putBucketMetricsConfigurationResponse = await _client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = _bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.Equal(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.Equal(((MetricsTagPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Tag.Key, "tagK");
            Assert.Equal(((MetricsTagPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Tag.Value, "tagV");

            await ListBucketMetrics();
            await DeleteBucketMetricsAndValidate();
        }

        public async Task BucketMetricsConfigurationsPrefixFilterTest()
        {
            var putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest
            {
                BucketName = _bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter
                    {
                        MetricsFilterPredicate = new MetricsPrefixPredicate("string")
                    }
                }
            };

            var putBucketMetricsConfigurationResponse = await _client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = _bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.Equal(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.Equal(((MetricsPrefixPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Prefix, "string");

            await ListBucketMetrics();
            await DeleteBucketMetricsAndValidate();
        }

        public async Task BucketMetricsConfigurationAccessPointArnFilterTest()
        {
            var putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest
            {
                BucketName = _bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter
                    {
                        MetricsFilterPredicate = new MetricsAccessPointArnPredicate(accessPointArn)
                    }
                }
            };

            var putBucketMetricsConfigurationResponse = await _client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = _bucketName
            };

            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.Equal(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.Equal(((MetricsAccessPointArnPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).AccessPointArn, accessPointArn);

            await ListBucketMetrics();
            await DeleteBucketMetricsAndValidate();
        }

        public async Task BucketMetricsConfigurationsAndFilterTest()
        {
            var list = new List<MetricsFilterPredicate>
            {
                new MetricsPrefixPredicate("string"),
                new MetricsTagPredicate(new Tag
                {
                    Key = "tagK",
                    Value = "tagV"
                }),
                new MetricsAccessPointArnPredicate(accessPointArn)
            };

            var putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest
            {
                BucketName = _bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter
                    {
                        MetricsFilterPredicate = new MetricsAndOperator(list)
                    }
                }
            };

            var putBucketMetricsConfigurationResponse = await _client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = _bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.Equal(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);

            foreach (var predicate in ((MetricsNAryOperator)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Operands)
            {
                if (predicate is MetricsPrefixPredicate prefixPredicate)
                {
                    Assert.Equal(prefixPredicate.Prefix, "string");
                }
                else if (predicate is MetricsTagPredicate tagPredicate)
                {
                    Assert.Equal(tagPredicate.Tag.Key, "tagK");
                    Assert.Equal(tagPredicate.Tag.Value, "tagV");
                }
                else
                {
                    Assert.Equal(((MetricsAccessPointArnPredicate)predicate).AccessPointArn, accessPointArn);
                }
            }

            await ListBucketMetrics();
            await DeleteBucketMetricsAndValidate();
        }

        private async Task ListBucketMetrics()
        {
            var listResponse = await _client.ListBucketMetricsConfigurationsAsync(new ListBucketMetricsConfigurationsRequest
            {
                BucketName = _bucketName
            });
            Assert.True(listResponse.MetricsConfigurationList.Count > 0);
        }

        private async Task DeleteBucketMetricsAndValidate()
        {
            await _client.DeleteBucketMetricsConfigurationAsync(new DeleteBucketMetricsConfigurationRequest
            {
                BucketName = _bucketName,
                MetricsId = "configId"
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
