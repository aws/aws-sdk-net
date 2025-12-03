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
using Amazon.S3.Util;

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
        private readonly DownloadManagerConfiguration _config;
        private readonly IPartDataHandler _dataHandler;
        private readonly SemaphoreSlim _httpConcurrencySlots;
        private readonly bool _ownsHttpThrottler;
        private readonly RequestEventHandler _requestEventHandler;
        
        private Exception _downloadException;
        private bool _disposed = false;
        private bool _discoveryCompleted = false;
        private Task _downloadCompletionTask;

        private string _savedETag;
        private int _discoveredPartCount;

        // Progress tracking fields for multipart download aggregation
        private long _totalTransferredBytes = 0;
        private long _totalObjectSize = 0;
        private EventHandler<WriteObjectProgressArgs> _userProgressCallback;
        
        // Atomic flag to ensure completion event fires exactly once
        // Without this, concurrent parts completing simultaneously can both see
        // transferredBytes >= _totalObjectSize and fire duplicate completion events
        // Uses int instead of bool because Interlocked.CompareExchange requires reference types
        private int _completionEventFired = 0;  // 0 = false, 1 = true

        private readonly Logger _logger = Logger.GetLogger(typeof(MultipartDownloadManager));

        /// <summary>
        /// Task that completes when all downloads finish (successfully or with error).
        /// For file-based downloads, await this before returning to ensure file is committed.
        /// For stream-based downloads, this can be ignored as the consumer naturally waits.
        /// Returns a completed task if downloads haven't started or completed synchronously.
        /// </summary>
        public Task DownloadCompletionTask => _downloadCompletionTask ?? Task.CompletedTask;

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartDownloadManager"/> for single file downloads.
        /// This constructor creates and owns its own HTTP concurrency throttler based on the configuration.
        /// </summary>
        /// <param name="s3Client">The <see cref="IAmazonS3"/> client used to make GetObject requests to S3.</param>
        /// <param name="request">The <see cref="BaseDownloadRequest"/> containing bucket, key, version, and download strategy configuration.</param>
        /// <param name="config">The <see cref="DownloadManagerConfiguration"/> specifying concurrency limits and part size settings.</param>
        /// <param name="dataHandler">The <see cref="IPartDataHandler"/> responsible for buffering and processing downloaded part data.</param>
        /// <param name="requestEventHandler">Optional request event handler for adding custom headers or tracking requests. May be null.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="s3Client"/>, <paramref name="request"/>, <paramref name="config"/>, or <paramref name="dataHandler"/> is null.
        /// </exception>
        /// <remarks>
        /// This constructor is used for single file downloads where each download manages its own HTTP concurrency.
        /// The created <see cref="SemaphoreSlim"/> throttler will be disposed when this instance is disposed.
        /// For directory downloads with shared concurrency management, use the overload that accepts a shared throttler.
        /// </remarks>
        /// <seealso cref="DownloadManagerConfiguration"/>
        /// <seealso cref="IPartDataHandler"/>
        /// <seealso cref="MultipartDownloadType"/>
        /// <exception cref="NotSupportedException">Thrown when using S3 encryption client, which does not support multipart downloads.</exception>
        public MultipartDownloadManager(IAmazonS3 s3Client, BaseDownloadRequest request, DownloadManagerConfiguration config, IPartDataHandler dataHandler, RequestEventHandler requestEventHandler = null)
            : this(s3Client, request, config, dataHandler, requestEventHandler, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartDownloadManager"/> for directory downloads or scenarios requiring shared concurrency control.
        /// This constructor allows using a shared HTTP concurrency throttler across multiple concurrent file downloads.
        /// </summary>
        /// <param name="s3Client">The <see cref="IAmazonS3"/> client used to make GetObject requests to S3.</param>
        /// <param name="request">The <see cref="BaseDownloadRequest"/> containing bucket, key, version, and download strategy configuration.</param>
        /// <param name="config">The <see cref="DownloadManagerConfiguration"/> specifying concurrency limits and part size settings.</param>
        /// <param name="dataHandler">The <see cref="IPartDataHandler"/> responsible for buffering and processing downloaded part data.</param>
        /// <param name="requestEventHandler">Optional request event handler for adding custom headers or tracking requests. May be null.</param>
        /// <param name="sharedHttpThrottler">
        /// Optional shared <see cref="SemaphoreSlim"/> for coordinating HTTP concurrency across multiple downloads.
        /// If null, a new throttler will be created and owned by this instance.
        /// If provided, the caller retains ownership and responsibility for disposal.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when <paramref name="s3Client"/>, <paramref name="request"/>, <paramref name="config"/>, or <paramref name="dataHandler"/> is null.
        /// </exception>
        /// <remarks>
        /// <para>
        /// This constructor is typically used by directory download operations where multiple files are being downloaded
        /// concurrently and need to share a global HTTP concurrency limit.
        /// </para>
        /// <para>
        /// <strong>Resource Ownership:</strong>
        /// If <paramref name="sharedHttpThrottler"/> is provided, this instance does NOT take ownership and will NOT dispose it.
        /// If <paramref name="sharedHttpThrottler"/> is null, this instance creates and owns the throttler and will dispose it.
        /// </para>
        /// </remarks>
        /// <seealso cref="DownloadManagerConfiguration"/>
        /// <seealso cref="IPartDataHandler"/>
        /// <seealso cref="MultipartDownloadType"/>
        /// <seealso cref="DiscoverDownloadStrategyAsync"/>
        /// <seealso cref="StartDownloadsAsync"/>
        /// <exception cref="NotSupportedException">Thrown when using S3 encryption client, which does not support multipart downloads.</exception>
        public MultipartDownloadManager(IAmazonS3 s3Client, BaseDownloadRequest request, DownloadManagerConfiguration config, IPartDataHandler dataHandler, RequestEventHandler requestEventHandler, SemaphoreSlim sharedHttpThrottler)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _dataHandler = dataHandler ?? throw new ArgumentNullException(nameof(dataHandler));

            // Validate that S3 encryption client is not being used for multipart downloads
            if (_s3Client is Amazon.S3.Internal.IAmazonS3Encryption)
            {
                throw new NotSupportedException("Multipart download is not supported when using Amazon.S3.Internal.IAmazonS3Encryption client. Please use the Amazon.S3.AmazonS3Client for multipart download.");
            }

            _requestEventHandler = requestEventHandler;
            
            // Use shared throttler if provided, otherwise create our own
            if (sharedHttpThrottler != null)
            {
                _httpConcurrencySlots = sharedHttpThrottler;
                _ownsHttpThrottler = false; // Don't dispose - directory command owns it
            }
            else
            {
                _httpConcurrencySlots = new SemaphoreSlim(_config.ConcurrentServiceRequests);
                _ownsHttpThrottler = true; // We own it, so we dispose it
            }
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

            _logger.DebugFormat("MultipartDownloadManager: Starting discovery with strategy={0}",
                _request.MultipartDownloadType);

            try
            {
                // Use strategy-specific discovery based on MultipartDownloadType
                var result = _request.MultipartDownloadType == MultipartDownloadType.PART
                    ? await DiscoverUsingPartStrategyAsync(cancellationToken).ConfigureAwait(false)
                    : await DiscoverUsingRangeStrategyAsync(cancellationToken).ConfigureAwait(false);
                
                _discoveryCompleted = true;

                _logger.InfoFormat("MultipartDownloadManager: Discovery complete - ObjectSize={0}, TotalParts={1}, Strategy={2}, ETagPresent={3}",
                    result.ObjectSize,
                    result.TotalParts,
                    _request.MultipartDownloadType,
                    !string.IsNullOrEmpty(_savedETag));
                
                return result;
            }
            catch (Exception ex)
            {
                _downloadException = ex;
                _logger.Error(ex, "MultipartDownloadManager: Discovery failed");
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task StartDownloadsAsync(DownloadDiscoveryResult discoveryResult, EventHandler<WriteObjectProgressArgs> progressCallback, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (discoveryResult == null)
                throw new ArgumentNullException(nameof(discoveryResult));

            // Store for progress aggregation
            _userProgressCallback = progressCallback;
            _totalObjectSize = discoveryResult.ObjectSize;

            _logger.DebugFormat("MultipartDownloadManager: Starting downloads - TotalParts={0}, IsSinglePart={1}",
                discoveryResult.TotalParts, discoveryResult.IsSinglePart);

            var downloadTasks = new List<Task>();
            var internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            try
            {
                // Prepare the data handler (e.g., create temp files for file-based downloads)
                await _dataHandler.PrepareAsync(discoveryResult, cancellationToken).ConfigureAwait(false);
                
                // Create delegate once and reuse for all parts
                var wrappedCallback = progressCallback != null 
                    ? new EventHandler<WriteObjectProgressArgs>(DownloadPartProgressEventCallback)
                    : null;
                
                try
                {
                    // Attach progress callback to Part 1's response if provided
                    if (wrappedCallback != null)
                    {
                        discoveryResult.InitialResponse.WriteObjectProgressEvent += wrappedCallback;
                    }
                    
                    // Process Part 1 from InitialResponse (applies to both single-part and multipart)
                    _logger.DebugFormat("MultipartDownloadManager: Buffering Part 1 from discovery response");
                    await _dataHandler.ProcessPartAsync(1, discoveryResult.InitialResponse, cancellationToken).ConfigureAwait(false);
                }
                finally
                {
                    // Always detach the event handler to prevent memory leak
                    // This runs whether ProcessPartAsync succeeds or throws
                    if (wrappedCallback != null)
                    {
                        discoveryResult.InitialResponse.WriteObjectProgressEvent -= wrappedCallback;
                    }
                }

                if (discoveryResult.IsSinglePart)
                {
                    // Single-part: Part 1 is the entire object
                    _logger.DebugFormat("MultipartDownloadManager: Single-part download complete");
                    _dataHandler.OnDownloadComplete(null);
                    return;
                }

                // Check if already cancelled before creating background task
                cancellationToken.ThrowIfCancellationRequested();

                // Start background task to handle capacity acquisition and task creation
                // This allows the method to return immediately so the consumer can start reading
                // which prevents deadlock when MaxInMemoryParts is reached before consumer begins reading
                _downloadCompletionTask = Task.Run(async () =>
                {
                    try
                    {
                        _logger.DebugFormat("MultipartDownloadManager: Background task starting capacity acquisition and downloads");
                        
                        // Multipart: Start concurrent downloads for remaining parts (Part 2 onwards)
                        _logger.InfoFormat("MultipartDownloadManager: Starting concurrent downloads for parts 2-{0}",
                            discoveryResult.TotalParts);

                        // Pre-acquire capacity in sequential order to prevent race condition deadlock
                        // This ensures Part 2 gets capacity before Part 3, etc., preventing out-of-order
                        // parts from consuming all buffer slots and blocking the next expected part
                        for (int partNum = 2; partNum <= discoveryResult.TotalParts; partNum++)
                        {
                            _logger.DebugFormat("MultipartDownloadManager: [Part {0}] Waiting for buffer space", partNum);

                            // Acquire capacity sequentially - guarantees Part 2 before Part 3, etc.
                            await _dataHandler.WaitForCapacityAsync(cancellationToken).ConfigureAwait(false);
                            
                            _logger.DebugFormat("MultipartDownloadManager: [Part {0}] Buffer space acquired", partNum);

                            var task = CreateDownloadTaskAsync(partNum, discoveryResult.ObjectSize, wrappedCallback, internalCts.Token);
                            downloadTasks.Add(task);
                        }

                        var expectedTaskCount = downloadTasks.Count;
                        _logger.DebugFormat("MultipartDownloadManager: Background task waiting for {0} download tasks", expectedTaskCount);
                        
                        // Wait for all downloads to complete (fails fast on first exception)
                        await TaskHelpers.WhenAllOrFirstExceptionAsync(downloadTasks, cancellationToken).ConfigureAwait(false);

                        _logger.DebugFormat("MultipartDownloadManager: All download tasks completed successfully");

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
                        _logger.InfoFormat("MultipartDownloadManager: Download completed successfully - TotalParts={0}",
                            discoveryResult.TotalParts);
                        _dataHandler.OnDownloadComplete(null);
                    }
                    #pragma warning disable CA1031 // Do not catch general exception types

                    catch (Exception ex)
                    {
                        _downloadException = ex;
                        _logger.Error(ex, "MultipartDownloadManager: Background download task failed");
                        _dataHandler.OnDownloadComplete(ex);
                        throw;
                    }
                    #pragma warning restore CA1031 // Do not catch general exception types
                    finally
                    {
                        // Dispose the CancellationTokenSource after all background operations complete
                        // This ensures the token remains valid for the entire lifetime of download tasks
                        internalCts.Dispose();
                    }
                }, cancellationToken);

                // Return immediately to allow consumer to start reading
                // This prevents deadlock when buffer fills up before consumer begins reading
                _logger.DebugFormat("MultipartDownloadManager: Returning to allow consumer to start reading");
            }
            catch (Exception ex)
            {
                _downloadException = ex;
                _logger.Error(ex, "MultipartDownloadManager: Download failed");
                
                _dataHandler.OnDownloadComplete(ex);
                
                // Dispose the CancellationTokenSource if background task was never started
                // This handles the case where an error occurs before Task.Run is called
                internalCts.Dispose();
                
                throw;
            }
        }



        private async Task CreateDownloadTaskAsync(int partNumber, long objectSize, EventHandler<WriteObjectProgressArgs> progressCallback, CancellationToken cancellationToken)
        {            
            GetObjectResponse response = null;
            var ownsResponse = false;  // Track if we still own the response
            
            try
            {
                _logger.DebugFormat("MultipartDownloadManager: [Part {0}] Waiting for HTTP concurrency slot (Available: {1}/{2})",
                    partNumber, _httpConcurrencySlots.CurrentCount, _config.ConcurrentServiceRequests);

                // Limit HTTP concurrency
                await _httpConcurrencySlots.WaitAsync(cancellationToken).ConfigureAwait(false);

                _logger.DebugFormat("MultipartDownloadManager: [Part {0}] HTTP concurrency slot acquired", partNumber);
                
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

                        _logger.DebugFormat("MultipartDownloadManager: [Part {0}] Sending GetObject request with PartNumber={1}, IfMatchPresent={2}",
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

                        _logger.DebugFormat("MultipartDownloadManager: [Part {0}] Sending GetObject request with ByteRange={1}-{2}, IfMatchPresent={3}",
                            partNumber, startByte, endByte, !string.IsNullOrEmpty(_savedETag));
                    }
                    
                    response = await _s3Client.GetObjectAsync(getObjectRequest, cancellationToken).ConfigureAwait(false);
                    ownsResponse = true;  // We now own the response
                    
                    // Attach progress callback to response if provided
                    if (progressCallback != null)
                    {
                        response.WriteObjectProgressEvent += progressCallback;
                    }

                    _logger.DebugFormat("MultipartDownloadManager: [Part {0}] GetObject response received - ContentLength={1}",
                        partNumber, response.ContentLength);
                    
                    // SEP Part GET Step 5 / Ranged GET Step 7: Validate ContentRange matches request
                    ValidateContentRange(response, partNumber, objectSize);

                    _logger.DebugFormat("MultipartDownloadManager: [Part {0}] ContentRange validation passed", partNumber);
                    
                    // Validate ETag consistency for SEP compliance
                    if (!string.IsNullOrEmpty(_savedETag) && !string.Equals(_savedETag, response.ETag, StringComparison.OrdinalIgnoreCase))
                    {
                        _logger.Error(null, "MultipartDownloadManager: [Part {0}] ETag mismatch detected - object modified during download", partNumber);
                        throw new InvalidOperationException($"ETag mismatch detected for part {partNumber} - object may have been modified during download");
                    }

                    _logger.DebugFormat("MultipartDownloadManager: [Part {0}] ETag validation passed", partNumber);
                }
                finally
                {
                    _httpConcurrencySlots.Release();
                    _logger.DebugFormat("MultipartDownloadManager: [Part {0}] HTTP concurrency slot released (Available: {1}/{2})",
                        partNumber, _httpConcurrencySlots.CurrentCount, _config.ConcurrentServiceRequests);
                }

                _logger.DebugFormat("MultipartDownloadManager: [Part {0}] Processing part (handler will decide: stream or buffer)", partNumber);
                
                // Delegate data handling to the handler
                // IMPORTANT: Handler takes ownership of response and is responsible for disposing it in ALL cases:
                // - If streaming: StreamingDataSource takes ownership and disposes when consumer finishes reading
                // - If buffering: Handler disposes immediately after copying data to buffer
                // - On error: Handler disposes in its catch block before rethrowing
                await _dataHandler.ProcessPartAsync(partNumber, response, cancellationToken).ConfigureAwait(false);
                ownsResponse = false;  // Ownership transferred to handler

                _logger.DebugFormat("MultipartDownloadManager: [Part {0}] Processing completed successfully", partNumber);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "MultipartDownloadManager: [Part {0}] Download failed", partNumber);
                
                // Dispose response if we still own it (error occurred before handler took ownership)
                if (ownsResponse)
                    response?.Dispose();
                
                // Release capacity on failure
                _dataHandler.ReleaseCapacity();
                throw;
            }
        }


        private async Task<DownloadDiscoveryResult> DiscoverUsingPartStrategyAsync(CancellationToken cancellationToken)
        {
            // Check for cancellation before making any S3 calls
            cancellationToken.ThrowIfCancellationRequested();
            
            // SEP Part GET Step 1: "create a new GetObject request copying all fields in DownloadRequest. 
            // Set partNumber to 1."
            var firstPartRequest = CreateGetObjectRequest();
            firstPartRequest.PartNumber = 1;
            
            // Wait for both capacity types before making HTTP request (consistent with background parts)
            _logger.DebugFormat("MultipartDownloadManager: [Part 1 Discovery] Waiting for buffer capacity");
            await _dataHandler.WaitForCapacityAsync(cancellationToken).ConfigureAwait(false);

            _logger.DebugFormat("MultipartDownloadManager: [Part 1 Discovery] Waiting for HTTP concurrency slot");
            await _httpConcurrencySlots.WaitAsync(cancellationToken).ConfigureAwait(false);

            GetObjectResponse firstPartResponse = null;
            try
            {
                // SEP Part GET Step 2: "send the request and wait for the response in a non-blocking fashion"
                firstPartResponse = await _s3Client.GetObjectAsync(firstPartRequest, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                _httpConcurrencySlots.Release();
                _logger.DebugFormat("MultipartDownloadManager: [Part 1 Discovery] HTTP concurrency slot released");
            }
            
            if (firstPartResponse == null)
                throw new InvalidOperationException("Failed to retrieve object from S3");
            
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
            // Check for cancellation before making any S3 calls
            cancellationToken.ThrowIfCancellationRequested();
            
            // Get target part size for RANGE strategy (already set in config from request or default)
            var targetPartSize = _config.TargetPartSizeBytes;
            
            // SEP Ranged GET Step 1: "create a new GetObject request copying all fields in the original request. 
            // Set range value to bytes=0-{targetPartSizeBytes-1} to request the first part."
            var firstRangeRequest = CreateGetObjectRequest();
            firstRangeRequest.ByteRange = new ByteRange(0, targetPartSize - 1);
            
            // Wait for both capacity types before making HTTP request (consistent with background parts)
            _logger.DebugFormat("MultipartDownloadManager: [Part 1 Discovery] Waiting for buffer capacity");
            await _dataHandler.WaitForCapacityAsync(cancellationToken).ConfigureAwait(false);

            _logger.DebugFormat("MultipartDownloadManager: [Part 1 Discovery] Waiting for HTTP concurrency slot");
            await _httpConcurrencySlots.WaitAsync(cancellationToken).ConfigureAwait(false);

            GetObjectResponse firstRangeResponse = null;
            try
            {
                // SEP Ranged GET Step 2: "send the request and wait for the response in a non-blocking fashion"
                firstRangeResponse = await _s3Client.GetObjectAsync(firstRangeRequest, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                _httpConcurrencySlots.Release();
                _logger.DebugFormat("MultipartDownloadManager: [Part 1 Discovery] HTTP concurrency slot released");
            }
            
            // Defensive null check
            if (firstRangeResponse == null)
                throw new InvalidOperationException("Failed to retrieve object from S3");
            
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
            // Delegate to centralized ContentRange parsing utility
            return ContentRangeParser.Parse(contentRange);
        }

        internal long ExtractTotalSizeFromContentRange(string contentRange)
        {
            // Delegate to centralized ContentRange parsing utility
            return ContentRangeParser.GetTotalSize(contentRange);
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
        }

        /// <summary>
        /// Creates progress args with aggregated values for multipart downloads.
        /// </summary>
        private WriteObjectProgressArgs CreateProgressArgs(long incrementTransferred, long transferredBytes, bool completed = false)
        {
            string filePath = (_request as TransferUtilityDownloadRequest)?.FilePath;
            
            return new WriteObjectProgressArgs(
                _request.BucketName,
                _request.Key,
                filePath,
                _request.VersionId,
                incrementTransferred,
                transferredBytes,
                _totalObjectSize,
                completed
            );
        }

        /// <summary>
        /// Progress aggregation callback that combines progress across all concurrent part downloads.
        /// Uses thread-safe counter increment to handle concurrent updates.
        /// Detects completion naturally when transferred bytes reaches total size.
        /// Uses atomic flag to ensure completion event fires exactly once.
        /// </summary>
        private void DownloadPartProgressEventCallback(object sender, WriteObjectProgressArgs e)
        {
            long transferredBytes = Interlocked.Add(ref _totalTransferredBytes, e.IncrementTransferred);
            
            // Use atomic CompareExchange to ensure only first thread fires completion
            bool isComplete = false;
            if (transferredBytes >= _totalObjectSize)
            {
                // CompareExchange returns the original value before the exchange
                // If original value was 0 (false), we're the first thread and should fire completion
                int originalValue = Interlocked.CompareExchange(ref _completionEventFired, 1, 0);
                if (originalValue == 0)  // Was false, now set to true
                {
                    isComplete = true;
                }
            }
            
            // Create and fire aggregated progress event
            var aggregatedArgs = CreateProgressArgs(e.IncrementTransferred, transferredBytes, isComplete);
            _userProgressCallback?.Invoke(this, aggregatedArgs);
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
                    // Only dispose HTTP throttler if we own it
                    if (_ownsHttpThrottler)
                    {
                        _httpConcurrencySlots?.Dispose();
                    }
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
