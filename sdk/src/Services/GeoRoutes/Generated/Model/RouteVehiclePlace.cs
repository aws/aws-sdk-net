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
    /// Place details corresponding to the arrival or departure.
    /// </summary>
    public partial class RouteVehiclePlace
    {
        private string _name;
        private List<double> _originalPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<double> _position = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private RouteSideOfStreet _sideOfStreet;
        private int? _waypointIndex;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the place.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalPosition. 
        /// <para>
        /// Position provided in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=2, Max=3)]
        public List<double> OriginalPosition
        {
            get { return this._originalPosition; }
            set { this._originalPosition = value; }
        }

        // Check to see if OriginalPosition property is set
        internal bool IsSetOriginalPosition()
        {
            return this._originalPosition != null && (this._originalPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Position defined as <c>[longitude, latitude]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=3)]
        public List<double> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && (this._position.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SideOfStreet. 
        /// <para>
        /// Options to configure matching the provided position to a side of the street.
        /// </para>
        /// </summary>
        public RouteSideOfStreet SideOfStreet
        {
            get { return this._sideOfStreet; }
            set { this._sideOfStreet = value; }
        }

        // Check to see if SideOfStreet property is set
        internal bool IsSetSideOfStreet()
        {
            return this._sideOfStreet != null;
        }

        /// <summary>
        /// Gets and sets the property WaypointIndex. 
        /// <para>
        /// Index of the waypoint in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int WaypointIndex
        {
            get { return this._waypointIndex.GetValueOrDefault(); }
            set { this._waypointIndex = value; }
        }

        // Check to see if WaypointIndex property is set
        internal bool IsSetWaypointIndex()
        {
            return this._waypointIndex.HasValue; 
        }

    }
}