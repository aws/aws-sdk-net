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
using Amazon.Runtime.Internal.UserAgent;
using Amazon.S3;
using Amazon.S3.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class UserAgentTests
    {
        [Ignore("Need to rework after the UA2.1 changes, we cannot compare with a string anymore.")]
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

        [TestMethod]
        public void AddFeature_ShouldStoreFeatureId()
        {
            var userAgentDetails = new UserAgentDetails();
            userAgentDetails.AddFeature(UserAgentFeatureId.S3_TRANSFER);
            userAgentDetails.AddFeature(UserAgentFeatureId.S3_EXPRESS_BUCKET);

            var trackedFeatures = userAgentDetails.TrackedFeatureIds;
            Assert.IsTrue(trackedFeatures.Contains(UserAgentFeatureId.S3_EXPRESS_BUCKET.Value));
            Assert.IsTrue(trackedFeatures.Contains(UserAgentFeatureId.S3_TRANSFER.Value));
        }

        [TestMethod]
        public void GenerateMetricsUserAgent_ShouldContainStoredFeatureIds()
        {
            var userAgentDetails = new UserAgentDetails();
            userAgentDetails.AddFeature(UserAgentFeatureId.RETRY_MODE_ADAPTIVE);
            userAgentDetails.AddFeature(UserAgentFeatureId.PAGINATOR);

            string result = userAgentDetails.GenerateMetricsUserAgent();

            Assert.IsTrue(result.Contains(UserAgentFeatureId.RETRY_MODE_ADAPTIVE.Value));
            Assert.IsTrue(result.Contains(UserAgentFeatureId.PAGINATOR.Value));
        }

        [TestMethod]
        public void GenerateMetricsUserAgent_ShouldTruncateTo1KB()
        {
            var userAgentDetails = new UserAgentDetails();

            // Generate feature IDs that exceed 1024 bytes
            for (int i = 0; i < 500; i++)
            {
                userAgentDetails.AddFeature(new UserAgentFeatureId(i + "ID"));
            }
            string result = userAgentDetails.GenerateMetricsUserAgent();

            Assert.IsTrue(Encoding.UTF8.GetByteCount(result) <= 1024);
            Assert.IsTrue(result.EndsWith("ID")); // Ensure truncation preserves valid feature IDs and does not cut in the middle of an ID
        }

        [TestMethod]
        public void GenerateMetricsUserAgent_ShouldReturnEmptyWhenNoFeatures()
        {
            var userAgentDetails = new UserAgentDetails();
            string result = userAgentDetails.GenerateMetricsUserAgent();
            Assert.AreEqual(string.Empty, result);
        }

        private IRequest RunMockRequest(AmazonWebServiceRequest request, AmazonS3Config config)
        {
            var pipeline = new RuntimePipeline(new List<IPipelineHandler>
            {
                new S3ArnTestUtils.NoopPipelineHandler(),
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
