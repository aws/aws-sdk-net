/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains the details returned from a Transfer Utility download directory operation.
    /// </summary>
    public class TransferUtilityDownloadDirectoryResponse
    {
        /// <summary>
        /// The number of objects that have been successfully downloaded.
        /// </summary>
        public long ObjectsDownloaded { get; set; }

        /// <summary>
        /// The number of objects that failed to download. Zero if all succeeded.
        /// </summary>
        public long ObjectsFailed { get; set; }

        /// <summary>
        /// The collection of exceptions encountered when downloading individual objects.
        /// Only populated when the FailurePolicy is CONTINUE_ON_FAILURE.
        /// </summary>
        public IList<Exception> Errors { get; set; }

        /// <summary>
        /// Overall result of the directory download operation.
        /// SUCCESS: All objects downloaded.
        /// PARTIAL_SUCCESS: Some objects downloaded, some failed (CONTINUE_ON_FAILURE policy).
        /// FAILURE: All attempted objects failed (CONTINUE_ON_FAILURE policy).
        /// </summary>
        public TransferUtilityDownloadDirectoryResult Result { get; set; } = TransferUtilityDownloadDirectoryResult.SUCCESS;
    }

    /// <summary>
    /// Overall outcome of a directory download operation.
    /// </summary>
    public enum TransferUtilityDownloadDirectoryResult
    {
        /// <summary>
        /// All objects downloaded successfully.
        /// </summary>
        SUCCESS,
        /// <summary>
        /// Some objects succeeded and some failed.
        /// </summary>
        PARTIAL_SUCCESS,
        /// <summary>
        /// All attempted objects failed.
        /// </summary>
        FAILURE
    }
}
