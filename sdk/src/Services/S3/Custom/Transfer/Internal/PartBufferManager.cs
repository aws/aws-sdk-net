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
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
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
            var waitTimer = Stopwatch.StartNew();
            await _bufferSpaceAvailable.WaitAsync(cancellationToken).ConfigureAwait(false);
            waitTimer.Stop();
            
            if (waitTimer.ElapsedMilliseconds > 0)
            {
                var slotsAfter = _bufferSpaceAvailable.CurrentCount;
                Logger.InfoFormat("[BUFFER] SpaceWait - DurationMs={0}, SlotsAfter={1}", 
                    waitTimer.ElapsedMilliseconds, slotsAfter);
            }
        }

        public Task AddDataSourceAsync(IPartDataSource dataSource, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            if (dataSource == null)
                throw new ArgumentNullException(nameof(dataSource));

            Logger.DebugFormat("[BUFFER] AddDataSource - Part{0} - IsAvailable={1}", 
                dataSource.PartNumber, dataSource.IsAvailable);

            // Add the data source to the collection
            if (!_partDataSources.TryAdd(dataSource.PartNumber, dataSource))
            {
                // Duplicate part number - this shouldn't happen in normal operation
                Logger.DebugFormat("[BUFFER] DuplicatePart - Part{0} - Action=Rejected", dataSource.PartNumber);
                dataSource?.Dispose(); // Clean up the duplicate part
                throw new InvalidOperationException($"Duplicate part {dataSource.PartNumber} attempted to be added");
            }

            Logger.DebugFormat("[BUFFER] PartStored - Part{0} - TotalPartsInCollection={1}", 
                dataSource.PartNumber, _partDataSources.Count);
            
            // DEBUG: Log all parts currently in the dictionary
            var partsInCollection = string.Join(", ", _partDataSources.Keys);
            Logger.DebugFormat("[BUFFER] CollectionState - Parts=[{0}]", partsInCollection);

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

            var overallTimer = Stopwatch.StartNew();
            Logger.DebugFormat("[BUFFER] ReadStart - Part{0} - Offset={1}, Count={2}, NextExpected={3}", 
                requestedPartNumber, offset, count, _nextExpectedPartNumber);

            // Validate sequential access
            lock (_lockObject)
            {
                if (requestedPartNumber != _nextExpectedPartNumber)
                {
                    Logger.DebugFormat("[BUFFER] SequenceViolation - RequestedPart={0}, ExpectedPart={1}", 
                        requestedPartNumber, _nextExpectedPartNumber);
                    throw new InvalidOperationException(
                        $"Requested part {requestedPartNumber} but expected part {_nextExpectedPartNumber}. Parts must be consumed sequentially.");
                }
            }
            
            // CROSS-PART BOUNDARY READING - Fill buffer completely across multiple parts
            int totalBytesRead = 0;
            int partsConsumed = 0;
            var totalWaitTime = TimeSpan.Zero;
            
            Logger.DebugFormat("[BUFFER] CrossPartReadStart - RequestedBytes={0}, StartPart={1}", count, _nextExpectedPartNumber);
            
            // Keep reading until buffer is full or we reach true EOF
            while (totalBytesRead < count)
            {
                var currentPartNumber = _nextExpectedPartNumber;
                Logger.DebugFormat("[BUFFER] CrossPartReadTrying - Part{0} - Progress={1}/{2}, PartsInCollection={3}", 
                    currentPartNumber, totalBytesRead, count, _partDataSources.Count);

                // Wait for the current part to become available
                int waitIterations = 0;
                var partWaitTimer = Stopwatch.StartNew();
                while (!_partDataSources.ContainsKey(currentPartNumber))
                {
                    waitIterations++;
                    Logger.DebugFormat("[BUFFER] PartUnavailable - Part{0} - WaitIteration={1}", 
                        currentPartNumber, waitIterations);

                    // Check for completion first
                    lock (_lockObject)
                    {
                        if (_downloadComplete)
                        {
                            partWaitTimer.Stop();
                            Logger.DebugFormat("[STATE] DownloadComplete - Part{0} - HasException={1}", 
                                currentPartNumber, _downloadException != null);

                            if (_downloadException != null)
                                throw new InvalidOperationException("Multipart download failed", _downloadException);
                            
                            // True EOF - return what we've read so far
                            overallTimer.Stop();
                            Logger.InfoFormat("[PERF] CrossPartRead Complete - PartsConsumed={0}, TotalBytes={1}, DurationMs={2}, WaitMs={3:F0}", 
                                partsConsumed, totalBytesRead, overallTimer.ElapsedMilliseconds, totalWaitTime.TotalMilliseconds);
                            Logger.DebugFormat("[BUFFER] CrossPartReadEOF - BytesReturned={0}", totalBytesRead);
                            return totalBytesRead;
                        }
                    }
                    
                    // Wait for a part to become available
                    Logger.DebugFormat("[BUFFER] PartWaitStart - Part{0}", currentPartNumber);
                    await Task.Run(() => _partAvailable.WaitOne(), cancellationToken).ConfigureAwait(false);
                    Logger.DebugFormat("[BUFFER] PartWaitComplete - Part{0} - Rechecking", currentPartNumber);
                }
                partWaitTimer.Stop();
                totalWaitTime += partWaitTimer.Elapsed;
                
                if (waitIterations > 0)
                {
                    Logger.InfoFormat("[BUFFER] PartAvailWait - Part{0} - Iterations={1}, DurationMs={2}", 
                        currentPartNumber, waitIterations, partWaitTimer.ElapsedMilliseconds);
                }

                Logger.DebugFormat("[BUFFER] PartFound - Part{0} - Action=RetrievingDataSource", currentPartNumber);

                // Get the data source for current part
                if (!_partDataSources.TryGetValue(currentPartNumber, out var dataSource))
                {
                    Logger.DebugFormat("[BUFFER] PartDisappeared - Part{0} - State=AfterAvailabilityCheck", currentPartNumber);
                    
                    // DEBUG: Show what's actually in the dictionary
                    var actualParts = string.Join(", ", _partDataSources.Keys);
                    Logger.DebugFormat("[BUFFER] CollectionState - Parts=[{0}]", actualParts);
                    
                    throw new InvalidOperationException($"Part {currentPartNumber} disappeared after availability check");
                }

                Logger.DebugFormat("[BUFFER] DataSourceState - Part{0} - IsComplete={1}, IsAvailable={2}", 
                    currentPartNumber, dataSource.IsComplete, dataSource.IsAvailable);

                try
                {
                    // Calculate remaining space in buffer for cross-part reading
                    int remainingCount = count - totalBytesRead;
                    int currentOffset = offset + totalBytesRead;
                    
                    Logger.DebugFormat("[BUFFER] ReadAttempt - Part{0} - Offset={1}, Count={2}, Progress={3}/{4}", 
                        currentPartNumber, currentOffset, remainingCount, totalBytesRead, count);
                    
                    // Log buffer state BEFORE reading from data source
                    if (totalBytesRead > 0 && count >= 16)
                    {
                        var bufferLastBytes = string.Join(" ", buffer
                            .Skip(offset + Math.Max(0, totalBytesRead - 8))
                            .Take(Math.Min(8, totalBytesRead))
                            .Select(b => $"0x{b:X2}"));
                        Logger.DebugFormat("[BUFFER] BufferStateBefore - Part{0} - Last8Bytes=[{1}]", 
                            currentPartNumber, bufferLastBytes);
                    }
                    
                    // Read from this part into the remaining buffer space
                    var partReadTimer = Stopwatch.StartNew();
                    var partBytesRead = await dataSource.ReadAsync(buffer, currentOffset, remainingCount, cancellationToken).ConfigureAwait(false);
                    partReadTimer.Stop();
                    
                    Logger.DebugFormat("[BUFFER] ReadResult - Part{0} - BytesRead={1}, BytesReq={2}, IsComplete={3}", 
                        currentPartNumber, partBytesRead, remainingCount, dataSource.IsComplete);
                    Logger.InfoFormat("[PERF] Buffer ToUser - Part{0} - DurationMs={1}, Bytes={2}", 
                        currentPartNumber, partReadTimer.ElapsedMilliseconds, partBytesRead);
                    
                    // Log buffer state AFTER reading from data source
                    if (partBytesRead > 0)
                    {
                        var newBytesFirst = string.Join(" ", buffer
                            .Skip(currentOffset)
                            .Take(Math.Min(8, partBytesRead))
                            .Select(b => $"0x{b:X2}"));
                        var newBytesLast = partBytesRead >= 8
                            ? string.Join(" ", buffer
                                .Skip(currentOffset + partBytesRead - 8)
                                .Take(8)
                                .Select(b => $"0x{b:X2}"))
                            : "N/A";
                        Logger.DebugFormat("[BUFFER] BufferStateAfter - Part{0} - First8=[{1}], Last8=[{2}]", 
                            currentPartNumber, newBytesFirst, newBytesLast);
                        
                        // Show the boundary region (last 4 bytes of previous + first 4 bytes of new)
                        if (totalBytesRead > 0 && count >= 8)
                        {
                            var boundaryBytes = string.Join(" ", buffer
                                .Skip(offset + Math.Max(0, totalBytesRead - 4))
                                .Take(Math.Min(8, 4 + partBytesRead))
                                .Select(b => $"0x{b:X2}"));
                            Logger.DebugFormat("[BUFFER] BoundaryState - Part{0} - Boundary4Prev4New=[{1}], Offset={2}", 
                                currentPartNumber, boundaryBytes, offset + Math.Max(0, totalBytesRead - 4));
                        }
                    }
                    
                    // Accumulate the bytes read
                    totalBytesRead += partBytesRead;
                    partsConsumed++;
                    
                    Logger.DebugFormat("[BUFFER] ReadAccumulated - Part{0} - TotalBytes={1}/{2}, PartsConsumed={3}", 
                        currentPartNumber, totalBytesRead, count, partsConsumed);
                    
                    // If this part is complete, clean up and advance
                    if (dataSource.IsComplete)
                    {
                        Logger.DebugFormat("[STATE] PartComplete - Part{0} - Action=RemovingAndAdvancing", currentPartNumber);
                        
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
                            Logger.DebugFormat("[STATE] PartAdvance - From={0}, To={1}", 
                                currentPartNumber, _nextExpectedPartNumber);
                        }
                        
                        // If this part gave us 0 bytes, continue to next part
                        if (partBytesRead == 0)
                        {
                            Logger.DebugFormat("[BUFFER] CrossPartContinue - Part{0} - Reason=ZeroBytes, NextPart={1}", 
                                currentPartNumber, _nextExpectedPartNumber);
                            continue; // Try next part
                        }
                        
                        // If buffer is not full yet, continue to next part
                        if (totalBytesRead < count)
                        {
                            Logger.DebugFormat("[BUFFER] CrossPartContinue - Progress={0}/{1}, NextPart={2}", 
                                totalBytesRead, count, _nextExpectedPartNumber);
                            continue; // Continue filling buffer from next part
                        }
                    }
                    
                    // If part is not complete but we got 0 bytes, it's EOF
                    if (partBytesRead == 0)
                    {
                        Logger.DebugFormat("[BUFFER] EOFReached - Part{0} - Reason=ZeroBytesNotComplete", 
                            currentPartNumber);
                        break; // End of stream
                    }
                    
                    // If buffer is full, we're done
                    if (totalBytesRead >= count)
                    {
                        Logger.DebugFormat("[BUFFER] BufferFull - Progress={0}/{1}", totalBytesRead, count);
                        break; // Buffer is full
                    }
                }
                catch (Exception ex)
                {
                    Logger.DebugFormat("[ERROR] ReadFailed - Part{0} - Message={1}", currentPartNumber, ex.Message);
                    // Clean up on failure
                    dataSource?.Dispose();
                    ReleaseBufferSpace();
                    throw;
                }
            }
            
            overallTimer.Stop();
            Logger.InfoFormat("[PERF] CrossPartRead Complete - PartsConsumed={0}, TotalBytes={1}, BytesReq={2}, DurationMs={3}, WaitMs={4:F0}", 
                partsConsumed, totalBytesRead, count, overallTimer.ElapsedMilliseconds, totalWaitTime.TotalMilliseconds);
            Logger.DebugFormat("[BUFFER] ReadComplete - BytesReturned={0}, BytesReq={1}", 
                totalBytesRead, count);
            
            return totalBytesRead;
        }

        public void ReleaseBufferSpace()
        {
            ThrowIfDisposed();
            
            // Release buffer space when a consumer finishes with a part (CRT-style)
            _bufferSpaceAvailable.Release();  // Frees buffer space for new downloads
        }

        public void MarkDownloadComplete(Exception exception)
        {
            Logger.DebugFormat("[STATE] DownloadComplete - HasException={0}", 
                exception != null);

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
