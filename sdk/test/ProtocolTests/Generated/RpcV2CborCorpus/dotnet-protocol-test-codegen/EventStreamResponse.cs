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
    public class EventStreamResponse
    {
        /// <summary>
        /// A buffered request that expects a streaming response sets Accept
        /// to the event stream media type while its own Content-Type stays
        /// application/cbor. Content-Length is permitted here, and indeed
        /// expected, because the request itself is buffered. The response
        /// envelope carries the event stream media type as its Content-Type,
        /// and the stream's own frames are covered elsewhere.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseEnvelopeRequestAndResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
            };
            mockResponse.Headers["Content-Type"] = "application/vnd.amazon.eventstream";
            mockResponse.Headers["smithy-protocol"] = "rpc-v2-cbor";
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;

            // Assert
            Assert.AreEqual("POST", actualRequest.Method);
            Assert.AreEqual("/service/RpcV2CborCorpusTests/operation/EventStreamResponse", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
            Assert.AreEqual("application/vnd.amazon.eventstream".Replace(" ",""), actualRequest.Headers["Accept"].Replace(" ",""));
            Assert.AreEqual("application/cbor".Replace(" ",""), actualRequest.Headers["Content-Type"].Replace(" ",""));
            Assert.AreEqual("rpc-v2-cbor".Replace(" ",""), actualRequest.Headers["smithy-protocol"].Replace(" ",""));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amz-Target"));
            Assert.IsFalse(actualRequest.Headers.ContainsKey("X-Amzn-Target"));
            Assert.AreEqual((HttpStatusCode)Enum.ToObject(typeof(HttpStatusCode), 200), actualResponse.HttpStatusCode);
        }

        /// <summary>
        /// EventStreamResponseOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. An event payload keeps arbitrary precision the way a
        /// buffered body does: a bigInteger is CBOR tag 2 or tag 3 over a
        /// byte string holding the big-endian magnitude, and a bigDecimal is
        /// tag 4 over an [exponent, mantissa] pair whose mantissa here
        /// itself needs tag 2. Unlike the quoted-string rule of the
        /// JSON-based protocols, the tags are fixed normatively by this
        /// protocol's shape serialization table, so a bare integer or a
        /// float in place of either tag is a conformance failure: it routes
        /// the value through a double and loses precision. The [exponent,
        /// mantissa] pair is not scale-canonical, so compare the numeric
        /// value rather than the pair.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseArbitraryPrecisionResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("onBiaWdJbnRlZ2VyTWVtYmVywlEDoMkgdcDb87isvF+Wzj8K0nBiaWdEZWNpbWFsTWVtYmVyxII4JsJRCTt4vIi+kNk6woLlCuVp/WU="), new Dictionary<string, object>
                    {
                        { ":event-type", "scalarsEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(ScalarsEvent));
            Comparer.CompareObjects<ScalarsEvent>(new ScalarsEvent
            {
                BigIntegerMember = System.Numerics.BigInteger.Parse("1234567890123456789012345678901234567890", System.Globalization.CultureInfo.InvariantCulture),
                BigDecimalMember = Amazon.Extensions.Numerics.BigDecimal.Parse("3.141592653589793238462643383279502884197", System.Globalization.CultureInfo.InvariantCulture),
            }, (ScalarsEvent)actualEvents[1]);
        }

        /// <summary>
        /// EventStreamResponseOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Deserializes an event whose implicit payload carries
        /// every scalar type: the blob is a raw CBOR byte string rather than
        /// base64, the timestamp is tag 1 epoch seconds, the enum is its
        /// string value and the intEnum is an integer.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseScalarsResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("rG1ib29sZWFuTWVtYmVy9WpieXRlTWVtYmVyCWtzaG9ydE1lbWJlchkCAG1pbnRlZ2VyTWVtYmVyGQTSamxvbmdNZW1iZXIbAAAAAhhxGgBrZmxvYXRNZW1iZXL6P8AAAGxkb3VibGVNZW1iZXL6QBAAAGxzdHJpbmdNZW1iZXJtc2NhbGFycyBldmVudGpibG9iTWVtYmVyQ2Zvb290aW1lc3RhbXBNZW1iZXLBGl/vDZBqc3RyaW5nRW51bWNGb29naW50RW51bQE="), new Dictionary<string, object>
                    {
                        { ":event-type", "scalarsEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(ScalarsEvent));
            Comparer.CompareObjects<ScalarsEvent>(new ScalarsEvent
            {
                BooleanMember = true,
                ByteMember = 9,
                ShortMember = 512,
                IntegerMember = 1234,
                LongMember = 9000000000,
                FloatMember = 1.5F,
                DoubleMember = 2.25,
                StringMember = "scalars event",
                BlobMember = new MemoryStream(Encoding.UTF8.GetBytes("foo")),
                TimestampMember = ProtocolTestConstants.epoch.AddSeconds(1609502096),
                StringEnum = "Foo",
                IntEnum = 1,
            }, (ScalarsEvent)actualEvents[1]);
        }

        /// <summary>
        /// EventStreamResponseOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Deserializes an event whose payload carries lists of
        /// scalars as CBOR arrays.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseListResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("o2dzdHJpbmdzgmVmaXJzdGZzZWNvbmRoaW50ZWdlcnODAQIDanRpbWVzdGFtcHOCwRpf7w2QwRpf8F8Q"), new Dictionary<string, object>
                    {
                        { ":event-type", "listEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(ListEvent));
            Comparer.CompareObjects<ListEvent>(new ListEvent
            {
                Strings =  new List<string>()
                {
                    "first",
                    "second",
                },
                Integers =  new List<int>()
                {
                    1,
                    2,
                    3,
                },
                Timestamps =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1609502096),
                    ProtocolTestConstants.epoch.AddSeconds(1609588496),
                },
            }, (ListEvent)actualEvents[1]);
        }

        /// <summary>
        /// EventStreamResponseOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Deserializes an event whose payload carries maps of
        /// scalars as CBOR maps with text string keys.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseMapResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("o2dzdHJpbmdzomVhbHBoYWVmaXJzdGRiZXRhZnNlY29uZGhpbnRlZ2Vyc6Jjb25lAWN0d28CanRpbWVzdGFtcHOiZXN0YXJ0wRpf7w2QY2VuZMEaX/BfEA=="), new Dictionary<string, object>
                    {
                        { ":event-type", "mapEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(MapEvent));
            Comparer.CompareObjects<MapEvent>(new MapEvent
            {
                Strings = new Dictionary<string, string>()
                {

                    { "alpha", "first" },
                    { "beta", "second" },
                },
                Integers = new Dictionary<string, int>()
                {

                    { "one", 1 },
                    { "two", 2 },
                },
                Timestamps = new Dictionary<string, DateTime>()
                {

                    { "start", ProtocolTestConstants.epoch.AddSeconds(1609502096) },
                    { "end", ProtocolTestConstants.epoch.AddSeconds(1609588496) },
                },
            }, (MapEvent)actualEvents[1]);
        }

        /// <summary>
        /// EventStreamResponseOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Deserializes an event whose payload nests a
        /// structure, which is a CBOR map keyed by member name like any
        /// other.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseStructResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("oWV2YWx1ZaNsc3RyaW5nTWVtYmVybG5lc3RlZFN0cmluZ21pbnRlZ2VyTWVtYmVyGDdtYm9vbGVhbk1lbWJlcvU="), new Dictionary<string, object>
                    {
                        { ":event-type", "structEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(StructEvent));
            Comparer.CompareObjects<StructEvent>(new StructEvent
            {
                Value = new SimpleStruct
                {
                    StringMember = "nestedString",
                    IntegerMember = 55,
                    BooleanMember = true,
                },
            }, (StructEvent)actualEvents[1]);
        }

        /// <summary>
        /// EventStreamResponseOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Deserializes an event whose payload nests a union,
        /// serialized as a CBOR map with exactly one member set.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseUnionResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("oWV2YWx1ZaFrc3RyaW5nVmFsdWVrdW5pb24gZXZlbnQ="), new Dictionary<string, object>
                    {
                        { ":event-type", "unionEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(2, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(UnionEvent));
            Comparer.CompareObjects<UnionEvent>(new UnionEvent
            {
                Value = new CorpusUnion{
                    StringValue = "union event"
                },
            }, (UnionEvent)actualEvents[1]);
        }

        /// <summary>
        /// EventStreamResponseOutput has no members besides the event
        /// stream, so there are no non-stream members to serialize. This
        /// case pins the reading under which an initial-response event is
        /// sent anyway and its payload is the serialization of that empty
        /// set of members, an empty CBOR map, carrying an application/cbor
        /// :content-type. The competing reading, under which no initial
        /// response exists to be sent, is unresolved against it; see the
        /// file header. Dispatches a sequence of events to the correct union
        /// variants. The heartbeat event models an empty structure, so it
        /// carries no payload.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RpcV2CborCorpusTests")]
        public async Task RpcV2CborEventStreamResponseMultipleEventsResponse()
        {
            // Arrange
            var request = new EventStreamResponseRequest
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
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("rG1ib29sZWFuTWVtYmVy9WpieXRlTWVtYmVyB2tzaG9ydE1lbWJlchkBLG1pbnRlZ2VyTWVtYmVyC2psb25nTWVtYmVyGwAAAAHc1lABa2Zsb2F0TWVtYmVy+kBQAABsZG91YmxlTWVtYmVy+kCYAABsc3RyaW5nTWVtYmVybWZpcnN0IG1lc3NhZ2VqYmxvYk1lbWJlckNiYXJvdGltZXN0YW1wTWVtYmVywRpf8F8QanN0cmluZ0VudW1jQmFyZ2ludEVudW0C"), new Dictionary<string, object>
                    {
                        { ":event-type", "scalarsEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Encoding.UTF8.GetBytes(""), new Dictionary<string, object>
                    {
                        { ":event-type", "heartbeatEvent" },
                        { ":message-type", "event" },
                    }),
                    MockHttpClientUtils.EncodeEvent(Convert.FromBase64String("o2dzdHJpbmdzgmV0aGlyZGZmb3VydGhoaW50ZWdlcnOCBAVqdGltZXN0YW1wc4LBGl/xsJDBGl/zAhA="), new Dictionary<string, object>
                    {
                        { ":event-type", "listEvent" },
                        { ":content-type", "application/cbor" },
                        { ":message-type", "event" },
                    })
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.EventStreamResponseAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Events.ToList();

            // Assert
            Assert.AreEqual(4, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(Amazon.Runtime.EventStreams.Internal.InitialResponseEvent));
            Assert.IsInstanceOfType(actualEvents[1], typeof(ScalarsEvent));
            Comparer.CompareObjects<ScalarsEvent>(new ScalarsEvent
            {
                BooleanMember = true,
                ByteMember = 7,
                ShortMember = 300,
                IntegerMember = 11,
                LongMember = 8000000001,
                FloatMember = 3.25F,
                DoubleMember = 4.75,
                StringMember = "first message",
                BlobMember = new MemoryStream(Encoding.UTF8.GetBytes("bar")),
                TimestampMember = ProtocolTestConstants.epoch.AddSeconds(1609588496),
                StringEnum = "Bar",
                IntEnum = 2,
            }, (ScalarsEvent)actualEvents[1]);
            Assert.IsInstanceOfType(actualEvents[2], typeof(HeartbeatEvent));
            Comparer.CompareObjects<HeartbeatEvent>(new HeartbeatEvent
            {
            }, (HeartbeatEvent)actualEvents[2]);
            Assert.IsInstanceOfType(actualEvents[3], typeof(ListEvent));
            Comparer.CompareObjects<ListEvent>(new ListEvent
            {
                Strings =  new List<string>()
                {
                    "third",
                    "fourth",
                },
                Integers =  new List<int>()
                {
                    4,
                    5,
                },
                Timestamps =  new List<DateTime>()
                {
                    ProtocolTestConstants.epoch.AddSeconds(1609674896),
                    ProtocolTestConstants.epoch.AddSeconds(1609761296),
                },
            }, (ListEvent)actualEvents[3]);
        }

    }
}
