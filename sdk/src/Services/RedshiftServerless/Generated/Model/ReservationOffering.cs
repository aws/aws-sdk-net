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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The class of offering for the reservation. The offering class determines the payment
    /// schedule for the reservation.
    /// </summary>
    public partial class ReservationOffering
    {
        private string _currencyCode;
        private int? _duration;
        private double? _hourlyCharge;
        private string _offeringId;
        private OfferingType _offeringType;
        private double? _upfrontCharge;

        /// <summary>
        /// Gets and sets the property CurrencyCode. 
        /// <para>
        /// The currency code for the offering.
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
        /// The duration, in seconds, for which the reservation reserves the RPUs.
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
        /// Gets and sets the property HourlyCharge. 
        /// <para>
        /// The rate you are charged for each hour the reservation is active.
        /// </para>
        /// </summary>
        public double? HourlyCharge
        {
            get { return this._hourlyCharge; }
            set { this._hourlyCharge = value; }
        }

        // Check to see if HourlyCharge property is set
        internal bool IsSetHourlyCharge()
        {
            return this._hourlyCharge.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The offering identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// Determines the payment schedule for the reservation.
        /// </para>
        /// </summary>
        public OfferingType OfferingType
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
        /// Gets and sets the property UpfrontCharge. 
        /// <para>
        /// The up-front price you are charged for the reservation.
        /// </para>
        /// </summary>
        public double? UpfrontCharge
        {
            get { return this._upfrontCharge; }
            set { this._upfrontCharge = value; }
        }

        // Check to see if UpfrontCharge property is set
        internal bool IsSetUpfrontCharge()
        {
            return this._upfrontCharge.HasValue; 
        }

    }
}