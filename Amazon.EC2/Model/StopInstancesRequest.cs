/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Stops an instance that uses an Amazon EBS volume as its root device.
    /// Instances that use Amazon EBS volumes as their root devices can be
    /// quickly stopped and started. When an instance is
    /// stopped, the compute resources are released and
    /// you are not billed for hourly instance usage. However,
    /// your root partition Amazon EBS volume remains,
    /// continues to persist your data, and you are charged
    /// for Amazon EBS volume usage. You can restart
    /// your instance at any time.
    ///
    /// Before stopping an instance, make sure it is in a state from
    /// which it can be restarted. Stopping an instance does not preserve
    /// data stored in RAM.
    ///
    /// Performing this operation on an instance that
    /// uses an instance store as its
    /// root device returns
    /// an error.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class StopInstancesRequest
    {    
        private List<string> instanceIdField;
        private bool? forceField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// The instance ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public List<string> InstanceId
        {
            get
            {
                if (this.instanceIdField == null)
                {
                    this.instanceIdField = new List<string>();
                }
                return this.instanceIdField;
            }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="list">The instance ID.</param>
        /// <returns>this instance</returns>
        public StopInstancesRequest WithInstanceId(params string[] list)
        {
            foreach (string item in list)
            {
                InstanceId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return (InstanceId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Force property.
        /// Forces the instance to stop. The instance will
        /// not have an opportunity to flush file system caches nor file
        /// system meta data. If you use this option, you must perform file
        /// system check and repair procedures. This option is not
        /// recommended for Windows instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "Force")]
        public bool Force
        {
            get { return this.forceField.GetValueOrDefault(); }
            set { this.forceField = value; }
        }

        /// <summary>
        /// Sets the Force property
        /// </summary>
        /// <param name="force">Forces the instance to stop. The instance will
        /// not have an opportunity to flush file system caches nor file
        /// system meta data. If you use this option, you must perform file
        /// system check and repair procedures. This option is not
        /// recommended for Windows instances.</param>
        /// <returns>this instance</returns>
        public StopInstancesRequest WithForce(bool force)
        {
            this.forceField = force;
            return this;
        }

        /// <summary>
        /// Checks if Force property is set
        /// </summary>
        /// <returns>true if Force property is set</returns>
        public bool IsSetForce()
        {
            return this.forceField.HasValue;
        }

    }
}
