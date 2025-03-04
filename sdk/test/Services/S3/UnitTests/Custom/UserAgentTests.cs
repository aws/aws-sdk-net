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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class UserAgentTests
    {
        [DataTestMethod]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/X,Z,b")]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "m/X,Z,c")]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/a,b")]
        [DataRow("SHA1", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "m/a,c")]
        
        [DataRow("SHA256", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/Y,Z,b")]
        [DataRow("SHA256", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "m/Y,Z,c")]
        [DataRow("SHA256", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/a,b")]
        [DataRow("SHA256", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "m/a,c")]

        [DataRow("CRC32", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/U,Z,b")]
        [DataRow("CRC32", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "m/U,Z,c")]
        [DataRow("CRC32", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/a,b")]
        [DataRow("CRC32", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "m/a,c")]

        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/V,Z,b")]
        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "m/V,Z,c")]
        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/a,b")]
        [DataRow("CRC32C", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "m/a,c")]

        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/W,Z,b")]
        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_SUPPORTED, ResponseChecksumValidation.WHEN_REQUIRED, "m/W,Z,c")]
        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_SUPPORTED, "m/a,b")]
        [DataRow("CRC64NVME", RequestChecksumCalculation.WHEN_REQUIRED, ResponseChecksumValidation.WHEN_REQUIRED, "m/a,c")]
        public void Test_AddsFeatureIdsToUserAgent(
            string checksumAlgorithm, 
            RequestChecksumCalculation requestChecksumCalculation,
            ResponseChecksumValidation responseChecksumValidation,
            string expectedUserAgentContent
        )
        {
            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "test-bucket",
                Key = "test-key",
                ContentBody = "test-content",
                ChecksumAlgorithm = checksumAlgorithm
            };

            var config = new AmazonS3Config
            {
                RequestChecksumCalculation = requestChecksumCalculation,
                ResponseChecksumValidation = responseChecksumValidation
            };

            var mockRequest = RunMockRequest(putObjectRequest, config);
            var userAgentHeader = mockRequest.Headers[AWSSDKUtils.UserAgentHeader];
            Assert.IsNotNull(userAgentHeader);
            Assert.IsTrue(userAgentHeader.Contains(expectedUserAgentContent));
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, AmazonS3Config config)
        {
            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                new S3ArnTestUtils.NoopPipelineHandler(),
                new AmazonS3UserAgentHandler(),
                new ChecksumHandler(),
                new AmazonS3PostMarshallHandler(),
                new AmazonS3EndpointResolver(),
                new Marshaller(),
                new AmazonS3PreMarshallHandler(),
            });

            var requestContext = new RequestContext(config.LogMetrics, new NullSigner())
            {
                ClientConfig = config,
                Marshaller = PutObjectRequestMarshaller.Instance,
                OriginalRequest = request,
                Unmarshaller = null,
                IsAsync = false
            };

            var executionContext = new ExecutionContext(requestContext, new ResponseContext());
            pipeline.InvokeSync(executionContext);

            return requestContext.Request;
        }
    }
}
