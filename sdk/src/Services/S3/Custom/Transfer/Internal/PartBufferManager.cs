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
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Simplified part buffer manager using unified data source pattern.
    /// Treats both direct streaming and buffered parts identically through IPartDataSource abstraction.
    /// Dramatically reduces complexity while preserving all performance optimizations.
    /// </summary>
    internal class PartBufferManager : IPartBufferManager
    {
        private readonly ConcurrentDictionary<int, IPartDataSource> _partDataSources;
        private readonly SemaphoreSlim _bufferSpaceAvailable;
        private readonly AutoResetEvent _partAvailable;
        private readonly object _lockObject = new object();
        
        private int _nextExpectedPartNumber = 1;
        private bool _downloadComplete = false;
        private Exception _downloadException;
        private bool _disposed = false;

         private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

        public PartBufferManager(StreamConfiguration config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
                
            config.Validate();
            
            _partDataSources = new ConcurrentDictionary<int, IPartDataSource>();
            _bufferSpaceAvailable = new SemaphoreSlim(config.MaxInMemoryParts);
            _partAvailable = new AutoResetEvent(false);
        }

        public int NextExpectedPartNumber 
        { 
            get 
            { 
                lock (_lockObject)
                {
                    return _nextExpectedPartNumber;
                }
            }
        }

        public async Task WaitForBufferSpaceAsync(CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            await _bufferSpaceAvailable.WaitAsync(cancellationToken).ConfigureAwait(false);
        }

        public Task AddDataSourceAsync(IPartDataSource dataSource, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (dataSource == null)
                throw new ArgumentNullException(nameof(dataSource));

            Logger.DebugFormat("[DEBUG] PartBufferManager.AddDataSourceAsync - adding data source for part {0}, IsDirectStream={1}, IsAvailable={2}", 
                dataSource.PartNumber, dataSource.IsDirectStream, dataSource.IsAvailable);

            // Add the data source to the collection
            if (!_partDataSources.TryAdd(dataSource.PartNumber, dataSource))
            {
                // Duplicate part number - this shouldn't happen in normal operation
                Logger.DebugFormat("[DEBUG] PartBufferManager - Duplicate part {0} attempted to be added", dataSource.PartNumber);
                dataSource?.Dispose(); // Clean up the duplicate part
                throw new InvalidOperationException($"Duplicate part {dataSource.PartNumber} attempted to be added");
            }

            Logger.DebugFormat("[DEBUG] PartBufferManager - Part {0} successfully stored in dictionary, total parts in collection: {1}", 
                dataSource.PartNumber, _partDataSources.Count);
            
            // DEBUG: Log all parts currently in the dictionary
            var partsInCollection = string.Join(", ", _partDataSources.Keys);
            Logger.DebugFormat("[DEBUG] PartBufferManager - Dictionary now contains parts: {0}", partsInCollection);

            // Signal that a new part is available
            _partAvailable.Set();
            
            return Task.CompletedTask;
        }

        public async Task AddBufferAsync(StreamPartBuffer buffer, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            // Create a BufferedDataSource and add it
            var bufferedSource = new BufferedDataSource(buffer);
            await AddDataSourceAsync(bufferedSource, cancellationToken).ConfigureAwait(false);
        }

        public async Task AddStreamSourceAsync(int partNumber, Func<byte[], int, int, CancellationToken, Task<int>> streamCallback, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (streamCallback == null)
                throw new ArgumentNullException(nameof(streamCallback));

            // Create a StreamDataSource and add it
            var streamSource = new StreamDataSource(partNumber, streamCallback);
            await AddDataSourceAsync(streamSource, cancellationToken).ConfigureAwait(false);
        }

        public async Task<ReadResult> ReadPartAsync(int requestedPartNumber, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset must be non-negative");
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
            if (offset + count > buffer.Length)
                throw new ArgumentException("Offset and count exceed buffer bounds");

            Logger.DebugFormat("[PartBufferManager] ReadPartAsync called for part {0} - offset={1}, count={2}, nextExpected={3}", 
                requestedPartNumber, offset, count, _nextExpectedPartNumber);

            // Validate sequential access
            lock (_lockObject)
            {
                if (requestedPartNumber != _nextExpectedPartNumber)
                {
                    Logger.DebugFormat("[PartBufferManager] Sequential access violation - requested part {0} but expected part {1}", 
                        requestedPartNumber, _nextExpectedPartNumber);
                    throw new InvalidOperationException(
                        $"Requested part {requestedPartNumber} but expected part {_nextExpectedPartNumber}. Parts must be consumed sequentially.");
                }
            }
            
            // CROSS-PART BOUNDARY READING - Fill buffer completely across multiple parts
            int totalBytesRead = 0;
            bool wasDirectStreamed = false;
            
            Logger.DebugFormat("[PartBufferManager] Starting cross-part boundary read - filling {0} bytes across multiple parts if needed", count);
            
            // Keep reading until buffer is full or we reach true EOF
            while (totalBytesRead < count)
            {
                var currentPartNumber = _nextExpectedPartNumber;
                Logger.DebugFormat("[PartBufferManager] Cross-part read - trying part {0}, progress={1}/{2}, parts in collection: {3}", 
                    currentPartNumber, totalBytesRead, count, _partDataSources.Count);

                // Wait for the current part to become available
                int waitIterations = 0;
                while (!_partDataSources.ContainsKey(currentPartNumber))
                {
                    waitIterations++;
                    Logger.DebugFormat("[PartBufferManager] Part {0} - not available yet, wait iteration {1}", 
                        currentPartNumber, waitIterations);

                    // Check for completion first
                    lock (_lockObject)
                    {
                        if (_downloadComplete)
                        {
                            Logger.DebugFormat("[PartBufferManager] Part {0} - download marked complete, exception={1}", 
                                currentPartNumber, _downloadException?.Message ?? "none");

                            if (_downloadException != null)
                                throw new InvalidOperationException("Multipart download failed", _downloadException);
                            
                            // True EOF - return what we've read so far
                            Logger.DebugFormat("[PartBufferManager] Cross-part read - TRUE EOF reached, returning {0} bytes", totalBytesRead);
                            return new ReadResult { BytesRead = totalBytesRead, IsDirectStreamed = wasDirectStreamed };
                        }
                    }
                    
                    // Wait for a part to become available
                    Logger.DebugFormat("[PartBufferManager] Part {0} - waiting for part to become available...", currentPartNumber);
                    await Task.Run(() => _partAvailable.WaitOne(), cancellationToken).ConfigureAwait(false);
                    Logger.DebugFormat("[PartBufferManager] Part {0} - wait completed, rechecking availability", currentPartNumber);
                }

                Logger.DebugFormat("[PartBufferManager] Part {0} - found in collection, retrieving data source", currentPartNumber);

                // Get the data source for current part
                if (!_partDataSources.TryGetValue(currentPartNumber, out var dataSource))
                {
                    Logger.DebugFormat("[PartBufferManager] Part {0} - disappeared after availability check", currentPartNumber);
                    
                    // DEBUG: Show what's actually in the dictionary
                    var actualParts = string.Join(", ", _partDataSources.Keys);
                    Logger.DebugFormat("[PartBufferManager] Dictionary actually contains parts: {0}", actualParts);
                    
                    throw new InvalidOperationException($"Part {currentPartNumber} disappeared after availability check");
                }

                Logger.DebugFormat("[PartBufferManager] Part {0} - data source: IsDirectStream={1}, IsComplete={2}, IsAvailable={3}", 
                    currentPartNumber, dataSource.IsDirectStream, dataSource.IsComplete, dataSource.IsAvailable);

                try
                {
                    // Calculate remaining space in buffer for cross-part reading
                    int remainingCount = count - totalBytesRead;
                    int currentOffset = offset + totalBytesRead;
                    
                    Logger.DebugFormat("[PartBufferManager] Part {0} - reading into remaining buffer space: offset={1}, count={2} (total progress: {3}/{4})", 
                        currentPartNumber, currentOffset, remainingCount, totalBytesRead, count);
                    
                    // Read from this part into the remaining buffer space
                    var partBytesRead = await dataSource.ReadAsync(buffer, currentOffset, remainingCount, cancellationToken).ConfigureAwait(false);
                    
                    Logger.DebugFormat("[PartBufferManager] Part {0} - dataSource.ReadAsync returned {1} bytes (requested {2}), IsComplete={3}", 
                        currentPartNumber, partBytesRead, remainingCount, dataSource.IsComplete);
                    
                    // Accumulate the bytes read and track direct streaming
                    totalBytesRead += partBytesRead;
                    wasDirectStreamed = wasDirectStreamed || dataSource.IsDirectStream;
                    
                    // If this part is complete, clean up and advance
                    if (dataSource.IsComplete)
                    {
                        Logger.DebugFormat("[PartBufferManager] Part {0} - marked complete, removing from collection and advancing", currentPartNumber);
                        
                        // Remove from collection
                        _partDataSources.TryRemove(currentPartNumber, out _);
                        
                        // Clean up the data source
                        dataSource.Dispose();
                        
                        // Release buffer space (for buffered sources, this frees up a slot)
                        ReleaseBufferSpace();
                        
                        // Advance to next part
                        lock (_lockObject)
                        {
                            _nextExpectedPartNumber++;
                            Logger.DebugFormat("[PartBufferManager] Part {0} - advanced nextExpectedPartNumber to {1}", 
                                currentPartNumber, _nextExpectedPartNumber);
                        }
                        
                        // If this part gave us 0 bytes, continue to next part
                        if (partBytesRead == 0)
                        {
                            Logger.DebugFormat("[PartBufferManager] Cross-part read - part {0} completed with 0 bytes, continuing to part {1}", 
                                currentPartNumber, _nextExpectedPartNumber);
                            continue; // Try next part
                        }
                        
                        // If buffer is not full yet, continue to next part
                        if (totalBytesRead < count)
                        {
                            Logger.DebugFormat("[PartBufferManager] Cross-part read - buffer not full ({0}/{1}), continuing to part {2}", 
                                totalBytesRead, count, _nextExpectedPartNumber);
                            continue; // Continue filling buffer from next part
                        }
                    }
                    
                    // If part is not complete but we got 0 bytes, it's EOF
                    if (partBytesRead == 0)
                    {
                        Logger.DebugFormat("[PartBufferManager] Part {0} returned 0 bytes but not complete - EOF reached", 
                            currentPartNumber);
                        break; // End of stream
                    }
                    
                    // If buffer is full, we're done
                    if (totalBytesRead >= count)
                    {
                        Logger.DebugFormat("[PartBufferManager] Cross-part read - buffer filled completely ({0}/{1})", totalBytesRead, count);
                        break; // Buffer is full
                    }
                }
                catch (Exception ex)
                {
                    Logger.DebugFormat("[PartBufferManager] Part {0} - ReadAsync failed: {1}", currentPartNumber, ex.Message);
                    // Clean up on failure
                    dataSource?.Dispose();
                    ReleaseBufferSpace();
                    throw;
                }
            }
            
            Logger.DebugFormat("[PartBufferManager] Cross-part read completed - returning {0} bytes (requested {1}), wasDirectStreamed={2}", 
                totalBytesRead, count, wasDirectStreamed);
            
            return new ReadResult 
            { 
                BytesRead = totalBytesRead, 
                IsDirectStreamed = wasDirectStreamed 
            };
        }

        public void ReleaseBufferSpace()
        {
            ThrowIfDisposed();
            
            // Release buffer space when a consumer finishes with a part (CRT-style)
            _bufferSpaceAvailable.Release();  // Frees buffer space for new downloads
        }

        public void MarkDownloadComplete(Exception exception)
        {
            Logger.DebugFormat("[PartBufferManager] MarkDownloadComplete called, exception={0}", 
                exception?.Message ?? "none");

            lock (_lockObject)
            {
                _downloadComplete = true;
                _downloadException = exception;
            }

            // Signal that completion status has changed
            _partAvailable.Set();
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(PartBufferManager));
        }

        #region Dispose Pattern

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    // Clean up all data sources (both buffered and streaming)
                    foreach (var dataSource in _partDataSources.Values)
                    {
                        dataSource?.Dispose();
                    }
                    _partDataSources.Clear();
                    
                    // Clean up synchronization primitives
                    _bufferSpaceAvailable?.Dispose();
                    _partAvailable?.Dispose();
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
