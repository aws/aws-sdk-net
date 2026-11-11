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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// This structure specifies the metrics and target utilization settings for a predictive
    /// scaling policy. 
    /// 
    ///  
    /// <para>
    /// You must specify either a metric pair, or a load metric and a scaling metric individually.
    /// Specifying a metric pair instead of individual metrics provides a simpler way to configure
    /// metrics for a scaling policy. You choose the metric pair, and the policy automatically
    /// knows the correct sum and average statistics to use for the load metric and the scaling
    /// metric.
    /// </para>
    ///  
    /// <para>
    /// Example
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You create a predictive scaling policy and specify <c>ALBRequestCount</c> as the value
    /// for the metric pair and <c>1000.0</c> as the target value. For this type of metric,
    /// you must provide the metric dimension for the corresponding target group, so you also
    /// provide a resource label for the Application Load Balancer target group that is attached
    /// to your Auto Scaling group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The number of requests the target group receives per minute provides the load metric,
    /// and the request count averaged between the members of the target group provides the
    /// scaling metric. In CloudWatch, this refers to the <c>RequestCount</c> and <c>RequestCountPerTarget</c>
    /// metrics, respectively.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For optimal use of predictive scaling, you adhere to the best practice of using a
    /// dynamic scaling policy to automatically scale between the minimum capacity and maximum
    /// capacity in response to real-time changes in resource utilization.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon EC2 Auto Scaling consumes data points for the load metric over the last 14
    /// days and creates an hourly load forecast for predictive scaling. (A minimum of 24
    /// hours of data is required.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After creating the load forecast, Amazon EC2 Auto Scaling determines when to reduce
    /// or increase the capacity of your Auto Scaling group in each hour of the forecast period
    /// so that the average number of requests received by each instance is as close to 1000
    /// requests per minute as possible at all times.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about using custom metrics with predictive scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/predictive-scaling-customized-metric-specification.html">Advanced
    /// predictive scaling policy configurations using custom metrics</a> in the <i>Amazon
    /// EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PredictiveScalingMetricSpecification
    {
        /// <summary>
        /// Gets and sets the property CustomizedCapacityMetricSpecification. 
        /// <para>
        /// The customized capacity metric specification.
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedCapacityMetric CustomizedCapacityMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedCapacityMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedCapacityMetricSpecification() => this.CustomizedCapacityMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property CustomizedLoadMetricSpecification. 
        /// <para>
        /// The customized load metric specification.
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedLoadMetric CustomizedLoadMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedLoadMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedLoadMetricSpecification() => this.CustomizedLoadMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property CustomizedScalingMetricSpecification. 
        /// <para>
        /// The customized scaling metric specification.
        /// </para>
        /// </summary>
        public PredictiveScalingCustomizedScalingMetric CustomizedScalingMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedScalingMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedScalingMetricSpecification() => this.CustomizedScalingMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property PredefinedLoadMetricSpecification. 
        /// <para>
        /// The predefined load metric specification.
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedLoadMetric PredefinedLoadMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedLoadMetricSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedLoadMetricSpecification() => this.PredefinedLoadMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property PredefinedMetricPairSpecification. 
        /// <para>
        /// The predefined metric pair specification from which Amazon EC2 Auto Scaling determines
        /// the appropriate scaling metric and load metric to use.
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedMetricPair PredefinedMetricPairSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedMetricPairSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedMetricPairSpecification() => this.PredefinedMetricPairSpecification != null;

        /// <summary>
        /// Gets and sets the property PredefinedScalingMetricSpecification. 
        /// <para>
        /// The predefined scaling metric specification.
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedScalingMetric PredefinedScalingMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedScalingMetricSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedScalingMetricSpecification() => this.PredefinedScalingMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// Specifies the target utilization.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some metrics are based on a count instead of a percentage, such as the request count
        /// for an Application Load Balancer or the number of messages in an SQS queue. If the
        /// scaling policy specifies one of these metrics, specify the target utilization as the
        /// optimal average request or message count per instance during any one-minute interval.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? TargetValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetValue property is set.
        /// </summary>
        internal bool IsSetTargetValue() => this.TargetValue.HasValue;
    }
}
