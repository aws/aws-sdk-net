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
    /// Mode-specific routing options that further refine how reachable areas are calculated.
    /// Options are only considered when they match the selected travel mode.
    /// </summary>
    public partial class IsolineTravelModeOptions
    {
        /// <summary>
        /// Gets and sets the property Car. 
        /// <para>
        /// Options specific to passenger vehicle routing (<c>Car</c>, such as vehicle characteristics
        /// and license plate restrictions.
        /// </para>
        /// </summary>
        public IsolineCarOptions Car { get; set; }

        /// <summary>
        /// Checks to see if the Car property is set.
        /// </summary>
        internal bool IsSetCar() => this.Car != null;

        /// <summary>
        /// Gets and sets the property Scooter. 
        /// <para>
        /// Options specific to scooter routing (<c>Scooter</c>, such as vehicle characteristics
        /// and license plate restrictions.
        /// </para>
        ///  <note> 
        /// <para>
        /// When using the <c>Scooter</c> travel mode, controlled-access highways are automatically
        /// avoided unless explicitly allowed.
        /// </para>
        ///  </note>
        /// </summary>
        public IsolineScooterOptions Scooter { get; set; }

        /// <summary>
        /// Checks to see if the Scooter property is set.
        /// </summary>
        internal bool IsSetScooter() => this.Scooter != null;

        /// <summary>
        /// Gets and sets the property Truck. 
        /// <para>
        /// Options specific to commercial truck routing (<c>Truck</c>, including vehicle dimensions,
        /// weight limits, and hazardous cargo specifications.
        /// </para>
        /// </summary>
        public IsolineTruckOptions Truck { get; set; }

        /// <summary>
        /// Checks to see if the Truck property is set.
        /// </summary>
        internal bool IsSetTruck() => this.Truck != null;
    }
}
