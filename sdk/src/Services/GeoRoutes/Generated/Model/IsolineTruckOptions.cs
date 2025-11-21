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
    /// Travel mode options when the provided travel mode is "Truck"
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
        /// Total number of axles of the vehicle.
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
        /// Engine type of the vehicle.
        /// </para>
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
        /// Gross weight of the vehicle including trailers, and goods at capacity.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
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
        /// List of Hazardous cargo contained in the vehicle.
        /// </para>
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
        /// Height of the vehicle.
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
        /// Height of the vehicle above its first axle.
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
        /// Kingpin to rear axle length of the vehicle.
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
        /// Length of the vehicle.
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
        /// The vehicle License Plate.
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
        /// Maximum speed specified.
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
        /// Number of tires on the vehicle.
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
        /// Trailer options corresponding to the vehicle.
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
        /// Type of the truck.
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
        /// Heaviest weight per axle irrespective of the axle type or the axle group. Meant for
        /// usage in countries where the differences in axle types or axle groups are not distinguished.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
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
        /// Specifies the total weight for the specified axle group. Meant for usage in countries
        /// that have different regulations based on the axle group type.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>Kilograms</c> 
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
        /// Width of the vehicle.
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