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
    /// Travel mode related options for the provided travel mode.
    /// </summary>
    public partial class RouteMatrixTravelModeOptions
    {
        private RouteMatrixCarOptions _car;
        private RouteMatrixScooterOptions _scooter;
        private RouteMatrixTruckOptions _truck;

        /// <summary>
        /// Gets and sets the property Car. 
        /// <para>
        /// Travel mode options when the provided travel mode is "Car"
        /// </para>
        /// </summary>
        public RouteMatrixCarOptions Car
        {
            get { return this._car; }
            set { this._car = value; }
        }

        // Check to see if Car property is set
        internal bool IsSetCar()
        {
            return this._car != null;
        }

        /// <summary>
        /// Gets and sets the property Scooter. 
        /// <para>
        /// Travel mode options when the provided travel mode is <c>Scooter</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// When travel mode is set to <c>Scooter</c>, then the avoidance option <c>ControlledAccessHighways</c>
        /// defaults to <c>true</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public RouteMatrixScooterOptions Scooter
        {
            get { return this._scooter; }
            set { this._scooter = value; }
        }

        // Check to see if Scooter property is set
        internal bool IsSetScooter()
        {
            return this._scooter != null;
        }

        /// <summary>
        /// Gets and sets the property Truck. 
        /// <para>
        /// Travel mode options when the provided travel mode is "Truck"
        /// </para>
        /// </summary>
        public RouteMatrixTruckOptions Truck
        {
            get { return this._truck; }
            set { this._truck = value; }
        }

        // Check to see if Truck property is set
        internal bool IsSetTruck()
        {
            return this._truck != null;
        }

    }
}