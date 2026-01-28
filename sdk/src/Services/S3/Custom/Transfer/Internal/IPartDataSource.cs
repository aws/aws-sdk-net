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
    /// Interface for buffered part data sources.
    /// </summary>
    internal interface IPartDataSource : IDisposable
    {
        /// <summary>
        /// Reads data from the ArrayPool buffer into the destination buffer.
        /// </summary>
        /// <param name="buffer">Destination buffer</param>
        /// <param name="offset">Offset in destination buffer</param>
        /// <param name="count">Maximum bytes to read</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Number of bytes actually read</returns>
        Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

        /// <summary>
        /// Whether this data source has been fully consumed.
        /// </summary>
        bool IsComplete { get; }

        /// <summary>
        /// Part number this data source represents.
        /// </summary>
        int PartNumber { get; }
    }
}
