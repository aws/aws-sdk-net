/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using Amazon.Runtime.Internal.Util;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using System.Net;
using Amazon.Runtime.Internal;
using Amazon.Runtime;
using Amazon.Util.Internal;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Amazon.Runtime.Endpoints;
using ThirdParty.RuntimeBackports;

using System.Threading.Tasks;
#if NETSTANDARD
using System.Net.Http;
using System.Runtime.InteropServices;
#endif

namespace Amazon.Util
{
    /// <summary>
    /// This class defines utilities and constants that can be used by 
    /// all the client libraries of the SDK.
    /// </summary>
    public static partial class AWSSDKUtils
    {
#region Internal Constants

        internal const string DefaultRegion = "us-east-1";
        internal const string DefaultGovRegion = "us-gov-west-1";

        private const char WindowsDirectorySeparatorChar = '\\';
        private const char WindowsAltDirectorySeparatorChar = '/';
        private const char WindowsVolumeSeparatorChar = ':';

        private const char SlashChar = '/';
        private const string Slash = "/";
        private const string EncodedSlash = "%2F";

        internal const int DefaultMaxRetry = 3;
        private const int DefaultConnectionLimit = 50;
        private const int DefaultMaxIdleTime = 50 * 1000; // 50 seconds

        private const int MaxIsSetMethodsCacheSize = 50;
        private const long TicksPerSecond = 10_000_000;

        public static readonly DateTime EPOCH_START = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public const int DefaultBufferSize = 8192;

        // Default value of progress update interval for streaming is 100KB.
        public const long DefaultProgressUpdateInterval = 102400;

        internal const string S3Accelerate = "s3-accelerate";
        internal const string S3Control = "s3-control";

        private static readonly string _userAgent = InternalSDKUtils.BuildUserAgentString(string.Empty, string.Empty);

#endregion

#region Public Constants


        /// <summary>
        /// The user agent string header
        /// </summary>
        public const string UserAgentHeader = "User-Agent";


        /// <summary>
        /// The Set of accepted and valid Url characters per RFC3986. 
        /// Characters outside of this set will be encoded.
        /// </summary>
        public const string ValidUrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

        /// <summary>
        /// The Set of accepted and valid Url characters per RFC1738. 
        /// Characters outside of this set will be encoded.
        /// </summary>
        public const string ValidUrlCharactersRFC1738 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.";

        /// <summary>
        /// The set of accepted and valid Url path characters per RFC3986.
        /// </summary>
        private static readonly string ValidPathCharacters = DetermineValidPathCharacters();

        /// <summary>
        /// The set of characters which are not to be encoded as part of the X-Amzn-Trace-Id header values
        /// </summary>
        public const string ValidTraceIdHeaderValueCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-=;:+&[]{}\"',";

        // Valid path characters per RFC 3986 https://datatracker.ietf.org/doc/html/rfc3986#section-3.3
        // segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" ) ; non-zero-length segment without any colon ":"
        // check https://datatracker.ietf.org/doc/html/rfc3986#section-2.2 for sub-delims

        private static string DetermineValidPathCharacters()
        {
            const string basePathCharacters = "/'()!*$+,;=&";

            var sb = new StringBuilder();
            foreach (var c in basePathCharacters)
            {
                // This warning is suggesting EscapeDataString when escaping full query string components
                // and will always escape the base path characters. We don't need to worry about the
                // corruption warning because we are only attempting to scape a single character.
#pragma warning disable SYSLIB0013
                var escaped = Uri.EscapeUriString(c.ToString());
#pragma warning restore SYSLIB0013
                if (escaped.Length == 1 && escaped[0] == c)
                    sb.Append(c);
            }
            return sb.ToString();
        }

        // Precomputed ASCII membership table per (RFC scheme, isPath) combination, so UrlEncode can test
        // each byte with an O(1) lookup instead of scanning the character set string. Declared after
        // ValidPathCharacters so it is initialized first (static fields initialize in textual order).
        private static readonly bool[] _urlEncodeLookup3986 = BuildUrlEncodeLookup(ValidUrlCharacters, false);
        private static readonly bool[] _urlEncodeLookup3986Path = BuildUrlEncodeLookup(ValidUrlCharacters, true);
        private static readonly bool[] _urlEncodeLookup1738 = BuildUrlEncodeLookup(ValidUrlCharactersRFC1738, false);
        private static readonly bool[] _urlEncodeLookup1738Path = BuildUrlEncodeLookup(ValidUrlCharactersRFC1738, true);

        private static bool[] BuildUrlEncodeLookup(string scheme, bool path)
        {
            var table = new bool[128];
            foreach (var c in scheme)
                if (c < 128) table[c] = true;
            if (path)
                foreach (var c in ValidPathCharacters)
                    if (c < 128) table[c] = true;
            return table;
        }

        private static bool[] GetUrlEncodeLookup(int rfcNumber, bool path)
        {
            // 1738 is the only alternative scheme; everything else (including unrecognised values) uses 3986.
            if (rfcNumber == 1738)
                return path ? _urlEncodeLookup1738Path : _urlEncodeLookup1738;
            return path ? _urlEncodeLookup3986Path : _urlEncodeLookup3986;
        }

#if NET8_0_OR_GREATER
        // SearchValues equivalents of the tables above, used by UrlEncode to vectorize the scan to the first
        // byte that needs encoding via SIMD-accelerated IndexOfAnyExcept.
        private static readonly SearchValues<byte> _urlEncodeSearchValues3986 = SearchValues.Create(BuildUrlEncodeBytes(ValidUrlCharacters, false));
        private static readonly SearchValues<byte> _urlEncodeSearchValues3986Path = SearchValues.Create(BuildUrlEncodeBytes(ValidUrlCharacters, true));
        private static readonly SearchValues<byte> _urlEncodeSearchValues1738 = SearchValues.Create(BuildUrlEncodeBytes(ValidUrlCharactersRFC1738, false));
        private static readonly SearchValues<byte> _urlEncodeSearchValues1738Path = SearchValues.Create(BuildUrlEncodeBytes(ValidUrlCharactersRFC1738, true));

        private static byte[] BuildUrlEncodeBytes(string scheme, bool path)
        {
            var table = BuildUrlEncodeLookup(scheme, path);
            var count = 0;
            for (var i = 0; i < table.Length; i++)
                if (table[i]) count++;

            var bytes = new byte[count];
            var index = 0;
            for (var i = 0; i < table.Length; i++)
                if (table[i]) bytes[index++] = (byte)i;
            return bytes;
        }

        private static SearchValues<byte> GetUrlEncodeSearchValues(int rfcNumber, bool path)
        {
            if (rfcNumber == 1738)
                return path ? _urlEncodeSearchValues1738Path : _urlEncodeSearchValues1738;
            return path ? _urlEncodeSearchValues3986Path : _urlEncodeSearchValues3986;
        }
#endif

        /// <summary>
        /// The string representing Url Encoded Content in HTTP requests
        /// </summary>
        public const string UrlEncodedContent = "application/x-www-form-urlencoded; charset=utf-8";

        /// <summary>
        /// The GMT Date Format string. Used when parsing date objects
        /// </summary>
        public const string GMTDateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

        /// <summary>
        /// The ISO8601Date Format string. Used when parsing date objects
        /// </summary>
        public const string ISO8601DateFormat = "yyyy-MM-dd\\THH:mm:ss.fff\\Z";

        /// <summary>
        /// The ISO8601Date Format string. Used when parsing date objects
        /// </summary>
        public const string ISO8601DateFormatNoMS = "yyyy-MM-dd\\THH:mm:ss\\Z";

        /// <summary>
        /// The ISO8601 Basic date/time format string. Used when parsing date objects
        /// </summary>
        public const string ISO8601BasicDateTimeFormat = "yyyyMMddTHHmmssZ";

        /// <summary>
        /// The ISO8601 basic date format. Used during AWS4 signature computation.
        /// </summary>
        public const string ISO8601BasicDateFormat = "yyyyMMdd";

        /// <summary>
        /// The RFC822Date Format string. Used when parsing date objects
        /// </summary>
        public const string RFC822DateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

        /// <summary>
        /// Represents the ISO8601 basic date/time format with a UTC offset
        /// </summary>
        public const string ISO8601WithUTCOffset = "yyyy-MM-ddTHH:mm:ssZ";

        #endregion

        #region Internal Methods

        /// <summary>
        /// Returns an extension of a path.
        /// This has the same behavior as System.IO.Path.GetExtension, but does not
        /// check the path for invalid characters.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetExtension(string path)
        {
            if (path is null)
                return null;

#if NET8_0_OR_GREATER
            // LastIndexOf and LastIndexOfAny is vectorized on .NET8+ and is
            // significantly faster for cases where 'path' does not end with a short file
            // extension, such as GUIDs
            ReadOnlySpan<char> pathSpan = path.AsSpan();
            int extensionIndex = pathSpan.LastIndexOf('.');
            if (extensionIndex == -1)
            {
                return string.Empty;
            }

            int directoryIndex = pathSpan.LastIndexOfAny('/', '\\', ':');

            // extension separator is found and exists before path separator or path separator doesn't exist
            // AND it's not the last one in the string
            if (directoryIndex < extensionIndex && extensionIndex < pathSpan.Length - 1)
            {
                return pathSpan.Slice(extensionIndex).ToString();
            }

            return string.Empty;
#else
            int length = path.Length;
            int index = length;

            while (--index >= 0)
            {
                char ch = path[index];
                if (ch == '.')
                {
                    if (index != length - 1)
                        return path.Substring(index, length - index);
                    else
                        return string.Empty;
                }
                else if (IsPathSeparator(ch))
                    break;
            }

            return string.Empty;

            bool IsPathSeparator(char ch)
            {
                return (ch == '\\' ||
                        ch == '/' ||
                        ch == ':');
            }
#endif
        }

