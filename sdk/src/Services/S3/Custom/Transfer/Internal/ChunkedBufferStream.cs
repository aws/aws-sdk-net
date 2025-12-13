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
    /// Maximum supported stream size is approximately 175TB (int.MaxValue * CHUNK_SIZE bytes).
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
    /// // Switch to read mode
    /// stream.SwitchToReadMode();
    /// 
    /// // Read phase: Stream data out
    /// int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
    /// 
    /// // Cleanup: Returns all chunks to ArrayPool
    /// stream.Dispose();
    /// </code>
    /// </remarks>
    internal class ChunkedBufferStream : Stream
    {
        /// <summary>
        /// Size of each buffer chunk. Set to 80KB to safely stay below the 85KB Large Object Heap threshold.
        /// </summary>
        private const int CHUNK_SIZE = 81920; // 80KB - safely below 85KB LOH threshold

        /// <summary>
        /// Maximum supported stream size. This limit exists because chunk indexing uses int for List indexing.
        /// With 80KB chunks, this allows approximately 175TB of data.
        /// </summary>
        private const long MAX_STREAM_SIZE = (long)int.MaxValue * CHUNK_SIZE;

        private readonly List<byte[]> _chunks = new List<byte[]>();
        private long _length = 0;
        private long _position = 0;
        private bool _isReadMode = false;
        private bool _disposed = false;

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
        /// Returns true only after <see cref="SwitchToReadMode"/> has been called.
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

            int remaining = count;
            int sourceOffset = offset;

            while (remaining > 0)
            {
                // Calculate which chunk and offset within chunk for current write position
                int chunkIndex = (int)(_length / CHUNK_SIZE);
                int offsetInChunk = (int)(_length % CHUNK_SIZE);

                // Allocate new chunk if we've filled all existing chunks
                if (chunkIndex >= _chunks.Count)
                {
                    _chunks.Add(ArrayPool<byte>.Shared.Rent(CHUNK_SIZE));
                }

                // Copy data to current chunk
                int bytesToWrite = Math.Min(remaining, CHUNK_SIZE - offsetInChunk);
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
        /// </summary>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing data.</param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <returns>
        /// The total number of bytes read into the buffer. This can be less than the requested count
        /// if that many bytes are not currently available, or zero if the end of the stream is reached.
        /// </returns>
        /// <exception cref="ObjectDisposedException">Thrown if the stream has been disposed.</exception>
        /// <exception cref="InvalidOperationException">Thrown if <see cref="SwitchToReadMode"/> has not been called.</exception>
        /// <exception cref="ArgumentNullException">Thrown if buffer is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if offset or count is negative or exceeds buffer bounds.</exception>
        public override int Read(byte[] buffer, int offset, int count)
        {
            ThrowIfDisposed();
            
            if (!_isReadMode)
                throw new InvalidOperationException("Must call SwitchToReadMode() before reading");

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
                int chunkIndex = (int)(_position / CHUNK_SIZE);
                int offsetInChunk = (int)(_position % CHUNK_SIZE);
                int bytesInThisChunk = Math.Min(bytesToRead - bytesRead, CHUNK_SIZE - offsetInChunk);

                Buffer.BlockCopy(_chunks[chunkIndex], offsetInChunk, buffer, offset + bytesRead, bytesInThisChunk);

                _position += bytesInThisChunk;
                bytesRead += bytesInThisChunk;
            }

            return bytesRead;
        }

        /// <summary>
        /// Asynchronously reads a sequence of bytes from the stream.
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
        /// Must be called after all writing is complete and before reading begins.
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
