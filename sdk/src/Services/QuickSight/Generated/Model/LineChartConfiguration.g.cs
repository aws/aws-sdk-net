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
    /// The configuration of a line chart.
    /// </summary>
    public partial class LineChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property ContributionAnalysisDefaults. 
        /// <para>
        /// The default configuration of a line chart's contribution analysis.
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
        /// The data label configuration of a line chart.
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
        /// The options that determine the default presentation of all line series in <c>LineChartVisual</c>.
        /// </para>
        /// </summary>
        public LineChartDefaultSeriesSettings DefaultSeriesSettings { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSeriesSettings property is set.
        /// </summary>
        internal bool IsSetDefaultSeriesSettings() => this.DefaultSeriesSettings != null;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field well configuration of a line chart.
        /// </para>
        /// </summary>
        public LineChartFieldWells FieldWells { get; set; }

        /// <summary>
        /// Checks to see if the FieldWells property is set.
        /// </summary>
        internal bool IsSetFieldWells() => this.FieldWells != null;

        /// <summary>
        /// Gets and sets the property ForecastConfigurations. 
        /// <para>
        /// The forecast configuration of a line chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ForecastConfiguration> ForecastConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ForecastConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ForecastConfigurations property is set.
        /// </summary>
        internal bool IsSetForecastConfigurations() => this.ForecastConfigurations != null && (this.ForecastConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The legend configuration of a line chart.
        /// </para>
        /// </summary>
        public LegendOptions Legend { get; set; }

        /// <summary>
        /// Checks to see if the Legend property is set.
        /// </summary>
        internal bool IsSetLegend() => this.Legend != null;

        /// <summary>
        /// Gets and sets the property PrimaryYAxisDisplayOptions. 
        /// <para>
        /// The series axis configuration of a line chart.
        /// </para>
        /// </summary>
        public LineSeriesAxisDisplayOptions PrimaryYAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryYAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetPrimaryYAxisDisplayOptions() => this.PrimaryYAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property PrimaryYAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the y-axis label.
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
        /// The reference lines configuration of a line chart.
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
        /// The series axis configuration of a line chart.
        /// </para>
        /// </summary>
        public LineSeriesAxisDisplayOptions SecondaryYAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryYAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetSecondaryYAxisDisplayOptions() => this.SecondaryYAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property SecondaryYAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the secondary y-axis label.
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
        /// The series item configuration of a line chart.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<SeriesItem> Series { get; set; } = AWSConfigs.InitializeCollections ? new List<SeriesItem>() : null;

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
        /// The sort configuration of a line chart.
        /// </para>
        /// </summary>
        public LineChartSortConfiguration SortConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SortConfiguration property is set.
        /// </summary>
        internal bool IsSetSortConfiguration() => this.SortConfiguration != null;

        /// <summary>
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip configuration of a line chart.
        /// </para>
        /// </summary>
        public TooltipOptions Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Determines the type of the line chart.
        /// </para>
        /// </summary>
        public LineChartType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a line chart.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette { get; set; }

        /// <summary>
        /// Checks to see if the VisualPalette property is set.
        /// </summary>
        internal bool IsSetVisualPalette() => this.VisualPalette != null;

        /// <summary>
        /// Gets and sets the property XAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the x-axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions XAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the XAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetXAxisDisplayOptions() => this.XAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property XAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the x-axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions XAxisLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the XAxisLabelOptions property is set.
        /// </summary>
        internal bool IsSetXAxisLabelOptions() => this.XAxisLabelOptions != null;
    }
}
