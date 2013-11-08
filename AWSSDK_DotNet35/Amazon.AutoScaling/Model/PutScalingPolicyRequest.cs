/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Creates or updates a policy for an Auto Scaling group. To update an existing policy, use the existing policy name and set the
    /// parameter(s) you want to change. Any existing parameter not changed in an update to an existing policy is not changed in this update
    /// request. </para>
    /// </summary>
    public partial class PutScalingPolicyRequest : AmazonWebServiceRequest
    {
        private string autoScalingGroupName;
        private string policyName;
        private int? scalingAdjustment;
        private string adjustmentType;
        private int? cooldown;
        private int? minAdjustmentStep;

        /// <summary>
        /// The name or ARN of the Auto Scaling group.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 1600</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this.autoScalingGroupName; }
            set { this.autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this.autoScalingGroupName != null;
        }

        /// <summary>
        /// The name of the policy you want to create or update.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this.policyName; }
            set { this.policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this.policyName != null;
        }

        /// <summary>
        /// The number of instances by which to scale. <c>AdjustmentType</c> determines the interpretation of this number (e.g., as an absolute number
        /// or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes
        /// from the current capacity.
        ///  
        /// </summary>
        public int ScalingAdjustment
        {
            get { return this.scalingAdjustment ?? default(int); }
            set { this.scalingAdjustment = value; }
        }

        // Check to see if ScalingAdjustment property is set
        internal bool IsSetScalingAdjustment()
        {
            return this.scalingAdjustment.HasValue;
        }

        /// <summary>
        /// Specifies whether the <c>ScalingAdjustment</c> is an absolute number or a percentage of the current capacity. Valid values are
        /// <c>ChangeInCapacity</c>, <c>ExactCapacity</c>, and <c>PercentChangeInCapacity</c>. For more information about the adjustment types supported
        /// by Auto Scaling, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-scale-based-on-demand.html">Scale Based on
        /// Demand</a>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string AdjustmentType
        {
            get { return this.adjustmentType; }
            set { this.adjustmentType = value; }
        }

        // Check to see if AdjustmentType property is set
        internal bool IsSetAdjustmentType()
        {
            return this.adjustmentType != null;
        }

        /// <summary>
        /// The amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start. For more information, see
        /// <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#Cooldown">Cooldown Period</a>
        ///  
        /// </summary>
        public int Cooldown
        {
            get { return this.cooldown ?? default(int); }
            set { this.cooldown = value; }
        }

        // Check to see if Cooldown property is set
        internal bool IsSetCooldown()
        {
            return this.cooldown.HasValue;
        }

        /// <summary>
        /// Used with <c>AdjustmentType</c> with the value <c>PercentChangeInCapacity</c>, the scaling policy changes the <c>DesiredCapacity</c> of the
        /// Auto Scaling group by at least the number of instances specified in the value. You will get a <c>ValidationError</c> if you use
        /// <c>MinAdjustmentStep</c> on a policy with an <c>AdjustmentType</c> other than <c>PercentChangeInCapacity</c>.
        ///  
        /// </summary>
        public int MinAdjustmentStep
        {
            get { return this.minAdjustmentStep ?? default(int); }
            set { this.minAdjustmentStep = value; }
        }

        // Check to see if MinAdjustmentStep property is set
        internal bool IsSetMinAdjustmentStep()
        {
            return this.minAdjustmentStep.HasValue;
        }

    }
}
    
