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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Container for the parameters to the ListAllowedNodeTypeModifications operation. Lists
    /// all available node types that you can scale with your cluster's replication group's
    /// current node type. <para> When you use the <c>ModifyCacheCluster</c> or <c>ModifyReplicationGroup</c>
    /// operations to scale your cluster or replication group, the value of the <c>CacheNodeType</c>
    /// parameter must be one of the node types returned by this operation. </para>
    /// </summary>
    public partial class ListAllowedNodeTypeModificationsRequest : AmazonElastiCacheRequest
    {
        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The name of the cluster you want to scale up to a larger node instanced type. ElastiCache
        /// uses the cluster id to identify the current node type of this cluster and from that
        /// to create a list of node types you can scale up to.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must provide a value for either the <c>CacheClusterId</c> or the <c>ReplicationGroupId</c>.
        /// </para>
        ///  </important>
        /// </summary>
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroupId. 
        /// <para>
        /// The name of the replication group want to scale up to a larger node type. ElastiCache
        /// uses the replication group id to identify the current node type being used by this
        /// replication group, and from that to create a list of node types you can scale up to.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must provide a value for either the <c>CacheClusterId</c> or the <c>ReplicationGroupId</c>.
        /// </para>
        ///  </important>
        /// </summary>
        public string ReplicationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the ReplicationGroupId property is set.
        /// </summary>
        internal bool IsSetReplicationGroupId() => this.ReplicationGroupId != null;
    }
}
