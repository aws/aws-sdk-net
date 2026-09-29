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
    /// The configuration of a <c>BoxPlotVisual</c>.
    /// </summary>
    public partial class BoxPlotChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property BoxPlotOptions. 
        /// <para>
        /// The box plot chart options for a box plot visual
        /// </para>
        /// </summary>
        public BoxPlotOptions BoxPlotOptions { get; set; }

        /// <summary>
        /// Checks to see if the BoxPlotOptions property is set.
        /// </summary>
        internal bool IsSetBoxPlotOptions() => this.BoxPlotOptions != null;

        /// <summary>
        /// Gets and sets the property CategoryAxis. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) of a box plot category.
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
        /// The label options (label text, label visibility and sort Icon visibility) of a box
        /// plot category.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the CategoryLabelOptions property is set.
        /// </summary>
        internal bool IsSetCategoryLabelOptions() => this.CategoryLabelOptions != null;

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public BoxPlotFieldWells FieldWells { get; set; }

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
        /// </summary>
        public LegendOptions Legend { get; set; }

        /// <summary>
        /// Checks to see if the Legend property is set.
        /// </summary>
        internal bool IsSetLegend() => this.Legend != null;

        /// <summary>
        /// Gets and sets the property PrimaryYAxisDisplayOptions. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) of a box plot category.
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
        /// The label options (label text, label visibility and sort icon visibility) of a box
        /// plot value.
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
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <c>BoxPlotVisual</c>.
        /// </para>
        /// </summary>
        public BoxPlotSortConfiguration SortConfiguration { get; set; }

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
