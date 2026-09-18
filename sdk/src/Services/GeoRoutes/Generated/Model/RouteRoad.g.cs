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
    /// The road on the route.
    /// </summary>
    public partial class RouteRoad
    {
        /// <summary>
        /// Gets and sets the property RoadName. 
        /// <para>
        /// Name of the road (localized).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<LocalizedString> RoadName { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;

        /// <summary>
        /// Checks to see if the RoadName property is set.
        /// </summary>
        internal bool IsSetRoadName() => this.RoadName != null && (this.RoadName.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RouteNumber. 
        /// <para>
        /// Route number of the road.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<RouteNumber> RouteNumber { get; set; } = AWSConfigs.InitializeCollections ? new List<RouteNumber>() : null;

        /// <summary>
        /// Checks to see if the RouteNumber property is set.
        /// </summary>
        internal bool IsSetRouteNumber() => this.RouteNumber != null && (this.RouteNumber.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Towards. 
        /// <para>
        /// Names of destinations that can be reached when traveling on the road.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<LocalizedString> Towards { get; set; } = AWSConfigs.InitializeCollections ? new List<LocalizedString>() : null;

        /// <summary>
        /// Checks to see if the Towards property is set.
        /// </summary>
        internal bool IsSetTowards() => this.Towards != null && (this.Towards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of road.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteRoadType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
