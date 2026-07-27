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
        /// Converts the string representation of a number to its <see cref="BigDecimal"/> equivalent,
        /// using the current culture.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        /// <exception cref="FormatException">Thrown when <paramref name="value"/> is not in a valid format.</exception>
        public static BigDecimal Parse(string value) => Parse(value, CultureInfo.CurrentCulture);

        /// <summary>
        /// Converts the string representation of a number to its <see cref="BigDecimal"/> equivalent,
        /// using the specified format provider.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="provider">A format provider supplying the decimal separator and sign symbols.</param>
        /// <returns>The parsed value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="value"/> is <c>null</c>.</exception>
        /// <exception cref="FormatException">Thrown when <paramref name="value"/> is not in a valid format.</exception>
        /// <exception cref="OverflowException">Thrown when the value's scale does not fit in a 32-bit integer.</exception>
        /// <remarks>
        /// Leading and trailing whitespace is trimmed before parsing, following the convention of the
        /// built-in .NET numeric parsers. This is a deliberate divergence from Java's
        /// <c>new BigDecimal(String)</c>, which rejects surrounding whitespace.
        /// </remarks>
        public static BigDecimal Parse(string value, IFormatProvider provider)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(value));

            BigDecimal result;
            string error;
            if (!TryParseInternal(value, provider, out result, out error))
                throw new FormatException(error);

            return result;
        }

        /// <summary>
        /// Attempts to convert the string representation of a number to its <see cref="BigDecimal"/>
        /// equivalent, using the current culture.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="result">When this method returns, contains the parsed value or <see cref="Zero"/> on failure.</param>
        /// <returns><c>true</c> if the conversion succeeded; otherwise <c>false</c>.</returns>
        public static bool TryParse(string value, out BigDecimal result) =>
            TryParse(value, CultureInfo.CurrentCulture, out result);

        /// <summary>
        /// Attempts to convert the string representation of a number to its <see cref="BigDecimal"/>
        /// equivalent, using the specified format provider.
        /// </summary>
        /// <param name="value">A string containing a number to convert.</param>
        /// <param name="provider">A format provider supplying the decimal separator and sign symbols.</param>
        /// <param name="result">When this method returns, contains the parsed value or <see cref="Zero"/> on failure.</param>
        /// <returns><c>true</c> if the conversion succeeded; otherwise <c>false</c>.</returns>
        public static bool TryParse(string value, IFormatProvider provider, out BigDecimal result)
        {
            if (value is null)
            {
                result = Zero;
                return false;
            }

            string error;
            return TryParseInternal(value, provider, out result, out error);
        }

        private static bool TryParseInternal(string value, IFormatProvider provider, out BigDecimal result, out string error)
        {
            result = Zero;
            error = null;

            NumberFormatInfo nfi = NumberFormatInfo.GetInstance(provider);
            string decimalSeparator = nfi.NumberDecimalSeparator;
            string positiveSign = nfi.PositiveSign;
            string negativeSign = nfi.NegativeSign;

            string text = value.Trim();
            if (text.Length == 0)
            {
                error = "Input string was empty.";
                return false;
            }

            int index = 0;
            bool negative = false;

            // Leading sign.
            if (StartsWith(text, index, positiveSign))
            {
                index += positiveSign.Length;
            }
            else if (StartsWith(text, index, negativeSign))
            {
                negative = true;
                index += negativeSign.Length;
            }

            var digits = new StringBuilder();
            int fractionDigits = 0;
            bool seenDigit = false;
            bool seenDecimalPoint = false;

            // Integer and fraction digits.
            while (index < text.Length)
            {
                char c = text[index];
                if (c >= '0' && c <= '9')
                {
                    digits.Append(c);
                    if (seenDecimalPoint)
                        fractionDigits++;
                    seenDigit = true;
                    index++;
                }
                else if (!seenDecimalPoint && StartsWith(text, index, decimalSeparator))
                {
                    seenDecimalPoint = true;
                    index += decimalSeparator.Length;
                }
                else
                {
                    break;
                }
            }

            if (!seenDigit)
            {
                error = "Input string '" + value + "' was not in a correct format.";
                return false;
            }

            // Optional exponent.
            long exponent = 0;
            if (index < text.Length && (text[index] == 'e' || text[index] == 'E'))
            {
                index++;
                if (!TryParseExponent(text, ref index, out exponent, out error))
                    return false;
            }

            // Any trailing characters are invalid.
            if (index != text.Length)
            {
                error = "Input string '" + value + "' was not in a correct format.";
                return false;
            }

            BigInteger unscaled = digits.Length == 0 ? BigInteger.Zero : BigInteger.Parse(digits.ToString(), CultureInfo.InvariantCulture);
            if (negative)
                unscaled = -unscaled;

            long scale = (long)fractionDigits - exponent;
            if (scale > int.MaxValue || scale < int.MinValue)
            {
                error = "The scale of the parsed value is outside the range of a 32-bit integer.";
                return false;
            }

            result = new BigDecimal(unscaled, (int)scale);
            return true;
        }

        private static bool TryParseExponent(string text, ref int index, out long exponent, out string error)
        {
            exponent = 0;
            error = null;

            bool expNegative = false;
            if (index < text.Length && (text[index] == '+' || text[index] == '-'))
            {
                expNegative = text[index] == '-';
                index++;
            }

            int startDigits = index;
            long magnitude = 0;
            while (index < text.Length && text[index] >= '0' && text[index] <= '9')
            {
                magnitude = magnitude * 10 + (text[index] - '0');
                if (magnitude > int.MaxValue)
                {
                    error = "The exponent is outside the supported range.";
                    return false;
                }
                index++;
            }

            if (index == startDigits)
            {
                error = "The exponent did not contain any digits.";
                return false;
            }

            exponent = expNegative ? -magnitude : magnitude;
            return true;
        }

        private static bool StartsWith(string text, int index, string token)
        {
            if (string.IsNullOrEmpty(token) || index + token.Length > text.Length)
                return false;

            return string.CompareOrdinal(text, index, token, 0, token.Length) == 0;
        }
    }
}
