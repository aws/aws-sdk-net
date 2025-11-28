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
    /// Manages part buffers with ArrayPool lifecycle and concurrency control.
    /// </summary>
    internal interface IPartBufferManager : IDisposable
    {
        /// <summary>
        /// Waits for available buffer space before downloading a new part.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the wait operation.</param>
        /// <returns>A task that completes when buffer space becomes available.</returns>
        Task WaitForBufferSpaceAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Adds a part data source and signals readers when next expected part arrives.
        /// </summary>
        /// <param name="dataSource">The part data source to add.</param>
        void AddDataSource(IPartDataSource dataSource);
        
        /// <summary>
        /// Adds a downloaded part buffer and signals readers when next expected part arrives.
        /// </summary>
        /// <param name="buffer">The downloaded part buffer to add.</param>
        void AddBuffer(StreamPartBuffer buffer);
        
        /// <summary>
        /// Reads data from the buffer manager. Automatically handles sequential part consumption
        /// and reads across part boundaries to fill the buffer when possible, matching standard Stream.Read() behavior.
        /// </summary>
        /// <param name="buffer">The buffer to read data into.</param>
        /// <param name="offset">The offset in the buffer.</param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>
        /// A task whose result contains the number of bytes read.
        /// Returns 0 bytes read when end of stream is reached.
        /// </returns>
        Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
        
        /// <summary>
        /// Releases buffer space to allow new parts to be downloaded.
        /// </summary>
        void ReleaseBufferSpace();
        
        /// <summary>
        /// Next expected part number in the sequence.
        /// </summary>
        int NextExpectedPartNumber { get; }
        
        /// <summary>
        /// Marks download completion and handles end-of-stream.
        /// </summary>
        /// <param name="exception">Any exception that occurred during downloads, or null if successful.</param>
        void MarkDownloadComplete(Exception exception);
    }
}
