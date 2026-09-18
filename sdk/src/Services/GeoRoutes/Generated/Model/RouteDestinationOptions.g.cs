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
    /// Options related to the destination.
    /// </summary>
    public partial class RouteDestinationOptions
    {
        /// <summary>
        /// Gets and sets the property AvoidActionsForDistance. 
        /// <para>
        /// The distance in meters from the destination point within which certain routing actions
        /// (such as U-turns or left turns across traffic) are restricted. This helps generate
        /// more practical routes by avoiding potentially dangerous maneuvers near the endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 2000)]
        public long? AvoidActionsForDistance { get; set; }

        /// <summary>
        /// Checks to see if the AvoidActionsForDistance property is set.
        /// </summary>
        internal bool IsSetAvoidActionsForDistance() => this.AvoidActionsForDistance.HasValue;

        /// <summary>
        /// Gets and sets the property AvoidUTurns. 
        /// <para>
        /// Avoid U-turns for calculation on highways and motorways.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? AvoidUTurns { get; set; }

        /// <summary>
        /// Checks to see if the AvoidUTurns property is set.
        /// </summary>
        internal bool IsSetAvoidUTurns() => this.AvoidUTurns.HasValue;

        /// <summary>
        /// Gets and sets the property Heading. 
        /// <para>
        /// GPS Heading at the position.
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
        /// Options to configure matching the provided position to the road network.
        /// </para>
        /// </summary>
        public RouteMatchingOptions Matching { get; set; }

        /// <summary>
        /// Checks to see if the Matching property is set.
        /// </summary>
        internal bool IsSetMatching() => this.Matching != null;

        /// <summary>
        /// Gets and sets the property SideOfStreet. 
        /// <para>
        /// Options to configure matching the provided position to a side of the street.
        /// </para>
        /// </summary>
        public RouteSideOfStreetOptions SideOfStreet { get; set; }

        /// <summary>
        /// Checks to see if the SideOfStreet property is set.
        /// </summary>
        internal bool IsSetSideOfStreet() => this.SideOfStreet != null;

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
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? StopDuration { get; set; }

        /// <summary>
        /// Checks to see if the StopDuration property is set.
        /// </summary>
        internal bool IsSetStopDuration() => this.StopDuration.HasValue;
    }
}
