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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Describes a reserved node. </para>
    /// </summary>
    public class ReservedNode
    {
        
        private string reservedNodeId;
        private string reservedNodeOfferingId;
        private string nodeType;
        private DateTime? startTime;
        private int? duration;
        private double? fixedPrice;
        private double? usagePrice;
        private string currencyCode;
        private int? nodeCount;
        private string state;
        private string offeringType;
        private List<RecurringCharge> recurringCharges = new List<RecurringCharge>();

        /// <summary>
        /// The unique identifier for the reservation.
        ///  
        /// </summary>
        public string ReservedNodeId
        {
            get { return this.reservedNodeId; }
            set { this.reservedNodeId = value; }
        }

        /// <summary>
        /// Sets the ReservedNodeId property
        /// </summary>
        /// <param name="reservedNodeId">The value to set for the ReservedNodeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithReservedNodeId(string reservedNodeId)
        {
            this.reservedNodeId = reservedNodeId;
            return this;
        }
            

        // Check to see if ReservedNodeId property is set
        internal bool IsSetReservedNodeId()
        {
            return this.reservedNodeId != null;
        }

        /// <summary>
        /// The identifier for the reserved node offering.
        ///  
        /// </summary>
        public string ReservedNodeOfferingId
        {
            get { return this.reservedNodeOfferingId; }
            set { this.reservedNodeOfferingId = value; }
        }

        /// <summary>
        /// Sets the ReservedNodeOfferingId property
        /// </summary>
        /// <param name="reservedNodeOfferingId">The value to set for the ReservedNodeOfferingId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithReservedNodeOfferingId(string reservedNodeOfferingId)
        {
            this.reservedNodeOfferingId = reservedNodeOfferingId;
            return this;
        }
            

        // Check to see if ReservedNodeOfferingId property is set
        internal bool IsSetReservedNodeOfferingId()
        {
            return this.reservedNodeOfferingId != null;
        }

        /// <summary>
        /// The node type of the reserved node.
        ///  
        /// </summary>
        public string NodeType
        {
            get { return this.nodeType; }
            set { this.nodeType = value; }
        }

        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithNodeType(string nodeType)
        {
            this.nodeType = nodeType;
            return this;
        }
            

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this.nodeType != null;
        }

        /// <summary>
        /// The time the reservation started. You purchase a reserved node offering for a duration. This is the start time of that duration.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithStartTime(DateTime startTime)
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
        /// The duration of the node reservation in seconds.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithDuration(int duration)
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
        /// The fixed cost Amazon Redshift charged you for this reserved node.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithFixedPrice(double fixedPrice)
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
        /// The hourly rate Amazon Redshift charge you for this reserved node.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithUsagePrice(double usagePrice)
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
        /// The currency code for the reserved cluster.
        ///  
        /// </summary>
        public string CurrencyCode
        {
            get { return this.currencyCode; }
            set { this.currencyCode = value; }
        }

        /// <summary>
        /// Sets the CurrencyCode property
        /// </summary>
        /// <param name="currencyCode">The value to set for the CurrencyCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithCurrencyCode(string currencyCode)
        {
            this.currencyCode = currencyCode;
            return this;
        }
            

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this.currencyCode != null;
        }

        /// <summary>
        /// The number of reserved compute nodes.
        ///  
        /// </summary>
        public int NodeCount
        {
            get { return this.nodeCount ?? default(int); }
            set { this.nodeCount = value; }
        }

        /// <summary>
        /// Sets the NodeCount property
        /// </summary>
        /// <param name="nodeCount">The value to set for the NodeCount property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithNodeCount(int nodeCount)
        {
            this.nodeCount = nodeCount;
            return this;
        }
            

        // Check to see if NodeCount property is set
        internal bool IsSetNodeCount()
        {
            return this.nodeCount.HasValue;
        }

        /// <summary>
        /// The state of the reserved Compute Node. Possible Values: <ul> <li>pending-payment-This reserved node has recently been purchased, and the
        /// sale has been approved, but payment has not yet been confirmed.</li> <li>active-This reserved node is owned by the caller and is available
        /// for use.</li> <li>payment-failed-Payment failed for the purchase attempt.</li> </ul>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithState(string state)
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
        /// The anticipated utilization of the reserved node, as defined in the reserved node offering.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithOfferingType(string offeringType)
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
        /// The recurring charges for the reserved node.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithRecurringCharges(params RecurringCharge[] recurringCharges)
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNode WithRecurringCharges(IEnumerable<RecurringCharge> recurringCharges)
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
