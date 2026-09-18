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
    /// Place details corresponding to the arrival or departure.
    /// </summary>
    public partial class RouteTransitPlace
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the place.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OriginalPosition. 
        /// <para>
        /// Position provided in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 2, Max = 3)]
        public List<double> OriginalPosition { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the OriginalPosition property is set.
        /// </summary>
        internal bool IsSetOriginalPosition() => this.OriginalPosition != null && (this.OriginalPosition.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Sensitive = true, Min = 2, Max = 3)]
        public List<double> Position { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the Position property is set.
        /// </summary>
        internal bool IsSetPosition() => this.Position != null && (this.Position.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StationDetails. 
        /// <para>
        /// Details about the station.
        /// </para>
        /// </summary>
        public RouteStationDetails StationDetails { get; set; }

        /// <summary>
        /// Checks to see if the StationDetails property is set.
        /// </summary>
        internal bool IsSetStationDetails() => this.StationDetails != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the place.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public RouteTransitPlaceType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WaypointIndex. 
        /// <para>
        /// Index of the waypoint in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0)]
        public int? WaypointIndex { get; set; }

        /// <summary>
        /// Checks to see if the WaypointIndex property is set.
        /// </summary>
        internal bool IsSetWaypointIndex() => this.WaypointIndex.HasValue;
    }
}
