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
    /// Represents the output of a <c>PurchaseReservedCacheNodesOffering</c> operation.
    /// </summary>
    public partial class ReservedCacheNode
    {
        private int? _cacheNodeCount;
        private string _cacheNodeType;
        private int? _duration;
        private double? _fixedPrice;
        private string _offeringType;
        private string _productDescription;
        private List<RecurringCharge> _recurringCharges = AWSConfigs.InitializeCollections ? new List<RecurringCharge>() : null;
        private string _reservationARN;
        private string _reservedCacheNodeId;
        private string _reservedCacheNodesOfferingId;
        private DateTime? _startTime;
        private string _state;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property CacheNodeCount. 
        /// <para>
        /// The number of cache nodes that have been reserved.
        /// </para>
        /// </summary>
        public int? CacheNodeCount
        {
            get { return this._cacheNodeCount; }
            set { this._cacheNodeCount = value; }
        }

        // Check to see if CacheNodeCount property is set
        internal bool IsSetCacheNodeCount()
        {
            return this._cacheNodeCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CacheNodeType. 
        /// <para>
        /// The cache node type for the reserved cache nodes.
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
        /// The duration of the reservation in seconds.
        /// </para>
        /// </summary>
        public int? Duration
        {
            get { return this._duration; }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The fixed price charged for this reserved cache node.
        /// </para>
        /// </summary>
        public double? FixedPrice
        {
            get { return this._fixedPrice; }
            set { this._fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this._fixedPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The offering type of this reserved cache node.
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
        /// The description of the reserved cache node.
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
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring price charged to run this reserved cache node.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this._recurringCharges; }
            set { this._recurringCharges = value; }
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this._recurringCharges != null && (this._recurringCharges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReservationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the reserved cache node.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>arn:aws:elasticache:us-east-1:123456789012:reserved-instance:ri-2017-03-27-08-33-25-582</c>
        /// 
        /// </para>
        /// </summary>
        public string ReservationARN
        {
            get { return this._reservationARN; }
            set { this._reservationARN = value; }
        }

        // Check to see if ReservationARN property is set
        internal bool IsSetReservationARN()
        {
            return this._reservationARN != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedCacheNodeId. 
        /// <para>
        /// The unique identifier for the reservation.
        /// </para>
        /// </summary>
        public string ReservedCacheNodeId
        {
            get { return this._reservedCacheNodeId; }
            set { this._reservedCacheNodeId = value; }
        }

        // Check to see if ReservedCacheNodeId property is set
        internal bool IsSetReservedCacheNodeId()
        {
            return this._reservedCacheNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedCacheNodesOfferingId. 
        /// <para>
        /// The offering identifier.
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

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the reservation started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the reserved cache node.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The hourly price charged for this reserved cache node.
        /// </para>
        /// </summary>
        public double? UsagePrice
        {
            get { return this._usagePrice; }
            set { this._usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this._usagePrice.HasValue; 
        }

    }
}