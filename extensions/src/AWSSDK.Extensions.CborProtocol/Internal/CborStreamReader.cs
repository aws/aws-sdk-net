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
using Amazon.Runtime.Internal.Util;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Formats.Cbor;
using System.IO;

namespace Amazon.Extensions.CborProtocol.Internal
{
    /// <summary>
    /// A streaming CBOR reader that processes large CBOR data streams in chunks without loading
    /// the entire payload into memory at once. This class wraps <see cref="CborReader"/>
    /// to provide streaming capabilities while maintaining the same reading interface.
    /// </summary>
    public class CborStreamReader : IDisposable
    {
        /// <summary>
        /// Enum to track the type of CBOR container (map or array)
        /// for state management within the CborStreamReader.
        /// </summary>
        private enum CborContainerType
        {
            Map,
            Array
        }

        private static readonly ILogger _logger = Logger.GetLogger(typeof(CborStreamReader));
        private readonly Stack<CborContainerType> _nestingStack = new Stack<CborContainerType>();
        private readonly Stream _stream;
        private byte[] _buffer;
        private CborReader _internalCborReader;
        private int _currentChunkSize;

        /// <summary>
        /// Initializes a new instance of the <see cref="CborStreamReader"/> class that reads CBOR data
        /// from the specified stream.
        /// </summary>
        /// <param name="stream">The input stream containing CBOR-formatted data.
        /// The stream must be readable and remain open for the lifetime of the reader.</param>
        /// <exception cref="ArgumentNullException">Thrown when the stream parameter is null.</exception>
        /// <remarks>
        /// The reader uses a configurable initial buffer size (from <see cref="AWSConfigs.CborReaderInitialBufferSize"/>)
        /// and will automatically resize the buffer if needed to handle larger CBOR items.
        /// </remarks>
        public CborStreamReader(Stream stream)
        {
            _stream = stream ?? throw new ArgumentNullException(nameof(stream));
            _buffer = ArrayPool<byte>.Shared.Rent(AWSConfigs.CborReaderInitialBufferSize);

            _currentChunkSize = _stream.Read(_buffer, 0, _buffer.Length);
            var memorySlice = new ReadOnlyMemory<byte>(_buffer, 0, _currentChunkSize);

            // We must allow multiple root values because when refilling the new chunk is just a fragment of the whole stream.
            _internalCborReader = new CborReader(memorySlice, allowMultipleRootLevelValues: true);
        }

        /// <summary>
        /// This method is called when a read operation fails because it needs more
        /// data than is currently available in the buffer. It handles stitching leftover
        /// data with a new chunk from the stream and, if necessary, resizing the buffer.
        /// </summary>
        /// <param name="bytesToSkip">Number of bytes to skip before reading new data (e.g., 1 to skip CBOR break byte 0xFF)</param>
        private void RefillBuffer(int bytesToSkip = 0)
        {
            int leftoverBytesCount = _internalCborReader.BytesRemaining;

            // Determine where the leftover bytes start
            int leftoverStartIndex = _currentChunkSize - leftoverBytesCount;

            // If we are skipping bytes, we need to move the start forward
            leftoverStartIndex += bytesToSkip;
            leftoverBytesCount = leftoverBytesCount - bytesToSkip;

            // If the leftover data completely fills the buffer, grow it
            if (leftoverBytesCount >= _buffer.Length)
            {
                int newSize = _buffer.Length * 2;
                var newBuffer = ArrayPool<byte>.Shared.Rent(newSize);

                Buffer.BlockCopy(_buffer, leftoverStartIndex, newBuffer, 0, leftoverBytesCount);
                ArrayPool<byte>.Shared.Return(_buffer);
                _buffer = newBuffer;
            }
            else if (leftoverBytesCount > 0)  // Shift leftovers (after skipping) to the beginning of the buffer
            {
                Buffer.BlockCopy(_buffer, leftoverStartIndex, _buffer, 0, leftoverBytesCount);
            }

            // Read from stream into buffer after leftovers
            int bytesReadFromStream = _stream.Read(_buffer, leftoverBytesCount, _buffer.Length - leftoverBytesCount);

            // Update the total size of valid data in our buffer.
            _currentChunkSize = leftoverBytesCount + bytesReadFromStream;

            // Check for a malformed stream: if we have leftovers but the stream is empty,
            // it means the CBOR data was truncated.
            if (bytesReadFromStream == 0 && leftoverBytesCount > 0)
            {
                throw new CborContentException("Stream ended unexpectedly with an incomplete CBOR data item.");
            }

            var newMemorySlice = new ReadOnlyMemory<byte>(_buffer, 0, _currentChunkSize);
            _internalCborReader.Reset(newMemorySlice);

            _logger.DebugFormat("Buffer refilled: read {0} byte(s), total in buffer now: {1}.", bytesReadFromStream, _currentChunkSize);
        }

