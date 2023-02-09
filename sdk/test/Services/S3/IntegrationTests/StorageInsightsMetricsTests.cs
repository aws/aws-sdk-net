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
    /// Tests for StorageInsightsMetrics
    /// </summary>
    [TestClass]
    public class StorageInsightsMetricsTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;
        private const string accessPointArn = "arn:aws:s3:us-east-1:123456789012:accesspoint:myendpoint";

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
            AWSConfigsS3.UseSignatureVersion4 = true;            
            BucketMetricsConfigurationsAndFilterTest();
            BucketMetricsConfigurationsPrefixFilterTest();
            BucketMetricssConfigurationsTagFilterTest();
            BucketMetricsConfigurationAccessPointArnFilterTest();
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketAnalyticsConfigurationsTestWithS3SigV2()
        {
            AWSConfigsS3.UseSignatureVersion4 = false;            
            BucketMetricsConfigurationsAndFilterTest();
            BucketMetricsConfigurationsPrefixFilterTest();
            BucketMetricssConfigurationsTagFilterTest();
            BucketMetricsConfigurationAccessPointArnFilterTest();
        }

        public void BucketMetricssConfigurationsTagFilterTest()
        {
            Tag tag = new Tag()
            {
                Key = "tagK",
                Value = "tagV"
            };
            PutBucketMetricsConfigurationRequest putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest()
            {
                BucketName = bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration()
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter()
                    {
                        MetricsFilterPredicate = new MetricsTagPredicate(tag)
                    }
                }
            };
            var putBucketMetricsConfigurationResponse = Client.PutBucketMetricsConfiguration(putBucketMetricsConfigurationRequest);

            GetBucketMetricsConfigurationRequest getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest()
            {
                MetricsId = "configId",
                BucketName = bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketMetricsConfiguration(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.AreEqual(((MetricsTagPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Tag.Key, "tagK");
            Assert.AreEqual(((MetricsTagPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Tag.Value, "tagV");

            ListBucketMetrics();

            DeleteBucketMetricsAndValidate();
        }

        public void BucketMetricsConfigurationsPrefixFilterTest()
        {
            PutBucketMetricsConfigurationRequest putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest()
            {
                BucketName = bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration()
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter()
                    {
                        MetricsFilterPredicate = new MetricsPrefixPredicate("string")
                    }
                }
            };
            var putBucketMetricsConfigurationResponse = Client.PutBucketMetricsConfiguration(putBucketMetricsConfigurationRequest);

            GetBucketMetricsConfigurationRequest getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest()
            {
                MetricsId = "configId",
                BucketName = bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketMetricsConfiguration(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.AreEqual(((MetricsPrefixPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Prefix, "string");


            ListBucketMetrics();

            DeleteBucketMetricsAndValidate();
        }

        public void BucketMetricsConfigurationAccessPointArnFilterTest()
        {
            PutBucketMetricsConfigurationRequest putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest()
            {
                BucketName = bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration()
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter()
                    {
                        MetricsFilterPredicate = new MetricsAccessPointArnPredicate(accessPointArn)
                    }
                }
            };
            var putBucketMetricsConfigurationResponse = Client.PutBucketMetricsConfiguration(putBucketMetricsConfigurationRequest);

            GetBucketMetricsConfigurationRequest getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest()
            {
                MetricsId = "configId",
                BucketName = bucketName
            };

            var getBucketMetricsConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketMetricsConfiguration(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.AreEqual(((MetricsAccessPointArnPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).AccessPointArn, accessPointArn);


            ListBucketMetrics();

            DeleteBucketMetricsAndValidate();
        }

        public void BucketMetricsConfigurationsAndFilterTest()
        {
            Tag tag = new Tag()
            {
                Key = "tagK",
                Value = "tagV"
            };
            List<MetricsFilterPredicate> list = new List<MetricsFilterPredicate>();
            list.Add(new MetricsPrefixPredicate("string"));
            list.Add(new MetricsTagPredicate(tag));
            list.Add(new MetricsAccessPointArnPredicate(accessPointArn));
            PutBucketMetricsConfigurationRequest putBucketMetricsConfigurationRequest = new PutBucketMetricsConfigurationRequest()
            {
                BucketName = bucketName,
                MetricsId = "configId",
                MetricsConfiguration = new MetricsConfiguration()
                {
                    MetricsId = "configId",
                    MetricsFilter = new MetricsFilter()
                    {
                        MetricsFilterPredicate = new MetricsAndOperator(list)
                    }
                }
            };
            var putBucketMetricsConfigurationResponse = Client.PutBucketMetricsConfiguration(putBucketMetricsConfigurationRequest);

            GetBucketMetricsConfigurationRequest getBucketMetricsConfigurationRequest = new GetBucketMetricsConfigurationRequest()
            {
                MetricsId = "configId",
                BucketName = bucketName
            };
                        
            var getBucketMetricsConfigurationResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketMetricsConfiguration(getBucketMetricsConfigurationRequest);
                return res.MetricsConfiguration?.MetricsId == getBucketMetricsConfigurationRequest.MetricsId ? res : null;
            });

            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);

            foreach (var predicate in ((MetricsNAryOperator)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Operands)
            {
                if (predicate is MetricsPrefixPredicate)
                {
                    Assert.AreEqual(((MetricsPrefixPredicate)predicate).Prefix, "string");
                }
                else if (predicate is MetricsTagPredicate)
                {
                    Assert.AreEqual(((MetricsTagPredicate)predicate).Tag.Key, "tagK");
                    Assert.AreEqual(((MetricsTagPredicate)predicate).Tag.Value, "tagV");
                }
                else
                {
                    Assert.AreEqual(((MetricsAccessPointArnPredicate)predicate).AccessPointArn, accessPointArn);
                }
            }

            ListBucketMetrics();

            DeleteBucketMetricsAndValidate();
        }

        private static void ListBucketMetrics()
        {
            ListBucketMetricsConfigurationsRequest listBucketMetricsConfigurationRequest = new ListBucketMetricsConfigurationsRequest()
            {
                BucketName = bucketName
            };

            var listBucketMetricsConfigurationResponse = Client.ListBucketMetricsConfigurations(listBucketMetricsConfigurationRequest);
            Assert.IsTrue(listBucketMetricsConfigurationResponse.MetricsConfigurationList.Count > 0);
        }

        private static void DeleteBucketMetricsAndValidate()
        {
            DeleteBucketMetricsConfigurationRequest deleteBucketMetricsConfigurationRequest = new DeleteBucketMetricsConfigurationRequest()
            {
                BucketName = bucketName,
                MetricsId = "configId"
            };

            var deleteBucketMetricsConfigurationResponse = Client.DeleteBucketMetricsConfiguration(deleteBucketMetricsConfigurationRequest);

            var response = Client.ListObjects(new ListObjectsRequest()
            {
                BucketName = bucketName
            });

            var successFlag = true;
            if (response.S3Objects.Count > 0)
            {
                successFlag = false;
            }

            Assert.IsTrue(successFlag);
        }
    }
}
