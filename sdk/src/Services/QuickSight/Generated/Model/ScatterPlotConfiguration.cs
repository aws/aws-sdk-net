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
    /// The configuration of a scatter plot.
    /// </summary>
    public partial class ScatterPlotConfiguration
    {
        private DataLabelOptions _dataLabels;
        private ScatterPlotFieldWells _fieldWells;
        private LegendOptions _legend;
        private TooltipOptions _tooltip;
        private VisualPalette _visualPalette;
        private AxisDisplayOptions _xAxisDisplayOptions;
        private ChartAxisLabelOptions _xAxisLabelOptions;
        private AxisDisplayOptions _yAxisDisplayOptions;
        private ChartAxisLabelOptions _yAxisLabelOptions;

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
        public ScatterPlotFieldWells FieldWells
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
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The legend display setup of the visual.
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

        /// <summary>
        /// Gets and sets the property XAxisDisplayOptions. 
        /// <para>
        /// The label display options (grid line, range, scale, and axis step) of the scatter
        /// plot's x-axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions XAxisDisplayOptions
        {
            get { return this._xAxisDisplayOptions; }
            set { this._xAxisDisplayOptions = value; }
        }

        // Check to see if XAxisDisplayOptions property is set
        internal bool IsSetXAxisDisplayOptions()
        {
            return this._xAxisDisplayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property XAxisLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility, and sort icon visibility) of the
        /// scatter plot's x-axis.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions XAxisLabelOptions
        {
            get { return this._xAxisLabelOptions; }
            set { this._xAxisLabelOptions = value; }
        }

        // Check to see if XAxisLabelOptions property is set
        internal bool IsSetXAxisLabelOptions()
        {
            return this._xAxisLabelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property YAxisDisplayOptions. 
        /// <para>
        /// The label display options (grid line, range, scale, and axis step) of the scatter
        /// plot's y-axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions YAxisDisplayOptions
        {
            get { return this._yAxisDisplayOptions; }
            set { this._yAxisDisplayOptions = value; }
        }

        // Check to see if YAxisDisplayOptions property is set
        internal bool IsSetYAxisDisplayOptions()
        {
            return this._yAxisDisplayOptions != null;
        }

        /// <summary>
        /// Gets and sets the property YAxisLabelOptions. 
        /// <para>
        /// The label options (label text, label visibility, and sort icon visibility) of the
        /// scatter plot's y-axis.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions YAxisLabelOptions
        {
            get { return this._yAxisLabelOptions; }
            set { this._yAxisLabelOptions = value; }
        }

        // Check to see if YAxisLabelOptions property is set
        internal bool IsSetYAxisLabelOptions()
        {
            return this._yAxisLabelOptions != null;
        }

    }
}