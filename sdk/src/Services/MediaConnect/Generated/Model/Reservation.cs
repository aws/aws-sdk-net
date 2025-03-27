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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A pricing agreement for a discounted rate for a specific outbound bandwidth that
    /// your MediaConnect account will use each month over a specific time period. The discounted
    /// rate in the reservation applies to outbound bandwidth for all flows from your account
    /// until your account reaches the amount of bandwidth in your reservation. If you use
    /// more outbound bandwidth than the agreed upon amount in a single month, the overage
    /// is charged at the on-demand rate.
    /// </summary>
    public partial class Reservation
    {
        private string _currencyCode;
        private int? _duration;
        private DurationUnits _durationUnits;
        private string _end;
        private string _offeringArn;
        private string _offeringDescription;
        private string _pricePerUnit;
        private PriceUnits _priceUnits;
        private string _reservationArn;
        private string _reservationName;
        private ReservationState _reservationState;
        private ResourceSpecification _resourceSpecification;
        private string _start;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///  The type of currency that is used for billing. The currencyCode used for your reservation
        /// is US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The length of time that this reservation is active. MediaConnect defines this value
        /// in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DurationUnits. 
        /// <para>
        ///  The unit of measurement for the duration of the reservation. MediaConnect defines
        /// this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DurationUnits DurationUnits
        {
            get { return this._durationUnits; }
            set { this._durationUnits = value; }
        }

        // Check to see if DurationUnits property is set
        internal bool IsSetDurationUnits()
        {
            return this._durationUnits != null;
        }

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        ///  The day and time that this reservation expires. This value is calculated based on
        /// the start date and time that you set and the offering's duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that MediaConnect assigns to the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OfferingArn
        {
            get { return this._offeringArn; }
            set { this._offeringArn = value; }
        }

        // Check to see if OfferingArn property is set
        internal bool IsSetOfferingArn()
        {
            return this._offeringArn != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingDescription. 
        /// <para>
        ///  A description of the offering. MediaConnect defines this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OfferingDescription
        {
            get { return this._offeringDescription; }
            set { this._offeringDescription = value; }
        }

        // Check to see if OfferingDescription property is set
        internal bool IsSetOfferingDescription()
        {
            return this._offeringDescription != null;
        }

        /// <summary>
        /// Gets and sets the property PricePerUnit. 
        /// <para>
        ///  The cost of a single unit. This value, in combination with priceUnits, makes up the
        /// rate. MediaConnect defines this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PricePerUnit
        {
            get { return this._pricePerUnit; }
            set { this._pricePerUnit = value; }
        }

        // Check to see if PricePerUnit property is set
        internal bool IsSetPricePerUnit()
        {
            return this._pricePerUnit != null;
        }

        /// <summary>
        /// Gets and sets the property PriceUnits. 
        /// <para>
        ///  The unit of measurement that is used for billing. This value, in combination with
        /// pricePerUnit, makes up the rate. MediaConnect defines this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PriceUnits PriceUnits
        {
            get { return this._priceUnits; }
            set { this._priceUnits = value; }
        }

        // Check to see if PriceUnits property is set
        internal bool IsSetPriceUnits()
        {
            return this._priceUnits != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that MediaConnect assigns to the reservation when
        /// you purchase an offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReservationArn
        {
            get { return this._reservationArn; }
            set { this._reservationArn = value; }
        }

        // Check to see if ReservationArn property is set
        internal bool IsSetReservationArn()
        {
            return this._reservationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        ///  The name that you assigned to the reservation when you purchased the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ReservationState. 
        /// <para>
        ///  The status of your reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReservationState ReservationState
        {
            get { return this._reservationState; }
            set { this._reservationState = value; }
        }

        // Check to see if ReservationState property is set
        internal bool IsSetReservationState()
        {
            return this._reservationState != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        ///  A definition of the amount of outbound bandwidth that you would be reserving if you
        /// purchase the offering. MediaConnect defines the values that make up the resourceSpecification
        /// in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceSpecification ResourceSpecification
        {
            get { return this._resourceSpecification; }
            set { this._resourceSpecification = value; }
        }

        // Check to see if ResourceSpecification property is set
        internal bool IsSetResourceSpecification()
        {
            return this._resourceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        ///  The day and time that the reservation becomes active. You set this value when you
        /// purchase the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

    }
}