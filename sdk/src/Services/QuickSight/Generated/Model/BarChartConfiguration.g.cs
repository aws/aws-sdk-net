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
    /// The configuration of a <c>BarChartVisual</c>.
    /// </summary>
    public partial class BarChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property BarsArrangement. 
        /// <para>
        /// Determines the arrangement of the bars. The orientation and arrangement of bars determine
        /// the type of bar that is used in the visual.
        /// </para>
        /// </summary>
        public BarsArrangement BarsArrangement { get; set; }

        /// <summary>
        /// Checks to see if the BarsArrangement property is set.
        /// </summary>
        internal bool IsSetBarsArrangement() => this.BarsArrangement != null;

        /// <summary>
        /// Gets and sets the property CategoryAxis. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) for bar chart category.
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
        /// The label options (label text, label visibility and sort icon visibility) for a bar
        /// chart.
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
        /// The label options (label text, label visibility and sort icon visibility) for a color
        /// that is used in a bar chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColorLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColorLabelOptions property is set.
        /// </summary>
        internal bool IsSetColorLabelOptions() => this.ColorLabelOptions != null;

        /// <summary>
        /// Gets and sets the property ContributionAnalysisDefaults. 
        /// <para>
        /// The contribution analysis (anomaly configuration) setup of the visual.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<ContributionAnalysisDefault> ContributionAnalysisDefaults { get; set; } = AWSConfigs.InitializeCollections ? new List<ContributionAnalysisDefault>() : null;

        /// <summary>
        /// Checks to see if the ContributionAnalysisDefaults property is set.
        /// </summary>
        internal bool IsSetContributionAnalysisDefaults() => this.ContributionAnalysisDefaults != null && (this.ContributionAnalysisDefaults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The options that determine if visual data labels are displayed.
        /// </para>
        /// </summary>
        public DataLabelOptions DataLabels { get; set; }

        /// <summary>
        /// Checks to see if the DataLabels property is set.
        /// </summary>
        internal bool IsSetDataLabels() => this.DataLabels != null;

        /// <summary>
        /// Gets and sets the property DefaultSeriesSettings. 
        /// <para>
        /// The options that determine the default presentation of all bar series in <c>BarChartVisual</c>.
        /// </para>
        /// </summary>
        public BarChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }

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
        public BarChartFieldWells FieldWells { get; set; }

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
        /// Gets and sets the property Orientation. 
        /// <para>
        /// The orientation of the bars in a bar chart visual. There are two valid values in this
        /// structure:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HORIZONTAL</c>: Used for charts that have horizontal bars. Visuals that use this
        /// value are horizontal bar charts, horizontal stacked bar charts, and horizontal stacked
        /// 100% bar charts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VERTICAL</c>: Used for charts that have vertical bars. Visuals that use this value
        /// are vertical bar charts, vertical stacked bar charts, and vertical stacked 100% bar
        /// charts.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BarChartOrientation Orientation { get; set; }

        /// <summary>
        /// Checks to see if the Orientation property is set.
        /// </summary>
        internal bool IsSetOrientation() => this.Orientation != null;

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
        /// Gets and sets the property Series. 
        /// <para>
        /// The series item configuration of a <c>BarChartVisual</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<BarSeriesItem> Series { get; set; } = AWSConfigs.InitializeCollections ? new List<BarSeriesItem>() : null;

        /// <summary>
        /// Checks to see if the Series property is set.
        /// </summary>
        internal bool IsSetSeries() => this.Series != null && (this.Series.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SmallMultiplesOptions. 
        /// <para>
        /// The small multiples setup for the visual.
        /// </para>
        /// </summary>
        public SmallMultiplesOptions SmallMultiplesOptions { get; set; }

        /// <summary>
        /// Checks to see if the SmallMultiplesOptions property is set.
        /// </summary>
        internal bool IsSetSmallMultiplesOptions() => this.SmallMultiplesOptions != null;

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <c>BarChartVisual</c>.
        /// </para>
        /// </summary>
        public BarChartSortConfiguration SortConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SortConfiguration property is set.
        /// </summary>
        internal bool IsSetSortConfiguration() => this.SortConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip display setup of the visual.
        /// </para>
        /// </summary>
        public TooltipOptions Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;

        /// <summary>
        /// Gets and sets the property ValueAxis. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) for a bar chart value.
        /// </para>
        /// </summary>
        public AxisDisplayOptions ValueAxis { get; set; }

        /// <summary>
        /// Checks to see if the ValueAxis property is set.
        /// </summary>
        internal bool IsSetValueAxis() => this.ValueAxis != null;

        /// <summary>
        /// Gets and sets the property ValueLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility and sort icon visibility) for a bar
        /// chart value.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ValueLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the ValueLabelOptions property is set.
        /// </summary>
        internal bool IsSetValueLabelOptions() => this.ValueLabelOptions != null;

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
