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
    /// <remarks>
    /// Backed by the incremental <see cref="CborReader"/> APIs (<c>SlideData</c> and the
    /// <c>NeedsMoreData</c> state), which let the reader request the next chunk and keep its parsing
    /// state across chunk boundaries.
    /// </remarks>
    public class CborStreamReader : IDisposable
    {
        private static readonly ILogger _logger = Logger.GetLogger(typeof(CborStreamReader));
        private readonly Stream _stream;
        private byte[] _buffer;
        private CborReader _internalCborReader;

        /// <summary>
        /// Total bytes handed to the reader by the most recent <c>SlideData</c> call. The reader consumes
        /// from the front of this window, so the unconsumed bytes are the tail of <c>_buffer[0.._slidLength]</c>.
        /// </summary>
        private int _slidLength;

        /// <summary>
        /// Set once a read from the underlying stream returns no data, so later fills mark the final block.
        /// </summary>
        private bool _streamExhausted;

        private bool _hasReadFromStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="CborStreamReader"/> class that reads CBOR data
        /// from the specified stream.
        /// </summary>
        /// <param name="stream">The input stream containing CBOR-formatted data.
        /// The stream must be readable and remain open for the lifetime of the reader.</param>
        /// <exception cref="ArgumentNullException">Thrown when the stream parameter is null.</exception>
        public CborStreamReader(Stream stream)
        {
            _stream = stream ?? throw new ArgumentNullException(nameof(stream));
            _buffer = ArrayPool<byte>.Shared.Rent(AWSConfigs.CborReaderInitialBufferSize);

            // Incremental reading requires Lax conformance: stricter modes reject a non-final block.
            // The stream is read lazily on the first CBOR read (see ExecuteRead); an event stream
            // response hands the stream on undecoded, so reading here would consume its first frames.
            _internalCborReader = new CborReader(
                ReadOnlyMemory<byte>.Empty,
                new CborReaderOptions { ConformanceMode = CborConformanceMode.Lax, AllowMultipleRootLevelValues = true },
                isFinalBlock: false);
        }

        /// <summary>
        /// Pulls the next chunk from the stream and hands it to the reader via <c>SlideData</c>, preserving
        /// any bytes the reader has not yet consumed. Grows the buffer when the unconsumed bytes already fill it.
        /// </summary>
        private void Fill()
        {
            int unconsumed = _internalCborReader.BytesRemaining;

            // The reader consumes from the front of the last slid window, so the unconsumed bytes are the tail
            // of _buffer[0.._slidLength]. Move them to the front, then read new bytes after them. SlideData then
            // takes the leftover plus the new bytes as one contiguous block, so the reader never sees a split item.
            if (unconsumed > 0)
            {
                Buffer.BlockCopy(_buffer, _slidLength - unconsumed, _buffer, 0, unconsumed);
            }

            if (unconsumed == _buffer.Length)
            {
                var grown = ArrayPool<byte>.Shared.Rent(_buffer.Length * 2);
                Buffer.BlockCopy(_buffer, 0, grown, 0, unconsumed);
                ArrayPool<byte>.Shared.Return(_buffer);
                _buffer = grown;
            }

            int read = _stream.Read(_buffer, unconsumed, _buffer.Length - unconsumed);
            if (read == 0)
                _streamExhausted = true;

            _slidLength = unconsumed + read;
            _internalCborReader.SlideData(new ReadOnlyMemory<byte>(_buffer, 0, _slidLength), isFinalBlock: _streamExhausted);

            _logger.DebugFormat("Buffer refilled: read {0} byte(s), total in buffer now: {1}.", read, _slidLength);
        }

        /// <summary>
        /// Executes a CBOR read, refilling while the reader reports <see cref="CborReaderState.NeedsMoreData"/>.
        /// That only covers the next item's header, so multi-item values (indefinite-length strings, decimal
        /// fractions) are also retried after a refill until they succeed or the stream is exhausted.
        /// </summary>
        private T ExecuteRead<T>(Func<CborStreamReader, CborReader, T> readOperation)
        {
            EnsureStarted();

            while (true)
            {
                FillWhileNeedsMoreData();

                try
                {
                    return readOperation(this, _internalCborReader);
                }
                catch (Exception ex) when ((ex is CborContentException || ex is InvalidOperationException)
                    && !_streamExhausted && NextItemIsMultiItemValue())
                {
                    // A failed read leaves the reader at the start of the value. Scoped to multi-item values so a malformed
                    // ordinary value fails fast instead of pulling the rest of the stream into the buffer.
                    _logger.DebugFormat("Multi-item CBOR value spans a chunk boundary; refilling and retrying.");
                    Fill();
                }
                catch (InvalidOperationException ex)
                {
                    // The incremental reader raises InvalidOperationException for structural misuse, such as
                    // ending the wrong container type or reading a value as the wrong major type on a malformed
                    // payload. Surface it as a content error so callers see the same exception as with the previous reader.
                    throw new CborContentException(ex.Message, ex);
                }
            }
        }

        // Initial bytes of values the reader decodes as several CBOR items in one call (RFC 8949 §3.2.3, §3.4.4).
        private const byte IndefiniteLengthByteString = 0x5F;
        private const byte IndefiniteLengthTextString = 0x7F;
        private const byte DecimalFractionTag = 0xC4;

        private bool NextItemIsMultiItemValue()
        {
            int remaining = _internalCborReader.BytesRemaining;
            if (remaining <= 0)
                return false;

            byte initialByte = _buffer[_slidLength - remaining];
            return initialByte == IndefiniteLengthByteString
                || initialByte == IndefiniteLengthTextString
                || initialByte == DecimalFractionTag;
        }

        private void EnsureStarted()
        {
            if (!_hasReadFromStream)
            {
                _hasReadFromStream = true;
                Fill();
            }
        }

        /// <summary>
        /// Refills while the reader needs more bytes for its next token, stopping once the stream is
        /// exhausted (a remaining <see cref="CborReaderState.NeedsMoreData"/> then means a truncated payload).
        /// </summary>
        private void FillWhileNeedsMoreData()
        {
            while (_internalCborReader.PeekState() == CborReaderState.NeedsMoreData && !_streamExhausted)
            {
                Fill();
            }
        }

        public int? ReadStartMap() => ExecuteRead(static (_, r) => r.ReadStartMap());
        public int? ReadStartArray() => ExecuteRead(static (_, r) => r.ReadStartArray());
        public void ReadEndMap() => ExecuteRead(static (_, r) => { r.ReadEndMap(); return true; });
        public void ReadEndArray() => ExecuteRead(static (_, r) => { r.ReadEndArray(); return true; });

        public CborReaderState PeekState() => ExecuteRead(static (_, r) => r.PeekState());

        public string ReadTextString() => ExecuteRead(static (_, r) => r.ReadTextString());
        public byte[] ReadByteString() => ExecuteRead(static (_, r) => r.ReadByteString());
        public int ReadInt32() => ExecuteRead(static (_, r) => r.ReadInt32());
        public long ReadInt64() => ExecuteRead(static (_, r) => r.ReadInt64());
        public ulong ReadUInt64() => ExecuteRead(static (_, r) => r.ReadUInt64());
        public decimal ReadDecimal() => ExecuteRead(static (_, r) => r.ReadDecimal());
        public double ReadDouble() => ExecuteRead(static (_, r) => r.ReadDouble());
        public bool ReadBoolean() => ExecuteRead(static (_, r) => r.ReadBoolean());
        public float ReadSingle() => ExecuteRead(static (_, r) => r.ReadSingle());
        public void ReadNull() => ExecuteRead(static (_, r) => { r.ReadNull(); return true; });

        /// <summary>
        /// Skips the next value, which may be a subtree spanning several chunks. Uses <c>TrySkipValue</c>
        /// (returns <see langword="false"/> without consuming when more data is needed) so large values are
        /// skipped by refilling in a loop rather than by catching exceptions.
        /// </summary>
        public void SkipValue()
        {
            EnsureStarted();
            FillWhileNeedsMoreData();

            try
            {
                while (!_internalCborReader.TrySkipValue())
                {
                    if (_streamExhausted)
                    {
                        // Truncated payload: the value can never complete.
                        throw new CborContentException("Unexpected end of CBOR data stream while skipping a value.");
                    }

                    Fill();
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new CborContentException(ex.Message, ex);
            }
        }

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
