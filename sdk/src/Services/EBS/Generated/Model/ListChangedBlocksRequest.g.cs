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
    /// Container for the parameters to the ListChangedBlocks operation. Returns information
    /// about the blocks that are different between two Amazon Elastic Block Store snapshots
    /// of the same volume/snapshot lineage. <note> <para> You should always retry requests
    /// that receive server (<c>5xx</c>) error responses, and <c>ThrottlingException</c> and
    /// <c>RequestThrottledException</c> client error responses. For more information see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/error-retries.html">Error
    /// retries</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. </para> </note>
    /// </summary>
    public partial class ListChangedBlocksRequest : AmazonEBSRequest
    {
        /// <summary>
        /// Gets and sets the property FirstSnapshotId. 
        /// <para>
        /// The ID of the first snapshot to use for the comparison.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>FirstSnapshotID</c> parameter must be specified with a <c>SecondSnapshotId</c>
        /// parameter; otherwise, an error occurs.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string FirstSnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the FirstSnapshotId property is set.
        /// </summary>
        internal bool IsSetFirstSnapshotId() => this.FirstSnapshotId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of blocks to be returned by the request.
        /// </para>
        ///  
        /// <para>
        /// Even if additional blocks can be retrieved from the snapshot, the request can return
        /// less blocks than <b>MaxResults</b> or an empty array of blocks.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the next set of blocks from the snapshot, make another request with the
        /// returned <b>NextToken</b> value. The value of <b>NextToken</b> is <c>null</c> when
        /// there are no more blocks to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 100, Max = 10000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to request the next page of results.
        /// </para>
        ///  
        /// <para>
        /// If you specify <b>NextToken</b>, then <b>StartingBlockIndex</b> is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SecondSnapshotId. 
        /// <para>
        /// The ID of the second snapshot to use for the comparison.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>SecondSnapshotId</c> parameter must be specified with a <c>FirstSnapshotID</c>
        /// parameter; otherwise, an error occurs.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string SecondSnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SecondSnapshotId property is set.
        /// </summary>
        internal bool IsSetSecondSnapshotId() => this.SecondSnapshotId != null;

        /// <summary>
        /// Gets and sets the property StartingBlockIndex. 
        /// <para>
        /// The block index from which the comparison should start.
        /// </para>
        ///  
        /// <para>
        /// The list in the response will start from this block index or the next valid block
        /// index in the snapshots.
        /// </para>
        ///  
        /// <para>
        /// If you specify <b>NextToken</b>, then <b>StartingBlockIndex</b> is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? StartingBlockIndex { get; set; }

        /// <summary>
        /// Checks to see if the StartingBlockIndex property is set.
        /// </summary>
        internal bool IsSetStartingBlockIndex() => this.StartingBlockIndex.HasValue;
    }
}
