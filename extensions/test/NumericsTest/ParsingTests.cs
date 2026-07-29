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
    public class ParsingTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        [Theory]
        [InlineData("0", 0, 0)]
        [InlineData("123", 123, 0)]
        [InlineData("-123", -123, 0)]
        [InlineData("1.5", 15, 1)]
        [InlineData("0.0015", 15, 4)]
        [InlineData("007.50", 750, 2)]
        [InlineData("+42", 42, 0)]
        public void Parse_PlainNumbers(string input, int expectedUnscaled, int expectedScale)
        {
            var value = BigDecimal.Parse(input, Inv);
            Assert.Equal(new BigInteger(expectedUnscaled), value.UnscaledValue);
            Assert.Equal(expectedScale, value.Scale);
        }

        [Theory]
        [InlineData("1.5E-10", 15, 11)]
        [InlineData("1.5E+3", 15, -2)]
        [InlineData("1E5", 1, -5)]
        [InlineData("1.5e2", 15, -1)]
        public void Parse_Scientific(string input, int expectedUnscaled, int expectedScale)
        {
            var value = BigDecimal.Parse(input, Inv);
            Assert.Equal(new BigInteger(expectedUnscaled), value.UnscaledValue);
            Assert.Equal(expectedScale, value.Scale);
        }

        [Fact]
        public void Parse_NegativeZeroWithScale()
        {
            var value = BigDecimal.Parse("-0.00", Inv);
            Assert.Equal(0, value.Sign);
            Assert.Equal(2, value.Scale);
            Assert.True(value.IsZero);
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        [InlineData("abc")]
        [InlineData("1.2.3")]
        [InlineData("1.5E")]
        [InlineData("-")]
        [InlineData("1e1.5")]
        public void Parse_Invalid_Throws(string input)
        {
            Assert.Throws<FormatException>(() => BigDecimal.Parse(input, Inv));
        }

        [Fact]
        public void Parse_Null_Throws()
        {
            Assert.Throws<ArgumentNullException>(() => BigDecimal.Parse((string)null, Inv));
        }

        [Theory]
        [InlineData("1.5")]
        [InlineData("abc")]
        [InlineData(null)]
        public void TryParse_NeverThrows(string input)
        {
            BigDecimal result;
            bool success = BigDecimal.TryParse(input, Inv, out result);
            Assert.Equal(input == "1.5", success);
        }

        [Fact]
        public void Parse_CultureAwareDecimalSeparator()
        {
            var german = CultureInfo.GetCultureInfo("de-DE"); // comma decimal separator
            var value = BigDecimal.Parse("1,5", german);
            Assert.Equal(BigDecimal.Parse("1.5", Inv), value);
        }

        [Theory]
        [InlineData("1.5E-10")]
        [InlineData("123.456")]
        [InlineData("-0.0001")]
        [InlineData("1000000")]
        public void RoundTrip_ParseThenToStringThenParse(string input)
        {
            var first = BigDecimal.Parse(input, Inv);
            string text = first.ToString(Inv);
            var second = BigDecimal.Parse(text, Inv);
            Assert.Equal(first, second);
            Assert.Equal(first.Scale, second.Scale);
        }
    }
}
