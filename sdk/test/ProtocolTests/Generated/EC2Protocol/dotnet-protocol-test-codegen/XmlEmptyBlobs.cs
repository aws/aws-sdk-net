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

/*
 * Do not modify this file. This file is generated.
 */
using AWSSDK.ProtocolTests;
using AWSSDK.ProtocolTests.Utils;
using AWSSDK_DotNet.UnitTests.TestTools;
using Amazon.EC2Protocol;
using Amazon.EC2Protocol.Model;
using Amazon.EC2Protocol.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.AwsEc2
{
    [TestClass]
    public class XmlEmptyBlobs
    {
        /// <summary>
        /// Empty blobs are deserialized as empty string
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public async Task Ec2XmlEmptyBlobsResponse()
        {
            // Arrange
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonEC2ProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlEmptyBlobsResponse xmlns=\"https://example.com/\">\n    <data></data>\n    <requestId>requestid</requestId>\n</XmlEmptyBlobsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlEmptyBlobsAsync(new XmlEmptyBlobsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlEmptyBlobsResponse
            {
                Data = new MemoryStream(Encoding.UTF8.GetBytes("")),
            };

            // Assert
            Comparer.CompareObjects<XmlEmptyBlobsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Empty self closed blobs are deserialized as empty string
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("AwsEc2")]
        public async Task Ec2XmlEmptySelfClosedBlobsResponse()
        {
            // Arrange
            var config = new AmazonEC2ProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonEC2ProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("<XmlEmptyBlobsResponse xmlns=\"https://example.com/\">\n    <data/>\n    <requestId>requestid</requestId>\n</XmlEmptyBlobsResponse>\n"),
            };
            mockResponse.Headers["Content-Type"] = "text/xml;charset=UTF-8";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.XmlEmptyBlobsAsync(new XmlEmptyBlobsRequest()).ConfigureAwait(false);
            var expectedResponse = new XmlEmptyBlobsResponse
            {
                Data = new MemoryStream(Encoding.UTF8.GetBytes("")),
            };

            // Assert
            Comparer.CompareObjects<XmlEmptyBlobsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