        /*
         * Determines the string to be signed based on the input parameters for
         * AWS Signature Version 2
         */
        internal static string CalculateStringToSignV2(ParameterCollection parameterCollection, string serviceUrl)
        {
            StringBuilder data = new StringBuilder("POST\n", 512);
            var sortedParameters = parameterCollection.GetParametersEnumerable();
            Uri endpoint = new Uri(serviceUrl);

            data.Append(endpoint.Host);
            data.Append('\n');
            string uri = endpoint.AbsolutePath;
            if (string.IsNullOrEmpty(uri))
            {
                uri = "/";
            }

            data.Append(AWSSDKUtils.UrlEncode(uri, true));
            data.Append('\n');

            foreach (KeyValuePair<string, string> pair in sortedParameters)
            {
                if (pair.Value != null)
                {
                    data.Append(AWSSDKUtils.UrlEncode(pair.Key, false));
                    data.Append('=');
                    data.Append(AWSSDKUtils.UrlEncode(pair.Value, false));
                    data.Append('&');
                }
            }

            data.Remove(data.Length - 1, 1); // Remove the trailing '\n' or '&' character
            return data.ToString();
        }

        /**
         * Convert request parameters to Url encoded query string
         */
        internal static string GetParametersAsString(IRequest request)
        {
            return GetParametersAsString(request.ParameterCollection);
        }

        /// <summary>
        /// Returns the request parameters in the form of a query string.
        /// </summary>
        /// <param name="request">The request instance</param>
        /// <param name="usesQueryString">Optional parameter: if true, we will return an empty byte array</param>
        /// <returns>Request parameters in query string byte array format</returns>
        public static byte[] GetRequestPayloadBytes(IRequest request, bool? usesQueryString = null)
        {
            if (request.Content != null)
                return request.Content;

            if (usesQueryString.HasValue && usesQueryString.Value)
            {
                return ArrayEx.Empty<byte>();
            }

#if !NETFRAMEWORK
            // Build the form-url-encoded body straight into UTF-8 bytes, skipping the intermediate
            // UTF-16 string (and per-value encode strings) that the string path allocates.
            return GetParametersAsBytes(request.ParameterCollection);
#else
            return Encoding.UTF8.GetBytes(GetParametersAsString(request));
#endif
        }

        /**
         * Convert Dictionary of parameters to Url encoded query string
         */
        internal static string GetParametersAsString(ParameterCollection parameterCollection)
        {
            var parameterBuilder = new ValueStringBuilder(512);
            foreach (var kvp in parameterCollection.GetParametersEnumerable())
            {
                var value = kvp.Value;
                if (value == null)
                    continue;
                parameterBuilder.Append(kvp.Key);
                parameterBuilder.Append('=');
                parameterBuilder.Append(AWSSDKUtils.UrlEncode(value, false));
                parameterBuilder.Append('&');
            }

            var length = parameterBuilder.Length;
            return length == 0 ? string.Empty : parameterBuilder.ToString(0, length - 1);
        }

#if !NETFRAMEWORK
        /// <summary>
        /// Builds the form-url-encoded body ("key=value&amp;key=value") from the parameter collection
        /// straight into UTF-8 bytes, byte-for-byte identical to
        /// <c>Encoding.UTF8.GetBytes(GetParametersAsString(parameterCollection))</c> but without the
        /// intermediate UTF-16 string or per-value encode strings.
        /// </summary>
        internal static byte[] GetParametersAsBytes(ParameterCollection parameterCollection)
        {
            using var writer = new ArrayPoolBufferWriter<byte>();
            WriteParameters(writer, parameterCollection);

            var written = writer.WrittenSpan;
            return written.Length == 0 ? ArrayEx.Empty<byte>() : written.ToArray();
        }

        /// <summary>
        /// Writes the form-url-encoded body of <paramref name="request"/>'s parameters into a
        /// <see cref="PooledContentStream"/>, avoiding the per-request byte[] that
        /// <see cref="GetRequestPayloadBytes"/> allocates.
        /// </summary>
        public static PooledContentStream WriteParametersToPooledStream(IRequest request)
        {
            var stream = new PooledContentStream();
            try
            {
                WriteParameters(stream.BufferWriter, request.ParameterCollection);
            }
            catch
            {
                stream.Dispose();
                throw;
            }
            return stream;
        }

        /// <summary>
        /// Emits "key=urlencoded(value)" pairs joined by '&amp;' (no trailing '&amp;'),
        /// skipping parameters with a null value, exactly as
        /// <see cref="GetParametersAsString(ParameterCollection)"/> does.
        /// </summary>
        private static void WriteParameters(IBufferWriter<byte> buffer, ParameterCollection parameterCollection)
        {
            var first = true;
            foreach (var kvp in parameterCollection.GetParametersEnumerable())
            {
                var value = kvp.Value;
                if (value == null)
                    continue;

                // Prefix '&' before every pair except the first, which yields no trailing '&' — matching
                // GetParametersAsString's append-then-drop-last-'&' behavior.
                if (!first)
                    WriteByte(buffer, (byte)'&');
                first = false;

                WriteUtf8(buffer, kvp.Key);
                WriteByte(buffer, (byte)'=');
                UrlEncodeToBuffer(3986, buffer, value, false);
            }
        }

        private static void WriteByte(IBufferWriter<byte> buffer, byte value)
        {
            var span = buffer.GetSpan(1);
            span[0] = value;
            buffer.Advance(1);
        }

        private static void WriteUtf8(IBufferWriter<byte> buffer, string value)
        {
            if (string.IsNullOrEmpty(value))
                return;

            var span = buffer.GetSpan(Encoding.UTF8.GetMaxByteCount(value.Length));
            var written = Encoding.UTF8.GetBytes(value.AsSpan(), span);
            buffer.Advance(written);
        }
#endif

        /// <summary>
        /// Returns the canonicalized resource path for the service endpoint.
        /// </summary>
        /// <param name="endpoint">Endpoint URL for the request.</param>
        /// <param name="resourcePath">Resource path for the request.</param>
        /// <param name="encode">If true will URL-encode path segments including "/". "S3" is currently the only service that does not expect pre URL-encoded segments.</param>
        /// <param name="pathResources">Dictionary of key/value parameters containing the values for the ResourcePath key replacements.</param>
        /// <remarks>If resourcePath begins or ends with slash, the resulting canonicalized path will follow suit.</remarks>
        /// <returns>Canonicalized resource path for the endpoint.</returns>
        public static string CanonicalizeResourcePathV2(Uri endpoint, string resourcePath, bool encode, IDictionary<string, string> pathResources)
        {
            if (endpoint != null)
            {
                var path = endpoint.AbsolutePath;
                if (string.IsNullOrEmpty(path) || string.Equals(path, Slash, StringComparison.Ordinal))
                    path = string.Empty;

                if (!string.IsNullOrEmpty(resourcePath) && resourcePath.StartsWith(Slash, StringComparison.Ordinal))
                    resourcePath = resourcePath.Substring(1);

                if (!string.IsNullOrEmpty(resourcePath))
                    path = path + Slash + resourcePath;

                resourcePath = path;
            }

            if (string.IsNullOrEmpty(resourcePath))
                return Slash;

            IEnumerable<UriComponent> encodedSegments = AWSSDKUtils.SplitResourcePathIntoSegmentsV2(resourcePath, pathResources);

            var pathWasPreEncoded = false;
            if (encode)
            {
                if (endpoint == null)
                    throw new ArgumentNullException(nameof(endpoint), "A non-null endpoint is necessary to decide whether or not to pre URL encode.");
                foreach(var segment in encodedSegments)
                {
                    if (segment.SegmentType == SegmentType.Label)
                        segment.Value = UrlEncode(segment.Value, false);
                    else
                        segment.Value = UrlEncode(segment.Value, true);
                }
                pathWasPreEncoded = true;
            }
            string canonicalizedResourcePath = JoinResourcePathSegmentsV2(encodedSegments);

            // Get the logger each time (it's cached) because we shouldn't store it in a static variable.
            Logger.GetLogger(typeof(AWSSDKUtils)).DebugFormat("{0} encoded {1}{2} for canonicalization: {3}",
                pathWasPreEncoded ? "Double" : "Single",
                resourcePath,
                endpoint == null ? "" : " with endpoint " + endpoint.AbsoluteUri,
                canonicalizedResourcePath);

            return canonicalizedResourcePath;
        }

        /// <summary>
        /// Splits the resourcePath at / into segments then resolves any keys with the path resource values. Greedy
        /// key values will be split into multiple segments at each /. This is used for splitting resource path into segments for
        /// signing.
        /// </summary>
        /// <param name="resourcePath">The patterned resourcePath</param>
        /// <param name="pathResources">The key/value lookup for the patterned resourcePath</param>
        /// <returns>A list of path segments where all keys in the resourcePath have been resolved to one or more path segment values</returns>
        public static IEnumerable<string> SplitResourcePathIntoSegments(string resourcePath, IDictionary<string, string> pathResources)
        {
            var splitChars = new char[] { SlashChar };
            var pathSegments = resourcePath.Split(splitChars, StringSplitOptions.None);
            if(pathResources == null || pathResources.Count == 0)
            {
                return pathSegments;
            }

            //Otherwise there are key/values that need to be resolved
            var resolvedSegments = new List<string>();
            foreach(var segment in pathSegments)
            {
                if (!pathResources.ContainsKey(segment))
                {
                    resolvedSegments.Add(segment);
                    continue;
                }

                //Determine if the path is greedy. If greedy the segment will be split at each / into multiple segments.
                if (segment.EndsWith("+}", StringComparison.Ordinal))
                {
                    resolvedSegments.AddRange(pathResources[segment].Split(splitChars, StringSplitOptions.None));
                }
                else
                {
                    resolvedSegments.Add(pathResources[segment]);
                }
            }

            return resolvedSegments;
        }

