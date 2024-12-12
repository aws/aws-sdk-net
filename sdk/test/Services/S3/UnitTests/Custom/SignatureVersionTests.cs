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
            signer.Sign(iRequest, config, new RequestMetrics(), new BasicAWSCredentials("ACCESS", "SECRET"));

            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));
            Assert.IsTrue((iRequest.Headers["Authorization"]).Contains("s3-outposts"));
        }

        [DataTestMethod]
        [TestCategory("S3")]
        [DataRow(SignatureVersion.SigV4)]
        [DataRow(SignatureVersion.SigV4a)]
        public void TestS3SignerSignatureVersionSigV4(SignatureVersion signatureVersion)
        {
            var signer = new S3Signer();
            var putObjectRequest = new PutObjectRequest();
            var iRequest = new DefaultRequest(putObjectRequest, "s3")
            {
                SignatureVersion = signatureVersion,
                Endpoint = new System.Uri("https://does_not_matter.com")
            };
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USWest1
            };

            signer.Sign(iRequest, config, new RequestMetrics(), new BasicAWSCredentials("ACCESS", "SECRET"));
            Assert.IsTrue(iRequest.Headers.ContainsKey(HeaderKeys.AuthorizationHeader));

            if (signatureVersion == SignatureVersion.SigV4a)
            {
                Assert.IsTrue(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS4-ECDSA-P256-SHA256"));
                Assert.IsFalse(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS4-HMAC-SHA256"));
            }
            else if (signatureVersion == SignatureVersion.SigV4)
            {
                Assert.IsFalse(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS4-ECDSA-P256-SHA256"));
                Assert.IsTrue(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS4-HMAC-SHA256"));
            }

            //AWS ACCESS is a SigV2 component and it must not exist in the authorization header for SigV4 signatures.
            Assert.IsFalse(iRequest.Headers[HeaderKeys.AuthorizationHeader].Contains("AWS ACCESS"));            
        }
    }
}