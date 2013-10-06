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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents a single node within a node group.</para>
    /// </summary>
    public class NodeGroupMember
    {
        
        private string cacheClusterId;
        private string cacheNodeId;
        private Endpoint readEndpoint;
        private string preferredAvailabilityZone;
        private string currentRole;

        /// <summary>
        /// The ID of the cache cluster to which the node belongs.
        ///  
        /// </summary>
        public string CacheClusterId
        {
            get { return this.cacheClusterId; }
            set { this.cacheClusterId = value; }
        }

        /// <summary>
        /// Sets the CacheClusterId property
        /// </summary>
        /// <param name="cacheClusterId">The value to set for the CacheClusterId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NodeGroupMember WithCacheClusterId(string cacheClusterId)
        {
            this.cacheClusterId = cacheClusterId;
            return this;
        }
            

        // Check to see if CacheClusterId property is set
        internal bool IsSetCacheClusterId()
        {
            return this.cacheClusterId != null;
        }

        /// <summary>
        /// The ID of the node within its cache cluster. A node ID is a numeric identifier (0001, 0002, etc.).
        ///  
        /// </summary>
        public string CacheNodeId
        {
            get { return this.cacheNodeId; }
            set { this.cacheNodeId = value; }
        }

        /// <summary>
        /// Sets the CacheNodeId property
        /// </summary>
        /// <param name="cacheNodeId">The value to set for the CacheNodeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NodeGroupMember WithCacheNodeId(string cacheNodeId)
        {
            this.cacheNodeId = cacheNodeId;
            return this;
        }
            

        // Check to see if CacheNodeId property is set
        internal bool IsSetCacheNodeId()
        {
            return this.cacheNodeId != null;
        }

        /// <summary>
        /// Represents the information required for client programs to connect to a cache node.
        ///  
        /// </summary>
        public Endpoint ReadEndpoint
        {
            get { return this.readEndpoint; }
            set { this.readEndpoint = value; }
        }

        /// <summary>
        /// Sets the ReadEndpoint property
        /// </summary>
        /// <param name="readEndpoint">The value to set for the ReadEndpoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NodeGroupMember WithReadEndpoint(Endpoint readEndpoint)
        {
            this.readEndpoint = readEndpoint;
            return this;
        }
            

        // Check to see if ReadEndpoint property is set
        internal bool IsSetReadEndpoint()
        {
            return this.readEndpoint != null;
        }

        /// <summary>
        /// The name of the Availability Zone in which the node is located.
        ///  
        /// </summary>
        public string PreferredAvailabilityZone
        {
            get { return this.preferredAvailabilityZone; }
            set { this.preferredAvailabilityZone = value; }
        }

        /// <summary>
        /// Sets the PreferredAvailabilityZone property
        /// </summary>
        /// <param name="preferredAvailabilityZone">The value to set for the PreferredAvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NodeGroupMember WithPreferredAvailabilityZone(string preferredAvailabilityZone)
        {
            this.preferredAvailabilityZone = preferredAvailabilityZone;
            return this;
        }
            

        // Check to see if PreferredAvailabilityZone property is set
        internal bool IsSetPreferredAvailabilityZone()
        {
            return this.preferredAvailabilityZone != null;
        }

        /// <summary>
        /// The role that is currently assigned to the node - <i>primary</i> or <i>replica</i>.
        ///  
        /// </summary>
        public string CurrentRole
        {
            get { return this.currentRole; }
            set { this.currentRole = value; }
        }

        /// <summary>
        /// Sets the CurrentRole property
        /// </summary>
        /// <param name="currentRole">The value to set for the CurrentRole property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public NodeGroupMember WithCurrentRole(string currentRole)
        {
            this.currentRole = currentRole;
            return this;
        }
            

        // Check to see if CurrentRole property is set
        internal bool IsSetCurrentRole()
        {
            return this.currentRole != null;
        }
    }
}
