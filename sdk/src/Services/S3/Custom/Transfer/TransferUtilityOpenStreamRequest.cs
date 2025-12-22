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
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters
    /// that can be set when making a this request with the 
    /// <c>TransferUtility</c> method.
    /// </summary>
    public class TransferUtilityOpenStreamRequest : BaseDownloadRequest
    {
        private int _maxInMemoryParts = 1024;

        /// <summary>
        /// Gets or sets the maximum number of parts to buffer in memory during multipart downloads.
        /// The default value is 1024.
        /// </summary>
        /// <remarks>
        /// This property controls memory usage during streaming downloads. When combined with the 
        /// default part size of 8MB, the default value of 1024 parts allows up to 8GB of memory usage.
        /// Adjust this value based on your application's memory constraints and performance requirements.
        /// </remarks>
        public int MaxInMemoryParts
        {
            get { return this._maxInMemoryParts; }
            set { this._maxInMemoryParts = value; }
        }

        /// <summary>
        /// Gets or sets the chunk buffer size for ChunkedBufferStream.
        /// When null, the default 64KB chunk size is used.
        /// </summary>
        public int? ChunkBufferSize { get; set; }
    }
}
