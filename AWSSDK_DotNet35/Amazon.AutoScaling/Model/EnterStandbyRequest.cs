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
    /// Container for the parameters to the EnterStandby operation.
    /// Move instances in an Auto Scaling group into a Standby mode. 
    /// 
    ///  
    /// <para>
    /// To learn more about how to put instances into a Standby mode, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/AutoScalingInServiceState.html">Auto
    /// Scaling InService State</a>.
    /// </para>
    /// </summary>
    public partial class EnterStandbyRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _instanceIds = new List<string>();
        private bool? _shouldDecrementDesiredCapacity;


        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        ///  The name of the Auto Scaling group from which to move instances into Standby mode.
        /// 
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
        /// Gets and sets the property InstanceIds. 
        /// <para>
        ///  The instances to move into Standby mode. You must specify at least one instance ID.
        /// 
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property ShouldDecrementDesiredCapacity. 
        /// <para>
        ///  Specifies whether the instances moved to Standby mode count as part of the Auto Scaling
        /// group's desired capacity. If set, the desired capacity for the Auto Scaling group
        /// decrements by the number of instances moved to Standby mode. 
        /// </para>
        /// </summary>
        public bool ShouldDecrementDesiredCapacity
        {
            get { return this._shouldDecrementDesiredCapacity.GetValueOrDefault(); }
            set { this._shouldDecrementDesiredCapacity = value; }
        }

        // Check to see if ShouldDecrementDesiredCapacity property is set
        internal bool IsSetShouldDecrementDesiredCapacity()
        {
            return this._shouldDecrementDesiredCapacity.HasValue; 
        }

    }
}