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
    public class EventStreamInitialResponse
    {
        /// <summary>
        /// Non-stream output members are delivered ahead of the stream.
        /// Under rpcv2Cbor the operation's @httpHeader bindings are ignored,
        /// so every non-stream output member travels in the CBOR payload of
        /// an initial-response event rather than in HTTP response headers.
        /// This output has non-stream members and values are provided for
        /// them, so the initial-response event must be sent and the question
        /// the file header leaves open does not arise here.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamInitialResponseResponse()
        {
            // Arrange
            var request = new EventStreamInitialResponseRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("omlzZXNzaW9uSWRrc2Vzc2lvbjRhMmZndGltZW91dBge"), new Dictionary<string, object>
                    {
                        { ":event-type", "initial-response" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("omxzdHJpbmdNZW1iZXJ4Hm1lc3NhZ2UgYWZ0ZXIgaW5pdGlhbCByZXNwb25zZW1pbnRlZ2VyTWVtYmVyGE0="), new Dictionary<string, object>
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
            using var actualResponse = await client.EventStreamInitialResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            var expectedResponse = new EventStreamInitialResponseResponse
            {
                SessionId = "session4a2f",
                Timeout = 30,
            };
            Comparer.CompareObjects(expectedResponse.SessionId, actualResponse.SessionId);
            Comparer.CompareObjects(expectedResponse.Timeout, actualResponse.Timeout);
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(ScalarsEvent));
            Comparer.CompareObjects<ScalarsEvent>(new ScalarsEvent
            {
                StringMember = "message after initial response",
                IntegerMember = 77,
            }, (ScalarsEvent)actualEvents[1]);
        }

    }
}
