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
using System;
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
using ThirdParty.MD5;
using System.Collections.Generic;
using Amazon;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Tests for StorageInsightsAnalytics
    /// </summary>
    [TestClass]
    public class StorageInsightsAnalyticsTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        
        [TestInitialize]
        public void Init()
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [TestCleanup]
        public void Cleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketAnalyticsConfigurationsTestWithSigV4()
        {
            BucketAnalyticsConfigurationsAndFilterTest();
            BucketAnalyticsConfigurationsPrefixFilterTest();
            BucketAnalyticsConfigurationsTagFilterTest();
        }

        public void BucketAnalyticsConfigurationsAndFilterTest()
        {
            Tag tag = new Tag()
            {
                Key = "tagK",
                Value = "tagV"
            };
            List<AnalyticsFilterPredicate> list = new List<AnalyticsFilterPredicate>();
            list.Add(new AnalyticsPrefixPredicate("string"));
            list.Add(new AnalyticsTagPredicate(tag));
            PutBucketAnalyticsConfigurationRequest putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest()
            {
                BucketName = bucketName,
                AnalyticsId = "configId",
                AnalyticsConfiguration = new AnalyticsConfiguration()
                {
                    AnalyticsFilter = new AnalyticsFilter()
                    {
                        AnalyticsFilterPredicate = new AnalyticsAndOperator(list)
                    },
                    AnalyticsId = "configId",
                    StorageClassAnalysis = new StorageClassAnalysis()
                    {
                        DataExport = new StorageClassAnalysisDataExport()
                        {
                            OutputSchemaVersion = StorageClassAnalysisSchemaVersion.V_1,
                            Destination = new AnalyticsExportDestination()
                            {
                                S3BucketDestination = new AnalyticsS3BucketDestination()
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
            var putBucketAnalyticsConfigurationResponse = Client.PutBucketAnalyticsConfiguration(putBucketAnalyticsConfigurationRequest);

            GetBucketAnalyticsConfigurationRequest getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest()
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            };

            var getBucketAnalyticsConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketAnalyticsConfiguration(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });
            
            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;

            foreach (var predicate in ((AnalyticsNAryOperator)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Operands)
            {
                if (predicate is AnalyticsPrefixPredicate)
                {
                    Assert.AreEqual(((AnalyticsPrefixPredicate)predicate).Prefix, "string");
                }
                else
                {
                    Assert.AreEqual(((AnalyticsTagPredicate)predicate).Tag.Key, "tagK");
                    Assert.AreEqual(((AnalyticsTagPredicate)predicate).Tag.Value, "tagV");
                }
            }

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);

            ListBucketAnalytics();

            DeleteAnalyticsBucketAndValidate();


        }

        public void BucketAnalyticsConfigurationsPrefixFilterTest()
        {
            PutBucketAnalyticsConfigurationRequest putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest()
            {
                BucketName = bucketName,
                AnalyticsId = "configId",
                AnalyticsConfiguration = new AnalyticsConfiguration()
                {
                    AnalyticsFilter = new AnalyticsFilter()
                    {
                        AnalyticsFilterPredicate = new AnalyticsPrefixPredicate("string")
                    },
                    AnalyticsId = "configId",
                    StorageClassAnalysis = new StorageClassAnalysis()
                    {
                        DataExport = new StorageClassAnalysisDataExport()
                        {
                            OutputSchemaVersion = StorageClassAnalysisSchemaVersion.V_1,
                            Destination = new AnalyticsExportDestination()
                            {
                                S3BucketDestination = new AnalyticsS3BucketDestination()
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
            var putBucketAnalyticsConfigurationResponse = Client.PutBucketAnalyticsConfiguration(putBucketAnalyticsConfigurationRequest);

            GetBucketAnalyticsConfigurationRequest getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest()
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            };
                        
            var getBucketAnalyticsConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketAnalyticsConfiguration(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });

            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;

            Assert.AreEqual(((AnalyticsPrefixPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Prefix, "string");

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);


            ListBucketAnalytics();
            
            DeleteAnalyticsBucketAndValidate();
        }

        public void BucketAnalyticsConfigurationsTagFilterTest()
        {
            Tag tag = new Tag()
            {
                Key = "tagK",
                Value = "tagV"
            };
            PutBucketAnalyticsConfigurationRequest putBucketAnalyticsConfigurationRequest = new PutBucketAnalyticsConfigurationRequest()
            {
                BucketName = bucketName,
                AnalyticsId = "configId",
                AnalyticsConfiguration = new AnalyticsConfiguration()
                {
                    AnalyticsFilter = new AnalyticsFilter()
                    {
                        AnalyticsFilterPredicate = new AnalyticsTagPredicate(tag)
                    },
                    AnalyticsId = "configId",
                    StorageClassAnalysis = new StorageClassAnalysis()
                    {
                        DataExport = new StorageClassAnalysisDataExport()
                        {
                            OutputSchemaVersion = StorageClassAnalysisSchemaVersion.V_1,
                            Destination = new AnalyticsExportDestination()
                            {
                                S3BucketDestination = new AnalyticsS3BucketDestination()
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
            var putBucketAnalyticsConfigurationResponse = Client.PutBucketAnalyticsConfiguration(putBucketAnalyticsConfigurationRequest);

            GetBucketAnalyticsConfigurationRequest getBucketAnalyticsConfigurationRequest = new GetBucketAnalyticsConfigurationRequest()
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            };
                        
            var getBucketAnalyticsConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketAnalyticsConfiguration(getBucketAnalyticsConfigurationRequest);
                return res.AnalyticsConfiguration?.AnalyticsId == putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration.AnalyticsId ? res : null;
            });

            var getAnalyticsConfiguration = getBucketAnalyticsConfigurationResponse.AnalyticsConfiguration;
            var putAnalyticsConfiguration = putBucketAnalyticsConfigurationRequest.AnalyticsConfiguration;
            Assert.AreEqual(((AnalyticsTagPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Tag.Key, "tagK");
            Assert.AreEqual(((AnalyticsTagPredicate)getAnalyticsConfiguration.AnalyticsFilter.AnalyticsFilterPredicate).Tag.Value, "tagV");

            GetBucketAnalyticsValidation(getAnalyticsConfiguration, putAnalyticsConfiguration);

            ListBucketAnalytics();

            DeleteAnalyticsBucketAndValidate();
        }

        private static void ListBucketAnalytics()
        {
            ListBucketAnalyticsConfigurationsRequest listBucketAnalyticsConfigurationsRequest = new ListBucketAnalyticsConfigurationsRequest()
            {
                BucketName = bucketName
            };

            var response = Client.ListBucketAnalyticsConfigurations(listBucketAnalyticsConfigurationsRequest);
        }

        private static void DeleteAnalyticsBucketAndValidate()
        {
            DeleteBucketAnalyticsConfigurationRequest deleteBucketAnalyticsConfigurationRequest = new DeleteBucketAnalyticsConfigurationRequest()
            {
                BucketName = bucketName,
                AnalyticsId = "configId"
            };

            var deleteBucketAnalyticsConfigurationResponse = Client.DeleteBucketAnalyticsConfiguration(deleteBucketAnalyticsConfigurationRequest);

            var response = Client.ListObjects(new ListObjectsRequest()
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
