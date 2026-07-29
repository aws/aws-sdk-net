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

// The Generic Math surface (INumber<BigDecimal> and friends, span/UTF-8 parsing) exists only on the
// library's net8.0 build, so these tests compile only when the test host targets net8.0 or later. On
// net472 — where the suite runs against the library's netstandard2.0 asset — that API is absent.
#if NET8_0_OR_GREATER

using System;
using System.Globalization;
using System.Numerics;
using Amazon.Extensions.Numerics;
using Xunit;

namespace NumericsTest
{
    public class GenericMathTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;
        private static BigDecimal P(string s) => BigDecimal.Parse(s, Inv);

        // Generic methods constrained on the Generic Math interfaces. These only compile if BigDecimal
        // genuinely satisfies the constraints.
        private static T Sum<T>(T a, T b) where T : INumber<T> => a + b;
        private static T ParseInvariant<T>(string s) where T : IParsable<T> => T.Parse(s, Inv);

        [Fact]
        public void SatisfiesINumberConstraint()
        {
            Assert.Equal(P("5"), Sum<BigDecimal>(P("2.5"), P("2.5")));
        }

        [Fact]
        public void SatisfiesIParsableConstraint()
        {
            Assert.Equal(P("1.5"), ParseInvariant<BigDecimal>("1.5"));
        }

        [Fact]
        public void NumberBaseConstants()
        {
            Assert.Equal(P("0"), BigDecimal.Zero);
            Assert.Equal(P("1"), BigDecimal.One);
            Assert.Equal(P("-1"), BigDecimal.NegativeOne);
        }

        [Fact]
        public void IdentitiesViaGenericConstraint()
        {
            Assert.Equal(BigDecimal.Zero, AdditiveIdentity<BigDecimal>());
            Assert.Equal(BigDecimal.One, MultiplicativeIdentity<BigDecimal>());
        }

        private static T AdditiveIdentity<T>() where T : IAdditiveIdentity<T, T> => T.AdditiveIdentity;
        private static T MultiplicativeIdentity<T>() where T : IMultiplicativeIdentity<T, T> => T.MultiplicativeIdentity;

        [Fact]
        public void RadixIsTen()
        {
            Assert.Equal(10, GetRadix<BigDecimal>());
        }

        private static int GetRadix<T>() where T : INumberBase<T> => T.Radix;

        [Theory]
        [InlineData("5", false)]
        [InlineData("2", true)]
        [InlineData("2.00", true)]   // trailing-zero integer
        [InlineData("2.5", false)]
        public void IsEvenInteger(string input, bool expected)
        {
            Assert.Equal(expected, BigDecimal.IsEvenInteger(P(input)));
        }

        [Theory]
        [InlineData("2.00", true)]
        [InlineData("2.5", false)]
        [InlineData("100", true)]
        public void IsInteger(string input, bool expected)
        {
            Assert.Equal(expected, BigDecimal.IsInteger(P(input)));
        }

        [Fact]
        public void IsNegativeAndPositive()
        {
            Assert.True(BigDecimal.IsNegative(P("-1")));
            Assert.False(BigDecimal.IsNegative(P("0")));
            Assert.True(BigDecimal.IsPositive(P("0")));
            Assert.True(BigDecimal.IsPositive(P("1")));
        }

        [Fact]
        public void FiniteAlwaysTrue_NaNInfinityAlwaysFalse()
        {
            Assert.True(BigDecimal.IsFinite(P("1.5")));
            Assert.False(BigDecimal.IsNaN(P("1.5")));
            Assert.False(BigDecimal.IsInfinity(P("1.5")));
        }

        [Fact]
        public void AbsStatic()
        {
            Assert.Equal(P("2.5"), BigDecimal.Abs(P("-2.5")));
        }

        [Fact]
        public void MinMaxClamp()
        {
            Assert.Equal(P("1"), BigDecimal.Min(P("1"), P("2")));
            Assert.Equal(P("2"), BigDecimal.Max(P("1"), P("2")));
            Assert.Equal(P("5"), BigDecimal.Clamp(P("10"), P("0"), P("5")));
            Assert.Equal(P("0"), BigDecimal.Clamp(P("-3"), P("0"), P("5")));
            Assert.Equal(P("3"), BigDecimal.Clamp(P("3"), P("0"), P("5")));
        }

        [Fact]
        public void CopySign()
        {
            Assert.Equal(P("-5"), BigDecimal.CopySign(P("5"), P("-1")));
            Assert.Equal(P("5"), BigDecimal.CopySign(P("-5"), P("1")));
        }

