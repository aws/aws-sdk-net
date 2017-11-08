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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCacheCluster operation.
    /// Deletes a previously provisioned cluster. <code>DeleteCacheCluster</code> deletes
    /// all associated cache nodes, node endpoints and the cluster itself. When you receive
    /// a successful response from this operation, Amazon ElastiCache immediately begins deleting
    /// the cluster; you cannot cancel or revert this operation.
    /// 
    ///  
    /// <para>
    /// This operation cannot be used to delete a cluster that is the last read replica of
    /// a replication group or node group (shard) that has Multi-AZ mode enabled or a cluster
    /// from a Redis (cluster mode enabled) replication group.
    /// </para>
    ///  <important> 
    /// <para>
    /// Due to current limitations on Redis (cluster mode disabled), this operation or parameter
    /// is not supported on Redis (cluster mode enabled) replication groups.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteCacheClusterRequest : AmazonElastiCacheRequest
    {
        private string _cacheClusterId;
        private string _finalSnapshotIdentifier;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteCacheClusterRequest() { }

        /// <summary>
        /// Instantiates DeleteCacheClusterRequest with the parameterized properties
        /// </summary>
        /// <param name="cacheClusterId">The cluster identifier for the cluster to be deleted. This parameter is not case sensitive.</param>
        public DeleteCacheClusterRequest(string cacheClusterId)
        {
            _cacheClusterId = cacheClusterId;
        }

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The cluster identifier for the cluster to be deleted. This parameter is not case sensitive.
        /// </para>
        /// </summary>
        public string CacheClusterId
        {
            get { return this._cacheClusterId; }
            set { this._cacheClusterId = value; }
        }

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this._cacheClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property FinalSnapshotIdentifier. 
        /// <para>
        /// The user-supplied name of a final cluster snapshot. This is the unique name that identifies
        /// the snapshot. ElastiCache creates the snapshot, and then deletes the cluster immediately
        /// afterward.
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

    }
}