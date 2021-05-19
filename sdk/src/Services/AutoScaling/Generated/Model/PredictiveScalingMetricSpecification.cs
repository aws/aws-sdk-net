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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
    /// You create a predictive scaling policy and specify <code>ALBRequestCount</code> as
    /// the value for the metric pair and <code>1000.0</code> as the target value. For this
    /// type of metric, you must provide the metric dimension for the corresponding target
    /// group, so you also provide a resource label for the Application Load Balancer target
    /// group that is attached to your Auto Scaling group.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The number of requests the target group receives per minute provides the load metric,
    /// and the request count averaged between the members of the target group provides the
    /// scaling metric. In CloudWatch, this refers to the <code>RequestCount</code> and <code>RequestCountPerTarget</code>
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
    /// </summary>
    public partial class PredictiveScalingMetricSpecification
    {
        private PredictiveScalingPredefinedLoadMetric _predefinedLoadMetricSpecification;
        private PredictiveScalingPredefinedMetricPair _predefinedMetricPairSpecification;
        private PredictiveScalingPredefinedScalingMetric _predefinedScalingMetricSpecification;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property PredefinedLoadMetricSpecification. 
        /// <para>
        /// The load metric specification.
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedLoadMetric PredefinedLoadMetricSpecification
        {
            get { return this._predefinedLoadMetricSpecification; }
            set { this._predefinedLoadMetricSpecification = value; }
        }

        // Check to see if PredefinedLoadMetricSpecification property is set
        internal bool IsSetPredefinedLoadMetricSpecification()
        {
            return this._predefinedLoadMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PredefinedMetricPairSpecification. 
        /// <para>
        /// The metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate
        /// scaling metric and load metric to use.
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedMetricPair PredefinedMetricPairSpecification
        {
            get { return this._predefinedMetricPairSpecification; }
            set { this._predefinedMetricPairSpecification = value; }
        }

        // Check to see if PredefinedMetricPairSpecification property is set
        internal bool IsSetPredefinedMetricPairSpecification()
        {
            return this._predefinedMetricPairSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property PredefinedScalingMetricSpecification. 
        /// <para>
        /// The scaling metric specification.
        /// </para>
        /// </summary>
        public PredictiveScalingPredefinedScalingMetric PredefinedScalingMetricSpecification
        {
            get { return this._predefinedScalingMetricSpecification; }
            set { this._predefinedScalingMetricSpecification = value; }
        }

        // Check to see if PredefinedScalingMetricSpecification property is set
        internal bool IsSetPredefinedScalingMetricSpecification()
        {
            return this._predefinedScalingMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// Specifies the target utilization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double TargetValue
        {
            get { return this._targetValue.GetValueOrDefault(); }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

    }
}