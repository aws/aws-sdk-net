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
 *  API Version: 2010-07-15
 *
 */

using System;
using System.Collections.Specialized;

using Amazon.Util;

namespace Amazon.CloudFront.Util
{
    /// <summary>
    /// Provides utilities used by the Amazon CloudFront client implementation.
    /// </summary>
    [Obsolete("This utility class is no longer maintained and will be removed in the next major version.")]
    public static class AmazonCloudFrontUtil
    {
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
        /// URL encodes a string. If the path property is specified,
        /// the accepted characters {/:+} are not encoded.
        /// </summary>
        /// <param name="data">The string to encode</param>
        /// <param name="path">Whether the string is a URL path or not</param>
        /// <returns></returns>
        public static string UrlEncode(string data, bool path)
        {
            return AWSSDKUtils.UrlEncode(1738, data, path);
        }
    }
}