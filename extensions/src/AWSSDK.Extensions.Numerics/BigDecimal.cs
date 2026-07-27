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
using System.Diagnostics;
using System.Numerics;

namespace Amazon.Extensions.Numerics
{
    /// <summary>
    /// An immutable, arbitrary-precision signed decimal number. A <see cref="BigDecimal"/> is
    /// represented by an arbitrary-precision unscaled value and a 32-bit integer scale, where the
    /// numeric value equals <c>unscaledValue &#215; 10<sup>-scale</sup></c>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This type preserves every digit of the values it is given. Unlike <see cref="double"/> it has
    /// no binary rounding error, and unlike <see cref="decimal"/> it has no fixed digit limit, which
    /// makes it suitable for round-tripping high-precision numeric values across AWS service requests
    /// and responses without loss.
    /// </para>
    /// <para>
    /// Trailing zeros are significant for storage purposes: <c>2.0</c> (scale 1) and <c>2.00</c>
    /// (scale 2) retain their distinct scales, so <see cref="Scale"/> and <see cref="object.ToString()"/>
    /// faithfully reflect the original value. However, equality and comparison are purely numeric, so
    /// <c>2.0</c> and <c>2.00</c> compare as equal. This differs from Java's <c>BigDecimal.equals</c>,
    /// which is scale-sensitive.
    /// </para>
    /// </remarks>
    public readonly partial struct BigDecimal
        : IEquatable<BigDecimal>, IComparable<BigDecimal>, IComparable, IFormattable
    {
        private readonly BigInteger _unscaledValue;
        private readonly int _scale;

        /// <summary>
        /// A <see cref="BigDecimal"/> representing the value zero, with a scale of zero.
        /// </summary>
        public static BigDecimal Zero { get; } = new BigDecimal(BigInteger.Zero, 0);

        /// <summary>
        /// A <see cref="BigDecimal"/> representing the value one, with a scale of zero.
        /// </summary>
        public static BigDecimal One { get; } = new BigDecimal(BigInteger.One, 0);

        /// <summary>
        /// A <see cref="BigDecimal"/> representing the value ten, with a scale of zero.
        /// </summary>
        public static BigDecimal Ten { get; } = new BigDecimal(new BigInteger(10), 0);

        /// <summary>
        /// Initializes a new <see cref="BigDecimal"/> from an unscaled value and a scale, such that
        /// the numeric value equals <c>unscaledValue &#215; 10<sup>-scale</sup></c>.
        /// </summary>
        /// <param name="unscaledValue">The unscaled value (the significant digits, including sign).</param>
        /// <param name="scale">
        /// The scale. A positive scale denotes digits to the right of the decimal point; a negative
        /// scale multiplies the unscaled value by a positive power of ten.
        /// </param>
        public BigDecimal(BigInteger unscaledValue, int scale)
        {
            _unscaledValue = unscaledValue;
            _scale = scale;
        }

        /// <summary>
        /// Initializes a new <see cref="BigDecimal"/> from a <see cref="BigInteger"/> with a scale of zero.
        /// </summary>
        /// <param name="value">The integer value.</param>
        public BigDecimal(BigInteger value)
            : this(value, 0)
        {
        }

        /// <summary>
        /// Initializes a new <see cref="BigDecimal"/> from a 32-bit signed integer with a scale of zero.
        /// </summary>
        /// <param name="value">The integer value.</param>
        public BigDecimal(int value)
            : this(new BigInteger(value), 0)
        {
        }

        /// <summary>
        /// Initializes a new <see cref="BigDecimal"/> from a 64-bit signed integer with a scale of zero.
        /// </summary>
        /// <param name="value">The integer value.</param>
        public BigDecimal(long value)
            : this(new BigInteger(value), 0)
        {
        }

        /// <summary>
        /// Initializes a new <see cref="BigDecimal"/> that exactly represents the supplied
        /// <see cref="decimal"/> value, preserving its scale (including trailing zeros).
        /// </summary>
        /// <param name="value">The decimal value.</param>
        public BigDecimal(decimal value)
        {
            this = FromDecimal(value);
        }

        /// <summary>
        /// Gets the scale of this value. A positive scale is the number of digits to the right of the
        /// decimal point; a negative scale indicates the unscaled value is multiplied by a positive
        /// power of ten.
        /// </summary>
        public int Scale => _scale;

        /// <summary>
        /// Gets the unscaled value (the significant digits, including sign) of this <see cref="BigDecimal"/>.
        /// </summary>
        public BigInteger UnscaledValue => _unscaledValue;

        /// <summary>
        /// Gets the precision of this value: the number of digits in the unscaled value. The precision
        /// of zero is <c>1</c>.
        /// </summary>
        public int Precision => DigitCount(_unscaledValue);

        /// <summary>
        /// Gets a number indicating the sign of this value: <c>-1</c> if negative, <c>0</c> if zero,
        /// and <c>1</c> if positive.
        /// </summary>
        public int Sign => _unscaledValue.Sign;

        /// <summary>
        /// Gets a value indicating whether this <see cref="BigDecimal"/> is zero, regardless of scale.
        /// </summary>
        public bool IsZero => _unscaledValue.IsZero;

        /// <summary>
        /// Returns the number of decimal digits in the absolute value of <paramref name="value"/>.
        /// Zero has a digit count of <c>1</c>.
        /// </summary>
        internal static int DigitCount(BigInteger value)
        {
            if (value.IsZero)
                return 1;

            if (value.Sign < 0)
                value = -value;

            // Fast path for magnitudes that fit in a ulong: count digits against a small table, avoiding
            // the ToByteArray allocation and BigInteger comparison the general path needs. Small values
            // dominate the SDK's serialization workload, and DigitCount is on the hot path of Precision,
            // Round, and division.
            if (value <= UInt64MaxValue)
                return DigitCountUInt64((ulong)value);

            // Estimate using the bit length (log10(2) ~= 0.30103), then correct by at most one.
            int estimate = (int)(BitLength(value) * 0.30102999566398119521) + 1;

            // Correct the estimate against the exact power of ten.
            if (value < PowerOfTen(estimate - 1))
                estimate--;

            return estimate;
        }

        /// <summary>
        /// Returns the number of bits in the binary representation of the non-negative value
        /// <paramref name="value"/> (the position of its most-significant set bit, plus one); zero has a
        /// bit length of zero. This is the single bit-length helper shared across the conversion paths so
        /// the implementations cannot drift.
        /// </summary>
        internal static int BitLength(BigInteger value)
        {
            Debug.Assert(value.Sign >= 0, "BitLength expects a non-negative value.");
#if NET8_0_OR_GREATER
            // For a non-negative value the shortest two's-complement bit length without the sign bit is
            // exactly the magnitude's bit length. GetBitLength avoids the ToByteArray allocation the
            // netstandard2.0 path below requires.
            return (int)value.GetBitLength();
#else
            // BigInteger has no GetBitLength on netstandard2.0, so derive it from the byte representation.
            // ToByteArray is little-endian and may carry a trailing 0x00 to denote a positive sign; skip any
            // leading zero bytes from the most-significant end, then count bits in the top non-zero byte.
            byte[] bytes = value.ToByteArray();
            int index = bytes.Length - 1;
            while (index > 0 && bytes[index] == 0)
                index--;

            int bits = index * 8;
            int top = bytes[index];
            while (top > 0)
            {
                bits++;
                top >>= 1;
            }

            return bits;
#endif
        }

        /// <summary>
        /// The largest power-of-ten exponent — equivalently, the largest number of digits — this type will
        /// materialize in a single operation. A <see cref="BigDecimal"/> can be parsed or constructed cheaply
        /// with an extreme scale (for example <c>"1E2000000000"</c> or <c>"1E-2000000000"</c> is only a handful
        /// of bytes on the wire and stores an unscaled value of <c>1</c>). The cost is paid only when an
        /// operation has to realize <c>10<sup>scale</sup></c> as actual digits: scale alignment
        /// (<see cref="Add(BigDecimal)"/>, <see cref="Subtract(BigDecimal)"/>, <see cref="CompareTo(BigDecimal)"/>,
        /// <see cref="Remainder(BigDecimal)"/>), the integer and <see cref="decimal"/> conversions,
        /// <see cref="SetScale(int, RoundingMode)"/>, the <c>MovePoint</c> family, and plain-string formatting.
        /// Left unbounded, those paths allocate gigabytes and terminate the process with an
        /// <see cref="OutOfMemoryException"/> from a tiny, attacker-controlled value — the same class of issue
        /// that led the Java/JSON ecosystem to cap <c>BigDecimal</c> magnitude at the deserialization boundary.
        /// Because realizing this many digits is already far beyond any real-world AWS wire value, exceeding the
        /// limit instead throws a clear, catchable <see cref="OverflowException"/>. (This is a deliberate
        /// divergence from Java, whose <c>BigDecimal</c> leaves the same operations unbounded.)
        /// </summary>
        internal const int MaxMaterializedDigits = 100_000_000;

        /// <summary>
        /// Throws an <see cref="OverflowException"/> when an operation would have to materialize more than
        /// <see cref="MaxMaterializedDigits"/> digits, converting a would-be <see cref="OutOfMemoryException"/>
        /// into a clear, catchable error. <paramref name="digitCount"/> is taken as <see cref="long"/> so a
        /// count derived from an extreme scale cannot wrap before it is checked.
        /// </summary>
        internal static void GuardMaterializedDigits(long digitCount)
        {
            if (digitCount > MaxMaterializedDigits)
                throw new OverflowException(
                    "The operation would materialize more than " + MaxMaterializedDigits.ToString(System.Globalization.CultureInfo.InvariantCulture) +
                    " digits, which exceeds the supported limit. This typically indicates a value with an extreme scale from untrusted input.");
        }

        /// <summary>
        /// Returns <c>10<sup>exponent</sup></c> as a <see cref="BigInteger"/>, using a small cache for
        /// frequently used exponents.
        /// </summary>
        /// <param name="exponent">A non-negative exponent.</param>
        /// <exception cref="OverflowException">Thrown when <paramref name="exponent"/> exceeds <see cref="MaxMaterializedDigits"/>.</exception>
        internal static BigInteger PowerOfTen(int exponent)
        {
            if (exponent < 0)
                throw new ArgumentOutOfRangeException(nameof(exponent), "Exponent cannot be negative.");

            if (exponent < PowersOfTenCache.Length)
                return PowersOfTenCache[exponent];

            GuardMaterializedDigits(exponent);

            return BigInteger.Pow(BigIntegerTen, exponent);
        }

        private static readonly BigInteger BigIntegerTen = new BigInteger(10);

        private static readonly BigInteger UInt64MaxValue = new BigInteger(ulong.MaxValue);

        // Lower bound of each decimal digit-count for a ulong: PowersOfTenUInt64[k] == 10^k. ulong.MaxValue
        // (20 digits) sits between 10^19 and 10^20, so 10^20 would overflow; the table stops at 10^19.
        private static readonly ulong[] PowersOfTenUInt64 =
        {
            1UL, 10UL, 100UL, 1000UL, 10000UL, 100000UL, 1000000UL, 10000000UL,
            100000000UL, 1000000000UL, 10000000000UL, 100000000000UL, 1000000000000UL,
            10000000000000UL, 100000000000000UL, 1000000000000000UL, 10000000000000000UL,
            100000000000000000UL, 1000000000000000000UL, 10000000000000000000UL,
        };

        /// <summary>
        /// Returns the number of decimal digits in <paramref name="value"/>, for a magnitude that fits in
        /// a <see cref="ulong"/>. Zero has a digit count of <c>1</c>.
        /// </summary>
        private static int DigitCountUInt64(ulong value)
        {
            // Approximate log10 from the bit length, then correct by at most one against the power table.
            int bits = 0;
            ulong shifted = value;
            while (shifted > 0)
            {
                bits++;
                shifted >>= 1;
            }

            int estimate = (int)((bits - 1) * 0.30102999566398119521) + 1;
            if (estimate < 1)
                estimate = 1;

            if (estimate < PowersOfTenUInt64.Length && value >= PowersOfTenUInt64[estimate])
                estimate++;

            return estimate;
        }

        /// <summary>
        /// Validates that a scale computed in <see cref="long"/> arithmetic fits in the 32-bit range that
        /// <see cref="Scale"/> requires, and returns it narrowed to <see cref="int"/>. Scale-producing
        /// operations compute in <see cref="long"/> first so an intermediate that exceeds the range fails
        /// here with a clear error rather than silently wrapping (and then surfacing as a confusing
        /// negative-exponent error deeper in the call).
        /// </summary>
        /// <param name="scale">The candidate scale.</param>
        /// <returns>The scale narrowed to <see cref="int"/>.</returns>
        /// <exception cref="OverflowException">Thrown when <paramref name="scale"/> is outside the 32-bit integer range.</exception>
        internal static int CheckScaleRange(long scale)
        {
            if (scale > int.MaxValue || scale < int.MinValue)
                throw new OverflowException("The resulting scale is outside the range of a 32-bit integer.");

            return (int)scale;
        }

        private static readonly BigInteger[] PowersOfTenCache = CreatePowersOfTenCache();

        private static BigInteger[] CreatePowersOfTenCache()
        {
            // Covers exponents 0..31, which captures every power of ten reachable from the
            // built-in integer and decimal types without a BigInteger.Pow call.
            var cache = new BigInteger[32];
            BigInteger current = BigInteger.One;
            for (int i = 0; i < cache.Length; i++)
            {
                cache[i] = current;
                current *= 10;
            }

            return cache;
        }
    }
}
