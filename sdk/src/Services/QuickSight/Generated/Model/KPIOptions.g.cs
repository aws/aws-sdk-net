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
    /// The options that determine the presentation of a KPI visual.
    /// </summary>
    public partial class KPIOptions
    {
        /// <summary>
        /// Gets and sets the property Comparison. 
        /// <para>
        /// The comparison configuration of a KPI visual.
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

        /// <summary>
        /// Gets and sets the property ProgressBar. 
        /// <para>
        /// The options that determine the presentation of the progress bar of a KPI visual.
        /// </para>
        /// </summary>
        public ProgressBarOptions ProgressBar { get; set; }

        /// <summary>
        /// Checks to see if the ProgressBar property is set.
        /// </summary>
        internal bool IsSetProgressBar() => this.ProgressBar != null;

        /// <summary>
        /// Gets and sets the property SecondaryValue. 
        /// <para>
        /// The options that determine the presentation of the secondary value of a KPI visual.
        /// </para>
        /// </summary>
        public SecondaryValueOptions SecondaryValue { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryValue property is set.
        /// </summary>
        internal bool IsSetSecondaryValue() => this.SecondaryValue != null;

        /// <summary>
        /// Gets and sets the property SecondaryValueFontConfiguration. 
        /// <para>
        /// The options that determine the secondary value font configuration.
        /// </para>
        /// </summary>
        public FontConfiguration SecondaryValueFontConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryValueFontConfiguration property is set.
        /// </summary>
        internal bool IsSetSecondaryValueFontConfiguration() => this.SecondaryValueFontConfiguration != null;

        /// <summary>
        /// Gets and sets the property Sparkline. 
        /// <para>
        /// The options that determine the visibility, color, type, and tooltip visibility of
        /// the sparkline of a KPI visual.
        /// </para>
        /// </summary>
        public KPISparklineOptions Sparkline { get; set; }

        /// <summary>
        /// Checks to see if the Sparkline property is set.
        /// </summary>
        internal bool IsSetSparkline() => this.Sparkline != null;

        /// <summary>
        /// Gets and sets the property TrendArrows. 
        /// <para>
        /// The options that determine the presentation of trend arrows in a KPI visual.
        /// </para>
        /// </summary>
        public TrendArrowOptions TrendArrows { get; set; }

        /// <summary>
        /// Checks to see if the TrendArrows property is set.
        /// </summary>
        internal bool IsSetTrendArrows() => this.TrendArrows != null;

        /// <summary>
        /// Gets and sets the property VisualLayoutOptions. 
        /// <para>
        /// The options that determine the layout a KPI visual.
        /// </para>
        /// </summary>
        public KPIVisualLayoutOptions VisualLayoutOptions { get; set; }

        /// <summary>
        /// Checks to see if the VisualLayoutOptions property is set.
        /// </summary>
        internal bool IsSetVisualLayoutOptions() => this.VisualLayoutOptions != null;
    }
}
