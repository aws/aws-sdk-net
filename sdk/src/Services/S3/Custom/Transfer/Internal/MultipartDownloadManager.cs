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
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Coordinates multipart downloads using PART or RANGE strategies per SEP spec.
    /// Handles discovery, concurrent downloads.
    /// </summary>
    internal class MultipartDownloadManager : IDownloadManager
    {
        private readonly IAmazonS3 _s3Client;
        private readonly BaseDownloadRequest _request;
        private readonly DownloadCoordinatorConfiguration _config;
        private readonly IPartDataHandler _dataHandler;
        private readonly SemaphoreSlim _httpConcurrencySlots;
        private readonly RequestEventHandler _requestEventHandler;
        
        private Exception _downloadException;
        private bool _disposed = false;
        private bool _discoveryCompleted = false;

        private string _savedETag;
        private int _discoveredPartCount;

        private Logger Logger
        {
            get { return Logger.GetLogger(typeof(TransferUtility)); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartDownloadManager"/> class.
        /// </summary>
        /// <param name="s3Client">The <see cref="IAmazonS3"/> client for making S3 requests.</param>
        /// <param name="request">The <see cref="BaseDownloadRequest"/> containing download parameters.</param>
        /// <param name="config">The <see cref="DownloadCoordinatorConfiguration"/> with download settings.</param>
        /// <param name="dataHandler">The <see cref="IPartDataHandler"/> for processing downloaded parts.</param>
        /// <param name="requestEventHandler">Optional <see cref="RequestEventHandler"/> for user agent tracking.</param>
        /// <exception cref="ArgumentNullException">Thrown when any required parameter is null.</exception>
        public MultipartDownloadManager(IAmazonS3 s3Client, BaseDownloadRequest request, DownloadCoordinatorConfiguration config, IPartDataHandler dataHandler, RequestEventHandler requestEventHandler = null)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _dataHandler = dataHandler ?? throw new ArgumentNullException(nameof(dataHandler));
            _requestEventHandler = requestEventHandler;
            
            _httpConcurrencySlots = new SemaphoreSlim(_config.ConcurrentServiceRequests);
        }

        /// <inheritdoc/>
        public Exception DownloadException
        { 
            get 
            { 
                return _downloadException;
            }
        }

        /// <inheritdoc/>
        public async Task<DownloadDiscoveryResult> DiscoverDownloadStrategyAsync(CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (_discoveryCompleted)
                throw new InvalidOperationException("Discovery has already been performed");

            Logger.DebugFormat("MultipartDownloadManager: Starting discovery with strategy={0}",
                _request.MultipartDownloadType);

            try
            {
                // Use strategy-specific discovery based on MultipartDownloadType
                var result = _request.MultipartDownloadType == MultipartDownloadType.PART
                    ? await DiscoverUsingPartStrategyAsync(cancellationToken).ConfigureAwait(false)
                    : await DiscoverUsingRangeStrategyAsync(cancellationToken).ConfigureAwait(false);
                
                _discoveryCompleted = true;

                Logger.InfoFormat("MultipartDownloadManager: Discovery complete - ObjectSize={0}, TotalParts={1}, Strategy={2}, ETagPresent={3}",
                    result.ObjectSize,
                    result.TotalParts,
                    _request.MultipartDownloadType,
                    !string.IsNullOrEmpty(_savedETag));
                
                return result;
            }
            catch (Exception ex)
            {
                _downloadException = ex;
                Logger.Error(ex, "MultipartDownloadManager: Discovery failed");
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task StartDownloadsAsync(DownloadDiscoveryResult discoveryResult, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (discoveryResult == null)
                throw new ArgumentNullException(nameof(discoveryResult));

            Logger.DebugFormat("MultipartDownloadManager: Starting downloads - TotalParts={0}, IsSinglePart={1}",
                discoveryResult.TotalParts, discoveryResult.IsSinglePart);

            var downloadTasks = new List<Task>();
            var internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            try
            {
                // Process Part 1 from InitialResponse (applies to both single-part and multipart)
                Logger.DebugFormat("MultipartDownloadManager: Buffering Part 1 from discovery response");
                await _dataHandler.ProcessPartAsync(1, discoveryResult.InitialResponse, cancellationToken).ConfigureAwait(false);

                if (discoveryResult.IsSinglePart)
                {
                    // Single-part: Part 1 is the entire object
                    Logger.DebugFormat("MultipartDownloadManager: Single-part download complete");
                    _dataHandler.OnDownloadComplete(null);
                    return;
                }

                // Multipart: Start concurrent downloads for remaining parts (Part 2 onwards)
                Logger.InfoFormat("MultipartDownloadManager: Starting concurrent downloads for parts 2-{0}",
                    discoveryResult.TotalParts);

                for (int partNum = 2; partNum <= discoveryResult.TotalParts; partNum++)
                {
                    var task = CreateDownloadTaskAsync(partNum, discoveryResult.ObjectSize, internalCts.Token);
                    downloadTasks.Add(task);
                }

                // Store count before WhenAllOrFirstException (which modifies the list internally)
                var expectedTaskCount = downloadTasks.Count;

                Logger.DebugFormat("MultipartDownloadManager: Waiting for {0} download tasks to complete", expectedTaskCount);

                // Wait for all downloads to complete (fails fast on first exception)
                await TaskHelpers.WhenAllOrFirstExceptionAsync(downloadTasks, cancellationToken).ConfigureAwait(false);

                Logger.DebugFormat("MultipartDownloadManager: All download tasks completed successfully");

                // SEP Part GET Step 6 / Ranged GET Step 8:
                // "validate that the total number of part GET requests sent matches with the expected PartsCount"
                // Note: This should always be true if we reach this point, since WhenAllOrFirstException
                // ensures all tasks completed successfully (or threw on first failure).
                // The check serves as a defensive assertion for SEP compliance.
                // Note: expectedTaskCount + 1 accounts for Part 1 being buffered during discovery
                if (expectedTaskCount + 1 != discoveryResult.TotalParts)
                {
                    throw new InvalidOperationException(
                        $"Request count mismatch. Expected {discoveryResult.TotalParts} parts, " +
                        $"but sent {expectedTaskCount + 1} requests");
                }

                // Mark successful completion
                Logger.InfoFormat("MultipartDownloadManager: Download completed successfully - TotalParts={0}",
                    discoveryResult.TotalParts);
                _dataHandler.OnDownloadComplete(null);
            }
            catch (Exception ex)
            {
                _downloadException = ex;
                Logger.Error(ex, "MultipartDownloadManager: Download failed");
                
                _dataHandler.OnDownloadComplete(ex);
                throw;
            }
            finally
            {
                internalCts.Dispose();
            }
        }



        private async Task CreateDownloadTaskAsync(int partNumber, long objectSize, CancellationToken cancellationToken)
        {
                Logger.DebugFormat("MultipartDownloadManager: [Part {0}] Waiting for buffer space", partNumber);

            // Wait for capacity before starting download
            await _dataHandler.WaitForCapacityAsync(cancellationToken).ConfigureAwait(false);

            Logger.DebugFormat("MultipartDownloadManager: [Part {0}] Buffer space acquired", partNumber);
            
            GetObjectResponse response = null;
            
            try
            {
                Logger.DebugFormat("MultipartDownloadManager: [Part {0}] Waiting for HTTP concurrency slot (Available: {1}/{2})",
                    partNumber, _httpConcurrencySlots.CurrentCount, _config.ConcurrentServiceRequests);

                // Limit HTTP concurrency
                await _httpConcurrencySlots.WaitAsync(cancellationToken).ConfigureAwait(false);

                Logger.DebugFormat("MultipartDownloadManager: [Part {0}] HTTP concurrency slot acquired", partNumber);
                
                try
                {
                    // Create strategy-specific request
                    GetObjectRequest getObjectRequest;
                    
                    if (_request.MultipartDownloadType == MultipartDownloadType.PART)
                    {
                        // PART strategy: Use part number from original upload
                        getObjectRequest = CreateGetObjectRequest();
                        getObjectRequest.PartNumber = partNumber;
                        
                        // SEP Part GET Step 4: "The S3 Transfer Manager MUST also set IfMatch member 
                        // for each request to the Etag value saved from Step 3"
                        getObjectRequest.EtagToMatch = _savedETag;

                        Logger.DebugFormat("MultipartDownloadManager: [Part {0}] Sending GetObject request with PartNumber={1}, IfMatchPresent={2}",
                            partNumber, partNumber, !string.IsNullOrEmpty(_savedETag));
                    }
                    else
                    {
                        // RANGE strategy: Use calculated byte range
                        var (startByte, endByte) = CalculatePartRange(partNumber, objectSize);
                        
                        getObjectRequest = CreateGetObjectRequest();
                        getObjectRequest.ByteRange = new ByteRange(startByte, endByte);
                        
                        // SEP Ranged GET Step 6: "The S3 Transfer Manager MUST also set IfMatch member 
                        // for each request to the value saved from Step 5"
                        getObjectRequest.EtagToMatch = _savedETag;

                        Logger.DebugFormat("MultipartDownloadManager: [Part {0}] Sending GetObject request with ByteRange={1}-{2}, IfMatchPresent={3}",
                            partNumber, startByte, endByte, !string.IsNullOrEmpty(_savedETag));
                    }
                    
                    response = await _s3Client.GetObjectAsync(getObjectRequest, cancellationToken).ConfigureAwait(false);

                    Logger.DebugFormat("MultipartDownloadManager: [Part {0}] GetObject response received - ContentLength={1}",
                        partNumber, response.ContentLength);
                    
                    // SEP Part GET Step 5 / Ranged GET Step 7: Validate ContentRange matches request
                    ValidateContentRange(response, partNumber, objectSize);

                    Logger.DebugFormat("MultipartDownloadManager: [Part {0}] ContentRange validation passed", partNumber);
                    
                    // Validate ETag consistency for SEP compliance
                    if (!string.IsNullOrEmpty(_savedETag) && !string.Equals(_savedETag, response.ETag, StringComparison.OrdinalIgnoreCase))
                    {
                        Logger.Error(null, "MultipartDownloadManager: [Part {0}] ETag mismatch detected - object modified during download", partNumber);
                        throw new InvalidOperationException($"ETag mismatch detected for part {partNumber} - object may have been modified during download");
                    }

                    Logger.DebugFormat("MultipartDownloadManager: [Part {0}] ETag validation passed", partNumber);
                }
                finally
                {
                    _httpConcurrencySlots.Release();
                    Logger.DebugFormat("MultipartDownloadManager: [Part {0}] HTTP concurrency slot released (Available: {1}/{2})",
                        partNumber, _httpConcurrencySlots.CurrentCount, _config.ConcurrentServiceRequests);
                }

                Logger.DebugFormat("MultipartDownloadManager: [Part {0}] Starting buffering", partNumber);
                
                // Delegate data handling to the handler
                await _dataHandler.ProcessPartAsync(partNumber, response, cancellationToken).ConfigureAwait(false);

                Logger.DebugFormat("MultipartDownloadManager: [Part {0}] Buffering completed successfully", partNumber);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "MultipartDownloadManager: [Part {0}] Download failed", partNumber);
                // Release capacity on failure
                _dataHandler.ReleaseCapacity();
                throw;
            }
            finally
            {
                // Always dispose the response since we never transfer ownership
                response?.Dispose();
            }
        }


        private async Task<DownloadDiscoveryResult> DiscoverUsingPartStrategyAsync(CancellationToken cancellationToken)
        {
            // SEP Part GET Step 1: "create a new GetObject request copying all fields in DownloadRequest. 
            // Set partNumber to 1."
            var firstPartRequest = CreateGetObjectRequest();
            firstPartRequest.PartNumber = 1;
            
            // SEP Part GET Step 2: "send the request and wait for the response in a non-blocking fashion"
            var firstPartResponse = await _s3Client.GetObjectAsync(firstPartRequest, cancellationToken).ConfigureAwait(false);
            
            // SEP Part GET Step 3: Save ETag for later IfMatch validation in subsequent requests
            _savedETag = firstPartResponse.ETag;
            
            // SEP Part GET Step 3: "check the response. First parse total content length from ContentRange 
            // of the GetObject response and save the value in a variable. The length is the numeric value 
            // after / delimiter. For example, given ContentRange=bytes 0-1/5, 5 is the total content length. 
            // Then check PartsCount."
            if (firstPartResponse.PartsCount.HasValue && firstPartResponse.PartsCount.Value > 1)
            {
                // SEP Part GET Step 3: "If PartsCount in the response is larger than 1, it indicates there 
                // are more parts available to download. The S3 Transfer Manager MUST save etag from the 
                // response to a variable."
                _discoveredPartCount = firstPartResponse.PartsCount.Value;
                
                // Parse total content length from ContentRange header
                // For example, "bytes 0-5242879/52428800" -> extract 52428800
                var totalObjectSize = ExtractTotalSizeFromContentRange(firstPartResponse.ContentRange);
                
                // SEP Part GET Step 7 will use this response for creating DownloadResponse
                // Keep the response with its stream (will be buffered in StartDownloadsAsync)
                return new DownloadDiscoveryResult
                {
                    TotalParts = firstPartResponse.PartsCount.Value,
                    ObjectSize = totalObjectSize,
                    InitialResponse = firstPartResponse  // Keep response with stream
                };
            }
            else
            {
                // SEP Part GET Step 3: "If PartsCount is 1, go to Step 7."
                _discoveredPartCount = 1;
                
                // Single part upload - return the response for immediate use (SEP Step 7)
                return new DownloadDiscoveryResult
                {
                    TotalParts = 1,
                    ObjectSize = firstPartResponse.ContentLength,
                    InitialResponse = firstPartResponse  // Keep response with stream
                };
            }
        }

        private async Task<DownloadDiscoveryResult> DiscoverUsingRangeStrategyAsync(CancellationToken cancellationToken)
        {
            // Get target part size for RANGE strategy (already set in config from request or default)
            var targetPartSize = _config.TargetPartSizeBytes;
            
            // SEP Ranged GET Step 1: "create a new GetObject request copying all fields in the original request. 
            // Set range value to bytes=0-{targetPartSizeBytes-1} to request the first part."
            var firstRangeRequest = CreateGetObjectRequest();
            firstRangeRequest.ByteRange = new ByteRange(0, targetPartSize - 1);
            
            // SEP Ranged GET Step 2: "send the request and wait for the response in a non-blocking fashion"
            var firstRangeResponse = await _s3Client.GetObjectAsync(firstRangeRequest, cancellationToken).ConfigureAwait(false);
            
            // SEP Ranged GET Step 5: "save Etag from the response to a variable" 
            // (for IfMatch validation in subsequent requests)
            _savedETag = firstRangeResponse.ETag;
            
            // SEP Ranged GET Step 3: "parse total content length from ContentRange of the GetObject response 
            // and save the value in a variable. The length is the numeric value after / delimiter. 
            // For example, given ContentRange=bytes0-1/5, 5 is the total content length."
            // Check if ContentRange is null (object smaller than requested range)
            if (firstRangeResponse.ContentRange == null)
            {
                // No ContentRange means we got the entire small object
                _discoveredPartCount = 1;
                
                return new DownloadDiscoveryResult
                {
                    TotalParts = 1,
                    ObjectSize = firstRangeResponse.ContentLength,
                    InitialResponse = firstRangeResponse  // Keep response with stream
                };
            }
            
            // Parse total object size from ContentRange (e.g., "bytes 0-5242879/52428800" -> 52428800)
            var totalContentLength = ExtractTotalSizeFromContentRange(firstRangeResponse.ContentRange);
            
            // SEP Ranged GET Step 4: "compare the parsed total content length from Step 3 with ContentLength 
            // of the response. If the parsed total content length equals to the value from ContentLength, 
            // it indicates this request contains all of the data. The request is finished, return the response."
            if (totalContentLength == firstRangeResponse.ContentLength)
            {
                // Single part: total size equals returned ContentLength
                // This request contains all of the data
                _discoveredPartCount = 1;
                
                return new DownloadDiscoveryResult
                {
                    TotalParts = 1,
                    ObjectSize = totalContentLength,
                    InitialResponse = firstRangeResponse  // Keep response with stream
                };
            }
            
            // SEP Ranged GET Step 4: "If they do not match, it indicates there are more parts available 
            // to download. Add a validation to verify that ContentLength equals to the targetPartSizeBytes."
            if (firstRangeResponse.ContentLength != targetPartSize)
            {
                throw new InvalidOperationException(
                    $"Expected first part size {targetPartSize} bytes, but received {firstRangeResponse.ContentLength} bytes. " +
                    $"Total object size is {totalContentLength} bytes.");
            }
            
            // SEP Ranged GET Step 5: "calculate number of requests required by performing integer division 
            // of total contentLength/targetPartSizeBytes. Save the number of ranged GET requests in a variable."
            _discoveredPartCount = (int)Math.Ceiling((double)totalContentLength / targetPartSize);
            
            // SEP Ranged GET Step 9 will use this response for creating DownloadResponse
            // Keep the response with its stream (will be buffered in StartDownloadsAsync)
            return new DownloadDiscoveryResult
            {
                TotalParts = _discoveredPartCount,
                ObjectSize = totalContentLength,
                InitialResponse = firstRangeResponse  // Keep response with stream
            };
        }

        private GetObjectRequest CreateGetObjectRequest()
        {
            var request = RequestMapper.MapToGetObjectRequest(_request);
            
            // Attach user agent handler if provided
            if (_requestEventHandler != null)
            {
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)request)
                    .AddBeforeRequestHandler(_requestEventHandler);
            }
            
            return request;
        }

        internal (long startByte, long endByte) CalculatePartRange(int partNumber, long objectSize)
        {
            var targetPartSize = _config.TargetPartSizeBytes;
            
            var startByte = (partNumber - 1) * targetPartSize;
            var endByte = Math.Min(startByte + targetPartSize - 1, objectSize - 1);
            return (startByte, endByte);
        }

        internal (long startByte, long endByte, long totalSize) ParseContentRange(string contentRange)
        {
            if (string.IsNullOrEmpty(contentRange))
                throw new InvalidOperationException("Content-Range header is missing");

            // Format: "bytes {start}-{end}/{total-size}"
            var parts = contentRange.Replace("bytes ", "").Split('/');
            if (parts.Length != 2)
                throw new InvalidOperationException($"Invalid ContentRange format: {contentRange}");

            // Parse byte range
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

        internal long ExtractTotalSizeFromContentRange(string contentRange)
        {
            var (_, _, totalSize) = ParseContentRange(contentRange);
            return totalSize;
        }

        internal void ValidateContentRange(GetObjectResponse response, int partNumber, long objectSize)
        {
            // Ranged GET Step 7: 
            // "validate that ContentRange matches with the requested range"            
            if (_request.MultipartDownloadType == MultipartDownloadType.RANGE)
            {
                var (expectedStartByte, expectedEndByte) = CalculatePartRange(partNumber, objectSize);

                // Parse actual ContentRange from response using unified helper
                if (string.IsNullOrEmpty(response.ContentRange))
                {
                    throw new InvalidOperationException($"ContentRange header missing from part {partNumber} response");
                }

                var (actualStartByte, actualEndByte, _) = ParseContentRange(response.ContentRange);

                // Validate range matches what we requested
                if (actualStartByte != expectedStartByte || actualEndByte != expectedEndByte)
                {
                    throw new InvalidOperationException(
                        $"ContentRange mismatch for part {partNumber}. " +
                        $"Expected: bytes {expectedStartByte}-{expectedEndByte}, " +
                        $"Actual: bytes {actualStartByte}-{actualEndByte}");
                }
            }
         
            // TODO in future for file based download it also says
            // Applicable to destinations to which the SDK writes parts parallelly, e.g., a file
            // the content range of the response aligns with the starting offset of the destination to which the SDK writes the part. For example, given a part with content range of bytes 8388608-16777215/33555032, 
            // it should be written to the file from offset 8,388,608 to 1,6777,215.
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(MultipartDownloadManager));
        }

        #region Dispose Pattern

        /// <inheritdoc/>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    _httpConcurrencySlots?.Dispose();
                    _dataHandler?.Dispose();
                }
                catch (Exception)
                {
                    // Suppressing CA1031: Dispose methods should not throw exceptions
                    // Continue disposal process silently on any errors
                }
                
                _disposed = true;
            }
        }

        #endregion
    }
}
