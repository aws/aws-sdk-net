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

            // Add the data source to the collection
            if (!_partDataSources.TryAdd(dataSource.PartNumber, dataSource))
            {
                // Duplicate part number - this shouldn't happen in normal operation
                dataSource?.Dispose(); // Clean up the duplicate part
                throw new InvalidOperationException($"Duplicate part {dataSource.PartNumber} attempted to be added");
            }

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

        public async Task<int> ReadPartAsync(int requestedPartNumber, byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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

            // Validate sequential access
            lock (_lockObject)
            {
                if (requestedPartNumber != _nextExpectedPartNumber)
                {
                    throw new InvalidOperationException(
                        $"Requested part {requestedPartNumber} but expected part {_nextExpectedPartNumber}. Parts must be consumed sequentially.");
                }
            }
            
            // Read across part boundaries to fill the buffer completely, matching standard Stream.Read() behavior
            // (should fill buffer as much as possible, not stop at internal part boundaries)

            int totalBytesRead = 0;
            
            // Keep reading until buffer is full or we reach true EOF
            while (totalBytesRead < count)
            {
                var currentPartNumber = _nextExpectedPartNumber;

                // Wait for the current part to become available
                while (!_partDataSources.ContainsKey(currentPartNumber))
                {
                    // Check for completion first
                    lock (_lockObject)
                    {
                        if (_downloadComplete)
                        {
                            if (_downloadException != null)
                                throw new InvalidOperationException("Multipart download failed", _downloadException);
                            
                            // True EOF - return what we've read so far
                            return totalBytesRead;
                        }
                    }
                    
                    // Wait for a part to become available
                    await Task.Run(() => _partAvailable.WaitOne(), cancellationToken).ConfigureAwait(false);
                }

                // Get the data source for current part
                if (!_partDataSources.TryGetValue(currentPartNumber, out var dataSource))
                {
                    throw new InvalidOperationException($"Part {currentPartNumber} disappeared after availability check");
                }

                try
                {
                    // Calculate remaining space in buffer for cross-part reading
                    int remainingCount = count - totalBytesRead;
                    int currentOffset = offset + totalBytesRead;
                    
                    // Read from this part into the remaining buffer space
                    var partBytesRead = await dataSource.ReadAsync(buffer, currentOffset, remainingCount, cancellationToken).ConfigureAwait(false);
                    
                    // Accumulate the bytes read
                    totalBytesRead += partBytesRead;
                    
                    // If this part is complete, clean up and advance
                    if (dataSource.IsComplete)
                    {
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
                        }
                        
                        // If this part gave us 0 bytes, continue to next part
                        if (partBytesRead == 0)
                        {
                            continue; // Try next part
                        }
                        
                        // If buffer is not full yet, continue to next part
                        if (totalBytesRead < count)
                        {
                            continue; // Continue filling buffer from next part
                        }
                    }
                    
                    // If part is not complete but we got 0 bytes, it's EOF
                    if (partBytesRead == 0)
                    {
                        break; // End of stream
                    }
                    
                    // If buffer is full, we're done
                    if (totalBytesRead >= count)
                    {
                        break; // Buffer is full
                    }
                }
                catch (Exception)
                {
                    // Clean up on failure
                    dataSource?.Dispose();
                    ReleaseBufferSpace();
                    throw;
                }
            }
            
            return totalBytesRead;
        }

        public void ReleaseBufferSpace()
        {
            ThrowIfDisposed();
            
            // Release buffer space when a consumer finishes with a part
            _bufferSpaceAvailable.Release();
        }

        public void MarkDownloadComplete(Exception exception)
        {
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
