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
    /// Options that control how the destination point is interpreted and matched to the road
    /// network when calculating reachable areas. This affects which roads are considered
    /// accessible near the destination and how the final approach is calculated.
    /// </summary>
    public partial class IsolineDestinationOptions
    {
        private long? _avoidActionsForDistance;
        private double? _heading;
        private IsolineMatchingOptions _matching;
        private IsolineSideOfStreetOptions _sideOfStreet;

        /// <summary>
        /// Gets and sets the property AvoidActionsForDistance. 
        /// <para>
        /// The distance in meters from the destination point within which certain routing actions
        /// (such as U-turns or left turns across traffic) are restricted. This helps generate
        /// more practical routes by avoiding potentially dangerous maneuvers near the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4294967295)]
        public long? AvoidActionsForDistance
        {
            get { return this._avoidActionsForDistance; }
            set { this._avoidActionsForDistance = value; }
        }

        // Check to see if AvoidActionsForDistance property is set
        internal bool IsSetAvoidActionsForDistance()
        {
            return this._avoidActionsForDistance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Heading. 
        /// <para>
        /// The initial direction of travel in degrees (0-360, where 0 is north). This can affect
        /// which road segments are considered accessible from the starting point.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=360)]
        public double? Heading
        {
            get { return this._heading; }
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
        /// Controls how the destination point is matched to the road network, including search
        /// radius and name-based matching preferences.
        /// </para>
        /// </summary>
        public IsolineMatchingOptions Matching
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
        /// Gets and sets the property SideOfStreet. 
        /// <para>
        /// Specifies which side of the street should be considered accessible, which is important
        /// when building entrances or parking access points are only reachable from one side
        /// of the road.
        /// </para>
        /// </summary>
        public IsolineSideOfStreetOptions SideOfStreet
        {
            get { return this._sideOfStreet; }
            set { this._sideOfStreet = value; }
        }

        // Check to see if SideOfStreet property is set
        internal bool IsSetSideOfStreet()
        {
            return this._sideOfStreet != null;
        }

    }
}