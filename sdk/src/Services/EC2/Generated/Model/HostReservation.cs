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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HostReservation
    {
        private int? _count;
        private CurrencyCodeValues _currencyCode;
        private int? _duration;
        private DateTime? _end;
        private List<string> _hostIdSet = new List<string>();
        private string _hostReservationId;
        private string _hourlyPrice;
        private string _instanceFamily;
        private string _offeringId;
        private PaymentOption _paymentOption;
        private DateTime? _start;
        private ReservationState _state;
        private string _upfrontPrice;

        /// <summary>
        /// Gets and sets the property Count.
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrencyCode.
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
        /// Gets and sets the property End.
        /// </summary>
        public DateTime End
        {
            get { return this._end.GetValueOrDefault(); }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostIdSet.
        /// </summary>
        public List<string> HostIdSet
        {
            get { return this._hostIdSet; }
            set { this._hostIdSet = value; }
        }

        // Check to see if HostIdSet property is set
        internal bool IsSetHostIdSet()
        {
            return this._hostIdSet != null && this._hostIdSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HostReservationId.
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
        /// </summary>
        public DateTime Start
        {
            get { return this._start.GetValueOrDefault(); }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State.
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
        /// Gets and sets the property UpfrontPrice.
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