        /// <summary>
        /// This is used to split resource path into segments for composing a URL, not for signing. When splitting resource path into 
        /// segments for composing a URL we must discern that which is a literal which we do not encode and that which is a label which
        /// we do encode.
        /// </summary>
        /// <param name="resourcePath">The resource path, which includes literals and labels.</param>
        /// <param name="pathResources">The dictionary for substituting label values.</param>
        /// <returns></returns>
        public static IEnumerable<UriComponent> SplitResourcePathIntoSegmentsV2(string resourcePath, IDictionary<string, string> pathResources)
        {
            var splitChars = new char[] { SlashChar };
            var pathSegments = resourcePath.Split(splitChars, StringSplitOptions.None);
            var uriComponentSegments = new List<UriComponent>();
            if (pathResources == null || pathResources.Count == 0)
            {
                foreach (var segment in pathSegments)
                {
                    uriComponentSegments.Add(new UriComponent { SegmentType = SegmentType.Literal, Value = segment});
                }
                return uriComponentSegments;
            }

            //Otherwise there are key/values that need to be resolved
            foreach (var segment in pathSegments)
            {
                string resolvedSegment;
                if (!pathResources.TryGetValue(segment, out resolvedSegment))
                {
                    uriComponentSegments.Add(new UriComponent { SegmentType = SegmentType.Literal, Value = segment});
                    continue;
                }

                //Determine if the path is greedy. If greedy the segment will be split at each / into multiple segments.
                if (segment.EndsWith("+}", StringComparison.Ordinal))
                {
                    uriComponentSegments.AddRange(resolvedSegment.Split(splitChars, StringSplitOptions.None).Select(x => new UriComponent { Value = x, SegmentType = SegmentType.Label}));
                }
                else
                {
                    uriComponentSegments.Add(new UriComponent { SegmentType = SegmentType.Label, Value = resolvedSegment });
                }
            }

            return uriComponentSegments;
        }

        /// <summary>
        /// Joins all path segments with the / character and encodes each segment before joining
        /// </summary>
        /// <param name="pathSegments"></param>
        /// <returns></returns>
        public static string JoinResourcePathSegmentsV2(IEnumerable<string> pathSegments)
        {
            pathSegments = pathSegments.Select(segment => UrlEncode(segment, false));

            // join the encoded segments with /
            return string.Join(Slash, pathSegments.ToArray());
        }

        /// <summary>
        /// Joins all path segments with the / character and encodes each non-literal segment before joining
        /// </summary>
        /// <param name="pathSegments"></param>
        /// <returns></returns>
        public static string JoinResourcePathSegmentsV2(IEnumerable<UriComponent> pathSegments)
        {
            string[] encodedSegments = pathSegments.Select(segment =>
            {
                if (segment.SegmentType == SegmentType.Label)
                    return UrlEncode(segment.Value, false);
                else
                    return UrlEncode(segment.Value, true);
            }).ToArray();
            // join the encoded segments with /
            return string.Join(Slash, encodedSegments);
        }


        /// <summary>
        /// Takes a patterned resource path and resolves it using the key/value path resources into
        /// a segmented encoded URL.
        /// </summary>
        /// <param name="resourcePath">The patterned resourcePath</param>
        /// <param name="pathResources">The key/value lookup for the patterned resourcePath</param>
        /// <returns></returns>
        public static string ResolveResourcePathV2(string resourcePath, IDictionary<string, string> pathResources)
        {
            if (string.IsNullOrEmpty(resourcePath))
            {
                return resourcePath; 
            }
            return JoinResourcePathSegmentsV2(SplitResourcePathIntoSegmentsV2(resourcePath, pathResources));
        }

        /// <summary>
        /// Returns a new string created by joining each of the strings in the
        /// specified list together, with a comma between them.
        /// </summary>
        /// <parma name="strings">The list of strings to join into a single, comma delimited
        /// string list.</parma>
        /// <returns> A new string created by joining each of the strings in the
        /// specified list together, with a comma between strings.</returns>
        public static String Join(List<String> strings)
        {
            return string.Join(", ", strings);
        }

        /// <summary>
        /// Attempt to infer the region for a service request based on the endpoint
        /// </summary>
        /// <param name="url">Endpoint to the service to be called</param>
        /// <returns>
        /// Region parsed from the endpoint; DefaultRegion (or DefaultGovRegion)
        /// if it cannot be determined/is not explicit
        /// </returns>
        public static string DetermineRegion(string url)
        {
            var regionEndpoint = RegionFinder.Instance.FindRegion(url);
            return regionEndpoint?.SystemName;
        }

        /// <summary>
        /// Attempt to infer the service name for a request (in short form, eg 'iam') from the
        /// service endpoint.
        /// </summary>
        /// <param name="url">Endpoint to the service to be called</param>
        /// <returns>
        /// Short-form name of the service parsed from the endpoint; empty string if it cannot 
        /// be determined
        /// </returns>
        public static string DetermineService(string url)
        {
            var urlSpan = url.AsSpan();

            var doubleSlashIndex = urlSpan.IndexOf(DoubleSlash, StringComparison.Ordinal);
            if (doubleSlashIndex >= 0)
                urlSpan = urlSpan.Slice(doubleSlashIndex + 2);

            var dotIndex = urlSpan.IndexOf('.');

            if (dotIndex < 0)
                return string.Empty;

            var servicePartSpan = urlSpan.Slice(0, dotIndex);
            var hyphenIndex = servicePartSpan.IndexOf('-');
            if (hyphenIndex > 0)
            {
                servicePartSpan = servicePartSpan.Slice(0, hyphenIndex);
            }

            // Check for SQS : return "sqs" in case service is determined to be "queue" as per the URL.
            return servicePartSpan.Equals(Queue, StringComparison.OrdinalIgnoreCase) ? "sqs" : servicePartSpan.ToString();
        }

        // Compiler trick to directly refer to static data in the assembly
        private static ReadOnlySpan<char> DoubleSlash => new[] { '/', '/' };
        private static ReadOnlySpan<char> Queue => new[] { 'q', 'u', 'e', 'u', 'e' };

        /// <summary>
        /// Utility method for converting Unix epoch seconds to DateTime structure.
        /// </summary>
        /// <param name="seconds">The number of seconds that have elapsed since 00:00:00 Coordinated Universal Time (UTC), Thursday, 1 January 1970.</param>
        /// <returns>Converted DateTime structure</returns>
        public static DateTime ConvertFromUnixEpochSeconds(int seconds)
        {
            return new DateTime(seconds * TicksPerSecond + EPOCH_START.Ticks, DateTimeKind.Utc);
        }

        /// <summary>
        /// Utility method for converting Unix epoch seconds to DateTime structure.
        /// </summary>
        /// <param name="seconds">The number of seconds since January 1, 1970.</param>
        /// <returns>Converted DateTime structure</returns>
        public static DateTime ConvertFromUnixLongEpochSeconds(long seconds)
        {
            return new DateTime(seconds * TicksPerSecond + EPOCH_START.Ticks, DateTimeKind.Utc);
        }

        /// <summary>
        /// Utility method for converting Unix epoch seconds to DateTime structure.
        /// </summary>
        /// <param name="seconds">The number of seconds since January 1, 1970.</param>
        /// <returns>Converted DateTime structure</returns>
        public static DateTime ConvertFromUnixDoubleEpochSeconds(double seconds)
        {
            var ticksSinceEpoch = (long)(seconds * TicksPerSecond);
            return new DateTime(ticksSinceEpoch + EPOCH_START.Ticks, DateTimeKind.Utc);
        }

        /// <summary>
        /// Utility method for converting Unix epoch milliseconds to DateTime structure.
        /// </summary>
        /// <param name="milliseconds">The number of milliseconds that have elapsed since 00:00:00 Coordinated Universal Time (UTC), Thursday, 1 January 1970.</param>
        /// <returns>Converted DateTime structure</returns>
        public static DateTime ConvertFromUnixEpochMilliseconds(long milliseconds)
        {
            return new DateTime(milliseconds * 10000L + EPOCH_START.Ticks, DateTimeKind.Utc);
        }

        public static int ConvertToUnixEpochSeconds(DateTime dateTime)
        {
            return Convert.ToInt32(GetTimeSpanInTicks(dateTime).TotalSeconds);
        }

        public static long ConvertToUnixEpochMilliseconds(DateTime dateTime)
        {
            return Convert.ToInt64(GetTimeSpanInTicks(dateTime).TotalMilliseconds);
        }

        public static string ConvertToUnixEpochSecondsString(DateTime dateTime)
        {
            return Convert.ToInt64(GetTimeSpanInTicks(dateTime).TotalSeconds).ToString(CultureInfo.InvariantCulture);
        }


        public static double ConvertToUnixEpochSecondsDouble(DateTime dateTime)
        {
            return Math.Round(GetTimeSpanInTicks(dateTime).TotalMilliseconds, 0) / 1000.0;
        }

        /// <summary>
        /// This method ensures the passed in DateTime is in UTC format then gets the numbers of ticks from that UTC time
        /// minus the number of ticks from the UTC Epoch start time.
        /// </summary>
        /// <param name="dateTime">The DateTime used to determine the TimeSpan from the Epoch start time. </param>
        /// <returns>Returns the TimeSpan of the passed DateTime minus the Epoch start time.</returns>
        public static TimeSpan GetTimeSpanInTicks(DateTime dateTime)
        {
            return new TimeSpan(dateTime.ToUniversalTime().Ticks - EPOCH_START.Ticks);
        }

