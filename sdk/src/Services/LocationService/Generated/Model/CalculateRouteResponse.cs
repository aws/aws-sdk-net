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

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Returns the result of the route calculation. Metadata includes legs and route summary.
    /// </summary>
    public partial class CalculateRouteResponse : AmazonWebServiceResponse
    {
        private List<Leg> _legs = new List<Leg>();
        private CalculateRouteSummary _summary;

        /// <summary>
        /// Gets and sets the property Legs. 
        /// <para>
        /// Contains details about each path between a pair of positions included along a route
        /// such as: <code>StartPosition</code>, <code>EndPosition</code>, <code>Distance</code>,
        /// <code>DurationSeconds</code>, <code>Geometry</code>, and <code>Steps</code>. The number
        /// of legs returned corresponds to one fewer than the total number of positions in the
        /// request. 
        /// </para>
        ///  
        /// <para>
        /// For example, a route with a departure position and destination position returns one
        /// leg with the positions <a href="https://docs.aws.amazon.com/location/latest/developerguide/snap-to-nearby-road.html">snapped
        /// to a nearby road</a>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>StartPosition</code> is the departure position.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>EndPosition</code> is the destination position.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A route with a waypoint between the departure and destination position returns two
        /// legs with the positions snapped to a nearby road:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Leg 1: The <code>StartPosition</code> is the departure position . The <code>EndPosition</code>
        /// is the waypoint positon.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Leg 2: The <code>StartPosition</code> is the waypoint position. The <code>EndPosition</code>
        /// is the destination position.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Leg> Legs
        {
            get { return this._legs; }
            set { this._legs = value; }
        }

        // Check to see if Legs property is set
        internal bool IsSetLegs()
        {
            return this._legs != null && this._legs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Contains information about the whole route, such as: <code>RouteBBox</code>, <code>DataSource</code>,
        /// <code>Distance</code>, <code>DistanceUnit</code>, and <code>DurationSeconds</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CalculateRouteSummary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}