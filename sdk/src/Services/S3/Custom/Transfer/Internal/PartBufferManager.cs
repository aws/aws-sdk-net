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

        public async Task<ReadResult> ReadPartAsync(int partNumber, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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
                partNumber, offset, count, _nextExpectedPartNumber);

            // Validate sequential access
            lock (_lockObject)
            {
                if (partNumber != _nextExpectedPartNumber)
                {
                    Logger.DebugFormat("[PartBufferManager] Sequential access violation - requested part {0} but expected part {1}", 
                        partNumber, _nextExpectedPartNumber);
                    throw new InvalidOperationException(
                        $"Requested part {partNumber} but expected part {_nextExpectedPartNumber}. Parts must be consumed sequentially.");
                }
            }

            Logger.DebugFormat("[PartBufferManager] Part {0} - checking availability, current parts in collection: {1}", 
                partNumber, _partDataSources.Count);

            // Wait for the part to become available
            int waitIterations = 0;
            while (!_partDataSources.ContainsKey(partNumber))
            {
                waitIterations++;
                Logger.DebugFormat("[PartBufferManager] Part {0} - not available yet, wait iteration {1}", 
                    partNumber, waitIterations);

                // Check for completion first
                lock (_lockObject)
                {
                    if (_downloadComplete)
                    {
                        Logger.DebugFormat("[PartBufferManager] Part {0} - download marked complete, exception={1}", 
                            partNumber, _downloadException?.Message ?? "none");

                        if (_downloadException != null)
                            throw new InvalidOperationException("Multipart download failed", _downloadException);
                        
                        return new ReadResult { BytesRead = 0, IsDirectStreamed = false }; // End of stream
                    }
                }
                
                // Wait for a part to become available
                Logger.DebugFormat("[PartBufferManager] Part {0} - waiting for part to become available...", partNumber);
                await Task.Run(() => _partAvailable.WaitOne(), cancellationToken).ConfigureAwait(false);
                Logger.DebugFormat("[PartBufferManager] Part {0} - wait completed, rechecking availability", partNumber);
            }

            Logger.DebugFormat("[PartBufferManager] Part {0} - found in collection, retrieving data source", partNumber);

            // Get the data source for this part (leave it in collection)
            if (!_partDataSources.TryGetValue(partNumber, out var dataSource))
            {
                Logger.DebugFormat("[DEBUG] PartBufferManager - Part {0} expected but not found after availability check", partNumber);
                
                // DEBUG: Show what's actually in the dictionary
                var actualParts = string.Join(", ", _partDataSources.Keys);
                Logger.DebugFormat("[DEBUG] PartBufferManager - Dictionary actually contains parts: {0}", actualParts);
                
                throw new InvalidOperationException($"Part {partNumber} was expected but not found");
            }

            Logger.DebugFormat("[DEBUG] PartBufferManager - Retrieved data source for part {0}: actual PartNumber={1}, IsDirectStream={2}, IsComplete={3}, IsAvailable={4}", 
                partNumber, dataSource.PartNumber, dataSource.IsDirectStream, dataSource.IsComplete, dataSource.IsAvailable);
            
            // DEBUG: Verify the data source claims the same part number we requested
            if (dataSource.PartNumber != partNumber)
            {
                Logger.DebugFormat("[DEBUG] PartBufferManager - CRITICAL BUG: Requested part {0} but got data source for part {1}!", 
                    partNumber, dataSource.PartNumber);
            }

            try
            {
                // Single, unified read path - works for both direct streaming and buffered!
                Logger.DebugFormat("[PartBufferManager] Part {0} - calling dataSource.ReadAsync(offset={1}, count={2})", 
                    partNumber, offset, count);
                
                var bytesRead = await dataSource.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                
                Logger.DebugFormat("[PartBufferManager] Part {0} - dataSource.ReadAsync returned {1} bytes, IsComplete={2}", 
                    partNumber, bytesRead, dataSource.IsComplete);
                
                // Only remove and advance when we're actually done with this part
                if (dataSource.IsComplete)
                {
                    Logger.DebugFormat("[PartBufferManager] Part {0} - marked complete, removing from collection and advancing", partNumber);
                    
                    // Remove from collection
                    _partDataSources.TryRemove(partNumber, out _);
                    
                    // Clean up the data source
                    dataSource.Dispose();
                    
                    // Release buffer space (for buffered sources, this frees up a slot)
                    ReleaseBufferSpace();
                    
                    // Advance to next part only when this part is complete
                    lock (_lockObject)
                    {
                        _nextExpectedPartNumber++;
                        Logger.DebugFormat("[PartBufferManager] Part {0} - advanced nextExpectedPartNumber to {1}", 
                            partNumber, _nextExpectedPartNumber);
                    }
                }
                else
                {
                    Logger.DebugFormat("[PartBufferManager] Part {0} - not complete yet, keeping in collection for next read", partNumber);
                }
                
                return new ReadResult 
                { 
                    BytesRead = bytesRead, 
                    IsDirectStreamed = dataSource.IsDirectStream 
                };
            }
            catch (Exception ex)
            {
                Logger.DebugFormat("[PartBufferManager] Part {0} - ReadAsync failed: {1}", partNumber, ex.Message);
                // Clean up on failure
                dataSource?.Dispose();
                ReleaseBufferSpace();
                throw;
            }
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
