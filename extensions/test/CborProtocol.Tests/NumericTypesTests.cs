using System;
using System.Formats.Cbor;
using System.Globalization;
using System.IO;
using System.Numerics;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;
using Amazon.Extensions.Numerics;
using Xunit;

namespace Amazon.CborProtocol.Tests;

/// <summary>
/// The byte, short, bigInteger and bigDecimal types from the Full Numeric Type Support specification, encoded as Smithy RPC v2
/// CBOR requires: integers, bignums (tags 2/3) and decimal fractions (tag 4). Hex examples are from RFC 8949.
/// </summary>
public class NumericTypesTests
{
    [Theory]
    // RFC 8949 appendix A: 18446744073709551616 (2^64) as a bignum.
    [InlineData("18446744073709551616", "C249010000000000000000")]
    // RFC 8949 appendix A: -18446744073709551617 (-2^64 - 1) as a negative bignum.
    [InlineData("-18446744073709551617", "C349010000000000000000")]
    // .NET writes the zero magnitude as a one-byte string; leading zero bytes are valid (RFC 8949 section 3.4.3).
    [InlineData("0", "C24100")]
    [InlineData("-1", "C34100")]
    public void BigInteger_IsWrittenAsBignum_AndReadBack(string text, string expectedHex)
    {
        var value = BigInteger.Parse(text, CultureInfo.InvariantCulture);
        var writer = new CborWriter();
        writer.WriteBigInteger(value);

        Assert.Equal(expectedHex, ToHex(writer.Encode()));
        Assert.Equal(value, Read(CborBigIntegerUnmarshaller.Instance, writer.Encode()));
        Assert.Equal(value, Read(CborNullableBigIntegerUnmarshaller.Instance, writer.Encode()));
    }

    [Theory]
    [InlineData("00", "0")]
    [InlineData("1B7FFFFFFFFFFFFFFF", "9223372036854775807")]
    [InlineData("1BFFFFFFFFFFFFFFFF", "18446744073709551615")]
    [InlineData("3B7FFFFFFFFFFFFFFF", "-9223372036854775808")]
    public void BigInteger_AcceptsPlainIntegers(string hex, string expected)
    {
        Assert.Equal(BigInteger.Parse(expected, CultureInfo.InvariantCulture), Read(CborBigIntegerUnmarshaller.Instance, FromHex(hex)));
    }

    [Theory]
    // RFC 8949 section 3.4.4: 273.15 is the decimal fraction [-2, 27315].
    [InlineData("273.15", "C48221196AB3")]
    [InlineData("1.50", "C482211896")]
    [InlineData("-0.5", "C4822024")]
    [InlineData("1E+3", "C4820301")]
    public void BigDecimal_IsWrittenAsDecimalFraction_AndReadBack(string text, string expectedHex)
    {
        var value = BigDecimal.Parse(text, CultureInfo.InvariantCulture);
        var writer = new CborWriter();
        writer.WriteBigDecimal(value);

        Assert.Equal(expectedHex, ToHex(writer.Encode()));
        AssertSameDigitsAndScale(value, Read(CborBigDecimalUnmarshaller.Instance, writer.Encode()));
        AssertSameDigitsAndScale(value, Read(CborNullableBigDecimalUnmarshaller.Instance, writer.Encode()).Value);
    }

    [Fact]
    public void BigDecimal_WithMantissaBeyondLong_UsesBignumMantissa()
    {
        // 50 significant digits and 30 decimal places: neither the mantissa nor the value fits in long, double or decimal.
        var value = BigDecimal.Parse("-98765432109876543210.987654321098765432109876543210", CultureInfo.InvariantCulture);
        var writer = new CborWriter();
        writer.WriteBigDecimal(value);
        var bytes = writer.Encode();

        // Tag 4, array of 2, exponent -30 (0x38 0x1D), then a negative bignum (tag 3) mantissa.
        Assert.Equal("C482381DC3", ToHex(bytes, 0, 5));
        AssertSameDigitsAndScale(value, Read(CborBigDecimalUnmarshaller.Instance, bytes));
    }

