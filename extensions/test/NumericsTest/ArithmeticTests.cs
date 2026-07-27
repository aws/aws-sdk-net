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
    public class ArithmeticTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);

        [Theory]
        [InlineData("1.5", "2.25", "3.75")]
        [InlineData("0.1", "0.2", "0.3")]
        [InlineData("100", "0.001", "100.001")]
        [InlineData("-5", "5", "0")]
        [InlineData("0.7", "0.6", "1.3")]
        public void Add_IsExact(string a, string b, string expected)
        {
            Assert.Equal(P(expected), P(a).Add(P(b)));
        }

        [Fact]
        public void Add_ResultScaleIsMaxOfOperandScales()
        {
            var result = P("1.5").Add(P("2.250"));
            Assert.Equal(3, result.Scale);
        }

        [Theory]
        [InlineData("5", "3", "2")]
        [InlineData("0.3", "0.1", "0.2")]
        [InlineData("1", "1.5", "-0.5")]
        public void Subtract_IsExact(string a, string b, string expected)
        {
            Assert.Equal(P(expected), P(a).Subtract(P(b)));
        }

        [Theory]
        [InlineData("1.5", "2", "3.0")]
        [InlineData("0.1", "0.1", "0.01")]
        [InlineData("-2", "3", "-6")]
        [InlineData("12.34", "0", "0")]
        public void Multiply_IsExact(string a, string b, string expected)
        {
            Assert.Equal(P(expected), P(a).Multiply(P(b)));
        }

        [Fact]
        public void Multiply_ScaleIsSumOfScales()
        {
            var result = P("1.50").Multiply(P("2.5")); // scale 2 + scale 1 = 3
            Assert.Equal(3, result.Scale);
            Assert.Equal(P("3.750"), result);
        }

        [Theory]
        [InlineData("5", "-5")]
        [InlineData("-2.5", "2.5")]
        [InlineData("0", "0")]
        public void Negate_FlipsSign(string input, string expected)
        {
            Assert.Equal(P(expected), P(input).Negate());
        }

        [Theory]
        [InlineData("-2.5", "2.5")]
        [InlineData("2.5", "2.5")]
        [InlineData("0", "0")]
        public void Abs_ReturnsMagnitude(string input, string expected)
        {
            Assert.Equal(P(expected), P(input).Abs());
        }

        [Fact]
        public void Negate_PreservesScale()
        {
            Assert.Equal(3, P("1.500").Negate().Scale);
        }

        [Theory]
        [InlineData("10", "3", "1")]
        [InlineData("10.5", "3", "1.5")]
        [InlineData("-10", "3", "-1")]      // remainder takes the sign of the dividend
        [InlineData("10", "-3", "1")]
        [InlineData("7.5", "2.5", "0")]
        public void Remainder_MatchesJavaSemantics(string a, string b, string expected)
        {
            Assert.Equal(P(expected), P(a).Remainder(P(b)));
        }

        [Fact]
        public void ModulusOperator_DelegatesToRemainder()
        {
            Assert.Equal(P("1"), P("10") % P("3"));
        }

        [Fact]
        public void Remainder_ByZero_Throws()
        {
            Assert.Throws<System.DivideByZeroException>(() => P("10").Remainder(P("0")));
        }
    }
}
