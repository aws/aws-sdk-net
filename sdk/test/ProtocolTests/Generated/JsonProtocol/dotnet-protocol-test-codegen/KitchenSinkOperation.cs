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
    public class KitchenSinkOperation
    {
        /// <summary>
        /// Serializes string shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_string_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                String = "abc xyz",
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"String\":\"abc xyz\"}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes string shapes with jsonvalue trait
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_string_shapes_with_jsonvalue_traitRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                JsonValue = "{\"string\":\"value\",\"number\":1234.5,\"boolTrue\":true,\"boolFalse\":false,\"array\":[1,2,3,4],\"object\":{\"key\":\"value\"},\"null\":null}",
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"JsonValue\":\"{\\\"string\\\":\\\"value\\\",\\\"number\\\":1234.5,\\\"boolTrue\\\":true,\\\"boolFalse\\\":false,\\\"array\\\":[1,2,3,4],\\\"object\\\":{\\\"key\\\":\\\"value\\\"},\\\"null\\\":null}\"}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes integer shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_integer_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Integer = 1234,
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Integer\":1234}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes long shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_long_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Long = 999999999999,
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Long\":999999999999}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes float shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_float_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Float = 1234.5F,
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Float\":1234.5}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes double shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_double_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Double = 1234.5,
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Double\":1234.5}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes blob shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_blob_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Blob = new MemoryStream(Encoding.UTF8.GetBytes("binary-value")),
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Blob\":\"YmluYXJ5LXZhbHVl\"}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes boolean shapes (true)
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_boolean_shapes_trueRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Boolean = true,
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Boolean\":true}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes boolean shapes (false)
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_boolean_shapes_falseRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Boolean = false,
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Boolean\":false}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes timestamp shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_timestamp_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Timestamp\":946845296}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes timestamp shapes with iso8601 timestampFormat
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_timestamp_shapes_with_iso8601_timestampformatRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                Iso8601Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"Iso8601Timestamp\":\"2000-01-02T20:34:56Z\"}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes timestamp shapes with httpdate timestampFormat
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_timestamp_shapes_with_httpdate_timestampformatRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                HttpdateTimestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"HttpdateTimestamp\":\"Sun, 02 Jan 2000 20:34:56 GMT\"}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes timestamp shapes with unixTimestamp timestampFormat
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_timestamp_shapes_with_unixtimestamp_timestampformatRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                UnixTimestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"UnixTimestamp\":946845296}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes list shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_list_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                ListOfStrings =  new List<string>()
                {
                    "abc",
                    "mno",
                    "xyz",
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"ListOfStrings\":[\"abc\",\"mno\",\"xyz\"]}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes empty list shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_empty_list_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                ListOfStrings =  new List<string>()
                {
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"ListOfStrings\":[]}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes list of map shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_list_of_map_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                ListOfMapsOfStrings =  new List<Dictionary<string, string>>()
                {
                    new Dictionary<string, string>()
                    {

                        { "foo", "bar" },
                    },
                    new Dictionary<string, string>()
                    {

                        { "abc", "xyz" },
                    },
                    new Dictionary<string, string>()
                    {

                        { "red", "blue" },
                    },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"ListOfMapsOfStrings\":[{\"foo\":\"bar\"},{\"abc\":\"xyz\"},{\"red\":\"blue\"}]}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes list of structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_list_of_structure_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                ListOfStructs =  new List<SimpleStruct>()
                {
                    new SimpleStruct
                    {
                        Value = "abc",
                    },
                    new SimpleStruct
                    {
                        Value = "mno",
                    },
                    new SimpleStruct
                    {
                        Value = "xyz",
                    },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"ListOfStructs\":[{\"Value\":\"abc\"},{\"Value\":\"mno\"},{\"Value\":\"xyz\"}]}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes list of recursive structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_list_of_recursive_structure_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                RecursiveList =  new List<KitchenSink>()
                {
                    new KitchenSink
                    {
                        RecursiveList =  new List<KitchenSink>()
                        {
                            new KitchenSink
                            {
                                RecursiveList =  new List<KitchenSink>()
                                {
                                    new KitchenSink
                                    {
                                        Integer = 123,
                                    },
                                },
                            },
                        },
                    },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"RecursiveList\":[{\"RecursiveList\":[{\"RecursiveList\":[{\"Integer\":123}]}]}]}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes map shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_map_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                MapOfStrings = new Dictionary<string, string>()
                {

                    { "abc", "xyz" },
                    { "mno", "hjk" },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"MapOfStrings\":{\"abc\":\"xyz\",\"mno\":\"hjk\"}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes empty map shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_empty_map_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                MapOfStrings = new Dictionary<string, string>()
                {

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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"MapOfStrings\":{}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes map of list shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_map_of_list_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                MapOfListsOfStrings = new Dictionary<string, List<string>>()
                {

                    { "abc",  new List<string>()
                    {
                        "abc",
                        "xyz",
                    } },
                    { "mno",  new List<string>()
                    {
                        "xyz",
                        "abc",
                    } },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"MapOfListsOfStrings\":{\"abc\":[\"abc\",\"xyz\"],\"mno\":[\"xyz\",\"abc\"]}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes map of structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_map_of_structure_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                MapOfStructs = new Dictionary<string, SimpleStruct>()
                {

                    { "key1", new SimpleStruct
                    {
                        Value = "value-1",
                    } },
                    { "key2", new SimpleStruct
                    {
                        Value = "value-2",
                    } },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"MapOfStructs\":{\"key1\":{\"Value\":\"value-1\"},\"key2\":{\"Value\":\"value-2\"}}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes map of recursive structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_map_of_recursive_structure_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                RecursiveMap = new Dictionary<string, KitchenSink>()
                {

                    { "key1", new KitchenSink
                    {
                        RecursiveMap = new Dictionary<string, KitchenSink>()
                        {

                            { "key2", new KitchenSink
                            {
                                RecursiveMap = new Dictionary<string, KitchenSink>()
                                {

                                    { "key3", new KitchenSink
                                    {
                                        Boolean = false,
                                    } },
                                },
                            } },
                        },
                    } },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"RecursiveMap\":{\"key1\":{\"RecursiveMap\":{\"key2\":{\"RecursiveMap\":{\"key3\":{\"Boolean\":false}}}}}}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_structure_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                SimpleStruct = new SimpleStruct
                {
                    Value = "abc",
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"SimpleStruct\":{\"Value\":\"abc\"}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes structure members with locationName traits
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_structure_members_with_locationname_traitsRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                StructWithJsonName = new StructWithJsonName
                {
                    Value = "some-value",
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"StructWithJsonName\":{\"Value\":\"some-value\"}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes empty structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_empty_structure_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                SimpleStruct = new SimpleStruct
                {
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"SimpleStruct\":{}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes structure which have no members
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_structure_which_have_no_membersRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                EmptyStruct = new EmptyStruct
                {
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"EmptyStruct\":{}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Serializes recursive structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("JsonProtocol")]
        public async Task serializes_recursive_structure_shapesRequest()
        {
            // Arrange
            var request = new KitchenSinkOperationRequest
            {
                String = "top-value",
                Boolean = false,
                RecursiveStruct = new KitchenSink
                {
                    String = "nested-value",
                    Boolean = true,
                    RecursiveList =  new List<KitchenSink>()
                    {
                        new KitchenSink
                        {
                            String = "string-only",
                        },
                        new KitchenSink
                        {
                            RecursiveStruct = new KitchenSink
                            {
                                MapOfStrings = new Dictionary<string, string>()
                                {

                                    { "color", "red" },
                                    { "size", "large" },
                                },
                            },
                        },
                    },
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
            await client.KitchenSinkOperationAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            var expectedBody = "{\"String\":\"top-value\",\"Boolean\":false,\"RecursiveStruct\":{\"String\":\"nested-value\",\"Boolean\":true,\"RecursiveList\":[{\"String\":\"string-only\"},{\"RecursiveStruct\":{\"MapOfStrings\":{\"color\":\"red\",\"size\":\"large\"}}}]}}";
            JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/x-amz-json-1.1".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("JsonProtocol.KitchenSinkOperation".Replace(" ",""), actualRequest.Headers["X-Amz-Target"].Replace(" ",""));
            Assert.IsTrue(actualRequest.Headers.ContainsKey("Content-Length"));
        }

        /// <summary>
        /// Parses operations with empty JSON bodies
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_operations_with_empty_json_bodiesResponse()
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
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses string shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_string_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"String\":\"string-value\"}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                String = "string-value",
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses integer shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_integer_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Integer\":1234}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Integer = 1234,
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses long shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_long_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Long\":1234567890123456789}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Long = 1234567890123456789,
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses float shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_float_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Float\":1234.5}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Float = 1234.5F,
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses double shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_double_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Double\":123456789.12345679}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Double = 1.2345678912345679E8,
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses boolean shapes (true)
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_boolean_shapes_trueResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Boolean\":true}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Boolean = true,
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses boolean (false)
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_boolean_falseResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Boolean\":false}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Boolean = false,
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses blob shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_blob_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Blob\":\"YmluYXJ5LXZhbHVl\"}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Blob = new MemoryStream(Encoding.UTF8.GetBytes("binary-value")),
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses timestamp shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_timestamp_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Timestamp\":946845296}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses iso8601 timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_iso8601_timestampsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"Iso8601Timestamp\":\"2000-01-02T20:34:56Z\"}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                Iso8601Timestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses httpdate timestamps
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_httpdate_timestampsResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"HttpdateTimestamp\":\"Sun, 02 Jan 2000 20:34:56 GMT\"}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                HttpdateTimestamp = ProtocolTestConstants.epoch.AddSeconds(946845296),
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses list shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_list_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"ListOfStrings\":[\"abc\",\"mno\",\"xyz\"]}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                ListOfStrings =  new List<string>()
                {
                    "abc",
                    "mno",
                    "xyz",
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses list of map shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_list_of_map_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"ListOfMapsOfStrings\":[{\"size\":\"large\"},{\"color\":\"red\"}]}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                ListOfMapsOfStrings =  new List<Dictionary<string, string>>()
                {
                    new Dictionary<string, string>()
                    {

                        { "size", "large" },
                    },
                    new Dictionary<string, string>()
                    {

                        { "color", "red" },
                    },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses list of list shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_list_of_list_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"ListOfLists\":[[\"abc\",\"mno\",\"xyz\"],[\"hjk\",\"qrs\",\"tuv\"]]}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                ListOfLists =  new List<List<string>>()
                {
                     new List<string>()
                    {
                        "abc",
                        "mno",
                        "xyz",
                    },
                     new List<string>()
                    {
                        "hjk",
                        "qrs",
                        "tuv",
                    },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses list of structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_list_of_structure_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"ListOfStructs\":[{\"Value\":\"value-1\"},{\"Value\":\"value-2\"}]}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                ListOfStructs =  new List<SimpleStruct>()
                {
                    new SimpleStruct
                    {
                        Value = "value-1",
                    },
                    new SimpleStruct
                    {
                        Value = "value-2",
                    },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses list of recursive structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_list_of_recursive_structure_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"RecursiveList\":[{\"RecursiveList\":[{\"RecursiveList\":[{\"String\":\"value\"}]}]}]}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                RecursiveList =  new List<KitchenSink>()
                {
                    new KitchenSink
                    {
                        RecursiveList =  new List<KitchenSink>()
                        {
                            new KitchenSink
                            {
                                RecursiveList =  new List<KitchenSink>()
                                {
                                    new KitchenSink
                                    {
                                        String = "value",
                                    },
                                },
                            },
                        },
                    },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses map shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_map_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"MapOfStrings\":{\"size\":\"large\",\"color\":\"red\"}}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                MapOfStrings = new Dictionary<string, string>()
                {

                    { "size", "large" },
                    { "color", "red" },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses map of list shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_map_of_list_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"MapOfListsOfStrings\":{\"sizes\":[\"large\",\"small\"],\"colors\":[\"red\",\"green\"]}}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                MapOfListsOfStrings = new Dictionary<string, List<string>>()
                {

                    { "sizes",  new List<string>()
                    {
                        "large",
                        "small",
                    } },
                    { "colors",  new List<string>()
                    {
                        "red",
                        "green",
                    } },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses map of map shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_map_of_map_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"MapOfMaps\":{\"sizes\":{\"large\":\"L\",\"medium\":\"M\"},\"colors\":{\"red\":\"R\",\"blue\":\"B\"}}}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                MapOfMaps = new Dictionary<string, Dictionary<string, string>>()
                {

                    { "sizes", new Dictionary<string, string>()
                    {

                        { "large", "L" },
                        { "medium", "M" },
                    } },
                    { "colors", new Dictionary<string, string>()
                    {

                        { "red", "R" },
                        { "blue", "B" },
                    } },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses map of structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_map_of_structure_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"MapOfStructs\":{\"size\":{\"Value\":\"small\"},\"color\":{\"Value\":\"red\"}}}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                MapOfStructs = new Dictionary<string, SimpleStruct>()
                {

                    { "size", new SimpleStruct
                    {
                        Value = "small",
                    } },
                    { "color", new SimpleStruct
                    {
                        Value = "red",
                    } },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses map of recursive structure shapes
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_map_of_recursive_structure_shapesResponse()
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
                Body = Encoding.ASCII.GetBytes("{\"RecursiveMap\":{\"key-1\":{\"RecursiveMap\":{\"key-2\":{\"RecursiveMap\":{\"key-3\":{\"String\":\"value\"}}}}}}}"),
            };
            mockResponse.Headers["Content-Type"] = "application/x-amz-json-1.1";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
                RecursiveMap = new Dictionary<string, KitchenSink>()
                {

                    { "key-1", new KitchenSink
                    {
                        RecursiveMap = new Dictionary<string, KitchenSink>()
                        {

                            { "key-2", new KitchenSink
                            {
                                RecursiveMap = new Dictionary<string, KitchenSink>()
                                {

                                    { "key-3", new KitchenSink
                                    {
                                        String = "value",
                                    } },
                                },
                            } },
                        },
                    } },
                },
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses the request id from the response
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("JsonProtocol")]
        public async Task parses_the_request_id_from_the_responseResponse()
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
            mockResponse.Headers["X-Amzn-Requestid"] = "amazon-uniq-request-id";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.KitchenSinkOperationAsync(new KitchenSinkOperationRequest()).ConfigureAwait(false);
            var expectedResponse = new KitchenSinkOperationResponse
            {
            };

            // Assert
            Comparer.CompareObjects<KitchenSinkOperationResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
