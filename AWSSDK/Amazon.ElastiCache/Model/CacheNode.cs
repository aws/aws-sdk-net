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
    /// <para>Represents an individual cache node within a cache cluster. Each cache node runs its own instance of the cluster's protocol-compliant
    /// caching software - either Memcached or Redis.</para>
    /// </summary>
    public class CacheNode
    {
        
        private string cacheNodeId;
        private string cacheNodeStatus;
        private DateTime? cacheNodeCreateTime;
        private Endpoint endpoint;
        private string parameterGroupStatus;
        private string sourceCacheNodeId;

        /// <summary>
        /// The cache node identifier. A node ID is a numeric identifier (0001, 0002, etc.). The combination of cluster ID and node ID uniquely
        /// identifies every cache node used in a customer's AWS account.
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
        public CacheNode WithCacheNodeId(string cacheNodeId)
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
        /// The current state of this cache node.
        ///  
        /// </summary>
        public string CacheNodeStatus
        {
            get { return this.cacheNodeStatus; }
            set { this.cacheNodeStatus = value; }
        }

        /// <summary>
        /// Sets the CacheNodeStatus property
        /// </summary>
        /// <param name="cacheNodeStatus">The value to set for the CacheNodeStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNode WithCacheNodeStatus(string cacheNodeStatus)
        {
            this.cacheNodeStatus = cacheNodeStatus;
            return this;
        }
            

        // Check to see if CacheNodeStatus property is set
        internal bool IsSetCacheNodeStatus()
        {
            return this.cacheNodeStatus != null;
        }

        /// <summary>
        /// The date and time the cache node was created.
        ///  
        /// </summary>
        public DateTime CacheNodeCreateTime
        {
            get { return this.cacheNodeCreateTime ?? default(DateTime); }
            set { this.cacheNodeCreateTime = value; }
        }

        /// <summary>
        /// Sets the CacheNodeCreateTime property
        /// </summary>
        /// <param name="cacheNodeCreateTime">The value to set for the CacheNodeCreateTime property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNode WithCacheNodeCreateTime(DateTime cacheNodeCreateTime)
        {
            this.cacheNodeCreateTime = cacheNodeCreateTime;
            return this;
        }
            

        // Check to see if CacheNodeCreateTime property is set
        internal bool IsSetCacheNodeCreateTime()
        {
            return this.cacheNodeCreateTime.HasValue;
        }

        /// <summary>
        /// The hostname and IP address for connecting to this cache node.
        ///  
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this.endpoint; }
            set { this.endpoint = value; }
        }

        /// <summary>
        /// Sets the Endpoint property
        /// </summary>
        /// <param name="endpoint">The value to set for the Endpoint property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNode WithEndpoint(Endpoint endpoint)
        {
            this.endpoint = endpoint;
            return this;
        }
            

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this.endpoint != null;
        }

        /// <summary>
        /// The status of the parameter group applied to this cache node.
        ///  
        /// </summary>
        public string ParameterGroupStatus
        {
            get { return this.parameterGroupStatus; }
            set { this.parameterGroupStatus = value; }
        }

        /// <summary>
        /// Sets the ParameterGroupStatus property
        /// </summary>
        /// <param name="parameterGroupStatus">The value to set for the ParameterGroupStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNode WithParameterGroupStatus(string parameterGroupStatus)
        {
            this.parameterGroupStatus = parameterGroupStatus;
            return this;
        }
            

        // Check to see if ParameterGroupStatus property is set
        internal bool IsSetParameterGroupStatus()
        {
            return this.parameterGroupStatus != null;
        }

        /// <summary>
        /// The ID of the primary node to which this read replica node is synchronized. If this field is empty, then this node is not associated with a
        /// primary cache cluster.
        ///  
        /// </summary>
        public string SourceCacheNodeId
        {
            get { return this.sourceCacheNodeId; }
            set { this.sourceCacheNodeId = value; }
        }

        /// <summary>
        /// Sets the SourceCacheNodeId property
        /// </summary>
        /// <param name="sourceCacheNodeId">The value to set for the SourceCacheNodeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CacheNode WithSourceCacheNodeId(string sourceCacheNodeId)
        {
            this.sourceCacheNodeId = sourceCacheNodeId;
            return this;
        }
            

        // Check to see if SourceCacheNodeId property is set
        internal bool IsSetSourceCacheNodeId()
        {
            return this.sourceCacheNodeId != null;
        }
    }
}
