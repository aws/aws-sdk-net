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
    /// Vehicle characteristics and restrictions that affect which roads can be used when
    /// calculating reachable areas for trucks. These details ensure that routes respect physical
    /// limitations and legal requirements.
    /// 
    ///  
    /// <para>
    /// These apply when the provided travel mode is <c>Truck</c> 
    /// </para>
    /// </summary>
    public partial class IsolineTruckOptions
    {
        private int? _axleCount;
        private IsolineEngineType _engineType;
        private long? _grossWeight;
        private List<string> _hazardousCargos = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private long? _height;
        private long? _heightAboveFirstAxle;
        private long? _kpraLength;
        private long? _length;
        private IsolineVehicleLicensePlate _licensePlate;
        private double? _maxSpeed;
        private int? _occupancy;
        private long? _payloadCapacity;
        private int? _tireCount;
        private IsolineTrailerOptions _trailer;
        private IsolineTruckType _truckType;
        private string _tunnelRestrictionCode;
        private long? _weightPerAxle;
        private WeightPerAxleGroup _weightPerAxleGroup;
        private long? _width;

        /// <summary>
        /// Gets and sets the property AxleCount. 
        /// <para>
        /// The total number of axles on the vehicle. Required for certain road restrictions and
        /// weight limit calculations.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=255)]
        public int? AxleCount
        {
            get { return this._axleCount; }
            set { this._axleCount = value; }
        }

        // Check to see if AxleCount property is set
        internal bool IsSetAxleCount()
        {
            return this._axleCount.HasValue; 
        }

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
        /// Gets and sets the property GrossWeight. 
        /// <para>
        /// The gross vehicle weight (the maximum weight a vehicle can safely operate at, as specified
        /// by the manufacturer) in kilograms. Used to avoid roads with weight restrictions and
        /// ensure compliance with maximum allowed vehicle weight regulations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? GrossWeight
        {
            get { return this._grossWeight; }
            set { this._grossWeight = value; }
        }

        // Check to see if GrossWeight property is set
        internal bool IsSetGrossWeight()
        {
            return this._grossWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HazardousCargos. 
        /// <para>
        /// Types of hazardous materials being transported. This affects which roads and tunnels
        /// can be used based on local regulations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Combustible</c>—Materials that can burn readily
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Corrosive</c>—Materials that can destroy or irreversibly damage other substances
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Explosive</c>—Materials that can produce an explosion by chemical reaction
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Flammable</c>—Materials that can easily ignite
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Gas</c>—Hazardous materials in gaseous form
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HarmfulToWater</c>—Materials that pose a risk to water sources if released
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Organic</c>—Hazardous organic compounds
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Other</c>—Hazardous materials not covered by other categories
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Poison</c>—Toxic materials
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PoisonousInhalation</c>—Materials that are toxic when inhaled
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Radioactive</c>—Materials that emit ionizing radiation
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=11)]
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
        /// Gets and sets the property Height. 
        /// <para>
        /// The vehicle height in centimeters. Used to avoid routes with low bridges or other
        /// height restrictions.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=5000)]
        public long? Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        // Check to see if Height property is set
        internal bool IsSetHeight()
        {
            return this._height.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HeightAboveFirstAxle. 
        /// <para>
        /// The height in centimeters measured from the ground to the highest point above the
        /// first axle. Used for specific bridge and tunnel clearance restrictions.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=5000)]
        public long? HeightAboveFirstAxle
        {
            get { return this._heightAboveFirstAxle; }
            set { this._heightAboveFirstAxle = value; }
        }

        // Check to see if HeightAboveFirstAxle property is set
        internal bool IsSetHeightAboveFirstAxle()
        {
            return this._heightAboveFirstAxle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KpraLength. 
        /// <para>
        /// The kingpin to rear axle (KPRA) length in centimeters. Used to determine if the vehicle
        /// can safely navigate turns and intersections.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? KpraLength
        {
            get { return this._kpraLength; }
            set { this._kpraLength = value; }
        }

        // Check to see if KpraLength property is set
        internal bool IsSetKpraLength()
        {
            return this._kpraLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Length. 
        /// <para>
        /// The total vehicle length in centimeters. Used to avoid roads with length restrictions
        /// and determine if the vehicle can safely navigate turns.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=30000)]
        public long? Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        // Check to see if Length property is set
        internal bool IsSetLength()
        {
            return this._length.HasValue; 
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
        /// The maximum speed in kilometers per hour at which the vehicle can or is permitted
        /// to travel. This affects travel time calculations and may result in different reachable
        /// areas compared to using default speed limits. Value must be between 3.6 and 252 kilometers
        /// per hour.
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

        /// <summary>
        /// Gets and sets the property PayloadCapacity. 
        /// <para>
        /// The maximum cargo weight in kilograms that the vehicle (including attached trailers)
        /// is rated to carry.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? PayloadCapacity
        {
            get { return this._payloadCapacity; }
            set { this._payloadCapacity = value; }
        }

        // Check to see if PayloadCapacity property is set
        internal bool IsSetPayloadCapacity()
        {
            return this._payloadCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TireCount. 
        /// <para>
        /// The total number of tires on the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
        public int? TireCount
        {
            get { return this._tireCount; }
            set { this._tireCount = value; }
        }

        // Check to see if TireCount property is set
        internal bool IsSetTireCount()
        {
            return this._tireCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Trailer. 
        /// <para>
        /// Optional specifications for attached trailers. When provided, trailer characteristics
        /// affect route calculations to ensure compliance with trailer-specific restrictions
        /// such as length limits, weight distribution requirements, and access restrictions for
        /// multi-trailer configurations.
        /// </para>
        /// </summary>
        public IsolineTrailerOptions Trailer
        {
            get { return this._trailer; }
            set { this._trailer = value; }
        }

        // Check to see if Trailer property is set
        internal bool IsSetTrailer()
        {
            return this._trailer != null;
        }

        /// <summary>
        /// Gets and sets the property TruckType. 
        /// <para>
        /// The type of truck: <c>LightTruck</c> for smaller delivery vehicles, <c> StraightTruck
        /// </c> for rigid body trucks, or <c>Tractor</c> for tractor-trailer combinations.
        /// </para>
        /// </summary>
        public IsolineTruckType TruckType
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

        /// <summary>
        /// Gets and sets the property WeightPerAxle. 
        /// <para>
        /// The heaviest weight per axle in kilograms, regardless of axle type or grouping. Used
        /// for roads with axle-weight restrictions in regions where regulations don't distinguish
        /// between different axle configurations.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? WeightPerAxle
        {
            get { return this._weightPerAxle; }
            set { this._weightPerAxle = value; }
        }

        // Check to see if WeightPerAxle property is set
        internal bool IsSetWeightPerAxle()
        {
            return this._weightPerAxle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeightPerAxleGroup. 
        /// <para>
        /// Specifies the total weight for different axle group configurations. Used in regions
        /// where regulations set different weight limits based on axle group types.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>kilograms</c> 
        /// </para>
        /// </summary>
        public WeightPerAxleGroup WeightPerAxleGroup
        {
            get { return this._weightPerAxleGroup; }
            set { this._weightPerAxleGroup = value; }
        }

        // Check to see if WeightPerAxleGroup property is set
        internal bool IsSetWeightPerAxleGroup()
        {
            return this._weightPerAxleGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Width. 
        /// <para>
        /// The vehicle width in centimeters. Used to avoid routes with width restrictions.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>centimeters</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=5000)]
        public long? Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Check to see if Width property is set
        internal bool IsSetWidth()
        {
            return this._width.HasValue; 
        }

    }
}