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
    /// The configuration of a <code>GaugeChartVisual</code>.
    /// </summary>
    public partial class GaugeChartConfiguration
    {
        private DataLabelOptions _dataLabels;
        private GaugeChartFieldWells _fieldWells;
        private GaugeChartOptions _gaugeChartOptions;
        private TooltipOptions _tooltipOptions;
        private VisualPalette _visualPalette;

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The data label configuration of a <code>GaugeChartVisual</code>.
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
        /// The field well configuration of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public GaugeChartFieldWells FieldWells
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
        /// Gets and sets the property GaugeChartOptions. 
        /// <para>
        /// The options that determine the presentation of the <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public GaugeChartOptions GaugeChartOptions
        {
            get { return this._gaugeChartOptions; }
            set { this._gaugeChartOptions = value; }
        }

        // Check to see if GaugeChartOptions property is set
        internal bool IsSetGaugeChartOptions()
        {
            return this._gaugeChartOptions != null;
        }

        /// <summary>
        /// Gets and sets the property TooltipOptions. 
        /// <para>
        /// The tooltip configuration of a <code>GaugeChartVisual</code>.
        /// </para>
        /// </summary>
        public TooltipOptions TooltipOptions
        {
            get { return this._tooltipOptions; }
            set { this._tooltipOptions = value; }
        }

        // Check to see if TooltipOptions property is set
        internal bool IsSetTooltipOptions()
        {
            return this._tooltipOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a <code>GaugeChartVisual</code>.
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