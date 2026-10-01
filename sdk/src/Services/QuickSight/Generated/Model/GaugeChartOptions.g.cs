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
    /// The options that determine the presentation of the <c>GaugeChartVisual</c>.
    /// </summary>
    public partial class GaugeChartOptions
    {
        /// <summary>
        /// Gets and sets the property Arc. 
        /// <para>
        /// The arc configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public ArcConfiguration Arc { get; set; }

        /// <summary>
        /// Checks to see if the Arc property is set.
        /// </summary>
        internal bool IsSetArc() => this.Arc != null;

        /// <summary>
        /// Gets and sets the property ArcAxis. 
        /// <para>
        /// The arc axis configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public ArcAxisConfiguration ArcAxis { get; set; }

        /// <summary>
        /// Checks to see if the ArcAxis property is set.
        /// </summary>
        internal bool IsSetArcAxis() => this.ArcAxis != null;

        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The comparison configuration of a <c>GaugeChartVisual</c>.
        /// </para>
        /// </summary>
        public ComparisonConfiguration Comparison { get; set; }

        /// <summary>
        /// Checks to see if the Comparison property is set.
        /// </summary>
        internal bool IsSetComparison() => this.Comparison != null;

        /// <summary>
        /// Gets and sets the property PrimaryValueDisplayType. 
        /// <para>
        /// The options that determine the primary value display type.
        /// </para>
        /// </summary>
        public PrimaryValueDisplayType PrimaryValueDisplayType { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryValueDisplayType property is set.
        /// </summary>
        internal bool IsSetPrimaryValueDisplayType() => this.PrimaryValueDisplayType != null;

        /// <summary>
        /// Gets and sets the property PrimaryValueFontConfiguration. 
        /// <para>
        /// The options that determine the primary value font configuration.
        /// </para>
        /// </summary>
        public FontConfiguration PrimaryValueFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryValueFontConfiguration property is set.
        /// </summary>
        internal bool IsSetPrimaryValueFontConfiguration() => this.PrimaryValueFontConfiguration != null;
    }
}
