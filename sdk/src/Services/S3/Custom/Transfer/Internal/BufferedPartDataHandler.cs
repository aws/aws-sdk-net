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
using System.Threading;
using System.Threading.Tasks;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Buffers downloaded parts in memory using ArrayPool and IPartBufferManager.
    /// Implements current streaming behavior for multipart downloads.
    /// </summary>
    internal class BufferedPartDataHandler : IPartDataHandler
    {
        private readonly IPartBufferManager _partBufferManager;
        private readonly BufferedDownloadConfiguration _config;
        
        public BufferedPartDataHandler(
            IPartBufferManager partBufferManager,
            BufferedDownloadConfiguration config)
        {
            _partBufferManager = partBufferManager ?? throw new ArgumentNullException(nameof(partBufferManager));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }
        
        public async Task ProcessPartAsync(
            int partNumber,
            GetObjectResponse response, 
            CancellationToken cancellationToken)
        {
            // Buffer the part from the response stream into memory
            var buffer = await BufferPartFromResponseAsync(
                partNumber, 
                response, 
                cancellationToken).ConfigureAwait(false);
                
            // Add the buffered part to the buffer manager
            await _partBufferManager.AddBufferAsync(buffer, cancellationToken).ConfigureAwait(false);
        }
        
        public Task WaitForCapacityAsync(CancellationToken cancellationToken)
        {
            return _partBufferManager.WaitForBufferSpaceAsync(cancellationToken);
        }
        
        public void ReleaseCapacity()
        {
            _partBufferManager.ReleaseBufferSpace();
        }
        
        public void OnDownloadComplete(Exception exception)
        {
            _partBufferManager.MarkDownloadComplete(exception);
        }
        
        public void Dispose()
        {
            // _partBufferManager is owned by caller, don't dispose
        }
        
        private async Task<StreamPartBuffer> BufferPartFromResponseAsync(
            int partNumber, 
            GetObjectResponse response, 
            CancellationToken cancellationToken)
        {
            StreamPartBuffer downloadedPart = null;
            byte[] partBuffer = null;
            
            try
            {
                // Use ContentLength to determine exact bytes to read and allocate
                long expectedBytes = response.ContentLength;
                int initialBufferSize = (int)expectedBytes;
                
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
    }
}
