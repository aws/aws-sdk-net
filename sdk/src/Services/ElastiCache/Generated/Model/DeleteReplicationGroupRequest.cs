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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteReplicationGroup operation.
    /// Deletes an existing replication group. By default, this operation deletes the entire
    /// replication group, including the primary/primaries and all of the read replicas. If
    /// the replication group has only one primary, you can optionally delete only the read
    /// replicas, while retaining the primary by setting <c>RetainPrimaryCluster=true</c>.
    /// 
    ///  
    /// <para>
    /// When you receive a successful response from this operation, Amazon ElastiCache immediately
    /// begins deleting the selected resources; you cannot cancel or revert this operation.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    ///  <c>CreateSnapshot</c> permission is required to create a final snapshot. Without
    /// this permission, the API call will fail with an <c>Access Denied</c> exception.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// This operation is valid for Redis OSS only.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class DeleteReplicationGroupRequest : AmazonElastiCacheRequest
    {
        private string _finalSnapshotIdentifier;
        private string _replicationGroupId;
        private bool? _retainPrimaryCluster;

        /// <summary>
        /// Gets and sets the property FinalSnapshotIdentifier. 
        /// <para>
        /// The name of a final node group (shard) snapshot. ElastiCache creates the snapshot
        /// from the primary node in the cluster, rather than one of the replicas; this is to
        /// ensure that it captures the freshest data. After the final snapshot is taken, the
        /// replication group is immediately deleted.
        /// </para>
        /// </summary>
        public string FinalSnapshotIdentifier
        {
            get { return this._finalSnapshotIdentifier; }
            set { this._finalSnapshotIdentifier = value; }
        }

        // Check to see if FinalSnapshotIdentifier property is set
        internal bool IsSetFinalSnapshotIdentifier()
        {
            return this._finalSnapshotIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The identifier for the cluster to be deleted. This parameter is not case sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationGroupId
        {
            get { return this._replicationGroupId; }
            set { this._replicationGroupId = value; }
        }

        // Check to see if ReplicationGroupId property is set
        internal bool IsSetReplicationGroupId()
        {
            return this._replicationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property RetainPrimaryCluster. 
        /// <para>
        /// If set to <c>true</c>, all of the read replicas are deleted, but the primary node
        /// is retained.
        /// </para>
        /// </summary>
        public bool? RetainPrimaryCluster
        {
            get { return this._retainPrimaryCluster; }
            set { this._retainPrimaryCluster = value; }
        }

        // Check to see if RetainPrimaryCluster property is set
        internal bool IsSetRetainPrimaryCluster()
        {
            return this._retainPrimaryCluster.HasValue; 
        }

    }
}