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

using System.Numerics;
using Amazon.Extensions.Numerics;
using Xunit;

namespace NumericsTest
{
    public class ConstructionAndPropertiesTests
    {
        [Fact]
        public void UnscaledAndScaleConstructor_RoundTripsComponents()
        {
            var value = new BigDecimal(new BigInteger(12345), 2);
            Assert.Equal(new BigInteger(12345), value.UnscaledValue);
            Assert.Equal(2, value.Scale);
        }

        [Fact]
        public void IntConstructor_HasZeroScale()
        {
            var value = new BigDecimal(42);
            Assert.Equal(0, value.Scale);
            Assert.Equal(new BigInteger(42), value.UnscaledValue);
        }

        [Fact]
        public void DecimalConstructor_PreservesTrailingZeros()
        {
            var value = new BigDecimal(2.00m);
            Assert.Equal(2, value.Scale);
            Assert.Equal(new BigInteger(200), value.UnscaledValue);
        }

        [Theory]
        [InlineData(0, 1)]      // zero -> precision 1
        [InlineData(7, 1)]
        [InlineData(100, 3)]
        [InlineData(-100, 3)]
        [InlineData(999, 3)]
        [InlineData(1000, 4)]
        public void Precision_CountsDigits(int unscaled, int expectedPrecision)
        {
            var value = new BigDecimal(new BigInteger(unscaled), 0);
            Assert.Equal(expectedPrecision, value.Precision);
        }

        [Fact]
        public void Precision_LargeValue()
        {
            var value = new BigDecimal(BigInteger.Pow(10, 50), 0); // 1 followed by 50 zeros => 51 digits
            Assert.Equal(51, value.Precision);
        }

        [Theory]
        [InlineData(5, 1)]
        [InlineData(0, 0)]
        [InlineData(-5, -1)]
        public void Sign_ReflectsValue(int unscaled, int expectedSign)
        {
            var value = new BigDecimal(new BigInteger(unscaled), 3);
            Assert.Equal(expectedSign, value.Sign);
        }

        [Fact]
        public void IsZero_TrueRegardlessOfScale()
        {
            Assert.True(new BigDecimal(BigInteger.Zero, 5).IsZero);
            Assert.True(BigDecimal.Zero.IsZero);
            Assert.False(BigDecimal.One.IsZero);
        }

        [Fact]
        public void WellKnownValues()
        {
            Assert.Equal(BigInteger.Zero, BigDecimal.Zero.UnscaledValue);
            Assert.Equal(BigInteger.One, BigDecimal.One.UnscaledValue);
            Assert.Equal(new BigInteger(10), BigDecimal.Ten.UnscaledValue);
        }
    }
}