        [Fact]
        public void MaxMinMagnitude()
        {
            Assert.Equal(P("-10"), BigDecimal.MaxMagnitude(P("3"), P("-10")));
            Assert.Equal(P("3"), BigDecimal.MinMagnitude(P("3"), P("-10")));
        }

        [Fact]
        public void IncrementDecrement()
        {
            var value = P("5.5");
            value++;
            Assert.Equal(P("6.5"), value);
            value--;
            Assert.Equal(P("5.5"), value);
        }

        [Fact]
        public void ModulusOperatorViaGenericMath()
        {
            Assert.Equal(P("1"), P("10") % P("3"));
        }

        // CreateChecked is a default-implemented static interface member, so it is reached through a
        // generic constraint rather than directly on BigDecimal.
        private static T Create<T, TOther>(TOther value)
            where T : INumberBase<T>
            where TOther : INumberBase<TOther> => T.CreateChecked(value);

        [Fact]
        public void CreateChecked_FromVariousTypes()
        {
            Assert.Equal(P("42"), Create<BigDecimal, int>(42));
            Assert.Equal(P("42"), Create<BigDecimal, long>(42L));
            Assert.Equal(BigDecimal.FromDecimal(123.45m), Create<BigDecimal, decimal>(123.45m));
            Assert.Equal(P("0.5"), Create<BigDecimal, double>(0.5)); // 0.5 is exact in binary
        }

        [Fact]
        public void CreateChecked_ToSmallTypeOverflows()
        {
            // Convert a huge BigDecimal out to int via int's generic-math Create*.
            BigDecimal huge = P("99999999999999999999");
            Assert.Throws<OverflowException>(() => int.CreateChecked(huge));
        }

        [Fact]
        public void CreateSaturating_ToSmallTypeClamps()
        {
            BigDecimal huge = P("99999999999999999999");
            Assert.Equal(int.MaxValue, int.CreateSaturating(huge));

            BigDecimal verySmall = P("-99999999999999999999");
            Assert.Equal(int.MinValue, int.CreateSaturating(verySmall));
        }

        [Fact]
        public void ConvertToType_RoundTripIntegral()
        {
            BigDecimal value = P("123.99");
            Assert.Equal(123, int.CreateTruncating(value)); // truncates fractional part
        }

        [Fact]
        public void ConvertToType_BigInteger()
        {
            BigDecimal value = P("123.99");
            Assert.Equal(new BigInteger(123), BigInteger.CreateChecked(value));
        }

        [Fact]
        public void SpanParse_AgreesWithStringParse()
        {
            ReadOnlySpan<char> span = "1.5".AsSpan();
            var fromSpan = BigDecimal.Parse(span, Inv);
            Assert.Equal(P("1.5"), fromSpan);

            Assert.True(BigDecimal.TryParse("2.25".AsSpan(), Inv, out var tryResult));
            Assert.Equal(P("2.25"), tryResult);
        }

        [Fact]
        public void SpanFormat_AgreesWithToString()
        {
            var value = P("123.456");
            Span<char> buffer = stackalloc char[32];
            Assert.True(value.TryFormat(buffer, out int written, default, Inv));
            Assert.Equal(value.ToString(Inv), new string(buffer.Slice(0, written)));
        }

        [Fact]
        public void SpanFormat_ReturnsFalseWhenTooSmall()
        {
            var value = P("123.456");
            Span<char> tiny = stackalloc char[2];
            Assert.False(value.TryFormat(tiny, out int written, default, Inv));
            Assert.Equal(0, written);
        }

        [Fact]
        public void Utf8Parse_AgreesWithStringParse()
        {
            ReadOnlySpan<byte> utf8 = System.Text.Encoding.UTF8.GetBytes("3.14").AsSpan();
            Assert.True(BigDecimal.TryParse(utf8, Inv, out var result));
            Assert.Equal(P("3.14"), result);
        }

        [Fact]
        public void Utf8Format_AgreesWithToString()
        {
            var value = P("123.456");
            Span<byte> buffer = stackalloc byte[32];
            Assert.True(value.TryFormat(buffer, out int written, default, Inv));
            string expected = value.ToString(Inv);
            Assert.Equal(expected, System.Text.Encoding.UTF8.GetString(buffer.Slice(0, written)));
            Assert.Equal(System.Text.Encoding.UTF8.GetByteCount(expected), written);
        }

        [Fact]
        public void Utf8Format_ReturnsFalseWhenTooSmall()
        {
            var value = P("123.456");
            Span<byte> tiny = stackalloc byte[2];
            Assert.False(value.TryFormat(tiny, out int written, default, Inv));
            Assert.Equal(0, written);
        }
    }
}

#endif
