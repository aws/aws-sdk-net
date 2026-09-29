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
    /// The configuration of a <c>ComboChartVisual</c>.
    /// </summary>
    public partial class ComboChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property BarDataLabels. 
        /// <para>
        /// The options that determine if visual data labels are displayed.
        /// </para>
        ///  
        /// <para>
        /// The data label options for a bar in a combo chart.
        /// </para>
        /// </summary>
        public DataLabelOptions BarDataLabels { get; set; }

        /// <summary>
        /// Checks to see if the BarDataLabels property is set.
        /// </summary>
        internal bool IsSetBarDataLabels() => this.BarDataLabels != null;

        /// <summary>
        /// Gets and sets the property BarsArrangement. 
        /// <para>
        /// Determines the bar arrangement in a combo chart. The following are valid values in
        /// this structure:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLUSTERED</c>: For clustered bar combo charts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STACKED</c>: For stacked bar combo charts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STACKED_PERCENT</c>: Do not use. If you use this value, the operation returns
        /// a validation error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BarsArrangement BarsArrangement { get; set; }

        /// <summary>
        /// Checks to see if the BarsArrangement property is set.
        /// </summary>
        internal bool IsSetBarsArrangement() => this.BarsArrangement != null;

        /// <summary>
        /// Gets and sets the property CategoryAxis. 
        /// <para>
        /// The category axis of a combo chart.
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
        /// The label options (label text, label visibility, and sort icon visibility) of a combo
        /// chart category (group/color) field well.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the CategoryLabelOptions property is set.
        /// </summary>
        internal bool IsSetCategoryLabelOptions() => this.CategoryLabelOptions != null;

        /// <summary>
        /// Gets and sets the property ColorLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility, and sort icon visibility) of a combo
        /// chart's color field well.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColorLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColorLabelOptions property is set.
        /// </summary>
        internal bool IsSetColorLabelOptions() => this.ColorLabelOptions != null;

        /// <summary>
        /// Gets and sets the property DefaultSeriesSettings. 
        /// <para>
        /// The options that determine the default presentation of all series in <c>ComboChartVisual</c>.
        /// </para>
        /// </summary>
        public ComboChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSeriesSettings property is set.
        /// </summary>
        internal bool IsSetDefaultSeriesSettings() => this.DefaultSeriesSettings != null;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public ComboChartFieldWells FieldWells { get; set; }

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
        /// Gets and sets the property LineDataLabels. 
        /// <para>
        /// The options that determine if visual data labels are displayed.
        /// </para>
        ///  
        /// <para>
        /// The data label options for a line in a combo chart.
        /// </para>
        /// </summary>
        public DataLabelOptions LineDataLabels { get; set; }

        /// <summary>
        /// Checks to see if the LineDataLabels property is set.
        /// </summary>
        internal bool IsSetLineDataLabels() => this.LineDataLabels != null;

        /// <summary>
        /// Gets and sets the property PrimaryYAxisDisplayOptions. 
        /// <para>
        /// The label display options (grid line, range, scale, and axis step) of a combo chart's
        /// primary y-axis (bar) field well.
        /// </para>
        /// </summary>
        public AxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryYAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetPrimaryYAxisDisplayOptions() => this.PrimaryYAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property PrimaryYAxisLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility, and sort icon visibility) of a combo
        /// chart's primary y-axis (bar) field well.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryYAxisLabelOptions property is set.
        /// </summary>
        internal bool IsSetPrimaryYAxisLabelOptions() => this.PrimaryYAxisLabelOptions != null;

        /// <summary>
        /// Gets and sets the property ReferenceLines. 
        /// <para>
        /// The reference line setup of the visual.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<ReferenceLine> ReferenceLines { get; set; } = AWSConfigs.InitializeCollections ? new List<ReferenceLine>() : null;

        /// <summary>
        /// Checks to see if the ReferenceLines property is set.
        /// </summary>
        internal bool IsSetReferenceLines() => this.ReferenceLines != null && (this.ReferenceLines.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecondaryYAxisDisplayOptions. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) of a combo chart's
        /// secondary y-axis (line) field well.
        /// </para>
        /// </summary>
        public AxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryYAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetSecondaryYAxisDisplayOptions() => this.SecondaryYAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property SecondaryYAxisLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility, and sort icon visibility) of a combo
        /// chart's secondary y-axis(line) field well.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions SecondaryYAxisLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryYAxisLabelOptions property is set.
        /// </summary>
        internal bool IsSetSecondaryYAxisLabelOptions() => this.SecondaryYAxisLabelOptions != null;

        /// <summary>
        /// Gets and sets the property Series. 
        /// <para>
        /// The series item configuration of a <c>ComboChartVisual</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<ComboSeriesItem> Series { get; set; } = AWSConfigs.InitializeCollections ? new List<ComboSeriesItem>() : null;

        /// <summary>
        /// Checks to see if the Series property is set.
        /// </summary>
        internal bool IsSetSeries() => this.Series != null && (this.Series.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SingleAxisOptions.
        /// </summary>
        public SingleAxisOptions SingleAxisOptions { get; set; }

        /// <summary>
        /// Checks to see if the SingleAxisOptions property is set.
        /// </summary>
        internal bool IsSetSingleAxisOptions() => this.SingleAxisOptions != null;

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <c>ComboChartVisual</c>.
        /// </para>
        /// </summary>
        public ComboChartSortConfiguration SortConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SortConfiguration property is set.
        /// </summary>
        internal bool IsSetSortConfiguration() => this.SortConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The legend display setup of the visual.
        /// </para>
        /// </summary>
        public TooltipOptions Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;

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
