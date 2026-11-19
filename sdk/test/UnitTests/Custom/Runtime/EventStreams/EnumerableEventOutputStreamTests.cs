using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EnumerableEventOutputStreamTests
    {
        // "end" is a terminal event: nothing after it is yielded, and the failure is still thrown.
        [TestMethod]
        [DataRow(false, "event", 2)]
        [DataRow(true, "event", 2)]
        [DataRow(false, "end", 1)]
        [DataRow(true, "end", 1)]
        public async Task EventsBeforeAFailingMessageAreYieldedBeforeItThrows(bool async, string firstEvent, int expected)
        {
            using var stream = OneRead(firstEvent, "event", "fails");
            var seen = new List<TestEvent>();
            await Assert.ThrowsExactlyAsync<TestException>(() => Read(stream, async, seen.Add));
            Assert.AreEqual(expected, seen.Count);
            Assert.IsTrue(stream.Disposed);
        }

        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task DisposingTheStreamEndsEnumerationWithoutTheFailure(bool async)
        {
            using var stream = OneRead("event", "event", "fails");
            var seen = new List<TestEvent>();

            await Read(stream, async, ev =>
            {
                seen.Add(ev);
                stream.Dispose();
            });

            Assert.AreEqual(1, seen.Count);
        }

        // A loop body that throws abandons the enumeration while events before the failure are still queued.
        [TestMethod]
        [DataRow(false)]
        [DataRow(true)]
        public async Task AbandonedEnumerationCannotBeStartedAgain(bool async)
        {
            using var stream = OneRead("event", "event", "fails");
            await Assert.ThrowsExactlyAsync<TimeoutException>(() => Read(stream, async, ev => throw new TimeoutException()));
            await Assert.ThrowsExactlyAsync<InvalidOperationException>(() => Read(stream, async, ev => { }));
        }

        private static async Task Read(TestEventStream stream, bool async, Action<TestEvent> onEvent)
        {
            if (async)
            {
                await foreach (var ev in stream)
                {
                    onEvent(ev);
                }
            }
            else
            {
                foreach (var ev in stream)
                {
                    onEvent(ev);
                }
            }
        }

        // A stream whose single network read carries one message per event type.
        private static TestEventStream OneRead(params string[] eventTypes)
        {
            var bytes = new MemoryStream();
            foreach (var type in eventTypes)
            {
                var messageType = new EventStreamHeader(":message-type");
                messageType.SetString("event");

                var eventType = new EventStreamHeader(":event-type");
                eventType.SetString(type);

                var headers = new List<IEventStreamHeader> { messageType, eventType };
                var message = new EventStreamMessage(headers, Array.Empty<byte>());
                var encoded = message.ToByteArray();
                bytes.Write(encoded, 0, encoded.Length);
            }

            bytes.Position = 0;
            return new TestEventStream(bytes);
        }

        private class TestEvent : IEventStreamEvent { }
        private sealed class TestTerminalEvent : TestEvent, IEventStreamTerminalEvent { }
        private sealed class TestException : EventStreamException { }

        private sealed class TestEventStream : EnumerableEventOutputStream<TestEvent, TestException>
        {
            protected override IDictionary<string, Func<IEventStreamMessage, TestEvent>> EventMapping { get; } = new Dictionary<string, Func<IEventStreamMessage, TestEvent>>();
            protected override IDictionary<string, Func<IEventStreamMessage, TestException>> ExceptionMapping { get; } = new Dictionary<string, Func<IEventStreamMessage, TestException>>();
            protected override bool IsProcessing { get; set; }
            public bool Disposed => IsDisposed;
            public override event EventHandler<EventStreamEventReceivedArgs<TestEvent>> EventReceived;

            public TestEventStream(Stream stream) : base(stream, null)
            {
                EventMapping["event"] = message => new TestEvent();
                EventMapping["end"] = message => new TestTerminalEvent();
                EventMapping["fails"] = message => throw new TestException();
                Decoder.MessageReceived += (sender, args) =>
                {
                    var ev = ConvertMessageToEvent(args.Message);
                    var received = new EventStreamEventReceivedArgs<TestEvent>(ev);
                    EventReceived?.Invoke(this, received);
                };
            }
        }
    }
}
