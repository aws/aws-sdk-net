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
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Stream wrapper to append trailing headers, including an optional
    /// rolling checksum for a request with an unsigned payload.
    /// </summary>
    public class TrailingHeadersWrapperStream : WrapperStream
    {
        private const string STREAM_NEWLINE = "\r\n";
        private const string EMPTY_CHUNK = "0\r\n";
        private const int NEWLINE_LENGTH = 2;            // additional length for any new lines
        private const int EMPTY_CHUNK_LENGTH = 3;        // additional length for an empty chunk "0CRLF"
        private const int HEADER_ROW_PADDING_LENGTH = 3; // additional length for each row of a trailing header, 1 for ':' between the key and value, plus 2 for CRLF

        private Stream _baseStream;
        private HashAlgorithm _hashAlgorithm;
        private IDictionary<string, string> _trailingHeaders;
        private CoreChecksumAlgorithm _checksumAlgorithm;
        string _prefix;
        string _suffix;
        bool _haveFinishedPrefix;
        bool _haveFinishedStream;
        bool _haveFinishedSuffix;
        int _prefixPosition;
        int _suffixPosition;

        /// <summary>
        /// Initiates a stream wrapper to append trailing headers to an unsigned payload
        /// </summary>
        /// <param name="baseStream">Stream to wrap</param>
        /// <param name="trailingHeaders">Trailing headers to append after the wrapped stream</param>
        public TrailingHeadersWrapperStream(Stream baseStream, IDictionary<string, string> trailingHeaders) : base(baseStream)
        {
            if (trailingHeaders == null || trailingHeaders.Count == 0)
            {
                throw new AmazonClientException($"{nameof(TrailingHeadersWrapperStream)} was initialized without any trailing headers.");
            }
            _baseStream = baseStream;
            _trailingHeaders = trailingHeaders;
            _prefix = GenerateContentChunkLength();
        }

        /// <summary>
        /// Initiates a stream wrapper to append trailing headers to an unsigned payload,
        /// with a trailing checksum
        /// </summary>
        /// <param name="baseStream">Stream to wrap</param>
        /// <param name="trailingHeaders">Header keys and values to append after the stream's conent</param>
        /// <param name="checksumAlgorithm">Algorithm to use to calculate the stream's checksum</param>
        public TrailingHeadersWrapperStream(
            Stream baseStream, 
            IDictionary<string, string> trailingHeaders,
            CoreChecksumAlgorithm checksumAlgorithm) : this(baseStream, trailingHeaders)
        {
            if (checksumAlgorithm != CoreChecksumAlgorithm.NONE)
            {
                _checksumAlgorithm = checksumAlgorithm;
                _hashAlgorithm = CryptoUtilFactory.GetChecksumInstance(checksumAlgorithm);
            }
        }

        /// <summary>
        /// Reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
        /// </summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte 
        /// array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if 
        /// that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        public override int Read(byte[] buffer, int offset, int count)
        {
            return ReadInternal(buffer, offset, count, false, CancellationToken.None).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously reads a sequence of bytes from the current stream and advances the position within the stream by the number of bytes read.
        /// </summary>
        /// <param name="buffer">An array of bytes. When this method returns, the buffer contains the specified byte 
        /// array with the values between offset and (offset + count - 1) replaced by the bytes read from the current source.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing the data read from the current stream.</param>
        /// <param name="count">The maximum number of bytes to be read from the current stream.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>The total number of bytes read into the buffer. This can be less than the number of bytes requested if 
        /// that many bytes are not currently available, or zero (0) if the end of the stream has been reached.</returns>
        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            return await ReadInternal(buffer, offset, count, true, cancellationToken).ConfigureAwait(false);
        }

        private async Task<int> ReadInternal(byte[] buffer, int offset, int count, bool useAsyncRead, CancellationToken cancellationToken)
        {
            var countRemainingForThisRead = count;
            var countFromPrefix = 0;
            var countFromStream = 0;
            var countFromSuffix = 0;

            if (countRemainingForThisRead > 0 && !_haveFinishedPrefix)
            {
                countFromPrefix = ReadFromPrefix(buffer, offset, countRemainingForThisRead);
                offset += countFromPrefix;
                countRemainingForThisRead -= countFromPrefix;
            }

            if (countRemainingForThisRead > 0 && !_haveFinishedStream)
            {
                // First read from the stream into a buffer here
                byte[] thisBuffer = new byte[countRemainingForThisRead];

                if (!useAsyncRead)
                {
                    countFromStream = base.Read(thisBuffer, 0, countRemainingForThisRead);
                }
                else
                {
                    countFromStream = await base.ReadAsync(thisBuffer, 0, countRemainingForThisRead, cancellationToken).ConfigureAwait(false);
                }

                // Update rolling checksum for that content, and copy it to the output buffer
                if (countFromStream != 0)
                {
                    if (_hashAlgorithm != null)
                    {
                        _hashAlgorithm.TransformBlock(thisBuffer, 0, countFromStream, thisBuffer, 0);
                    }
                    Buffer.BlockCopy(thisBuffer, 0, buffer, offset, countFromStream);
                }
                else // finished the stream, so finalize checksum
                {
                    if (_hashAlgorithm != null)
                    {
                        _hashAlgorithm.TransformFinalBlock(ArrayEx.Empty<byte>(), 0, 0);
                    }
                    _haveFinishedStream = true;
                    _suffix = GenerateTrailingHeaderChunk();
                }

                offset += countFromStream;
                countRemainingForThisRead -= countFromStream;
            }

            if (countRemainingForThisRead > 0 && _haveFinishedStream && !_haveFinishedSuffix)
            {
                countFromSuffix = ReadFromSuffix(buffer, offset, countRemainingForThisRead);
            }

            return countFromPrefix + countFromStream + countFromSuffix;
        }

        /// <summary>
        /// Generates the prefix for the content chunk, which is 
        /// the content's length in hex followed by CRLF
        /// </summary>
        /// <returns>Length of a stream chunk</returns>
        private string GenerateContentChunkLength()
        {
            return $"{_baseStream.Length.ToString("X", CultureInfo.InvariantCulture)}{STREAM_NEWLINE}";
        }

        /// <summary>
        /// Copies the chunk length prefix to the output buffer
        /// </summary>
        /// <param name="buffer">The buffer to write the data into</param>
        /// <param name="offset">The byte offset in buffer at which to begin copying data</param>
        /// <param name="countRemainingForThisRead">The maximum number of bytes to copy</param>
        /// <returns>Number of bytes copied</returns>
        private int ReadFromPrefix(byte[] buffer, int offset, int countRemainingForThisRead)
        {
            var charsLeftInPrefix = _prefix.Length - _prefixPosition;

            if (charsLeftInPrefix <= countRemainingForThisRead)
            {
                Encoding.Default.GetBytes(_prefix, _prefixPosition, charsLeftInPrefix, buffer, offset);
                _haveFinishedPrefix = true;
                return charsLeftInPrefix;
            }
            else // can only read a subset of the prefix (the rest of countRemainingForThisRead)
            {
                Encoding.Default.GetBytes(_prefix, _prefixPosition, countRemainingForThisRead, buffer, offset);
                _prefixPosition += countRemainingForThisRead;
                return countRemainingForThisRead;
            }
        }

        /// <summary>
        /// Generates the trailing header content, assuming the rolling checksum is now finalized
        /// </summary>
        /// <returns>Trailing headers as a single string</returns>
        private string GenerateTrailingHeaderChunk()
        {
            var trailer = new StringBuilder();

            // Avoid adding an empty chunk for an empty stream. Adding the empty chunk for an empty stream will trigger
            // service error for malformed trailing headers.
            if (_baseStream.Length > 0)
            {
                // End the data chunk
                trailer.Append(STREAM_NEWLINE);

                // Append a chunk of size 0
                trailer.Append(EMPTY_CHUNK);
            }

            // Append trailing headers, including special handling for the checksum.
            // The order here must match the order of keys sent already in the X-Amz-Trailer header.
            foreach (var kvp in _trailingHeaders.OrderBy(kvp => kvp.Key))
            {
                if (_checksumAlgorithm != CoreChecksumAlgorithm.NONE && ChecksumUtils.GetChecksumHeaderKey(_checksumAlgorithm) == kvp.Key)
                {
                    // Use the calculated checksum, since it likely wasn't set in advance
                    trailer.Append($"{kvp.Key}:{Convert.ToBase64String(_hashAlgorithm.Hash)}{STREAM_NEWLINE}");
                }
                else
                {
                    trailer.Append($"{kvp.Key}:{kvp.Value}{STREAM_NEWLINE}");
                }
            }

            // Append a final trailing CRLF
            trailer.Append(STREAM_NEWLINE);

            return trailer.ToString();
        }

        /// <summary>
        /// Copies the trailing header suffix to the output buffer
        /// </summary>
        /// <param name="buffer">The buffer to write the data into</param>
        /// <param name="offset">The byte offset in buffer at which to begin copying data</param>
        /// <param name="countRemainingForThisRead">The maximum number of bytes to copy</param>
        /// <returns>Number of bytes copied</returns>
        private int ReadFromSuffix(byte[] buffer, int offset, int countRemainingForThisRead)
        {
            var charsLeftInSuffix = _suffix.Length - _suffixPosition;

            // If the current suffix fits entirely within the current read buffer
            if (charsLeftInSuffix <= countRemainingForThisRead)
            {
                Encoding.Default.GetBytes(_suffix, _suffixPosition, charsLeftInSuffix, buffer, offset);
                _haveFinishedSuffix = true;
                return charsLeftInSuffix;
            }
            else // else we can only read a subset of the prefix (the rest of countRemainingForThisRead)
            {
                Encoding.Default.GetBytes(_suffix, _suffixPosition, countRemainingForThisRead, buffer, offset);
                _suffixPosition += countRemainingForThisRead;
                return countRemainingForThisRead;
            }
        }

        /// <summary>
        /// Gets the length in bytes of the stream
        /// </summary>
        public override long Length => CalculateLength(_trailingHeaders, _checksumAlgorithm, _baseStream.Length);

        /// <summary>
        /// Calculates the length in bytes of a TrailingChecksumWrapperStream initialized
        /// with the given trailing headers and optional checksum
        /// </summary>
        /// <param name="trailingHeaders">Dictionary of trailing headers</param>
        /// <param name="checksumAlgorithm">Trailing checksum</param>
        /// <param name="baseStreamLength">Length of the base stream in bytes</param>
        /// <returns>Length of a TrailingChecksumWrapperStream with given parameters, in bytes</returns>
        public static long CalculateLength(IDictionary<string, string> trailingHeaders, CoreChecksumAlgorithm checksumAlgorithm, long baseStreamLength)
        {
            var prefixLength = baseStreamLength.ToString("X", CultureInfo.InvariantCulture).Length;
            var trailingHeaderLength = 0;

            if (trailingHeaders != null)
            {
                foreach (var key in trailingHeaders.Keys)
                {
                    if (checksumAlgorithm != CoreChecksumAlgorithm.NONE && ChecksumUtils.GetChecksumHeaderKey(checksumAlgorithm) == key)
                    {
                        trailingHeaderLength += key.Length +
                            CryptoUtilFactory.GetChecksumBase64Length(checksumAlgorithm) + HEADER_ROW_PADDING_LENGTH;
                    }
                    else
                    {
                        trailingHeaderLength += key.Length + trailingHeaders[key].Length + HEADER_ROW_PADDING_LENGTH;
                    }
                }
            }

            var emptyChunkTotalLength = NEWLINE_LENGTH + EMPTY_CHUNK_LENGTH;
            if (baseStreamLength == 0) // Empty chunk is only added when the baseStream isn't empty
            {
                emptyChunkTotalLength = 0;
            }

            return prefixLength +
                   NEWLINE_LENGTH +
                   baseStreamLength +
                   emptyChunkTotalLength +
                   trailingHeaderLength +
                   NEWLINE_LENGTH;
        }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking
        /// </summary>
        public override bool CanSeek => false;

        /// <summary>
        /// Gets whether this stream has a length
        /// </summary>
        internal override bool HasLength => (_baseStream != null) || (_trailingHeaders != null);
    }
}
