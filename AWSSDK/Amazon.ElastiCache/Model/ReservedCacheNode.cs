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
    /// <para> This data type is used as a response element in the DescribeReservedCacheNodes and PurchaseReservedCacheNodesOffering actions.
    /// </para>
    /// </summary>
    public class ReservedCacheNode
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

        /// <summary>
        /// Sets the ReservedCacheNodeId property
        /// </summary>
        /// <param name="reservedCacheNodeId">The value to set for the ReservedCacheNodeId property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithReservedCacheNodeId(string reservedCacheNodeId)
        {
            this.reservedCacheNodeId = reservedCacheNodeId;
            return this;
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

        /// <summary>
        /// Sets the ReservedCacheNodesOfferingId property
        /// </summary>
        /// <param name="reservedCacheNodesOfferingId">The value to set for the ReservedCacheNodesOfferingId property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithReservedCacheNodesOfferingId(string reservedCacheNodesOfferingId)
        {
            this.reservedCacheNodesOfferingId = reservedCacheNodesOfferingId;
            return this;
        }
            

        // Check to see if ReservedCacheNodesOfferingId property is set
        internal bool IsSetReservedCacheNodesOfferingId()
        {
            return this.reservedCacheNodesOfferingId != null;
        }

        /// <summary>
        /// The cache node type for the reserved Cache Node.
        ///  
        /// </summary>
        public string CacheNodeType
        {
            get { return this.cacheNodeType; }
            set { this.cacheNodeType = value; }
        }

        /// <summary>
        /// Sets the CacheNodeType property
        /// </summary>
        /// <param name="cacheNodeType">The value to set for the CacheNodeType property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithCacheNodeType(string cacheNodeType)
        {
            this.cacheNodeType = cacheNodeType;
            return this;
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

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The value to set for the StartTime property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithStartTime(DateTime startTime)
        {
            this.startTime = startTime;
            return this;
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

        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithDuration(int duration)
        {
            this.duration = duration;
            return this;
        }
            

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration.HasValue;
        }

        /// <summary>
        /// The fixed price charged for this reserved Cache Node.
        ///  
        /// </summary>
        public double FixedPrice
        {
            get { return this.fixedPrice ?? default(double); }
            set { this.fixedPrice = value; }
        }

        /// <summary>
        /// Sets the FixedPrice property
        /// </summary>
        /// <param name="fixedPrice">The value to set for the FixedPrice property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithFixedPrice(double fixedPrice)
        {
            this.fixedPrice = fixedPrice;
            return this;
        }
            

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this.fixedPrice.HasValue;
        }

        /// <summary>
        /// The hourly price charged for this reserved Cache Node.
        ///  
        /// </summary>
        public double UsagePrice
        {
            get { return this.usagePrice ?? default(double); }
            set { this.usagePrice = value; }
        }

        /// <summary>
        /// Sets the UsagePrice property
        /// </summary>
        /// <param name="usagePrice">The value to set for the UsagePrice property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithUsagePrice(double usagePrice)
        {
            this.usagePrice = usagePrice;
            return this;
        }
            

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this.usagePrice.HasValue;
        }

        /// <summary>
        /// The number of reserved Cache Nodes.
        ///  
        /// </summary>
        public int CacheNodeCount
        {
            get { return this.cacheNodeCount ?? default(int); }
            set { this.cacheNodeCount = value; }
        }

        /// <summary>
        /// Sets the CacheNodeCount property
        /// </summary>
        /// <param name="cacheNodeCount">The value to set for the CacheNodeCount property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithCacheNodeCount(int cacheNodeCount)
        {
            this.cacheNodeCount = cacheNodeCount;
            return this;
        }
            

        // Check to see if CacheNodeCount property is set
        internal bool IsSetCacheNodeCount()
        {
            return this.cacheNodeCount.HasValue;
        }

        /// <summary>
        /// The description of the reserved Cache Node.
        ///  
        /// </summary>
        public string ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        /// <summary>
        /// Sets the ProductDescription property
        /// </summary>
        /// <param name="productDescription">The value to set for the ProductDescription property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithProductDescription(string productDescription)
        {
            this.productDescription = productDescription;
            return this;
        }
            

        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;
        }

        /// <summary>
        /// The offering type of this reserved Cache Node.
        ///  
        /// </summary>
        public string OfferingType
        {
            get { return this.offeringType; }
            set { this.offeringType = value; }
        }

        /// <summary>
        /// Sets the OfferingType property
        /// </summary>
        /// <param name="offeringType">The value to set for the OfferingType property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithOfferingType(string offeringType)
        {
            this.offeringType = offeringType;
            return this;
        }
            

        // Check to see if OfferingType property is set
        internal bool IsSetOfferingType()
        {
            return this.offeringType != null;
        }

        /// <summary>
        /// The state of the reserved Cache Node.
        ///  
        /// </summary>
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        /// <summary>
        /// Sets the State property
        /// </summary>
        /// <param name="state">The value to set for the State property </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithState(string state)
        {
            this.state = state;
            return this;
        }
            

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The recurring price charged to run this reserved Cache Node.
        ///  
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this.recurringCharges; }
            set { this.recurringCharges = value; }
        }
        /// <summary>
        /// Adds elements to the RecurringCharges collection
        /// </summary>
        /// <param name="recurringCharges">The values to add to the RecurringCharges collection </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithRecurringCharges(params RecurringCharge[] recurringCharges)
        {
            foreach (RecurringCharge element in recurringCharges)
            {
                this.recurringCharges.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the RecurringCharges collection
        /// </summary>
        /// <param name="recurringCharges">The values to add to the RecurringCharges collection </param>
        /// <returns>this instance</returns>
        public ReservedCacheNode WithRecurringCharges(IEnumerable<RecurringCharge> recurringCharges)
        {
            foreach (RecurringCharge element in recurringCharges)
            {
                this.recurringCharges.Add(element);
            }

            return this;
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this.recurringCharges.Count > 0;
        }
    }
}
