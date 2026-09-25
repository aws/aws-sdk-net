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
using Amazon.JSONRPC10;
using Amazon.JSONRPC10.Model;
using Amazon.JSONRPC10.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.JsonRpc10
{
    [TestClass]
    public class NoInputAndNoOutput
    {
        /// <summary>
        /// Clients must always send an empty JSON object payload for
        /// operations with no input (that is, `{}`). While AWS service
        /// implementations support requests with no payload or requests that
        /// send `{}`, always sending `{}` from the client is preferred for
        /// forward compatibility in case input is ever added to an
        /// operation.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonRpc10")]
        public async Task AwsJson10MustAlwaysSendEmptyJsonPayloadRequest()
        {
            // Arrange
            var request = new NoInputAndNoOutputRequest
            {
            };
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/",
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJSONRPC10Client(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.NoInputAndNoOutputAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.0".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonRpc10.NoInputAndNoOutput".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// When no output is defined, the service is expected to return an
        /// empty payload, however, client must ignore a JSON payload if one
        /// is returned. This ensures that if output is added later, then it
        /// will not break the client.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public async Task AwsJson10HandlesEmptyOutputShapeResponse()
        {
            // Arrange
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/",
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJSONRPC10Client(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("{}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.0";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.NoInputAndNoOutputAsync(new NoInputAndNoOutputRequest()).ConfigureAwait(false);
            var expectedResponse = new NoInputAndNoOutputResponse
            {
            };

            // Assert
            Comparer.CompareObjects<NoInputAndNoOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// This client-only test builds on handles_empty_output_shape, by
        /// including unexpected fields in the JSON. A client needs to ignore
        /// JSON output that is empty or that contains JSON object data.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public async Task AwsJson10HandlesUnexpectedJsonOutputResponse()
        {
            // Arrange
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/",
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJSONRPC10Client(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("{\n    \"foo\": true\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.0";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.NoInputAndNoOutputAsync(new NoInputAndNoOutputRequest()).ConfigureAwait(false);
            var expectedResponse = new NoInputAndNoOutputResponse
            {
            };

            // Assert
            Comparer.CompareObjects<NoInputAndNoOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// When no output is defined, the service is expected to return an
        /// empty payload. Despite the lack of a payload, the service is
        /// expected to always send a Content-Type header. Clients must
        /// handle cases where a service returns a JSON object and where a
        /// service returns no JSON at all.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonRpc10")]
        public async Task AwsJson10ServiceRespondsWithNoPayloadResponse()
        {
            // Arrange
            var config = new AmazonJSONRPC10Config
            {
              ServiceURL = "https://test.com/",
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJSONRPC10Client(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.0";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.NoInputAndNoOutputAsync(new NoInputAndNoOutputRequest()).ConfigureAwait(false);
            var expectedResponse = new NoInputAndNoOutputResponse
            {
            };

            // Assert
            Comparer.CompareObjects<NoInputAndNoOutputResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
