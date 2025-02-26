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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
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
    /// Container for the parameters to the CompleteSnapshot operation.
    /// Seals and completes the snapshot after all of the required blocks of data have been
    /// written to it. Completing the snapshot changes the status to <c>completed</c>. You
    /// cannot write new blocks to a snapshot after it has been completed.
    /// 
    ///  <note> 
    /// <para>
    /// You should always retry requests that receive server (<c>5xx</c>) error responses,
    /// and <c>ThrottlingException</c> and <c>RequestThrottledException</c> client error responses.
    /// For more information see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
    /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CompleteSnapshotRequest : AmazonEBSRequest
    {
        private int? _changedBlocksCount;
        private string _checksum;
        private ChecksumAggregationMethod _checksumAggregationMethod;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property ChangedBlocksCount. 
        /// <para>
        /// The number of blocks that were written to the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? ChangedBlocksCount
        {
            get { return this._changedBlocksCount; }
            set { this._changedBlocksCount = value; }
        }

        // Check to see if ChangedBlocksCount property is set
        internal bool IsSetChangedBlocksCount()
        {
            return this._changedBlocksCount.HasValue; 
        }

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
        [AWSProperty(Max=64)]
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAggregationMethod. 
        /// <para>
        /// The aggregation method used to generate the checksum. Currently, the only supported
        /// aggregation method is <c>LINEAR</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public ChecksumAggregationMethod ChecksumAggregationMethod
        {
            get { return this._checksumAggregationMethod; }
            set { this._checksumAggregationMethod = value; }
        }

        // Check to see if ChecksumAggregationMethod property is set
        internal bool IsSetChecksumAggregationMethod()
        {
            return this._checksumAggregationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// The algorithm used to generate the checksum. Currently, the only supported algorithm
        /// is <c>SHA256</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}