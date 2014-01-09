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
    /// Container for the parameters to the ExecutePolicy operation.
    /// <para>Executes the specified policy. </para>
    /// </summary>
    public partial class ExecutePolicyRequest : AmazonAutoScalingRequest
    {
        private string autoScalingGroupName;
        private string policyName;
        private bool? honorCooldown;


        /// <summary>
        /// The name or the Amazon Resource Name (ARN) of the Auto Scaling group.
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
        /// The name or ARN of the policy you want to run.
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
        /// Set to <c>True</c> if you want Auto Scaling to wait for the cooldown period associated with the Auto Scaling group to complete before
        /// executing the policy. Set to <c>False</c> if you want Auto Scaling to circumvent the cooldown period associated with the Auto Scaling group
        /// and execute the policy before the cooldown period ends. For information about cooldown period, see <a
        /// href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AS_Concepts.html#Cooldown">Cooldown Period</a> in the <i>Auto Scaling
        /// Developer Guide</i>.
        ///  
        /// </summary>
        public bool HonorCooldown
        {
            get { return this.honorCooldown ?? default(bool); }
            set { this.honorCooldown = value; }
        }

        // Check to see if HonorCooldown property is set
        internal bool IsSetHonorCooldown()
        {
            return this.honorCooldown.HasValue;
        }

    }
}
    
