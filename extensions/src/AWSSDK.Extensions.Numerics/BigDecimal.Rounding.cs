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

namespace Amazon.Extensions.Numerics
{
    public readonly partial struct BigDecimal
    {
        /// <summary>
        /// Returns a <see cref="BigDecimal"/> rounded to the precision and rounding mode specified by
        /// <paramref name="context"/>. If the context has unlimited precision the value is returned
        /// unchanged.
        /// </summary>
        /// <param name="context">The precision and rounding settings to apply.</param>
        /// <returns>The rounded value.</returns>
        /// <exception cref="ArithmeticException">
        /// Thrown when <paramref name="context"/> uses <see cref="RoundingMode.Unnecessary"/> but rounding
        /// would change the value.
        /// </exception>
        public BigDecimal Round(MathContext context)
        {
            if (context.Precision == 0)
                return this;

            int drop = DigitCount(_unscaledValue) - context.Precision;
            if (drop <= 0)
                return this;

            BigDecimal result = DropDigits(drop, context.RoundingMode);

            // Rounding can carry into an additional digit (e.g. 9.99 -> 10.0); drop one more if so.
            if (DigitCount(result._unscaledValue) > context.Precision)
                result = result.DropDigits(1, context.RoundingMode);

            return result;
        }

        /// <summary>
        /// Returns a <see cref="BigDecimal"/> with the specified scale. If the new scale is larger the
        /// value is exact; if it is smaller the value is rounded using <paramref name="mode"/>.
        /// </summary>
        /// <param name="newScale">The desired scale.</param>
        /// <param name="mode">The rounding mode to use when the scale is reduced.</param>
        /// <returns>A value with scale equal to <paramref name="newScale"/>.</returns>
        /// <exception cref="ArithmeticException">
        /// Thrown when <paramref name="mode"/> is <see cref="RoundingMode.Unnecessary"/> but reducing the
        /// scale would discard non-zero digits.
        /// </exception>
        public BigDecimal SetScale(int newScale, RoundingMode mode)
        {
            if (newScale == _scale)
                return this;

            // Compute the scale delta in long so two opposite-signed int scales cannot wrap; the magnitude
            // is the power of ten we scale by (growing) or the digit count we drop (shrinking).
            if (newScale > _scale)
                return new BigDecimal(_unscaledValue * PowerOfTen(CheckScaleRange((long)newScale - _scale)), newScale);

            return DropDigits(CheckScaleRange((long)_scale - newScale), mode);
        }

        /// <summary>
        /// Returns a numerically equal <see cref="BigDecimal"/> with any trailing zeros removed from its
        /// unscaled value (reducing the scale accordingly). Zero is normalized to a scale of zero.
        /// </summary>
        /// <returns>An equivalent value with trailing zeros stripped.</returns>
        public BigDecimal StripTrailingZeros()
        {
            if (_unscaledValue.IsZero)
                return new BigDecimal(BigInteger.Zero, 0);

            BigInteger unscaled = _unscaledValue;
            int scale = _scale;

            BigInteger remainder;
            BigInteger quotient = BigInteger.DivRem(unscaled, BigIntegerTen, out remainder);
            while (remainder.IsZero)
            {
                unscaled = quotient;
                scale--;
                quotient = BigInteger.DivRem(unscaled, BigIntegerTen, out remainder);
            }

            return new BigDecimal(unscaled, scale);
        }

        /// <summary>
        /// Divides the unscaled value by <c>10^<paramref name="n"/></c>, rounding the discarded digits
        /// using <paramref name="mode"/>, and reduces the scale by <paramref name="n"/>.
        /// </summary>
        private BigDecimal DropDigits(int n, RoundingMode mode)
        {
            BigInteger divisor = PowerOfTen(n);
            BigInteger magnitude = BigInteger.Abs(_unscaledValue);

            BigInteger remainder;
            BigInteger quotient = BigInteger.DivRem(magnitude, divisor, out remainder);

            BigInteger rounded = RoundMagnitude(quotient, remainder, divisor, _unscaledValue.Sign, mode);
            return new BigDecimal(rounded, _scale - n);
        }

        /// <summary>
        /// Applies <paramref name="mode"/> to a truncated-toward-zero quotient magnitude and returns the
        /// signed, rounded result. <paramref name="resultSign"/> is the sign of the exact value.
        /// </summary>
        internal static BigInteger RoundMagnitude(
            BigInteger quotientMagnitude,
            BigInteger remainderMagnitude,
            BigInteger divisorMagnitude,
            int resultSign,
            RoundingMode mode)
        {
            return RoundMagnitude(quotientMagnitude, remainderMagnitude, divisorMagnitude, resultSign, mode, false);
        }

        /// <summary>
        /// Applies <paramref name="mode"/> to a truncated-toward-zero quotient magnitude and returns the
        /// signed, rounded result. <paramref name="sticky"/> indicates that non-zero digits exist beyond
        /// the supplied remainder (so the true discarded fraction is strictly larger than
        /// <paramref name="remainderMagnitude"/> implies); this only affects exact half-way ties.
        /// </summary>
        internal static BigInteger RoundMagnitude(
            BigInteger quotientMagnitude,
            BigInteger remainderMagnitude,
            BigInteger divisorMagnitude,
            int resultSign,
            RoundingMode mode,
            bool sticky)
        {
            bool roundUp = ShouldRoundUp(quotientMagnitude, remainderMagnitude, divisorMagnitude, resultSign, mode, sticky);
            BigInteger magnitude = roundUp ? quotientMagnitude + BigInteger.One : quotientMagnitude;
            return resultSign < 0 ? -magnitude : magnitude;
        }

        /// <summary>
        /// Decides whether a truncated quotient magnitude should be incremented (rounded away from zero)
        /// given the discarded remainder, an optional sticky bit for hidden lower-order digits, and the
        /// selected rounding mode.
        /// </summary>
        private static bool ShouldRoundUp(
            BigInteger quotientMagnitude,
            BigInteger remainderMagnitude,
            BigInteger divisorMagnitude,
            int resultSign,
            RoundingMode mode,
            bool sticky)
        {
            // No discarded fraction at all means the result is exact; never round.
            if (remainderMagnitude.IsZero && !sticky)
                return false;

            switch (mode)
            {
                case RoundingMode.Up:
                    return true;
                case RoundingMode.Down:
                    return false;
                case RoundingMode.Ceiling:
                    return resultSign > 0;
                case RoundingMode.Floor:
                    return resultSign < 0;
                case RoundingMode.Unnecessary:
                    throw new ArithmeticException("Rounding necessary but RoundingMode.Unnecessary was specified.");
                case RoundingMode.HalfUp:
                case RoundingMode.HalfDown:
                case RoundingMode.HalfEven:
                    int comparison = (remainderMagnitude * 2).CompareTo(divisorMagnitude);
                    if (comparison > 0)
                        return true;
                    if (comparison < 0)
                        return false;

                    // remainder is exactly half the divisor; hidden lower-order digits push it over half.
                    if (sticky)
                        return true;

                    // Exactly halfway between two representable values.
                    switch (mode)
                    {
                        case RoundingMode.HalfUp:
                            return true;
                        case RoundingMode.HalfDown:
                            return false;
                        default: // HalfEven: round up only if the retained digit is odd.
                            return !(quotientMagnitude % 2).IsZero;
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, "Unknown rounding mode.");
            }
        }
    }
}
