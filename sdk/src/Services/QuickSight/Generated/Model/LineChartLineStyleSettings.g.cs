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
    /// Line styles options for a line series in <c>LineChartVisual</c>.
    /// </summary>
    public partial class LineChartLineStyleSettings
    {
        /// <summary>
        /// Gets and sets the property LineInterpolation. 
        /// <para>
        /// Interpolation style for line series.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LINEAR</c>: Show as default, linear style.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SMOOTH</c>: Show as a smooth curve.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STEPPED</c>: Show steps in line.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineInterpolation LineInterpolation { get; set; }

        /// <summary>
        /// Checks to see if the LineInterpolation property is set.
        /// </summary>
        internal bool IsSetLineInterpolation() => this.LineInterpolation != null;

        /// <summary>
        /// Gets and sets the property LineStyle. 
        /// <para>
        /// Line style for line series.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SOLID</c>: Show as a solid line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DOTTED</c>: Show as a dotted line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DASHED</c>: Show as a dashed line.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineChartLineStyle LineStyle { get; set; }

        /// <summary>
        /// Checks to see if the LineStyle property is set.
        /// </summary>
        internal bool IsSetLineStyle() => this.LineStyle != null;

        /// <summary>
        /// Gets and sets the property LineVisibility. 
        /// <para>
        /// Configuration option that determines whether to show the line for the series.
        /// </para>
        /// </summary>
        public Visibility LineVisibility { get; set; }

        /// <summary>
        /// Checks to see if the LineVisibility property is set.
        /// </summary>
        internal bool IsSetLineVisibility() => this.LineVisibility != null;

        /// <summary>
        /// Gets and sets the property LineWidth. 
        /// <para>
        /// Width that determines the line thickness.
        /// </para>
        /// </summary>
        public string LineWidth { get; set; }

        /// <summary>
        /// Checks to see if the LineWidth property is set.
        /// </summary>
        internal bool IsSetLineWidth() => this.LineWidth != null;
    }
}
