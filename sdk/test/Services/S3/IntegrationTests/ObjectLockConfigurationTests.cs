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
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class ObjectLockConfigurationTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;        
        private Random random = new Random();
        private static readonly Dictionary<string, string> headers = new Dictionary<string, string>(StringComparer.Ordinal)
        {
            { "Content-Type", "text/html" },
            { "Content-Disposition", "attachment; filename=\"fname.ext\"" }
        };

        [ClassInitialize()]
        public static async Task Initialize(TestContext a)
        {   
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, new PutBucketRequest
            {
                ObjectLockEnabledForBucket = true
            });
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await DeleteBucketObjectsIncludingLocked(Client, bucketName);
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
        }

        public async Task AddObjectLockConfiguration()
        {
            var putResponse = await Client.PutObjectLockConfigurationAsync(new PutObjectLockConfigurationRequest
            {
                BucketName = bucketName,
                RequestPayer = RequestPayer.Requester,
                ObjectLockConfiguration = new ObjectLockConfiguration
                {
                    ObjectLockEnabled = ObjectLockEnabled.Enabled,
                    Rule = new ObjectLockRule
                    {
                        DefaultRetention = new DefaultRetention
                        {
                            Days = 1,
                            Mode = ObjectLockRetentionMode.Governance
                        }
                    }
                }
            });
            Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);

            // Make sure the object lock has been enabled
            await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetObjectLockConfigurationAsync(new GetObjectLockConfigurationRequest
                {
                    BucketName = bucketName
                });

                return res.ObjectLockConfiguration?.ObjectLockEnabled == ObjectLockEnabled.Enabled ? res : null;
            });
        }

        public async Task<string> PutObject(DateTime? retainUntilDate = null)
        {
            var key = "contentBodyPut" + random.Next();
            var content = "This is the content body!";
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = content,
                MD5Digest = AWSSDKUtils.GenerateChecksumForContent(content, true),
            };

            if (retainUntilDate.HasValue)
            {
                putObjectRequest.ObjectLockMode = ObjectLockMode.Governance;
                putObjectRequest.ObjectLockRetainUntilDate = retainUntilDate.Value;
            }
            
            foreach (var kvp in headers)
            {
                putObjectRequest.Headers[kvp.Key] = kvp.Value;
            }                

            await Client.PutObjectAsync(putObjectRequest);
            return key;
        }

        public async Task DeleteObject(string key)
        {
            var deleteResponse = await Client.DeleteObjectAsync(new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                RequestPayer = RequestPayer.Requester,
                BypassGovernanceRetention = true
            });
            Assert.AreEqual(HttpStatusCode.NoContent, deleteResponse.HttpStatusCode);
        }

        public async Task DeleteObjects(List<KeyVersion> objects)
        {
            var deleteResponse = await Client.DeleteObjectsAsync(new DeleteObjectsRequest
            {
                BucketName = bucketName,
                Objects = objects,
                RequestPayer = RequestPayer.Requester,
                BypassGovernanceRetention = true
            });
            Assert.AreEqual(HttpStatusCode.OK, deleteResponse.HttpStatusCode);
        }

        public async Task PutObjectLegalHold(string key, ObjectLockLegalHoldStatus status)
        {
            var putResponse = await Client.PutObjectLegalHoldAsync(new PutObjectLegalHoldRequest
            {
                BucketName = bucketName,
                LegalHold = new ObjectLockLegalHold
                {
                    Status = status
                },
                RequestPayer = RequestPayer.Requester,
                Key = key
            });
            Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);

            var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetObjectLegalHoldAsync(new GetObjectLegalHoldRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    RequestPayer = RequestPayer.Requester
                });
                return res.LegalHold?.Status == status ? res : null;
            });
            Assert.AreEqual(HttpStatusCode.OK, getResponse.HttpStatusCode);
            Assert.AreEqual(status, getResponse.LegalHold.Status);
        }

        [TestMethod]
        public async Task TestObjectLockConfiguration_Set()
        {
            await AddObjectLockConfiguration();
        }
        
        [TestMethod]
        public async Task TestObjectRetention_SetCompliance()
        {
            await AddObjectLockConfiguration();
            DateTime date = DateTime.UtcNow.AddMinutes(15);
            var key = await PutObject();

            try
            {
                var putResponse = await Client.PutObjectRetentionAsync(new PutObjectRetentionRequest
                {
                    BucketName = bucketName,
                    BypassGovernanceRetention = true,
                    Retention = new ObjectLockRetention
                    {
                        Mode = ObjectLockRetentionMode.Governance,
                        RetainUntilDate = date
                    },
                    RequestPayer = RequestPayer.Requester,
                    Key = key
                });
                Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);

                var getResponse = await Client.GetObjectRetentionAsync(new GetObjectRetentionRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    RequestPayer = RequestPayer.Requester
                });
                Assert.AreEqual(HttpStatusCode.OK, getResponse.HttpStatusCode);
                Assert.AreEqual(ObjectLockRetentionMode.Governance, getResponse.Retention.Mode);
                Assert.AreEqual(date.ToString(), getResponse.Retention.RetainUntilDate.ToString());
            }
            finally
            {
                await DeleteObject(key);
            }
        }

        [TestMethod]
        public async Task TestObjectLockRetainUntilDate()
        {
            await AddObjectLockConfiguration();
            DateTime date = DateTime.UtcNow.AddMinutes(15);
            var key = await PutObject(date);

            try
            {                
                var getResponse = await Client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    RequestPayer = RequestPayer.Requester
                });
                Assert.AreEqual(HttpStatusCode.OK, getResponse.HttpStatusCode);
                Assert.AreEqual(date.ToUniversalTime().ToString(), getResponse.ObjectLockRetainUntilDate.ToString());                
            }
            finally
            {
                await DeleteObject(key);
            }
        }

        [TestMethod]
        public async Task TestObjectLegalHold_SetUnset()
        {
            await AddObjectLockConfiguration();
            var key = await PutObject();

            try
            {
                await PutObjectLegalHold(key, ObjectLockLegalHoldStatus.On);
                await PutObjectLegalHold(key, ObjectLockLegalHoldStatus.Off);
            }
            finally
            {
                await DeleteObject(key);
            }
        }

        [TestMethod]
        public async Task TestMultipleObjectDeleteWithBypass()
        {
            await AddObjectLockConfiguration();
            var objects = new List<KeyVersion>();
                            
            try
            {
                for (var i = 0; i < 3; i++)
                {
                    objects.Add(new KeyVersion
                    {
                        Key = await PutObject()
                    });
                }
            }
            finally
            {
                await DeleteObjects(objects);
            }
        }

        private static async Task DeleteBucketObjectsIncludingLocked(IAmazonS3 s3Client, string bucketName)
        {            
            var listVersionsRequest = new ListVersionsRequest
            {
                BucketName = bucketName
            };

            ListVersionsResponse listVersionsResponse;

            // Iterate through the objects in the bucket and delete them.
            do
            {
                // List all the versions of all the objects in the bucket.
                listVersionsResponse = await s3Client.ListVersionsAsync(listVersionsRequest);

                if (listVersionsResponse.Versions.Count == 0)
                {
                    // If the bucket has no objects break the loop.
                    break;
                }

                var keyVersionList = new List<KeyVersion>(listVersionsResponse.Versions.Count);
                for (int index = 0; index < listVersionsResponse.Versions.Count; index++)
                {
                    keyVersionList.Add(new KeyVersion
                    {
                        Key = listVersionsResponse.Versions[index].Key,
                        VersionId = listVersionsResponse.Versions[index].VersionId
                    });
                }

                try
                {
                    // Delete the current set of objects.
                    await s3Client.DeleteObjectsAsync(new DeleteObjectsRequest
                    {
                        BucketName = bucketName,
                        Objects = keyVersionList,                        
                        BypassGovernanceRetention = true
                    });
                }
                catch
                {
                    // Ignore exceptions and continue deleting remaining objects.
                }

                // Set the markers to get next set of objects from the bucket.
                listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;
            }
            // Continue listing objects and deleting them until the bucket is empty.
            while (listVersionsResponse.IsTruncated.Value);
        }
    }
}