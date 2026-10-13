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
    public class JsonIntEnums
    {
        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11IntEnumsRequest()
        {
            // Arrange
            var request = new JsonIntEnumsRequest
            {
                IntEnum1 = 1,
                IntEnum2 = 2,
                IntEnum3 = 3,
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumSet =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumMap = new Dictionary<string, int>()
                {

                    { "a", 1 },
                    { "b", 2 },
                },
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
            await client.JsonIntEnumsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"intEnum1\": 1,\n    \"intEnum2\": 2,\n    \"intEnum3\": 3,\n    \"intEnumList\": [\n        1,\n        2\n    ],\n    \"intEnumSet\": [\n        1,\n        2\n    ],\n    \"intEnumMap\": {\n        \"a\": 1,\n        \"b\": 2\n    }\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.JsonIntEnums".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes simple scalar properties
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task AwsJson11IntEnumsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"intEnum1\": 1,\n    \"intEnum2\": 2,\n    \"intEnum3\": 3,\n    \"intEnumList\": [\n        1,\n        2\n    ],\n    \"intEnumSet\": [\n        1,\n        2\n    ],\n    \"intEnumMap\": {\n        \"a\": 1,\n        \"b\": 2\n    }\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            mockResponse.Headers["X-Amz-Target"] = "JsonProtocol.JsonIntEnums";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.JsonIntEnumsAsync(new JsonIntEnumsRequest()).ConfigureAwait(false);
            var expectedResponse = new JsonIntEnumsResponse
            {
                IntEnum1 = 1,
                IntEnum2 = 2,
                IntEnum3 = 3,
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumSet =  new List<int>()
                {
                    1,
                    2,
                },
                IntEnumMap = new Dictionary<string, int>()
                {

                    { "a", 1 },
                    { "b", 2 },
                },
            };

            // Assert
            Comparer.CompareObjects<JsonIntEnumsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
