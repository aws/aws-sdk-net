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
    /// Coordinates multipart download orchestration including discovery, concurrent downloads,
    /// and progress reporting. Separates download coordination logic from stream management.
    /// </summary>
    internal interface IDownloadCoordinator : IDisposable
    {
        /// <summary>
        /// Discover whether the object requires single-part or multipart downloading.
        /// Performs HEAD request or similar to determine object size and part strategy.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the discovery operation.</param>
        /// <returns>
        /// A task containing discovery results including total parts, object size,
        /// and initial response data if single-part.
        /// </returns>
        Task<DownloadDiscoveryResult> DiscoverDownloadStrategyAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Initialize and start concurrent multipart downloads.
        /// Manages HTTP concurrency, part range calculations, and download orchestration.
        /// </summary>
        /// <param name="discoveryResult">Results from the discovery phase.</param>
        /// <param name="partBufferManager">Manager for coordinating downloaded part buffers.</param>
        /// <param name="cancellationToken">A token to cancel the download operation.</param>
        /// <returns>A task that completes when all downloads finish or an error occurs.</returns>
        Task StartDownloadsAsync(DownloadDiscoveryResult discoveryResult, IPartBufferManager partBufferManager, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the exception that occurred during downloads, if applicable.
        /// </summary>
        Exception DownloadException { get; }
    }

    /// <summary>
    /// Results from the download discovery phase.
    /// Contains information needed to determine download strategy.
    /// </summary>
    internal class DownloadDiscoveryResult
    {
        /// <summary>
        /// Total number of parts needed for the download.
        /// 1 indicates single-part download, >1 indicates multipart.
        /// </summary>
        public int TotalParts { get; set; }

        /// <summary>
        /// Total size of the object in bytes.
        /// </summary>
        public long ObjectSize { get; set; }

        /// <summary>
        /// For single-part downloads, contains the response with the object stream.
        /// Null for multipart downloads.
        /// </summary>
        public GetObjectResponse SinglePartResponse { get; set; }

        /// <summary>
        /// Contains the initial GetObjectResponse from the discovery phase.
        /// Used for extracting metadata (ETag, Headers, ServerSideEncryption, etc.) 
        /// in both single-part and multipart scenarios.
        /// For single-part, this will be the same as SinglePartResponse.
        /// For multipart, this contains metadata from the first part request.
        /// </summary>
        public GetObjectResponse InitialResponse { get; set; }

        /// <summary>
        /// For multipart downloads, contains the pre-buffered first part from discovery.
        /// This optimization avoids re-downloading Part 1 during the concurrent download phase.
        /// Null for single-part downloads.
        /// </summary>
        public StreamPartBuffer BufferedFirstPart { get; set; }

        /// <summary>
        /// Indicates if this is a single-part download (TotalParts == 1).
        /// </summary>
        public bool IsSinglePart => TotalParts == 1;
    }
}
