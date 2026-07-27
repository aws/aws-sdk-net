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
    public class EqualityAndComparisonTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);

        [Fact]
        public void Equals_IsNumeric_IgnoresScale()
        {
            Assert.Equal(P("2.0"), P("2.00"));
            Assert.True(P("2.0") == P("2.00"));
            Assert.True(P("2.0").Equals(P("2.00")));
        }

        [Fact]
        public void GetHashCode_EqualForNumericallyEqualDifferentScales()
        {
            Assert.Equal(P("2.0").GetHashCode(), P("2.00").GetHashCode());
            Assert.Equal(P("2").GetHashCode(), P("2.000").GetHashCode());
        }

        [Fact]
        public void GetHashCode_AllZerosEqual()
        {
            Assert.Equal(P("0").GetHashCode(), P("0.00").GetHashCode());
            Assert.Equal(BigDecimal.Zero.GetHashCode(), P("0.0").GetHashCode());
        }

        [Fact]
        public void Equals_DistinctValuesNotEqual()
        {
            Assert.NotEqual(P("2.0"), P("2.01"));
            Assert.True(P("2.0") != P("2.01"));
        }

        [Theory]
        [InlineData("1", "2", -1)]
        [InlineData("2", "1", 1)]
        [InlineData("2.0", "2.00", 0)]
        [InlineData("-5", "5", -1)]
        [InlineData("0.1", "0.10", 0)]
        [InlineData("10", "9.9", 1)]
        public void CompareTo_IsNumeric(string a, string b, int expectedSign)
        {
            Assert.Equal(expectedSign, Math.Sign(P(a).CompareTo(P(b))));
        }

        [Fact]
        public void ComparisonOperators()
        {
            Assert.True(P("1.5") < P("1.6"));
            Assert.True(P("1.6") > P("1.5"));
            Assert.True(P("2.0") <= P("2.00"));
            Assert.True(P("2.0") >= P("2.00"));
        }

        [Fact]
        public void CompareToObject_WrongType_Throws()
        {
            Assert.Throws<ArgumentException>(() => P("1").CompareTo("not a big decimal"));
        }

        [Fact]
        public void CompareToObject_Null_ReturnsPositive()
        {
            Assert.True(P("1").CompareTo((object)null) > 0);
        }

        [Fact]
        public void Equals_ConsistentWithCompareTo()
        {
            var a = P("3.14");
            var b = P("3.140");
            Assert.Equal(a.Equals(b), a.CompareTo(b) == 0);
        }

        // CompareTo settles unequal magnitudes by their adjusted exponents (precision - scale), which is both
        // correct and avoids aligning two wildly different scales. These cases exercise that path, including
        // the negative-sign mirror where the magnitude comparison is inverted.
        [Theory]
        [InlineData("1E-50", "1E50", -1)]   // tiny positive vs huge positive
        [InlineData("1E50", "1E-50", 1)]
        [InlineData("-1E-50", "-1E50", 1)]  // negative: tiny magnitude is the greater (closer to zero) value
        [InlineData("-1E50", "-1E-50", -1)]
        [InlineData("9.9", "100", -1)]      // adjusted exponents 1 and 2 differ despite overlapping digits
        [InlineData("100", "9.9", 1)]
        public void CompareTo_DifferentAdjustedExponents(string a, string b, int expectedSign)
        {
            Assert.Equal(expectedSign, Math.Sign(P(a).CompareTo(P(b))));
        }

        // Equal adjusted exponents force the alignment branch; the comparison must still be exact there.
        [Theory]
        [InlineData("1.5", "1.49", 1)]
        [InlineData("1.49", "1.5", -1)]
        [InlineData("9.99", "9.990", 0)]
        public void CompareTo_EqualAdjustedExponents(string a, string b, int expectedSign)
        {
            Assert.Equal(expectedSign, Math.Sign(P(a).CompareTo(P(b))));
        }

        [Fact]
        public void CompareTo_ZerosWithDifferentScalesAreEqual()
        {
            Assert.Equal(0, P("0E-50").CompareTo(P("0E50")));
            Assert.Equal(0, BigDecimal.Zero.CompareTo(P("0.000")));
        }
    }
}
