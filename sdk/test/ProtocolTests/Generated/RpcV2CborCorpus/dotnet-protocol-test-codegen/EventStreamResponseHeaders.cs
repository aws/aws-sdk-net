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
    public class EventStreamResponseHeaders
    {
        /// <summary>
        /// EventStreamResponseHeadersOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Each @eventHeader member is carried as a typed event
        /// stream message header rather than in the payload, so the event
        /// stream framing fixes their encoding and this protocol does not. A
        /// string @eventPayload is written as raw text and takes the
        /// text/plain content type.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseHeadersResponse()
        {
            // Arrange
            var request = new EventStreamResponseHeadersRequest
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
                    MockHttpClientUtils.EncodeEvent(Encoding.UTF8.GetBytes("event payload text"), new Dictionary<string, object>
                    {
                        { "blobHeader", Convert.FromBase64String("aGVhZGVy") },
                        { "integerHeader", 1234 },
                        { "booleanHeader", true },
                        { "byteHeader", (sbyte)9 },
                        { "shortHeader", (short)512 },
                        { "timestampHeader", ProtocolTestConstants.epoch.AddMilliseconds(1609502096000) },
                        { ":event-type", "headerEvent" },
                        { ":content-type", "text/plain" },
                        { ":message-type", "event" },
                        { "longHeader", 9000000000L },
                        { "stringHeader", "headerString" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseHeadersAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(HeaderEvent));
            Comparer.CompareObjects<HeaderEvent>(new HeaderEvent
            {
                StringHeader = "headerString",
                IntegerHeader = 1234,
                BooleanHeader = true,
                ByteHeader = 9,
                ShortHeader = 512,
                LongHeader = 9000000000,
                TimestampHeader = ProtocolTestConstants.epoch.AddSeconds(1609502096),
                BlobHeader = new MemoryStream(Encoding.UTF8.GetBytes("header")),
                Body = "event payload text",
            }, (HeaderEvent)actualEvents[1]);
        }

    }
}
