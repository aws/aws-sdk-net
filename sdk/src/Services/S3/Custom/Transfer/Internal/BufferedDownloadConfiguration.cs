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

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Configuration settings for buffered multipart downloads to streams.
    /// Extends base coordinator settings with buffer-specific parameters.
    /// </summary>
    internal class BufferedDownloadConfiguration : DownloadManagerConfiguration
    {
        /// <summary>
        /// Maximum parts to keep in memory simultaneously.
        /// </summary>
        public int MaxInMemoryParts { get; set; }
        
        /// <summary>
        /// Buffer size for I/O operations.
        /// </summary>
        public int BufferSize { get; set; }
        
        /// <summary>
        /// Creates a BufferedDownloadConfiguration with the specified configuration values.
        /// </summary>
        /// <param name="concurrentServiceRequests">Maximum concurrent HTTP requests for downloading parts.</param>
        /// <param name="maxInMemoryParts">Maximum number of parts to keep in memory simultaneously.</param>
        /// <param name="bufferSize">Buffer size used for optimal I/O operations.</param>
        /// <param name="targetPartSizeBytes">Target size for each part in bytes.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when any parameter is less than or equal to 0.</exception>
        public BufferedDownloadConfiguration(
            int concurrentServiceRequests,
            int maxInMemoryParts,
            int bufferSize,
            long targetPartSizeBytes)
            : base(concurrentServiceRequests, targetPartSizeBytes)
        {
            if (maxInMemoryParts <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxInMemoryParts), "Must be greater than 0");
            if (bufferSize <= 0)
                throw new ArgumentOutOfRangeException(nameof(bufferSize), "Must be greater than 0");
            
            MaxInMemoryParts = maxInMemoryParts;
            BufferSize = bufferSize;
        }
    }
}
