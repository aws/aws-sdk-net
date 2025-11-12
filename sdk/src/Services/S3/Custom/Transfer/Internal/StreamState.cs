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

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Represents the current state of a multipart download stream.
    /// Used for progress monitoring, error handling, and coordination between components.
    /// </summary>
    internal enum StreamState
    {
        /// <summary>
        /// Stream is being initialized - discovery phase in progress.
        /// </summary>
        Initializing,
        
        /// <summary>
        /// Single-part download detected - using direct stream passthrough.
        /// </summary>
        SinglePartStreaming,
        
        /// <summary>
        /// Multipart downloads are actively in progress.
        /// Parts are being downloaded concurrently and buffered for sequential reading.
        /// </summary>
        MultipartDownloading,
        
        /// <summary>
        /// All downloads have completed successfully.
        /// Stream may still have buffered data available for reading.
        /// </summary>
        DownloadsComplete,
        
        /// <summary>
        /// An error occurred during downloads.
        /// Stream is in an error state and should propagate the exception.
        /// </summary>
        Error,
        
        /// <summary>
        /// Stream has been disposed and is no longer usable.
        /// </summary>
        Disposed
    }
}
