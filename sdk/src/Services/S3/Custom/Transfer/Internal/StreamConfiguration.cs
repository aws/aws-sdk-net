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
    /// Configuration settings for multipart download streams.
    /// Encapsulates all configuration parameters needed by the stream components.
    /// </summary>
    internal class StreamConfiguration
    {
        /// <summary>
        /// Maximum number of concurrent HTTP requests for downloading parts.
        /// Controls download parallelism and resource usage.
        /// </summary>
        public int ConcurrentServiceRequests { get; set; }
        
        /// <summary>
        /// Maximum number of parts to keep in memory simultaneously.
        /// Controls memory usage by limiting buffered parts.
        /// </summary>
        public int MaxInMemoryParts { get; set; }
        
        /// <summary>
        /// Target size for each part in bytes.
        /// Used for buffer allocation and part range calculations.
        /// </summary>
        public long TargetPartSizeBytes { get; set; }
        
        /// <summary>
        /// Buffer size used for optimal I/O operations.
        /// Controls the chunk size for reading from S3 response streams.
        /// </summary>
        public int BufferSize { get; set; }
        
        /// <summary>
        /// Creates a StreamConfiguration from the specific configuration values needed.
        /// </summary>
        /// <param name="concurrentServiceRequests">Maximum concurrent HTTP requests for downloading parts.</param>
        /// <param name="maxInMemoryParts">Maximum number of parts to keep in memory simultaneously.</param>
        /// <param name="bufferSize">Buffer size used for optimal I/O operations.</param>
        /// <param name="request">Download request containing part size information.</param>
        /// <returns>A new StreamConfiguration instance with the specified values.</returns>
        public static StreamConfiguration FromValues(int concurrentServiceRequests, int maxInMemoryParts, int bufferSize, BaseDownloadRequest request = null)
        {
            // Determine target part size from request or use 8MB default
            long targetPartSize = (request?.IsSetPartSize() == true) 
                ? request.PartSize 
                : 8 * 1024 * 1024; // 8MB default
                
            return new StreamConfiguration
            {
                ConcurrentServiceRequests = concurrentServiceRequests,
                MaxInMemoryParts = maxInMemoryParts,
                TargetPartSizeBytes = targetPartSize,
                BufferSize = bufferSize
            };
        }
        
        /// <summary>
        /// Validates that all configuration values are within acceptable ranges.
        /// </summary>
        public void Validate()
        {
            if (ConcurrentServiceRequests <= 0)
                throw new ArgumentOutOfRangeException(nameof(ConcurrentServiceRequests), "Must be greater than 0");
                
            if (MaxInMemoryParts <= 0)
                throw new ArgumentOutOfRangeException(nameof(MaxInMemoryParts), "Must be greater than 0");
                
            if (TargetPartSizeBytes <= 0)
                throw new ArgumentOutOfRangeException(nameof(TargetPartSizeBytes), "Must be greater than 0");
                
            if (BufferSize <= 0)
                throw new ArgumentOutOfRangeException(nameof(BufferSize), "Must be greater than 0");
        }
        
        /// <summary>
        /// Creates a copy of this configuration.
        /// </summary>
        /// <returns>A new StreamConfiguration instance with the same values.</returns>
        public StreamConfiguration Clone()
        {
            return new StreamConfiguration
            {
                ConcurrentServiceRequests = ConcurrentServiceRequests,
                MaxInMemoryParts = MaxInMemoryParts,
                TargetPartSizeBytes = TargetPartSizeBytes,
                BufferSize = BufferSize
            };
        }
    }
}
