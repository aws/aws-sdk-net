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

#if NET8_0_OR_GREATER

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace Amazon.Extensions.Numerics
{
    // .NET Generic Math support. This partial declaration is compiled only for net8.0 (and any later
    // target, via NET8_0_OR_GREATER) because the System.Numerics math interfaces rely on static
    // abstract interface members, which do not exist on netstandard2.0. The interface list here is
    // merged by the compiler with the primary declaration in BigDecimal.cs.
    public readonly partial struct BigDecimal
        : INumber<BigDecimal>,
          ISignedNumber<BigDecimal>
    {
        // --- Identities and constants -------------------------------------------------------------

        /// <summary>Gets the additive identity (<see cref="Zero"/>).</summary>
        static BigDecimal IAdditiveIdentity<BigDecimal, BigDecimal>.AdditiveIdentity => Zero;

        /// <summary>Gets the multiplicative identity (<see cref="One"/>).</summary>
        static BigDecimal IMultiplicativeIdentity<BigDecimal, BigDecimal>.MultiplicativeIdentity => One;

        /// <summary>Gets the value <c>-1</c> for the type.</summary>
        public static BigDecimal NegativeOne { get; } = new BigDecimal(BigInteger.MinusOne, 0);

        /// <summary>Gets the radix (base) for the type, which is always <c>10</c>.</summary>
        static int INumberBase<BigDecimal>.Radix => 10;

        // --- Increment / decrement ----------------------------------------------------------------

        /// <summary>Increments a value by one.</summary>
        public static BigDecimal operator ++(BigDecimal value) => value.Add(One);

        /// <summary>Decrements a value by one.</summary>
        public static BigDecimal operator --(BigDecimal value) => value.Subtract(One);

        // --- Abs / sign / magnitude ---------------------------------------------------------------

        /// <summary>Computes the absolute value of <paramref name="value"/>.</summary>
        public static BigDecimal Abs(BigDecimal value) => value.Abs();

        /// <summary>Returns the sign of <paramref name="value"/>: -1, 0, or +1.</summary>
        // Explicit because the instance property BigDecimal.Sign already uses this name.
        static int INumber<BigDecimal>.Sign(BigDecimal value) => value.Sign;

        /// <summary>Returns the value with the greater magnitude (absolute value).</summary>
        public static BigDecimal MaxMagnitude(BigDecimal x, BigDecimal y)
        {
            int comparison = x.Abs().CompareTo(y.Abs());
            if (comparison > 0)
                return x;
            if (comparison < 0)
                return y;

            // Equal magnitude: prefer the positive value, matching the built-in numeric types.
            return x.Sign < 0 ? y : x;
        }

        /// <summary>Returns the value with the greater magnitude. Equivalent to <see cref="MaxMagnitude"/> for this finite type.</summary>
        public static BigDecimal MaxMagnitudeNumber(BigDecimal x, BigDecimal y) => MaxMagnitude(x, y);

        /// <summary>Returns the value with the lesser magnitude (absolute value).</summary>
        public static BigDecimal MinMagnitude(BigDecimal x, BigDecimal y)
        {
            int comparison = x.Abs().CompareTo(y.Abs());
            if (comparison < 0)
                return x;
            if (comparison > 0)
                return y;

            return x.Sign < 0 ? x : y;
        }

        /// <summary>Returns the value with the lesser magnitude. Equivalent to <see cref="MinMagnitude"/> for this finite type.</summary>
        public static BigDecimal MinMagnitudeNumber(BigDecimal x, BigDecimal y) => MinMagnitude(x, y);

        // --- Comparison helpers (INumber) ---------------------------------------------------------

        /// <summary>Returns the greater of two values.</summary>
        public static BigDecimal Max(BigDecimal x, BigDecimal y) => x.CompareTo(y) >= 0 ? x : y;

        /// <summary>Returns the greater of two values. Equivalent to <see cref="Max(BigDecimal, BigDecimal)"/> for this finite type.</summary>
        public static BigDecimal MaxNumber(BigDecimal x, BigDecimal y) => Max(x, y);

        /// <summary>Returns the lesser of two values.</summary>
        public static BigDecimal Min(BigDecimal x, BigDecimal y) => x.CompareTo(y) <= 0 ? x : y;

        /// <summary>Returns the lesser of two values. Equivalent to <see cref="Min(BigDecimal, BigDecimal)"/> for this finite type.</summary>
        public static BigDecimal MinNumber(BigDecimal x, BigDecimal y) => Min(x, y);

        /// <summary>Clamps <paramref name="value"/> to the inclusive range [<paramref name="min"/>, <paramref name="max"/>].</summary>
        public static BigDecimal Clamp(BigDecimal value, BigDecimal min, BigDecimal max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("min cannot be greater than max.", nameof(min));

            if (value.CompareTo(min) < 0)
                return min;
            if (value.CompareTo(max) > 0)
                return max;
            return value;
        }

        /// <summary>Copies the sign of <paramref name="sign"/> onto the magnitude of <paramref name="value"/>.</summary>
        public static BigDecimal CopySign(BigDecimal value, BigDecimal sign)
        {
            BigDecimal magnitude = value.Abs();
            return sign.Sign < 0 ? magnitude.Negate() : magnitude;
        }

        // --- Is* predicates -----------------------------------------------------------------------

        /// <summary>Determines whether a value is in its canonical representation. Always <c>true</c>.</summary>
        public static bool IsCanonical(BigDecimal value) => true;

        /// <summary>Determines whether a value is a complex number. Always <c>false</c>.</summary>
        public static bool IsComplexNumber(BigDecimal value) => false;

        /// <summary>Determines whether a value represents an even integral number.</summary>
        public static bool IsEvenInteger(BigDecimal value)
        {
            if (!IsInteger(value))
                return false;
            return (value.ToBigInteger() % 2).IsZero;
        }

        /// <summary>Determines whether a value represents an odd integral number.</summary>
        public static bool IsOddInteger(BigDecimal value)
        {
            if (!IsInteger(value))
                return false;
            return !(value.ToBigInteger() % 2).IsZero;
        }

        /// <summary>Determines whether a value is finite. Always <c>true</c> for <see cref="BigDecimal"/>.</summary>
        public static bool IsFinite(BigDecimal value) => true;

        /// <summary>Determines whether a value is imaginary. Always <c>false</c>.</summary>
        public static bool IsImaginaryNumber(BigDecimal value) => false;

        /// <summary>Determines whether a value is infinite. Always <c>false</c> for <see cref="BigDecimal"/>.</summary>
        public static bool IsInfinity(BigDecimal value) => false;

        /// <summary>Determines whether a value represents an integral number (no fractional part).</summary>
        public static bool IsInteger(BigDecimal value)
        {
            if (value._scale <= 0)
                return true;

            // A positive scale still represents an integer when every fractional digit is zero, e.g. 2.00.
            return value.StripTrailingZeros()._scale <= 0;
        }

        /// <summary>Determines whether a value is NaN. Always <c>false</c> for <see cref="BigDecimal"/>.</summary>
        public static bool IsNaN(BigDecimal value) => false;

        /// <summary>Determines whether a value is negative.</summary>
        public static bool IsNegative(BigDecimal value) => value.Sign < 0;

        /// <summary>Determines whether a value is negative infinity. Always <c>false</c>.</summary>
        public static bool IsNegativeInfinity(BigDecimal value) => false;

        /// <summary>Determines whether a value is normal (non-zero). </summary>
        public static bool IsNormal(BigDecimal value) => !value.IsZero;

        /// <summary>Determines whether a value is positive (zero or greater).</summary>
        public static bool IsPositive(BigDecimal value) => value.Sign >= 0;

        /// <summary>Determines whether a value is positive infinity. Always <c>false</c>.</summary>
        public static bool IsPositiveInfinity(BigDecimal value) => false;

        /// <summary>Determines whether a value represents a real number. Always <c>true</c>.</summary>
        public static bool IsRealNumber(BigDecimal value) => true;

        /// <summary>Determines whether a value is subnormal. Always <c>false</c>.</summary>
        public static bool IsSubnormal(BigDecimal value) => false;

        /// <summary>Determines whether a value is zero.</summary>
        // Explicit because the instance property BigDecimal.IsZero already uses this name.
        static bool INumberBase<BigDecimal>.IsZero(BigDecimal value) => value.IsZero;

        // --- Conversions (INumberBase) ------------------------------------------------------------

        static bool INumberBase<BigDecimal>.TryConvertFromChecked<TOther>(TOther value, out BigDecimal result)
            => TryConvertFrom(value, out result);

        static bool INumberBase<BigDecimal>.TryConvertFromSaturating<TOther>(TOther value, out BigDecimal result)
            => TryConvertFrom(value, out result);

        static bool INumberBase<BigDecimal>.TryConvertFromTruncating<TOther>(TOther value, out BigDecimal result)
            => TryConvertFrom(value, out result);

        // BigDecimal is unbounded, so converting any finite value INTO a BigDecimal never overflows,
        // saturates, or truncates; the three "from" variants are therefore identical.
        private static bool TryConvertFrom<TOther>(TOther value, out BigDecimal result)
        {
            switch (value)
            {
                case byte v: result = new BigDecimal(v); return true;
                case sbyte v: result = new BigDecimal(v); return true;
                case short v: result = new BigDecimal(v); return true;
                case ushort v: result = new BigDecimal(v); return true;
                case int v: result = new BigDecimal(v); return true;
                case uint v: result = new BigDecimal(v); return true;
                case long v: result = new BigDecimal(v); return true;
                case ulong v: result = (BigDecimal)v; return true;
                case decimal v: result = FromDecimal(v); return true;
                case BigInteger v: result = new BigDecimal(v, 0); return true;
                case float v:
                    if (float.IsNaN(v) || float.IsInfinity(v)) { result = Zero; return false; }
                    result = FromDouble(v); return true;
                case double v:
                    if (double.IsNaN(v) || double.IsInfinity(v)) { result = Zero; return false; }
                    result = FromDouble(v); return true;
                default:
                    result = Zero;
                    return false;
            }
        }

        static bool INumberBase<BigDecimal>.TryConvertToChecked<TOther>(BigDecimal value, [MaybeNullWhen(false)] out TOther result)
            => TryConvertTo(value, ConversionMode.Checked, out result);

        static bool INumberBase<BigDecimal>.TryConvertToSaturating<TOther>(BigDecimal value, [MaybeNullWhen(false)] out TOther result)
            => TryConvertTo(value, ConversionMode.Saturating, out result);

        static bool INumberBase<BigDecimal>.TryConvertToTruncating<TOther>(BigDecimal value, [MaybeNullWhen(false)] out TOther result)
            => TryConvertTo(value, ConversionMode.Truncating, out result);

        private enum ConversionMode { Checked, Saturating, Truncating }

        private static bool TryConvertTo<TOther>(BigDecimal value, ConversionMode mode, [MaybeNullWhen(false)] out TOther result)
            where TOther : INumberBase<TOther>
        {
            // Convert the integer part (truncated toward zero) for integral targets; pass the full value
            // through for the real-number targets. Delegate range handling to TOther's own Create* APIs so
            // each target's MinValue/MaxValue and saturation rules are honored.
            Type target = typeof(TOther);

            if (target == typeof(decimal))
            {
                result = (TOther)(object)value.ToDecimal();
                return true;
            }
            if (target == typeof(double))
            {
                result = (TOther)(object)value.ToDouble();
                return true;
            }
            if (target == typeof(float))
            {
                result = (TOther)(object)value.ToSingle();
                return true;
            }
            if (target == typeof(BigInteger))
            {
                result = (TOther)(object)value.ToBigInteger();
                return true;
            }

            // Integral targets: truncate to an integer, then hand off to the target's generic-math Create*
            // so out-of-range behavior matches the requested mode.
            if (target == typeof(byte) || target == typeof(sbyte) ||
                target == typeof(short) || target == typeof(ushort) ||
                target == typeof(int) || target == typeof(uint) ||
                target == typeof(long) || target == typeof(ulong) ||
                target == typeof(nint) || target == typeof(nuint) ||
                target == typeof(Int128) || target == typeof(UInt128))
            {
                BigInteger integer = value.ToBigInteger();
                return TryCreateInteger(integer, mode, out result);
            }

            result = default;
            return false;
        }

        private static bool TryCreateInteger<TOther>(BigInteger integer, ConversionMode mode, [MaybeNullWhen(false)] out TOther result)
            where TOther : INumberBase<TOther>
        {
            result = mode switch
            {
                ConversionMode.Checked => TOther.CreateChecked(integer),
                ConversionMode.Saturating => TOther.CreateSaturating(integer),
                _ => TOther.CreateTruncating(integer),
            };
            return true;
        }

        // --- Parsing (IParsable / ISpanParsable / INumberBase) ------------------------------------

        /// <summary>Parses a span of characters into a <see cref="BigDecimal"/>.</summary>
        public static BigDecimal Parse(ReadOnlySpan<char> s, IFormatProvider provider) =>
            Parse(s.ToString(), provider);

        /// <summary>
        /// Parses a span of characters into a <see cref="BigDecimal"/>. The <paramref name="style"/>
        /// argument is <b>ignored</b>; parsing always uses the same grammar as <see cref="Parse(string, IFormatProvider)"/>
        /// (optional sign, decimal digits, and an optional exponent), which is the format
        /// <see cref="BigDecimal"/> values round-trip through. Styles such as
        /// <see cref="NumberStyles.AllowThousands"/> or <see cref="NumberStyles.AllowParentheses"/> are not honored.
        /// </summary>
        public static BigDecimal Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider) =>
            Parse(s.ToString(), provider);

        /// <summary>
        /// Parses a string into a <see cref="BigDecimal"/>. The <paramref name="style"/> argument is
        /// <b>ignored</b>; parsing always uses the same grammar as <see cref="Parse(string, IFormatProvider)"/>
        /// (optional sign, decimal digits, and an optional exponent), which is the format
        /// <see cref="BigDecimal"/> values round-trip through. Styles such as
        /// <see cref="NumberStyles.AllowThousands"/> or <see cref="NumberStyles.AllowParentheses"/> are not honored.
        /// </summary>
        public static BigDecimal Parse(string s, NumberStyles style, IFormatProvider provider) =>
            Parse(s, provider);

        /// <summary>Attempts to parse a span of characters into a <see cref="BigDecimal"/>.</summary>
        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, out BigDecimal result) =>
            TryParse(s.ToString(), provider, out result);

        /// <summary>
        /// Attempts to parse a span of characters into a <see cref="BigDecimal"/>. The
        /// <paramref name="style"/> argument is <b>ignored</b>; see <see cref="Parse(string, NumberStyles, IFormatProvider)"/>.
        /// </summary>
        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, out BigDecimal result) =>
            TryParse(s.ToString(), provider, out result);

        /// <summary>
        /// Attempts to parse a string into a <see cref="BigDecimal"/>. The <paramref name="style"/>
        /// argument is <b>ignored</b>; see <see cref="Parse(string, NumberStyles, IFormatProvider)"/>.
        /// </summary>
        public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out BigDecimal result) =>
            TryParse(s, provider, out result);

        // --- UTF-8 parsing (IUtf8SpanParsable) ----------------------------------------------------

        /// <summary>Parses a span of UTF-8 bytes into a <see cref="BigDecimal"/>.</summary>
        public static BigDecimal Parse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider) =>
            Parse(Encoding.UTF8.GetString(utf8Text), provider);

        /// <summary>Attempts to parse a span of UTF-8 bytes into a <see cref="BigDecimal"/>.</summary>
        public static bool TryParse(ReadOnlySpan<byte> utf8Text, IFormatProvider provider, out BigDecimal result) =>
            TryParse(Encoding.UTF8.GetString(utf8Text), provider, out result);

        // --- Formatting (ISpanFormattable / IUtf8SpanFormattable) ---------------------------------

        /// <summary>Tries to format this value into the provided span of characters.</summary>
        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            string text = ToString(provider);
            if (text.Length <= destination.Length)
            {
                text.AsSpan().CopyTo(destination);
                charsWritten = text.Length;
                return true;
            }

            charsWritten = 0;
            return false;
        }

        /// <summary>Tries to format this value as UTF-8 into the provided span of bytes.</summary>
        public bool TryFormat(Span<byte> utf8Destination, out int bytesWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            // Encode straight into the caller's span rather than through an intermediate byte[]; GetByteCount
            // does not allocate, so the fit check stays allocation-free for this span-based API.
            string text = ToString(provider);
            if (Encoding.UTF8.GetByteCount(text) <= utf8Destination.Length)
            {
                bytesWritten = Encoding.UTF8.GetBytes(text, utf8Destination);
                return true;
            }

            bytesWritten = 0;
            return false;
        }
    }
}

#endif
