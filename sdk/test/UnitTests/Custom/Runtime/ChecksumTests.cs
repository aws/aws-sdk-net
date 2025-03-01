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
using Amazon.CloudWatch;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using AWSSDK_DotNet.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ChecksumTests
    {
        /// <summary>
        /// Test that the outermost function for calculating a checksum computes the correct value
        /// </summary>
        [DataRow(CoreChecksumAlgorithm.SHA1, "", "2jmj7l5rSw0yVb/vlWAYkK/YBwk=")]
        [DataRow(CoreChecksumAlgorithm.SHA1, "abc", "qZk+NkcGgWq6PiVxeFDCbJzQ2J0=")]
        [DataRow(CoreChecksumAlgorithm.SHA1, "Hello world", "e1AsOh9IyGCa4hLN+2Od7jlnP14=")]
        [DataRow(CoreChecksumAlgorithm.SHA256, "", "47DEQpj8HBSa+/TImW+5JCeuQeRkm5NMpJWZG3hSuFU=")]
        [DataRow(CoreChecksumAlgorithm.SHA256, "abc", "ungWv48Bz+pBQUDeXa4iI7ADYaOWF3qctBD/YfIAFa0=")]
        [DataRow(CoreChecksumAlgorithm.SHA256, "Hello world", "ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw=")]
        [DataRow(CoreChecksumAlgorithm.CRC32, "", "AAAAAA==")]
        [DataRow(CoreChecksumAlgorithm.CRC32, "abc", "NSRBwg==")]
        [DataRow(CoreChecksumAlgorithm.CRC32, "Hello world", "i9aeUg==")]
        [DataRow(CoreChecksumAlgorithm.CRC32C, "", "AAAAAA==")]
        [DataRow(CoreChecksumAlgorithm.CRC32C, "abc", "Nks/tw==")]
        [DataRow(CoreChecksumAlgorithm.CRC32C, "Hello world", "crUfeA==")]
        [DataRow(CoreChecksumAlgorithm.CRC64NVME, "", "AAAAAAAAAAA=")]
        [DataRow(CoreChecksumAlgorithm.CRC64NVME, "abc", "BeXKuz/B+us=")]
        [DataRow(CoreChecksumAlgorithm.CRC64NVME, "Hello world", "OOJZ0D8xKts=")]
        [DataTestMethod]
        public void CalculateChecksumTest(CoreChecksumAlgorithm algorithm, string content, string expectedBase64Checksum)
        {
            var contentBytes = Encoding.Default.GetBytes(content);
            var computedChecksum = Convert.ToBase64String(CryptoUtilFactory.GetChecksumInstance(algorithm).ComputeHash(contentBytes));
            Assert.AreEqual(expectedBase64Checksum, computedChecksum);
        }

        /// <summary>
        /// Test the interaction between whether a checksum is required, whether
        /// an algorithm is provided, and whether a precalculated checksum is provided
        /// to verify that the correct checksum is calculated for the request.
        /// </summary>
        [DataTestMethod]

        // MD5 fallback test cases
        [DataRow(false, true, CoreChecksumAlgorithm.NONE, null, "", "Content-MD5")]
        [DataRow(false, true, CoreChecksumAlgorithm.NONE, null, "Content-MD5", "Content-MD5")]

        // Checksum required and not specified, default to CRC32
        [DataRow(true, false, CoreChecksumAlgorithm.NONE, RequestChecksumCalculation.WHEN_REQUIRED, "", "x-amz-checksum-crc32")]
        [DataRow(true, false, CoreChecksumAlgorithm.NONE, RequestChecksumCalculation.WHEN_SUPPORTED, "", "x-amz-checksum-crc32")]

        // Checksum required and specified using different value than default
        [DataRow(true, false, CoreChecksumAlgorithm.CRC32C, RequestChecksumCalculation.WHEN_REQUIRED, "", "x-amz-checksum-crc32c")]
        [DataRow(true, false, CoreChecksumAlgorithm.SHA256, RequestChecksumCalculation.WHEN_SUPPORTED, "", "x-amz-checksum-sha256")]

        // Checksum specified but another value was already set (pre-calculated header takes precedence)
        [DataRow(true, false, CoreChecksumAlgorithm.CRC32, RequestChecksumCalculation.WHEN_REQUIRED, "x-amz-checksum-crc32", "x-amz-checksum-crc32")]
        [DataRow(false, false, CoreChecksumAlgorithm.SHA256, RequestChecksumCalculation.WHEN_SUPPORTED, "x-amz-checksum-crc32", "x-amz-checksum-crc32")]

        // Checksum not required but config set to when supported, calculated anyway
        [DataRow(false, false, CoreChecksumAlgorithm.NONE, RequestChecksumCalculation.WHEN_SUPPORTED, "", "x-amz-checksum-crc32")]

        // Checksum not required and config set to when required only, no checksum calculated
        [DataRow(false, false, CoreChecksumAlgorithm.NONE, RequestChecksumCalculation.WHEN_REQUIRED, "", "")]
        public void TestRequestChecksumSelection(
            bool isRequestChecksumRequired,
            bool fallbackToMD5,
            CoreChecksumAlgorithm checksumAlgorithm,
            RequestChecksumCalculation requestChecksumCalculation,
            string originalHeaderKey,
            string expectedHeaderKey
        )
        {
            var sdkAlgorithmHeaderName = "x-amz-sdk-checksum-algorithm";

            var mock = new Mock<IRequest>();
            var headers = new Dictionary<string, string>();
            var request = mock.Object;
            mock.SetupGet(x => x.Headers).Returns(headers);
            mock.SetupGet(x => x.Content).Returns(Encoding.ASCII.GetBytes("foo"));
            mock.SetupGet(x => x.ChecksumData).Returns(new ChecksumData(checksumAlgorithm.ToString(), MD5Checksum: false, fallbackToMD5, isRequestChecksumRequired, headerName: sdkAlgorithmHeaderName));

            if (!string.IsNullOrEmpty(originalHeaderKey))
            {
                headers.Add(originalHeaderKey, "foo");
            }

            ChecksumUtils.SetRequestChecksumV2(request, new AmazonCloudWatchConfig
            {
                RequestChecksumCalculation = requestChecksumCalculation
            });

            if (!string.IsNullOrEmpty(expectedHeaderKey))
            {
                Assert.IsTrue(request.Headers.ContainsKey(expectedHeaderKey));
                Assert.IsFalse(string.IsNullOrEmpty(request.Headers[expectedHeaderKey]));

                if (!fallbackToMD5 && string.IsNullOrEmpty(originalHeaderKey))
                {
                    var expectedValue = checksumAlgorithm == CoreChecksumAlgorithm.NONE ? ChecksumUtils.DefaultAlgorithm.ToString() : checksumAlgorithm.ToString();
                    Assert.IsTrue(request.Headers.ContainsKey(sdkAlgorithmHeaderName));
                    Assert.AreEqual(expectedValue, request.Headers[sdkAlgorithmHeaderName]);
                }
            }
            else
            {
                Assert.AreEqual(0, request.Headers.Count);
            }
        }

        [TestMethod]
        public void ResponseChecksumSelection_NoChecksumsReturned()
        {
            var operationSupportedChecksums = new List<CoreChecksumAlgorithm> 
            { 
                CoreChecksumAlgorithm.CRC32,
                CoreChecksumAlgorithm.CRC32C
            };
            var responseData = new WebResponseData();
            
            // No checksum headers on the response, so we cannot choose one to validate
            Assert.AreEqual(CoreChecksumAlgorithm.NONE,
                ChecksumUtils.SelectChecksumForResponseValidation(operationSupportedChecksums, responseData));
        }

        [TestMethod]
        public void ResponseChecksumSelection_SingleChecksum()
        {
            var operationSupportedChecksums = new List<CoreChecksumAlgorithm> 
            { 
                CoreChecksumAlgorithm.SHA256,
                CoreChecksumAlgorithm.CRC32
            };
            var responseData = new WebResponseData();
            responseData.Headers = new Dictionary<string, string>
            {
                { "x-amz-checksum-sha256", "checksum" }
            };

            // Even though CRC32 is supported and comes first in priority order, only SHA256 is returned from service
            Assert.AreEqual(CoreChecksumAlgorithm.SHA256,
                ChecksumUtils.SelectChecksumForResponseValidation(operationSupportedChecksums, responseData));
        }

        [TestMethod]
        public void TestResponseChecksumSelection_Priority()
        {
            var operationSupportedChecksums = new List<CoreChecksumAlgorithm>
            { 
                CoreChecksumAlgorithm.SHA256,
                CoreChecksumAlgorithm.CRC32
            };
            var responseData = new WebResponseData();
            responseData.Headers = new Dictionary<string, string>
            {
                { "x-amz-checksum-sha256", "checksum" },
                { "x-amz-checksum-crc32", "checksum" }
            };

            // CRC32 should take priority over SHA256 when both are returned
            Assert.AreEqual(CoreChecksumAlgorithm.CRC32,
                ChecksumUtils.SelectChecksumForResponseValidation(operationSupportedChecksums, responseData));
        }

        [TestMethod]
        public void TestResponseChecksumSelection_UnsupportedChecksum()
        {
            var operationSupportedChecksums = new List<CoreChecksumAlgorithm>
            { 
                CoreChecksumAlgorithm.SHA256,
                CoreChecksumAlgorithm.CRC32
            };
            var responseData = new WebResponseData();
            responseData.Headers = new Dictionary<string, string>
            {
                { "x-amz-checksum-nonsupported", "checksum" }
            };

            // Validation is skipped if the SDK doesn't support the returned checksum.
            Assert.AreEqual(CoreChecksumAlgorithm.NONE,
                ChecksumUtils.SelectChecksumForResponseValidation(operationSupportedChecksums, responseData));
        }
    }
}