        /// <summary>
        /// Helper function to format a byte array into string
        /// </summary>
        /// <param name="data">The data blob to process</param>
        /// <param name="lowercase">If true, returns hex digits in lower case form</param>
        /// <returns>String version of the data</returns>
        public static string ToHex(byte[] data, bool lowercase)
        {
#if NET8_0_OR_GREATER
            if (!lowercase)
            {
                return Convert.ToHexString(data);
            }
#endif

#if NETCOREAPP3_1_OR_GREATER
            return string.Create(data.Length * 2, (data, lowercase), static (chars, state) =>
            {
                ToHexString(state.data, chars, state.lowercase);
            });
#else
            char[] chars = ArrayPool<char>.Shared.Rent(data.Length * 2);

            try
            {
                ToHexString(data, chars, lowercase);

                return new string(chars, 0, data.Length * 2);
            }
            finally
            {
                ArrayPool<char>.Shared.Return(chars);
            }
#endif
        }

        /// <summary>
        /// Calls a specific EventHandler in a background thread
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="args"></param>
        /// <param name="sender"></param>
        public static void InvokeInBackground<T>(EventHandler<T> handler, T args, object sender) where T : EventArgs
        {
            if (handler == null) return;


            var list = handler.GetInvocationList();
            foreach (var call in list)
            {
                var eventHandler = ((EventHandler<T>)call);
                if (eventHandler != null)
                {
                    Dispatcher.Dispatch(() => eventHandler(sender, args));
                }
            }
        }

        private static BackgroundInvoker _dispatcher;

        private static BackgroundInvoker Dispatcher
        {
            get
            {
                if (_dispatcher == null)
                {
                    _dispatcher = new BackgroundInvoker();
                }

                return _dispatcher;
            }
        }

        /// <summary>
        /// Parses a query string of a URL and returns the parameters as a string-to-string dictionary.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Dictionary<string, string> ParseQueryParameters(string url)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(url))
            {
                int queryIndex = url.IndexOf('?');
                if (queryIndex >= 0)
                {
                    string queryString = url.Substring(queryIndex + 1);
                    string[] kvps = queryString.Split(new char[] { '&' }, StringSplitOptions.None);
                    foreach (string kvp in kvps)
                    {
                        if (string.IsNullOrEmpty(kvp))
                            continue;

                        string[] nameValuePair = kvp.Split(new char[] { '=' }, 2);
                        string name = nameValuePair[0];
                        string value = nameValuePair.Length == 1 ? null : nameValuePair[1];
                        parameters[name] = value;
                    }
                }
            }

            return parameters;
        }

        internal static bool AreEqual(object[] itemsA, object[] itemsB)
        {
            if (itemsA == null || itemsB == null)
                return (itemsA == itemsB);

            if (itemsA.Length != itemsB.Length)
                return false;

            var length = itemsA.Length;
            for (int i = 0; i < length; i++)
            {
                var a = itemsA[i];
                var b = itemsB[i];
                if (!AreEqual(a, b))
                    return false;
            }

            return true;
        }

        internal static bool AreEqual(object a, object b)
        {
            if (a == null || b == null)
                return (a == b);

            if (object.ReferenceEquals(a, b))
                return true;

            return (a.Equals(b));
        }

        internal static bool DictionariesAreEqual<TKey,TValue>(Dictionary<TKey, TValue> a, Dictionary<TKey, TValue> b)
        {
            if (a == null || b == null)
                return (a == b);

            if (object.ReferenceEquals(a, b))
                return true;

            return a.Count == b.Count && a.All(aKV => b.TryGetValue(aKV.Key, out var bVal) && EqualityComparer<TValue>.Default.Equals(aKV.Value, bVal));
        }

        /// <summary>
        /// Utility method for converting a string to a MemoryStream.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static MemoryStream GenerateMemoryStreamFromString(string s)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        /// <summary>
        /// Utility method for copy the contents of the source stream to the destination stream.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void CopyStream(Stream source, Stream destination)
        {
            CopyStream(source, destination, DefaultBufferSize);
        }

        /// <summary>
        /// Utility method for copy the contents of the source stream to the destination stream.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="bufferSize"></param>
        public static void CopyStream(Stream source, Stream destination, int bufferSize)
        {
            source.CopyTo(destination, bufferSize);
        }

        /// <summary>
        /// Copies the contents of the source stream into a new <see cref="MemoryStream"/> positioned
        /// at the beginning. When <paramref name="capacityHint"/> is a usable value it sizes the
        /// stream up front, avoiding the repeated buffer doubling (and the associated garbage)
        /// an unsized <see cref="MemoryStream"/> incurs for large payloads. An inaccurate hint is
        /// safe: the returned stream always contains exactly the bytes read from the source.
        /// </summary>
        /// <param name="source">Stream to copy from</param>
        /// <param name="capacityHint">Expected content length, e.g. the response Content-Length.
        /// Values less than or equal to 0 are ignored. Because the hint typically originates from
        /// the untrusted Content-Length response header, values larger than an internal limit do
        /// not translate into an eager allocation of that size; growth beyond the limit requires
        /// actual data to arrive.</param>
        /// <returns>A <see cref="MemoryStream"/> with the copied content, positioned at 0</returns>
        public static MemoryStream CopyToMemoryStream(Stream source, long capacityHint)
        {
            // Simple path: the claimed length is small enough to trust with an exact-size
            // allocation (bounded by MaxCapacityHintPreallocationBytes, so a hostile
            // Content-Length cannot force a LOH allocation).
            // Essentially the payload is too small to ramp up a pooled chained-block stream,
            // so we just allocate the exact size and copy.
            if (capacityHint > 0 && capacityHint <= MaxCapacityHintPreallocationBytes)
            {
                var destination = new MemoryStream((int)capacityHint);
                CopyStream(source, destination);
                destination.Seek(0, SeekOrigin.Begin);
                return destination;
            }

            // Unknown content length (e.g. chunked or compressed responses) or a length above the
            // preallocation cap: copy into a pooled chained-block stream (RecyclableMemoryStream)
            // and return it directly - RMS derives from MemoryStream, so no final copy or final
            // allocation is needed. Growth appends pooled fixed-size blocks (no resize copies, no
            // garbage), and the untrusted hint is ignored entirely: blocks are rented only as data
            // actually arrives, so a hostile Content-Length cannot force any eager rent at all.
            // Pool ownership transfers to the returned stream; disposing it returns the blocks,
            // and an undisposed stream degrades to ordinary collectible garbage.
            // PoC: evaluating Microsoft.IO.RecyclableMemoryStream as a formal Core dependency.
            // Its GetBuffer/TryGetBuffer semantics differ from a plain MemoryStream (GetBuffer
            // coalesces into a pooled contiguous buffer; the non-virtual TryGetBuffer reports the
            // empty base buffer) - for these reasons ideal implementation option would be configurable
            // opt-in or an extension.
            var pooledDestination = _responseBodyStreamManager.GetStream(nameof(CopyToMemoryStream));
            
            // NOTE: we avoid source.CopyTo(pooledDestination), it would be simpler, but forces
            // copying every byte twice (source -> intermediate copy buffer -> RMS block, with that
            // buffer being per-call garbage on some netstandard2.0 platforms); reading straight into
            // the RMS block via its IBufferWriter<byte> surface moves each byte once.
            while (true)
            {
                // Read straight into the stream's current pooled block (IBufferWriter<byte>);
                var free = pooledDestination.GetMemory();

                // RecyclableMemoryStream memory is always backed by a pooled array.
                if (!System.Runtime.InteropServices.MemoryMarshal.TryGetArray<byte>(free, out var segment))
                    throw new InvalidOperationException("Expected an array-backed buffer.");

                var read = source.Read(segment.Array, segment.Offset, segment.Count);
                if (read == 0) // by spec the only EoF signal, even if that means extra loop on shorter reads
                    break;

                pooledDestination.Advance(read);
            }
            pooledDestination.Seek(0, SeekOrigin.Begin);
            return pooledDestination;
        }

        /// <summary>
        /// Upper bound on the eager allocation performed by <see cref="CopyToMemoryStream"/>.
        /// The capacity hint comes from the Content-Length header, which is remote input; without
        /// a bound a hostile endpoint could claim a huge length and force large allocations
        /// without ever sending the bytes. The value is kept below the 85,000-byte large-object-heap
        /// threshold so a hostile Content-Length cannot push allocations onto the LOH with a tiny actual
        /// payload; 81,920 (80 KB) is the same size the BCL uses for stream copy buffers for the same
        /// reason. Payloads up to this size are allocated exactly; larger (or fake) lengths grow with
        /// actual received data.
        /// </summary>
        internal const int MaxCapacityHintPreallocationBytes = 80 * 1024;

        /// <summary>
        /// Shared pool of chained-block streams used by <see cref="CopyToMemoryStream"/> for
        /// response bodies that exceed <see cref="MaxCapacityHintPreallocationBytes"/> or have no
        /// usable length hint. Default options: 128 KB blocks, so growth never copies existing data
        /// and abuse of the untrusted Content-Length header cannot cause allocation beyond the
        /// pooled blocks actually filled by received data.
        /// PoC: uses Microsoft.IO.RecyclableMemoryStream as a MS official high-performance memory
        /// stream. For POC benchmarking we use default settings with safe zeroing of returned blocks,
        /// which should be most reasonable default. Opposite to RMS default that doesn't zero out 
        /// returned blocks.
        /// </summary>
        private static readonly Microsoft.IO.RecyclableMemoryStreamManager _responseBodyStreamManager =
            new(new Microsoft.IO.RecyclableMemoryStreamManager.Options() {  ZeroOutBuffer = true});
#endregion

#region Public Methods and Properties

