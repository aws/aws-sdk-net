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
    /// The properties for a circle symbol style.
    /// </summary>
    public partial class GeospatialCircleSymbolStyle
    {
        /// <summary>
        /// Gets and sets the property CircleRadius. 
        /// <para>
        /// The radius of the circle.
        /// </para>
        /// </summary>
        public GeospatialCircleRadius CircleRadius { get; set; }

        /// <summary>
        /// Checks to see if the CircleRadius property is set.
        /// </summary>
        internal bool IsSetCircleRadius() => this.CircleRadius != null;

        /// <summary>
        /// Gets and sets the property FillColor. 
        /// <para>
        /// The color and opacity values for the fill color.
        /// </para>
        /// </summary>
        public GeospatialColor FillColor { get; set; }

        /// <summary>
        /// Checks to see if the FillColor property is set.
        /// </summary>
        internal bool IsSetFillColor() => this.FillColor != null;

        /// <summary>
        /// Gets and sets the property StrokeColor. 
        /// <para>
        /// The color and opacity values for the stroke color.
        /// </para>
        /// </summary>
        public GeospatialColor StrokeColor { get; set; }

        /// <summary>
        /// Checks to see if the StrokeColor property is set.
        /// </summary>
        internal bool IsSetStrokeColor() => this.StrokeColor != null;

        /// <summary>
        /// Gets and sets the property StrokeWidth. 
        /// <para>
        /// The width of the stroke (border).
        /// </para>
        /// </summary>
        public GeospatialLineWidth StrokeWidth { get; set; }

        /// <summary>
        /// Checks to see if the StrokeWidth property is set.
        /// </summary>
        internal bool IsSetStrokeWidth() => this.StrokeWidth != null;
    }
}
