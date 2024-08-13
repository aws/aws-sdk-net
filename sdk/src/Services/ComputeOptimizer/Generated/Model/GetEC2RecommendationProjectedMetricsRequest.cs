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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetEC2RecommendationProjectedMetrics operation.
    /// Returns the projected utilization metrics of Amazon EC2 instance recommendations.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>Cpu</c> and <c>Memory</c> metrics are the only projected utilization metrics
    /// returned when you run this action. Additionally, the <c>Memory</c> metric is returned
    /// only for resources that have the unified CloudWatch agent installed on them. For more
    /// information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
    /// Memory Utilization with the CloudWatch Agent</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetEC2RecommendationProjectedMetricsRequest : AmazonComputeOptimizerRequest
    {
        private DateTime? _endTime;
        private string _instanceArn;
        private int? _period;
        private RecommendationPreferences _recommendationPreferences;
        private DateTime? _startTime;
        private MetricStatistic _stat;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp of the last projected metrics data point to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instances for which to return recommendation
        /// projected metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the projected metrics data points.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationPreferences. 
        /// <para>
        /// An object to specify the preferences for the Amazon EC2 recommendation projected metrics
        /// to return in the response.
        /// </para>
        /// </summary>
        public RecommendationPreferences RecommendationPreferences
        {
            get { return this._recommendationPreferences; }
            set { this._recommendationPreferences = value; }
        }

        // Check to see if RecommendationPreferences property is set
        internal bool IsSetRecommendationPreferences()
        {
            return this._recommendationPreferences != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp of the first projected metrics data point to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic of the projected metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricStatistic Stat
        {
            get { return this._stat; }
            set { this._stat = value; }
        }

        // Check to see if Stat property is set
        internal bool IsSetStat()
        {
            return this._stat != null;
        }

    }
}