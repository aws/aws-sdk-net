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

using Amazon.Runtime.Internal;
using Amazon.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Amazon.CloudWatch.Model.Internal.MarshallTransformations;
using Amazon.CloudWatch.Model;
using Amazon.CloudWatch;
using Amazon.Runtime.Internal.Auth;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ChecksumHandlerTests
    {
        private const string JunkChecksumHeaderValue = "JunkHeaderValue";
        private const string SdkAlgorithmHeaderName = "x-amz-sdk-checksum-algorithm";

#if BCL
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]

        // Set "Content-MD5" header when checksum data is MD5 (regardless if selected checksum is valid or not)
        [DataRow(true, false, "NonExistent", true, false, HeaderKeys.ContentMD5Header, true, RequestChecksumCalculation.WHEN_REQUIRED)]
        [DataRow(true, false, "CRC32", true, false, HeaderKeys.ContentMD5Header, true, RequestChecksumCalculation.WHEN_SUPPORTED)]

        // Set default checksum when checksum wasn't specified and we don't want to fallback to MD5
        [DataRow(true, false, "NONE", false, false, "x-amz-checksum-crc32", true, RequestChecksumCalculation.WHEN_REQUIRED)]

        // Set checksum header when a valid algorithm (different than the default) is specified
        [DataRow(true, false, "CRC32C", false, false, "x-amz-checksum-crc32c", false, RequestChecksumCalculation.WHEN_SUPPORTED)]

        // Don't set header twice when value is already set
        [DataRow(true, true, "SHA256", false, false, "x-amz-checksum-sha256", false, RequestChecksumCalculation.WHEN_SUPPORTED)]

        // Don't set any checksum headers when checksum data equals null
        [DataRow(false, false, "NONE", true, true, null, true, null)]

        // Don't set any checksum headers when not required and config set to when required only
        [DataRow(true, false, "SHA1", false, false, null, false, RequestChecksumCalculation.WHEN_REQUIRED)]
        [DataRow(true, false, "NONE", false, false, null, false, RequestChecksumCalculation.WHEN_REQUIRED)]

        [DataTestMethod]
        public async Task TestChecksumInvokeAsync(
            bool checksumDataExists, 
            bool checksumHeaderAlreadyExists, 
            string selectedChecksum,
            bool MD5Checksum, 
            bool fallBackToMD5,
            string headerKey,
            bool isRequestChecksumRequired,
            RequestChecksumCalculation requestChecksumCalculation
        )
        {
            ChecksumData checksumData = null;
            if (checksumDataExists)
            {
                checksumData = new ChecksumData(selectedChecksum, MD5Checksum, fallBackToMD5, isRequestChecksumRequired, SdkAlgorithmHeaderName);
            }

            var handler = new ChecksumHandler();
            var mockHandler = new MockActionHandler();
            handler.InnerHandler = mockHandler;

            var executionContext = CreateTestContext(requestChecksumCalculation);
            var request = executionContext.RequestContext.Request;
            request.ChecksumData = checksumData;

            if (checksumHeaderAlreadyExists)
            {
                request.Headers[headerKey] = JunkChecksumHeaderValue;
            }

            await handler.InvokeAsync<AmazonWebServiceResponse>(executionContext);

            if (checksumHeaderAlreadyExists)
            {
                // Make sure that we don't set checksum header twice when it already exists
                Assert.IsTrue(request.Headers[headerKey].Equals(JunkChecksumHeaderValue));
                Assert.IsTrue(request.Headers.Count == 1);
            }
            else if (headerKey != null)
            {
                Assert.IsTrue(request.Headers.ContainsKey(headerKey));
                Assert.IsTrue(request.Headers[headerKey] != null);

                if (!MD5Checksum)
                {
                    var expectedValue = selectedChecksum == "NONE" ? ChecksumUtils.DefaultAlgorithm.ToString() : selectedChecksum;
                    Assert.IsTrue(request.Headers.ContainsKey(SdkAlgorithmHeaderName));
                    Assert.AreEqual(expectedValue, request.Headers[SdkAlgorithmHeaderName]);
                }
            }
            else
            {
                Assert.IsTrue(request.Headers.Count == 0);
            }
        }
#endif

        private ExecutionContext CreateTestContext(RequestChecksumCalculation requestChecksumCalculation)
        {
            var putMetricDataRequest = new PutMetricDataRequest
            {
                Namespace = "compression-test",
            };

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = putMetricDataRequest,
                Request = new PutMetricDataRequestMarshaller().Marshall(putMetricDataRequest),
                ClientConfig = new AmazonCloudWatchConfig
                {
                    RequestChecksumCalculation = requestChecksumCalculation,
                },
                Identity = new BasicAWSCredentials("access key", "secret"),
            };

            return new ExecutionContext(requestContext, null);
        }
    }
}
