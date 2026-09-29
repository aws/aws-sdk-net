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
    /// The configuration of a <c>GaugeChartVisual</c>.
    /// </summary>
    public partial class GaugeChartConfiguration
    {
        /// <summary>
        /// Gets and sets the property ColorConfiguration. 
        /// <para>
        /// The color configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public GaugeChartColorConfiguration ColorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ColorConfiguration property is set.
        /// </summary>
        internal bool IsSetColorConfiguration() => this.ColorConfiguration != null;

        /// <summary>
        /// Gets and sets the property DataLabels. 
        /// <para>
        /// The data label configuration of a <c>GaugeChartVisual</c>.
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
        /// The field well configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public GaugeChartFieldWells FieldWells { get; set; }

        /// <summary>
        /// Checks to see if the FieldWells property is set.
        /// </summary>
        internal bool IsSetFieldWells() => this.FieldWells != null;

        /// <summary>
        /// Gets and sets the property GaugeChartOptions. 
        /// <para>
        /// The options that determine the presentation of the <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public GaugeChartOptions GaugeChartOptions { get; set; }

        /// <summary>
        /// Checks to see if the GaugeChartOptions property is set.
        /// </summary>
        internal bool IsSetGaugeChartOptions() => this.GaugeChartOptions != null;

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
        /// Gets and sets the property TooltipOptions. 
        /// <para>
        /// The tooltip configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public TooltipOptions TooltipOptions { get; set; }

        /// <summary>
        /// Checks to see if the TooltipOptions property is set.
        /// </summary>
        internal bool IsSetTooltipOptions() => this.TooltipOptions != null;

        /// <summary>
        /// Gets and sets the property VisualPalette. 
        /// <para>
        /// The visual palette configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public VisualPalette VisualPalette { get; set; }

        /// <summary>
        /// Checks to see if the VisualPalette property is set.
        /// </summary>
        internal bool IsSetVisualPalette() => this.VisualPalette != null;
    }
}
