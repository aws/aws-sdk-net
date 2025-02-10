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
    /// Represents an individual cache node within a cluster. Each cache node runs its own
    /// instance of the cluster's protocol-compliant caching software - either Memcached,
    /// Valkey or Redis OSS.
    /// 
    ///  
    /// <para>
    /// The following node types are supported by ElastiCache. Generally speaking, the current
    /// generation types provide more memory and computational power at lower cost when compared
    /// to their equivalent previous generation counterparts.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// General purpose:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Current generation: 
    /// </para>
    ///  
    /// <para>
    ///  <b>M7g node types</b>: <c>cache.m7g.large</c>, <c>cache.m7g.xlarge</c>, <c>cache.m7g.2xlarge</c>,
    /// <c>cache.m7g.4xlarge</c>, <c>cache.m7g.8xlarge</c>, <c>cache.m7g.12xlarge</c>, <c>cache.m7g.16xlarge</c>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported
    /// Node Types</a> 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>M6g node types</b> (available only for Redis OSS engine version 5.0.6 onward and
    /// for Memcached engine version 1.5.16 onward): <c>cache.m6g.large</c>, <c>cache.m6g.xlarge</c>,
    /// <c>cache.m6g.2xlarge</c>, <c>cache.m6g.4xlarge</c>, <c>cache.m6g.8xlarge</c>, <c>cache.m6g.12xlarge</c>,
    /// <c>cache.m6g.16xlarge</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>M5 node types:</b> <c>cache.m5.large</c>, <c>cache.m5.xlarge</c>, <c>cache.m5.2xlarge</c>,
    /// <c>cache.m5.4xlarge</c>, <c>cache.m5.12xlarge</c>, <c>cache.m5.24xlarge</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>M4 node types:</b> <c>cache.m4.large</c>, <c>cache.m4.xlarge</c>, <c>cache.m4.2xlarge</c>,
    /// <c>cache.m4.4xlarge</c>, <c>cache.m4.10xlarge</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>T4g node types</b> (available only for Redis OSS engine version 5.0.6 onward and
    /// Memcached engine version 1.5.16 onward): <c>cache.t4g.micro</c>, <c>cache.t4g.small</c>,
    /// <c>cache.t4g.medium</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>T3 node types:</b> <c>cache.t3.micro</c>, <c>cache.t3.small</c>, <c>cache.t3.medium</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>T2 node types:</b> <c>cache.t2.micro</c>, <c>cache.t2.small</c>, <c>cache.t2.medium</c>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Previous generation: (not recommended. Existing clusters are still supported but creation
    /// of new clusters is not supported for these types.)
    /// </para>
    ///  
    /// <para>
    ///  <b>T1 node types:</b> <c>cache.t1.micro</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>M1 node types:</b> <c>cache.m1.small</c>, <c>cache.m1.medium</c>, <c>cache.m1.large</c>,
    /// <c>cache.m1.xlarge</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>M3 node types:</b> <c>cache.m3.medium</c>, <c>cache.m3.large</c>, <c>cache.m3.xlarge</c>,
    /// <c>cache.m3.2xlarge</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Compute optimized:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Previous generation: (not recommended. Existing clusters are still supported but creation
    /// of new clusters is not supported for these types.)
    /// </para>
    ///  
    /// <para>
    ///  <b>C1 node types:</b> <c>cache.c1.xlarge</c> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Memory optimized:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Current generation: 
    /// </para>
    ///  
    /// <para>
    ///  <b>R7g node types</b>: <c>cache.r7g.large</c>, <c>cache.r7g.xlarge</c>, <c>cache.r7g.2xlarge</c>,
    /// <c>cache.r7g.4xlarge</c>, <c>cache.r7g.8xlarge</c>, <c>cache.r7g.12xlarge</c>, <c>cache.r7g.16xlarge</c>
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// For region availability, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/CacheNodes.SupportedTypes.html#CacheNodes.SupportedTypesByRegion">Supported
    /// Node Types</a> 
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>R6g node types</b> (available only for Redis OSS engine version 5.0.6 onward and
    /// for Memcached engine version 1.5.16 onward): <c>cache.r6g.large</c>, <c>cache.r6g.xlarge</c>,
    /// <c>cache.r6g.2xlarge</c>, <c>cache.r6g.4xlarge</c>, <c>cache.r6g.8xlarge</c>, <c>cache.r6g.12xlarge</c>,
    /// <c>cache.r6g.16xlarge</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>R5 node types:</b> <c>cache.r5.large</c>, <c>cache.r5.xlarge</c>, <c>cache.r5.2xlarge</c>,
    /// <c>cache.r5.4xlarge</c>, <c>cache.r5.12xlarge</c>, <c>cache.r5.24xlarge</c> 
    /// </para>
    ///  
    /// <para>
    ///  <b>R4 node types:</b> <c>cache.r4.large</c>, <c>cache.r4.xlarge</c>, <c>cache.r4.2xlarge</c>,
    /// <c>cache.r4.4xlarge</c>, <c>cache.r4.8xlarge</c>, <c>cache.r4.16xlarge</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Previous generation: (not recommended. Existing clusters are still supported but creation
    /// of new clusters is not supported for these types.)
    /// </para>
    ///  
    /// <para>
    ///  <b>M2 node types:</b> <c>cache.m2.xlarge</c>, <c>cache.m2.2xlarge</c>, <c>cache.m2.4xlarge</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>R3 node types:</b> <c>cache.r3.large</c>, <c>cache.r3.xlarge</c>, <c>cache.r3.2xlarge</c>,
    /// <c>cache.r3.4xlarge</c>, <c>cache.r3.8xlarge</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>Additional node type info</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// All current generation instance types are created in Amazon VPC by default.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Valkey or Redis OSS append-only files (AOF) are not supported for T1 or T2 instances.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Valkey or Redis OSS Multi-AZ with automatic failover is not supported on T1 instances.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The configuration variables <c>appendonly</c> and <c>appendfsync</c> are not supported
    /// on Valkey, or on Redis OSS version 2.8.22 and later.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CacheNode
    {
        private DateTime? _cacheNodeCreateTime;
        private string _cacheNodeId;
        private string _cacheNodeStatus;
        private string _customerAvailabilityZone;
        private string _customerOutpostArn;
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
        public DateTime? CacheNodeCreateTime
        {
            get { return this._cacheNodeCreateTime; }
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
        /// a customer's Amazon account.
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
        /// The current state of this cache node, one of the following values: <c>available</c>,
        /// <c>creating</c>, <c>rebooting</c>, or <c>deleting</c>.
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
        /// Gets and sets the property CustomerOutpostArn. 
        /// <para>
        /// The customer outpost ARN of the cache node.
        /// </para>
        /// </summary>
        public string CustomerOutpostArn
        {
            get { return this._customerOutpostArn; }
            set { this._customerOutpostArn = value; }
        }

        // Check to see if CustomerOutpostArn property is set
        internal bool IsSetCustomerOutpostArn()
        {
            return this._customerOutpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The hostname for connecting to this cache node.
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
        /// field is empty, this node is not associated with a primary cluster.
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