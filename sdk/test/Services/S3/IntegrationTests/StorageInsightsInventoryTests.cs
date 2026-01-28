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
    public class StorageInsightsInventoryTests : TestBase<AmazonS3Client>
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
            var putBucketInventoryConfigurationRequest = new PutBucketInventoryConfigurationRequest
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

            var putBucketInventoryConfigurationResponse = await Client.PutBucketInventoryConfigurationAsync(putBucketInventoryConfigurationRequest);

            var getBucketInventoryConfigurationRequest = new GetBucketInventoryConfigurationRequest
            {
                BucketName = bucketName,
                InventoryId = "configId"
            };

            var getBucketInventoryConfigurationResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketInventoryConfigurationAsync(getBucketInventoryConfigurationRequest);
                return res.InventoryConfiguration?.InventoryId == putBucketInventoryConfigurationRequest.InventoryConfiguration.InventoryId ? res : null;
            });

            var getInventoryConfiguration = getBucketInventoryConfigurationResponse.InventoryConfiguration;
            var putInventoryConfiguration = putBucketInventoryConfigurationRequest.InventoryConfiguration;
            GetBucketInventoryAndValidate(getInventoryConfiguration, putInventoryConfiguration);
            await DeleteInventoryAndValidate();
        }
        
        private static void GetBucketInventoryAndValidate(InventoryConfiguration getInventoryConfiguration, InventoryConfiguration putInventoryConfiguration)
        {
            Assert.AreEqual(getInventoryConfiguration.InventoryId, putInventoryConfiguration.InventoryId);
            Assert.IsTrue(getInventoryConfiguration.IsEnabled.Value);
            Assert.AreEqual(getInventoryConfiguration.Schedule.Frequency, putInventoryConfiguration.Schedule.Frequency);
            Assert.AreEqual(((InventoryPrefixPredicate)getInventoryConfiguration.InventoryFilter.InventoryFilterPredicate).Prefix, "string");
            Assert.AreEqual(getInventoryConfiguration.IncludedObjectVersions, putInventoryConfiguration.IncludedObjectVersions);
            CollectionAssert.AreEqual(getInventoryConfiguration.InventoryOptionalFields, putInventoryConfiguration.InventoryOptionalFields);
        }

        private static async Task DeleteInventoryAndValidate()
        {
            await Client.DeleteBucketInventoryConfigurationAsync(new DeleteBucketInventoryConfigurationRequest
            {
                BucketName = bucketName,
                InventoryId = "configId"
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
