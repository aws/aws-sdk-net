/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Xsl;

using Microsoft.Win32;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Util
{
    /// <summary>
    /// This class defines utilities and constants that can be used by 
    /// all the client libraries of the SDK.
    /// </summary>
    public static class AWSSDKUtils
    {
        #region Internal Constants

        internal const string DefaultRegion = "us-east-1";
        internal const string DefaultGovRegion = "us-gov-west-1";

        internal const string SDKVersionNumber = "1.5.37.0";

        internal const string IfModifiedSinceHeader = "IfModifiedSince";
        internal const string IfMatchHeader = "If-Match";
        internal const string ContentTypeHeader = "Content-Type";
        internal const string ContentLengthHeader = "Content-Length";
        internal const string ContentMD5Header = "Content-MD5";
        internal const string ETagHeader = "ETag";
        internal const string RequestIdHeader = "x-amzn-RequestId";
        internal const int DefaultMaxRetry = 3;
        private const int DefaultConnectionLimit = 50;

        private static readonly DateTime EPOCH_START = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        internal static Dictionary<int, string> RFCEncodingSchemes = new Dictionary<int, string>
        {
            { 3986,  ValidUrlCharacters },
            { 1738,  ValidUrlCharactersRFC1738 }
        };

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
        /// The RFC822Date Format string. Used when parsing date objects
        /// </summary>
        public const string RFC822DateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

        #endregion

        #region UserAgent

        static string _userAgentBaseName = "aws-sdk-dotnet";
        static string _versionNumber;
        static string _sdkUserAgent;
        /// <summary>
        /// The AWS SDK User Agent
        /// </summary>        
        public static string SDKUserAgent
        {
            get
            {
                return _sdkUserAgent;
            }
        }

        static AWSSDKUtils()
        {
            buildUserAgentString();
        }

        public static void SetUserAgent(string productName, string versionNumber)
        {
            _userAgentBaseName = productName;
            _versionNumber = versionNumber;
            buildUserAgentString();
        }

        static void buildUserAgentString()
        {
            if (_versionNumber == null)
            {
                _versionNumber = SDKVersionNumber;
            }

            _sdkUserAgent = string.Format("{0}/{1} .NET Runtime/{2} .NET Framework/{3} OS/{4}",
                _userAgentBaseName,
                _versionNumber,
                determineRuntime(),
                determineFramework(),
                Environment.OSVersion.Version.ToString());
        }

        static string determineRuntime()
        {
            return string.Format("{0}.{1}", Environment.Version.Major, Environment.Version.MajorRevision);
        }

        static string determineFramework()
        {
            try
            {
                if (Environment.Version.Major >= 4 && Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Net Framework Setup\\NDP\\v4") != null)
                    return "4.0";
                if (Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Net Framework Setup\\NDP\\v3.5") != null)
                    return "3.5";
                if (Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\Net Framework Setup\\NDP\\v3.0") != null)
                    return "3.0";
                if (Registry.LocalMachine.OpenSubKey(@"Software\\Microsoft\\Net Framework Setup\\NDP\\v2.0.50727") != null)
                    return "2.0";
            }
            catch
            {
            }

            return "Unknown";
        }    

        #endregion

        #region Internal Methods

        internal static void ForceCanonicalPathAndQuery(Uri uri)
        {
            try
            {
                string paq = uri.PathAndQuery; // need to access PathAndQuery
                FieldInfo flagsFieldInfo = typeof(Uri).GetField("m_Flags", BindingFlags.Instance | BindingFlags.NonPublic);
                ulong flags = (ulong)flagsFieldInfo.GetValue(uri);
                flags &= ~((ulong)0x30); // Flags.PathNotCanonical|Flags.QueryNotCanonical
                flagsFieldInfo.SetValue(uri, flags);
            }
            catch { }
        }

        /*
         * Determines the string to be signed based on the input parameters for
         * AWS Signature Version 2
         */
        internal static string CalculateStringToSignV2(IDictionary<string, string> parameters, string serviceUrl)
        {
            StringBuilder data = new StringBuilder("POST\n", 512);
            IDictionary<string, string> sorted =
                  new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
            Uri endpoint = new Uri(serviceUrl);

            data.Append(endpoint.Host);
            data.Append("\n");
            string uri = endpoint.AbsolutePath;
            if (uri == null || uri.Length == 0)
            {
                uri = "/";
            }

            data.Append(AWSSDKUtils.UrlEncode(uri, true));
            data.Append("\n");
            foreach (KeyValuePair<string, string> pair in sorted)
            {
                if (pair.Value != null)
                {
                    data.Append(AWSSDKUtils.UrlEncode(pair.Key, false));
                    data.Append("=");
                    data.Append(AWSSDKUtils.UrlEncode(pair.Value, false));
                    data.Append("&");
                }
            }

            string result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /**
         * Convert Dictionary of paremeters to Url encoded query string
         */
        internal static string GetParametersAsString(IDictionary<string, string> parameters)
        {
            string[] keys = new string[parameters.Keys.Count];
            parameters.Keys.CopyTo(keys, 0);
            Array.Sort<string>(keys);

            StringBuilder data = new StringBuilder(512);
            foreach (string key in keys)
            {
                string value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(AWSSDKUtils.UrlEncode(value, false));
                    data.Append('&');
                }
            }
            string result = data.ToString();
            if (result.Length == 0)
                return string.Empty;

            return result.Remove(result.Length - 1);
        }


        static Dictionary<string, XslCompiledTransform> typeToXslCompiledTransform = new Dictionary<string, XslCompiledTransform>();
        static object typeToXslCompiledTransformLock = new object();

        internal static XslCompiledTransform GetXslCompiledTransform(string name)
        {
            XslCompiledTransform Result;

            lock (typeToXslCompiledTransformLock)
            {
                if (false == typeToXslCompiledTransform.TryGetValue(name, out Result))
                {
                    Result = new XslCompiledTransform();

                    using (XmlTextReader xmlReader = new XmlTextReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(name)))
                    {
                        Result.Load(xmlReader);
                    }

                    typeToXslCompiledTransform.Add(name, Result);
                }
            }

            return Result;
        }

        static readonly object _preserveStackTraceLookupLock = new object();
        static bool _preserveStackTraceLookup = false;
        static MethodInfo _preserveStackTrace;
        /// <summary>
        /// This method is used preserve the stacktrace used from clients that support async calls.  This 
        /// make sure that exceptions thrown during EndXXX methods has the orignal stacktrace that happen 
        /// in the background thread.
        /// </summary>
        /// <param name="exception"></param>
        internal static void PreserveStackTrace(Exception exception)
        {
            if (!_preserveStackTraceLookup)
            {
                lock (_preserveStackTraceLookupLock)
                {
                    _preserveStackTraceLookup = true;
                    try
                    {
                        _preserveStackTrace = typeof(Exception).GetMethod("InternalPreserveStackTrace",
                            BindingFlags.Instance | BindingFlags.NonPublic);
                    }
                    catch { }
                }
            }

            if (_preserveStackTrace != null)
            {
                _preserveStackTrace.Invoke(exception, null);
            }
        }

        /// <summary>
        /// Returns a new string created by joining each of the strings in the
        /// specified list together, with a comma between them.
        /// </summary>
        /// <parma name="strings">The list of strings to join into a single, comma delimited
        /// string list.</parma>
        /// <returns> A new string created by joining each of the strings in the
        /// specified list together, with a comma between strings.</returns>
        internal static String Join(List<String> strings)
        {
            StringBuilder result = new StringBuilder();

            Boolean first = true;
            foreach (String s in strings)
            {
                if (!first) result.Append(", ");

                result.Append(s);
                first = false;
            }

            return result.ToString();
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
            if (url.Contains("//"))
                url = url.Substring(url.IndexOf("//") + 2);

            if(url.EndsWith("/"))
                url = url.Substring(0, url.Length - 1);

            if (!url.Contains(".amazonaws.com"))
                return DefaultRegion;

            string serviceAndRegion = url.Substring(0, url.IndexOf(".amazonaws.com"));

            int queueIndex = serviceAndRegion.IndexOf("queue");
            if (queueIndex == 0)
                return DefaultRegion;
            if (queueIndex > 0)
                return serviceAndRegion.Substring(0, queueIndex - 1);

            char separator;
            if (serviceAndRegion.StartsWith("s3"))
                separator = '-';
            else
                separator = '.';

            if (serviceAndRegion.IndexOf(separator) == -1)
                return DefaultRegion;

            string region = serviceAndRegion.Substring(serviceAndRegion.IndexOf(separator) + 1);
            if (string.Equals(region, "us-gov"))
                return DefaultGovRegion;

            return region;
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
            if (url.Contains("//"))
                url = url.Substring(url.IndexOf("//") + 2);

            string[] urlParts = url.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            if (urlParts == null || urlParts.Length == 0)
                return string.Empty;

            string servicePart = urlParts[0];
            int hyphenated = servicePart.IndexOf('-');
            if (hyphenated < 0)
                return servicePart;
            else
                return servicePart.Substring(0, hyphenated);
        }

        /// <summary>
        /// Utilitly method for converting Unix epoch seconds to DateTime structure.
        /// </summary>
        /// <param name="seconds">The number of seconds since January 1, 1970.</param>
        /// <returns>Converted DateTime structure</returns>
        public static DateTime ConvertFromUnixEpochSeconds(int seconds)
        {
            return new DateTime(seconds * 10000000L + EPOCH_START.Ticks, DateTimeKind.Utc).ToLocalTime();
        }

        public static int ConvertToUnixEpochSeconds(DateTime dateTime)
        {
            return (int)ConvertToUnixEpochMilliSeconds(dateTime);
        }

        public static double ConvertToUnixEpochMilliSeconds(DateTime dateTime)
        {
            TimeSpan ts = new TimeSpan(dateTime.ToUniversalTime().Ticks - EPOCH_START.Ticks);
            double milli = Math.Round(ts.TotalMilliseconds, 0) / 1000.0;
            return milli;
        }

        internal static int GetConnectionLimit(int? clientConfigValue)
        {
            // Connection limit has been explicitly set on the client.
            if (clientConfigValue.HasValue)
                return clientConfigValue.Value;

            // If default has been left at the system default return the SDK default.
            if (ServicePointManager.DefaultConnectionLimit == 2)
                return AWSSDKUtils.DefaultConnectionLimit;

            // The system default has been explicitly changed so we will honor that value.
            return ServicePointManager.DefaultConnectionLimit;
        }

        /// <summary>
        /// Helper function to format a byte array into string
        /// </summary>
        /// <param name="data">The data blob to process</param>
        /// <param name="lowercase">If true, returns hex digits in lower case form</param>
        /// <returns>String version of the data</returns>
        internal static string ToHex(byte[] data, bool lowercase)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString(lowercase ? "x2" : "X2"));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Calls a specific EventHandler in a background thread
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="args"></param>
        /// <param name="sender"></param>
        internal static void InvokeInBackground<T>(EventHandler<T> handler, T args, object sender) where T : EventArgs
        {
            if (handler == null) return;

            var list = handler.GetInvocationList();
            foreach (var call in list)
            {
                var eventHandler = ((EventHandler<T>)call);
                if (eventHandler != null)
                {
                    dispatcher.Invoke(() => eventHandler(sender, args));
                }
            }
        }

        private static BackgroundDispatcher dispatcher = new BackgroundDispatcher();

        /// <summary>
        /// Parses a query string of a URL and returns the parameters as a string-to-string dictionary.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        internal static Dictionary<string, string> ParseQueryParameters(string url)
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
                DateTime dateTime = DateTime.UtcNow;
                DateTime formatted = new DateTime(
                    dateTime.Year,
                    dateTime.Month,
                    dateTime.Day,
                    dateTime.Hour,
                    dateTime.Minute,
                    dateTime.Second,
                    dateTime.Millisecond,
                    DateTimeKind.Local
                    );
                return formatted.ToString(
                    GMTDateFormat,
                    CultureInfo.InvariantCulture
                    );
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
            DateTime dateTime = DateTime.UtcNow.AddMinutes(minutesFromNow);
            DateTime formatted = new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                dateTime.Hour,
                dateTime.Minute,
                dateTime.Second,
                dateTime.Millisecond,
                DateTimeKind.Local
                );
            return formatted.ToString(
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
            DateTime dateTime = DateTime.UtcNow.AddMinutes(minutesFromNow);
            DateTime formatted = new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                dateTime.Hour,
                dateTime.Minute,
                dateTime.Second,
                dateTime.Millisecond,
                DateTimeKind.Local
                );
            return formatted.ToString(
                AWSSDKUtils.RFC822DateFormat,
                CultureInfo.InvariantCulture
                );
        }

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature
        /// </summary>
        /// <param name="data">The data to be signed</param>
        /// <param name="key">The secret signing key</param>
        /// <param name="algorithm">The algorithm to sign the data with</param>
        /// <exception cref="T:System.ArgumentNullException"/>
        /// <returns>A string representing the HMAC signature</returns>
        public static string HMACSign(string data, System.Security.SecureString key, KeyedHashAlgorithm algorithm)
        {
            if (null == key)
            {
                throw new ArgumentNullException("key", "The AWS Secret Access Key specified is NULL!");
            }

            if (String.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("data", "Please specify data to sign.");
            }

            if (null == algorithm)
            {
                throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
            }

            // pointer to hold unmanaged reference to SecureString instance
            IntPtr bstr = IntPtr.Zero;
            char[] charArray = new char[key.Length];
            try
            {
                // Marshal SecureString into byte array
                bstr = Marshal.SecureStringToBSTR(key);
                Marshal.Copy(bstr, charArray, 0, charArray.Length);
                algorithm.Key = Encoding.UTF8.GetBytes(charArray);
                return Convert.ToBase64String(algorithm.ComputeHash(
                    Encoding.UTF8.GetBytes(data.ToCharArray()))
                    );
            }
            finally
            {
                // Make sure that the clear text data is zeroed out
                Marshal.ZeroFreeBSTR(bstr);
                algorithm.Clear();
                Array.Clear(charArray, 0, charArray.Length);
            }
        }

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature
        /// </summary>
        /// <param name="data">The data to be signed</param>
        /// <param name="key">The secret signing key</param>
        /// <param name="algorithm">The algorithm to sign the data with</param>
        /// <exception cref="T:System.ArgumentNullException"/>
        /// <returns>A string representing the HMAC signature</returns>
        public static string HMACSign(byte[] data, System.Security.SecureString key, KeyedHashAlgorithm algorithm)
        {
            if (null == key)
            {
                throw new ArgumentNullException("key", "The AWS Secret Access Key specified is NULL!");
            }

            if (data == null || data.Length == 0)
            {
                throw new ArgumentNullException("data", "Please specify data to sign.");
            }

            if (null == algorithm)
            {
                throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
            }

            // pointer to hold unmanaged reference to SecureString instance
            IntPtr bstr = IntPtr.Zero;
            char[] charArray = new char[key.Length];
            try
            {
                // Marshal SecureString into byte array
                bstr = Marshal.SecureStringToBSTR(key);
                Marshal.Copy(bstr, charArray, 0, charArray.Length);
                algorithm.Key = Encoding.UTF8.GetBytes(charArray);
                return Convert.ToBase64String(algorithm.ComputeHash(data));
            }
            finally
            {
                // Make sure that the clear text data is zeroed out
                Marshal.ZeroFreeBSTR(bstr);
                algorithm.Clear();
                Array.Clear(charArray, 0, charArray.Length);
            }
        }

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature
        /// </summary>
        /// <param name="data">The data to be signed</param>
        /// <param name="key">The secret signing key</param>
        /// <param name="algorithm">The algorithm to sign the data with</param>
        /// <exception cref="T:System.ArgumentNullException"/>
        /// <returns>A string representing the HMAC signature</returns>
        public static string HMACSign(string data, string key, KeyedHashAlgorithm algorithm)
        {
            if (String.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");
            }

            if (String.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException("data", "Please specify data to sign.");
            }

            if (null == algorithm)
            {
                throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
            }

            try
            {
                algorithm.Key = Encoding.UTF8.GetBytes(key);
                return Convert.ToBase64String(algorithm.ComputeHash(
                    Encoding.UTF8.GetBytes(data))
                    );
            }
            finally
            {
                algorithm.Clear();
            }
        }

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature
        /// </summary>
        /// <param name="data">The data to be signed</param>
        /// <param name="key">The secret signing key</param>
        /// <param name="algorithm">The algorithm to sign the data with</param>
        /// <exception cref="T:System.ArgumentNullException"/>
        /// <returns>A string representing the HMAC signature</returns>
        public static string HMACSign(byte[] data, string key, KeyedHashAlgorithm algorithm)
        {
            if (String.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key", "Please specify a Secret Signing Key.");
            }

            if (data == null || data.Length == 0)
            {
                throw new ArgumentNullException("data", "Please specify data to sign.");
            }

            if (null == algorithm)
            {
                throw new ArgumentNullException("algorithm", "Please specify a KeyedHashAlgorithm to use.");
            }

            try
            {
                algorithm.Key = Encoding.UTF8.GetBytes(key);
                byte[] bytes = algorithm.ComputeHash(data);
                return Convert.ToBase64String(bytes);
            }
            finally
            {
                algorithm.Clear();
            }
        }

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
        /// <param name="rfcNumber">RFC number determing safe characters</param>
        /// <param name="data">The string to encode</param>
        /// <param name="path">Whether the string is a URL path or not</param>
        /// <returns>The encoded string</returns>
        /// <remarks>
        /// Currently recognised RFC versions are 1738 (Dec '94) and 3986 (Jan '05). 
        /// If the specified RFC is not recognised, 3986 is used by default.
        /// </remarks>
        internal static string UrlEncode(int rfcNumber, string data, bool path)
        {
            StringBuilder encoded = new StringBuilder(data.Length * 2);
            string validUrlCharacters;
            if (!RFCEncodingSchemes.TryGetValue(rfcNumber, out validUrlCharacters))
                validUrlCharacters = ValidUrlCharacters;

            string unreservedChars = String.Concat(validUrlCharacters, (path ? "/:'()" : ""));

            foreach (char symbol in System.Text.Encoding.UTF8.GetBytes(data))
            {
                if (unreservedChars.IndexOf(symbol) != -1)
                {
                    encoded.Append(symbol);
                }
                else
                {
                    encoded.Append("%").Append(String.Format("{0:X2}", (int)symbol));
                }
            }

            return encoded.ToString();
        }
        #endregion
    }
}