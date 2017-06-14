/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a step scaling policy configuration.
    /// </summary>
    public partial class StepScalingPolicyConfiguration
    {
        private AdjustmentType _adjustmentType;
        private int? _cooldown;
        private MetricAggregationType _metricAggregationType;
        private int? _minAdjustmentMagnitude;
        private List<StepAdjustment> _stepAdjustments = new List<StepAdjustment>();

        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// The adjustment type, which specifies how the <code>ScalingAdjustment</code> parameter
        /// in a <a>StepAdjustment</a> is interpreted.
        /// </para>
        /// </summary>
        public AdjustmentType AdjustmentType
        {
            get { return this._adjustmentType; }
            set { this._adjustmentType = value; }
        }

        // Check to see if AdjustmentType property is set
        internal bool IsSetAdjustmentType()
        {
            return this._adjustmentType != null;
        }

        /// <summary>
        /// Gets and sets the property Cooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scaling activity completes where previous
        /// trigger-related scaling activities can influence future scaling events.
        /// </para>
        ///  
        /// <para>
        /// For scale out policies, while the cooldown period is in effect, the capacity that
        /// has been added by the previous scale out event that initiated the cooldown is calculated
        /// as part of the desired capacity for the next scale out. The intention is to continuously
        /// (but not excessively) scale out. For example, an alarm triggers a step scaling policy
        /// to scale out an Amazon ECS service by 2 tasks, the scaling activity completes successfully,
        /// and a cooldown period of 5 minutes starts. During the Cooldown period, if the alarm
        /// triggers the same policy again but at a more aggressive step adjustment to scale out
        /// the service by 3 tasks, the 2 tasks that were added in the previous scale out event
        /// are considered part of that capacity and only 1 additional task is added to the desired
        /// count.
        /// </para>
        ///  
        /// <para>
        /// For scale in policies, the cooldown period is used to block subsequent scale in requests
        /// until it has expired. The intention is to scale in conservatively to protect your
        /// application's availability. However, if another alarm triggers a scale out policy
        /// during the cooldown period after a scale-in, Application Auto Scaling scales out your
        /// scalable target immediately.
        /// </para>
        /// </summary>
        public int Cooldown
        {
            get { return this._cooldown.GetValueOrDefault(); }
            set { this._cooldown = value; }
        }

        // Check to see if Cooldown property is set
        internal bool IsSetCooldown()
        {
            return this._cooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricAggregationType. 
        /// <para>
        /// The aggregation type for the CloudWatch metrics. Valid values are <code>Minimum</code>,
        /// <code>Maximum</code>, and <code>Average</code>.
        /// </para>
        /// </summary>
        public MetricAggregationType MetricAggregationType
        {
            get { return this._metricAggregationType; }
            set { this._metricAggregationType = value; }
        }

        // Check to see if MetricAggregationType property is set
        internal bool IsSetMetricAggregationType()
        {
            return this._metricAggregationType != null;
        }

        /// <summary>
        /// Gets and sets the property MinAdjustmentMagnitude. 
        /// <para>
        /// The minimum number to adjust your scalable dimension as a result of a scaling activity.
        /// If the adjustment type is <code>PercentChangeInCapacity</code>, the scaling policy
        /// changes the scalable dimension of the scalable target by this amount.
        /// </para>
        /// </summary>
        public int MinAdjustmentMagnitude
        {
            get { return this._minAdjustmentMagnitude.GetValueOrDefault(); }
            set { this._minAdjustmentMagnitude = value; }
        }

        // Check to see if MinAdjustmentMagnitude property is set
        internal bool IsSetMinAdjustmentMagnitude()
        {
            return this._minAdjustmentMagnitude.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StepAdjustments. 
        /// <para>
        /// A set of adjustments that enable you to scale based on the size of the alarm breach.
        /// </para>
        /// </summary>
        public List<StepAdjustment> StepAdjustments
        {
            get { return this._stepAdjustments; }
            set { this._stepAdjustments = value; }
        }

        // Check to see if StepAdjustments property is set
        internal bool IsSetStepAdjustments()
        {
            return this._stepAdjustments != null && this._stepAdjustments.Count > 0; 
        }

    }
}