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
    /// The configuration of a <code>RadarChartVisual</code>.
    /// </summary>
    public partial class RadarChartConfiguration
    {
        private Visibility _alternateBandColorsVisibility;
        private string _alternateBandEvenColor;
        private string _alternateBandOddColor;
        private RadarChartSeriesSettings _baseSeriesSettings;
        private AxisDisplayOptions _categoryAxis;
        private ChartAxisLabelOptions _categoryLabelOptions;
        private AxisDisplayOptions _colorAxis;
        private ChartAxisLabelOptions _colorLabelOptions;
        private RadarChartFieldWells _fieldWells;
        private LegendOptions _legend;
        private RadarChartShape _shape;
        private RadarChartSortConfiguration _sortConfiguration;
        private double? _startAngle;
        private VisualPalette _visualPalette;

        /// <summary>
        /// Gets and sets the property AlternateBandColorsVisibility. 
        /// <para>
        /// Determines the visibility of the colors of alternatign bands in a radar chart.
        /// </para>
        /// </summary>
        public Visibility AlternateBandColorsVisibility
        {
            get { return this._alternateBandColorsVisibility; }
            set { this._alternateBandColorsVisibility = value; }
        }

        // Check to see if AlternateBandColorsVisibility property is set
        internal bool IsSetAlternateBandColorsVisibility()
        {
            return this._alternateBandColorsVisibility != null;
        }

        /// <summary>
        /// Gets and sets the property AlternateBandEvenColor. 
        /// <para>
        /// The color of the even-numbered alternate bands of a radar chart.
        /// </para>
        /// </summary>
        public string AlternateBandEvenColor
        {
            get { return this._alternateBandEvenColor; }
            set { this._alternateBandEvenColor = value; }
        }

        // Check to see if AlternateBandEvenColor property is set
        internal bool IsSetAlternateBandEvenColor()
        {
            return this._alternateBandEvenColor != null;
        }

        /// <summary>
        /// Gets and sets the property AlternateBandOddColor. 
        /// <para>
        /// The color of the odd-numbered alternate bands of a radar chart.
        /// </para>
        /// </summary>
        public string AlternateBandOddColor
        {
            get { return this._alternateBandOddColor; }
            set { this._alternateBandOddColor = value; }
        }

        // Check to see if AlternateBandOddColor property is set
        internal bool IsSetAlternateBandOddColor()
        {
            return this._alternateBandOddColor != null;
        }

        /// <summary>
        /// Gets and sets the property BaseSeriesSettings. 
        /// <para>
        /// The base sreies settings of a radar chart.
        /// </para>
        /// </summary>
        public RadarChartSeriesSettings BaseSeriesSettings
        {
            get { return this._baseSeriesSettings; }
            set { this._baseSeriesSettings = value; }
        }

        // Check to see if BaseSeriesSettings property is set
        internal bool IsSetBaseSeriesSettings()
        {
            return this._baseSeriesSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryAxis. 
        /// <para>
        /// The category axis of a radar chart.
        /// </para>
        /// </summary>
        public AxisDisplayOptions CategoryAxis
        {
            get { return this._categoryAxis; }
            set { this._categoryAxis = value; }
        }

        // Check to see if CategoryAxis property is set
        internal bool IsSetCategoryAxis()
        {
            return this._categoryAxis != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryLabelOptions. 
        /// <para>
        /// The category label options of a radar chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions
        {
            get { return this._categoryLabelOptions; }
            set { this._categoryLabelOptions = value; }
        }

        // Check to see if CategoryLabelOptions property is set
        internal bool IsSetCategoryLabelOptions()
        {
            return this._categoryLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ColorAxis. 
        /// <para>
        /// The color axis of a radar chart.
        /// </para>
        /// </summary>
        public AxisDisplayOptions ColorAxis
        {
            get { return this._colorAxis; }
            set { this._colorAxis = value; }
        }

        // Check to see if ColorAxis property is set
        internal bool IsSetColorAxis()
        {
            return this._colorAxis != null;
        }

        /// <summary>
        /// Gets and sets the property ColorLabelOptions. 
        /// <para>
        /// The color label options of a radar chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColorLabelOptions
        {
            get { return this._colorLabelOptions; }
            set { this._colorLabelOptions = value; }
        }

        // Check to see if ColorLabelOptions property is set
        internal bool IsSetColorLabelOptions()
        {
            return this._colorLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field well configuration of a <code>RadarChartVisual</code>.
        /// </para>
        /// </summary>
        public RadarChartFieldWells FieldWells
        {
            get { return this._fieldWells; }
            set { this._fieldWells = value; }
        }

        // Check to see if FieldWells property is set
        internal bool IsSetFieldWells()
        {
            return this._fieldWells != null;
        }

        /// <summary>
        /// Gets and sets the property Legend. 
        /// <para>
        /// The legend display setup of the visual.
        /// </para>
        /// </summary>
        public LegendOptions Legend
        {
            get { return this._legend; }
            set { this._legend = value; }
        }

        // Check to see if Legend property is set
        internal bool IsSetLegend()
        {
            return this._legend != null;
        }

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape of the radar chart.
        /// </para>
        /// </summary>
        public RadarChartShape Shape
        {
            get { return this._shape; }
            set { this._shape = value; }
        }

        // Check to see if Shape property is set
        internal bool IsSetShape()
        {
            return this._shape != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <code>RadarChartVisual</code>.
        /// </para>
        /// </summary>
        public RadarChartSortConfiguration SortConfiguration
        {
            get { return this._sortConfiguration; }
            set { this._sortConfiguration = value; }
        }

        // Check to see if SortConfiguration property is set
        internal bool IsSetSortConfiguration()
        {
            return this._sortConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StartAngle. 
        /// <para>
        /// The start angle of a radar chart's axis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-360, Max=360)]
        public double StartAngle
        {
            get { return this._startAngle.GetValueOrDefault(); }
            set { this._startAngle = value; }
        }

        // Check to see if StartAngle property is set
        internal bool IsSetStartAngle()
        {
            return this._startAngle.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The palette (chart color) display setup of the visual.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette
        {
            get { return this._visualPalette; }
            set { this._visualPalette = value; }
        }

        // Check to see if VisualPalette property is set
        internal bool IsSetVisualPalette()
        {
            return this._visualPalette != null;
        }

    }
}