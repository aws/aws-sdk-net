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
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class PublicAccessBlockTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;
     
        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {            
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);         
            BaseClean();
        }
                
        private async Task<PublicAccessBlockConfiguration> CallPutPublicAccessBlock()
        {
            var configuration = new PublicAccessBlockConfiguration
            {
                BlockPublicAcls = true,
                BlockPublicPolicy = true,
                IgnorePublicAcls = true,
                RestrictPublicBuckets = true
            };

            var putResponse = await Client.PutPublicAccessBlockAsync(new PutPublicAccessBlockRequest
            {
                BucketName = bucketName,
                PublicAccessBlockConfiguration = configuration
            });
            Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);

            return configuration;
        }

        private async Task CallGetPublicAccessBlock(PublicAccessBlockConfiguration expectedConfiguration)
        {
            var getRequest = new GetPublicAccessBlockRequest
            {
                BucketName = bucketName
            };

            if (expectedConfiguration == null)
            {
                // If expectedConfiguration is null then we want GetPublicAccessBlock to throw an exception because the configuration was removed.
                await Client.GetPublicAccessBlockAsync(getRequest);
                Assert.Fail("An expected exception was not thrown");
            }
            
            var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetPublicAccessBlockAsync(getRequest);
                return res.HttpStatusCode == HttpStatusCode.OK
                    && expectedConfiguration.BlockPublicAcls == res.PublicAccessBlockConfiguration.BlockPublicAcls
                    && expectedConfiguration.BlockPublicPolicy == res.PublicAccessBlockConfiguration.BlockPublicPolicy
                    && expectedConfiguration.IgnorePublicAcls == res.PublicAccessBlockConfiguration.IgnorePublicAcls
                    && expectedConfiguration.RestrictPublicBuckets == res.PublicAccessBlockConfiguration.RestrictPublicBuckets ? res : null;
            });
                        
            Assert.AreEqual(expectedConfiguration.BlockPublicAcls, getResponse.PublicAccessBlockConfiguration.BlockPublicAcls);
            Assert.AreEqual(expectedConfiguration.BlockPublicPolicy, getResponse.PublicAccessBlockConfiguration.BlockPublicPolicy);
            Assert.AreEqual(expectedConfiguration.IgnorePublicAcls, getResponse.PublicAccessBlockConfiguration.IgnorePublicAcls);
            Assert.AreEqual(expectedConfiguration.RestrictPublicBuckets, getResponse.PublicAccessBlockConfiguration.RestrictPublicBuckets);
        }

        [TestMethod]
        public async Task TestDeletePublicAccessBlock()
        {
            var configuration = await CallPutPublicAccessBlock();
            await CallGetPublicAccessBlock(configuration);

            var deleteResponse = await Client.DeletePublicAccessBlockAsync(new DeletePublicAccessBlockRequest
            {
                BucketName = bucketName
            });
            Assert.AreEqual(HttpStatusCode.NoContent, deleteResponse.HttpStatusCode);

            // Verify the configuration was deleted. This call will throw a public access block configuration was not found message.
            await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() => CallGetPublicAccessBlock(null));
        }
        
        [TestMethod]
        public async Task TestPutPublicAccessBlock()
        {
            await CallPutPublicAccessBlock();
        }

        [TestMethod]
        public async Task TestGetPublicAccessBlock()
        {
            string[] testProperties =
            {
                nameof(PublicAccessBlockConfiguration.BlockPublicAcls),
                nameof(PublicAccessBlockConfiguration.BlockPublicPolicy),
                nameof(PublicAccessBlockConfiguration.IgnorePublicAcls),
                nameof(PublicAccessBlockConfiguration.RestrictPublicBuckets)
            };
            
            // Set each property in PublicAccessBlockConfiguration, do the put, then do the get to test that the value was set.
            foreach (string propertyName in testProperties)
            {
                var configuration = new PublicAccessBlockConfiguration
                {
                    BlockPublicAcls = false,
                    BlockPublicPolicy = false,
                    IgnorePublicAcls = false,
                    RestrictPublicBuckets = false
                };

                var putRequest = new PutPublicAccessBlockRequest
                {
                    BucketName = bucketName,
                    PublicAccessBlockConfiguration = configuration
                };

                System.Reflection.PropertyInfo property = putRequest.PublicAccessBlockConfiguration.GetType().GetProperty(propertyName);
                property.SetValue(configuration, true);

                var putResponse = await Client.PutPublicAccessBlockAsync(putRequest);
                Assert.AreEqual(HttpStatusCode.OK, putResponse.HttpStatusCode);
                await CallGetPublicAccessBlock(configuration);                
            }
        }
    }
}