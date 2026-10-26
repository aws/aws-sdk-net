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
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// A wrapper around Utf8JsonReader that can handle reading from a stream.
    /// </summary>
    public ref struct StreamingUtf8JsonReader
    {
        private Utf8JsonReader _reader;

        /// <summary>
        /// A copy of the underlying <see cref="Utf8JsonReader"/>, positioned on the current token.
        /// Reading it fills the first buffer if the stream has not been read yet.
        /// </summary>
        /// <remarks>
        /// Each access copies the whole reader struct. Use it only for one-off checks that have no forwarding
        /// member here, such as <see cref="Utf8JsonReader.IsFinalBlock"/> before the first <see cref="Read"/>
        /// to detect an empty body. Per-token code should use the forwarding members of this struct
        /// (<see cref="TokenType"/>, <see cref="GetString"/>, <see cref="TryGetInt32"/>, ...), which do not copy.
        /// </remarks>
        public Utf8JsonReader Reader
        {
            get
            {
                if (!_hasReadFromStream)
                {
                    ReadFirstBuffer();
                }

                return _reader;
            }
        }

        /// <summary>
        /// Compares the UTF-8 encoded text of the current JSON token value (e.g. a property name)
        /// to the supplied text for equality, without allocating a string and without copying the
        /// underlying <see cref="Utf8JsonReader"/>. Escaped characters in the JSON are unescaped
        /// before comparison, and the comparison is ordinal (case-sensitive).
        /// </summary>
        /// <param name="text">The text to compare against the current token value.</param>
        /// <returns>True if the current token value matches <paramref name="text"/>.</returns>
        public bool ValueTextEquals(string text)
        {
            // Pass the chars as a span. netstandard2.0 has no implicit string -> ReadOnlySpan<char>
            // conversion, so AsSpan() is used explicitly; it is allocation-free.
            return _reader.ValueTextEquals(text.AsSpan());
        }

        // The TryGet* methods below forward to the underlying Utf8JsonReader without copying it,
        // which reading through the Reader property would do.

        /// <summary>
        /// Tries to parse the current JSON token value as an <see cref="int"/>.
        /// </summary>
        public bool TryGetInt32(out int value)
        {
            return _reader.TryGetInt32(out value);
        }

        /// <summary>
        /// Tries to parse the current JSON token value as a <see cref="long"/>.
        /// </summary>
        public bool TryGetInt64(out long value)
        {
            return _reader.TryGetInt64(out value);
        }

        /// <summary>
        /// Tries to parse the current JSON token value as a <see cref="float"/>.
        /// </summary>
        public bool TryGetSingle(out float value)
        {
            return _reader.TryGetSingle(out value);
        }

        /// <summary>
        /// Tries to parse the current JSON token value as a <see cref="double"/>.
        /// </summary>
        public bool TryGetDouble(out double value)
        {
            return _reader.TryGetDouble(out value);
        }

        /// <summary>
        /// Tries to parse the current JSON token value as a <see cref="decimal"/>.
        /// </summary>
        public bool TryGetDecimal(out decimal value)
        {
            return _reader.TryGetDecimal(out value);
        }

        /// <summary>
        /// Tries to parse the current JSON token value as a <see cref="byte"/>.
        /// </summary>
        public bool TryGetByte(out byte value)
        {
            return _reader.TryGetByte(out value);
        }

        /// <summary>
        /// Tries to decode the current JSON string token value from Base64.
        /// </summary>
        public bool TryGetBytesFromBase64(out byte[] value)
        {
            return _reader.TryGetBytesFromBase64(out value);
        }

        /// <summary>
        /// The type of the current JSON token.
        /// </summary>
        public JsonTokenType TokenType => _reader.TokenType;

        /// <summary>
        /// The raw UTF-8 bytes of the current JSON token value.
        /// </summary>
        public ReadOnlySpan<byte> ValueSpan => _reader.ValueSpan;

        /// <summary>
        /// Reads the current JSON string or property name token value as a <see cref="string"/>.
        /// </summary>
        public string GetString()
        {
            return _reader.GetString();
        }

        /// <summary>
        /// Reads the current JSON true or false token value as a <see cref="bool"/>.
        /// </summary>
        public bool GetBoolean()
        {
            return _reader.GetBoolean();
        }

        private Stream _stream;
        private byte[] _buffer;
        private bool _hasReadFromStream;
        private bool _bufferReturned;

        /// <summary>
        /// Initializes a new instance of the StreamingUtf8JsonReader. The stream is not read until the first call to <see cref="Read"/>, which fills the buffer.
        /// If a UTF8 BOM is present in the stream, it will be skipped. Unless <see cref="AWSConfigs.StreamingUtf8JsonReaderBufferSize"/> is set, the default
        /// buffer size for buffering data from the stream will be 4096. You can also use the constructor that accepts bufferSize to change this value.
        /// </summary>
        /// <param name="stream">the stream containing the data</param>
        public StreamingUtf8JsonReader(Stream stream) : this(stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StreamingUtf8JsonReader. The stream is not read until the first call to <see cref="Read"/>, which fills the buffer.
        /// If a UTF8 BOM is present in the stream, it will be skipped.
        /// </summary>
        /// <param name="stream">the stream containing the data</param>
        /// <param name="bufferSize">the size of the buffer when reading data from the stream</param>
        /// <exception cref="ArgumentException"></exception>
        public StreamingUtf8JsonReader(Stream stream, int bufferSize) : this(stream, bufferSize, JsonConstants.JsonMaxDepth)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StreamingUtf8JsonReader with a custom maximum JSON depth.
        /// The stream is not read until the first call to <see cref="Read"/>, which fills the buffer.
        /// If a UTF8 BOM is present in the stream, it will be skipped.
        /// </summary>
        /// <param name="stream">the stream containing the data</param>
        /// <param name="bufferSize">the size of the buffer when reading data from the stream</param>
        /// <param name="maxDepth">the maximum depth allowed when reading JSON data</param>
        /// <exception cref="ArgumentException"></exception>
        public StreamingUtf8JsonReader(Stream stream, int bufferSize, int maxDepth)
        {
            if (stream is null)
                throw new ArgumentException("Stream must not be null. Please initialize a stream and pass it into the constructor.");

            _stream = stream;
            _buffer = ArrayPool<byte>.Shared.Rent(bufferSize);
            Debug.Assert(_buffer.Length >= JsonConstants.Utf8Bom.Length);

            var options = new JsonReaderOptions
            {
                AllowTrailingCommas = true,
                MaxDepth = maxDepth
            };
            // The stream is first read on the first Read(), not here. Generated code constructs this reader before
            // it knows whether the body is JSON: an event stream event whose payload is a raw blob or string hands
            // context.Stream to the caller as-is, and reading here would leave that stream positioned past the first buffer.
            _reader = new Utf8JsonReader(ReadOnlySpan<byte>.Empty, isFinalBlock: false, new JsonReaderState(options));
        }

        /// <summary>
        /// Reads data from the buffer and fetches more data from the stream to fill the buffer it more data exists.
        /// </summary>
        /// <returns>true if there is more data, false otherwise.</returns>
        public bool Read()
        {
            if (_bufferReturned)
            {
                // The document has been fully read and the buffer handed back to the pool; there
                // is nothing left to read and the pooled array must not be touched again.
                return false;
            }

            if (!_hasReadFromStream)
            {
                ReadFirstBuffer();
            }

            // hasMoreData can return false if the value starts in one buffer and leaks into the next buffer
            bool hasMoreData = _reader.Read();

            while (!hasMoreData)
            {
                if (_reader.IsFinalBlock)
                {
                    ReturnBuffer();
                    break;
                }

                GetMoreBytesFromStream(_stream, ref _buffer, ref _reader);

                hasMoreData = _reader.Read();
            }

            // Generated unmarshallers stop reading at the closing token of the root value and never read past the end of
            // the document, so the buffer would otherwise only be returned to the pool when a caller reads to end-of-stream.
            // A JSON document has a single root value, so once its closing token has been read the buffer can be released.
            if (hasMoreData && _reader.CurrentDepth == 0 &&
                (_reader.TokenType == JsonTokenType.EndObject || _reader.TokenType == JsonTokenType.EndArray))
            {
                ReturnBuffer();
            }

            return hasMoreData;
        }

        private void ReturnBuffer()
        {
            if (!_bufferReturned)
            {
                _bufferReturned = true;
                ArrayPool<byte>.Shared.Return(_buffer);
            }
        }

        private void ReadFirstBuffer()
        {
            _hasReadFromStream = true;

            int bytesRead = FillBuffer(_stream, ref _buffer, 0, _buffer.Length);
            int start = 0;
            if (_buffer.AsSpan(0, bytesRead).StartsWith(JsonConstants.Utf8Bom))
            {
                start = JsonConstants.Utf8Bom.Length;
                bytesRead -= start;
            }

            _reader = new Utf8JsonReader(_buffer.AsSpan(start, bytesRead), isFinalBlock: bytesRead == 0, _reader.CurrentState);
        }

        private static void GetMoreBytesFromStream(Stream stream, ref byte[] buffer, ref Utf8JsonReader reader)
        {
            int bytesRead = 0;
            ReadOnlySpan<byte> leftover = buffer.AsSpan().Slice((int)reader.BytesConsumed);
            if (reader.BytesConsumed < buffer.Length)
            {
                // If BytesConsumed is 0 that means that the previous Read failed because the JSON token was too large to fit in the buffer.
                // In that case we need to resize the buffer and try again to read the JSON token.
                if (reader.BytesConsumed == 0)
                {
                    var resizedBuffer = ArrayPool<byte>.Shared.Rent(Math.Min(int.MaxValue, (buffer.Length * 2)));
                    Logger.GetLogger(typeof(StreamingUtf8JsonReader)).DebugFormat("Resizing buffer from {0} to {1}", buffer.Length, resizedBuffer.Length);
                    // copy over the data from the previous read's buffer to the newly resized buffer.
                    buffer.AsSpan().CopyTo(resizedBuffer);
                    // return the previous buffer to the pool and set the new buffer to equal the resized buffer.
                    ArrayPool<byte>.Shared.Return(buffer);
                    buffer = resizedBuffer;
                    // fill the new resized buffer with data from the stream. the offset MUST be leftover.Length 
                    // so we don't overwrite the data that was copied from the previous buffer, and the number of bytes
                    // we read must be buffer.Length - leftover.Length which is just the second half of the buffer.
                    bytesRead = FillBuffer(stream, ref buffer, leftover.Length, buffer.Length - leftover.Length);
                    var resizedSpan = buffer.AsSpan(0, bytesRead + leftover.Length);
                    reader = new Utf8JsonReader(resizedSpan, isFinalBlock: bytesRead == 0, reader.CurrentState);
                    // early return since we have a reader
                    return;
                }
                else
                {
                    // Move the unprocessed data from the buffer to the start and fill
                    // remaining space in the buffer with new content from the stream.
                    leftover.CopyTo(buffer);
                    bytesRead = FillBuffer(stream, ref buffer, leftover.Length, buffer.Length - leftover.Length);
                }
            }
            else
            {
                bytesRead = FillBuffer(stream, ref buffer, 0, buffer.Length);
            }

            if (bytesRead == 0)
            {
                // empty buffer will be returned 
                reader = new Utf8JsonReader(buffer.AsSpan(0, bytesRead), isFinalBlock: true, reader.CurrentState);
                return;
            }

            // passing in 0 for the start position and bytesRead + leftover.Length as the span length is safe here because even if we are on the last buffer block,
            // and leftover is junk, that means bytesRead would've been zero and control would flow through the if block above.
            reader = new Utf8JsonReader(buffer.AsSpan(0, bytesRead + leftover.Length), isFinalBlock: ((bytesRead + leftover.Length) != buffer.Length || bytesRead == 0), reader.CurrentState);
        }

        private static int FillBuffer(Stream stream, ref byte[] buffer, int offset, int bytesToRead)
        {
            if (stream is null)
                throw new ArgumentNullException("stream must be populated.");
            int bytesRead = 0;
            while (bytesToRead > 0)
            {
                int read = stream.Read(buffer, offset, bytesToRead);
                if (read == 0) break; // End of stream
                offset += read;
                bytesToRead -= read;
                bytesRead += read;
            }

            return bytesRead;
        }
    }
}
