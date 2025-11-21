using System.Formats.Cbor;
using Xunit;
using Amazon.Extensions.CborProtocol;

namespace Amazon.CborProtocol.Tests;

public class WriteOptimizedNumberTests
{
    [Theory]
    [InlineData(0, 1)] // Fits in initial byte (major type + value)
    [InlineData(23, 1)] // Still in initial byte
    [InlineData(24, 2)] // One additional byte for UInt8
    [InlineData(255, 2)] // UInt8
    [InlineData(256, 3)] // UInt16
    [InlineData(65535, 3)] // UInt16 max
    [InlineData(65536, 5)] // UInt32
    [InlineData(uint.MaxValue, 5)] // UInt32
    [InlineData((long)uint.MaxValue + 1, 9)] // UInt64
    public void WriteOptimizedNumber_UsesExpectedEncodingLength_ForUInt64(double value, int expectedBytes)
    {
        var writer = new CborWriter();
        writer.WriteOptimizedNumber((double)value);
        var encoded = writer.Encode();

        Assert.Equal(expectedBytes, encoded.Length);
    }

    [Theory]
    [InlineData(-1, 1)] // Negative integers encoded compactly
    [InlineData(-24, 1)]
    [InlineData(-25, 2)] // Beyond negative byte range
    [InlineData(int.MinValue, 5)] // Should require full 32 bits
    [InlineData(long.MinValue, 9)] // Full 64-bit negative integer
    public void WriteOptimizedNumber_UsesExpectedEncodingLength_ForNegativeIntegers(long value, int expectedBytes)
    {
        var writer = new CborWriter();
        writer.WriteOptimizedNumber((double)value);
        var encoded = writer.Encode();

        Assert.Equal(expectedBytes, encoded.Length);
    }

    [Theory]
    [InlineData(1.5, 5, 0xFA)] // float32 marker + 4 bytes
    [InlineData(123456789.12345, 9, 0xFB)] // Doesn't fit in float32
    public void WriteOptimizedNumber_Float32_IsManuallyEncodedAsFiveBytes(double value, int expectedBytes, byte floatMarker)
    {
        var writer = new CborWriter();
        writer.WriteOptimizedNumber(value);
        var encoded = writer.Encode();

        Assert.Equal(expectedBytes, encoded.Length);
        Assert.Equal(floatMarker, encoded[0]); // Check float32 CBOR marker
    }
}
