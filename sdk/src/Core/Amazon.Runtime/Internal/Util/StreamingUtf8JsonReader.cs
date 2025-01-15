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
        private static JsonReaderOptions _jsonOptions = new JsonReaderOptions
        {
            AllowTrailingCommas = true
        };
        /// <summary>
        /// The UTF8JsonReader attached to the instance. 
        /// </summary>
        public Utf8JsonReader Reader
        {
            get
            {
                return _reader;
            }
        }

        private Stream _stream;
        private byte[] _buffer;

        /// <summary>
        /// Initializes a new instance of the StreamingUtf8JsonReader. Upon initialization the reader will read from the stream and fill the buffer.
        /// If a UTF8 BOM is present in the stream, it will be skipped. Unless <see cref="AWSConfigs.StreamingUtf8JsonReaderBufferSize"/> is set, the default
        /// buffer size for buffering data from the stream will be 4096. You can also use the constructor that accepts bufferSize to change this value.
        /// </summary>
        /// <param name="stream">the stream containing the data</param>
        public StreamingUtf8JsonReader(Stream stream) : this(stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096)
        {
        }

        /// <summary>
        /// Initializes a new instance of the StreamingUtf8JsonReader. Upon initialization the reader will read from the stream and fill the buffer.
        /// If a UTF8 BOM is present in the stream, it will be skipped.
        /// </summary>
        /// <param name="stream">the stream containing the data</param>
        /// <param name="bufferSize">the size of the buffer when reading data from the stream</param>
        /// <exception cref="ArgumentException"></exception>
        public StreamingUtf8JsonReader(Stream stream, int bufferSize)
        {
            if (stream is null)
                throw new ArgumentException("Stream must not be null. Please initialize a stream and pass it into the constructor.");

            _stream = stream;
            _buffer = ArrayPool<byte>.Shared.Rent(bufferSize);
            int utf8BomLength = JsonConstants.Utf8Bom.Length;
            Debug.Assert(_buffer.Length >= utf8BomLength);

            int bytesRead = FillBuffer(stream, ref _buffer,0, _buffer.Length);
            int start = 0;
            if (_buffer.AsSpan().StartsWith(JsonConstants.Utf8Bom))
            {
                start += utf8BomLength;
                bytesRead -= utf8BomLength;
            }

            _reader = new Utf8JsonReader(_buffer.AsSpan(start, bytesRead), isFinalBlock: bytesRead == 0, new JsonReaderState(_jsonOptions));
        }

        /// <summary>
        /// Reads data from the buffer and fetches more data from the stream to fill the buffer it more data exists.
        /// </summary>
        /// <returns>true if there is more data, false otherwise.</returns>
        public bool Read()
        {
            // hasMoreData can return false if the value starts in one buffer and leaks into the next buffer
            bool hasMoreData = _reader.Read();

            while (!hasMoreData)
            {
                if (_reader.IsFinalBlock)
                {
                    ArrayPool<byte>.Shared.Return(_buffer);
                    break;
                }

                GetMoreBytesFromStream(_stream, ref _buffer, ref _reader);

                hasMoreData = _reader.Read();
            }

            return hasMoreData;
        }

        private static void GetMoreBytesFromStream(Stream stream, ref byte[] buffer, ref Utf8JsonReader reader)
        {
            int bytesRead = 0;
            ReadOnlySpan<byte> leftover = buffer.AsSpan().Slice((int)reader.BytesConsumed);
            var data = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(data);
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
