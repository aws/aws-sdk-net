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
    /// Represents a single reachable area calculated for a specific threshold.
    /// </summary>
    public partial class Isoline
    {
        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// Lines connecting separate parts of the reachable area that can be reached within the
        /// same threshold. These occur when areas are reachable but not contiguous, such as when
        /// separated by water or unroutable areas. When present, these lines represent actual
        /// transportation network segments (such as ferry routes or bridges) that connect the
        /// separated areas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<IsolineConnection> Connections { get; set; } = AWSConfigs.InitializeCollections ? new List<IsolineConnection>() : null;

        /// <summary>
        /// Checks to see if the Connections property is set.
        /// </summary>
        internal bool IsSetConnections() => this.Connections != null && (this.Connections.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DistanceThreshold. 
        /// <para>
        /// The travel distance in meters used to calculate this isoline, if distance-based thresholds
        /// were specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? DistanceThreshold { get; set; }

        /// <summary>
        /// Checks to see if the DistanceThreshold property is set.
        /// </summary>
        internal bool IsSetDistanceThreshold() => this.DistanceThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property Geometries. 
        /// <para>
        /// The shapes that define the reachable area, provided in the requested geometry format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<IsolineShapeGeometry> Geometries { get; set; } = AWSConfigs.InitializeCollections ? new List<IsolineShapeGeometry>() : null;

        /// <summary>
        /// Checks to see if the Geometries property is set.
        /// </summary>
        internal bool IsSetGeometries() => this.Geometries != null && (this.Geometries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TimeThreshold. 
        /// <para>
        /// The travel time in seconds used to calculate this isoline, if time-based thresholds
        /// were specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4294967295)]
        public long? TimeThreshold { get; set; }

        /// <summary>
        /// Checks to see if the TimeThreshold property is set.
        /// </summary>
        internal bool IsSetTimeThreshold() => this.TimeThreshold.HasValue;
    }
}
