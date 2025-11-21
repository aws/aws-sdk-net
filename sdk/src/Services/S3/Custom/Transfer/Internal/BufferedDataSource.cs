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
using Amazon.Runtime.Internal.Util;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// ArrayPool-based buffered data source that reads from pre-buffered part data.
    /// Manages ArrayPool lifecycle and provides efficient buffer-to-buffer copying.
    /// </summary>
    internal class BufferedDataSource : IPartDataSource
    {
        private readonly StreamPartBuffer _partBuffer;
        private bool _disposed = false;

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
        public int PartNumber => _partBuffer.PartNumber;
        
        /// <inheritdoc/>
        public bool IsComplete => _partBuffer.RemainingBytes == 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="BufferedDataSource"/> class.
        /// </summary>
        /// <param name="partBuffer">The <see cref="StreamPartBuffer"/> containing the buffered part data.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="partBuffer"/> is null.</exception>
        public BufferedDataSource(StreamPartBuffer partBuffer)
        {
            _partBuffer = partBuffer ?? throw new ArgumentNullException(nameof(partBuffer));
            
            Logger.DebugFormat("BufferedDataSource: Created for part {0} (BufferLength={1}, RemainingBytes={2})", 
                _partBuffer.PartNumber, _partBuffer.Length, _partBuffer.RemainingBytes);
        }

        /// <inheritdoc/>
        public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
            try
            {
                if (buffer == null)
                    throw new ArgumentNullException(nameof(buffer));
                if (offset < 0)
                    throw new ArgumentOutOfRangeException(nameof(offset), "Offset must be non-negative");
                if (count < 0)
                    throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
                if (offset + count > buffer.Length)
                    throw new ArgumentException("Offset and count exceed buffer bounds");

                if (_partBuffer.RemainingBytes == 0)
                {
                    Logger.DebugFormat("BufferedDataSource: [Part {0}] Reached end of buffer (RemainingBytes=0)", _partBuffer.PartNumber);
                    return Task.FromResult(0); // End of part
                }

                // Calculate bytes to copy from buffered part
                var availableBytes = _partBuffer.RemainingBytes;
                var bytesToRead = Math.Min(count, availableBytes);
                
                Logger.DebugFormat("BufferedDataSource: [Part {0}] Reading {1} bytes (Requested={2}, Available={3}, CurrentPosition={4})", 
                    _partBuffer.PartNumber, bytesToRead, count, availableBytes, _partBuffer.CurrentPosition);
                
                Buffer.BlockCopy(
                    _partBuffer.ArrayPoolBuffer,    // Source: ArrayPool buffer
                    _partBuffer.CurrentPosition,    // Source offset
                    buffer,                         // Destination: user buffer
                    offset,                         // Destination offset
                    bytesToRead                     // Bytes to copy
                );
                
                // Update position in the part buffer
                _partBuffer.CurrentPosition += bytesToRead;
                
                Logger.DebugFormat("BufferedDataSource: [Part {0}] Read complete (BytesRead={1}, NewPosition={2}, RemainingBytes={3}, IsComplete={4})", 
                    _partBuffer.PartNumber, bytesToRead, _partBuffer.CurrentPosition, _partBuffer.RemainingBytes, IsComplete);
                
                return Task.FromResult(bytesToRead);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "BufferedDataSource: [Part {0}] Error during read: {1}", _partBuffer.PartNumber, ex.Message);
                
                // On any error during read (including validation), mark the buffer as consumed to prevent further reads
                _partBuffer.CurrentPosition = _partBuffer.Length;
                throw;
            }
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(BufferedDataSource));
        }

        /// <inheritdoc/>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    Logger.DebugFormat("BufferedDataSource: [Part {0}] Disposing (Returning buffer to ArrayPool)", _partBuffer.PartNumber);
                    
                    // Dispose the underlying StreamPartBuffer, which returns ArrayPool buffer to pool
                    _partBuffer?.Dispose();
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "BufferedDataSource: [Part {0}] Error during disposal: {1}", _partBuffer.PartNumber, ex.Message);
                    
                    // Suppressing CA1031: Dispose methods should not throw exceptions
                    // Continue disposal process silently on any errors
                }
                
                _disposed = true;
            }
        }
    }
}
