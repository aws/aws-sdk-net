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
    /// Travel mode related options for the provided travel mode.
    /// </summary>
    public partial class RouteMatrixTravelModeOptions
    {
        /// <summary>
        /// Gets and sets the property Car. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Car</c>.
        /// </para>
        /// </summary>
        public RouteMatrixCarOptions Car { get; set; }

        /// <summary>
        /// Checks to see if the Car property is set.
        /// </summary>
        internal bool IsSetCar() => this.Car != null;

        /// <summary>
        /// Gets and sets the property Scooter. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Scooter</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When travel mode is set to <c>Scooter</c>, then the avoidance option <c>ControlledAccessHighways</c>
        /// defaults to <c>true</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public RouteMatrixScooterOptions Scooter { get; set; }

        /// <summary>
        /// Checks to see if the Scooter property is set.
        /// </summary>
        internal bool IsSetScooter() => this.Scooter != null;

        /// <summary>
        /// Gets and sets the property Truck. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Truck</c>.
        /// </para>
        /// </summary>
        public RouteMatrixTruckOptions Truck { get; set; }

        /// <summary>
        /// Checks to see if the Truck property is set.
        /// </summary>
        internal bool IsSetTruck() => this.Truck != null;
    }
}
