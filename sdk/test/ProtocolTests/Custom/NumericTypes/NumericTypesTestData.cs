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
using Amazon.Extensions.Numerics;
using System;
using System.Globalization;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.ProtocolTests.NumericTypes
{
    /// <summary>
    /// Values for the Full Numeric Type Support SEP tests. They are chosen so that losing digits, scale or sign,
    /// or going through double or decimal, changes the value.
    /// </summary>
    internal static class NumericTypesTestData
    {
        // 50 digits: beyond long, ulong and decimal.
        public const string BigIntegerText = "-98765432109876543210987654321098765432109876543210";
        // One past ulong.MaxValue.
        public const string BigIntegerInMapText = "18446744073709551616";
        // 2^53 + 1: the first integer a double cannot represent.
        public const string DoubleLossyIntegerText = "9007199254740993";
        // A double reads this as 0.1.
        public const string DoubleLossyDecimalText = "0.1000000000000000055511151231257827";
        // Trailing zero: the scale (2) must survive.
        public const string BigDecimalText = "1.50";
        public const string NestedBigDecimalText = "-0.5";

        public static BigInteger BigInteger(string text) => System.Numerics.BigInteger.Parse(text, CultureInfo.InvariantCulture);

        public static BigDecimal BigDecimal(string text) => Amazon.Extensions.Numerics.BigDecimal.Parse(text, CultureInfo.InvariantCulture);

        /// <summary>
        /// Returns the exception <paramref name="call"/> throws, failing if it does not throw.
        /// </summary>
        public static async Task<Exception> CaptureExceptionAsync(Func<Task> call)
        {
            try
            {
                await call().ConfigureAwait(false);
            }
            catch (Exception e)
            {
                return e;
            }
            throw new InvalidOperationException("Expected the call to throw.");
        }

        /// <summary>
        /// Asserts that <paramref name="actual"/> is the same exception type an int overflow produces on the same
        /// protocol (<paramref name="intOverflow"/>), and that the root cause is an <see cref="OverflowException"/>.
        /// </summary>
        public static void AssertSameAsIntOverflow(Exception intOverflow, Exception actual)
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(intOverflow.GetType(), actual.GetType());
            var root = actual;
            while (root.InnerException != null)
            {
                root = root.InnerException;
            }
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsInstanceOfType(root, typeof(OverflowException));
        }

        /// <summary>
        /// Runs <paramref name="action"/> under a culture whose number formatting differs from the invariant culture
        /// (nb-NO uses U+2212 as the negative sign and a comma decimal separator).
        /// </summary>
        public static void InNonInvariantCulture(Action action)
        {
            var original = Thread.CurrentThread.CurrentCulture;
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("nb-NO");
                action();
            }
            finally
            {
                Thread.CurrentThread.CurrentCulture = original;
            }
        }
    }
}
