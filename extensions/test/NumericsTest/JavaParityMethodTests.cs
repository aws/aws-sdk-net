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
    // Coverage for the methods added for parity with java.math.BigDecimal: Pow, MovePointLeft/Right,
    // ScaleByPowerOfTen, the Divide(divisor, RoundingMode) convenience overload, DivideToIntegralValue,
    // DivideAndRemainder, and the instance Min/Max. Expected values match Java's BigDecimal output.
    public class JavaParityMethodTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);
        private static string S(BigDecimal d) => d.ToString(CultureInfo.InvariantCulture);

        // --- Pow(int) -----------------------------------------------------------------------------

        [Theory]
        [InlineData("2", 0, "1")]        // x^0 is one for every x
        [InlineData("0", 0, "1")]        // including zero, matching Java
        [InlineData("2", 10, "1024")]
        [InlineData("-2", 3, "-8")]
        [InlineData("1.1", 2, "1.21")]   // scale is this.scale * n
        [InlineData("2.00", 3, "8.000000")]
        public void Pow_Exact(string value, int exponent, string expected)
        {
            Assert.Equal(expected, S(P(value).Pow(exponent)));
        }

        [Fact]
        public void Pow_ScalePreservesExponentMultiple()
        {
            Assert.Equal(6, P("2.00").Pow(3).Scale);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(1000000000)]
        public void Pow_ExponentOutOfRange_Throws(int exponent)
        {
            Assert.Throws<ArithmeticException>(() => P("2").Pow(exponent));
        }

        [Fact]
        public void Pow_ScaleOverflow_Throws()
        {
            var value = new BigDecimal(System.Numerics.BigInteger.One, int.MaxValue);
            Assert.Throws<OverflowException>(() => value.Pow(2));
        }

        // --- Pow(int, MathContext) ----------------------------------------------------------------

        [Fact]
        public void Pow_WithContext_NegativeExponent_ComputesReciprocal()
        {
            Assert.Equal("0.5", S(P("2").Pow(-1, new MathContext(5, RoundingMode.HalfUp))));
        }

        [Fact]
        public void Pow_WithContext_NegativeExponent_Rounds()
        {
            // 3^-2 = 1/9 = 0.1111... rounded to 5 significant digits.
            Assert.Equal("0.11111", S(P("3").Pow(-2, new MathContext(5, RoundingMode.HalfUp))));
        }

        [Fact]
        public void Pow_WithContext_PositiveExponent()
        {
            Assert.Equal(P("1000"), P("10").Pow(3, new MathContext(2)));
        }

        [Fact]
        public void Pow_WithContext_ExponentDigitsExceedPrecision_Throws()
        {
            // |exponent| has 3 digits but the context precision is only 2 (the ANSI X3.274 rule).
            Assert.Throws<ArithmeticException>(() => P("2").Pow(100, new MathContext(2, RoundingMode.HalfUp)));
        }

        [Fact]
        public void Pow_WithUnlimitedContext_DefersToExact()
        {
            Assert.Equal("1024", S(P("2").Pow(10, MathContext.Unlimited)));
        }

        // --- MovePointLeft / MovePointRight -------------------------------------------------------

        [Theory]
        [InlineData("1.5", 2, "0.015")]
        [InlineData("1.5", 0, "1.5")]
        [InlineData("1.5", -2, "150")]   // a negative shift moves the point right
        [InlineData("123", 5, "0.00123")]
        public void MovePointLeft_Cases(string value, int n, string expected)
        {
            Assert.Equal(expected, S(P(value).MovePointLeft(n)));
        }

        [Theory]
        [InlineData("1.5", 2, "150")]
        [InlineData("1.5", 1, "15")]
        [InlineData("1.5", -2, "0.015")] // a negative shift moves the point left
        [InlineData("123", 2, "12300")]
        public void MovePointRight_Cases(string value, int n, string expected)
        {
            Assert.Equal(expected, S(P(value).MovePointRight(n)));
        }

        [Fact]
        public void MovePoint_ResultScaleNeverNegative()
        {
            // Moving 1.5 right by 2 yields 150 at scale 0, not unscaled 15 at scale -1.
            Assert.Equal(0, P("1.5").MovePointRight(2).Scale);
            Assert.Equal(0, P("1.5").MovePointLeft(-2).Scale);
        }

        [Fact]
        public void MovePointLeft_ScaleOverflow_Throws()
        {
            var value = new BigDecimal(System.Numerics.BigInteger.One, int.MaxValue);
            Assert.Throws<OverflowException>(() => value.MovePointLeft(1));
        }

        // --- ScaleByPowerOfTen --------------------------------------------------------------------

        [Fact]
        public void ScaleByPowerOfTen_OnlyShiftsScale()
        {
            // Unlike MovePoint*, the unscaled value is untouched, so the scale may go negative.
            var result = P("1.5").ScaleByPowerOfTen(2);
            Assert.Equal(P("150"), result);
            Assert.Equal(-1, result.Scale);
        }

        // --- Divide(divisor, RoundingMode) --------------------------------------------------------

        [Fact]
        public void Divide_RoundingMode_UsesDividendScale()
        {
            // The convenience overload rounds to this value's own scale (2 here), matching Java.
            var result = P("10.00").Divide(P("3"), RoundingMode.HalfUp);
            Assert.Equal("3.33", S(result));
            Assert.Equal(2, result.Scale);
        }

        // --- DivideToIntegralValue ----------------------------------------------------------------

        [Theory]
        [InlineData("7", "2", "3")]
        [InlineData("-7", "2", "-3")]    // truncates toward zero
        [InlineData("7.5", "2", "3.0")]  // preferred scale is this.scale - divisor.scale = 1
        [InlineData("11", "3", "3")]
        public void DivideToIntegralValue_Cases(string a, string b, string expected)
        {
            Assert.Equal(expected, S(P(a).DivideToIntegralValue(P(b))));
        }

        [Fact]
        public void DivideToIntegralValue_DividendSmaller_IsZeroAtPreferredScale()
        {
            var result = P("1").DivideToIntegralValue(P("3"));
            Assert.True(result.IsZero);
        }

        [Fact]
        public void DivideToIntegralValue_ByZero_Throws()
        {
            Assert.Throws<DivideByZeroException>(() => P("1").DivideToIntegralValue(P("0")));
        }

        // --- DivideAndRemainder -------------------------------------------------------------------

        [Theory]
        [InlineData("11", "3", "3", "2")]
        [InlineData("-11", "3", "-3", "-2")] // remainder takes the sign of the dividend
        [InlineData("7.5", "2", "3.0", "1.5")]
        public void DivideAndRemainder_Cases(string a, string b, string expectedQuotient, string expectedRemainder)
        {
            BigDecimal remainder;
            var quotient = P(a).DivideAndRemainder(P(b), out remainder);
            Assert.Equal(expectedQuotient, S(quotient));
            Assert.Equal(expectedRemainder, S(remainder));
        }

        [Fact]
        public void DivideAndRemainder_RemainderMatchesRemainderMethod()
        {
            BigDecimal remainder;
            P("11").DivideAndRemainder(P("3"), out remainder);
            Assert.Equal(P("11").Remainder(P("3")), remainder);
        }

        // --- Min / Max ----------------------------------------------------------------------------

        [Fact]
        public void Max_ReturnsGreater()
        {
            Assert.Equal(P("3"), P("2.0").Max(P("3")));
        }

        [Fact]
        public void Min_ReturnsLesser_PreservingScaleOfChosenOperand()
        {
            var result = P("2.0").Min(P("3"));
            Assert.Equal("2.0", S(result));
        }

        [Fact]
        public void MinMax_EqualMagnitudeDifferentScale_ReturnThis()
        {
            // 2.0 and 2.00 are numerically equal; Max/Min return the receiver, preserving its scale.
            Assert.Equal("2.0", S(P("2.0").Max(P("2.00"))));
            Assert.Equal("2.0", S(P("2.0").Min(P("2.00"))));
        }
    }
}
