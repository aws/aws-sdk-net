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
    /// This property contains a summary of violated constraints.
    /// </summary>
    public partial class RouteViolatedConstraints
    {
        private bool? _allHazardsRestricted;
        private RouteNoticeDetailRange _axleCount;
        private List<string> _hazardousCargos = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _maxHeight;
        private long? _maxKpraLength;
        private long? _maxLength;
        private long? _maxPayloadCapacity;
        private RouteWeightConstraint _maxWeight;
        private long? _maxWeightPerAxle;
        private WeightPerAxleGroup _maxWeightPerAxleGroup;
        private long? _maxWidth;
        private RouteNoticeDetailRange _occupancy;
        private string _restrictedTimes;
        private bool? _timeDependent;
        private RouteNoticeDetailRange _trailerCount;
        private bool? _travelMode;
        private string _truckRoadType;
        private RouteTruckType _truckType;
        private string _tunnelRestrictionCode;

        /// <summary>
        /// Gets and sets the property AllHazardsRestricted. 
        /// <para>
        /// This restriction applies to truck cargo, where the resulting route excludes roads
        /// on which hazardous materials are prohibited from being transported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? AllHazardsRestricted
        {
            get { return this._allHazardsRestricted; }
            set { this._allHazardsRestricted = value; }
        }

        // Check to see if AllHazardsRestricted property is set
        internal bool IsSetAllHazardsRestricted()
        {
            return this._allHazardsRestricted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AxleCount. 
        /// <para>
        /// Total number of axles of the vehicle.
        /// </para>
        /// </summary>
        public RouteNoticeDetailRange AxleCount
        {
            get { return this._axleCount; }
            set { this._axleCount = value; }
        }

        // Check to see if AxleCount property is set
        internal bool IsSetAxleCount()
        {
            return this._axleCount != null;
        }

        /// <summary>
        /// Gets and sets the property HazardousCargos. 
        /// <para>
        /// List of Hazardous cargo contained in the vehicle.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=11)]
        public List<string> HazardousCargos
        {
            get { return this._hazardousCargos; }
            set { this._hazardousCargos = value; }
        }

        // Check to see if HazardousCargos property is set
        internal bool IsSetHazardousCargos()
        {
            return this._hazardousCargos != null && (this._hazardousCargos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxHeight. 
        /// <para>
        /// The maximum height of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? MaxHeight
        {
            get { return this._maxHeight; }
            set { this._maxHeight = value; }
        }

        // Check to see if MaxHeight property is set
        internal bool IsSetMaxHeight()
        {
            return this._maxHeight.HasValue; 
        }

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
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? MaxKpraLength
        {
            get { return this._maxKpraLength; }
            set { this._maxKpraLength = value; }
        }

        // Check to see if MaxKpraLength property is set
        internal bool IsSetMaxKpraLength()
        {
            return this._maxKpraLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxLength. 
        /// <para>
        /// The maximum length of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? MaxLength
        {
            get { return this._maxLength; }
            set { this._maxLength = value; }
        }

        // Check to see if MaxLength property is set
        internal bool IsSetMaxLength()
        {
            return this._maxLength.HasValue; 
        }

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
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? MaxPayloadCapacity
        {
            get { return this._maxPayloadCapacity; }
            set { this._maxPayloadCapacity = value; }
        }

        // Check to see if MaxPayloadCapacity property is set
        internal bool IsSetMaxPayloadCapacity()
        {
            return this._maxPayloadCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxWeight. 
        /// <para>
        /// The maximum weight of the route.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        public RouteWeightConstraint MaxWeight
        {
            get { return this._maxWeight; }
            set { this._maxWeight = value; }
        }

        // Check to see if MaxWeight property is set
        internal bool IsSetMaxWeight()
        {
            return this._maxWeight != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWeightPerAxle. 
        /// <para>
        /// The maximum weight per axle of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? MaxWeightPerAxle
        {
            get { return this._maxWeightPerAxle; }
            set { this._maxWeightPerAxle = value; }
        }

        // Check to see if MaxWeightPerAxle property is set
        internal bool IsSetMaxWeightPerAxle()
        {
            return this._maxWeightPerAxle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxWeightPerAxleGroup. 
        /// <para>
        /// The maximum weight per axle group of the vehicle.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
        /// </para>
        /// </summary>
        public WeightPerAxleGroup MaxWeightPerAxleGroup
        {
            get { return this._maxWeightPerAxleGroup; }
            set { this._maxWeightPerAxleGroup = value; }
        }

        // Check to see if MaxWeightPerAxleGroup property is set
        internal bool IsSetMaxWeightPerAxleGroup()
        {
            return this._maxWeightPerAxleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property MaxWidth. 
        /// <para>
        /// The maximum width of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? MaxWidth
        {
            get { return this._maxWidth; }
            set { this._maxWidth = value; }
        }

        // Check to see if MaxWidth property is set
        internal bool IsSetMaxWidth()
        {
            return this._maxWidth.HasValue; 
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
        public RouteNoticeDetailRange Occupancy
        {
            get { return this._occupancy; }
            set { this._occupancy = value; }
        }

        // Check to see if Occupancy property is set
        internal bool IsSetOccupancy()
        {
            return this._occupancy != null;
        }

        /// <summary>
        /// Gets and sets the property RestrictedTimes. 
        /// <para>
        /// Access radius restrictions based on time.
        /// </para>
        /// </summary>
        public string RestrictedTimes
        {
            get { return this._restrictedTimes; }
            set { this._restrictedTimes = value; }
        }

        // Check to see if RestrictedTimes property is set
        internal bool IsSetRestrictedTimes()
        {
            return this._restrictedTimes != null;
        }

        /// <summary>
        /// Gets and sets the property TimeDependent. 
        /// <para>
        /// The time dependent constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? TimeDependent
        {
            get { return this._timeDependent; }
            set { this._timeDependent = value; }
        }

        // Check to see if TimeDependent property is set
        internal bool IsSetTimeDependent()
        {
            return this._timeDependent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrailerCount. 
        /// <para>
        /// Number of trailers attached to the vehicle.
        /// </para>
        ///  
        /// <para>
        /// Default Value: <c>0</c> 
        /// </para>
        /// </summary>
        public RouteNoticeDetailRange TrailerCount
        {
            get { return this._trailerCount; }
            set { this._trailerCount = value; }
        }

        // Check to see if TrailerCount property is set
        internal bool IsSetTrailerCount()
        {
            return this._trailerCount != null;
        }

        /// <summary>
        /// Gets and sets the property TravelMode. 
        /// <para>
        /// Travel mode corresponding to the leg.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? TravelMode
        {
            get { return this._travelMode; }
            set { this._travelMode = value; }
        }

        // Check to see if TravelMode property is set
        internal bool IsSetTravelMode()
        {
            return this._travelMode.HasValue; 
        }

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
        public string TruckRoadType
        {
            get { return this._truckRoadType; }
            set { this._truckRoadType = value; }
        }

        // Check to see if TruckRoadType property is set
        internal bool IsSetTruckRoadType()
        {
            return this._truckRoadType != null;
        }

        /// <summary>
        /// Gets and sets the property TruckType. 
        /// <para>
        /// Type of the truck.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RouteTruckType TruckType
        {
            get { return this._truckType; }
            set { this._truckType = value; }
        }

        // Check to see if TruckType property is set
        internal bool IsSetTruckType()
        {
            return this._truckType != null;
        }

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
        [AWSProperty(Sensitive=true, Min=1, Max=1)]
        public string TunnelRestrictionCode
        {
            get { return this._tunnelRestrictionCode; }
            set { this._tunnelRestrictionCode = value; }
        }

        // Check to see if TunnelRestrictionCode property is set
        internal bool IsSetTunnelRestrictionCode()
        {
            return this._tunnelRestrictionCode != null;
        }

    }
}