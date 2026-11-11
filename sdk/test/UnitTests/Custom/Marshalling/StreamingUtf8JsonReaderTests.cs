using AWSSDK_DotNet.CommonTest.Utils;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon;
namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Protocol tests already exists to test the marshalling and unmarshalling of request and responses in json, but they don't test very
    /// large payloads, which would trigger the logic for getting more bytes from the stream. 
    /// This class just tests the wrapper class StreamingUtf8JsonReader. 
    /// </summary>
    [TestClass]
    public class StreamingUtf8JsonReaderTests
    {
        [TestMethod]
        public void SkipsUtf8BOM()
        {
            // we can't use reflection to access the private fields of StreamingUtf8JsonReader since it is a ref struct so we have to test it this way.
            var a = Convert.ToByte('{');
            var b = Convert.ToByte('x');
            var c = Convert.ToByte(':');
            var d = Convert.ToByte('y');
            var e = Convert.ToByte('}');

            byte[] payload = new byte[] { 0xEF, 0xBB, 0xBF, a, b, c, d, e };
            MemoryStream stream = new MemoryStream(payload);
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(stream);
            while (reader.Read())
            {
                Assert.IsTrue(reader.Reader.TokenType == JsonTokenType.StartObject);
                return;
            }
        }

        // Mirrors a generated event stream event whose @eventPayload is a raw blob or string: the reader is
        // constructed over the payload stream before the event unmarshaller hands that same stream to the caller,
        // so constructing the reader must not advance it.
        [TestMethod]
        public void ConstructingTheReaderDoesNotAdvanceTheStream()
        {
            var payload = Encoding.UTF8.GetBytes("raw event payload, not JSON");
            var stream = new MemoryStream(payload);
            var reader = new StreamingUtf8JsonReader(stream);

            Assert.AreEqual(0, stream.Position);
            using (var sr = new StreamReader(stream))
            {
                Assert.AreEqual("raw event payload, not JSON", sr.ReadToEnd());
            }
        }

        // Generated response unmarshallers for an @httpPayload structure check this before any Read() to return
        // an empty response object for an empty body instead of failing on "no JSON tokens".
        [TestMethod]
        public void IsFinalBlockBeforeTheFirstReadTellsAnEmptyBodyFromAJsonBody()
        {
            var empty = new StreamingUtf8JsonReader(new MemoryStream(Array.Empty<byte>()));
            Assert.IsTrue(empty.Reader.IsFinalBlock);

            var json = new StreamingUtf8JsonReader(new MemoryStream(Encoding.UTF8.GetBytes("{}")));
            Assert.IsFalse(json.Reader.IsFinalBlock);
            Assert.IsTrue(json.Read());
            Assert.AreEqual(JsonTokenType.StartObject, json.Reader.TokenType);
        }

        // This method tests that if the json token starts in one buffer but continues into the next buffer
        // the reader can handle parsing it correctly.
        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesJsonTokenThatSpansMultipleBuffers()
        {
            // Arrange
            // here we're creating a json string that is greater than the default buffer size to test the GetMoreBytesFromStream logic
            var sb = new StringBuilder();
            sb.Append("{ \"key\": \"");
            var size = 4096 + 500;
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();

            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesNormalPayload()
        {
            // Arrange
            var sb = new StringBuilder();
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', 1));
            sb.Append("\" }");
            string largeJson = sb.ToString();

            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', 1), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesExactBufferSize()
        {
            var sb = new StringBuilder();
            // everything other than the 'x' is 13 bytes
            var size = 4096 - 13;
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();
            Assert.AreEqual<int>(4096, Encoding.UTF8.GetByteCount(largeJson));


            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesBufferSizePlusOne()
        {
            var sb = new StringBuilder();
            // everything other than the 'x' is 13 bytes
            var size = 4096 - 13 + 1;
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();


            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }

        [TestMethod]
        public void StreamingUtf8JsonReaderHandlesBufferSizeMinusOne()
        {
            var sb = new StringBuilder();
            // everything other than the 'x' is 13 bytes
            var size = 4096 - 13 - 1;
            sb.Append("{ \"key\": \"");
            sb.Append(new string('x', size));
            sb.Append("\" }");
            string largeJson = sb.ToString();


            byte[] payload = Encoding.UTF8.GetBytes(largeJson);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                string key = null, value = null;

                while (reader.Read())
                {
                    if (reader.Reader.TokenType == JsonTokenType.PropertyName)
                    {
                        key = reader.Reader.GetString();
                    }
                    else if (reader.Reader.TokenType == JsonTokenType.String)
                    {
                        value = reader.Reader.GetString();
                    }
                }
                Assert.AreEqual<string>("key", key);
                Assert.AreEqual<string>(new string('x', size), value);
            }
        }

        [TestMethod]
        public void CustomMaxDepthAllowsDeeperNesting()
        {
            int depth = 100;
            string json = GenerateNestedJson(depth);
            byte[] payload = Encoding.UTF8.GetBytes(json);
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream, 4096, 128);
                int maxDepthSeen = 0;
                while (reader.Read())
                {
                    if (reader.Reader.CurrentDepth > maxDepthSeen)
                        maxDepthSeen = (int)reader.Reader.CurrentDepth;
                }
                Assert.IsTrue(maxDepthSeen >= depth);
            }
        }

        private static string GenerateNestedJson(int depth)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < depth; i++)
                sb.Append("{\"a\":");
            sb.Append("1");
            for (int i = 0; i < depth; i++)
                sb.Append("}");
            return sb.ToString();
        }

        /// <summary>
        /// Once the root object's closing token has been read the pooled buffer is released; further reads
        /// report end of document instead of touching the buffer.
        /// </summary>
        [TestMethod]
        public void ReadReturnsFalseAfterRootObjectCloses()
        {
            // The bytes after the root value are not valid JSON: if the reader kept filling its buffer after the
            // closing token (instead of releasing it), the next Read would throw a JsonException.
            byte[] payload = Encoding.UTF8.GetBytes("{ \"key\": { \"nested\": [1, 2, 3] } }garbage-after-root");
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream, 16);
                var tokens = new List<JsonTokenType>();
                while (reader.Read())
                {
                    tokens.Add(reader.TokenType);
                }

                Assert.AreEqual(JsonTokenType.EndObject, tokens[tokens.Count - 1]);
                Assert.AreEqual(2, tokens.Count(t => t == JsonTokenType.EndObject));
                Assert.IsFalse(reader.Read());
                Assert.IsFalse(reader.Read());
            }
        }

        /// <summary>
        /// A root array is released on its closing token too, including when the document spans several buffers.
        /// </summary>
        [TestMethod]
        public void ReadReturnsFalseAfterRootArrayClosesAcrossBuffers()
        {
            var sb = new StringBuilder("[");
            for (int i = 0; i < 100; i++)
            {
                if (i > 0) sb.Append(',');
                sb.Append("{\"k\":\"").Append(new string('v', 40)).Append("\"}");
            }
            sb.Append("]not-json");
            byte[] payload = Encoding.UTF8.GetBytes(sb.ToString());
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream, 64);
                int objects = 0;
                JsonTokenType last = JsonTokenType.None;
                while (reader.Read())
                {
                    last = reader.TokenType;
                    if (last == JsonTokenType.StartObject) objects++;
                }

                Assert.AreEqual(100, objects);
                Assert.AreEqual(JsonTokenType.EndArray, last);
                Assert.IsFalse(reader.Read());
            }
        }

        /// <summary>
        /// Generated unmarshallers stop at the closing token; the context must still observe it as the current token.
        /// </summary>
        [TestMethod]
        public void ContextSeesRootEndObjectAfterBufferRelease()
        {
            byte[] payload = Encoding.UTF8.GetBytes("{\"a\":1}");
            using (var stream = new MemoryStream(payload))
            using (var context = new Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext(stream, false, null))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                var sawRootEnd = false;
                while (context.Read(ref reader))
                {
                    if (context.CurrentTokenType == JsonTokenType.EndObject && context.CurrentDepth == 0)
                    {
                        sawRootEnd = true;
                    }
                }

                Assert.IsTrue(sawRootEnd);
                Assert.IsNull(context.CurrentTokenType);
            }
        }

        /// <summary>
        /// After the buffer has been released the value accessors must not read from the array that went back to the
        /// pool: they report nothing or throw, and the token type is still that of the closing token.
        /// </summary>
        [TestMethod]
        public void ValueAccessorsDoNotReadReleasedBuffer()
        {
            byte[] payload = Encoding.UTF8.GetBytes("{\"key\":\"value\"}");
            using (var stream = new MemoryStream(payload))
            {
                var reader = new StreamingUtf8JsonReader(stream);
                while (reader.Read())
                {
                    if (reader.TokenType == JsonTokenType.String)
                    {
                        Assert.AreEqual("value", reader.GetString());
                    }
                }

                Assert.AreEqual(JsonTokenType.EndObject, reader.TokenType);
                Assert.AreEqual(0, reader.ValueSpan.Length);

                // The reader is no longer positioned on a string, so these throw instead of returning stale data.
                Assert.IsTrue(Throws(ref reader, (ref StreamingUtf8JsonReader r) => r.GetString()));
                Assert.IsTrue(Throws(ref reader, (ref StreamingUtf8JsonReader r) => r.ValueTextEquals("key")));
            }
        }

        private delegate void ReaderAction(ref StreamingUtf8JsonReader reader);

        private static bool Throws(ref StreamingUtf8JsonReader reader, ReaderAction action)
        {
            try
            {
                action(ref reader);
                return false;
            }
            catch (InvalidOperationException)
            {
                return true;
            }
        }

        /// <summary>
        /// Every buffer rented while reading a document, including ones rented to grow the buffer, goes back to the pool
        /// once the root value's closing token has been read.
        /// </summary>
        [TestMethod]
        public void BuffersAreReturnedToThePoolAfterRootValueCloses()
        {
            // The first token (a long string) does not fit in the 16 byte buffer, so the reader also has to grow it.
            byte[] payload = Encoding.UTF8.GetBytes("{\"key\":\"" + new string('v', 100) + "\",\"n\":[1,2,3]}trailing");

            using (var listener = new ArrayPoolListener())
            {
                using (var stream = new MemoryStream(payload))
                {
                    var reader = new StreamingUtf8JsonReader(stream, 16);
                    while (reader.Read()) { }
                }

                Assert.IsTrue(listener.RentedCount > 1, "Expected the initial buffer and at least one resized buffer to be rented.");
                Assert.AreEqual(0, listener.OutstandingCount, "Buffers rented by the reader were not returned to the pool.");
            }
        }

        /// <summary>
        /// Records the shared ArrayPool buffers rented, and not yet returned, by the thread that created it.
        /// </summary>
        private sealed class ArrayPoolListener : System.Diagnostics.Tracing.EventListener
        {
            // Event ids of System.Buffers.ArrayPoolEventSource.
            private const int BufferRented = 1;
            private const int BufferReturned = 3;

            private readonly int _threadId = System.Threading.Thread.CurrentThread.ManagedThreadId;
            private readonly HashSet<long> _outstanding = new HashSet<long>();

            public int RentedCount { get; private set; }

            public int OutstandingCount
            {
                get { lock (_outstanding) return _outstanding.Count; }
            }

            protected override void OnEventSourceCreated(System.Diagnostics.Tracing.EventSource eventSource)
            {
                if (eventSource.Name == "System.Buffers.ArrayPoolEventSource")
                {
                    EnableEvents(eventSource, System.Diagnostics.Tracing.EventLevel.Verbose, System.Diagnostics.Tracing.EventKeywords.All);
                }
            }

            protected override void OnEventWritten(System.Diagnostics.Tracing.EventWrittenEventArgs eventData)
            {
                // Events are written synchronously on the thread that rents or returns the buffer, so other tests
                // running in parallel that use the shared pool can be told apart by thread.
                if (eventData.EventSource.Name != "System.Buffers.ArrayPoolEventSource" ||
                    System.Threading.Thread.CurrentThread.ManagedThreadId != _threadId)
                {
                    return;
                }

                var bufferId = Convert.ToInt64(eventData.Payload[0]);
                lock (_outstanding)
                {
                    if (eventData.EventId == BufferRented)
                    {
                        RentedCount++;
                        _outstanding.Add(bufferId);
                    }
                    else if (eventData.EventId == BufferReturned)
                    {
                        _outstanding.Remove(bufferId);
                    }
                }
            }
        }

    }
}
