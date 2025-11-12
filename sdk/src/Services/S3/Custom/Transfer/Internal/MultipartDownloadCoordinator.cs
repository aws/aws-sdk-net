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
using Amazon.Runtime.Internal.Util;

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

        private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

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
                return _request.MultipartDownloadType == MultipartDownloadType.PART
                    ? await DiscoverUsingPartStrategyAsync(cancellationToken).ConfigureAwait(false)
                    : await DiscoverUsingRangeStrategyAsync(cancellationToken).ConfigureAwait(false);
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
                lock (_lockObject)
                {
                    _currentState = StreamState.DownloadsComplete;
                }
                return;
            }

            var downloadTasks = new List<Task>();
            var internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            try
            {
                // Check if we have a cached first part response to avoid re-downloading part 1
                if (discoveryResult.CachedFirstPartResponse != null)
                {
                    // Process cached first part response
                    var cachedPartTask = ProcessCachedFirstPartAsync(discoveryResult.CachedFirstPartResponse, partBufferManager, internalCts.Token);
                    downloadTasks.Add(cachedPartTask);
                    
                    // Start concurrent downloads for remaining parts (2 onwards)
                    for (int partNum = 2; partNum <= discoveryResult.TotalParts; partNum++)
                    {
                        var task = CreateDownloadTaskAsync(partNum, discoveryResult.ObjectSize, partBufferManager, internalCts.Token);
                        downloadTasks.Add(task);
                    }
                }
                else
                {
                    // No cached response - start concurrent downloads for all parts
                    for (int partNum = 1; partNum <= discoveryResult.TotalParts; partNum++)
                    {
                        var task = CreateDownloadTaskAsync(partNum, discoveryResult.ObjectSize, partBufferManager, internalCts.Token);
                        downloadTasks.Add(task);
                    }
                }

                // Wait for all downloads to complete
                await Task.WhenAll(downloadTasks).ConfigureAwait(false);

                // Mark successful completion
                lock (_lockObject)
                {
                    _currentState = StreamState.DownloadsComplete;
                }
                
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

        private StreamDataSource CreateResponseStreamDataSource(int partNumber, GetObjectResponse response, long objectSize)
        {
            return new StreamDataSource(partNumber, async (buffer, offset, count, ct) =>
            {
                // Extracted lambda logic (same as current implementation)
                int totalRead = 0;
                while (totalRead < count && totalRead < response.ContentLength)
                {
                    int remainingInBuffer = count - totalRead;
                    int remainingInResponse = (int)(response.ContentLength - totalRead);
                    int maxToRead = Math.Min(remainingInBuffer, remainingInResponse);
                    
                    int bytesRead = await response.ResponseStream.ReadAsync(
                        buffer, offset + totalRead, maxToRead, ct).ConfigureAwait(false);
                    
                    if (bytesRead == 0) break;
                    totalRead += bytesRead;
                }
                
                ReportProgress(partNumber, totalRead, objectSize);
                return totalRead;
            });
        }

        private async Task ProcessCachedFirstPartAsync(GetObjectResponse cachedResponse, IPartBufferManager partBufferManager, CancellationToken cancellationToken)
        {
            try
            {
                var streamSource = CreateResponseStreamDataSource(1, cachedResponse, cachedResponse.ContentLength);
                await partBufferManager.AddDataSourceAsync(streamSource, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                cachedResponse?.Dispose();
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
                
                // Try direct streaming first if this is the expected part
                if (partNumber == partBufferManager.NextExpectedPartNumber)
                {
                    var streamSource = CreateResponseStreamDataSource(partNumber, response, objectSize);
                    await partBufferManager.AddDataSourceAsync(streamSource, cancellationToken).ConfigureAwait(false);
                    
                    // Direct streaming registered successfully - return early
                    return;
                }
                
                // Fallback to buffering approach
                var downloadedPart = await BufferPartFromResponseAsync(partNumber, response, cancellationToken).ConfigureAwait(false);
                
                // Add the downloaded part to the buffer manager (smart signaling handled internally)
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
                response?.Dispose();
            }
        }


        private async Task<DownloadDiscoveryResult> DiscoverUsingPartStrategyAsync(CancellationToken cancellationToken)
        {
            try
            {
                // For PART strategy, start with GetObject for partNumber=1 (no HEAD request needed)
                // This provides both discovery data and content in a single request
                var firstPartRequest = CreateGetObjectRequest();
                firstPartRequest.PartNumber = 1;
                
                var firstPartResponse = await _s3Client.GetObjectAsync(firstPartRequest, cancellationToken).ConfigureAwait(false);
                
                // Save ETag for SEP compliance validation
                _savedETag = firstPartResponse.ETag;
                
                // Check if PartsCount is available (indicates multipart upload)
                if (firstPartResponse.PartsCount.HasValue && firstPartResponse.PartsCount.Value > 1)
                {
                    // SEP-compliant: Store actual part count from S3 response
                    _discoveredPartCount = firstPartResponse.PartsCount.Value;
                    
                    // This is a multipart upload - cache the first part response to avoid re-requesting it
                    return new DownloadDiscoveryResult
                    {
                        TotalParts = firstPartResponse.PartsCount.Value,
                        ObjectSize = firstPartResponse.ContentLength,
                        SinglePartResponse = null,
                        CachedFirstPartResponse = firstPartResponse // Cache for reuse during downloads
                    };
                }
                else
                {
                        // SEP-compliant: Single part strategy
                        _discoveredPartCount = 1;
                        
                        // This is a single part upload
                        return new DownloadDiscoveryResult
                        {
                            TotalParts = 1,
                            ObjectSize = firstPartResponse.ContentLength,
                            SinglePartResponse = firstPartResponse,
                            CachedFirstPartResponse = null
                        };
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Failed to discover download strategy using PART method for {0}/{1}", _request.BucketName, _request.Key);
                throw;
            }
        }

        private async Task<DownloadDiscoveryResult> DiscoverUsingRangeStrategyAsync(CancellationToken cancellationToken)
        {
            try
            {
                // Get target part size for RANGE strategy
                var targetPartSize = _request.IsSetPartSize() ? _request.PartSize : _config.TargetPartSizeBytes;
                
                // For RANGE strategy, start with GetObject for ByteRange(0, targetPartSize-1) (no HEAD request needed)
                // This provides both discovery data and content in a single request
                var firstRangeRequest = CreateGetObjectRequest();
                firstRangeRequest.ByteRange = new ByteRange(0, targetPartSize - 1);
                
                var firstRangeResponse = await _s3Client.GetObjectAsync(firstRangeRequest, cancellationToken).ConfigureAwait(false);
                
                // Save ETag for SEP compliance validation
                _savedETag = firstRangeResponse.ETag;
                
                var objectSize = firstRangeResponse.ContentLength;
                
                // Check if we got the entire object in one request (small object case)
                if (firstRangeResponse.ContentRange == null || objectSize <= targetPartSize)
                {
                    // SEP-compliant: Single part strategy
                    _discoveredPartCount = 1;
                    
                    // This is a small object that fits in one part
                    return new DownloadDiscoveryResult
                    {
                        TotalParts = 1,
                        ObjectSize = objectSize,
                        SinglePartResponse = firstRangeResponse,
                        CachedFirstPartResponse = null
                    };
                }
                
                // Parse the Content-Range header to get the total object size
                // Format: "bytes 0-{end}/{total-size}" or "bytes 0-{end}/*"
                var contentRange = firstRangeResponse.ContentRange;
                var totalObjectSize = ExtractTotalSizeFromContentRange(contentRange);
                
                firstRangeResponse.Dispose();
                
                // SEP-compliant: Calculate and store part count based on object size and target part size
                _discoveredPartCount = (int)Math.Ceiling((double)totalObjectSize / targetPartSize);
                
                return new DownloadDiscoveryResult
                {
                    TotalParts = _discoveredPartCount,
                    ObjectSize = totalObjectSize,
                    SinglePartResponse = null,
                    CachedFirstPartResponse = null
                };
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Failed to discover download strategy using RANGE method for {0}/{1}", _request.BucketName, _request.Key);
                throw;
            }
        }

        private GetObjectRequest CreateGetObjectRequest()
        {
            var request = new GetObjectRequest
            {
                BucketName = _request.BucketName,
                Key = _request.Key,
                VersionId = _request.VersionId,
                ServerSideEncryptionCustomerMethod = _request.ServerSideEncryptionCustomerMethod,
                ServerSideEncryptionCustomerProvidedKey = _request.ServerSideEncryptionCustomerProvidedKey,
                ServerSideEncryptionCustomerProvidedKeyMD5 = _request.ServerSideEncryptionCustomerProvidedKeyMD5
            };
            
            return request;
        }

        private async Task<StreamPartBuffer> DownloadPartAsync(int partNumber, long objectSize, CancellationToken cancellationToken)
        {
            GetObjectResponse response = null;
            StreamPartBuffer downloadedPart = null;
            byte[] partBuffer = null;
            
            try
            {
                // Create strategy-specific request
                GetObjectRequest getObjectRequest;
                int expectedPartSize;
                
                if (_request.MultipartDownloadType == MultipartDownloadType.PART)
                {
                    // PART strategy: Use part number from original upload
                    getObjectRequest = CreateGetObjectRequest();
                    getObjectRequest.PartNumber = partNumber;
                    
                    // For PART strategy, we don't know the exact size ahead of time
                    expectedPartSize = (int)_config.BufferSize;
                }
                else
                {
                    // RANGE strategy: Use calculated byte range
                    var (startByte, endByte) = CalculatePartRange(partNumber, objectSize);
                    expectedPartSize = (int)(endByte - startByte + 1);
                    
                    getObjectRequest = CreateGetObjectRequest();
                    getObjectRequest.ByteRange = new ByteRange(startByte, endByte);
                }
                
                partBuffer = ArrayPool<byte>.Shared.Rent(expectedPartSize);
                response = await _s3Client.GetObjectAsync(getObjectRequest, cancellationToken).ConfigureAwait(false);
                
                // Validate ETag consistency for SEP compliance
                if (!string.IsNullOrEmpty(_savedETag) && !string.Equals(_savedETag, response.ETag, StringComparison.OrdinalIgnoreCase))
                {
                    throw new InvalidOperationException($"ETag mismatch detected for part {partNumber} - object may have been modified during download");
                }

                int totalRead = 0;
                
                // Read directly into final buffer - NO INTERMEDIATE BUFFER!
                while (totalRead < partBuffer.Length)
                {
                    // Calculate optimal read size for this iteration
                    int remainingSpace = partBuffer.Length - totalRead;
                    int readSize = Math.Min(remainingSpace, _config.BufferSize);
                    
                    // Read directly into final destination at correct offset
                    int bytesRead = await response.ResponseStream.ReadAsync(
                        partBuffer,     // Destination: final ArrayPool buffer
                        totalRead,      // Offset: current position in buffer
                        readSize,       // Count: optimal chunk size
                        cancellationToken).ConfigureAwait(false);
                    
                    if (bytesRead == 0) break; // End of stream
                    totalRead += bytesRead;
                    
                    // Handle buffer expansion if part is larger than expected
                    if (totalRead == partBuffer.Length && await HasMoreDataAsync(response.ResponseStream, cancellationToken).ConfigureAwait(false))
                    {
                        partBuffer = ExpandPartBuffer(partBuffer, totalRead);
                    }
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
            catch (Exception exception)
            {
                // Set exception for coordination
                lock (_lockObject)
                {
                    if (_downloadException == null) // Only set first exception
                    {
                        _downloadException = exception;
                        _currentState = StreamState.Error;
                    }
                }
                
                throw;
            }
            finally
            {
                response?.Dispose();
                
                // OPTIMIZATION: Only return partBuffer if ownership wasn't transferred
                if (partBuffer != null)
                    ArrayPool<byte>.Shared.Return(partBuffer);
            }
        }

        private async Task<StreamPartBuffer> BufferPartFromResponseAsync(int partNumber, GetObjectResponse response, CancellationToken cancellationToken)
        {
            StreamPartBuffer downloadedPart = null;
            byte[] partBuffer = null;
            
            try
            {
                // Estimate buffer size based on strategy
                int expectedPartSize;
                if (_request.MultipartDownloadType == MultipartDownloadType.PART)
                {
                    // For PART strategy, we don't know the exact size ahead of time
                    // TODO come back to this maybe we should just use 8MB here?
                    expectedPartSize = (int)_config.BufferSize;
                }
                else
                {
                    // For RANGE strategy, use the Content-Length from response
                    expectedPartSize = (int)response.ContentLength;
                }
                
                partBuffer = ArrayPool<byte>.Shared.Rent(expectedPartSize);
                
                int totalRead = 0;
                
                // Read response stream into buffer - NO INTERMEDIATE BUFFER!
                while (totalRead < partBuffer.Length)
                {
                    // Calculate optimal read size for this iteration
                    int remainingSpace = partBuffer.Length - totalRead;
                    int readSize = Math.Min(remainingSpace, _config.BufferSize);
                    
                    // Read directly into final destination at correct offset
                    int bytesRead = await response.ResponseStream.ReadAsync(
                        partBuffer,     // Destination: final ArrayPool buffer
                        totalRead,      // Offset: current position in buffer
                        readSize,       // Count: optimal chunk size
                        cancellationToken).ConfigureAwait(false);
                    
                    if (bytesRead == 0) break; // End of stream
                    totalRead += bytesRead;
                    
                    // Handle buffer expansion if part is larger than expected
                    if (totalRead == partBuffer.Length && await HasMoreDataAsync(response.ResponseStream, cancellationToken).ConfigureAwait(false))
                    {
                        partBuffer = ExpandPartBuffer(partBuffer, totalRead);
                    }
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

        private async Task<bool> HasMoreDataAsync(Stream stream, CancellationToken cancellationToken)
        {
            // Simple peek check - try to read one more byte
            var tempBuffer = new byte[1];
            var result = await stream.ReadAsync(tempBuffer, 0, 1, cancellationToken).ConfigureAwait(false);
            return result > 0;
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
