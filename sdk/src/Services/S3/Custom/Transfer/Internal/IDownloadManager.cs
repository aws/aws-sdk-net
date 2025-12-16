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
using System.Threading;
using System.Threading.Tasks;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Coordinates multipart downloads including discovery, concurrent downloads, and progress reporting.
    /// </summary>
    internal interface IDownloadManager : IDisposable
    {
        /// <summary>
        /// Discovers the download strategy and starts concurrent downloads in a single operation.
        /// This unified method eliminates resource leakage by managing HTTP slots and buffer capacity
        /// internally throughout the entire download lifecycle.
        /// </summary>
        /// <param name="progressCallback">Optional callback for progress tracking events.</param>
        /// <param name="cancellationToken">A token to cancel the download operation.</param>
        /// <returns>
        /// A task containing download results including total parts, object size,
        /// and initial response data.
        /// </returns>
        /// <remarks>
        /// This method performs both discovery and download operations atomically:
        /// 1. Acquires HTTP slot and buffer capacity
        /// 2. Makes initial GetObject request to discover download strategy
        /// 3. Processes Part 1 immediately
        /// 4. Starts background downloads for remaining parts (if multipart)
        /// 5. Returns after Part 1 is processed, allowing consumer to begin reading
        /// 
        /// Resources (HTTP slots, buffer capacity) are managed internally and released
        /// at the appropriate times, eliminating the awkward resource holding that existed
        /// with the previous two-method API.
        /// </remarks>
        Task<DownloadResult> StartDownloadAsync(EventHandler<WriteObjectProgressArgs> progressCallback, CancellationToken cancellationToken);
    }

    /// <summary>
    /// Download results with metadata about the completed discovery and initial download.
    /// </summary>
    internal class DownloadResult
    {
        /// <summary>
        /// Total parts needed (1 = single-part, >1 = multipart).
        /// </summary>
        public int TotalParts { get; set; }

        /// <summary>
        /// Total size of the object in bytes.
        /// </summary>
        public long ObjectSize { get; set; }

        /// <summary>
        /// GetObjectResponse obtained during download initialization, containing the ResponseStream. 
        /// Represents the complete object for single-part downloads or the first range/part for multipart downloads.
        /// </summary>
        public GetObjectResponse InitialResponse { get; set; }

        /// <summary>
        /// Whether this is a single-part download.
        /// </summary>
        public bool IsSinglePart => TotalParts == 1;
    }
}
