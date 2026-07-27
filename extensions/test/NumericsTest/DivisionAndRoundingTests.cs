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
using Amazon.Extensions.Numerics;
using Xunit;

namespace NumericsTest
{
    public class DivisionAndRoundingTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);
        private static string S(BigDecimal d) => d.ToString(CultureInfo.InvariantCulture);

        [Theory]
        [InlineData("10", "2", "5")]
        [InlineData("1", "8", "0.125")]
        [InlineData("1", "4", "0.25")]
        [InlineData("-1", "8", "-0.125")]
        [InlineData("7.5", "2.5", "3")]
        public void Divide_Exact_Succeeds(string a, string b, string expected)
        {
            Assert.Equal(P(expected), P(a).Divide(P(b)));
        }

        [Fact]
        public void Divide_NonTerminating_Throws()
        {
            Assert.Throws<ArithmeticException>(() => P("1").Divide(P("3")));
        }

        [Fact]
        public void Divide_ByZero_Throws()
        {
            Assert.Throws<DivideByZeroException>(() => P("1").Divide(P("0")));
        }

        [Fact]
        public void Divide_WithContext_RoundsNonTerminating()
        {
            var result = P("1").Divide(P("3"), new MathContext(5, RoundingMode.HalfUp));
            Assert.Equal("0.33333", S(result));
        }

        [Fact]
        public void Divide_WithContext_TwoThirds_RoundsHalfUpLastDigit()
        {
            var result = P("2").Divide(P("3"), new MathContext(5, RoundingMode.HalfUp));
            Assert.Equal("0.66667", S(result));
        }

        // 1.25 rounded to one decimal place under each Half* mode is the canonical tie case.
        [Theory]
        [InlineData(RoundingMode.HalfUp, "1.3")]
        [InlineData(RoundingMode.HalfDown, "1.2")]
        [InlineData(RoundingMode.HalfEven, "1.2")]
        public void SetScale_TieCase_125(RoundingMode mode, string expected)
        {
            Assert.Equal(expected, S(P("1.25").SetScale(1, mode)));
        }

        // 1.35 -> even neighbor is 1.4 for HalfEven.
        [Theory]
        [InlineData(RoundingMode.HalfUp, "1.4")]
        [InlineData(RoundingMode.HalfDown, "1.3")]
        [InlineData(RoundingMode.HalfEven, "1.4")]
        public void SetScale_TieCase_135(RoundingMode mode, string expected)
        {
            Assert.Equal(expected, S(P("1.35").SetScale(1, mode)));
        }

        [Theory]
        [InlineData(RoundingMode.Up, "1.3")]
        [InlineData(RoundingMode.Down, "1.2")]
        [InlineData(RoundingMode.Ceiling, "1.3")]
        [InlineData(RoundingMode.Floor, "1.2")]
        public void SetScale_NonTie_Positive(RoundingMode mode, string expected)
        {
            Assert.Equal(expected, S(P("1.21").SetScale(1, mode)));
        }

        [Theory]
        [InlineData(RoundingMode.Up, "-1.3")]
        [InlineData(RoundingMode.Down, "-1.2")]
        [InlineData(RoundingMode.Ceiling, "-1.2")]
        [InlineData(RoundingMode.Floor, "-1.3")]
        public void SetScale_NonTie_Negative(RoundingMode mode, string expected)
        {
            Assert.Equal(expected, S(P("-1.21").SetScale(1, mode)));
        }

        [Fact]
        public void SetScale_Unnecessary_ThrowsWhenInexact()
        {
            Assert.Throws<ArithmeticException>(() => P("1.21").SetScale(1, RoundingMode.Unnecessary));
        }

        [Fact]
        public void SetScale_Unnecessary_SucceedsWhenExact()
        {
            Assert.Equal("1.20", S(P("1.2").SetScale(2, RoundingMode.Unnecessary)));
        }

        [Fact]
        public void DivideWithScale_RoundsToTargetScale()
        {
            var result = P("10").Divide(P("3"), 4, RoundingMode.HalfUp);
            Assert.Equal("3.3333", S(result));
            Assert.Equal(4, result.Scale);
        }

        [Fact]
        public void Round_ReducesPrecision()
        {
            var result = P("123.456").Round(new MathContext(4, RoundingMode.HalfUp));
            Assert.Equal("123.5", S(result));
        }

        [Fact]
        public void Round_CarryGrowsToNewLeadingDigit()
        {
            // 9.99 to 2 significant digits rounds up to 10.
            var result = P("9.99").Round(new MathContext(2, RoundingMode.HalfUp));
            Assert.Equal(P("10"), result);
        }

        [Fact]
        public void Divide_HalfUp_RoundsUpAtExactHalf()
        {
            // 0.5005 to 3 significant digits is an exact half (0.500|5); HalfUp rounds away from zero.
            var result = P("0.5005").Divide(P("1"), new MathContext(3, RoundingMode.HalfUp));
            Assert.Equal("0.501", S(result));
        }

        [Fact]
        public void Divide_HalfEven_NonTerminatingRoundsToNearest()
        {
            // 100/32 = 3.125 exactly; to 2 significant digits the discarded .025 is below half -> 3.1.
            var result = P("100").Divide(P("32"), new MathContext(2, RoundingMode.HalfEven));
            Assert.Equal("3.1", S(result));
        }

        [Theory]
        [InlineData("1", "8", 5, "0.125")]     // exact quotient is not padded to 0.12500
        [InlineData("10", "2", 5, "5")]        // strips down to the preferred scale (0)
        [InlineData("1", "4", 10, "0.25")]
        [InlineData("5", "8", 6, "0.625")]
        public void Divide_WithContext_ExactQuotient_StripsToPreferredScale(string a, string b, int precision, string expected)
        {
            // When the quotient terminates within the requested precision, the result is reduced toward the
            // preferred scale (this.scale - divisor.scale) rather than padded with trailing zeros, matching
            // Java's divide(divisor, MathContext).
            var result = P(a).Divide(P(b), new MathContext(precision, RoundingMode.HalfUp));
            Assert.Equal(expected, S(result));
        }

        [Fact]
        public void Divide_WithContext_ExactQuotient_KeepsPreferredScaleZeros()
        {
            // Preferred scale is sA - sB = 2 - 1 = 1, so the trailing zero down to scale 1 is retained.
            var result = P("2.50").Divide(P("2.5"), new MathContext(5, RoundingMode.HalfUp));
            Assert.Equal("1.0", S(result));
        }

        [Theory]
        [InlineData("Add", "2.5", "2.5", "5")]
        [InlineData("Subtract", "5.0", "1.0", "4")]
        [InlineData("Multiply", "2.0", "3.0", "6")]
        public void ArithmeticWithContext_RoundsResult(string op, string a, string b, string expected)
        {
            var context = new MathContext(1, RoundingMode.HalfUp);
            var left = P(a);
            var right = P(b);
            BigDecimal result = op switch
            {
                "Add" => left.Add(right, context),
                "Subtract" => left.Subtract(right, context),
                _ => left.Multiply(right, context),
            };
            Assert.Equal(expected, S(result));
        }

        [Fact]
        public void MultiplyWithContext_RoundsToPrecision()
        {
            // 1.23 * 4.56 = 5.6088; rounded to 3 significant digits HalfUp -> 5.61.
            var result = P("1.23").Multiply(P("4.56"), new MathContext(3, RoundingMode.HalfUp));
            Assert.Equal("5.61", S(result));
        }

        [Fact]
        public void NegateAndAbsWithContext_Round()
        {
            var context = new MathContext(2, RoundingMode.HalfUp);
            Assert.Equal("-1.3", S(P("1.25").Negate(context)));
            Assert.Equal("1.3", S(P("-1.25").Abs(context)));
        }
    }
}
