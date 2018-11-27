/*
 * Copyright 2011-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for the object lock configuration operations
    /// </summary>
    [TestClass]
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
        public static void Initialize(TestContext a)
        {   
            bucketName = S3TestUtils.CreateBucket(Client, new PutBucketRequest
            {
                ObjectLockEnabledForBucket = true                
            });
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);            
            BaseClean();
        }

        public PutObjectLockConfigurationResponse AddObjectLockConfiguration()
        {            
            var objectLockConfiguration = new ObjectLockConfiguration();
            objectLockConfiguration.ObjectLockEnabled = ObjectLockEnabled.Enabled;
            objectLockConfiguration.Rule = new ObjectLockRule
            {
                DefaultRetention = new DefaultRetention
                {
                    Days = 1,                    
                    Mode = ObjectLockRetentionMode.Governance
                }
            };

            var putRequest = new PutObjectLockConfigurationRequest
            {
                BucketName = bucketName,
                RequestPayer = RequestPayer.Requester,
                ObjectLockConfiguration = objectLockConfiguration
            };

            var putResponse = Client.PutObjectLockConfiguration(putRequest);
            Assert.AreEqual(true, putResponse.HttpStatusCode == HttpStatusCode.OK);

            return putResponse;
        }

        public string PutObject()
        {
            var key = "contentBodyPut" + random.Next();
            var content = "This is the content body!";
            var putObjectRequest = new PutObjectRequest()
            {
                BucketName = bucketName,
                Key = key,
                ContentBody = content,
                MD5Digest = AmazonS3Util.GenerateChecksumForContent(content, true)                
            };

            //Set the headers
            foreach (var kvp in headers)
            {
                putObjectRequest.Headers[kvp.Key] = kvp.Value;
            }                

            Client.PutObject(putObjectRequest);
            return key;
        }

        public void DeleteObject(string key)
        {
            var deleteRequest = new DeleteObjectRequest
            {
                BucketName = bucketName,
                Key = key,
                RequestPayer = RequestPayer.Requester,
                BypassGovernanceRetention = true
            };

            var deleteResponse = Client.DeleteObject(deleteRequest);
            Assert.AreEqual(true, deleteResponse.HttpStatusCode == HttpStatusCode.NoContent);
        }
        public void DeleteObjects(List<KeyVersion> objects)
        {
            var deleteRequest = new DeleteObjectsRequest
            {
                BucketName = bucketName,
                Objects = objects,
                RequestPayer = RequestPayer.Requester,
                BypassGovernanceRetention = true
            };

            var deleteResponse = Client.DeleteObjects(deleteRequest);
            Assert.AreEqual(true, deleteResponse.HttpStatusCode == HttpStatusCode.OK);
        }

        public void PutObjectLegalHold(string key, ObjectLockLegalHoldStatus status)
        {
            //Put the legal hold
            var objectLegalHold = new ObjectLockLegalHold();
            objectLegalHold.Status = status;
            var putRequest = new PutObjectLegalHoldRequest
            {
                BucketName = bucketName,
                LegalHold = objectLegalHold,
                RequestPayer = RequestPayer.Requester,
                Key = key
            };

            var putResponse = Client.PutObjectLegalHold(putRequest);
            Assert.AreEqual(true, putResponse.HttpStatusCode == HttpStatusCode.OK);

            //Get the legal hold
            var getRequest = new GetObjectLegalHoldRequest
            {
                BucketName = bucketName,
                Key = key,
                RequestPayer = RequestPayer.Requester
            };

            var getResponse = Client.GetObjectLegalHold(getRequest);
            Assert.AreEqual(true, putResponse.HttpStatusCode == HttpStatusCode.OK);
            Assert.AreEqual(status, getResponse.LegalHold.Status);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestObjectLockConfiguration_Set()
        {
            AddObjectLockConfiguration();
        }
        
        [TestMethod]
        [TestCategory("S3")]
        public void TestObjectRetention_SetCompliance()
        {
            AddObjectLockConfiguration();

            DateTime date = DateTime.Now.AddMinutes(1);
            var key = PutObject();

            try
            {
                //Put the object retention on the specific object
                var putRequest = new PutObjectRetentionRequest
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
                };

                var putResponse = Client.PutObjectRetention(putRequest);
                Assert.AreEqual(true, putResponse.HttpStatusCode == HttpStatusCode.OK);

                //Get the object retention
                var getRequest = new GetObjectRetentionRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    RequestPayer = RequestPayer.Requester
                };

                var getResponse = Client.GetObjectRetention(getRequest);
                Assert.AreEqual(true, putResponse.HttpStatusCode == HttpStatusCode.OK);

                Assert.AreEqual(ObjectLockRetentionMode.Governance, getResponse.Retention.Mode);
                Assert.AreEqual(date.ToString(), getResponse.Retention.RetainUntilDate.ToString());
            }
            catch
            {
                throw;
            }
            finally
            {
                DeleteObject(key);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestObjectLegalHold_SetUnset()
        {
            AddObjectLockConfiguration();

            var key = PutObject();
            try
            {
                PutObjectLegalHold(key, ObjectLockLegalHoldStatus.On);
                PutObjectLegalHold(key, ObjectLockLegalHoldStatus.Off);
            }
            catch
            {
                throw;
            }
            finally
            {
                DeleteObject(key);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestMultipleObjectDeleteWithBypass()
        {
            AddObjectLockConfiguration();

            List<KeyVersion> objects = new List<KeyVersion>();
                            
            try
            {
                for (var i = 0; i < 3; i++)
                {
                    objects.Add(new KeyVersion
                    {
                        Key = PutObject()
                    });
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                DeleteObjects(objects);
            }
        }

    }
}