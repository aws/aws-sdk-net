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

namespace Amazon.Extensions.Numerics
{
    /// <summary>
    /// Encapsulates the precision and rounding settings used by certain <see cref="BigDecimal"/>
    /// operations, most notably <see cref="BigDecimal.Divide(BigDecimal, MathContext)"/> and
    /// <see cref="BigDecimal.Round(MathContext)"/>.
    /// </summary>
    /// <remarks>
    /// The semantics mirror Java's <c>java.math.MathContext</c>. A <see cref="Precision"/> of
    /// <c>0</c> means "unlimited" precision: the operation must produce an exact result or it will
    /// throw an <see cref="ArithmeticException"/>.
    /// </remarks>
    public readonly struct MathContext : IEquatable<MathContext>
    {
        /// <summary>
        /// The number of significant digits to retain in the result. A value of <c>0</c> indicates
        /// unlimited precision (the result must be exact).
        /// </summary>
        public int Precision { get; }

        /// <summary>
        /// The rounding mode to apply when the result must be rounded to <see cref="Precision"/> digits.
        /// </summary>
        public RoundingMode RoundingMode { get; }

        /// <summary>
        /// Initializes a new <see cref="MathContext"/> with the specified precision and rounding mode.
        /// </summary>
        /// <param name="precision">The number of significant digits; must be non-negative. <c>0</c> means unlimited.</param>
        /// <param name="roundingMode">The rounding mode to apply.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="precision"/> is negative.</exception>
        public MathContext(int precision, RoundingMode roundingMode)
        {
            if (precision < 0)
                throw new ArgumentOutOfRangeException(nameof(precision), "Precision cannot be negative.");

            Precision = precision;
            RoundingMode = roundingMode;
        }

        /// <summary>
        /// Initializes a new <see cref="MathContext"/> with the specified precision and a default
        /// rounding mode of <see cref="Numerics.RoundingMode.HalfUp"/>.
        /// </summary>
        /// <param name="precision">The number of significant digits; must be non-negative. <c>0</c> means unlimited.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="precision"/> is negative.</exception>
        public MathContext(int precision)
            : this(precision, RoundingMode.HalfUp)
        {
        }

        /// <summary>
        /// A context with unlimited precision. Operations using this context must produce an exact
        /// result or throw an <see cref="ArithmeticException"/>.
        /// </summary>
        public static MathContext Unlimited { get; } = new MathContext(0, RoundingMode.HalfUp);

        /// <summary>
        /// A context matching the IEEE 754 decimal32 format: 7 significant digits, <see cref="Numerics.RoundingMode.HalfEven"/>.
        /// </summary>
        public static MathContext Decimal32 { get; } = new MathContext(7, RoundingMode.HalfEven);

        /// <summary>
        /// A context matching the IEEE 754 decimal64 format: 16 significant digits, <see cref="Numerics.RoundingMode.HalfEven"/>.
        /// </summary>
        public static MathContext Decimal64 { get; } = new MathContext(16, RoundingMode.HalfEven);

        /// <summary>
        /// A context matching the IEEE 754 decimal128 format: 34 significant digits, <see cref="Numerics.RoundingMode.HalfEven"/>.
        /// </summary>
        public static MathContext Decimal128 { get; } = new MathContext(34, RoundingMode.HalfEven);

        /// <inheritdoc/>
        public bool Equals(MathContext other) =>
            Precision == other.Precision && RoundingMode == other.RoundingMode;

        /// <inheritdoc/>
        public override bool Equals(object obj) => obj is MathContext other && Equals(other);

        /// <inheritdoc/>
        public override int GetHashCode() => (Precision * 397) ^ (int)RoundingMode;

        /// <summary>
        /// Indicates whether two <see cref="MathContext"/> values are equal.
        /// </summary>
        public static bool operator ==(MathContext left, MathContext right) => left.Equals(right);

        /// <summary>
        /// Indicates whether two <see cref="MathContext"/> values are not equal.
        /// </summary>
        public static bool operator !=(MathContext left, MathContext right) => !left.Equals(right);

        /// <inheritdoc/>
        public override string ToString() =>
            "precision=" + Precision.ToString(System.Globalization.CultureInfo.InvariantCulture) +
            " roundingMode=" + RoundingMode;
    }
}
