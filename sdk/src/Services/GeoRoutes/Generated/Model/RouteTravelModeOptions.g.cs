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
    public partial class RouteTravelModeOptions
    {
        /// <summary>
        /// Gets and sets the property Car. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Car</c>.
        /// </para>
        /// </summary>
        public RouteCarOptions Car { get; set; }

        /// <summary>
        /// Checks to see if the Car property is set.
        /// </summary>
        internal bool IsSetCar() => this.Car != null;

        /// <summary>
        /// Gets and sets the property Intermodal. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Intermodal</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  </note>
        /// </summary>
        public RouteIntermodalOptions Intermodal { get; set; }

        /// <summary>
        /// Checks to see if the Intermodal property is set.
        /// </summary>
        internal bool IsSetIntermodal() => this.Intermodal != null;

        /// <summary>
        /// Gets and sets the property Pedestrian. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Pedestrian</c>.
        /// </para>
        /// </summary>
        public RoutePedestrianOptions Pedestrian { get; set; }

        /// <summary>
        /// Checks to see if the Pedestrian property is set.
        /// </summary>
        internal bool IsSetPedestrian() => this.Pedestrian != null;

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
        public RouteScooterOptions Scooter { get; set; }

        /// <summary>
        /// Checks to see if the Scooter property is set.
        /// </summary>
        internal bool IsSetScooter() => this.Scooter != null;

        /// <summary>
        /// Gets and sets the property Transit. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Transit</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers.
        /// </para>
        ///  </note>
        /// </summary>
        public RouteTransitOptions Transit { get; set; }

        /// <summary>
        /// Checks to see if the Transit property is set.
        /// </summary>
        internal bool IsSetTransit() => this.Transit != null;

        /// <summary>
        /// Gets and sets the property Truck. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Truck</c>.
        /// </para>
        /// </summary>
        public RouteTruckOptions Truck { get; set; }

        /// <summary>
        /// Checks to see if the Truck property is set.
        /// </summary>
        internal bool IsSetTruck() => this.Truck != null;
    }
}
