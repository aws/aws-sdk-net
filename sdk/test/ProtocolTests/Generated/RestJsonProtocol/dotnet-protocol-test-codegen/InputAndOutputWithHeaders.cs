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
    public class InputAndOutputWithHeaders
    {
        /// <summary>
        /// Tests requests with string header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithStringHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderString = "Hello",
                HeaderStringList =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
                HeaderStringSet =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("Hello".Replace(" ",""), actualRequest.Headers["X-String"].Replace(" ",""));
            Assert.AreEqual("a, b, c".Replace(" ",""), actualRequest.Headers["X-StringList"].Replace(" ",""));
            Assert.AreEqual("a, b, c".Replace(" ",""), actualRequest.Headers["X-StringSet"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with string list header bindings that require
        /// quoting
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithQuotedStringHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderStringList =  new List<string>()
                {
                    "b,c",
                    "\"def\"",
                    "a",
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("\"b,c\", \"\\\"def\\\"\", a".Replace(" ",""), actualRequest.Headers["X-StringList"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with numeric header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithNumericHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderByte = 1,
                HeaderShort = 123,
                HeaderInteger = 123,
                HeaderLong = 123,
                HeaderFloat = 1.1F,
                HeaderDouble = 1.1,
                HeaderIntegerList =  new List<int>()
                {
                    1,
                    2,
                    3,
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("1".Replace(" ",""), actualRequest.Headers["X-Byte"].Replace(" ",""));
            Assert.AreEqual("1.1".Replace(" ",""), actualRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("1.1".Replace(" ",""), actualRequest.Headers["X-Float"].Replace(" ",""));
            Assert.AreEqual("123".Replace(" ",""), actualRequest.Headers["X-Integer"].Replace(" ",""));
            Assert.AreEqual("1, 2, 3".Replace(" ",""), actualRequest.Headers["X-IntegerList"].Replace(" ",""));
            Assert.AreEqual("123".Replace(" ",""), actualRequest.Headers["X-Long"].Replace(" ",""));
            Assert.AreEqual("123".Replace(" ",""), actualRequest.Headers["X-Short"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with boolean header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithBooleanHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderTrueBool = true,
                HeaderFalseBool = false,
                HeaderBooleanList =  new List<bool>()
                {
                    true,
                    false,
                    true,
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("true".Replace(" ",""), actualRequest.Headers["X-Boolean1"].Replace(" ",""));
            Assert.AreEqual("false".Replace(" ",""), actualRequest.Headers["X-Boolean2"].Replace(" ",""));
            Assert.AreEqual("true, false, true".Replace(" ",""), actualRequest.Headers["X-BooleanList"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with timestamp header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithTimestampHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderTimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("Mon, 16 Dec 2019 23:48:18 GMT, Mon, 16 Dec 2019 23:48:18 GMT".Replace(" ",""), actualRequest.Headers["X-TimestampList"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with enum header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithEnumHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderEnum = "Foo",
                HeaderEnumList =  new List<string>()
                {
                    "Foo",
                    "Bar",
                    "Baz",
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("Foo".Replace(" ",""), actualRequest.Headers["X-Enum"].Replace(" ",""));
            Assert.AreEqual("Foo, Bar, Baz".Replace(" ",""), actualRequest.Headers["X-EnumList"].Replace(" ",""));
        }

        /// <summary>
        /// Tests requests with intEnum header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithIntEnumHeadersRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderIntegerEnum = 1,
                HeaderIntegerEnumList =  new List<int>()
                {
                    1,
                    2,
                    3,
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("1".Replace(" ",""), actualRequest.Headers["X-IntegerEnum"].Replace(" ",""));
            Assert.AreEqual("1, 2, 3".Replace(" ",""), actualRequest.Headers["X-IntegerEnumList"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling NaN float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSupportsNaNFloatHeaderInputsRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderFloat = float.NaN,
                HeaderDouble = double.NaN,
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("NaN".Replace(" ",""), actualRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("NaN".Replace(" ",""), actualRequest.Headers["X-Float"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSupportsInfinityFloatHeaderInputsRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderFloat = float.PositiveInfinity,
                HeaderDouble = double.PositiveInfinity,
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("Infinity".Replace(" ",""), actualRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("Infinity".Replace(" ",""), actualRequest.Headers["X-Float"].Replace(" ",""));
        }

        /// <summary>
        /// Supports handling -Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSupportsNegativeInfinityFloatHeaderInputsRequest()
        {
            // Arrange
            var request = new InputAndOutputWithHeadersRequest
            {
                HeaderFloat = float.NegativeInfinity,
                HeaderDouble = double.NegativeInfinity,
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
            await client.InputAndOutputWithHeadersAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/InputAndOutputWithHeaders", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("-Infinity".Replace(" ",""), actualRequest.Headers["X-Double"].Replace(" ",""));
            Assert.AreEqual("-Infinity".Replace(" ",""), actualRequest.Headers["X-Float"].Replace(" ",""));
        }

        /// <summary>
        /// Tests responses with string header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithStringHeadersResponse()
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
            mockResponse.Headers["X-String"] = "Hello";
            mockResponse.Headers["X-StringList"] = "a, b, c";
            mockResponse.Headers["X-StringSet"] = "a, b, c";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderString = "Hello",
                HeaderStringList =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
                HeaderStringSet =  new List<string>()
                {
                    "a",
                    "b",
                    "c",
                },
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Tests responses with string list header bindings that require
        /// quoting
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithQuotedStringHeadersResponse()
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
            mockResponse.Headers["X-StringList"] = "\"b,c\", \"\\\"def\\\"\", a";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderStringList =  new List<string>()
                {
                    "b,c",
                    "\"def\"",
                    "a",
                },
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Tests responses with numeric header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithNumericHeadersResponse()
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
            mockResponse.Headers["X-Byte"] = "1";
            mockResponse.Headers["X-Double"] = "1.1";
            mockResponse.Headers["X-Float"] = "1.1";
            mockResponse.Headers["X-Integer"] = "123";
            mockResponse.Headers["X-IntegerList"] = "1, 2, 3";
            mockResponse.Headers["X-Long"] = "123";
            mockResponse.Headers["X-Short"] = "123";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderByte = 1,
                HeaderShort = 123,
                HeaderInteger = 123,
                HeaderLong = 123,
                HeaderFloat = 1.1F,
                HeaderDouble = 1.1,
                HeaderIntegerList =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Tests responses with boolean header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithBooleanHeadersResponse()
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
            mockResponse.Headers["X-Boolean1"] = "true";
            mockResponse.Headers["X-Boolean2"] = "false";
            mockResponse.Headers["X-BooleanList"] = "true, false, true";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderTrueBool = true,
                HeaderFalseBool = false,
                HeaderBooleanList =  new List<bool>()
                {
                    true,
                    false,
                    true,
                },
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Tests responses with timestamp header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithTimestampHeadersResponse()
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
            mockResponse.Headers["X-TimestampList"] = "Mon, 16 Dec 2019 23:48:18 GMT, Mon, 16 Dec 2019 23:48:18 GMT";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderTimestampList =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
                    ProtocolTestConstants.epoch.AddSeconds(1576540098),
                },
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Tests responses with enum header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithEnumHeadersResponse()
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
            mockResponse.Headers["X-Enum"] = "Foo";
            mockResponse.Headers["X-EnumList"] = "Foo, Bar, Baz";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderEnum = "Foo",
                HeaderEnumList =  new List<string>()
                {
                    "Foo",
                    "Bar",
                    "Baz",
                },
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Tests responses with intEnum header bindings
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInputAndOutputWithIntEnumHeadersResponse()
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
            mockResponse.Headers["X-IntegerEnum"] = "1";
            mockResponse.Headers["X-IntegerEnumList"] = "1, 2, 3";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderIntegerEnum = 1,
                HeaderIntegerEnumList =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Supports handling NaN float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSupportsNaNFloatHeaderOutputsResponse()
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
            mockResponse.Headers["X-Double"] = "NaN";
            mockResponse.Headers["X-Float"] = "NaN";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderFloat = float.NaN,
                HeaderDouble = double.NaN,
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Supports handling Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSupportsInfinityFloatHeaderOutputsResponse()
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
            mockResponse.Headers["X-Double"] = "Infinity";
            mockResponse.Headers["X-Float"] = "Infinity";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderFloat = float.PositiveInfinity,
                HeaderDouble = double.PositiveInfinity,
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Supports handling -Infinity float header values.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSupportsNegativeInfinityFloatHeaderOutputsResponse()
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
            mockResponse.Headers["X-Double"] = "-Infinity";
            mockResponse.Headers["X-Float"] = "-Infinity";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.InputAndOutputWithHeadersAsync(new InputAndOutputWithHeadersRequest()).ConfigureAwait(false);
            var expectedResponse = new InputAndOutputWithHeadersResponse
            {
                HeaderFloat = float.NegativeInfinity,
                HeaderDouble = double.NegativeInfinity,
            };

            // Assert
            Comparer.CompareObjects<InputAndOutputWithHeadersResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

    }
}
