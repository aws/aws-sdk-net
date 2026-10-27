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

namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// Represents a target tracking scaling policy configuration to use with Application
    /// Auto Scaling.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html">Target
    /// tracking scaling policies</a> in the <i>Application Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TargetTrackingScalingPolicyConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomizedMetricSpecification. 
        /// <para>
        /// A customized metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public CustomizedMetricSpecification CustomizedMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CustomizedMetricSpecification property is set.
        /// </summary>
        internal bool IsSetCustomizedMetricSpecification() => this.CustomizedMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property DisableScaleIn. 
        /// <para>
        /// Indicates whether scale in by the target tracking scaling policy is disabled. If the
        /// value is <c>true</c>, scale in is disabled and the target tracking scaling policy
        /// won't remove capacity from the scalable target. Otherwise, scale in is enabled and
        /// the target tracking scaling policy can remove capacity from the scalable target. The
        /// default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DisableScaleIn { get; set; }

        /// <summary>
        /// Checks to see if the DisableScaleIn property is set.
        /// </summary>
        internal bool IsSetDisableScaleIn() => this.DisableScaleIn.HasValue;

        /// <summary>
        /// Gets and sets the property PredefinedMetricSpecification. 
        /// <para>
        /// A predefined metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public PredefinedMetricSpecification PredefinedMetricSpecification { get; set; }

        /// <summary>
        /// Checks to see if the PredefinedMetricSpecification property is set.
        /// </summary>
        internal bool IsSetPredefinedMetricSpecification() => this.PredefinedMetricSpecification != null;

        /// <summary>
        /// Gets and sets the property ScaleInCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scale-in activity completes before another
        /// scale-in activity can start. For more information and for default values, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/target-tracking-scaling-policy-overview.html#target-tracking-cooldown">Define
        /// cooldown periods</a> in the <i>Application Auto Scaling User Guide</i>.
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
        /// effect. For more information and for default values, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/target-tracking-scaling-policy-overview.html#target-tracking-cooldown">Define
        /// cooldown periods</a> in the <i>Application Auto Scaling User Guide</i>.
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
        /// range of -2^360 to 2^360. The value must be a valid number based on the choice of
        /// metric. For example, if the metric is CPU utilization, then the target value is a
        /// percent value that represents how much of the CPU can be used before scaling out.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the scaling policy specifies the <c>ALBRequestCountPerTarget</c> predefined metric,
        /// specify the target utilization as the optimal average request count per target during
        /// any one-minute interval.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? TargetValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetValue property is set.
        /// </summary>
        internal bool IsSetTargetValue() => this.TargetValue.HasValue;
    }
}
