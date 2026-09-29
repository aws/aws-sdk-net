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
    /// The configuration of a tree map.
    /// </summary>
    public partial class TreeMapConfiguration
    {
        /// <summary>
        /// Gets and sets the property ColorLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility) for the colors displayed in a tree
        /// map.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColorLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the ColorLabelOptions property is set.
        /// </summary>
        internal bool IsSetColorLabelOptions() => this.ColorLabelOptions != null;

        /// <summary>
        /// Gets and sets the property ColorScale. 
        /// <para>
        /// The color options (gradient color, point of divergence) of a tree map.
        /// </para>
        /// </summary>
        public ColorScale ColorScale { get; set; }

        /// <summary>
        /// Checks to see if the ColorScale property is set.
        /// </summary>
        internal bool IsSetColorScale() => this.ColorScale != null;

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
        public TreeMapFieldWells FieldWells { get; set; }

        /// <summary>
        /// Checks to see if the FieldWells property is set.
        /// </summary>
        internal bool IsSetFieldWells() => this.FieldWells != null;

        /// <summary>
        /// Gets and sets the property GroupLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility) of the groups that are displayed
        /// in a tree map.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions GroupLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the GroupLabelOptions property is set.
        /// </summary>
        internal bool IsSetGroupLabelOptions() => this.GroupLabelOptions != null;

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
        /// Gets and sets the property SizeLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility) of the sizes that are displayed in
        /// a tree map.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions SizeLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the SizeLabelOptions property is set.
        /// </summary>
        internal bool IsSetSizeLabelOptions() => this.SizeLabelOptions != null;

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a tree map.
        /// </para>
        /// </summary>
        public TreeMapSortConfiguration SortConfiguration { get; set; }

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
