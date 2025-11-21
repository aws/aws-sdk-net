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
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Buffers downloaded parts in memory using <see cref="ArrayPool{T}"/> and <see cref="IPartBufferManager"/>.
    /// Implements current streaming behavior for multipart downloads.
    /// </summary>
    internal class BufferedPartDataHandler : IPartDataHandler
    {
        private readonly IPartBufferManager _partBufferManager;
        private readonly BufferedDownloadConfiguration _config;

        private Logger Logger
        {
            get { return Logger.GetLogger(typeof(TransferUtility)); }
        }
        
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
            Logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Starting to buffer part from response stream - ContentLength={1}",
                partNumber, response.ContentLength);

            // Buffer the part from the response stream into memory
            var buffer = await BufferPartFromResponseAsync(
                partNumber, 
                response, 
                cancellationToken).ConfigureAwait(false);

            Logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Buffered {1} bytes into memory",
                partNumber, buffer.Length);
                
            // Add the buffered part to the buffer manager
            await _partBufferManager.AddBufferAsync(buffer, cancellationToken).ConfigureAwait(false);

            Logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Added to buffer manager",
                partNumber);
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
            
            try
            {
                // Use ContentLength to determine exact bytes to read and allocate
                long expectedBytes = response.ContentLength;
                int initialBufferSize = (int)expectedBytes;

                Logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Allocating buffer of size {1} bytes from ArrayPool",
                    partNumber, initialBufferSize);
                
                downloadedPart = StreamPartBuffer.Create(partNumber, initialBufferSize);
                
                // Get reference to the buffer for writing
                var partBuffer = downloadedPart.ArrayPoolBuffer;
                
                int totalRead = 0;
                int chunkCount = 0;
                
                // Read response stream into buffer in chunks based on ContentLength.
                // Example: For a 10MB part with 8KB BufferSize:
                //   - Loop 1: remainingBytes=10MB, readSize=8KB → reads 8KB at offset 0
                //   - Loop 2: remainingBytes=9.992MB, readSize=8KB → reads 8KB at offset 8KB
                //   - ...continues until totalRead reaches 10MB (1,280 iterations)
                while (totalRead < expectedBytes)
                {
                    // Calculate how many bytes we still need to read
                    int remainingBytes = (int)(expectedBytes - totalRead);
                    
                    // Read in chunks up to BufferSize, but never exceed remaining bytes
                    int readSize = Math.Min(remainingBytes, _config.BufferSize);
                    
                    // Read directly into buffer at current position
                    int bytesRead = await response.ResponseStream.ReadAsync(
                        partBuffer,
                        totalRead,
                        readSize,
                        cancellationToken).ConfigureAwait(false);
                    
                    if (bytesRead == 0) 
                    {
                        Logger.Error(null, "BufferedPartDataHandler: [Part {0}] Unexpected EOF - Expected {1} bytes, got {2} bytes",
                            partNumber, expectedBytes, totalRead);
                        // Unexpected EOF
                        break;
                    }
                    
                    totalRead += bytesRead;
                    chunkCount++;
                }

                Logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Read {1} bytes in {2} chunks from response stream",
                    partNumber, totalRead, chunkCount);

                // Set the length to reflect actual bytes read
                downloadedPart.SetLength(totalRead);

                if (totalRead != expectedBytes)
                {
                    Logger.Error(null, "BufferedPartDataHandler: [Part {0}] Size mismatch - Expected {1} bytes, read {2} bytes",
                        partNumber, expectedBytes, totalRead);
                }
                
                return downloadedPart;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "BufferedPartDataHandler: [Part {0}] Failed to buffer part from response stream", partNumber);
                // If something goes wrong, StreamPartBuffer.Dispose() will handle cleanup
                downloadedPart?.Dispose();
                throw;
            }
        }
    }
}
