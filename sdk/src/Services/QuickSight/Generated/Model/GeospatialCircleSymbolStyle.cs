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
    /// The properties for a circle symbol style.
    /// </summary>
    public partial class GeospatialCircleSymbolStyle
    {
        private GeospatialCircleRadius _circleRadius;
        private GeospatialColor _fillColor;
        private GeospatialColor _strokeColor;
        private GeospatialLineWidth _strokeWidth;

        /// <summary>
        /// Gets and sets the property CircleRadius. 
        /// <para>
        /// The radius of the circle.
        /// </para>
        /// </summary>
        public GeospatialCircleRadius CircleRadius
        {
            get { return this._circleRadius; }
            set { this._circleRadius = value; }
        }

        // Check to see if CircleRadius property is set
        internal bool IsSetCircleRadius()
        {
            return this._circleRadius != null;
        }

        /// <summary>
        /// Gets and sets the property FillColor. 
        /// <para>
        /// The color and opacity values for the fill color.
        /// </para>
        /// </summary>
        public GeospatialColor FillColor
        {
            get { return this._fillColor; }
            set { this._fillColor = value; }
        }

        // Check to see if FillColor property is set
        internal bool IsSetFillColor()
        {
            return this._fillColor != null;
        }

        /// <summary>
        /// Gets and sets the property StrokeColor. 
        /// <para>
        /// The color and opacity values for the stroke color.
        /// </para>
        /// </summary>
        public GeospatialColor StrokeColor
        {
            get { return this._strokeColor; }
            set { this._strokeColor = value; }
        }

        // Check to see if StrokeColor property is set
        internal bool IsSetStrokeColor()
        {
            return this._strokeColor != null;
        }

        /// <summary>
        /// Gets and sets the property StrokeWidth. 
        /// <para>
        /// The width of the stroke (border).
        /// </para>
        /// </summary>
        public GeospatialLineWidth StrokeWidth
        {
            get { return this._strokeWidth; }
            set { this._strokeWidth = value; }
        }

        // Check to see if StrokeWidth property is set
        internal bool IsSetStrokeWidth()
        {
            return this._strokeWidth != null;
        }

    }
}