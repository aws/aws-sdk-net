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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

using Amazon.S3.Model;
using Amazon.Util;
using System.Threading;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Provides utilities used by the Amazon S3 client implementation.
    /// These utilities might be useful to consumers of the Amazon S3
    /// library.
    /// </summary>
    public static class AmazonS3Util
    {
        private static Dictionary<string, string> extensionToMime;

        static AmazonS3Util()
        {
            extensionToMime = new Dictionary<string, string>(150, StringComparer.InvariantCultureIgnoreCase);

            extensionToMime[".ai"] = "application/postscript";
            extensionToMime[".aif"] = "audio/x-aiff";
            extensionToMime[".aifc"] = "audio/x-aiff";
            extensionToMime[".aiff"] = "audio/x-aiff";
            extensionToMime[".asc"] = "text/plain";
            extensionToMime[".au"] = "audio/basic";
            extensionToMime[".avi"] = "video/x-msvideo";
            extensionToMime[".bcpio"] = "application/x-bcpio";
            extensionToMime[".bin"] = "application/octet-stream";
            extensionToMime[".c"] = "text/plain";
            extensionToMime[".cc"] = "text/plain";
            extensionToMime[".ccad"] = "application/clariscad";
            extensionToMime[".cdf"] = "application/x-netcdf";
            extensionToMime[".class"] = "application/octet-stream";
            extensionToMime[".cpio"] = "application/x-cpio";
            extensionToMime[".cpp"] = "text/plain";
            extensionToMime[".cpt"] = "application/mac-compactpro";
            extensionToMime[".cs"] = "text/plain";
            extensionToMime[".csh"] = "application/x-csh";
            extensionToMime[".css"] = "text/css";
            extensionToMime[".dcr"] = "application/x-director";
            extensionToMime[".dir"] = "application/x-director";
            extensionToMime[".dms"] = "application/octet-stream";
            extensionToMime[".doc"] = "application/msword";
            extensionToMime[".docx"] = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            extensionToMime[".dot"] = "application/msword";
            extensionToMime[".drw"] = "application/drafting";
            extensionToMime[".dvi"] = "application/x-dvi";
            extensionToMime[".dwg"] = "application/acad";
            extensionToMime[".dxf"] = "application/dxf";
            extensionToMime[".dxr"] = "application/x-director";
            extensionToMime[".eps"] = "application/postscript";
            extensionToMime[".etx"] = "text/x-setext";
            extensionToMime[".exe"] = "application/octet-stream";
            extensionToMime[".ez"] = "application/andrew-inset";
            extensionToMime[".f"] = "text/plain";
            extensionToMime[".f90"] = "text/plain";
            extensionToMime[".fli"] = "video/x-fli";
            extensionToMime[".gif"] = "image/gif";
            extensionToMime[".gtar"] = "application/x-gtar";
            extensionToMime[".gz"] = "application/x-gzip";
            extensionToMime[".h"] = "text/plain";
            extensionToMime[".hdf"] = "application/x-hdf";
            extensionToMime[".hh"] = "text/plain";
            extensionToMime[".hqx"] = "application/mac-binhex40";
            extensionToMime[".htm"] = "text/html";
            extensionToMime[".html"] = "text/html";
            extensionToMime[".ice"] = "x-conference/x-cooltalk";
            extensionToMime[".ief"] = "image/ief";
            extensionToMime[".iges"] = "model/iges";
            extensionToMime[".igs"] = "model/iges";
            extensionToMime[".ips"] = "application/x-ipscript";
            extensionToMime[".ipx"] = "application/x-ipix";
            extensionToMime[".jpe"] = "image/jpeg";
            extensionToMime[".jpeg"] = "image/jpeg";
            extensionToMime[".jpg"] = "image/jpeg";
            extensionToMime[".js"] = "application/x-javascript";
            extensionToMime[".kar"] = "audio/midi";
            extensionToMime[".latex"] = "application/x-latex";
            extensionToMime[".lha"] = "application/octet-stream";
            extensionToMime[".lsp"] = "application/x-lisp";
            extensionToMime[".lzh"] = "application/octet-stream";
            extensionToMime[".m"] = "text/plain";
            extensionToMime[".m3u8"] = "application/x-mpegURL";
            extensionToMime[".man"] = "application/x-troff-man";
            extensionToMime[".me"] = "application/x-troff-me";
            extensionToMime[".mesh"] = "model/mesh";
            extensionToMime[".mid"] = "audio/midi";
            extensionToMime[".midi"] = "audio/midi";
            extensionToMime[".mime"] = "www/mime";
            extensionToMime[".mov"] = "video/quicktime";
            extensionToMime[".movie"] = "video/x-sgi-movie";
            extensionToMime[".mp2"] = "audio/mpeg";
            extensionToMime[".mp3"] = "audio/mpeg";
            extensionToMime[".mpe"] = "video/mpeg";
            extensionToMime[".mpeg"] = "video/mpeg";
            extensionToMime[".mpg"] = "video/mpeg";
            extensionToMime[".mpga"] = "audio/mpeg";
            extensionToMime[".ms"] = "application/x-troff-ms";
            extensionToMime[".msi"] = "application/x-ole-storage";
            extensionToMime[".msh"] = "model/mesh";
            extensionToMime[".nc"] = "application/x-netcdf";
            extensionToMime[".oda"] = "application/oda";
            extensionToMime[".pbm"] = "image/x-portable-bitmap";
            extensionToMime[".pdb"] = "chemical/x-pdb";
            extensionToMime[".pdf"] = "application/pdf";
            extensionToMime[".pgm"] = "image/x-portable-graymap";
            extensionToMime[".pgn"] = "application/x-chess-pgn";
            extensionToMime[".png"] = "image/png";
            extensionToMime[".pnm"] = "image/x-portable-anymap";
            extensionToMime[".pot"] = "application/mspowerpoint";
            extensionToMime[".ppm"] = "image/x-portable-pixmap";
            extensionToMime[".pps"] = "application/mspowerpoint";
            extensionToMime[".ppt"] = "application/mspowerpoint";
            extensionToMime[".pptx"] = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
            extensionToMime[".ppz"] = "application/mspowerpoint";
            extensionToMime[".pre"] = "application/x-freelance";
            extensionToMime[".prt"] = "application/pro_eng";
            extensionToMime[".ps"] = "application/postscript";
            extensionToMime[".qt"] = "video/quicktime";
            extensionToMime[".ra"] = "audio/x-realaudio";
            extensionToMime[".ram"] = "audio/x-pn-realaudio";
            extensionToMime[".ras"] = "image/cmu-raster";
            extensionToMime[".rgb"] = "image/x-rgb";
            extensionToMime[".rm"] = "audio/x-pn-realaudio";
            extensionToMime[".roff"] = "application/x-troff";
            extensionToMime[".rpm"] = "audio/x-pn-realaudio-plugin";
            extensionToMime[".rtf"] = "text/rtf";
            extensionToMime[".rtx"] = "text/richtext";
            extensionToMime[".scm"] = "application/x-lotusscreencam";
            extensionToMime[".set"] = "application/set";
            extensionToMime[".sgm"] = "text/sgml";
            extensionToMime[".sgml"] = "text/sgml";
            extensionToMime[".sh"] = "application/x-sh";
            extensionToMime[".shar"] = "application/x-shar";
            extensionToMime[".silo"] = "model/mesh";
            extensionToMime[".sit"] = "application/x-stuffit";
            extensionToMime[".skd"] = "application/x-koan";
            extensionToMime[".skm"] = "application/x-koan";
            extensionToMime[".skp"] = "application/x-koan";
            extensionToMime[".skt"] = "application/x-koan";
            extensionToMime[".smi"] = "application/smil";
            extensionToMime[".smil"] = "application/smil";
            extensionToMime[".snd"] = "audio/basic";
            extensionToMime[".sol"] = "application/solids";
            extensionToMime[".spl"] = "application/x-futuresplash";
            extensionToMime[".src"] = "application/x-wais-source";
            extensionToMime[".step"] = "application/STEP";
            extensionToMime[".stl"] = "application/SLA";
            extensionToMime[".stp"] = "application/STEP";
            extensionToMime[".sv4cpio"] = "application/x-sv4cpio";
            extensionToMime[".sv4crc"] = "application/x-sv4crc";
            extensionToMime[".swf"] = "application/x-shockwave-flash";
            extensionToMime[".t"] = "application/x-troff";
            extensionToMime[".tar"] = "application/x-tar";
            extensionToMime[".tcl"] = "application/x-tcl";
            extensionToMime[".tex"] = "application/x-tex";
            extensionToMime[".tif"] = "image/tiff";
            extensionToMime[".tiff"] = "image/tiff";
            extensionToMime[".tr"] = "application/x-troff";
            extensionToMime[".ts"] = "video/MP2T";
            extensionToMime[".tsi"] = "audio/TSP-audio";
            extensionToMime[".tsp"] = "application/dsptype";
            extensionToMime[".tsv"] = "text/tab-separated-values";
            extensionToMime[".txt"] = "text/plain";
            extensionToMime[".unv"] = "application/i-deas";
            extensionToMime[".ustar"] = "application/x-ustar";
            extensionToMime[".vcd"] = "application/x-cdlink";
            extensionToMime[".vda"] = "application/vda";
            extensionToMime[".vrml"] = "model/vrml";
            extensionToMime[".wav"] = "audio/x-wav";
            extensionToMime[".wrl"] = "model/vrml";
            extensionToMime[".xbm"] = "image/x-xbitmap";
            extensionToMime[".xlc"] = "application/vnd.ms-excel";
            extensionToMime[".xll"] = "application/vnd.ms-excel";
            extensionToMime[".xlm"] = "application/vnd.ms-excel";
            extensionToMime[".xls"] = "application/vnd.ms-excel";
            extensionToMime[".xlsx"] = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            extensionToMime[".xlw"] = "application/vnd.ms-excel";
            extensionToMime[".xml"] = "text/xml";
            extensionToMime[".xpm"] = "image/x-xpixmap";
            extensionToMime[".xwd"] = "image/x-xwindowdump";
            extensionToMime[".xyz"] = "chemical/x-pdb";
            extensionToMime[".zip"] = "application/zip";
            extensionToMime[".m4v"] = "video/x-m4v";
            extensionToMime[".webm"] = "video/webm";
            extensionToMime[".ogv"] = "video/ogv";
            extensionToMime[".xap"] = "application/x-silverlight-app";
            extensionToMime[".mp4"] = "video/mp4";
            extensionToMime[".wmv"] = "video/x-ms-wmv";

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
        /// Computes RFC 2104-compliant HMAC signature
        /// </summary>
        /// <param name="data">The data to be signed</param>
        /// <param name="key">The secret signing key</param>
        /// <param name="algorithm">The algorithm to sign the data with</param>
        /// <returns>A string representing the HMAC signature</returns>
        public static string Sign(string data, System.Security.SecureString key, KeyedHashAlgorithm algorithm)
        {
            if (key == null)
            {
                throw new AmazonS3Exception("The AWS Secret Access Key specified is NULL!");
            }

            return AWSSDKUtils.HMACSign(data, key, algorithm);
        }

        /// <summary>
        /// Generates an md5Digest for the file-stream specified
        /// </summary>
        /// <param name="input">The Stream for which the MD5 Digest needs
        /// to be computed.</param>
        /// <param name="fbase64Encode">Whether the hash should be base64 encoded
        /// </param>
        /// <returns>A string representation of the hash with or w/o base64 encoding
        /// </returns>
        public static string GenerateChecksumForStream(Stream input, bool fbase64Encode)
        {
            string hash = null;
            // Create a new instance of the MD5CryptoServiceProvider object.
            BufferedStream bstream = new BufferedStream(input, 1024 * 1024);

            // Use an MD5 instance to compute the has for the stream
            byte[] hashed = MD5.Create().ComputeHash(bstream);

            if (fbase64Encode)
            {
                hash = Convert.ToBase64String(hashed);
            }
            else
            {
                hash = BitConverter.ToString(hashed).Replace("-", String.Empty);
            }

            // Now that the hash has been generated, reset the stream to its
            // origin so that the stream's data can be processed
            bstream.Position = 0;

            return hash;
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
            byte[] hashed = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(content));

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

        /// <summary>
        /// Builds and returns the name value collection
        /// that can be added to the HTTP headers for the request
        /// </summary>
        /// <param name="key">The key to be added to the headers (eg. Content-Body)</param>
        /// <param name="value">The value of the key being added</param>
        /// <returns>A NameValueCollection with just one key-value pair</returns>
        public static NameValueCollection CreateHeaderEntry(string key, string value)
        {
            NameValueCollection collection = new NameValueCollection();
            collection.Add(key, value);
            return collection;
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

            if (bucketName.StartsWith("s3.amazonaws.com"))
            {
                return false;
            }

            // If the entire S3 URL is passed instead of just the bucketName, 
            // strip out the Amazon S3 part of the URL
            int idx = bucketName.IndexOf(".s3.amazonaws.com");
            if (idx > 0)
            {
                bucketName = bucketName.Substring(0, idx);
            }

            if (bucketName.Length < S3Constants.MinBucketLength ||
                 bucketName.Length > S3Constants.MaxBucketLength ||
                 bucketName.StartsWith(".") ||
                 bucketName.EndsWith("."))
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

        /// <summary>
        /// Determines whether an S3 bucket exists or not.
        /// This is done by:
        /// 1. Creating a PreSigned Url for the bucket (with an expiry date at the end of this decade)
        /// 2. Making a HEAD request to the Url
        /// </summary>
        /// <param name="bucketName">The name of the bucket to check.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <returns></returns>
        public static bool DoesS3BucketExist(string bucketName, AmazonS3 s3Client)
        {
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client", "The s3Client cannot be null!");
            }

            if (String.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName cannot be null or the empty string!");
            }

            GetPreSignedUrlRequest request = new GetPreSignedUrlRequest();
            request.BucketName = bucketName;
            request.Expires = new DateTime(2019, 12, 31);
            request.Verb = HttpVerb.HEAD;
            request.Protocol = Protocol.HTTP;
            string url = s3Client.GetPreSignedURL(request);

            HttpWebRequest httpRequest = WebRequest.Create(url) as HttpWebRequest;
            httpRequest.Method = "HEAD";
            AmazonS3Client concreteClient = s3Client as AmazonS3Client;
            if (concreteClient != null)
            {
                concreteClient.ConfigureProxy(httpRequest);
            }

            try
            {
                HttpWebResponse httpResponse = httpRequest.GetResponse() as HttpWebResponse;
                // If all went well, the bucket was found!
                return true;
            }
            catch (WebException we)
            {
                using (HttpWebResponse errorResponse = we.Response as HttpWebResponse)
                {
                    if (errorResponse != null)
                    {
                        HttpStatusCode code = errorResponse.StatusCode;
                        return code != HttpStatusCode.NotFound &&
                            code != HttpStatusCode.BadRequest;
                    }

                    // The Error Response is null which is indicative of either
                    // a bad request or some other problem
                    return false;
                }
            }
        }

         /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void DeleteS3BucketWithObjects(string bucketName, AmazonS3 s3Client)
        {
            var result=BeginDeleteS3BucketWithObjects(bucketName, s3Client, null, null);
            EndDeleteS3BucketWithObjects(result);
        }

        /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">Options to control the behavior of the delete operation.</param>
        public static void DeleteS3BucketWithObjects(string bucketName, AmazonS3 s3Client, S3DeleteBucketWithObjectsOptions deleteOptions)
        {
            var result = BeginDeleteS3BucketWithObjects(bucketName, s3Client,deleteOptions, null, null);
            EndDeleteS3BucketWithObjects(result);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteS3BucketWithObjects operation. 
        /// DeleteS3BucketWithObjects deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static IAsyncCancelableResult BeginDeleteS3BucketWithObjects(string bucketName, AmazonS3 s3Client,
            AsyncCallback callback, object state)
        {
            return BeginDeleteS3BucketWithObjects(bucketName, s3Client,
                new S3DeleteBucketWithObjectsOptions
                {
                    ContinueOnError = false,
                    QuietMode = true,
                },
                callback,
                state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteS3BucketWithObjects operation. 
        /// DeleteS3BucketWithObjects deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">Options to control the behavior of the delete operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static IAsyncCancelableResult BeginDeleteS3BucketWithObjects(string bucketName, AmazonS3 s3Client,
             S3DeleteBucketWithObjectsOptions deleteOptions, AsyncCallback callback, object state)
        {
            return BeginDeleteS3BucketWithObjects(bucketName, s3Client, deleteOptions, null, callback, state);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteS3BucketWithObjects operation. 
        /// DeleteS3BucketWithObjects deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">>Options to control the behavior of the delete operation.</param>
        /// <param name="updateCallback">An callback that is invoked to send updates while delete operation is in progress.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static IAsyncCancelableResult BeginDeleteS3BucketWithObjects(string bucketName, AmazonS3 s3Client,
             S3DeleteBucketWithObjectsOptions deleteOptions,Action<S3DeleteBucketWithObjectsUpdate> updateCallback, AsyncCallback callback, object state)
        {
            var asyncResult = new AsyncCancelableResult(callback, state);

            var request = new S3DeleteBucketWithObjectsRequest
            {
                AsyncCancelableResult = asyncResult,
                BucketName = bucketName,
                DeleteOptions = deleteOptions,
                UpdateCallback=updateCallback,
                S3Client = s3Client
            };

            ThreadPool.QueueUserWorkItem(InvokeDeleteS3BucketWithObjects, request);
            return asyncResult;
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteS3BucketWithObjects operation.
        /// </summary>
        /// <param name="asyncCancelableResult">The IAsyncCancelableResult returned by the call to BeginDeleteS3BucketWithObjects.</param>
        public static void EndDeleteS3BucketWithObjects(IAsyncCancelableResult asyncCancelableResult)
        {
            var asyncResult = asyncCancelableResult as AsyncCancelableResult;
            
            try
            {
                if (!(asyncResult.IsCompleted || asyncResult.IsCanceled))
                {
                    asyncResult.AsyncWaitHandle.WaitOne();
                }

                if (asyncResult.LastException != null)
                {
                    AWSSDKUtils.PreserveStackTrace(asyncResult.LastException);
                    throw asyncResult.LastException;
                }
            }
            finally
            {
                asyncResult.Dispose();
            }
        }

        /// <summary>
        /// Upload data to Amazon S3 using HTTP POST.
        /// </summary>
        /// <remarks>
        /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
        /// </remarks>
        /// <param name="request">Request object which describes the data to POST</param>
        /// <exception cref="S3PostUploadException">Thrown if the service returns an error</exception>
        public static S3PostUploadResponse PostUpload(S3PostUploadRequest request)
        {
            string url;
            
            if (request.Bucket.IndexOf('.') > -1)
                url = String.Format("https://s3.amazonaws.com/{0}/", request.Bucket);
            else
                url = String.Format("https://{0}.s3.amazonaws.com", request.Bucket);

            HttpWebRequest webRequest = WebRequest.Create(url) as HttpWebRequest;

            var boundary = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace('=','z');

            webRequest.ContentType = String.Format("multipart/form-data; boundary={0}", boundary);
            webRequest.Method = "POST";

            using (var reqStream = webRequest.GetRequestStream())
            {
                request.WriteFormData(boundary, reqStream);

                byte[] boundaryBytes = Encoding.UTF8.GetBytes(String.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"\r\n\r\n", boundary));

                reqStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                using (var inputStream = null == request.Path ? request.InputStream : File.OpenRead(request.Path))
                {
                    byte[] buf = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = inputStream.Read(buf, 0, 1024)) > 0)
                    {
                        reqStream.Write(buf, 0, bytesRead);
                    }
                }

                byte[] endBoundaryBytes = Encoding.UTF8.GetBytes(String.Format("\r\n--{0}--", boundary));

                reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            }

            HttpWebResponse response = null;
            try
            {
                response = webRequest.GetResponse() as HttpWebResponse;
            }
            catch (WebException ex)
            {
                throw S3PostUploadException.FromResponse((HttpWebResponse)ex.Response);
            }

            return S3PostUploadResponse.FromWebResponse(response);
        }
        
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
        /// Sets the storage class for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="s3Object">The S3 Object whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.Model.S3StorageClass"/>
        public static void SetObjectStorageClass(S3Object s3Object, S3StorageClass sClass, AmazonS3 s3Client)
        {
            SetObjectStorageClass(s3Object.BucketName, s3Object.Key, sClass, s3Client);
        }

        /// <summary>
        /// Sets the storage class for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.Model.S3StorageClass"/>
        public static void SetObjectStorageClass(string bucketName, string key, S3StorageClass sClass, AmazonS3 s3Client)
        {
            SetObjectStorageClass(bucketName, key, null, sClass, s3Client);
        }

        /// <summary>
        /// Sets the storage class for the S3 Object Version to the value
        /// specified.
        /// </summary>
        /// <param name="s3ObjectVer">The S3 Object Version whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.Model.S3StorageClass"/>
        public static void SetObjectStorageClass(S3ObjectVersion s3ObjectVer, S3StorageClass sClass, AmazonS3 s3Client)
        {
            SetObjectStorageClass(s3ObjectVer.BucketName, s3ObjectVer.Key, s3ObjectVer.VersionId, sClass, s3Client);
        }

        /// <summary>
        /// Sets the storage class for the S3 Object's Version to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object whose storage class needs changing</param>
        /// <param name="version">The version of the S3 Object whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.Model.S3StorageClass"/>
        public static void SetObjectStorageClass(string bucketName, string key, string version, S3StorageClass sClass, AmazonS3 s3Client)
        {
            CopyObjectRequest copyRequest;
            SetACLRequest setACLRequest;

            SetupForObjectModification(bucketName, key, version, s3Client, out copyRequest, out setACLRequest);

            copyRequest.StorageClass = sClass;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.VersionId))
                setACLRequest.VersionId = copyResponse.VersionId;

            s3Client.SetACL(setACLRequest);
        }

        /// <summary>
        /// Sets the server side encryption method for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="s3Object">The S3 Object</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(S3Object s3Object, ServerSideEncryptionMethod method, AmazonS3 s3Client)
        {
            SetServerSideEncryption(s3Object.BucketName, s3Object.Key, method, s3Client);
        }

        /// <summary>
        /// Sets the server side encryption method for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(string bucketName, string key, ServerSideEncryptionMethod method, AmazonS3 s3Client)
        {
            SetServerSideEncryption(bucketName, key, null, method, s3Client);
        }

        /// <summary>
        /// Sets the server side encryption method for the S3 Object Version to the value
        /// specified.
        /// </summary>
        /// <param name="s3ObjectVer">The S3 Object Version</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(S3ObjectVersion s3ObjectVer, ServerSideEncryptionMethod method, AmazonS3 s3Client)
        {
            SetServerSideEncryption(s3ObjectVer.BucketName, s3ObjectVer.Key, s3ObjectVer.VersionId, method, s3Client);
        }

        /// <summary>
        /// Sets the server side encryption method for the S3 Object's Version to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="version">The version of the S3 Object</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(string bucketName, string key, string version, ServerSideEncryptionMethod method, AmazonS3 s3Client)
        {
            CopyObjectRequest copyRequest;
            SetACLRequest setACLRequest;

            SetupForObjectModification(bucketName, key, version, s3Client, out copyRequest, out setACLRequest);

            copyRequest.ServerSideEncryptionMethod = method;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.VersionId))
                setACLRequest.VersionId = copyResponse.VersionId;

            s3Client.SetACL(setACLRequest);
        }

        /// <summary>
        /// Sets the redirect location for the S3 Object's when being accessed through the S3 website endpoint.
        /// </summary>
        /// <param name="s3Object">The S3 Object</param>
        /// <param name="websiteRedirectLocation">The redirect location</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetWebsiteRedirectLocation(S3Object s3Object, string websiteRedirectLocation, AmazonS3 s3Client)
        {
            SetWebsiteRedirectLocation(s3Object.BucketName, s3Object.Key, websiteRedirectLocation, s3Client);
        }

        /// <summary>
        /// Sets the redirect location for the S3 Object's when being accessed through the S3 website endpoint.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="websiteRedirectLocation">The redirect location</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetWebsiteRedirectLocation(string bucketName, string key, string websiteRedirectLocation, AmazonS3 s3Client)
        {
            CopyObjectRequest copyRequest;
            SetACLRequest setACLRequest;

            SetupForObjectModification(bucketName, key, null, s3Client, out copyRequest, out setACLRequest);

            copyRequest.WebsiteRedirectLocation = websiteRedirectLocation;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.VersionId))
                setACLRequest.VersionId = copyResponse.VersionId;

            s3Client.SetACL(setACLRequest);
        }

        /// <summary>
        /// Invokes the DeleteS3BucketWithObjectsInternal method.
        /// </summary>
        /// <param name="state">The Request object that has all the data to complete the operation. </param>
        private static void InvokeDeleteS3BucketWithObjects(object state)
        {
            var request = (S3DeleteBucketWithObjectsRequest)state;

            try
            {
                DeleteS3BucketWithObjectsInternal(
                    request.BucketName,
                    request.S3Client,
                    request.DeleteOptions,
                    request.UpdateCallback,
                    request.AsyncCancelableResult
                    );
            }
            catch (Exception exception)
            {
                // Catch unhandled exception and store it on the async result.
                request.AsyncCancelableResult.LastException = exception;
                request.AsyncCancelableResult.SignalWaitHandleOnCompleted();
            }
        }

        /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. The function deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">Options to control the behavior of the delete operation.</param>
        /// <param name="updateCallback">The callback which is used to send updates about the delete operation.</param>
        /// <param name="asyncCancelableResult">An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</param>
        private static void DeleteS3BucketWithObjectsInternal(string bucketName, AmazonS3 s3Client,
            S3DeleteBucketWithObjectsOptions deleteOptions,Action<S3DeleteBucketWithObjectsUpdate> updateCallback,
            AsyncCancelableResult asyncCancelableResult)            
        {    
            // Validations.
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client", "The s3Client cannot be null!");
            }

            if (string.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName cannot be null or empty string!");
            }
            
            var listVersionsRequest = new ListVersionsRequest { BucketName=bucketName };
            
            ListVersionsResponse listVersionsResponse;

            // Iterate through the objects in the bucket and delete them.
            do
            {
                // Check if the operation has been canceled.
                if (asyncCancelableResult.IsCancelRequested)
                {
                    // Signal that the operation is canceled.
                    asyncCancelableResult.SignalWaitHandleOnCanceled();                    
                    return;
                }

                // List all the versions of all the objects in the bucket.
                listVersionsResponse = s3Client.ListVersions(listVersionsRequest);

                if (listVersionsResponse.Versions.Count==0)
                {
                    // If the bucket has no objects break the loop.
                    break;
                }

                var keyVersionList = new List<KeyVersion>(listVersionsResponse.Versions.Count);
                for (int index = 0; index < listVersionsResponse.Versions.Count; index++)
                {
                    keyVersionList.Add(new KeyVersion(
                                                listVersionsResponse.Versions[index].Key,
                                                listVersionsResponse.Versions[index].VersionId
                                            ));
                }

                try
                {
                    // Delete the current set of objects.
                    var deleteObjectsResponse =
                        s3Client.DeleteObjects(new DeleteObjectsRequest
                        {
                            BucketName=bucketName,
                            Quiet=deleteOptions.QuietMode,
                            Keys=keyVersionList
                        });

                    if (!deleteOptions.QuietMode)
                    {
                        // If quiet mode is not set, update the client with list of deleted objects.
                        InvokeS3DeleteBucketWithObjectsUpdateCallback(
                                        updateCallback,
                                        new S3DeleteBucketWithObjectsUpdate
                                        {
                                            DeletedObjects = deleteObjectsResponse.DeletedObjects
                                        }
                                    );
                    }
                }
                catch (DeleteObjectsException deleteObjectsException)
                {
                    if (deleteOptions.ContinueOnError)
                    {
                        // Continue the delete operation if an error was encountered.
                        // Update the client with the list of objects that were deleted and the 
                        // list of objects on which the delete failed.
                        InvokeS3DeleteBucketWithObjectsUpdateCallback(
                                updateCallback,
                                new S3DeleteBucketWithObjectsUpdate
                                {
                                    DeletedObjects = deleteObjectsException.ErrorResponse.DeletedObjects,
                                    DeleteErrors = deleteObjectsException.ErrorResponse.DeleteErrors
                                }
                            );
                    }
                    else
                    {
                        // Re-throw the exception if an error was encountered.
                        throw;
                    }
                }

                // Set the markers to get next set of objects from the bucket.
                listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;

            } 
            // Continue listing objects and deleting them until the bucket is empty.
            while (listVersionsResponse.IsTruncated);

            for (int attempts = 0; true; attempts++)
            {
                try
                {
                    // Bucket is empty, delete the bucket.
                    s3Client.DeleteBucket( new DeleteBucketRequest { BucketName = bucketName } );
                    
                    break;
                }
                catch (AmazonS3Exception e)
                {
                    if (!string.Equals(e.ErrorCode, S3Constants.BucketNotEmpty) || attempts >= 3)
                        throw;
                    Thread.Sleep(5 * 1000);
                }
            }

            // Signal that the operation is completed.
            asyncCancelableResult.SignalWaitHandleOnCompleted();            
        }

        /// <summary>
        /// Invokes the callback which provides updated about the delete operation.
        /// </summary>
        /// <param name="updateCallback">The callback to be invoked.</param>
        /// <param name="update">The data being passed to the callback.</param>
        private static void InvokeS3DeleteBucketWithObjectsUpdateCallback(
            Action<S3DeleteBucketWithObjectsUpdate> updateCallback,S3DeleteBucketWithObjectsUpdate update)
        {
            if (updateCallback != null)
            {
                updateCallback(update);
            }
        }


        /// <summary>
        /// Sets up the request needed to make an exact copy of the object leaving the parent method
        /// the ability to change just the attribute being requested to change.
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="key"></param>
        /// <param name="version"></param>
        /// <param name="s3Client"></param>
        /// <param name="copyRequest"></param>
        /// <param name="setACLRequest"></param>
        static void SetupForObjectModification(string bucketName, string key, string version, AmazonS3 s3Client,
            out CopyObjectRequest copyRequest, out SetACLRequest setACLRequest)
        {
            // Get the existing ACL of the object
            GetACLRequest getACLRequest = new GetACLRequest();
            getACLRequest.BucketName = bucketName;
            getACLRequest.Key = key;
            if (version != null)
                getACLRequest.VersionId = version;
            GetACLResponse getACLResponse = s3Client.GetACL(getACLRequest);


            // Set the object's original ACL back onto it because a COPY
            // operation resets the ACL on the destination object.
            setACLRequest = new SetACLRequest();
            setACLRequest.BucketName = bucketName;
            setACLRequest.Key = key;
            setACLRequest.ACL = getACLResponse.AccessControlList;


            ListObjectsResponse listObjectResponse = s3Client.ListObjects(new ListObjectsRequest
            {
                BucketName = bucketName,
                Prefix = key,
                MaxKeys = 1
            });

            if (listObjectResponse.S3Objects.Count != 1)
            {
                throw new ArgumentNullException("No object exists with this bucket name and key.");
            }

            GetObjectMetadataRequest getMetaRequest = new GetObjectMetadataRequest()
            {
                BucketName = bucketName,
                Key = key
            };
            GetObjectMetadataResponse getMetaResponse = s3Client.GetObjectMetadata(getMetaRequest);

            // Set the storage class on the object
            copyRequest = new CopyObjectRequest();
            copyRequest.SourceBucket = copyRequest.DestinationBucket = bucketName;
            copyRequest.SourceKey = copyRequest.DestinationKey = key;
            copyRequest.StorageClass = listObjectResponse.S3Objects[0].StorageClass == "STANDARD" ? S3StorageClass.Standard : S3StorageClass.ReducedRedundancy;
            if (version != null)
                copyRequest.SourceVersionId = version;

            copyRequest.WebsiteRedirectLocation = getMetaResponse.WebsiteRedirectLocation;
            copyRequest.ServerSideEncryptionMethod = getMetaResponse.ServerSideEncryptionMethod;
        }

        internal static void ParseAmzRestoreHeader(string header, out bool restoreInProgress, out DateTime? restoreExpiration)
        {
            const string ONGOING_REQUEST = "ongoing-request";
            const string EXPIRY_DATE = "expiry-date";

            restoreExpiration = null;
            restoreInProgress = false;

            if (header == null)
                return;

            int pos = header.IndexOf(ONGOING_REQUEST);
            if (pos != -1)
            {
                int startPos = header.IndexOf('"', pos) + 1;
                int endPos = header.IndexOf('"', startPos + 1);

                string value = header.Substring(startPos, endPos - startPos);
                Boolean.TryParse(value, out restoreInProgress);
    }
            pos = header.IndexOf(EXPIRY_DATE);
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

        /// <summary>
        /// Converts the string representing a storage class that would come back from a ListObjects request
        /// to the S3StorageClass enumeration.
        /// </summary>
        /// <param name="value">Amazon S3 string values for storage class</param>
        /// <returns>The converted S3StorageClass enumeration</returns>
        public static S3StorageClass ConvertToS3StorageClass(string value)
        {
            switch(value)
            {
                case "REDUCED_REDUNDANCY":
                    return S3StorageClass.ReducedRedundancy;
                case "GLACIER":
                    return S3StorageClass.Glacier;
                default:
                    return S3StorageClass.Standard;                
            }
        }

    }
}