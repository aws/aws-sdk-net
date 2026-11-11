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
    public class DuplexStream
    {
        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexBooleanHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    BooleanHeader = true,
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "booleanHeader", true);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexIntegerHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    IntHeader = 3,
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "intHeader", 3);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexLongHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    LongHeader = 4294967294,
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "longHeader", 4294967294L);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexBlobHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    BlobHeader = new MemoryStream(Encoding.UTF8.GetBytes("foo")),
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "blobHeader", Convert.FromBase64String("Zm9v"));
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexStringHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    StringHeader = "foo",
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "stringHeader", "foo");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexTimestampHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    TimestampHeader = ProtocolTestConstants.epoch.AddMilliseconds(1730384114000),
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "timestampHeader", ProtocolTestConstants.epoch.AddMilliseconds(1730384114000));
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexMultipleHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    BooleanHeader = true,
                    StringHeader = "foo",
                    BlobHeader = new MemoryStream(Encoding.UTF8.GetBytes("bar")),
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "blobHeader", Convert.FromBase64String("YmFy"));
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "booleanHeader", true);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "stringHeader", "foo");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexStringPayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new StringPayloadEvent
                {
                    Payload = "foo",
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "stringPayload");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "text/plain");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("foo"), sentEvents[0].Payload);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexBlobPayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new BlobPayloadEvent
                {
                    Payload = new MemoryStream(Encoding.UTF8.GetBytes("bar")),
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "blobPayload");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/octet-stream");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            CollectionAssert.AreEqual(Encoding.UTF8.GetBytes("bar"), sentEvents[0].Payload);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexStructurePayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new StructurePayloadEvent
                {
                    Payload = new PayloadStructure
                    {
                        StructureMember = "foo",
                    },
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "structurePayload");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/json");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            JsonProtocolUtils.AssertBody(sentEvents[0].Payload, "{\"structureMember\":\"foo\"}");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexUnionPayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new UnionPayloadEvent
                {
                    Payload = new PayloadUnion{
                        UnionMember = "bar"
                    },
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "unionPayload");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/json");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            JsonProtocolUtils.AssertBody(sentEvents[0].Payload, "{\"unionMember\":\"bar\"}");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexHeadersAndExplicitPayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersAndExplicitPayloadEvent
                {
                    Header = "foo",
                    Payload = new PayloadStructure
                    {
                        StructureMember = "bar",
                    },
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "header", "foo");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headersAndExplicitPayload");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/json");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            JsonProtocolUtils.AssertBody(sentEvents[0].Payload, "{\"structureMember\":\"bar\"}");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task DuplexHeadersAndImplicitPayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersAndImplicitPayloadEvent
                {
                    Header = "foo",
                    Payload = "bar",
                },
            });
            var request = new DuplexStreamRequest
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
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], "header", "foo");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headersAndImplicitPayload");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":content-type", "application/json");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            JsonProtocolUtils.AssertBody(sentEvents[0].Payload, "{\"payload\":\"bar\"}");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexBooleanHeaderOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAASwAAADv7Cl8VDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMNYm9vbGVhbkhlYWRlcgC4J9Ws")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                BooleanHeader = true,
            }, (HeadersEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexIntegerHeaderOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAASwAAADv7Cl8VDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMJaW50SGVhZGVyBAAAAAPlyUrb")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                IntHeader = 3,
            }, (HeadersEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexLongHeaderOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAUAAAAEAr7VEyDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMKbG9uZ0hlYWRlcgUAAAAA/////udnd/I=")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                LongHeader = 4294967294,
            }, (HeadersEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexBlobHeaderOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAATQAAAD2dKQ+ADTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMKYmxvYkhlYWRlcgYAA2Zvb5sbbGM=")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                BlobHeader = new MemoryStream(Encoding.UTF8.GetBytes("foo")),
            }, (HeadersEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexStringHeaderOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAATwAAAD8J5z3MDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMMc3RyaW5nSGVhZGVyBwADZm9vxT+2MA==")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                StringHeader = "foo",
            }, (HeadersEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexTimestampHeaderOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAVQAAAEWTZyrNDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMPdGltZXN0YW1wSGVhZGVyCAAAAZLi7jFQ6uV3Eg==")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                TimestampHeader = ProtocolTestConstants.epoch.AddMilliseconds(1730384114000),
            }, (HeadersEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexMultipleHeaderOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAbwAAAF+FlHOQDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMNYm9vbGVhbkhlYWRlcgAMc3RyaW5nSGVhZGVyBwADZm9vCmJsb2JIZWFkZXIGAANiYXIDXbo7")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                BooleanHeader = true,
                StringHeader = "foo",
                BlobHeader = new MemoryStream(Encoding.UTF8.GetBytes("bar")),
            }, (HeadersEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexStringPayloadOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAYAAAAE30fZUJDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcADXN0cmluZ1BheWxvYWQNOmNvbnRlbnQtdHlwZQcACnRleHQvcGxhaW5mb29G1ELr")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(StringPayloadEvent));
            Comparer.CompareObjects<StringPayloadEvent>(new StringPayloadEvent
            {
                Payload = "foo",
            }, (StringPayloadEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexBlobPayloadOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAbAAAAFkrV6x1DTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAC2Jsb2JQYXlsb2FkDTpjb250ZW50LXR5cGUHABhhcHBsaWNhdGlvbi9vY3RldC1zdHJlYW1iYXJv5nGJ")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(BlobPayloadEvent));
            Comparer.CompareObjects<BlobPayloadEvent>(new BlobPayloadEvent
            {
                Payload = new MemoryStream(Encoding.UTF8.GetBytes("bar")),
            }, (BlobPayloadEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexStructurePayloadOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAfwAAAFacqFy2DTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAEHN0cnVjdHVyZVBheWxvYWQNOmNvbnRlbnQtdHlwZQcAEGFwcGxpY2F0aW9uL2pzb257InN0cnVjdHVyZU1lbWJlciI6ImZvbyJ9rcIRVA==")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(StructurePayloadEvent));
            Comparer.CompareObjects<StructurePayloadEvent>(new StructurePayloadEvent
            {
                Payload = new PayloadStructure
                {
                    StructureMember = "foo",
                },
            }, (StructurePayloadEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexUnionPayloadOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAdwAAAFKrtdNuDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcADHVuaW9uUGF5bG9hZA06Y29udGVudC10eXBlBwAQYXBwbGljYXRpb24vanNvbnsidW5pb25NZW1iZXIiOiJiYXIifcZDMD4=")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(UnionPayloadEvent));
            Comparer.CompareObjects<UnionPayloadEvent>(new UnionPayloadEvent
            {
                Payload = new PayloadUnion{
                    UnionMember = "bar"
                },
            }, (UnionPayloadEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexHeadersAndExplicitPayloadOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAlQAAAGw4wFp6DTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAGWhlYWRlcnNBbmRFeHBsaWNpdFBheWxvYWQNOmNvbnRlbnQtdHlwZQcAEGFwcGxpY2F0aW9uL2pzb24GaGVhZGVyBwADZm9veyJzdHJ1Y3R1cmVNZW1iZXIiOiJiYXIifTafKXs=")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersAndExplicitPayloadEvent));
            Comparer.CompareObjects<HeadersAndExplicitPayloadEvent>(new HeadersAndExplicitPayloadEvent
            {
                Header = "foo",
                Payload = new PayloadStructure
                {
                    StructureMember = "bar",
                },
            }, (HeadersAndExplicitPayloadEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexHeadersAndImplicitPayloadOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAjQAAAGxoUIY5DTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAGWhlYWRlcnNBbmRJbXBsaWNpdFBheWxvYWQNOmNvbnRlbnQtdHlwZQcAEGFwcGxpY2F0aW9uL2pzb24GaGVhZGVyBwADZm9veyJwYXlsb2FkIjoiYmFyIn15lZtT")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersAndImplicitPayloadEvent));
            Comparer.CompareObjects<HeadersAndImplicitPayloadEvent>(new HeadersAndImplicitPayloadEvent
            {
                Header = "foo",
                Payload = "bar",
            }, (HeadersAndImplicitPayloadEvent)actualEvents[0]);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexClientErrorOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAdAAAAFObEpkoDTptZXNzYWdlLXR5cGUHAAlleGNlcHRpb24POmV4Y2VwdGlvbi10eXBlBwAFZXJyb3INOmNvbnRlbnQtdHlwZQcAEGFwcGxpY2F0aW9uL2pzb257Im1lc3NhZ2UiOiJmb28ifTua1S8=")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsExactlyAsync<RestJsonProtocolEventStreamException>(async () =>
            {
                using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
            Assert.IsInstanceOfType(exception.InnerException, typeof(ErrorEventException));
        }
        #endif

        #if NET8_0_OR_GREATER
        /// <summary>
        /// Clients must be able to handle structured, but unmodeled errors.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexClientUnexpectedErrorOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAbwAAAF+FlHOQDTptZXNzYWdlLXR5cGUHAAVlcnJvcgs6ZXJyb3ItY29kZQcADmludGVybmFsLWVycm9yDjplcnJvci1tZXNzYWdlBwAaQW4gdW5rbm93biBlcnJvciBvY2N1cnJlZC4kun0t")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(async () =>
            {
                using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }
        #endif

        #if NET8_0_OR_GREATER
        /// <summary>
        /// Clients must reject events that don't contain a :message-type
        /// header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexMissingMessageTypeOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAfwAAAFacqFy2CzpldmVudC10eXBlBwAZaGVhZGVyc0FuZEV4cGxpY2l0UGF5bG9hZA06Y29udGVudC10eXBlBwAQYXBwbGljYXRpb24vanNvbgZoZWFkZXIHAANmb297InN0cnVjdHVyZU1lbWJlciI6ImJhciJ98LexJg==")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(async () =>
            {
                using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }
        #endif

        #if NET8_0_OR_GREATER
        /// <summary>
        /// Client must reject events that contain a malformed :message-type
        /// header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexMalformedMessageTypeOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAlQAAAGw4wFp6DTptZXNzYWdlLXR5cGUGAAVldmVudAs6ZXZlbnQtdHlwZQcAGWhlYWRlcnNBbmRFeHBsaWNpdFBheWxvYWQNOmNvbnRlbnQtdHlwZQcAEGFwcGxpY2F0aW9uL2pzb24GaGVhZGVyBwADZm9veyJzdHJ1Y3R1cmVNZW1iZXIiOiJiYXIifVwdfzU=")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(async () =>
            {
                using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }
        #endif

        #if NET8_0_OR_GREATER
        /// <summary>
        /// Clients must reject message events that don't contain an
        /// :event-type header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexMissingEventTypeOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAbQAAAER1MekcDTptZXNzYWdlLXR5cGUHAAVldmVudA06Y29udGVudC10eXBlBwAQYXBwbGljYXRpb24vanNvbgZoZWFkZXIHAANmb297InN0cnVjdHVyZU1lbWJlciI6ImJhciJ9riy0Gg==")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(async () =>
            {
                using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }
        #endif

        #if NET8_0_OR_GREATER
        /// <summary>
        /// Clients must reject message events that contain a malformed
        /// :event-type header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task DuplexMalformedEventTypeOutputResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
            });
            var request = new DuplexStreamRequest
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
                Body = MockHttpClientUtils.EncodeEvents(
                    Convert.FromBase64String("AAAAlQAAAGw4wFp6DTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQYAGWhlYWRlcnNBbmRFeHBsaWNpdFBheWxvYWQNOmNvbnRlbnQtdHlwZQcAEGFwcGxpY2F0aW9uL2pzb24GaGVhZGVyBwADZm9veyJzdHJ1Y3R1cmVNZW1iZXIiOiJiYXIifcP6KLk=")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            var exception = await Assert.ThrowsAsync<Exception>(async () =>
            {
                using var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }
        #endif

    }
}
