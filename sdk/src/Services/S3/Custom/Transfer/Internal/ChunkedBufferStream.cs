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

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// A writable and readable stream that stores data across multiple small ArrayPool buffers,
    /// avoiding the 2GB array size limitation and Large Object Heap (LOH) allocations.
    /// </summary>
    /// <remarks>
    /// <para><strong>Design Goals:</strong></para>
    /// <list type="bullet">
    /// <item>Keep each buffer chunk below 85KB to avoid LOH allocation</item>
    /// <item>Support parts larger than 2GB (int.MaxValue)</item>
    /// <item>Efficient memory management via ArrayPool</item>
    /// <item>Present standard Stream interface for easy integration</item>
    /// </list>
    /// 
    /// <para><strong>Size Limits:</strong></para>
    /// <para>
    /// Maximum supported stream size is approximately 140TB (int.MaxValue * CHUNK_SIZE bytes).
    /// This limit exists because chunk indexing uses int for List indexing.
    /// </para>
    /// 
    /// <para><strong>Usage Pattern:</strong></para>
    /// <code>
    /// var stream = new ChunkedBufferStream();
    /// 
    /// // Write phase: Stream data in
    /// await response.WriteResponseStreamAsync(stream, ...);
    /// 
    /// // Read phase: Stream data out (automatically switches to read mode)
    /// int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
    /// 
    /// // Cleanup: Returns all chunks to ArrayPool
    /// stream.Dispose();
    /// </code>
    /// <para>
    /// Note: The stream automatically switches to read mode on the first read operation.
    /// You can optionally call <see cref="SwitchToReadMode"/> explicitly for clarity.
    /// </para>
    /// </remarks>
    internal class ChunkedBufferStream : Stream
    {
        /// <summary>
        /// Size of each buffer chunk. Set to 64KB to match ArrayPool bucket size and stay below the 85KB Large Object Heap threshold.
        /// If we chose any higher than 64KB, ArrayPool would round up to 128KB (which would go to LOH).
        /// </summary>
        private const int CHUNK_SIZE = 65536; // 64KB - matches ArrayPool bucket, safely below 85KB LOH threshold

        /// <summary>
        /// Bit shift for fast division by CHUNK_SIZE. Since CHUNK_SIZE = 65536 = 2^16, we can use right shift by 16 instead of division.
        /// </summary>
        private const int CHUNK_SIZE_BITS = 16; // log2(65536) = 16

        /// <summary>
        /// Bit mask for fast modulo by CHUNK_SIZE. Since CHUNK_SIZE = 2^16, mask is 2^16 - 1 = 0xFFFF.
        /// </summary>
        private const int CHUNK_SIZE_MASK = CHUNK_SIZE - 1; // 0xFFFF for fast modulo

        /// <summary>
        /// Maximum supported stream size. This limit exists because chunk indexing uses int for List indexing.
        /// With 64KB chunks, this allows approximately 140TB of data.
        /// </summary>
        private const long MAX_STREAM_SIZE = (long)int.MaxValue * CHUNK_SIZE;

        private readonly List<byte[]> _chunks;
        private long _length = 0;
        private long _position = 0;
        private bool _isReadMode = false;
        private bool _disposed = false;

        // Cached write position state for performance optimization
        private int _currentWriteChunkIndex = 0;
        private int _currentWriteChunkOffset = 0;
        private byte[] _currentWriteChunk = null;

        /// <summary>
        /// Creates a new ChunkedBufferStream with default initial capacity.
        /// </summary>
        public ChunkedBufferStream()
        {
            _chunks = new List<byte[]>();
        }

        /// <summary>
        /// Creates a new ChunkedBufferStream with pre-allocated capacity for the expected size.
        /// This avoids List resizing during writes, improving performance for known sizes.
        /// </summary>
        /// <param name="estimatedSize">The estimated total size in bytes. Used to pre-allocate the chunk list capacity.</param>
        public ChunkedBufferStream(long estimatedSize)
        {
            if (estimatedSize > 0)
            {
                // Ceiling division formula: (n + d - 1) / d calculates ceil(n / d) using integer arithmetic.
                // This computes how many chunks are needed to hold estimatedSize bytes, rounding up to
                // ensure the last partial chunk is accounted for. Avoids floating-point math for performance.
                // Example: For 100 bytes with CHUNK_SIZE=32: (100 + 31) / 32 = 131 / 32 = 4 chunks
                //          (simple division 100/32=3 would only hold 96 bytes, losing 4 bytes)
                long estimatedChunks = (estimatedSize + CHUNK_SIZE - 1) / CHUNK_SIZE;
                int capacity = (int)Math.Min(estimatedChunks, int.MaxValue);
                _chunks = new List<byte[]>(capacity);
            }
            else
            {
                _chunks = new List<byte[]>();
            }
        }

        /// <summary>
        /// Throws <see cref="ObjectDisposedException"/> if the stream has been disposed.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Thrown if the stream is disposed.</exception>
        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(ChunkedBufferStream));
        }

        /// <summary>
        /// Gets a value indicating whether the stream supports reading.
        /// Returns true after the first read operation or after <see cref="SwitchToReadMode"/> has been called.
        /// </summary>
        public override bool CanRead => _isReadMode;

        /// <summary>
        /// Gets a value indicating whether the stream supports seeking.
        /// Always returns false - seeking is not supported.
        /// </summary>
        public override bool CanSeek => false;

        /// <summary>
        /// Gets a value indicating whether the stream supports writing.
        /// Returns true before <see cref="SwitchToReadMode"/> is called, false after.
        /// </summary>
        public override bool CanWrite => !_isReadMode;

        /// <summary>
        /// Gets the length in bytes of the stream.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Thrown if the stream has been disposed.</exception>
        public override long Length
        {
            get
            {
                ThrowIfDisposed();
                return _length;
            }
        }

        /// <summary>
        /// Gets or sets the position within the current stream.
        /// Setting the position is not supported and will throw <see cref="NotSupportedException"/>.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Thrown if the stream has been disposed.</exception>
        /// <exception cref="NotSupportedException">Thrown when attempting to set the position.</exception>
        public override long Position
        {
            get
            {
                ThrowIfDisposed();
                return _position;
            }
            set => throw new NotSupportedException("Seeking not supported");
        }

        /// <summary>
        /// Writes a sequence of bytes to the stream and advances the current position by the number of bytes written.
        /// Automatically allocates new chunks from ArrayPool as needed.
        /// </summary>
        /// <param name="buffer">The buffer containing data to write.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin copying bytes.</param>
        /// <param name="count">The number of bytes to write.</param>
        /// <exception cref="ObjectDisposedException">Thrown if the stream has been disposed.</exception>
        /// <exception cref="NotSupportedException">Thrown if stream is in read mode.</exception>
        /// <exception cref="ArgumentNullException">Thrown if buffer is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if offset or count is negative or exceeds buffer bounds.</exception>
        /// <exception cref="IOException">Thrown if the write would exceed the maximum supported stream size (approximately 175TB).</exception>
        public override void Write(byte[] buffer, int offset, int count)
        {
            ThrowIfDisposed();
            
            if (_isReadMode)
                throw new NotSupportedException("Cannot write after switching to read mode");

            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset must be non-negative");
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
            if (offset + count > buffer.Length)
                throw new ArgumentException("Offset and count exceed buffer bounds");

            // Check for overflow before writing - prevents chunk index overflow for extremely large streams
            if (_length > MAX_STREAM_SIZE - count)
                throw new IOException($"Write would exceed maximum supported stream size of {MAX_STREAM_SIZE} bytes (approximately 175TB).");

            // Fast path: entire write fits in current chunk (most common case with 8KB writes into 64KB chunks)
            int spaceInCurrentChunk = CHUNK_SIZE - _currentWriteChunkOffset;
            if (count <= spaceInCurrentChunk && _currentWriteChunk != null)
            {
                Buffer.BlockCopy(buffer, offset, _currentWriteChunk, _currentWriteChunkOffset, count);
                _currentWriteChunkOffset += count;
                _length += count;
                _position = _length;
                return;
            }

            // Slow path: write spans multiple chunks
            WriteSlowPath(buffer, offset, count);
        }

        /// <summary>
        /// Handles writes that span multiple chunks or require chunk allocation.
        /// Uses bit shifting for fast chunk index/offset calculation.
        /// </summary>
        private void WriteSlowPath(byte[] buffer, int offset, int count)
        {
            int remaining = count;
            int sourceOffset = offset;

            while (remaining > 0)
            {
                // Use bit shifting for fast division and modulo (10-20x faster than / and %)
                // Since CHUNK_SIZE = 65536 = 2^16:
                //   chunkIndex = _length / CHUNK_SIZE   ->   _length >> 16
                //   offsetInChunk = _length % CHUNK_SIZE   ->   _length & 0xFFFF
                int chunkIndex = (int)(_length >> CHUNK_SIZE_BITS);
                int offsetInChunk = (int)(_length & CHUNK_SIZE_MASK);

                // Allocate new chunk if we've filled all existing chunks
                if (chunkIndex >= _chunks.Count)
                {
                    var newChunk = ArrayPool<byte>.Shared.Rent(CHUNK_SIZE);
                    _chunks.Add(newChunk);
                    
                    // Update cached state for next fast path
                    _currentWriteChunk = newChunk;
                    _currentWriteChunkIndex = chunkIndex;
                    _currentWriteChunkOffset = offsetInChunk;
                }
                else if (chunkIndex != _currentWriteChunkIndex)
                {
                    // Update cached state when moving to different chunk
                    _currentWriteChunk = _chunks[chunkIndex];
                    _currentWriteChunkIndex = chunkIndex;
                    _currentWriteChunkOffset = offsetInChunk;
                }

                // Copy data to current chunk
                int bytesToWrite = Math.Min(remaining, CHUNK_SIZE - offsetInChunk);
                Buffer.BlockCopy(buffer, sourceOffset, _chunks[chunkIndex], offsetInChunk, bytesToWrite);

                _length += bytesToWrite;
                sourceOffset += bytesToWrite;
                remaining -= bytesToWrite;
                _currentWriteChunkOffset = (int)((_length & CHUNK_SIZE_MASK));
            }

            _position = _length;
        }

        /// <summary>
        /// Asynchronously writes a sequence of bytes to the stream.
        /// </summary>
        /// <param name="buffer">The buffer containing data to write.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin copying bytes.</param>
        /// <param name="count">The number of bytes to write.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task representing the asynchronous write operation.</returns>
        /// <remarks>
        /// Delegates to synchronous <see cref="Write"/> as ArrayPool operations are fast and don't benefit from async.
        /// </remarks>
        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            Write(buffer, offset, count);
            return Task.CompletedTask;
        }

        /// <summary>
        /// Reads a sequence of bytes from the stream and advances the position by the number of bytes read.
        /// Automatically switches to read mode on the first read if not already in read mode.
        /// </summary>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing data.</param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <returns>
        /// The total number of bytes read into the buffer. This can be less than the requested count
        /// if that many bytes are not currently available, or zero if the end of the stream is reached.
        /// </returns>
        /// <exception cref="ObjectDisposedException">Thrown if the stream has been disposed.</exception>
        /// <exception cref="ArgumentNullException">Thrown if buffer is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if offset or count is negative or exceeds buffer bounds.</exception>
        public override int Read(byte[] buffer, int offset, int count)
        {
            ThrowIfDisposed();
            
            // Automatically switch to read mode on first read
            if (!_isReadMode)
            {
                _isReadMode = true;
                _position = 0;
            }

            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset must be non-negative");
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
            if (offset + count > buffer.Length)
                throw new ArgumentException("Offset and count exceed buffer bounds");

            if (_position >= _length)
                return 0; // End of stream

            long bytesAvailable = _length - _position;
            int bytesToRead = (int)Math.Min(count, bytesAvailable);
            int bytesRead = 0;

            while (bytesRead < bytesToRead)
            {
                // Use bit shifting for fast division and modulo (10-20x faster than / and %)
                int chunkIndex = (int)(_position >> CHUNK_SIZE_BITS);
                int offsetInChunk = (int)(_position & CHUNK_SIZE_MASK);
                int bytesInThisChunk = Math.Min(bytesToRead - bytesRead, CHUNK_SIZE - offsetInChunk);

                Buffer.BlockCopy(_chunks[chunkIndex], offsetInChunk, buffer, offset + bytesRead, bytesInThisChunk);

                _position += bytesInThisChunk;
                bytesRead += bytesInThisChunk;
            }

            return bytesRead;
        }

        /// <summary>
        /// Asynchronously reads a sequence of bytes from the stream.
        /// Automatically switches to read mode on the first read if not already in read mode.
        /// </summary>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing data.</param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous read operation. The task result contains the total number
        /// of bytes read into the buffer.
        /// </returns>
        /// <remarks>
        /// Delegates to synchronous <see cref="Read"/> as buffer operations are fast and don't benefit from async.
        /// </remarks>
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult(Read(buffer, offset, count));
        }

        /// <summary>
        /// Switches the stream from write mode to read mode.
        /// This method is optional - the stream will automatically switch to read mode on the first read operation.
        /// Call this explicitly if you want to switch modes before reading or for clarity in your code.
        /// Resets the position to the beginning of the stream.
        /// </summary>
        /// <exception cref="ObjectDisposedException">Thrown if the stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">Thrown if already in read mode.</exception>
        public void SwitchToReadMode()
        {
            ThrowIfDisposed();
            
            if (_isReadMode)
                throw new InvalidOperationException("Stream is already in read mode");

            _isReadMode = true;
            _position = 0;
        }

        /// <summary>
        /// Flushes any buffered data. This is a no-op for this stream type.
        /// </summary>
        public override void Flush()
        {
            // No-op: No buffering layer that needs flushing
        }

        /// <summary>
        /// Sets the position within the current stream.
        /// Not supported - always throws <see cref="NotSupportedException"/>.
        /// </summary>
        /// <exception cref="NotSupportedException">Always thrown.</exception>
        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotSupportedException("Seeking is not supported");
        }

        /// <summary>
        /// Sets the length of the current stream.
        /// Not supported - always throws <see cref="NotSupportedException"/>.
        /// </summary>
        /// <exception cref="NotSupportedException">Always thrown.</exception>
        public override void SetLength(long value)
        {
            throw new NotSupportedException("SetLength is not supported");
        }

        /// <summary>
        /// Releases the unmanaged resources used by the stream and optionally releases the managed resources.
        /// Returns all ArrayPool chunks back to the shared pool.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        protected override void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                try
                {
                    // Return all chunks to ArrayPool
                    foreach (var chunk in _chunks)
                    {
                        ArrayPool<byte>.Shared.Return(chunk);
                    }
                    _chunks.Clear();
                }
                catch (Exception)
                {
                    // Suppress exceptions in Dispose - continue cleanup
                }

                _disposed = true;
            }

            base.Dispose(disposing);
        }
    }
}
