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
    public class EventStreamInitialRequest
    {
        #if NET8_0_OR_GREATER
        /// <summary>
        /// Non-stream input members are sent ahead of the stream. Under
        /// rpcv2Cbor the operation's @httpHeader bindings are ignored, so
        /// every non-stream input member travels in the CBOR payload of an
        /// initial-request event rather than in HTTP headers.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamInitialRequestRequest()
        {
            // Arrange
            var inputEvents = new Queue<IRequestEventStreamEvent>(new IRequestEventStreamEvent[]
            {
                new SendMessageEvent
                {
                    Content = "after initial request",
                },
            });
            var request = new EventStreamInitialRequestRequest
            {
                RequestId = "request-5f1c",
                Priority = 7,
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
            using var actualResponse = await client.EventStreamInitialRequestAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/service/RpcV2CborCorpusTests/operation/EventStreamInitialRequest", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/cbor".Replace(" ",""), actualRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/vnd.amazon.eventstream".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), actualRequest.Headers["smithy-protocol"].Replace(" ",""));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amz-Target"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amzn-Target"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Request-Id"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Priority"));
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(2, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "initial-request");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[0].Payload, "omlyZXF1ZXN0SWRscmVxdWVzdC01ZjFjaHByaW9yaXR5Bw==");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":event-type", "sendMessage");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":content-type", "application/cbor");
            MockHttpClientUtils.AssertEventHeader(sentEvents[1], ":message-type", "event");
            CborProtocolUtils.AssertBody(sentEvents[1].Payload, "oWdjb250ZW50dWFmdGVyIGluaXRpYWwgcmVxdWVzdA==");
        }
        #endif

    }
}
