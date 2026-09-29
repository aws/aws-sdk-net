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
    /// The configuration of a heat map.
    /// </summary>
    public partial class HeatMapConfiguration
    {
        /// <summary>
        /// Gets and sets the property ColorScale. 
        /// <para>
        /// The color options (gradient color, point of divergence) in a heat map.
        /// </para>
        /// </summary>
        public ColorScale ColorScale { get; set; }

        /// <summary>
        /// Checks to see if the ColorScale property is set.
        /// </summary>
        internal bool IsSetColorScale() => this.ColorScale != null;

        /// <summary>
        /// Gets and sets the property ColumnAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the row axis label.
        /// </para>
        /// </summary>
        public AxisDisplayOptions ColumnAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColumnAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetColumnAxisDisplayOptions() => this.ColumnAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property ColumnLabelOptions. 
        /// <para>
        /// The label options of the column that is displayed in a heat map.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColumnLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColumnLabelOptions property is set.
        /// </summary>
        internal bool IsSetColumnLabelOptions() => this.ColumnLabelOptions != null;

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
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public HeatMapFieldWells FieldWells { get; set; }

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
        /// Gets and sets the property RowAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the row axis label.
        /// </para>
        /// </summary>
        public AxisDisplayOptions RowAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the RowAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetRowAxisDisplayOptions() => this.RowAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property RowLabelOptions. 
        /// <para>
        /// The label options of the row that is displayed in a <c>heat map</c>.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions RowLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the RowLabelOptions property is set.
        /// </summary>
        internal bool IsSetRowLabelOptions() => this.RowLabelOptions != null;

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a heat map.
        /// </para>
        /// </summary>
        public HeatMapSortConfiguration SortConfiguration { get; set; }

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
    }
}
