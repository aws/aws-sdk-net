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
    public class OutputStream
    {
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task BooleanHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                BooleanHeader = true,
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task ByteHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                    Convert.FromBase64String("AAAASQAAADlvxG1ZDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMKYnl0ZUhlYWRlcgIBKFTmjg==")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                ByteHeader = 1,
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task ShortHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                    Convert.FromBase64String("AAAASwAAADv7Cl8VDTptZXNzYWdlLXR5cGUHAAVldmVudAs6ZXZlbnQtdHlwZQcAB2hlYWRlcnMLc2hvcnRIZWFkZXIDAAL1ETsK")
                ),
            };
            var mockHttp = MockHttpClientUtils.InjectMockHttp(client, mockResponse);

            // Act
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                ShortHeader = 2,
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task IntegerHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                IntHeader = 3,
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task LongHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                LongHeader = 4294967294,
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task BlobHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                BlobHeader = new MemoryStream(Encoding.UTF8.GetBytes("foo")),
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task StringHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                StringHeader = "foo",
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task TimestampHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(HeadersEvent));
            Comparer.CompareObjects<HeadersEvent>(new HeadersEvent
            {
                TimestampHeader = ProtocolTestConstants.epoch.AddMilliseconds(1730384114000),
            }, (HeadersEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task MultipleHeaderOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
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

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task StringPayloadOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(StringPayloadEvent));
            Comparer.CompareObjects<StringPayloadEvent>(new StringPayloadEvent
            {
                Payload = "foo",
            }, (StringPayloadEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task BlobPayloadOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            var actualEvents = actualResponse.Stream.ToList();

            // Assert
            Assert.AreEqual(1, actualEvents.Count);
            Assert.IsInstanceOfType(actualEvents[0], typeof(BlobPayloadEvent));
            Comparer.CompareObjects<BlobPayloadEvent>(new BlobPayloadEvent
            {
                Payload = new MemoryStream(Encoding.UTF8.GetBytes("bar")),
            }, (BlobPayloadEvent)actualEvents[0]);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task StructurePayloadOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
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

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task UnionPayloadOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
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

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task HeadersAndExplicitPayloadOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
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

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task HeadersAndImplicitPayloadOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
            using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
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

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task ClientErrorOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
            Assert.IsInstanceOfType(exception.InnerException, typeof(ErrorEventException));
        }

        /// <summary>
        /// Clients must be able to handle structured, but unmodeled errors.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task ClientUnexpectedErrorOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }

        /// <summary>
        /// Clients must reject events that don't contain a :message-type
        /// header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task MissingMessageTypeOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }

        /// <summary>
        /// Client must reject events that contain a malformed :message-type
        /// header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task MalformedMessageTypeOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }

        /// <summary>
        /// Clients must reject message events that don't contain an
        /// :event-type header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task MissingEventTypeOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }

        /// <summary>
        /// Clients must reject message events that contain a malformed
        /// :event-type header.
        /// </summary>
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task MalformedEventTypeOutputResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
                actualResponse.Stream.ToList();
            }).ConfigureAwait(false);

            // Assert
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task ModeledProtocolErrorResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            }).ConfigureAwait(false);

            // Assert
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task UnmodeledProtocolErrorResponse()
        {
            // Arrange
            var request = new OutputStreamRequest
            {
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
                using var actualResponse = await client.OutputStreamAsync(request).ConfigureAwait(false);
            }).ConfigureAwait(false);

            // Assert
        }

    }
}
