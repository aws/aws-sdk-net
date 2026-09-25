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

using Amazon.RestJsonProtocol;
using Amazon.RestJsonProtocol.Model;
using AWSSDK.ProtocolTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.RestJson
{
    /// <summary>
    /// Sample protocol tests that run end-to-end through a real client with a mocked HTTP layer.
    /// These mirror existing generated tests and are the pattern the generator will move to.
    /// </summary>
    [TestClass]
    public class MockHttpSampleTests
    {
        private static AmazonRestJsonProtocolClient CreateClient()
        {
            var config = new AmazonRestJsonProtocolConfig
            {
                ServiceURL = MockHttpClientUtils.TestServiceUrl,
                MaxErrorRetry = 0,
            };
            return new AmazonRestJsonProtocolClient(MockHttpClientUtils.TestCredentials, config);
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonAllQueryStringTypesRequest()
        {
            // Arrange
            var request = new AllQueryStringTypesRequest
            {
                QueryString = "Hello there",
                QueryStringList = new List<string>() { "a", "b", "c", },
                QueryInteger = 3,
                QueryBoolean = true,
            };
            using (var client = CreateClient())
            {
                var factory = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse());

                // Act
                await client.AllQueryStringTypesAsync(request).ConfigureAwait(false);

                // Assert
                var actualRequest = factory.LastCreatedRequest;
                Assert.AreEqual("GET", actualRequest.Method);
                Assert.AreEqual("/AllQueryStringTypesInput", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
                var actualQuerySegments = ProtocolTestUtils.GetQuerySegmentsFromOriginalString(actualRequest.RequestUri);
                Assert.IsTrue(actualQuerySegments.Contains("String=Hello%20there"));
                Assert.IsTrue(actualQuerySegments.Contains("StringList=a"));
                Assert.IsTrue(actualQuerySegments.Contains("StringList=b"));
                Assert.IsTrue(actualQuerySegments.Contains("StringList=c"));
                Assert.IsTrue(actualQuerySegments.Contains("Integer=3"));
                Assert.IsTrue(actualQuerySegments.Contains("Boolean=true"));
                Assert.IsTrue(actualRequest.Headers.ContainsKey("Authorization"));
            }
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonSimpleScalarPropertiesRequest()
        {
            // Arrange
            var request = new SimpleScalarPropertiesRequest
            {
                Foo = "Foo",
                StringValue = "string",
                TrueBooleanValue = true,
                FalseBooleanValue = false,
                ByteValue = 1,
                ShortValue = 2,
                IntegerValue = 3,
                LongValue = 4,
                FloatValue = 5.5F,
                DoubleValue = 6.5,
            };
            using (var client = CreateClient())
            {
                var factory = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
                {
                    Body = Encoding.UTF8.GetBytes("{}"),
                    ContentType = "application/json",
                });

                // Act
                await client.SimpleScalarPropertiesAsync(request).ConfigureAwait(false);

                // Assert
                var actualRequest = factory.LastCreatedRequest;
                var expectedBody = "{\n    \"stringValue\": \"string\",\n    \"trueBooleanValue\": true,\n    \"falseBooleanValue\": false,\n    \"byteValue\": 1,\n    \"shortValue\": 2,\n    \"integerValue\": 3,\n    \"longValue\": 4,\n    \"floatValue\": 5.5,\n    \"DoubleDribble\": 6.5\n}";
                JsonProtocolUtils.AssertBody(actualRequest.Body, expectedBody);
                Assert.AreEqual("PUT", actualRequest.Method);
                Assert.AreEqual("/SimpleScalarProperties", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
                Assert.AreEqual("application/json", actualRequest.Headers["Content-Type"].Replace(" ", ""));
                Assert.AreEqual("Foo", actualRequest.Headers["X-Foo"]);
            }
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonGreetingWithErrorsResponse()
        {
            // Arrange
            using (var client = CreateClient())
            {
                var response = new MockHttpResponse
                {
                    StatusCode = HttpStatusCode.OK,
                    Body = Encoding.UTF8.GetBytes("{}"),
                };
                response.Headers["X-Greeting"] = "Hello";
                MockHttpClientUtils.InjectMockHttp(client, response);

                // Act
                var actualResponse = await client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest()).ConfigureAwait(false);

                // Assert
                // Comparer.CompareObjects can't be used on a response from a real client because
                // the pipeline also populates ResponseMetadata, which the comparer can't reflect over.
                Assert.AreEqual("Hello", actualResponse.Greeting);
                Assert.AreEqual(HttpStatusCode.OK, actualResponse.HttpStatusCode);
            }
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ErrorTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonInvalidGreetingErrorErrorResponse()
        {
            // Arrange
            using (var client = CreateClient())
            {
                var response = new MockHttpResponse
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    ContentType = "application/json",
                    Body = Encoding.UTF8.GetBytes("{\n    \"Message\": \"Hi\"\n}"),
                };
                response.Headers["X-Amzn-Errortype"] = "InvalidGreeting";
                MockHttpClientUtils.InjectMockHttp(client, response);

                // Act
                var exception = await Assert.ThrowsExactlyAsync<InvalidGreetingException>(
                    () => client.GreetingWithErrorsAsync(new GreetingWithErrorsRequest())).ConfigureAwait(false);

                // Assert
                Assert.AreEqual(HttpStatusCode.BadRequest, exception.StatusCode);
                Assert.AreEqual("Hi", exception.Message);
            }
        }

        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("ResponseTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonOutputStreamResponse()
        {
            // Arrange
            using (var client = CreateClient())
            {
                var response = new MockHttpResponse
                {
                    ContentType = "application/vnd.amazon.eventstream",
                    Body = MockHttpClientUtils.EncodeEvents(
                        MockHttpClientUtils.CreateEvent("headersAndImplicitPayload", "application/json", "{\"payload\":\"first\"}",
                            new Dictionary<string, string> { { "header", "h1" } }),
                        MockHttpClientUtils.CreateEvent("headersAndImplicitPayload", "application/json", "{\"payload\":\"second\"}",
                            new Dictionary<string, string> { { "header", "h2" } })),
                };
                MockHttpClientUtils.InjectMockHttp(client, response);

                // Act
                using (var actualResponse = await client.OutputStreamAsync(new OutputStreamRequest()).ConfigureAwait(false))
                {
                    var events = actualResponse.Stream.OfType<HeadersAndImplicitPayloadEvent>().ToList();

                    // Assert
                    CollectionAssert.AreEqual(new[] { "first", "second" }, events.Select(e => e.Payload).ToList());
                    CollectionAssert.AreEqual(new[] { "h1", "h2" }, events.Select(e => e.Header).ToList());
                }
            }
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        [TestCategory("ProtocolTest")]
        [TestCategory("RequestTest")]
        [TestCategory("RestJson")]
        public async Task RestJsonDuplexStreamRequestAndResponse()
        {
            // Arrange
            var inputEvents = new Queue<IEventStreamEvent>(new IEventStreamEvent[]
            {
                new HeadersAndImplicitPayloadEvent { Header = "h", Payload = "hello" },
            });
            var request = new DuplexStreamRequest
            {
                StreamPublisher = () => Task.FromResult(inputEvents.Count > 0 ? inputEvents.Dequeue() : null),
            };
            using (var client = CreateClient())
            {
                var factory = MockHttpClientUtils.InjectMockHttp(client, new MockHttpResponse
                {
                    ContentType = "application/vnd.amazon.eventstream",
                    Body = MockHttpClientUtils.EncodeEvents(
                        MockHttpClientUtils.CreateEvent("headersAndImplicitPayload", "application/json", "{\"payload\":\"world\"}",
                            new Dictionary<string, string> { { "header", "h" } })),
                });

                // Act
                using (var actualResponse = await client.DuplexStreamAsync(request).ConfigureAwait(false))
                {
                    var actualRequest = factory.LastCreatedRequest;
                    await actualRequest.InputStreamCompleted.ConfigureAwait(false);
                    var outputEvents = actualResponse.Stream.ToList();

                    // Assert request
                    Assert.AreEqual("POST", actualRequest.Method);
                    Assert.AreEqual("/DuplexStream", ProtocolTestUtils.GetEncodedResourcePathFromOriginalString(actualRequest.RequestUri));
                    Assert.AreEqual("application/vnd.amazon.eventstream", actualRequest.Headers["Content-Type"]);
                    var sentEvents = MockHttpClientUtils.DecodeSignedInputFrames(actualRequest.InputFrames);
                    Assert.AreEqual(1, sentEvents.Count);
                    Assert.AreEqual("event", MockHttpClientUtils.GetStringHeader(sentEvents[0], ":message-type"));
                    Assert.AreEqual("headersAndImplicitPayload", MockHttpClientUtils.GetStringHeader(sentEvents[0], ":event-type"));
                    Assert.AreEqual("h", MockHttpClientUtils.GetStringHeader(sentEvents[0], "header"));
                    JsonProtocolUtils.AssertBody(sentEvents[0].Payload, "{\"payload\":\"hello\"}");

                    // Assert response
                    var received = outputEvents.OfType<HeadersAndImplicitPayloadEvent>().ToList();
                    CollectionAssert.AreEqual(new[] { "world" }, received.Select(e => e.Payload).ToList());
                }
            }
        }
#endif
    }
}
