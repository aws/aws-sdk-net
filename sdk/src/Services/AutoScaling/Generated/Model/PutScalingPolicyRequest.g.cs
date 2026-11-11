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
    /// Container for the parameters to the PutScalingPolicy operation. Creates or updates
    /// a scaling policy for an Auto Scaling group. Scaling policies are used to scale an
    /// Auto Scaling group based on configurable metrics. If no policies are defined, the
    /// dynamic scaling and predictive scaling features are not used. <para> For more information
    /// about using dynamic scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-target-tracking.html">Target
    /// tracking scaling policies</a> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html">Step
    /// and simple scaling policies</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para> <para> For more information about using predictive scaling, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-predictive-scaling.html">Predictive
    /// scaling for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para> <para> You can view the scaling policies for an Auto Scaling group using the
    /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribePolicies.html">DescribePolicies</a>
    /// API call. If you are no longer using a scaling policy, you can delete it by calling
    /// the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DeletePolicy.html">DeletePolicy</a>
    /// API. </para>
    /// </summary>
    public partial class PutScalingPolicyRequest : AmazonAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// Specifies how the scaling adjustment is interpreted (for example, an absolute number
        /// or a percentage). The valid values are <c>ChangeInCapacity</c>, <c>ExactCapacity</c>,
        /// and <c>PercentChangeInCapacity</c>.
        /// </para>
        ///  
        /// <para>
        /// Required if the policy type is <c>StepScaling</c> or <c>SimpleScaling</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html#as-scaling-adjustment">Scaling
        /// adjustment types</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentType property is set.
        /// </summary>
        internal bool IsSetAdjustmentType() => this.AdjustmentType != null;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AutoScalingGroupName { get; set; }

        /// <summary>
        /// Checks to see if the AutoScalingGroupName property is set.
        /// </summary>
        internal bool IsSetAutoScalingGroupName() => this.AutoScalingGroupName != null;

        /// <summary>
        /// Gets and sets the property Cooldown. 
        /// <para>
        /// A cooldown period, in seconds, that applies to a specific simple scaling policy. When
        /// a cooldown period is specified here, it overrides the default cooldown.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <c>SimpleScaling</c>. For more information, see <a
        /// href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-scaling-cooldowns.html">Scaling
        /// cooldowns for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: None
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
        /// Indicates whether the scaling policy is enabled or disabled. The default is enabled.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-enable-disable-scaling-policy.html">Disable
        /// a scaling policy for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling User
        /// Guide</i>.
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
        ///  <i>Not needed if the default instance warmup is defined for the group.</i> 
        /// </para>
        ///  
        /// <para>
        /// The estimated time, in seconds, until a newly launched instance can contribute to
        /// the CloudWatch metrics. This warm-up period applies to instances launched due to a
        /// specific target tracking or step scaling policy. When a warm-up period is specified
        /// here, it overrides the default instance warmup.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <c>TargetTrackingScaling</c> or <c>StepScaling</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The default is to use the value for the default instance warmup defined for the group.
        /// If default instance warmup is null, then <c>EstimatedInstanceWarmup</c> falls back
        /// to the value of default cooldown.
        /// </para>
        ///  </note>
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
        /// <c>Maximum</c>, and <c>Average</c>. If the aggregation type is null, the value is
        /// treated as <c>Average</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <c>StepScaling</c>.
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
        /// For example, suppose that you create a step scaling policy to scale out an Auto Scaling
        /// group by 25 percent and you specify a <c>MinAdjustmentMagnitude</c> of 2. If the group
        /// has 4 instances and the scaling policy is performed, 25 percent of 4 is 1. However,
        /// because you specified a <c>MinAdjustmentMagnitude</c> of 2, Amazon EC2 Auto Scaling
        /// scales out the group by 2 instances.
        /// </para>
        ///  
        /// <para>
        /// Valid only if the policy type is <c>StepScaling</c> or <c>SimpleScaling</c>. For more
        /// information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-scaling-simple-step.html#as-scaling-adjustment">Scaling
        /// adjustment types</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some Auto Scaling groups use instance weights. In this case, set the <c>MinAdjustmentMagnitude</c>
        /// to a value that is at least as large as your largest instance weight.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
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
        /// A predictive scaling policy. Provides support for predefined and custom metrics.
        /// </para>
        ///  
        /// <para>
        /// Predefined metrics include CPU utilization, network in/out, and the Application Load
        /// Balancer request count.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_PredictiveScalingConfiguration.html">PredictiveScalingConfiguration</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Required if the policy type is <c>PredictiveScaling</c>.
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
        /// For exact capacity, you must specify a non-negative value.
        /// </para>
        ///  
        /// <para>
        /// Required if the policy type is <c>SimpleScaling</c>. (Not used with any other policy
        /// type.) 
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
        ///  
        /// <para>
        /// Required if the policy type is <c>StepScaling</c>. (Not used with any other policy
        /// type.) 
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
        /// A target tracking scaling policy. Provides support for predefined or custom metrics.
        /// </para>
        ///  
        /// <para>
        /// The following predefined metrics are available:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASGAverageCPUUtilization</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASGAverageNetworkIn</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASGAverageNetworkOut</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALBRequestCountPerTarget</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify <c>ALBRequestCountPerTarget</c> for the metric, you must specify the
        /// <c>ResourceLabel</c> property with the <c>PredefinedMetricSpecification</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_TargetTrackingConfiguration.html">TargetTrackingConfiguration</a>
        /// in the <i>Amazon EC2 Auto Scaling API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// Required if the policy type is <c>TargetTrackingScaling</c>.
        /// </para>
        /// </summary>
        public TargetTrackingConfiguration TargetTrackingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetTrackingConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetTrackingConfiguration() => this.TargetTrackingConfiguration != null;
    }
}
