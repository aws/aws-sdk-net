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
    /// The configuration of a <c>RadarChartVisual</c>.
    /// </summary>
    public partial class RadarChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property AlternateBandColorsVisibility. 
        /// <para>
        /// Determines the visibility of the colors of alternatign bands in a radar chart.
        /// </para>
        /// </summary>
        public Visibility AlternateBandColorsVisibility { get; set; }

        /// <summary>
        /// Checks to see if the AlternateBandColorsVisibility property is set.
        /// </summary>
        internal bool IsSetAlternateBandColorsVisibility() => this.AlternateBandColorsVisibility != null;

        /// <summary>
        /// Gets and sets the property AlternateBandEvenColor. 
        /// <para>
        /// The color of the even-numbered alternate bands of a radar chart.
        /// </para>
        /// </summary>
        public string AlternateBandEvenColor { get; set; }

        /// <summary>
        /// Checks to see if the AlternateBandEvenColor property is set.
        /// </summary>
        internal bool IsSetAlternateBandEvenColor() => this.AlternateBandEvenColor != null;

        /// <summary>
        /// Gets and sets the property AlternateBandOddColor. 
        /// <para>
        /// The color of the odd-numbered alternate bands of a radar chart.
        /// </para>
        /// </summary>
        public string AlternateBandOddColor { get; set; }

        /// <summary>
        /// Checks to see if the AlternateBandOddColor property is set.
        /// </summary>
        internal bool IsSetAlternateBandOddColor() => this.AlternateBandOddColor != null;

        /// <summary>
        /// Gets and sets the property AxesRangeScale. 
        /// <para>
        /// The axis behavior options of a radar chart.
        /// </para>
        /// </summary>
        public RadarChartAxesRangeScale AxesRangeScale { get; set; }

        /// <summary>
        /// Checks to see if the AxesRangeScale property is set.
        /// </summary>
        internal bool IsSetAxesRangeScale() => this.AxesRangeScale != null;

        /// <summary>
        /// Gets and sets the property BaseSeriesSettings. 
        /// <para>
        /// The base sreies settings of a radar chart.
        /// </para>
        /// </summary>
        public RadarChartSeriesSettings BaseSeriesSettings { get; set; }

        /// <summary>
        /// Checks to see if the BaseSeriesSettings property is set.
        /// </summary>
        internal bool IsSetBaseSeriesSettings() => this.BaseSeriesSettings != null;

        /// <summary>
        /// Gets and sets the property CategoryAxis. 
        /// <para>
        /// The category axis of a radar chart.
        /// </para>
        /// </summary>
        public AxisDisplayOptions CategoryAxis { get; set; }

        /// <summary>
        /// Checks to see if the CategoryAxis property is set.
        /// </summary>
        internal bool IsSetCategoryAxis() => this.CategoryAxis != null;

        /// <summary>
        /// Gets and sets the property CategoryLabelOptions. 
        /// <para>
        /// The category label options of a radar chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the CategoryLabelOptions property is set.
        /// </summary>
        internal bool IsSetCategoryLabelOptions() => this.CategoryLabelOptions != null;

        /// <summary>
        /// Gets and sets the property ColorAxis. 
        /// <para>
        /// The color axis of a radar chart.
        /// </para>
        /// </summary>
        public AxisDisplayOptions ColorAxis { get; set; }

        /// <summary>
        /// Checks to see if the ColorAxis property is set.
        /// </summary>
        internal bool IsSetColorAxis() => this.ColorAxis != null;

        /// <summary>
        /// Gets and sets the property ColorLabelOptions. 
        /// <para>
        /// The color label options of a radar chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColorLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColorLabelOptions property is set.
        /// </summary>
        internal bool IsSetColorLabelOptions() => this.ColorLabelOptions != null;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field well configuration of a <c>RadarChartVisual</c>.
        /// </para>
        /// </summary>
        public RadarChartFieldWells FieldWells { get; set; }

        /// <summary>
        /// Checks to see if the FieldWells property is set.
        /// </summary>
        internal bool IsSetFieldWells() => this.FieldWells != null;

        /// <summary>
        /// Gets and sets the property Interactions. 
        /// <para>
        /// The general visual interactions setup for a visual.
        /// </para>
        /// </summary>
        public VisualInteractionOptions Interactions { get; set; }

        /// <summary>
        /// Checks to see if the Interactions property is set.
        /// </summary>
        internal bool IsSetInteractions() => this.Interactions != null;

        /// <summary>
        /// Gets and sets the property Legend. 
        /// <para>
        /// The legend display setup of the visual.
        /// </para>
        /// </summary>
        public LegendOptions Legend { get; set; }

        /// <summary>
        /// Checks to see if the Legend property is set.
        /// </summary>
        internal bool IsSetLegend() => this.Legend != null;

        /// <summary>
        /// Gets and sets the property Shape. 
        /// <para>
        /// The shape of the radar chart.
        /// </para>
        /// </summary>
        public RadarChartShape Shape { get; set; }

        /// <summary>
        /// Checks to see if the Shape property is set.
        /// </summary>
        internal bool IsSetShape() => this.Shape != null;

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <c>RadarChartVisual</c>.
        /// </para>
        /// </summary>
        public RadarChartSortConfiguration SortConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SortConfiguration property is set.
        /// </summary>
        internal bool IsSetSortConfiguration() => this.SortConfiguration != null;

        /// <summary>
        /// Gets and sets the property StartAngle. 
        /// <para>
        /// The start angle of a radar chart's axis.
        /// </para>
        /// </summary>
        [AWSProperty(Min = -360, Max = 360)]
        public double? StartAngle { get; set; }

        /// <summary>
        /// Checks to see if the StartAngle property is set.
        /// </summary>
        internal bool IsSetStartAngle() => this.StartAngle.HasValue;

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The palette (chart color) display setup of the visual.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette { get; set; }

        /// <summary>
        /// Checks to see if the VisualPalette property is set.
        /// </summary>
        internal bool IsSetVisualPalette() => this.VisualPalette != null;
    }
}
