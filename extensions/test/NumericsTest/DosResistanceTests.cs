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
    // A BigDecimal can be parsed or constructed cheaply with an extreme scale: "1E-2000000000" is only a few
    // bytes on the wire yet stores a unscaled value of 1 with a two-billion scale. Without a backstop, the
    // first operation that materializes 10^scale as actual digits — scale alignment, an integer/decimal
    // conversion, SetScale, MovePoint, or plain-string formatting — allocates gigabytes and terminates the
    // process with an OutOfMemoryException. These tests assert those paths now fail fast with a catchable
    // OverflowException instead. (This is the resource-exhaustion class of issue the Java/JSON ecosystem
    // hardened at the deserialization boundary; .NET diverges from Java here intentionally.)
    public class DosResistanceTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);

        // An extreme scale parses cheaply; the cost is only paid when an operation realizes the digits.
        private static BigDecimal HugePositiveScale => P("1E-2000000000"); // scale = +2,000,000,000
        private static BigDecimal HugeNegativeScale => P("1E2000000000");  // scale = -2,000,000,000

        [Fact]
        public void Parse_ExtremeScale_DoesNotThrow()
        {
            // Parsing stays cheap and Java-faithful: storing the value must not eagerly materialize digits.
            Assert.Equal(2000000000, HugePositiveScale.Scale);
            Assert.Equal(-2000000000, HugeNegativeScale.Scale);
        }

        [Fact]
        public void ToPlainString_HugePositiveScale_ThrowsOverflow()
        {
            Assert.Throws<OverflowException>(() => HugePositiveScale.ToPlainString(CultureInfo.InvariantCulture));
        }

        [Fact]
        public void ToPlainString_HugeNegativeScale_ThrowsOverflow()
        {
            Assert.Throws<OverflowException>(() => HugeNegativeScale.ToPlainString(CultureInfo.InvariantCulture));
        }

        [Fact]
        public void ToBigInteger_HugeNegativeScale_ThrowsOverflow()
        {
            // ToBigInteger multiplies the unscaled value by 10^(-scale) for a negative scale.
            Assert.Throws<OverflowException>(() => HugeNegativeScale.ToBigInteger());
        }

        [Fact]
        public void ToDecimal_HugeNegativeScale_ThrowsOverflow()
        {
            Assert.Throws<OverflowException>(() => HugeNegativeScale.ToDecimal());
        }

        [Fact]
        public void Add_ExtremeScaleDifference_ThrowsOverflow()
        {
            // Aligning a +2e9 scale with a -2e9 scale would multiply a mantissa by 10^4e9.
            Assert.Throws<OverflowException>(() => HugePositiveScale.Add(HugeNegativeScale));
        }

        [Fact]
        public void CompareTo_ExtremeScaleDifference_ComparesWithoutMaterializing()
        {
            // CompareTo settles unequal magnitudes by their adjusted exponents (precision - scale) and so
            // never materializes 10^|scaleDiff| for a pair of cheaply-stored extreme scales. HugePositiveScale
            // (1E-2000000000) is a tiny positive number; HugeNegativeScale (1E2000000000) is enormous, so the
            // tiny value compares as less than the huge one — returned instantly rather than throwing.
            Assert.Equal(-1, HugePositiveScale.CompareTo(HugeNegativeScale));
            Assert.Equal(1, HugeNegativeScale.CompareTo(HugePositiveScale));
            Assert.True(HugePositiveScale < HugeNegativeScale);
            Assert.NotEqual(HugePositiveScale, HugeNegativeScale);
        }

        [Fact]
        public void SetScale_GrowToExtremeScale_ThrowsOverflow()
        {
            // Growing the scale by ~2 billion pads the unscaled value with that many zeros.
            Assert.Throws<OverflowException>(() => P("1").SetScale(2000000000, RoundingMode.Unnecessary));
        }

        [Fact]
        public void MovePointRight_ExtremeShift_ThrowsOverflow()
        {
            // A negative resulting scale is folded into the unscaled value via 10^|scale|.
            Assert.Throws<OverflowException>(() => HugeNegativeScale.MovePointRight(0));
        }

        [Fact]
        public void GuardLimit_JustUnderBoundary_DoesNotThrow()
        {
            // A value whose plain form sits just under the limit must still format, confirming the guard
            // rejects only genuinely oversized materializations rather than reasonable large numbers.
            var value = new BigDecimal(System.Numerics.BigInteger.One, 100_000); // 0.000...1, 100k fraction digits
            string plain = value.ToPlainString(CultureInfo.InvariantCulture);
            Assert.Equal(100_002, plain.Length); // "0." + 100,000 digits
        }
    }
}
