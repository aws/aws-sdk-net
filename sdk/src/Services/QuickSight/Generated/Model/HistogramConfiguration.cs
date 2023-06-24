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
    /// The configuration for a <code>HistogramVisual</code>.
    /// </summary>
    public partial class HistogramConfiguration
    {
        private HistogramBinOptions _binOptions;
        private DataLabelOptions _dataLabels;
        private HistogramFieldWells _fieldWells;
        private TooltipOptions _tooltip;
        private VisualPalette _visualPalette;
        private AxisDisplayOptions _xAxisDisplayOptions;
        private ChartAxisLabelOptions _xAxisLabelOptions;
        private AxisDisplayOptions _yAxisDisplayOptions;

        /// <summary>
        /// Gets and sets the property BinOptions. 
        /// <para>
        /// The options that determine the presentation of histogram bins.
        /// </para>
        /// </summary>
        public HistogramBinOptions BinOptions
        {
            get { return this._binOptions; }
            set { this._binOptions = value; }
        }

        // Check to see if BinOptions property is set
        internal bool IsSetBinOptions()
        {
            return this._binOptions != null;
        }

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The data label configuration of a histogram.
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
        /// The field well configuration of a histogram.
        /// </para>
        /// </summary>
        public HistogramFieldWells FieldWells
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
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip configuration of a histogram.
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
        /// The visual palette configuration of a histogram.
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
        /// The options that determine the presentation of the x-axis.
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
        /// The options that determine the presentation of the x-axis label.
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
        /// The options that determine the presentation of the y-axis.
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

    }
}