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
using Amazon.Extensions.Numerics;
using Xunit;

namespace NumericsTest
{
    // Pins the corners where this type's behavior is derived from (or deliberately diverges from)
    // java.math.BigDecimal. These guard against well-meaning "fixes" that would silently reintroduce a
    // Java gotcha or undo a documented divergence. Expected values are cross-checked against Java's
    // BigDecimal output except where a divergence is called out in the test name/comment.
    public class JavaEdgeCaseParityTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);
        private static string S(BigDecimal d) => d.ToString(CultureInfo.InvariantCulture);

        // --- Numeric equality (divergence from Java's scale-sensitive equals) ---------------------

        [Fact]
        public void Equals_NumericNotScaleSensitive_DivergesFromJava()
        {
            // Java: new BigDecimal("2.0").equals(new BigDecimal("2.00")) is FALSE. This type is numeric, so
            // they are equal, Equals is consistent with CompareTo, and the hashes match. Guard the divergence.
            BigDecimal a = P("2.0");
            BigDecimal b = P("2.00");

            Assert.True(a.Equals(b));
            Assert.True(a == b);
            Assert.Equal(0, a.CompareTo(b));
            Assert.Equal(a.GetHashCode(), b.GetHashCode());

            // Storage fidelity is still preserved: the scales themselves remain distinct.
            Assert.Equal(1, a.Scale);
            Assert.Equal(2, b.Scale);
        }

        // --- StripTrailingZeros corners -----------------------------------------------------------

        [Fact]
        public void StripTrailingZeros_IntegerCreatesNegativeScale()
        {
            // 600 strips to unscaled 6 at scale -2 ("6E+2"), matching Java's stripTrailingZeros.
            BigDecimal value = P("600").StripTrailingZeros();
            Assert.Equal(new BigInteger(6), value.UnscaledValue);
            Assert.Equal(-2, value.Scale);
            Assert.Equal("6E+2", S(value));
        }

        [Theory]
        [InlineData("0")]
        [InlineData("0.0")]
        [InlineData("0.000")]
        [InlineData("0E-50")]
        public void StripTrailingZeros_AnyZero_NormalizesToScaleZero(string input)
        {
            // Divergence from older Java (which could yield 0E-n): this type normalizes every zero to scale 0.
            BigDecimal value = P(input).StripTrailingZeros();
            Assert.True(value.IsZero);
            Assert.Equal(0, value.Scale);
        }

        // --- Exact Divide preferred scale, including the negative-scale case ----------------------

        [Theory]
        [InlineData("1", "8", "0.125", 3)]      // preferred scale sA - sB = 0; natural scale 3 wins
        [InlineData("10", "4", "2.5", 1)]
        [InlineData("7.5", "2.5", "3", 0)]      // preferred scale 1-1=0
        [InlineData("100", "10", "10", 0)]
        public void Divide_Exact_PreferredScale(string a, string b, string expected, int expectedScale)
        {
            BigDecimal result = P(a).Divide(P(b));
            Assert.Equal(expected, S(result));
            Assert.Equal(expectedScale, result.Scale);
        }

        [Fact]
        public void Divide_Exact_NegativePreferredScale_IsPreservedNotFolded()
        {
            // 1 / 0.001 = 1000. Java's divide keeps the preferred scale sA - sB = 0 - 3 = -3, i.e. unscaled 1
            // at scale -3, printed "1E+3". The negative scale must NOT be folded into the unscaled value.
            BigDecimal result = P("1").Divide(P("0.001"));
            Assert.Equal(new BigInteger(1), result.UnscaledValue);
            Assert.Equal(-3, result.Scale);
            Assert.Equal("1E+3", S(result));
            Assert.Equal(P("1000"), result); // still numerically 1000
        }

        [Fact]
        public void Divide_WithContext_NegativePreferredScale_IsPreservedNotFolded()
        {
            // 100 / 1 at precision 1: the exact quotient strips toward the preferred scale 0 - 0 = 0, but the
            // single significant digit forces scale -2 ("1E+2"). Java reports the same; the negative scale is
            // preserved rather than folded to unscaled 100 at scale 0.
            BigDecimal result = P("100").Divide(P("1"), new MathContext(1, RoundingMode.HalfUp));
            Assert.Equal(new BigInteger(1), result.UnscaledValue);
            Assert.Equal(-2, result.Scale);
            Assert.Equal("1E+2", S(result));
            Assert.Equal(P("100"), result);
        }

        // --- Pow(int) materialization guard -------------------------------------------------------

        [Fact]
        public void Pow_ModestBaseHugeExponent_ThrowsOverflowNotOom()
        {
            // 10^200000000 would be ~200 million digits, over the 100M materialization cap. The base can come
            // from untrusted input, so this throws a catchable OverflowException rather than exhausting memory.
            Assert.Throws<OverflowException>(() => P("10").Pow(200_000_000));
        }

        [Theory]
        [InlineData("0", 999999999, "0")]   // 0^n is 0, no growth, exempt from the guard
        [InlineData("1", 999999999, "1")]   // 1^n is 1, exempt
        [InlineData("-1", 999999998, "1")]  // (-1)^even is 1, exempt
        public void Pow_BaseMagnitudeZeroOrOne_NotGuardedEvenForHugeExponent(string value, int exponent, string expected)
        {
            Assert.Equal(expected, S(P(value).Pow(exponent)));
        }

        [Fact]
        public void Pow_ReasonableResult_StillSucceeds()
        {
            // A genuinely large but in-bounds result must not be rejected by the guard.
            Assert.Equal(P("1024"), P("2").Pow(10));
        }

        // --- Parse: NumberStyles is ignored; whitespace is trimmed (divergence from Java) ---------

#if NET8_0_OR_GREATER
        [Fact]
        public void Parse_NumberStyles_IsIgnored_ThousandsSeparatorRejected()
        {
            // The NumberStyles overload exists for INumberBase parity but ignores the style. A grouping
            // separator is therefore NOT accepted even when AllowThousands is requested.
            Assert.False(BigDecimal.TryParse("1,000", NumberStyles.AllowThousands, CultureInfo.InvariantCulture, out _));
        }

        [Fact]
        public void Parse_NumberStyles_PlainNumberStillParses()
        {
            BigDecimal result = BigDecimal.Parse("1.5", NumberStyles.Float, CultureInfo.InvariantCulture);
            Assert.Equal(P("1.5"), result);
        }
#endif

        [Theory]
        [InlineData("  1.5  ")]
        [InlineData("\t42\n")]
        public void Parse_SurroundingWhitespace_IsTrimmed_DivergesFromJava(string input)
        {
            // Java's new BigDecimal(String) rejects surrounding whitespace; this type trims it, following the
            // built-in .NET numeric parsers.
            Assert.True(BigDecimal.TryParse(input, CultureInfo.InvariantCulture, out BigDecimal result));
            Assert.Equal(P(input.Trim()), result);
        }
    }
}
