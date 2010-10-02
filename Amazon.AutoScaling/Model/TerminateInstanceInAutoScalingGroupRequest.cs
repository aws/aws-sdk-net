/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Returns the activity to terminate the instance.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class TerminateInstanceInAutoScalingGroupRequest
    {
        private string instanceIdField;
        private bool? shouldDecrementDesiredCapacityField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// Terminates the specified instance. Optionally, the desired group size can be adjusted.
        /// If set to true, the default, the AutoScalingGroup size decreases by one. If the AutoScalingGroup
        /// is associated with a LoadBalancer, the system deregisters the instance before terminating it.
        /// This call simply registers a termination request. The termination of the instance can not happen immediately.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">Terminates the specified instance. Optionally, the desired group size can be adjusted.
        /// If set to true, the default, the AutoScalingGroup size decreases by one. If the AutoScalingGroup
        /// is associated with a LoadBalancer, the system deregisters the instance before terminating it.
        /// This call simply registers a termination request. The termination of the instance can not happen immediately.</param>
        /// <returns>this instance</returns>
        public TerminateInstanceInAutoScalingGroupRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Gets and sets the ShouldDecrementDesiredCapacity property.
        /// Specifies whether terminating this instance should also decrement the size of the AutoScalingGroup.
        /// The default is true.
        /// </summary>
        [XmlElementAttribute(ElementName = "ShouldDecrementDesiredCapacity")]
        public bool ShouldDecrementDesiredCapacity
        {
            get { return this.shouldDecrementDesiredCapacityField.GetValueOrDefault(); }
            set { this.shouldDecrementDesiredCapacityField = value; }
        }

        /// <summary>
        /// Sets the ShouldDecrementDesiredCapacity property
        /// </summary>
        /// <param name="shouldDecrementDesiredCapacity">Specifies whether terminating this instance should also decrement the size of the AutoScalingGroup.
        /// The default is true.</param>
        /// <returns>this instance</returns>
        public TerminateInstanceInAutoScalingGroupRequest WithShouldDecrementDesiredCapacity(bool shouldDecrementDesiredCapacity)
        {
            this.shouldDecrementDesiredCapacityField = shouldDecrementDesiredCapacity;
            return this;
        }

        /// <summary>
        /// Checks if ShouldDecrementDesiredCapacity property is set
        /// </summary>
        /// <returns>true if ShouldDecrementDesiredCapacity property is set</returns>
        public bool IsSetShouldDecrementDesiredCapacity()
        {
            return this.shouldDecrementDesiredCapacityField.HasValue;
        }

    }
}
