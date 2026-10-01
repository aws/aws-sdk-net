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
    /// The options for sparklines in a table.
    /// </summary>
    public partial class SparklinesOptions
    {
        /// <summary>
        /// Gets and sets the property AllPointsMarker.
        /// </summary>
        public LineChartMarkerStyleSettings AllPointsMarker { get; set; }

        /// <summary>
        /// Checks to see if the AllPointsMarker property is set.
        /// </summary>
        internal bool IsSetAllPointsMarker() => this.AllPointsMarker != null;

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID of the value column that the sparkline is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string FieldId { get; set; }

        /// <summary>
        /// Checks to see if the FieldId property is set.
        /// </summary>
        internal bool IsSetFieldId() => this.FieldId != null;

        /// <summary>
        /// Gets and sets the property LineColor. 
        /// <para>
        /// The color of the sparkline line.
        /// </para>
        /// </summary>
        public string LineColor { get; set; }

        /// <summary>
        /// Checks to see if the LineColor property is set.
        /// </summary>
        internal bool IsSetLineColor() => this.LineColor != null;

        /// <summary>
        /// Gets and sets the property LineInterpolation. 
        /// <para>
        /// The interpolation style for the sparkline line.
        /// </para>
        /// </summary>
        public LineInterpolation LineInterpolation { get; set; }

        /// <summary>
        /// Checks to see if the LineInterpolation property is set.
        /// </summary>
        internal bool IsSetLineInterpolation() => this.LineInterpolation != null;

        /// <summary>
        /// Gets and sets the property MaxValueMarker.
        /// </summary>
        public LineChartMarkerStyleSettings MaxValueMarker { get; set; }

        /// <summary>
        /// Checks to see if the MaxValueMarker property is set.
        /// </summary>
        internal bool IsSetMaxValueMarker() => this.MaxValueMarker != null;

        /// <summary>
        /// Gets and sets the property MinValueMarker.
        /// </summary>
        public LineChartMarkerStyleSettings MinValueMarker { get; set; }

        /// <summary>
        /// Checks to see if the MinValueMarker property is set.
        /// </summary>
        internal bool IsSetMinValueMarker() => this.MinValueMarker != null;

        /// <summary>
        /// Gets and sets the property VisualType. 
        /// <para>
        /// The type of the sparkline. Valid values are <c>LINE</c> and <c>AREA_LINE</c>.
        /// </para>
        /// </summary>
        public SparklineVisualType VisualType { get; set; }

        /// <summary>
        /// Checks to see if the VisualType property is set.
        /// </summary>
        internal bool IsSetVisualType() => this.VisualType != null;

        /// <summary>
        /// Gets and sets the property XAxisField.
        /// </summary>
        [AWSProperty(Required = true)]
        public DimensionField XAxisField { get; set; }

        /// <summary>
        /// Checks to see if the XAxisField property is set.
        /// </summary>
        internal bool IsSetXAxisField() => this.XAxisField != null;

        /// <summary>
        /// Gets and sets the property YAxisBehavior. 
        /// <para>
        /// Determines whether the Y axis is shared across all sparklines or independent for each
        /// sparkline.
        /// </para>
        /// </summary>
        public SparklineAxisBehavior YAxisBehavior { get; set; }

        /// <summary>
        /// Checks to see if the YAxisBehavior property is set.
        /// </summary>
        internal bool IsSetYAxisBehavior() => this.YAxisBehavior != null;
    }
}
