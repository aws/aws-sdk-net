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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Details of an OpenSearch Reserved Instance offering.
    /// </summary>
    public partial class ReservedInstanceOffering
    {
        private string _currencyCode;
        private int? _duration;
        private double? _fixedPrice;
        private OpenSearchPartitionInstanceType _instanceType;
        private ReservedInstancePaymentOption _paymentOption;
        private List<RecurringCharge> _recurringCharges = AWSConfigs.InitializeCollections ? new List<RecurringCharge>() : null;
        private string _reservedInstanceOfferingId;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the Reserved Instance offering.
        /// </para>
        /// </summary>
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
        /// The duration, in seconds, for which the offering will reserve the OpenSearch instance.
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
        /// The upfront fixed charge you will pay to purchase the specific Reserved Instance offering.
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
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The OpenSearch instance type offered by the Reserved Instance offering.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// Payment option for the Reserved Instance offering
        /// </para>
        /// </summary>
        public ReservedInstancePaymentOption PaymentOption
        {
            get { return this._paymentOption; }
            set { this._paymentOption = value; }
        }

        // Check to see if PaymentOption property is set
        internal bool IsSetPaymentOption()
        {
            return this._paymentOption != null;
        }

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring charge to your account, regardless of whether you creates any domains
        /// using the offering.
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
        /// Gets and sets the property ReservedInstanceOfferingId. 
        /// <para>
        /// The unique identifier of the Reserved Instance offering.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ReservedInstanceOfferingId
        {
            get { return this._reservedInstanceOfferingId; }
            set { this._reservedInstanceOfferingId = value; }
        }

        // Check to see if ReservedInstanceOfferingId property is set
        internal bool IsSetReservedInstanceOfferingId()
        {
            return this._reservedInstanceOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The hourly rate at which you're charged for the domain using this Reserved Instance.
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