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

namespace Amazon.Extensions.Numerics
{
    /// <summary>
    /// Specifies the rounding behavior to apply when a <see cref="BigDecimal"/> operation
    /// (such as division or a scale reduction) produces a result that cannot be represented
    /// exactly at the requested precision or scale.
    /// </summary>
    /// <remarks>
    /// The semantics mirror Java's <c>java.math.RoundingMode</c>.
    /// </remarks>
    public enum RoundingMode
    {
        /// <summary>
        /// Rounds away from zero. Always increments the digit prior to a non-zero discarded fraction.
        /// </summary>
        Up,

        /// <summary>
        /// Rounds toward zero. Never increments the digit prior to a discarded fraction (truncates).
        /// </summary>
        Down,

        /// <summary>
        /// Rounds toward positive infinity. Behaves like <see cref="Up"/> for positive values and
        /// like <see cref="Down"/> for negative values.
        /// </summary>
        Ceiling,

        /// <summary>
        /// Rounds toward negative infinity. Behaves like <see cref="Down"/> for positive values and
        /// like <see cref="Up"/> for negative values.
        /// </summary>
        Floor,

        /// <summary>
        /// Rounds toward the nearest neighbor; if both neighbors are equidistant, rounds away from zero.
        /// This is the rounding most people are taught in school.
        /// </summary>
        HalfUp,

        /// <summary>
        /// Rounds toward the nearest neighbor; if both neighbors are equidistant, rounds toward zero.
        /// </summary>
        HalfDown,

        /// <summary>
        /// Rounds toward the nearest neighbor; if both neighbors are equidistant, rounds toward the
        /// even neighbor. Also known as banker's rounding; minimizes cumulative rounding bias.
        /// </summary>
        HalfEven,

        /// <summary>
        /// Asserts that the requested operation has an exact result and therefore no rounding is
        /// necessary. If the result would in fact require rounding, an <see cref="System.ArithmeticException"/>
        /// is thrown.
        /// </summary>
        Unnecessary
    }
}
