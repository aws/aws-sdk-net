/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Formats.Cbor;
using System.Numerics;
using Amazon.Extensions.Numerics;

namespace Amazon.Extensions.CborProtocol.Internal.Transform
{
    /// <summary>
    /// Reads the byte, short, bigInteger and bigDecimal types from the Full Numeric Type Support specification.
    /// <para>
    /// Smithy RPC v2 CBOR encodes byte and short as major type 0/1 integers, bigInteger as a bignum (tags 2 and 3)
    /// and bigDecimal as a decimal fraction (tag 4). The readers also accept a plain integer for bigInteger and
    /// bigDecimal, since it holds the same value. A floating-point value is rejected for the arbitrary-precision
    /// types, because reading it would mean going through a double.
    /// </para>
    /// </summary>
    internal static class CborNumericReader
    {
        public static bool TryReadNull(CborStreamReader reader)
        {
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Reads a signed 8-bit integer. Values outside the sbyte range throw an <see cref="OverflowException"/>.
        /// </summary>
        public static sbyte ReadSByte(CborStreamReader reader) => checked((sbyte)reader.ReadInt32());

        /// <summary>
        /// Reads a 16-bit integer. Values outside the short range throw an <see cref="OverflowException"/>.
        /// </summary>
        public static short ReadInt16(CborStreamReader reader) => checked((short)reader.ReadInt32());

        public static BigInteger ReadBigInteger(CborStreamReader reader)
        {
            switch (reader.PeekState())
            {
                case CborReaderState.UnsignedInteger:
                    return new BigInteger(reader.ReadUInt64());
                case CborReaderState.NegativeInteger:
                    return new BigInteger(reader.ReadInt64());
                case CborReaderState.Tag:
                    return ReadTaggedBigInteger(reader, reader.ReadTag());
                default:
                    throw new CborContentException($"Expected a CBOR integer or bignum for a bigInteger value but found {reader.PeekState()}.");
            }
        }

        public static BigDecimal ReadBigDecimal(CborStreamReader reader)
        {
            switch (reader.PeekState())
            {
                case CborReaderState.UnsignedInteger:
                case CborReaderState.NegativeInteger:
                    return new BigDecimal(ReadBigInteger(reader));
                case CborReaderState.Tag:
                    break;
                default:
                    throw new CborContentException($"Expected a CBOR decimal fraction for a bigDecimal value but found {reader.PeekState()}.");
            }

            var tag = reader.ReadTag();
            if (tag != CborTag.DecimalFraction)
            {
                return new BigDecimal(ReadTaggedBigInteger(reader, tag));
            }

            // RFC 8949 section 3.4.4: a two-element array [exponent, mantissa], value = mantissa * 10^exponent.
            var length = reader.ReadStartArray();
            if (length != 2)
            {
                throw new CborContentException("A CBOR decimal fraction must be an array of exactly two items.");
            }
            var exponent = reader.ReadInt64();
            var mantissa = ReadBigInteger(reader);
            reader.ReadEndArray();

            // BigDecimal's scale is the negated exponent and must fit in an int.
            return new BigDecimal(mantissa, checked((int)-exponent));
        }

        private static BigInteger ReadTaggedBigInteger(CborStreamReader reader, CborTag tag)
        {
            if (tag != CborTag.UnsignedBigNum && tag != CborTag.NegativeBigNum)
            {
                throw new CborContentException($"Expected a CBOR bignum (tag 2 or 3) but found tag {(ulong)tag}.");
            }

            // The byte string is the big-endian magnitude n; tag 3 means -1 - n (RFC 8949 section 3.4.3).
            var bigEndian = reader.ReadByteString();
            var littleEndian = new byte[bigEndian.Length + 1];
            for (int i = 0; i < bigEndian.Length; i++)
            {
                littleEndian[i] = bigEndian[bigEndian.Length - 1 - i];
            }
            var magnitude = new BigInteger(littleEndian);
            return tag == CborTag.UnsignedBigNum ? magnitude : BigInteger.MinusOne - magnitude;
        }
    }

