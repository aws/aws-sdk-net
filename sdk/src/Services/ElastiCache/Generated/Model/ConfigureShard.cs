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
    /// Node group (shard) configuration options when adding or removing replicas. Each node
    /// group (shard) configuration has the following members: NodeGroupId, NewReplicaCount,
    /// and PreferredAvailabilityZones.
    /// </summary>
    public partial class ConfigureShard
    {
        private int? _newReplicaCount;
        private string _nodeGroupId;
        private List<string> _preferredAvailabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _preferredOutpostArns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NewReplicaCount. 
        /// <para>
        /// The number of replicas you want in this node group at the end of this operation. The
        /// maximum value for <c>NewReplicaCount</c> is 5. The minimum value depends upon the
        /// type of Valkey or Redis OSS replication group you are working with.
        /// </para>
        ///  
        /// <para>
        /// The minimum number of replicas in a shard or replication group is:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valkey or Redis OSS (cluster mode disabled)
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If Multi-AZ: 1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If Multi-AZ: 0
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Valkey or Redis OSS (cluster mode enabled): 0 (though you will not be able to failover
        /// to a replica if your primary node fails)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? NewReplicaCount
        {
            get { return this._newReplicaCount; }
            set { this._newReplicaCount = value; }
        }

        // Check to see if NewReplicaCount property is set
        internal bool IsSetNewReplicaCount()
        {
            return this._newReplicaCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeGroupId. 
        /// <para>
        /// The 4-digit id for the node group you are configuring. For Valkey or Redis OSS (cluster
        /// mode disabled) replication groups, the node group id is always 0001. To find a Valkey
        /// or Redis OSS (cluster mode enabled)'s node group's (shard's) id, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/shard-find-id.html">Finding
        /// a Shard's Id</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public string NodeGroupId
        {
            get { return this._nodeGroupId; }
            set { this._nodeGroupId = value; }
        }

        // Check to see if NodeGroupId property is set
        internal bool IsSetNodeGroupId()
        {
            return this._nodeGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZones. 
        /// <para>
        /// A list of <c>PreferredAvailabilityZone</c> strings that specify which availability
        /// zones the replication group's nodes are to be in. The nummber of <c>PreferredAvailabilityZone</c>
        /// values must equal the value of <c>NewReplicaCount</c> plus 1 to account for the primary
        /// node. If this member of <c>ReplicaConfiguration</c> is omitted, ElastiCache selects
        /// the availability zone for each of the replicas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PreferredAvailabilityZones
        {
            get { return this._preferredAvailabilityZones; }
            set { this._preferredAvailabilityZones = value; }
        }

        // Check to see if PreferredAvailabilityZones property is set
        internal bool IsSetPreferredAvailabilityZones()
        {
            return this._preferredAvailabilityZones != null && (this._preferredAvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreferredOutpostArns. 
        /// <para>
        /// The outpost ARNs in which the cache cluster is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PreferredOutpostArns
        {
            get { return this._preferredOutpostArns; }
            set { this._preferredOutpostArns = value; }
        }

        // Check to see if PreferredOutpostArns property is set
        internal bool IsSetPreferredOutpostArns()
        {
            return this._preferredOutpostArns != null && (this._preferredOutpostArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}