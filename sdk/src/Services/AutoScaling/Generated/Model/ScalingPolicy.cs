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
    /// Describes a scaling policy.
    /// </summary>
    public partial class ScalingPolicy
    {
        private string _adjustmentType;
        private List<Alarm> _alarms = new List<Alarm>();
        private string _autoScalingGroupName;
        private int? _cooldown;
        private int? _estimatedInstanceWarmup;
        private string _metricAggregationType;
        private int? _minAdjustmentMagnitude;
        private int? _minAdjustmentStep;
        private string _policyARN;
        private string _policyName;
        private string _policyType;
        private int? _scalingAdjustment;
        private List<StepAdjustment> _stepAdjustments = new List<StepAdjustment>();
        private TargetTrackingConfiguration _targetTrackingConfiguration;

        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// The adjustment type, which specifies how <code>ScalingAdjustment</code> is interpreted.
        /// Valid values are <code>ChangeInCapacity</code>, <code>ExactCapacity</code>, and <code>PercentChangeInCapacity</code>.
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
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms related to the policy.
        /// </para>
        /// </summary>
        public List<Alarm> Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null && this._alarms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group associated with this scaling policy.
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
        /// The amount of time, in seconds, after a scaling activity completes before any further
        /// trigger-related scaling activities can start.
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
        /// the CloudWatch metrics.
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
        /// <code>Maximum</code>, and <code>Average</code>.
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
        /// Gets and sets the property PolicyARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy.
        /// </para>
        /// </summary>
        public string PolicyARN
        {
            get { return this._policyARN; }
            set { this._policyARN = value; }
        }

        // Check to see if PolicyARN property is set
        internal bool IsSetPolicyARN()
        {
            return this._policyARN != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the scaling policy.
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
        /// A target tracking policy.
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