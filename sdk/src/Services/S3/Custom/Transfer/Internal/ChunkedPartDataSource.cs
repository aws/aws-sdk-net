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
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// IPartDataSource implementation that wraps a ChunkedBufferStream for large buffered parts
    /// </summary>
    /// <remarks>
    /// <para><strong>Purpose:</strong></para>
    /// <list type="bullet">
    /// <item>Wraps ChunkedBufferStream to present IPartDataSource interface</item>
    /// <item>Enables seamless integration with PartBufferManager</item>
    /// <item>Handles disposal of underlying ChunkedBufferStream</item>
    /// </list>
    /// 
    /// <para><strong>Lifecycle:</strong></para>
    /// <code>
    /// // Created in BufferedPartDataHandler for large parts
    /// var chunkedStream = new ChunkedBufferStream();
    /// await response.WriteResponseStreamAsync(chunkedStream, ...);
    /// chunkedStream.SwitchToReadMode();
    /// var dataSource = new ChunkedPartDataSource(partNumber, chunkedStream);
    /// 
    /// // Added to PartBufferManager
    /// _partBufferManager.AddDataSource(dataSource);
    /// 
    /// // Consumer reads sequentially
    /// await dataSource.ReadAsync(buffer, offset, count, ct);
    /// 
    /// // Disposed by PartBufferManager when part is consumed
    /// dataSource.Dispose(); // Returns all chunks to ArrayPool
    /// </code>
    /// </remarks>
    internal class ChunkedPartDataSource : IPartDataSource
    {
        private readonly ChunkedBufferStream _stream;
        private bool _disposed = false;

        /// <summary>
        /// Gets the part number for this data source.
        /// Used by PartBufferManager for sequential ordering.
        /// </summary>
        public int PartNumber { get; }

        /// <summary>
        /// Gets whether this data source has been fully consumed.
        /// Returns true when all data has been read from the chunked buffer stream.
        /// </summary>
        public bool IsComplete => _stream.Position >= _stream.Length;

        /// <summary>
        /// Creates a new ChunkedPartDataSource wrapping a ChunkedBufferStream.
        /// The ChunkedBufferStream must already be in read mode (SwitchToReadMode called).
        /// Takes ownership of the stream and will dispose it when this data source is disposed.
        /// </summary>
        /// <param name="partNumber">The part number for ordering.</param>
        /// <param name="stream">The ChunkedBufferStream containing the buffered part data. Must be in read mode.</param>
        /// <exception cref="ArgumentNullException">Thrown if stream is null.</exception>
        /// <exception cref="InvalidOperationException">Thrown if the stream is not in read mode (CanRead is false).</exception>
        public ChunkedPartDataSource(int partNumber, ChunkedBufferStream stream)
        {
            PartNumber = partNumber;
            _stream = stream ?? throw new ArgumentNullException(nameof(stream));
            
            if (!_stream.CanRead)
                throw new InvalidOperationException("ChunkedBufferStream must be in read mode (call SwitchToReadMode first)");
        }

        /// <summary>
        /// Asynchronously reads a sequence of bytes from the chunked buffer stream.
        /// </summary>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing data.</param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>
        /// A task representing the asynchronous read operation. The task result contains the total number
        /// of bytes read into the buffer. This can be less than the requested count if that many bytes
        /// are not currently available, or zero if the end of the stream is reached.
        /// </returns>
        /// <exception cref="ObjectDisposedException">Thrown if the object has been disposed.</exception>
        public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(ChunkedPartDataSource));
            
            return _stream.ReadAsync(buffer, offset, count, cancellationToken);
        }

        /// <summary>
        /// Returns a string representation of this ChunkedPartDataSource for debugging.
        /// </summary>
        /// <returns>A string describing this chunked part data source.</returns>
        public override string ToString()
        {
            return $"ChunkedPartDataSource(Part={PartNumber}, Length={_stream.Length} bytes, Position={_stream.Position})";
        }


        /// <summary>
        /// Releases all resources used by this ChunkedPartDataSource.
        /// Disposes the underlying ChunkedBufferStream, which returns all ArrayPool chunks.
        /// </summary>
        public void Dispose()
        {
            if (!_disposed)
            {
                _stream?.Dispose();
                _disposed = true;
            }
        }
    }
}
