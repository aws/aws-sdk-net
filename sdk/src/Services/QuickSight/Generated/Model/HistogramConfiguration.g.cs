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
    /// The configuration for a <c>HistogramVisual</c>.
    /// </summary>
    public partial class HistogramConfiguration
    {
        /// <summary>
        /// Gets and sets the property BinOptions. 
        /// <para>
        /// The options that determine the presentation of histogram bins.
        /// </para>
        /// </summary>
        public HistogramBinOptions BinOptions { get; set; }

        /// <summary>
        /// Checks to see if the BinOptions property is set.
        /// </summary>
        internal bool IsSetBinOptions() => this.BinOptions != null;

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The data label configuration of a histogram.
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
        /// The field well configuration of a histogram.
        /// </para>
        /// </summary>
        public HistogramFieldWells FieldWells { get; set; }

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
        /// Gets and sets the property Tooltip. 
        /// <para>
        /// The tooltip configuration of a histogram.
        /// </para>
        /// </summary>
        public TooltipOptions Tooltip { get; set; }

        /// <summary>
        /// Checks to see if the Tooltip property is set.
        /// </summary>
        internal bool IsSetTooltip() => this.Tooltip != null;

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a histogram.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette { get; set; }

        /// <summary>
        /// Checks to see if the VisualPalette property is set.
        /// </summary>
        internal bool IsSetVisualPalette() => this.VisualPalette != null;

        /// <summary>
        /// Gets and sets the property XAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the x-axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions XAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the XAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetXAxisDisplayOptions() => this.XAxisDisplayOptions != null;

        /// <summary>
        /// Gets and sets the property XAxisLabelOptions. 
        /// <para>
        /// The options that determine the presentation of the x-axis label.
        /// </para>
        /// </summary>
        public ChartAxisLabelOptions XAxisLabelOptions { get; set; }

        /// <summary>
        /// Checks to see if the XAxisLabelOptions property is set.
        /// </summary>
        internal bool IsSetXAxisLabelOptions() => this.XAxisLabelOptions != null;

        /// <summary>
        /// Gets and sets the property YAxisDisplayOptions. 
        /// <para>
        /// The options that determine the presentation of the y-axis.
        /// </para>
        /// </summary>
        public AxisDisplayOptions YAxisDisplayOptions { get; set; }

        /// <summary>
        /// Checks to see if the YAxisDisplayOptions property is set.
        /// </summary>
        internal bool IsSetYAxisDisplayOptions() => this.YAxisDisplayOptions != null;
    }
}
