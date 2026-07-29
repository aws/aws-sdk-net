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
    public class ConversionTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);

        [Fact]
        public void ImplicitFromInt()
        {
            BigDecimal value = 42;
            Assert.Equal(P("42"), value);
        }

        [Fact]
        public void ImplicitFromLong()
        {
            BigDecimal value = 9000000000L;
            Assert.Equal(P("9000000000"), value);
        }

        [Fact]
        public void ImplicitFromDecimal_Lossless()
        {
            BigDecimal value = 1.250m;
            Assert.Equal(3, value.Scale);
            Assert.Equal(P("1.250"), value);
        }

        [Fact]
        public void ImplicitFromBigInteger()
        {
            BigDecimal value = BigInteger.Parse("123456789012345678901234567890");
            Assert.Equal(P("123456789012345678901234567890"), value);
        }

        [Fact]
        public void ExplicitFromDouble_CapturesExactBinaryValue()
        {
            // 0.5 is exactly representable in binary, so this is clean.
            BigDecimal half = (BigDecimal)0.5;
            Assert.Equal(P("0.5"), half);
        }

        [Fact]
        public void FromDouble_NaN_Throws()
        {
            Assert.Throws<OverflowException>(() => BigDecimal.FromDouble(double.NaN));
        }

        [Fact]
        public void FromDouble_Infinity_Throws()
        {
            Assert.Throws<OverflowException>(() => BigDecimal.FromDouble(double.PositiveInfinity));
        }

        [Theory]
        [InlineData("123.99", 123)]
        [InlineData("-123.99", -123)]
        [InlineData("5", 5)]
        public void ToInt32_TruncatesTowardZero(string input, int expected)
        {
            Assert.Equal(expected, P(input).ToInt32());
        }

        [Fact]
        public void ToInt32_Overflow_Throws()
        {
            Assert.Throws<OverflowException>(() => P("99999999999999999999").ToInt32());
        }

        [Fact]
        public void ToBigInteger_TruncatesFraction()
        {
            Assert.Equal(new BigInteger(7), P("7.9999").ToBigInteger());
        }

        [Fact]
        public void ToDecimal_RoundTrip()
        {
            decimal original = 12345.6789m;
            BigDecimal big = original;
            Assert.Equal(original, big.ToDecimal());
        }

        [Fact]
        public void ExplicitToDouble()
        {
            BigDecimal value = P("1.5");
            Assert.Equal(1.5, (double)value);
        }

        [Theory]
        [InlineData(0.1, "0.1")]
        [InlineData(2.5, "2.5")]
        [InlineData(19.99, "19.99")]
        public void FromDoubleRoundTrip_UsesShortestDecimal(double input, string expected)
        {
            // Unlike FromDouble (which captures the exact binary value), the round-trip factory yields the
            // short decimal the caller most likely intended.
            Assert.Equal(P(expected), BigDecimal.FromDoubleRoundTrip(input));
        }

        [Fact]
        public void FromDoubleRoundTrip_DiffersFromExactBinary()
        {
            Assert.NotEqual(BigDecimal.FromDouble(0.1), BigDecimal.FromDoubleRoundTrip(0.1));
            Assert.Equal(P("0.1"), BigDecimal.FromDoubleRoundTrip(0.1));
        }

        [Fact]
        public void FromSingleRoundTrip_UsesShortestDecimal()
        {
            Assert.Equal(P("0.1"), BigDecimal.FromSingleRoundTrip(0.1f));
        }

        [Theory]
        [InlineData("123", 123)]
        [InlineData("123.000", 123)]
        [InlineData("-45", -45)]
        public void ToInt32Exact_IntegralValue_Succeeds(string input, int expected)
        {
            Assert.Equal(expected, P(input).ToInt32Exact());
        }

        [Fact]
        public void ToInt32Exact_FractionalValue_Throws()
        {
            Assert.Throws<ArithmeticException>(() => P("7.5").ToInt32Exact());
        }

        [Fact]
        public void ToInt32Exact_Overflow_Throws()
        {
            Assert.Throws<OverflowException>(() => P("99999999999999999999").ToInt32Exact());
        }

        [Fact]
        public void ToBigIntegerExact_FractionalValue_Throws()
        {
            Assert.Throws<ArithmeticException>(() => P("7.0001").ToBigIntegerExact());
        }

        [Fact]
        public void ToBigIntegerExact_TrailingZeros_Succeeds()
        {
            Assert.Equal(new BigInteger(250), P("250.00").ToBigIntegerExact());
        }

        [Fact]
        public void ToInt64Exact_IntegralValue_Succeeds()
        {
            Assert.Equal(9000000000L, P("9000000000.0").ToInt64Exact());
        }

        [Theory]
        [InlineData("0")]
        [InlineData("0.00")]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("12345.6789")]
        [InlineData("-12345.6789")]
        [InlineData("2.50")]                                       // trailing-zero scale preserved
        [InlineData("0.0000000000000000000000000001")]            // 28 fractional digits: the decimal limit
        [InlineData("79228162514264337593543950335")]             // decimal.MaxValue
        [InlineData("-79228162514264337593543950335")]            // decimal.MinValue
        [InlineData("7922816251426433759354395.0335")]            // full 29-digit mantissa with a fractional part
        public void ToDecimalExact_RepresentableValue_RoundTrips(string input)
        {
            BigDecimal value = P(input);
            decimal result = value.ToDecimalExact();

            // The exact conversion must not lose any digits: converting back reproduces the original value.
            Assert.Equal(value, (BigDecimal)result);
        }

        [Fact]
        public void ToDecimalExact_PreservesScale()
        {
            // decimal.Scale is unavailable on net472, so read the scale out of the bit representation.
            Assert.Equal(2, DecimalScale(P("2.50").ToDecimalExact()));
            Assert.Equal(0, DecimalScale(P("250").ToDecimalExact()));
        }

        private static int DecimalScale(decimal value) => (decimal.GetBits(value)[3] >> 16) & 0x7F;

        [Fact]
        public void ToDecimalExact_NegativeScaleValue_Succeeds()
        {
            // 1.5E+3 is stored with a negative scale; the exact conversion folds it into the magnitude.
            Assert.Equal(1500m, P("1.5E+3").ToDecimalExact());
        }

        [Theory]
        [InlineData("79228162514264337593543950336")]             // decimal.MaxValue + 1
        [InlineData("-79228162514264337593543950336")]
        [InlineData("1E+400")]
        [InlineData("1E+2000000000")]                             // extreme scale must not materialize digits
        public void ToDecimalExact_OutOfRangeMagnitude_ThrowsOverflow(string input)
        {
            Assert.Throws<OverflowException>(() => P(input).ToDecimalExact());
        }

        [Theory]
        [InlineData("0.00000000000000000000000000001")]           // 29 fractional digits: one past the limit
        [InlineData("1.23456789012345678901234567890123")]        // more significant digits than decimal holds
        [InlineData("0.1234567890123456789012345678901")]
        public void ToDecimalExact_TooMuchPrecision_ThrowsArithmetic(string input)
        {
            Assert.Throws<ArithmeticException>(() => P(input).ToDecimalExact());
        }

        [Fact]
        public void ToDecimalExact_AgreesWithFromDecimalRoundTrip()
        {
            // Every decimal must survive a BigDecimal round-trip exactly through the exact converter.
            foreach (decimal d in new[] { 0m, 1m, -1m, 2.50m, 12345.6789m, decimal.MaxValue, decimal.MinValue, 0.0000000000000000000000000001m })
            {
                BigDecimal big = d;
                Assert.Equal(d, big.ToDecimalExact());
            }
        }

        [Fact]
        public void ToDecimal_TooMuchPrecision_RoundsRatherThanThrows()
        {
            // The lossy converter keeps rounding (contrast with ToDecimalExact, which throws).
            decimal result = P("1.23456789012345678901234567890123").ToDecimal();
            Assert.Equal(1.2345678901234567890123456789m, result);
        }

        [Fact]
        public void ToDouble_OutOfRangeMagnitude_SaturatesToInfinity()
        {
            // A magnitude beyond double's range saturates rather than throwing, uniformly across targets.
            Assert.Equal(double.PositiveInfinity, P("1E+400").ToDouble());
            Assert.Equal(double.NegativeInfinity, P("-1E+400").ToDouble());
        }

        [Fact]
        public void ToSingle_OutOfRangeMagnitude_SaturatesToInfinity()
        {
            Assert.Equal(float.PositiveInfinity, P("1E+40").ToSingle());
            Assert.Equal(float.NegativeInfinity, P("-1E+40").ToSingle());
        }

        // --- ToDouble / ToSingle: correctly-rounded conversion ------------------------------------
        // The conversion is computed directly from the unscaled value and scale in BigInteger arithmetic
        // (round half to even) so it is correctly rounded on every target. On net8.0, double.Parse is itself
        // correctly rounded, so it serves as the oracle: ToDouble must reproduce it exactly, bit for bit.

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("0.1")]
        [InlineData("-0.1")]
        [InlineData("0.2")]
        [InlineData("0.3")]
        [InlineData("1.5")]
        [InlineData("3.141592653589793238462643383279502884")]
        [InlineData("2.718281828459045235360287471352662497")]
        [InlineData("123456789.123456789")]
        [InlineData("0.0000000000000000000001")]
        [InlineData("9007199254740993")]            // 2^53 + 1: not exactly representable, forces rounding
        [InlineData("9007199254740992.5")]           // exact half just below 2^53, exercises round-to-even
        [InlineData("1.7976931348623157E+308")]      // near double.MaxValue
        [InlineData("4.9E-324")]                      // smallest subnormal magnitude
        [InlineData("2.2250738585072014E-308")]      // smallest normal
        [InlineData("2.2250738585072009E-308")]      // largest subnormal
        public void ToDouble_IsCorrectlyRounded(string input)
        {
            double expected = double.Parse(input, NumberStyles.Float, CultureInfo.InvariantCulture);
            Assert.Equal(expected, P(input).ToDouble());
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("-1")]
        [InlineData("0.1")]
        [InlineData("0.3")]
        [InlineData("3.14159265358979")]
        [InlineData("16777217")]                      // 2^24 + 1: not exactly representable as a float
        [InlineData("3.4028235E+38")]                 // near float.MaxValue
        [InlineData("1.4E-45")]                        // smallest subnormal float magnitude
        [InlineData("1.17549435E-38")]                // smallest normal float
        public void ToSingle_IsCorrectlyRounded(string input)
        {
            float expected = float.Parse(input, NumberStyles.Float, CultureInfo.InvariantCulture);
            Assert.Equal(expected, P(input).ToSingle());
        }

        [Fact]
        public void ToDouble_ExhaustiveAgainstParseOracle()
        {
            // Sweep a broad mix of magnitudes, scales, and signs; every result must match the correctly-
            // rounded reference produced by double.Parse on this (net8.0) runtime.
            long[] unscaledSamples = { 1, 2, 5, 7, 9, 13, 99, 12345, 9999999, 1234567890123456789 };
            int[] scaleSamples = { -30, -10, -3, -1, 0, 1, 2, 7, 15, 28, 50, 100, 200 };

            foreach (long u in unscaledSamples)
            {
                foreach (int scale in scaleSamples)
                {
                    foreach (int s in new[] { 1, -1 })
                    {
                        var value = new BigDecimal(new BigInteger(u * s), scale);
                        double expected = double.Parse(value.ToString(CultureInfo.InvariantCulture), NumberStyles.Float, CultureInfo.InvariantCulture);
                        Assert.Equal(expected, value.ToDouble());
                    }
                }
            }
        }

        [Fact]
        public void ToDouble_NegativeZeroScaledValue_PreservesSignWhenUnderflowing()
        {
            // A tiny negative magnitude that rounds to zero keeps the negative sign (-0.0), matching IEEE 754.
            double result = P("-1E-400").ToDouble();
            Assert.Equal(0.0, result);
            // Distinguish -0.0 from +0.0 via the raw bit pattern (double.IsNegative is unavailable on net472).
            Assert.Equal(BitConverter.DoubleToInt64Bits(-0.0), BitConverter.DoubleToInt64Bits(result));
        }

        [Fact]
        public void ToDouble_LargeScaleDoesNotMaterializeDigits()
        {
            // An extreme scale must saturate via the adjusted-exponent guard rather than realize 10^scale.
            Assert.Equal(double.PositiveInfinity, new BigDecimal(BigInteger.One, -2_000_000_000).ToDouble());
            Assert.Equal(0.0, new BigDecimal(BigInteger.One, 2_000_000_000).ToDouble());
        }

        [Fact]
        public void FromDoubleRoundTrip_ResultParsesBackToOriginalDouble()
        {
            // The factory must yield a decimal that round-trips: converting back reproduces the input exactly.
            foreach (double d in new[] { 0.1, 0.2, 0.3, 1.5, 19.99, 123456.789, 1.0 / 3.0, Math.PI, Math.E })
            {
                BigDecimal big = BigDecimal.FromDoubleRoundTrip(d);
                Assert.Equal(d, big.ToDouble());
            }
        }

        [Fact]
        public void FromSingleRoundTrip_ResultParsesBackToOriginalSingle()
        {
            foreach (float f in new[] { 0.1f, 0.2f, 1.5f, 19.99f, 123456.7f, 1.0f / 3.0f })
            {
                BigDecimal big = BigDecimal.FromSingleRoundTrip(f);
                Assert.Equal(f, big.ToSingle());
            }
        }
    }
}
