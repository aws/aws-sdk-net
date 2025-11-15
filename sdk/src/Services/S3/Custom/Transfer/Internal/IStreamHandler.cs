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
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Abstraction for different streaming strategies (single-part vs multipart).
    /// </summary>
    internal interface IStreamHandler : IDisposable
    {
        /// <summary>
        /// Asynchronously reads data into the provided buffer.
        /// </summary>
        /// <param name="buffer">The buffer to write data into.</param>
        /// <param name="offset">The zero-based byte offset in buffer at which to begin storing data.</param>
        /// <param name="count">The maximum number of bytes to read.</param>
        /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
        /// <returns>
        /// A task representing the asynchronous read operation. The value of the task's Result 
        /// parameter contains the total number of bytes read into the buffer. The result value 
        /// can be less than the number of bytes requested if the number of bytes currently 
        /// available is less than the requested number, or it can be 0 (zero) if the end 
        /// of the stream has been reached.
        /// </returns>
        Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);
    }
}
