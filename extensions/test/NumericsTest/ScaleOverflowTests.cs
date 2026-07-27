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
using System.Numerics;
using Amazon.Extensions.Numerics;
using Xunit;

namespace NumericsTest
{
    // Operations that rescale an operand subtract two int scales. With extreme opposite-signed scales that
    // difference exceeds the int range; it is computed in long and validated so it surfaces as a clear
    // OverflowException rather than wrapping into a confusing negative-power-of-ten error.
    public class ScaleOverflowTests
    {
        // A scale difference of int.MaxValue - int.MinValue overflows a 32-bit int.
        private static BigDecimal HighPositiveScale => new BigDecimal(BigInteger.One, int.MaxValue);
        private static BigDecimal HighNegativeScale => new BigDecimal(BigInteger.One, int.MinValue);

        [Fact]
        public void Add_ScaleDifferenceOverflows_Throws()
        {
            Assert.Throws<OverflowException>(() => HighPositiveScale.Add(HighNegativeScale));
        }

        [Fact]
        public void Subtract_ScaleDifferenceOverflows_Throws()
        {
            Assert.Throws<OverflowException>(() => HighPositiveScale.Subtract(HighNegativeScale));
        }

        [Fact]
        public void CompareTo_ExtremeScaleDifference_ComparesWithoutOverflow()
        {
            // CompareTo settles unequal magnitudes by their adjusted exponents (precision - scale), so it does
            // not subtract the two extreme scales and therefore does not overflow. HighPositiveScale (scale
            // int.MaxValue) is a tiny positive number and HighNegativeScale (scale int.MinValue) is enormous,
            // so the tiny value compares as less than the huge one. The alignment multiply only ever runs when
            // adjusted exponents are equal, where the scale difference is bounded by the digit-count difference.
            Assert.Equal(-1, HighPositiveScale.CompareTo(HighNegativeScale));
            Assert.Equal(1, HighNegativeScale.CompareTo(HighPositiveScale));
        }

        [Fact]
        public void SetScale_Grow_ScaleDifferenceOverflows_Throws()
        {
            // Growing from int.MinValue scale toward a high positive scale overflows the delta.
            Assert.Throws<OverflowException>(() => HighNegativeScale.SetScale(int.MaxValue, RoundingMode.Unnecessary));
        }

        [Fact]
        public void SetScale_Shrink_ScaleDifferenceOverflows_Throws()
        {
            Assert.Throws<OverflowException>(() => HighPositiveScale.SetScale(int.MinValue, RoundingMode.Down));
        }

        [Fact]
        public void Remainder_ScaleDifferenceOverflows_Throws()
        {
            Assert.Throws<OverflowException>(() => HighPositiveScale.Remainder(HighNegativeScale));
        }

        // A value with scale int.MinValue must negate its scale to realize 10^|scale| during MovePoint*,
        // ToBigInteger, and similar. Negating int.MinValue as an int wraps back to int.MinValue (still
        // negative), which would reach PowerOfTen as a bogus negative exponent and throw the wrong
        // exception while bypassing the materialization guard. These assert it instead surfaces as the
        // same clear OverflowException every other out-of-range scale produces.

        [Fact]
        public void MovePointLeft_MinValueScale_Throws()
        {
            Assert.Throws<OverflowException>(() => HighNegativeScale.MovePointLeft(0));
        }

        [Fact]
        public void MovePointRight_MinValueScale_Throws()
        {
            Assert.Throws<OverflowException>(() => HighNegativeScale.MovePointRight(0));
        }

        [Fact]
        public void ToBigInteger_MinValueScale_Throws()
        {
            Assert.Throws<OverflowException>(() => HighNegativeScale.ToBigInteger());
        }

        // The negate-in-long fix must not disturb ordinary negative scales, which still expand correctly.

        [Fact]
        public void ToBigInteger_ModerateNegativeScale_ExpandsExactly()
        {
            // unscaled 15 at scale -2 is numerically 1500.
            var value = new BigDecimal(new BigInteger(15), -2);
            Assert.Equal(new BigInteger(1500), value.ToBigInteger());
        }

        [Fact]
        public void MovePointRight_NegativeScaleResult_FoldsIntoUnscaledValue()
        {
            // Moving 1.5 (unscaled 15, scale 1) right by 2 yields 150 at scale 0, never a negative scale.
            var result = new BigDecimal(new BigInteger(15), 1).MovePointRight(2);
            Assert.Equal(new BigInteger(150), result.UnscaledValue);
            Assert.Equal(0, result.Scale);
        }
    }
}
