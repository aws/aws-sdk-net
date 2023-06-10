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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshots operation.
    /// Describes the specified EBS snapshots available to you or all of the EBS snapshots
    /// available to you.
    /// 
    ///  
    /// <para>
    /// The snapshots available to you include public snapshots, private snapshots that you
    /// own, and private snapshots owned by other Amazon Web Services accounts for which you
    /// have explicit create volume permissions.
    /// </para>
    ///  
    /// <para>
    /// The create volume permissions fall into the following categories:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
    /// snapshot to the <code>all</code> group. All Amazon Web Services accounts have create
    /// volume permissions for these snapshots.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
    /// specific Amazon Web Services account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>implicit</i>: An Amazon Web Services account has implicit create volume permissions
    /// for all snapshots it owns.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The list of snapshots returned can be filtered by specifying snapshot IDs, snapshot
    /// owners, or Amazon Web Services accounts with create volume permissions. If no options
    /// are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.
    /// </para>
    ///  
    /// <para>
    /// If you specify one or more snapshot IDs, only snapshots that have the specified IDs
    /// are returned. If you specify an invalid snapshot ID, an error is returned. If you
    /// specify a snapshot ID for which you do not have access, it is not included in the
    /// returned results.
    /// </para>
    ///  
    /// <para>
    /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
    /// only snapshots from the specified owners and for which you have access are returned.
    /// The results can include the Amazon Web Services account IDs of the specified owners,
    /// <code>amazon</code> for snapshots owned by Amazon, or <code>self</code> for snapshots
    /// that you own.
    /// </para>
    ///  
    /// <para>
    /// If you specify a list of restorable users, only snapshots with create snapshot permissions
    /// for those users are returned. You can specify Amazon Web Services account IDs (if
    /// you own the snapshots), <code>self</code> for snapshots for which you own or have
    /// explicit permissions, or <code>all</code> for public snapshots.
    /// </para>
    ///  
    /// <para>
    /// If you are describing a long list of snapshots, we recommend that you paginate the
    /// output to make the list more manageable. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
    /// </para>
    ///  
    /// <para>
    /// To get the state of fast snapshot restores for a snapshot, use <a>DescribeFastSnapshotRestores</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
    /// EBS snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _ownerIds = new List<string>();
        private List<string> _restorableByUserIds = new List<string>();
        private List<string> _snapshotIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// The filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>description</code> - A description of the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>encrypted</code> - Indicates whether the snapshot is encrypted (<code>true</code>
        /// | <code>false</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-alias</code> - The owner alias, from an Amazon-maintained list (<code>amazon</code>).
        /// This is not the user-configured Amazon Web Services account alias set using the IAM
        /// console. We recommend that you use the related parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>owner-id</code> - The Amazon Web Services account ID of the owner. We recommend
        /// that you use the related parameter instead of this filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>progress</code> - The progress of the snapshot, as a percentage (for example,
        /// 80%).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>snapshot-id</code> - The snapshot ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>start-time</code> - The time stamp when the snapshot was initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status</code> - The status of the snapshot (<code>pending</code> | <code>completed</code>
        /// | <code>error</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>storage-tier</code> - The storage tier of the snapshot (<code>archive</code>
        /// | <code>standard</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-id</code> - The ID of the volume the snapshot is for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>volume-size</code> - The size of the volume, in GiB.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
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
        /// <para>
        /// The maximum number of snapshots to return for this request. This value can be between
        /// 5 and 1,000; if this value is larger than 1,000, only 1,000 results are returned.
        /// If this parameter is not used, then the request returns all snapshots. You cannot
        /// specify this parameter and the snapshot IDs parameter in the same request. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html#api-pagination">Pagination</a>.
        /// </para>
        /// </summary>
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
        /// <para>
        /// The token returned from a previous paginated request. Pagination continues from the
        /// end of the items returned by the previous request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwnerIds. 
        /// <para>
        /// Scopes the results to snapshots with the specified owners. You can specify a combination
        /// of Amazon Web Services account IDs, <code>self</code>, and <code>amazon</code>.
        /// </para>
        /// </summary>
        public List<string> OwnerIds
        {
            get { return this._ownerIds; }
            set { this._ownerIds = value; }
        }

        // Check to see if OwnerIds property is set
        internal bool IsSetOwnerIds()
        {
            return this._ownerIds != null && this._ownerIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RestorableByUserIds. 
        /// <para>
        /// The IDs of the Amazon Web Services accounts that can create volumes from the snapshot.
        /// </para>
        /// </summary>
        public List<string> RestorableByUserIds
        {
            get { return this._restorableByUserIds; }
            set { this._restorableByUserIds = value; }
        }

        // Check to see if RestorableByUserIds property is set
        internal bool IsSetRestorableByUserIds()
        {
            return this._restorableByUserIds != null && this._restorableByUserIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotIds. 
        /// <para>
        /// The snapshot IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes the snapshots for which you have create volume permissions.
        /// </para>
        /// </summary>
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