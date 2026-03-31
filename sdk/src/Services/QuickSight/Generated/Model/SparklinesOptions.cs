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
    /// The options for sparklines in a table.
    /// </summary>
    public partial class SparklinesOptions
    {
        private LineChartMarkerStyleSettings _allPointsMarker;
        private string _fieldId;
        private string _lineColor;
        private LineInterpolation _lineInterpolation;
        private LineChartMarkerStyleSettings _maxValueMarker;
        private LineChartMarkerStyleSettings _minValueMarker;
        private SparklineVisualType _visualType;
        private DimensionField _xAxisField;
        private SparklineAxisBehavior _yAxisBehavior;

        /// <summary>
        /// Gets and sets the property AllPointsMarker.
        /// </summary>
        public LineChartMarkerStyleSettings AllPointsMarker
        {
            get { return this._allPointsMarker; }
            set { this._allPointsMarker = value; }
        }

        // Check to see if AllPointsMarker property is set
        internal bool IsSetAllPointsMarker()
        {
            return this._allPointsMarker != null;
        }

        /// <summary>
        /// Gets and sets the property FieldId. 
        /// <para>
        /// The field ID of the value column that the sparkline is applied to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string FieldId
        {
            get { return this._fieldId; }
            set { this._fieldId = value; }
        }

        // Check to see if FieldId property is set
        internal bool IsSetFieldId()
        {
            return this._fieldId != null;
        }

        /// <summary>
        /// Gets and sets the property LineColor. 
        /// <para>
        /// The color of the sparkline line.
        /// </para>
        /// </summary>
        public string LineColor
        {
            get { return this._lineColor; }
            set { this._lineColor = value; }
        }

        // Check to see if LineColor property is set
        internal bool IsSetLineColor()
        {
            return this._lineColor != null;
        }

        /// <summary>
        /// Gets and sets the property LineInterpolation. 
        /// <para>
        /// The interpolation style for the sparkline line.
        /// </para>
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
        /// Gets and sets the property MaxValueMarker.
        /// </summary>
        public LineChartMarkerStyleSettings MaxValueMarker
        {
            get { return this._maxValueMarker; }
            set { this._maxValueMarker = value; }
        }

        // Check to see if MaxValueMarker property is set
        internal bool IsSetMaxValueMarker()
        {
            return this._maxValueMarker != null;
        }

        /// <summary>
        /// Gets and sets the property MinValueMarker.
        /// </summary>
        public LineChartMarkerStyleSettings MinValueMarker
        {
            get { return this._minValueMarker; }
            set { this._minValueMarker = value; }
        }

        // Check to see if MinValueMarker property is set
        internal bool IsSetMinValueMarker()
        {
            return this._minValueMarker != null;
        }

        /// <summary>
        /// Gets and sets the property VisualType. 
        /// <para>
        /// The type of the sparkline. Valid values are <c>LINE</c> and <c>AREA_LINE</c>.
        /// </para>
        /// </summary>
        public SparklineVisualType VisualType
        {
            get { return this._visualType; }
            set { this._visualType = value; }
        }

        // Check to see if VisualType property is set
        internal bool IsSetVisualType()
        {
            return this._visualType != null;
        }

        /// <summary>
        /// Gets and sets the property XAxisField.
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionField XAxisField
        {
            get { return this._xAxisField; }
            set { this._xAxisField = value; }
        }

        // Check to see if XAxisField property is set
        internal bool IsSetXAxisField()
        {
            return this._xAxisField != null;
        }

        /// <summary>
        /// Gets and sets the property YAxisBehavior. 
        /// <para>
        /// Determines whether the Y axis is shared across all sparklines or independent for each
        /// sparkline.
        /// </para>
        /// </summary>
        public SparklineAxisBehavior YAxisBehavior
        {
            get { return this._yAxisBehavior; }
            set { this._yAxisBehavior = value; }
        }

        // Check to see if YAxisBehavior property is set
        internal bool IsSetYAxisBehavior()
        {
            return this._yAxisBehavior != null;
        }

    }
}