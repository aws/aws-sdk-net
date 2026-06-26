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
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using System;
using System.Collections;
#if NET8_0_OR_GREATER
using System.Collections.Frozen;
#endif
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using ThirdParty.RuntimeBackports;

namespace Amazon.Runtime.Internal.Endpoints.StandardLibrary
{
    /// <summary>
    /// Set of internal functions supported by ruleset conditions.
    /// </summary>
    public static class Fn
    {
        /// <summary>
        /// Evaluates whether a value (such as an endpoint parameter) is set
        /// </summary>
        public static bool IsSet(object value)
        {
            return value != null;
        }

        /// <summary>
        /// Extracts part of given object graph by path
        /// 
        /// Example: Given the input object {"Thing1": "foo", "Thing2": ["index0", "index1"], "Thing3": {"SubThing": 42}}
        /// GetAttr(object, "Thing1") returns "foo"
        /// path "Thing2[0]" returns "index0"
        /// path "Thing3.SubThing" returns 42
        /// Given the input IEnumerable list = {"foo", "bar"}
        /// GetAttr(list, "[0]") returns "foo"
        ///
        /// Every path segment must resolve to IPropertyBag
        /// Every path segment with indexer must resolve to IEnumerable
        /// Indexers must be at the very end of the path
        /// </summary>
        public static object GetAttr(object value, string path)
        {
#if NET8_0_OR_GREATER
            ArgumentNullException.ThrowIfNull(path);
#else
            if (path is null) throw new ArgumentNullException(nameof(path));
#endif

            return GetAttr(value, path.AsSpan());
        }

        private static object GetAttr(object value, ReadOnlySpan<char> path)
        {
            if (path.Length == 0) throw new ArgumentNullException(nameof(path));

            var propertyValue = value;

            bool isLastSegment = false;
            var remainder = path;
            while (!isLastSegment)
            {
                var dotPos = remainder.IndexOf('.');
                isLastSegment = dotPos == -1;
                ReadOnlySpan<char> segment;
                if (isLastSegment)
                {
                    segment = remainder;
                }
                else
                {
                    segment = remainder.Slice(0, dotPos);
                    remainder = remainder.Slice(dotPos + 1);
                }


                // indexer is always at the end of path e.g. "Part1.Part2[3]" or "[0]"
                // multiple indexers only consume the last segment e.g. "Part1[1][2]" consumes [2]
                if (isLastSegment)
                {
                    var bracketPos = segment.LastIndexOf('[');
                    if (bracketPos >= 0)
                    {
                        var indexSegment = segment.Slice(bracketPos + 1, segment.Length - bracketPos - 2);

#if NETCOREAPP3_1_OR_GREATER
                        var index = int.Parse(indexSegment);
#else
                        var index = int.Parse(indexSegment.ToString());
#endif

                        // property segment before the bracket e.g. "Part2[3]"
                        if (bracketPos > 0)
                        {
                            if (propertyValue is not IPropertyBag propBag)
                                throw new InvalidCastException($"Object addressing by pathing segment must be IPropertyBag");
                            propertyValue = propBag[segment.Slice(0, bracketPos).ToString()];
                        }

                        if (propertyValue is not IEnumerable enumerable)
                            throw new ArgumentException($"Object addressing by pathing segment with indexer must be IEnumerable");



                        // avoid Cast<object>().ToList() – use IList direct access when possible
                        if (enumerable is IList directList)
                            return index >= 0 && index < directList.Count ? directList[index] : null;

                        // fallback for non-IList enumerables: walk without allocating a list
                        int pos = 0;
                        foreach (var item in enumerable)
                        {
                            if (pos++ == index) return item;
                        }
                        return null;
                    }
                }

                if (propertyValue is not IPropertyBag bag)
                    throw new ArgumentException($"Object addressing by pathing segment must be IPropertyBag");
                propertyValue = bag[segment.ToString()];
            }
            return propertyValue;
        }

        /// <summary>
        /// Returns partition data for a region
        /// </summary>
        public static Partition Partition(string region)
        {
            return StandardLibrary.Partition.GetPartitionByRegion(region);
        }

        /// <summary>
        /// Evaluates a string ARN value, and returns an object containing details about the parsed ARN.
        /// If the input was not a valid ARN, the function returns null.
        /// </summary>
        public static Arn ParseArn(string arn)
        {
            Arn parsedArn;
            if (!Arn.TryParse(arn, out parsedArn))
            {
                return null;
            }
            return parsedArn;
        }

