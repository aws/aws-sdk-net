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
using System.IO;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Handles multipart download data with intelligent stream-vs-buffer decision making.
    /// Optimizes for sequential part arrival by streaming directly to consumer when possible,
    /// while buffering out-of-order parts into memory using <see cref="ArrayPool{T}"/>.
    /// </summary>
    /// <remarks>
    /// <para><strong>Optimization Strategy:</strong></para>
    /// <list type="bullet">
    /// <item>Parts arriving in expected order (matching NextExpectedPartNumber) stream directly to consumer</item>
    /// <item>Out-of-order parts buffer into ArrayPool memory for later sequential consumption</item>
    /// <item>Best case: All parts in order → zero buffering → pure streaming</item>
    /// <item>Worst case: All parts out of order → full buffering (original behavior)</item>
    /// </list>
    /// 
    /// 
    /// <para><strong>Response Ownership:</strong></para>
    /// <list type="bullet">
    /// <item>Streaming: StreamingDataSource takes ownership and disposes after reading</item>
    /// <item>Buffering: Handler disposes response immediately after buffering completes</item>
    /// </list>
    /// </remarks>
    internal class BufferedPartDataHandler : IPartDataHandler
    {
        private readonly IPartBufferManager _partBufferManager;
        private readonly BufferedDownloadConfiguration _config;

        private readonly Logger _logger = Logger.GetLogger(typeof(BufferedPartDataHandler));
        
        /// <summary>
        /// Initializes a new instance of the <see cref="BufferedPartDataHandler"/> class.
        /// </summary>
        /// <param name="partBufferManager">The <see cref="IPartBufferManager"/> for managing part buffers.</param>
        /// <param name="config">The <see cref="BufferedDownloadConfiguration"/> with buffering settings.</param>
        /// <exception cref="ArgumentNullException">Thrown when any required parameter is null.</exception>
        public BufferedPartDataHandler(
            IPartBufferManager partBufferManager,
            BufferedDownloadConfiguration config)
        {
            _partBufferManager = partBufferManager ?? throw new ArgumentNullException(nameof(partBufferManager));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }
        
        public Task PrepareAsync(DownloadDiscoveryResult discoveryResult, CancellationToken cancellationToken)
        {
            // No preparation needed for buffered handler - buffers are created on demand
            return Task.CompletedTask;
        }
        
        /// <inheritdoc/>
        /// <remarks>
        /// <para>
        /// Intelligently chooses between streaming and buffering based on part arrival order:
        /// </para>
        /// <list type="bullet">
        /// <item>If partNumber matches NextExpectedPartNumber: Stream directly (no buffering)</item>
        /// <item>Otherwise: Buffer into memory for later sequential consumption</item>
        /// </list>
        /// <para><strong>Response Ownership:</strong></para>
        /// <para>
        /// This method takes ownership of the response and is responsible for disposing it in ALL cases,
        /// including error scenarios. Callers must NOT dispose the response after calling this method.
        /// </para>
        /// </remarks>
        public async Task ProcessPartAsync(
            int partNumber,
            GetObjectResponse response, 
            CancellationToken cancellationToken)
        {
            if (partNumber == _partBufferManager.NextExpectedPartNumber)
            {
                await ProcessStreamingPartAsync(partNumber, response, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                await ProcessBufferedPartAsync(partNumber, response, cancellationToken).ConfigureAwait(false);
            }
        }
        
        /// <summary>
        /// Processes a part that arrives in expected order by streaming it directly without buffering.
        /// Takes ownership of the response and transfers it to the StreamingDataSource.
        /// </summary>
        /// <param name="partNumber">The part number being processed.</param>
        /// <param name="response">The GetObjectResponse containing the part data. Ownership is transferred to StreamingDataSource.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <remarks>
        /// This method is called when the part arrives in the expected sequential order, allowing
        /// for optimal zero-copy streaming directly to the consumer without buffering into memory.
        /// 
        /// OWNERSHIP TRANSFER:
        /// 1. Response is passed to StreamingDataSource constructor (StreamingDataSource takes ownership)
        /// 2. StreamingDataSource is added to buffer manager (buffer manager takes ownership)
        /// 3. After successful AddBufferAsync, we null out our reference to mark ownership transfer
        /// 4. Buffer manager will dispose StreamingDataSource (which disposes response) during cleanup
        /// 
        /// ERROR HANDLING:
        /// - If StreamingDataSource constructor fails: We dispose the response (still our responsibility)
        /// - If constructor succeeds but AddBufferAsync fails: StreamingDataSource.Dispose() handles the response
        /// - If AddBufferAsync succeeds: Buffer manager owns everything and will clean up
        /// </remarks>
        private async Task ProcessStreamingPartAsync(
            int partNumber,
            GetObjectResponse response, 
            CancellationToken cancellationToken)
        {
            _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Matches NextExpectedPartNumber - streaming directly without buffering",
                partNumber);

            StreamingDataSource streamingDataSource = null;
            var ownsResponse = true; // Track if we still own the response
            
            try
            {
                // Create a StreamingDataSource that will stream directly from the response
                // If successful, StreamingDataSource takes ownership of the response and will dispose it
                streamingDataSource = new StreamingDataSource(partNumber, response);
                ownsResponse = false; // Ownership transferred to StreamingDataSource

                // Add the streaming data source to the buffer manager
                // After this succeeds, the buffer manager owns the data source
                _partBufferManager.AddBuffer(streamingDataSource);
                
                // Mark ownership transfer by nulling our reference
                // If ReleaseBufferSpace() throws, we no longer own the data source, so we won't dispose it
                streamingDataSource = null;

                // Release capacity immediately since we're not holding anything in memory
                _partBufferManager.ReleaseBufferSpace();

                _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] StreamingDataSource added and capacity released",
                    partNumber);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "BufferedPartDataHandler: [Part {0}] Failed to process streaming part", partNumber);
                
                // Dispose response if we still own it (constructor failed before taking ownership)
                if (ownsResponse)
                    response?.Dispose();
                
                // Dispose StreamingDataSource if we created it but buffer manager doesn't own it yet
                // If null, the buffer manager owns it and will handle cleanup
                streamingDataSource?.Dispose();
                
                throw;
            }
        }
        
        /// <summary>
        /// Processes a part that arrives out of order by buffering it into memory.
        /// Takes ownership of the response and disposes it after buffering completes.
        /// </summary>
        /// <param name="partNumber">The part number being processed.</param>
        /// <param name="response">The GetObjectResponse containing the part data. This method owns and disposes it.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <remarks>
        /// This method is called when the part arrives out of the expected sequential order.
        /// The part data is buffered into ArrayPool memory for later sequential consumption.
        /// 
        /// OWNERSHIP:
        /// - Response is read and buffered into StreamPartBuffer
        /// - Response is disposed immediately after buffering (no longer needed)
        /// - StreamPartBuffer is added to buffer manager (buffer manager takes ownership)
        /// - Buffer manager will dispose StreamPartBuffer during cleanup
        /// 
        /// ERROR HANDLING:
        /// - Always dispose response in catch block since we own it throughout this method
        /// - BufferPartFromResponseAsync handles its own cleanup of StreamPartBuffer on error
        /// </remarks>
        private async Task ProcessBufferedPartAsync(
            int partNumber,
            GetObjectResponse response, 
            CancellationToken cancellationToken)
        {
            _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Out of order (NextExpected={1}) - buffering to memory",
                partNumber, _partBufferManager.NextExpectedPartNumber);

            try
            {
                // Buffer the part from the response stream into memory
                var buffer = await BufferPartFromResponseAsync(
                    partNumber, 
                    response, 
                    cancellationToken).ConfigureAwait(false);

                // Response has been fully read and buffered - dispose it now
                response?.Dispose();

                _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Buffered {1} bytes into memory",
                    partNumber, buffer.Length);
                    
                // Add the buffered part to the buffer manager
                _partBufferManager.AddBuffer(buffer);

                _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Added to buffer manager (capacity will be released after consumption)",
                    partNumber);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "BufferedPartDataHandler: [Part {0}] Failed to process buffered part", partNumber);
                
                // We own the response throughout this method, so dispose it on error
                response?.Dispose();
                
                throw;
            }
        }
        
        /// <inheritdoc/>
        public Task WaitForCapacityAsync(CancellationToken cancellationToken)
        {
            return _partBufferManager.WaitForBufferSpaceAsync(cancellationToken);
        }
        
        /// <inheritdoc/>
        public void ReleaseCapacity()
        {
            _partBufferManager.ReleaseBufferSpace();
        }
        
        /// <inheritdoc/>
        public void OnDownloadComplete(Exception exception)
        {
            _partBufferManager.MarkDownloadComplete(exception);
        }
        
        /// <inheritdoc/>
        public void Dispose()
        {
            // _partBufferManager is owned by caller, don't dispose
        }
        
        /// <summary>
        /// Buffers a part from the GetObjectResponse stream into ArrayPool memory.
        /// Used when a part arrives out of order and cannot be streamed directly.
        /// </summary>
        /// <param name="partNumber">The part number being buffered.</param>
        /// <param name="response">The GetObjectResponse containing the part data stream.</param>
        /// <param name="cancellationToken">Cancellation token for the operation.</param>
        /// <returns>A <see cref="StreamPartBuffer"/> containing the buffered part data.</returns>
        /// <exception cref="Exception">Thrown when buffering fails. The StreamPartBuffer will be disposed automatically.</exception>
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

                _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Allocating buffer of size {1} bytes from ArrayPool",
                    partNumber, initialBufferSize);
                
                downloadedPart = StreamPartBuffer.Create(partNumber, initialBufferSize);
                
                // Get reference to the buffer for writing
                var partBuffer = downloadedPart.ArrayPoolBuffer;
                
                // Create a MemoryStream wrapper around the pooled buffer
                // writable: true allows WriteResponseStreamAsync to write to it
                // The MemoryStream starts at position 0 and can grow up to initialBufferSize
                using (var memoryStream = new MemoryStream(partBuffer, 0, initialBufferSize, writable: true))
                {
                    _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Reading response stream into buffer",
                        partNumber);

                    // Use GetObjectResponse's stream copy logic which includes:
                    // - Progress tracking with events
                    // - Size validation (ContentLength vs bytes read)
                    // - Buffered reading with proper chunk sizes
                    await response.WriteResponseStreamAsync(
                        memoryStream,
                        null, // destination identifier (not needed for memory stream)
                        _config.BufferSize,
                        cancellationToken,
                        validateSize: true)
                        .ConfigureAwait(false);
                    
                    int totalRead = (int)memoryStream.Position;
                    
                    _logger.DebugFormat("BufferedPartDataHandler: [Part {0}] Read {1} bytes from response stream",
                        partNumber, totalRead);

                    // Set the length to reflect actual bytes read
                    downloadedPart.SetLength(totalRead);

                    if (totalRead != expectedBytes)
                    {
                        _logger.Error(null, "BufferedPartDataHandler: [Part {0}] Size mismatch - Expected {1} bytes, read {2} bytes",
                            partNumber, expectedBytes, totalRead);
                    }
                }
                
                return downloadedPart;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "BufferedPartDataHandler: [Part {0}] Failed to buffer part from response stream", partNumber);
                // If something goes wrong, StreamPartBuffer.Dispose() will handle cleanup
                downloadedPart?.Dispose();
                throw;
            }
        }
    }
}
