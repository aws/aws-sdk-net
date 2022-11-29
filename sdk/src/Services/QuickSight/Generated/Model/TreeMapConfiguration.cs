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
    /// The configuration of a tree map.
    /// </summary>
    public partial class TreeMapConfiguration
    {
        private ChartAxisLabelOptions _colorLabelOptions;
        private ColorScale _colorScale;
        private DataLabelOptions _dataLabels;
        private TreeMapFieldWells _fieldWells;
        private ChartAxisLabelOptions _groupLabelOptions;
        private LegendOptions _legend;
        private ChartAxisLabelOptions _sizeLabelOptions;
        private TreeMapSortConfiguration _sortConfiguration;
        private TooltipOptions _tooltip;

        /// <summary>
        /// Gets and sets the property ColorLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility) for the colors displayed in a tree
        /// map.
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
        /// Gets and sets the property ColorScale. 
        /// <para>
        /// The color options (gradient color, point of divergence) of a tree map.
        /// </para>
        /// </summary>
        public ColorScale ColorScale
        {
            get { return this._colorScale; }
            set { this._colorScale = value; }
        }

        // Check to see if ColorScale property is set
        internal bool IsSetColorScale()
        {
            return this._colorScale != null;
        }

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The options that determine if visual data labels are displayed.
        /// </para>
        /// </summary>
        public DataLabelOptions DataLabels
        {
            get { return this._dataLabels; }
            set { this._dataLabels = value; }
        }

        // Check to see if DataLabels property is set
        internal bool IsSetDataLabels()
        {
            return this._dataLabels != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public TreeMapFieldWells FieldWells
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
        /// Gets and sets the property GroupLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility) of the groups that are displayed
        /// in a tree map.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions GroupLabelOptions
        {
            get { return this._groupLabelOptions; }
            set { this._groupLabelOptions = value; }
        }

        // Check to see if GroupLabelOptions property is set
        internal bool IsSetGroupLabelOptions()
        {
            return this._groupLabelOptions != null;
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
        /// Gets and sets the property SizeLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility) of the sizes that are displayed in
        /// a tree map.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions SizeLabelOptions
        {
            get { return this._sizeLabelOptions; }
            set { this._sizeLabelOptions = value; }
        }

        // Check to see if SizeLabelOptions property is set
        internal bool IsSetSizeLabelOptions()
        {
            return this._sizeLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a tree map.
        /// </para>
        /// </summary>
        public TreeMapSortConfiguration SortConfiguration
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
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip display setup of the visual.
        /// </para>
        /// </summary>
        public TooltipOptions Tooltip
        {
            get { return this._tooltip; }
            set { this._tooltip = value; }
        }

        // Check to see if Tooltip property is set
        internal bool IsSetTooltip()
        {
            return this._tooltip != null;
        }

    }
}