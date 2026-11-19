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
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.RpcV2CborCorpusTests
{
    [TestClass]
    public class EventStreamRequest
    {
        #if NET8_0_OR_GREATER
        /// <summary>
        /// EventStreamRequestInput has no members besides the event stream,
        /// so no initial request is modeled and there are no non-stream
        /// members to serialize. This case pins the behavior of sending an
        /// initial-request event anyway, ahead of the stream's events,
        /// carrying the serialization of that empty set of members -- an
        /// empty CBOR map, written as the canonical definite-length 0xa0 --
        /// plus an application/cbor :content-type. The streaming
        /// specification states that when an initial request is not modeled
        /// a client MUST NOT send one and a server MUST NOT expect one, and
        /// that a client or server MUST NOT fail when an initial message
        /// containing only optional members is not received. This case
        /// therefore asserts behavior the specification forbids a client to
        /// produce, and it does NOT establish conformance: a client that
        /// correctly omits the event fails it, and a client that passes it
        /// has not been shown to conform. Serializes a single struct-payload
        /// event onto a request stream as CBOR. An event streaming request
        /// sets Content-Type to the event stream media type, must not set a
        /// Content-Length, and must not name the operation in either target
        /// header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamRequestSendMessageRequest()
        {
            // Arrange
            var inputEvents = new Queue<IRequestEventStreamEvent>(new IRequestEventStreamEvent[]
            {
                new SendMessageEvent
                {
                    Content = "outbound message",
                },
            });
            var request = new EventStreamRequestRequest
            {
                EventsPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRpcV2CBORCorpusProtocolTestsConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRpcV2CBORCorpusProtocolTestsClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            using var actualResponse = await client.EventStreamRequestAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/service/RpcV2CborCorpusTests/operation/EventStreamRequest", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), actualRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/vnd.amazon.eventstream".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), actualRequest.Headers["smithy-protocol"].Replace(" ",""));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amz-Target"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amzn-Target"));
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(2, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "initial-request");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[0].Payload, "oA==");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":event-type", "sendMessage");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[1].Payload, "oWdjb250ZW50cG91dGJvdW5kIG1lc3NhZ2U=");
        }
        #endif

        #if NET8_0_OR_GREATER
        /// <summary>
        /// EventStreamRequestInput has no members besides the event stream,
        /// so no initial request is modeled and there are no non-stream
        /// members to serialize. This case pins the behavior of sending an
        /// initial-request event anyway, ahead of the stream's events,
        /// carrying the serialization of that empty set of members -- an
        /// empty CBOR map, written as the canonical definite-length 0xa0 --
        /// plus an application/cbor :content-type. The streaming
        /// specification states that when an initial request is not modeled
        /// a client MUST NOT send one and a server MUST NOT expect one, and
        /// that a client or server MUST NOT fail when an initial message
        /// containing only optional members is not received. This case
        /// therefore asserts behavior the specification forbids a client to
        /// produce, and it does NOT establish conformance: a client that
        /// correctly omits the event fails it, and a client that passes it
        /// has not been shown to conform. Serializes a sequence of events
        /// onto a request stream, closing with an empty-structure event that
        /// carries no payload.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamRequestMultipleEventsRequest()
        {
            // Arrange
            var inputEvents = new Queue<IRequestEventStreamEvent>(new IRequestEventStreamEvent[]
            {
                new SendMessageEvent
                {
                    Content = "outbound message",
                },
                new SendMessageEvent
                {
                    Content = "second outbound message",
                },
                new EndStreamEvent
                {
                },
            });
            var request = new EventStreamRequestRequest
            {
                EventsPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRpcV2CBORCorpusProtocolTestsConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRpcV2CBORCorpusProtocolTestsClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "text/xml",
                Body = Encoding.UTF8.GetBytes("<Response/>"),
            });

            // Act
            using var actualResponse = await client.EventStreamRequestAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/service/RpcV2CborCorpusTests/operation/EventStreamRequest", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), actualRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/vnd.amazon.eventstream".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), actualRequest.Headers["smithy-protocol"].Replace(" ",""));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amz-Target"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amzn-Target"));
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(4, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "initial-request");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[0].Payload, "oA==");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":event-type", "sendMessage");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[1].Payload, "oWdjb250ZW50cG91dGJvdW5kIG1lc3NhZ2U=");
            MockHttpClientUtils.AssertEventHeader(sentEvents[2], ":event-type", "sendMessage");
            MockHttpClientUtils.AssertEventHeader(sentEvents[2], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[2], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[2].Payload, "oWdjb250ZW50d3NlY29uZCBvdXRib3VuZCBtZXNzYWdl");
            MockHttpClientUtils.AssertEventHeader(sentEvents[3], ":event-type", "endStream");
            MockHttpClientUtils.AssertEventHeader(sentEvents[3], ":message-type", "event");
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes(""), sentEvents[3].Payload);
        }
        #endif

    }
}
