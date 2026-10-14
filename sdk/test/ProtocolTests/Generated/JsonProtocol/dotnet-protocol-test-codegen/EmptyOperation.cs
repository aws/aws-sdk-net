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
using Amazon.JsonProtocol;
using Amazon.JsonProtocol.Model;
using Amazon.JsonProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.JsonProtocol
{
    [TestClass]
    public class EmptyOperation
    {
        /// <summary>
        /// Sends requests to /
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task sends_requests_to_slashRequest()
        {
            // Arrange
            var request = new EmptyOperationRequest
            {
            };
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.EmptyOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.EmptyOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Includes X-Amz-Target header and Content-Type
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task includes_x_amz_target_and_content_typeRequest()
        {
            // Arrange
            var request = new EmptyOperationRequest
            {
            };
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.EmptyOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.EmptyOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

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
        [TestCategory("JsonProtocol")]
        public async Task json_1_1_client_sends_empty_payload_for_no_input_shapeRequest()
        {
            // Arrange
            var request = new EmptyOperationRequest
            {
            };
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.EmptyOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.EmptyOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
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
        [TestCategory("JsonProtocol")]
        public async Task handles_empty_output_shapeResponse()
        {
            // Arrange
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("{}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.EmptyOperationAsync(new EmptyOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new EmptyOperationResponse
            {
            };

            // Assert
            Comparer.CompareObjects<EmptyOperationResponse>(expectedResponse,actualResponse);
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
        [TestCategory("JsonProtocol")]
        public async Task handles_unexpected_json_outputResponse()
        {
            // Arrange
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("{\n    \"foo\": true\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.EmptyOperationAsync(new EmptyOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new EmptyOperationResponse
            {
            };

            // Assert
            Comparer.CompareObjects<EmptyOperationResponse>(expectedResponse,actualResponse);
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
        [TestCategory("JsonProtocol")]
        public async Task json_1_1_service_responds_with_no_payloadResponse()
        {
            // Arrange
            var config = new AmazonJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.EmptyOperationAsync(new EmptyOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new EmptyOperationResponse
            {
            };

            // Assert
            Comparer.CompareObjects<EmptyOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
