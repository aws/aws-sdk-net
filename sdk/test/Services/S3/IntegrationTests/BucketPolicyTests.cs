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
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    [TestCategory("S3")]
    public class BucketPolicyTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;

        [TestInitialize]
        public async Task Init()
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, true);
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
        }

        [TestMethod]
        public async Task TestGetBucketPolicyStatus_IsPublic()
        {
            // Set the bucket policy to public
            await Client.PutBucketPolicyAsync(new PutBucketPolicyRequest
            {
                BucketName = bucketName,
                Policy = string.Format(@"{{
                    ""Version"":""2012-10-17"",
                    ""Statement"":[
                        {{
                            ""Sid"":""AddPerm"",
                            ""Effect"":""Allow"",
                            ""Principal"": ""*"",
                            ""Action"":[""s3:GetObject""],
                            ""Resource"":[""arn:aws:s3:::{0}/*""]
                        }}
                    ]
                }}", bucketName)
            });

            var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketPolicyStatusAsync(new GetBucketPolicyStatusRequest
                {
                    BucketName = bucketName
                });
                return res.PolicyStatus?.IsPublic == true ? res : null;
            });
            Assert.AreEqual(true, getResponse.PolicyStatus.IsPublic);
        }

        [TestMethod]
        public async Task TestGetBucketPolicyStatus_IsNotPublic()
        {
            // Set the bucket policy to not public
            await Client.PutBucketPolicyAsync(new PutBucketPolicyRequest
            {
                BucketName = bucketName,
                Policy = string.Format(
                @"{{
                    ""Version"":""2012-10-17"",
                    ""Statement"":[
                        {{
                            ""Sid"":""AddPerm"",
                            ""Effect"":""Deny"",
                            ""Principal"": ""*"",
                            ""Action"":[""s3:GetObject""],
                            ""Resource"":[""arn:aws:s3:::{0}/*""]
                        }}
                    ]
                }}", bucketName)
            });

            var getResponse = await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketPolicyStatusAsync(new GetBucketPolicyStatusRequest
                {
                    BucketName = bucketName
                });
                return res.PolicyStatus?.IsPublic == false ? res : null;
            });
            Assert.AreEqual(false, getResponse.PolicyStatus.IsPublic);
        }

        [TestMethod]
        public async Task TestGetBucketPolicyStatus_PolicyNotSet()
        {
            var exception = await Assert.ThrowsExceptionAsync<AmazonS3Exception>(() =>
                Client.GetBucketPolicyStatusAsync(new GetBucketPolicyStatusRequest
                {
                    BucketName = bucketName
                })
            );

            Assert.AreEqual("The bucket policy does not exist", exception.Message);
        }
    }
}