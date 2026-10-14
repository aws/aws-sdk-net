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
        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// Specifies how the <c>ScalingAdjustment</c> value in a <a href="https://docs.aws.amazon.com/autoscaling/application/APIReference/API_StepAdjustment.html">StepAdjustment</a>
        /// is interpreted (for example, an absolute number or a percentage). The valid values
        /// are <c>ChangeInCapacity</c>, <c>ExactCapacity</c>, and <c>PercentChangeInCapacity</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>AdjustmentType</c> is required if you are adding a new step scaling policy configuration.
        /// </para>
        /// </summary>
        public AdjustmentType AdjustmentType { get; set; }

        /// <summary>
        /// Checks to see if the AdjustmentType property is set.
        /// </summary>
        internal bool IsSetAdjustmentType() => this.AdjustmentType != null;

        /// <summary>
        /// Gets and sets the property Cooldown. 
        /// <para>
        /// The amount of time, in seconds, to wait for a previous scaling activity to take effect.
        /// If not specified, the default value is 300. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/step-scaling-policy-overview.html#step-scaling-cooldown">Cooldown
        /// period</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int? Cooldown { get; set; }

        /// <summary>
        /// Checks to see if the Cooldown property is set.
        /// </summary>
        internal bool IsSetCooldown() => this.Cooldown.HasValue;

        /// <summary>
        /// Gets and sets the property MetricAggregationType. 
        /// <para>
        /// The aggregation type for the CloudWatch metrics. Valid values are <c>Minimum</c>,
        /// <c>Maximum</c>, and <c>Average</c>. If the aggregation type is null, the value is
        /// treated as <c>Average</c>.
        /// </para>
        /// </summary>
        public MetricAggregationType MetricAggregationType { get; set; }

        /// <summary>
        /// Checks to see if the MetricAggregationType property is set.
        /// </summary>
        internal bool IsSetMetricAggregationType() => this.MetricAggregationType != null;

        /// <summary>
        /// Gets and sets the property MinAdjustmentMagnitude. 
        /// <para>
        /// The minimum value to scale by when the adjustment type is <c>PercentChangeInCapacity</c>.
        /// For example, suppose that you create a step scaling policy to scale out an Amazon
        /// ECS service by 25 percent and you specify a <c>MinAdjustmentMagnitude</c> of 2. If
        /// the service has 4 tasks and the scaling policy is performed, 25 percent of 4 is 1.
        /// However, because you specified a <c>MinAdjustmentMagnitude</c> of 2, Application Auto
        /// Scaling scales out the service by 2 tasks.
        /// </para>
        /// </summary>
        public int? MinAdjustmentMagnitude { get; set; }

        /// <summary>
        /// Checks to see if the MinAdjustmentMagnitude property is set.
        /// </summary>
        internal bool IsSetMinAdjustmentMagnitude() => this.MinAdjustmentMagnitude.HasValue;

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
    }
}
