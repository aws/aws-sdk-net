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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a step adjustment for a <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_StepScalingPolicyConfiguration.html">StepScalingPolicyConfiguration</a>.
    /// Describes an adjustment based on the difference between the value of the aggregated
    /// CloudWatch metric and the breach threshold that you've defined for the alarm. 
    /// 
    ///  
    /// <para>
    /// For the following examples, suppose that you have an alarm with a breach threshold
    /// of 50:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To initiate the adjustment when the metric is greater than or equal to 50 and less
    /// than 60, specify a lower bound of <code>0</code> and an upper bound of <code>10</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To initiate the adjustment when the metric is greater than 40 and less than or equal
    /// to 50, specify a lower bound of <code>-10</code> and an upper bound of <code>0</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// There are a few rules for the step adjustments for your step policy:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The ranges of your step adjustments can't overlap or have a gap.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// At most one step adjustment can have a null lower bound. If one step adjustment has
    /// a negative lower bound, then there must be a step adjustment with a null lower bound.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// At most one step adjustment can have a null upper bound. If one step adjustment has
    /// a positive upper bound, then there must be a step adjustment with a null upper bound.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The upper and lower bound can't be null in the same step adjustment.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StepAdjustment
    {
        private double? _metricIntervalLowerBound;
        private double? _metricIntervalUpperBound;
        private int? _scalingAdjustment;

        /// <summary>
        /// Gets and sets the property MetricIntervalLowerBound. 
        /// <para>
        /// The lower bound for the difference between the alarm threshold and the CloudWatch
        /// metric. If the metric value is above the breach threshold, the lower bound is inclusive
        /// (the metric must be greater than or equal to the threshold plus the lower bound).
        /// Otherwise, it's exclusive (the metric must be greater than the threshold plus the
        /// lower bound). A null value indicates negative infinity.
        /// </para>
        /// </summary>
        public double MetricIntervalLowerBound
        {
            get { return this._metricIntervalLowerBound.GetValueOrDefault(); }
            set { this._metricIntervalLowerBound = value; }
        }

        // Check to see if MetricIntervalLowerBound property is set
        internal bool IsSetMetricIntervalLowerBound()
        {
            return this._metricIntervalLowerBound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricIntervalUpperBound. 
        /// <para>
        /// The upper bound for the difference between the alarm threshold and the CloudWatch
        /// metric. If the metric value is above the breach threshold, the upper bound is exclusive
        /// (the metric must be less than the threshold plus the upper bound). Otherwise, it's
        /// inclusive (the metric must be less than or equal to the threshold plus the upper bound).
        /// A null value indicates positive infinity.
        /// </para>
        ///  
        /// <para>
        /// The upper bound must be greater than the lower bound.
        /// </para>
        /// </summary>
        public double MetricIntervalUpperBound
        {
            get { return this._metricIntervalUpperBound.GetValueOrDefault(); }
            set { this._metricIntervalUpperBound = value; }
        }

        // Check to see if MetricIntervalUpperBound property is set
        internal bool IsSetMetricIntervalUpperBound()
        {
            return this._metricIntervalUpperBound.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// The amount by which to scale, based on the specified adjustment type. A positive value
        /// adds to the current capacity while a negative number removes from the current capacity.
        /// For exact capacity, you must specify a positive value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int ScalingAdjustment
        {
            get { return this._scalingAdjustment.GetValueOrDefault(); }
            set { this._scalingAdjustment = value; }
        }

        // Check to see if ScalingAdjustment property is set
        internal bool IsSetScalingAdjustment()
        {
            return this._scalingAdjustment.HasValue; 
        }

    }
}