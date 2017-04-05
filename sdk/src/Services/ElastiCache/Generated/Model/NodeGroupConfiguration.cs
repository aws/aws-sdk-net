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
    /// node group (shard) configuration options. Each node group (shard) configuration has
    /// the following: <code>Slots</code>, <code>PrimaryAvailabilityZone</code>, <code>ReplicaAvailabilityZones</code>,
    /// <code>ReplicaCount</code>.
    /// </summary>
    public partial class NodeGroupConfiguration
    {
        private string _primaryAvailabilityZone;
        private List<string> _replicaAvailabilityZones = new List<string>();
        private int? _replicaCount;
        private string _slots;

        /// <summary>
        /// Gets and sets the property PrimaryAvailabilityZone. 
        /// <para>
        /// The Availability Zone where the primary node of this node group (shard) is launched.
        /// </para>
        /// </summary>
        public string PrimaryAvailabilityZone
        {
            get { return this._primaryAvailabilityZone; }
            set { this._primaryAvailabilityZone = value; }
        }

        // Check to see if PrimaryAvailabilityZone property is set
        internal bool IsSetPrimaryAvailabilityZone()
        {
            return this._primaryAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicaAvailabilityZones. 
        /// <para>
        /// A list of Availability Zones to be used for the read replicas. The number of Availability
        /// Zones in this list must match the value of <code>ReplicaCount</code> or <code>ReplicasPerNodeGroup</code>
        /// if not specified.
        /// </para>
        /// </summary>
        public List<string> ReplicaAvailabilityZones
        {
            get { return this._replicaAvailabilityZones; }
            set { this._replicaAvailabilityZones = value; }
        }

        // Check to see if ReplicaAvailabilityZones property is set
        internal bool IsSetReplicaAvailabilityZones()
        {
            return this._replicaAvailabilityZones != null && this._replicaAvailabilityZones.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReplicaCount. 
        /// <para>
        /// The number of read replica nodes in this node group (shard).
        /// </para>
        /// </summary>
        public int ReplicaCount
        {
            get { return this._replicaCount.GetValueOrDefault(); }
            set { this._replicaCount = value; }
        }

        // Check to see if ReplicaCount property is set
        internal bool IsSetReplicaCount()
        {
            return this._replicaCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Slots. 
        /// <para>
        /// A string that specifies the keyspace for a particular node group. Keyspaces range
        /// from 0 to 16,383. The string is in the format <code>startkey-endkey</code>.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>"0-3999"</code> 
        /// </para>
        /// </summary>
        public string Slots
        {
            get { return this._slots; }
            set { this._slots = value; }
        }

        // Check to see if Slots property is set
        internal bool IsSetSlots()
        {
            return this._slots != null;
        }

    }
}