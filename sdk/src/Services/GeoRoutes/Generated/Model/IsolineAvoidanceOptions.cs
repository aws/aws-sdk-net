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
    /// Specifies features of the road network to avoid when calculating reachable areas.
    /// These preferences guide route calculations but may be overridden when no reasonable
    /// alternative exists. For example, if avoiding toll roads would make an area unreachable,
    /// toll roads may still be used.
    /// 
    ///  
    /// <para>
    /// Avoidance options include physical features (like ferries and tunnels), road characteristics
    /// (like dirt roads and highways), and regulated areas (like congestion zones). They
    /// can be combined to match specific routing needs, such as avoiding both toll roads
    /// and ferries.
    /// </para>
    /// </summary>
    public partial class IsolineAvoidanceOptions
    {
        private List<IsolineAvoidanceArea> _areas = AWSConfigs.InitializeCollections ? new List<IsolineAvoidanceArea>() : null;
        private bool? _carShuttleTrains;
        private bool? _controlledAccessHighways;
        private bool? _dirtRoads;
        private bool? _ferries;
        private bool? _seasonalClosure;
        private bool? _tollRoads;
        private bool? _tollTransponders;
        private List<string> _truckRoadTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _tunnels;
        private bool? _uTurns;
        private List<IsolineAvoidanceZoneCategory> _zoneCategories = AWSConfigs.InitializeCollections ? new List<IsolineAvoidanceZoneCategory>() : null;

        /// <summary>
        /// Gets and sets the property Areas. 
        /// <para>
        /// Specifies geographic areas to avoid where possible. Routes may still pass through
        /// these areas if no reasonable alternative exists.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IsolineAvoidanceArea> Areas
        {
            get { return this._areas; }
            set { this._areas = value; }
        }

        // Check to see if Areas property is set
        internal bool IsSetAreas()
        {
            return this._areas != null && (this._areas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CarShuttleTrains. 
        /// <para>
        /// Indicates a preference to avoid car shuttle trains (auto trains) where possible. These
        /// may still be included if no reasonable alternative route exists.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? CarShuttleTrains
        {
            get { return this._carShuttleTrains; }
            set { this._carShuttleTrains = value; }
        }

        // Check to see if CarShuttleTrains property is set
        internal bool IsSetCarShuttleTrains()
        {
            return this._carShuttleTrains.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ControlledAccessHighways. 
        /// <para>
        /// Indicates a preference to avoid controlled-access highways (such as interstate highways
        /// or motorways) where possible. If a viable route cannot be calculated using only local
        /// roads, controlled-access highways may still be included.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? ControlledAccessHighways
        {
            get { return this._controlledAccessHighways; }
            set { this._controlledAccessHighways = value; }
        }

        // Check to see if ControlledAccessHighways property is set
        internal bool IsSetControlledAccessHighways()
        {
            return this._controlledAccessHighways.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirtRoads. 
        /// <para>
        /// Indicates a preference to avoid unpaved or dirt roads where possible. Routes may still
        /// include dirt roads if no reasonable paved alternative exists.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? DirtRoads
        {
            get { return this._dirtRoads; }
            set { this._dirtRoads = value; }
        }

        // Check to see if DirtRoads property is set
        internal bool IsSetDirtRoads()
        {
            return this._dirtRoads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ferries. 
        /// <para>
        /// Indicates a preference to avoid ferries where possible. If a viable route cannot be
        /// calculated without using ferries, they may still be included.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Ferries
        {
            get { return this._ferries; }
            set { this._ferries = value; }
        }

        // Check to see if Ferries property is set
        internal bool IsSetFerries()
        {
            return this._ferries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SeasonalClosure. 
        /// <para>
        /// Indicates a preference to avoid roads that may be subject to seasonal closures where
        /// possible. These roads may still be included if no reasonable year-round alternative
        /// exists.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? SeasonalClosure
        {
            get { return this._seasonalClosure; }
            set { this._seasonalClosure = value; }
        }

        // Check to see if SeasonalClosure property is set
        internal bool IsSetSeasonalClosure()
        {
            return this._seasonalClosure.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TollRoads. 
        /// <para>
        /// Indicates a preference to avoid toll roads where possible. If a viable route cannot
        /// be calculated without using toll roads, they may still be included.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? TollRoads
        {
            get { return this._tollRoads; }
            set { this._tollRoads = value; }
        }

        // Check to see if TollRoads property is set
        internal bool IsSetTollRoads()
        {
            return this._tollRoads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TollTransponders. 
        /// <para>
        /// Indicates a preference to avoid roads that require electronic toll collection transponders
        /// where possible. These roads may still be included if no viable alternative route exists.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? TollTransponders
        {
            get { return this._tollTransponders; }
            set { this._tollTransponders = value; }
        }

        // Check to see if TollTransponders property is set
        internal bool IsSetTollTransponders()
        {
            return this._tollTransponders.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TruckRoadTypes. 
        /// <para>
        /// For truck travel modes, indicates specific road classification types in Sweden (<c>
        /// BK1</c> through <c>BK4</c>) and Mexico (<c>A2, A4, B2, B4, C, D, ET2, ET4</c>) to
        /// avoid where possible. These road types may still be used if no reasonable alternative
        /// exists.
        /// </para>
        ///  <note> 
        /// <para>
        /// There are currently no other supported values as of 26th April 2024.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public List<string> TruckRoadTypes
        {
            get { return this._truckRoadTypes; }
            set { this._truckRoadTypes = value; }
        }

        // Check to see if TruckRoadTypes property is set
        internal bool IsSetTruckRoadTypes()
        {
            return this._truckRoadTypes != null && (this._truckRoadTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tunnels. 
        /// <para>
        /// Indicates a preference to avoid tunnels where possible. If a viable route cannot be
        /// calculated without using tunnels, they may still be included.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? Tunnels
        {
            get { return this._tunnels; }
            set { this._tunnels = value; }
        }

        // Check to see if Tunnels property is set
        internal bool IsSetTunnels()
        {
            return this._tunnels.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UTurns. 
        /// <para>
        /// Indicates a preference to avoid U-turns where possible. U-turns may still be included
        /// if necessary to reach certain areas or when no reasonable alternative exists.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public bool? UTurns
        {
            get { return this._uTurns; }
            set { this._uTurns = value; }
        }

        // Check to see if UTurns property is set
        internal bool IsSetUTurns()
        {
            return this._uTurns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ZoneCategories. 
        /// <para>
        /// Indicates types of regulated zones (such as congestion pricing or environmental zones)
        /// to avoid where possible. Routes may still pass through these zones if no reasonable
        /// alternative exists.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<IsolineAvoidanceZoneCategory> ZoneCategories
        {
            get { return this._zoneCategories; }
            set { this._zoneCategories = value; }
        }

        // Check to see if ZoneCategories property is set
        internal bool IsSetZoneCategories()
        {
            return this._zoneCategories != null && (this._zoneCategories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}