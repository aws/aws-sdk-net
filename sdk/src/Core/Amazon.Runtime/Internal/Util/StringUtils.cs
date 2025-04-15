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
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;

using Amazon.Util;
using System.Linq;
using System.Diagnostics.CodeAnalysis;
using System.Buffers;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Utilities for converting objects to strings or strings to objects. Used by the marshaller classes.
    /// </summary>
    public static class StringUtils
    {
        private static readonly Encoding UTF_8 = Encoding.UTF8;
        private static readonly char[] rfc7230HeaderFieldValueDelimeters = "\"(),/:;<=>?@[\\]{}".ToCharArray();

        public static string FromString(String value)
        {
            return value;
        }

        public static string FromStringWithSlashEncoding(String value)
        {
            return AWSSDKUtils.UrlEncodeSlash(FromString(value));
        }

        public static string FromString(ConstantClass value)
        {
            return value == null ? "" : value.Intern().Value;
        }

        public static string FromMemoryStream(MemoryStream value)
        {
            if (value.TryGetBuffer(out var buffer))
            {
                return Convert.ToBase64String(buffer.Array, buffer.Offset, buffer.Count);
            }
            else
            {
                var array = ArrayPool<byte>.Shared.Rent((int)value.Length);
                try
                {
                    value.Read(array, 0, (int)value.Length);
                    return Convert.ToBase64String(array, 0, (int)value.Length);
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(array);
                }
            }
        }

        public static string FromInt(int value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromInt(int? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromLong(long value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromLong(long? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromFloat(float value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromFloat(float? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromSpecialFloatValue(float value)
        {
            if (float.IsPositiveInfinity(value))
            {
                return "Infinity";
            }
            else if (float.IsNegativeInfinity(value))
            {
                return "-Infinity";
            }
            else if (float.IsNaN(value))
            {
                return "NaN";
            }
            else
            {
                throw new ArgumentException("Only float.PositiveInfinity, float.NegativeInfinity, or float.Nan are valid");
            }
        }
        public static bool IsSpecialFloatValue(float value)
        {
            return float.IsInfinity(value) || float.IsNaN(value);
        }
        public static bool IsSpecialDoubleValue(double value)
        {
            return double.IsInfinity(value) || double.IsNaN(value);
        }

        public static string FromSpecialDoubleValue(double value)
        {
            if (double.IsPositiveInfinity(value))
            {
                return "Infinity";
            }
            else if (double.IsNegativeInfinity(value))
            {
                return "-Infinity";
            }
            else if (double.IsNaN(value))
            {
                return "NaN";
            }
            else
            {
                throw new ArgumentException("Only double.PositiveInfinity, double.NegativeInfinity, or double.Nan are valid");
            }
        }
        public static string FromBool(bool? value)
        {
            return FromBool(value.GetValueOrDefault());
        }

        public static string FromBool(bool value)
        {
            return value ? "true" : "false";
        }


        /// <summary>
        /// Converts a DateTime to ISO8601 formatted string.
        /// </summary>
        public static string FromDateTimeToISO8601(DateTime value)
        {
            return value.ToUniversalTime().ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a nullable DateTime to ISO8601 formatted string.
        /// </summary>
        public static string FromDateTimeToISO8601(DateTime? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToUniversalTime().ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a DateTime to ISO8601 formatted string without milliseconds.
        /// </summary>
        public static string FromDateTimeToISO8601NoMs(DateTime value)
        {
            return value.ToUniversalTime().ToString(AWSSDKUtils.ISO8601DateFormatNoMS, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a nullable DateTime to ISO8601 formatted string without milliseconds.
        /// </summary>
        public static string FromDateTimeToISO8601NoMs(DateTime? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToUniversalTime().ToString(AWSSDKUtils.ISO8601DateFormatNoMS, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a DateTime to ISO8601 formatted string with milliseconds
        /// if they are not zero.
        /// </summary>
        public static string FromDateTimeToISO8601WithOptionalMs(DateTime value)
        {
            var format = value.Millisecond == 0
                ? AWSSDKUtils.ISO8601DateFormatNoMS
                : AWSSDKUtils.ISO8601DateFormat;
            return value.ToUniversalTime().ToString(format, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a nullable DateTime to ISO8601 formatted string with milliseconds
        /// if they are not zero.
        /// </summary>
        public static string FromDateTimeToISO8601WithOptionalMs(DateTime? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            var format = value.Value.Millisecond == 0
                ? AWSSDKUtils.ISO8601DateFormatNoMS
                : AWSSDKUtils.ISO8601DateFormat;
            return value.Value.ToUniversalTime().ToString(format, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a DateTime to RFC822 formatted string.
        /// </summary>
        public static string FromDateTimeToRFC822(DateTime value)
        {
            return value.ToUniversalTime().ToString(
                AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a nullable DateTime to RFC822 formatted string.
        /// </summary>
        public static string FromDateTimeToRFC822(DateTime? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToUniversalTime().ToString(
                AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts a DateTime to Unix epoch time formatted string.
        /// </summary>
        public static string FromDateTimeToUnixTimestamp(DateTime value)
        {
            return AWSSDKUtils.ConvertToUnixEpochSecondsString(value);
        }

        /// <summary>
        /// Converts a nullable DateTime to Unix epoch time formatted string.
        /// </summary>
        public static string FromDateTimeToUnixTimestamp(DateTime? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return AWSSDKUtils.ConvertToUnixEpochSecondsString(value.Value);
        }

        public static string FromDouble(double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromDouble(double? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromDecimal(decimal value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }

        public static string FromDecimal(decimal? value)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return value.Value.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Combines an enumerable of enums into a comma-separated string to be marshalled as a header.
        /// </summary>
        /// <param name="values">List of enums</param>
        /// <returns>Header value representing the list of enums</returns>
        public static string FromList(IEnumerable<Enum> values)
        {
            return FromList(values?.Select(x => x.ToString()));
        }

        /// <summary>
        /// Combines a list of enums into a comma-separated string to be marshalled as a header.
        /// </summary>
        /// <param name="values">List of enums</param>
        /// <returns>Header value representing the list of enums</returns>
        public static string FromList(List<Enum> values)
        {
            return FromList(values?.Select(x => x.ToString()));
        }

        /// <summary>
        /// Combines an enumerable of ConstantClass enums into a comma-separated string to be marshalled as a header
        /// </summary>
        /// <param name="values">List of enums</param>
        /// <returns>Header value representing the list of enums</returns>
        public static string FromList<T>(IEnumerable<T> values) where T : ConstantClass
        {
            return FromList(values?.Select(x => x.ToString()));
        }

        /// <summary>
        /// Combines a list of ConstantClass enums into a comma-separated string to be marshalled as a header
        /// </summary>
        /// <param name="values">List of enums</param>
        /// <returns>Header value representing the list of enums</returns>
        public static string FromList<T>(List<T> values) where T : ConstantClass
        {
            return FromList(values?.Select(x => x.ToString()));
        }

        /// <summary>
        /// Combines an enumerable of T into a comma-separated string to be marshalled as a header.
        /// </summary>
        /// <param name="values">List of T</param>
        /// <returns>Header value representing the list of T.</returns>
        public static string FromValueTypeList<T>(IEnumerable<T> values) where T : struct
        {
            return FromList(values?.Select(x => x.ToString()));
        }

        /// <summary>
        /// Combines a List of T into a comma-separated string to be marshalled as a header.
        /// </summary>
        /// <param name="values">List of T</param>
        /// <returns>Header value representing the list of T</returns>
        [SuppressMessage("Microsoft.Globalization", "CA1308", Justification = "Value is not surfaced to user. Booleans have been lowercased by SDK precedent.")]
        public static string FromValueTypeList<T>(List<T> values) where T : struct
        {
            // ToString() on boolean types automatically Pascal Cases. Xml-based protocols
            // are case sensitive and accept "true" and "false" as the valid set of booleans.
            // and we should be returning the booleans as is.
            if (typeof(T) == typeof(bool))
            {
                return FromList(values?.Select(x => x.ToString().ToLowerInvariant()));
            }
            // See https://datatracker.ietf.org/doc/html/rfc7231.html#section-7.1.1.1
            // FromDateTimeToRFC822 is compatible with IMF-fixdate
            else if (typeof(T) == typeof(DateTime))
            {
                return string.Join(",", values?.Select(x => FromDateTimeToRFC822((DateTime)(object)x)));
            }

            return FromList(values?.Select(x => x.ToString()));
        }

        /// <summary>
        /// Combines a list of strings into a comma-separated string to be marshalled as a header
        /// </summary>
        /// <param name="values">List of strings</param>
        /// <returns>Header value representing the list of strings</returns>
        public static string FromList(IEnumerable<string> values)
        {
            if (values == null || values.Count() == 0)
            {
                return "";
            }

            // Comma separate any non-null/non-empty entries with below formatting
            return string.Join(",", values.Where(x => !string.IsNullOrEmpty(x)).Select(x => EscapeHeaderListEntry(x)).ToArray());
        }

        /// <summary>
        /// Escapes a header list entry wrapping each item with quotes where a quote 
        /// or comma exists in the entry. All backslashes are encoded in the item.
        /// </summary>
        /// <param name="headerListEntry">Single item from the header's list</param>
        /// <returns>Item wrapped in double quotes if appropriate</returns>
        private static string EscapeHeaderListEntry(string headerListEntry)
        {
            //https://datatracker.ietf.org/doc/html/rfc7230#section-3.2.6

            // If it contains any of the field value delimeters double quote the string. Since
            // \" is one of the field value delimeters it is must be escaped with a \ if it exists.
            if (headerListEntry.IndexOfAny(rfc7230HeaderFieldValueDelimeters) != -1)
            {
                return $"\"{headerListEntry.Replace("\"", "\\\"")}\"";
            }

            return headerListEntry;
        }

        public static long Utf8ByteLength(string value)
        {
            if (value == null)
            {
                return 0;
            }
            return UTF_8.GetByteCount(value);
        }
    }
}
