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
    public class GreetingWithErrors
    {
        /// <summary>
        /// Ensures that operations with errors successfully know how to
        /// deserialize a successful response. As of January 2021, server
        /// implementations are expected to respond with a JSON object
        /// regardless of if the output parameters are empty.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonGreetingWithErrorsResponse()
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
                Body = Encoding.ASCII.GetBytes("{}"),
            };
            mockResponse.Headers["X-Greeting"] = "Hello";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest()).ConfigureAwait(false);
            var expectedResponse = new GreetingWithErrorsResponse
            {
                Greeting = "Hello",
            };

            // Assert
            Comparer.CompareObjects<GreetingWithErrorsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// This test is similar to RestJsonGreetingWithErrors, but it
        /// ensures that clients can gracefully deal with a server omitting a
        /// response payload.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonGreetingWithErrorsNoPayloadResponse()
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
            mockResponse.Headers["X-Greeting"] = "Hello";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var actualResponse = await client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest()).ConfigureAwait(false);
            var expectedResponse = new GreetingWithErrorsResponse
            {
                Greeting = "Hello",
            };

            // Assert
            Comparer.CompareObjects<GreetingWithErrorsResponse>(expectedResponse,actualResponse);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// Parses simple JSON errors
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInvalidGreetingErrorErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400),
                Body = Encoding.ASCII.GetBytes("{\n    \"Message\": \"Hi\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            mockResponse.Headers["X-Amzn-Errortype"] = "InvalidGreeting";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<InvalidGreetingException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 400), errorResponse.StatusCode);
        }

        /// <summary>
        /// Serializes a complex error with no message member
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonComplexErrorWithNoMessageErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 403),
                Body = Encoding.ASCII.GetBytes("{\n    \"TopLevel\": \"Top level\",\n    \"Nested\": {\n        \"Fooooo\": \"bar\"\n    }\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            mockResponse.Headers["X-Amzn-Errortype"] = "ComplexError";
            mockResponse.Headers["X-Header"] = "Header";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<ComplexErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 403), errorResponse.StatusCode);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonEmptyComplexErrorWithNoMessageErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 403),
                Body = Encoding.ASCII.GetBytes("{}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            mockResponse.Headers["X-Amzn-Errortype"] = "ComplexError";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<ComplexErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 403), errorResponse.StatusCode);
        }

        /// <summary>
        /// Serializes the X-Amzn-ErrorType header. For an example service,
        /// see Amazon EKS.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorUsingXAmznErrorTypeErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["X-Amzn-Errortype"] = "FooError";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Some X-Amzn-Errortype headers contain URLs. Clients need to split
        /// the URL on ':' and take only the first half of the string. For
        /// example,
        /// 'ValidationException:http://internal.amazon.com/coral/com.amazon.coral.validate/'
        /// is to be interpreted as 'ValidationException'.  For an example
        /// service see Amazon Polly.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorUsingXAmznErrorTypeWithUriErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["X-Amzn-Errortype"] = "FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// X-Amzn-Errortype might contain a URL and a namespace. Client
        /// should extract only the shape name. This is a pathalogical case
        /// that might not actually happen in any deployed AWS service.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorUsingXAmznErrorTypeWithUriAndNamespaceErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["X-Amzn-Errortype"] = "aws.protocoltests.restjson#FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Because namespace and URL are ignored, an unrecognized namespace
        /// should not make a difference.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorUsingXAmznErrorTypeWithUriAndDifferentNamespaceErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes(""),
            };
            mockResponse.Headers["X-Amzn-Errortype"] = "aws.different.namespace#FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// This example uses the 'code' property in the output rather than
        /// X-Amzn-Errortype. Some services do this though it's preferable to
        /// send the X-Amzn-Errortype. Client implementations must first
        /// check for the X-Amzn-Errortype and then check for a top-level
        /// 'code' property.  For example service see Amazon S3 Glacier.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorUsingCodeErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes("{\n    \"code\": \"FooError\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Some services serialize errors using code, and it might contain a
        /// namespace. Clients should just take the last part of the string
        /// after '#'.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorUsingCodeAndNamespaceErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes("{\n    \"code\": \"aws.protocoltests.restjson#FooError\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Some services serialize errors using code, and it might contain a
        /// namespace. It also might contain a URI. Clients should just take
        /// the last part of the string after '#' and before ":". This is a
        /// pathalogical case that might not occur in any deployed AWS
        /// service.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorUsingCodeUriAndNamespaceErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes("{\n    \"code\": \"aws.protocoltests.restjson#FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Some services serialize errors using __type.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorWithDunderTypeErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes("{\n    \"__type\": \"FooError\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Some services serialize errors using __type, and it might contain
        /// a namespace. Clients should just take the last part of the string
        /// after '#'.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorWithDunderTypeAndNamespaceErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes("{\n    \"__type\": \"aws.protocoltests.restjson#FooError\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Some services serialize errors using __type, and it might contain
        /// a namespace. It also might contain a URI. Clients should just
        /// take the last part of the string after '#' and before ":". This
        /// is a pathalogical case that might not occur in any deployed AWS
        /// service.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorWithDunderTypeUriAndNamespaceErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes("{\n    \"__type\": \"aws.protocoltests.restjson#FooError:http://internal.amazon.com/coral/com.amazon.coral.validate/\"\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

        /// <summary>
        /// Some services serialize errors using __type, and if the response
        /// includes additional shapes that belong to a different namespace
        /// there'll be a nested __type property that must not be considered
        /// when determining which error to be surfaced.  For an example
        /// service see Amazon DynamoDB.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonFooErrorWithNestedTypePropertyErrorResponse()
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
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.ASCII.GetBytes("{\n    \"__type\": \"aws.protocoltests.restjson#FooError\",\n    \"ErrorDetails\": [\n      {\n          \"__type\": \"com.amazon.internal#ErrorDetails\",\n          \"reason\": \"Some reason\"\n      }\n    ]\n}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var errorResponse = await Assert.ThrowsExactlyAsync<FooErrorException>(() => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

            // Assert
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500), errorResponse.StatusCode);
        }

    }
}
