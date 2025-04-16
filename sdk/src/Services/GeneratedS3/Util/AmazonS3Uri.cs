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
 *
 */

using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Uri wrapper that can parse out information (bucket, key, region, style) from an
    /// S3 URI.
    /// </summary>
    public partial class AmazonS3Uri
    {
        private const string EndpointRegexPattern = @"^(.+\.)?(?:s3|s3express)[.-]([a-z0-9-]+)\.";

#if NET8_0_OR_GREATER
        [GeneratedRegex(EndpointRegexPattern)]
        private static partial Regex EndpointRegexMatch();
#else
        private static Regex EndpointRegexMatch() => _endpointRegexMatch;
        private static readonly Regex _endpointRegexMatch = new Regex(EndpointRegexPattern, RegexOptions.Compiled);
#endif

        /// <summary>
        /// True if the URI contains the bucket in the path, false if it contains the bucket in the authority.
        /// </summary>
        public bool IsPathStyle { get; private set; }

        /// <summary>
        /// The bucket name parsed from the URI (or null if no bucket specified).
        /// </summary>
        public string Bucket { get; private set; }
        
        /// <summary>
        /// The key parsed from the URI (or null if no key specified).
        /// </summary>
        public string Key { get; private set; }
        
        /// <summary>
        /// The region parsed from the URI (or null if no region specified).
        /// </summary>
        public RegionEndpoint Region { get; set; }

        /// <summary>
        /// Constructs a parser for the S3 URI specified as a string.
        /// An encoded URI is expected.
        /// </summary>
        /// <param name="uri">The S3 URI to be parsed.</param>
        public AmazonS3Uri(string uri)
            : this(new Uri(uri))
        {
        }

        /// <summary>
        /// Constructs a parser for the S3 URI specified as a Uri instance.
        /// An encoded URI is expected.
        /// </summary>
        /// <param name="uri">The S3 URI to be parsed.</param>
        public AmazonS3Uri(Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException("uri");

            if (string.IsNullOrEmpty(uri.Host))
                throw new ArgumentException("Invalid URI - no hostname present");

            if (uri.Scheme == "s3")
            {
                this.Region = null;
                this.IsPathStyle = false;
                this.Bucket = uri.Authority;

                if (this.Bucket == null)
                {
                    throw new ArgumentException("Invalid S3 URI - no bucket present");
                }

                this.Key = uri.AbsolutePath.Equals("/") ? null : Decode(uri.AbsolutePath.Substring(1));

                return;
            }

            var match = EndpointRegexMatch().Match(uri.Host);
            if (!match.Success)
                throw new ArgumentException("Invalid S3 URI - hostname does not appear to be a valid S3 endpoint");

            // for host style urls:
            //   group 0 is bucketname plus 's3' prefix and possible region code
            //   group 1 is bucket name
            //   group 2 will be region or 'amazonaws' if US Classic region
            // for path style urls:
            //   group 0 will be s3 prefix plus possible region code
            //   group 1 will be empty
            //   group 2 will be region or 'amazonaws' if US Classic region
            var bucketNameGroup = match.Groups[1];
            if (string.IsNullOrEmpty(bucketNameGroup.Value))
            {
                // no bucket name in the authority, parse it from the path
                this.IsPathStyle = true;

                // grab the encoded path so we don't run afoul of '/'s in the bucket name
                var path = uri.AbsolutePath;
                if (path.Equals("/"))
                {
                    this.Bucket = null;
                    this.Key = null;
                }
                else
                {
                    var index = path.IndexOf('/', 1);
                    if (index == -1)
                    {
                        // https://s3.amazonaws.com/bucket
                        this.Bucket = Decode(path.Substring(1));
                        this.Key = null;
                    }
                    else if (index == (path.Length - 1))
                    {
                        // https://s3.amazonaws.com/bucket/
                        this.Bucket = Decode(path.Substring(1, index)).TrimEnd('/');
                        this.Key = null;
                    }
                    else
                    {
                        // https://s3.amazonaws.com/bucket/key
                        this.Bucket = Decode(path.Substring(1, index)).TrimEnd('/');
                        this.Key = Decode(path.Substring(index + 1));
                    }
                }
            }
            else
            {
                // bucket name in the host, path is the object key
                this.IsPathStyle = false;

                // remove any trailing '.' from the prefix to get the bucket name
                this.Bucket = bucketNameGroup.Value.TrimEnd('.');
                this.Key = uri.AbsolutePath.Equals("/") ? null : Decode(uri.AbsolutePath.Substring(1));
            }

            if (match.Groups.Count > 2)
            {
                // US 'classic' urls will not have a region code in the endpoint
                var regionGroupValue = match.Groups[2].Value;
                if (regionGroupValue.Equals("amazonaws", StringComparison.Ordinal)
                    || regionGroupValue.Equals("external-1", StringComparison.Ordinal))
                    this.Region = RegionEndpoint.USEast1;
                else
                {
                    try
                    {
                        this.Region = RegionEndpoint.GetBySystemName(regionGroupValue);
                    }
                    catch (Amazon.Runtime.AmazonClientException)
                    {
                        // in cases where endpoints such as "s3-accelerate" matches, 
                        // just set the region to null and move on.
                        this.Region = null;
                    }
                }
            }
        }

        /// <summary>
        /// Constructs a parser for the S3 URI specified as a string.
        /// An encoded URI is expected.
        /// </summary>
        /// <param name="uri">The S3 URI to be parsed.</param>
        /// <param name="decode">Flag indicating if URI string should be preprocessed to decode certain characters.</param>
        public AmazonS3Uri(string uri, bool decode)
            : this(decode ? EscapeSpecialControlCharacters(uri) : uri)
        {
        }

        /// <summary>
        /// If the given string is an AmazonS3Endpoint return true and set the AmazonS3Uri out parameter.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="amazonS3Uri"></param>
        /// <returns>true if the string is an AmazonS3Endpoint, and the out paramter has been filled in, false otherwise</returns>
        public static bool TryParseAmazonS3Uri(string uri, out AmazonS3Uri amazonS3Uri)
        {
            try
            {
                return TryParseAmazonS3Uri(new Uri(uri), out amazonS3Uri);
            }
            catch (Exception)
            {
                amazonS3Uri = null;
                return false;
            }
        }

        /// <summary>
        /// If the given string is an AmazonS3Endpoint return true and set the AmazonS3Uri out parameter.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="decode">Flag indicating if URI string should be preprocessed to decode certain characters.</param>
        /// <param name="amazonS3Uri"></param>
        /// <returns>true if the string is an AmazonS3Endpoint, and the out paramter has been filled in, false otherwise</returns>
        public static bool TryParseAmazonS3Uri(string uri, bool decode, out AmazonS3Uri amazonS3Uri)
        {
            if (decode)
                uri = EscapeSpecialControlCharacters(uri);

            return TryParseAmazonS3Uri(new Uri(uri), out amazonS3Uri);
        }

        /// <summary>
        /// If the given Uri is an AmazonS3Endpoint return true and set the AmazonS3Uri out parameter.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="amazonS3Uri"></param>
        /// <returns>true if the Uri is an AmazonS3Endpoint, and the out paramter has been filled in, false otherwise</returns>
        public static bool TryParseAmazonS3Uri(Uri uri, out AmazonS3Uri amazonS3Uri)
        {
            try
            {
                if (IsAmazonS3Endpoint(uri))
                {
                    amazonS3Uri = new AmazonS3Uri(uri);
                    return true;
                }
            }
            // intentionally suppress all exceptions, because this is a try method
#pragma warning disable CA1031 // Do not catch general exception types
            catch { }
#pragma warning restore CA1031 // Do not catch general exception types

            amazonS3Uri = null;
            return false;
        }

        /// <summary>
        /// Checks whether the given URI is a Amazon S3 URI.
        /// </summary>
        /// <param name="uri">The S3 URI to be checked.</param>
        /// <returns>true if the URI is a Amazon S3 URI, false; otherwise.</returns>
        public static bool IsAmazonS3Endpoint(string uri)
        {
            if (uri == null)
                throw new ArgumentNullException("uri");

            return IsAmazonS3Endpoint(new Uri(uri));
        }

        /// <summary>
        /// Checks whether the given URI is a Amazon S3 URI.
        /// </summary>
        /// <param name="uri">The S3 URI to be checked.</param>
        /// <returns>true if the URI is a Amazon S3 URI, false; otherwise.</returns>
        public static bool IsAmazonS3Endpoint(Uri uri)
        {
            if (uri == null)
                throw new ArgumentNullException("uri");

            if (uri.IsAbsoluteUri && (uri.Host.EndsWith("amazonaws.com", StringComparison.OrdinalIgnoreCase) || uri.Host.EndsWith("amazonaws.com.cn", StringComparison.OrdinalIgnoreCase)))
            {
                return EndpointRegexMatch().Match(uri.Host).Success;
            }
            else if (uri.IsAbsoluteUri && uri.Scheme == "s3") // For S3 scheme URI, URI Authority is bucket name
            {
                return !string.IsNullOrEmpty(uri.Authority);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Percent-decodes the given string, with a fast path for strings that are not
        /// percent-encoded.
        /// </summary>
        /// <param name="s">The string to decode</param>
        /// <returns>The decoded string</returns>
        static string Decode(string s)
        {
            if (s == null)
                return null;

            for (var i = 0; i < s.Length; ++i)
            {
                if (s[i] == '%')
                    return Decode(s, i);
            }

            return s;
        }

        /// <summary>
        /// Percent-decodes the given string.
        /// </summary>
        /// <param name="s">The string to decode</param>
        /// <param name="firstPercent">The index of the first '%' in the string</param>
        /// <returns>The decoded string</returns>
        static string Decode(string s, int firstPercent)
        {
            var sb = new StringBuilder(s.Substring(0, firstPercent));

            AppendDecoded(sb, s, firstPercent);

            for (var i = firstPercent + 3; i < s.Length; ++i)
            {
                if (s[i] == '%')
                {
                    AppendDecoded(sb, s, i);
                    i += 2;
                }
                else
                    sb.Append(s[i]);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Decodes the percent-encoded character at the given index in the string
        /// and appends the decoded value to the string under construction.
        /// </summary>
        /// <param name="builder">
        /// The string under construction to which the decoded character will be 
        /// appended.
        /// </param>
        /// <param name="s">The string being decoded.</param>
        /// <param name="index">The index of the '%' character in the string.</param>
        static void AppendDecoded(StringBuilder builder, string s, int index)
        {
            if (index > s.Length - 3)
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, 
                                                                  "Invalid percent-encoded string '{0}'", 
                                                                  s));

            var first = s[index + 1];
            var second = s[index + 2];

            var decoded = (char) (FromHex(first) << 4 | FromHex(second));
            builder.Append(decoded);
        }

        /// <summary>
        /// Converts a hex character (0-9A-Fa-f) into its corresponding quad value.
        /// </summary>
        /// <param name="c">The hex character</param>
        /// <returns>The quad value</returns>
        static int FromHex(char c)
        {
            if (c < '0')
            {
                throw new InvalidOperationException(
                    "Invalid percent-encoded string: bad character '" + c + "' in "
                    + "escape sequence.");
            }
            if (c <= '9')
            {
                return (c - '0');
            }

            if (c < 'A')
            {
                throw new InvalidOperationException(
                    "Invalid percent-encoded string: bad character '" + c + "' in "
                    + "escape sequence.");
            }
            if (c <= 'F')
            {
                return (c - 'A') + 10;
            }

            if (c < 'a')
            {
                throw new InvalidOperationException(
                    "Invalid percent-encoded string: bad character '" + c + "' in "
                    + "escape sequence.");
            }
            if (c <= 'f')
            {
                return (c - 'a') + 10;
            }

            throw new InvalidOperationException(
                "Invalid percent-encoded string: bad character '" + c + "' in "
                + "escape sequence.");
        }

        private static string EscapeSpecialControlCharacters(string uri)
        {
            // Addresses https://github.com/aws/aws-sdk-net/issues/1894. Ports the logic from AmazonS3Uri class in Java V1 SDK.
            return uri?.Replace("%3A", ":")
                       .Replace("%2F", "/")
                       .Replace("+", "%20");
        }
    }
}
