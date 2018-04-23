/*
 * Copyright 2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SignatureVersionTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void TestS3SignerSignatureVersion()
        {
            var defaultClientConfigSignatureVersion = (new AmazonS3Config{
                                                            RegionEndpoint = RegionEndpoint.USEast1
                                                        }).SignatureVersion;
            var defaultAWSConfigsS3UseSignatureVersion4 = AWSConfigsS3.UseSignatureVersion4;
            
            // customers don't control IRequest.UseSigV4 because it's in the Internal namespace
            TestS3Signer(false, defaultClientConfigSignatureVersion, defaultAWSConfigsS3UseSignatureVersion4, true);
            TestS3Signer(true, defaultClientConfigSignatureVersion, defaultAWSConfigsS3UseSignatureVersion4, true);

            TestS3Signer(false, null, false, false);
            TestS3Signer(false, null, true, true);
            TestS3Signer(false, "2", false, false);
            TestS3Signer(false, "2", true, false);
            TestS3Signer(false, "4", false, true);
            TestS3Signer(false, "4", true, true);
            TestS3Signer(false, "garbage", false, false);
            TestS3Signer(false, "garbage", true, true);
            TestS3Signer(true, null, false, true);
            TestS3Signer(true, null, true, true);
            TestS3Signer(true, "2", false, true);
            TestS3Signer(true, "2", true, true);
            TestS3Signer(true, "4", false, true);
            TestS3Signer(true, "4", true, true);
            TestS3Signer(true, "garbage", false, true);
            TestS3Signer(true, "garbage", true, true);
        }

        private void TestS3Signer(bool requestUseSigV4, string clientConfigSignatureVersion,
            bool awsConfigsS3UseSignatureVersion4, bool expectSigV4)
        {
            var originalAWSConfigsS3UseSignatureVersion4 = AWSConfigsS3.UseSignatureVersion4;
            try
            {
                AWSConfigsS3.UseSignatureVersion4 = awsConfigsS3UseSignatureVersion4;

                var signer = new S3Signer();
                var putObjectRequest = new PutObjectRequest();
                var iRequest = new DefaultRequest(putObjectRequest, "s3")
                {
                    UseSigV4 = requestUseSigV4,
                    Endpoint = new System.Uri("https://does_not_matter.com")
                };
                var config = new AmazonS3Config
                {
                    SignatureVersion = clientConfigSignatureVersion,
                    RegionEndpoint = RegionEndpoint.USWest1
                };

                signer.Sign(iRequest, config, new RequestMetrics(), "ACCESS", "SECRET");

                Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
                Assert.AreEqual(expectSigV4, iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("aws4_request"));
            }
            finally
            {
                AWSConfigsS3.UseSignatureVersion4 = originalAWSConfigsS3UseSignatureVersion4;
            }
        }
    }
}