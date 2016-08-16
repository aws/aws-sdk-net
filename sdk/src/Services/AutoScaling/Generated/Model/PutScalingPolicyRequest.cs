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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutScalingPolicy operation.
    /// Creates or updates a policy for an Auto Scaling group. To update an existing policy,
    /// use the existing policy name and set the parameters you want to change. Any existing
    /// parameter not changed in an update to an existing policy is not changed in this update
    /// request.
    /// 
    ///  
    /// <para>
    /// If you exceed your maximum limit of step adjustments, which by default is 20 per region,
    /// the call fails. For information about updating this limit, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html">AWS
    /// Service Limits</a> in the <i>Amazon Web Services General Reference</i>.
    /// </para>
    /// </summary>
    public partial class PutScalingPolicyRequest : AmazonAutoScalingRequest
    {
        private string _adjustmentType;
        private string _autoScalingGroupName;
        private int? _cooldown;
        private int? _estimatedInstanceWarmup;
        private string _metricAggregationType;
        private int? _minAdjustmentMagnitude;
        private int? _minAdjustmentStep;
        private string _policyName;
        private string _policyType;
        private int? _scalingAdjustment;
        private List<StepAdjustment> _stepAdjustments = new List<StepAdjustment>();

        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// The adjustment type. Valid values are <code>ChangeInCapacity</code>, <code>ExactCapacity</code>,
        /// and <code>PercentChangeInCapacity</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-scale-based-on-demand.html">Dynamic
        /// Scaling</a> in the <i>Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public string AdjustmentType
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
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name or ARN of the group.
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Cooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scaling activity completes and before the
        /// next scaling activity can start. If this parameter is not specified, the default cooldown
        /// period for the group applies.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported unless the policy type is <code>SimpleScaling</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/Cooldown.html">Auto
        /// Scaling Cooldowns</a> in the <i>Auto Scaling User Guide</i>.
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
        /// Gets and sets the property EstimatedInstanceWarmup. 
        /// <para>
        /// The estimated time, in seconds, until a newly launched instance can contribute to
        /// the CloudWatch metrics. The default is to use the value specified for the default
        /// cooldown period for the group.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported if the policy type is <code>SimpleScaling</code>.
        /// </para>
        /// </summary>
        public int EstimatedInstanceWarmup
        {
            get { return this._estimatedInstanceWarmup.GetValueOrDefault(); }
            set { this._estimatedInstanceWarmup = value; }
        }

        // Check to see if EstimatedInstanceWarmup property is set
        internal bool IsSetEstimatedInstanceWarmup()
        {
            return this._estimatedInstanceWarmup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricAggregationType. 
        /// <para>
        /// The aggregation type for the CloudWatch metrics. Valid values are <code>Minimum</code>,
        /// <code>Maximum</code>, and <code>Average</code>. If the aggregation type is null, the
        /// value is treated as <code>Average</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported if the policy type is <code>SimpleScaling</code>.
        /// </para>
        /// </summary>
        public string MetricAggregationType
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
        /// The minimum number of instances to scale. If the value of <code>AdjustmentType</code>
        /// is <code>PercentChangeInCapacity</code>, the scaling policy changes the <code>DesiredCapacity</code>
        /// of the Auto Scaling group by at least this many instances. Otherwise, the error is
        /// <code>ValidationError</code>.
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
        /// Gets and sets the property MinAdjustmentStep. 
        /// <para>
        /// Available for backward compatibility. Use <code>MinAdjustmentMagnitude</code> instead.
        /// </para>
        /// </summary>
        public int MinAdjustmentStep
        {
            get { return this._minAdjustmentStep.GetValueOrDefault(); }
            set { this._minAdjustmentStep = value; }
        }

        // Check to see if MinAdjustmentStep property is set
        internal bool IsSetMinAdjustmentStep()
        {
            return this._minAdjustmentStep.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The policy type. Valid values are <code>SimpleScaling</code> and <code>StepScaling</code>.
        /// If the policy type is null, the value is treated as <code>SimpleScaling</code>.
        /// </para>
        /// </summary>
        public string PolicyType
        {
            get { return this._policyType; }
            set { this._policyType = value; }
        }

        // Check to see if PolicyType property is set
        internal bool IsSetPolicyType()
        {
            return this._policyType != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// The amount by which to scale, based on the specified adjustment type. A positive value
        /// adds to the current capacity while a negative number removes from the current capacity.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if the policy type is <code>SimpleScaling</code> and not
        /// supported otherwise.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property StepAdjustments. 
        /// <para>
        /// A set of adjustments that enable you to scale based on the size of the alarm breach.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if the policy type is <code>StepScaling</code> and not
        /// supported otherwise.
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