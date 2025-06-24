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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// The capacity reservation status for each Availability Zone.
    /// </summary>
    public partial class ZonalCapacityReservationState
    {
        private string _availabilityZone;
        private double? _effectiveCapacityUnits;
        private CapacityReservationStatus _state;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Information about the Availability Zone.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveCapacityUnits. 
        /// <para>
        /// The number of effective capacity units.
        /// </para>
        /// </summary>
        public double? EffectiveCapacityUnits
        {
            get { return this._effectiveCapacityUnits; }
            set { this._effectiveCapacityUnits = value; }
        }

        // Check to see if EffectiveCapacityUnits property is set
        internal bool IsSetEffectiveCapacityUnits()
        {
            return this._effectiveCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the capacity reservation.
        /// </para>
        /// </summary>
        public CapacityReservationStatus State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}