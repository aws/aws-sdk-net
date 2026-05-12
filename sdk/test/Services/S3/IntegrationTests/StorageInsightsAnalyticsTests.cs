using Amazon.S3;
using Amazon.S3.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class StorageInsightsAnalyticsTests : IClassFixture<S3BucketFixture>
    {
        private readonly AmazonS3Client _client;
        private readonly string _bucketName;

        public StorageInsightsAnalyticsTests(S3BucketFixture fixture)
        {
            _client = fixture.Client;
            _bucketName = fixture.BucketName;
        }

        [Fact]
        public async Task BucketAnalyticsConfigurationsTestWithSigV4()
        {
            await BucketAnalyticsConfigurationsAndFilterTest();
            await BucketAnalyticsConfigurationsPrefixFilterTest();
            await BucketAnalyticsConfigurationsTagFilterTest();
        }

        public async Task BucketAnalyticsConfigurationsAndFilterTest()
        {
            var list = new List<AnalyticsFilterPredicate>
            {
                new AnalyticsPrefixPredicate("string"),
                new AnalyticsTagPredicate(new Tag
                {
                    Key = "tagK",
                    Value = "tagV"
                })
            };

            var putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest
            {
                BucketName = _bucketName,
                AnalyticsId = "configId",
                AnalyticsConfiguration = new AnalyticsConfiguration
                {
                    AnalyticsFilter = new AnalyticsFilter
                    {
                        AnalyticsFilterPredicate = new AnalyticsAndOperator(list)
                    },
                    AnalyticsId = "configId",
                    StorageClassAnalysis = new StorageClassAnalysis
                    {
                        DataExport = new StorageClassAnalysisDataExport
                        {
                            OutputSchemaVersion = StorageClassAnalysisSchemaVersion.V_1,
                            Destination = new AnalyticsExportDestination
                            {
                                S3BucketDestination = new AnalyticsS3BucketDestination
                                {
                                    Format = AnalyticsS3ExportFileFormat.CSV,
                                    BucketAccountId = "599169622985",
                                    Prefix = "string",
                                    BucketName = "arn:aws:s3:::" + _bucketName
                                }
                            }
                        }
                    }
                }
            };

            var putBucketAnalyticsConfigurationResponse = await _client.PutBucketAnalyticsConfigurationAsync(putBucketAnalyticsConfigurationRequest);

            var getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest
            {
                BucketName = _bucketName,
                AnalyticsId = "configId"
            };

            var getBucketAnalyticsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketAnalyticsConfigurationAsync(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });
            
            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;

            foreach (var predicate in ((AnalyticsNAryOperator)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Operands)
            {
                if (predicate is AnalyticsPrefixPredicate prefixPredicate)
                {
                    Assert.Equal(prefixPredicate.Prefix, "string");
                }
                else
                {
                    Assert.Equal(((AnalyticsTagPredicate)predicate).Tag.Key, "tagK");
                    Assert.Equal(((AnalyticsTagPredicate)predicate).Tag.Value, "tagV");
                }
            }

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);
            await DeleteAnalyticsBucketAndValidate();
        }

        public async Task BucketAnalyticsConfigurationsPrefixFilterTest()
        {
            var putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest
            {
                BucketName = _bucketName,
                AnalyticsId = "configId",
                AnalyticsConfiguration = new AnalyticsConfiguration
                {
                    AnalyticsFilter = new AnalyticsFilter
                    {
                        AnalyticsFilterPredicate = new AnalyticsPrefixPredicate("string")
                    },
                    AnalyticsId = "configId",
                    StorageClassAnalysis = new StorageClassAnalysis
                    {
                        DataExport = new StorageClassAnalysisDataExport
                        {
                            OutputSchemaVersion = StorageClassAnalysisSchemaVersion.V_1,
                            Destination = new AnalyticsExportDestination
                            {
                                S3BucketDestination = new AnalyticsS3BucketDestination
                                {
                                    Format = AnalyticsS3ExportFileFormat.CSV,
                                    BucketAccountId = "599169622985",
                                    Prefix = "string",
                                    BucketName = "arn:aws:s3:::" + _bucketName
                                }
                            }
                        }
                    }
                }
            };

            var putBucketAnalyticsConfigurationResponse = await _client.PutBucketAnalyticsConfigurationAsync(putBucketAnalyticsConfigurationRequest);

            var getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest
            {
                BucketName = _bucketName,
                AnalyticsId = "configId"
            };
                        
            var getBucketAnalyticsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketAnalyticsConfigurationAsync(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });

            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;
            Assert.Equal(((AnalyticsPrefixPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Prefix, "string");

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);
            await DeleteAnalyticsBucketAndValidate();
        }

        public async Task BucketAnalyticsConfigurationsTagFilterTest()
        {
            var putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest
            {
                BucketName = _bucketName,
                AnalyticsId = "configId",
                AnalyticsConfiguration = new AnalyticsConfiguration
                {
                    AnalyticsFilter = new AnalyticsFilter
                    {
                        AnalyticsFilterPredicate = new AnalyticsTagPredicate(new Tag
                        {
                            Key = "tagK",
                            Value = "tagV"
                        })
                    },
                    AnalyticsId = "configId",
                    StorageClassAnalysis = new StorageClassAnalysis
                    {
                        DataExport = new StorageClassAnalysisDataExport
                        {
                            OutputSchemaVersion = StorageClassAnalysisSchemaVersion.V_1,
                            Destination = new AnalyticsExportDestination
                            {
                                S3BucketDestination = new AnalyticsS3BucketDestination
                                {
                                    Format = AnalyticsS3ExportFileFormat.CSV,
                                    BucketAccountId = "599169622985",
                                    Prefix = "string",
                                    BucketName = "arn:aws:s3:::" + _bucketName
                                }
                            }
                        }
                    }
                }
            };

            var putBucketAnalyticsConfigurationResponse = await _client.PutBucketAnalyticsConfigurationAsync(putBucketAnalyticsConfigurationRequest);
            var getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest
            {
                BucketName = _bucketName,
                AnalyticsId = "configId"
            };
                        
            var getBucketAnalyticsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await _client.GetBucketAnalyticsConfigurationAsync(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });

            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;
            Assert.Equal(((AnalyticsTagPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Tag.Key, "tagK");
            Assert.Equal(((AnalyticsTagPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Tag.Value, "tagV");

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);
            await DeleteAnalyticsBucketAndValidate();
        }

        private async Task DeleteAnalyticsBucketAndValidate()
        {
            await _client.DeleteBucketAnalyticsConfigurationAsync(new DeleteBucketAnalyticsConfigurationRequest
            {
                BucketName = _bucketName,
                AnalyticsId = "configId"
            });

            var response = await _client.ListObjectsAsync(new ListObjectsRequest()
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

        private static void GetBucketAnalyticsValidation(AnalyticsConfiguration getAnalyticsConfiguration, AnalyticsConfiguration putAnalyticsConfiguration)
        {
            Assert.Equal(getAnalyticsConfiguration.AnalyticsId, putAnalyticsConfiguration.AnalyticsId);
            var getDestination = getAnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination;
            var getOutputSchemaVersion = getAnalyticsConfiguration.StorageClassAnalysis.DataExport.OutputSchemaVersion;
            var getS3BucketDestination = getDestination.S3BucketDestination;

            var putDestination = putAnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination;
            var putOutputSchemaVersion = putAnalyticsConfiguration.StorageClassAnalysis.DataExport.OutputSchemaVersion;
            var putS3BucketDestination = putDestination.S3BucketDestination;

            Assert.Equal(getOutputSchemaVersion, putOutputSchemaVersion);
            Assert.Equal(getS3BucketDestination.BucketName, putS3BucketDestination.BucketName);
            Assert.Equal(getS3BucketDestination.BucketAccountId, putS3BucketDestination.BucketAccountId);
            Assert.Equal(getS3BucketDestination.Format, putS3BucketDestination.Format);
            Assert.Equal(getS3BucketDestination.Prefix, putS3BucketDestination.Prefix);
        }
    }
}
