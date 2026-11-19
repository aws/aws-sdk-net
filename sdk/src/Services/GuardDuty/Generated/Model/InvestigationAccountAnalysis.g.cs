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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains an analysis of the findings in an account. Either <c>Trend</c> or <c>Baseline</c>
    /// is set, depending on the <c>AnalysisType</c> of the record.
    /// </summary>
    public partial class InvestigationAccountAnalysis
    {
        /// <summary>
        /// Gets and sets the property Baseline. 
        /// <para>
        /// A comparison of findings against normal behavior. Set when <c>AnalysisType</c> is
        /// <c>BASELINE</c>.
        /// </para>
        /// </summary>
        public Baseline Baseline { get; set; }

        /// <summary>
        /// Checks to see if the Baseline property is set.
        /// </summary>
        internal bool IsSetBaseline() => this.Baseline != null;

        /// <summary>
        /// Gets and sets the property Trend. 
        /// <para>
        /// The trend of findings over time. Set when <c>AnalysisType</c> is <c>TREND</c>.
        /// </para>
        /// </summary>
        public Trend Trend { get; set; }

        /// <summary>
        /// Checks to see if the Trend property is set.
        /// </summary>
        internal bool IsSetTrend() => this.Trend != null;
    }
}
