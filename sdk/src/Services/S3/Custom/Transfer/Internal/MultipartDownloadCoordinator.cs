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
        
        private Exception _downloadException;
        private bool _disposed = false;
        private bool _discoveryCompleted = false;
        private readonly object _lockObject = new object();

        private string _savedETag;
        private int _discoveredPartCount;

        public MultipartDownloadCoordinator(IAmazonS3 s3Client, TransferUtilityOpenStreamRequest request, StreamConfiguration config)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _config = config ?? throw new ArgumentNullException(nameof(config));
            
            _config.Validate();
            _httpConcurrencySlots = new SemaphoreSlim(_config.ConcurrentServiceRequests);
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
                if (_discoveryCompleted)
                    throw new InvalidOperationException("Discovery has already been performed");
            }

            try
            {
                // Use strategy-specific discovery based on MultipartDownloadType
                var result = _request.MultipartDownloadType == MultipartDownloadType.PART
                    ? await DiscoverUsingPartStrategyAsync(cancellationToken).ConfigureAwait(false)
                    : await DiscoverUsingRangeStrategyAsync(cancellationToken).ConfigureAwait(false);
                
                lock (_lockObject)
                {
                    _discoveryCompleted = true;
                }
                
                return result;
            }
            catch (Exception ex)
            {
                lock (_lockObject)
                {
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
                // Part 1 is always buffered during discovery (optimization to avoid re-downloading)
                await partBufferManager.AddBufferAsync(discoveryResult.BufferedFirstPart, cancellationToken).ConfigureAwait(false);

                // Start concurrent downloads for remaining parts (Part 2 onwards)
                for (int partNum = 2; partNum <= discoveryResult.TotalParts; partNum++)
                {
                    var task = CreateDownloadTaskAsync(partNum, discoveryResult.ObjectSize, partBufferManager, internalCts.Token);
                    downloadTasks.Add(task);
                }

                // Wait for all downloads to complete
                await Task.WhenAll(downloadTasks).ConfigureAwait(false);

                // SEP Part GET Step 6 / Ranged GET Step 8:
                // "validate that the total number of part GET requests sent matches with the expected PartsCount"
                // Note: downloadTasks.Count + 1 accounts for Part 1 being buffered during discovery
                if (downloadTasks.Count + 1 != discoveryResult.TotalParts)
                {
                    throw new InvalidOperationException(
                        $"Request count mismatch. Expected {discoveryResult.TotalParts} parts, " +
                        $"but sent {downloadTasks.Count + 1} requests");
                }

                // Mark successful completion
                partBufferManager.MarkDownloadComplete(null);
            }
            catch (Exception ex)
            {
                lock (_lockObject)
                {
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
                        
                        // SEP Part GET Step 4: "The S3 Transfer Manager MUST also set IfMatch member 
                        // for each request to the Etag value saved from Step 3"
                        getObjectRequest.EtagToMatch = _savedETag;
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
                    }
                    
                    response = await _s3Client.GetObjectAsync(getObjectRequest, cancellationToken).ConfigureAwait(false);
                    
                    // SEP Part GET Step 5 / Ranged GET Step 7: Validate ContentRange matches request
                    ValidateContentRange(response, partNumber, objectSize);
                    
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
                
                // Optimization: Buffer Part 1 NOW to avoid re-downloading it later (SEP Step 4 will use this)
                var bufferedFirstPart = await BufferPartFromResponseAsync(1, firstPartResponse, cancellationToken).ConfigureAwait(false);
                
                // SEP Part GET Step 7 will use this response for creating DownloadResponse
                // Keep the response for metadata extraction (will be disposed by OpenStreamWithResponseCommand)
                return new DownloadDiscoveryResult
                {
                    TotalParts = firstPartResponse.PartsCount.Value,
                    ObjectSize = totalObjectSize,
                    SinglePartResponse = null,
                    InitialResponse = firstPartResponse,  // Keep for metadata
                    BufferedFirstPart = bufferedFirstPart  // Reuse this!
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
                    SinglePartResponse = firstPartResponse,
                    InitialResponse = firstPartResponse,  // Same as SinglePartResponse for consistency
                    BufferedFirstPart = null  // Not needed for single-part
                };
            }
        }

        private async Task<DownloadDiscoveryResult> DiscoverUsingRangeStrategyAsync(CancellationToken cancellationToken)
        {
            // Get target part size for RANGE strategy
            var targetPartSize = _request.IsSetPartSize() ? _request.PartSize : _config.TargetPartSizeBytes;
            
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
                    SinglePartResponse = firstRangeResponse,
                    InitialResponse = firstRangeResponse,  // Same as SinglePartResponse for consistency
                    BufferedFirstPart = null  // Not needed for single-part
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
                    SinglePartResponse = firstRangeResponse,
                    InitialResponse = firstRangeResponse,  // Same as SinglePartResponse for consistency
                    BufferedFirstPart = null  // Not needed for single-part
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
            
            // Optimization: Buffer Part 1 NOW to avoid re-downloading it later (SEP Step 6 will use this)
            var bufferedFirstPart = await BufferPartFromResponseAsync(1, firstRangeResponse, cancellationToken).ConfigureAwait(false);
            
            // SEP Ranged GET Step 5: "calculate number of requests required by performing integer division 
            // of total contentLength/targetPartSizeBytes. Save the number of ranged GET requests in a variable."
            _discoveredPartCount = (int)Math.Ceiling((double)totalContentLength / targetPartSize);
            
            // SEP Ranged GET Step 9 will use this response for creating DownloadResponse
            // Keep the response for metadata extraction (will be disposed by OpenStreamWithResponseCommand)
            return new DownloadDiscoveryResult
            {
                TotalParts = _discoveredPartCount,
                ObjectSize = totalContentLength,
                SinglePartResponse = null,
                InitialResponse = firstRangeResponse,  // Keep for metadata
                BufferedFirstPart = bufferedFirstPart  // Reuse first part
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
                    
                    // Read size is minimum of: remaining bytes needed, buffer space available, and configured buffer size
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
                // Only return partBuffer if ownership wasn't transferred
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

        // TODO add unit tests for these validations
        private void ValidateContentRange(GetObjectResponse response, int partNumber, long objectSize)
        {
            // SEP Part GET Step 5 / Ranged GET Step 7: 
            // "validate that ContentRange matches with the requested range" and
            // "the content range of the response aligns with the starting offset of the destination"
            
            if (_request.MultipartDownloadType == MultipartDownloadType.RANGE)
            {
                var (expectedStartByte, expectedEndByte) = CalculatePartRange(partNumber, objectSize);
                
                // Parse actual ContentRange from response
                // Format: "bytes {start}-{end}/{total}"
                var contentRange = response.ContentRange;
                if (string.IsNullOrEmpty(contentRange))
                {
                    throw new InvalidOperationException($"ContentRange header missing from part {partNumber} response");
                }
                
                var parts = contentRange.Replace("bytes ", "").Split('/');
                if (parts.Length != 2)
                {
                    throw new InvalidOperationException($"Invalid ContentRange format: {contentRange}");
                }
                
                var rangeParts = parts[0].Split('-');
                if (rangeParts.Length != 2 || 
                    !long.TryParse(rangeParts[0], out var actualStartByte) ||
                    !long.TryParse(rangeParts[1], out var actualEndByte))
                {
                    throw new InvalidOperationException($"Unable to parse ContentRange: {contentRange}");
                }
                
                // Validate range matches what we requested
                if (actualStartByte != expectedStartByte || actualEndByte != expectedEndByte)
                {
                    throw new InvalidOperationException(
                        $"ContentRange mismatch for part {partNumber}. " +
                        $"Expected: bytes {expectedStartByte}-{expectedEndByte}, " +
                        $"Actual: bytes {actualStartByte}-{actualEndByte}");
                }
            }
            // For PART strategy, we could validate but S3 manages the part boundaries,
            // so we trust the PartsCount and ContentRange from the initial response
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