        /// <summary>
        /// Formats the current date as a GMT timestamp
        /// </summary>
        /// <returns>A GMT formatted string representation
        /// of the current date and time
        /// </returns>
        public static string FormattedCurrentTimestampGMT
        {
            get
            {
                DateTime dateTime = AWSSDKUtils.CorrectedUtcNow;
                return dateTime.ToString(GMTDateFormat, CultureInfo.InvariantCulture);
            }
        }



        /// <summary>
        /// Formats the current date as ISO 8601 timestamp
        /// </summary>
        /// <returns>An ISO 8601 formatted string representation
        /// of the current date and time
        /// </returns>
        public static string FormattedCurrentTimestampISO8601
        {
            get
            {
                return GetFormattedTimestampISO8601(0);
            }
        }

        /// <summary>
        /// Gets the ISO8601 formatted timestamp that is minutesFromNow
        /// in the future.
        /// </summary>
        /// <param name="minutesFromNow">The number of minutes from the current instant
        /// for which the timestamp is needed.</param>
        /// <returns>The ISO8601 formatted future timestamp.</returns>
        public static string GetFormattedTimestampISO8601(int minutesFromNow)
        {
            return GetFormattedTimestampISO8601(AWSSDKUtils.CorrectedUtcNow.AddMinutes(minutesFromNow));
        }

        internal static string GetFormattedTimestampISO8601(IClientConfig config, AmazonWebServiceRequest request)
        {
            var endpoint = config.DetermineServiceOperationEndpoint(new ServiceOperationEndpointParameters(request));
            var correctedUtcNow = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(endpoint.URL);

            return GetFormattedTimestampISO8601(correctedUtcNow);
        }

        private static string GetFormattedTimestampISO8601(DateTime dateTime)
        {
            // In this private method in all cases where it is called the dateTime is already a UTC date but
            // we will ensure it is one before formatting as a UTC ISO8601 datetime string.
            return dateTime.ToUniversalTime().ToString(
                AWSSDKUtils.ISO8601DateFormat,
                CultureInfo.InvariantCulture
                );
        }

        /// <summary>
        /// Formats the current date as ISO 8601 timestamp
        /// </summary>
        /// <returns>An ISO 8601 formatted string representation
        /// of the current date and time
        /// </returns>
        public static string FormattedCurrentTimestampRFC822
        {
            get
            {
                return GetFormattedTimestampRFC822(0);
            }
        }

