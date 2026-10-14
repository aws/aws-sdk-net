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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Container for the parameters to the GetEC2RecommendationProjectedMetrics operation.
    /// Returns the projected utilization metrics of Amazon EC2 instance recommendations.
    /// <note> <para> The <c>Cpu</c> and <c>Memory</c> metrics are the only projected utilization
    /// metrics returned when you run this action. Additionally, the <c>Memory</c> metric
    /// is returned only for resources that have the unified CloudWatch agent installed on
    /// them. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
    /// Memory Utilization with the CloudWatch Agent</a>. </para> </note>
    /// </summary>
    public partial class GetEC2RecommendationProjectedMetricsRequest : AmazonComputeOptimizerRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp of the last projected metrics data point to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the instances for which to return recommendation
        /// projected metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the projected metrics data points.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Period { get; set; }

        /// <summary>
        /// Checks to see if the Period property is set.
        /// </summary>
        internal bool IsSetPeriod() => this.Period.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendationPreferences. 
        /// <para>
        /// An object to specify the preferences for the Amazon EC2 recommendation projected metrics
        /// to return in the response.
        /// </para>
        /// </summary>
        public RecommendationPreferences RecommendationPreferences { get; set; }

        /// <summary>
        /// Checks to see if the RecommendationPreferences property is set.
        /// </summary>
        internal bool IsSetRecommendationPreferences() => this.RecommendationPreferences != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp of the first projected metrics data point to return.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Stat. 
        /// <para>
        /// The statistic of the projected metrics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MetricStatistic Stat { get; set; }

        /// <summary>
        /// Checks to see if the Stat property is set.
        /// </summary>
        internal bool IsSetStat() => this.Stat != null;
    }
}
