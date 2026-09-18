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
    /// Travel mode options when the provided travel mode is <c>Truck</c>. Not supported
    /// in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
    /// customers.
    /// </summary>
    public partial class RouteTruckOptions
    {
        /// <summary>
        /// Gets and sets the property AxleCount. 
        /// <para>
        /// Total number of axles of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 255)]
        public int? AxleCount { get; set; }

        /// <summary>
        /// Checks to see if the AxleCount property is set.
        /// </summary>
        internal bool IsSetAxleCount() => this.AxleCount.HasValue;

        /// <summary>
        /// Gets and sets the property EngineType. 
        /// <para>
        /// Engine type of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteEngineType EngineType { get; set; }

        /// <summary>
        /// Checks to see if the EngineType property is set.
        /// </summary>
        internal bool IsSetEngineType() => this.EngineType != null;

        /// <summary>
        /// Gets and sets the property GrossWeight. 
        /// <para>
        /// Gross weight of the vehicle including trailers, and goods at capacity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? GrossWeight { get; set; }

        /// <summary>
        /// Checks to see if the GrossWeight property is set.
        /// </summary>
        internal bool IsSetGrossWeight() => this.GrossWeight.HasValue;

        /// <summary>
        /// Gets and sets the property HazardousCargos. 
        /// <para>
        /// List of Hazardous cargo contained in the vehicle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 11)]
        public List<string> HazardousCargos { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HazardousCargos property is set.
        /// </summary>
        internal bool IsSetHazardousCargos() => this.HazardousCargos != null && (this.HazardousCargos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Height. 
        /// <para>
        /// Height of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 5000)]
        public long? Height { get; set; }

        /// <summary>
        /// Checks to see if the Height property is set.
        /// </summary>
        internal bool IsSetHeight() => this.Height.HasValue;

        /// <summary>
        /// Gets and sets the property HeightAboveFirstAxle. 
        /// <para>
        /// Height of the vehicle above its first axle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 5000)]
        public long? HeightAboveFirstAxle { get; set; }

        /// <summary>
        /// Checks to see if the HeightAboveFirstAxle property is set.
        /// </summary>
        internal bool IsSetHeightAboveFirstAxle() => this.HeightAboveFirstAxle.HasValue;

        /// <summary>
        /// Gets and sets the property KpraLength. 
        /// <para>
        /// Kingpin to rear axle length of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? KpraLength { get; set; }

        /// <summary>
        /// Checks to see if the KpraLength property is set.
        /// </summary>
        internal bool IsSetKpraLength() => this.KpraLength.HasValue;

        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// Length of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>c</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 30000)]
        public long? Length { get; set; }

        /// <summary>
        /// Checks to see if the Length property is set.
        /// </summary>
        internal bool IsSetLength() => this.Length.HasValue;

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
        /// Maximum speed
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
        /// The number of occupants in the vehicle.
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

        /// <summary>
        /// Gets and sets the property PayloadCapacity. 
        /// <para>
        /// Payload capacity of the vehicle and trailers attached.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? PayloadCapacity { get; set; }

        /// <summary>
        /// Checks to see if the PayloadCapacity property is set.
        /// </summary>
        internal bool IsSetPayloadCapacity() => this.PayloadCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property TireCount. 
        /// <para>
        /// Number of tires on the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 255)]
        public int? TireCount { get; set; }

        /// <summary>
        /// Checks to see if the TireCount property is set.
        /// </summary>
        internal bool IsSetTireCount() => this.TireCount.HasValue;

        /// <summary>
        /// Gets and sets the property Trailer. 
        /// <para>
        /// Trailer options corresponding to the vehicle.
        /// </para>
        /// </summary>
        public RouteTrailerOptions Trailer { get; set; }

        /// <summary>
        /// Checks to see if the Trailer property is set.
        /// </summary>
        internal bool IsSetTrailer() => this.Trailer != null;

        /// <summary>
        /// Gets and sets the property TruckType. 
        /// <para>
        /// The type of truck: <c>LightTruck</c> for smaller delivery vehicles, <c> StraightTruck</c>
        /// for rigid body trucks, or <c>Tractor</c> for tractor-trailer combinations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteTruckType TruckType { get; set; }

        /// <summary>
        /// Checks to see if the TruckType property is set.
        /// </summary>
        internal bool IsSetTruckType() => this.TruckType != null;

        /// <summary>
        /// Gets and sets the property TunnelRestrictionCode. 
        /// <para>
        /// The tunnel restriction code.
        /// </para>
        ///  
        /// <para>
        /// Tunnel categories in this list indicate the restrictions which apply to certain tunnels
        /// in Great Britain. They relate to the types of dangerous goods that can be transported
        /// through them.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Tunnel Category B</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: Limited risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Few restrictions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i>Tunnel Category C</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: Medium risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Some restrictions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i>Tunnel Category D</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: High risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Many restrictions occur
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <i>Tunnel Category E</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Risk Level</i>: Very high risk
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Restrictions</i>: Restricted tunnel
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 20)]
        public string TunnelRestrictionCode { get; set; }

        /// <summary>
        /// Checks to see if the TunnelRestrictionCode property is set.
        /// </summary>
        internal bool IsSetTunnelRestrictionCode() => this.TunnelRestrictionCode != null;

        /// <summary>
        /// Gets and sets the property WeightPerAxle. 
        /// <para>
        /// Heaviest weight per axle irrespective of the axle type or the axle group. Meant for
        /// usage in countries where the differences in axle types or axle groups are not distinguished.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? WeightPerAxle { get; set; }

        /// <summary>
        /// Checks to see if the WeightPerAxle property is set.
        /// </summary>
        internal bool IsSetWeightPerAxle() => this.WeightPerAxle.HasValue;

        /// <summary>
        /// Gets and sets the property WeightPerAxleGroup. 
        /// <para>
        /// Specifies the total weight for the specified axle group. Meant for usage in countries
        /// that have different regulations based on the axle group type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        public WeightPerAxleGroup WeightPerAxleGroup { get; set; }

        /// <summary>
        /// Checks to see if the WeightPerAxleGroup property is set.
        /// </summary>
        internal bool IsSetWeightPerAxleGroup() => this.WeightPerAxleGroup != null;

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// Width of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 5000)]
        public long? Width { get; set; }

        /// <summary>
        /// Checks to see if the Width property is set.
        /// </summary>
        internal bool IsSetWidth() => this.Width.HasValue;
    }
}
