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
    /// Marker styles options for a line series in <c>LineChartVisual</c>.
    /// </summary>
    public partial class LineChartMarkerStyleSettings
    {
        /// <summary>
        /// Gets and sets the property MarkerColor. 
        /// <para>
        /// Color of marker in the series.
        /// </para>
        /// </summary>
        public string MarkerColor { get; set; }

        /// <summary>
        /// Checks to see if the MarkerColor property is set.
        /// </summary>
        internal bool IsSetMarkerColor() => this.MarkerColor != null;

        /// <summary>
        /// Gets and sets the property MarkerShape. 
        /// <para>
        /// Shape option for markers in the series.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CIRCLE</c>: Show marker as a circle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRIANGLE</c>: Show marker as a triangle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SQUARE</c>: Show marker as a square.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIAMOND</c>: Show marker as a diamond.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROUNDED_SQUARE</c>: Show marker as a rounded square.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineChartMarkerShape MarkerShape { get; set; }

        /// <summary>
        /// Checks to see if the MarkerShape property is set.
        /// </summary>
        internal bool IsSetMarkerShape() => this.MarkerShape != null;

        /// <summary>
        /// Gets and sets the property MarkerSize. 
        /// <para>
        /// Size of marker in the series.
        /// </para>
        /// </summary>
        public string MarkerSize { get; set; }

        /// <summary>
        /// Checks to see if the MarkerSize property is set.
        /// </summary>
        internal bool IsSetMarkerSize() => this.MarkerSize != null;

        /// <summary>
        /// Gets and sets the property MarkerVisibility. 
        /// <para>
        /// Configuration option that determines whether to show the markers in the series.
        /// </para>
        /// </summary>
        public Visibility MarkerVisibility { get; set; }

        /// <summary>
        /// Checks to see if the MarkerVisibility property is set.
        /// </summary>
        internal bool IsSetMarkerVisibility() => this.MarkerVisibility != null;
    }
}
