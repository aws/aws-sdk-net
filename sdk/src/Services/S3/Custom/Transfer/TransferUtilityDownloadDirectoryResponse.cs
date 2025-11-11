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

using Amazon.Runtime;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains the details returned from a Transfer Utility download directory operation.
    /// </summary>
    public class TransferUtilityDownloadDirectoryResponse
    {
        /// <summary>
        /// The number of objects that have been downloaded
        /// </summary>
        public long ObjectsDownloaded { get; set; }
    }
}
