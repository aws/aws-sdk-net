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
using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Manages buffered parts for multipart downloads with memory flow control and sequential consumption.
    /// Implements a producer-consumer pattern where download tasks produce buffered parts and the read stream consumes them in order.
    /// </summary>
    /// <remarks>
    /// This class coordinates concurrent multipart downloads while ensuring sequential reading and bounded memory usage.
    /// 
    /// SYNCHRONIZATION PRIMITIVES AND THEIR PURPOSES:
    /// 
    /// 1. _lockObject (object lock)
    ///    - Protects: _nextExpectedPartNumber, _downloadComplete, _downloadException
    ///    - Purpose: Ensures only one thread can update the part counter or completion state at a time
    ///    - Example: When part 3 finishes reading, the lock ensures the counter increments 
    ///      to 4 before another reader checks it, preventing conflicts.
    ///    
    /// 2. _bufferSpaceAvailable (slot counter)
    ///    - Purpose: Flow control to limit memory usage by limiting concurrent buffered parts
    ///    - Capacity: Set to MaxInMemoryParts (e.g., 10 parts)
    ///    - Example: If 10 parts are buffered in memory and part 1 is still being read, a download 
    ///      task attempting to buffer part 11 must wait. Once part 1 is consumed and disposed, 
    ///      its buffer slot is released, allowing part 11 to be buffered.
    ///    - Critical: Prevents unbounded memory growth during large multipart downloads
    ///    
    /// 3. _partAvailable (signal for readers)
    ///    - Purpose: Signals when new parts are added or download completes
    ///    - Signaled by: AddBufferAsync (when new part added), MarkDownloadComplete (when done)
    ///    - Waited on by: ReadFromCurrentPartAsync (when expected part not yet available)
    ///    - Example: Reader waits for part 3. When a download task adds part 3 to the dictionary,
    ///      it signals this event, waking the waiting reader to proceed.
    ///    - Automatically resets after waking one waiting reader
    ///    
    /// 4. _partDataSources (dictionary storing parts)
    ///    - Purpose: Thread-safe storage of buffered part data indexed by part number
    ///    - Key: Part number (allows quickly finding the next part to read)
    ///    - Example: Download tasks 1-10 run concurrently, each adding their buffered part to the 
    ///      dictionary when ready. The reader sequentially consumes part 1, then 2, then 3, etc.,
    ///      even if they arrived in a different order (e.g., 3, 1, 5, 2, 4).
    ///    
    /// PRODUCER-CONSUMER FLOW:
    /// 
    /// Producer Flow (Download Tasks buffering parts):
    /// 1. Wait for buffer space: await WaitForBufferSpaceAsync()
    ///    - Blocks if MaxInMemoryParts are already buffered in memory
    ///    - Example: With MaxInMemoryParts=10, if parts 5-14 are buffered, the task downloading
    ///      part 15 blocks here until the reader consumes and releases part 5's buffer
    /// 2. Read part data from S3 into pooled buffer
    /// 3. Add buffered part: await AddBufferAsync(buffer)
    ///    - Adds buffer to _partDataSources dictionary
    ///    - Signals _partAvailable to wake consumer if waiting
    /// 4. Consumer eventually releases the buffer slot after reading the part
    /// 
    /// Consumer Flow (Read Stream reading parts sequentially):
    /// 1. Check if expected part (_nextExpectedPartNumber) is available in dictionary
    /// 2. If not available, wait on _partAvailable event
    ///    - Example: Waiting for part 2, even if parts 3, 5, 7 are already available
    ///    - Also checks for download completion while waiting to detect end-of-file
    /// 3. Once available, read from the part's buffer sequentially
    /// 4. When part is fully read (IsComplete = true):
    ///    - Remove part from dictionary
    ///    - Dispose data source (returns buffer to ArrayPool)
    ///    - Call ReleaseBufferSpace() (frees slot for producer to buffer next part)
    ///    - Increment _nextExpectedPartNumber (under _lockObject for atomicity)
    /// 5. Continue to next part to fill caller's buffer across part boundaries if needed
    /// 
    /// SEQUENTIAL GUARANTEE:
    /// The _nextExpectedPartNumber field ensures parts are consumed in order, even when they 
    /// arrive out of order. The consumer always waits for the next sequential part before 
    /// reading, regardless of what other parts are already buffered.
    /// 
    /// Example scenario with 5-part download:
    /// - Download order: Part 3 arrives, then 1, then 5, then 2, then 4
    /// - Parts in dictionary: {3, 1, 5} then {3, 1, 5, 2} then {3, 1, 5, 2, 4}
    /// - Reader consumption order: Waits for 1, reads 1, advances to 2, waits for 2, reads 2, 
    ///   advances to 3, reads 3 (already available), advances to 4, waits for 4, etc.
    /// - Final read order: 1, 2, 3, 4, 5 (sequential, regardless of arrival order)
    /// 
    /// MEMORY MANAGEMENT:
    /// This bounded buffer approach prevents memory exhaustion on large files:
    /// - Without flow control: All parts could be buffered simultaneously (e.g., 1000 parts × 10MB = 10GB)
    /// - With flow control (MaxInMemoryParts=10): Maximum 10 parts buffered (10 × 10MB = 100MB)
    /// - The semaphore creates backpressure on download tasks when memory limit is reached
    /// </remarks>
    internal class PartBufferManager : IPartBufferManager
    {
        #region Private members

        // Stores buffered parts by their part number so we can quickly find them.
        // Example: If parts arrive as 3, 1, 5, they're stored as {3: buffer3, 1: buffer1, 5: buffer5}
        // but consumed in order: 1, 2 (wait), 3, 4 (wait), 5.
        private readonly ConcurrentDictionary<int, IPartDataSource> _partDataSources;

        // Limits how many parts can be buffered in memory at once.
        // Capacity set to MaxInMemoryParts (e.g., 10 parts). Download tasks wait here 
        // before buffering new parts if the limit is reached. Consumers release slots 
        // after disposing consumed part buffers.
        // Example: With limit=10, if parts 1-10 are buffered and part 1 is being read,
        // the download task for part 11 blocks here. Once part 1 is consumed and its
        // buffer returned to the pool via ReleaseBufferSpace(), part 11 can be buffered.
        private readonly SemaphoreSlim _bufferSpaceAvailable;

        // Signals when new parts are added or download completes.
        // Automatically resets after waking one waiting reader.
        // Signaled by: AddBufferAsync when new part added, MarkDownloadComplete when finished.
        // Waited on by: ReadFromCurrentPartAsync when expected part not yet available.
        // Example: Reader waits for part 4. When download task adds part 4, it signals
        // this event, immediately waking the reader to proceed with consumption.
        private readonly AutoResetEvent _partAvailable;

        // Prevents conflicts when updating the part counter or completion status.
        // Guards: _nextExpectedPartNumber, _downloadComplete, _downloadException.
        // Example: When part 2 finishes reading, this lock ensures _nextExpectedPartNumber
        // is incremented to 3 before any other thread checks or updates it.
        private readonly object _lockObject = new object();
        
        // Tracks the next part number to consume sequentially. Ensures in-order reading.
        // Uses _lockObject to prevent conflicts when reading or updating.
        // Consumer advances this after fully consuming each part.
        // Example: Set to 1 initially. After reading part 1, incremented to 2.
        // Even if part 5 is available, consumer waits for part 2 before proceeding.
        private int _nextExpectedPartNumber = 1;

        // Indicates all download tasks have completed (successfully or with error).
        // Protected by _lockObject. Set by MarkDownloadComplete, read by consumer.
        // When true with null exception: Normal end-of-file, no more parts coming.
        // When true with non-null exception: Download failed, throw to consumer.
        private bool _downloadComplete = false;

        // Stores any exception from download tasks. Null if successful.
        // Protected by _lockObject. If set, thrown to consumer on next read attempt.
        private Exception _downloadException;

        private bool _disposed = false;

        #endregion

        #region Logger

        private Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

        #endregion

        public PartBufferManager(BufferedDownloadConfiguration config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));
            
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

        /// <summary>
        /// Waits for buffer space to become available before buffering a new part.
        /// This provides flow control to prevent unbounded memory usage.
        /// </summary>
        /// <remarks>
        /// This method is called by download tasks before buffering a new part. If MaxInMemoryParts
        /// are already buffered, the task blocks here until the consumer reads and disposes a part,
        /// freeing a slot via ReleaseBufferSpace().
        /// 
        /// Example: With MaxInMemoryParts=10:
        /// - Parts 1-10 are buffered in memory
        /// - Download task for part 11 calls this method and blocks
        /// - Consumer reads and completes part 1, calls ReleaseBufferSpace()
        /// - This method returns, allowing part 11 to be buffered
        /// </remarks>
        public async Task WaitForBufferSpaceAsync(CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            await _bufferSpaceAvailable.WaitAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds a part data source to the dictionary and signals waiting consumers.
        /// </summary>
        /// <remarks>
        /// This method is thread-safe and can be called concurrently by multiple download tasks.
        /// After adding the part to the dictionary, it signals _partAvailable to wake any consumer
        /// waiting for this specific part number.
        /// 
        /// Example: Download tasks for parts 3, 1, 5 all call this concurrently:
        /// - Each adds to dictionary with their part number as key
        /// - Each signals _partAvailable
        /// - Consumer waiting for part 1 wakes up when part 1 is added
        /// </remarks>
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

        public async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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

            int totalBytesRead = 0;
            
            // Keep reading until buffer is full or we reach true EOF
            // Note: We read across part boundaries to fill the buffer completely, matching standard Stream.Read() behavior
            while (totalBytesRead < count)
            {
                var (bytesRead, shouldContinue) = await ReadFromCurrentPartAsync(
                    buffer, 
                    offset + totalBytesRead, 
                    count - totalBytesRead, 
                    cancellationToken).ConfigureAwait(false);
                
                totalBytesRead += bytesRead;
                
                if (!shouldContinue)
                    break;
            }
            
            return totalBytesRead;
        }

        /// <summary>
        /// Reads from the current expected part, handling availability, consumption, and cleanup.
        /// Returns (bytesRead, shouldContinue) where shouldContinue indicates if more data is available.
        /// </summary>
        /// <remarks>
        /// This method implements the core sequential consumption logic with these responsibilities:
        /// - Waiting for the next expected part to arrive (even if later parts already available)
        /// - Reading data from the part's buffer
        /// - Cleaning up completed parts (disposing buffer, releasing slot, advancing counter)
        /// - Detecting download completion and errors
        /// 
        /// SEQUENTIAL CONSUMPTION EXAMPLE:
        /// Scenario: Downloading 5-part file, parts arrive out of order
        /// 
        /// Initial state: _nextExpectedPartNumber = 1, dictionary is empty
        /// 
        /// Step 1: Part 3 arrives first
        /// - Dictionary: {3: buffer3}
        /// - Consumer calls this method, expects part 1
        /// - ContainsKey(1) = false, enters wait loop
        /// - Waits on _partAvailable event
        /// 
        /// Step 2: Part 1 arrives
        /// - Dictionary: {3: buffer3, 1: buffer1}
        /// - AddDataSourceAsync signals _partAvailable
        /// - Consumer wakes up, checks ContainsKey(1) = true, exits wait loop
        /// - Reads from part 1's buffer
        /// - Part 1 becomes complete (IsComplete = true)
        /// - Removes part 1 from dictionary: {3: buffer3}
        /// - Disposes buffer (returns to ArrayPool)
        /// - Releases buffer slot (ReleaseBufferSpace)
        /// - Locks _lockObject, increments counter: _nextExpectedPartNumber = 2
        /// - Returns (bytesRead, shouldContinue=true) to fill more of caller's buffer
        /// 
        /// Step 3: Next iteration, now expecting part 2
        /// - Dictionary: {3: buffer3}
        /// - ContainsKey(2) = false, enters wait loop again
        /// - Waits for part 2, even though part 3 is already available
        /// 
        /// This continues until all parts are consumed in order: 1, 2, 3, 4, 5
        /// </remarks>
        private async Task<(int bytesRead, bool shouldContinue)> ReadFromCurrentPartAsync(
            byte[] buffer, 
            int offset, 
            int count, 
            CancellationToken cancellationToken)
        {
            var currentPartNumber = _nextExpectedPartNumber;

            // Wait for the current part to become available.
            // This loop handles out-of-order part arrival - we always wait for the next 
            // sequential part (_nextExpectedPartNumber) before proceeding, even if later
            // parts are already available in the dictionary.
            // Example: If parts 3, 5, 7 are available but we need part 2, we wait here.
            while (!_partDataSources.ContainsKey(currentPartNumber))
            {
                // Check for completion first to avoid indefinite waiting.
                // Acquires _lockObject to atomically read both completion flags.
                // This prevents TOCTOU (time-of-check-time-of-use) race condition where
                // completion could be signaled between checking ContainsKey and waiting.
                lock (_lockObject)
                {
                    if (_downloadComplete)
                    {
                        if (_downloadException != null)
                            throw new InvalidOperationException("Multipart download failed", _downloadException);
                        
                        // True EOF - all parts downloaded, no more data coming
                        return (0, false);
                    }
                }
                
                // Wait for a part to become available.
                // _partAvailable is signaled by:
                // 1. AddDataSourceAsync when a new part is added to the dictionary
                // 2. MarkDownloadComplete when all download tasks finish
                // 
                // Example: Waiting for part 2. When download task completes buffering part 2
                // and calls AddDataSourceAsync, it signals this event, waking us to check again.
                await Task.Run(() => _partAvailable.WaitOne(), cancellationToken).ConfigureAwait(false);
            }

            // At this point, the expected part is available in the dictionary.
            // Double-check with TryGetValue for safety (handles rare race conditions).
            if (!_partDataSources.TryGetValue(currentPartNumber, out var dataSource))
            {
                // Log technical details for troubleshooting
                Logger.Error(null, "Part {0} disappeared after availability check. This indicates a race condition in the buffer manager.", currentPartNumber);
                
                // Throw user-friendly exception
                throw new InvalidOperationException("Multipart download failed due to an internal error.");
            }

            try
            {
                // Read from this part's buffer into the caller's buffer.
                var partBytesRead = await dataSource.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                
                // If this part is fully consumed, perform cleanup and advance to next part.
                if (dataSource.IsComplete)
                {
                    // Remove from collection
                    _partDataSources.TryRemove(currentPartNumber, out _);
                    
                    // Clean up the data source (returns buffer to ArrayPool)
                    dataSource.Dispose();
                    
                    // Release buffer space slot (allows producer to buffer the next part).
                    // This is critical for flow control - without this release, download tasks
                    // would eventually block waiting for space, even though we've consumed this part.
                    // Example: After consuming part 1 (freeing its slot), download task can now
                    // buffer part 11 if parts 2-10 are still being held.
                    ReleaseBufferSpace();
                    
                    // Advance to next part.
                    // Acquires _lockObject to atomically increment the counter.
                    // This ensures sequential consumption even with concurrent readers.
                    // Example: Two threads reading simultaneously won't both increment from 3 to 4.
                    lock (_lockObject)
                    {
                        _nextExpectedPartNumber++;
                    }
                    
                    // Continue reading to fill buffer across part boundaries.
                    // This matches standard Stream.Read() behavior where we attempt to
                    // fill the caller's buffer completely before returning, even if it
                    // requires reading from multiple parts.
                    // Example: Caller requests 20MB, part 1 has 5MB remaining. We return
                    // (5MB, shouldContinue=true), then on next iteration read from part 2
                    // to try to fill the remaining 15MB.
                    return (partBytesRead, true);
                }
                
                // If part is not complete but we got 0 bytes, it's EOF
                if (partBytesRead == 0)
                {
                    return (0, false);
                }
                
                // Part still has more data available. Return what we read.
                // We'll resume from this part on the next ReadAsync call.
                return (partBytesRead, false);
            }
            catch (Exception)
            {
                // Clean up on failure to prevent resource leaks
                dataSource?.Dispose();
                ReleaseBufferSpace();
                throw;
            }
        }

        /// <summary>
        /// Releases a buffer space slot, allowing producers to buffer additional parts.
        /// This is the critical feedback mechanism in the flow control loop.
        /// </summary>
        /// <remarks>
        /// Called by the consumer after fully reading and disposing a buffered part.
        /// This method releases a slot in the _bufferSpaceAvailable semaphore, which may
        /// unblock a download task waiting in WaitForBufferSpaceAsync().
        /// 
        /// FLOW CONTROL CYCLE:
        /// 1. Download task blocks in WaitForBufferSpaceAsync() (slot count = 0)
        /// 2. Consumer reads and completes a part
        /// 3. Consumer calls this method (slot count = 1)
        /// 4. Download task unblocks and can buffer next part
        /// 
        /// Example: With MaxInMemoryParts=10, after consuming part 1, this allows part 11 to be buffered.
        /// </remarks>
        public void ReleaseBufferSpace()
        {
            ThrowIfDisposed();
            
            // Release buffer space when a consumer finishes with a part
            _bufferSpaceAvailable.Release();
        }

        /// <summary>
        /// Marks the download as complete (success or failure) and wakes waiting consumers.
        /// </summary>
        /// <remarks>
        /// Called by the download coordinator when all download tasks have finished.
        /// This signals to the consumer that no more parts will arrive, allowing it to
        /// detect end-of-file correctly even if waiting for a part that will never come.
        /// 
        /// Example: All 5 parts downloaded successfully
        /// - Download coordinator calls MarkDownloadComplete(null)
        /// - Consumer waiting for non-existent part 6 wakes up
        /// - Consumer checks _downloadComplete = true, _downloadException = null
        /// - Consumer returns EOF (0 bytes)
        /// </remarks>
        public void MarkDownloadComplete(Exception exception)
        {
            lock (_lockObject)
            {
                _downloadComplete = true;
                _downloadException = exception;
            }

            // Signal that completion status has changed.
            // This wakes any consumer waiting in ReadFromCurrentPartAsync to check completion.
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