    [Theory]
    [InlineData("1864", "100")]
    [InlineData("C249010000000000000000", "18446744073709551616")]
    public void BigDecimal_AcceptsIntegersAndBignums(string hex, string expected)
    {
        AssertSameDigitsAndScale(BigDecimal.Parse(expected, CultureInfo.InvariantCulture), Read(CborBigDecimalUnmarshaller.Instance, FromHex(hex)));
    }

    [Theory]
    // A float would go through a double, losing digits.
    [InlineData("FB3FB999999999999A")]
    // A text string is not a number.
    [InlineData("6131")]
    public void ArbitraryPrecision_RejectsNonIntegerEncodings(string hex)
    {
        var bytes = FromHex(hex);
        Assert.Throws<CborContentException>(() => { Read(CborBigDecimalUnmarshaller.Instance, bytes); });
        Assert.Throws<CborContentException>(() => { Read(CborBigIntegerUnmarshaller.Instance, bytes); });
    }

    [Fact]
    public void BigDecimal_ScaleOutsideInt32_Throws()
    {
        var writer = new CborWriter();
        writer.WriteTag(CborTag.DecimalFraction);
        writer.WriteStartArray(2);
        writer.WriteInt64((long)int.MaxValue + 2);
        writer.WriteInt32(1);
        writer.WriteEndArray();

        Assert.Throws<OverflowException>(() => { Read(CborBigDecimalUnmarshaller.Instance, writer.Encode()); });
    }

    [Theory]
    [InlineData("387F", (sbyte)-128)]
    [InlineData("187F", (sbyte)127)]
    public void SByte_InRange(string hex, sbyte expected)
    {
        Assert.Equal(expected, Read(CborSByteUnmarshaller.Instance, FromHex(hex)));
        Assert.Equal(expected, Read(CborNullableSByteUnmarshaller.Instance, FromHex(hex)));
    }

    [Theory]
    [InlineData("1880")]   // 128
    [InlineData("3880")]   // -129
    public void SByte_OutOfRange_Throws(string hex)
    {
        Assert.Throws<OverflowException>(() => { Read(CborSByteUnmarshaller.Instance, FromHex(hex)); });
    }

    [Theory]
    [InlineData("397FFF", (short)-32768)]
    [InlineData("197FFF", (short)32767)]
    public void Short_InRange(string hex, short expected)
    {
        Assert.Equal(expected, Read(CborShortUnmarshaller.Instance, FromHex(hex)));
        Assert.Equal(expected, Read(CborNullableShortUnmarshaller.Instance, FromHex(hex)));
    }

    [Theory]
    [InlineData("198000")] // 32768
    [InlineData("398000")] // -32769
    public void Short_OutOfRange_Throws(string hex)
    {
        Assert.Throws<OverflowException>(() => { Read(CborShortUnmarshaller.Instance, FromHex(hex)); });
    }

    [Fact]
    public void Nullable_ReadNull()
    {
        var nullValue = FromHex("F6");
        Assert.Null(Read(CborNullableSByteUnmarshaller.Instance, nullValue));
        Assert.Null(Read(CborNullableShortUnmarshaller.Instance, nullValue));
        Assert.Null(Read(CborNullableBigIntegerUnmarshaller.Instance, nullValue));
        Assert.Null(Read(CborNullableBigDecimalUnmarshaller.Instance, nullValue));
    }

    // Convert.FromHexString/ToHexString are not available on net472.
    private static byte[] FromHex(string hex)
    {
        var bytes = new byte[hex.Length / 2];
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i] = byte.Parse(hex.Substring(i * 2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture);
        }
        return bytes;
    }

    private static string ToHex(byte[] bytes, int offset = 0, int count = -1)
    {
        return BitConverter.ToString(bytes, offset, count < 0 ? bytes.Length - offset : count).Replace("-", "");
    }

    private static T Read<T>(ICborUnmarshaller<T, CborUnmarshallerContext> unmarshaller, byte[] bytes)
    {
        var context = new CborUnmarshallerContext(new MemoryStream(bytes), false, null);
        return unmarshaller.Unmarshall(context);
    }

    private static void AssertSameDigitsAndScale(BigDecimal expected, BigDecimal actual)
    {
        Assert.Equal(expected.UnscaledValue, actual.UnscaledValue);
        Assert.Equal(expected.Scale, actual.Scale);
    }
}
