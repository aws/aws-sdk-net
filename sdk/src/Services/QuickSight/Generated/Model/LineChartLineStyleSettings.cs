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
    /// Line styles options for a line series in <code>LineChartVisual</code>.
    /// </summary>
    public partial class LineChartLineStyleSettings
    {
        private LineInterpolation _lineInterpolation;
        private LineChartLineStyle _lineStyle;
        private Visibility _lineVisibility;
        private string _lineWidth;

        /// <summary>
        /// Gets and sets the property LineInterpolation. 
        /// <para>
        /// Interpolation style for line series.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>LINEAR</code>: Show as default, linear style.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMOOTH</code>: Show as a smooth curve.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STEPPED</code>: Show steps in line.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineInterpolation LineInterpolation
        {
            get { return this._lineInterpolation; }
            set { this._lineInterpolation = value; }
        }

        // Check to see if LineInterpolation property is set
        internal bool IsSetLineInterpolation()
        {
            return this._lineInterpolation != null;
        }

        /// <summary>
        /// Gets and sets the property LineStyle. 
        /// <para>
        /// Line style for line series.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SOLID</code>: Show as a solid line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DOTTED</code>: Show as a dotted line.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DASHED</code>: Show as a dashed line.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public LineChartLineStyle LineStyle
        {
            get { return this._lineStyle; }
            set { this._lineStyle = value; }
        }

        // Check to see if LineStyle property is set
        internal bool IsSetLineStyle()
        {
            return this._lineStyle != null;
        }

        /// <summary>
        /// Gets and sets the property LineVisibility. 
        /// <para>
        /// Configuration option that determines whether to show the line for the series.
        /// </para>
        /// </summary>
        public Visibility LineVisibility
        {
            get { return this._lineVisibility; }
            set { this._lineVisibility = value; }
        }

        // Check to see if LineVisibility property is set
        internal bool IsSetLineVisibility()
        {
            return this._lineVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property LineWidth. 
        /// <para>
        /// Width that determines the line thickness.
        /// </para>
        /// </summary>
        public string LineWidth
        {
            get { return this._lineWidth; }
            set { this._lineWidth = value; }
        }

        // Check to see if LineWidth property is set
        internal bool IsSetLineWidth()
        {
            return this._lineWidth != null;
        }

    }
}