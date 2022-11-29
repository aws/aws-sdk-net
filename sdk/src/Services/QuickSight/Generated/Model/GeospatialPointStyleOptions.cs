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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The point style of the geospatial map.
    /// </summary>
    public partial class GeospatialPointStyleOptions
    {
        private ClusterMarkerConfiguration _clusterMarkerConfiguration;
        private GeospatialSelectedPointStyle _selectedPointStyle;

        /// <summary>
        /// Gets and sets the property ClusterMarkerConfiguration. 
        /// <para>
        /// The cluster marker configuration of the geospatial point style.
        /// </para>
        /// </summary>
        public ClusterMarkerConfiguration ClusterMarkerConfiguration
        {
            get { return this._clusterMarkerConfiguration; }
            set { this._clusterMarkerConfiguration = value; }
        }

        // Check to see if ClusterMarkerConfiguration property is set
        internal bool IsSetClusterMarkerConfiguration()
        {
            return this._clusterMarkerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SelectedPointStyle. 
        /// <para>
        /// The selected point styles (point, cluster) of the geospatial map.
        /// </para>
        /// </summary>
        public GeospatialSelectedPointStyle SelectedPointStyle
        {
            get { return this._selectedPointStyle; }
            set { this._selectedPointStyle = value; }
        }

        // Check to see if SelectedPointStyle property is set
        internal bool IsSetSelectedPointStyle()
        {
            return this._selectedPointStyle != null;
        }

    }
}