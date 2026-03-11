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
 *  API Version: 2006-03-01
 *
 */
using System;

namespace Amazon.S3.Util
{
    /// <summary>
    /// Utility for parsing S3 ContentRange headers.
    /// Format: "bytes {start}-{end}/{total}"
    /// Example: "bytes 0-5242879/52428800"
    /// </summary>
    internal static class ContentRangeParser
    {
        /// <summary>
        /// Parses ContentRange header into its components.
        /// </summary>
        /// <param name="contentRange">ContentRange header value (e.g., "bytes 0-1023/2048")</param>
        /// <returns>Tuple of (startByte, endByte, totalSize)</returns>
        /// <exception cref="InvalidOperationException">If ContentRange format is invalid</exception>
        public static (long startByte, long endByte, long totalSize) Parse(string contentRange)
        {
            if (string.IsNullOrEmpty(contentRange))
                throw new InvalidOperationException("Content-Range header is missing");

            // Format: "bytes {start}-{end}/{total-size}"
            // Remove "bytes " prefix if present
            var parts = contentRange.Replace("bytes ", "").Split('/');
            if (parts.Length != 2)
                throw new InvalidOperationException($"Invalid ContentRange format: {contentRange}");

            // Parse byte range (start-end)
            var rangeParts = parts[0].Split('-');
            if (rangeParts.Length != 2 ||
                !long.TryParse(rangeParts[0], out var startByte) ||
                !long.TryParse(rangeParts[1], out var endByte))
                throw new InvalidOperationException($"Unable to parse ContentRange byte range: {contentRange}");

            // Parse total size - S3 always returns exact sizes, never wildcards
            if (parts[1] == "*")
                throw new InvalidOperationException($"Unexpected wildcard in ContentRange total size: {contentRange}. S3 always returns exact object sizes.");
            if (!long.TryParse(parts[1], out var totalSize))
                throw new InvalidOperationException($"Unable to parse ContentRange total size: {contentRange}");

            return (startByte, endByte, totalSize);
        }

        /// <summary>
        /// Extracts just the start byte position from ContentRange.
        /// </summary>
        /// <param name="contentRange">ContentRange header value</param>
        /// <returns>Start byte position</returns>
        /// <exception cref="InvalidOperationException">If ContentRange format is invalid</exception>
        public static long GetStartByte(string contentRange)
        {
            var (startByte, _, _) = Parse(contentRange);
            return startByte;
        }

        /// <summary>
        /// Extracts just the total size from ContentRange.
        /// </summary>
        /// <param name="contentRange">ContentRange header value</param>
        /// <returns>Total object size in bytes</returns>
        /// <exception cref="InvalidOperationException">If ContentRange format is invalid</exception>
        public static long GetTotalSize(string contentRange)
        {
            var (_, _, totalSize) = Parse(contentRange);
            return totalSize;
        }
    }
}
