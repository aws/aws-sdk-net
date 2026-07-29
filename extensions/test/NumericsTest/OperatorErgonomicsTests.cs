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
    public class OperatorErgonomicsTests
    {
        private static BigDecimal P(string s) => BigDecimal.Parse(s, CultureInfo.InvariantCulture);

        [Fact]
        public void AddIntLiteral_ViaImplicitConversion()
        {
            var current = P("5.25");
            current = current + 10;            // the canonical scenario from the requirements
            Assert.Equal(P("15.25"), current);
        }

        [Fact]
        public void IntLiteralOnLeft()
        {
            var current = P("5.25");
            var result = 10 + current;
            Assert.Equal(P("15.25"), result);
        }

        [Fact]
        public void MixedSubtractMultiplyDivide()
        {
            var value = P("100.00");
            Assert.Equal(P("90.00"), value - 10);
            Assert.Equal(P("200.00"), value * 2);
            Assert.Equal(P("50"), value / 2);
        }

        [Fact]
        public void CompareAgainstIntLiteral()
        {
            var value = P("2.00");
            Assert.True(value == 2);
            Assert.True(value < 3);
            Assert.True(value > 1);
        }

        [Fact]
        public void UnaryNegate()
        {
            Assert.Equal(P("-5.5"), -P("5.5"));
            Assert.Equal(P("5.5"), +P("5.5"));
        }

        [Fact]
        public void ChainedArithmetic()
        {
            var result = P("1.5") + P("2.5") * 2 - 1;
            Assert.Equal(P("5.5"), result);
        }
    }
}
