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
 *  API Version: 2006-03-01
 *
 */

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Provides utilities used by the Amazon S3 client implementation.
    /// These utilities might be useful to consumers of the Amazon S3
    /// library.
    /// </summary>
    public static partial class AmazonS3Util
    {
        private static Dictionary<string, string> extensionToMime = new Dictionary<string, string>(200, StringComparer.OrdinalIgnoreCase)
        {
            { ".ai", "application/postscript" },
            { ".aif", "audio/x-aiff" },
            { ".aifc", "audio/x-aiff" },
            { ".aiff", "audio/x-aiff" },
            { ".asc", "text/plain" },
            { ".au", "audio/basic" },
            { ".avi", "video/x-msvideo" },
            { ".bcpio", "application/x-bcpio" },
            { ".bin", "application/octet-stream" },
            { ".c", "text/plain" },
            { ".cc", "text/plain" },
            { ".ccad", "application/clariscad" },
            { ".cdf", "application/x-netcdf" },
            { ".class", "application/octet-stream" },
            { ".cpio", "application/x-cpio" },
            { ".cpp", "text/plain" },
            { ".cpt", "application/mac-compactpro" },
            { ".cs", "text/plain" },
            { ".csh", "application/x-csh" },
            { ".css", "text/css" },
            { ".dcr", "application/x-director" },
            { ".dir", "application/x-director" },
            { ".dms", "application/octet-stream" },
            { ".doc", "application/msword" },
            { ".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
            { ".dot", "application/msword" },
            { ".drw", "application/drafting" },
            { ".dvi", "application/x-dvi" },
            { ".dwg", "application/acad" },
            { ".dxf", "application/dxf" },
            { ".dxr", "application/x-director" },
            { ".eps", "application/postscript" },
            { ".etx", "text/x-setext" },
            { ".exe", "application/octet-stream" },
            { ".ez", "application/andrew-inset" },
            { ".f", "text/plain" },
            { ".f90", "text/plain" },
            { ".fli", "video/x-fli" },
            { ".gif", "image/gif" },
            { ".gtar", "application/x-gtar" },
            { ".gz", "application/x-gzip" },
            { ".h", "text/plain" },
            { ".hdf", "application/x-hdf" },
            { ".hh", "text/plain" },
            { ".hqx", "application/mac-binhex40" },
            { ".htm", "text/html" },
            { ".html", "text/html" },
            { ".ice", "x-conference/x-cooltalk" },
            { ".ief", "image/ief" },
            { ".iges", "model/iges" },
            { ".igs", "model/iges" },
            { ".ips", "application/x-ipscript" },
            { ".ipx", "application/x-ipix" },
            { ".jpe", "image/jpeg" },
            { ".jpeg", "image/jpeg" },
            { ".jpg", "image/jpeg" },
            { ".js", "application/x-javascript" },
            { ".kar", "audio/midi" },
            { ".latex", "application/x-latex" },
            { ".lha", "application/octet-stream" },
            { ".lsp", "application/x-lisp" },
            { ".lzh", "application/octet-stream" },
            { ".m", "text/plain" },
            { ".m3u8", "application/x-mpegURL" },
            { ".man", "application/x-troff-man" },
            { ".me", "application/x-troff-me" },
            { ".mesh", "model/mesh" },
            { ".mid", "audio/midi" },
            { ".midi", "audio/midi" },
            { ".mime", "www/mime" },
            { ".mov", "video/quicktime" },
            { ".movie", "video/x-sgi-movie" },
            { ".mp2", "audio/mpeg" },
            { ".mp3", "audio/mpeg" },
            { ".mpe", "video/mpeg" },
            { ".mpeg", "video/mpeg" },
            { ".mpg", "video/mpeg" },
            { ".mpga", "audio/mpeg" },
            { ".ms", "application/x-troff-ms" },
            { ".msi", "application/x-ole-storage" },
            { ".msh", "model/mesh" },
            { ".nc", "application/x-netcdf" },
            { ".oda", "application/oda" },
            { ".pbm", "image/x-portable-bitmap" },
            { ".pdb", "chemical/x-pdb" },
            { ".pdf", "application/pdf" },
            { ".pgm", "image/x-portable-graymap" },
            { ".pgn", "application/x-chess-pgn" },
            { ".png", "image/png" },
            { ".pnm", "image/x-portable-anymap" },
            { ".pot", "application/mspowerpoint" },
            { ".ppm", "image/x-portable-pixmap" },
            { ".pps", "application/mspowerpoint" },
            { ".ppt", "application/mspowerpoint" },
            { ".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation" },
            { ".ppz", "application/mspowerpoint" },
            { ".pre", "application/x-freelance" },
            { ".prt", "application/pro_eng" },
            { ".ps", "application/postscript" },
            { ".qt", "video/quicktime" },
            { ".ra", "audio/x-realaudio" },
            { ".ram", "audio/x-pn-realaudio" },
            { ".ras", "image/cmu-raster" },
            { ".rgb", "image/x-rgb" },
            { ".rm", "audio/x-pn-realaudio" },
            { ".roff", "application/x-troff" },
            { ".rpm", "audio/x-pn-realaudio-plugin" },
            { ".rtf", "text/rtf" },
            { ".rtx", "text/richtext" },
            { ".scm", "application/x-lotusscreencam" },
            { ".set", "application/set" },
            { ".sgm", "text/sgml" },
            { ".sgml", "text/sgml" },
            { ".sh", "application/x-sh" },
            { ".shar", "application/x-shar" },
            { ".silo", "model/mesh" },
            { ".sit", "application/x-stuffit" },
            { ".skd", "application/x-koan" },
            { ".skm", "application/x-koan" },
            { ".skp", "application/x-koan" },
            { ".skt", "application/x-koan" },
            { ".smi", "application/smil" },
            { ".smil", "application/smil" },
            { ".snd", "audio/basic" },
            { ".sol", "application/solids" },
            { ".spl", "application/x-futuresplash" },
            { ".src", "application/x-wais-source" },
            { ".step", "application/STEP" },
            { ".stl", "application/SLA" },
            { ".stp", "application/STEP" },
            { ".sv4cpio", "application/x-sv4cpio" },
            { ".sv4crc", "application/x-sv4crc" },
            { ".svg", "image/svg+xml" },
            { ".swf", "application/x-shockwave-flash" },
            { ".t", "application/x-troff" },
            { ".tar", "application/x-tar" },
            { ".tcl", "application/x-tcl" },
            { ".tex", "application/x-tex" },
            { ".tif", "image/tiff" },
            { ".tiff", "image/tiff" },
            { ".tr", "application/x-troff" },
            { ".ts", "video/MP2T" },
            { ".tsi", "audio/TSP-audio" },
            { ".tsp", "application/dsptype" },
            { ".tsv", "text/tab-separated-values" },
            { ".txt", "text/plain" },
            { ".unv", "application/i-deas" },
            { ".ustar", "application/x-ustar" },
            { ".vcd", "application/x-cdlink" },
            { ".vda", "application/vda" },
            { ".vrml", "model/vrml" },
            { ".wav", "audio/x-wav" },
            { ".wrl", "model/vrml" },
            { ".xbm", "image/x-xbitmap" },
            { ".xlc", "application/vnd.ms-excel" },
            { ".xll", "application/vnd.ms-excel" },
            { ".xlm", "application/vnd.ms-excel" },
            { ".xls", "application/vnd.ms-excel" },
            { ".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" },
            { ".xlw", "application/vnd.ms-excel" },
            { ".xml", "text/xml" },
            { ".xpm", "image/x-xpixmap" },
            { ".xwd", "image/x-xwindowdump" },
            { ".xyz", "chemical/x-pdb" },
            { ".zip", "application/zip" },
            { ".m4v", "video/x-m4v" },
            { ".webm", "video/webm" },
            { ".ogv", "video/ogv" },
            { ".xap", "application/x-silverlight-app" },
            { ".mp4", "video/mp4" },
            { ".wmv", "video/x-ms-wmv" }
        };

        /// <summary>
        /// Determines MIME type from a file extension
        /// </summary>
        /// <param name="ext">The extension of the file</param>
        /// <returns>The MIME type for the extension, or text/plain</returns>
        public static string MimeTypeFromExtension(string ext)
        {
            if (extensionToMime.ContainsKey(ext))
            {
                return extensionToMime[ext];
            }
            else
            {
                return "application/octet-stream";
            }
        }

        /// <summary>
        /// URL encodes a string. If the path property is specified,
        /// the accepted path characters {/+:} are not encoded.
        /// </summary>
        /// <param name="data">The string to encode</param>
        /// <param name="path">Whether the string is a URL path or not</param>
        /// <returns></returns>
        public static string UrlEncode(string data, bool path)
        {
            return AWSSDKUtils.UrlEncode(data, path);
        }

        /// <summary>
        /// Converts a non-seekable stream into a System.IO.MemoryStream.
        /// A MemoryStream's position can be moved arbitrarily
        /// </summary>
        /// <param name="input">The stream to be converted</param>
        /// <returns>A seekable MemoryStream</returns>
        /// <remarks>MemoryStreams use byte arrays as their backing store.
        /// Please use this judicially as it is likely that a very large
        /// stream will cause system resources to be used up.
        /// </remarks>
        public static System.IO.Stream MakeStreamSeekable(System.IO.Stream input)
        {
            System.IO.MemoryStream output = new System.IO.MemoryStream();
            const int readSize = 32 * 1024;
            byte[] buffer = new byte[readSize];

            int count = 0;
            using (input)
            {
                while ((count = input.Read(buffer, 0, readSize)) > 0)
                {
                    output.Write(buffer, 0, count);
                }
            }

            output.Position = 0;
            return output;
        }

        /// <summary>
        /// Formats the current date as a GMT timestamp
        /// </summary>
        /// <returns>A GMT formatted string representation
        /// of the current date and time
        /// </returns>
        public static string FormattedCurrentTimestamp
        {
            get
            {
                return AWSSDKUtils.FormattedCurrentTimestampGMT;
            }
        }

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
            byte[] hashed = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(Encoding.UTF8.GetBytes(content));

            if (fBase64Encode)
            {
                // Convert the hash to a Base64 Encoded string and return it
                return Convert.ToBase64String(hashed);
            }
            else
            {
                return BitConverter.ToString(hashed).Replace("-", String.Empty);
            }
        }

        internal static string ComputeEncodedMD5FromEncodedString(string base64EncodedString)
        {
            var unencodedValue = Convert.FromBase64String(base64EncodedString);
            var valueMD5 = CryptoUtilFactory.CryptoInstance.ComputeMD5Hash(unencodedValue);
            var encodedMD5 = Convert.ToBase64String(valueMD5);
            return encodedMD5;
        }

        internal static void SetMetadataHeaders(IRequest request, MetadataCollection metadata)
        {
            foreach (var name in metadata.Keys)
                request.Headers[name] = metadata[name];
        }

        internal static DateTime? ParseExpiresHeader(string rawValue, string requestId)
        {
            if (!string.IsNullOrEmpty(rawValue))
            {
                try
                {
                    return S3Transforms.ToDateTime(rawValue);
                }
                catch (FormatException e)
                {
                    throw new AmazonDateTimeUnmarshallingException(
                        requestId,
                        string.Empty,
                        string.Empty,
                        rawValue,
                        message: string.Format(
                            CultureInfo.InvariantCulture,
                            "The value {0} cannot be converted to a DateTime instance.",
                            rawValue),
                        innerException: e);
                }
            }
            else
            {
                return default(DateTime);
            }
        }

        /// <summary>
        /// Version2 S3 buckets adhere to RFC 1035:
        /// <list type="number">
        /// <item>Less than 255 characters, with each label less than 63 characters.</item>
        /// <item>Label must start with a letter</item>
        /// <item>Label must end with a letter or digit</item>
        /// <item>Label can have a string of letter, digits and hyphens in the middle.</item>
        /// <item>Although names can be case-sensitive, no significance is attached to the case.</item>
        /// <item>RFC 1123: Allow label to start with letter or digit (e.g. 3ware.com works)</item>
        /// <item>RFC 2181: No restrictions apart from the length restrictions.</item>
        /// </list>
        /// S3 V2 will start with RFCs 1035 and 1123 and impose the following additional restrictions:
        /// <list type="number">
        /// <item>Length between 3 and 63 characters (to allow headroom for upper-level domains,
        ///     as well as to avoid separate length restrictions for bucket-name and its labels</item>
        /// <item>Only lower-case to avoid user confusion.</item>
        /// <item>No dotted-decimal IPv4-like strings</item>
        /// </list>
        /// </summary>
        /// <param name="bucketName">The BucketName to validate if V2 addressing should be used</param>
        /// <returns>True if the BucketName should use V2 bucket addressing, false otherwise</returns>
        /// <seealso href="http://docs.amazonwebservices.com/AmazonS3/2006-03-01/dev/index.html?BucketRestrictions.html">
        /// S3 v2 Bucket restrictions</seealso>
        public static bool ValidateV2Bucket(string bucketName)
        {
            if (String.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "Please specify a bucket name");
            }

            if (bucketName.StartsWith("s3.amazonaws.com", StringComparison.Ordinal))
            {
                return false;
            }

            // If the entire S3 URL is passed instead of just the bucketName, 
            // strip out the Amazon S3 part of the URL
            int idx = bucketName.IndexOf(".s3.amazonaws.com", StringComparison.Ordinal);
            if (idx > 0)
            {
                bucketName = bucketName.Substring(0, idx);
            }

            if (bucketName.Length < S3Constants.MinBucketLength ||
                 bucketName.Length > S3Constants.MaxBucketLength ||
                 bucketName.StartsWith(".", StringComparison.Ordinal) ||
                 bucketName.EndsWith(".", StringComparison.Ordinal))
            {
                return false;
            }

            // Check not IPv4-like
            Regex ipv4 = new Regex("^[0-9]+\\.[0-9]+\\.[0-9]+\\.[0-9]+$");
            if (ipv4.IsMatch(bucketName))
            {
                return false;
            }

            // Check each label
            Regex v2Regex = new Regex("^[a-z0-9]([a-z0-9\\-]*[a-z0-9])?$");
            string[] labels = bucketName.Split("\\.".ToCharArray());
            foreach (string label in labels)
            {
                if (!v2Regex.IsMatch(label))
                {
                    return false;
                }
            }
            return true;
        }

        internal static void AddQueryStringParameter(StringBuilder queryString, string parameterName, string parameterValue)
        {
            AddQueryStringParameter(queryString, parameterName, parameterValue, null);
        }

        internal static void AddQueryStringParameter(StringBuilder queryString, string parameterName, string parameterValue, IDictionary<string, string> parameterMap)
        {
            if (queryString.Length > 0)
                queryString.Append("&");
            queryString.AppendFormat("{0}={1}", AWSSDKUtils.UrlEncode(parameterName, false), AWSSDKUtils.UrlEncode(parameterValue, false));
            if (parameterMap != null)
                parameterMap.Add(parameterName, parameterValue);
        }

        internal static string TagSetToQueryString(List<Tag> tags)
        {
            StringBuilder builder = new StringBuilder();
            foreach(var tag in tags)
            {
                AddQueryStringParameter(builder, tag.Key, tag.Value);
            }
            return builder.ToString();
        }

        internal static void SerializeTagToXml(XmlWriter xmlWriter, Tag tag)
        {
            xmlWriter.WriteStartElement("Tag", "");

            if (tag.IsSetKey())
            {
                xmlWriter.WriteElementString("Key", "", S3Transforms.ToXmlStringValue(tag.Key));
            }
            if (tag.IsSetValue())
            {
                xmlWriter.WriteElementString("Value", "", S3Transforms.ToXmlStringValue(tag.Value));
            }

            xmlWriter.WriteEndElement();
        }

        internal static void SerializeTagSetToXml(XmlWriter xmlWriter, List<Tag> tagset)
        {
            xmlWriter.WriteStartElement("TagSet", "");

            if (tagset != null && tagset.Count > 0)
            {
                foreach (var tag in tagset)
                {
                    SerializeTagToXml(xmlWriter, tag);
                }
            }
            xmlWriter.WriteEndElement();
        }

        internal static string SerializeTaggingToXml(Tagging tagging)
        {
            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = Encoding.UTF8, OmitXmlDeclaration = true }))
            {
                xmlWriter.WriteStartElement("Tagging", "");

                SerializeTagSetToXml(xmlWriter, tagging.TagSet);

                xmlWriter.WriteEndElement();
            }

            return stringWriter.ToString();
        }

        internal static void ParseAmzRestoreHeader(string header, out bool restoreInProgress, out DateTime? restoreExpiration)
        {
            const string ONGOING_REQUEST = "ongoing-request";
            const string EXPIRY_DATE = "expiry-date";

            restoreExpiration = null;
            restoreInProgress = false;

            if (header == null)
                return;

            int pos = header.IndexOf(ONGOING_REQUEST, StringComparison.Ordinal);
            if (pos != -1)
            {
                int startPos = header.IndexOf('"', pos) + 1;
                int endPos = header.IndexOf('"', startPos + 1);

                string value = header.Substring(startPos, endPos - startPos);
                bool parseBool;
                if (Boolean.TryParse(value, out parseBool))
                    restoreInProgress = parseBool;
            }
            pos = header.IndexOf(EXPIRY_DATE, StringComparison.Ordinal);
            if (pos != -1)
            {
                int startPos = header.IndexOf('"', pos) + 1;
                int endPos = header.IndexOf('"', startPos + 1);

                string value = header.Substring(startPos, endPos - startPos);
                DateTime parseDate;
                if (DateTime.TryParseExact(value, Amazon.Util.AWSSDKUtils.RFC822DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out parseDate))
                    restoreExpiration = parseDate;
            }
        }

        internal static bool IsInstructionFile(string key)
        {
            return key.EndsWith(S3Constants.EncryptionInstructionfileSuffix, StringComparison.Ordinal);
        }


