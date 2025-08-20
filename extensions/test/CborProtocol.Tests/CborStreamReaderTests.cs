using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using System;
using System.Formats.Cbor;
using System.IO;
using System.Linq;
using Xunit;

namespace Amazon.CborProtocol.Tests;


public class BufferSizeConfigFixture : IDisposable
{
    private readonly int _originalValue;

    public BufferSizeConfigFixture()
    {
        // Save original value
        _originalValue = AWSConfigs.CborReaderInitialBufferSize;

        // Set a small buffer size to easily test larger streams.
        AWSConfigs.CborReaderInitialBufferSize = 100;
    }

    public void Dispose()
    {
        // Restore original value
        AWSConfigs.CborReaderInitialBufferSize = _originalValue;
    }
}

public class CborStreamReaderTests : IClassFixture<BufferSizeConfigFixture>
{

    [Fact]
    public void Unmarshall_SimpleObject_FitsInInitialBuffer()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(2);
        writer.WriteTextString("Key1");
        writer.WriteTextString("Value1");
        writer.WriteTextString("Key2");
        writer.WriteInt32(123);
        writer.WriteEndMap();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Equal("Key1", reader.ReadTextString());
        Assert.Equal("Value1", reader.ReadTextString());
        Assert.Equal("Key2", reader.ReadTextString());
        reader.SkipValue(); // Skip integer
        reader.ReadEndMap();
        Assert.Equal(CborReaderState.Finished, reader.PeekState());

    }

    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(8)]
    public void Unmarshall_ItemLargerThanBuffer_ResizesMultipleTimes(int multiplier)
    {
        // Create a string that will force multiple buffer resizes.
        int stringSize = (AWSConfigs.CborReaderInitialBufferSize * multiplier) + 50;
        var veryLargeString = new string('B', stringSize);

        var writer = new CborWriter();
        writer.WriteTextString(veryLargeString);
        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        string result = reader.ReadTextString();
        Assert.Equal(veryLargeString, result);

    }

    [Fact]
    public void Unmarshall_ObjectCrossesBufferBoundary_RefillsCorrectly()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(null);
        writer.WriteTextString("key1");
        writer.WriteTextString(new string('A', 90));
        writer.WriteTextString("key2");
        writer.WriteStartMap(null);
        writer.WriteTextString("key3");
        writer.WriteTextString("value2");
        writer.WriteEndMap();
        writer.WriteEndMap();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Equal("key1", reader.ReadTextString());
        string value1 = reader.ReadTextString(); // This read will consume most of the first chunk.
        Assert.Equal(90, value1.Length);
        Assert.Equal("key2", reader.ReadTextString());
        reader.ReadStartMap();

        Assert.Equal("key3", reader.ReadTextString());
        Assert.Equal("value2", reader.ReadTextString());
        reader.ReadEndMap();
        reader.ReadEndMap();

    }

    [Fact]
    public void SkipValue_OnLargeNestedMap_Succeeds()
    {
        var writer = new CborWriter();
        writer.WriteStartArray(2);

        // Start the large nested map
        writer.WriteStartMap(1);
        writer.WriteTextString("large_key");
        writer.WriteTextString(new string('X', 300)); // This will force refills
        writer.WriteEndMap();

        // The value we want to read after the skip
        writer.WriteInt32(99);
        writer.WriteEndArray();

        var stream = new MemoryStream(writer.Encode());

        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray();

        // Skip the entire large map object
        reader.SkipValue();

        // Assert that we can correctly read the next item
        Assert.Equal(99, reader.ReadInt32());

        reader.ReadEndArray();
        Assert.Equal(CborReaderState.Finished, reader.PeekState());

    }

    [Fact]
    public void ReadEndArray_WhenInMap_ThrowsCborContentException()
    {
        // Arrange: A simple map
        var writer = new CborWriter();
        writer.WriteStartMap(0);
        writer.WriteEndMap();
        var stream = new MemoryStream(writer.Encode());

        // Act & Assert
        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Throws<CborContentException>(() => reader.ReadEndArray());

    }

    [Fact]
    public void Unmarshall_IncompleteStream_ThrowsCborContentException()
    {
        // CBOR header for a string of length 20, but we only provide 10 bytes of data.
        byte[] bytes = Convert.FromBase64String("eBQKCgoKCgoKCg==");
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        // The reader will attempt to read the string, realize it's incomplete,
        // try to refill, find no more data, and then throw an exception.
        Assert.Throws<CborContentException>(() => reader.ReadTextString());

    }


    [Fact]
    public void Unmarshall_EmptyStream_ThrowsOnRead()
    {
        byte[] bytes = new byte[0];
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        // Attempting to read from a finished reader should throw.
        Assert.Throws<CborContentException>(() => reader.ReadStartMap());

    }

    [Fact]
    public void Unmarshall_ComplexObject_SpansMultipleBuffers()
    {
        // Create a single map object with three large items.
        var writer = new CborWriter();
        writer.WriteStartMap(3);

        writer.WriteTextString("item1");
        writer.WriteTextString(new string('A', 80)); // Item 1

        writer.WriteTextString("item2");
        writer.WriteTextString(new string('B', 80)); // Item 2 (will cross boundary)

        writer.WriteTextString("item3");
        writer.WriteTextString(new string('C', 80)); // Item 3 (in second and third chunk)

        writer.WriteEndMap();
        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();

        Assert.Equal("item1", reader.ReadTextString());
        Assert.Equal(80, reader.ReadTextString().Length);

        Assert.Equal("item2", reader.ReadTextString());
        Assert.Equal(80, reader.ReadTextString().Length);

        Assert.Equal("item3", reader.ReadTextString());
        Assert.Equal(80, reader.ReadTextString().Length);

        reader.ReadEndMap();
        Assert.Equal(CborReaderState.Finished, reader.PeekState());

    }

    [Fact]
    public void Unmarshall_DefiniteLength_NestedMapAndArray()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(1);
        writer.WriteTextString("nestedArray");
        writer.WriteStartArray(2);
        writer.WriteInt32(1);
        writer.WriteInt32(2);
        writer.WriteEndArray();
        writer.WriteEndMap();

        var stream = new MemoryStream(writer.Encode());

        using var reader = new CborStreamReader(stream);
        reader.ReadStartMap();
        Assert.Equal("nestedArray", reader.ReadTextString());
        reader.ReadStartArray();
        Assert.Equal(1, reader.ReadInt32());
        Assert.Equal(2, reader.ReadInt32());
        reader.ReadEndArray();
        reader.ReadEndMap();
    }

    [Fact]
    public void Unmarshall_IndefiniteLengthArray_CrossesBuffer_EndsWithBreak()
    {
        var writer = new CborWriter();
        writer.WriteStartArray(null);
        writer.WriteTextString(new string('X', 90)); // Fills buffer
        writer.WriteTextString("done");
        writer.WriteEndArray();

        var stream = new MemoryStream(writer.Encode());

        using var reader = new CborStreamReader(stream);
        reader.ReadStartArray();
        Assert.Equal(90, reader.ReadTextString().Length);
        Assert.Equal("done", reader.ReadTextString());
        reader.ReadEndArray();
    }

    [Fact]
    public void Unmarshall_NestedIndefinite_MapArrayStructure()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(null);
        writer.WriteTextString("array");
        writer.WriteStartArray(null);
        writer.WriteTextString("one");
        writer.WriteTextString("two");
        writer.WriteEndArray();
        writer.WriteEndMap();

        var stream = new MemoryStream(writer.Encode());

        using var reader = new CborStreamReader(stream);
        reader.ReadStartMap();
        Assert.Equal("array", reader.ReadTextString());
        reader.ReadStartArray();
        Assert.Equal("one", reader.ReadTextString());
        Assert.Equal("two", reader.ReadTextString());
        reader.ReadEndArray();
        reader.ReadEndMap();
    }

    [Fact]
    public void Unmarshall_EmptyIndefiniteArray()
    {
        var writer = new CborWriter();
        writer.WriteStartArray(null);
        writer.WriteEndArray();

        var stream = new MemoryStream(writer.Encode());

        using var reader = new CborStreamReader(stream);
        reader.ReadStartArray();
        reader.ReadEndArray();
    }

    [Fact]
    public void Unmarshall_IncompleteMap_ThrowsCborContentException()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(1);
        writer.WriteTextString("key");
        writer.WriteTextString("value");
        writer.WriteEndMap();

        var bytes = writer.Encode().Take(5).ToArray(); // Truncate it
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);
        reader.ReadStartMap();
        Assert.Equal("key", reader.ReadTextString());
        Assert.Throws<CborContentException>(() => reader.ReadTextString());
    }

    [Fact]
    public void Unmarshall_SkipValue_CrossesBufferBoundary()
    {
        var writer = new CborWriter();
        writer.WriteStartArray(2);
        writer.WriteTextString(new string('X', 200));
        writer.WriteInt32(42);
        writer.WriteEndArray();

        var stream = new MemoryStream(writer.Encode());

        using var reader = new CborStreamReader(stream);
        reader.ReadStartArray();
        reader.SkipValue(); // This string skip will require buffer refill
        Assert.Equal(42, reader.ReadInt32());
        reader.ReadEndArray();
    }

    [Fact]
    public void Unmarshall_ByteString_CrossingBuffer()
    {
        var writer = new CborWriter();
        byte[] largeByteArray = new byte[150]; // Larger than buffer size
        new Random().NextBytes(largeByteArray);

        writer.WriteByteString(largeByteArray);

        using var reader = new CborStreamReader(new MemoryStream(writer.Encode()));
        byte[] result = reader.ReadByteString();

        Assert.Equal(largeByteArray, result);
    }

    [Fact]
    public void Unmarshall_CborTags()
    {
        var writer = new CborWriter();
        writer.WriteTag(CborTag.DateTimeString);
        writer.WriteTextString("2025-07-29T00:00:00Z");

        using var reader = new CborStreamReader(new MemoryStream(writer.Encode()));
        CborTag tag = reader.ReadTag();
        string dateStr = reader.ReadTextString();

        Assert.Equal(CborTag.DateTimeString, tag);
        Assert.Equal("2025-07-29T00:00:00Z", dateStr);
    }

    [Fact]
    public void Unmarshall_DeeplyNestedStructure()
    {
        var writer = new CborWriter();
        // Create a deeply nested structure
        for (int i = 0; i < 10; i++)
        {
            writer.WriteStartMap(1);
            writer.WriteTextString($"level{i}");
        }
        writer.WriteTextString("value");
        for (int i = 0; i < 10; i++)
        {
            writer.WriteEndMap();
        }

        using var reader = new CborStreamReader(new MemoryStream(writer.Encode()));
        for (int i = 0; i < 10; i++)
        {
            reader.ReadStartMap();
            Assert.Equal($"level{i}", reader.ReadTextString());
        }
        Assert.Equal("value", reader.ReadTextString());
        for (int i = 0; i < 10; i++)
        {
            reader.ReadEndMap();
        }
    }

    [Fact]
    public void PeekState_DoesNotAssumeEnd_WhenValueIsInNextChunk()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(null);
        writer.WriteTextString("key");
        writer.WriteTextString(new string('X', 95)); // Forces a refill before the value is fully read
        writer.WriteEndMap();

        byte[] bytes = writer.Encode();
        using var stream = new MemoryStream(bytes);
        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Equal("key", reader.ReadTextString());

        // This should trigger a refill, not treat it as EndMap
        var value = reader.ReadTextString();
        Assert.Equal(95, value.Length);

        reader.ReadEndMap();
    }

    [Fact]
    public void Handles_BreakMarker_AtStartOfNextChunk()
    {
        var writer = new CborWriter();
        writer.WriteStartArray(null);
        writer.WriteTextString(new string('A', 95)); // Fills buffer almost completely
        writer.WriteEndArray(); // Writes 0xFF as break byte

        var bytes = writer.Encode();
        using var stream = new MemoryStream(bytes);
        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray();
        string value = reader.ReadTextString();

        // This will cause a refill where the 0xFF is the first byte of the new chunk
        reader.ReadEndArray();

        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Handles_MultipleBreakMarkers_AtEndOfStream()
    {
        var writer = new CborWriter();
        writer.WriteStartArray(null);
        writer.WriteStartArray(null);
        writer.WriteTextString("val");
        writer.WriteEndArray(); // Ends inner
        writer.WriteEndArray(); // Ends outer

        byte[] bytes = writer.Encode();
        using var stream = new MemoryStream(bytes);
        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray(); // outer
        reader.ReadStartArray(); // inner
        Assert.Equal("val", reader.ReadTextString());

        // Should skip 0xFF, refill, then skip another 0xFF
        reader.ReadEndArray();
        reader.ReadEndArray();

        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void DoesNotInferEndMap_WhenContentFollows()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(2);
        writer.WriteTextString("k1");
        writer.WriteTextString(new string('A', 80));
        writer.WriteTextString("k2");
        writer.WriteTextString(new string('B', 80));
        writer.WriteEndMap();

        byte[] bytes = writer.Encode();
        using var stream = new MemoryStream(bytes);
        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Equal("k1", reader.ReadTextString());
        Assert.Equal(80, reader.ReadTextString().Length);

        Assert.Equal("k2", reader.ReadTextString());

        // This should not throw or prematurely infer EndMap
        Assert.Equal(80, reader.ReadTextString().Length);

        reader.ReadEndMap();
    }

    [Fact]
    public void Handles_DefinedLengthMap_ThatEndsExactlyAtEof()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(1);
        writer.WriteTextString("key");
        writer.WriteTextString("value");
        writer.WriteEndMap(); // Definite-length, no break byte

        var bytes = writer.Encode();
        using var stream = new MemoryStream(bytes);
        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Equal("key", reader.ReadTextString());
        Assert.Equal("value", reader.ReadTextString());
        reader.ReadEndMap();

        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Handles_NestedMapEndAtBufferBoundary_FollowedByOuterKey()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(null);      // Outer map
        writer.WriteTextString("outerKey1");
        writer.WriteStartMap(null);      // Inner map
        writer.WriteTextString("innerKey");
        writer.WriteTextString("innerVal");
        writer.WriteEndMap();            // Ends inner map
        writer.WriteTextString("outerKey2");
        writer.WriteTextString("outerVal");
        writer.WriteEndMap();            // Ends outer map

        byte[] bytes = writer.Encode();

        using var stream = new MemoryStream(bytes);
        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Equal("outerKey1", reader.ReadTextString());
        reader.ReadStartMap();
        Assert.Equal("innerKey", reader.ReadTextString());
        Assert.Equal("innerVal", reader.ReadTextString());

        // This ReadEndMap will bring us to the end of current buffer
        reader.ReadEndMap(); // This will trigger refill internally if needed

        // Without a refill, the next ReadTextString() throws:
        // "No more CBOR data items to read in the current context."
        Assert.Equal("outerKey2", reader.ReadTextString());
        Assert.Equal("outerVal", reader.ReadTextString());
        reader.ReadEndMap();
        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void ReadTextString_TriggersRefill_After_ReadEndMap_AtBufferEnd()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(null);              // Outer map
        writer.WriteTextString("outerKey1");
        writer.WriteStartMap(null);              // Inner map
        writer.WriteTextString("innerKey");
        writer.WriteTextString(new string('A', 30)); // Ensure we consume most of the buffer
        writer.WriteEndMap();                    // End inner map — should still fit in buffer
        writer.WriteTextString("outerKey2");     // Starts in next refill
        writer.WriteTextString("outerVal");
        writer.WriteEndMap();                    // End outer map

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();                   // outer map
        Assert.Equal("outerKey1", reader.ReadTextString());

        reader.ReadStartMap();                   // inner map
        Assert.Equal("innerKey", reader.ReadTextString());
        Assert.Equal(new string('A', 30), reader.ReadTextString());

        reader.ReadEndMap();                     // This must succeed without triggering refill

        // This next read should trigger refill and continue parsing correctly
        Assert.Equal("outerKey2", reader.ReadTextString());
        Assert.Equal("outerVal", reader.ReadTextString());
        reader.ReadEndMap();                     // outer map
        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Unmarshall_MultipleNestedIndefiniteMapsEndingAtStreamEnd_ShouldSucceed()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(null);
        writer.WriteTextString("nested");
        writer.WriteStartMap(null);
        writer.WriteTextString("deep");
        writer.WriteTextString("value");
        writer.WriteEndMap(); // emits 0xFF
        writer.WriteEndMap(); // emits 0xFF

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);
        reader.ReadStartMap();
        Assert.Equal("nested", reader.ReadTextString());
        reader.ReadStartMap();
        Assert.Equal("deep", reader.ReadTextString());
        Assert.Equal("value", reader.ReadTextString());
        reader.ReadEndMap(); // should correctly handle 0xFF at end
        reader.ReadEndMap(); // should correctly handle 0xFF at end
    }

}

