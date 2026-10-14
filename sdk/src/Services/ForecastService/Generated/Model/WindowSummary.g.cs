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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// The metrics for a time range within the evaluation portion of a dataset. This object
    /// is part of the <a>EvaluationResult</a> object.
    /// 
    ///  
    /// <para>
    /// The <c>TestWindowStart</c> and <c>TestWindowEnd</c> parameters are determined by the
    /// <c>BackTestWindowOffset</c> parameter of the <a>EvaluationParameters</a> object.
    /// </para>
    /// </summary>
    public partial class WindowSummary
    {
        /// <summary>
        /// Gets and sets the property EvaluationType. 
        /// <para>
        /// The type of evaluation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUMMARY</c> - The average metrics across all windows.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPUTED</c> - The metrics for the specified window.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EvaluationType EvaluationType { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationType property is set.
        /// </summary>
        internal bool IsSetEvaluationType() => this.EvaluationType != null;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of data points within the window.
        /// </para>
        /// </summary>
        public int? ItemCount { get; set; }

        /// <summary>
        /// Checks to see if the ItemCount property is set.
        /// </summary>
        internal bool IsSetItemCount() => this.ItemCount.HasValue;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Provides metrics used to evaluate the performance of a predictor.
        /// </para>
        /// </summary>
        public Metrics Metrics { get; set; }

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null;

        /// <summary>
        /// Gets and sets the property TestWindowEnd. 
        /// <para>
        /// The timestamp that defines the end of the window.
        /// </para>
        /// </summary>
        public DateTime? TestWindowEnd { get; set; }

        /// <summary>
        /// Checks to see if the TestWindowEnd property is set.
        /// </summary>
        internal bool IsSetTestWindowEnd() => this.TestWindowEnd.HasValue;

        /// <summary>
        /// Gets and sets the property TestWindowStart. 
        /// <para>
        /// The timestamp that defines the start of the window.
        /// </para>
        /// </summary>
        public DateTime? TestWindowStart { get; set; }

        /// <summary>
        /// Checks to see if the TestWindowStart property is set.
        /// </summary>
        internal bool IsSetTestWindowStart() => this.TestWindowStart.HasValue;
    }
}
