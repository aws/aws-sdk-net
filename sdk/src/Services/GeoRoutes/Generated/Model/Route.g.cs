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
    /// The route.
    /// </summary>
    public partial class Route
    {
        /// <summary>
        /// Gets and sets the property Legs. 
        /// <para>
        /// A leg is a section of a route from one waypoint to the next. A leg could be of type
        /// Vehicle, Pedestrian or Ferry. Legs of different types could occur together within
        /// a single route. For example, a car employing the use of a Ferry will contain Vehicle
        /// legs corresponding to journey on land, and Ferry legs corresponding to the journey
        /// via Ferry.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteLeg> Legs { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteLeg>() : null;

        /// <summary>
        /// Checks to see if the Legs property is set.
        /// </summary>
        internal bool IsSetLegs() => this.Legs != null && (this.Legs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MajorRoadLabels. 
        /// <para>
        /// Important labels including names and route numbers that differentiate the current
        /// route from the alternatives presented.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2)]
        public List<RouteMajorRoadLabel> MajorRoadLabels { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteMajorRoadLabel>() : null;

        /// <summary>
        /// Checks to see if the MajorRoadLabels property is set.
        /// </summary>
        internal bool IsSetMajorRoadLabels() => this.MajorRoadLabels != null && (this.MajorRoadLabels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// Summarized details of the leg.
        /// </para>
        /// </summary>
        public RouteSummary Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;
    }
}
