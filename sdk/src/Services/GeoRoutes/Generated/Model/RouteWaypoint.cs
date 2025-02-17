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
    /// Waypoint between the Origin and Destination.
    /// </summary>
    public partial class RouteWaypoint
    {
        private long? _avoidActionsForDistance;
        private bool? _avoidUTurns;
        private double? _heading;
        private RouteMatchingOptions _matching;
        private bool? _passThrough;
        private List<double> _position = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private RouteSideOfStreetOptions _sideOfStreet;
        private long? _stopDuration;

        /// <summary>
        /// Gets and sets the property AvoidActionsForDistance. 
        /// <para>
        /// Avoids actions for the provided distance. This is typically to consider for users
        /// in moving vehicles who may not have sufficient time to make an action at an origin
        /// or a destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2000)]
        public long AvoidActionsForDistance
        {
            get { return this._avoidActionsForDistance.GetValueOrDefault(); }
            set { this._avoidActionsForDistance = value; }
        }

        // Check to see if AvoidActionsForDistance property is set
        internal bool IsSetAvoidActionsForDistance()
        {
            return this._avoidActionsForDistance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvoidUTurns. 
        /// <para>
        /// Avoid U-turns for calculation on highways and motorways.
        /// </para>
        /// </summary>
        public bool AvoidUTurns
        {
            get { return this._avoidUTurns.GetValueOrDefault(); }
            set { this._avoidUTurns = value; }
        }

        // Check to see if AvoidUTurns property is set
        internal bool IsSetAvoidUTurns()
        {
            return this._avoidUTurns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Heading. 
        /// <para>
        /// GPS Heading at the position.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=360)]
        public double Heading
        {
            get { return this._heading.GetValueOrDefault(); }
            set { this._heading = value; }
        }

        // Check to see if Heading property is set
        internal bool IsSetHeading()
        {
            return this._heading.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Matching. 
        /// <para>
        /// Options to configure matching the provided position to the road network.
        /// </para>
        /// </summary>
        public RouteMatchingOptions Matching
        {
            get { return this._matching; }
            set { this._matching = value; }
        }

        // Check to see if Matching property is set
        internal bool IsSetMatching()
        {
            return this._matching != null;
        }

        /// <summary>
        /// Gets and sets the property PassThrough. 
        /// <para>
        /// If the waypoint should not be treated as a stop. If yes, the waypoint is passed through
        /// and doesn't split the route into different legs.
        /// </para>
        /// </summary>
        public bool PassThrough
        {
            get { return this._passThrough.GetValueOrDefault(); }
            set { this._passThrough = value; }
        }

        // Check to see if PassThrough property is set
        internal bool IsSetPassThrough()
        {
            return this._passThrough.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Position defined as <c>[longitude, latitude]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
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
        public RouteSideOfStreetOptions SideOfStreet
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
        /// Gets and sets the property StopDuration. 
        /// <para>
        /// Duration of the stop.
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=4294967295)]
        public long StopDuration
        {
            get { return this._stopDuration.GetValueOrDefault(); }
            set { this._stopDuration = value; }
        }

        // Check to see if StopDuration property is set
        internal bool IsSetStopDuration()
        {
            return this._stopDuration.HasValue; 
        }

    }
}