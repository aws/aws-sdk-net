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
    /// Container for the parameters to the TerminateInstances operation.
    /// <para>Shuts down one or more instances. This operation is idempotent; if you terminate an instance more than once, each call
    /// succeeds.</para> <para>Terminated instances remain visible after termination (for approximately one hour).</para> <para>By default, Amazon
    /// EC2 deletes all Amazon EBS volumes that were attached when the instance launched. Volumes attached after instance launch continue
    /// running.</para> <para>You can stop, start, and terminate EBS-backed instances. You can only terminate instance store-backed instances. What
    /// happens to an instance differs if you stop it or terminate it. For example, when you stop an instance, the root device and any other devices
    /// attached to the instance persist. When you terminate an instance, the root device and any other devices attached during the instance launch
    /// are automatically deleted. For more information about the differences between stopping and terminating instances, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html" >Instance Lifecycle</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para> <para>For more information about troubleshooting, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesShuttingDown.html" >Troubleshooting Terminating Your
    /// Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class TerminateInstancesRequest : EC2Request
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
