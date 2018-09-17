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
    /// Container for the parameters to the DescribeReservedCacheNodesOfferings operation.
    /// Lists available reserved cache node offerings.
    /// </summary>
    public partial class DescribeReservedCacheNodesOfferingsRequest : AmazonElastiCacheRequest
    {
        private string _cacheNodeType;
        private string _duration;
        private string _marker;
        private int? _maxRecords;
        private string _offeringType;
        private string _productDescription;
        private string _reservedCacheNodesOfferingId;

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The cache node type filter value. Use this parameter to show only the available offerings
        /// matching the specified cache node type.
        /// </para>
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
        ///  <b>T2 node types:</b> <code>cache.t2.micro</code>, <code>cache.t2.small</code>, <code>cache.t2.medium</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>M3 node types:</b> <code>cache.m3.medium</code>, <code>cache.m3.large</code>,
        /// <code>cache.m3.xlarge</code>, <code>cache.m3.2xlarge</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M4 node types:</b> <code>cache.m4.large</code>, <code>cache.m4.xlarge</code>,
        /// <code>cache.m4.2xlarge</code>, <code>cache.m4.4xlarge</code>, <code>cache.m4.10xlarge</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: (not recommended)
        /// </para>
        ///  
        /// <para>
        ///  <b>T1 node types:</b> <code>cache.t1.micro</code> 
        /// </para>
        ///  
        /// <para>
        ///  <b>M1 node types:</b> <code>cache.m1.small</code>, <code>cache.m1.medium</code>,
        /// <code>cache.m1.large</code>, <code>cache.m1.xlarge</code> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Compute optimized:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Previous generation: (not recommended)
        /// </para>
        ///  
        /// <para>
        ///  <b>C1 node types:</b> <code>cache.c1.xlarge</code> 
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
        ///  <b>R3 node types:</b> <code>cache.r3.large</code>, <code>cache.r3.xlarge</code>,
        /// <code>cache.r3.2xlarge</code>, <code>cache.r3.4xlarge</code>, <code>cache.r3.8xlarge</code>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>R4 node types;</b> <code>cache.r4.large</code>, <code>cache.r4.xlarge</code>,
        /// <code>cache.r4.2xlarge</code>, <code>cache.r4.4xlarge</code>, <code>cache.r4.8xlarge</code>,
        /// <code>cache.r4.16xlarge</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Previous generation: (not recommended)
        /// </para>
        ///  
        /// <para>
        ///  <b>M2 node types:</b> <code>cache.m2.xlarge</code>, <code>cache.m2.2xlarge</code>,
        /// <code>cache.m2.4xlarge</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        ///  <b>Notes:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// All T2 instances are created in an Amazon Virtual Private Cloud (Amazon VPC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis (cluster mode disabled): Redis backup/restore is not supported on T1 and T2
        /// instances. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis (cluster mode enabled): Backup/restore is not supported on T1 instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Redis Append-only files (AOF) functionality is not supported for T1 or T2 instances.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a complete listing of node types and specifications, see:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://aws.amazon.com/elasticache/details">Amazon ElastiCache Product Features
        /// and Details</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/mem-ug/ParameterGroups.Memcached.html#ParameterGroups.Memcached.NodeSpecific">Cache
        /// Node Type-Specific Parameters for Memcached</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/AmazonElastiCache/latest/red-ug/ParameterGroups.Redis.html#ParameterGroups.Redis.NodeSpecific">Cache
        /// Node Type-Specific Parameters for Redis</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string CacheNodeType
        {
            get { return this._cacheNodeType; }
            set { this._cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this._cacheNodeType != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// Duration filter value, specified in years or seconds. Use this parameter to show only
        /// reservations for a given duration.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>1 | 3 | 31536000 | 94608000</code> 
        /// </para>
        /// </summary>
        public string Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional marker returned from a prior request. Use this marker for pagination of
        /// results from this operation. If this parameter is specified, the response includes
        /// only records beyond the marker, up to the value specified by <code>MaxRecords</code>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxRecords. 
        /// <para>
        /// The maximum number of records to include in the response. If more records exist than
        /// the specified <code>MaxRecords</code> value, a marker is included in the response
        /// so that the remaining results can be retrieved.
        /// </para>
        ///  
        /// <para>
        /// Default: 100
        /// </para>
        ///  
        /// <para>
        /// Constraints: minimum 20; maximum 100.
        /// </para>
        /// </summary>
        public int MaxRecords
        {
            get { return this._maxRecords.GetValueOrDefault(); }
            set { this._maxRecords = value; }
        }

        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this._maxRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type filter value. Use this parameter to show only the available offerings
        /// matching the specified offering type.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>"Light Utilization"|"Medium Utilization"|"Heavy Utilization"</code>
        /// 
        /// </para>
        /// </summary>
        public string OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this._offeringType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductDescription. 
        /// <para>
        /// The product description filter value. Use this parameter to show only the available
        /// offerings matching the specified product description.
        /// </para>
        /// </summary>
        public string ProductDescription
        {
            get { return this._productDescription; }
            set { this._productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this._productDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedCacheNodesOfferingId. 
        /// <para>
        /// The offering identifier filter value. Use this parameter to show only the available
        /// offering that matches the specified reservation identifier.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>438012d3-4052-4cc7-b2e3-8d3372e0e706</code> 
        /// </para>
        /// </summary>
        public string ReservedCacheNodesOfferingId
        {
            get { return this._reservedCacheNodesOfferingId; }
            set { this._reservedCacheNodesOfferingId = value; }
        }

        // Check to see if ReservedCacheNodesOfferingId property is set
        internal bool IsSetReservedCacheNodesOfferingId()
        {
            return this._reservedCacheNodesOfferingId != null;
        }

    }
}