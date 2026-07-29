/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
#if !NETFRAMEWORK
using System;
using System.IO;
using ThirdParty.RuntimeBackports;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// A seekable, read-only stream backed by an ArrayPoolBufferWriter.
    /// Used as request.ContentStream to avoid byte[] copies in the marshalling pipeline.
    /// Disposing returns the pooled buffer.
    /// </summary>
    public sealed class PooledContentStream : Stream
    {
        private ArrayPoolBufferWriter<byte> _writer;
        private int _position;

        /// <summary>
        /// Creates a new PooledContentStream with its own ArrayPoolBufferWriter.
        /// Use <see cref="BufferWriter"/> to write content before setting as ContentStream.
        /// </summary>
        public PooledContentStream()
        {
            _writer = new ArrayPoolBufferWriter<byte>();
        }

        /// <summary>
        /// Creates a new PooledContentStream whose underlying buffer is rented with at least
        /// <paramref name="initialCapacity"/> bytes. Use this when the final content size is known
        /// up front (e.g. CBOR's writer.BytesWritten) to rent a right-sized buffer immediately and
        /// avoid the default-size rent followed by a resize+return.
        /// </summary>
        /// <param name="initialCapacity">The minimum capacity to rent for the underlying buffer.</param>
        public PooledContentStream(int initialCapacity)
        {
            _writer = new ArrayPoolBufferWriter<byte>(initialCapacity);
        }

        /// <summary>
        /// The underlying buffer writer. Use this to write content (e.g. via Utf8JsonWriter or XmlWriter).
        /// Must not be accessed after the stream is set as ContentStream and pipeline processing begins.
        /// </summary>
        public ArrayPoolBufferWriter<byte> BufferWriter => _writer;

        /// <summary>
        /// The written content as a contiguous memory region.
        /// Pipeline consumers use this for zero-copy access to the request body.
        /// </summary>
        public ReadOnlyMemory<byte> Content => _writer?.WrittenMemory ?? ReadOnlyMemory<byte>.Empty;

        public override bool CanRead => true;
        public override bool CanSeek => true;
        public override bool CanWrite => false;
        public override long Length => _writer?.WrittenCount ?? 0;

        public override long Position
        {
            get => _position;
            set
            {
                if (value < 0 || value > Length)
                    throw new ArgumentOutOfRangeException(nameof(value));
                _position = (int)value;
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (_writer == null)
                throw new ObjectDisposedException(nameof(PooledContentStream));

            var source = _writer.WrittenMemory;
            int available = source.Length - _position;
            if (available <= 0)
                return 0;

            int toCopy = Math.Min(count, available);
            source.Slice(_position, toCopy).Span.CopyTo(buffer.AsSpan(offset, toCopy));
            _position += toCopy;
            return toCopy;
        }

#if NET8_0_OR_GREATER
        public override int Read(Span<byte> buffer)
        {
            if (_writer == null)
                throw new ObjectDisposedException(nameof(PooledContentStream));

            var source = _writer.WrittenMemory;
            int available = source.Length - _position;
            if (available <= 0)
                return 0;

            int toCopy = Math.Min(buffer.Length, available);
            source.Slice(_position, toCopy).Span.CopyTo(buffer.Slice(0, toCopy));
            _position += toCopy;
            return toCopy;
        }
#endif

        public override long Seek(long offset, SeekOrigin origin)
        {
            if (_writer == null)
                throw new ObjectDisposedException(nameof(PooledContentStream));

            long newPosition = origin switch
            {
                SeekOrigin.Begin => offset,
                SeekOrigin.Current => _position + offset,
                SeekOrigin.End => _writer.WrittenCount + offset,
                _ => throw new ArgumentOutOfRangeException(nameof(origin))
            };
            if (newPosition < 0 || newPosition > _writer.WrittenCount)
                throw new ArgumentOutOfRangeException(nameof(offset));

            _position = (int)newPosition;
            return _position;
        }

        public override void Flush() { }
        public override void SetLength(long value) => throw new NotSupportedException();
        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _writer?.Dispose();
                _writer = null;
                _position = 0;
            }
            base.Dispose(disposing);
        }
    }
}
#endif
