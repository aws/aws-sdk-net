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
using Amazon.Runtime.Documents;
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
    public class DocumentType
    {
        /// <summary>
        /// Serializes document types as part of the JSON request payload
        /// with no escaping.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DocumentTypeInputWithObjectRequest()
        {
            // Arrange
            var request = new DocumentTypeRequest
            {
                StringValue = "string",
                DocumentValue = new Document(new Dictionary<string,Document>
                {
                    {"foo", "bar"},
                }),
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
            await client.DocumentTypeAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"stringValue\": \"string\",\n    \"documentValue\": {\n        \"foo\": \"bar\"\n    }\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/DocumentType", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes document types using a string.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DocumentInputWithStringRequest()
        {
            // Arrange
            var request = new DocumentTypeRequest
            {
                StringValue = "string",
                DocumentValue = "hello",
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
            await client.DocumentTypeAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"stringValue\": \"string\",\n    \"documentValue\": \"hello\"\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/DocumentType", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes document types using a number.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DocumentInputWithNumberRequest()
        {
            // Arrange
            var request = new DocumentTypeRequest
            {
                StringValue = "string",
                DocumentValue = 10,
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
            await client.DocumentTypeAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"stringValue\": \"string\",\n    \"documentValue\": 10\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/DocumentType", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes document types using a boolean.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DocumentInputWithBooleanRequest()
        {
            // Arrange
            var request = new DocumentTypeRequest
            {
                StringValue = "string",
                DocumentValue = true,
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
            await client.DocumentTypeAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"stringValue\": \"string\",\n    \"documentValue\": true\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/DocumentType", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes document types using a list.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DocumentInputWithListRequest()
        {
            // Arrange
            var request = new DocumentTypeRequest
            {
                StringValue = "string",
                DocumentValue = new Document
                {
                    true,
                    "hi",
                    new Document
                    {
                        1,
                        2,
                    },
                    new Document(new Dictionary<string,Document>
                    {
                        {"foo", new Document(new Dictionary<string,Document>
                        {
                            {"baz", new Document
                            {
                                3,
                                4,
                            }},
                        })},
                    }),
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
            await client.DocumentTypeAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\n    \"stringValue\": \"string\",\n    \"documentValue\": [\n        true,\n        \"hi\",\n        [\n            1,\n            2\n        ],\n        {\n            \"foo\": {\n                \"baz\": [\n                    3,\n                    4\n                ]\n            }\n        }\n    ]\n}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("PUT", actualRequest.Method);
            Assert.AreEqual("/DocumentType", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/json".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
        }

        /// <summary>
        /// Serializes documents as part of the JSON response payload with no
        /// escaping.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DocumentOutputResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"stringValue\": \"string\",\n    \"documentValue\": {\n        \"foo\": \"bar\"\n    }\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.DocumentTypeAsync(new DocumentTypeRequest()).ConfigureAwait(false);
            var expectedResponse = new DocumentTypeResponse
            {
                StringValue = "string",
                DocumentValue = new Document(new Dictionary<string,Document>
                {
                    {"foo", "bar"},
                }),
            };

            // Assert
            Comparer.CompareObjects<DocumentTypeResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Document types can be JSON scalars too.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DocumentOutputStringResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"stringValue\": \"string\",\n    \"documentValue\": \"hello\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.DocumentTypeAsync(new DocumentTypeRequest()).ConfigureAwait(false);
            var expectedResponse = new DocumentTypeResponse
            {
                StringValue = "string",
                DocumentValue = "hello",
            };

            // Assert
            Comparer.CompareObjects<DocumentTypeResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Document types can be JSON scalars too.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DocumentOutputNumberResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"stringValue\": \"string\",\n    \"documentValue\": 10\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.DocumentTypeAsync(new DocumentTypeRequest()).ConfigureAwait(false);
            var expectedResponse = new DocumentTypeResponse
            {
                StringValue = "string",
                DocumentValue = 10,
            };

            // Assert
            Comparer.CompareObjects<DocumentTypeResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Document types can be JSON scalars too.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DocumentOutputBooleanResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"stringValue\": \"string\",\n    \"documentValue\": false\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.DocumentTypeAsync(new DocumentTypeRequest()).ConfigureAwait(false);
            var expectedResponse = new DocumentTypeResponse
            {
                StringValue = "string",
                DocumentValue = false,
            };

            // Assert
            Comparer.CompareObjects<DocumentTypeResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Document types can be JSON arrays.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DocumentOutputArrayResponse()
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
                Body = Encoding.ASCII.GetBytes("{\n    \"stringValue\": \"string\",\n    \"documentValue\": [\n        true,\n        false\n    ]\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.DocumentTypeAsync(new DocumentTypeRequest()).ConfigureAwait(false);
            var expectedResponse = new DocumentTypeResponse
            {
                StringValue = "string",
                DocumentValue = new Document
                {
                    true,
                    false,
                },
            };

            // Assert
            Comparer.CompareObjects<DocumentTypeResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