        /// <summary>
        /// Gets the RFC822 formatted timestamp that is minutesFromNow
        /// in the future.
        /// </summary>
        /// <param name="minutesFromNow">The number of minutes from the current instant
        /// for which the timestamp is needed.</param>
        /// <returns>The ISO8601 formatted future timestamp.</returns>
        public static string GetFormattedTimestampRFC822(int minutesFromNow)
        {
            DateTime dateTime = AWSSDKUtils.CorrectedUtcNow.AddMinutes(minutesFromNow);
            return dateTime.ToString(AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Determines whether the given string is an absolute path to a root.
        /// </summary>
        /// <param name="path">The hypothetical absolute path.</param>
        /// <returns>True if <paramref name="path"/> is an absolute path.</returns>
        public static bool IsAbsolutePath(string path)
        {
            return IsWindows() ? !IsPartiallyQualifiedForWindows(path) : Path.IsPathRooted(path);
        }

        private static bool IsWindows()
        {
#if NETSTANDARD
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
#else
            return true;
#endif
        }

        /// <summary>
        /// This method returns true if the variant of the SDK being used is the .NET Framework target. This allows
        /// libraries using .NET Standard 2.0 like AWSSDK.Extensions.NETCore.Setup to know at runtime if they are
        /// using the .NET Framework version and if so make decisions on what APIs it should call.
        /// </summary>
        /// <returns>True if the version of the SDK is .NET Framework variant.</returns>
        public static bool IsNETFramework()
        {
#if NETFRAMEWORK
            return true;
#else
            return false;
#endif
        }

        #region The code in this region has been minimally adapted from Microsoft's PathInternal.Windows.cs class as of 11/19/2019.  The logic remains the same.
        /// <summary>
        /// Returns true if the path specified is relative to the current drive or working directory.
        /// Returns false if the path is fixed to a specific drive or UNC path.  This method does no
        /// validation of the path (URIs will be returned as relative as a result).
        /// </summary>
        /// <remarks>
        /// Handles paths that use the alternate directory separator.  It is a frequent mistake to
        /// assume that rooted paths (Path.IsPathRooted) are not relative.  This isn't the case.
        /// "C:a" is drive relative- meaning that it will be resolved against the current directory
        /// for C: (rooted, but relative). "C:\a" is rooted and not relative (the current directory
        /// will not be used to modify the path).
        /// </remarks>
        private static bool IsPartiallyQualifiedForWindows(string path)
        {
            if (path.Length < 2)
            {
                // It isn't fixed, it must be relative.  There is no way to specify a fixed
                // path with one character (or less).
                return true;
            }

            if (IsWindowsDirectorySeparator(path[0]))
            {
                // There is no valid way to specify a relative path with two initial slashes or
                // \? as ? isn't valid for drive relative paths and \??\ is equivalent to \\?\
                return !(path[1] == '?' || IsWindowsDirectorySeparator(path[1]));
            }

            // The only way to specify a fixed path that doesn't begin with two slashes
            // is the drive, colon, slash format- i.e. C:\
            return !((path.Length >= 3)
                && (path[1] == WindowsVolumeSeparatorChar)
                && IsWindowsDirectorySeparator(path[2])
                // To match old behavior we'll check the drive character for validity as the path is technically
                // not qualified if you don't have a valid drive. "=:\" is the "=" file's default data stream.
                && IsValidWindowsDriveChar(path[0]));
        }

        /// <summary>
        /// True if the given character is a directory separator.
        /// </summary>
        private static bool IsWindowsDirectorySeparator(char c)
        {
            return c == WindowsDirectorySeparatorChar || c == WindowsAltDirectorySeparatorChar;
        }

        /// <summary>
        /// Returns true if the given character is a valid drive letter
        /// </summary>
        private static bool IsValidWindowsDriveChar(char value)
        {
            return (value >= 'A' && value <= 'Z') || (value >= 'a' && value <= 'z');
        }
#endregion The code in this region has been minimally adapted from Microsoft's PathInternal.Windows.cs class as of 11/19/2019.  The logic remains the same.

        /// <summary>
        /// URL encodes a string per RFC3986. If the path property is specified,
        /// the accepted path characters {/+:} are not encoded.
        /// </summary>
        /// <param name="data">The string to encode</param>
        /// <param name="path">Whether the string is a URL path or not</param>
        /// <returns>The encoded string</returns>
        public static string UrlEncode(string data, bool path)
        {
            return UrlEncode(3986, data, path);
        }

        /// <summary>
        /// URL encodes a string per the specified RFC. If the path property is specified,
        /// the accepted path characters {/+:} are not encoded.
        /// </summary>
        /// <param name="rfcNumber">RFC number determining safe characters</param>
        /// <param name="data">The string to encode</param>
        /// <param name="path">Whether the string is a URL path or not</param>
        /// <returns>The encoded string</returns>
        /// <remarks>
        /// Currently recognised RFC versions are 1738 (Dec '94) and 3986 (Jan '05). 
        /// If the specified RFC is not recognised, 3986 is used by default.
        /// </remarks>
        [SkipLocalsInit]
        public static string UrlEncode(int rfcNumber, string data, bool path)
        {
            // Return empty (never null) for null/empty input, since the loops below return the original
            // reference unchanged when nothing needs encoding.
            if (string.IsNullOrEmpty(data))
                return string.Empty;

            byte[] sharedDataBuffer = null;
            const int MaxStackLimit = 256;
            try
            {
                var dataAsSpan = data.AsSpan();
                var encoding = Encoding.UTF8;

                var dataByteLength = encoding.GetMaxByteCount(dataAsSpan.Length);

                // The dataBuffer byte span will be used to store utf8 bytes of the data be encoded at the end and
                // url encoded at the start of dataBuffer. As the utf8 bytes are iterated and percent encoded at the
                // beginning dataBuffer the utf8 bytes at the end will be overwritten by the percent encoding.
                // The size of the dataBuffer needs to be 3 times the size utf8 max encoding to handle the worst
                // case scenario of every character needing to be percent encoding taking 3 bytes.
                var encodedByteLength = 3 * dataByteLength;
                var dataBuffer = encodedByteLength <= MaxStackLimit
                    ? stackalloc byte[MaxStackLimit]
                    : sharedDataBuffer = ArrayPool<byte>.Shared.Rent(encodedByteLength);

                var output = UrlEncodeToSpan(rfcNumber, dataAsSpan, path, dataBuffer, out var encoded);

                // Nothing was encoded, so the output equals the input; return the original string and skip the
                // allocation.
                if (!encoded)
                    return data;

                return encoding.GetString(output);
            }
            finally
            {
                if (sharedDataBuffer != null) ArrayPool<byte>.Shared.Return(sharedDataBuffer);
            }
        }

        /// <summary>
        /// Core of <see cref="UrlEncode(int, string, bool)"/>: UTF-8 encodes <paramref name="data"/> and
        /// percent-encodes it per the given RFC into <paramref name="dataBuffer"/>, which must be at least
        /// 3x the UTF-8 max byte count of <paramref name="data"/>. Returns the slice of bytes that form the
        /// output (this aliases into <paramref name="dataBuffer"/>) and sets <paramref name="encoded"/> to
        /// false when no character needed escaping (the returned slice is then the raw UTF-8 bytes).
        /// </summary>
        private static ReadOnlySpan<byte> UrlEncodeToSpan(int rfcNumber, ReadOnlySpan<char> data, bool path, Span<byte> dataBuffer, out bool encoded)
        {
            var unreservedChars = GetUrlEncodeLookup(rfcNumber, path);
            var encoding = Encoding.UTF8;

            var dataByteLength = encoding.GetMaxByteCount(data.Length);

            // Instead of stack allocating or renting two buffers we use one buffer with at least twice the capacity of the
            // max encoding length. Then store the character data as bytes in the second half reserving the first half of the buffer
            // for the encoded representation.
            var encodingBuffer = dataBuffer.Slice(dataBuffer.Length - dataByteLength);
            var bytesWritten = encoding.GetBytes(data, encodingBuffer);
            var encodingBytes = encodingBuffer.Slice(0, bytesWritten);

            var index = 0;
            var startIndex = 0;

#if NET8_0_OR_GREATER
            // Vectorized scan to the first byte that needs encoding. When there is none, the output equals
            // the raw utf8 bytes; return the encodingBytes unchanged - the common case for already-safe values.
            var firstEncoded = ((ReadOnlySpan<byte>)encodingBytes).IndexOfAnyExcept(GetUrlEncodeSearchValues(rfcNumber, path));
            if (firstEncoded == -1)
            {
                encoded = false;
                return encodingBytes;
            }

            // Bulk-copy the safe prefix, then let the per-byte loop handle the remainder.
            if (firstEncoded > 0)
            {
                encodingBytes.Slice(0, firstEncoded).CopyTo(dataBuffer);
                index = firstEncoded;
                startIndex = firstEncoded;
            }
#endif

            encoded = false;
            for (var i = startIndex; i < encodingBytes.Length; i++)
            {
                var symbol = encodingBytes[i];
                if (symbol < 128 && unreservedChars[symbol])
                {
                    dataBuffer[index++] = symbol;
                }
                else
                {
                    encoded = true;
                    dataBuffer[index++] = (byte)'%';

                    // Break apart the byte into two four-bit components and
                    // then convert each into their hexadecimal equivalent.
                    var hiNibble = symbol >> 4;
                    var loNibble = symbol & 0xF;
                    dataBuffer[index++] = (byte)upperHex[hiNibble];
                    dataBuffer[index++] = (byte)upperHex[loNibble];
                }
            }

            return dataBuffer.Slice(0, index);
        }

#if !NETFRAMEWORK
        /// <summary>
        /// Percent-encodes <paramref name="data"/> per the given RFC and writes the resulting UTF-8 bytes
        /// directly into <paramref name="buffer"/>, avoiding the intermediate string that
        /// <see cref="UrlEncode(int, string, bool)"/> allocates. Used by the Query-protocol body builders to
        /// write straight into a pooled buffer. Produces byte-for-byte the same output as
        /// <c>Encoding.UTF8.GetBytes(UrlEncode(rfcNumber, data, path))</c>.
        /// </summary>
        [SkipLocalsInit]
        internal static void UrlEncodeToBuffer(int rfcNumber, IBufferWriter<byte> buffer, string data, bool path)
        {
            if (string.IsNullOrEmpty(data))
                return;

            byte[] sharedDataBuffer = null;
            const int MaxStackLimit = 256;
            try
            {
                var dataAsSpan = data.AsSpan();
                var encodedByteLength = 3 * Encoding.UTF8.GetMaxByteCount(dataAsSpan.Length);
                var dataBuffer = encodedByteLength <= MaxStackLimit
                    ? stackalloc byte[MaxStackLimit]
                    : sharedDataBuffer = ArrayPool<byte>.Shared.Rent(encodedByteLength);

                // Unlike the string overload, the no-encode case must still WRITE the raw utf8 bytes (the
                // string overload returns the original string instead). UrlEncodeToSpan returns the output
                // slice for both the encoded and the raw-passthrough case, so we always copy what it returns.
                var output = UrlEncodeToSpan(rfcNumber, dataAsSpan, path, dataBuffer, out _);

                var dest = buffer.GetSpan(output.Length);
                output.CopyTo(dest);
                buffer.Advance(output.Length);
            }
            finally
            {
                if (sharedDataBuffer != null) ArrayPool<byte>.Shared.Return(sharedDataBuffer);
            }
        }
#endif
        
        internal static bool TryGetRFCEncodingSchemes(int rfcNumber, out string encodingScheme)
        {
            if (rfcNumber == 3986)
            {
                encodingScheme = ValidUrlCharacters;
                return true;
            }

            if (rfcNumber == 1738)
            {
                encodingScheme = ValidUrlCharactersRFC1738;
                return true;
            }

            encodingScheme = null;
            return false;
        }

        private static readonly char[] lowerHex = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
        private static readonly char[] upperHex = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        private static void ToHexString(ReadOnlySpan<byte> source, Span<char> destination, bool lowercase)
        {
            var converter = lowercase ? lowerHex : upperHex;
            for (int i = source.Length - 1; i >= 0; i--)
            {
                // Break apart the byte into two four-bit components and
                // then convert each into their hexadecimal equivalent.
                byte b = source[i];
                int hiNibble = b >> 4;
                int loNibble = b & 0xF;
                destination[i * 2] = converter[hiNibble];
                destination[i * 2 + 1] = converter[loNibble];
            }
        }

        internal static string UrlEncodeSlash(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return data;
            }

            return data.Replace("/", EncodedSlash);
        }


        private static readonly bool[] ValidTraceIdHeaderValueCharactersLookup = BuildTraceIdHeaderValueLookup(ValidTraceIdHeaderValueCharacters);

        private static bool[] BuildTraceIdHeaderValueLookup(string validTraceIdHeaderValueCharacters)
        {
            var lookup = new bool[128];
            foreach (var c in validTraceIdHeaderValueCharacters)
            {
                if (c < 128) lookup[c] = true;
            }
            return lookup;
        }

        /// <summary>
        /// Percent encodes the X-Amzn-Trace-Id header value skipping any characters within the
        /// ValidTraceIdHeaderValueCharacters character set.
        /// </summary>
        /// <param name="value">The X-Amzn-Trace-Id header value to encode.</param>
        /// <returns>An encoded X-Amzn-Trace-Id header value.</returns>
        internal static string EncodeTraceIdHeaderValue(string value)
        {
            using var encoded = new ValueStringBuilder(value.Length * 2);
            var utf8Bytes = ArrayPool<byte>.Shared.Rent(Encoding.UTF8.GetMaxByteCount(value.Length));
            try
            {
#if NETCOREAPP3_1_OR_GREATER
                var length = Encoding.UTF8.GetBytes(value, utf8Bytes);
#else
                var length = Encoding.UTF8.GetBytes(value, 0, value.Length, utf8Bytes, 0);
#endif
                foreach (var b in utf8Bytes.AsSpan(0, length))
                {
                    if (b < 128 && ValidTraceIdHeaderValueCharactersLookup[b])
                    {
                        encoded.Append((char)b);
                    }
                    else
                    {
                        encoded.Append('%');
                        encoded.Append(upperHex[b >> 4]);
                        encoded.Append(upperHex[b & 0xF]);
                    }
                }
            }
            finally
            {
                ArrayPool<byte>.Shared.Return(utf8Bytes);
            }
            return encoded.AsSpan().ToString();
        }

        /// <summary>
        /// Generates an MD5 Digest for the stream specified
        /// </summary>
        /// <param name="input">The Stream for which the MD5 Digest needs
        /// to be computed.</param>
        /// <returns>A string representation of the hash with base64 encoding
        /// </returns>
        public static string GenerateMD5ChecksumForStream(Stream input)
        {
            string hash = null;

            if (!input.CanSeek)
                throw new InvalidOperationException("Input stream must be seekable");

            // Use an MD5 instance to compute the hash for the stream
            byte[] hashed = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(input);

            // Convert the hash to a Base64 Encoded string and return it
            hash = Convert.ToBase64String(hashed);

            // Now that the hash has been generated, reset the stream to its origin so that the stream's data can be processed
            input.Position = 0;

            return hash;
        }

        /// <remarks> 
        /// Note, this was called directly from service packages prior to compression support
        /// being added shortly after 3.7.200. It's important to preserve the signature and functionality
        /// until the next minor version for those older 3.7.* service packages.
        /// </remarks>
        /// <summary>
        /// Generates an MD5 Digest for the string-based content
        /// </summary>
        /// <param name="content">The content for which the MD5 Digest needs
        /// to be computed.
        /// </param>
        /// <param name="fBase64Encode">Whether the returned checksum should be
        /// base64 encoded.
        /// </param>
        /// <returns>A string representation of the hash with or w/o base64 encoding
        /// </returns>
        public static string GenerateChecksumForContent(string content, bool fBase64Encode)
        {
            // Convert the input string to a byte array and compute the hash.
            return GenerateChecksumForBytes(Encoding.UTF8.GetBytes(content), fBase64Encode);
        }

        /// <summary>
        /// Generates an MD5 Digest for the given byte array
        /// </summary>
        /// <param name="content">The content for which the MD5 Digest needs
        /// to be computed.
        /// </param>
        /// <param name="fBase64Encode">Whether the returned checksum should be
        /// base64 encoded.
        /// </param>
        /// <returns>A string representation of the hash with or w/o base64 encoding
        /// </returns>
        public static string GenerateChecksumForBytes(byte[] content, bool fBase64Encode)
        {

            var hashed = content != null ?
                CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(content) :
                CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(ArrayEx.Empty<byte>());

            if (fBase64Encode)
            {
                // Convert the hash to a Base64 Encoded string and return it
                return Convert.ToBase64String(hashed);
            }
            else
            {
#if NET8_0_OR_GREATER
                return Convert.ToHexString(hashed);
#else
                return BitConverter.ToString(hashed).Replace("-", String.Empty);
#endif
            }
        }

        public static void Sleep(TimeSpan ts)
        {
            Sleep((int)ts.TotalMilliseconds);
        }

        /// <summary>
        /// Convert a hex string to bytes
        /// </summary>
        /// <param name="hex">Hexadecimal string</param>
        /// <returns>Byte array corresponding to the hex string.</returns>
        public static byte[] HexStringToBytes(string hex)
        {
            if (string.IsNullOrEmpty(hex) || hex.Length % 2 == 1)
            {
                throw new ArgumentOutOfRangeException(nameof(hex));
            }
#if NET8_0_OR_GREATER
            return Convert.FromHexString(hex);
#else
            byte[] buffer = new byte[hex.Length / 2];
            for (int i = 0, j = 0; i < hex.Length; i += 2, j++)
                buffer[j] = (byte)((HexCharToNibble(hex[i]) << 4) | HexCharToNibble(hex[i + 1]));

            return buffer;
#endif
        }

#if !NET8_0_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int HexCharToNibble(char c)
        {
            if ((uint)(c - '0') <= 9) return c - '0';
            if ((uint)(c - 'A') <= 5) return c - 'A' + 10;
            if ((uint)(c - 'a') <= 5) return c - 'a' + 10;
            throw new FormatException("Invalid hex character: " + c);
        }
#endif

        /// <summary>
        /// Returns DateTime.UtcNow + ManualClockCorrection when
        /// <seealso cref="AWSConfigs.ManualClockCorrection"/> is set.
        /// This value should be used instead of DateTime.UtcNow to factor in manual clock correction
        /// </summary>
        public static DateTime CorrectedUtcNow
        {
            get
            {
                var now = AWSConfigs.utcNowSource();
                if (AWSConfigs.ManualClockCorrection.HasValue)
                    now += AWSConfigs.ManualClockCorrection.Value;
                return now;
            }
        }

        private static readonly char[] _bidiControlChars =
        {
            '\u200E', // LRM
            '\u200F', // RLM
            '\u202A', // LRE
            '\u202B', // RLE
            '\u202C', // PDF
            '\u202D', // LRO
            '\u202E'  // RLO
        };

#if NET8_0_OR_GREATER
        private static readonly SearchValues<char> _bidiControlCharSearchValues =
            SearchValues.Create(_bidiControlChars);
#endif

        /// <summary>
        /// Returns true if the string has any bidirectional control characters.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool HasBidiControlCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;
#if NET8_0_OR_GREATER
            return input.AsSpan().IndexOfAny(_bidiControlCharSearchValues) >= 0;
#else
            return input.AsSpan().IndexOfAny(_bidiControlChars) >= 0;
#endif
        }

