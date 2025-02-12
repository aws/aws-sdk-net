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
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.Util;

namespace AWSSDK.UnitTests.S3
{
    [TestClass]
    public class KmsTests
    {
        [TestMethod]
        [TestCategory("S3")]
        public void KmsHeaderSetsSigV4()
        {
            var request = new PutObjectRequest
            {
                BucketName = "bucket",
                Key = "key",
                ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMS
            };
            var internalRequest = S3TestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance);
            Assert.AreEqual(ServerSideEncryptionMethod.AWSKMS.Value, internalRequest.Headers[HeaderKeys.XAmzServerSideEncryptionHeader]);
            Assert.AreEqual(SignatureVersion.SigV4, internalRequest.SignatureVersion);
        }
        [TestMethod]
        [TestCategory("S3")]
        public void KmsHeaderDSSESetSigV4()
        {
            var request = new PutObjectRequest
            {
                BucketName = "bucket",
                Key = "key",
                ServerSideEncryptionMethod = ServerSideEncryptionMethod.AWSKMSDSSE
            };
            var internalRequest = S3TestUtils.RunMockRequest(request, PutObjectRequestMarshaller.Instance);
            Assert.AreEqual(ServerSideEncryptionMethod.AWSKMSDSSE.Value, internalRequest.Headers[HeaderKeys.XAmzServerSideEncryptionHeader]);
            Assert.AreEqual(SignatureVersion.SigV4, internalRequest.SignatureVersion);
        }
    }
}