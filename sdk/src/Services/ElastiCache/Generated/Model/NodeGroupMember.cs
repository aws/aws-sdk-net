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
    /// Represents a single node within a node group (shard).
    /// </summary>
    public partial class NodeGroupMember
    {
        private string _cacheClusterId;
        private string _cacheNodeId;
        private string _currentRole;
        private string _preferredAvailabilityZone;
        private string _preferredOutpostArn;
        private Endpoint _readEndpoint;

        /// <summary>
        /// Gets and sets the property CacheClusterId. 
        /// <para>
        /// The ID of the cluster to which the node belongs.
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
        /// Gets and sets the property CacheNodeId. 
        /// <para>
        /// The ID of the node within its cluster. A node ID is a numeric identifier (0001, 0002,
        /// etc.).
        /// </para>
        /// </summary>
        public string CacheNodeId
        {
            get { return this._cacheNodeId; }
            set { this._cacheNodeId = value; }
        }

        // Check to see if CacheNodeId property is set
        internal bool IsSetCacheNodeId()
        {
            return this._cacheNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentRole. 
        /// <para>
        /// The role that is currently assigned to the node - <c>primary</c> or <c>replica</c>.
        /// This member is only applicable for Valkey or Redis OSS (cluster mode disabled) replication
        /// groups.
        /// </para>
        /// </summary>
        public string CurrentRole
        {
            get { return this._currentRole; }
            set { this._currentRole = value; }
        }

        // Check to see if CurrentRole property is set
        internal bool IsSetCurrentRole()
        {
            return this._currentRole != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredAvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone in which the node is located.
        /// </para>
        /// </summary>
        public string PreferredAvailabilityZone
        {
            get { return this._preferredAvailabilityZone; }
            set { this._preferredAvailabilityZone = value; }
        }

        // Check to see if PreferredAvailabilityZone property is set
        internal bool IsSetPreferredAvailabilityZone()
        {
            return this._preferredAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredOutpostArn. 
        /// <para>
        /// The outpost ARN of the node group member.
        /// </para>
        /// </summary>
        public string PreferredOutpostArn
        {
            get { return this._preferredOutpostArn; }
            set { this._preferredOutpostArn = value; }
        }

        // Check to see if PreferredOutpostArn property is set
        internal bool IsSetPreferredOutpostArn()
        {
            return this._preferredOutpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReadEndpoint. 
        /// <para>
        /// The information required for client programs to connect to a node for read operations.
        /// The read endpoint is only applicable on Valkey or Redis OSS (cluster mode disabled)
        /// clusters.
        /// </para>
        /// </summary>
        public Endpoint ReadEndpoint
        {
            get { return this._readEndpoint; }
            set { this._readEndpoint = value; }
        }

        // Check to see if ReadEndpoint property is set
        internal bool IsSetReadEndpoint()
        {
            return this._readEndpoint != null;
        }

    }
}