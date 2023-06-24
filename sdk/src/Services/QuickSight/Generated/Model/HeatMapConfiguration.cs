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
    /// The configuration of a heat map.
    /// </summary>
    public partial class HeatMapConfiguration
    {
        private ColorScale _colorScale;
        private ChartAxisLabelOptions _columnLabelOptions;
        private DataLabelOptions _dataLabels;
        private HeatMapFieldWells _fieldWells;
        private LegendOptions _legend;
        private ChartAxisLabelOptions _rowLabelOptions;
        private HeatMapSortConfiguration _sortConfiguration;
        private TooltipOptions _tooltip;

        /// <summary>
        /// Gets and sets the property ColorScale. 
        /// <para>
        /// The color options (gradient color, point of divergence) in a heat map.
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
        /// Gets and sets the property ColumnLabelOptions. 
        /// <para>
        /// The label options of the column that is displayed in a heat map.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ColumnLabelOptions
        {
            get { return this._columnLabelOptions; }
            set { this._columnLabelOptions = value; }
        }

        // Check to see if ColumnLabelOptions property is set
        internal bool IsSetColumnLabelOptions()
        {
            return this._columnLabelOptions != null;
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
        public HeatMapFieldWells FieldWells
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
        /// Gets and sets the property RowLabelOptions. 
        /// <para>
        /// The label options of the row that is displayed in a <code>heat map</code>.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions RowLabelOptions
        {
            get { return this._rowLabelOptions; }
            set { this._rowLabelOptions = value; }
        }

        // Check to see if RowLabelOptions property is set
        internal bool IsSetRowLabelOptions()
        {
            return this._rowLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a heat map.
        /// </para>
        /// </summary>
        public HeatMapSortConfiguration SortConfiguration
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