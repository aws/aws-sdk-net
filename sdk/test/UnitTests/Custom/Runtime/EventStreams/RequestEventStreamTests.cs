#if NET8_0_OR_GREATER
using Amazon.Runtime;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Pipeline.HttpHandler;
using Moq;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class RequestEventStreamTests
    {
        [TestMethod]
        public void DisposeEventContext()
        {
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

        [TestMethod]
        public async Task VerifyCreateEventStreamMessage()
        {
            var eventType = "EventFoo";
            var contentType = "application/foo";
            var eventPayload = new byte[] { 1, 2, 3 };
            var publisher = new FakeEventStreamPublisher(eventType, contentType, null, eventPayload);

            var message = await publisher.NextEventAsync();
            Assert.AreEqual(3, message.Headers.Count);

            Assert.IsTrue(message.Headers.TryGetValue(":event-type", out var eventTypeHeader), "Missing event type header");
            Assert.AreEqual(EventStreamHeaderType.String, eventTypeHeader.HeaderType);
            Assert.AreEqual(eventType, eventTypeHeader.AsString());

            Assert.IsTrue(message.Headers.TryGetValue(":content-type", out var contentTypeHeader), "Missing content type header");
            Assert.AreEqual(EventStreamHeaderType.String, contentTypeHeader.HeaderType);
            Assert.AreEqual(contentType, contentTypeHeader.AsString());

            Assert.IsTrue(message.Headers.TryGetValue(":message-type", out var messageTypeHeader), "Missing message type header");
            Assert.AreEqual(EventStreamHeaderType.String, messageTypeHeader.HeaderType);
            Assert.AreEqual("event", messageTypeHeader.AsString());

            CollectionAssert.AreEqual(eventPayload, message.Payload);
        }

        [TestMethod]
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
            Assert.AreEqual(4, message.Headers.Count);

            Assert.IsTrue(message.Headers.TryGetValue(customHeader.Name, out var foundCustomTypeHeader), "Missing custom type header");
            Assert.IsTrue(object.ReferenceEquals(customHeader, foundCustomTypeHeader));
        }

        [TestMethod]
        public async Task SignInputEvents()
        {
            var signature = "initial-signature";
            var aws4Signer = new AWS4Signer();

            var eventSigner = aws4Signer.CreateEventSigner("secret-dummy", "us-east-1", "the-service", signature);

            var eventType = "Foo1";
            var contentType = "application/json";
            var eventPayload = new byte[] { 1, 2 };
            var eventPublisher = new FakeEventStreamPublisher();
            eventPublisher.AddEvent(eventType, contentType, null, eventPayload);
            eventPublisher.AddEvent(eventType, contentType, null, eventPayload);

            var streamPublisher = new EventSignerHttpRequestStreamPublisher(eventPublisher, eventSigner);

            var signedBytes1 = await streamPublisher.NextBytesAsync();
            var signedMessage1 = EventStreamMessage.FromBuffer(signedBytes1, 0, signedBytes1.Length);
            Assert.AreEqual(2, signedMessage1.Headers.Count);
            Assert.IsTrue(((IDictionary<string, IEventStreamHeader>)signedMessage1.Headers).ContainsKey(":date"));
            Assert.IsTrue(((IDictionary<string, IEventStreamHeader>)signedMessage1.Headers).ContainsKey(":chunk-signature"));

            var signedBytes2 = await streamPublisher.NextBytesAsync();
            var signedMessage2 = EventStreamMessage.FromBuffer(signedBytes2, 0, signedBytes2.Length);
            Assert.IsTrue(((IDictionary<string, IEventStreamHeader>)signedMessage2.Headers).ContainsKey(":date"));
            Assert.IsTrue(((IDictionary<string, IEventStreamHeader>)signedMessage2.Headers).ContainsKey(":chunk-signature"));

            CollectionAssert.AreNotEqual(signedMessage1.Headers[":chunk-signature"].AsByteBuf(), signedMessage2.Headers[":chunk-signature"].AsByteBuf());

            var innerEventMessage = EventStreamMessage.FromBuffer(signedMessage1.Payload, 0, signedMessage1.Payload.Length);
            Assert.AreEqual(3, innerEventMessage.Headers.Count);

            Assert.IsTrue(innerEventMessage.Headers.TryGetValue(":event-type", out var innerEventTypeHeader), "Missing event type header");
            Assert.AreEqual(EventStreamHeaderType.String, innerEventTypeHeader.HeaderType);
            Assert.AreEqual(eventType, innerEventTypeHeader.AsString());

            Assert.IsTrue(innerEventMessage.Headers.TryGetValue(":content-type", out var innerContentTypeHeader), "Missing content type header");
            Assert.AreEqual(EventStreamHeaderType.String, innerContentTypeHeader.HeaderType);
            Assert.AreEqual(contentType, innerContentTypeHeader.AsString());

            Assert.IsTrue(innerEventMessage.Headers.TryGetValue(":message-type", out var innerMessageTypeHeader), "Missing message type header");
            Assert.AreEqual(EventStreamHeaderType.String, innerMessageTypeHeader.HeaderType);
            Assert.AreEqual("event", innerMessageTypeHeader.AsString());

            CollectionAssert.AreEqual(eventPayload, innerEventMessage.Payload);
        }

        [TestMethod]
        public async Task HttpContentStreamAllData()
        {
            var publisher = new TestHttpContentRequestStreamHandle.TestPublisher();
            publisher.AddData(new byte[] { 1 });
            publisher.AddData(new byte[] { 2, 3 });

            Assert.AreEqual(2, publisher.Count);

            var content = new TestHttpContentRequestStreamHandle(publisher);

            var memoryStream = new MemoryStream();
            Task task = content.InvokeSerializeToStreamAsync(memoryStream);

            await Task.Delay(2000);
            Assert.IsFalse(task.IsCompletedSuccessfully);

            content.Dispose();
            await Task.Delay(2000);
            Assert.IsTrue(task.IsCompletedSuccessfully);

            Assert.AreEqual(3L, memoryStream.Length);
        }

        [TestMethod]
        public void HttpContentEnsureEarlierDisposeDoesnotCauseNPE()
        {
            var publisher = new TestHttpContentRequestStreamHandle.TestPublisher(shouldDiposeAfterWrite: true);
            publisher.AddData(new byte[] { 1 });
            publisher.AddData(new byte[] { 2, 3 });

            var content = new TestHttpContentRequestStreamHandle(publisher);

            var memoryStream = new MemoryStream();
            Task task = content.InvokeSerializeToStreamAsync(memoryStream);

            Assert.IsTrue(task.IsCompletedSuccessfully);
        }

        public class TestHttpContentRequestStreamHandle : HttpContentRequestStreamHandle
        {
            public TestHttpContentRequestStreamHandle(TestPublisher publisher)
                : base(new HttpRequestMessage(), publisher)
            {
                publisher.Parent = this;
            }

            public async Task InvokeSerializeToStreamAsync(Stream stream)
            {
                await SerializeToStreamAsync(stream, null);
            }

            public class TestPublisher : IHttpRequestStreamPublisher
            {
                public TestHttpContentRequestStreamHandle Parent { get; set; }

                bool _shouldDiposeAfterWrite = false;
                Queue<byte[]> _data = new Queue<byte[]>();

                public TestPublisher(bool shouldDiposeAfterWrite = false)
                {
                    _shouldDiposeAfterWrite = shouldDiposeAfterWrite;
                }

                public void AddData(byte[] data)
                {
                    _data.Enqueue(data);
                }

                public Task<byte[]> NextBytesAsync()
                {
                    if (_data.TryDequeue(out var item))
                    {
                        if (_shouldDiposeAfterWrite)
                        {
                            Parent.Dispose();
                            _shouldDiposeAfterWrite = false;
                        }

                        return Task.FromResult(item);
                    }

                    return Task.FromResult((byte[])null);
                }

                public int Count => _data.Count;
            }
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
                _events.Enqueue(new Item
                {
                    EventType = eventType,
                    ContentType = contentType,
                    MarshalledEventHeaders = marshalledEventHeaders,
                    EventPayload = eventPayload
                });
            }

            public override Task<IEventStreamMessage> NextEventAsync()
            {
                if (_events.TryDequeue(out var item))
                {
                    return Task.FromResult(CreateEventStreamMessage(item.EventType, item.ContentType, item.MarshalledEventHeaders, item.EventPayload));
                }

                return Task.FromResult((IEventStreamMessage)null);
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
#endif
