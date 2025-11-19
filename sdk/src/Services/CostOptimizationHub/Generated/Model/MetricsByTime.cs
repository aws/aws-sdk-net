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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
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
        private double? _savings;
        private double? _score;
        private double? _spend;
        private string _timestamp;

        /// <summary>
        /// Gets and sets the property Savings. 
        /// <para>
        /// The estimated savings amount for this time period, representing the potential cost
        /// reduction achieved through optimization recommendations.
        /// </para>
        /// </summary>
        public double Savings
        {
            get { return this._savings.GetValueOrDefault(); }
            set { this._savings = value; }
        }

        // Check to see if Savings property is set
        internal bool IsSetSavings()
        {
            return this._savings.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The efficiency score for this time period. The score represents a measure of how effectively
        /// the cloud resources are being optimized, with higher scores indicating better optimization
        /// performance.
        /// </para>
        /// </summary>
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Spend. 
        /// <para>
        /// The total spending amount for this time period.
        /// </para>
        /// </summary>
        public double Spend
        {
            get { return this._spend.GetValueOrDefault(); }
            set { this._spend = value; }
        }

        // Check to see if Spend property is set
        internal bool IsSetSpend()
        {
            return this._spend.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// The timestamp for this data point. The format depends on the granularity: YYYY-MM-DD
        /// for daily metrics, or YYYY-MM for monthly metrics.
        /// </para>
        /// </summary>
        public string Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp != null;
        }

    }
}