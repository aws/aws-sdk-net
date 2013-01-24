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
    /// Shuts down one or more instances.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This operation is idempotent; if you terminate an instance more than
    /// once, each call will succeed. Terminated instances will remain visible
    /// after termination (approximately one hour).
    /// </para>
    /// <para>
    /// By default, Amazon EC2 deletes all Amazon EBS volumes that were attached
    /// when the instance launched. Amazon EBS volumes attached after instance
    /// launch continue running.
    /// </para>
    /// <para>
    /// You can stop, start, and terminate EBS-backed instances. You can only
    /// terminate S3-backed instances. What happens to an instance differs if
    /// you stop it or terminate it. For example, when you stop an instance,
    /// the root device and any other devices attached to the instance persist.
    /// When you terminate an instance, the root device and any other devices
    /// attached during the instance launch are automatically deleted.
    /// </para>
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class TerminateInstancesRequest
    {    
        private List<string> instanceIdField;

        /// <summary>
        /// Instance IDs to terminate.
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
        /// Sets instance IDs to terminate.
        /// </summary>
        /// <param name="list">Instance ID to terminate.</param>
        /// <returns>this instance</returns>
        public TerminateInstancesRequest WithInstanceId(params string[] list)
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
