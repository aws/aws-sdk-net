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
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Direct streaming data source that pipes HTTP response stream directly to user buffer.
    /// Provides zero-copy performance by eliminating intermediate ArrayPool buffering.
    /// Used when the reader is ready to consume data immediately as it arrives.
    /// </summary>
    internal class StreamDataSource : IPartDataSource
    {
        private readonly Func<byte[], int, int, CancellationToken, Task<int>> _streamCallback;
        private bool _disposed = false;
        private bool _isComplete = false;

        public int PartNumber { get; }
        public bool IsAvailable => true; // Always available when created
        public bool IsComplete => _isComplete;
        public bool IsDirectStream => true;

        public StreamDataSource(int partNumber, Func<byte[], int, int, CancellationToken, Task<int>> streamCallback)
        {
            PartNumber = partNumber;
            _streamCallback = streamCallback ?? throw new ArgumentNullException(nameof(streamCallback));
        }

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
                return 0; // End of stream

            try
            {
                // Direct streaming: HTTP response stream → user buffer (zero-copy)
                var bytesRead = await _streamCallback(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                
                // If we read less than requested, we've reached the end of this part
                if (bytesRead < count || bytesRead == 0)
                {
                    _isComplete = true;
                }
                
                return bytesRead;
            }
            catch (Exception)
            {
                _isComplete = true; // Mark complete on any error to prevent further reads
                throw;
            }
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(StreamDataSource));
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    _isComplete = true;
                    // Note: We don't dispose the underlying stream as it's managed by the HTTP client
                    // The callback itself handles the lifecycle of the response stream
                }
                catch (Exception)
                {
                    // Suppressing CA1031: Dispose methods should not throw exceptions
                    // Continue disposal process silently on any errors
                }
                
                _disposed = true;
            }
        }
    }
}