        public static string DownloadStringContent(Uri uri)
        {
            return DownloadStringContent(uri, TimeSpan.Zero, null);
        }

        public static string DownloadStringContent(Uri uri, TimeSpan timeout)
        {
            return DownloadStringContent(uri, timeout, null);
        }

        public static string DownloadStringContent(Uri uri, IWebProxy proxy)
        {
            return DownloadStringContent(uri, TimeSpan.Zero, proxy);
        }                

        public static string DownloadStringContent(Uri uri, TimeSpan timeout, IWebProxy proxy)
        {
#if NETSTANDARD
            using (var client = CreateClient(uri, timeout, proxy, null))
            {
                return AsyncHelpers.RunSync<string>(() =>
                {
                    return client.GetStringAsync(uri);
                }); 
            }
#else
            var request = CreateClient(uri, timeout, proxy, null);

            using (var response = request.GetResponse() as HttpWebResponse)
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
#endif
        }

        /// <summary>
        /// Executes an HTTP request and returns the response as a string. This method
        /// throws WebException and HttpRequestException. In the event HttpRequestException
        /// is thrown the StatusCode is sent as user defined data on the exception under
        /// the key "StatusCode".
        /// </summary>
        /// <param name="uri">The URI to make the request to</param>
        /// <param name="requestType">The request type: GET, PUT, POST</param>
        /// <param name="content">null or the content to send with the request</param>
        /// <param name="timeout">Timeout for the request</param>
        /// <param name="proxy">Proxy for the request</param>
        /// <param name="headers">null or any headers to send with the request</param>
        /// <returns>The response as a string.</returns>
        public static string ExecuteHttpRequest(Uri uri, string requestType, string content, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
        {
#if NETSTANDARD
            using (var client = CreateClient(uri, timeout, proxy, headers))
            {           
                var response = AsyncHelpers.RunSync<HttpResponseMessage>(() =>
                {
                    var requestMessage = new HttpRequestMessage(new HttpMethod(requestType), uri);
                    if(!string.IsNullOrEmpty(content))
                    {
                        requestMessage.Content = new StringContent(content);         
                    }
                                
                    return client.SendAsync(requestMessage);        
                });

                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch(HttpRequestException e)
                {
                    var httpRequestException = new HttpRequestException(e.Message, e);
                    httpRequestException.Data.Add(nameof(response.StatusCode), response.StatusCode);

                    response.Dispose();
                    throw httpRequestException;
                }
                            
                try
                {
                    return AsyncHelpers.RunSync<string>(() =>
                    {
                        return response.Content.ReadAsStringAsync();        
                    });
                }
                finally 
                {
                    response.Dispose();
                }
            }
#else
            var request = CreateClient(uri, timeout, proxy, headers);
            request.Method = requestType;
            request.ContentLength = 0;
                        
            if (!string.IsNullOrEmpty(content))
            {
                var contentBytes = Encoding.UTF8.GetBytes(content);
                request.ContentLength = contentBytes.Length;
                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(contentBytes, 0, contentBytes.Length);
                }                
            }
                        
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }            
#endif
        }

        /// <summary>
        /// Executes an HTTP request and returns the response as a string. This method
        /// throws WebException and HttpRequestException. In the event HttpRequestException
        /// is thrown the StatusCode is sent as user defined data on the exception under
        /// the key "StatusCode".
        /// </summary>
        /// <param name="uri">The URI to make the request to</param>
        /// <param name="requestType">The request type: GET, PUT, POST</param>
        /// <param name="content">null or the content to send with the request</param>
        /// <param name="timeout">Timeout for the request</param>
        /// <param name="proxy">Proxy for the request</param>
        /// <param name="headers">null or any headers to send with the request</param>
        /// <returns>The response as a string.</returns>
        public static async Task<string> ExecuteHttpRequestAsync(Uri uri, string requestType, string content, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
        {
#if NETSTANDARD
            using (var client = CreateClient(uri, timeout, proxy, headers))
            {
                var requestMessage = new HttpRequestMessage(new HttpMethod(requestType), uri);
                if (!string.IsNullOrEmpty(content))
                {
                    requestMessage.Content = new StringContent(content);
                }
                var response = await client.SendAsync(requestMessage).ConfigureAwait(false);

                try
                {
                    response.EnsureSuccessStatusCode();
                }
                catch (HttpRequestException e)
                {
                    var httpRequestException = new HttpRequestException(e.Message, e);
                    httpRequestException.Data.Add(nameof(response.StatusCode), response.StatusCode);

                    response.Dispose();
                    throw httpRequestException;
                }

                try
                {
                        return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                finally
                {
                    response.Dispose();
                }
            }
#else
            var request = CreateClient(uri, timeout, proxy, headers);
            request.Method = requestType;
            request.ContentLength = 0;
                        
            if (!string.IsNullOrEmpty(content))
            {
                var contentBytes = Encoding.UTF8.GetBytes(content);
                request.ContentLength = contentBytes.Length;
                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(contentBytes, 0, contentBytes.Length);
                }                
            }
                        
            using (var response = await request.GetResponseAsync().ConfigureAwait(false) as HttpWebResponse)
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    return await reader.ReadToEndAsync().ConfigureAwait(false);
                }
            }            
#endif
        }

#if NETSTANDARD
        private static HttpClient CreateClient(Uri uri, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
        {
            var client = new HttpClient(new System.Net.Http.HttpClientHandler() { Proxy = proxy });
            
            if (timeout > TimeSpan.Zero)
            {
                client.Timeout = timeout;
            }
                
            //DefaultRequestHeaders should not be used if we reuse the HttpClient. It is currently created for each request.
            client.DefaultRequestHeaders.TryAddWithoutValidation(UserAgentHeader, _userAgent);
            if(headers != null)
            {
                foreach(var nameValue in headers)
                {
                    client.DefaultRequestHeaders.TryAddWithoutValidation(nameValue.Key, nameValue.Value);
                }
            }
                                
            return client;
        }
#else
        private static HttpWebRequest CreateClient(Uri uri, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
        { 
            HttpWebRequest request = HttpWebRequest.Create(uri) as HttpWebRequest;
            request.Proxy = proxy ?? WebRequest.DefaultWebProxy;

            if (timeout > TimeSpan.Zero)
            {
                request.Timeout = (int)timeout.TotalMilliseconds;
            }

            request.UserAgent = _userAgent;
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    // HttpWebRequest requires that UserAgent be set via the explicit property instead of using the headers collection.
                    // If you use the Headers collection an exception will be thrown.
                    if(string.Equals(header.Key, HeaderKeys.UserAgentHeader, StringComparison.InvariantCultureIgnoreCase))
                    {
                        request.UserAgent = header.Value;
                    }
                    else
                    {
                        request.Headers.Add(header.Key, header.Value);
                    }
                }
            }

            return request;
        }
