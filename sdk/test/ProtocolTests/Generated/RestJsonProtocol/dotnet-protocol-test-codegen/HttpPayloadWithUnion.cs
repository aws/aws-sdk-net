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
using Amazon.RestJsonProtocol;
using Amazon.RestJsonProtocol.Model;
using Amazon.RestJsonProtocol.Model.Internal.MarshallTransformations;
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

namespace AWSSDK.ProtocolTests.RestJson
{
    [TestClass]
    public class HttpPayloadWithUnion
    {
        /// <summary>
        /// Serializes a union in the payload.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPayloadWithUnionRequest()
        {
            // Arrange
            var request = new HttpPayloadWithUnionRequest
            {
                Nested = new UnionPayload{
                    Greeting = "hello"
                },
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.HttpPayloadWithUnionAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"greeting\": \"hello\"\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/HttpPayloadWithUnion", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// No payload is sent if the union has no value.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPayloadWithUnsetUnionRequest()
        {
            // Arrange
            var request = new HttpPayloadWithUnionRequest
            {
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            await client.HttpPayloadWithUnionAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/HttpPayloadWithUnion", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
        }

        /// <summary>
        /// Serializes a union in the payload.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPayloadWithUnionResponse()
        {
            // Arrange
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes("{\n    \"greeting\": \"hello\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.HttpPayloadWithUnionAsync(new HttpPayloadWithUnionRequest()).ConfigureAwait(false);
            var expectedResponse = new HttpPayloadWithUnionResponse
            {
                Nested = new UnionPayload{
                    Greeting = "hello"
                },
            };

            // Assert
            Comparer.CompareObjects<HttpPayloadWithUnionResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// No payload is sent if the union has no value.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonHttpPayloadWithUnsetUnionResponse()
        {
            // Arrange
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["Content-Length"] = "0";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.HttpPayloadWithUnionAsync(new HttpPayloadWithUnionRequest()).ConfigureAwait(false);
            var expectedResponse = new HttpPayloadWithUnionResponse
            {
            };

            // Assert
            Comparer.CompareObjects<HttpPayloadWithUnionResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
