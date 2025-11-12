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
using System.Buffers;
using System.Diagnostics.CodeAnalysis;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Container for downloaded part data optimized for streaming scenarios.
    /// Uses ArrayPool buffers and tracks reading position for sequential access
    /// by BufferedMultipartStream.
    /// </summary>
    internal class StreamPartBuffer : IDisposable
    {
        private bool _disposed = false;

        /// <summary>
        /// Gets or sets the part number for priority queue ordering.
        /// For Part GET strategy: Uses the actual part number from the multipart upload.
        /// For Range GET strategy: Calculated based on byte range position.
        /// </summary>
        public int PartNumber { get; set; }

        /// <summary>
        /// Gets or sets the ArrayPool buffer containing the downloaded part data.
        /// Ownership is transferred to this StreamPartBuffer and will be returned to pool on disposal.
        /// </summary>
        public byte[] ArrayPoolBuffer { get; set; }

        /// <summary>
        /// Gets or sets the current reading position within the buffer.
        /// Used by BufferedMultipartStream for sequential reading.
        /// </summary>
        public int CurrentPosition { get; set; } = 0;

        /// <summary>
        /// Gets the number of bytes remaining to be read from current position.
        /// </summary>
        public int RemainingBytes => Math.Max(0, Length - CurrentPosition);

        /// <summary>
        /// Gets or sets the length of valid data in the ArrayPool buffer.
        /// The buffer may be larger than this due to ArrayPool size rounding.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// Creates a new StreamPartBuffer for streaming scenarios.
        /// </summary>
        /// <param name="partNumber">The part number for ordering</param>
        /// <param name="arrayPoolBuffer">The ArrayPool buffer containing the data (ownership transferred)</param>
        /// <param name="length">The length of valid data in the buffer</param>
        public StreamPartBuffer(int partNumber, byte[] arrayPoolBuffer, int length)
        {
            PartNumber = partNumber;
            ArrayPoolBuffer = arrayPoolBuffer;
            Length = length;
            CurrentPosition = 0;
        }

        /// <summary>
        /// Creates a StreamPartBuffer from ArrayPool buffer
        /// Transfers ownership of the ArrayPool buffer to this StreamPartBuffer.
        /// </summary>
        /// <param name="partNumber">The part number for ordering</param>
        /// <param name="arrayPoolBuffer">The ArrayPool buffer containing downloaded data (ownership transferred)</param>
        /// <param name="length">Length of valid data in buffer</param>
        /// <returns>A StreamPartBuffer ready for sequential reading</returns>
        public static StreamPartBuffer FromArrayPoolBuffer(int partNumber, byte[] arrayPoolBuffer, int length)
        {
            return new StreamPartBuffer(partNumber, arrayPoolBuffer, length);
        }

        /// <summary>
        /// Returns a string representation of this StreamPartBuffer for debugging.
        /// </summary>
        /// <returns>A string describing this stream part buffer</returns>
        public override string ToString()
        {
            return $"StreamPartBuffer(Part={PartNumber}, ArrayPool={Length} bytes, pos={CurrentPosition}, remaining={RemainingBytes})";
        }

        #region IDisposable Implementation

        /// <summary>
        /// Releases all resources used by this StreamPartBuffer.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases the unmanaged resources used by the StreamPartBuffer and optionally releases the managed resources.
        /// Returns the ArrayPool buffer back to the shared pool.
        /// </summary>
        /// <param name="disposing">True to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                try
                {
                    // Return ArrayPool buffer to shared pool
                    if (ArrayPoolBuffer != null)
                    {
                        ArrayPool<byte>.Shared.Return(ArrayPoolBuffer);
                        ArrayPoolBuffer = null;
                    }
                }
                catch (Exception)
                {
                    
                }

                _disposed = true;
            }
        }

        /// <summary>
        /// Finalizer to ensure resources are cleaned up if Dispose is not called.
        /// </summary>
        ~StreamPartBuffer()
        {
            Dispose(false);
        }

        #endregion
    }
}
