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
    /// Describes a scaling policy.
    /// </summary>
    public partial class ScalingPolicy
    {
        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// Specifies how the scaling adjustment is interpreted (for example, an absolute number
        /// or a percentage). The valid values are <c>ChangeInCapacity</c>, <c>ExactCapacity</c>,
        /// and <c>PercentChangeInCapacity</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentType property is set.
        /// </summary>
        internal bool IsSetAdjustmentType() => this.AdjustmentType != null;

        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        /// The CloudWatch alarms related to the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Alarm> Alarms { get; set; } = AWSConfigs.InitializeCollections ? new List<Alarm>() : null;

        /// <summary>
        /// Checks to see if the Alarms property is set.
        /// </summary>
        internal bool IsSetAlarms() => this.Alarms != null && (this.Alarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property Cooldown. 
        /// <para>
        /// The duration of the policy's cooldown period, in seconds.
        /// </para>
        /// </summary>
        public int? Cooldown { get; set; }

        /// <summary>
        /// Checks to see if the Cooldown property is set.
        /// </summary>
        internal bool IsSetCooldown() => this.Cooldown.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the policy is enabled (<c>true</c>) or disabled (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedInstanceWarmup. 
        /// <para>
        /// The estimated time, in seconds, until a newly launched instance can contribute to
        /// the CloudWatch metrics.
        /// </para>
        /// </summary>
        public int? EstimatedInstanceWarmup { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedInstanceWarmup property is set.
        /// </summary>
        internal bool IsSetEstimatedInstanceWarmup() => this.EstimatedInstanceWarmup.HasValue;

        /// <summary>
        /// Gets and sets the property MetricAggregationType. 
        /// <para>
        /// The aggregation type for the CloudWatch metrics. The valid values are <c>Minimum</c>,
        /// <c>Maximum</c>, and <c>Average</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string MetricAggregationType { get; set; }

        /// <summary>
        /// Checks to see if the MetricAggregationType property is set.
        /// </summary>
        internal bool IsSetMetricAggregationType() => this.MetricAggregationType != null;

        /// <summary>
        /// Gets and sets the property MinAdjustmentMagnitude. 
        /// <para>
        /// The minimum value to scale by when the adjustment type is <c>PercentChangeInCapacity</c>.
        /// 
        /// </para>
        /// </summary>
        public int? MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// Checks to see if the MinAdjustmentMagnitude property is set.
        /// </summary>
        internal bool IsSetMinAdjustmentMagnitude() => this.MinAdjustmentMagnitude.HasValue;

        /// <summary>
        /// Gets and sets the property MinAdjustmentStep. 
        /// <para>
        /// Available for backward compatibility. Use <c>MinAdjustmentMagnitude</c> instead.
        /// </para>
        /// </summary>
        public int? MinAdjustmentStep { get; set; }

        /// <summary>
        /// Checks to see if the MinAdjustmentStep property is set.
        /// </summary>
        internal bool IsSetMinAdjustmentStep() => this.MinAdjustmentStep.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string PolicyARN { get; set; }

        /// <summary>
        /// Checks to see if the PolicyARN property is set.
        /// </summary>
        internal bool IsSetPolicyARN() => this.PolicyARN != null;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

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
        [AWSProperty(Min = 1, Max = 64)]
        public string PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property PredictiveScalingConfiguration. 
        /// <para>
        /// A predictive scaling policy.
        /// </para>
        /// </summary>
        public PredictiveScalingConfiguration PredictiveScalingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the PredictiveScalingConfiguration property is set.
        /// </summary>
        internal bool IsSetPredictiveScalingConfiguration() => this.PredictiveScalingConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// The amount by which to scale, based on the specified adjustment type. A positive value
        /// adds to the current capacity while a negative number removes from the current capacity.
        /// </para>
        /// </summary>
        public int? ScalingAdjustment { get; set; }

        /// <summary>
        /// Checks to see if the ScalingAdjustment property is set.
        /// </summary>
        internal bool IsSetScalingAdjustment() => this.ScalingAdjustment.HasValue;

        /// <summary>
        /// Gets and sets the property StepAdjustments. 
        /// <para>
        /// A set of adjustments that enable you to scale based on the size of the alarm breach.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StepAdjustment> StepAdjustments { get; set; } = AWSConfigs.InitializeCollections ? new List<StepAdjustment>() : null;

        /// <summary>
        /// Checks to see if the StepAdjustments property is set.
        /// </summary>
        internal bool IsSetStepAdjustments() => this.StepAdjustments != null && (this.StepAdjustments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetTrackingConfiguration. 
        /// <para>
        /// A target tracking scaling policy.
        /// </para>
        /// </summary>
        public TargetTrackingConfiguration TargetTrackingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetTrackingConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetTrackingConfiguration() => this.TargetTrackingConfiguration != null;
    }
}
