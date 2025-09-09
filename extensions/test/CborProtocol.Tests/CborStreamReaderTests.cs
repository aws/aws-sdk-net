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

    [Fact]
    public void PeekState_DefiniteArrayAcrossBuffer_ReturnsEndArrayBeforeNextValue()
    {
        var writer = new CborWriter(allowMultipleRootLevelValues: true);
        writer.WriteStartArray(3);
        writer.WriteInt32(1);
        writer.WriteTextString(new string('X', 200));
        writer.WriteInt32(3);
        writer.WriteEndArray();
        writer.WriteInt32(99); // trailing value outside array

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray();
        Assert.Equal(1, reader.ReadInt32());
        Assert.Equal(200, reader.ReadTextString().Length);
        Assert.Equal(3, reader.ReadInt32());

        // PeekState should return EndArray before the trailing value
        Assert.Equal(CborReaderState.EndArray, reader.PeekState());

        // Reading EndArray moves reader to the next value
        reader.ReadEndArray();
        Assert.Equal(CborReaderState.UnsignedInteger, reader.PeekState());
    }

    [Fact]
    public void PeekState_DefiniteMapAcrossBuffer_ReturnsEndMapBeforeNextValue()
    {
        var writer = new CborWriter(allowMultipleRootLevelValues: true);
        writer.WriteStartMap(2);
        writer.WriteTextString("a");
        writer.WriteInt32(1);
        writer.WriteTextString("b");
        writer.WriteTextString(new string('X', 200));
        writer.WriteEndMap();
        writer.WriteInt32(99); // trailing value outside map

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        Assert.Equal("a", reader.ReadTextString());
        Assert.Equal(1, reader.ReadInt32());
        Assert.Equal("b", reader.ReadTextString());
        Assert.Equal(200, reader.ReadTextString().Length);

        // PeekState should return EndMap before the trailing value
        Assert.Equal(CborReaderState.EndMap, reader.PeekState());

        // Reading EndMap moves reader to the next value
        reader.ReadEndMap();
        Assert.Equal(CborReaderState.UnsignedInteger, reader.PeekState());
    }

    [Fact]
    public void PeekState_LongDefiniteArray_FitsAcrossMultipleBuffers()
    {
        var writer = new CborWriter();
        writer.WriteStartArray(100); // large array to exceed 100-byte buffer
        for (int i = 0; i < 100; i++)
        {
            writer.WriteInt32(i);
        }
        writer.WriteEndArray();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray();
        for (int i = 0; i < 100; i++)
        {
            Assert.Equal(i, reader.ReadInt32());
        }

        // PeekState should correctly report EndArray after last element
        Assert.Equal(CborReaderState.EndArray, reader.PeekState());
    }

    [Fact]
    public void PeekState_LongDefiniteMap_FitsAcrossMultipleBuffers()
    {
        var writer = new CborWriter();
        writer.WriteStartMap(25); // large map, each entry has key+value
        for (int i = 0; i < 25; i++)
        {
            writer.WriteTextString("k" + i);
            writer.WriteInt32(i);
        }
        writer.WriteEndMap();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();
        for (int i = 0; i < 25; i++)
        {
            Assert.Equal("k" + i, reader.ReadTextString());
            Assert.Equal(i, reader.ReadInt32());
        }

        // PeekState should correctly report EndMap after last entry
        Assert.Equal(CborReaderState.EndMap, reader.PeekState());
    }


    [Fact]
    public void Unmarshall_NestedContainers_UpdatesParentItemCountCorrectly()
    {
        var writer = new CborWriter();

        writer.WriteStartMap(2);

        writer.WriteTextString(new string('A', 100));

        writer.WriteStartMap(1);
        writer.WriteTextString("InnerKey");

        writer.WriteStartArray(2);
        writer.WriteTextString(new string('A', 100));
        writer.WriteInt32(20);
        writer.WriteEndArray();

        writer.WriteEndMap();

        writer.WriteTextString("Key2");

        writer.WriteInt32(42);

        writer.WriteEndMap();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();

        Assert.Equal(100, reader.ReadTextString().Length);
        reader.ReadStartMap();
        Assert.Equal("InnerKey", reader.ReadTextString());
        reader.ReadStartArray();
        Assert.Equal(100, reader.ReadTextString().Length);
        Assert.Equal(20, reader.ReadInt32());
        reader.ReadEndArray();
        reader.ReadEndMap();

        // Key2 -> inner map
        Assert.Equal(CborReaderState.TextString, reader.PeekState());
        Assert.Equal("Key2", reader.ReadTextString());
        Assert.Equal(42, reader.ReadInt32());
        reader.ReadEndMap();


        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Unmarshall_NestedArrays_CrossBufferBoundary_RefillsCorrectly()
    {
        var writer = new CborWriter();

        writer.WriteStartArray(5);

        writer.WriteStartArray(1);
        writer.WriteTextString(new string('A', 50));
        writer.WriteEndArray();

        writer.WriteStartArray(1);
        writer.WriteTextString(new string('B', 50));
        writer.WriteEndArray();

        writer.WriteStartArray(1);
        writer.WriteTextString(new string('C', 50));
        writer.WriteEndArray();

        writer.WriteStartArray(1);
        writer.WriteTextString(new string('D', 50));
        writer.WriteEndArray();

        writer.WriteInt32(42);

        writer.WriteEndArray();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray();

        // Inner arrays
        reader.ReadStartArray();
        Assert.Equal(new string('A', 50), reader.ReadTextString());
        reader.ReadEndArray();

        reader.ReadStartArray();
        Assert.Equal(new string('B', 50), reader.ReadTextString());
        reader.ReadEndArray();

        reader.ReadStartArray();
        Assert.Equal(new string('C', 50), reader.ReadTextString());
        reader.ReadEndArray();

        reader.ReadStartArray();
        Assert.Equal(new string('D', 50), reader.ReadTextString());
        reader.ReadEndArray();

        // PeekState should correctly indicate we are still inside the outer array
        Assert.Equal(CborReaderState.UnsignedInteger, reader.PeekState());

        // Second item in outer array
        Assert.Equal(42, reader.ReadInt32());

        reader.ReadEndArray();
        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Unmarshall_NestedArrays_MixedLengthsAcrossBuffers()
    {
        var writer = new CborWriter();

        // Outer array: 3 items (definite length)
        writer.WriteStartArray(3);

        // Item 1: long string to force buffer refill
        writer.WriteTextString(new string('A', 150));

        // Item 2: definite-length array with 2 items
        writer.WriteStartArray(2);
        writer.WriteInt32(100);
        writer.WriteInt32(200);
        writer.WriteEndArray();

        // Item 3: indefinite-length array with mixed items
        writer.WriteStartArray(null);
        writer.WriteTextString("inner1");
        writer.WriteTextString(new string('B', 120)); // cross buffer
        writer.WriteEndArray();

        writer.WriteEndArray(); // End outer array

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray();

        // Item 1
        string longString = reader.ReadTextString();
        Assert.Equal(150, longString.Length);

        // Item 2: definite-length array
        reader.ReadStartArray();
        Assert.Equal(100, reader.ReadInt32());
        Assert.Equal(200, reader.ReadInt32());
        reader.ReadEndArray();

        // Item 3: indefinite-length array
        reader.ReadStartArray();
        Assert.Equal("inner1", reader.ReadTextString());
        string longStringB = reader.ReadTextString();
        Assert.Equal(120, longStringB.Length);
        reader.ReadEndArray();

        reader.ReadEndArray();

        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Unmarshall_NestedMaps_MixedLengthsAcrossBuffers()
    {
        var writer = new CborWriter();

        // Outer map: 2 pairs (definite length)
        writer.WriteStartMap(2);

        // Pair 1: key = "k1", value = definite-length map
        writer.WriteTextString("k1");
        writer.WriteStartMap(2);
        writer.WriteTextString("innerKey1");
        writer.WriteTextString(new string('X', 130)); // crosses buffer
        writer.WriteTextString("innerKey2");
        writer.WriteInt32(999);
        writer.WriteEndMap();

        // Pair 2: key = "k2", value = indefinite-length map
        writer.WriteTextString("k2");
        writer.WriteStartMap(null);
        writer.WriteTextString("innerKey3");
        writer.WriteTextString("innerVal3");
        writer.WriteTextString("innerKey4");
        writer.WriteTextString(new string('Y', 140)); // crosses buffer
        writer.WriteEndMap();

        writer.WriteEndMap(); // End outer map

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();

        // Pair 1
        Assert.Equal("k1", reader.ReadTextString());
        reader.ReadStartMap();
        Assert.Equal("innerKey1", reader.ReadTextString());
        string innerVal1 = reader.ReadTextString();
        Assert.Equal(130, innerVal1.Length);
        Assert.Equal("innerKey2", reader.ReadTextString());
        Assert.Equal(999, reader.ReadInt32());
        reader.ReadEndMap();

        // Pair 2
        Assert.Equal("k2", reader.ReadTextString());
        reader.ReadStartMap();
        Assert.Equal("innerKey3", reader.ReadTextString());
        Assert.Equal("innerVal3", reader.ReadTextString());
        Assert.Equal("innerKey4", reader.ReadTextString());
        string innerVal4 = reader.ReadTextString();
        Assert.Equal(140, innerVal4.Length);
        reader.ReadEndMap();

        reader.ReadEndMap();

        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Unmarshall_NestedArrays_MixedDefiniteAndIndefiniteLengthsAcrossBuffers()
    {
        var writer = new CborWriter();

        // Outer array: 3 items (definite length)
        writer.WriteStartArray(3);

        writer.WriteTextString(new string('A', 150));

        // Item 2: definite-length array with 2 items
        writer.WriteStartArray(2);
        writer.WriteInt32(100);
        writer.WriteInt32(200);
        writer.WriteEndArray();

        // Item 3: indefinite-length array with mixed items
        writer.WriteStartArray(null);
        writer.WriteTextString("inner1");
        writer.WriteTextString(new string('B', 120));
        writer.WriteEndArray();

        writer.WriteEndArray();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartArray();

        // Item 1
        string longString = reader.ReadTextString();
        Assert.Equal(150, longString.Length);

        // Item 2: definite-length array
        reader.ReadStartArray();
        Assert.Equal(100, reader.ReadInt32());
        Assert.Equal(200, reader.ReadInt32());
        reader.ReadEndArray();

        // Item 3: indefinite-length array
        reader.ReadStartArray();
        Assert.Equal("inner1", reader.ReadTextString());
        string longStringB = reader.ReadTextString();
        Assert.Equal(120, longStringB.Length);
        reader.ReadEndArray();

        reader.ReadEndArray();

        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void Unmarshall_NestedMaps_MixedDefiniteAndIndefiniteLengthsAcrossBuffers()
    {
        var writer = new CborWriter();

        writer.WriteStartMap(2);

        // Pair 1: key = "k1", value = definite-length map
        writer.WriteTextString("k1");
        writer.WriteStartMap(2);
        writer.WriteTextString("innerKey1");
        writer.WriteTextString(new string('X', 130));
        writer.WriteTextString("innerKey2");
        writer.WriteInt32(999);
        writer.WriteEndMap();

        // Pair 2: key = "k2", value = indefinite-length map
        writer.WriteTextString("k2");
        writer.WriteStartMap(null);
        writer.WriteTextString("innerKey3");
        writer.WriteTextString("innerVal3");
        writer.WriteTextString("innerKey4");
        writer.WriteTextString(new string('Y', 140));
        writer.WriteEndMap();

        writer.WriteEndMap();

        byte[] bytes = writer.Encode();
        var stream = new MemoryStream(bytes);

        using var reader = new CborStreamReader(stream);

        reader.ReadStartMap();

        // Pair 1
        Assert.Equal("k1", reader.ReadTextString());
        reader.ReadStartMap();
        Assert.Equal("innerKey1", reader.ReadTextString());
        string innerVal1 = reader.ReadTextString();
        Assert.Equal(130, innerVal1.Length);
        Assert.Equal("innerKey2", reader.ReadTextString());
        Assert.Equal(999, reader.ReadInt32());
        reader.ReadEndMap();

        // Pair 2
        Assert.Equal("k2", reader.ReadTextString());
        reader.ReadStartMap();
        Assert.Equal("innerKey3", reader.ReadTextString());
        Assert.Equal("innerVal3", reader.ReadTextString());
        Assert.Equal("innerKey4", reader.ReadTextString());
        string innerVal4 = reader.ReadTextString();
        Assert.Equal(140, innerVal4.Length);
        reader.ReadEndMap();

        reader.ReadEndMap();

        Assert.Equal(CborReaderState.Finished, reader.PeekState());
    }

    [Fact]
    public void ReadNestedMixedArraysAndMaps_WithDefiniteAndIndefiniteLengthsAndLongItemsAcrossBuffers_ShouldSucceed()
    {
        var writer = new CborWriter();

        writer.WriteStartArray(4);

        writer.WriteStartArray(2);
        writer.WriteInt32(1);
        writer.WriteTextString(new string('a', 150));
        writer.WriteEndArray();

        writer.WriteStartArray(null);
        writer.WriteStartArray(2);
        writer.WriteInt32(2);
        writer.WriteByteString(new byte[150]);
        writer.WriteEndArray();
        writer.WriteEndArray();

        writer.WriteStartMap(2);

        writer.WriteInt32(3);
        writer.WriteStartArray(2);
        writer.WriteTextString(new string('b', 150)); 
        writer.WriteInt32(4);
        writer.WriteEndArray();

        writer.WriteInt32(5);
        writer.WriteStartMap(1);
        writer.WriteInt32(6);
        writer.WriteByteString(new byte[150]);
        writer.WriteEndMap();

        writer.WriteEndMap();

        writer.WriteStartMap(1);
        writer.WriteInt32(7);
        writer.WriteStartMap(null);
        writer.WriteInt32(8);
        writer.WriteTextString(new string('c', 150));
        writer.WriteEndMap();
        writer.WriteEndMap();

        writer.WriteEndArray();

        var encoding = writer.Encode();

        using var stream = new MemoryStream(encoding);
        var reader = new CborStreamReader(stream);

        reader.ReadStartArray();

        reader.ReadStartArray();
        Assert.Equal(1, reader.ReadInt32());
        var str1 = reader.ReadTextString();
        Assert.Equal(new string('a', 150), str1);
        reader.ReadEndArray();

        reader.ReadStartArray();
        reader.ReadStartArray();
        Assert.Equal(2, reader.ReadInt32());
        var bytes1 = reader.ReadByteString();
        Assert.Equal(150, bytes1.Length);
        reader.ReadEndArray();
        reader.ReadEndArray();

        reader.ReadStartMap();

        Assert.Equal(3, reader.ReadInt32());
        reader.ReadStartArray();
        var str2 = reader.ReadTextString();
        Assert.Equal(new string('b', 150), str2);
        Assert.Equal(4, reader.ReadInt32());
        reader.ReadEndArray();

        Assert.Equal(5, reader.ReadInt32());
        reader.ReadStartMap();
        Assert.Equal(6, reader.ReadInt32());
        var bytes2 = reader.ReadByteString();
        Assert.Equal(150, bytes2.Length);
        reader.ReadEndMap();

        reader.ReadEndMap();

        reader.ReadStartMap();
        Assert.Equal(7, reader.ReadInt32());
        reader.ReadStartMap();
        Assert.Equal(8, reader.ReadInt32());
        var str3 = reader.ReadTextString();
        Assert.Equal(new string('c', 150), str3);
        reader.ReadEndMap();
        reader.ReadEndMap();

        reader.ReadEndArray();
    }
}

