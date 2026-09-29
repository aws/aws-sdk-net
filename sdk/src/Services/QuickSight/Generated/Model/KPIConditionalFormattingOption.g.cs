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
    /// The conditional formatting options of a KPI visual.
    /// </summary>
    public partial class KPIConditionalFormattingOption
    {
        /// <summary>
        /// Gets and sets the property ActualValue. 
        /// <para>
        /// The conditional formatting for the actual value of a KPI visual.
        /// </para>
        /// </summary>
        public KPIActualValueConditionalFormatting ActualValue { get; set; }

        /// <summary>
        /// Checks to see if the ActualValue property is set.
        /// </summary>
        internal bool IsSetActualValue() => this.ActualValue != null;

        /// <summary>
        /// Gets and sets the property ComparisonValue. 
        /// <para>
        /// The conditional formatting for the comparison value of a KPI visual.
        /// </para>
        /// </summary>
        public KPIComparisonValueConditionalFormatting ComparisonValue { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonValue property is set.
        /// </summary>
        internal bool IsSetComparisonValue() => this.ComparisonValue != null;

        /// <summary>
        /// Gets and sets the property PrimaryValue. 
        /// <para>
        /// The conditional formatting for the primary value of a KPI visual.
        /// </para>
        /// </summary>
        public KPIPrimaryValueConditionalFormatting PrimaryValue { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryValue property is set.
        /// </summary>
        internal bool IsSetPrimaryValue() => this.PrimaryValue != null;

        /// <summary>
        /// Gets and sets the property ProgressBar. 
        /// <para>
        /// The conditional formatting for the progress bar of a KPI visual.
        /// </para>
        /// </summary>
        public KPIProgressBarConditionalFormatting ProgressBar { get; set; }

        /// <summary>
        /// Checks to see if the ProgressBar property is set.
        /// </summary>
        internal bool IsSetProgressBar() => this.ProgressBar != null;
    }
}
