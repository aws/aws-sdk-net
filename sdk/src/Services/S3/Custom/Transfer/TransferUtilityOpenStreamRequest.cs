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
        /// Gets or sets the chunk buffer size (in bytes) used for buffering out-of-order parts during multipart downloads.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property controls the size of individual memory chunks allocated from the ArrayPool when buffering 
        /// downloaded parts that arrive out of order. The default value is 64 KB (65,536 bytes), which is specifically 
        /// chosen to avoid allocations on the Large Object Heap (LOH).
        /// </para>
        /// <para>
        /// <b>Default Behavior (64 KB):</b>
        /// </para>
        /// <list type="bullet">
        /// <item><description>Keeps allocations below the 85,000 byte LOH threshold</description></item>
        /// <item><description>Prevents LOH fragmentation and reduces GC pressure</description></item>
        /// </list>
        /// <para>
        /// <b>Using Larger Chunk Sizes:</b>
        /// </para>
        /// <list type="bullet">
        /// <item><description>May improve throughput by reducing the number of ArrayPool rent/return operations</description></item>
        /// <item><description>Larger chunks (≥85 KB) will be allocated on the LOH</description></item>
        /// <item><description>Can lead to increased memory fragmentation and higher long-term memory usage</description></item>
        /// <item><description>Consider this trade-off carefully based on your application's memory profile</description></item>
        /// </list>
        /// <para>
        /// Set this property to null to use the default 64 KB chunk size. Only modify this value if you have 
        /// specific performance requirements and understand the memory management implications.
        /// </para>
        /// </remarks>
        public int? ChunkBufferSize { get; set; }
    }
}
