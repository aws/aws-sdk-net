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

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Stream handler for single-part downloads that provides direct passthrough to the underlying S3 response stream.
    /// Optimized for small objects that don't require multipart downloading.
    /// </summary>
    internal class SinglePartStreamHandler : IStreamHandler
    {
        private readonly Stream _underlyingStream;
        private bool _disposed = false;

        public SinglePartStreamHandler(Stream underlyingStream)
        {
            _underlyingStream = underlyingStream ?? throw new ArgumentNullException(nameof(underlyingStream));
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

            // Direct passthrough to underlying S3 response stream
            return await _underlyingStream.ReadAsync(buffer, offset, count, cancellationToken)
                .ConfigureAwait(false);
        }

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(SinglePartStreamHandler));
        }

        #region Dispose Pattern

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        public void Dispose()
        {
            if (!_disposed)
            {
                try
                {
                    // Dispose the underlying S3 response stream
                    _underlyingStream?.Dispose();
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
