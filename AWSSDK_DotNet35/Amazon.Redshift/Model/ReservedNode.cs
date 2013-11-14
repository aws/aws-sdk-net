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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Describes a reserved node. </para>
    /// </summary>
    public partial class ReservedNode : AmazonWebServiceResponse
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

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this.recurringCharges.Count > 0;
        }
    }
}
