/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshots operation.
    /// Describes one or more of the Amazon EBS snapshots available to you. Available snapshots
    /// include public snapshots available for any AWS account to launch, private snapshots
    /// that you own, and private snapshots owned by another AWS account but for which you've
    /// been given explicit create volume permissions.
    /// 
    ///  
    /// <para>
    /// The create volume permissions fall into the following categories:
    /// </para>
    ///  <ul> <li> <i>public</i>: The owner of the snapshot granted create volume permissions
    /// for the snapshot to the <code>all</code> group. All AWS accounts have create volume
    /// permissions for these snapshots.</li> <li> <i>explicit</i>: The owner of the snapshot
    /// granted create volume permissions to a specific AWS account.</li> <li> <i>implicit</i>:
    /// An AWS account has implicit create volume permissions for all snapshots it owns.</li>
    /// </ul> 
    /// <para>
    /// The list of snapshots returned can be modified by specifying snapshot IDs, snapshot
    /// owners, or AWS accounts with create volume permissions. If no options are specified,
    /// Amazon EC2 returns all snapshots for which you have create volume permissions.
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
    /// If you specify one or more snapshot owners, only snapshots from the specified owners
    /// and for which you have access are returned. The results can include the AWS account
    /// IDs of the specified owners, <code>amazon</code> for snapshots owned by Amazon, or
    /// <code>self</code> for snapshots that you own.
    /// </para>
    ///  
    /// <para>
    /// If you specify a list of restorable users, only snapshots with create snapshot permissions
    /// for those users are returned. You can specify AWS account IDs (if you own the snapshots),
    /// <code>self</code> for snapshots for which you own or have explicit permissions, or
    /// <code>all</code> for public snapshots.
    /// </para>
    ///  
    /// <para>
    /// For more information about Amazon EBS snapshots, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html'>Amazon
    /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _ownerIds = new List<string>();
        private List<string> _restorableByUserIds = new List<string>();
        private List<string> _snapshotIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>description</code> - A description of the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>owner-alias</code> - The AWS account alias (for example, <code>amazon</code>)
        /// that owns the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>owner-id</code> - The ID of the AWS account that owns the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>progress</code> - The progress of the snapshot, as a percentage (for example,
        /// 80%).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>snapshot-id</code> - The snapshot ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>start-time</code> - The time stamp when the snapshot was initiated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>status</code> - The status of the snapshot (<code>pending</code> | <code>completed</code>
        /// | <code>error</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag</code>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned
        /// to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-key</code> - The key of a tag assigned to the resource. This filter is independent
        /// of the <code>tag-value</code> filter. For example, if you use both the filter "tag-key=Purpose"
        /// and the filter "tag-value=X", you get any resources assigned both the tag key Purpose
        /// (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <code>tag</code>:<i>key</i>=<i>value</i>
        /// filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>tag-value</code> - The value of a tag assigned to the resource. This filter
        /// is independent of the <code>tag-key</code> filter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>volume-id</code> - The ID of the volume the snapshot is for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>volume-size</code> - The size of the volume, in GiB.
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
        /// Gets and sets the property OwnerIds. 
        /// <para>
        /// Returns the snapshots owned by the specified owner. Multiple owners can be specified.
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
        /// One or more AWS accounts IDs that can create volumes from the snapshot.
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
        /// One or more snapshot IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes snapshots for which you have launch permissions.
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