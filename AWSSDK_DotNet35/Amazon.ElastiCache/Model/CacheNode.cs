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
 * Do not modify this file. This file is generated from the elasticache-2014-07-15.normal.json service model.
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
    /// Represents an individual cache node within a cache cluster. Each cache node runs its
    /// own instance of the cluster's protocol-compliant caching software - either Memcached
    /// or Redis.
    /// </summary>
    public partial class CacheNode
    {
        private DateTime? _cacheNodeCreateTime;
        private string _cacheNodeId;
        private string _cacheNodeStatus;
        private string _customerAvailabilityZone;
        private Endpoint _endpoint;
        private string _parameterGroupStatus;
        private string _sourceCacheNodeId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CacheNode() { }

        /// <summary>
        /// Gets and sets the property CacheNodeCreateTime. 
        /// <para>
        /// The date and time when the cache node was created.
        /// </para>
        /// </summary>
        public DateTime CacheNodeCreateTime
        {
            get { return this._cacheNodeCreateTime.GetValueOrDefault(); }
            set { this._cacheNodeCreateTime = value; }
        }

        // Check to see if CacheNodeCreateTime property is set
        internal bool IsSetCacheNodeCreateTime()
        {
            return this._cacheNodeCreateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheNodeId. 
        /// <para>
        /// The cache node identifier. A node ID is a numeric identifier (0001, 0002, etc.). The
        /// combination of cluster ID and node ID uniquely identifies every cache node used in
        /// a customer's AWS account.
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
        /// Gets and sets the property CacheNodeStatus. 
        /// <para>
        /// The current state of this cache node.
        /// </para>
        /// </summary>
        public string CacheNodeStatus
        {
            get { return this._cacheNodeStatus; }
            set { this._cacheNodeStatus = value; }
        }

        // Check to see if CacheNodeStatus property is set
        internal bool IsSetCacheNodeStatus()
        {
            return this._cacheNodeStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerAvailabilityZone. 
        /// <para>
        /// The Availability Zone where this node was created and now resides.
        /// </para>
        /// </summary>
        public string CustomerAvailabilityZone
        {
            get { return this._customerAvailabilityZone; }
            set { this._customerAvailabilityZone = value; }
        }

        // Check to see if CustomerAvailabilityZone property is set
        internal bool IsSetCustomerAvailabilityZone()
        {
            return this._customerAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The hostname and IP address for connecting to this cache node.
        /// </para>
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupStatus. 
        /// <para>
        /// The status of the parameter group applied to this cache node.
        /// </para>
        /// </summary>
        public string ParameterGroupStatus
        {
            get { return this._parameterGroupStatus; }
            set { this._parameterGroupStatus = value; }
        }

        // Check to see if ParameterGroupStatus property is set
        internal bool IsSetParameterGroupStatus()
        {
            return this._parameterGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SourceCacheNodeId. 
        /// <para>
        /// The ID of the primary node to which this read replica node is synchronized. If this
        /// field is empty, then this node is not associated with a primary cache cluster.
        /// </para>
        /// </summary>
        public string SourceCacheNodeId
        {
            get { return this._sourceCacheNodeId; }
            set { this._sourceCacheNodeId = value; }
        }

        // Check to see if SourceCacheNodeId property is set
        internal bool IsSetSourceCacheNodeId()
        {
            return this._sourceCacheNodeId != null;
        }

    }
}