    public class CborSByteUnmarshaller : ICborUnmarshaller<sbyte, CborUnmarshallerContext>
    {
        private CborSByteUnmarshaller() { }

        public static CborSByteUnmarshaller Instance { get; } = new CborSByteUnmarshaller();

        public sbyte Unmarshall(CborUnmarshallerContext context) => CborNumericReader.ReadSByte(context.Reader);
    }

    public class CborNullableSByteUnmarshaller : ICborUnmarshaller<sbyte?, CborUnmarshallerContext>
    {
        private CborNullableSByteUnmarshaller() { }

        public static CborNullableSByteUnmarshaller Instance { get; } = new CborNullableSByteUnmarshaller();

        public sbyte? Unmarshall(CborUnmarshallerContext context) =>
            CborNumericReader.TryReadNull(context.Reader) ? (sbyte?)null : CborNumericReader.ReadSByte(context.Reader);
    }

    public class CborShortUnmarshaller : ICborUnmarshaller<short, CborUnmarshallerContext>
    {
        private CborShortUnmarshaller() { }

        public static CborShortUnmarshaller Instance { get; } = new CborShortUnmarshaller();

        public short Unmarshall(CborUnmarshallerContext context) => CborNumericReader.ReadInt16(context.Reader);
    }

    public class CborNullableShortUnmarshaller : ICborUnmarshaller<short?, CborUnmarshallerContext>
    {
        private CborNullableShortUnmarshaller() { }

        public static CborNullableShortUnmarshaller Instance { get; } = new CborNullableShortUnmarshaller();

        public short? Unmarshall(CborUnmarshallerContext context) =>
            CborNumericReader.TryReadNull(context.Reader) ? (short?)null : CborNumericReader.ReadInt16(context.Reader);
    }

    public class CborBigIntegerUnmarshaller : ICborUnmarshaller<BigInteger, CborUnmarshallerContext>
    {
        private CborBigIntegerUnmarshaller() { }

        public static CborBigIntegerUnmarshaller Instance { get; } = new CborBigIntegerUnmarshaller();

        public BigInteger Unmarshall(CborUnmarshallerContext context) => CborNumericReader.ReadBigInteger(context.Reader);
    }

    public class CborNullableBigIntegerUnmarshaller : ICborUnmarshaller<BigInteger?, CborUnmarshallerContext>
    {
        private CborNullableBigIntegerUnmarshaller() { }

        public static CborNullableBigIntegerUnmarshaller Instance { get; } = new CborNullableBigIntegerUnmarshaller();

        public BigInteger? Unmarshall(CborUnmarshallerContext context) =>
            CborNumericReader.TryReadNull(context.Reader) ? (BigInteger?)null : CborNumericReader.ReadBigInteger(context.Reader);
    }

    public class CborBigDecimalUnmarshaller : ICborUnmarshaller<BigDecimal, CborUnmarshallerContext>
    {
        private CborBigDecimalUnmarshaller() { }

        public static CborBigDecimalUnmarshaller Instance { get; } = new CborBigDecimalUnmarshaller();

        public BigDecimal Unmarshall(CborUnmarshallerContext context) => CborNumericReader.ReadBigDecimal(context.Reader);
    }

    public class CborNullableBigDecimalUnmarshaller : ICborUnmarshaller<BigDecimal?, CborUnmarshallerContext>
    {
        private CborNullableBigDecimalUnmarshaller() { }

        public static CborNullableBigDecimalUnmarshaller Instance { get; } = new CborNullableBigDecimalUnmarshaller();

        public BigDecimal? Unmarshall(CborUnmarshallerContext context) =>
            CborNumericReader.TryReadNull(context.Reader) ? (BigDecimal?)null : CborNumericReader.ReadBigDecimal(context.Reader);
    }
}
