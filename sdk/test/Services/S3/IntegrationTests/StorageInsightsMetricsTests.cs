/*
 * Copyright 2011-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    public class StorageInsightsMetricsTests
    {
        public static string bucketName;
        public static AmazonS3Client Client;

        public static void CreateTestBase()
        {
            Client = new AmazonS3Client();
            bucketName = S3TestUtils.CreateBucket(Client);


            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName
            });
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketAnalyticsConfigurationsTestWithSigV4()
        {
            AWSConfigsS3.UseSignatureVersion4 = true;
            CreateTestBase();
            BucketMetricsConfigurationsAndFilterTest();
            BucketMetricsConfigurationsPrefixFilterTest();
            BucketMetricssConfigurationsTagFilterTest();
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketAnalyticsConfigurationsTestWithS3SigV2()
        {
            AWSConfigsS3.UseSignatureVersion4 = false;
            CreateTestBase();
            BucketMetricsConfigurationsAndFilterTest();
            BucketMetricsConfigurationsPrefixFilterTest();
            BucketMetricssConfigurationsTagFilterTest();
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

            var getBucketMetricsConfigurationResponse = Client.GetBucketMetricsConfiguration(getBucketMetricsConfigurationRequest);
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

            var getBucketMetricsConfigurationResponse = Client.GetBucketMetricsConfiguration(getBucketMetricsConfigurationRequest);
            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);
            Assert.AreEqual(((MetricsPrefixPredicate)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Prefix, "string");


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

            var getBucketMetricsConfigurationResponse = Client.GetBucketMetricsConfiguration(getBucketMetricsConfigurationRequest);
            var getMetricsConfiguration = getBucketMetricsConfigurationResponse.MetricsConfiguration;
            var putMetricsConfiguration = putBucketMetricsConfigurationRequest.MetricsConfiguration;
            Assert.AreEqual(getMetricsConfiguration.MetricsId, putMetricsConfiguration.MetricsId);

            foreach (var predicate in ((MetricsNAryOperator)getMetricsConfiguration.MetricsFilter.MetricsFilterPredicate).Operands)
            {
                if (predicate is MetricsPrefixPredicate)
                {
                    Assert.AreEqual(((MetricsPrefixPredicate)predicate).Prefix, "string");
                }
                else
                {
                    Assert.AreEqual(((MetricsTagPredicate)predicate).Tag.Key, "tagK");
                    Assert.AreEqual(((MetricsTagPredicate)predicate).Tag.Value, "tagV");
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
