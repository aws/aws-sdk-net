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
        /// Adds another value to this one. The result is exact and its scale is the larger of the two
        /// operand scales.
        /// </summary>
        /// <param name="other">The value to add.</param>
        /// <returns>The sum.</returns>
        public BigDecimal Add(BigDecimal other)
        {
            int resultScale;
            BigInteger left, right;
            AlignScales(this, other, out left, out right, out resultScale);
            return new BigDecimal(left + right, resultScale);
        }

        /// <summary>
        /// Subtracts another value from this one. The result is exact and its scale is the larger of the
        /// two operand scales.
        /// </summary>
        /// <param name="other">The value to subtract.</param>
        /// <returns>The difference.</returns>
        public BigDecimal Subtract(BigDecimal other)
        {
            int resultScale;
            BigInteger left, right;
            AlignScales(this, other, out left, out right, out resultScale);
            return new BigDecimal(left - right, resultScale);
        }

        /// <summary>
        /// Multiplies this value by another. The result is exact and its scale is the sum of the two
        /// operand scales.
        /// </summary>
        /// <param name="other">The value to multiply by.</param>
        /// <returns>The product.</returns>
        /// <exception cref="OverflowException">Thrown when the resulting scale does not fit in a 32-bit integer.</exception>
        public BigDecimal Multiply(BigDecimal other)
        {
            int resultScale = CheckScaleRange((long)_scale + other._scale);
            return new BigDecimal(_unscaledValue * other._unscaledValue, resultScale);
        }

        /// <summary>
        /// Adds another value to this one and rounds the result to the precision and rounding mode of
        /// <paramref name="context"/>.
        /// </summary>
        /// <param name="other">The value to add.</param>
        /// <param name="context">The precision and rounding settings to apply to the result.</param>
        /// <returns>The rounded sum.</returns>
        public BigDecimal Add(BigDecimal other, MathContext context) => Add(other).Round(context);

        /// <summary>
        /// Subtracts another value from this one and rounds the result to the precision and rounding mode
        /// of <paramref name="context"/>.
        /// </summary>
        /// <param name="other">The value to subtract.</param>
        /// <param name="context">The precision and rounding settings to apply to the result.</param>
        /// <returns>The rounded difference.</returns>
        public BigDecimal Subtract(BigDecimal other, MathContext context) => Subtract(other).Round(context);

        /// <summary>
        /// Multiplies this value by another and rounds the result to the precision and rounding mode of
        /// <paramref name="context"/>.
        /// </summary>
        /// <param name="other">The value to multiply by.</param>
        /// <param name="context">The precision and rounding settings to apply to the result.</param>
        /// <returns>The rounded product.</returns>
        /// <exception cref="OverflowException">Thrown when the intermediate scale does not fit in a 32-bit integer.</exception>
        public BigDecimal Multiply(BigDecimal other, MathContext context) => Multiply(other).Round(context);

        /// <summary>
        /// Returns the negation of this value, rounded to the precision and rounding mode of
        /// <paramref name="context"/>.
        /// </summary>
        /// <param name="context">The precision and rounding settings to apply to the result.</param>
        /// <returns>The rounded, negated value.</returns>
        public BigDecimal Negate(MathContext context) => Negate().Round(context);

        /// <summary>
        /// Returns the absolute value of this value, rounded to the precision and rounding mode of
        /// <paramref name="context"/>.
        /// </summary>
        /// <param name="context">The precision and rounding settings to apply to the result.</param>
        /// <returns>The rounded absolute value.</returns>
        public BigDecimal Abs(MathContext context) => Abs().Round(context);

        /// <summary>
        /// Divides this value by another, requiring the quotient to have an exact, terminating decimal
        /// representation.
        /// </summary>
        /// <param name="divisor">The value to divide by.</param>
        /// <returns>The exact quotient.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="divisor"/> is zero.</exception>
        /// <exception cref="ArithmeticException">Thrown when the exact quotient is a non-terminating decimal.</exception>
        /// <remarks>
        /// This mirrors Java's <c>BigDecimal.divide(BigDecimal)</c>. To divide with rounding, use
        /// <see cref="Divide(BigDecimal, MathContext)"/> or <see cref="Divide(BigDecimal, int, RoundingMode)"/>.
        /// </remarks>
        public BigDecimal Divide(BigDecimal divisor)
        {
            if (divisor._unscaledValue.IsZero)
                throw new DivideByZeroException();

            if (_unscaledValue.IsZero)
                return new BigDecimal(BigInteger.Zero, SaturatingSubtract(_scale, divisor._scale));

            // value = (uA / uB) * 10^(sB - sA). Reduce the fraction uA/uB to lowest terms; it terminates
            // in base ten only if the reduced denominator's prime factors are limited to 2 and 5.
            BigInteger numerator = _unscaledValue;
            BigInteger denominator = divisor._unscaledValue;

            BigInteger gcd = BigInteger.GreatestCommonDivisor(BigInteger.Abs(numerator), BigInteger.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            if (denominator.Sign < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            // Strip factors of 2 and 5 from the denominator, tracking how many of each we removed.
            int twos = 0;
            BigInteger reduced = denominator;
            BigInteger two = new BigInteger(2);
            BigInteger remainder;
            BigInteger quotient = BigInteger.DivRem(reduced, two, out remainder);
            while (remainder.IsZero)
            {
                reduced = quotient;
                twos++;
                quotient = BigInteger.DivRem(reduced, two, out remainder);
            }

            int fives = 0;
            BigInteger five = new BigInteger(5);
            quotient = BigInteger.DivRem(reduced, five, out remainder);
            while (remainder.IsZero)
            {
                reduced = quotient;
                fives++;
                quotient = BigInteger.DivRem(reduced, five, out remainder);
            }

            if (reduced != BigInteger.One)
                throw new ArithmeticException("Non-terminating decimal expansion; no exact representable result.");

            // Multiply numerator and denominator by whichever of 2/5 is needed to turn the denominator
            // into a pure power of ten, 10^maxPower.
            int maxPower = Math.Max(twos, fives);
            BigInteger numeratorScaled = numerator;
            if (maxPower - fives > 0)
                numeratorScaled *= BigInteger.Pow(five, maxPower - fives);
            if (maxPower - twos > 0)
                numeratorScaled *= BigInteger.Pow(two, maxPower - twos);

            // Now exactValue = numeratorScaled / 10^maxPower, then apply the 10^(sB - sA) factor.
            // The result scale is preserved as computed (it may be negative, e.g. 1 / 0.001 yields an
            // unscaled value of 1 at scale -3, "1E+3"), matching the preferred scale this.scale -
            // divisor.scale that Java's divide(BigDecimal) reports. The scale is not folded into the
            // unscaled value: this type keeps negative scales (see ScaleByPowerOfTen), and folding here
            // would diverge from Java and from the type's own scale-fidelity contract. When maxPower > 0
            // the numerator is coprime to 10, so numeratorScaled carries no surplus trailing zeros; when
            // maxPower == 0 the scale already equals the preferred scale, so no stripping or padding is
            // needed to match Java in either case.
            long resultScale = (long)maxPower + ((long)_scale - divisor._scale);
            return new BigDecimal(numeratorScaled, CheckScaleRange(resultScale));
        }

        /// <summary>
        /// Divides this value by another, rounding the quotient to the precision and rounding mode of
        /// <paramref name="context"/>.
        /// </summary>
        /// <param name="divisor">The value to divide by.</param>
        /// <param name="context">The precision and rounding settings to apply.</param>
        /// <returns>The rounded quotient.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="divisor"/> is zero.</exception>
        /// <exception cref="ArithmeticException">
        /// Thrown when <paramref name="context"/> has unlimited precision and the exact quotient does not
        /// terminate, or when it uses <see cref="RoundingMode.Unnecessary"/> and rounding would be required.
        /// </exception>
        public BigDecimal Divide(BigDecimal divisor, MathContext context)
        {
            if (context.Precision == 0)
                return Divide(divisor);

            if (divisor._unscaledValue.IsZero)
                throw new DivideByZeroException();

            if (_unscaledValue.IsZero)
                return new BigDecimal(BigInteger.Zero, SaturatingSubtract(_scale, divisor._scale));

            int sign = _unscaledValue.Sign * divisor._unscaledValue.Sign;
            BigInteger dividend = BigInteger.Abs(_unscaledValue);
            BigInteger divisorMagnitude = BigInteger.Abs(divisor._unscaledValue);

            // Scale the dividend by a power of ten so the integer quotient carries at least
            // (precision + 1) digits, giving a guard digit for the rounding decision. shift tracks the
            // applied power of ten and feeds into the result scale. It is computed in long so a large
            // context precision cannot wrap the intermediate (and pass a negative exponent to PowerOfTen);
            // an out-of-int-range power of ten is caught by PowerOfTen's materialization guard.
            long shift = (long)context.Precision + 1 - (DigitCount(dividend) - DigitCount(divisorMagnitude));
            if (shift > 0)
                dividend *= PowerOfTen(checked((int)shift));
            else if (shift < 0)
                divisorMagnitude *= PowerOfTen(checked((int)(-shift)));

            BigInteger remainder;
            BigInteger quotient = BigInteger.DivRem(dividend, divisorMagnitude, out remainder);

            // quotient == floor(value * 10^(shift + sA - sB)); remainder != 0 means the true value has
            // further non-zero digits (the sticky bit for half-way ties). Drop the surplus low digits so
            // the result carries exactly Precision significant digits, rounding per the context.
            bool sticky = !remainder.IsZero;
            int dropCount = DigitCount(quotient) - context.Precision;
            long quotientScale = (long)_scale - divisor._scale + shift;

            BigInteger resultUnscaled;
            long resultScale;
            bool exact;
            if (dropCount <= 0)
            {
                // Quotient already fits within the requested precision; the only discarded information is
                // the division remainder itself.
                resultUnscaled = RoundMagnitude(quotient, remainder, divisorMagnitude, sign, context.RoundingMode, false);
                resultScale = quotientScale;
                exact = remainder.IsZero;
            }
            else
            {
                BigInteger unit = PowerOfTen(dropCount);
                BigInteger droppedRemainder;
                BigInteger keptQuotient = BigInteger.DivRem(quotient, unit, out droppedRemainder);
                resultUnscaled = RoundMagnitude(keptQuotient, droppedRemainder, unit, sign, context.RoundingMode, sticky);
                resultScale = quotientScale - dropCount;
                exact = !sticky && droppedRemainder.IsZero;
            }

            // Rounding can carry into an additional digit (e.g. 9.5 -> 10 at precision 1), pushing the
            // result one digit over the requested precision. The carry always yields a trailing zero, so
            // dropping that digit is exact and restores the precision (matching Round and Java's divide).
            if (DigitCount(resultUnscaled) > context.Precision)
            {
                resultUnscaled /= BigIntegerTen;
                resultScale--;
            }

            // When the quotient is exact we do not pad it out to the full requested precision. Instead we
            // strip the surplus trailing zeros down toward the preferred scale (this.scale - divisor.scale),
            // so 1 / 8 with precision 5 yields 0.125 rather than 0.12500. Trailing zeros are only removed,
            // never added, so the scale settles at whichever of the preferred and natural scales is larger.
            if (exact)
            {
                long preferredScale = (long)_scale - divisor._scale;
                while (resultScale > preferredScale && !resultUnscaled.IsZero)
                {
                    BigInteger stripRemainder;
                    BigInteger stripped = BigInteger.DivRem(resultUnscaled, BigIntegerTen, out stripRemainder);
                    if (!stripRemainder.IsZero)
                        break;

                    resultUnscaled = stripped;
                    resultScale--;
                }
            }

            // Preserve the result scale as computed; it may be negative (e.g. 100 / 1 at precision 1 is
            // 1E+2, unscaled 1 at scale -2), matching the scale Java's divide(divisor, MathContext) reports.
            // The scale is not folded into the unscaled value (see the note in the exact Divide overload).
            return new BigDecimal(resultUnscaled, CheckScaleRange(resultScale));
        }

        /// <summary>
        /// Divides this value by another, returning a result with the specified scale, rounding the
        /// quotient using <paramref name="mode"/>.
        /// </summary>
        /// <param name="divisor">The value to divide by.</param>
        /// <param name="scale">The scale of the result.</param>
        /// <param name="mode">The rounding mode to apply.</param>
        /// <returns>The quotient rounded to <paramref name="scale"/>.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="divisor"/> is zero.</exception>
        /// <exception cref="ArithmeticException">
        /// Thrown when <paramref name="mode"/> is <see cref="RoundingMode.Unnecessary"/> and the exact
        /// quotient does not fit at the requested scale.
        /// </exception>
        public BigDecimal Divide(BigDecimal divisor, int scale, RoundingMode mode)
        {
            if (divisor._unscaledValue.IsZero)
                throw new DivideByZeroException();

            if (_unscaledValue.IsZero)
                return new BigDecimal(BigInteger.Zero, scale);

            int sign = _unscaledValue.Sign * divisor._unscaledValue.Sign;

            // We want the result expressed at the target scale: result = round(uA / uB * 10^(sB - sA + scale)).
            // Compute the integer quotient and remainder of |uA| * 10^shiftUp vs |uB| * 10^shiftDown.
            long shift = (long)scale + divisor._scale - _scale;

            BigInteger dividend = BigInteger.Abs(_unscaledValue);
            BigInteger divisorMagnitude = BigInteger.Abs(divisor._unscaledValue);

            if (shift > 0)
                dividend *= PowerOfTen(checked((int)shift));
            else if (shift < 0)
                divisorMagnitude *= PowerOfTen(checked((int)(-shift)));

            BigInteger remainder;
            BigInteger quotient = BigInteger.DivRem(dividend, divisorMagnitude, out remainder);

            BigInteger rounded = RoundMagnitude(quotient, remainder, divisorMagnitude, sign, mode);
            return new BigDecimal(rounded, scale);
        }

        /// <summary>
        /// Returns the negation of this value (its scale is preserved).
        /// </summary>
        /// <returns>The negated value.</returns>
        public BigDecimal Negate() => new BigDecimal(-_unscaledValue, _scale);

        /// <summary>
        /// Returns the absolute value of this value (its scale is preserved).
        /// </summary>
        /// <returns>The absolute value.</returns>
        public BigDecimal Abs() => _unscaledValue.Sign < 0 ? Negate() : this;

        /// <summary>
        /// Computes the remainder after dividing this value by <paramref name="divisor"/>. The result
        /// equals <c>this - divisor * q</c>, where <c>q</c> is the integer quotient truncated toward zero,
        /// and therefore carries the sign of the dividend (this value).
        /// </summary>
        /// <param name="divisor">The value to divide by.</param>
        /// <returns>The remainder.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="divisor"/> is zero.</exception>
        /// <remarks>This matches the semantics of Java's <c>BigDecimal.remainder</c>.</remarks>
        public BigDecimal Remainder(BigDecimal divisor)
        {
            if (divisor._unscaledValue.IsZero)
                throw new DivideByZeroException();

            if (_unscaledValue.IsZero)
                return this;

            // Align both operands to a common scale; integer division of the aligned mantissas yields the
            // quotient truncated toward zero (BigInteger division truncates), which is what remainder needs.
            int commonScale;
            BigInteger dividendUnscaled, divisorUnscaled;
            AlignScales(this, divisor, out dividendUnscaled, out divisorUnscaled, out commonScale);

            BigInteger integerQuotient = dividendUnscaled / divisorUnscaled;
            return Subtract(divisor.Multiply(new BigDecimal(integerQuotient, 0)));
        }

        /// <summary>
        /// Divides this value by another and returns a convenience overload that rounds the quotient to
        /// this value's own scale using <paramref name="mode"/>.
        /// </summary>
        /// <param name="divisor">The value to divide by.</param>
        /// <param name="mode">The rounding mode to apply.</param>
        /// <returns>The quotient rounded to <see cref="Scale"/>.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="divisor"/> is zero.</exception>
        /// <remarks>This mirrors Java's <c>BigDecimal.divide(BigDecimal, RoundingMode)</c>, whose result scale is the dividend's scale.</remarks>
        public BigDecimal Divide(BigDecimal divisor, RoundingMode mode) => Divide(divisor, _scale, mode);

        /// <summary>
        /// Returns the integer part of <c>this / divisor</c>, truncated toward zero. The preferred scale of
        /// the result is <c>this.Scale - divisor.Scale</c>.
        /// </summary>
        /// <param name="divisor">The value to divide by.</param>
        /// <returns>The integer part of the quotient.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="divisor"/> is zero.</exception>
        /// <remarks>This mirrors Java's <c>BigDecimal.divideToIntegralValue</c>.</remarks>
        public BigDecimal DivideToIntegralValue(BigDecimal divisor)
        {
            if (divisor._unscaledValue.IsZero)
                throw new DivideByZeroException();

            if (_unscaledValue.IsZero)
                return new BigDecimal(BigInteger.Zero, SaturatingSubtract(_scale, divisor._scale));

            // Align both operands to a common scale; BigInteger division then truncates toward zero, which
            // yields the exact integer part of the quotient without any rounding decision.
            int commonScale;
            BigInteger dividendUnscaled, divisorUnscaled;
            AlignScales(this, divisor, out dividendUnscaled, out divisorUnscaled, out commonScale);

            BigInteger integerQuotient = dividendUnscaled / divisorUnscaled;
            return IntegerAtPreferredScale(integerQuotient, (long)_scale - divisor._scale);
        }

        /// <summary>
        /// Returns the integer part of <c>this / divisor</c> (truncated toward zero) and, via
        /// <paramref name="remainder"/>, the remainder <c>this - divisor * integerPart</c>. The remainder
        /// carries the sign of this value.
        /// </summary>
        /// <param name="divisor">The value to divide by.</param>
        /// <param name="remainder">When this method returns, contains the remainder.</param>
        /// <returns>The integer part of the quotient.</returns>
        /// <exception cref="DivideByZeroException">Thrown when <paramref name="divisor"/> is zero.</exception>
        /// <remarks>
        /// This mirrors Java's <c>BigDecimal.divideAndRemainder</c>, which returns a two-element array; the
        /// .NET shape returns the integer quotient and supplies the remainder through an out parameter.
        /// Both results are derived from the same integer quotient, so they are mutually consistent.
        /// </remarks>
        public BigDecimal DivideAndRemainder(BigDecimal divisor, out BigDecimal remainder)
        {
            BigDecimal integralQuotient = DivideToIntegralValue(divisor);
            remainder = Subtract(integralQuotient.Multiply(divisor));
            return integralQuotient;
        }

        /// <summary>
        /// Returns this value raised to the power <paramref name="n"/>. The result is exact; its scale is
        /// <c>this.Scale * n</c>.
        /// </summary>
        /// <param name="n">The exponent. Must be in the range <c>0</c> through <c>999999999</c>.</param>
        /// <returns><c>this<sup>n</sup></c>.</returns>
        /// <exception cref="ArithmeticException">Thrown when <paramref name="n"/> is outside the supported range.</exception>
        /// <exception cref="OverflowException">Thrown when the resulting scale does not fit in a 32-bit integer.</exception>
        /// <remarks>This mirrors Java's <c>BigDecimal.pow(int)</c>; in particular <c>x.Pow(0)</c> is <see cref="One"/> for every <c>x</c>.</remarks>
        public BigDecimal Pow(int n)
        {
            if (n < 0 || n > 999999999)
                throw new ArithmeticException("Invalid operation: the exponent must be in the range 0 through 999999999.");

            int newScale = CheckScaleRange((long)_scale * n);

            // |unscaledValue|^n has at most DigitCount(unscaledValue) * n digits. Although the exponent is a
            // caller-supplied argument (kept at Java's 0..999999999 bound above), the base can originate from
            // untrusted wire input, so a modest base with a large exponent could still materialize gigabytes
            // and OOM the process. Guard the projected digit count so that case throws a clear, catchable
            // OverflowException instead, consistent with the rest of the type's materialization backstop.
            // A base whose unscaled magnitude is 0 or 1 raises to 0 or +/-1 with no growth, so it is exempt
            // (its DigitCount of 1 would otherwise overestimate the result as n digits). The product is
            // computed in long so it cannot wrap before the check.
            if (_unscaledValue > BigInteger.One || _unscaledValue < BigInteger.MinusOne)
                GuardMaterializedDigits((long)DigitCount(_unscaledValue) * n);

            return new BigDecimal(BigInteger.Pow(_unscaledValue, n), newScale);
        }

        /// <summary>
        /// Returns this value raised to the power <paramref name="n"/>, rounded to the precision and
        /// rounding mode of <paramref name="context"/>. A negative exponent computes the reciprocal power.
        /// </summary>
        /// <param name="n">The exponent. Must be in the range <c>-999999999</c> through <c>999999999</c>.</param>
        /// <param name="context">The precision and rounding settings to apply.</param>
        /// <returns>The rounded <c>this<sup>n</sup></c>.</returns>
        /// <exception cref="ArithmeticException">
        /// Thrown when <paramref name="n"/> is outside the supported range, or when the number of digits in
        /// <paramref name="n"/> exceeds the context precision (the ANSI X3.274 rule).
        /// </exception>
        /// <remarks>
        /// When <paramref name="context"/> has unlimited precision this defers to <see cref="Pow(int)"/>
        /// (and a negative exponent is then invalid). Otherwise the computation follows the iterative,
        /// per-step-rounded algorithm of Java's <c>BigDecimal.pow(int, MathContext)</c>, so results match Java.
        /// </remarks>
        public BigDecimal Pow(int n, MathContext context)
        {
            if (context.Precision == 0)
                return Pow(n);

            if (n < -999999999 || n > 999999999)
                throw new ArithmeticException("Invalid operation: the exponent must be in the range -999999999 through 999999999.");

            if (n == 0)
                return One;

            int mag = Math.Abs(n);
            int exponentDigits = DigitCountUInt64((ulong)mag);
            if (exponentDigits > context.Precision)
                throw new ArithmeticException("Invalid operation: the exponent has more digits than the context precision.");

            // Carry a few guard digits through the iterative squaring so the final rounding is correct.
            // The working precision is computed in checked arithmetic so an extreme context precision
            // surfaces as a clear OverflowException rather than wrapping into an invalid MathContext.
            var workContext = new MathContext(checked(context.Precision + exponentDigits + 1), context.RoundingMode);

            // Left-to-right binary exponentiation over the bits of |n|. Doubling 'mag' shifts a bit out of
            // the sign position each iteration; the wrap to negative is the high bit, hence the unchecked block.
            BigDecimal acc = One;
            bool seenBit = false;
            for (int i = 1; ; i++)
            {
                unchecked { mag += mag; }
                if (mag < 0) // top bit was set
                {
                    seenBit = true;
                    acc = acc.Multiply(this, workContext);
                }

                if (i == 31)
                    break;

                if (seenBit)
                    acc = acc.Multiply(acc, workContext);
            }

            if (n < 0)
                acc = One.Divide(acc, workContext);

            return acc.Round(context);
        }

        /// <summary>
        /// Returns a value numerically equal to this one with the decimal point moved <paramref name="n"/>
        /// places to the left (dividing by <c>10<sup>n</sup></c>). A negative <paramref name="n"/> moves it right.
        /// </summary>
        /// <param name="n">The number of places to move the decimal point left.</param>
        /// <returns>The value with the decimal point moved.</returns>
        /// <exception cref="OverflowException">Thrown when the resulting scale does not fit in a 32-bit integer.</exception>
        /// <remarks>This mirrors Java's <c>BigDecimal.movePointLeft</c>: the result scale is never negative.</remarks>
        public BigDecimal MovePointLeft(int n)
        {
            // Compute the new scale in long (so an int.MinValue scale cannot wrap when later negated) and
            // let CreateNormalizedFromScale fold any negative result back into the unscaled value at scale 0.
            return CreateNormalizedFromScale(_unscaledValue, (long)_scale + n);
        }

        /// <summary>
        /// Returns a value numerically equal to this one with the decimal point moved <paramref name="n"/>
        /// places to the right (multiplying by <c>10<sup>n</sup></c>). A negative <paramref name="n"/> moves it left.
        /// </summary>
        /// <param name="n">The number of places to move the decimal point right.</param>
        /// <returns>The value with the decimal point moved.</returns>
        /// <exception cref="OverflowException">Thrown when the resulting scale does not fit in a 32-bit integer.</exception>
        /// <remarks>This mirrors Java's <c>BigDecimal.movePointRight</c>: the result scale is never negative.</remarks>
        public BigDecimal MovePointRight(int n)
        {
            // Compute the new scale in long (so an int.MinValue scale cannot wrap when later negated) and
            // let CreateNormalizedFromScale fold any negative result back into the unscaled value at scale 0.
            return CreateNormalizedFromScale(_unscaledValue, (long)_scale - n);
        }

        /// <summary>
        /// Returns a value numerically equal to <c>this &#215; 10<sup>n</sup></c>. Only the scale changes;
        /// the unscaled value is unaffected, so a negative scale may result.
        /// </summary>
        /// <param name="n">The power of ten to apply.</param>
        /// <returns>The scaled value.</returns>
        /// <exception cref="OverflowException">Thrown when the resulting scale does not fit in a 32-bit integer.</exception>
        /// <remarks>This mirrors Java's <c>BigDecimal.scaleByPowerOfTen</c>.</remarks>
        public BigDecimal ScaleByPowerOfTen(int n) => new BigDecimal(_unscaledValue, CheckScaleRange((long)_scale - n));

        /// <summary>Returns the greater of this value and <paramref name="other"/> (numeric comparison).</summary>
        /// <param name="other">The value to compare against.</param>
        /// <returns>This value if it is greater than or equal to <paramref name="other"/>; otherwise <paramref name="other"/>.</returns>
        /// <remarks>This mirrors Java's <c>BigDecimal.max</c>.</remarks>
        public BigDecimal Max(BigDecimal other) => CompareTo(other) >= 0 ? this : other;

        /// <summary>Returns the lesser of this value and <paramref name="other"/> (numeric comparison).</summary>
        /// <param name="other">The value to compare against.</param>
        /// <returns>This value if it is less than or equal to <paramref name="other"/>; otherwise <paramref name="other"/>.</returns>
        /// <remarks>This mirrors Java's <c>BigDecimal.min</c>.</remarks>
        public BigDecimal Min(BigDecimal other) => CompareTo(other) <= 0 ? this : other;

        /// <summary>
        /// Expresses an integer value (scale 0) at its preferred scale, padding with trailing zeros when the
        /// preferred scale is positive or stripping existing trailing zeros down toward a negative preferred
        /// scale, never altering the numeric value. Used by <see cref="DivideToIntegralValue"/>.
        /// </summary>
        private static BigDecimal IntegerAtPreferredScale(BigInteger integer, long preferredScale)
        {
            if (integer.IsZero)
            {
                // Zero is numerically scale-independent; clamp the preferred scale into int range rather
                // than overflow (the exact scale of a zero result is only cosmetic), preserving its sign to
                // match the preferred scale Java reports for a zero integral quotient.
                int zeroScale = preferredScale > int.MaxValue
                    ? int.MaxValue
                    : preferredScale < int.MinValue ? int.MinValue : (int)preferredScale;
                return new BigDecimal(BigInteger.Zero, zeroScale);
            }

            if (preferredScale >= 0)
            {
                int scale = CheckScaleRange(preferredScale);
                return new BigDecimal(integer * PowerOfTen(scale), scale);
            }

            // Negative preferred scale: remove trailing zeros (each reduces the scale by one) until the
            // scale reaches the preferred value or no trailing zero remains.
            BigInteger unscaled = integer;
            long scaleValue = 0;
            while (scaleValue > preferredScale)
            {
                BigInteger stripRemainder;
                BigInteger stripped = BigInteger.DivRem(unscaled, BigIntegerTen, out stripRemainder);
                if (!stripRemainder.IsZero)
                    break;

                unscaled = stripped;
                scaleValue--;
            }

            return new BigDecimal(unscaled, (int)scaleValue);
        }

        /// <summary>Adds two values. See <see cref="Add(BigDecimal)"/>.</summary>
        public static BigDecimal operator +(BigDecimal left, BigDecimal right) => left.Add(right);

        /// <summary>Subtracts the right value from the left. See <see cref="Subtract(BigDecimal)"/>.</summary>
        public static BigDecimal operator -(BigDecimal left, BigDecimal right) => left.Subtract(right);

        /// <summary>Multiplies two values. See <see cref="Multiply(BigDecimal)"/>.</summary>
        public static BigDecimal operator *(BigDecimal left, BigDecimal right) => left.Multiply(right);

        /// <summary>
        /// Divides the left value by the right, requiring an exact, terminating result.
        /// See <see cref="Divide(BigDecimal)"/>.
        /// </summary>
        public static BigDecimal operator /(BigDecimal left, BigDecimal right) => left.Divide(right);

        /// <summary>
        /// Returns the remainder of dividing the left value by the right. See <see cref="Remainder(BigDecimal)"/>.
        /// </summary>
        public static BigDecimal operator %(BigDecimal left, BigDecimal right) => left.Remainder(right);

        /// <summary>Returns the value unchanged.</summary>
        public static BigDecimal operator +(BigDecimal value) => value;

        /// <summary>Returns the negation of the value. See <see cref="Negate()"/>.</summary>
        public static BigDecimal operator -(BigDecimal value) => value.Negate();

        /// <summary>
        /// Rescales both operands to their common (larger) scale, producing two unscaled values that can
        /// be added or compared directly.
        /// </summary>
        private static void AlignScales(BigDecimal a, BigDecimal b, out BigInteger left, out BigInteger right, out int scale)
        {
            if (a._scale == b._scale)
            {
                left = a._unscaledValue;
                right = b._unscaledValue;
                scale = a._scale;
            }
            else if (a._scale > b._scale)
            {
                // The scale difference (computed in long so two opposite-signed int scales cannot wrap)
                // is the power of ten the lower-scale operand is multiplied by; it must fit in int.
                right = b._unscaledValue * PowerOfTen(CheckScaleRange((long)a._scale - b._scale));
                left = a._unscaledValue;
                scale = a._scale;
            }
            else
            {
                left = a._unscaledValue * PowerOfTen(CheckScaleRange((long)b._scale - a._scale));
                right = b._unscaledValue;
                scale = b._scale;
            }
        }

        /// <summary>
        /// Builds a <see cref="BigDecimal"/> from an unscaled value and a (possibly out-of-range) scale.
        /// If the scale is negative it is absorbed into the unscaled value by multiplying by a power of
        /// ten; otherwise the scale is validated to fit in a 32-bit integer.
        /// </summary>
        private static BigDecimal CreateNormalizedFromScale(BigInteger unscaledValue, long scale)
        {
            if (scale >= 0)
            {
                if (scale > int.MaxValue)
                    throw new OverflowException("The resulting scale is outside the range of a 32-bit integer.");
                return new BigDecimal(unscaledValue, (int)scale);
            }

            // Negative scale: fold the negative power of ten into the unscaled value to keep scale = 0.
            long magnitude = -scale;
            if (magnitude > int.MaxValue)
                throw new OverflowException("The resulting scale is outside the range of a 32-bit integer.");

            return new BigDecimal(unscaledValue * PowerOfTen((int)magnitude), 0);
        }

        /// <summary>
        /// Subtracts two scales, clamping to the 32-bit integer range instead of overflowing. Used for the
        /// preferred scale of a zero quotient, where the exact scale is cosmetic.
        /// </summary>
        private static int SaturatingSubtract(int a, int b)
        {
            long result = (long)a - b;
            if (result > int.MaxValue)
                return int.MaxValue;
            if (result < int.MinValue)
                return int.MinValue;
            return (int)result;
        }
    }
}
