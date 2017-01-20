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
    /// Tests for StorageInsightsInventory
    /// </summary>
    [TestClass]
    public class StorageInsightsInventoryTests
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
            BucketInventoryConfigurationsAndFilterTest();
        }

        [TestCategory("S3")]
        [TestMethod]
        public void BucketAnalyticsConfigurationsTestWithS3SigV2()
        {
            AWSConfigsS3.UseSignatureVersion4 = false;
            CreateTestBase();
            BucketInventoryConfigurationsAndFilterTest();
        }

        public void BucketInventoryConfigurationsAndFilterTest()
        {
            PutBucketInventoryConfigurationRequest putBucketInventoryConfigurationRequest = new PutBucketInventoryConfigurationRequest()
            {
                BucketName = bucketName,
                InventoryId = "configId",
                InventoryConfiguration = new InventoryConfiguration
                {
                    Destination = new InventoryDestination
                    {
                        S3BucketDestination = new InventoryS3BucketDestination
                        {
                            AccountId = "599169622985",
                            BucketName = "arn:aws:s3:::" + bucketName,
                            InventoryFormat = InventoryFormat.CSV,
                            Prefix = "prefix"
                        }
                    },
                    IsEnabled = true,
                    InventoryFilter = new InventoryFilter()
                    {
                        InventoryFilterPredicate = new InventoryPrefixPredicate("string")
                    },
                    InventoryId = "configId",
                    IncludedObjectVersions = InventoryIncludedObjectVersions.All,
                    InventoryOptionalFields = new List<InventoryOptionalField>{InventoryOptionalField.Size,
                                                                               InventoryOptionalField.LastModifiedDate,
                                                                               InventoryOptionalField.StorageClass,
                                                                               InventoryOptionalField.ETag,
                                                                               InventoryOptionalField.IsMultipartUploaded,
                                                                               InventoryOptionalField.ReplicationStatus
                                                                               },
                    Schedule = new InventorySchedule
                    {
                        Frequency = InventoryFrequency.Daily
                    }
                }
            };
            var putBucketInventoryConfigurationResponse = Client.PutBucketInventoryConfiguration(putBucketInventoryConfigurationRequest);

            GetBucketInventoryConfigurationRequest getBucketInventoryConfigurationRequest = new GetBucketInventoryConfigurationRequest()
            {
                BucketName = bucketName,
                InventoryId = "configId"
            };

            var getBucketInventoryConfigurationResponse = Client.GetBucketInventoryConfiguration(getBucketInventoryConfigurationRequest);
            var getInventoryConfiguration = getBucketInventoryConfigurationResponse.InventoryConfiguration;
            var putInventoryConfiguration = putBucketInventoryConfigurationRequest.InventoryConfiguration;
            GetBucketInventoryAndValidate(getInventoryConfiguration, putInventoryConfiguration);

            ListBucketInventory();

            DeleteInventoryAndValidate();
        }

        private static void GetBucketInventoryAndValidate(InventoryConfiguration getInventoryConfiguration, InventoryConfiguration putInventoryConfiguration)
        {
            Assert.AreEqual(getInventoryConfiguration.InventoryId, putInventoryConfiguration.InventoryId);
            Assert.IsTrue(getInventoryConfiguration.IsEnabled);
            Assert.AreEqual(getInventoryConfiguration.Schedule.Frequency, putInventoryConfiguration.Schedule.Frequency);
            Assert.AreEqual(((InventoryPrefixPredicate)getInventoryConfiguration.InventoryFilter.InventoryFilterPredicate).Prefix, "string");
            Assert.AreEqual(getInventoryConfiguration.IncludedObjectVersions, putInventoryConfiguration.IncludedObjectVersions);
            CollectionAssert.AreEqual(getInventoryConfiguration.InventoryOptionalFields, putInventoryConfiguration.InventoryOptionalFields);
        }

        private static void ListBucketInventory()
        {
            ListBucketInventoryConfigurationsRequest listBucketInventoryConfigurationsRequest = new ListBucketInventoryConfigurationsRequest()
            {
                BucketName = bucketName
            };

            var listBucketInventoryConfigurationResponse = Client.ListBucketInventoryConfigurations(listBucketInventoryConfigurationsRequest);
        }

        private static void DeleteInventoryAndValidate()
        {
            DeleteBucketInventoryConfigurationRequest deleteBucketInventoryConfigurationRequest = new DeleteBucketInventoryConfigurationRequest()
            {
                BucketName = bucketName,
                InventoryId = "configId"
            };

            var deleteBucketInventoryConfigurationResponse = Client.DeleteBucketInventoryConfiguration(deleteBucketInventoryConfigurationRequest);

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
