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
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html"
    /// >http://docs.aws.amazon.com/opsworks/latest/userguide/resources.html</a> .</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.RegisterVolume"/>
    public class RegisterVolumeRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the Ec2VolumeId property
        /// </summary>
        /// <param name="ec2VolumeId">The value to set for the Ec2VolumeId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterVolumeRequest WithEc2VolumeId(string ec2VolumeId)
        {
            this.ec2VolumeId = ec2VolumeId;
            return this;
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

        /// <summary>
        /// Sets the StackId property
        /// </summary>
        /// <param name="stackId">The value to set for the StackId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RegisterVolumeRequest WithStackId(string stackId)
        {
            this.stackId = stackId;
            return this;
        }
            

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this.stackId != null;
        }
    }
}
    
