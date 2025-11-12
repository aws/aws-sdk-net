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
    /// Stream handler for multipart downloads that coordinates with buffer manager to provide sequential reading.
    /// Implements the direct streaming optimization to eliminate unnecessary ArrayPool buffering when possible.
    /// </summary>
    internal class MultipartStreamHandler : IStreamHandler
    {
        private readonly IPartBufferManager _partBufferManager;
        private StreamPartBuffer _currentPartBuffer;
        private bool _disposed = false;

        public MultipartStreamHandler(IPartBufferManager partBufferManager)
        {
            _partBufferManager = partBufferManager ?? throw new ArgumentNullException(nameof(partBufferManager));
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

            // If current ArrayPool buffer is exhausted, try to get next part
            if (_currentPartBuffer == null || _currentPartBuffer.RemainingBytes == 0)
            {
                // Dispose previous buffer (returns to ArrayPool) and release buffer space
                if (_currentPartBuffer != null)
                {
                    _currentPartBuffer.Dispose();
                    _partBufferManager.ReleaseBufferSpace(); // Free space for new downloads
                    _currentPartBuffer = null;
                }

                var nextPartNumber = _partBufferManager.NextExpectedPartNumber;
                
                var result = await _partBufferManager.ReadPartAsync(nextPartNumber, buffer, offset, count, cancellationToken)
                    .ConfigureAwait(false);
                
                if (result.IsDirectStreamed)
                {
                    // SUCCESS: Got data directly from downloader without buffering
                    return result.BytesRead;
                }
                
                if (result.BytesRead == 0)
                {
                    return 0; // End of stream
                }
                
                // If we got here with buffered data, the part should be available in the buffer manager
                // This indicates the ReadPartAsync returned early - we need to get the buffer separately
                // This shouldn't happen
                throw new InvalidOperationException("ReadPartAsync returned buffered data but no buffer was provided");
            }
            
            // Direct read from ArrayPool buffer (no MemoryStream overhead!)
            var availableBytes = _currentPartBuffer.RemainingBytes;
            var bytesToRead = Math.Min(count, availableBytes);
            
            // Direct copy from ArrayPool buffer to user buffer
            Buffer.BlockCopy(
                _currentPartBuffer.ArrayPoolBuffer,  // Source: ArrayPool buffer
                _currentPartBuffer.CurrentPosition,  // Source offset
                buffer,                              // Destination: user buffer
                offset,                              // Destination offset
                bytesToRead                          // Bytes to copy
            );
            
            _currentPartBuffer.CurrentPosition += bytesToRead;
            
            return bytesToRead;
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(MultipartStreamHandler));
        }

        #region Dispose Pattern

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    // Clean up current ArrayPool-based PartBuffer and release buffer space
                    if (_currentPartBuffer != null)
                    {
                        _currentPartBuffer.Dispose(); // Returns ArrayPool buffer to pool
                        _partBufferManager.ReleaseBufferSpace(); // Free space for new downloads
                        _currentPartBuffer = null;
                    }
                    
                    // Note: We don't dispose _partBufferManager here since it's owned by the coordinator
                    // The BufferedMultipartStream will handle disposing the buffer manager
                }
                catch (Exception)
                {
                    // Suppressing CA1031: Dispose methods should not throw exceptions
                    // Continue disposal process silently on any errors
                }
                
                _disposed = true;
            }
        }

        #endregion
    }
}
