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
    /// Represents a single node within a node group (shard).
    /// </summary>
    public partial class NodeGroupMember
    {
        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The ID of the cluster to which the node belongs.
        /// </para>
        /// </summary>
        public string CacheClusterId { get; set; }

        /// <summary>
        /// Checks to see if the CacheClusterId property is set.
        /// </summary>
        internal bool IsSetCacheClusterId() => this.CacheClusterId != null;

        /// <summary>
        /// Gets and sets the property CacheNodeId. 
        /// <para>
        /// The ID of the node within its cluster. A node ID is a numeric identifier (0001, 0002,
        /// etc.).
        /// </para>
        /// </summary>
        public string CacheNodeId { get; set; }

        /// <summary>
        /// Checks to see if the CacheNodeId property is set.
        /// </summary>
        internal bool IsSetCacheNodeId() => this.CacheNodeId != null;

        /// <summary>
        /// Gets and sets the property CurrentRole. 
        /// <para>
        /// The role that is currently assigned to the node - <c>primary</c> or <c>replica</c>.
        /// This member is only applicable for Valkey or Redis OSS (cluster mode disabled) replication
        /// groups.
        /// </para>
        /// </summary>
        public string CurrentRole { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRole property is set.
        /// </summary>
        internal bool IsSetCurrentRole() => this.CurrentRole != null;

        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone in which the node is located.
        /// </para>
        /// </summary>
        public string PreferredAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the PreferredAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetPreferredAvailabilityZone() => this.PreferredAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property PreferredOutpostArn. 
        /// <para>
        /// The outpost ARN of the node group member.
        /// </para>
        /// </summary>
        public string PreferredOutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the PreferredOutpostArn property is set.
        /// </summary>
        internal bool IsSetPreferredOutpostArn() => this.PreferredOutpostArn != null;

        /// <summary>
        /// Gets and sets the property ReadEndpoint. 
        /// <para>
        /// The information required for client programs to connect to a node for read operations.
        /// The read endpoint is only applicable on Valkey or Redis OSS (cluster mode disabled)
        /// clusters.
        /// </para>
        /// </summary>
        public Endpoint ReadEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ReadEndpoint property is set.
        /// </summary>
        internal bool IsSetReadEndpoint() => this.ReadEndpoint != null;
    }
}
