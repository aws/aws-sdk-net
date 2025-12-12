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
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Strategy interface for processing downloaded part data.
    /// Implementations determine WHERE and HOW downloaded parts are stored.
    /// Enables separation of download orchestration from data handling (buffering, file writing, etc).
    /// </summary>
    internal interface IPartDataHandler : IDisposable
    {
        /// <summary>
        /// Prepare the handler for processing parts based on discovery result.
        /// Called once before any parts are processed to perform initialization.
        /// </summary>
        /// <param name="discoveryResult">Discovery result containing object metadata</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task that completes when preparation is done</returns>
        Task PrepareAsync(DownloadResult discoveryResult, CancellationToken cancellationToken);
        
        /// <summary>
        /// Process a downloaded part from the GetObjectResponse.
        /// Implementation decides whether to buffer in memory, write to file, etc.
        /// </summary>
        /// <param name="partNumber">1-based part number</param>
        /// <param name="response">GetObjectResponse with ResponseStream to process</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task that completes when part processing is done</returns>
        Task ProcessPartAsync(
            int partNumber, 
            GetObjectResponse response, 
            CancellationToken cancellationToken);
        
        /// <summary>
        /// Wait for available capacity to process another part.
        /// Allows implementations to implement backpressure (memory limits, concurrency, etc).
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Task that completes when capacity becomes available</returns>
        Task WaitForCapacityAsync(CancellationToken cancellationToken);
        
        /// <summary>
        /// Release capacity after a part is processed/consumed.
        /// Pairs with WaitForCapacityAsync for backpressure management.
        /// </summary>
        void ReleaseCapacity();
        
        /// <summary>
        /// Called when all downloads complete (successfully or with error).
        /// Allows implementations to perform cleanup or commit operations.
        /// </summary>
        /// <param name="exception">Exception if download failed, null if successful</param>
        void OnDownloadComplete(Exception exception);
    }
}
