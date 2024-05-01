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
    /// Container for the parameters to the ListSnapshotBlocks operation.
    /// Returns information about the blocks in an Amazon Elastic Block Store snapshot.
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
    public partial class ListSnapshotBlocksRequest : AmazonEBSRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _snapshotId;
        private int? _startingBlockIndex;

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
        [AWSProperty(Min=100, Max=10000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

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
        [AWSProperty(Max=256)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot from which to get block indexes and block tokens.
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

        /// <summary>
        /// Gets and sets the property StartingBlockIndex. 
        /// <para>
        /// The block index from which the list should start. The list in the response will start
        /// from this block index or the next valid block index in the snapshot.
        /// </para>
        ///  
        /// <para>
        /// If you specify <b>NextToken</b>, then <b>StartingBlockIndex</b> is ignored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? StartingBlockIndex
        {
            get { return this._startingBlockIndex; }
            set { this._startingBlockIndex = value; }
        }

        // Check to see if StartingBlockIndex property is set
        internal bool IsSetStartingBlockIndex()
        {
            return this._startingBlockIndex.HasValue; 
        }

    }
}