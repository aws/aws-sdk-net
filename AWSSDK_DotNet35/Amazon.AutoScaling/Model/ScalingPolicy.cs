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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>ScalingPolicy</c> data type. </para>
    /// </summary>
    public class ScalingPolicy
    {
        
        private string autoScalingGroupName;
        private string policyName;
        private int? scalingAdjustment;
        private string adjustmentType;
        private int? cooldown;
        private string policyARN;
        private List<Alarm> alarms = new List<Alarm>();
        private int? minAdjustmentStep;

        /// <summary>
        /// The name of the Auto Scaling group associated with this scaling policy.
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
        /// The name of the scaling policy.
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
        /// The number associated with the specified adjustment type. A positive value adds to the current capacity and a negative value removes from
        /// the current capacity.
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
        /// <c>ChangeInCapacity</c>, <c>ExactCapacity</c>, and <c>PercentChangeInCapacity</c>.
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
        /// The amount of time, in seconds, after a scaling activity completes before any further trigger-related scaling activities can start.
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
        /// The Amazon Resource Name (ARN) of the policy.
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
        public string PolicyARN
        {
            get { return this.policyARN; }
            set { this.policyARN = value; }
        }

        // Check to see if PolicyARN property is set
        internal bool IsSetPolicyARN()
        {
            return this.policyARN != null;
        }

        /// <summary>
        /// A list of CloudWatch Alarms related to the policy.
        ///  
        /// </summary>
        public List<Alarm> Alarms
        {
            get { return this.alarms; }
            set { this.alarms = value; }
        }

        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this.alarms.Count > 0;
        }

        /// <summary>
        /// Changes the <c>DesiredCapacity</c> of the Auto Scaling group by at least the specified number of instances.
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
