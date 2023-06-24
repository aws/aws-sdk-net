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
    /// The configuration of a <code>FunnelChartVisual</code>.
    /// </summary>
    public partial class FunnelChartConfiguration
    {
        private ChartAxisLabelOptions _categoryLabelOptions;
        private FunnelChartDataLabelOptions _dataLabelOptions;
        private FunnelChartFieldWells _fieldWells;
        private FunnelChartSortConfiguration _sortConfiguration;
        private TooltipOptions _tooltip;
        private ChartAxisLabelOptions _valueLabelOptions;
        private VisualPalette _visualPalette;

        /// <summary>
        /// Gets and sets the property CategoryLabelOptions. 
        /// <para>
        /// The label options of the categories that are displayed in a <code>FunnelChartVisual</code>.
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
        /// Gets and sets the property DataLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the data labels.
        /// </para>
        /// </summary>
        public FunnelChartDataLabelOptions DataLabelOptions
        {
            get { return this._dataLabelOptions; }
            set { this._dataLabelOptions = value; }
        }

        // Check to see if DataLabelOptions property is set
        internal bool IsSetDataLabelOptions()
        {
            return this._dataLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property FieldWells. 
        /// <para>
        /// The field well configuration of a <code>FunnelChartVisual</code>.
        /// </para>
        /// </summary>
        public FunnelChartFieldWells FieldWells
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
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a <code>FunnelChartVisual</code>.
        /// </para>
        /// </summary>
        public FunnelChartSortConfiguration SortConfiguration
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
        /// The tooltip configuration of a <code>FunnelChartVisual</code>.
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
        /// Gets and sets the property ValueLabelOptions. 
        /// <para>
        /// The label options for the values that are displayed in a <code>FunnelChartVisual</code>.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions ValueLabelOptions
        {
            get { return this._valueLabelOptions; }
            set { this._valueLabelOptions = value; }
        }

        // Check to see if ValueLabelOptions property is set
        internal bool IsSetValueLabelOptions()
        {
            return this._valueLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a <code>FunnelChartVisual</code>.
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