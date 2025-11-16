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
    /// Base configuration for multipart download coordination.
    /// Contains settings common to all download strategies.
    /// </summary>
    internal class DownloadCoordinatorConfiguration
    {
        /// <summary>
        /// Maximum concurrent HTTP requests for downloading parts.
        /// </summary>
        public int ConcurrentServiceRequests { get; set; }
        
        /// <summary>
        /// Target part size in bytes.
        /// </summary>
        public long TargetPartSizeBytes { get; set; }
        
        /// <summary>
        /// Protected default constructor for derived classes.
        /// </summary>
        protected DownloadCoordinatorConfiguration() { }
        
        /// <summary>
        /// Creates a DownloadCoordinatorConfiguration with the specified configuration values.
        /// </summary>
        /// <param name="concurrentServiceRequests">Maximum concurrent HTTP requests for downloading parts.</param>
        /// <param name="targetPartSizeBytes">Target size for each part in bytes.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when any parameter is less than or equal to 0.</exception>
        public DownloadCoordinatorConfiguration(int concurrentServiceRequests, long targetPartSizeBytes)
        {
            if (concurrentServiceRequests <= 0)
                throw new ArgumentOutOfRangeException(nameof(concurrentServiceRequests), "Must be greater than 0");
            if (targetPartSizeBytes <= 0)
                throw new ArgumentOutOfRangeException(nameof(targetPartSizeBytes), "Must be greater than 0");
            
            ConcurrentServiceRequests = concurrentServiceRequests;
            TargetPartSizeBytes = targetPartSizeBytes;
        }
    }
}
