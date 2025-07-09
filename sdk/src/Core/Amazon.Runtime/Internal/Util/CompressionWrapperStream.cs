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

using Amazon.Util;
using Amazon.Runtime.Internal.Compression;
using System.IO;
using System.Threading;
using System;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Wrapper stream class for compressing a stream
    /// </summary>
    public class CompressionWrapperStream : WrapperStream
    {
        private Stream _compressionStream;
        private ICompressionAlgorithm _compressionAlgorithm;
        private MemoryStream _outputBufferStream;
        private bool _hitEnd;
        private readonly int _defaultChunkSize = AWSSDKUtils.DefaultBufferSize;
        private byte[] _inputBuffer;

        /// <summary>
        /// Constructs a new instance of <see cref="CompressionWrapperStream"/> class and initializes fields needed for compressing a stream.
        /// </summary>
        /// <param name="baseStream">The stream that we want to read from before compressing it</param>
        /// <param name="compressionAlgorithm">The compression algorithm that want to use</param>
        public CompressionWrapperStream(Stream baseStream, ICompressionAlgorithm compressionAlgorithm) : base(baseStream)
        {
            _compressionAlgorithm = compressionAlgorithm;
            Init();
        }

        /// <summary>
        /// Initializes fields needed for compressing a stream.
        /// </summary>
        private void Init()
        {
            _outputBufferStream = new MemoryStream();
            _compressionStream = _compressionAlgorithm.GetCompressionStream(_outputBufferStream);
            _hitEnd = false;
            _inputBuffer = new byte[_defaultChunkSize];
        }

        /// <summary>
        /// Resets all compression stream resources.
        /// </summary>
        public void Reset()
        {
            Init();
        }

        /// <summary>
        /// Reads a sequence of bytes from the current stream and compresses it. The compressed bytes
        /// are written into internal buffer <see cref="_outputBufferStream"/>. If the count of compressed bytes
        /// is larger than <paramref name="count"/>, we still write the leftover bytes into the internal buffer.
        /// We then write the compressed bytes into the <paramref name="buffer"/> up to <paramref name="count"/>.
        /// However, if we have leftover bytes from previous iteration(s), we would not read or compress the stream, 
        /// but instead, we would write leftover bytes into the <paramref name="buffer"/> up to <paramref name="count"/>.
        /// </summary>
        /// <param name="buffer">
        /// An array of bytes. When this method returns, the buffer contains the specified
        /// byte array with the values between offset and (offset + count - 1) replaced
        /// by the bytes read from the current source.
        /// </param>
        /// <param name="offset">
        /// The zero-based byte offset in buffer at which to begin storing the data read
        /// from the current stream.
        /// </param>
        /// <param name="count">
        /// The maximum number of bytes to be read from the current stream.
        /// </param>
        /// <returns>
        /// The total number of compressed bytes returned into the buffer. This can be less than the
        /// number of bytes requested if that many bytes are not currently available,
        /// or zero (0) if the end of the stream has been reached.
        /// </returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            // read leftover bytes from last compressed chunk
            if (_outputBufferStream.Position < _outputBufferStream.Length)
            {
                return _outputBufferStream.Read(buffer, offset, count);
            }
            else
            {
                // Reset last compressed chunk MemoryStream which has been consumed
                _outputBufferStream.SetLength(0);

                // Loop while GzipStream has not written data to the compressed stream or we haven't read the full stream yet
                while (_outputBufferStream.Length == 0 && !_hitEnd)
                {
                    var readCount = BaseStream.Read(_inputBuffer, 0, _inputBuffer.Length);
                    if (readCount == 0)
                    {
                        _hitEnd = true;
                        // .Flush() does not release all _compressionStream resources; hence why we used .Dispose() instead
                        _compressionStream.Dispose();
                    }
                    else
                    {
                        _compressionStream.Write(_inputBuffer, 0, readCount);
                    }
                }

                _outputBufferStream.Position = 0;
                return _outputBufferStream.Read(buffer, offset, count);
            }
        }

        /// <summary>
        /// Reads a sequence of bytes from the current stream and compresses it. The compressed bytes
        /// are written into internal buffer <see cref="_outputBufferStream"/>. If the count of compressed bytes
        /// is larger than <paramref name="count"/>, we still write the leftover bytes into the internal buffer.
        /// We then write the compressed bytes into the <paramref name="buffer"/> up to <paramref name="count"/>.
        /// However, if we have leftover bytes from previous iteration(s), we would not read or compress the stream, 
        /// but instead, we would write leftover bytes into the <paramref name="buffer"/> up to <paramref name="count"/>.
        /// </summary>
        /// <param name="buffer">
        /// An array of bytes. When this method returns, the buffer contains the specified
        /// byte array with the values between offset and (offset + count - 1) replaced
        /// by the bytes read from the current source.
        /// </param>
        /// <param name="offset">
        /// The zero-based byte offset in buffer at which to begin storing the data read
        /// from the current stream.
        /// </param>
        /// <param name="count">
        /// The maximum number of bytes to be read from the current stream.
        /// </param>
        /// <param name="cancellationToken">
        /// The token to monitor for cancellation requests.
        /// </param>
        /// <returns>
        /// The total number of compressed bytes returned into the buffer. This can be less than the
        /// number of bytes requested if that many bytes are not currently available,
        /// or zero (0) if the end of the stream has been reached.
        /// </returns>
        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
             // read leftover bytes from last compressed chunk
            if (_outputBufferStream.Position < _outputBufferStream.Length)
            {
                return await _outputBufferStream.ReadAsync(buffer, offset, count).ConfigureAwait(false);
            }
            else
            {
                // Reset last compressed chunk MemoryStream which has been consumed
                _outputBufferStream.SetLength(0);

                // Loop while GzipStream has not written data to the compressed stream or we haven't read the full stream yet
                while (_outputBufferStream.Length == 0 && !_hitEnd)
                {
                    var readCount = await BaseStream.ReadAsync(_inputBuffer, 0, _inputBuffer.Length).ConfigureAwait(false);
                    if (readCount == 0)
                    {
                        _hitEnd = true;
                        // .Flush() does not release all _compressionStream resources; hence why we used .Dispose() instead
                        _compressionStream.Dispose();
                    }
                    else
                    {
                        await _compressionStream.WriteAsync(_inputBuffer, 0, readCount).ConfigureAwait(false);
                    }
                }

                _outputBufferStream.Position = 0;
                return await _outputBufferStream.ReadAsync(buffer, offset, count).ConfigureAwait(false);
            }
        }

#if !NETSTANDARD
        /// <summary>
        /// Closes the compression and memory streams
        /// </summary>
        public override void Close()
        {
            _compressionStream.Close();
            _outputBufferStream.Close();
            base.Close();
        }
#endif

        /// <summary>
        /// Disposes the compression and memory streams
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _compressionStream.Dispose();
                _outputBufferStream.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// HasLength is false when compressing a stream. This avoids the client
        /// needing to read and compress the entire stream prior to sending the request.
        /// </summary>
        internal override bool HasLength
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// <see cref="CompressionWrapperStream"/> does not support seeking, this will always be false.
        /// </summary>
        public override bool CanSeek
        {
            get 
            { 
                return false;
            }
        }

        /// <summary>
        /// Gets or sets the position within the current stream.
        /// CompressionWrapperStream does not support seeking, attempting to set Position
        /// will throw NotSupportedException.
        /// </summary>
        public override long Position
        {
            get
            {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
                throw new NotSupportedException("CompressionWrapperStream does not support seeking");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
            }
            set
            {
                throw new NotSupportedException("CompressionWrapperStream does not support seeking");
            }
        }
    }
}