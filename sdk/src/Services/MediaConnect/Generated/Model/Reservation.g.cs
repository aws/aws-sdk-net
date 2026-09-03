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
        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        ///  The type of currency that is used for billing. The currencyCode used for your reservation
        /// is US dollars.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Checks to see if the CurrencyCode property is set.
        /// </summary>
        internal bool IsSetCurrencyCode() => this.CurrencyCode != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        ///  The length of time that this reservation is active. MediaConnect defines this value
        /// in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property DurationUnits. 
        /// <para>
        ///  The unit of measurement for the duration of the reservation. MediaConnect defines
        /// this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DurationUnits DurationUnits { get; set; }

        /// <summary>
        /// Checks to see if the DurationUnits property is set.
        /// </summary>
        internal bool IsSetDurationUnits() => this.DurationUnits != null;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        ///  The day and time that this reservation expires. This value is calculated based on
        /// the start date and time that you set and the offering's duration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string End { get; set; }

        /// <summary>
        /// Checks to see if the End property is set.
        /// </summary>
        internal bool IsSetEnd() => this.End != null;

        /// <summary>
        /// Gets and sets the property OfferingArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that MediaConnect assigns to the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OfferingArn { get; set; }

        /// <summary>
        /// Checks to see if the OfferingArn property is set.
        /// </summary>
        internal bool IsSetOfferingArn() => this.OfferingArn != null;

        /// <summary>
        /// Gets and sets the property OfferingDescription. 
        /// <para>
        ///  A description of the offering. MediaConnect defines this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OfferingDescription { get; set; }

        /// <summary>
        /// Checks to see if the OfferingDescription property is set.
        /// </summary>
        internal bool IsSetOfferingDescription() => this.OfferingDescription != null;

        /// <summary>
        /// Gets and sets the property PricePerUnit. 
        /// <para>
        ///  The cost of a single unit. This value, in combination with priceUnits, makes up the
        /// rate. MediaConnect defines this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PricePerUnit { get; set; }

        /// <summary>
        /// Checks to see if the PricePerUnit property is set.
        /// </summary>
        internal bool IsSetPricePerUnit() => this.PricePerUnit != null;

        /// <summary>
        /// Gets and sets the property PriceUnits. 
        /// <para>
        ///  The unit of measurement that is used for billing. This value, in combination with
        /// pricePerUnit, makes up the rate. MediaConnect defines this value in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PriceUnits PriceUnits { get; set; }

        /// <summary>
        /// Checks to see if the PriceUnits property is set.
        /// </summary>
        internal bool IsSetPriceUnits() => this.PriceUnits != null;

        /// <summary>
        /// Gets and sets the property ReservationArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that MediaConnect assigns to the reservation when
        /// you purchase an offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReservationArn { get; set; }

        /// <summary>
        /// Checks to see if the ReservationArn property is set.
        /// </summary>
        internal bool IsSetReservationArn() => this.ReservationArn != null;

        /// <summary>
        /// Gets and sets the property ReservationName. 
        /// <para>
        ///  The name that you assigned to the reservation when you purchased the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReservationName { get; set; }

        /// <summary>
        /// Checks to see if the ReservationName property is set.
        /// </summary>
        internal bool IsSetReservationName() => this.ReservationName != null;

        /// <summary>
        /// Gets and sets the property ReservationState. 
        /// <para>
        ///  The status of your reservation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReservationState ReservationState { get; set; }

        /// <summary>
        /// Checks to see if the ReservationState property is set.
        /// </summary>
        internal bool IsSetReservationState() => this.ReservationState != null;

        /// <summary>
        /// Gets and sets the property ResourceSpecification. 
        /// <para>
        ///  A definition of the amount of outbound bandwidth that you would be reserving if you
        /// purchase the offering. MediaConnect defines the values that make up the resourceSpecification
        /// in the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceSpecification ResourceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ResourceSpecification property is set.
        /// </summary>
        internal bool IsSetResourceSpecification() => this.ResourceSpecification != null;

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        ///  The day and time that the reservation becomes active. You set this value when you
        /// purchase the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Start { get; set; }

        /// <summary>
        /// Checks to see if the Start property is set.
        /// </summary>
        internal bool IsSetStart() => this.Start != null;
    }
}
