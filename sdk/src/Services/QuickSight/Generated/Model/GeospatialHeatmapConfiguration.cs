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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// The heatmap configuration of the geospatial point style.
    /// </summary>
    public partial class GeospatialHeatmapConfiguration
    {
        private GeospatialHeatmapColorScale _heatmapColor;

        /// <summary>
        /// Gets and sets the property HeatmapColor. 
        /// <para>
        /// The color scale specification for the heatmap point style.
        /// </para>
        /// </summary>
        public GeospatialHeatmapColorScale HeatmapColor
        {
            get { return this._heatmapColor; }
            set { this._heatmapColor = value; }
        }

        // Check to see if HeatmapColor property is set
        internal bool IsSetHeatmapColor()
        {
            return this._heatmapColor != null;
        }

    }
}