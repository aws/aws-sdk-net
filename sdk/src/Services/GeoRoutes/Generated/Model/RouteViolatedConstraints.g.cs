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
    /// This property contains a summary of violated constraints.
    /// </summary>
    public partial class RouteViolatedConstraints
    {
        /// <summary>
        /// Gets and sets the property AllHazardsRestricted. 
        /// <para>
        /// This restriction applies to truck cargo, where the resulting route excludes roads
        /// on which hazardous materials are prohibited from being transported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? AllHazardsRestricted { get; set; }

        /// <summary>
        /// Checks to see if the AllHazardsRestricted property is set.
        /// </summary>
        internal bool IsSetAllHazardsRestricted() => this.AllHazardsRestricted.HasValue;

        /// <summary>
        /// Gets and sets the property AxleCount. 
        /// <para>
        /// Total number of axles of the vehicle.
        /// </para>
        /// </summary>
        public RouteNoticeDetailRange AxleCount { get; set; }

        /// <summary>
        /// Checks to see if the AxleCount property is set.
        /// </summary>
        internal bool IsSetAxleCount() => this.AxleCount != null;

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
        [AWSProperty(Required = true, Max = 11)]
        public List<string> HazardousCargos { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HazardousCargos property is set.
        /// </summary>
        internal bool IsSetHazardousCargos() => this.HazardousCargos != null && (this.HazardousCargos.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxHeight. 
        /// <para>
        /// The maximum height of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? MaxHeight { get; set; }

        /// <summary>
        /// Checks to see if the MaxHeight property is set.
        /// </summary>
        internal bool IsSetMaxHeight() => this.MaxHeight.HasValue;

        /// <summary>
        /// Gets and sets the property MaxKpraLength. 
        /// <para>
        /// The maximum Kpra length of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? MaxKpraLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxKpraLength property is set.
        /// </summary>
        internal bool IsSetMaxKpraLength() => this.MaxKpraLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum length of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? MaxLength { get; set; }

        /// <summary>
        /// Checks to see if the MaxLength property is set.
        /// </summary>
        internal bool IsSetMaxLength() => this.MaxLength.HasValue;

        /// <summary>
        /// Gets and sets the property MaxPayloadCapacity. 
        /// <para>
        /// The maximum load capacity of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? MaxPayloadCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxPayloadCapacity property is set.
        /// </summary>
        internal bool IsSetMaxPayloadCapacity() => this.MaxPayloadCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MaxWeight. 
        /// <para>
        /// The maximum weight of the route.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        public RouteWeightConstraint MaxWeight { get; set; }

        /// <summary>
        /// Checks to see if the MaxWeight property is set.
        /// </summary>
        internal bool IsSetMaxWeight() => this.MaxWeight != null;

        /// <summary>
        /// Gets and sets the property MaxWeightPerAxle. 
        /// <para>
        /// The maximum weight per axle of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? MaxWeightPerAxle { get; set; }

        /// <summary>
        /// Checks to see if the MaxWeightPerAxle property is set.
        /// </summary>
        internal bool IsSetMaxWeightPerAxle() => this.MaxWeightPerAxle.HasValue;

        /// <summary>
        /// Gets and sets the property MaxWeightPerAxleGroup. 
        /// <para>
        /// The maximum weight per axle group of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        public WeightPerAxleGroup MaxWeightPerAxleGroup { get; set; }

        /// <summary>
        /// Checks to see if the MaxWeightPerAxleGroup property is set.
        /// </summary>
        internal bool IsSetMaxWeightPerAxleGroup() => this.MaxWeightPerAxleGroup != null;

        /// <summary>
        /// Gets and sets the property MaxWidth. 
        /// <para>
        /// The maximum width of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? MaxWidth { get; set; }

        /// <summary>
        /// Checks to see if the MaxWidth property is set.
        /// </summary>
        internal bool IsSetMaxWidth() => this.MaxWidth.HasValue;

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
        public RouteNoticeDetailRange Occupancy { get; set; }

        /// <summary>
        /// Checks to see if the Occupancy property is set.
        /// </summary>
        internal bool IsSetOccupancy() => this.Occupancy != null;

        /// <summary>
        /// Gets and sets the property RestrictedTimes. 
        /// <para>
        /// Access radius restrictions based on time.
        /// </para>
        /// </summary>
        public string RestrictedTimes { get; set; }

        /// <summary>
        /// Checks to see if the RestrictedTimes property is set.
        /// </summary>
        internal bool IsSetRestrictedTimes() => this.RestrictedTimes != null;

        /// <summary>
        /// Gets and sets the property TimeDependent. 
        /// <para>
        /// The time dependent constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? TimeDependent { get; set; }

        /// <summary>
        /// Checks to see if the TimeDependent property is set.
        /// </summary>
        internal bool IsSetTimeDependent() => this.TimeDependent.HasValue;

        /// <summary>
        /// Gets and sets the property TrailerCount. 
        /// <para>
        /// Number of trailers attached to the vehicle.
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>0</c> 
        /// </para>
        /// </summary>
        public RouteNoticeDetailRange TrailerCount { get; set; }

        /// <summary>
        /// Checks to see if the TrailerCount property is set.
        /// </summary>
        internal bool IsSetTrailerCount() => this.TrailerCount != null;

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Travel mode corresponding to the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? TravelMode { get; set; }

        /// <summary>
        /// Checks to see if the TravelMode property is set.
        /// </summary>
        internal bool IsSetTravelMode() => this.TravelMode.HasValue;

        /// <summary>
        /// Gets and sets the property TruckRoadType. 
        /// <para>
        /// Truck road type identifiers. <c>BK1</c> through <c>BK4</c> apply only to Sweden. <c>A2,A4,B2,B4,C,D,ET2,ET4</c>
        /// apply only to Mexico.
        /// </para>
        ///  <note> 
        /// <para>
        /// There are currently no other supported values as of 26th April 2024.
        /// </para>
        ///  </note>
        /// </summary>
        public string TruckRoadType { get; set; }

        /// <summary>
        /// Checks to see if the TruckRoadType property is set.
        /// </summary>
        internal bool IsSetTruckRoadType() => this.TruckRoadType != null;

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
        [AWSProperty(Sensitive = true, Min = 1, Max = 1)]
        public string TunnelRestrictionCode { get; set; }

        /// <summary>
        /// Checks to see if the TunnelRestrictionCode property is set.
        /// </summary>
        internal bool IsSetTunnelRestrictionCode() => this.TunnelRestrictionCode != null;
    }
}
