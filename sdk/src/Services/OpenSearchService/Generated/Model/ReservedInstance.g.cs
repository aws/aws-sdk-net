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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Details of an OpenSearch Reserved Instance.
    /// </summary>
    public partial class ReservedInstance
    {
        /// <summary>
        /// Gets and sets the property BillingSubscriptionId. 
        /// <para>
        /// The unique identifier of the billing subscription.
        /// </para>
        /// </summary>
        public long? BillingSubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the BillingSubscriptionId property is set.
        /// </summary>
        internal bool IsSetBillingSubscriptionId() => this.BillingSubscriptionId.HasValue;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the offering.
        /// </para>
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration, in seconds, for which the OpenSearch instance is reserved.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The upfront fixed charge you will paid to purchase the specific Reserved Instance
        /// offering.
        /// </para>
        /// </summary>
        public double? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of OpenSearch instances that have been reserved.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The OpenSearch instance type offered by theReserved Instance offering.
        /// </para>
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option as defined in the Reserved Instance offering.
        /// </para>
        /// </summary>
        public ReservedInstancePaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The recurring charge to your account, regardless of whether you create any domains
        /// using the Reserved Instance offering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecurringCharge> RecurringCharges { get; set; } = AWSConfigs.InitializeCollections ? new List<RecurringCharge>() : null;

        /// <summary>
        /// Checks to see if the RecurringCharges property is set.
        /// </summary>
        internal bool IsSetRecurringCharges() => this.RecurringCharges != null && (this.RecurringCharges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        /// The customer-specified identifier to track this reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 64)]
        public string ReservationName { get; set; }

        /// <summary>
        /// Checks to see if the ReservationName property is set.
        /// </summary>
        internal bool IsSetReservationName() => this.ReservationName != null;

        /// <summary>
        /// Gets and sets the property ReservedInstanceId. 
        /// <para>
        /// The unique identifier for the reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ReservedInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstanceId property is set.
        /// </summary>
        internal bool IsSetReservedInstanceId() => this.ReservedInstanceId != null;

        /// <summary>
        /// Gets and sets the property ReservedInstanceOfferingId. 
        /// <para>
        /// The unique identifier of the Reserved Instance offering.
        /// </para>
        /// </summary>
        public string ReservedInstanceOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedInstanceOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedInstanceOfferingId() => this.ReservedInstanceOfferingId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the reservation was purchased.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the Reserved Instance.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property UsagePrice. 
        /// <para>
        /// The hourly rate at which you're charged for the domain using this Reserved Instance.
        /// </para>
        /// </summary>
        public double? UsagePrice { get; set; }

        /// <summary>
        /// Checks to see if the UsagePrice property is set.
        /// </summary>
        internal bool IsSetUsagePrice() => this.UsagePrice.HasValue;
    }
}
