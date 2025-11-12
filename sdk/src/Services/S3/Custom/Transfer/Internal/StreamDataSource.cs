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
using Amazon.S3.Model;
using Amazon.Runtime.Internal.Util;

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
        private readonly GetObjectResponse _ownedResponse; // Response owned by this instance
        private bool _disposed = false;
        private bool _isComplete = false;

        public int PartNumber { get; }
        public bool IsAvailable => true; // Always available when created
        public bool IsComplete => _isComplete;
        public bool IsDirectStream => true;

         private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

        public StreamDataSource(int partNumber, Func<byte[], int, int, CancellationToken, Task<int>> streamCallback)
        {
            PartNumber = partNumber;
            _streamCallback = streamCallback ?? throw new ArgumentNullException(nameof(streamCallback));
        }

        /// <summary>
        /// Creates a StreamDataSource that takes ownership of the GetObjectResponse.
        /// The response will be disposed when this StreamDataSource is disposed.
        /// </summary>
        public StreamDataSource(int partNumber, GetObjectResponse response, long objectSize, Action<int, long, long> progressReporter)
        {
            PartNumber = partNumber;
            _ownedResponse = response ?? throw new ArgumentNullException(nameof(response));
            
            Logger.DebugFormat("[DEBUG] StreamDataSource constructor - creating for part {0}, ContentLength={1}, ObjectSize={2}, ETag={3}", 
                partNumber, response.ContentLength, objectSize, response.ETag);
            
            // Create the streaming callback that uses the owned response
            // FIXED: Just read what the consumer requested from HTTP stream - let the stream handle completion
            _streamCallback = async (buffer, offset, count, ct) =>
            {
                Logger.DebugFormat("[StreamDataSource] Part {0} lambda callback called - offset={1}, count={2}, ContentLength={3}", 
                    partNumber, offset, count, response.ContentLength);
                
                // Simple fix: Just read from the HTTP stream until it says it's done
                var bytesRead = await response.ResponseStream.ReadAsync(
                    buffer, offset, count, ct).ConfigureAwait(false);
                
                Logger.DebugFormat("[StreamDataSource] Part {0} lambda callback completed - totalRead={1}, requested={2}", 
                    partNumber, bytesRead, count);
                
                progressReporter?.Invoke(partNumber, bytesRead, objectSize);
                return bytesRead;
            };
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
            {
                Logger.DebugFormat("[StreamDataSource] Part {0} ReadAsync called but already complete, returning 0", PartNumber);
                return 0; // End of stream
            }

            Logger.DebugFormat("[StreamDataSource] Part {0} ReadAsync called - offset={1}, count={2}, isComplete={3}", 
                PartNumber, offset, count, _isComplete);

            try
            {
                // Direct streaming: HTTP response stream → user buffer (zero-copy)
                var bytesRead = await _streamCallback(buffer, offset, count, cancellationToken).ConfigureAwait(false);
                
                Logger.DebugFormat("[StreamDataSource] Part {0} ReadAsync - streamCallback returned {1} bytes (requested {2})", 
                    PartNumber, bytesRead, count);

                // ENHANCED DEBUGGING: Log first and last few bytes for pattern verification
                if (bytesRead > 0)
                {
                    var firstBytes = "";
                    var lastBytes = "";
                    int bytesToLog = Math.Min(8, bytesRead);
                    
                    for (int i = 0; i < bytesToLog; i++)
                    {
                        firstBytes += $"0x{buffer[offset + i]:X2} ";
                    }
                    
                    if (bytesRead > 8)
                    {
                        for (int i = Math.Max(bytesToLog, bytesRead - 4); i < bytesRead; i++)
                        {
                            lastBytes += $"0x{buffer[offset + i]:X2} ";
                        }
                        Logger.DebugFormat("[StreamDataSource] Part {0} data - first bytes: {1}, last bytes: {2}", 
                            PartNumber, firstBytes.TrimEnd(), lastBytes.TrimEnd());
                    }
                    else
                    {
                        Logger.DebugFormat("[StreamDataSource] Part {0} data - bytes: {1}", 
                            PartNumber, firstBytes.TrimEnd());
                    }
                }
                
                // If we read less than requested, we've reached the end of this part
                if (bytesRead < count || bytesRead == 0)
                {
                    Logger.DebugFormat("[StreamDataSource] Part {0} ReadAsync - marking complete because bytesRead({1}) < count({2}) or bytesRead == 0", 
                        PartNumber, bytesRead, count);
                    Logger.DebugFormat("[StreamDataSource] Part {0} ReadAsync - STREAM ENDED: ExpectedContentLength={1}", 
                        PartNumber, _ownedResponse?.ContentLength ?? -1);
                    _isComplete = true;
                }
                
                return bytesRead;
            }
            catch (Exception ex)
            {
                Logger.DebugFormat("[StreamDataSource] Part {0} ReadAsync failed: {1}", PartNumber, ex.Message);
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
                    
                    // If we own the response, dispose it properly
                    _ownedResponse?.Dispose();
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