        /// <summary>
        /// Executes a CBOR read operation, refilling the buffer and retrying if a CborContentException is thrown.
        /// </summary>
        /// <typeparam name="T">The return type of the CBOR read operation.</typeparam>
        /// <param name="readOperation">A delegate representing the read operation to execute.</param>
        /// <returns>The result of the read operation.</returns>
        /// <exception cref="CborContentException">
        /// Thrown if too many retries are attempted or if the stream ends unexpectedly.
        /// </exception>
        private T ExecuteRead<T>(Func<CborReader, T> readOperation)
        {
            int maxRetries = 64;
            int retryCount = 0;

            while (true)
            {
                try
                {
                    return readOperation(_internalCborReader);
                }
                catch (CborContentException ex)
                {
                    if (_currentChunkSize == 0 && _internalCborReader.BytesRemaining == 0)
                    {
                        // Fail fast if we’ve already consumed all input and nothing remains to refill.
                        throw;
                    }

                    if (++retryCount > maxRetries)
                    {
                        throw new CborContentException("Too many retries during CBOR stream parsing. Possible malformed or infinite data.", ex);
                    }

                    _logger.Debug(ex, "CborContentException caught (attempt #{0}), attempting to refill buffer.", retryCount);
                    // Attempt to refill and retry the operation.
                    RefillBuffer();
                }
            }
        }


        private bool IsNextByteEndOfContainer()
        {
            int unreadOffset = _currentChunkSize - _internalCborReader.BytesRemaining;
            if (unreadOffset < _currentChunkSize)
                return _buffer[unreadOffset] == 0xFF; // 0xFF indicates "break" in indefinite-length map/array

            return false;
        }

        private void ReadEndContainer(CborContainerType expectedType, CborReaderState expectedEndState, Action<CborReader> readEndAction)
        {
            ExecuteRead(r =>
            {
                if (_nestingStack.Count == 0 || _nestingStack.Peek() != expectedType)
                    throw new CborContentException($"Unexpected end of {expectedType.ToString().ToLowerInvariant()}.");

                var state = CborReaderState.Finished;
                try
                {
                    state = r.PeekState();
                }
                catch (CborContentException)
                {
                    // This exception is expected in two cases:
                    // 1. When we've reached the end of the current CBOR buffer chunk and need to refill.
                    // 2. When the current buffer does not contain the start of the array/map we're trying to end.
                    // In both cases, the internal CborReader's state will be `Finished` and we will trigger a buffer refill.
                    // This is not a true error, but logging at Info level can help trace how we arrived at a certain state.
                    _logger.DebugFormat("CborContentException caught during PeekState while expecting end of {0}", expectedType.ToString().ToLowerInvariant());
                }

                if (state == expectedEndState)
                {
                    readEndAction(r);
                    _nestingStack.Pop();
                    return true;
                }

                if (state == CborReaderState.Finished)
                {
                    if (IsNextByteEndOfContainer())
                    {
                        RefillBuffer(1); // Skip the break marker (0xFF)
                    }
                    else
                    {
                        RefillBuffer(0); // This means we are in a definite-length map/array which doesn't end with 0xFF.
                    }
                    _nestingStack.Pop();
                    return true;
                }

                throw new CborContentException($"Expected end of {expectedType.ToString().ToLowerInvariant()} but could not parse it.");
            });
        }


        public void ReadEndMap()
        {
            ReadEndContainer(CborContainerType.Map, CborReaderState.EndMap, (reader) => reader.ReadEndMap());
        }

        public void ReadEndArray()
        {
            ReadEndContainer(CborContainerType.Array, CborReaderState.EndArray, (r) => r.ReadEndArray());
        }


        public int? ReadStartMap() => ExecuteRead(reader =>
        {
            var result = reader.ReadStartMap();
            _nestingStack.Push(CborContainerType.Map);
            return result;
        });

        public int? ReadStartArray() => ExecuteRead(reader =>
        {
            var result = reader.ReadStartArray();
            _nestingStack.Push(CborContainerType.Array);
            return result;
        });


        public CborReaderState PeekState()
        {
            return ExecuteRead(r =>
            {
                try
                {
                    return r.PeekState();
                }
                catch (CborContentException ex)
                {
                    // Translate a Break code to the appropriate container end state
                    // based on our own nesting stack.
                    if (_nestingStack.Count > 0)
                    {
                        var inferredState = _nestingStack.Peek() == CborContainerType.Map
                            ? CborReaderState.EndMap
                            : CborReaderState.EndArray;

                        _logger.Debug(ex, "CborContentException during PeekState interpreted as {0} due to nesting stack.", inferredState);
                        return inferredState;
                    }
                    // If our stack is empty, it's a genuine error.
                    throw;
                }
            });
        }

        public string ReadTextString() => ExecuteRead(r => r.ReadTextString());
        public int ReadInt32() => ExecuteRead(r => r.ReadInt32());
        public long ReadInt64() => ExecuteRead(r => r.ReadInt64());
        public decimal ReadDecimal() => ExecuteRead(r => r.ReadDecimal());
        public double ReadDouble() => ExecuteRead(r => r.ReadDouble());
        public bool ReadBoolean() => ExecuteRead(r => r.ReadBoolean());
        public float ReadSingle() => ExecuteRead(r => r.ReadSingle());
        public CborTag ReadTag() => ExecuteRead(r => r.ReadTag());
        public byte[] ReadByteString() => ExecuteRead(r => r.ReadByteString());
        public void ReadNull() => ExecuteRead(r => { r.ReadNull(); return true; });
        public void SkipValue() => ExecuteRead(r => { r.SkipValue(); return true; });
        public int CurrentDepth => _internalCborReader.CurrentDepth;

        public void Dispose()
        {
            if (_buffer != null)
            {
                ArrayPool<byte>.Shared.Return(_buffer);
                _buffer = null;
            }
        }
    }
}