#endif


        public static Stream OpenStream(Uri uri)
        {
            return OpenStream(uri, null);
        }

        public static Stream OpenStream(Uri uri, IWebProxy proxy)
        {
#if NETSTANDARD
            using (var client = new System.Net.Http.HttpClient(new System.Net.Http.HttpClientHandler() { Proxy = proxy }))
            {
                var task = client.GetStreamAsync(uri);
                return task.Result;
            }
#else
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.Proxy = proxy ?? WebRequest.DefaultWebProxy;
            var asynResult = request.BeginGetResponse(null, null);
            HttpWebResponse response = request.EndGetResponse(asynResult) as HttpWebResponse;
            return response.GetResponseStream();
#endif
        }

        /// <summary>
        /// Utility method that accepts a string and replaces white spaces with a space.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string CompressSpaces(string data)
        {
            const char SPACE = ' ';
            if (data == null)
            {
                return null;
            }

            var dataLength = data.Length;
            if (dataLength == 0)
            {
                return string.Empty;
            }

            // Fast path: scan for the first run of consecutive whitespace or non-space whitespacecharacter.
            // If none exists the string is already compact — return it unchanged with no allocation.
            bool prevWasWhiteSpace = false;
            int firstRunIndex = -1;
            for (int i = 0; i < dataLength; i++)
            {
                char c = data[i];
                bool isWS = char.IsWhiteSpace(c);
                if (isWS && (prevWasWhiteSpace || c != SPACE))
                {
                    firstRunIndex = i - 1;
                    break;
                }
                prevWasWhiteSpace = isWS;
            }

            if (firstRunIndex < 0)
                return data;

            // Slow path: at least one run was found.  Copy the clean prefix directly,
            // then process the remainder segment-by-segment: flush each non-WS run as a
            // single Append(span) call and skip each WS run with a do-while.
            var stringBuilder = new ValueStringBuilder(dataLength);
            stringBuilder.Append(data.AsSpan(0, firstRunIndex));

            int pos = firstRunIndex;
            while (pos < dataLength)
            {
                if (char.IsWhiteSpace(data[pos]))
                {
                    stringBuilder.Append(SPACE);
                    do { pos++; } while (pos < dataLength && char.IsWhiteSpace(data[pos]));
                }
                else
                {
                    int segStart = pos;
                    do { pos++; } while (pos < dataLength && !char.IsWhiteSpace(data[pos]));
                    stringBuilder.Append(data.AsSpan(segStart, pos - segStart));
                }
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Extracts the operation name from a given request name.
        /// </summary>
        /// <param name="requestName">The name of the request from which the operation name is to be extracted.</param>
        /// <returns>
        /// The operation name if the request name ends with "Request"; otherwise, returns the original request name.
        /// </returns>
        internal static string ExtractOperationName(string requestName)
        {
            if (requestName.EndsWith("Request", StringComparison.Ordinal))
            {
                return requestName.Substring(0, requestName.Length - 7);
            }
            return requestName;
        }

        /// <summary>
        /// Runs a process with the below input parameters.
        /// </summary>
        /// <param name="processStartInfo"></param>
        /// <returns></returns>
        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
        public static ProcessExecutionResult RunProcess(ProcessStartInfo processStartInfo)
        {
            using (var process = new Process
            {
                StartInfo = processStartInfo
            })
            {
                var logger = Logger.GetLogger(typeof(AWSSDKUtils));
                logger.InfoFormat("Starting a process with the following ProcessInfo: UseShellExecute - {0} RedirectStandardError - {1}, RedirectStandardOutput - {2}, CreateNoWindow - {3}",  
                    processStartInfo.UseShellExecute, processStartInfo.RedirectStandardError, processStartInfo.RedirectStandardOutput, processStartInfo.CreateNoWindow);
                process.Start();
                logger.DebugFormat("Process started");
                string standardOutput = null;
                var thread = new Thread(() => standardOutput = process.StandardOutput.ReadToEnd());
                thread.Start();
                var standardError = process.StandardError.ReadToEnd();
                thread.Join();
                process.WaitForExit();    

                return new ProcessExecutionResult
                {
                    ExitCode = process.ExitCode,
                    StandardError = standardError,
                    StandardOutput = standardOutput
                };    
            }
        }

        [SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
        public static async Task<ProcessExecutionResult> RunProcessAsync(ProcessStartInfo processStartInfo)
        {
            var logger = Logger.GetLogger(typeof(AWSSDKUtils));
            using (var process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            })
            {
                var tcs = new TaskCompletionSource<object>();
                process.Exited += (s, ea) => tcs.SetResult(null);
                logger.InfoFormat("Starting a process with the following ProcessInfo: UseShellExecute - {0} RedirectStandardError - {1}, RedirectStandardOutput - {2}, CreateNoWindow - {3}",  
                    processStartInfo.UseShellExecute, processStartInfo.RedirectStandardError, processStartInfo.RedirectStandardOutput, processStartInfo.CreateNoWindow);    
                process.Start();
                logger.DebugFormat("Process started");

                var standardErrorTask = process.StandardError.ReadToEndAsync();
                var standardOutputTask = process.StandardOutput.ReadToEndAsync();

                await Task.WhenAll(tcs.Task, standardErrorTask, standardOutputTask).ConfigureAwait(false);

                return new ProcessExecutionResult
                {
                    ExitCode = process.ExitCode,
                    StandardError = standardErrorTask.Result,
                    StandardOutput = standardOutputTask.Result
                };
            }

        }

        /// <summary>
        /// This method allows to check whether a property of an object returned by a service call
        /// is set. This method is needed to discriminate whether a field is not set (not present in
        /// the service response) or if it is set to the default value for its type. Using this
        /// method is not required for nullable properties (non-ValueType and Nullable) because
        /// they will be simply set to null when not included in the service response.
        /// This method can also be used on objects used as part of service requests.
        /// This method doesn't support objects that are part of the S3 service model.
        /// </summary>
        /// <param name="awsServiceObject">An object that is used in an AWS service request or is
        /// returned as part of an AWS service response.</param>
        /// <param name="propertyName">The name of the property of awsServiceObject to check.</param>
        /// <returns>True if the property is set, otherwise false.</returns>
        public static bool IsPropertySet(object awsServiceObject, string propertyName)
        {
            var type = awsServiceObject.GetType();
            var nameSpace = type.Namespace;

            if (!nameSpace.StartsWith("Amazon.", StringComparison.Ordinal) || !nameSpace.EndsWith(".Model", StringComparison.Ordinal))
            {
                throw new ArgumentException("IsPropertySet can be used only on Amazon Model classes");
            }
            else if (nameSpace == "Amazon.S3.Model")
            {
                throw new ArgumentException("IsPropertySet doesn't support S3");
            }

            var key = new IsSetMethodsCacheKey(type, propertyName);

            //We cache the result of GetIsPropertySetMethodInfo even if it is null
            var method = IsSetMethodsCache.GetOrAdd(key, (k) => k.Type.GetMethod("IsSet" + k.PropertyName,
                                                                                 BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance,
                                                                                 null,
                                                                                 new Type[0],
                                                                                 new ParameterModifier[0]));
            if (method == null)
            {
                throw new ArgumentException("Could not find an IsSet method for property " + key);
            }

            object result = method.Invoke(awsServiceObject, new object[0]);

            if (!(result is bool))
            {
                throw new ArgumentException("The IsSet method for property " + key + " didn't return a bool");
            }

            return (bool)result;
        }
#endregion

#region Private Methods, Static Fields and Classes

        private static readonly LruCache<IsSetMethodsCacheKey, MethodInfo> IsSetMethodsCache = new LruCache<IsSetMethodsCacheKey, MethodInfo>(MaxIsSetMethodsCacheSize);

        private class IsSetMethodsCacheKey
        {
            public readonly Type Type;
            public readonly string PropertyName;
            public IsSetMethodsCacheKey(Type type, string propertyName)
            {
                Type = type;
                PropertyName = propertyName;
            }
            public override bool Equals(object other)
            {
                var otherKey = other as IsSetMethodsCacheKey;
                if (otherKey == null)
                {
                    return false;
                }
                return Type == otherKey.Type && PropertyName == otherKey.PropertyName;
            }

            public override int GetHashCode()
            {
                return Type.GetHashCode() ^ PropertyName.GetHashCode();
            }

            public override string ToString()
            {
                return Type.FullName + "." + PropertyName;
            }
        }
#endregion
    }

    public class JitteredDelay
    {
        private readonly TimeSpan _maxDelay;
        private readonly TimeSpan _variance;
        private readonly TimeSpan _baseIncrement;
        private readonly Random _rand = null;
        private int _count = 0;

        public JitteredDelay(TimeSpan baseIncrement, TimeSpan variance)
            : this(baseIncrement, variance, new TimeSpan(0, 0, 30))
        {
        }

        public JitteredDelay(TimeSpan baseIncrement, TimeSpan variance, TimeSpan maxDelay)
        {
            _baseIncrement = baseIncrement;
            _variance = variance;
            _maxDelay = maxDelay;
            _rand = new System.Random();
        }

        public TimeSpan GetRetryDelay(int attemptCount)
        {
            long ticks = (_baseIncrement.Ticks * (long)Math.Pow(2, attemptCount) + (long)(_rand.NextDouble() * _variance.Ticks));
            return new TimeSpan(ticks);
        }

        public TimeSpan Next()
        {
            long nextTick = GetRetryDelay(_count + 1).Ticks;
            if (nextTick < _maxDelay.Ticks)
            {
                _count++;
            }
            else
            {
                nextTick = _maxDelay.Ticks;
            }
            return new TimeSpan(nextTick);
        }

        public void Reset()
        {
            _count = 0;
        }
    }
    public class UriComponent
    {
        public SegmentType SegmentType { get; set; }
        public string Value { get; set; }
    }
    public enum SegmentType
    {
        Literal,
        Label,
    }
    
}
