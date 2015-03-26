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
    /// Container for the parameters to the ExecutePolicy operation.
    /// Executes the specified policy.
    /// </summary>
    public partial class ExecutePolicyRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private bool? _honorCooldown;
        private string _policyName;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the Auto Scaling group.
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
        /// Gets and sets the property HonorCooldown. 
        /// <para>
        /// Set to <code>True</code> if you want Auto Scaling to wait for the cooldown period
        /// associated with the Auto Scaling group to complete before executing the policy.
        /// </para>
        ///  
        /// <para>
        /// Set to <code>False</code> if you want Auto Scaling to circumvent the cooldown period
        /// associated with the Auto Scaling group and execute the policy before the cooldown
        /// period ends.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/Cooldown.html">Understanding
        /// Auto Scaling Cooldowns</a> in the <i>Auto Scaling Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool HonorCooldown
        {
            get { return this._honorCooldown.GetValueOrDefault(); }
            set { this._honorCooldown = value; }
        }

        // Check to see if HonorCooldown property is set
        internal bool IsSetHonorCooldown()
        {
            return this._honorCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name or ARN of the policy.
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

    }
}