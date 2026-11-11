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
    public class DuplexStreamWithInitialMessages
    {
        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexInitialRequestInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamWithInitialMessagesRequest
            {
                InitialRequestMember = "foo",
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                ContentType = "application/vnd.amazon.eventstream",
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamWithInitialMessagesAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/DuplexStreamWithInitialMessages", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("foo".Replace(" ",""), actualRequest.Headers["initial-request-member"].Replace(" ",""));
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexInitialResponseOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamWithInitialMessagesRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                ContentType = "application/vnd.amazon.eventstream",
            };
            mockResponse.Headers["initial-response-member"] = "foo";
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamWithInitialMessagesAsync(request).ConfigureAwait(false);

            // Assert
            var expectedResponse = new DuplexStreamWithInitialMessagesResponse
            {
                InitialResponseMember = "foo",
            };
            Comparer.CompareObjects(expectedResponse.InitialResponseMember, actualResponse.InitialResponseMember);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexModeledProtocolErrorResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamWithInitialMessagesRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.UTF8.GetBytes("{\"message\": \"foo\"}"),
            };
            mockResponse.Headers["Content-Type"] = "application/json";
            mockResponse.Headers["X-Amzn-Errortype"] = "ServiceUnavailableError";
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsExactlyAsync<ServiceUnavailableErrorException>(async () =>
            {
                using var actualResponse = await client.DuplexStreamWithInitialMessagesAsync(request).ConfigureAwait(false);
            }).ConfigureAwait(false);

            // Assert
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexUnmodeledProtocolErrorResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamWithInitialMessagesRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 500),
                Body = Encoding.UTF8.GetBytes("service unavailable"),
            };
            mockResponse.Headers["Content-Type"] = "text/plain";
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(async () =>
            {
                using var actualResponse = await client.DuplexStreamWithInitialMessagesAsync(request).ConfigureAwait(false);
            }).ConfigureAwait(false);

            // Assert
        }
        #endif

    }
}
