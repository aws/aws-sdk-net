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
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Coordinates multipart download orchestration including discovery, concurrent downloads,
    /// and progress reporting. Supports both PART and RANGE strategies following SEP specification.
    /// </summary>
    internal class MultipartDownloadCoordinator : IDownloadCoordinator
    {
        private readonly IAmazonS3 _s3Client;
        private readonly TransferUtilityOpenStreamRequest _request;
        private readonly StreamConfiguration _config;
        private readonly SemaphoreSlim _httpConcurrencySlots;
        
        private StreamState _currentState = StreamState.Initializing;
        private Exception _downloadException;
        private bool _disposed = false;
        private readonly object _lockObject = new object();

        // Strategy-specific state
        private string _savedETag;
        private int _discoveredPartCount;

        public event EventHandler<DownloadProgressEventArgs> ProgressChanged;

        public MultipartDownloadCoordinator(IAmazonS3 s3Client, TransferUtilityOpenStreamRequest request, StreamConfiguration config)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _config = config ?? throw new ArgumentNullException(nameof(config));
            
            _config.Validate();
            _httpConcurrencySlots = new SemaphoreSlim(_config.ConcurrentServiceRequests);
        }

        public StreamState CurrentState 
        { 
            get 
            { 
                lock (_lockObject)
                {
                    return _currentState;
                }
            }
        }

        public Exception DownloadException 
        { 
            get 
            { 
                lock (_lockObject)
                {
                    return _downloadException;
                }
            }
        }

        public async Task<DownloadDiscoveryResult> DiscoverDownloadStrategyAsync(CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            lock (_lockObject)
            {
                if (_currentState != StreamState.Initializing)
                    throw new InvalidOperationException($"Discovery can only be performed in Initializing state, current state: {_currentState}");
            }

            try
            {
                // Use strategy-specific discovery based on MultipartDownloadType
                var result = _request.MultipartDownloadType == MultipartDownloadType.PART
                    ? await DiscoverUsingPartStrategyAsync(cancellationToken).ConfigureAwait(false)
                    : await DiscoverUsingRangeStrategyAsync(cancellationToken).ConfigureAwait(false);
                
                return result;
            }
            catch (Exception ex)
            {
                lock (_lockObject)
                {
                    _currentState = StreamState.Error;
                    _downloadException = ex;
                }
                throw;
            }
        }

        public async Task StartDownloadsAsync(DownloadDiscoveryResult discoveryResult, IPartBufferManager partBufferManager, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (discoveryResult == null)
                throw new ArgumentNullException(nameof(discoveryResult));
            if (partBufferManager == null)
                throw new ArgumentNullException(nameof(partBufferManager));

            if (discoveryResult.IsSinglePart)
            {
                // Single part - no downloads needed, just state management
                return;
            }

            var downloadTasks = new List<Task>();
            var internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            try
            {
                // Start concurrent downloads for all parts with fresh HTTP requests
                // This ensures all parts (including Part 1) get fresh connections to prevent timeouts
                for (int partNum = 1; partNum <= discoveryResult.TotalParts; partNum++)
                {
                    var task = CreateDownloadTaskAsync(partNum, discoveryResult.ObjectSize, partBufferManager, internalCts.Token);
                    downloadTasks.Add(task);
                }

                // Wait for all downloads to complete
                await Task.WhenAll(downloadTasks).ConfigureAwait(false);

                // Mark successful completion
                partBufferManager.MarkDownloadComplete(null);
            }
            catch (Exception ex)
            {
                lock (_lockObject)
                {
                    _currentState = StreamState.Error;
                    _downloadException = ex;
                }
                
                partBufferManager.MarkDownloadComplete(ex);
                throw;
            }
            finally
            {
                internalCts.Dispose();
            }
        }



        private async Task CreateDownloadTaskAsync(int partNumber, long objectSize, IPartBufferManager partBufferManager, CancellationToken cancellationToken)
        {
            // Wait for buffer space before starting download
            await partBufferManager.WaitForBufferSpaceAsync(cancellationToken).ConfigureAwait(false);
            
            GetObjectResponse response = null;
            
            try
            {
                // Limit HTTP concurrency
                await _httpConcurrencySlots.WaitAsync(cancellationToken).ConfigureAwait(false);
                
                try
                {
                    // Create strategy-specific request
                    GetObjectRequest getObjectRequest;
                    
                    if (_request.MultipartDownloadType == MultipartDownloadType.PART)
                    {
                        // PART strategy: Use part number from original upload
                        getObjectRequest = CreateGetObjectRequest();
                        getObjectRequest.PartNumber = partNumber;
                    }
                    else
                    {
                        // RANGE strategy: Use calculated byte range
                        var (startByte, endByte) = CalculatePartRange(partNumber, objectSize);
                        
                        getObjectRequest = CreateGetObjectRequest();
                        getObjectRequest.ByteRange = new ByteRange(startByte, endByte);
                    }
                    
                    response = await _s3Client.GetObjectAsync(getObjectRequest, cancellationToken).ConfigureAwait(false);
                    
                    // Validate ETag consistency for SEP compliance
                    if (!string.IsNullOrEmpty(_savedETag) && !string.Equals(_savedETag, response.ETag, StringComparison.OrdinalIgnoreCase))
                    {
                        throw new InvalidOperationException($"ETag mismatch detected for part {partNumber} - object may have been modified during download");
                    }
                }
                finally
                {
                    _httpConcurrencySlots.Release();
                }
                
                // Always buffer the part
                var downloadedPart = await BufferPartFromResponseAsync(partNumber, response, cancellationToken).ConfigureAwait(false);
                
                // Add the downloaded part to the buffer manager
                await partBufferManager.AddBufferAsync(downloadedPart, cancellationToken).ConfigureAwait(false);
                
                // Report progress
                ReportProgress(partNumber, downloadedPart.ActualSize, objectSize);
            }
            catch (Exception)
            {
                // On any failure, the buffer space reservation is handled by the part buffer manager
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
            // For PART strategy, start with GetObject for partNumber=1 (no HEAD request needed)
            // This provides discovery data - we'll dispose the response immediately to avoid stale connections
            var firstPartRequest = CreateGetObjectRequest();
            firstPartRequest.PartNumber = 1;
            
            var firstPartResponse = await _s3Client.GetObjectAsync(firstPartRequest, cancellationToken).ConfigureAwait(false);
            
            try
            {
                // Save ETag for SEP compliance validation
                _savedETag = firstPartResponse.ETag;
                
                // Check if PartsCount is available (indicates multipart upload)
                if (firstPartResponse.PartsCount.HasValue && firstPartResponse.PartsCount.Value > 1)
                {
                    // SEP-compliant: Store actual part count from S3 response
                    _discoveredPartCount = firstPartResponse.PartsCount.Value;
                    
                    // SEP Step 3: Parse total content length from ContentRange header
                    // For example, "bytes 0-5242879/52428800" -> extract 52428800
                    var totalObjectSize = ExtractTotalSizeFromContentRange(firstPartResponse.ContentRange);
                    
                    // This is a multipart upload - extract metadata only, no caching
                    return new DownloadDiscoveryResult
                    {
                        TotalParts = firstPartResponse.PartsCount.Value,
                        ObjectSize = totalObjectSize,
                        SinglePartResponse = null,
                    };
                }
                else
                {
                    // SEP-compliant: Single part strategy
                    _discoveredPartCount = 1;
                    
                    // This is a single part upload - return the response for immediate use
                    return new DownloadDiscoveryResult
                    {
                        TotalParts = 1,
                        ObjectSize = firstPartResponse.ContentLength,
                        SinglePartResponse = firstPartResponse,
                    };
                }
            }
            finally
            {
                // For multipart uploads, dispose the response immediately to prevent stale connections
                // For single part uploads, the response is returned and will be disposed by the caller
                if (firstPartResponse.PartsCount.HasValue && firstPartResponse.PartsCount.Value > 1)
                {
                    firstPartResponse.Dispose();
                }
            }
        }

        private async Task<DownloadDiscoveryResult> DiscoverUsingRangeStrategyAsync(CancellationToken cancellationToken)
        {
            // Get target part size for RANGE strategy
            var targetPartSize = _request.IsSetPartSize() ? _request.PartSize : _config.TargetPartSizeBytes;
            
            // SEP Step 1: Create GetObject request with range=0-{targetPartSize-1} for first part
            var firstRangeRequest = CreateGetObjectRequest();
            firstRangeRequest.ByteRange = new ByteRange(0, targetPartSize - 1);
            
            // SEP Step 2: Send request and wait for response
            var firstRangeResponse = await _s3Client.GetObjectAsync(firstRangeRequest, cancellationToken).ConfigureAwait(false);
            
            // Save ETag for SEP Step 5 (IfMatch validation in subsequent requests)
            _savedETag = firstRangeResponse.ETag;
            
            // SEP Step 3: Parse total content length from ContentRange header
            // Check if ContentRange is null (object smaller than requested range)
            if (firstRangeResponse.ContentRange == null)
            {
                // No ContentRange means we got the entire small object
                _discoveredPartCount = 1;
                
                return new DownloadDiscoveryResult
                {
                    TotalParts = 1,
                    ObjectSize = firstRangeResponse.ContentLength,
                    SinglePartResponse = firstRangeResponse,
                };
            }
            
            // Parse total object size from ContentRange (e.g., "bytes 0-5242879/52428800" -> 52428800)
            var totalContentLength = ExtractTotalSizeFromContentRange(firstRangeResponse.ContentRange);
            
            // SEP Step 4: Compare parsed total with ContentLength to determine single vs multipart
            if (totalContentLength == firstRangeResponse.ContentLength)
            {
                // Single part: total size equals returned ContentLength
                // This request contains all of the data
                _discoveredPartCount = 1;
                
                return new DownloadDiscoveryResult
                {
                    TotalParts = 1,
                    ObjectSize = totalContentLength,
                    SinglePartResponse = firstRangeResponse,
                };
            }
            
            // Multipart: total size != ContentLength, more parts available
            // SEP Step 4 validation: Verify ContentLength matches targetPartSize
            if (firstRangeResponse.ContentLength != targetPartSize)
            {
                throw new InvalidOperationException(
                    $"Expected first part size {targetPartSize} bytes, but received {firstRangeResponse.ContentLength} bytes. " +
                    $"Total object size is {totalContentLength} bytes.");
            }
            
            // Dispose first part response since we'll download all parts fresh
            firstRangeResponse.Dispose();
            
            // SEP Step 5: Calculate number of ranged GET requests required
            _discoveredPartCount = (int)Math.Ceiling((double)totalContentLength / targetPartSize);
            
            return new DownloadDiscoveryResult
            {
                TotalParts = _discoveredPartCount,
                ObjectSize = totalContentLength,
                SinglePartResponse = null
            };
        }

        private GetObjectRequest CreateGetObjectRequest()
        {
            // TODO i need to add user agent information here somehow
            return RequestMapper.MapToGetObjectRequest(_request);
        }

        private async Task<StreamPartBuffer> BufferPartFromResponseAsync(int partNumber, GetObjectResponse response, CancellationToken cancellationToken)
        {
            StreamPartBuffer downloadedPart = null;
            byte[] partBuffer = null;
            
            try
            {
                // Use ContentLength to determine exact bytes to read
                long expectedBytes = response.ContentLength;
                
                // Start with initial buffer size
                int initialBufferSize;
                if (_request.MultipartDownloadType == MultipartDownloadType.PART)
                {
                    // For PART strategy, start with reasonable size and expand as needed
                    initialBufferSize = (int)Math.Min(expectedBytes, _config.TargetPartSizeBytes);
                }
                else
                {
                    // For RANGE strategy, use the exact Content-Length
                    initialBufferSize = (int)expectedBytes;
                }
                
                partBuffer = ArrayPool<byte>.Shared.Rent(initialBufferSize);
                
                int totalRead = 0;
                
                // Read response stream into buffer based on ContentLength
                while (totalRead < expectedBytes)
                {
                    // Calculate how many bytes we still need to read
                    int remainingBytes = (int)(expectedBytes - totalRead);
                    int bufferSpace = partBuffer.Length - totalRead;
                    
                    // Expand buffer if needed BEFORE reading
                    if (bufferSpace == 0)
                    {
                        partBuffer = ExpandPartBuffer(partBuffer, totalRead);
                        bufferSpace = partBuffer.Length - totalRead;
                    }
                    
                    // Read size is minimum of: remaining bytes needed, buffer space available, and optimal chunk size
                    int readSize = Math.Min(Math.Min(remainingBytes, bufferSpace), _config.BufferSize);
                    
                    // Read directly into final destination at correct offset
                    int bytesRead = await response.ResponseStream.ReadAsync(
                        partBuffer,     // Destination: final ArrayPool buffer
                        totalRead,      // Offset: current position in buffer
                        readSize,       // Count: optimal chunk size
                        cancellationToken).ConfigureAwait(false);
                    
                    if (bytesRead == 0) 
                    {
                        // Unexpected EOF
                        break;
                    }
                    
                    totalRead += bytesRead;
                }

                // Create ArrayPool-based StreamPartBuffer (no copying!)
                downloadedPart = StreamPartBuffer.FromArrayPoolBuffer(
                    partNumber,
                    partBuffer,     // Transfer ownership to StreamPartBuffer
                    totalRead       // Actual data length
                );

                partBuffer = null; // Clear reference to prevent return in finally
                return downloadedPart;
            }
            finally
            {
                // OPTIMIZATION: Only return partBuffer if ownership wasn't transferred
                if (partBuffer != null)
                    ArrayPool<byte>.Shared.Return(partBuffer);
            }
        }

        private byte[] ExpandPartBuffer(byte[] currentBuffer, int validDataLength)
        {
            var newSize = Math.Max(currentBuffer.Length * 2, validDataLength + (int)_config.TargetPartSizeBytes);
            var expandedBuffer = ArrayPool<byte>.Shared.Rent(newSize);
            
            // Single copy of valid data to expanded buffer
            Buffer.BlockCopy(currentBuffer, 0, expandedBuffer, 0, validDataLength);
            
            // Return old buffer to pool
            ArrayPool<byte>.Shared.Return(currentBuffer);
            
            return expandedBuffer;
        }

        private int CalculatePartCount(long objectSize)
        {
            // SEP-compliant: Always return the discovered part count determined during strategy discovery
            // This ensures consistency with SEP specification:
            // - PART strategy: Uses PartsCount from S3 response (SEP Step 3)  
            // - RANGE strategy: Uses calculated count based on object size and target part size (SEP Step 5)
            return _discoveredPartCount;
        }

        private (long startByte, long endByte) CalculatePartRange(int partNumber, long objectSize)
        {
            var targetPartSize = _request.IsSetPartSize() ? _request.PartSize : _config.TargetPartSizeBytes;
            
            var startByte = (partNumber - 1) * targetPartSize;
            var endByte = Math.Min(startByte + targetPartSize - 1, objectSize - 1);
            return (startByte, endByte);
        }
        
        private long ExtractTotalSizeFromContentRange(string contentRange)
        {
            if (string.IsNullOrEmpty(contentRange))
                throw new InvalidOperationException("Content-Range header is missing from range request response");
                
            // Format: "bytes 0-{end}/{total-size}" or "bytes 0-{end}/*"
            var parts = contentRange.Split('/');
            if (parts.Length == 2 && parts[1] != "*")
            {
                if (long.TryParse(parts[1], out var totalSize))
                {
                    return totalSize;
                }
            }
            
            throw new InvalidOperationException($"Unable to parse Content-Range header: {contentRange}");
        }

        private void ReportProgress(int completedPart, long partBytes, long totalBytes)
        {
            var targetPartSize = _request.IsSetPartSize() ? _request.PartSize : _config.TargetPartSizeBytes;
            
            ProgressChanged?.Invoke(this, new DownloadProgressEventArgs
            {
                CompletedParts = completedPart,
                TotalParts = _discoveredPartCount, // SEP-compliant: Use stored part count
                BytesDownloaded = completedPart * targetPartSize, // Approximation
                TotalBytes = totalBytes
            });
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(MultipartDownloadCoordinator));
        }

        #region Dispose Pattern

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    _httpConcurrencySlots?.Dispose();
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
