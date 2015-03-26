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
    /// </summary>
    public partial class PutScalingPolicyRequest : AmazonAutoScalingRequest
    {
        private string _adjustmentType;
        private string _autoScalingGroupName;
        private int? _cooldown;
        private int? _minAdjustmentStep;
        private string _policyName;
        private int? _scalingAdjustment;

        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        /// Specifies whether the <code>ScalingAdjustment</code> is an absolute number or a percentage
        /// of the current capacity. Valid values are <code>ChangeInCapacity</code>, <code>ExactCapacity</code>,
        /// and <code>PercentChangeInCapacity</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-scale-based-on-demand.html">Dynamic
        /// Scaling</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// next scaling activity can start.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/Cooldown.html">Understanding
        /// Auto Scaling Cooldowns</a> in the <i>Auto Scaling Developer Guide</i>.
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
        /// Gets and sets the property MinAdjustmentStep. 
        /// <para>
        /// Used with <code>AdjustmentType</code> with the value <code>PercentChangeInCapacity</code>,
        /// the scaling policy changes the <code>DesiredCapacity</code> of the Auto Scaling group
        /// by at least the number of instances specified in the value. 
        /// </para>
        ///  
        /// <para>
        /// You will get a <code>ValidationError</code> if you use <code>MinAdjustmentStep</code>
        /// on a policy with an <code>AdjustmentType</code> other than <code>PercentChangeInCapacity</code>.
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
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        /// The number of instances by which to scale. <code>AdjustmentType</code> determines
        /// the interpretation of this number (e.g., as an absolute number or as a percentage
        /// of the existing Auto Scaling group size). A positive increment adds to the current
        /// capacity and a negative value removes from the current capacity.
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

    }
}