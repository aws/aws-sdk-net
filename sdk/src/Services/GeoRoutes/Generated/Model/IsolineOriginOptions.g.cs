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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Options that control how the origin point is interpreted when calculating reachable
    /// areas. These options affect which roads are considered accessible from the starting
    /// point and how initial routing decisions are made.
    /// </summary>
    public partial class IsolineOriginOptions
    {
        /// <summary>
        /// Gets and sets the property AvoidActionsForDistance. 
        /// <para>
        /// The distance in meters from the origin point within which certain routing actions
        /// (such as U-turns or left turns across traffic) are restricted. This helps generate
        /// more practical routes by avoiding potentially dangerous maneuvers near the starting
        /// point.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? AvoidActionsForDistance { get; set; }

        /// <summary>
        /// Checks to see if the AvoidActionsForDistance property is set.
        /// </summary>
        internal bool IsSetAvoidActionsForDistance() => this.AvoidActionsForDistance.HasValue;

        /// <summary>
        /// Gets and sets the property Heading. 
        /// <para>
        /// Initial direction of travel in degrees (0-360, where 0 is north). This affects which
        /// road segments are considered accessible from the starting point and is particularly
        /// useful when the origin is on a divided road or at a complex intersection.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 360)]
        public double? Heading { get; set; }

        /// <summary>
        /// Checks to see if the Heading property is set.
        /// </summary>
        internal bool IsSetHeading() => this.Heading.HasValue;

        /// <summary>
        /// Gets and sets the property Matching. 
        /// <para>
        /// Controls how the origin point is matched to the road network, including search radius
        /// and matching strategy.
        /// </para>
        /// </summary>
        public IsolineMatchingOptions Matching { get; set; }

        /// <summary>
        /// Checks to see if the Matching property is set.
        /// </summary>
        internal bool IsSetMatching() => this.Matching != null;

        /// <summary>
        /// Gets and sets the property SideOfStreet. 
        /// <para>
        /// Controls which side of the street is considered accessible from the origin point,
        /// particularly important for divided roads where building entrances or parking access
        /// may only be available from one direction.
        /// </para>
        /// </summary>
        public IsolineSideOfStreetOptions SideOfStreet { get; set; }

        /// <summary>
        /// Checks to see if the SideOfStreet property is set.
        /// </summary>
        internal bool IsSetSideOfStreet() => this.SideOfStreet != null;
    }
}
