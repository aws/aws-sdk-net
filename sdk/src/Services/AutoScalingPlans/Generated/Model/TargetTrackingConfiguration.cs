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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
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
        private CustomizedScalingMetricSpecification _customizedScalingMetricSpecification;
        private bool? _disableScaleIn;
        private int? _estimatedInstanceWarmup;
        private PredefinedScalingMetricSpecification _predefinedScalingMetricSpecification;
        private int? _scaleInCooldown;
        private int? _scaleOutCooldown;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property CustomizedScalingMetricSpecification. 
        /// <para>
        /// A customized metric. You can specify either a predefined metric or a customized metric.
        /// 
        /// </para>
        /// </summary>
        public CustomizedScalingMetricSpecification CustomizedScalingMetricSpecification
        {
            get { return this._customizedScalingMetricSpecification; }
            set { this._customizedScalingMetricSpecification = value; }
        }

        // Check to see if CustomizedScalingMetricSpecification property is set
        internal bool IsSetCustomizedScalingMetricSpecification()
        {
            return this._customizedScalingMetricSpecification != null;
        }

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
        public bool? DisableScaleIn
        {
            get { return this._disableScaleIn; }
            set { this._disableScaleIn = value; }
        }

        // Check to see if DisableScaleIn property is set
        internal bool IsSetDisableScaleIn()
        {
            return this._disableScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedInstanceWarmup. 
        /// <para>
        /// The estimated time, in seconds, until a newly launched instance can contribute to
        /// the CloudWatch metrics. This value is used only if the resource is an Auto Scaling
        /// group.
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
        /// Gets and sets the property PredefinedScalingMetricSpecification. 
        /// <para>
        /// A predefined metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public PredefinedScalingMetricSpecification PredefinedScalingMetricSpecification
        {
            get { return this._predefinedScalingMetricSpecification; }
            set { this._predefinedScalingMetricSpecification = value; }
        }

        // Check to see if PredefinedScalingMetricSpecification property is set
        internal bool IsSetPredefinedScalingMetricSpecification()
        {
            return this._predefinedScalingMetricSpecification != null;
        }

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
        public int? ScaleInCooldown
        {
            get { return this._scaleInCooldown; }
            set { this._scaleInCooldown = value; }
        }

        // Check to see if ScaleInCooldown property is set
        internal bool IsSetScaleInCooldown()
        {
            return this._scaleInCooldown.HasValue; 
        }

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
        public int? ScaleOutCooldown
        {
            get { return this._scaleOutCooldown; }
            set { this._scaleOutCooldown = value; }
        }

        // Check to see if ScaleOutCooldown property is set
        internal bool IsSetScaleOutCooldown()
        {
            return this._scaleOutCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the metric. Although this property accepts numbers of type Double,
        /// it won't accept values that are either too small or too large. Values must be in the
        /// range of -2^360 to 2^360.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? TargetValue
        {
            get { return this._targetValue; }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

    }
}