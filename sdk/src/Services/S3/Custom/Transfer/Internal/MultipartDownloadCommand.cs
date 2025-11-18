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
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Command for downloading files using multipart download strategy.
    /// Orchestrates the <see cref="MultipartDownloadManager"/> and <see cref="FilePartDataHandler"/>
    /// to perform concurrent part downloads with SEP compliance.
    /// </summary>
    internal partial class MultipartDownloadCommand : BaseCommand<TransferUtilityDownloadResponse>
    {
        private readonly IAmazonS3 _s3Client;
        private readonly TransferUtilityDownloadRequest _request;
        private readonly TransferUtilityConfig _config;
        
        // Track last known transferred bytes from coordinator's progress events
        private long _lastKnownTransferredBytes;

        private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

        /// <summary>
        /// Initializes a new instance of the MultipartDownloadCommand class.
        /// </summary>
        /// <param name="s3Client">The S3 client to use for downloads.</param>
        /// <param name="request">The download request containing configuration.</param>
        /// <param name="config">The TransferUtility configuration.</param>
        internal MultipartDownloadCommand(IAmazonS3 s3Client, TransferUtilityDownloadRequest request, TransferUtilityConfig config)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Validates the download request to ensure all required parameters are set.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when required parameters are missing.</exception>
        private void ValidateRequest()
        {
            if (!_request.IsSetBucketName())
            {
                throw new InvalidOperationException("The BucketName specified is null or empty!");
            }
            
            if (!_request.IsSetKey())
            {
                throw new InvalidOperationException("The Key specified is null or empty!");
            }
            
#if BCL
            if (!_request.IsSetFilePath())
            {
                throw new InvalidOperationException("The FilePath specified is null or empty!");
            }
#endif
        }

        /// <summary>
        /// Creates a FileDownloadConfiguration from the request and S3 client configuration.
        /// </summary>
        /// <returns>A configured FileDownloadConfiguration instance.</returns>
        private FileDownloadConfiguration CreateConfiguration()
        {
            // Use concurrent service requests from config
            int concurrentRequests = _config.ConcurrentServiceRequests;

            // Determine target part size
            // Use request setting if available, otherwise use 8MB default (matching BufferedMultipartStream)
            long targetPartSize = _request.IsSetPartSize() 
                ? _request.PartSize 
                : S3Constants.DefaultPartSize; // 8MB default

            // Use S3 client buffer size for I/O operations
            int bufferSize = _s3Client.Config.BufferSize;

            Logger.DebugFormat("MultipartDownloadCommand: Creating configuration - PartSizeFromRequest={0}, UsingDefaultPartSize={1}",
                _request.IsSetPartSize() ? _request.PartSize.ToString() : "Not Set",
                !_request.IsSetPartSize());

            return new FileDownloadConfiguration(
                concurrentRequests,
                bufferSize,
                targetPartSize,
                _request.FilePath
            );
        }

        #region Event Firing Methods

        /// <summary>
        /// Fires the DownloadInitiatedEvent to notify subscribers that the download has started.
        /// This event is fired exactly once at the beginning of the download operation.
        /// </summary>
        private void FireTransferInitiatedEvent()
        {
            var transferInitiatedEventArgs = new DownloadInitiatedEventArgs(_request, _request.FilePath);
            _request.OnRaiseTransferInitiatedEvent(transferInitiatedEventArgs);
        }

        /// <summary>
        /// Fires the DownloadCompletedEvent to notify subscribers that the download completed successfully.
        /// This event is fired exactly once when all parts have been downloaded and assembled.
        /// Downloads are complete, so transferred bytes equals total bytes.
        /// </summary>
        /// <param name="response">The unified TransferUtilityDownloadResponse containing S3 metadata</param>
        /// <param name="totalBytes">The total number of bytes in the file</param>
        private void FireTransferCompletedEvent(TransferUtilityDownloadResponse response, long totalBytes)
        {
            var transferCompletedEventArgs = new DownloadCompletedEventArgs(
                _request,
                response,
                _request.FilePath,
                totalBytes,
                totalBytes);
            _request.OnRaiseTransferCompletedEvent(transferCompletedEventArgs);
        }

        /// <summary>
        /// Fires the DownloadFailedEvent to notify subscribers that the download failed.
        /// This event is fired exactly once when an error occurs during the download.
        /// Uses the last known transferred bytes from progress tracking.
        /// </summary>
        /// <param name="totalBytes">Total file size if known, otherwise -1</param>
        private void FireTransferFailedEvent(long totalBytes = -1)
        {
            var eventArgs = new DownloadFailedEventArgs(
                _request,
                _request.FilePath,
                System.Threading.Interlocked.Read(ref _lastKnownTransferredBytes),
                totalBytes);
            _request.OnRaiseTransferFailedEvent(eventArgs);
        }

        #endregion

        #region Progress Tracking

        /// <summary>
        /// Callback for part download progress.
        /// Forwards the aggregated progress events from the coordinator to the user's progress callback.
        /// The coordinator has already aggregated progress across all concurrent part downloads.
        /// Tracks the last known transferred bytes for failure reporting.
        /// </summary>
        /// <param name="sender">The event sender (coordinator)</param>
        /// <param name="e">Aggregated progress information from the coordinator</param>
        internal void DownloadPartProgressEventCallback(object sender, WriteObjectProgressArgs e)
        {
            // Track last known transferred bytes using Exchange (not Add).
            // 
            // Why Exchange? The coordinator already aggregates increments from concurrent parts:
            //   Coordinator receives: Part 1: +512 bytes, Part 2: +1024 bytes, Part 3: +768 bytes
            //   Coordinator aggregates: 0 -> 512 -> 1536 -> 2304 (using Interlocked.Add)
            //   Coordinator passes to us: e.TransferredBytes = 2304 (pre-aggregated total)
            //
            // We receive the TOTAL (e.TransferredBytes = 2304), not an increment (+768).
            // Using Add here would incorrectly accumulate totals: 0 + 2304 + 2304 + ... = wrong!
            // Using Exchange correctly stores the latest total: 2304 (overwrite previous value).
            //
            // Compare to other commands (SimpleUploadCommand, DownloadCommand) which receive
            // INCREMENTS directly from SDK streams and must use Add to accumulate them.
            System.Threading.Interlocked.Exchange(ref _lastKnownTransferredBytes, e.TransferredBytes);
            
            // Set the Request property to enable access to the original download request
            e.Request = _request;
            
            // Forward the coordinator's aggregated progress event to the user
            _request.OnRaiseProgressEvent(e);
        }

        #endregion
    }
}
