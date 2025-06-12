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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Details about the Dedicated Host Reservation and associated Dedicated Hosts.
    /// </summary>
    public partial class HostReservation
    {
        private int? _count;
        private CurrencyCodeValues _currencyCode;
        private int? _duration;
        private DateTime? _end;
        private List<string> _hostIdSet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _hostReservationId;
        private string _hourlyPrice;
        private string _instanceFamily;
        private string _offeringId;
        private PaymentOption _paymentOption;
        private DateTime? _start;
        private ReservationState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _upfrontPrice;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of Dedicated Hosts the reservation is associated with.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency in which the <c>upfrontPrice</c> and <c>hourlyPrice</c> amounts are specified.
        /// At this time, the only supported currency is <c>USD</c>.
        /// </para>
        /// </summary>
        public CurrencyCodeValues CurrencyCode
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
        /// The length of the reservation's term, specified in seconds. Can be <c>31536000 (1
        /// year)</c> | <c>94608000 (3 years)</c>.
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
        /// Gets and sets the property End. 
        /// <para>
        /// The date and time that the reservation ends.
        /// </para>
        /// </summary>
        public DateTime? End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostIdSet. 
        /// <para>
        /// The IDs of the Dedicated Hosts associated with the reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HostIdSet
        {
            get { return this._hostIdSet; }
            set { this._hostIdSet = value; }
        }

        // Check to see if HostIdSet property is set
        internal bool IsSetHostIdSet()
        {
            return this._hostIdSet != null && (this._hostIdSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HostReservationId. 
        /// <para>
        /// The ID of the reservation that specifies the associated Dedicated Hosts.
        /// </para>
        /// </summary>
        public string HostReservationId
        {
            get { return this._hostReservationId; }
            set { this._hostReservationId = value; }
        }

        // Check to see if HostReservationId property is set
        internal bool IsSetHostReservationId()
        {
            return this._hostReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property HourlyPrice. 
        /// <para>
        /// The hourly price of the reservation.
        /// </para>
        /// </summary>
        public string HourlyPrice
        {
            get { return this._hourlyPrice; }
            set { this._hourlyPrice = value; }
        }

        // Check to see if HourlyPrice property is set
        internal bool IsSetHourlyPrice()
        {
            return this._hourlyPrice != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceFamily. 
        /// <para>
        /// The instance family of the Dedicated Host Reservation. The instance family on the
        /// Dedicated Host must be the same in order for it to benefit from the reservation.
        /// </para>
        /// </summary>
        public string InstanceFamily
        {
            get { return this._instanceFamily; }
            set { this._instanceFamily = value; }
        }

        // Check to see if InstanceFamily property is set
        internal bool IsSetInstanceFamily()
        {
            return this._instanceFamily != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the reservation. This remains the same regardless of which Dedicated Hosts
        /// are associated with it.
        /// </para>
        /// </summary>
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentOption. 
        /// <para>
        /// The payment option selected for this reservation.
        /// </para>
        /// </summary>
        public PaymentOption PaymentOption
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
        /// Gets and sets the property Start. 
        /// <para>
        /// The date and time that the reservation started.
        /// </para>
        /// </summary>
        public DateTime? Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the reservation.
        /// </para>
        /// </summary>
        public ReservationState State
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the Dedicated Host Reservation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpfrontPrice. 
        /// <para>
        /// The upfront price of the reservation.
        /// </para>
        /// </summary>
        public string UpfrontPrice
        {
            get { return this._upfrontPrice; }
            set { this._upfrontPrice = value; }
        }

        // Check to see if UpfrontPrice property is set
        internal bool IsSetUpfrontPrice()
        {
            return this._upfrontPrice != null;
        }

    }
}