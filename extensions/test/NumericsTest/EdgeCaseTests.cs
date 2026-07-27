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
    public class EdgeCaseTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);

        [Fact]
        public void StripTrailingZeros()
        {
            var value = P("2.500").StripTrailingZeros();
            Assert.Equal(new BigInteger(25), value.UnscaledValue);
            Assert.Equal(1, value.Scale);
        }

        [Fact]
        public void StripTrailingZeros_Zero()
        {
            var value = P("0.000").StripTrailingZeros();
            Assert.Equal(0, value.Scale);
            Assert.True(value.IsZero);
        }

        [Fact]
        public void StripTrailingZeros_IntegerWithTrailingZeros()
        {
            // 1500 with scale 0 strips to unscaled 15, scale -2 (still numerically 1500).
            var value = new BigDecimal(new BigInteger(1500), 0).StripTrailingZeros();
            Assert.Equal(P("1500"), value);
            Assert.Equal(-2, value.Scale);
        }

        [Fact]
        public void MathContext_NegativePrecision_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new MathContext(-1, RoundingMode.HalfUp));
        }

        [Fact]
        public void Multiply_ScaleOverflow_Throws()
        {
            var a = new BigDecimal(BigInteger.One, int.MaxValue);
            var b = new BigDecimal(BigInteger.One, 1);
            Assert.Throws<OverflowException>(() => a.Multiply(b));
        }

        [Fact]
        public void LargeScale_AddAligns()
        {
            var a = new BigDecimal(new BigInteger(1), 100);
            var b = new BigDecimal(new BigInteger(1), 100);
            var result = a.Add(b);
            Assert.Equal(new BigInteger(2), result.UnscaledValue);
            Assert.Equal(100, result.Scale);
        }

        [Fact]
        public void VeryLargeValues_MultiplyExact()
        {
            var a = new BigDecimal(BigInteger.Pow(10, 100), 0);
            var b = new BigDecimal(BigInteger.Pow(10, 100), 0);
            var result = a.Multiply(b);
            Assert.Equal(new BigDecimal(BigInteger.Pow(10, 200), 0), result);
        }

        [Fact]
        public void ZeroDivide_PreservesAsZero()
        {
            var result = P("0.00").Divide(P("5"));
            Assert.True(result.IsZero);
        }

        [Fact]
        public void NegativeZero_EqualsZero()
        {
            Assert.Equal(BigDecimal.Zero, P("-0.00"));
            Assert.Equal(0, P("-0.00").Sign);
        }

        // Precision delegates to DigitCount, which has a ulong fast path and a BigInteger general path that
        // join at ulong.MaxValue. Exercise both sides of every power-of-ten boundary, including the handoff,
        // since an off-by-one there would corrupt every precision-sensitive operation (Round, division).
        [Theory]
        [InlineData("9", 1)]
        [InlineData("10", 2)]
        [InlineData("99", 2)]
        [InlineData("100", 3)]
        [InlineData("999999999999999999", 18)]
        [InlineData("1000000000000000000", 19)]   // 10^18
        [InlineData("9999999999999999999", 19)]
        [InlineData("10000000000000000000", 20)]   // 10^19, within ulong (max is ~1.8e19)
        [InlineData("18446744073709551615", 20)]   // ulong.MaxValue, the last fast-path value
        [InlineData("18446744073709551616", 20)]   // ulong.MaxValue + 1, first general-path value
        [InlineData("99999999999999999999", 20)]
        [InlineData("100000000000000000000", 21)]  // 10^20, general path
        public void Precision_AcrossUInt64Boundary(string unscaled, int expectedPrecision)
        {
            var value = new BigDecimal(BigInteger.Parse(unscaled, CultureInfo.InvariantCulture), 0);
            Assert.Equal(expectedPrecision, value.Precision);
        }

        [Fact]
        public void Precision_MatchesDigitStringLength_AcrossManyMagnitudes()
        {
            // Cross-check DigitCount against the obvious (but allocation-heavy) ground truth: the length of
            // the decimal string. Covers exponentially growing magnitudes through both code paths.
            BigInteger value = BigInteger.One;
            for (int i = 0; i < 60; i++)
            {
                int expected = value.ToString(CultureInfo.InvariantCulture).Length;
                Assert.Equal(expected, new BigDecimal(value, 0).Precision);
                Assert.Equal(expected, new BigDecimal(-value, 0).Precision);
                value = value * 7 + 3; // grows ~0.85 digits per step, hitting varied leading digits
            }
        }
    }
}
