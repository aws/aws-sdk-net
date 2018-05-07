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

/*
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Details of a reserved Elasticsearch instance.
    /// </summary>
    public partial class ReservedElasticsearchInstance
    {
        private string _currencyCode;
        private int? _duration;
        private int? _elasticsearchInstanceCount;
        private ESPartitionInstanceType _elasticsearchInstanceType;
        private double? _fixedPrice;
        private ReservedElasticsearchInstancePaymentOption _paymentOption;
        private List<RecurringCharge> _recurringCharges = new List<RecurringCharge>();
        private string _reservationName;
        private string _reservedElasticsearchInstanceId;
        private string _reservedElasticsearchInstanceOfferingId;
        private DateTime? _startTime;
        private string _state;
        private double? _usagePrice;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the reserved Elasticsearch instance offering.
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
        /// The duration, in seconds, for which the Elasticsearch instance is reserved.
        /// </para>
        /// </summary>
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchInstanceCount. 
        /// <para>
        /// The number of Elasticsearch instances that have been reserved.
        /// </para>
        /// </summary>
        public int ElasticsearchInstanceCount
        {
            get { return this._elasticsearchInstanceCount.GetValueOrDefault(); }
            set { this._elasticsearchInstanceCount = value; }
        }

        // Check to see if ElasticsearchInstanceCount property is set
        internal bool IsSetElasticsearchInstanceCount()
        {
            return this._elasticsearchInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElasticsearchInstanceType. 
        /// <para>
        /// The Elasticsearch instance type offered by the reserved instance offering.
        /// </para>
        /// </summary>
        public ESPartitionInstanceType ElasticsearchInstanceType
        {
            get { return this._elasticsearchInstanceType; }
            set { this._elasticsearchInstanceType = value; }
        }

        // Check to see if ElasticsearchInstanceType property is set
        internal bool IsSetElasticsearchInstanceType()
        {
            return this._elasticsearchInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property FixedPrice. 
        /// <para>
        /// The upfront fixed charge you will paid to purchase the specific reserved Elasticsearch
        /// instance offering. 
        /// </para>
        /// </summary>
        public double FixedPrice
        {
            get { return this._fixedPrice.GetValueOrDefault(); }
            set { this._fixedPrice = value; }
        }

        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this._fixedPrice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option as defined in the reserved Elasticsearch instance offering.
        /// </para>
        /// </summary>
        public ReservedElasticsearchInstancePaymentOption PaymentOption
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
        /// The charge to your account regardless of whether you are creating any domains using
        /// the instance offering.
        /// </para>
        /// </summary>
        public List<RecurringCharge> RecurringCharges
        {
            get { return this._recurringCharges; }
            set { this._recurringCharges = value; }
        }

        // Check to see if RecurringCharges property is set
        internal bool IsSetRecurringCharges()
        {
            return this._recurringCharges != null && this._recurringCharges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        /// The customer-specified identifier to track this reservation.
        /// </para>
        /// </summary>
        public string ReservationName
        {
            get { return this._reservationName; }
            set { this._reservationName = value; }
        }

        // Check to see if ReservationName property is set
        internal bool IsSetReservationName()
        {
            return this._reservationName != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedElasticsearchInstanceId. 
        /// <para>
        /// The unique identifier for the reservation.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceId
        {
            get { return this._reservedElasticsearchInstanceId; }
            set { this._reservedElasticsearchInstanceId = value; }
        }

        // Check to see if ReservedElasticsearchInstanceId property is set
        internal bool IsSetReservedElasticsearchInstanceId()
        {
            return this._reservedElasticsearchInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedElasticsearchInstanceOfferingId. 
        /// <para>
        /// The offering identifier.
        /// </para>
        /// </summary>
        public string ReservedElasticsearchInstanceOfferingId
        {
            get { return this._reservedElasticsearchInstanceOfferingId; }
            set { this._reservedElasticsearchInstanceOfferingId = value; }
        }

        // Check to see if ReservedElasticsearchInstanceOfferingId property is set
        internal bool IsSetReservedElasticsearchInstanceOfferingId()
        {
            return this._reservedElasticsearchInstanceOfferingId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the reservation started.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// The state of the reserved Elasticsearch instance.
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
        /// The rate you are charged for each hour for the domain that is using this reserved
        /// instance.
        /// </para>
        /// </summary>
        public double UsagePrice
        {
            get { return this._usagePrice.GetValueOrDefault(); }
            set { this._usagePrice = value; }
        }

        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this._usagePrice.HasValue; 
        }

    }
}