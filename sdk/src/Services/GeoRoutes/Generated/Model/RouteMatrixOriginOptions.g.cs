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
    /// Origin related options.
    /// </summary>
    public partial class RouteMatrixOriginOptions
    {
        /// <summary>
        /// Gets and sets the property AvoidActionsForDistance. 
        /// <para>
        /// Avoids actions for the provided distance. This is typically to consider for users
        /// in moving vehicles who may not have sufficient time to make an action at an origin
        /// or a destination.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public long? AvoidActionsForDistance { get; set; }

        /// <summary>
        /// Checks to see if the AvoidActionsForDistance property is set.
        /// </summary>
        internal bool IsSetAvoidActionsForDistance() => this.AvoidActionsForDistance.HasValue;

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
        public RouteMatrixMatchingOptions Matching { get; set; }

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
        public RouteMatrixSideOfStreetOptions SideOfStreet { get; set; }

        /// <summary>
        /// Checks to see if the SideOfStreet property is set.
        /// </summary>
        internal bool IsSetSideOfStreet() => this.SideOfStreet != null;
    }
}
