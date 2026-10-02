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
using System.Buffers.Binary;
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
        /// Represents a single container frame (map or array) within the nesting stack
        /// of the <see cref="CborStreamReader"/>. This is a struct kept in an array-backed
        /// stack so that entering a container does not allocate.
        /// </summary>
        private struct ContainerFrame
        {
            /// <summary>
            /// Gets the type of CBOR container (map or array).
            /// </summary>
            public CborContainerType Type { get; }

            /// <summary>
            /// Gets the number of items left to be read in this container.
            /// For indefinite-length containers, this value is <c>null</c>.
            /// </summary>
            public int? RemainingItems { get; private set; }

            /// <summary>
            /// Initializes a new instance of the <see cref="ContainerFrame"/> struct.
            /// </summary>
            /// <param name="type">The container type (map or array).</param>
            /// <param name="remainingItems">
            /// The number of items in the container, or <c>null</c> for indefinite-length containers.
            /// </param>
            public ContainerFrame(CborContainerType type, int? remainingItems)
            {
                Type = type;
                RemainingItems = remainingItems;
                if (RemainingItems.HasValue && type == CborContainerType.Map)
                {
                    // Multiply RemainingItems by 2 for maps to account for key value pairs.
                    RemainingItems *= 2;
                }
            }

            /// <summary>
            /// Decrements the <see cref="RemainingItems"/> count when an item is consumed.
            /// For indefinite-length containers, this method does nothing.
            /// </summary>
            public void ConsumeItem()
            {
                RemainingItems = RemainingItems.HasValue ? RemainingItems.Value - 1 : (int?)null;

                if (RemainingItems < 0)
                {
                    // This should never happen if container boundaries are respected.
                    // It indicates that more items were read than the container declared.
                    throw new CborContentException(
                        $"Too many items read from {Type} container. Expected {RemainingItems + 1} more item(s)."
                    );
                }
            }

            /// <summary>
            /// Gets a value indicating whether this container has been fully consumed.
            /// </summary>
            public bool IsComplete => RemainingItems == 0;
        }

        /// <summary>
        /// Enum to track the type of CBOR container (map or array)
        /// for state management within the CborStreamReader.
        /// </summary>
        private enum CborContainerType
        {
            Map,
            Array
        }

        /// <summary>
        /// A minimal stack of <see cref="ContainerFrame"/> values. Unlike <see cref="Stack{T}"/>,
        /// <see cref="Peek"/> returns the top frame by reference so it can be updated in place.
        /// </summary>
        private sealed class ContainerFrameStack
        {
            private ContainerFrame[] _frames = new ContainerFrame[8];

            public int Count { get; private set; }

            public void Push(ContainerFrame frame)
            {
                if (Count == _frames.Length)
                {
                    Array.Resize(ref _frames, _frames.Length * 2);
                }
                _frames[Count++] = frame;
            }

            public ref ContainerFrame Peek()
            {
                if (Count == 0)
                    throw new InvalidOperationException("Stack empty.");
                return ref _frames[Count - 1];
            }

            public void Pop()
            {
                if (Count == 0)
                    throw new InvalidOperationException("Stack empty.");
                Count--;
            }
        }

        private static readonly ILogger _logger = Logger.GetLogger(typeof(CborStreamReader));
        private readonly ContainerFrameStack _nestingStack = new ContainerFrameStack();
        private readonly Stream _stream;
        private byte[] _buffer;
        private CborReader _internalCborReader;
        private int _currentChunkSize;

        /// <summary>
        /// Set once a read from the underlying stream returns no data, so the reader stops
        /// trying to refill ahead of reads at the end of the stream.
        /// </summary>
        private bool _streamExhausted;

        /// <summary>
        /// The longest CBOR data item header: the initial byte followed by up to 8 bytes of argument.
        /// </summary>
        private const int MaxCborHeaderLength = 1 + 8;

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
            _streamExhausted = _currentChunkSize == 0;
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
            if (bytesReadFromStream == 0)
                _streamExhausted = true;

            // Update the total size of valid data in our buffer.
            _currentChunkSize = leftoverBytesCount + bytesReadFromStream;

            var newMemorySlice = new ReadOnlyMemory<byte>(_buffer, 0, _currentChunkSize);
            _internalCborReader.Reset(newMemorySlice);

            _logger.DebugFormat("Buffer refilled: read {0} byte(s), total in buffer now: {1}.", bytesReadFromStream, _currentChunkSize);
        }

        /// <summary>
        /// Executes a CBOR read operation, refilling the buffer and retrying if a CborContentException is thrown.
        /// </summary>
        /// <typeparam name="T">The return type of the CBOR read operation.</typeparam>
        /// <param name="readOperation">A delegate representing the read operation to execute. It receives this
        /// <see cref="CborStreamReader"/> and the internal <see cref="CborReader"/> as arguments so the delegates
        /// passed here don't capture state and are cached by the compiler instead of allocated per call.</param>
        /// <returns>The result of the read operation.</returns>
        /// <exception cref="CborContentException">
        /// Thrown if too many retries are attempted or if the stream ends unexpectedly.
        /// </exception>
        private T ExecuteRead<T>(Func<CborStreamReader, CborReader, T> readOperation)
        {
            int maxRetries = 64;
            int retryCount = 0;

            // Refill before the read when fewer bytes remain than the longest CBOR header, so a value that
            // straddles the end of the chunk is read whole instead of failing and being retried. Each such
            // failure throws, and exceptions cost far more than a refill.
            if (_internalCborReader.BytesRemaining < MaxCborHeaderLength && !_streamExhausted)
            {
                RefillBuffer();
            }

            while (true)
            {
                try
                {
                    return readOperation(this, _internalCborReader);
                }
                catch (Exception ex) when (ex is InvalidOperationException || ex is CborContentException)
                {
                    // Both InvalidOperationException and CborContentException can occur when the reader
                    // runs out of buffered data mid-item or encounters an incomplete CBOR structure.
                    // - CborContentException: typically thrown when encountering invalid CBOR content,
                    //   such as a premature break or truncated container.
                    // - InvalidOperationException: can happen when the reader attempts to interpret data
                    //   as a different type due to hitting a buffer boundary before the full item is available.
                    // We catch both, trigger a buffer refill, and retry before deciding if it is a genuine error.

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

        private void ReadEndContainer(CborContainerType expectedType)
        {
            // One static delegate per container type so neither captures the expected type.
            if (expectedType == CborContainerType.Map)
                ExecuteRead(static (self, r) => self.ReadEndContainerCore(r, CborContainerType.Map));
            else
                ExecuteRead(static (self, r) => self.ReadEndContainerCore(r, CborContainerType.Array));
        }

        private bool ReadEndContainerCore(CborReader r, CborContainerType expectedType)
        {
            var expectedEndState = expectedType == CborContainerType.Map ? CborReaderState.EndMap : CborReaderState.EndArray;
            if (_nestingStack.Count == 0 || _nestingStack.Peek().Type != expectedType)
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
                if (expectedType == CborContainerType.Map)
                    r.ReadEndMap();
                else
                    r.ReadEndArray();
                _nestingStack.Pop();
                return true;
            }

            if (state == CborReaderState.Finished)
            {
                // We got CborReaderState.Finished which means the reader has exhausted the bytes currently
                // given to it and the next token may live in the next chunk that we haven't read yet.
                //
                // For indefinite-length containers the end of the container is a break marker byte (0xFF).
                // If that break byte is the next byte in the stream, we must consume it, otherwise the reader
                // will become desynchronized (it will still think we're inside a container while removed the
                // container from the _nestingStack).
                // This byte can exist in the next chunk, so when we hit Finished we first attempt to refill
                // the buffer (no skip) so the reader can see the next byte(s). Only after refilling can we safely
                // determine whether the next byte is a break byte that terminates the current container.

                // Try to refill first, maybe the break marker is in the next chunk.
                RefillBuffer(0);

                if (!_nestingStack.Peek().RemainingItems.HasValue && IsNextByteEndOfContainer())
                {
                    // If the next raw byte after refill is the CBOR "break" (0xFF), that indicates an
                    // indefinite-length container terminator. We must explicitly consume that break byte
                    // so we can remove the item from the _nestingStack and parsing can continue correctly.
                    //
                    // We call RefillBuffer(1) to skip the break byte and  rebuild the internal reader.
                    // It consumes the break byte from the leftover buffer so subsequent calls to the CborReader
                    // see the next item.

                    RefillBuffer(1); // Skip the break marker (0xFF)
                }
                _nestingStack.Pop();
                return true;
            }
            else if (_nestingStack.Count > 0 && _nestingStack.Peek().IsComplete)
            {
                // Special handling for definite-length containers that are fully consumed:
                // For definite-length maps/arrays, the internal CborReader does not provide an explicit
                // end token. Once we have read all items (tracked via the _nestingStack frame's RemainingItems),
                // PeekState may point to the next item rather than EndArray/EndMap. In that case, we can
                // safely consider the container complete, pop the frame, and continue parsing.
                //
                // This prevents throwing a CborContentException when reading end container of a large
                // container that spans multiple buffer chunks and ensures ReadEndContainer returns the correct
                // logical end of the container.
                _nestingStack.Pop();
                return true;
            }

            throw new CborContentException($"Expected end of {expectedType.ToString().ToLowerInvariant()} but could not parse it.");
        }


        public void ReadEndMap()
        {
            ReadEndContainer(CborContainerType.Map);
            // After reading the end of a container (map/array), we need to mark it as consumed
            // in the parent container (if any). This ensures that nested arrays/maps count as
            // a single item in their enclosing container. Without this, the parent container
            // would incorrectly think there are remaining items, causing PeekState and
            // item-count tracking to become desynchronized with the actual CBOR stream.
            if (_nestingStack.Count > 0)
            {
                _nestingStack.Peek().ConsumeItem();
            }
        }

        public void ReadEndArray()
        {
            ReadEndContainer(CborContainerType.Array);
            // After reading the end of a container (map/array), we need to mark it as consumed
            // in the parent container (if any). This ensures that nested arrays/maps count as
            // a single item in their enclosing container. Without this, the parent container
            // would incorrectly think there are remaining items, causing PeekState and
            // item-count tracking to become desynchronized with the actual CBOR stream.
            if (_nestingStack.Count > 0)
            {
                _nestingStack.Peek().ConsumeItem();
            }
        }


        public int? ReadStartMap() => ExecuteRead(static (self, reader) =>
        {
            self.EnsureDefiniteLengthItemIsBuffered(2);
            var count = reader.ReadStartMap();
            self._nestingStack.Push(new ContainerFrame(CborContainerType.Map, count));
            return count;
        });

        public int? ReadStartArray() => ExecuteRead(static (self, reader) =>
        {
            self.EnsureDefiniteLengthItemIsBuffered(1);
            var count = reader.ReadStartArray();
            self._nestingStack.Push(new ContainerFrame(CborContainerType.Array, count));
            return count;
        });


        public CborReaderState PeekState()
        {
            return ExecuteRead(static (self, r) => self.PeekStateCore(r));
        }

        private CborReaderState PeekStateCore(CborReader r)
        {
            // Handle definite-length containers that silently complete
            if (_nestingStack.Count > 0)
            {
                var frame = _nestingStack.Peek();
                if (frame.IsComplete)
                {
                    return frame.Type == CborContainerType.Map
                        ? CborReaderState.EndMap
                        : CborReaderState.EndArray;
                }
            }

            // We need to Peek twice in case the first time failed because we are near the end of the current chunk and we just need to refill.
            for (int attempt = 0; attempt < 2; attempt++)
            {
                try
                {
                    var state = r.PeekState();
                    if (state == CborReaderState.Finished && _nestingStack.Count > 0)
                    {
                        _logger.DebugFormat("PeekState returned Finished, but nesting stack is not empty. Attempting refill.");
                        RefillBuffer(0);
                        continue;
                    }

                    return state;
                }
                catch (CborContentException ex)
                {
                    // PeekState threw an exception, we will attempt to refill in case we aren't at the end of the stream.
                    _logger.Debug(ex, "PeekState threw exception (attempt #{0}). Attempting refill.", attempt + 1);
                    RefillBuffer(0);
                }
            }

            // If PeekState still fails after refilling, and we're truly at the end of the stream,
            // only then consider inferring the state based on container nesting.
            if (_nestingStack.Count > 0)
            {
                var inferredState = _nestingStack.Peek().Type == CborContainerType.Map
                    ? CborReaderState.EndMap
                    : CborReaderState.EndArray;

                _logger.DebugFormat("CborContentException during PeekState interpreted as {0} due to nesting stack.", inferredState);
                return inferredState;
            }

            throw new CborContentException("Unable to determine CBOR reader state after retries, and no containers remain.");
        }

        /// <summary>
        /// Executes the provided CBOR read operation and automatically updates the item count
        /// of the current container (if any) to ensure that whenever an item is read, the parent
        /// container's RemainingItems count is decremented.
        /// </summary>
        private T ExecuteValueRead<T>(Func<CborStreamReader, CborReader, T> readOperation)
        {
            var result = ExecuteRead<T>(readOperation);
            if (_nestingStack.Count > 0)
            {
                _nestingStack.Peek().ConsumeItem();
            }

            return result;
        }

        /// <summary>
        /// Makes sure the buffer holds enough of an upcoming definite-length CBOR item for <see cref="CborReader"/>
        /// to accept it: the whole payload of a string, or for a map or array at least one byte per element,
        /// since <see cref="CborReader"/> rejects a declared length that can't fit in the bytes it holds.
        /// If the item runs past the end of the current chunk, the buffer is refilled, and expanded first
        /// when the item is larger than the buffer's capacity.
        ///
        /// This reads large items in one step instead of through multiple incremental refills, and avoids
        /// the exception the read would otherwise throw when an item straddles the end of a chunk.
        /// </summary>
        /// <param name="minBytesPerElement">The minimum encoded size of one element of the declared length:
        /// 1 for strings (bytes) and arrays (items), 2 for maps (a key and a value per entry).</param>
        private void EnsureDefiniteLengthItemIsBuffered(int minBytesPerElement)
        {
            const int AdditionalInfoMask = 0b0001_1111;

            var leftoverBytesCount = _internalCborReader.BytesRemaining;
            var unreadOffset = _currentChunkSize - leftoverBytesCount;

            if (leftoverBytesCount == 0)
                return;

            // Extract the additional information field which determines how the length is encoded.
            var additionalInfo = _buffer[unreadOffset] & AdditionalInfoMask;

            int headerLength =
                additionalInfo < 24 ? 1 :
                additionalInfo == 24 ? 2 :
                additionalInfo == 25 ? 3 :
                additionalInfo == 26 ? 5 :
                additionalInfo == 27 ? 9 :
                0;

            // Indefinite-length item (31) or unsupported additional info: the total size can't be precomputed.
            // Also skip when the header itself isn't fully buffered; the read's retry handles that case.
            if (headerLength == 0 || leftoverBytesCount < headerLength)
                return;

            // The bytes following the initial type/length header.
            var valueSpan = _buffer.AsSpan(unreadOffset + 1);

            ulong len64 = 0;

            // Decode the declared length according to CBOR major type encoding rules.
            if (additionalInfo < 24)
            {
                len64 = (ulong)additionalInfo; // Length directly encoded in the additionalInfo bits.
            }
            else if (additionalInfo == 24)
            {
                len64 = valueSpan[0];
            }
            else if (additionalInfo == 25)
            {
                len64 = BinaryPrimitives.ReadUInt16BigEndian(valueSpan);
            }
            else if (additionalInfo == 26)
            {
                len64 = BinaryPrimitives.ReadUInt32BigEndian(valueSpan);
            }
            else
            {
                len64 = BinaryPrimitives.ReadUInt64BigEndian(valueSpan);
            }

            // Guard the multiplication below; lengths this large fall through to the size check after it.
            if (len64 <= int.MaxValue)
                len64 *= (ulong)minBytesPerElement;

            // The whole item (header + payload) is already in the buffer.
            if (len64 <= (ulong)(leftoverBytesCount - headerLength))
                return;

            // Add header length margin to ensure we can read the full header + payload contiguously.
            len64 += MaxCborHeaderLength;

            // Guard against unreasonably large declared lengths that would exceed our
            // maximum buffer size (int.MaxValue) or cause overflow when cast to int.
            // CBOR supports 64-bit lengths theoretically, but such values are not expected
            // in real-world SDK payloads. If we encounter a larger value, it is most likely
            // due to malformed or corrupted data, so we skip preemptive expansion and
            // fall back to incremental reading instead.
            if (len64 > (ulong)int.MaxValue - (ulong)MaxCborHeaderLength)
            {
                _logger.DebugFormat("Skipping preemptive expansion: declared length {0} too large.", len64);
                return;
            }

            // Safe cast since len64 <= int.MaxValue at this point.
            int declaredLength = (int)len64;

            // If the declared value fits within the current buffer capacity, moving the leftover bytes
            // to the start of the buffer and reading more is enough.
            if (declaredLength <= _buffer.Length)
            {
                if (!_streamExhausted)
                    RefillBuffer();
                return;
            }

            var newBuffer = ArrayPool<byte>.Shared.Rent(declaredLength);

            Buffer.BlockCopy(_buffer, unreadOffset, newBuffer, 0, leftoverBytesCount);
            ArrayPool<byte>.Shared.Return(_buffer);
            _buffer = newBuffer;

            // Read from stream into buffer after leftovers
            var bytesReadFromStream = _stream.Read(_buffer, leftoverBytesCount, _buffer.Length - leftoverBytesCount);
            if (bytesReadFromStream == 0)
                _streamExhausted = true;

            // Update the total size of valid data in our buffer.
            _currentChunkSize = leftoverBytesCount + bytesReadFromStream;

            var newMemorySlice = new ReadOnlyMemory<byte>(_buffer, 0, _currentChunkSize);
            _internalCborReader.Reset(newMemorySlice);

            _logger.DebugFormat(
                "Preemptive buffer expansion for large CBOR value. Declared length: {0}, buffer resized to {1}.",
                declaredLength, _buffer.Length);
        }

        public string ReadTextString() => ExecuteValueRead(static (self, r) => { self.EnsureDefiniteLengthItemIsBuffered(1); return r.ReadTextString(); });
        public byte[] ReadByteString() => ExecuteValueRead(static (self, r) => { self.EnsureDefiniteLengthItemIsBuffered(1); return r.ReadByteString(); });
        public int ReadInt32() => ExecuteValueRead(static (_, r) => r.ReadInt32());
        public long ReadInt64() => ExecuteValueRead(static (_, r) => r.ReadInt64());
        public ulong ReadUInt64() => ExecuteValueRead(static (_, r) => r.ReadUInt64());
        public decimal ReadDecimal() => ExecuteValueRead(static (_, r) => r.ReadDecimal());
        public double ReadDouble() => ExecuteValueRead(static (_, r) => r.ReadDouble());
        public bool ReadBoolean() => ExecuteValueRead(static (_, r) => r.ReadBoolean());
        public float ReadSingle() => ExecuteValueRead(static (_, r) => r.ReadSingle());
        public void ReadNull() => ExecuteValueRead(static (_, r) => { r.ReadNull(); return true; });
        public void SkipValue() => ExecuteValueRead(static (_, r) => { r.SkipValue(); return true; });

        // Tags annotate the next CBOR item but are not themselves counted
        // as items within a definite-length array or map. For this reason,
        // we do not call ExecuteValueRead() and only use ExecuteRead() here.
        public CborTag ReadTag() => ExecuteRead(static (_, r) => r.ReadTag());
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
