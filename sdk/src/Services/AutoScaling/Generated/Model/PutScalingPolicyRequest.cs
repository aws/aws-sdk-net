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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutScalingPolicy operation.
    /// Creates or updates a scaling policy for an Auto Scaling group.
    /// 
    ///  
    /// <para>
    /// For more information about using scaling policies to scale your Auto Scaling group,
    /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-target-tracking.html">Target
    /// Tracking Scaling Policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html">Step
    /// and Simple Scaling Policies</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutScalingPolicyRequest : AmazonAutoScalingRequest
    {
        private string _adjustmentType;
        private string _autoScalingGroupName;
        private int? _cooldown;
        private bool? _enabled;
        private int? _estimatedInstanceWarmup;
        private string _metricAggregationType;
        private int? _minAdjustmentMagnitude;
        private int? _minAdjustmentStep;
        private string _policyName;
        private string _policyType;
        private int? _scalingAdjustment;
        private List<StepAdjustment> _stepAdjustments = new List<StepAdjustment>();
        private TargetTrackingConfiguration _targetTrackingConfiguration;

        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// Specifies whether the <code>ScalingAdjustment</code> parameter is an absolute number
        /// or a percentage of the current capacity. The valid values are <code>ChangeInCapacity</code>,
        /// <code>ExactCapacity</code>, and <code>PercentChangeInCapacity</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <code>StepScaling</code> or <code>SimpleScaling</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html#as-scaling-adjustment">Scaling
        /// Adjustment Types</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
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
        /// The amount of time, in seconds, after a scaling activity completes before any further
        /// dynamic scaling activities can start. If this parameter is not specified, the default
        /// cooldown period for the group applies.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <code>SimpleScaling</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/Cooldown.html">Scaling
        /// Cooldowns</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the scaling policy is enabled or disabled. The default is enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enable-disable-scaling-policy.html">Disabling
        /// a Scaling Policy for an Auto Scaling Group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
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
        /// Valid only if the policy type is <code>StepScaling</code> or <code>TargetTrackingScaling</code>.
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
        /// The aggregation type for the CloudWatch metrics. The valid values are <code>Minimum</code>,
        /// <code>Maximum</code>, and <code>Average</code>. If the aggregation type is null, the
        /// value is treated as <code>Average</code>.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <code>StepScaling</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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
        /// The minimum value to scale by when scaling by percentages. For example, suppose that
        /// you create a step scaling policy to scale out an Auto Scaling group by 25 percent
        /// and you specify a <code>MinAdjustmentMagnitude</code> of 2. If the group has 4 instances
        /// and the scaling policy is performed, 25 percent of 4 is 1. However, because you specified
        /// a <code>MinAdjustmentMagnitude</code> of 2, Amazon EC2 Auto Scaling scales out the
        /// group by 2 instances. 
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <code>StepScaling</code> or <code>SimpleScaling</code>
        /// and the adjustment type is <code>PercentChangeInCapacity</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html#as-scaling-adjustment">Scaling
        /// Adjustment Types</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The policy type. The valid values are <code>SimpleScaling</code>, <code>StepScaling</code>,
        /// and <code>TargetTrackingScaling</code>. If the policy type is null, the value is treated
        /// as <code>SimpleScaling</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The amount by which a simple scaling policy scales the Auto Scaling group in response
        /// to an alarm breach. The adjustment is based on the value that you specified in the
        /// <code>AdjustmentType</code> parameter (either an absolute number or a percentage).
        /// A positive value adds to the current capacity and a negative value subtracts from
        /// the current capacity. For exact capacity, you must specify a positive value.
        /// </para>
        ///  
        /// <para>
        /// Conditional: If you specify <code>SimpleScaling</code> for the policy type, you must
        /// specify this parameter. (Not used with any other policy type.) 
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
        /// Conditional: If you specify <code>StepScaling</code> for the policy type, you must
        /// specify this parameter. (Not used with any other policy type.) 
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

        /// <summary>
        /// Gets and sets the property TargetTrackingConfiguration. 
        /// <para>
        /// A target tracking scaling policy. Includes support for predefined or customized metrics.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_TargetTrackingConfiguration.html">TargetTrackingConfiguration</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Conditional: If you specify <code>TargetTrackingScaling</code> for the policy type,
        /// you must specify this parameter. (Not used with any other policy type.) 
        /// </para>
        /// </summary>
        public TargetTrackingConfiguration TargetTrackingConfiguration
        {
            get { return this._targetTrackingConfiguration; }
            set { this._targetTrackingConfiguration = value; }
        }

        // Check to see if TargetTrackingConfiguration property is set
        internal bool IsSetTargetTrackingConfiguration()
        {
            return this._targetTrackingConfiguration != null;
        }

    }
}