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

namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Details if the toll rate can be a pass that supports multiple trips.
    /// </summary>
    public partial class RouteTollPass
    {
        /// <summary>
        /// Gets and sets the property IncludesReturnTrip. 
        /// <para>
        /// If the pass includes the rate for the return leg of the trip.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? IncludesReturnTrip { get; set; }

        /// <summary>
        /// Checks to see if the IncludesReturnTrip property is set.
        /// </summary>
        internal bool IsSetIncludesReturnTrip() => this.IncludesReturnTrip.HasValue;

        /// <summary>
        /// Gets and sets the property SeniorPass. 
        /// <para>
        /// If the pass is only valid for senior persons.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? SeniorPass { get; set; }

        /// <summary>
        /// Checks to see if the SeniorPass property is set.
        /// </summary>
        internal bool IsSetSeniorPass() => this.SeniorPass.HasValue;

        /// <summary>
        /// Gets and sets the property TransferCount. 
        /// <para>
        /// If the toll pass can be transferred, and how many times.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public int? TransferCount { get; set; }

        /// <summary>
        /// Checks to see if the TransferCount property is set.
        /// </summary>
        internal bool IsSetTransferCount() => this.TransferCount.HasValue;

        /// <summary>
        /// Gets and sets the property TripCount. 
        /// <para>
        /// Number of trips the pass is valid for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public int? TripCount { get; set; }

        /// <summary>
        /// Checks to see if the TripCount property is set.
        /// </summary>
        internal bool IsSetTripCount() => this.TripCount.HasValue;

        /// <summary>
        /// Gets and sets the property ValidityPeriod. 
        /// <para>
        /// Period for which the pass is valid.
        /// </para>
        /// </summary>
        public RouteTollPassValidityPeriod ValidityPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ValidityPeriod property is set.
        /// </summary>
        internal bool IsSetValidityPeriod() => this.ValidityPeriod != null;
    }
}
