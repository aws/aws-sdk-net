/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Stops an Amazon EBS-backed instance.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each time you transition an instance from stopped to started,
    /// we charge a full instance hour, even if transitions happen multiple
    /// times within a single hour.
    /// </para>
    /// <para>
    /// Although Spot Instances can use Amazon EBS-backed AMIs, they don't
    /// support Stop/Start. In other words, you can't stop and start Spot
    /// Instances launched from an AMI with an Amazon EBS root device.
    /// </para>
    /// <para>
    /// Instances that use Amazon EBS volumes as their root devices can be
    /// quickly stopped and started. When an instance is stopped, the compute
    /// resources are released and you are not billed for hourly instance usage.
    /// However, your root partition Amazon EBS volume remains, continues to
    /// persist your data, and you are charged for Amazon EBS volume usage.
    /// You can restart your instance at any time.
    /// </para>
    /// <para>
    /// Before stopping an instance, make sure it is in a state from which it
    /// can be restarted. Stopping an instance does not preserve data stored
    /// in RAM. Performing this operation on an instance that uses an instance
    /// store as its root device returns an error.
    /// </para>
    /// <para>
    /// You can stop, start, and terminate EBS-backed instances. You can only
    /// terminate S3-backed instances. What happens to an instance differs
    /// if you stop it or terminate it. For example, when you stop an instance,
    /// the root device and any other devices attached to the instance persist.
    /// When you terminate an instance, the root device and any other devices
    /// attached during the instance launch are automatically deleted.
    /// </para>
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class StopInstancesRequest
    {    
        private List<string> instanceIdField;
        private bool? forceField;

        /// <summary>
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
        /// Sets the instance ID.
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
        /// Whether to force the instance to stop.
        /// </summary>
        /// <remarks>
        /// The instance will not have an opportunity to flush file
        /// system caches nor file system meta data. If you use this
        /// option, you must perform file system check and repair
        /// procedures.
        /// This option is not recommended for Windows instances.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Force")]
        public bool Force
        {
            get { return this.forceField.GetValueOrDefault(); }
            set { this.forceField = value; }
        }

        /// <summary>
        /// Sets whether to force the instance to stop.
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
