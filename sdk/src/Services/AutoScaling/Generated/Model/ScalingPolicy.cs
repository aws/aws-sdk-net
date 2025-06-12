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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a scaling policy.
    /// </summary>
    public partial class ScalingPolicy
    {
        private string _adjustmentType;
        private List<Alarm> _alarms = AWSConfigs.InitializeCollections ? new List<Alarm>() : null;
        private string _autoScalingGroupName;
        private int? _cooldown;
        private bool? _enabled;
        private int? _estimatedInstanceWarmup;
        private string _metricAggregationType;
        private int? _minAdjustmentMagnitude;
        private int? _minAdjustmentStep;
        private string _policyARN;
        private string _policyName;
        private string _policyType;
        private PredictiveScalingConfiguration _predictiveScalingConfiguration;
        private int? _scalingAdjustment;
        private List<StepAdjustment> _stepAdjustments = AWSConfigs.InitializeCollections ? new List<StepAdjustment>() : null;
        private TargetTrackingConfiguration _targetTrackingConfiguration;

        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// Specifies how the scaling adjustment is interpreted (for example, an absolute number
        /// or a percentage). The valid values are <c>ChangeInCapacity</c>, <c>ExactCapacity</c>,
        /// and <c>PercentChangeInCapacity</c>.
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
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms related to the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Alarm> Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null && (this._alarms.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The duration of the policy's cooldown period, in seconds.
        /// </para>
        /// </summary>
        public int? Cooldown
        {
            get { return this._cooldown; }
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
        /// Indicates whether the policy is enabled (<c>true</c>) or disabled (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
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
        /// the CloudWatch metrics.
        /// </para>
        /// </summary>
        public int? EstimatedInstanceWarmup
        {
            get { return this._estimatedInstanceWarmup; }
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
        /// The aggregation type for the CloudWatch metrics. The valid values are <c>Minimum</c>,
        /// <c>Maximum</c>, and <c>Average</c>.
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
        /// The minimum value to scale by when the adjustment type is <c>PercentChangeInCapacity</c>.
        /// 
        /// </para>
        /// </summary>
        public int? MinAdjustmentMagnitude
        {
            get { return this._minAdjustmentMagnitude; }
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
        /// Available for backward compatibility. Use <c>MinAdjustmentMagnitude</c> instead.
        /// </para>
        /// </summary>
        public int? MinAdjustmentStep
        {
            get { return this._minAdjustmentStep; }
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
        [AWSProperty(Min=1, Max=1600)]
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
        [AWSProperty(Min=1, Max=255)]
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
        /// One of the following policy types: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>TargetTrackingScaling</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StepScaling</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SimpleScaling</c> (default)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PredictiveScaling</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-target-tracking.html">Target
        /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html">Step
        /// and simple scaling policies</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// Gets and sets the property PredictiveScalingConfiguration. 
        /// <para>
        /// A predictive scaling policy.
        /// </para>
        /// </summary>
        public PredictiveScalingConfiguration PredictiveScalingConfiguration
        {
            get { return this._predictiveScalingConfiguration; }
            set { this._predictiveScalingConfiguration = value; }
        }

        // Check to see if PredictiveScalingConfiguration property is set
        internal bool IsSetPredictiveScalingConfiguration()
        {
            return this._predictiveScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// The amount by which to scale, based on the specified adjustment type. A positive value
        /// adds to the current capacity while a negative number removes from the current capacity.
        /// </para>
        /// </summary>
        public int? ScalingAdjustment
        {
            get { return this._scalingAdjustment; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepAdjustment> StepAdjustments
        {
            get { return this._stepAdjustments; }
            set { this._stepAdjustments = value; }
        }

        // Check to see if StepAdjustments property is set
        internal bool IsSetStepAdjustments()
        {
            return this._stepAdjustments != null && (this._stepAdjustments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetTrackingConfiguration. 
        /// <para>
        /// A target tracking scaling policy.
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