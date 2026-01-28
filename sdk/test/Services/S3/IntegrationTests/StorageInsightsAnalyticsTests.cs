/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class StorageInsightsAnalyticsTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        
        [TestInitialize]
        public async Task Init()
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
        }

        [TestMethod]
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
                BucketName = bucketName,
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
                                    BucketName = "arn:aws:s3:::" + bucketName
                                }
                            }
                        }
                    }
                }
            };

            var putBucketAnalyticsConfigurationResponse = await Client.PutBucketAnalyticsConfigurationAsync(putBucketAnalyticsConfigurationRequest);

            var getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            };

            var getBucketAnalyticsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketAnalyticsConfigurationAsync(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });
            
            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;

            foreach (var predicate in ((AnalyticsNAryOperator)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Operands)
            {
                if (predicate is AnalyticsPrefixPredicate prefixPredicate)
                {
                    Assert.AreEqual(prefixPredicate.Prefix, "string");
                }
                else
                {
                    Assert.AreEqual(((AnalyticsTagPredicate)predicate).Tag.Key, "tagK");
                    Assert.AreEqual(((AnalyticsTagPredicate)predicate).Tag.Value, "tagV");
                }
            }

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);
            await DeleteAnalyticsBucketAndValidate();
        }

        public async Task BucketAnalyticsConfigurationsPrefixFilterTest()
        {
            var putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest
            {
                BucketName = bucketName,
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
                                    BucketName = "arn:aws:s3:::" + bucketName
                                }
                            }
                        }
                    }
                }
            };

            var putBucketAnalyticsConfigurationResponse = await Client.PutBucketAnalyticsConfigurationAsync(putBucketAnalyticsConfigurationRequest);

            var getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            };
                        
            var getBucketAnalyticsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketAnalyticsConfigurationAsync(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });

            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;
            Assert.AreEqual(((AnalyticsPrefixPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Prefix, "string");

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);
            await DeleteAnalyticsBucketAndValidate();
        }

        public async Task BucketAnalyticsConfigurationsTagFilterTest()
        {
            var putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest
            {
                BucketName = bucketName,
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
                                    BucketName = "arn:aws:s3:::" + bucketName
                                }
                            }
                        }
                    }
                }
            };

            var putBucketAnalyticsConfigurationResponse = await Client.PutBucketAnalyticsConfigurationAsync(putBucketAnalyticsConfigurationRequest);
            var getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            };
                        
            var getBucketAnalyticsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketAnalyticsConfigurationAsync(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });

            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;
            Assert.AreEqual(((AnalyticsTagPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Tag.Key, "tagK");
            Assert.AreEqual(((AnalyticsTagPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Tag.Value, "tagV");

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);
            await DeleteAnalyticsBucketAndValidate();
        }

        private static async Task DeleteAnalyticsBucketAndValidate()
        {
            await Client.DeleteBucketAnalyticsConfigurationAsync(new DeleteBucketAnalyticsConfigurationRequest
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            });

            var response = await Client.ListObjectsAsync(new ListObjectsRequest()
            {
                BucketName = bucketName
            });

            var successFlag = true;
            if (response.S3Objects != null && response.S3Objects.Count > 0)
            {
                successFlag = false;
            }

            Assert.IsTrue(successFlag);
        }

        private static void GetBucketAnalyticsValidation(AnalyticsConfiguration getAnalyticsConfiguration, AnalyticsConfiguration putAnalyticsConfiguration)
        {
            Assert.AreEqual(getAnalyticsConfiguration.AnalyticsId, putAnalyticsConfiguration.AnalyticsId);
            var getDestination = getAnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination;
            var getOutputSchemaVersion = getAnalyticsConfiguration.StorageClassAnalysis.DataExport.OutputSchemaVersion;
            var getS3BucketDestination = getDestination.S3BucketDestination;

            var putDestination = putAnalyticsConfiguration.StorageClassAnalysis.DataExport.Destination;
            var putOutputSchemaVersion = putAnalyticsConfiguration.StorageClassAnalysis.DataExport.OutputSchemaVersion;
            var putS3BucketDestination = putDestination.S3BucketDestination;

            Assert.AreEqual(getOutputSchemaVersion, putOutputSchemaVersion);
            Assert.AreEqual(getS3BucketDestination.BucketName, putS3BucketDestination.BucketName);
            Assert.AreEqual(getS3BucketDestination.BucketAccountId, putS3BucketDestination.BucketAccountId);
            Assert.AreEqual(getS3BucketDestination.Format, putS3BucketDestination.Format);
            Assert.AreEqual(getS3BucketDestination.Prefix, putS3BucketDestination.Prefix);
        }
    }
}
