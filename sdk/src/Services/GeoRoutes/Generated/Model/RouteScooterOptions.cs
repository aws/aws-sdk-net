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
    /// Travel mode options when the provided travel mode is <c>Scooter</c>
    /// </summary>
    public partial class RouteScooterOptions
    {
        private RouteEngineType _engineType;
        private RouteVehicleLicensePlate _licensePlate;
        private double? _maxSpeed;
        private int? _occupancy;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// Engine type of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteEngineType EngineType
        {
            get { return this._engineType; }
            set { this._engineType = value; }
        }

        // Check to see if EngineType property is set
        internal bool IsSetEngineType()
        {
            return this._engineType != null;
        }

        /// <summary>
        /// Gets and sets the property LicensePlate. 
        /// <para>
        /// The vehicle License Plate.
        /// </para>
        /// </summary>
        public RouteVehicleLicensePlate LicensePlate
        {
            get { return this._licensePlate; }
            set { this._licensePlate = value; }
        }

        // Check to see if LicensePlate property is set
        internal bool IsSetLicensePlate()
        {
            return this._licensePlate != null;
        }

        /// <summary>
        /// Gets and sets the property MaxSpeed. 
        /// <para>
        /// Maximum speed
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>KilometersPerHour</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=252)]
        public double? MaxSpeed
        {
            get { return this._maxSpeed; }
            set { this._maxSpeed = value; }
        }

        // Check to see if MaxSpeed property is set
        internal bool IsSetMaxSpeed()
        {
            return this._maxSpeed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Occupancy. 
        /// <para>
        /// The number of occupants in the vehicle.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1)]
        public int? Occupancy
        {
            get { return this._occupancy; }
            set { this._occupancy = value; }
        }

        // Check to see if Occupancy property is set
        internal bool IsSetOccupancy()
        {
            return this._occupancy.HasValue; 
        }

    }
}