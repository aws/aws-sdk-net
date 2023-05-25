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
    /// Represents a step scaling policy configuration to use with Application Auto Scaling.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html">Step
    /// scaling policies</a> in the <i>Application Auto Scaling User Guide</i>.
    /// </para>
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
        /// Specifies how the <code>ScalingAdjustment</code> value in a <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_StepAdjustment.html">StepAdjustment</a>
        /// is interpreted (for example, an absolute number or a percentage). The valid values
        /// are <code>ChangeInCapacity</code>, <code>ExactCapacity</code>, and <code>PercentChangeInCapacity</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <code>AdjustmentType</code> is required if you are adding a new step scaling policy
        /// configuration.
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
        /// The amount of time, in seconds, to wait for a previous scaling activity to take effect.
        /// If not specified, the default value is 300. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html#step-scaling-cooldown">Cooldown
        /// period</a> in the <i>Application Auto Scaling User Guide</i>.
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
        /// <code>Maximum</code>, and <code>Average</code>. If the aggregation type is null, the
        /// value is treated as <code>Average</code>.
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
        /// The minimum value to scale by when the adjustment type is <code>PercentChangeInCapacity</code>.
        /// For example, suppose that you create a step scaling policy to scale out an Amazon
        /// ECS service by 25 percent and you specify a <code>MinAdjustmentMagnitude</code> of
        /// 2. If the service has 4 tasks and the scaling policy is performed, 25 percent of 4
        /// is 1. However, because you specified a <code>MinAdjustmentMagnitude</code> of 2, Application
        /// Auto Scaling scales out the service by 2 tasks.
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
        ///  
        /// <para>
        /// At least one step adjustment is required if you are adding a new step scaling policy
        /// configuration.
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