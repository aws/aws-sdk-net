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
        /// Discovers whether the object requires single-part or multipart downloading.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the discovery operation.</param>
        /// <returns>
        /// A task containing discovery results including total parts, object size,
        /// and initial response data if single-part.
        /// </returns>
        Task<DownloadDiscoveryResult> DiscoverDownloadStrategyAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Starts concurrent downloads with HTTP concurrency control and part range calculations.
        /// </summary>
        /// <param name="discoveryResult">Results from the discovery phase.</param>
        /// <param name="cancellationToken">A token to cancel the download operation.</param>
        /// <param name="progressCallback">Optional callback for progress tracking events.</param>
        /// <returns>A task that completes when all downloads finish or an error occurs.</returns>
        Task StartDownloadsAsync(DownloadDiscoveryResult discoveryResult, CancellationToken cancellationToken, EventHandler<WriteObjectProgressArgs> progressCallback = null);

        /// <summary>
        /// Exception that occurred during downloads, if any.
        /// </summary>
        Exception DownloadException { get; }
    }

    /// <summary>
    /// Download discovery results with metadata for determining download strategy.
    /// </summary>
    internal class DownloadDiscoveryResult
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
        /// GetObjectResponse obtained during download initialization, containing the ResponseStream. Represents the complete object for single-part downloads or the first range/part for multipart downloads.
        /// </summary>
        public GetObjectResponse InitialResponse { get; set; }

        /// <summary>
        /// Whether this is a single-part download.
        /// </summary>
        public bool IsSinglePart => TotalParts == 1;
    }
}
