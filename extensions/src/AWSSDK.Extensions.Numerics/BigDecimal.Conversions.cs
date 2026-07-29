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
using System.Globalization;
using System.Numerics;
#if !NET8_0_OR_GREATER
using System.Collections.Generic;
#endif

namespace Amazon.Extensions.Numerics
{
    public readonly partial struct BigDecimal
    {
        /// <summary>
        /// Creates a <see cref="BigDecimal"/> that exactly represents the supplied <see cref="decimal"/>,
        /// preserving its scale including trailing zeros.
        /// </summary>
        /// <param name="value">The decimal value.</param>
        /// <returns>An exact <see cref="BigDecimal"/> representation.</returns>
        public static BigDecimal FromDecimal(decimal value)
        {
            // decimal layout: 96-bit integer (lo/mid/hi) plus a flags word holding sign and a scale of 0..28.
            int[] bits = decimal.GetBits(value);
            uint lo = (uint)bits[0];
            uint mid = (uint)bits[1];
            uint hi = (uint)bits[2];
            int flags = bits[3];

            int scale = (flags >> 16) & 0x7F;
            bool isNegative = (flags & unchecked((int)0x80000000)) != 0;

            BigInteger magnitude = (new BigInteger(hi) << 64) | (new BigInteger(mid) << 32) | new BigInteger(lo);
            if (isNegative)
                magnitude = -magnitude;

            return new BigDecimal(magnitude, scale);
        }

        /// <summary>
        /// Creates a <see cref="BigDecimal"/> that exactly represents the binary value of the supplied
        /// <see cref="double"/>. Because <see cref="double"/> is a binary floating-point type, the result
        /// captures the exact stored value (for example, <c>0.1</c> is not exactly one tenth). To obtain a
        /// value matching the decimal text, parse a string instead.
        /// </summary>
        /// <param name="value">The double value. Must be finite.</param>
        /// <returns>An exact <see cref="BigDecimal"/> representation of the double's binary value.</returns>
        /// <exception cref="OverflowException">Thrown when <paramref name="value"/> is NaN or infinite.</exception>
        public static BigDecimal FromDouble(double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                throw new OverflowException("Cannot convert NaN or Infinity to a BigDecimal.");

            if (value == 0.0)
                return Zero;

            long bits = BitConverter.DoubleToInt64Bits(value);
            bool negative = bits < 0;
            int exponent = (int)((bits >> 52) & 0x7FF);
            long mantissa = bits & 0xFFFFFFFFFFFFFL;

            if (exponent == 0)
                exponent++;            // subnormal
            else
                mantissa |= 0x10000000000000L; // restore the implicit leading bit

            // value = mantissa * 2^(exponent - 1075).
            exponent -= 1075;

            BigInteger significand = new BigInteger(mantissa);
            if (negative)
                significand = -significand;

            if (exponent >= 0)
            {
                // Pure integer: multiply out the positive power of two, scale 0.
                return new BigDecimal(significand * BigInteger.Pow(new BigInteger(2), exponent), 0);
            }

            // value = significand / 2^(-exponent) = significand * 5^(-exponent) / 10^(-exponent).
            int negExponent = -exponent;
            BigInteger unscaled = significand * BigInteger.Pow(new BigInteger(5), negExponent);
            return new BigDecimal(unscaled, negExponent);
        }

        /// <summary>
        /// Creates a <see cref="BigDecimal"/> from the shortest decimal string that round-trips to the
        /// supplied <see cref="double"/>, yielding the value a caller most likely intends. For example,
        /// <c>FromDoubleRoundTrip(0.1)</c> returns exactly <c>0.1</c>, whereas <see cref="FromDouble(double)"/>
        /// returns the much longer exact binary value <c>0.1000000000000000055511151231257827...</c>.
        /// </summary>
        /// <param name="value">The double value. Must be finite.</param>
        /// <returns>
        /// A <see cref="BigDecimal"/> equal to the shortest decimal that round-trips to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="OverflowException">Thrown when <paramref name="value"/> is NaN or infinite.</exception>
        /// <remarks>
        /// This is usually the preferred way to convert a <see cref="double"/> (or <see cref="float"/>) whose
        /// value originated as a decimal, since it discards the binary representation error. Use
        /// <see cref="FromDouble(double)"/> only when the exact stored binary value is required. The behavior
        /// mirrors the rounding performed by the <see cref="decimal"/> conversion built into the language.
        /// </remarks>
        public static BigDecimal FromDoubleRoundTrip(double value)
        {
            if (double.IsNaN(value) || double.IsInfinity(value))
                throw new OverflowException("Cannot convert NaN or Infinity to a BigDecimal.");

            // Convert from the shortest decimal string that round-trips to this double, which is the value a
            // caller almost always means (the same value Parse would yield from that literal). This is the
            // .NET analog of Java's BigDecimal.valueOf(double). The "R" format is deliberately avoided here:
            // it does not reliably round-trip a double on the .NET Framework runtime behind netstandard2.0.
            return Parse(ShortestRoundTrippableString(value), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Creates a <see cref="BigDecimal"/> from the shortest decimal string that round-trips to the
        /// supplied <see cref="float"/>, yielding the value a caller most likely intends. See
        /// <see cref="FromDoubleRoundTrip(double)"/>.
        /// </summary>
        /// <param name="value">The single-precision value. Must be finite.</param>
        /// <returns>
        /// A <see cref="BigDecimal"/> equal to the shortest decimal that round-trips to <paramref name="value"/>.
        /// </returns>
        /// <exception cref="OverflowException">Thrown when <paramref name="value"/> is NaN or infinite.</exception>
        public static BigDecimal FromSingleRoundTrip(float value)
        {
            if (float.IsNaN(value) || float.IsInfinity(value))
                throw new OverflowException("Cannot convert NaN or Infinity to a BigDecimal.");

            return Parse(ShortestRoundTrippableString(value), CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Returns the shortest decimal string that round-trips back to <paramref name="value"/>. On
        /// modern .NET (<c>net8.0</c>) the default <c>ToString</c> already produces the shortest
        /// round-trippable representation, so it is used directly. On the <c>netstandard2.0</c> target —
        /// which runs on the .NET Framework runtime where neither the default format nor <c>"R"</c>
        /// reliably round-trips a <see cref="double"/> — this starts from the <c>"G17"</c> form (guaranteed
        /// to round-trip) and shortens it to the fewest significant digits that still parse back to the
        /// same value, matching the shortest-decimal behavior of modern .NET.
        /// </summary>
        private static string ShortestRoundTrippableString(double value)
        {
#if NET8_0_OR_GREATER
            // The default format on net8.0+ is the shortest round-trippable representation.
            return value.ToString(CultureInfo.InvariantCulture);
#else
            return ShortenRoundTrip(
                value,
                "G17",
                s => double.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture),
                value);
#endif
        }

        /// <summary>
        /// Returns the shortest decimal string that round-trips back to <paramref name="value"/>. See
        /// <see cref="ShortestRoundTrippableString(double)"/> for the rationale.
        /// </summary>
        private static string ShortestRoundTrippableString(float value)
        {
#if NET8_0_OR_GREATER
            return value.ToString(CultureInfo.InvariantCulture);
#else
            return ShortenRoundTrip(
                value,
                "G9",
                s => float.Parse(s, NumberStyles.Float, CultureInfo.InvariantCulture),
                value);
#endif
        }

#if !NET8_0_OR_GREATER
        /// <summary>
        /// Finds the shortest <c>"G{precision}"</c> representation of <paramref name="value"/> (from 1 up to
        /// the type's guaranteed round-trip precision) that parses back to the original value, falling back to
        /// the guaranteed-round-trip <paramref name="maxPrecisionFormat"/> form when no shorter one round-trips.
        /// Used only on the netstandard2.0 target, where the runtime's own shortest-string formatting is
        /// unavailable or unreliable.
        /// </summary>
        private static string ShortenRoundTrip<T>(
            IFormattable value,
            string maxPrecisionFormat,
            Func<string, T> parse,
            T original)
        {
            // maxPrecisionFormat is "G17" (double) or "G9" (float); both round-trip by definition. Probe
            // increasing significant-digit counts and return the first whose parse reproduces the original.
            int maxDigits = maxPrecisionFormat == "G17" ? 17 : 9;
            for (int digits = 1; digits < maxDigits; digits++)
            {
                string candidate = value.ToString("G" + digits.ToString(CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
                if (EqualityComparer<T>.Default.Equals(parse(candidate), original))
                    return candidate;
            }

            return value.ToString(maxPrecisionFormat, CultureInfo.InvariantCulture);
        }
#endif

        /// <summary>Implicitly converts a 32-bit signed integer to a <see cref="BigDecimal"/> (lossless).</summary>
        public static implicit operator BigDecimal(int value) => new BigDecimal(value);

        /// <summary>Implicitly converts a 64-bit signed integer to a <see cref="BigDecimal"/> (lossless).</summary>
        public static implicit operator BigDecimal(long value) => new BigDecimal(value);

        /// <summary>Implicitly converts a 64-bit unsigned integer to a <see cref="BigDecimal"/> (lossless).</summary>
        public static implicit operator BigDecimal(ulong value) => new BigDecimal(new BigInteger(value), 0);

        /// <summary>Implicitly converts a <see cref="decimal"/> to a <see cref="BigDecimal"/> (lossless).</summary>
        public static implicit operator BigDecimal(decimal value) => FromDecimal(value);

        /// <summary>Implicitly converts a <see cref="BigInteger"/> to a <see cref="BigDecimal"/> (lossless).</summary>
        public static implicit operator BigDecimal(BigInteger value) => new BigDecimal(value, 0);

        /// <summary>
        /// Explicitly converts a <see cref="double"/> to a <see cref="BigDecimal"/>. This is explicit
        /// because the conversion captures the double's exact binary value. See <see cref="FromDouble(double)"/>.
        /// </summary>
        public static explicit operator BigDecimal(double value) => FromDouble(value);

        /// <summary>
        /// Explicitly converts a <see cref="float"/> to a <see cref="BigDecimal"/>. This is explicit
        /// because the conversion captures the value's exact binary representation.
        /// </summary>
        public static explicit operator BigDecimal(float value) => FromDouble(value);

        /// <summary>Explicitly converts a <see cref="BigDecimal"/> to a <see cref="BigInteger"/>, truncating any fractional part.</summary>
        public static explicit operator BigInteger(BigDecimal value) => value.ToBigInteger();

        /// <summary>Explicitly converts a <see cref="BigDecimal"/> to a 32-bit signed integer, truncating any fractional part.</summary>
        public static explicit operator int(BigDecimal value) => value.ToInt32();

        /// <summary>Explicitly converts a <see cref="BigDecimal"/> to a 64-bit signed integer, truncating any fractional part.</summary>
        public static explicit operator long(BigDecimal value) => value.ToInt64();

        /// <summary>Explicitly converts a <see cref="BigDecimal"/> to a <see cref="decimal"/>.</summary>
        public static explicit operator decimal(BigDecimal value) => value.ToDecimal();

        /// <summary>Explicitly converts a <see cref="BigDecimal"/> to a <see cref="double"/>.</summary>
        public static explicit operator double(BigDecimal value) => value.ToDouble();

        /// <summary>Explicitly converts a <see cref="BigDecimal"/> to a <see cref="float"/>.</summary>
        public static explicit operator float(BigDecimal value) => value.ToSingle();

        /// <summary>
        /// Converts this value to a <see cref="BigInteger"/>, truncating any fractional digits toward zero.
        /// </summary>
        /// <returns>The integer part of this value.</returns>
        public BigInteger ToBigInteger()
        {
            if (_scale == 0)
                return _unscaledValue;

            if (_scale < 0)
            {
                // Negate in long so an int.MinValue scale cannot wrap back to a negative int and reach
                // PowerOfTen as a bogus negative exponent. A magnitude this large is rejected by the
                // materialization guard inside PowerOfTen (as a clear OverflowException) before it is used.
                long magnitude = -(long)_scale;
                if (magnitude > int.MaxValue)
                    GuardMaterializedDigits(magnitude);
                return _unscaledValue * PowerOfTen((int)magnitude);
            }

            return _unscaledValue / PowerOfTen(_scale);
        }

        /// <summary>
        /// Converts this value to a 32-bit signed integer, truncating any fractional digits toward zero.
        /// </summary>
        /// <returns>The truncated integer value.</returns>
        /// <exception cref="OverflowException">Thrown when the value does not fit in an <see cref="int"/>.</exception>
        public int ToInt32() => (int)ToBigInteger();

        /// <summary>
        /// Converts this value to a 64-bit signed integer, truncating any fractional digits toward zero.
        /// </summary>
        /// <returns>The truncated integer value.</returns>
        /// <exception cref="OverflowException">Thrown when the value does not fit in a <see cref="long"/>.</exception>
        public long ToInt64() => (long)ToBigInteger();

        /// <summary>
        /// Converts this value to a <see cref="BigInteger"/>, requiring an exact integral value. Unlike
        /// <see cref="ToBigInteger"/>, this throws rather than silently discarding a fractional part.
        /// </summary>
        /// <returns>The integral value.</returns>
        /// <exception cref="ArithmeticException">Thrown when this value has a non-zero fractional part.</exception>
        public BigInteger ToBigIntegerExact()
        {
            if (_scale <= 0)
                return ToBigInteger();

            BigInteger remainder;
            BigInteger quotient = BigInteger.DivRem(_unscaledValue, PowerOfTen(_scale), out remainder);
            if (!remainder.IsZero)
                throw new ArithmeticException("The value has a non-zero fractional part and cannot be represented as an integer exactly.");

            return quotient;
        }

        /// <summary>
        /// Converts this value to a 32-bit signed integer, requiring an exact integral value that fits in an
        /// <see cref="int"/>. Unlike <see cref="ToInt32"/>, this throws rather than silently truncating a
        /// fractional part.
        /// </summary>
        /// <returns>The integral value.</returns>
        /// <exception cref="ArithmeticException">Thrown when this value has a non-zero fractional part.</exception>
        /// <exception cref="OverflowException">Thrown when the value does not fit in an <see cref="int"/>.</exception>
        public int ToInt32Exact() => checked((int)ToBigIntegerExact());

        /// <summary>
        /// Converts this value to a 64-bit signed integer, requiring an exact integral value that fits in a
        /// <see cref="long"/>. Unlike <see cref="ToInt64"/>, this throws rather than silently truncating a
        /// fractional part.
        /// </summary>
        /// <returns>The integral value.</returns>
        /// <exception cref="ArithmeticException">Thrown when this value has a non-zero fractional part.</exception>
        /// <exception cref="OverflowException">Thrown when the value does not fit in a <see cref="long"/>.</exception>
        public long ToInt64Exact() => checked((long)ToBigIntegerExact());

        /// <summary>
        /// Converts this value to a <see cref="decimal"/>. When this value has more precision than
        /// <see cref="decimal"/> can hold (more than 28&#8211;29 significant digits) the result is rounded;
        /// use <see cref="ToDecimalExact"/> to require an exact conversion instead.
        /// </summary>
        /// <returns>The decimal representation.</returns>
        /// <exception cref="OverflowException">Thrown when the value is outside the range of <see cref="decimal"/>.</exception>
        public decimal ToDecimal() => decimal.Parse(ToString(CultureInfo.InvariantCulture), NumberStyles.Float, CultureInfo.InvariantCulture);

        // The largest magnitude a decimal can store: a 96-bit unsigned integer, i.e. 2^96 - 1, which is
        // exactly decimal.MaxValue (79228162514264337593543950335). The exact decimal conversion both
        // bounds its mantissa against this and uses it (at scale 0) as the numeric range limit.
        private static readonly BigInteger DecimalMaxMantissa = (BigInteger.One << 96) - BigInteger.One;
        private static readonly BigDecimal DecimalMaxValue = new BigDecimal(DecimalMaxMantissa, 0);

        /// <summary>
        /// Converts this value to a <see cref="decimal"/>, requiring an exact representation. Unlike
        /// <see cref="ToDecimal"/>, this throws rather than silently rounding a value that carries more
        /// precision than <see cref="decimal"/> can hold, for callers validating that a value really does
        /// fit a <see cref="decimal"/> without loss. When the value is representable its scale is preserved
        /// where possible (so <c>2.50</c> round-trips with a scale of 2).
        /// </summary>
        /// <returns>The exact decimal representation.</returns>
        /// <exception cref="OverflowException">Thrown when the value's magnitude is outside the range of <see cref="decimal"/>.</exception>
        /// <exception cref="ArithmeticException">
        /// Thrown when the value is within range but cannot be represented exactly because it has more
        /// significant or fractional digits than <see cref="decimal"/> supports.
        /// </exception>
        public decimal ToDecimalExact()
        {
            if (_unscaledValue.IsZero)
            {
                // Preserve a representable, non-negative scale so a zero such as 0.00 round-trips; an
                // out-of-range scale on a zero is purely cosmetic, so fall back to a plain zero.
                return _scale >= 0 && _scale <= 28
                    ? new decimal(0, 0, 0, false, (byte)_scale)
                    : decimal.Zero;
            }

            // Reject a magnitude genuinely outside decimal's range up front. CompareTo settles this from the
            // adjusted exponents without materializing a power of ten, so an extreme (possibly untrusted)
            // scale throws a clear OverflowException here rather than allocating gigabytes below.
            if (Abs().CompareTo(DecimalMaxValue) > 0)
                throw new OverflowException("The value is outside the range of a decimal.");

            bool isNegative = _unscaledValue.Sign < 0;
            BigInteger magnitude = BigInteger.Abs(_unscaledValue);
            int scale = _scale;

            if (scale < 0)
            {
                // Fold the negative scale into the magnitude (value = magnitude * 10^-scale). The overflow
                // check above bounds the result by decimal.MaxValue, so the power of ten realized here is small.
                magnitude *= PowerOfTen(-scale);
                scale = 0;
            }
            else if (scale > 28)
            {
                // decimal stores at most 28 digits after the point. Remove the surplus low digits; any
                // non-zero digit among them means the value needs more fractional precision than decimal has.
                BigInteger remainder;
                magnitude = BigInteger.DivRem(magnitude, PowerOfTen(scale - 28), out remainder);
                if (!remainder.IsZero)
                    throw new ArithmeticException(
                        "The value cannot be represented as a decimal exactly; it requires more than 28 fractional digits.");
                scale = 28;
            }

            // The mantissa must fit in 96 bits. Removing trailing zeros (lowering the scale) shrinks it
            // without changing the value, which can bring an in-range value with surplus zeros into the limit.
            while (magnitude > DecimalMaxMantissa && scale > 0)
            {
                BigInteger remainder;
                BigInteger quotient = BigInteger.DivRem(magnitude, BigIntegerTen, out remainder);
                if (!remainder.IsZero)
                    break;
                magnitude = quotient;
                scale--;
            }

            // Magnitude is in decimal's numeric range (checked above), so an oversized mantissa here means the
            // value has more significant digits than decimal can hold — a precision loss, not a range overflow.
            if (magnitude > DecimalMaxMantissa)
                throw new ArithmeticException(
                    "The value cannot be represented as a decimal exactly; it has more significant digits than decimal supports.");

            // Pack the magnitude into decimal's three 32-bit words. ToByteArray is little-endian and may carry
            // a trailing 0x00 sign byte; bytes at or beyond index 12 are zero given the 96-bit bound above.
            byte[] bytes = magnitude.ToByteArray();
            int lo = 0, mid = 0, hi = 0;
            for (int i = 0; i < bytes.Length && i < 12; i++)
            {
                int shifted = bytes[i] << ((i % 4) * 8);
                if (i < 4)
                    lo |= shifted;
                else if (i < 8)
                    mid |= shifted;
                else
                    hi |= shifted;
            }

            return new decimal(lo, mid, hi, isNegative, (byte)scale);
        }

        /// <summary>
        /// Converts this value to a <see cref="double"/>. The result is the <see cref="double"/> nearest to
        /// this value, with ties resolved to even (the IEEE 754 default), and a magnitude too large for
        /// <see cref="double"/> saturates to <see cref="double.PositiveInfinity"/> or
        /// <see cref="double.NegativeInfinity"/> rather than throwing.
        /// </summary>
        /// <returns>The double representation.</returns>
        /// <remarks>
        /// The conversion is computed directly from the unscaled value and scale using exact
        /// <see cref="BigInteger"/> arithmetic, so it is correctly rounded on every target. (Routing through
        /// <see cref="double.Parse(string)"/> would not be correctly rounded on the .NET Framework runtime
        /// behind the <c>netstandard2.0</c> target, where the parse can be off by one unit in the last place.)
        /// </remarks>
        public double ToDouble()
        {
            if (_unscaledValue.IsZero)
                return 0.0;

            return BitConverter.Int64BitsToDouble(ToFloatingPointBits(DoubleFormat));
        }

        /// <summary>
        /// Converts this value to a <see cref="float"/>. The result is the <see cref="float"/> nearest to this
        /// value, with ties resolved to even, and a magnitude too large for <see cref="float"/> saturates to
        /// <see cref="float.PositiveInfinity"/> or <see cref="float.NegativeInfinity"/> rather than throwing.
        /// </summary>
        /// <returns>The single-precision representation.</returns>
        /// <remarks>See <see cref="ToDouble"/> for why the conversion is computed directly rather than via a parse.</remarks>
        public float ToSingle()
        {
            if (_unscaledValue.IsZero)
                return 0.0f;

            // BitConverter.Int32BitsToSingle is unavailable on netstandard2.0, so round-trip through bytes,
            // which is supported uniformly across all targets.
            int bits = (int)ToFloatingPointBits(SingleFormat);
            return BitConverter.ToSingle(BitConverter.GetBytes(bits), 0);
        }

        /// <summary>
        /// The IEEE-754 binary format constants that distinguish the <see cref="double"/> and
        /// <see cref="float"/> conversions. Passing these into shared helpers keeps the two conversion
        /// paths on a single implementation so they cannot drift.
        /// </summary>
        private readonly struct FloatingPointFormat
        {
            /// <summary>Number of significand bits, including the implicit leading bit (53 / 24).</summary>
            internal readonly int SignificandBits;
            /// <summary>Number of mantissa bits actually stored in the layout (52 / 23).</summary>
            internal readonly int StoredMantissaBits;
            /// <summary>Exponent bias (1023 / 127).</summary>
            internal readonly int ExponentBias;
            /// <summary>Largest unbiased binary exponent of a finite value; above it saturates to infinity (1023 / 127).</summary>
            internal readonly int MaxExponent;
            /// <summary>Smallest unbiased binary exponent of a normal value (-1022 / -126).</summary>
            internal readonly int MinExponent;
            /// <summary>
            /// Coarse decimal adjusted-exponent guard above which the value certainly overflows to infinity.
            /// Lets the conversion short-circuit before materializing any power of ten (310 / 40).
            /// </summary>
            internal readonly int SaturateHighExponent;
            /// <summary>Coarse decimal adjusted-exponent guard below which the value certainly rounds to zero (-330 / -50).</summary>
            internal readonly int SaturateLowExponent;
            /// <summary>The sign bit as a raw bit mask (bit 63 / bit 31).</summary>
            internal readonly long SignBit;
            /// <summary>The bit pattern of positive infinity: the all-ones exponent field with a zero mantissa.</summary>
            internal readonly long InfinityBits;

            internal FloatingPointFormat(
                int significandBits, int storedMantissaBits, int exponentBias,
                int maxExponent, int minExponent, int saturateHighExponent, int saturateLowExponent)
            {
                SignificandBits = significandBits;
                StoredMantissaBits = storedMantissaBits;
                ExponentBias = exponentBias;
                MaxExponent = maxExponent;
                MinExponent = minExponent;
                SaturateHighExponent = saturateHighExponent;
                SaturateLowExponent = saturateLowExponent;

                // The exponent field occupies the bits between the stored mantissa and the sign bit. Its width
                // is the smallest bit count holding every code: the normal range [minExponent, maxExponent]
                // plus the two reserved codes (zero/subnormal and infinity/NaN).
                int exponentCodes = (maxExponent - minExponent) + 2;
                int exponentBits = 0;
                while ((1 << exponentBits) < exponentCodes)
                    exponentBits++;

                SignBit = 1L << (storedMantissaBits + exponentBits);
                InfinityBits = ((1L << exponentBits) - 1L) << storedMantissaBits;
            }
        }

        // double: 53 significand bits (52 stored), bias 1023, normal exponent range [-1022, 1023].
        private static readonly FloatingPointFormat DoubleFormat = new FloatingPointFormat(53, 52, 1023, 1023, -1022, 310, -330);

        // float: 24 significand bits (23 stored), bias 127, normal exponent range [-126, 127].
        private static readonly FloatingPointFormat SingleFormat = new FloatingPointFormat(24, 23, 127, 127, -126, 40, -50);

        /// <summary>
        /// Rounds this value to the nearest binary floating-point value described by <paramref name="format"/>
        /// and returns its raw IEEE-754 bit pattern (in the low <see cref="FloatingPointFormat.SignificandBits"/>
        /// word for <see cref="float"/>). Shared by <see cref="ToDouble"/> and <see cref="ToSingle"/>; the caller
        /// reinterprets the bits as the concrete floating-point type. Assumes a non-zero value (callers
        /// short-circuit zero to a positive typed zero).
        /// </summary>
        private long ToFloatingPointBits(in FloatingPointFormat format)
        {
            int sign = _unscaledValue.Sign;

            // Short-circuit magnitudes that lie far outside the target's range before materializing any power of
            // ten. The adjusted exponent (~ floor(log10|value|)) bounds the magnitude, so this both avoids
            // needless work and prevents an extreme, possibly attacker-controlled scale from materializing
            // 10^|scale| as gigabytes of digits.
            long adjustedExponent = (long)Precision - _scale;
            if (adjustedExponent > format.SaturateHighExponent)
                return sign < 0 ? (format.SignBit | format.InfinityBits) : format.InfinityBits;
            if (adjustedExponent < format.SaturateLowExponent)
                return sign < 0 ? format.SignBit : 0L;

            BigInteger numerator, denominator;
            RationalForFloatingPoint(out numerator, out denominator);

            BigInteger mantissa;
            int shift;
            ScaleRationalToMantissa(numerator, denominator, format.SignificandBits, format.MinExponent, out mantissa, out shift);
            return AssembleFloatingPointBits(sign, mantissa, shift, format);
        }

        /// <summary>
        /// Expresses the absolute value of this <see cref="BigDecimal"/> as a positive rational
        /// <c>numerator / denominator</c>, the form the floating-point rounding helpers operate on. The sign
        /// is handled separately by the caller. Only reached after the caller has bounded the scale, so the
        /// power of ten materialized here is small.
        /// </summary>
        private void RationalForFloatingPoint(out BigInteger numerator, out BigInteger denominator)
        {
            BigInteger magnitude = BigInteger.Abs(_unscaledValue);
            if (_scale >= 0)
            {
                // value = magnitude / 10^scale.
                numerator = magnitude;
                denominator = PowerOfTen(_scale);
            }
            else
            {
                // value = magnitude * 10^(-scale). The caller's adjusted-exponent guard guarantees -scale is a
                // small positive int here (an int.MinValue scale would have saturated to infinity already).
                numerator = magnitude * PowerOfTen(-_scale);
                denominator = BigInteger.One;
            }
        }

        /// <summary>
        /// Rounds the positive rational <c>numerator / denominator</c> to a binary floating-point mantissa of
        /// <paramref name="precision"/> significand bits, using round-half-to-even. Returns the integer
        /// <paramref name="mantissa"/> and the binary exponent <paramref name="shift"/> of its least-significant
        /// bit, such that the rounded value equals <c>mantissa &#215; 2^shift</c>. The mantissa carries the full
        /// <paramref name="precision"/> bits for a normal result and fewer for a subnormal one (whose
        /// least-significant bit is pinned to <c>minExp - (precision - 1)</c>).
        /// </summary>
        private static void ScaleRationalToMantissa(
            BigInteger numerator,
            BigInteger denominator,
            int precision,
            int minExp,
            out BigInteger mantissa,
            out int shift)
        {
            // floor(log2(value)): start from the bit-length difference (accurate to within one) and correct by
            // direct comparison against neighboring powers of two.
            int e2 = BitLength(numerator) - BitLength(denominator);
            while (CompareToPowerOfTwo(numerator, denominator, e2) < 0)
                e2--;
            while (CompareToPowerOfTwo(numerator, denominator, e2 + 1) >= 0)
                e2++;

            // The least-significant bit of a 'precision'-bit normal mantissa sits at exponent e2-(precision-1).
            // For a subnormal the least-significant bit is pinned, so clamp the shift up to that floor.
            shift = e2 - (precision - 1);
            int minShift = minExp - (precision - 1);
            if (shift < minShift)
                shift = minShift;

            // Scale value by 2^-shift into an integer quotient plus remainder. Dividing by 2^shift never
            // introduces a non-terminating expansion, so the remainder fully captures the discarded fraction.
            BigInteger scaledNumerator, scaledDenominator;
            if (shift >= 0)
            {
                scaledNumerator = numerator;
                scaledDenominator = denominator << shift;
            }
            else
            {
                scaledNumerator = numerator << (-shift);
                scaledDenominator = denominator;
            }

            BigInteger remainder;
            mantissa = BigInteger.DivRem(scaledNumerator, scaledDenominator, out remainder);

            // Round half to even: compare twice the remainder against the divisor; on an exact tie round to
            // the even mantissa.
            int comparison = (remainder << 1).CompareTo(scaledDenominator);
            if (comparison > 0 || (comparison == 0 && !mantissa.IsEven))
                mantissa += BigInteger.One;
        }

        /// <summary>
        /// Assembles the raw IEEE-754 bit pattern described by <paramref name="format"/> from a non-negative
        /// <paramref name="mantissa"/> and the binary exponent <paramref name="shift"/> of its least-significant
        /// bit (value = <c>mantissa &#215; 2^shift</c>), applying <paramref name="sign"/>. Handles the rounding
        /// carry that can push the mantissa to the next power of two, the subnormal range, and saturation to
        /// infinity. Shared by the <see cref="double"/> and <see cref="float"/> conversions; the caller
        /// reinterprets the returned bits as the concrete type.
        /// </summary>
        private static long AssembleFloatingPointBits(int sign, BigInteger mantissa, int shift, in FloatingPointFormat format)
        {
            long signBit = sign < 0 ? format.SignBit : 0L;

            if (mantissa.IsZero)
                return signBit; // signed zero

            int bitLength = BitLength(mantissa);
            int e2 = bitLength - 1 + shift; // floor(log2(value)) of the rounded result

            if (e2 > format.MaxExponent)
                return signBit | format.InfinityBits;

            if (e2 >= format.MinExponent)
            {
                // Normal. Align the mantissa to exactly SignificandBits bits; a rounding carry can leave it one
                // bit wider (mantissa == 2^SignificandBits), and that single shifted-out bit is zero, so the
                // shift is exact.
                int significandBits = format.SignificandBits;
                if (bitLength > significandBits)
                    mantissa >>= bitLength - significandBits;
                else if (bitLength < significandBits)
                    mantissa <<= significandBits - bitLength;

                long storedMantissa = (long)(mantissa & ((BigInteger.One << format.StoredMantissaBits) - BigInteger.One));
                long biasedExponent = (long)(e2 + format.ExponentBias);
                return signBit | (biasedExponent << format.StoredMantissaBits) | storedMantissa;
            }

            // Subnormal: the mantissa already sits at the fixed least-significant-bit position and is below
            // 2^StoredMantissaBits (a carry to that would have produced the smallest normal, taking the branch
            // above).
            return signBit | (long)mantissa;
        }

        /// <summary>
        /// Compares the positive rational <c>numerator / denominator</c> against <c>2^exponent</c>, returning a
        /// negative number, zero, or a positive number as the rational is less than, equal to, or greater than
        /// the power of two. Used to pin down <c>floor(log2(value))</c> without floating-point error.
        /// </summary>
        private static int CompareToPowerOfTwo(BigInteger numerator, BigInteger denominator, int exponent)
        {
            // numerator/denominator vs 2^exponent  <=>  numerator vs denominator * 2^exponent. Shift whichever
            // side keeps both comparands integers.
            if (exponent >= 0)
                return numerator.CompareTo(denominator << exponent);

            return (numerator << (-exponent)).CompareTo(denominator);
        }
    }
}
