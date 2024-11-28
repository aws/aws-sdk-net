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

        public StreamingUtf8JsonReader(Stream stream)
        {
            if (stream is null)
                throw new ArgumentException("Stream must not be null. Please initialize a stream and pass it into the constructor.");

            _stream = stream;
            // 300 bytes of padding to acocunt for stream.read() returning more bytes than requested sometimes
            _buffer = ArrayPool<byte>.Shared.Rent( (AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096) + 0);
            // need to initialize the reader even if the buffer is empty because auto-default of unassigned fields is only 
            // supported in C# 11+
            _reader = new Utf8JsonReader(_buffer);
            HandleUtf8Bom(ref _buffer);
        }

        private void HandleUtf8Bom(ref byte[] buffer)
        {
            int utf8BomLength = JsonConstants.Utf8Bom.Length;
            Debug.Assert(buffer.Length >= utf8BomLength);

            int bytesRead = _stream.Read(buffer, 0, buffer.Length);
            int start = 0;
            if (buffer.AsSpan().StartsWith(JsonConstants.Utf8Bom))
            {
                start += utf8BomLength;
                bytesRead -= utf8BomLength;
            }
            _reader = new Utf8JsonReader(buffer.AsSpan(start, bytesRead), isFinalBlock: bytesRead == 0, default);
        }

        // Custom delegate to handle ref parameters
        public delegate void RefAction(ref Utf8JsonReader reader);

        /// <summary>
        /// Method to allow passing the private _reader as ref. This is a hacky way to get around the error
        /// "a property or indexer may not be passed as an out or ref parameter". Use this when you need to pass
        /// the Utf8JsonReader to a method that requires a ref parameter. <see cref="Amazon.Runtime.Internal.Transform.JsonUnmarshallerContext.ToJsonDocument(ref StreamingUtf8JsonReader)"/>
        /// for usage example.
        /// </summary>
        /// <param name="action">The custom delegate</param>
        public void PassReaderByRef(RefAction action)
        {
            action(ref _reader);
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
                GetMoreBytesFromStream(_stream, ref _buffer, ref _reader);

                if (_reader.IsFinalBlock)
                    break;

                hasMoreData = _reader.Read();
            }

            return hasMoreData;
        }

        private static void GetMoreBytesFromStream(Stream stream, ref byte[] buffer, ref Utf8JsonReader reader)
        {
            int bytesRead = 0;
            bool resized = false;
            int previousBufferLength = buffer.Length;

            if (reader.BytesConsumed < buffer.Length)
            {
                // if Read() returned false and we are here inside this if block that means that we couldn't fully parse the JSON token 
                // because it was too large to fit in the remainder of the buffer.
                ReadOnlySpan<byte> leftover = buffer.AsSpan().Slice((int)reader.BytesConsumed);

                if (leftover.Length == buffer.Length)
                {
                    resized = true;
                    // rent double the capacity, hopefully we never have to rent the maxValue but in case buffer.Length * 2 ends up greater 
                    // we must protect against that
                    var resizedBuffer = ArrayPool<byte>.Shared.Rent(Math.Min(int.MaxValue, (buffer.Length * 2) + 0));
                    Logger.GetLogger(typeof(StreamingUtf8JsonReader)).InfoFormat("Resizing buffer from {0} to {1}", buffer.Length, resizedBuffer.Length);
                    
                    buffer.AsSpan().CopyTo(resizedBuffer);
                    ArrayPool<byte>.Shared.Return(buffer);
                    buffer = resizedBuffer;
                }
                
                leftover.CopyTo(buffer);
                int offset = leftover.Length;

                bytesRead = FillBuffer(stream, ref buffer, leftover.Length, buffer.Length - leftover.Length);

                if (resized)
                {
                    var resizedSpan = buffer.AsSpan(0, bytesRead + previousBufferLength);
                    reader = new Utf8JsonReader(resizedSpan, isFinalBlock: bytesRead == 0, reader.CurrentState);
                    return;
                }
            }

            else
            {
                bytesRead = FillBuffer(stream, ref buffer, 0, buffer.Length);
            }

            if (bytesRead == 0)
            {
                ArrayPool<byte>.Shared.Return(buffer);
                //make sure buffer isn't used in another process
                buffer = null;
                reader = new Utf8JsonReader(buffer, isFinalBlock: true, reader.CurrentState);
                return;
            }

            reader = new Utf8JsonReader(buffer, isFinalBlock: false, reader.CurrentState);
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
