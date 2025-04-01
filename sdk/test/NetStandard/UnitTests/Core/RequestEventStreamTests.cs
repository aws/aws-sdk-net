using Amazon.Runtime;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.NetStandard.Core
{
    public class RequestEventStreamTests
    {
        [Fact]
        public void DisposeEventContext()
        {
            // Confirm no NPE if handle is not set.
            var contextWithNoHandle = new EventInputStreamContext();
            contextWithNoHandle.Dispose();

            Mock<IHttpRequestStreamHandle> mockHandle = new Mock<IHttpRequestStreamHandle>();

            var contextWithHandle = new EventInputStreamContext()
            {
                RequestStreamHandle = mockHandle.Object,
            };

            contextWithHandle.Dispose();
            mockHandle.Verify(s => s.Dispose(), Times.Once);
        }

        [Fact]
        public async Task VerifyCreateEventStreamMessage()
        {
            var eventType = "EventFoo";
            var contentType = "application/foo";
            var eventPayload = new byte[] { 1, 2, 3 };
            var publisher = new FakeEventStreamPublisher(eventType, contentType, null, eventPayload);

            var message = await publisher.NextEventAsync();
            Assert.Equal(3, message.Headers.Count);

            if (!message.Headers.TryGetValue(":event-type", out var eventTypeHeader))
            {
                Assert.Fail("Missing event type header");
            }

            Assert.Equal(EventStreamHeaderType.String, eventTypeHeader.HeaderType);
            Assert.Equal(eventType, eventTypeHeader.AsString());

            if (!message.Headers.TryGetValue(":content-type", out var contentTypeHeader))
            {
                Assert.Fail("Missing content type header");
            }

            Assert.Equal(EventStreamHeaderType.String, contentTypeHeader.HeaderType);
            Assert.Equal(contentType, contentTypeHeader.AsString());

            if (!message.Headers.TryGetValue(":message-type", out var messageTypeHeader))
            {
                Assert.Fail("Missing message type header");
            }

            Assert.Equal(EventStreamHeaderType.String, messageTypeHeader.HeaderType);
            Assert.Equal("event", messageTypeHeader.AsString());

            Assert.Equal(eventPayload, message.Payload);
        }

        [Fact]
        public async Task VerifyCreateEventStreamMessageWithHeaders()
        {
            var eventType = "EventFoo";
            var contentType = "application/bar";
            var eventPayload = new byte[] { 1, 2, 3 };
            var eventHeaders = new List<EventStreamHeader>();

            var customHeader = new EventStreamHeader("customHeader1")
            {
                HeaderType = EventStreamHeaderType.Int64
            };
            customHeader.SetInt64(14);

            eventHeaders.Add(customHeader);

            var publisher = new FakeEventStreamPublisher(eventType, contentType, eventHeaders, eventPayload);

            var message = await publisher.NextEventAsync();
            Assert.Equal(4, message.Headers.Count);

            if (!message.Headers.TryGetValue(customHeader.Name, out var foundCustomTypeHeader))
            {
                Assert.Fail("Missing custom type header");
            }


            Assert.True(object.ReferenceEquals(customHeader, foundCustomTypeHeader));
        }

        [Fact]
        public async Task SignInputEvents()
        {
            var signature = "initial-signature";
            var identity = new BasicAWSCredentials("access-dummy", "secret-dummy");
            var aws4Signer = new AWS4Signer();

            var eventSigner = aws4Signer.CreateEventSigner(identity, "us-east-1", "the-service", signature);

            var eventType = "Foo1";
            var contentType = "application/json";
            var eventPayload = new byte[] { 1, 2 };
            var eventPublisher = new FakeEventStreamPublisher();
            eventPublisher.AddEvent(eventType, contentType, null, eventPayload);
            eventPublisher.AddEvent(eventType, contentType, null, eventPayload);

            var streamPublisher = new EventSignerHttpRequestStreamPublisher(eventPublisher, eventSigner);

            var signedBytes1 = await streamPublisher.NextBytesAsync();
            var signedMessage1 = EventStreamMessage.FromBuffer(signedBytes1, 0, signedBytes1.Length);
            Assert.Equal(2, signedMessage1.Headers.Count);
            Assert.Contains(":date", (IDictionary<string, IEventStreamHeader>)signedMessage1.Headers);
            Assert.Contains(":chunk-signature", (IDictionary<string, IEventStreamHeader>)signedMessage1.Headers);


            var signedBytes2 = await streamPublisher.NextBytesAsync();
            var signedMessage2 = EventStreamMessage.FromBuffer(signedBytes2, 0, signedBytes2.Length);
            Assert.Contains(":date", (IDictionary<string, IEventStreamHeader>)signedMessage2.Headers);
            Assert.Contains(":chunk-signature", (IDictionary<string, IEventStreamHeader>)signedMessage2.Headers);

            // That will not be different even though the have the same data because the second message uses the signature of the first.
            Assert.NotEqual(signedMessage1.Headers[":chunk-signature"].AsByteBuf(), signedMessage2.Headers[":chunk-signature"].AsByteBuf());

            // Check inner message
            var innerEventMessage = EventStreamMessage.FromBuffer(signedMessage1.Payload, 0, signedMessage1.Payload.Length);
            Assert.Equal(3, innerEventMessage.Headers.Count);

            if (!innerEventMessage.Headers.TryGetValue(":event-type", out var eventTypeHeader))
            {
                Assert.Fail("Missing event type header");
            }

            Assert.Equal(EventStreamHeaderType.String, eventTypeHeader.HeaderType);
            Assert.Equal(eventType, eventTypeHeader.AsString());

            if (!innerEventMessage.Headers.TryGetValue(":content-type", out var contentTypeHeader))
            {
                Assert.Fail("Missing content type header");
            }

            Assert.Equal(EventStreamHeaderType.String, contentTypeHeader.HeaderType);
            Assert.Equal(contentType, contentTypeHeader.AsString());

            if (!innerEventMessage.Headers.TryGetValue(":message-type", out var messageTypeHeader))
            {
                Assert.Fail("Missing message type header");
            }

            Assert.Equal(EventStreamHeaderType.String, messageTypeHeader.HeaderType);
            Assert.Equal("event", messageTypeHeader.AsString());

            Assert.Equal(eventPayload, innerEventMessage.Payload);
        }

        public class FakeEventStreamPublisher : EventStreamPublisher
        {
            Queue<Item> _events = new Queue<Item>();

            public FakeEventStreamPublisher()
            {

            }

            public FakeEventStreamPublisher(string eventType, string contentType, IList<EventStreamHeader> marshalledEventHeaders, byte[] eventPayload)
            {
                AddEvent(eventType, contentType, marshalledEventHeaders, eventPayload);
            }

            public void AddEvent(string eventType, string contentType, IList<EventStreamHeader> marshalledEventHeaders, byte[] eventPayload)
            {
                var item = new Item
                {
                    EventType = eventType,
                    ContentType = contentType,
                    MarshalledEventHeaders = marshalledEventHeaders,
                    EventPayload = eventPayload
                };
                _events.Enqueue(item);
            }

            public override Task<IEventStreamMessage> NextEventAsync()
            {
                var item = _events.Dequeue();
                return Task.FromResult(CreateEventStreamMessage(item.EventType, item.ContentType, item.MarshalledEventHeaders, item.EventPayload));
            }

            class Item
            {
                public string EventType { get; set; }
                public string ContentType { get; set; }
                public IList<EventStreamHeader> MarshalledEventHeaders { get; set; }
                public byte[] EventPayload { get; set; }
            }
        }
    }
}
