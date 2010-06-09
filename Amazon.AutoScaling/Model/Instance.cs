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
    ///<summary>
    ///The Instance data type.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class Instance
    {
        private string instanceIdField;
        private string availabilityZoneField;
        private string lifecycleStateField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// Amazon EC2 instance ID.
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
        /// <param name="instanceId">Amazon EC2 instance ID.</param>
        /// <returns>this instance</returns>
        public Instance WithInstanceId(string instanceId)
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
        /// Gets and sets the AvailabilityZone property.
        /// Amazon EC2 availability zone.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">Amazon EC2 availability zone.</param>
        /// <returns>this instance</returns>
        public Instance WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// Gets and sets the LifecycleState property.
        /// Description of current lifecycle state.
        /// </summary>
        [XmlElementAttribute(ElementName = "LifecycleState")]
        public string LifecycleState
        {
            get { return this.lifecycleStateField; }
            set { this.lifecycleStateField = value; }
        }

        /// <summary>
        /// Sets the LifecycleState property
        /// </summary>
        /// <param name="lifecycleState">Description of current lifecycle state.</param>
        /// <returns>this instance</returns>
        public Instance WithLifecycleState(string lifecycleState)
        {
            this.lifecycleStateField = lifecycleState;
            return this;
        }

        /// <summary>
        /// Checks if LifecycleState property is set
        /// </summary>
        /// <returns>true if LifecycleState property is set</returns>
        public bool IsSetLifecycleState()
        {
            return this.lifecycleStateField != null;
        }

    }
}
