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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a reserved node offering.
    /// </summary>
    public partial class ReservedNodeOffering
    {
        private string _currencyCode;
        private int? _duration;
        private double? _fixedPrice;
        private string _nodeType;
        private string _offeringType;
        private List<RecurringCharge> _recurringCharges = AWSConfigs.InitializeCollections ? new List<RecurringCharge>() : null;
        private string _reservedNodeOfferingId;
        private ReservedNodeOfferingType _reservedNodeOfferingType;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the compute nodes offering.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration, in seconds, for which the offering will reserve the node.
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
        /// The upfront fixed charge you will pay to purchase the specific reserved node offering.
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
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The node type offered by the reserved node offering.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// The anticipated utilization of the reserved node, as defined in the reserved node
        /// offering.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The charge to your account regardless of whether you are creating any clusters using
        /// the node offering. Recurring charges are only in effect for heavy-utilization reserved
        /// nodes.
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
        /// Gets and sets the property ReservedNodeOfferingId. 
        /// <para>
        /// The offering identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ReservedNodeOfferingId
        {
            get { return this._reservedNodeOfferingId; }
            set { this._reservedNodeOfferingId = value; }
        }

        // Check to see if ReservedNodeOfferingId property is set
        internal bool IsSetReservedNodeOfferingId()
        {
            return this._reservedNodeOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedNodeOfferingType.
        /// </summary>
        public ReservedNodeOfferingType ReservedNodeOfferingType
        {
            get { return this._reservedNodeOfferingType; }
            set { this._reservedNodeOfferingType = value; }
        }

        // Check to see if ReservedNodeOfferingType property is set
        internal bool IsSetReservedNodeOfferingType()
        {
            return this._reservedNodeOfferingType != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The rate you are charged for each hour the cluster that is using the offering is running.
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