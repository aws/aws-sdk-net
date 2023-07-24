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

#if BCL45
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        /// Set <see cref="HeaderKeys.ContentMD5Header"/> when <see cref="ChecksumData.MD5Checksum"/> is true
        [DataRow(true, false, null, true, true, HeaderKeys.ContentMD5Header)]
        /// Set CRC32Header when <see cref="ChecksumData.MD5Checksum"/> is false and we have a valid
        /// CRC32 <see cref="ChecksumData.SelectedChecksum"/>
        [DataRow(true, false, "CRC32", false, true, "x-amz-checksum-crc32")]
        /// Don't set CRC32Header twice when the header is already set
        [DataRow(true, true, "CRC32", false, true, "x-amz-checksum-crc32")]
        /// Set <see cref="HeaderKeys.ContentMD5Header"/> when <see cref="ChecksumData.MD5Checksum"/> is set to true regardless whether
        /// selectedChecksum is set or not
        [DataRow(true, false, "CRC32", true, true, HeaderKeys.ContentMD5Header)]
        /// Don't set <see cref="HeaderKeys.ContentMD5Header"/> twice when the header is already set
        [DataRow(true, true, "CRC32", true, true, HeaderKeys.ContentMD5Header)]
        /// Set <see cref="HeaderKeys.ContentMD5Header"/> when <see cref="ChecksumData.MD5Checksum"/> is set to true regardless
        /// whether <see cref="ChecksumData.SelectedChecksum"/> is valid or not
        [DataRow(true, false, "NONE", false, true, HeaderKeys.ContentMD5Header)]
        /// Don't set any checksum header when <see cref="ChecksumData.SelectedChecksum"/> doesn't exist and we don't want to fallback to MD5
        [DataRow(true, false, "NONE", false, false, null)]
        /// Don't set any checksum header when <see cref="IRequest.ChecksumData"/> equals null
        [DataRow(false, false, "CRC32", true, true, null)]
        [DataTestMethod]
        public async Task TestChecksumInvokeAsync(bool checksumDataExists, bool checksumHeaderAlreadyExists, string selectedChecksum,
            bool MD5Checksum, bool fallBackToMD5, string headerKey)
        {
            ChecksumData checksumData = null;
            if (checksumDataExists)
            {
                checksumData = new ChecksumData(selectedChecksum, MD5Checksum, fallBackToMD5);
            }

            var handler = new ChecksumHandler();
            var mockHandler = new MockActionHandler();
            handler.InnerHandler = mockHandler;

            var executionContext = CreateTestContext();
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
                Assert.IsTrue(request.Headers.Count == 1);
                Assert.IsTrue(request.Headers.ContainsKey(headerKey));
                Assert.IsTrue(request.Headers[headerKey] != null);
            }
            else
            {
                Assert.IsTrue(request.Headers.Count == 0);
            }
        }

#elif !BCL45 && BCL
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
         /// Set <see cref="HeaderKeys.ContentMD5Header"/> when <see cref="ChecksumData.MD5Checksum"/> is true
        [DataRow(true, false, null, true, true, HeaderKeys.ContentMD5Header)]
        /// Set CRC32Header when <see cref="ChecksumData.MD5Checksum"/> is false and we have a valid
        /// CRC32 <see cref="ChecksumData.SelectedChecksum"/>
        [DataRow(true, false, "CRC32", false, true, "x-amz-checksum-crc32")]
        /// Don't set CRC32Header twice when the header is already set
        [DataRow(true, true, "CRC32", false, true, "x-amz-checksum-crc32")]
        /// Set <see cref="HeaderKeys.ContentMD5Header"/> when <see cref="ChecksumData.MD5Checksum"/> is set to true regardless whether
        /// selectedChecksum is set or not
        [DataRow(true, false, "CRC32", true, true, HeaderKeys.ContentMD5Header)]
        /// Don't set <see cref="HeaderKeys.ContentMD5Header"/> twice when the header is already set
        [DataRow(true, true, "CRC32", true, true, HeaderKeys.ContentMD5Header)]
        /// Set <see cref="HeaderKeys.ContentMD5Header"/> when <see cref="ChecksumData.MD5Checksum"/> is set to true regardless
        /// whether <see cref="ChecksumData.SelectedChecksum"/> is valid or not
        [DataRow(true, false, "NONE", false, true, HeaderKeys.ContentMD5Header)]
        /// Don't set any checksum header when <see cref="ChecksumData.SelectedChecksum"/> doesn't exist and we don't want to fallback to MD5
        [DataRow(true, false, "NONE", false, false, null)]
        /// Don't set any checksum header when <see cref="IRequest.ChecksumData"/> equals null
        [DataRow(false, false, "CRC32", true, true, null)]
        [DataTestMethod]
        public void TestChecksumInvoke(bool checksumDataExists, bool checksumHeaderAlreadyExists, string selectedChecksum,
            bool MD5Checksum, bool fallBackToMD5, string headerKey)
        {
            ChecksumData checksumData = null;
            if (checksumDataExists)
            {
                checksumData = new ChecksumData(selectedChecksum, MD5Checksum, fallBackToMD5);
            }

            var handler = new ChecksumHandler();
            var mockHandler = new MockActionHandler();
            handler.InnerHandler = mockHandler;

            var executionContext = CreateTestContext();
            var request = executionContext.RequestContext.Request;
            request.ChecksumData = checksumData;

            if (checksumHeaderAlreadyExists)
            {
                request.Headers[headerKey] = JunkChecksumHeaderValue;
            }

            handler.InvokeSync(executionContext);

            if (checksumHeaderAlreadyExists)
            {
                // Make sure that we don't set checksum header twice
                Assert.IsTrue(request.Headers[headerKey].Equals(JunkChecksumHeaderValue));
                Assert.IsTrue(request.Headers.Count == 1);
            }
            else if (headerKey != null)
            {
                Assert.IsTrue(request.Headers.Count == 1);
                Assert.IsTrue(request.Headers.ContainsKey(headerKey));
                Assert.IsTrue(request.Headers[headerKey] != null);
            }
            else
            {
                Assert.IsTrue(request.Headers.Count == 0);
            }
        }
#endif

        private ExecutionContext CreateTestContext()
        {
            var putMetricDataRequest = new PutMetricDataRequest()
            {
                Namespace = "compression-test",
            };

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = putMetricDataRequest,
                Request = new PutMetricDataRequestMarshaller().Marshall(putMetricDataRequest),
                ClientConfig = new AmazonCloudWatchConfig()
            };

            return new ExecutionContext(requestContext, null);
        }
    }

}
