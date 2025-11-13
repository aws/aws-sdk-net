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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

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

        private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

        public int PartNumber => _partBuffer.PartNumber;
        public bool IsAvailable => true; // Always available when created
        public bool IsComplete => _partBuffer.RemainingBytes == 0;

        public BufferedDataSource(StreamPartBuffer partBuffer)
        {
            _partBuffer = partBuffer ?? throw new ArgumentNullException(nameof(partBuffer));
            
            Logger.DebugFormat("[READ] Part {0} - BufferedDataSource created: Length={1}, CurrentPosition={2}, RemainingBytes={3}", 
                _partBuffer.PartNumber, _partBuffer.Length, _partBuffer.CurrentPosition, _partBuffer.RemainingBytes);
        }

        public Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
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

            Logger.DebugFormat("[READ] Part {0} - ReadAsync called: offset={1}, count={2}, CurrentPosition={3}, RemainingBytes={4}", 
                _partBuffer.PartNumber, offset, count, _partBuffer.CurrentPosition, _partBuffer.RemainingBytes);

            if (_partBuffer.RemainingBytes == 0)
            {
                Logger.DebugFormat("[READ] Part {0} - No remaining bytes, returning 0 (EOF)", _partBuffer.PartNumber);
                return Task.FromResult(0); // End of part
            }

            try
            {
                // Calculate bytes to copy from buffered part
                var availableBytes = _partBuffer.RemainingBytes;
                var bytesToRead = Math.Min(count, availableBytes);
                
                Logger.DebugFormat("[READ] Part {0} - Calculated bytesToRead={1} (min of count={2}, availableBytes={3})", 
                    _partBuffer.PartNumber, bytesToRead, count, availableBytes);
                
                // Log source buffer content before copy
                var sourceFirstBytes = string.Join(" ", _partBuffer.ArrayPoolBuffer
                    .Skip(_partBuffer.CurrentPosition)
                    .Take(Math.Min(8, bytesToRead))
                    .Select(b => $"0x{b:X2}"));
                var sourceLastBytes = bytesToRead >= 8
                    ? string.Join(" ", _partBuffer.ArrayPoolBuffer
                        .Skip(_partBuffer.CurrentPosition + bytesToRead - 8)
                        .Take(8)
                        .Select(b => $"0x{b:X2}"))
                    : "N/A";
                
                Logger.DebugFormat("[READ] Part {0} - BEFORE BlockCopy: sourceOffset={1}, destOffset={2}, count={3}", 
                    _partBuffer.PartNumber, _partBuffer.CurrentPosition, offset, bytesToRead);
                Logger.DebugFormat("[READ] Part {0} - Source buffer content: First 8=[{1}], Last 8=[{2}]", 
                    _partBuffer.PartNumber, sourceFirstBytes, sourceLastBytes);
                
                // Direct copy: ArrayPool buffer → user buffer (optimized single copy)
                Buffer.BlockCopy(
                    _partBuffer.ArrayPoolBuffer,    // Source: ArrayPool buffer
                    _partBuffer.CurrentPosition,    // Source offset
                    buffer,                         // Destination: user buffer
                    offset,                         // Destination offset
                    bytesToRead                     // Bytes to copy
                );
                
                // Log destination buffer content after copy
                var destFirstBytes = string.Join(" ", buffer
                    .Skip(offset)
                    .Take(Math.Min(8, bytesToRead))
                    .Select(b => $"0x{b:X2}"));
                var destLastBytes = bytesToRead >= 8
                    ? string.Join(" ", buffer
                        .Skip(offset + bytesToRead - 8)
                        .Take(8)
                        .Select(b => $"0x{b:X2}"))
                    : "N/A";
                
                Logger.DebugFormat("[READ] Part {0} - AFTER BlockCopy: Copied {1} bytes", 
                    _partBuffer.PartNumber, bytesToRead);
                Logger.DebugFormat("[READ] Part {0} - Dest buffer content: First 8=[{1}], Last 8=[{2}]", 
                    _partBuffer.PartNumber, destFirstBytes, destLastBytes);
                
                // Update position in the part buffer
                var oldPosition = _partBuffer.CurrentPosition;
                _partBuffer.CurrentPosition += bytesToRead;
                
                Logger.DebugFormat("[READ] Part {0} - Updated CurrentPosition: {1} -> {2}, RemainingBytes now={3}, IsComplete={4}", 
                    _partBuffer.PartNumber, oldPosition, _partBuffer.CurrentPosition, _partBuffer.RemainingBytes, IsComplete);
                
                return Task.FromResult(bytesToRead);
            }
            catch (Exception ex)
            {
                Logger.DebugFormat("[READ] Part {0} - Exception during ReadAsync: {1}", _partBuffer.PartNumber, ex.Message);
                // On any error during read, mark the buffer as consumed to prevent further reads
                _partBuffer.CurrentPosition = _partBuffer.Length;
                throw;
            }
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(BufferedDataSource));
        }

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    // Dispose the underlying StreamPartBuffer, which returns ArrayPool buffer to pool
                    _partBuffer?.Dispose();
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
