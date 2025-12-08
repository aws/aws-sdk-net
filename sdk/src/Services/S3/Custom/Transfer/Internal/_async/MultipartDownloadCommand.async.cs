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
    internal partial class MultipartDownloadCommand : BaseCommand<TransferUtilityDownloadResponse>
    {
        /// <inheritdoc/>
        public override async Task<TransferUtilityDownloadResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            // Validate request parameters
            ValidateRequest();
            
            // Fire initiated event before starting any network operations
            FireTransferInitiatedEvent();

            // Create configuration from request settings
            var config = CreateConfiguration();
            
            _logger.DebugFormat("MultipartDownloadCommand: Configuration - ConcurrentServiceRequests={0}, BufferSize={1}, TargetPartSize={2}",
                config.ConcurrentServiceRequests,
                config.BufferSize,
                config.TargetPartSizeBytes
                );
            
            // Create data handler for writing parts to disk
            using (var dataHandler = new FilePartDataHandler(config))
            {
                // Create coordinator to manage the download process
                // Pass shared HTTP throttler to control concurrency across files
                using (var coordinator = new MultipartDownloadManager(
                    _s3Client,
                    _request,
                    config,
                    dataHandler,
                    RequestEventHandler,
                    _sharedHttpThrottler))
                {
                    long totalBytes = -1;
                    try
                    {
                        // Step 1: Discover download strategy (PART or RANGE) and get metadata
                        _logger.DebugFormat("MultipartDownloadCommand: Discovering download strategy");
                        var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(cancellationToken)
                            .ConfigureAwait(false);
                        
                        totalBytes = discoveryResult.ObjectSize;

                        
                        _logger.DebugFormat("MultipartDownloadCommand: Discovered {0} part(s), total size: {1} bytes, IsSinglePart={2}",
                            discoveryResult.TotalParts, discoveryResult.ObjectSize, discoveryResult.IsSinglePart);
                        
                        // Step 2: Start concurrent downloads for all parts
                        _logger.DebugFormat("Starting downloads for {0} part(s)", discoveryResult.TotalParts);
                        await coordinator.StartDownloadsAsync(discoveryResult, DownloadPartProgressEventCallback, cancellationToken)
                            .ConfigureAwait(false);
                        
                        // Step 2b: Wait for all downloads to complete before returning
                        // This ensures file is fully written and committed for file-based downloads
                        // For stream-based downloads, this task completes immediately (no-op)
                        _logger.DebugFormat("MultipartDownloadCommand: Waiting for download completion");
                        await coordinator.DownloadCompletionTask.ConfigureAwait(false);
                        
                        _logger.DebugFormat("MultipartDownloadCommand: Completed multipart download");
                        _logger.DebugFormat("MultipartDownloadCommand: All parts written to disk, beginning response mapping");
                        
                        // Step 3: Map the response from the initial GetObject response
                        // The initial response contains all the metadata we need
                        _logger.DebugFormat("MultipartDownloadCommand: Mapping response from initial GetObject");
                        var mappedResponse = ResponseMapper.MapGetObjectResponse(discoveryResult.InitialResponse);
                        _logger.DebugFormat("MultipartDownloadCommand: Response mapping complete");
                        
                        // SEP Part GET Step 7 / Ranged GET Step 9:
                        // Set ContentLength to total object size (not just first part)
                        _logger.DebugFormat("MultipartDownloadCommand: Setting ContentLength to {0}", discoveryResult.ObjectSize);
                        mappedResponse.Headers.ContentLength = discoveryResult.ObjectSize;
                        
                        // Set ContentRange to represent the entire object: bytes 0-(ContentLength-1)/ContentLength
                        // S3 returns null for 0-byte objects, so we match that behavior
                        _logger.DebugFormat("MultipartDownloadCommand: Setting ContentRange");
                        if (discoveryResult.ObjectSize == 0)
                        {
                            mappedResponse.ContentRange = null;
                            _logger.DebugFormat("MultipartDownloadCommand: ContentRange set to null (0-byte object)");
                        }
                        else
                        {
                            mappedResponse.ContentRange = $"bytes 0-{discoveryResult.ObjectSize - 1}/{discoveryResult.ObjectSize}";
                            _logger.DebugFormat("MultipartDownloadCommand: ContentRange set to: {0}", mappedResponse.ContentRange);
                        }
                        
                        // SEP Part GET Step 7 / Ranged GET Step 9:
                        // Handle composite checksums for multipart objects
                        // Per spec: "If ChecksumType is COMPOSITE, set all checksum value members to null 
                        // as the checksum value returned from a part GET request is not the composite 
                        // checksum for the entire object"
                        _logger.DebugFormat("MultipartDownloadCommand: Processing checksums (ChecksumType={0})", mappedResponse.ChecksumType);
                        if (mappedResponse.ChecksumType == ChecksumType.COMPOSITE)
                        {
                            _logger.DebugFormat("MultipartDownloadCommand: Nullifying composite checksums");
                            mappedResponse.ChecksumCRC32 = null;
                            mappedResponse.ChecksumCRC32C = null;
                            mappedResponse.ChecksumCRC64NVME = null;
                            mappedResponse.ChecksumSHA1 = null;
                            mappedResponse.ChecksumSHA256 = null;
                        }
                        _logger.DebugFormat("MultipartDownloadCommand: Checksum processing complete");
                        
                        // Fire completed event
                        _logger.DebugFormat("MultipartDownloadCommand: Firing transfer completed event");
                        FireTransferCompletedEvent(mappedResponse, totalBytes);
                        _logger.DebugFormat("MultipartDownloadCommand: Transfer completed event fired");
                        
                        _logger.DebugFormat("MultipartDownloadCommand: Returning response to caller");
                        return mappedResponse;
                    }
                    catch (Exception ex)
                    {
                        _logger.Error(ex, "Exception during multipart download");
                        
                        // Fire failed event
                        FireTransferFailedEvent(totalBytes);
                        
                        throw;
                    }
                }
            }
        }
    }
}
