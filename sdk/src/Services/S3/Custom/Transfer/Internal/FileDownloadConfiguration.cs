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
    /// Configuration settings for file-based multipart downloads.
    /// Extends base coordinator settings with file-specific parameters.
    /// </summary>
    internal class FileDownloadConfiguration : DownloadManagerConfiguration
    {
        /// <summary>
        /// Buffer size for file I/O operations.
        /// </summary>
        public int BufferSize { get; set; }
        
        /// <summary>
        /// Destination file path for the download.
        /// </summary>
        public string DestinationFilePath { get; set; }
        
        /// <summary>
        /// Creates a FileDownloadConfiguration with the specified configuration values.
        /// </summary>
        /// <param name="concurrentServiceRequests">Maximum concurrent HTTP requests for downloading parts.</param>
        /// <param name="bufferSize">Buffer size used for file I/O operations.</param>
        /// <param name="targetPartSizeBytes">Target size for each part in bytes.</param>
        /// <param name="destinationFilePath">Destination file path for the download.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when any numeric parameter is less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">Thrown when destinationFilePath is null or empty.</exception>
        public FileDownloadConfiguration(
            int concurrentServiceRequests,
            int bufferSize,
            long targetPartSizeBytes,
            string destinationFilePath)
            : base(concurrentServiceRequests, targetPartSizeBytes)
        {
            if (bufferSize <= 0)
                throw new ArgumentOutOfRangeException(nameof(bufferSize), "Must be greater than 0");
            if (string.IsNullOrWhiteSpace(destinationFilePath))
                throw new ArgumentException("Destination file path cannot be null or empty", nameof(destinationFilePath));
            
            BufferSize = bufferSize;
            DestinationFilePath = destinationFilePath;
        }
    }
}
