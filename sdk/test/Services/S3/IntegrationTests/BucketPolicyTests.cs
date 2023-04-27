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
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for the bucket policy status
    /// </summary>
    [TestClass]
    public class BucketPolicyTests : TestBase<AmazonS3Client>
    {
        public static string bucketName;

        [TestInitialize]
        public void Init()
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client, true);
        }

        [TestCleanup]
        public void Cleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestGetBucketPolicyStatus_IsPublic()
        {
            //Set the bucket policy to public
            var putRequest = new PutBucketPolicyRequest
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
            };
            Client.PutBucketPolicy(putRequest);

            //Get the policy status on the bucket
            GetBucketPolicyStatusRequest getRequest = new GetBucketPolicyStatusRequest
            {
                BucketName = bucketName
            };

            var getResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketPolicyStatus(getRequest);
                return res.PolicyStatus?.IsPublic == true ? res : null;
            });

            Assert.AreEqual(true, getResponse.PolicyStatus.IsPublic);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestGetBucketPolicyStatus_IsNotPublic()
        {
            //Set the bucket policy to not public
            var putRequest = new PutBucketPolicyRequest
            {
                BucketName = bucketName,
                Policy = string.Format(@"{{
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
            };
            Client.PutBucketPolicy(putRequest);

            //Get the policy status on the bucket
            GetBucketPolicyStatusRequest getRequest = new GetBucketPolicyStatusRequest
            {
                BucketName = bucketName
            };

            var getResponse = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.GetBucketPolicyStatus(getRequest);
                return res.PolicyStatus?.IsPublic == false ? res : null;
            });
            Assert.AreEqual(false, getResponse.PolicyStatus.IsPublic);
        }

        [TestMethod]
        [TestCategory("S3")]
        [ExpectedException(typeof(AmazonS3Exception), "The bucket policy does not exist")]
        public void TestGetBucketPolicyStatus_PolicyNotSet()
        {            
            try
            {
                //Get the policy status on the bucket
                GetBucketPolicyStatusRequest getRequest = new GetBucketPolicyStatusRequest
                {
                    BucketName = bucketName
                };

                UtilityMethods.WaitUntilException(() =>
                {
                    Client.GetBucketPolicyStatus(getRequest);                    
                });
            }
            catch (AmazonS3Exception ex)
            {
                Assert.AreEqual<string>("The bucket policy does not exist", ex.Message);
                throw;
            }         
        }

    }
}