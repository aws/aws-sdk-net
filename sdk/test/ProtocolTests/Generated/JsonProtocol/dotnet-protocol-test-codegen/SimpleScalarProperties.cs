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
    public class SimpleScalarProperties
    {
        /// <summary>
        /// Supports handling NaN float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11SupportsNaNFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                FloatValue = float.NaN,
                DoubleValue = double.NaN,
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
            await client.SimpleScalarPropertiesAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"floatValue\": \"NaN\",\n    \"doubleValue\": \"NaN\"\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.SimpleScalarProperties".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11SupportsInfinityFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                FloatValue = float.PositiveInfinity,
                DoubleValue = double.PositiveInfinity,
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
            await client.SimpleScalarPropertiesAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"floatValue\": \"Infinity\",\n    \"doubleValue\": \"Infinity\"\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.SimpleScalarProperties".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling -Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11SupportsNegativeInfinityFloatInputsRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                FloatValue = float.NegativeInfinity,
                DoubleValue = double.NegativeInfinity,
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
            await client.SimpleScalarPropertiesAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"floatValue\": \"-Infinity\",\n    \"doubleValue\": \"-Infinity\"\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.SimpleScalarProperties".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling NaN float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11SupportsNaNFloatInputsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"floatValue\": \"NaN\",\n    \"doubleValue\": \"NaN\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.SimpleScalarPropertiesAsync(new SimpleScalarPropertiesRequest()).ConfigureAwait(false);
            var expectedResponse = new SimpleScalarPropertiesResponse
            {
                FloatValue = float.NaN,
                DoubleValue = double.NaN,
            };

            // Assert
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Supports handling Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11SupportsInfinityFloatInputsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"floatValue\": \"Infinity\",\n    \"doubleValue\": \"Infinity\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.SimpleScalarPropertiesAsync(new SimpleScalarPropertiesRequest()).ConfigureAwait(false);
            var expectedResponse = new SimpleScalarPropertiesResponse
            {
                FloatValue = float.PositiveInfinity,
                DoubleValue = double.PositiveInfinity,
            };

            // Assert
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Supports handling -Infinity float values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11SupportsNegativeInfinityFloatInputsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"floatValue\": \"-Infinity\",\n    \"doubleValue\": \"-Infinity\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.SimpleScalarPropertiesAsync(new SimpleScalarPropertiesRequest()).ConfigureAwait(false);
            var expectedResponse = new SimpleScalarPropertiesResponse
            {
                FloatValue = float.NegativeInfinity,
                DoubleValue = double.NegativeInfinity,
            };

            // Assert
            Comparer.CompareObjects<SimpleScalarPropertiesResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
