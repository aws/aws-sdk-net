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
    /// The configuration for a waterfall visual.
    /// </summary>
    public partial class WaterfallChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property CategoryAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the category axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions CategoryAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the CategoryAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetCategoryAxisDisplayOptions() => this.CategoryAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property CategoryAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the category axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryAxisLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the CategoryAxisLabelOptions property is set.
        /// </summary>
        internal bool IsSetCategoryAxisLabelOptions() => this.CategoryAxisLabelOptions != null;

        /// <summary>
        /// Gets and sets the property ColorConfiguration. 
        /// <para>
        /// The color configuration of a waterfall visual.
        /// </para>
        /// </summary>
        public WaterfallChartColorConfiguration ColorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ColorConfiguration property is set.
        /// </summary>
        internal bool IsSetColorConfiguration() => this.ColorConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The data label configuration of a waterfall visual.
        /// </para>
        /// </summary>
        public DataLabelOptions DataLabels { get; set; }

        /// <summary>
        /// Checks to see if the DataLabels property is set.
        /// </summary>
        internal bool IsSetDataLabels() => this.DataLabels != null;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field well configuration of a waterfall visual.
        /// </para>
        /// </summary>
        public WaterfallChartFieldWells FieldWells { get; set; }

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
        /// The legend configuration of a waterfall visual.
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
        /// The options that determine the presentation of the y-axis.
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
        /// The options that determine the presentation of the y-axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions PrimaryYAxisLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryYAxisLabelOptions property is set.
        /// </summary>
        internal bool IsSetPrimaryYAxisLabelOptions() => this.PrimaryYAxisLabelOptions != null;

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a waterfall visual.
        /// </para>
        /// </summary>
        public WaterfallChartSortConfiguration SortConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SortConfiguration property is set.
        /// </summary>
        internal bool IsSetSortConfiguration() => this.SortConfiguration != null;

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a waterfall visual.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette { get; set; }

        /// <summary>
        /// Checks to see if the VisualPalette property is set.
        /// </summary>
        internal bool IsSetVisualPalette() => this.VisualPalette != null;

        /// <summary>
        /// Gets and sets the property WaterfallChartOptions. 
        /// <para>
        /// The options that determine the presentation of a waterfall visual.
        /// </para>
        /// </summary>
        public WaterfallChartOptions WaterfallChartOptions { get; set; }

        /// <summary>
        /// Checks to see if the WaterfallChartOptions property is set.
        /// </summary>
        internal bool IsSetWaterfallChartOptions() => this.WaterfallChartOptions != null;
    }
}
