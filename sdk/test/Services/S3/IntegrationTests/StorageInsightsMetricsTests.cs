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
    public class StorageInsightsMetricsTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        private const string accessPointArn = "arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint";

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
            await BucketMetricsConfigurationsAndFilterTest();
            await BucketMetricsConfigurationsPrefixFilterTest();
            await BucketMetricsConfigurationsTagFilterTest();
            await BucketMetricsConfigurationAccessPointArnFilterTest();
        }

        public async Task BucketMetricsConfigurationsTagFilterTest()
        {
            var putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest
            {
                BucketName = bucketName,
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

            var putBucketMetricsConfigurationResponse = await Client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.AreEqual(((MetricsTagPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Tag.Key, "tagK");
            Assert.AreEqual(((MetricsTagPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Tag.Value, "tagV");

            await ListBucketMetrics();
            await DeleteBucketMetricsAndValidate();
        }

        public async Task BucketMetricsConfigurationsPrefixFilterTest()
        {
            var putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest
            {
                BucketName = bucketName,
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

            var putBucketMetricsConfigurationResponse = await Client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.AreEqual(((MetricsPrefixPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Prefix, "string");

            await ListBucketMetrics();
            await DeleteBucketMetricsAndValidate();
        }

        public async Task BucketMetricsConfigurationAccessPointArnFilterTest()
        {
            var putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest
            {
                BucketName = bucketName,
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

            var putBucketMetricsConfigurationResponse = await Client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = bucketName
            };

            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.AreEqual(((MetricsAccessPointArnPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).AccessPointArn, accessPointArn);

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
                BucketName = bucketName,
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

            var putBucketMetricsConfigurationResponse = await Client.PutBucketMetricsConfigurationAsync(putBucketMetricsConfigurationRequest);
            var getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest
            {
                MetricsId = "configId",
                BucketName = bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketMetricsConfigurationAsync(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);

            foreach (var predicate in ((MetricsNAryOperator)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Operands)
            {
                if (predicate is MetricsPrefixPredicate prefixPredicate)
                {
                    Assert.AreEqual(prefixPredicate.Prefix, "string");
                }
                else if (predicate is MetricsTagPredicate tagPredicate)
                {
                    Assert.AreEqual(tagPredicate.Tag.Key, "tagK");
                    Assert.AreEqual(tagPredicate.Tag.Value, "tagV");
                }
                else
                {
                    Assert.AreEqual(((MetricsAccessPointArnPredicate)predicate).AccessPointArn, accessPointArn);
                }
            }

            await ListBucketMetrics();
            await DeleteBucketMetricsAndValidate();
        }

        private static async Task ListBucketMetrics()
        {
            var listResponse = await Client.ListBucketMetricsConfigurationsAsync(new ListBucketMetricsConfigurationsRequest
            {
                BucketName = bucketName
            });
            Assert.IsTrue(listResponse.MetricsConfigurationList.Count > 0);
        }

        private static async Task DeleteBucketMetricsAndValidate()
        {
            await Client.DeleteBucketMetricsConfigurationAsync(new DeleteBucketMetricsConfigurationRequest
            {
                BucketName = bucketName,
                MetricsId = "configId"
            });

            var response = await Client.ListObjectsAsync(new ListObjectsRequest
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
    }
}
