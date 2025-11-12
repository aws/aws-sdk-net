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
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Result of a part read operation indicating how the data was obtained.
    /// </summary>
    internal class ReadResult
    {
        public int BytesRead { get; set; }
        public bool IsDirectStreamed { get; set; }
    }

    /// <summary>
    /// Manages part buffers with ArrayPool lifecycle and concurrency control.
    /// Handles smart sequential signaling and buffer space management to ensure
    /// efficient memory usage during multipart downloads.
    /// Uses callback-based coordination for optimal direct streaming performance.
    /// </summary>
    internal interface IPartBufferManager : IDisposable
    {
        /// <summary>
        /// Wait for available buffer space before downloading a new part.
        /// This ensures we don't exceed the configured maximum number of parts in memory.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the wait operation.</param>
        /// <returns>A task that completes when buffer space becomes available.</returns>
        Task WaitForBufferSpaceAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Add a data source (either buffered or streaming) for a specific part.
        /// This unified method handles both buffered parts and direct streaming sources.
        /// Uses smart signaling to only notify readers when the next expected part arrives.
        /// </summary>
        /// <param name="dataSource">The data source (BufferedDataSource or StreamDataSource) to add.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A task that completes when the data source has been added and signaling is complete.</returns>
        Task AddDataSourceAsync(IPartDataSource dataSource, CancellationToken cancellationToken);
        
        /// <summary>
        /// Add a downloaded part buffer and signal readers if it enables sequential reading.
        /// Uses smart signaling to only notify readers when the next expected part arrives.
        /// </summary>
        /// <param name="buffer">The downloaded part buffer to add.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A task that completes when the buffer has been added and signaling is complete.</returns>
        Task AddBufferAsync(StreamPartBuffer buffer, CancellationToken cancellationToken);
        
        /// <summary>
        /// Add a direct streaming source for a specific part number.
        /// This enables zero-copy performance when the reader is ready to consume data immediately.
        /// </summary>
        /// <param name="partNumber">The part number that will be available for streaming.</param>
        /// <param name="streamCallback">Callback to stream data directly to a reader's buffer.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A task that completes when the streaming source has been registered.</returns>
        Task AddStreamSourceAsync(int partNumber, Func<byte[], int, int, CancellationToken, Task<int>> streamCallback, CancellationToken cancellationToken);
        
        /// <summary>
        /// Read a part with automatic coordination between direct streaming and buffered data.
        /// This unified method handles both direct streaming (when available) and buffered reads seamlessly.
        /// </summary>
        /// <param name="partNumber">The part number to read.</param>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="offset">The offset in the buffer.</param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>
        /// A task whose result contains the number of bytes read and whether direct streaming was used.
        /// Returns 0 bytes read when end of stream is reached.
        /// </returns>
        Task<ReadResult> ReadPartAsync(int partNumber, byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        
        /// <summary>
        /// Release buffer space when a consumer finishes with a part.
        /// This allows new parts to be downloaded by freeing up buffer slots.
        /// </summary>
        void ReleaseBufferSpace();
        
        /// <summary>
        /// Gets the next expected part number in the sequence.
        /// Used for coordination between downloaders and readers.
        /// </summary>
        int NextExpectedPartNumber { get; }
        
        /// <summary>
        /// Mark that downloads have completed to handle end-of-stream scenarios.
        /// </summary>
        /// <param name="exception">Any exception that occurred during downloads, or null if successful.</param>
        void MarkDownloadComplete(Exception exception);
    }
}
