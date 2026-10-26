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
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.RestJson
{
    [TestClass]
    public class InputStream
    {
        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task BooleanHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    BooleanHeader = true,
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task ByteHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    ByteHeader = 1,
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertIntegerEventHeader(sentEvents[0], "byteHeader", 1L);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task ShortHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    ShortHeader = 2,
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertIntegerEventHeader(sentEvents[0], "shortHeader", 2L);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task IntegerHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    IntHeader = 3,
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertIntegerEventHeader(sentEvents[0], "intHeader", 3L);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task LongHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    LongHeader = 4294967294,
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
            var actualRequest = mockHttp.LastCreatedRequest;
            await actualRequest.InputStreamCompleted.ConfigureAwait(false);

            // Assert
            var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
            Assert.AreEqual(1, sentEvents.Count);
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":event-type", "headers");
            MockHttpClientUtils.AssertEventHeader(sentEvents[0], ":message-type", "event");
            MockHttpClientUtils.AssertIntegerEventHeader(sentEvents[0], "longHeader", 4294967294L);
        }
        #endif

        #if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task BlobHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    BlobHeader = new MemoryStream(Encoding.UTF8.GetBytes("foo")),
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task StringHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    StringHeader = "foo",
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task TimestampHeaderInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersEvent
                {
                    TimestampHeader = ProtocolTestConstants.epoch.AddMilliseconds(1730384114000),
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task MultipleHeaderInputRequest()
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
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task StringPayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new StringPayloadEvent
                {
                    Payload = "foo",
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task BlobPayloadInputRequest()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new BlobPayloadEvent
                {
                    Payload = new MemoryStream(Encoding.UTF8.GetBytes("bar")),
                },
            });
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task StructurePayloadInputRequest()
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
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task UnionPayloadInputRequest()
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
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task HeadersAndExplicitPayloadInputRequest()
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
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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
        public async Task HeadersAndImplicitPayloadInputRequest()
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
            var request = new InputStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            var config = new AmazonRestJsonProtocolConfig
            {
              ServiceURL = MockHttpClientUtils.TestServiceUrl,
              MaxErrorRetry = 0,
            };

            using var client = new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
            {
                ContentType = "application/json",
                Body = Encoding.UTF8.GetBytes("{}"),
            });

            // Act
            using var actualResponse = await client.InputStreamAsync(request).ConfigureAwait(false);
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

    }
}
