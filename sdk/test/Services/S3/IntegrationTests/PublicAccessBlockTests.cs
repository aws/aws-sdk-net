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
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for the public access block operations
    /// </summary>
    [TestClass]
    public class PublicAccessBlockTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;
        private static IAmazonS3 s3Client = null;

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            var config = new AmazonS3Config();
            s3Client = new AmazonS3Client(config);
            bucketName = S3TestUtils.CreateBucket(s3Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
            s3Client.Dispose();
            BaseClean();
        }
                
        private PutPublicAccessBlockResponse Call_PutPublicAccessBlock(IAmazonS3 client, string bucketName, bool blockPublicAcls = true, 
            bool blockPublicPolicy = true, bool ignorePublicAcls = true, bool restrictPublicBucket = true)
        {
            PutPublicAccessBlockRequest putRequest = new PutPublicAccessBlockRequest
            {
                BucketName = bucketName,
                PublicAccessBlockConfiguration = new PublicAccessBlockConfiguration
                {
                    BlockPublicAcls = true,
                    BlockPublicPolicy = true,
                    IgnorePublicAcls = true,
                    RestrictPublicBuckets = true
                }
            };

            var putResponse = client.PutPublicAccessBlock(putRequest);
            Assert.AreEqual(true, putResponse.HttpStatusCode == HttpStatusCode.OK);

            return putResponse;
        }

        private GetPublicAccessBlockResponse Call_GetPublicAccessBlock(IAmazonS3 client, string bucketName)
        {
            var getRequest = new GetPublicAccessBlockRequest
            {
                BucketName = bucketName
            };

            var getResponse = client.GetPublicAccessBlock(getRequest);
            Assert.AreEqual(true, getResponse.HttpStatusCode == HttpStatusCode.OK);

            return getResponse;
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonS3Exception), "The public access block configuration was not found")]
        public void TestDeletePublicAccessBlock()
        {
            try
            {
                //Add public access block configuration
                Call_PutPublicAccessBlock(s3Client, bucketName);

                //Verify the configuration exists            
                Call_GetPublicAccessBlock(s3Client, bucketName);

                //Delete the configuration
                var deleteRequest = new DeletePublicAccessBlockRequest
                {
                    BucketName = bucketName
                };
                var deleteResponse = s3Client.DeletePublicAccessBlock(deleteRequest);
                Assert.AreEqual(true, deleteResponse.HttpStatusCode == HttpStatusCode.NoContent);

                //Verify the configuration was deleted. This call will throw a public access block configuration was not found message.
                Call_GetPublicAccessBlock(s3Client, bucketName);
            }
            catch (AmazonS3Exception ex)
            {
                Assert.AreEqual<string>("The public access block configuration was not found", ex.Message);
                throw;
            }
        }
        
        [TestMethod]
        [TestCategory("S3")]
        public void TestPutPublicAccessBlock()
        {
            Call_PutPublicAccessBlock(s3Client, bucketName);            
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestGetPublicAccessBlock()
        {
            string[] testProperties =
            {
                nameof(PublicAccessBlockConfiguration.BlockPublicAcls),
                nameof(PublicAccessBlockConfiguration.BlockPublicPolicy),
                nameof(PublicAccessBlockConfiguration.IgnorePublicAcls),
                nameof(PublicAccessBlockConfiguration.RestrictPublicBuckets)
            };
            
            //Set each property in PublicAccessBlockConfiguration, do the put, then do the get to test that the value was set.
            foreach (string propertyName in testProperties)
            {
                var putRequest = new PutPublicAccessBlockRequest
                {
                    BucketName = bucketName,
                    PublicAccessBlockConfiguration = new PublicAccessBlockConfiguration
                    {
                        BlockPublicAcls = false,
                        BlockPublicPolicy = false,
                        IgnorePublicAcls = false,
                        RestrictPublicBuckets = false
                    }
                };

                System.Reflection.PropertyInfo property = putRequest.PublicAccessBlockConfiguration.GetType().GetProperty(propertyName);
                property.SetValue(putRequest.PublicAccessBlockConfiguration, true);

                var putResponse = s3Client.PutPublicAccessBlock(putRequest);
                Assert.AreEqual(true, putResponse.HttpStatusCode == HttpStatusCode.OK);

                var getResponse = Call_GetPublicAccessBlock(s3Client, bucketName);
                Assert.AreEqual(putRequest.PublicAccessBlockConfiguration.BlockPublicAcls, getResponse.PublicAccessBlockConfiguration.BlockPublicAcls);
                Assert.AreEqual(putRequest.PublicAccessBlockConfiguration.BlockPublicPolicy, getResponse.PublicAccessBlockConfiguration.BlockPublicPolicy);
                Assert.AreEqual(putRequest.PublicAccessBlockConfiguration.IgnorePublicAcls, getResponse.PublicAccessBlockConfiguration.IgnorePublicAcls);
                Assert.AreEqual(putRequest.PublicAccessBlockConfiguration.RestrictPublicBuckets, getResponse.PublicAccessBlockConfiguration.RestrictPublicBuckets);
            }
        }
        
    }
}