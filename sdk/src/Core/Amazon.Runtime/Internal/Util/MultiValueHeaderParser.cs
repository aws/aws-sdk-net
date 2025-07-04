using Amazon.Util;
using System.Collections.Generic;
using System;
using System.Globalization;
using System.Linq;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Functions for parsing multiple comma-delimited header values out of a
    /// single header. This parsing adheres to
    /// [RFC-7230's specification of header values](https://datatracker.ietf.org/doc/html/rfc7230#section-3.2.6).
    /// </summary>
    public static class MultiValueHeaderParser
    {
        private static char Delimiter = ',';

        /// <summary>
        /// Reads a header string which is optionally comma-delimited and converts it to a list of 
        /// strings.
        /// </summary>
        /// <param name="header">The header string to parse which is optionally a comma-delimited list 
        /// of header values. Examples:
        /// <list type="bullet">
        ///     <item>
        ///         <description>
        ///             "\"b,c\", \"\\\"def\\\"\", a" => ["b,c", "\"def\"", "a"]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "1, 2, 3" => ["1", "2", "3"]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "a" => ["a"]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "" => []
        ///         </description>
        ///     </item>
        /// </list>
        /// </param>
        /// <returns>A list of strings representing the comma-delimited header values.</returns>
        public static List<string> ToStringList(string header)
        {
            List<string> list = new List<string>();

            int startAtIndex = 0;
            var bytes = System.Text.Encoding.UTF8.GetBytes(header);
            Tuple<string, int> readResponse;
            while (startAtIndex < bytes.Length)
            {
                readResponse = ReadValue(bytes, startAtIndex);
                list.Add(readResponse.Item1);
                startAtIndex = readResponse.Item2;
            }

            return list;
        }

        /// <summary>
        /// Reads a header string which is optionally comma-delimited and converts it to a list of 
        /// DateTime values.
        /// </summary>        
        /// <param name="header">The header string to parse which is optionally a comma-delimited list 
        /// of header value timestamps matching the specified format. Examples:
        /// <list type="bullet">
        ///     <item>
        ///         <description>
        ///             "2019-12-16T23:48:18Z, 2019-12-16T23:48:18Z" => [ DateTime, DateTime ]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "Mon, 16 Dec 2019 23:48:18 GMT, Mon, 16 Dec 2019 23:48:18 GMT" => [ DateTime, DateTime ]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "1576540098, 1576540098" => [ DateTime, DateTime ]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "" => []
        ///         </description>
        ///     </item>
        /// </list>
        /// </param>
        /// <param name="format">ISO8601, RFC822, UnixTimestamp</param>
        /// <returns>List of DateTimes processed from the comma separated string.</returns>
        public static List<DateTime> ToDateTimeList(string header, string format)
        {
            var value = header?.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return new List<DateTime>();
            };

            if (format == "ISO8601")
            {
                //"2019-12-16T23:48:18Z, 2019-12-16T23:48:18Z"
                return value.Split(Delimiter).Select(item => DateTime.Parse(item.Trim(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal)).ToList();
            }
            else if (format == "RFC822")
            {
                //"Mon, 16 Dec 2019 23:48:18 GMT, Mon, 16 Dec 2019 23:48:18 GMT"                
                var dateStringList = new List<string>();
                var startIndex = 0;
                while (startIndex < value.Length)
                {
                    var index = value.IndexOf(Delimiter, startIndex);
                    if(index == -1 || index + 1 == value.Length)
                    {
                        throw new ArgumentException($"Invalid RFC822 format {value} at starting index {startIndex}.");
                    }

                    index = value.IndexOf(Delimiter, index + 1);
                    if (index == -1)
                    {
                        index = value.Length;    
                    }                    

                    dateStringList.Add(value.Substring(startIndex, index - startIndex));
                    startIndex = index + 1;
                }

                return dateStringList.Select(item => DateTime.Parse(item.Trim(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal)).ToList();

            }
            else if (format == "UnixTimestamp")
            {
                //"1576540098, 1576540098"
                return value.Split(Delimiter).Select(item => AWSSDKUtils.ConvertFromUnixEpochSeconds(int.Parse(item.Trim(), CultureInfo.InvariantCulture))).ToList();
            }
            else
            {
                throw new ArgumentException($"Unknown format type: {format}. Supported formats are: ISO8601, RFC822, UnixTimestamp");
            }
        }

        /// <summary>
        /// Reads a header string which is optionally comma-delimited and converts it to a list of 
        /// type T.
        /// </summary>
        /// <typeparam name="T">A value type such as int, double, etc.</typeparam>
        /// <param name="header">The header string to parse which is optionally a comma-delimited list 
        /// of header values. Examples:
        /// <list type="bullet">
        ///     <item>
        ///         <description>
        ///             "1.1, 1.2, 1.3" => [1.1, 1.2, 1.3]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "1, 2, 3" => [1, 2, 3]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "1" => [1]
        ///         </description>
        ///     </item>
        ///     <item>
        ///         <description>
        ///             "" => []
        ///         </description>
        ///     </item>
        /// </list>
        /// </param>
        /// <returns>A list of type T representing the comma-delimited header values.</returns>
        public static List<T> ToValueTypeList<T>(string header) where T : struct
        {
            var value = header?.Trim();
            if (string.IsNullOrEmpty(value))
            {
                return new List<T>();
            };

            var list = value.Split(Delimiter).ToList();
            return list.ConvertAll(item => (T)Convert.ChangeType(item.Trim(), typeof(T))).ToList();
        }

        private static Tuple<string, int> ReadValue(byte[] input, int startAtIndex)
        {
            for (int index = startAtIndex; index < input.Length; index++)
            {
                switch (input[index])
                {
                    case (byte)' ':
                    case (byte)'\t':
                        continue;
                    case (byte)'"':
                        return ReadQuotedValue(input, index + 1);
                    default:
                        return ReadUnquotedValue(input, index);
                }
            }

            // We only end up here if the entire header value was whitespace or empty
            return new Tuple<string, int>(string.Empty, input.Length);
        }

        private static Tuple<string, int> ReadUnquotedValue(byte[] input, int startIndex)
        {
            int nextDelim = Array.IndexOf(input, (byte)Delimiter, startIndex);
            int length = nextDelim != -1 ? nextDelim - startIndex : input.Length - startIndex;
            string firstStr = System.Text.Encoding.UTF8.GetString(input, startIndex, length).Trim();
            var remainingIndex = AdvanceIndexIfComma(input, startIndex + length);

            return new Tuple<string, int>(firstStr, remainingIndex);
        }

        private static Tuple<string, int> ReadQuotedValue(byte[] input, int startIndex)
        {
            for (int index = startIndex; index < input.Length; index++)
            {
                if (input[index] == (byte)'"' && (index == startIndex || input[index - 1] != (byte)'\\'))
                {
                    var inner = System.Text.Encoding.UTF8.GetString(input, startIndex, index - startIndex);
                    inner = inner.Replace("\\\"", "\"");
                    inner = inner.Replace("\\\\", "\\");
                    var remainingIndex = AdvanceIndexIfComma(input, index + 1);

                    return new Tuple<string, int>(inner, remainingIndex);
                }
            }

            throw new ArgumentException($"Input started with a quote but did not end with a quote at index {startIndex}.");
        }

        private static int AdvanceIndexIfComma(byte[] input, int index)
        {
            if (index >= input.Length)
            {
                return index;
            }
            else if (input[index] == (byte)Delimiter)
            {
                return index + 1;
            }
            else
            {
                throw new ArgumentException($"Expected delimiter `{Delimiter}` in input data at index {index}.");
            }
        }
    }
}
