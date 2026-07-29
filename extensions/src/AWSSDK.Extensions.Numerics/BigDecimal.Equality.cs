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
        /// Compares this value with another <see cref="BigDecimal"/>. The comparison is numeric, so
        /// values that are equal in magnitude but differ in scale (such as <c>2.0</c> and <c>2.00</c>)
        /// compare as equal.
        /// </summary>
        /// <param name="other">The value to compare against.</param>
        /// <returns>
        /// A negative number if this value is less than <paramref name="other"/>, zero if they are
        /// numerically equal, or a positive number if this value is greater.
        /// </returns>
        public int CompareTo(BigDecimal other)
        {
            // Fast path: differing signs settle the comparison immediately.
            int signComparison = _unscaledValue.Sign.CompareTo(other._unscaledValue.Sign);
            if (signComparison != 0)
                return signComparison;

            // Same sign. If this value is zero the other is zero too (their signs matched), so any two
            // zeros are numerically equal regardless of scale — settle it here without materializing a
            // power of ten for an extreme scale.
            if (_unscaledValue.IsZero)
                return 0;

            // Same scale: compare unscaled values directly.
            if (_scale == other._scale)
                return _unscaledValue.CompareTo(other._unscaledValue);

            // Scales differ. Compare adjusted exponents first. A value's magnitude lies in
            // [10^(ae-1), 10^ae) where ae = precision - scale, so unequal adjusted exponents place the
            // two magnitudes in disjoint ranges and settle the comparison without any alignment. This
            // mirrors Java's compareMagnitude and, crucially, avoids materializing 10^|scaleDiff| for a
            // pair of cheaply-stored extreme scales (the case that would otherwise hit the DoS guard).
            int sign = _unscaledValue.Sign; // equal to other's sign, and non-zero
            long thisAdjustedExponent = (long)Precision - _scale;
            long otherAdjustedExponent = (long)other.Precision - other._scale;
            if (thisAdjustedExponent != otherAdjustedExponent)
            {
                int magnitudeComparison = thisAdjustedExponent < otherAdjustedExponent ? -1 : 1;
                return sign > 0 ? magnitudeComparison : -magnitudeComparison;
            }

            // Equal adjusted exponents: scaleDiff == precisionDiff, so aligning to the larger scale
            // multiplies by a power of ten bounded by the real digit-count difference — never by the raw
            // (possibly extreme) scale. The difference is computed in long so two opposite-signed int
            // scales cannot wrap before the int-range check.
            if (_scale > other._scale)
            {
                BigInteger scaledOther = other._unscaledValue * PowerOfTen(CheckScaleRange((long)_scale - other._scale));
                return _unscaledValue.CompareTo(scaledOther);
            }
            else
            {
                BigInteger scaledThis = _unscaledValue * PowerOfTen(CheckScaleRange((long)other._scale - _scale));
                return scaledThis.CompareTo(other._unscaledValue);
            }
        }

        /// <summary>
        /// Compares this value with another object. See <see cref="CompareTo(BigDecimal)"/> for the
        /// comparison semantics.
        /// </summary>
        /// <param name="obj">The object to compare against. May be <c>null</c>.</param>
        /// <returns>
        /// A negative number, zero, or a positive number, per <see cref="CompareTo(BigDecimal)"/>.
        /// A <c>null</c> object sorts before any value (returns a positive number).
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="obj"/> is not a <see cref="BigDecimal"/>.</exception>
        public int CompareTo(object obj)
        {
            if (obj is null)
                return 1;

            if (obj is BigDecimal other)
                return CompareTo(other);

            throw new ArgumentException("Object must be of type BigDecimal.", nameof(obj));
        }

        /// <summary>
        /// Determines whether this value is numerically equal to another <see cref="BigDecimal"/>.
        /// Values that differ only in scale (such as <c>2.0</c> and <c>2.00</c>) are considered equal.
        /// </summary>
        /// <param name="other">The value to compare against.</param>
        /// <returns><c>true</c> if the values are numerically equal; otherwise <c>false</c>.</returns>
        public bool Equals(BigDecimal other) => CompareTo(other) == 0;

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is BigDecimal other && Equals(other);

        /// <summary>
        /// Returns a hash code that is consistent with numeric equality: two numerically equal values
        /// produce the same hash code regardless of their scale.
        /// </summary>
        /// <returns>A hash code for this value.</returns>
        public override int GetHashCode()
        {
            // All representations of zero hash identically.
            if (_unscaledValue.IsZero)
                return 0;

            // Normalize to a canonical (unscaledValue, scale) by stripping trailing zeros so that, for
            // example, (20, 1) and (200, 2) both reduce to (2, 0) and hash the same.
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

            unchecked
            {
                return (unscaled.GetHashCode() * 397) ^ scale;
            }
        }

        /// <summary>Indicates whether two values are numerically equal.</summary>
        public static bool operator ==(BigDecimal left, BigDecimal right) => left.CompareTo(right) == 0;

        /// <summary>Indicates whether two values are not numerically equal.</summary>
        public static bool operator !=(BigDecimal left, BigDecimal right) => left.CompareTo(right) != 0;

        /// <summary>Indicates whether the left value is numerically less than the right value.</summary>
        public static bool operator <(BigDecimal left, BigDecimal right) => left.CompareTo(right) < 0;

        /// <summary>Indicates whether the left value is numerically less than or equal to the right value.</summary>
        public static bool operator <=(BigDecimal left, BigDecimal right) => left.CompareTo(right) <= 0;

        /// <summary>Indicates whether the left value is numerically greater than the right value.</summary>
        public static bool operator >(BigDecimal left, BigDecimal right) => left.CompareTo(right) > 0;

        /// <summary>Indicates whether the left value is numerically greater than or equal to the right value.</summary>
        public static bool operator >=(BigDecimal left, BigDecimal right) => left.CompareTo(right) >= 0;
    }
}
