/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterVolume operation.
    /// <para>Registers an Amazon EBS volume with a specified stack. A volume can be registered with only one stack at a time. If the volume is
    /// already registered, you must first deregister it by calling DeregisterVolume. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html" >Resource Management</a> .</para> <para> <b>Required
    /// Permissions</b> : To use this action, an IAM user must have a Manage permissions level for the stack, or an attached policy that explicitly
    /// grants permissions. For more information on user permissions, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html" >Managing User Permissions</a> .</para>
    /// </summary>
    public partial class RegisterVolumeRequest : AmazonOpsWorksRequest
    {
        private string ec2VolumeId;
        private string stackId;


        /// <summary>
        /// The Amazon EBS volume ID.
        ///  
        /// </summary>
        public string Ec2VolumeId
        {
            get { return this.ec2VolumeId; }
            set { this.ec2VolumeId = value; }
        }

        // Check to see if Ec2VolumeId property is set
        internal bool IsSetEc2VolumeId()
        {
            return this.ec2VolumeId != null;
        }

        /// <summary>
        /// The stack ID.
        ///  
        /// </summary>
        public string StackId
        {
            get { return this.stackId; }
            set { this.stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }

    }
}
    
