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
    /// <c>AutoCircle</c> requests the route matrix service to define a <c>Circle</c> boundary
    /// that best attempts to include most waypoints (<c>Origins</c> and <c>Destinations</c>)
    /// using the <c>AutoCircle</c> settings. Any waypoints outside of the auto-defined <c>Circle</c>
    /// boundary will be considered out of the routing boundary, which results in a route
    /// matrix entry error.
    /// 
    ///  
    /// <para>
    ///  <c>AutoCircle</c> is only used in the request to configure a <c>Circle</c> for the
    /// route calculation. The derived <c>Circle</c> will also be provided in the response.
    /// </para>
    /// </summary>
    public partial class RouteMatrixAutoCircle
    {
        private long? _margin;
        private long? _maxRadius;

        /// <summary>
        /// Gets and sets the property Margin. 
        /// <para>
        /// The minimal distance, in meters, between any waypoint and the perimeter of the circle
        /// auto-defined for the boundary. Some margin is usually recommended so that the routing
        /// has enough leeway to travel from one waypoint to another optimally without conflicting
        /// with the routing boundary.
        /// </para>
        ///  
        /// <para>
        /// The total of <c>MaxRadius</c> and <c>Margin</c> must be less than or equal to 200,000
        /// meters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200000)]
        public long? Margin
        {
            get { return this._margin; }
            set { this._margin = value; }
        }

        // Check to see if Margin property is set
        internal bool IsSetMargin()
        {
            return this._margin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRadius. 
        /// <para>
        /// The maximum radius, in meters, that the auto-defined <c>Circle</c> boundary should
        /// have, before the <c>Margin</c> distance is added to the circle.
        /// </para>
        ///  
        /// <para>
        /// The total of <c>MaxRadius</c> and <c>Margin</c> must be less than or equal to 200,000
        /// meters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=200000)]
        public long? MaxRadius
        {
            get { return this._maxRadius; }
            set { this._maxRadius = value; }
        }

        // Check to see if MaxRadius property is set
        internal bool IsSetMaxRadius()
        {
            return this._maxRadius.HasValue; 
        }

    }
}