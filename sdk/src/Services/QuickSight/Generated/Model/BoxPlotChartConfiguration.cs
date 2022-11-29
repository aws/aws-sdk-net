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
    /// The configuration of a <code>BoxPlotVisual</code>.
    /// </summary>
    public partial class BoxPlotChartConfiguration
    {
        private BoxPlotOptions _boxPlotOptions;
        private AxisDisplayOptions _categoryAxis;
        private ChartAxisLabelOptions _categoryLabelOptions;
        private BoxPlotFieldWells _fieldWells;
        private LegendOptions _legend;
        private AxisDisplayOptions _primaryYAxisDisplayOptions;
        private ChartAxisLabelOptions _primaryYAxisLabelOptions;
        private List<ReferenceLine> _referenceLines = new List<ReferenceLine>();
        private BoxPlotSortConfiguration _sortConfiguration;
        private TooltipOptions _tooltip;
        private VisualPalette _visualPalette;

        /// <summary>
        /// Gets and sets the property BoxPlotOptions. 
        /// <para>
        /// The box plot chart options for a box plot visual
        /// </para>
        /// </summary>
        public BoxPlotOptions BoxPlotOptions
        {
            get { return this._boxPlotOptions; }
            set { this._boxPlotOptions = value; }
        }

        // Check to see if BoxPlotOptions property is set
        internal bool IsSetBoxPlotOptions()
        {
            return this._boxPlotOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryAxis. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) of a box plot category.
        /// </para>
        /// </summary>
        public AxisDisplayOptions CategoryAxis
        {
            get { return this._categoryAxis; }
            set { this._categoryAxis = value; }
        }

        // Check to see if CategoryAxis property is set
        internal bool IsSetCategoryAxis()
        {
            return this._categoryAxis != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility and sort Icon visibility) of a box
        /// plot category.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryLabelOptions
        {
            get { return this._categoryLabelOptions; }
            set { this._categoryLabelOptions = value; }
        }

        // Check to see if CategoryLabelOptions property is set
        internal bool IsSetCategoryLabelOptions()
        {
            return this._categoryLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field wells of the visual.
        /// </para>
        /// </summary>
        public BoxPlotFieldWells FieldWells
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
        /// Gets and sets the property PrimaryYAxisDisplayOptions. 
        /// <para>
        /// The label display options (grid line, range, scale, axis step) of a box plot category.
        /// </para>
        /// </summary>
        public AxisDisplayOptions PrimaryYAxisDisplayOptions
        {
            get { return this._primaryYAxisDisplayOptions; }
            set { this._primaryYAxisDisplayOptions = value; }
        }

        // Check to see if PrimaryYAxisDisplayOptions property is set
        internal bool IsSetPrimaryYAxisDisplayOptions()
        {
            return this._primaryYAxisDisplayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryYAxisLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility and sort icon visibility) of a box
        /// plot value.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions PrimaryYAxisLabelOptions
        {
            get { return this._primaryYAxisLabelOptions; }
            set { this._primaryYAxisLabelOptions = value; }
        }

        // Check to see if PrimaryYAxisLabelOptions property is set
        internal bool IsSetPrimaryYAxisLabelOptions()
        {
            return this._primaryYAxisLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceLines. 
        /// <para>
        /// The reference line setup of the visual.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public List<ReferenceLine> ReferenceLines
        {
            get { return this._referenceLines; }
            set { this._referenceLines = value; }
        }

        // Check to see if ReferenceLines property is set
        internal bool IsSetReferenceLines()
        {
            return this._referenceLines != null && this._referenceLines.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <code>BoxPlotVisual</code>.
        /// </para>
        /// </summary>
        public BoxPlotSortConfiguration SortConfiguration
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

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The palette (chart color) display setup of the visual.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette
        {
            get { return this._visualPalette; }
            set { this._visualPalette = value; }
        }

        // Check to see if VisualPalette property is set
        internal bool IsSetVisualPalette()
        {
            return this._visualPalette != null;
        }

    }
}