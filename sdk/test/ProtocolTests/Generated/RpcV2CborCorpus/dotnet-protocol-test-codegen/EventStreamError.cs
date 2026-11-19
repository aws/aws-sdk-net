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
using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.RpcV2CBORCorpusProtocolTests;
using Amazon.RpcV2CBORCorpusProtocolTests.Model;
using Amazon.RpcV2CBORCorpusProtocolTests.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.RpcV2CborCorpusTests
{
    [TestClass]
    public class EventStreamError
    {
        /// <summary>
        /// EventStreamErrorOutput has no members besides the event stream,
        /// so there are no non-stream members to serialize. This case pins
        /// the reading under which an initial-response event is sent anyway
        /// and its payload is the serialization of that empty set of
        /// members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. A modeled error event uses :message-type "exception"
        /// and names the union member in :exception-type, and resolves to
        /// the modeled error shape rather than a generic failure.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamErrorModeledResponse()
        {
            // Arrange
            var request = new EventStreamErrorRequest
            {
            };
            var config = new AmazonRpcV2CBORCorpusProtocolTestsConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRpcV2CBORCorpusProtocolTestsClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                ContentType = "application/vnd.amazon.eventstream",
                Body = MockHttpClientUtils.EncodeEvents(
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("oA=="), new Dictionary<string, object>
                    {
                        { ":event-type", "initial-response" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("omdtZXNzYWdlbXN0cmVhbSBmYWlsZWRkY29kZRg5"), new Dictionary<string, object>
                    {
                        { ":exception-type", "streamError" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "exception" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsExactlyAsync<RpcV2CBORCorpusProtocolTestsEventStreamException>(async () =>
            {
                using var actualResponse = await client.EventStreamErrorAsync(request).ConfigureAwait(false);
                actualResponse.Events.ToList();
            }).ConfigureAwait(false);

            // Assert
            Assert.IsInstanceOfType(exception.InnerException, typeof(StreamErrorException));
        }

        /// <summary>
        /// EventStreamErrorOutput has no members besides the event stream,
        /// so there are no non-stream members to serialize. This case pins
        /// the reading under which an initial-response event is sent anyway
        /// and its payload is the serialization of that empty set of
        /// members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. An error event arriving after successfully delivered
        /// events still resolves to the modeled error shape, so the events
        /// preceding it must not mask it.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamErrorAfterMessageResponse()
        {
            // Arrange
            var request = new EventStreamErrorRequest
            {
            };
            var config = new AmazonRpcV2CBORCorpusProtocolTestsConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRpcV2CBORCorpusProtocolTestsClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                ContentType = "application/vnd.amazon.eventstream",
                Body = MockHttpClientUtils.EncodeEvents(
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("oA=="), new Dictionary<string, object>
                    {
                        { ":event-type", "initial-response" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("omdjb250ZW50eBhkZWxpdmVyZWQgYmVmb3JlIGZhaWx1cmVoc2VxdWVuY2UYQg=="), new Dictionary<string, object>
                    {
                        { ":event-type", "messageEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("omdtZXNzYWdlbXN0cmVhbSBmYWlsZWRkY29kZRg5"), new Dictionary<string, object>
                    {
                        { ":exception-type", "streamError" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "exception" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsExactlyAsync<RpcV2CBORCorpusProtocolTestsEventStreamException>(async () =>
            {
                using var actualResponse = await client.EventStreamErrorAsync(request).ConfigureAwait(false);
                actualResponse.Events.ToList();
            }).ConfigureAwait(false);

            // Assert
            Assert.IsInstanceOfType(exception.InnerException, typeof(StreamErrorException));
        }

        /// <summary>
        /// EventStreamErrorOutput has no members besides the event stream,
        /// so there are no non-stream members to serialize. This case pins
        /// the reading under which an initial-response event is sent anyway
        /// and its payload is the serialization of that empty set of
        /// members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Clients must handle a structured but unmodeled
        /// error, which uses :message-type "error" with the code and message
        /// carried entirely in headers and no payload. No specification
        /// fixes the value of either :error-code or :error-message, so only
        /// their presence is asserted.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamErrorUnmodeledResponse()
        {
            // Arrange
            var request = new EventStreamErrorRequest
            {
            };
            var config = new AmazonRpcV2CBORCorpusProtocolTestsConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRpcV2CBORCorpusProtocolTestsClient(MockHttpClientUtils.TestCredentials, config);
            var mockResponse = new MockHttpResponse
            {
                StatusCode = (HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200),
                ContentType = "application/vnd.amazon.eventstream",
                Body = MockHttpClientUtils.EncodeEvents(
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("oA=="), new Dictionary<string, object>
                    {
                        { ":event-type", "initial-response" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Encoding.UTF8.GetBytes(""), new Dictionary<string, object>
                    {
                        { ":message-type", "error" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(async () =>
            {
                using var actualResponse = await client.EventStreamErrorAsync(request).ConfigureAwait(false);
                actualResponse.Events.ToList();
            }).ConfigureAwait(false);

            // Assert
        }

    }
}
