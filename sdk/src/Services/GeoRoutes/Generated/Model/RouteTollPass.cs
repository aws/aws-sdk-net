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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
        private bool? _includesReturnTrip;
        private bool? _seniorPass;
        private int? _transferCount;
        private int? _tripCount;
        private RouteTollPassValidityPeriod _validityPeriod;

        /// <summary>
        /// Gets and sets the property IncludesReturnTrip. 
        /// <para>
        /// If the pass includes the rate for the return leg of the trip.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? IncludesReturnTrip
        {
            get { return this._includesReturnTrip; }
            set { this._includesReturnTrip = value; }
        }

        // Check to see if IncludesReturnTrip property is set
        internal bool IsSetIncludesReturnTrip()
        {
            return this._includesReturnTrip.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeniorPass. 
        /// <para>
        /// If the pass is only valid for senior persons.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? SeniorPass
        {
            get { return this._seniorPass; }
            set { this._seniorPass = value; }
        }

        // Check to see if SeniorPass property is set
        internal bool IsSetSeniorPass()
        {
            return this._seniorPass.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransferCount. 
        /// <para>
        /// If the toll pass can be transferred, and how many times.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? TransferCount
        {
            get { return this._transferCount; }
            set { this._transferCount = value; }
        }

        // Check to see if TransferCount property is set
        internal bool IsSetTransferCount()
        {
            return this._transferCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TripCount. 
        /// <para>
        /// Number of trips the pass is valid for.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0)]
        public int? TripCount
        {
            get { return this._tripCount; }
            set { this._tripCount = value; }
        }

        // Check to see if TripCount property is set
        internal bool IsSetTripCount()
        {
            return this._tripCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidityPeriod. 
        /// <para>
        /// Period for which the pass is valid.
        /// </para>
        /// </summary>
        public RouteTollPassValidityPeriod ValidityPeriod
        {
            get { return this._validityPeriod; }
            set { this._validityPeriod = value; }
        }

        // Check to see if ValidityPeriod property is set
        internal bool IsSetValidityPeriod()
        {
            return this._validityPeriod != null;
        }

    }
}