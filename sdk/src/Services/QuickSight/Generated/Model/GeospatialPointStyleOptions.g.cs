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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The point style of the geospatial map.
    /// </summary>
    public partial class GeospatialPointStyleOptions
    {
        /// <summary>
        /// Gets and sets the property ClusterMarkerConfiguration. 
        /// <para>
        /// The cluster marker configuration of the geospatial point style.
        /// </para>
        /// </summary>
        public ClusterMarkerConfiguration ClusterMarkerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ClusterMarkerConfiguration property is set.
        /// </summary>
        internal bool IsSetClusterMarkerConfiguration() => this.ClusterMarkerConfiguration != null;

        /// <summary>
        /// Gets and sets the property HeatmapConfiguration. 
        /// <para>
        /// The heatmap configuration of the geospatial point style.
        /// </para>
        /// </summary>
        public GeospatialHeatmapConfiguration HeatmapConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the HeatmapConfiguration property is set.
        /// </summary>
        internal bool IsSetHeatmapConfiguration() => this.HeatmapConfiguration != null;

        /// <summary>
        /// Gets and sets the property SelectedPointStyle. 
        /// <para>
        /// The selected point styles (point, cluster) of the geospatial map.
        /// </para>
        /// </summary>
        public GeospatialSelectedPointStyle SelectedPointStyle { get; set; }

        /// <summary>
        /// Checks to see if the SelectedPointStyle property is set.
        /// </summary>
        internal bool IsSetSelectedPointStyle() => this.SelectedPointStyle != null;
    }
}
