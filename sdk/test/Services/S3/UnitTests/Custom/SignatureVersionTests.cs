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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class SignatureVersionTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void TestS3SignerDefaultConfigs()
        {
            // can't test these cases as DataRows because the input isn't static
            var defaultClientConfigSignatureVersion = new AmazonS3Config { RegionEndpoint = RegionEndpoint.USEast1 }.SignatureVersion;
            var defaultAWSConfigsS3UseSignatureVersion4 = AWSConfigsS3.UseSignatureVersion4;
            
            // customers don't control IRequest.UseSigV4 because it's in the Internal namespace
            TestS3SignerSignatureVersion(SignatureVersion.SigV2, defaultClientConfigSignatureVersion, defaultAWSConfigsS3UseSignatureVersion4, SignatureVersion.SigV4);
            TestS3SignerSignatureVersion(SignatureVersion.SigV4, defaultClientConfigSignatureVersion, defaultAWSConfigsS3UseSignatureVersion4, SignatureVersion.SigV4);
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3OutpostsSigner()
        {
            var signer = new S3Signer();
            
            var outpostsArn = "arn:aws:s3-outposts:us-west-2:123456789012:outpost:op-01234567890123456:accesspoint:myaccesspoint";
            var putObjectRequest = new PutObjectRequest()
            {
                BucketName = outpostsArn,
                Key = "foo.txt",
                ContentBody = "data"
            };
            var config = new AmazonS3Config
            {
                UseArnRegion = true,
                RegionEndpoint = RegionEndpoint.USWest2
            };
            var iRequest = S3ArnTestUtils.RunMockRequest(putObjectRequest, PutObjectRequestMarshaller.Instance, config);
            signer.Sign(iRequest, config, new RequestMetrics(), new ImmutableCredentials("ACCESS", "SECRET", ""));

            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-outposts"));
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow(SignatureVersion.SigV2, null, false, SignatureVersion.SigV2)]
        [DataRow(SignatureVersion.SigV2, null, true, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV2, "2", false, SignatureVersion.SigV2)]
        [DataRow(SignatureVersion.SigV2, "2", true, SignatureVersion.SigV2)]
        [DataRow(SignatureVersion.SigV2, "4", false, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV2, "4", true, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV2, "garbage", false, SignatureVersion.SigV2)]
        [DataRow(SignatureVersion.SigV2, "garbage", true, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, null, false, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, null, true, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, "2", false, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, "2", true, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, "4", false, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, "4", true, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, "garbage", false, SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4, "garbage", true, SignatureVersion.SigV4)]
        // Currently SigV4a is only used by S3 MRAP so once an internal request is "upgraded" to SigV4a,
        // verify that the other signing version settings will never "downgrade" it back to V4 or V2
        [DataRow(SignatureVersion.SigV4a, null, false, SignatureVersion.SigV4a)]
        [DataRow(SignatureVersion.SigV4a, null, true, SignatureVersion.SigV4a)]
        [DataRow(SignatureVersion.SigV4a, "2", false, SignatureVersion.SigV4a)]
        [DataRow(SignatureVersion.SigV4a, "2", true, SignatureVersion.SigV4a)]
        [DataRow(SignatureVersion.SigV4a, "4", false, SignatureVersion.SigV4a)]
        [DataRow(SignatureVersion.SigV4a, "4", true, SignatureVersion.SigV4a)]
        [DataRow(SignatureVersion.SigV4a, "garbage", false, SignatureVersion.SigV4a)]
        [DataRow(SignatureVersion.SigV4a, "garbage", true, SignatureVersion.SigV4a)]
        public void TestS3SignerSignatureVersion(SignatureVersion signatureVersion, string clientConfigSignatureVersion,
            bool awsConfigsS3UseSignatureVersion4, SignatureVersion expectedSignatureVersion)
        {
            var originalAWSConfigsS3UseSignatureVersion4 = AWSConfigsS3.UseSignatureVersion4;
            try
            {
                AWSConfigsS3.UseSignatureVersion4 = awsConfigsS3UseSignatureVersion4;

                var signer = new S3Signer();
                var putObjectRequest = new PutObjectRequest();
                var iRequest = new DefaultRequest(putObjectRequest, "s3")
                {
                    SignatureVersion = signatureVersion,
                    Endpoint = new System.Uri("https://does_not_matter.com")
                };
                var config = new AmazonS3Config
                {
                    SignatureVersion = clientConfigSignatureVersion,
                    RegionEndpoint = RegionEndpoint.USWest1
                };

                signer.Sign(iRequest, config, new RequestMetrics(), new ImmutableCredentials("ACCESS", "SECRET", ""));

                Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));

                if (expectedSignatureVersion == SignatureVersion.SigV4a)
                {
                    Assert.IsTrue(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS4-ECDSA-P256-SHA256"));
                }
                else if (expectedSignatureVersion == SignatureVersion.SigV4)
                {
                    Assert.IsTrue(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS4-HMAC-SHA256"));
                }
                else if (expectedSignatureVersion == SignatureVersion.SigV2)
                {
                    Assert.IsTrue(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS ACCESS"));
                }
            }
            finally
            {
                AWSConfigsS3.UseSignatureVersion4 = originalAWSConfigsS3UseSignatureVersion4;
            }
        }
    }
}