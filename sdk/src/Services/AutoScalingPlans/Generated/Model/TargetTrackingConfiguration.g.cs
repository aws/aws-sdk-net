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

namespace Amazon.AutoScalingPlans.Model
{
    /// <summary>
    /// Describes a target tracking configuration to use with AWS Auto Scaling. Used with
    /// <a>ScalingInstruction</a> and <a>ScalingPolicy</a>.
    /// </summary>
    public partial class TargetTrackingConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomizedScalingMetricSpecification. 
        /// <para>
        /// A customized metric. You can specify either a predefined metric or a customized metric.
        /// 
        /// </para>
        /// </summary>
        public CustomizedScalingMetricSpecification CustomizedScalingMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedScalingMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedScalingMetricSpecification() => this.CustomizedScalingMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property DisableScaleIn. 
        /// <para>
        /// Indicates whether scale in by the target tracking scaling policy is disabled. If the
        /// value is <c>true</c>, scale in is disabled and the target tracking scaling policy
        /// doesn't remove capacity from the scalable resource. Otherwise, scale in is enabled
        /// and the target tracking scaling policy can remove capacity from the scalable resource.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DisableScaleIn { get; set; }

        /// <summary>
        /// Checks to see if the DisableScaleIn property is set.
        /// </summary>
        internal bool IsSetDisableScaleIn() => this.DisableScaleIn.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedInstanceWarmup. 
        /// <para>
        /// The estimated time, in seconds, until a newly launched instance can contribute to
        /// the CloudWatch metrics. This value is used only if the resource is an Auto Scaling
        /// group.
        /// </para>
        /// </summary>
        public int? EstimatedInstanceWarmup { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedInstanceWarmup property is set.
        /// </summary>
        internal bool IsSetEstimatedInstanceWarmup() => this.EstimatedInstanceWarmup.HasValue;

        /// <summary>
        /// Gets and sets the property PredefinedScalingMetricSpecification. 
        /// <para>
        /// A predefined metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public PredefinedScalingMetricSpecification PredefinedScalingMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedScalingMetricSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedScalingMetricSpecification() => this.PredefinedScalingMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property ScaleInCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scale-in activity completes before another
        /// scale-in activity can start. This property is not used if the scalable resource is
        /// an Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// With the <i>scale-in cooldown period</i>, the intention is to scale in conservatively
        /// to protect your application’s availability, so scale-in activities are blocked until
        /// the cooldown period has expired. However, if another alarm triggers a scale-out activity
        /// during the scale-in cooldown period, Auto Scaling scales out the target immediately.
        /// In this case, the scale-in cooldown period stops and doesn't complete.
        /// </para>
        /// </summary>
        public int? ScaleInCooldown { get; set; }

        /// <summary>
        /// Checks to see if the ScaleInCooldown property is set.
        /// </summary>
        internal bool IsSetScaleInCooldown() => this.ScaleInCooldown.HasValue;

        /// <summary>
        /// Gets and sets the property ScaleOutCooldown. 
        /// <para>
        /// The amount of time, in seconds, to wait for a previous scale-out activity to take
        /// effect. This property is not used if the scalable resource is an Auto Scaling group.
        /// </para>
        ///  
        /// <para>
        /// With the <i>scale-out cooldown period</i>, the intention is to continuously (but not
        /// excessively) scale out. After Auto Scaling successfully scales out using a target
        /// tracking scaling policy, it starts to calculate the cooldown time. The scaling policy
        /// won't increase the desired capacity again unless either a larger scale out is triggered
        /// or the cooldown period ends.
        /// </para>
        /// </summary>
        public int? ScaleOutCooldown { get; set; }

        /// <summary>
        /// Checks to see if the ScaleOutCooldown property is set.
        /// </summary>
        internal bool IsSetScaleOutCooldown() => this.ScaleOutCooldown.HasValue;

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the metric. Although this property accepts numbers of type Double,
        /// it won't accept values that are either too small or too large. Values must be in the
        /// range of -2^360 to 2^360.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? TargetValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetValue property is set.
        /// </summary>
        internal bool IsSetTargetValue() => this.TargetValue.HasValue;
    }
}
