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
    /// Specifies options for areas to avoid. This is a best-effort avoidance setting, meaning
    /// the router will try to honor the avoidance preferences but may still include restricted
    /// areas if no feasible alternative route exists. If avoidance options are not followed,
    /// the response will indicate that the avoidance criteria were violated.
    /// </summary>
    public partial class WaypointOptimizationAvoidanceOptions
    {
        private List<WaypointOptimizationAvoidanceArea> _areas = AWSConfigs.InitializeCollections ? new List<WaypointOptimizationAvoidanceArea>() : null;
        private bool? _carShuttleTrains;
        private bool? _controlledAccessHighways;
        private bool? _dirtRoads;
        private bool? _ferries;
        private bool? _tollRoads;
        private bool? _tunnels;
        private bool? _uTurns;

        /// <summary>
        /// Gets and sets the property Areas. 
        /// <para>
        /// Areas to be avoided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<WaypointOptimizationAvoidanceArea> Areas
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
        /// Avoidance options for cars-shuttles-trains.
        /// </para>
        /// </summary>
        public bool CarShuttleTrains
        {
            get { return this._carShuttleTrains.GetValueOrDefault(); }
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
        /// Avoid controlled access highways while calculating the route.
        /// </para>
        /// </summary>
        public bool ControlledAccessHighways
        {
            get { return this._controlledAccessHighways.GetValueOrDefault(); }
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
        /// Avoid dirt roads while calculating the route.
        /// </para>
        /// </summary>
        public bool DirtRoads
        {
            get { return this._dirtRoads.GetValueOrDefault(); }
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
        /// Avoidance options for ferries.
        /// </para>
        /// </summary>
        public bool Ferries
        {
            get { return this._ferries.GetValueOrDefault(); }
            set { this._ferries = value; }
        }

        // Check to see if Ferries property is set
        internal bool IsSetFerries()
        {
            return this._ferries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TollRoads. 
        /// <para>
        /// Avoids roads where the specified toll transponders are the only mode of payment.
        /// </para>
        /// </summary>
        public bool TollRoads
        {
            get { return this._tollRoads.GetValueOrDefault(); }
            set { this._tollRoads = value; }
        }

        // Check to see if TollRoads property is set
        internal bool IsSetTollRoads()
        {
            return this._tollRoads.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tunnels. 
        /// <para>
        /// Avoid tunnels while calculating the route.
        /// </para>
        /// </summary>
        public bool Tunnels
        {
            get { return this._tunnels.GetValueOrDefault(); }
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
        /// Avoid U-turns for calculation on highways and motorways.
        /// </para>
        /// </summary>
        public bool UTurns
        {
            get { return this._uTurns.GetValueOrDefault(); }
            set { this._uTurns = value; }
        }

        // Check to see if UTurns property is set
        internal bool IsSetUTurns()
        {
            return this._uTurns.HasValue; 
        }

    }
}