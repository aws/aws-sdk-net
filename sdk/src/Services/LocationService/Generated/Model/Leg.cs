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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Contains the calculated route's details for each path between a pair of positions.
    /// The number of legs returned corresponds to one fewer than the total number of positions
    /// in the request. 
    /// 
    ///  
    /// <para>
    /// For example, a route with a departure position and destination position returns one
    /// leg with the positions <a href="https://docs.aws.amazon.com/location/previous/developerguide/snap-to-nearby-road.html">snapped
    /// to a nearby road</a>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>StartPosition</c> is the departure position.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>EndPosition</c> is the destination position.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// A route with a waypoint between the departure and destination position returns two
    /// legs with the positions snapped to a nearby road:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Leg 1: The <c>StartPosition</c> is the departure position . The <c>EndPosition</c>
    /// is the waypoint positon.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Leg 2: The <c>StartPosition</c> is the waypoint position. The <c>EndPosition</c> is
    /// the destination position.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class Leg
    {
        private double? _distance;
        private double? _durationSeconds;
        private List<double> _endPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private LegGeometry _geometry;
        private List<double> _startPosition = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<Step> _steps = AWSConfigs.InitializeCollections ? new List<Step>() : null;

        /// <summary>
        /// Gets and sets the property Distance. 
        /// <para>
        /// The distance between the leg's <c>StartPosition</c> and <c>EndPosition</c> along a
        /// calculated route. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The default measurement is <c>Kilometers</c> unless the request specifies a <c>DistanceUnit</c>
        /// of <c>Miles</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? Distance
        {
            get { return this._distance; }
            set { this._distance = value; }
        }

        // Check to see if Distance property is set
        internal bool IsSetDistance()
        {
            return this._distance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The estimated travel time between the leg's <c>StartPosition</c> and <c>EndPosition</c>.
        /// The travel mode and departure time that you specify in the request determines the
        /// calculated time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public double? DurationSeconds
        {
            get { return this._durationSeconds; }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndPosition. 
        /// <para>
        /// The terminating position of the leg. Follows the format <c>[longitude,latitude]</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the <c>EndPosition</c> isn't located on a road, it's <a href="https://docs.aws.amazon.com/location/previous/developerguide/nap-to-nearby-road.html">snapped
        /// to a nearby road</a>. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> EndPosition
        {
            get { return this._endPosition; }
            set { this._endPosition = value; }
        }

        // Check to see if EndPosition property is set
        internal bool IsSetEndPosition()
        {
            return this._endPosition != null && (this._endPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Geometry. 
        /// <para>
        /// Contains the calculated route's path as a linestring geometry.
        /// </para>
        /// </summary>
        public LegGeometry Geometry
        {
            get { return this._geometry; }
            set { this._geometry = value; }
        }

        // Check to see if Geometry property is set
        internal bool IsSetGeometry()
        {
            return this._geometry != null;
        }

        /// <summary>
        /// Gets and sets the property StartPosition. 
        /// <para>
        /// The starting position of the leg. Follows the format <c>[longitude,latitude]</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the <c>StartPosition</c> isn't located on a road, it's <a href="https://docs.aws.amazon.com/location/previous/developerguide/snap-to-nearby-road.html">snapped
        /// to a nearby road</a>. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=2, Max=2)]
        public List<double> StartPosition
        {
            get { return this._startPosition; }
            set { this._startPosition = value; }
        }

        // Check to see if StartPosition property is set
        internal bool IsSetStartPosition()
        {
            return this._startPosition != null && (this._startPosition.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Steps. 
        /// <para>
        /// Contains a list of steps, which represent subsections of a leg. Each step provides
        /// instructions for how to move to the next step in the leg such as the step's start
        /// position, end position, travel distance, travel duration, and geometry offset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Step> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}