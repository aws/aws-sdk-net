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
using System.Text;
using ThirdParty.RuntimeBackports;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// A TextWriter that encodes characters to UTF-8 directly into an ArrayPoolBufferWriter,
    /// with the same additional XML character escaping as <see cref="XMLEncodedStringWriter"/>.
    /// Used with XmlWriter.Create(TextWriter) to produce UTF-8 XML bytes without an intermediate string.
    /// </summary>
    public sealed class XMLEncodedBufferTextWriter : TextWriter
    {
        private readonly ArrayPoolBufferWriter<byte> _writer;
        private readonly Encoder _encoder;

        public XMLEncodedBufferTextWriter(ArrayPoolBufferWriter<byte> writer)
        {
            _writer = writer;
            _encoder = Encoding.UTF8.GetEncoder();
        }

        public override Encoding Encoding => Encoding.UTF8;

        // XmlWriter calls Write(char) for each character it outputs. We intercept here to
        // apply AWS-specific escaping that XmlWriter's NewLineHandling.Entitize doesn't cover.
        public override void Write(char value)
        {
            switch (value)
            {
                case '\n':
                    WriteAscii("&#xA;");
                    break;
                case '\u0085': // NEL (Next Line)
                    WriteAscii("&#x85;");
                    break;
                case '\u2028': // Unicode Line Separator
                    WriteAscii("&#x2028;");
                    break;
                default:
                    EncodeChar(value);
                    break;
            }
        }

        public override void Write(char[] buffer, int index, int count)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            if (index < 0 || buffer.Length - index < count) throw new ArgumentOutOfRangeException(nameof(index));

            WriteSpan(buffer.AsSpan(index, count));
        }

        public override void Write(string value)
        {
            if (value == null) return;

            WriteSpan(value.AsSpan());
        }

        // Splits the input into segments separated by special characters (\n, \u0085, \u2028).
        // Characters between special characters are UTF-8 encoded in a single batch Encoder.Convert
        // call (much faster than encoding one character at a time). Special characters are replaced
        // with their XML escape sequences. Most XML content has no special characters, so the
        // entire input is typically encoded in one batch call.
        private void WriteSpan(ReadOnlySpan<char> span)
        {
            int start = 0;
            for (int i = 0; i < span.Length; i++)
            {
                string escape = span[i] switch
                {
                    '\n' => "&#xA;",
                    '\u0085' => "&#x85;",
                    '\u2028' => "&#x2028;",
                    _ => null
                };

                if (escape != null)
                {
                    // Encode the clean run before this special character
                    if (i > start)
                        EncodeSpan(span.Slice(start, i - start));
                    WriteAscii(escape);
                    start = i + 1;
                }
            }

            // Encode any remaining clean run after the last special character (or entire input)
            if (start < span.Length)
                EncodeSpan(span.Slice(start));
        }

        // Escape sequences are pure ASCII, so each char maps 1:1 to a byte.
        private void WriteAscii(string ascii)
        {
            var span = _writer.GetSpan(ascii.Length);
            for (int i = 0; i < ascii.Length; i++)
            {
                span[i] = (byte)ascii[i];
            }
            _writer.Advance(ascii.Length);
        }


#if !NET8_0_OR_GREATER
        private readonly char[] _charBuffer = new char[1];
        // 4 bytes is the max a single UTF-8 codepoint can produce.
        private readonly byte[] _byteBuffer = new byte[4];
        // Scratch buffers for batch encoding. 128 chars × 3 bytes/char = 384 max bytes.
        private readonly char[] _charBatch = new char[128];
        private readonly byte[] _byteBatch = new byte[384];
#endif

        private void EncodeChar(char c)
        {
            // flush: false allows surrogate pairs to work. When a high surrogate arrives,
            // the encoder holds it internally (0 bytes output). When the low surrogate
            // arrives next, the encoder combines them into a full 4-byte UTF-8 sequence.

#if NET8_0_OR_GREATER
            // Writes directly into the pooled buffer — no intermediate byte[] copy.
            ReadOnlySpan<char> input = stackalloc char[1] { c };
            var dest = _writer.GetSpan(4);
            _encoder.Convert(input, dest, flush: false, out _, out int bytesUsed, out _);
#else
            _charBuffer[0] = c;
            _encoder.Convert(_charBuffer, 0, 1, _byteBuffer, 0, 4, flush: false, out _, out int bytesUsed, out _);
            var dest = _writer.GetSpan(bytesUsed);
            _byteBuffer.AsSpan(0, bytesUsed).CopyTo(dest);
#endif
            _writer.Advance(bytesUsed);
        }

        // Batch-encodes a clean run of characters (no special chars) into the pooled buffer.
        private void EncodeSpan(ReadOnlySpan<char> chars)
        {
#if NET8_0_OR_GREATER
            // Span-based overload writes directly into the pooled buffer — zero intermediate copies.
            while (chars.Length > 0)
            {
                // A single char (UTF-16) produces at most 3 UTF-8 bytes. Characters that need 4 bytes
                // require a surrogate pair (2 chars), so per-char max is still 3.
                var dest = _writer.GetSpan(chars.Length * 3);
                _encoder.Convert(chars, dest, flush: false, out int charsUsed, out int bytesUsed, out _);
                _writer.Advance(bytesUsed);
                chars = chars.Slice(charsUsed);
            }
#else
            // Array-based Encoder.Convert requires char[] input, so we copy into a reusable
            // instance buffer in 128-char chunks, encode into _byteBatch, then copy to the pooled buffer.
            int charIndex = 0;
            while (charIndex < chars.Length)
            {
                int charCount = Math.Min(chars.Length - charIndex, _charBatch.Length);
                chars.Slice(charIndex, charCount).CopyTo(_charBatch);
                _encoder.Convert(_charBatch, 0, charCount, _byteBatch, 0, _byteBatch.Length, flush: false, out int charsUsed, out int bytesUsed, out _);
                var dest = _writer.GetSpan(bytesUsed);
                _byteBatch.AsSpan(0, bytesUsed).CopyTo(dest);
                _writer.Advance(bytesUsed);
                charIndex += charsUsed;
            }
#endif
        }

        public override void Flush()
        {
            // flush: true forces the encoder to emit any pending state (e.g. orphaned high surrogate).
#if NET8_0_OR_GREATER
            var dest = _writer.GetSpan(4);
            _encoder.Convert(ReadOnlySpan<char>.Empty, dest, flush: true, out _, out int bytesUsed, out _);
            _writer.Advance(bytesUsed);
#else
            _encoder.Convert(Array.Empty<char>(), 0, 0, _byteBuffer, 0, 4, flush: true, out _, out int bytesUsed, out _);
            if (bytesUsed > 0)
            {
                var dest = _writer.GetSpan(bytesUsed);
                _byteBuffer.AsSpan(0, bytesUsed).CopyTo(dest);
                _writer.Advance(bytesUsed);
            }
#endif
        }
    }
}
#endif
