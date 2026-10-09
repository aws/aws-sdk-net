using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.Runtime.EventStreams;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.IO;
using Xunit;

namespace Amazon.CborProtocol.Tests;

public class CborUnmarshallerContextTests
{
    // Mirrors a generated event stream response: Core builds the context first, then the
    // unmarshaller hands context.Stream to the event stream class, which must still see the first frame.
    [Fact]
    public void Stream_HandedOnAfterConstruction_StillStartsAtTheFirstFrame()
    {
        var eventType = new EventStreamHeader(":event-type");
        eventType.SetString("sessionStart");

        var payload = new CborWriter();
        payload.WriteStartMap(0);
        payload.WriteEndMap();

        var frame = new EventStreamMessage(new List<IEventStreamHeader> { eventType }, payload.Encode()).ToByteArray();
        var context = new CborUnmarshallerContext(new MemoryStream(frame), false, null);

        var handedOn = new MemoryStream();
        context.Stream.CopyTo(handedOn);

        var message = EventStreamMessage.FromBuffer(handedOn.ToArray(), 0, (int)handedOn.Length);
        Assert.Equal("sessionStart", message.Headers[":event-type"].AsString());
    }
}
