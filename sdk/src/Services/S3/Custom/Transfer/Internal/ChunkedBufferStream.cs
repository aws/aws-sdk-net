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
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// A writable and readable stream that stores data across multiple small ArrayPool buffers,
    /// avoiding the 2GB array size limitation and Large Object Heap (LOH) allocations.
    /// </summary>
    /// <remarks>
    /// <para><strong>Design Goals:</strong></para>
    /// <list type="bullet">
    /// <item>Keep each buffer chunk below 85KB to avoid LOH allocation (default)</item>
    /// <item>Support parts larger than 2GB (int.MaxValue)</item>
    /// <item>Efficient memory management via ArrayPool</item>
    /// <item>Present standard Stream interface for easy integration</item>
    /// <item>Allow configurable chunk size for performance tuning</item>
    /// </list>
    /// 
    /// <para><strong>Size Limits:</strong></para>
    /// <para>
    /// Maximum supported stream size is approximately 140TB (int.MaxValue * chunkSize bytes).
    /// This limit exists because chunk indexing uses int for List indexing.
    /// </para>
    /// 
    /// <para><strong>Usage Pattern:</strong></para>
    /// <code>
    /// var stream = new ChunkedBufferStream(expectedSize, chunkSize);
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
        /// Default chunk size of 64KB - matches ArrayPool bucket size and stays below the 85KB Large Object Heap threshold.
        /// If we chose any higher than 64KB, ArrayPool would round up to 128KB (which would go to LOH).
        /// </summary>
        private const int DEFAULT_CHUNK_SIZE = 65536; // 64KB - matches ArrayPool bucket, safely below 85KB LOH threshold


        private readonly List<byte[]> _chunks;
        private readonly int _chunkSize;
        private readonly long _maxStreamSize;
        private readonly Logger _logger = Logger.GetLogger(typeof(ChunkedBufferStream));
        private long _length = 0;
        private long _position = 0;
        private bool _isReadMode = false;
        private bool _disposed = false;

        /// <summary>
        /// Creates a new ChunkedBufferStream with pre-allocated capacity for the expected size.
        /// This avoids List resizing during writes, improving performance for known sizes.
        /// </summary>
        /// <param name="estimatedSize">The estimated total size in bytes. Must be greater than 0. Used to pre-allocate the chunk list capacity.</param>
        /// <param name="chunkSize">The size of each buffer chunk. Defaults to 64KB if not specified.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when estimatedSize is less than or equal to 0.</exception>
        public ChunkedBufferStream(long estimatedSize, int? chunkSize = null)
        {
            if (estimatedSize <= 0)
                throw new ArgumentOutOfRangeException(nameof(estimatedSize), "EstimatedSize must be greater than 0");

            int requestedChunkSize = chunkSize ?? DEFAULT_CHUNK_SIZE;

            // Validate that chunk size doesn't exceed data size to prevent memory waste
            if (chunkSize.HasValue && requestedChunkSize > estimatedSize)
                throw new ArgumentOutOfRangeException(nameof(chunkSize),
                    $"Chunk size ({requestedChunkSize:N0} bytes) cannot exceed estimated data size ({estimatedSize:N0} bytes). " +
                    "For multipart downloads, chunk size should be less than or equal to part size.");

            _chunkSize = requestedChunkSize;
            _maxStreamSize = (long)int.MaxValue * _chunkSize;

            // Ceiling division formula: (n + d - 1) / d calculates ceil(n / d) using integer arithmetic.
            // This computes how many chunks are needed to hold estimatedSize bytes, rounding up to
            // ensure the last partial chunk is accounted for. Avoids floating-point math for performance.
            // Example: For 100 bytes with _chunkSize=32: (100 + 31) / 32 = 131 / 32 = 4 chunks
            //          (simple division 100/32=3 would only hold 96 bytes, losing 4 bytes)
            long estimatedChunks = (estimatedSize + _chunkSize - 1) / _chunkSize;
            int capacity = (int)Math.Min(estimatedChunks, int.MaxValue);
            _chunks = new List<byte[]>(capacity);
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
            if (_length > _maxStreamSize - count)
                throw new IOException($"Write would exceed maximum supported stream size of {_maxStreamSize} bytes.");

            int remaining = count;
            int sourceOffset = offset;

            while (remaining > 0)
            {
                // Calculate which chunk and offset within chunk for current write position
                int chunkIndex = (int)(_length / _chunkSize);
                int offsetInChunk = (int)(_length % _chunkSize);

                // Allocate new chunk if we've filled all existing chunks
                if (chunkIndex >= _chunks.Count)
                {
                    _chunks.Add(ArrayPool<byte>.Shared.Rent(_chunkSize));
                }

                // Copy data to current chunk
                int bytesToWrite = Math.Min(remaining, _chunkSize - offsetInChunk);
                Buffer.BlockCopy(buffer, sourceOffset, _chunks[chunkIndex], offsetInChunk, bytesToWrite);

                _length += bytesToWrite;
                sourceOffset += bytesToWrite;
                remaining -= bytesToWrite;
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
                int chunkIndex = (int)(_position / _chunkSize);
                int offsetInChunk = (int)(_position % _chunkSize);
                int bytesInThisChunk = Math.Min(bytesToRead - bytesRead, _chunkSize - offsetInChunk);

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
                // Return all chunks to ArrayPool
                foreach (var chunk in _chunks)
                {
                    try
                    {
                        ArrayPool<byte>.Shared.Return(chunk);
                    }
                    catch (Exception ex)
                    {
                        // Suppress exceptions in Dispose - continue cleanup
                        _logger.DebugFormat("ChunkedBufferStream.Dispose: Exception returning chunk to ArrayPool: {0}", ex.Message);
                    }
                }
                try
                {
                    _chunks.Clear();
                }
                catch (Exception ex)
                {
                    // Suppress exceptions in Dispose - continue cleanup
                    _logger.DebugFormat("ChunkedBufferStream.Dispose: Exception clearing chunks list: {0}", ex.Message);
                }
                _disposed = true;
            }

            base.Dispose(disposing);
        }
    }
}
