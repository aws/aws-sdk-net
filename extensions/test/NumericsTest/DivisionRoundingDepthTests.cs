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

using System.Globalization;
using Amazon.Extensions.Numerics;
using Xunit;

namespace NumericsTest
{
    // The MathContext division path is the most subtle code in the library: it scales the dividend by a
    // guard digit, divides, and rounds using a sticky bit that captures hidden lower-order digits beyond
    // the computed remainder. These tests exercise the half-way ties (with and without the sticky bit),
    // the HalfEven even/odd selection, and the rounding carry that grows the result past the requested
    // precision. Expected values match Java's BigDecimal.divide(divisor, MathContext).
    public class DivisionRoundingDepthTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);
        private static string S(BigDecimal d) => d.ToString(CultureInfo.InvariantCulture);

        // --- Exact half-way ties: the discarded fraction is exactly half a unit (sticky bit clear) -----

        // 5/4 = 1.25 exactly; rounding to 2 significant digits discards exactly half a unit.
        [Theory]
        [InlineData(RoundingMode.HalfUp, "1.3")]
        [InlineData(RoundingMode.HalfDown, "1.2")]
        [InlineData(RoundingMode.HalfEven, "1.2")] // retained digit 2 is even -> stays
        public void Divide_ExactTie_FiveQuarters(RoundingMode mode, string expected)
        {
            Assert.Equal(expected, S(P("5").Divide(P("4"), new MathContext(2, mode))));
        }

        // 7/4 = 1.75 exactly; HalfEven rounds the odd retained digit 7 up to 8.
        [Theory]
        [InlineData(RoundingMode.HalfUp, "1.8")]
        [InlineData(RoundingMode.HalfDown, "1.7")]
        [InlineData(RoundingMode.HalfEven, "1.8")]
        public void Divide_ExactTie_SevenQuarters(RoundingMode mode, string expected)
        {
            Assert.Equal(expected, S(P("7").Divide(P("4"), new MathContext(2, mode))));
        }

        // --- Non-ties driven by the sticky bit: just past half a unit -----------------------------

        [Fact]
        public void Divide_JustOverHalf_StickyForcesRoundUp_HalfDown()
        {
            // 2/3 = 0.6666...; to 1 significant digit the discarded fraction exceeds half, so even HalfDown
            // rounds up. This only resolves correctly if the sticky bit is honored beyond the guard digit.
            Assert.Equal("0.7", S(P("2").Divide(P("3"), new MathContext(1, RoundingMode.HalfDown))));
        }

        [Fact]
        public void Divide_JustUnderHalf_StickyKeepsDown_HalfUp()
        {
            // 1/3 = 0.3333...; the discarded fraction is below half, so HalfUp still rounds down.
            Assert.Equal("0.3", S(P("1").Divide(P("3"), new MathContext(1, RoundingMode.HalfUp))));
        }

        [Fact]
        public void Divide_StickyBreaksHalfEvenTieAppearance()
        {
            // 4/3 = 1.3333...; to 2 significant digits the true fraction (.33 of a unit) is below half, so it
            // rounds down to 1.3 regardless of mode. Confirms the guard digit + sticky logic doesn't
            // misread a near-tie as a tie.
            Assert.Equal("1.3", S(P("4").Divide(P("3"), new MathContext(2, RoundingMode.HalfEven))));
        }

        // --- Rounding carry that grows the result past the requested precision --------------------

        [Fact]
        public void Divide_RoundingCarry_DoesNotExceedRequestedPrecision()
        {
            // 9.95/1 = 9.95; to 2 significant digits HalfUp carries 99 -> 100. Without trimming the carry
            // the result would be 10.0 (three significant digits), violating the requested precision; the
            // carried digit is a trailing zero, so it is dropped to leave a two-digit result, numerically ten.
            var result = P("9.95").Divide(P("1"), new MathContext(2, RoundingMode.HalfUp));
            Assert.Equal(P("10"), result);
            Assert.True(result.Precision <= 2);
        }

        [Fact]
        public void Divide_RoundingCarry_NonTerminating()
        {
            // 35/36 = 0.9722...; to 1 significant digit it rounds up, carrying 9 -> 10 which trims to a
            // single significant digit: numerically one.
            var result = P("35").Divide(P("36"), new MathContext(1, RoundingMode.HalfUp));
            Assert.Equal(P("1"), result);
            Assert.True(result.Precision <= 1);
        }

        // --- Negative dividend: ties resolve on magnitude, sign is reapplied ----------------------

        [Theory]
        [InlineData(RoundingMode.HalfUp, "-1.3")]
        [InlineData(RoundingMode.HalfEven, "-1.2")]
        [InlineData(RoundingMode.Ceiling, "-1.2")] // toward +inf truncates magnitude
        [InlineData(RoundingMode.Floor, "-1.3")]   // toward -inf grows magnitude
        public void Divide_NegativeExactTie(RoundingMode mode, string expected)
        {
            Assert.Equal(expected, S(P("-5").Divide(P("4"), new MathContext(2, mode))));
        }
    }
}
