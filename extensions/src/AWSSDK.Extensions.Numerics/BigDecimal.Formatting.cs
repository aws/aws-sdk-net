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
using System.Numerics;
using System.Text;

namespace Amazon.Extensions.Numerics
{
    public readonly partial struct BigDecimal
    {
        /// <summary>
        /// Returns the string representation of this value using the current culture. Uses scientific
        /// notation when the magnitude is very large or very small, following the same layout rules as
        /// Java's <c>BigDecimal.toString</c>. The result round-trips through <see cref="Parse(string)"/>.
        /// </summary>
        /// <returns>The string representation.</returns>
        public override string ToString() => ToString(CultureInfo.CurrentCulture);

        /// <summary>
        /// Returns the string representation of this value using the specified format provider.
        /// </summary>
        /// <param name="provider">A format provider supplying the decimal separator and sign symbols.</param>
        /// <returns>The string representation.</returns>
        public string ToString(IFormatProvider provider) => Format(provider, useScientific: true);

        /// <summary>
        /// Returns the string representation of this value. The <paramref name="format"/> argument is
        /// accepted for <see cref="IFormattable"/> compatibility; the general (<c>"G"</c>) and null formats
        /// produce the default representation.
        /// </summary>
        /// <param name="format">The format string. Only the general format is supported.</param>
        /// <param name="formatProvider">A format provider supplying the decimal separator and sign symbols.</param>
        /// <returns>The string representation.</returns>
        public string ToString(string format, IFormatProvider formatProvider) => Format(formatProvider, useScientific: true);

        /// <summary>
        /// Returns the string representation of this value without ever using scientific notation.
        /// </summary>
        /// <returns>The plain (non-scientific) string representation.</returns>
        public string ToPlainString() => Format(CultureInfo.CurrentCulture, useScientific: false);

        /// <summary>
        /// Returns the plain string representation of this value using the specified format provider.
        /// </summary>
        /// <param name="provider">A format provider supplying the decimal separator and sign symbols.</param>
        /// <returns>The plain (non-scientific) string representation.</returns>
        public string ToPlainString(IFormatProvider provider) => Format(provider, useScientific: false);

        private string Format(IFormatProvider provider, bool useScientific)
        {
            NumberFormatInfo nfi = NumberFormatInfo.GetInstance(provider);
            string decimalSeparator = nfi.NumberDecimalSeparator;
            string negativeSign = nfi.NegativeSign;

            bool isNegative = _unscaledValue.Sign < 0;
            string digits = BigInteger.Abs(_unscaledValue).ToString(CultureInfo.InvariantCulture);

            // adjustedExponent is the power of ten of the most significant digit when written as d.dddE+exp.
            long adjustedExponent = (long)(digits.Length - 1) - _scale;

            string body = useScientific && (_scale < 0 || adjustedExponent < -6)
                ? FormatScientific(digits, adjustedExponent, decimalSeparator)
                : FormatPlain(digits, _scale, decimalSeparator);

            return isNegative ? negativeSign + body : body;
        }

        private static string FormatPlain(string digits, int scale, string decimalSeparator)
        {
            if (scale == 0)
                return digits;

            if (scale < 0)
            {
                // Append |scale| trailing zeros: the value is an integer scaled up by a power of ten. A scale
                // this far below zero comes from an extreme, typically untrusted value; appending that many
                // zeros would exhaust memory, so reject it with a clear error instead (see GuardMaterializedDigits).
                long zeros = -(long)scale;
                GuardMaterializedDigits(digits.Length + zeros);
                var builder = new StringBuilder(digits.Length + (int)zeros);
                builder.Append(digits);
                builder.Append('0', (int)zeros);
                return builder.ToString();
            }

            // scale > 0: place the decimal point so that 'scale' digits sit to its right.
            if (digits.Length > scale)
            {
                int pointIndex = digits.Length - scale;
                return digits.Substring(0, pointIndex) + decimalSeparator + digits.Substring(pointIndex);
            }

            // Need leading "0." plus padding zeros before the digits. An extreme scale would pad with that many
            // zeros and exhaust memory, so it is rejected the same way as the negative-scale branch above.
            GuardMaterializedDigits((long)scale + 2);
            var sb = new StringBuilder(scale + 2 + decimalSeparator.Length);
            sb.Append('0');
            sb.Append(decimalSeparator);
            sb.Append('0', scale - digits.Length);
            sb.Append(digits);
            return sb.ToString();
        }

        private static string FormatScientific(string digits, long adjustedExponent, string decimalSeparator)
        {
            var sb = new StringBuilder(digits.Length + decimalSeparator.Length + 6);
            sb.Append(digits[0]);
            if (digits.Length > 1)
            {
                sb.Append(decimalSeparator);
                sb.Append(digits, 1, digits.Length - 1);
            }

            sb.Append('E');
            if (adjustedExponent >= 0)
                sb.Append('+');
            sb.Append(adjustedExponent.ToString(CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