#if AWS_ASYNC_API
        /// <summary>
        /// Determines whether an S3 bucket exists or not.
        /// This is done by:
        /// 1. Creating a PreSigned Url for the bucket. To work with Signature V4 only regions, as
        /// well as Signature V4-optional regions, we keep the expiry to within the maximum for V4 
        /// (which is one week).
        /// 2. Making a HEAD request to the Url
        /// </summary>
        /// <param name="bucketName">The name of the bucket to check.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<bool> DoesS3BucketExistAsync(IAmazonS3 s3Client, string bucketName)
        {
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client", "The s3Client cannot be null!");
            }

            if (String.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName cannot be null or the empty string!");
            }

            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Expires = s3Client.Config.CorrectedUtcNow.ToLocalTime().AddDays(1),
                Verb = HttpVerb.HEAD,
                Protocol = Protocol.HTTP
            };

            var url = s3Client.GetPreSignedURL(request);
            var uri = new Uri(url);

            var httpRequest = WebRequest.Create(uri) as HttpWebRequest;
            httpRequest.Method = "HEAD";
            var concreteClient = s3Client as AmazonS3Client;
            if (concreteClient != null)
            {

                concreteClient.ConfigureProxy(httpRequest);
            }

            try
            {
#if PCL
                var result = httpRequest.BeginGetResponse(null, null);
                using (var httpResponse = httpRequest.EndGetResponse(result) as HttpWebResponse)
#else 
                using (var httpResponse = await httpRequest.GetResponseAsync().ConfigureAwait(false) as HttpWebResponse)
#endif          
                {
                    // If all went well, the bucket was found!
                    return true;
                }
            }
            catch (WebException we)
            {
                using (var errorResponse = we.Response as HttpWebResponse)
                {
                    if (errorResponse != null)
                    {
                        var code = errorResponse.StatusCode;
                        return code != HttpStatusCode.NotFound &&
                            code != HttpStatusCode.BadRequest;
                    }

                    // The Error Response is null which is indicative of either
                    // a bad request or some other problem
                    return false;
                }
            }
        }
#endif
    }
}