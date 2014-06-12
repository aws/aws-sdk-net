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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private List<RecurringCharge> _recurringCharges = new List<RecurringCharge>();
        private string _reservedNodeOfferingId;
        private double? _usagePrice;


        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///             The currency code for the compute nodes offering.        
        /// </para>
        /// </summary>
        public string CurrencyCode
        {
            get { return this._currencyCode; }
            set { this._currencyCode = value; }
        }


        /// <summary>
        /// Sets the CurrencyCode property
        /// </summary>
        /// <param name="currencyCode">The value to set for the CurrencyCode property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithCurrencyCode(string currencyCode)
        {
            this._currencyCode = currencyCode;
            return this;
        }

        // Check to see if CurrencyCode property is set
        internal bool IsSetCurrencyCode()
        {
            return this._currencyCode != null;
        }


        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///     The duration, in seconds, for which the offering will reserve the node.    
        /// </para>
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }


        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithDuration(int duration)
        {
            this._duration = duration;
            return this;
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        ///     The upfront fixed charge you will pay to purchase the specific reserved node offering.
        ///    
        /// </para>
        /// </summary>
        public double FixedPrice
        {
            get { return this._fixedPrice.GetValueOrDefault(); }
            set { this._fixedPrice = value; }
        }


        /// <summary>
        /// Sets the FixedPrice property
        /// </summary>
        /// <param name="fixedPrice">The value to set for the FixedPrice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithFixedPrice(double fixedPrice)
        {
            this._fixedPrice = fixedPrice;
            return this;
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this._fixedPrice.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        ///     The node type offered by the reserved node offering.    
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }


        /// <summary>
        /// Sets the NodeType property
        /// </summary>
        /// <param name="nodeType">The value to set for the NodeType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithNodeType(string nodeType)
        {
            this._nodeType = nodeType;
            return this;
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
        public string OfferingType
        {
            get { return this._offeringType; }
            set { this._offeringType = value; }
        }


        /// <summary>
        /// Sets the OfferingType property
        /// </summary>
        /// <param name="offeringType">The value to set for the OfferingType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithOfferingType(string offeringType)
        {
            this._offeringType = offeringType;
            return this;
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
        /// the node offering.            Recurring charges are only in effect for heavy-utilization
        /// reserved nodes.        
        /// </para>
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this._recurringCharges; }
            set { this._recurringCharges = value; }
        }

        /// <summary>
        /// Sets the RecurringCharges property
        /// </summary>
        /// <param name="recurringCharges">The values to add to the RecurringCharges collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithRecurringCharges(params RecurringCharge[] recurringCharges)
        {
            foreach (var element in recurringCharges)
            {
                this._recurringCharges.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the RecurringCharges property
        /// </summary>
        /// <param name="recurringCharges">The values to add to the RecurringCharges collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithRecurringCharges(IEnumerable<RecurringCharge> recurringCharges)
        {
            foreach (var element in recurringCharges)
            {
                this._recurringCharges.Add(element);
            }
            return this;
        }
        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this._recurringCharges != null && this._recurringCharges.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ReservedNodeOfferingId. 
        /// <para>
        ///     The offering identifier.    
        /// </para>
        /// </summary>
        public string ReservedNodeOfferingId
        {
            get { return this._reservedNodeOfferingId; }
            set { this._reservedNodeOfferingId = value; }
        }


        /// <summary>
        /// Sets the ReservedNodeOfferingId property
        /// </summary>
        /// <param name="reservedNodeOfferingId">The value to set for the ReservedNodeOfferingId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithReservedNodeOfferingId(string reservedNodeOfferingId)
        {
            this._reservedNodeOfferingId = reservedNodeOfferingId;
            return this;
        }

        // Check to see if ReservedNodeOfferingId property is set
        internal bool IsSetReservedNodeOfferingId()
        {
            return this._reservedNodeOfferingId != null;
        }


        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        ///     The rate you are charged for each hour the cluster that is using the offering
        /// is running.    
        /// </para>
        /// </summary>
        public double UsagePrice
        {
            get { return this._usagePrice.GetValueOrDefault(); }
            set { this._usagePrice = value; }
        }


        /// <summary>
        /// Sets the UsagePrice property
        /// </summary>
        /// <param name="usagePrice">The value to set for the UsagePrice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ReservedNodeOffering WithUsagePrice(double usagePrice)
        {
            this._usagePrice = usagePrice;
            return this;
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this._usagePrice.HasValue; 
        }

    }
}