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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EBS.Model
{
    /// <summary>
    /// Container for the parameters to the CompleteSnapshot operation. Seals and completes
    /// the snapshot after all of the required blocks of data have been written to it. Completing
    /// the snapshot changes the status to <c>completed</c>. You cannot write new blocks to
    /// a snapshot after it has been completed. <note> <para> You should always retry requests
    /// that receive server (<c>5xx</c>) error responses, and <c>ThrottlingException</c> and
    /// <c>RequestThrottledException</c> client error responses. For more information see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
    /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. </para> </note>
    /// </summary>
    public partial class CompleteSnapshotRequest : AmazonEBSRequest
    {
        /// <summary>
        /// Gets and sets the property ChangedBlocksCount. 
        /// <para>
        /// The number of blocks that were written to the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? ChangedBlocksCount { get; set; }

        /// <summary>
        /// Checks to see if the ChangedBlocksCount property is set.
        /// </summary>
        internal bool IsSetChangedBlocksCount() => this.ChangedBlocksCount.HasValue;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// An aggregated Base-64 SHA256 checksum based on the checksums of each written block.
        /// </para>
        ///  
        /// <para>
        /// To generate the aggregated checksum using the linear aggregation method, arrange the
        /// checksums for each written block in ascending order of their block index, concatenate
        /// them to form a single string, and then generate the checksum on the entire string
        /// using the SHA256 algorithm.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property ChecksumAggregationMethod. 
        /// <para>
        /// The aggregation method used to generate the checksum. Currently, the only supported
        /// aggregation method is <c>LINEAR</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public ChecksumAggregationMethod ChecksumAggregationMethod { get; set; }

        /// <summary>
        /// Checks to see if the ChecksumAggregationMethod property is set.
        /// </summary>
        internal bool IsSetChecksumAggregationMethod() => this.ChecksumAggregationMethod != null;

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm used to generate the checksum. Currently, the only supported algorithm
        /// is <c>SHA256</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 32)]
        public ChecksumAlgorithm ChecksumAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the ChecksumAlgorithm property is set.
        /// </summary>
        internal bool IsSetChecksumAlgorithm() => this.ChecksumAlgorithm != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;
    }
}
