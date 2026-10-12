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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Contains efficiency metrics for a specific point in time, including an efficiency
    /// score, potential savings, optimizable spend, and timestamp.
    /// </summary>
    public partial class MetricsByTime
    {
        /// <summary>
        /// Gets and sets the property Savings. 
        /// <para>
        /// The estimated savings amount for this time period, representing the potential cost
        /// reduction achieved through optimization recommendations.
        /// </para>
        /// </summary>
        public double? Savings { get; set; }

        /// <summary>
        /// Checks to see if the Savings property is set.
        /// </summary>
        internal bool IsSetSavings() => this.Savings.HasValue;

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The efficiency score for this time period. The score represents a measure of how effectively
        /// the cloud resources are being optimized, with higher scores indicating better optimization
        /// performance.
        /// </para>
        /// </summary>
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property Spend. 
        /// <para>
        /// The total spending amount for this time period.
        /// </para>
        /// </summary>
        public double? Spend { get; set; }

        /// <summary>
        /// Checks to see if the Spend property is set.
        /// </summary>
        internal bool IsSetSpend() => this.Spend.HasValue;

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp for this data point. The format depends on the granularity: YYYY-MM-DD
        /// for daily metrics, or YYYY-MM for monthly metrics.
        /// </para>
        /// </summary>
        public string Timestamp { get; set; }

        /// <summary>
        /// Checks to see if the Timestamp property is set.
        /// </summary>
        internal bool IsSetTimestamp() => this.Timestamp != null;
    }
}
