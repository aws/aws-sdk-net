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

using System;
using System.IO;
using System.IO.Hashing;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// A <see cref="Stream"/> that calculates a CRC-32 (a checksum) over all bytes read,
    /// or over all bytes written, as they flow through an inner stream. The stream should be
    /// used to either read or write, but not both; intermixing reads and writes produces
    /// undefined results.
    /// <para>
    /// The running CRC-32 can be read at any time via <see cref="Crc32"/> without resetting
    /// the calculation, which allows callers to validate a checksum partway through a stream
    /// and then continue accumulating (for example, the event stream framing checks).
    /// </para>
    /// <para>
    /// This uses <see cref="System.IO.Hashing.Crc32"/> configured with
    /// <see cref="Crc32ParameterSet.Crc32"/> (the standard zlib/PKZIP CRC-32), matching
    /// <see cref="Crc32Managed"/>.
    /// </para>
    /// </summary>
    public class Crc32Stream : Stream
    {
        private readonly Stream _innerStream;
        private readonly Crc32 _crc32 = new Crc32(Crc32ParameterSet.Crc32);
        private readonly long _length;
        private long _totalBytesProcessed;

        /// <summary>
        /// Constructs a stream that calculates a CRC-32 over all bytes read or written.
        /// </summary>
        /// <param name="stream">The underlying stream.</param>
        public Crc32Stream(Stream stream)
        {
            _innerStream = stream ?? throw new ArgumentNullException(nameof(stream));
        }

        /// <summary>
        /// Constructs a stream that calculates a CRC-32 over all bytes read or written, limiting
        /// the number of bytes read from the underlying stream to <paramref name="length"/>.
        /// </summary>
        /// <param name="stream">The underlying stream.</param>
        /// <param name="length">The maximum number of bytes to read from the underlying stream.</param>
        public Crc32Stream(Stream stream, long length)
        {
            _innerStream = stream ?? throw new ArgumentNullException(nameof(stream));
            _length = length;
        }

        /// <summary>
        /// Provides the current CRC-32 for all bytes processed so far.
        /// </summary>
        public int Crc32
        {
            get { return unchecked((int)_crc32.GetCurrentHashAsUInt32()); }
        }

        /// <summary>
        /// Gets the total number of bytes run through the CRC-32 calculator.
        /// </summary>
        public long TotalBytesSlurped
        {
            get { return _totalBytesProcessed; }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int bytesToRead = count;

            // If a length was provided, limit the number of bytes returned so we don't
            // "over-read" the underlying stream past the intended content.
            if (_length != 0)
            {
                if (_totalBytesProcessed >= _length) return 0; // EOF
                long bytesRemaining = _length - _totalBytesProcessed;
                if (bytesRemaining < count) bytesToRead = (int)bytesRemaining;
            }

            int n = _innerStream.Read(buffer, offset, bytesToRead);
            if (n > 0)
            {
                _crc32.Append(new ReadOnlySpan<byte>(buffer, offset, n));
                _totalBytesProcessed += n;
            }
            return n;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            if (count > 0)
            {
                _crc32.Append(new ReadOnlySpan<byte>(buffer, offset, count));
                _totalBytesProcessed += count;
            }
            _innerStream.Write(buffer, offset, count);
        }

        public override bool CanRead
        {
            get { return _innerStream.CanRead; }
        }

        public override bool CanSeek
        {
            // Seeking would invalidate the running CRC, so this stream never supports it
            // (regardless of the inner stream's capability), matching HashStream.
            get { return false; }
        }

        public override bool CanWrite
        {
            get { return _innerStream.CanWrite; }
        }

        public override void Flush()
        {
            _innerStream.Flush();
        }

        public override long Length
        {
            // When a length cap was provided, report it. Otherwise defer to the inner stream
            // rather than returning 0 (which would make the stream appear empty). The inner
            // stream throws NotSupportedException if it does not support Length.
            get { return _length != 0 ? _length : _innerStream.Length; }
        }

        public override long Position
        {
            get { return _totalBytesProcessed; }
            set { throw new NotImplementedException(); }
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }
    }
}