        /// <summary>
        /// Evaluates whether one or more string values are valid host labels per RFC 1123.
        /// https://www.rfc-editor.org/rfc/rfc1123#page-13
        /// Each host label must be between [1, 63] characters, start with a number or letter, and only contain numbers, letters, or hyphens.
        /// Host label can't end with a hyphen.
        /// If allowSubDomains is true, then the provided value may be zero or more dotted subdomains which are each validated per RFC 1123.
        /// </summary>
        public static bool IsValidHostLabel(string hostLabel, bool allowSubDomains)
        {
            var hosts = new List<string>();

            if (allowSubDomains)
            {
                hosts.AddRange(hostLabel.Split('.'));
            }
            else
            {
                hosts.Add(hostLabel);
            }

            foreach (var host in hosts)
            {
                if (!IsVirtualHostableName(host))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsVirtualHostableName(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 1 || name.Length > 63)
            {
                return false;
            }
            if (!char.IsLetterOrDigit(name[0]) || !char.IsLetterOrDigit(name[name.Length - 1]))
            {
                return false;
            }
            for (int i = 1; i < name.Length - 1; i++)
            {
                if (!char.IsLetterOrDigit(name[i]) && name[i] != '-')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// In addition to the restrictions defined in RFC 1123 and isValidHostLabel,
        /// validates that the bucket name is between [3,63] characters,
        /// does not contain upper case characters, and is not formatted as an IP4 address.
        /// Host label can't end with a hyphen.
        /// </summary>
        public static bool IsVirtualHostableS3Bucket(string hostLabel, bool allowSubDomains)
        {
            if (IsIpV4Address(hostLabel))
            {
                return false;
            }

            var hosts = new List<string>();
            if (allowSubDomains)
            {
                hosts.AddRange(hostLabel.Split('.'));
            }
            else
            {
                hosts.Add(hostLabel);
            }

            foreach (var host in hosts)
            {
                if (!IsVirtualHostableS3Name(host))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsVirtualHostableS3Name(string name)
        {
            if (string.IsNullOrEmpty(name) || name.Length < 3 || name.Length > 63)
            {
                return false;
            }
            if (char.IsUpper(name[0]) || !char.IsLetterOrDigit(name[0]) || !char.IsLetterOrDigit(name[name.Length-1]))
            {
                return false;
            }
            for (int i = 1; i < name.Length - 1; i++)
            {
                if (char.IsUpper(name[i]) || (!char.IsLetterOrDigit(name[i]) && name[i] != '-'))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsIpV4Address(string name)
        {
            const byte IpV4AddressPartsCount = 4;
            var parts = name.Split('.');
            if (parts.Length != IpV4AddressPartsCount)
            {
                return false;
            }
            foreach (var part in parts)
            {
                byte result;
                if (!byte.TryParse(part, out result))
                {
                    return false;
                }
            }
            return true;
        }

#pragma warning disable CA1055 // Uri return values should not be strings
        /// <summary>
        /// Given a string the function will perform uri percent-encoding
        /// </summary>
        public static string UriEncode(string value)
#pragma warning restore CA1055 // Uri return values should not be strings
        {
            return AWSSDKUtils.UrlEncode(value, false);
        }

#if NET8_0_OR_GREATER
        private static readonly FrozenSet<string> SupportedSchemas = new HashSet<string> { "http", "https", "wss" }
            .ToFrozenSet(StringComparer.Ordinal);
#else
        private static readonly HashSet<string> SupportedSchemas = new HashSet<string>(StringComparer.Ordinal) { "http", "https", "wss" };
#endif

        /// <summary>
        /// Parses url string into URL object.
        /// Given a string the function will attempt to parse the string into it’s URL components.
        /// If the string can not be parsed into a valid URL then the function will return a null.
        /// If the URL given contains a query portion, the URL MUST be rejected and the function MUST return null.
        /// We only support "http" and "https" schemas at the moment.
        /// </summary>
        public static URL ParseURL(string url)
        {
            Uri uri;
            Uri.TryCreate(url, UriKind.Absolute, out uri);
            if (uri == null || uri.Query?.Length > 0 || !SupportedSchemas.Contains(uri.Scheme))
            {
                return null;
            }

            var result = new URL
            {
                scheme = uri.Scheme,
                authority = uri.Authority,
                path = uri.GetComponents(UriComponents.Path, UriFormat.Unescaped)
            };

            if (result.path.Length > 0)
            {
                result.path = "/" + result.path;
            }

            result.normalizedPath = uri.PathAndQuery;
            if (result.normalizedPath.Length > 1)
            {
                result.normalizedPath += "/";
            }
            var hostNameType = Uri.CheckHostName(uri.Host);
            result.isIp = hostNameType == UriHostNameType.IPv4 || hostNameType == UriHostNameType.IPv6;
            return result;
        }

        /// <summary>
        /// Interpolate template placeholders with values from "refs" dictionary.
        /// 
        /// e.g. Template "My url scheme is {url#scheme} for {region}",
        /// where "url" and "region" are keys in refs dictionary and "scheme" is property of object refs["url"].
        /// Uses GetAttr() to resolve {} placeholders, i.e. {object#prop1.prop2[3]} -> GetAttr(refs["object"], "prop1.prop2[3]").
        /// {{ and }} are considered as escape sequences to allow rule authors to output a literal { and } respectively.
        /// Throws ArgumentException if template is not well formed.
        /// </summary>
        public static string Interpolate(string template, Dictionary<string, object> refs)
        {
            const char OpenBracket = '{';
            const char CloseBracket = '}';
            const char Hash = '#';
            var result = new ValueStringBuilder(template.Length); // preallocate to template length, will grow if needed
            var remainder = template.AsSpan();
            while (remainder.Length > 0)
            {
                var specialPos = remainder.IndexOfAny(OpenBracket, CloseBracket);
                if (specialPos < 0)
                {
                    result.Append(remainder);
                    break;
                }

                // copy the literal segment before the special character
                if (specialPos > 0)
                {
                    result.Append(remainder.Slice(0, specialPos));
                    remainder = remainder.Slice(specialPos);
                }

                var currentChar = remainder[0];
                var nextChar = remainder.Length > 1 ? remainder[1] : default(char);

                // {{ -> { and }} -> } escape sequences
                if (currentChar == nextChar)
                {
                    result.Append(currentChar);
                    remainder = remainder.Slice(2);
                    continue;
                }

                if (currentChar == CloseBracket)
                    throw new ArgumentException("template has non-matching closing bracket, use }} to output }");

                // currentChar == OpenBracket: resolve {ref} or {ref#path}
                var closingBracket = remainder.IndexOf(CloseBracket);
                if (closingBracket < 0)
                    throw new ArgumentException("template is missing closing }");

                var segment = remainder.Slice(1, closingBracket - 1);
                var hashPos = segment.IndexOf(Hash);
                if (hashPos >= 0)
                {
                    var refName = segment.Slice(0, hashPos).ToString();
                    segment = segment.Slice(hashPos + 1);

                    // If there is a secondary hash, we only want the path up to that point
                    var secondaryHashPos = segment.IndexOf(Hash);
                    if (secondaryHashPos >= 0)
                        segment = segment.Slice(0, secondaryHashPos);

                    result.Append(GetAttr(refs[refName], segment).ToString());
                }
                else
                {
                    result.Append(refs[segment.ToString()].ToString());
                }
                remainder = remainder.Slice(closingBracket + 1);
            }

            return result.ToString();
        }

        /// <summary>
        /// Interpolate all templates in all string nodes for given json
        /// </summary>
        public static string InterpolateJson(string json, Dictionary<string, object> refs)
        {
            if (string.IsNullOrEmpty(json))
                return string.Empty;
            try
            {
                using JsonDocument doc = JsonDocument.Parse(json);
                var element = doc.RootElement;
#if !NETFRAMEWORK
                // We assume new json will be at least similar size to the original json, so we can use the original json length as the initial buffer size.
                using var baseWriter = new ArrayPoolBufferWriter<byte>(json.Length);
                using var utf8Writer = new Utf8JsonWriter(baseWriter);

                InterpolateJson(element, refs, utf8Writer);
                utf8Writer.Flush();

                return Encoding.UTF8.GetString(baseWriter.WrittenSpan);
#else
                using var stream = new MemoryStream();
                using var utfWriter = new Utf8JsonWriter(stream);

                InterpolateJson(element, refs, utfWriter);
                utfWriter.Flush();

                return Encoding.UTF8.GetString(stream.ToArray());
#endif
            }
            catch (JsonException)
            {
                return string.Empty;
            }
        }

        private static void InterpolateJson(JsonElement element, Dictionary<string, object> refs, Utf8JsonWriter writer)
        {
            switch (element.ValueKind)
            {
                case JsonValueKind.Object:
                    writer.WriteStartObject();
                    foreach (var property in element.EnumerateObject())
                    {
                        writer.WritePropertyName(property.Name);
                        InterpolateJson(property.Value, refs, writer);
                    }
                    writer.WriteEndObject();
                    break;

                case JsonValueKind.Array:
                    writer.WriteStartArray();
                    foreach (var item in element.EnumerateArray())
                    {
                        InterpolateJson(item, refs, writer);
                    }
                    writer.WriteEndArray();
                    break;

                case JsonValueKind.String:
                    var interpolated = Interpolate(element.GetString(), refs);
                    writer.WriteStringValue(interpolated);
                    break;

                default:
                    element.WriteTo(writer);
                    break;
            }
        }

        /// <summary>
        /// Computes the substring of a given string, conditionally indexing from the end of the string. 
        /// When the string is long enough to fully include the substring, return the substring. 
        /// Otherwise, return null. The start index is inclusive and the stop index is exclusive. 
        /// The length of the returned string will always be stop-start.
        /// Substring MUST return null when the input contains non-ascii (>127) characters.
        /// </summary>
        public static string Substring(string input, int start, int stop, bool reverse)
        {
            var str = (string)input;
            if (start >= stop || str.Length < stop)
            {
                return null;
            }
            if (str.Any(c => c > 127))
            {
                return null;
            }
            if (!reverse)
            {
                return str.Substring(start, stop - start);
            }
            var r_start = str.Length - stop;
            var r_stop = str.Length - start;
            return str.Substring(r_start, r_stop - r_start);
        }
    }
}
