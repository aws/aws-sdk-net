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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshots operation.
    /// Returns the description of specific Amazon FSx for OpenZFS snapshots, if a <code>SnapshotIds</code>
    /// value is provided. Otherwise, this operation returns all snapshots owned by your Amazon
    /// Web Services account in the Amazon Web Services Region of the endpoint that you're
    /// calling.
    /// 
    ///  
    /// <para>
    /// When retrieving all snapshots, you can optionally specify the <code>MaxResults</code>
    /// parameter to limit the number of snapshots in a response. If more backups remain,
    /// Amazon FSx returns a <code>NextToken</code> value in the response. In this case, send
    /// a later request with the <code>NextToken</code> request parameter set to the value
    /// of <code>NextToken</code> from the last response. 
    /// </para>
    ///  
    /// <para>
    /// Use this operation in an iterative process to retrieve a list of your snapshots. <code>DescribeSnapshots</code>
    /// is called first without a <code>NextToken</code> value. Then the operation continues
    /// to be called with the <code>NextToken</code> parameter set to the value of the last
    /// <code>NextToken</code> value until a response has no <code>NextToken</code> value.
    /// </para>
    ///  
    /// <para>
    /// When using this operation, keep the following in mind:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The operation might return fewer than the <code>MaxResults</code> value of snapshot
    /// descriptions while still including a <code>NextToken</code> value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The order of snapshots returned in the response of one <code>DescribeSnapshots</code>
    /// call and the order of backups returned across the responses of a multi-call iteration
    /// is unspecified. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonFSxRequest
    {
        private List<SnapshotFilter> _filters = new List<SnapshotFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _snapshotIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters structure. The supported names are <code>file-system-id</code> or <code>volume-id</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<SnapshotFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property SnapshotIds. 
        /// <para>
        /// The IDs of the snapshots that you want to retrieve. This parameter value overrides
        /// any filters. If any IDs aren't found, a <code>SnapshotNotFound</code> error occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> SnapshotIds
        {
            get { return this._snapshotIds; }
            set { this._snapshotIds = value; }
        }

        // Check to see if SnapshotIds property is set
        internal bool IsSetSnapshotIds()
        {
            return this._snapshotIds != null && this._snapshotIds.Count > 0; 
        }

    }
}