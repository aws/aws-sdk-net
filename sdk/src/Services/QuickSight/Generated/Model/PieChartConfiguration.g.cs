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
    /// The configuration of a pie chart.
    /// </summary>
    public partial class PieChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property CategoryLabelOptions. 
        /// <para>
        /// The label options of the group/color that is displayed in a pie chart.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the CategoryLabelOptions property is set.
        /// </summary>
        internal bool IsSetCategoryLabelOptions() => this.CategoryLabelOptions != null;

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
        /// Gets and sets the property DonutOptions. 
        /// <para>
        /// The options that determine the shape of the chart. This option determines whether
        /// the chart is a pie chart or a donut chart.
        /// </para>
        /// </summary>
        public DonutOptions DonutOptions { get; set; }

        /// <summary>
        /// Checks to see if the DonutOptions property is set.
        /// </summary>
        internal bool IsSetDonutOptions() => this.DonutOptions != null;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public PieChartFieldWells FieldWells { get; set; }

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
        /// The sort configuration of a pie chart.
        /// </para>
        /// </summary>
        public PieChartSortConfiguration SortConfiguration { get; set; }

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
        /// Gets and sets the property ValueLabelOptions. 
        /// <para>
        /// The label options for the value that is displayed in a pie chart.
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
