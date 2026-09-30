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
    public class JsonMaps
    {
        /// <summary>
        /// Serializes JSON maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonJsonMapsRequest()
        {
            // Arrange
            var request = new JsonMapsRequest
            {
                DenseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
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
            await client.JsonMapsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"denseStructMap\": {\n        \"foo\": {\n            \"hi\": \"there\"\n        },\n        \"baz\": {\n            \"hi\": \"bye\"\n        }\n    }\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/JsonMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Ensure that 0 and false are sent over the wire in all maps and
        /// lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSerializesZeroValuesInMapsRequest()
        {
            // Arrange
            var request = new JsonMapsRequest
            {
                DenseNumberMap = new Dictionary<string, int>()
                {

                    { "x", 0 },
                },
                DenseBooleanMap = new Dictionary<string, bool>()
                {

                    { "x", false },
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
            await client.JsonMapsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"denseNumberMap\": {\n        \"x\": 0\n    },\n    \"denseBooleanMap\": {\n        \"x\": false\n    }\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/JsonMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// A request that contains a dense map of sets.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSerializesDenseSetMapRequest()
        {
            // Arrange
            var request = new JsonMapsRequest
            {
                DenseSetMap = new Dictionary<string, List<string>>()
                {

                    { "x",  new List<string>()
                    {
                    } },
                    { "y",  new List<string>()
                    {
                        "a",
                        "b",
                    } },
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
            await client.JsonMapsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"denseSetMap\": {\n        \"x\": [],\n        \"y\": [\"a\", \"b\"]\n    }\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/JsonMaps", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Deserializes JSON maps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonJsonMapsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"denseStructMap\": {\n        \"foo\": {\n            \"hi\": \"there\"\n        },\n        \"baz\": {\n            \"hi\": \"bye\"\n        }\n    }\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.JsonMapsAsync(new JsonMapsRequest()).ConfigureAwait(false);
            var expectedResponse = new JsonMapsResponse
            {
                DenseStructMap = new Dictionary<string, GreetingStruct>()
                {

                    { "foo", new GreetingStruct
                    {
                        Hi = "there",
                    } },
                    { "baz", new GreetingStruct
                    {
                        Hi = "bye",
                    } },
                },
            };

            // Assert
            Comparer.CompareObjects<JsonMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Ensure that 0 and false are sent over the wire in all maps and
        /// lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonDeserializesZeroValuesInMapsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"denseNumberMap\": {\n        \"x\": 0\n    },\n    \"denseBooleanMap\": {\n        \"x\": false\n    }\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.JsonMapsAsync(new JsonMapsRequest()).ConfigureAwait(false);
            var expectedResponse = new JsonMapsResponse
            {
                DenseNumberMap = new Dictionary<string, int>()
                {

                    { "x", 0 },
                },
                DenseBooleanMap = new Dictionary<string, bool>()
                {

                    { "x", false },
                },
            };

            // Assert
            Comparer.CompareObjects<JsonMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// A response that contains a dense map of sets.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonDeserializesDenseSetMapResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"denseSetMap\": {\n        \"x\": [],\n        \"y\": [\"a\", \"b\"]\n    }\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.JsonMapsAsync(new JsonMapsRequest()).ConfigureAwait(false);
            var expectedResponse = new JsonMapsResponse
            {
                DenseSetMap = new Dictionary<string, List<string>>()
                {

                    { "x",  new List<string>()
                    {
                    } },
                    { "y",  new List<string>()
                    {
                        "a",
                        "b",
                    } },
                },
            };

            // Assert
            Comparer.CompareObjects<JsonMapsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
