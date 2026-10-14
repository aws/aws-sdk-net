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
    public class JsonLists
    {
        /// <summary>
        /// Serializes JSON lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonListsRequest()
        {
            // Arrange
            var request = new JsonListsRequest
            {
                StringList =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                StringSet =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                IntegerList =  new List<int>()
                {
                    1,
                    2,
                },
                BooleanList =  new List<bool>()
                {
                    true,
                    false,
                },
                TimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                },
                EnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                NestedStringList =  new List<List<string>>()
                {
                     new List<string>()
                    {
                        "foo",
                        "bar",
                    },
                     new List<string>()
                    {
                        "baz",
                        "qux",
                    },
                },
                StructureList =  new List<StructureListMember>()
                {
                    new StructureListMember
                    {
                        A = "1",
                        B = "2",
                    },
                    new StructureListMember
                    {
                        A = "3",
                        B = "4",
                    },
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
            await client.JsonListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"stringList\": [\n        \"foo\",\n        \"bar\"\n    ],\n    \"stringSet\": [\n        \"foo\",\n        \"bar\"\n    ],\n    \"integerList\": [\n        1,\n        2\n    ],\n    \"booleanList\": [\n        true,\n        false\n    ],\n    \"timestampList\": [\n        1398796238,\n        1398796238\n    ],\n    \"enumList\": [\n        \"Foo\",\n        \"0\"\n    ],\n    \"intEnumList\": [\n        1,\n        2\n    ],\n    \"nestedStringList\": [\n        [\n            \"foo\",\n            \"bar\"\n        ],\n        [\n            \"baz\",\n            \"qux\"\n        ]\n    ],\n    \"myStructureList\": [\n        {\n            \"value\": \"1\",\n            \"other\": \"2\"\n        },\n        {\n            \"value\": \"3\",\n            \"other\": \"4\"\n        }\n    ]\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/JsonLists", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes empty JSON lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonListsEmptyRequest()
        {
            // Arrange
            var request = new JsonListsRequest
            {
                StringList =  new List<string>()
                {
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
            await client.JsonListsAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"stringList\": []\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/JsonLists", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes JSON lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonListsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"stringList\": [\n        \"foo\",\n        \"bar\"\n    ],\n    \"stringSet\": [\n        \"foo\",\n        \"bar\"\n    ],\n    \"integerList\": [\n        1,\n        2\n    ],\n    \"booleanList\": [\n        true,\n        false\n    ],\n    \"timestampList\": [\n        1398796238,\n        1398796238\n    ],\n    \"enumList\": [\n        \"Foo\",\n        \"0\"\n    ],\n    \"intEnumList\": [\n        1,\n        2\n    ],\n    \"nestedStringList\": [\n        [\n            \"foo\",\n            \"bar\"\n        ],\n        [\n            \"baz\",\n            \"qux\"\n        ]\n    ],\n    \"myStructureList\": [\n        {\n            \"value\": \"1\",\n            \"other\": \"2\"\n        },\n        {\n            \"value\": \"3\",\n            \"other\": \"4\"\n        }\n    ]\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.JsonListsAsync(new JsonListsRequest()).ConfigureAwait(false);
            var expectedResponse = new JsonListsResponse
            {
                StringList =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                StringSet =  new List<string>()
                {
                    "foo",
                    "bar",
                },
                IntegerList =  new List<int>()
                {
                    1,
                    2,
                },
                BooleanList =  new List<bool>()
                {
                    true,
                    false,
                },
                TimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                    ProtocolTestConstants.epoch.AddSeconds(1398796238),
                },
                EnumList =  new List<string>()
                {
                    "Foo",
                    "0",
                },
                IntEnumList =  new List<int>()
                {
                    1,
                    2,
                },
                NestedStringList =  new List<List<string>>()
                {
                     new List<string>()
                    {
                        "foo",
                        "bar",
                    },
                     new List<string>()
                    {
                        "baz",
                        "qux",
                    },
                },
                StructureList =  new List<StructureListMember>()
                {
                    new StructureListMember
                    {
                        A = "1",
                        B = "2",
                    },
                    new StructureListMember
                    {
                        A = "3",
                        B = "4",
                    },
                },
            };

            // Assert
            Comparer.CompareObjects<JsonListsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Serializes empty JSON lists
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonListsEmptyResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"stringList\": []\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.JsonListsAsync(new JsonListsRequest()).ConfigureAwait(false);
            var expectedResponse = new JsonListsResponse
            {
                StringList =  new List<string>()
                {
                },
            };

            // Assert
            Comparer.CompareObjects<JsonListsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
