using System;
using System.Formats.Cbor;
using Xunit;
using Amazon.Extensions.CborProtocol;

namespace Amazon.CborProtocol.Tests;

public class WriteDateTimeTests
{
    [Theory]
    [InlineData("1969-12-31T23:59:59Z", -1.0, CborReaderState.NegativeInteger, 2)]
    [InlineData("1970-01-01T00:00:01Z", 1.0, CborReaderState.UnsignedInteger, 2)]
    [InlineData("1970-01-01T00:00:00.500Z", 0.5, CborReaderState.SinglePrecisionFloat, 6)]
    [InlineData("2025-01-01T00:00:00Z", 1735689600.0, CborReaderState.UnsignedInteger, 6)]
    [InlineData("2025-06-19T20:15:28.468Z", 1750364128.468, CborReaderState.DoublePrecisionFloat, 10)]
    public void WriteDateTime_EncodesCorrectly(string isoDate, double expectedUnixEpoch, CborReaderState expectedState, int expectedTotalBytes)
    {
        var dt = DateTime.Parse(isoDate);
        var writer = new CborWriter();
        writer.WriteDateTime(dt);

        var encoded = writer.Encode();
        var reader = new CborReader(encoded);
        var tag = reader.ReadTag();

        Assert.Equal(CborTag.UnixTimeSeconds, tag);
        Assert.Equal(expectedState, reader.PeekState());

        double value = 0;

        if (expectedState == CborReaderState.SinglePrecisionFloat)
            value = reader.ReadSingle();
        else if (expectedState == CborReaderState.DoublePrecisionFloat)
            value = reader.ReadDouble();
        else if (expectedState == CborReaderState.UnsignedInteger)
            value = reader.ReadUInt64();
        else if (expectedState == CborReaderState.NegativeInteger)
            value = reader.ReadInt64();
        else
            Assert.Fail($"CBOR state not found: ${reader.PeekState()}");

        Assert.Equal(expectedUnixEpoch, value);
        Assert.Equal(expectedTotalBytes, encoded.Length);
    }
}
