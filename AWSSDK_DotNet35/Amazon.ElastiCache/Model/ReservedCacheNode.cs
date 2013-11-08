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
using Amazon.Runtime;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents the output of a <i>PurchaseReservedCacheNodesOffering</i> operation.</para>
    /// </summary>
    public partial class ReservedCacheNode : AmazonWebServiceResponse
    {
        
        private string reservedCacheNodeId;
        private string reservedCacheNodesOfferingId;
        private string cacheNodeType;
        private DateTime? startTime;
        private int? duration;
        private double? fixedPrice;
        private double? usagePrice;
        private int? cacheNodeCount;
        private string productDescription;
        private string offeringType;
        private string state;
        private List<RecurringCharge> recurringCharges = new List<RecurringCharge>();


        /// <summary>
        /// The unique identifier for the reservation.
        ///  
        /// </summary>
        public string ReservedCacheNodeId
        {
            get { return this.reservedCacheNodeId; }
            set { this.reservedCacheNodeId = value; }
        }

        // Check to see if ReservedCacheNodeId property is set
        internal bool IsSetReservedCacheNodeId()
        {
            return this.reservedCacheNodeId != null;
        }

        /// <summary>
        /// The offering identifier.
        ///  
        /// </summary>
        public string ReservedCacheNodesOfferingId
        {
            get { return this.reservedCacheNodesOfferingId; }
            set { this.reservedCacheNodesOfferingId = value; }
        }

        // Check to see if ReservedCacheNodesOfferingId property is set
        internal bool IsSetReservedCacheNodesOfferingId()
        {
            return this.reservedCacheNodesOfferingId != null;
        }

        /// <summary>
        /// The cache node type for the reserved cache nodes.
        ///  
        /// </summary>
        public string CacheNodeType
        {
            get { return this.cacheNodeType; }
            set { this.cacheNodeType = value; }
        }

        // Check to see if CacheNodeType property is set
        internal bool IsSetCacheNodeType()
        {
            return this.cacheNodeType != null;
        }

        /// <summary>
        /// The time the reservation started.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// The duration of the reservation in seconds.
        ///  
        /// </summary>
        public int Duration
        {
            get { return this.duration ?? default(int); }
            set { this.duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration.HasValue;
        }

        /// <summary>
        /// The fixed price charged for this reserved cache node.
        ///  
        /// </summary>
        public double FixedPrice
        {
            get { return this.fixedPrice ?? default(double); }
            set { this.fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this.fixedPrice.HasValue;
        }

        /// <summary>
        /// The hourly price charged for this reserved cache node.
        ///  
        /// </summary>
        public double UsagePrice
        {
            get { return this.usagePrice ?? default(double); }
            set { this.usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this.usagePrice.HasValue;
        }

        /// <summary>
        /// The number of cache nodes that have been reserved.
        ///  
        /// </summary>
        public int CacheNodeCount
        {
            get { return this.cacheNodeCount ?? default(int); }
            set { this.cacheNodeCount = value; }
        }

        // Check to see if CacheNodeCount property is set
        internal bool IsSetCacheNodeCount()
        {
            return this.cacheNodeCount.HasValue;
        }

        /// <summary>
        /// The description of the reserved cache node.
        ///  
        /// </summary>
        public string ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;
        }

        /// <summary>
        /// The offering type of this reserved cache node.
        ///  
        /// </summary>
        public string OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }

        /// <summary>
        /// The state of the reserved cache node.
        ///  
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The recurring price charged to run this reserved cache node.
        ///  
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this.recurringCharges; }
            set { this.recurringCharges = value; }
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this.recurringCharges.Count > 0;
        }
    }
}
