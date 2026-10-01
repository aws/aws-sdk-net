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
    /// Travel mode options when the provided travel mode is <c>Scooter</c>. For <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
    /// customers, <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions support only <c>LicensePlate</c>
    /// options.
    /// </summary>
    public partial class RouteScooterOptions
    {
        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        ///  Engine type of the vehicle. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteEngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property LicensePlate. 
        /// <para>
        /// The vehicle License Plate.
        /// </para>
        /// </summary>
        public RouteVehicleLicensePlate LicensePlate { get; set; }

        /// <summary>
        /// Checks to see if the LicensePlate property is set.
        /// </summary>
        internal bool IsSetLicensePlate() => this.LicensePlate != null;

        /// <summary>
        /// Gets and sets the property MaxSpeed. 
        /// <para>
        ///  Maximum speed Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions
        /// for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilometers per hour</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 252)]
        public double? MaxSpeed { get; set; }

        /// <summary>
        /// Checks to see if the MaxSpeed property is set.
        /// </summary>
        internal bool IsSetMaxSpeed() => this.MaxSpeed.HasValue;

        /// <summary>
        /// Gets and sets the property Occupancy. 
        /// <para>
        ///  The number of occupants in the vehicle. Not supported in <c>ap-southeast-1</c> and
        /// <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public int? Occupancy { get; set; }

        /// <summary>
        /// Checks to see if the Occupancy property is set.
        /// </summary>
        internal bool IsSetOccupancy() => this.Occupancy.HasValue;
    }
}
