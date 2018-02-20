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
        private double? _breachThreshold;
        private bool? _honorCooldown;
        private double? _metricValue;
        private string _policyName;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
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
        /// Gets and sets the property BreachThreshold. 
        /// <para>
        /// The breach threshold for the alarm.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if the policy type is <code>StepScaling</code> and not
        /// supported otherwise.
        /// </para>
        /// </summary>
        public double BreachThreshold
        {
            get { return this._breachThreshold.GetValueOrDefault(); }
            set { this._breachThreshold = value; }
        }

        // Check to see if BreachThreshold property is set
        internal bool IsSetBreachThreshold()
        {
            return this._breachThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HonorCooldown. 
        /// <para>
        /// Indicates whether Auto Scaling waits for the cooldown period to complete before executing
        /// the policy.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not supported if the policy type is <code>StepScaling</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/autoscaling/latest/userguide/Cooldown.html">Auto
        /// Scaling Cooldowns</a> in the <i>Auto Scaling User Guide</i>.
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
        /// Gets and sets the property MetricValue. 
        /// <para>
        /// The metric value to compare to <code>BreachThreshold</code>. This enables you to execute
        /// a policy of type <code>StepScaling</code> and determine which step adjustment to use.
        /// For example, if the breach threshold is 50 and you want to use a step adjustment with
        /// a lower bound of 0 and an upper bound of 10, you can set the metric value to 59.
        /// </para>
        ///  
        /// <para>
        /// If you specify a metric value that doesn't correspond to a step adjustment for the
        /// policy, the call returns an error.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required if the policy type is <code>StepScaling</code> and not
        /// supported otherwise.
        /// </para>
        /// </summary>
        public double MetricValue
        {
            get { return this._metricValue.GetValueOrDefault(); }
            set { this._metricValue = value; }
        }

        // Check to see if MetricValue property is set
        internal bool IsSetMetricValue()
        {
            return this._metricValue.HasValue; 
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