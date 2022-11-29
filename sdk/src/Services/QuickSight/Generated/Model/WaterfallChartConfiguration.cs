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
    /// The configuration for a waterfall visual.
    /// </summary>
    public partial class WaterfallChartConfiguration
    {
        private AxisDisplayOptions _categoryAxisDisplayOptions;
        private ChartAxisLabelOptions _categoryAxisLabelOptions;
        private DataLabelOptions _dataLabels;
        private WaterfallChartFieldWells _fieldWells;
        private LegendOptions _legend;
        private AxisDisplayOptions _primaryYAxisDisplayOptions;
        private ChartAxisLabelOptions _primaryYAxisLabelOptions;
        private WaterfallChartSortConfiguration _sortConfiguration;
        private VisualPalette _visualPalette;
        private WaterfallChartOptions _waterfallChartOptions;

        /// <summary>
        /// Gets and sets the property CategoryAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the category axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions CategoryAxisDisplayOptions
        {
            get { return this._categoryAxisDisplayOptions; }
            set { this._categoryAxisDisplayOptions = value; }
        }

        // Check to see if CategoryAxisDisplayOptions property is set
        internal bool IsSetCategoryAxisDisplayOptions()
        {
            return this._categoryAxisDisplayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CategoryAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the category axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions CategoryAxisLabelOptions
        {
            get { return this._categoryAxisLabelOptions; }
            set { this._categoryAxisLabelOptions = value; }
        }

        // Check to see if CategoryAxisLabelOptions property is set
        internal bool IsSetCategoryAxisLabelOptions()
        {
            return this._categoryAxisLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The data label configuration of a waterfall visual.
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
        /// The field well configuration of a waterfall visual.
        /// </para>
        /// </summary>
        public WaterfallChartFieldWells FieldWells
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
        /// The legend configuration of a waterfall visual.
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
        /// Gets and sets the property PrimaryYAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the y-axis.
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
        /// The options that determine the presentation of the y-axis label.
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
        /// Gets and sets the property SortConfiguration. 
        /// <para>
        /// The sort configuration of a waterfall visual.
        /// </para>
        /// </summary>
        public WaterfallChartSortConfiguration SortConfiguration
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
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a waterfall visual.
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

        /// <summary>
        /// Gets and sets the property WaterfallChartOptions. 
        /// <para>
        /// The options that determine the presentation of a waterfall visual.
        /// </para>
        /// </summary>
        public WaterfallChartOptions WaterfallChartOptions
        {
            get { return this._waterfallChartOptions; }
            set { this._waterfallChartOptions = value; }
        }

        // Check to see if WaterfallChartOptions property is set
        internal bool IsSetWaterfallChartOptions()
        {
            return this._waterfallChartOptions != null;
        }

    }
}