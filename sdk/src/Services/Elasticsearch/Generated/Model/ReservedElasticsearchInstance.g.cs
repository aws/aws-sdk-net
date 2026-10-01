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

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Details of a reserved Elasticsearch instance.
    /// </summary>
    public partial class ReservedElasticsearchInstance
    {
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the reserved Elasticsearch instance offering.
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
        /// The duration, in seconds, for which the Elasticsearch instance is reserved.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property ElasticsearchInstanceCount. 
        /// <para>
        /// The number of Elasticsearch instances that have been reserved.
        /// </para>
        /// </summary>
        public int? ElasticsearchInstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchInstanceCount property is set.
        /// </summary>
        internal bool IsSetElasticsearchInstanceCount() => this.ElasticsearchInstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property ElasticsearchInstanceType. 
        /// <para>
        /// The Elasticsearch instance type offered by the reserved instance offering.
        /// </para>
        /// </summary>
        public ESPartitionInstanceType ElasticsearchInstanceType { get; set; }

        /// <summary>
        /// Checks to see if the ElasticsearchInstanceType property is set.
        /// </summary>
        internal bool IsSetElasticsearchInstanceType() => this.ElasticsearchInstanceType != null;

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The upfront fixed charge you will paid to purchase the specific reserved Elasticsearch
        /// instance offering. 
        /// </para>
        /// </summary>
        public double? FixedPrice { get; set; }

        /// <summary>
        /// Checks to see if the FixedPrice property is set.
        /// </summary>
        internal bool IsSetFixedPrice() => this.FixedPrice.HasValue;

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option as defined in the reserved Elasticsearch instance offering.
        /// </para>
        /// </summary>
        public ReservedElasticsearchInstancePaymentOption PaymentOption { get; set; }

        /// <summary>
        /// Checks to see if the PaymentOption property is set.
        /// </summary>
        internal bool IsSetPaymentOption() => this.PaymentOption != null;

        /// <summary>
        /// Gets and sets the property RecurringCharges. 
        /// <para>
        /// The charge to your account regardless of whether you are creating any domains using
        /// the instance offering.
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
        /// Gets and sets the property ReservedElasticsearchInstanceId. 
        /// <para>
        /// The unique identifier for the reservation.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedElasticsearchInstanceId property is set.
        /// </summary>
        internal bool IsSetReservedElasticsearchInstanceId() => this.ReservedElasticsearchInstanceId != null;

        /// <summary>
        /// Gets and sets the property ReservedElasticsearchInstanceOfferingId. 
        /// <para>
        /// The offering identifier.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceOfferingId { get; set; }

        /// <summary>
        /// Checks to see if the ReservedElasticsearchInstanceOfferingId property is set.
        /// </summary>
        internal bool IsSetReservedElasticsearchInstanceOfferingId() => this.ReservedElasticsearchInstanceOfferingId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the reservation started.
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
        /// The state of the reserved Elasticsearch instance.
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
        /// The rate you are charged for each hour for the domain that is using this reserved
        /// instance.
        /// </para>
        /// </summary>
        public double? UsagePrice { get; set; }

        /// <summary>
        /// Checks to see if the UsagePrice property is set.
        /// </summary>
        internal bool IsSetUsagePrice() => this.UsagePrice.HasValue;
    }
}
