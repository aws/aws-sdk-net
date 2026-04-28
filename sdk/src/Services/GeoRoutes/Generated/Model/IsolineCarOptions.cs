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
    /// Vehicle characteristics and preferences that affect routing for passenger cars. This
    /// includes vehicle type, occupancy, and speed restrictions that may influence which
    /// roads can be used and expected travel times.
    /// </summary>
    public partial class IsolineCarOptions
    {
        private IsolineEngineType _engineType;
        private IsolineVehicleLicensePlate _licensePlate;
        private double? _maxSpeed;
        private int? _occupancy;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// The type of engine powering the vehicle, which may affect route calculation due to
        /// road restrictions or vehicle characteristics.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INTERNAL_COMBUSTION</c>—Standard gasoline or diesel engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ELECTRIC</c>—Battery electric vehicle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PLUGIN_HYBRID</c>—Combination of electric and internal combustion engines with
        /// plug-in charging capability.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public IsolineEngineType EngineType
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
        /// License plate information used in regions where road access or routing restrictions
        /// are based on license plate numbers.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public IsolineVehicleLicensePlate LicensePlate
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
        /// The maximum speed of the vehicle in kilometers per hour. When specified, routes will
        /// not include roads with higher speed limits. Valid values range from 3.6 km/h (1 m/s)
        /// to 252 km/h (70 m/s).
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
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
        /// The number of occupants in the vehicle. This can affect route calculations by enabling
        /// the use of high-occupancy vehicle (HOV) lanes where minimum occupancy requirements
        /// are met.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>1</c> 
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