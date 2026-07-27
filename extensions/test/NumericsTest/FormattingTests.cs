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
using System.Numerics;
using Amazon.Extensions.Numerics;
using Xunit;

namespace NumericsTest
{
    public class FormattingTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        [Theory]
        [InlineData(123, 0, "123")]
        [InlineData(15, 1, "1.5")]
        [InlineData(15, 4, "0.0015")]
        [InlineData(-15, 1, "-1.5")]
        [InlineData(200, 2, "2.00")]
        [InlineData(0, 0, "0")]
        [InlineData(0, 2, "0.00")]
        public void ToString_Plain(int unscaled, int scale, string expected)
        {
            var value = new BigDecimal(new BigInteger(unscaled), scale);
            Assert.Equal(expected, value.ToString(Inv));
        }

        [Theory]
        [InlineData(15, 11, "1.5E-10")]   // adjusted exponent -10 < -6 => scientific
        [InlineData(15, -2, "1.5E+3")]    // negative scale => scientific
        [InlineData(1, -5, "1E+5")]
        public void ToString_Scientific(int unscaled, int scale, string expected)
        {
            var value = new BigDecimal(new BigInteger(unscaled), scale);
            Assert.Equal(expected, value.ToString(Inv));
        }

        [Fact]
        public void ToPlainString_NeverUsesExponent()
        {
            var value = new BigDecimal(new BigInteger(15), 11);
            Assert.Equal("0.00000000015", value.ToPlainString(Inv));
        }

        [Fact]
        public void ToPlainString_NegativeScale()
        {
            var value = new BigDecimal(new BigInteger(15), -2); // 1500
            Assert.Equal("1500", value.ToPlainString(Inv));
        }

        [Fact]
        public void ToString_AtScientificBoundary_StaysPlain()
        {
            // adjusted exponent exactly -6 stays in plain form.
            var value = new BigDecimal(new BigInteger(1), 6); // 0.000001, adjusted exponent -6
            Assert.Equal("0.000001", value.ToString(Inv));
        }
    }
}
