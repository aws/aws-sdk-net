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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The class of offering for the reservation. The offering class determines the payment
    /// schedule for the reservation.
    /// </summary>
    public partial class ReservationOffering
    {
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
        /// The duration, in seconds, for which the reservation reserves the RPUs.
        /// </para>
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property HourlyCharge. 
        /// <para>
        /// The rate you are charged for each hour the reservation is active.
        /// </para>
        /// </summary>
        public double? HourlyCharge { get; set; }

        /// <summary>
        /// Checks to see if the HourlyCharge property is set.
        /// </summary>
        internal bool IsSetHourlyCharge() => this.HourlyCharge.HasValue;

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The offering identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string OfferingId { get; set; }

        /// <summary>
        /// Checks to see if the OfferingId property is set.
        /// </summary>
        internal bool IsSetOfferingId() => this.OfferingId != null;

        /// <summary>
        /// Gets and sets the property OfferingType. 
        /// <para>
        /// Determines the payment schedule for the reservation.
        /// </para>
        /// </summary>
        public OfferingType OfferingType { get; set; }

        /// <summary>
        /// Checks to see if the OfferingType property is set.
        /// </summary>
        internal bool IsSetOfferingType() => this.OfferingType != null;

        /// <summary>
        /// Gets and sets the property UpfrontCharge. 
        /// <para>
        /// The up-front price you are charged for the reservation.
        /// </para>
        /// </summary>
        public double? UpfrontCharge { get; set; }

        /// <summary>
        /// Checks to see if the UpfrontCharge property is set.
        /// </summary>
        internal bool IsSetUpfrontCharge() => this.UpfrontCharge.HasValue;
    }
}
