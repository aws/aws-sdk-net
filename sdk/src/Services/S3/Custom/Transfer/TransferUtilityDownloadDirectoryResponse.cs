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
using Amazon.S3.Transfer.Model;

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
        /// Only populated when the <see cref="FailurePolicy"/> is <see cref="FailurePolicy.ContinueOnFailure"/>.
        /// </summary>
        public IList<Exception> Errors { get; set; }

        /// <summary>
        /// Overall result of the directory download operation.
        /// </summary>
        public DirectoryResult Result { get; set; }
    }
}
