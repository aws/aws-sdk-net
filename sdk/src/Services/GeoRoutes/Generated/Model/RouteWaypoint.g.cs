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
    /// Waypoint between the Origin and Destination.
    /// </summary>
    public partial class RouteWaypoint
    {
        /// <summary>
        /// Gets and sets the property AvoidActionsForDistance. 
        /// <para>
        ///  Avoids actions for the provided distance. This is typically to consider for users
        /// in moving vehicles who may not have sufficient time to make an action at an origin
        /// or a destination. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
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
        ///  Avoid U-turns for calculation on highways and motorways. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
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
        ///  GPS Heading at the position. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
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
        ///  Options to configure matching the provided position to the road network. Not supported
        /// in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        public RouteMatchingOptions Matching { get; set; }

        /// <summary>
        /// Checks to see if the Matching property is set.
        /// </summary>
        internal bool IsSetMatching() => this.Matching != null;

        /// <summary>
        /// Gets and sets the property PassThrough. 
        /// <para>
        ///  If the waypoint should not be treated as a stop. If yes, the waypoint is passed through
        /// and doesn't split the route into different legs. Not supported in <c>ap-southeast-1</c>
        /// and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public bool? PassThrough { get; set; }

        /// <summary>
        /// Checks to see if the PassThrough property is set.
        /// </summary>
        internal bool IsSetPassThrough() => this.PassThrough.HasValue;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Position in World Geodetic System (WGS 84) format: [longitude, latitude].
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 2)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SideOfStreet. 
        /// <para>
        ///  Options to configure matching the provided position to a side of the street. Not
        /// supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c> regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
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
        ///  Duration of the stop. Not supported in <c>ap-southeast-1</c> and <c>ap-southeast-5</c>
        /// regions for <a href="https://docs.aws.amazon.com/location/latest/developerguide/GrabMaps.html">GrabMaps</a>
        /// customers. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Unit</b>: <c>seconds</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 49999)]
        public long? StopDuration { get; set; }

        /// <summary>
        /// Checks to see if the StopDuration property is set.
        /// </summary>
        internal bool IsSetStopDuration() => this.StopDuration.HasValue;
    }
}
