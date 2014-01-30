/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Describes one or more of the Amazon EBS snapshots available to you. Available snapshots include public snapshots available for any AWS
    /// account to launch, private snapshots that you own, and private snapshots owned by another AWS account but for which you've been given
    /// explicit create volume permissions.</para> <para>The create volume permissions fall into the following categories:</para>
    /// <ul>
    /// <li> <i>public</i> : The owner of the snapshot granted create volume permissions for the snapshot to the <c>all</c> group. All AWS accounts
    /// have create volume permissions for these snapshots.</li>
    /// <li> <i>explicit</i> : The owner of the snapshot granted create volume permissions to a specific AWS account.</li>
    /// <li> <i>implicit</i> : An AWS account has implicit create volume permissions for all snapshots it owns.</li>
    /// 
    /// </ul>
    /// <para>The list of snapshots returned can be modified by specifying snapshot IDs, snapshot owners, or AWS accounts with create volume
    /// permissions. If no options are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.</para> <para>If you
    /// specify one or more snapshot IDs, only snapshots that have the specified IDs are returned. If you specify an invalid snapshot ID, an error
    /// is returned. If you specify a snapshot ID for which you do not have access, it is not included in the returned results.</para> <para>If you
    /// specify one or more snapshot owners, only snapshots from the specified owners and for which you have access are returned. The results can
    /// include the AWS account IDs of the specified owners, <c>amazon</c> for snapshots owned by Amazon, or <c>self</c> for snapshots that you
    /// own.</para> <para>If you specify a list of restorable users, only snapshots with create snapshot permissions for those users are returned.
    /// You can specify AWS account IDs (if you own the snapshots), <c>self</c> for snapshots for which you own or have explicit permissions, or
    /// <c>all</c> for public snapshots.</para> <para>For more information about Amazon EBS snapshots, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html" >Amazon EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i> .</para>
    /// </summary>
    public partial class DescribeSnapshotsRequest : AmazonEC2Request
    {
        private List<string> snapshotIds = new List<string>();
        private List<string> ownerIds = new List<string>();
        private List<string> restorableByUserIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more snapshot IDs. Default: Describes snapshots for which you have launch permissions.
        ///  
        /// </summary>
        public List<string> SnapshotIds
        {
            get { return this.snapshotIds; }
            set { this.snapshotIds = value; }
        }

        // Check to see if SnapshotIds property is set
        internal bool IsSetSnapshotIds()
        {
            return this.snapshotIds.Count > 0;
        }

        /// <summary>
        /// Returns the snapshots owned by the specified owner. Multiple owners can be specified.
        ///  
        /// </summary>
        public List<string> OwnerIds
        {
            get { return this.ownerIds; }
            set { this.ownerIds = value; }
        }

        // Check to see if OwnerIds property is set
        internal bool IsSetOwnerIds()
        {
            return this.ownerIds.Count > 0;
        }

        /// <summary>
        /// One or more AWS accounts IDs that can create volumes from the snapshot.
        ///  
        /// </summary>
        public List<string> RestorableByUserIds
        {
            get { return this.restorableByUserIds; }
            set { this.restorableByUserIds = value; }
        }

        // Check to see if RestorableByUserIds property is set
        internal bool IsSetRestorableByUserIds()
        {
            return this.restorableByUserIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>description</c> - A description of the snapshot. </li> <li> <c>owner-alias</c> - The AWS account alias
        /// (for example, <c>amazon</c>) that owns the snapshot. </li> <li> <c>owner-id</c> - The ID of the AWS account that owns the snapshot. </li>
        /// <li> <c>progress</c> - The progress of the snapshot, as a percentage (for example, 80%). </li> <li> <c>snapshot-id</c> - The snapshot ID.
        /// </li> <li> <c>start-time</c> - The time stamp when the snapshot was initiated. </li> <li> <c>status</c> - The status of the snapshot
        /// (<c>pending</c> | <c>completed</c> | <c>error</c>). </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag
        /// assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This filter is independent of the
        /// <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter "tag-value=X", you get any resources
        /// assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X (regardless of what the tag's key is). If you
        /// want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value
        /// of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter. </li> <li> <c>volume-id</c> - The ID of the
        /// volume the snapshot is for. </li> <li> <c>volume-size</c> - The size of the volume, in GiB. </li> </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
