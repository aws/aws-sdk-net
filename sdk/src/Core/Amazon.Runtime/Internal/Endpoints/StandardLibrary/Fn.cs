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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

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
            if (string.IsNullOrEmpty(path)) throw new ArgumentNullException("path");

            var parts = path.Split('.');
            var propertyValue = value;
            
            for (int i = 0; i < parts.Length; i++)
            {
                var part = parts[i];

                // indexer is always at the end of path e.g. "Part1.Part2[3]"
                if (i == parts.Length - 1)
                {
                    var indexerStart = part.LastIndexOf('[');
                    var indexerEnd = part.Length - 1;

                    // indexer detected
                    if (indexerStart >= 0)
                    {
                        var propertyPath = part.Substring(0, indexerStart);
                        var index = int.Parse(part.Substring(indexerStart + 1, indexerEnd - indexerStart - 1));

                        // indexer can be passed directly as a path e.g. "[1]"
                        if (indexerStart > 0)
                        {
                            propertyValue = ((IPropertyBag)propertyValue)[propertyPath];
                        }

                        if (!(propertyValue is IEnumerable)) throw new ArgumentException("Object addressing by pathing segment '{part}' with indexer must be IEnumerable");

                        var enumerable = (IEnumerable)propertyValue;
                        var list = enumerable.Cast<object>().ToList();
                        if (index < 0 || index > list.Count - 1) 
                        {
                            return null;
                        }
                        return list[index];
                    }
                }

                if (!(propertyValue is IPropertyBag)) throw new ArgumentException("Object addressing by pathing segment '{part}' must be IPropertyBag");
                propertyValue = ((IPropertyBag)propertyValue)[part];
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
            if (!char.IsLetterOrDigit(name[0]) || !char.IsLetterOrDigit(name.Last()))
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
            if (char.IsUpper(name[0]) || !char.IsLetterOrDigit(name[0]) || !char.IsLetterOrDigit(name.Last()))
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

        private static string[] SupportedSchemas = new string[] { "http", "https", "wss" };
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
            var result = new StringBuilder();
            for (int i = 0; i < template.Length; i++)
            {
                var currentChar = template[i];
                char nextChar = (i < template.Length - 1) ? template[i + 1] : default(char);
                // translate {{ -> { and }} -> }
                if (currentChar == OpenBracket && nextChar == OpenBracket)
                {
                    result.Append(OpenBracket);
                    i++;
                    continue;
                }
                if (currentChar == CloseBracket && nextChar == CloseBracket)
                {
                    result.Append(CloseBracket);
                    i++;
                    continue;
                }
                // translate {object#path} -> value
                if (currentChar == OpenBracket)
                {
                    var placeholder = new StringBuilder();
                    while (i < template.Length - 1 && template[i + 1] != CloseBracket)
                    {
                        i++;
                        placeholder.Append(template[i]);
                    }
                    if (i == template.Length - 1)
                    {
                        throw new ArgumentException("template is missing closing }");
                    }
                    i++;
                    var refParts = placeholder.ToString().Split('#');
                    var refName = refParts[0];
                    if (refParts.Length > 1) // has path after #
                    {
                        result.Append(GetAttr(refs[refName], refParts[1]).ToString());
                    }
                    else
                    {
                        result.Append(refs[refName].ToString());
                    }
                }
                else if (currentChar == CloseBracket)
                {
                    throw new ArgumentException("template has non-matching closing bracket, use }} to output }");
                }
                else
                {
                    result.Append(currentChar);
                }
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
                using var stream = new MemoryStream();
                using var writer = new Utf8JsonWriter(stream);

                InterpolateJson(element, refs, writer);
                writer.Flush();

                return Encoding.UTF8.GetString(stream.ToArray());
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
