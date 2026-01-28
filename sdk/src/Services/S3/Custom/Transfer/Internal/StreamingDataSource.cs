/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Stream-based data source that reads directly from GetObjectResponse without buffering.
    /// Provides pass-through access to the response stream for optimal memory efficiency when parts arrive in order.
    /// </summary>
    /// <remarks>
    /// This class enables direct streaming optimization for multipart downloads. When a part arrives
    /// and happens to be the next expected part in the sequence, we can bypass buffering entirely
    /// and stream the response directly to the consumer.
    /// 
    /// OWNERSHIP AND LIFECYCLE:
    /// - Takes ownership of the GetObjectResponse and its stream
    /// - Responsible for disposing the response (releases HTTP connection)
    /// - Consumer reads directly from response stream via ReadAsync
    /// - Must be disposed to release network resources
    /// 
    /// THREAD SAFETY:
    /// - Designed for single-threaded consumption by PartBufferManager
    /// - PartBufferManager guarantees sequential access to each part
    /// - No internal synchronization needed
    /// 
    /// COMPLETION TRACKING:
    /// - Tracks bytes read vs ContentLength to detect completion
    /// - Sets IsComplete when stream exhausted OR expected bytes reached
    /// - Handles both normal completion and premature stream closure
    /// </remarks>
    internal class StreamingDataSource : IPartDataSource
    {
        private readonly GetObjectResponse _response;
        private readonly Stream _responseStream;
        private readonly long _expectedBytes;
        private readonly int _partNumber;
        private long _bytesRead;
        private bool _isComplete;
        private bool _disposed;

        #region Logger

        private Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

        #endregion

        /// <inheritdoc/>
        public int PartNumber
        {
            get
            {
                ThrowIfDisposed();
                return _partNumber;
            }
        }

        /// <inheritdoc/>
        public bool IsComplete
        {
            get
            {
                ThrowIfDisposed();
                return _isComplete;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingDataSource"/> class.
        /// Takes ownership of the GetObjectResponse and its stream.
        /// </summary>
        /// <param name="partNumber">The 1-based part number this source represents.</param>
        /// <param name="response">The GetObjectResponse containing the stream to read from. Ownership is transferred.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="response"/> is null.</exception>
        /// <remarks>
        /// CRITICAL: This constructor takes ownership of the response. The caller must NOT dispose it.
        /// The StreamingDataSource will dispose the response when it is disposed.
        /// </remarks>
        public StreamingDataSource(int partNumber, GetObjectResponse response)
        {
            if (response == null)
                throw new ArgumentNullException(nameof(response));

            _partNumber = partNumber;
            _response = response;
            _responseStream = response.ResponseStream;
            _expectedBytes = response.ContentLength;
            _bytesRead = 0;
            _isComplete = false;

            Logger.DebugFormat("StreamingDataSource: Created for part {0} (ExpectedBytes={1}, streaming directly from response)",
                _partNumber, _expectedBytes);
        }

        /// <inheritdoc/>
        /// <remarks>
        /// Reads directly from the underlying response stream without any buffering or copying.
        /// This provides optimal memory efficiency and minimal latency for in-order part arrivals.
        /// 
        /// COMPLETION DETECTION:
        /// The source is marked complete when:
        /// 1. Stream returns 0 bytes (normal EOF), OR
        /// 2. We've read the expected number of bytes (ContentLength)
        /// 
        /// ERROR HANDLING:
        /// Any exceptions from the underlying stream (network errors, timeout, etc.) propagate directly
        /// to the caller. The PartBufferManager will handle cleanup and error recovery.
        /// </remarks>
        public async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();

            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset must be non-negative");
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
            if (offset + count > buffer.Length)
                throw new ArgumentException("Offset and count exceed buffer bounds");

            if (_isComplete)
            {
                Logger.DebugFormat("StreamingDataSource: [Part {0}] Already complete, returning 0 bytes", PartNumber);
                return 0;
            }

            try
            {
                Logger.DebugFormat("StreamingDataSource: [Part {0}] Reading up to {1} bytes from response stream (BytesRead={2}/{3})",
                    PartNumber, count, _bytesRead, _expectedBytes);

                // Direct delegation to response stream - no buffering, just pass-through
                var bytesRead = await _responseStream.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false);

                _bytesRead += bytesRead;

                Logger.DebugFormat("StreamingDataSource: [Part {0}] Read {1} bytes from response stream (TotalBytesRead={2}/{3})",
                    PartNumber, bytesRead, _bytesRead, _expectedBytes);

                // Mark complete when stream exhausted OR we've read expected bytes
                if (bytesRead == 0 || _bytesRead >= _expectedBytes)
                {
                    _isComplete = true;
                    Logger.DebugFormat("StreamingDataSource: [Part {0}] Marked complete (BytesRead=0: {1}, ReachedExpected: {2})",
                        PartNumber, bytesRead == 0, _bytesRead >= _expectedBytes);
                }

                return bytesRead;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "StreamingDataSource: [Part {0}] Error reading from response stream: {1}",
                    PartNumber, ex.Message);

                // Mark as complete on error to prevent further read attempts
                _isComplete = true;
                throw;
            }
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(StreamingDataSource));
        }

        /// <inheritdoc/>
        /// <remarks>
        /// CRITICAL: Disposes the GetObjectResponse, which releases the HTTP connection back to the connection pool.
        /// Failure to dispose will cause connection leaks and eventual connection pool exhaustion.
        /// </remarks>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    Logger.DebugFormat("StreamingDataSource: [Part {0}] Disposing (Releasing HTTP connection, BytesRead={1}/{2})",
                        PartNumber, _bytesRead, _expectedBytes);

                    // Dispose the response - this releases the HTTP connection
                    _response?.Dispose();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "StreamingDataSource: [Part {0}] Error during disposal: {1}",
                        PartNumber, ex.Message);

                    // Suppressing CA1031: Dispose methods should not throw exceptions
                    // Continue disposal process silently on any errors
                }

                _disposed = true;
            }
        }
    }
}
