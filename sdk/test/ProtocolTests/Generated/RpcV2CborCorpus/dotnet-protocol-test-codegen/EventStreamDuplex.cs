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
    public class EventStreamDuplex
    {
        #if NET8_0_OR_GREATER
        /// <summary>
        /// A duplex stream carries both initial messages: the input members
        /// go out in an initial-request event and the output members come
        /// back in an initial-response event, each ahead of their own
        /// stream's events. Accept and Content-Type are both the event
        /// stream media type because both directions stream.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamDuplexRequestAndResponse()
        {
            // Arrange
            var inputEvents = new Queue<IRequestEventStreamEvent>(new IRequestEventStreamEvent[]
            {
                new SendMessageEvent
                {
                    Content = "duplex outbound",
                },
            });
            var request = new EventStreamDuplexRequest
            {
                RequestId = "duplex-3ba9",
                EventsPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
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
                Body = MockHttpClientUtils.EncodeEvents(
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("oWlzZXNzaW9uSWRxZHVwbGV4LXNlc3Npb24tNzc="), new Dictionary<string, object>
                    {
                        { ":event-type", "initial-response" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("omxzdHJpbmdNZW1iZXJuZHVwbGV4IGluYm91bmRtaW50ZWdlck1lbWJlchhY"), new Dictionary<string, object>
                    {
                        { ":event-type", "scalarsEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            mockResponse.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            mockResponse.Headers["smithy-protocol"] = "rpc-v2-cbor";
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamDuplexAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/service/RpcV2CborCorpusTests/operation/EventStreamDuplex", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/vnd.amazon.eventstream".Replace(" ",""), actualRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/vnd.amazon.eventstream".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), actualRequest.Headers["smithy-protocol"].Replace(" ",""));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amz-Target"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amzn-Target"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Request-Id"));
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(2, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "initial-request");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[0].Payload, "oWlyZXF1ZXN0SWRrZHVwbGV4LTNiYTk=");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":event-type", "sendMessage");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[1].Payload, "oWdjb250ZW50b2R1cGxleCBvdXRib3VuZA==");
            var expectedResponse = new EventStreamDuplexResponse
            {
                SessionId = "duplex-session-77",
            };
            Comparer.CompareObjects(expectedResponse.SessionId, actualResponse.SessionId);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(ScalarsEvent));
            Comparer.CompareObjects<ScalarsEvent>(new ScalarsEvent
            {
                StringMember = "duplex inbound",
                IntegerMember = 88,
            }, (ScalarsEvent)actualEvents[1]);
        }
        #endif

    }
}
