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
    /// Starts an Amazon EBS-backed AMI that you've previously stopped.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Instances that use Amazon EBS volumes as their root devices can be quickly
    /// stopped and started. When an instance is stopped, the compute resources are
    /// released and you are not billed for hourly instance usage. However, your
    /// root partition Amazon EBS volume remains, continues to persist your data, and
    /// you are charged for Amazon EBS volume usage. You can restart your instance
    /// at any time. Each time you transition an instance from stopped to started,
    /// we charge a full instance hour, even if transitions happen multiple times
    /// within a single hour.
    /// </para>
    /// <para>
    /// Before stopping an instance, make sure it is in a state from which it can
    /// be restarted. Stopping an instance does not preserve data stored in RAM.
    /// </para>
    /// <para>
    /// Performing this operation on an instance that uses an instance store as its root device returns
    /// an error.
    /// </para>
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class StartInstancesRequest : EC2Request
    {    
        private List<string> instanceIdField;

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public StartInstancesRequest WithInstanceId(params string[] list)
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

    }
}
