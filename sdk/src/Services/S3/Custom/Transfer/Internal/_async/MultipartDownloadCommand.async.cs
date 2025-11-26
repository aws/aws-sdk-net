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
            
            Logger.DebugFormat("MultipartDownloadCommand: Configuration - ConcurrentServiceRequests={0}, BufferSize={1}, TargetPartSize={2}",
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
                        Logger.DebugFormat("MultipartDownloadCommand: Discovering download strategy");
                        var discoveryResult = await coordinator.DiscoverDownloadStrategyAsync(cancellationToken)
                            .ConfigureAwait(false);
                        
                        totalBytes = discoveryResult.ObjectSize;

                        
                        Logger.DebugFormat("MultipartDownloadCommand: Discovered {0} part(s), total size: {1} bytes, IsSinglePart={2}",
                            discoveryResult.TotalParts, discoveryResult.ObjectSize, discoveryResult.IsSinglePart);
                        
                        // Step 2: Start concurrent downloads for all parts
                        Logger.DebugFormat("Starting downloads for {0} part(s)", discoveryResult.TotalParts);
                        await coordinator.StartDownloadsAsync(discoveryResult, DownloadPartProgressEventCallback, cancellationToken)
                            .ConfigureAwait(false);
                        
                        // Step 2b: Wait for all downloads to complete before returning
                        // This ensures file is fully written and committed for file-based downloads
                        // For stream-based downloads, this task completes immediately (no-op)
                        Logger.DebugFormat("MultipartDownloadCommand: Waiting for download completion");
                        await coordinator.DownloadCompletionTask.ConfigureAwait(false);
                        
                        Logger.DebugFormat("MultipartDownloadCommand: Completed multipart download");
                        
                        // Step 3: Map the response from the initial GetObject response
                        // The initial response contains all the metadata we need
                        var mappedResponse = ResponseMapper.MapGetObjectResponse(discoveryResult.InitialResponse);
                        
                        // SEP Part GET Step 7 / Ranged GET Step 9:
                        // Set ContentLength to total object size (not just first part)
                        mappedResponse.Headers.ContentLength = discoveryResult.ObjectSize;
                        
                        // Set ContentRange to represent the entire object: bytes 0-(ContentLength-1)/ContentLength
                        // S3 returns null for 0-byte objects, so we match that behavior
                        if (discoveryResult.ObjectSize == 0)
                        {
                            mappedResponse.ContentRange = null;
                        }
                        else
                        {
                            mappedResponse.ContentRange = $"bytes 0-{discoveryResult.ObjectSize - 1}/{discoveryResult.ObjectSize}";
                        }
                        
                        // SEP Part GET Step 7 / Ranged GET Step 9:
                        // Handle composite checksums for multipart objects
                        // Per spec: "If ChecksumType is COMPOSITE, set all checksum value members to null 
                        // as the checksum value returned from a part GET request is not the composite 
                        // checksum for the entire object"
                        if (mappedResponse.ChecksumType == ChecksumType.COMPOSITE)
                        {
                            mappedResponse.ChecksumCRC32 = null;
                            mappedResponse.ChecksumCRC32C = null;
                            mappedResponse.ChecksumCRC64NVME = null;
                            mappedResponse.ChecksumSHA1 = null;
                            mappedResponse.ChecksumSHA256 = null;
                        }
                        
                        // Fire completed event
                        FireTransferCompletedEvent(mappedResponse, totalBytes);
                        
                        return mappedResponse;
                    }
                    catch (Exception ex)
                    {
                        Logger.Error(ex, "Exception during multipart download");
                        
                        // Fire failed event
                        FireTransferFailedEvent(totalBytes);
                        
                        throw;
                    }
                }
            }
        }
    }
}
