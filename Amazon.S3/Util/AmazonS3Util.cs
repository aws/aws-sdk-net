/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

using Amazon.Util;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Provides utilities used by the Amazon S3 client implementation.
    /// These utilities might be useful to consumers of the Amazon S3
    /// library.
    /// </summary>
    public static class AmazonS3Util
    {
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
                throw new AmazonS3Exception("The AWS Secret Access Key specified is NULL");
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

            if (bucketName.Length < S3Constants.MinBucketLength||
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
    }
}