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
using System.Buffers.Binary;
using System.Formats.Cbor;
using System.Text;

namespace Amazon.Extensions.CborProtocol.Internal
{
    /// <summary>
    /// A forward-only CBOR writer that encodes directly into an <see cref="IBufferWriter{T}"/>, avoiding the
    /// internal buffer and the extra <c>Encode()</c> copy that <see cref="CborWriter"/> performs.
    /// </summary>
    /// <remarks>
    /// Containers may be written as definite-length (a count is supplied up front, no terminator) or
    /// indefinite-length (a leading <c>0xBF</c>/<c>0x9F</c> and a trailing <c>0xFF</c> break). The generated
    /// marshallers emit matching <c>WriteStart*</c>/<c>WriteEnd*</c> pairs regardless; this writer tracks each
    /// open container so <c>WriteEndMap</c>/<c>WriteEndArray</c> emits a break byte only for indefinite
    /// containers and is a no-op for definite ones. The writer performs no structural validation (the generator
    /// emits balanced calls), so it is internal-only.
    /// </remarks>
    public sealed class CborContentWriter
    {
        private readonly IBufferWriter<byte> _output;

        // One bit per open container: true = indefinite (needs a 0xFF break on close), false = definite (no break).
        // An array-backed stack avoids per-container allocation; 32 levels covers CBOR's default MaxDepth of 64
        // for the shapes the SDK marshals and grows if needed.
        private bool[] _indefiniteStack = new bool[32];
        private int _depth;

        /// <summary>Total bytes written so far, for callers that pre-size downstream buffers.</summary>
        public int BytesWritten { get; private set; }

        public CborContentWriter(IBufferWriter<byte> output)
        {
            _output = output ?? throw new ArgumentNullException(nameof(output));
        }

        private void WriteRawByte(byte b)
        {
            var span = _output.GetSpan(1);
            span[0] = b;
            _output.Advance(1);
            BytesWritten += 1;
        }

        /// <summary>Writes a major-type header with its argument using the shortest encoding.</summary>
        private void WriteTypeHeader(int majorType, ulong value)
        {
            int high = majorType << 5;
            if (value < 24)
            {
                WriteRawByte((byte)(high | (int)value));
            }
            else if (value <= byte.MaxValue)
            {
                var span = _output.GetSpan(2);
                span[0] = (byte)(high | 24);
                span[1] = (byte)value;
                _output.Advance(2);
                BytesWritten += 2;
            }
            else if (value <= ushort.MaxValue)
            {
                var span = _output.GetSpan(3);
                span[0] = (byte)(high | 25);
                BinaryPrimitives.WriteUInt16BigEndian(span.Slice(1), (ushort)value);
                _output.Advance(3);
                BytesWritten += 3;
            }
            else if (value <= uint.MaxValue)
            {
                var span = _output.GetSpan(5);
                span[0] = (byte)(high | 26);
                BinaryPrimitives.WriteUInt32BigEndian(span.Slice(1), (uint)value);
                _output.Advance(5);
                BytesWritten += 5;
            }
            else
            {
                var span = _output.GetSpan(9);
                span[0] = (byte)(high | 27);
                BinaryPrimitives.WriteUInt64BigEndian(span.Slice(1), value);
                _output.Advance(9);
                BytesWritten += 9;
            }
        }

        private void PushContainer(bool indefinite)
        {
            if (_depth == _indefiniteStack.Length)
                Array.Resize(ref _indefiniteStack, _indefiniteStack.Length * 2);
            _indefiniteStack[_depth++] = indefinite;
        }

        private void PopContainerAndWriteBreakIfNeeded()
        {
            if (_depth == 0)
                throw new InvalidOperationException("No open CBOR container to end.");
            if (_indefiniteStack[--_depth])
                WriteRawByte(0xFF);
        }

        // A null count opens an indefinite-length container (closed by a 0xFF break on WriteEndMap/WriteEndArray);
        // a non-null count writes a definite-length header and takes no terminator.
        public void WriteStartMap(int? definiteLength)
        {
            if (definiteLength is int n)
            {
                WriteTypeHeader(5, (ulong)n);
                PushContainer(indefinite: false);
            }
            else
            {
                WriteRawByte(0xBF);
                PushContainer(indefinite: true);
            }
        }

        public void WriteEndMap() => PopContainerAndWriteBreakIfNeeded();

        public void WriteStartArray(int? definiteLength)
        {
            if (definiteLength is int n)
            {
                WriteTypeHeader(4, (ulong)n);
                PushContainer(indefinite: false);
            }
            else
            {
                WriteRawByte(0x9F);
                PushContainer(indefinite: true);
            }
        }

        public void WriteEndArray() => PopContainerAndWriteBreakIfNeeded();

        public void WriteTextString(string value)
        {
            int byteCount = Encoding.UTF8.GetByteCount(value);
            WriteTypeHeader(3, (ulong)byteCount);
            var span = _output.GetSpan(byteCount);
            Encoding.UTF8.GetBytes(value, span);
            _output.Advance(byteCount);
            BytesWritten += byteCount;
        }

        public void WriteByteString(ReadOnlySpan<byte> value)
        {
            WriteTypeHeader(2, (ulong)value.Length);
            var span = _output.GetSpan(value.Length);
            value.CopyTo(span);
            _output.Advance(value.Length);
            BytesWritten += value.Length;
        }

        public void WriteInt32(int value) => WriteInt64(value);

        public void WriteInt64(long value)
        {
            if (value >= 0)
                WriteTypeHeader(0, (ulong)value);
            else
                WriteTypeHeader(1, (ulong)(-1L - value));
        }

        public void WriteUInt64(ulong value) => WriteTypeHeader(0, value);

        public void WriteBoolean(bool value) => WriteRawByte(value ? (byte)0xF5 : (byte)0xF4);

        public void WriteNull() => WriteRawByte(0xF6);

        public void WriteDouble(double value)
        {
            var span = _output.GetSpan(9);
            span[0] = 0xFB;
            BinaryPrimitives.WriteDoubleBigEndian(span.Slice(1), value);
            _output.Advance(9);
            BytesWritten += 9;
        }

        public void WriteSingle(float value)
        {
            var span = _output.GetSpan(5);
            span[0] = 0xFA;
            BinaryPrimitives.WriteSingleBigEndian(span.Slice(1), value);
            _output.Advance(5);
            BytesWritten += 5;
        }

        public void WriteTag(CborTag tag) => WriteTypeHeader(6, (ulong)tag);

        /// <summary>Writes an already-encoded CBOR data item verbatim.</summary>
        public void WriteEncodedValue(ReadOnlySpan<byte> encodedValue)
        {
            var span = _output.GetSpan(encodedValue.Length);
            encodedValue.CopyTo(span);
            _output.Advance(encodedValue.Length);
            BytesWritten += encodedValue.Length;
        }
    }
}
