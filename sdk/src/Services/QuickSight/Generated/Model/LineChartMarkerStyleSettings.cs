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
    /// Marker styles options for a line series in <code>LineChartVisual</code>.
    /// </summary>
    public partial class LineChartMarkerStyleSettings
    {
        private string _markerColor;
        private LineChartMarkerShape _markerShape;
        private string _markerSize;
        private Visibility _markerVisibility;

        /// <summary>
        /// Gets and sets the property MarkerColor. 
        /// <para>
        /// Color of marker in the series.
        /// </para>
        /// </summary>
        public string MarkerColor
        {
            get { return this._markerColor; }
            set { this._markerColor = value; }
        }

        // Check to see if MarkerColor property is set
        internal bool IsSetMarkerColor()
        {
            return this._markerColor != null;
        }

        /// <summary>
        /// Gets and sets the property MarkerShape. 
        /// <para>
        /// Shape option for markers in the series.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CIRCLE</code>: Show marker as a circle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TRIANGLE</code>: Show marker as a triangle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SQUARE</code>: Show marker as a square.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DIAMOND</code>: Show marker as a diamond.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ROUNDED_SQUARE</code>: Show marker as a rounded square.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineChartMarkerShape MarkerShape
        {
            get { return this._markerShape; }
            set { this._markerShape = value; }
        }

        // Check to see if MarkerShape property is set
        internal bool IsSetMarkerShape()
        {
            return this._markerShape != null;
        }

        /// <summary>
        /// Gets and sets the property MarkerSize. 
        /// <para>
        /// Size of marker in the series.
        /// </para>
        /// </summary>
        public string MarkerSize
        {
            get { return this._markerSize; }
            set { this._markerSize = value; }
        }

        // Check to see if MarkerSize property is set
        internal bool IsSetMarkerSize()
        {
            return this._markerSize != null;
        }

        /// <summary>
        /// Gets and sets the property MarkerVisibility. 
        /// <para>
        /// Configuration option that determines whether to show the markers in the series.
        /// </para>
        /// </summary>
        public Visibility MarkerVisibility
        {
            get { return this._markerVisibility; }
            set { this._markerVisibility = value; }
        }

        // Check to see if MarkerVisibility property is set
        internal bool IsSetMarkerVisibility()
        {
            return this._markerVisibility != null;
        }

    }
}