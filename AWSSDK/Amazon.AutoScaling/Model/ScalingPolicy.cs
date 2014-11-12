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
    /// The <code>ScalingPolicy</code> data type.
    /// </summary>
    public partial class ScalingPolicy
    {
        private string _adjustmentType;
        private List<Alarm> _alarms = new List<Alarm>();
        private string _autoScalingGroupName;
        private int? _cooldown;
        private int? _minAdjustmentStep;
        private string _policyARN;
        private string _policyName;
        private int? _scalingAdjustment;


        /// <summary>
        /// Gets and sets the property AdjustmentType. 
        /// <para>
        ///             Specifies whether the <code>ScalingAdjustment</code> is             an
        /// absolute number or a percentage of the current            capacity. Valid values are
        /// <code>ChangeInCapacity</code>,            <code>ExactCapacity</code>, and <code>PercentChangeInCapacity</code>.
        ///        
        /// </para>
        /// </summary>
        public string AdjustmentType
        {
            get { return this._adjustmentType; }
            set { this._adjustmentType = value; }
        }


        /// <summary>
        /// Sets the AdjustmentType property
        /// </summary>
        /// <param name="adjustmentType">The value to set for the AdjustmentType property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithAdjustmentType(string adjustmentType)
        {
            this._adjustmentType = adjustmentType;
            return this;
        }

        // Check to see if AdjustmentType property is set
        internal bool IsSetAdjustmentType()
        {
            return this._adjustmentType != null;
        }


        /// <summary>
        /// Gets and sets the property Alarms. 
        /// <para>
        ///             A list of CloudWatch Alarms related to the policy.        
        /// </para>
        /// </summary>
        public List<Alarm> Alarms
        {
            get { return this._alarms; }
            set { this._alarms = value; }
        }

        /// <summary>
        /// Sets the Alarms property
        /// </summary>
        /// <param name="alarms">The values to add to the Alarms collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithAlarms(params Alarm[] alarms)
        {
            foreach (var element in alarms)
            {
                this._alarms.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the Alarms property
        /// </summary>
        /// <param name="alarms">The values to add to the Alarms collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithAlarms(IEnumerable<Alarm> alarms)
        {
            foreach (var element in alarms)
            {
                this._alarms.Add(element);
            }
            return this;
        }
        // Check to see if Alarms property is set
        internal bool IsSetAlarms()
        {
            return this._alarms != null && this._alarms.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///             The name of the Auto Scaling group associated with this scaling policy.
        ///        
        /// </para>
        /// </summary>
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }


        /// <summary>
        /// Sets the AutoScalingGroupName property
        /// </summary>
        /// <param name="autoScalingGroupName">The value to set for the AutoScalingGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithAutoScalingGroupName(string autoScalingGroupName)
        {
            this._autoScalingGroupName = autoScalingGroupName;
            return this;
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Cooldown. 
        /// <para>
        ///             The amount of time, in seconds, after a scaling activity            completes
        /// before any further trigger-related scaling activities            can start.      
        ///  
        /// </para>
        /// </summary>
        public int Cooldown
        {
            get { return this._cooldown.GetValueOrDefault(); }
            set { this._cooldown = value; }
        }


        /// <summary>
        /// Sets the Cooldown property
        /// </summary>
        /// <param name="cooldown">The value to set for the Cooldown property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithCooldown(int cooldown)
        {
            this._cooldown = cooldown;
            return this;
        }

        // Check to see if Cooldown property is set
        internal bool IsSetCooldown()
        {
            return this._cooldown.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property MinAdjustmentStep. 
        /// <para>
        ///              Changes the <code>DesiredCapacity</code> of the Auto Scaling group by
        /// at least the specified number of instances.        
        /// </para>
        /// </summary>
        public int MinAdjustmentStep
        {
            get { return this._minAdjustmentStep.GetValueOrDefault(); }
            set { this._minAdjustmentStep = value; }
        }


        /// <summary>
        /// Sets the MinAdjustmentStep property
        /// </summary>
        /// <param name="minAdjustmentStep">The value to set for the MinAdjustmentStep property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithMinAdjustmentStep(int minAdjustmentStep)
        {
            this._minAdjustmentStep = minAdjustmentStep;
            return this;
        }

        // Check to see if MinAdjustmentStep property is set
        internal bool IsSetMinAdjustmentStep()
        {
            return this._minAdjustmentStep.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property PolicyARN. 
        /// <para>
        ///             The Amazon Resource Name (ARN) of the policy.        
        /// </para>
        /// </summary>
        public string PolicyARN
        {
            get { return this._policyARN; }
            set { this._policyARN = value; }
        }


        /// <summary>
        /// Sets the PolicyARN property
        /// </summary>
        /// <param name="policyARN">The value to set for the PolicyARN property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithPolicyARN(string policyARN)
        {
            this._policyARN = policyARN;
            return this;
        }

        // Check to see if PolicyARN property is set
        internal bool IsSetPolicyARN()
        {
            return this._policyARN != null;
        }


        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        ///             The name of the scaling policy.        
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }


        /// <summary>
        /// Sets the PolicyName property
        /// </summary>
        /// <param name="policyName">The value to set for the PolicyName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithPolicyName(string policyName)
        {
            this._policyName = policyName;
            return this;
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }


        /// <summary>
        /// Gets and sets the property ScalingAdjustment. 
        /// <para>
        ///             The number associated with the specified             adjustment type.
        ///            A positive value adds to the current capacity            and a negative
        /// value removes from the current capacity.        
        /// </para>
        /// </summary>
        public int ScalingAdjustment
        {
            get { return this._scalingAdjustment.GetValueOrDefault(); }
            set { this._scalingAdjustment = value; }
        }


        /// <summary>
        /// Sets the ScalingAdjustment property
        /// </summary>
        /// <param name="scalingAdjustment">The value to set for the ScalingAdjustment property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ScalingPolicy WithScalingAdjustment(int scalingAdjustment)
        {
            this._scalingAdjustment = scalingAdjustment;
            return this;
        }

        // Check to see if ScalingAdjustment property is set
        internal bool IsSetScalingAdjustment()
        {
            return this._scalingAdjustment.HasValue; 
        }

    }
}