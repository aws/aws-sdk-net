/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A block device for the instance.
    /// </summary>
    public partial class AwsAutoScalingLaunchConfigurationBlockDeviceMappingsDetails
    {
        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name that is exposed to the EC2 instance. For example, <c>/dev/sdh</c>
        /// or <c>xvdh</c>.
        /// </para>
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Ebs. 
        /// <para>
        /// Parameters that are used to automatically set up Amazon EBS volumes when an instance
        /// is launched.
        /// </para>
        /// </summary>
        public AwsAutoScalingLaunchConfigurationBlockDeviceMappingsEbsDetails Ebs { get; set; }

        /// <summary>
        /// Checks to see if the Ebs property is set.
        /// </summary>
        internal bool IsSetEbs() => this.Ebs != null;

        /// <summary>
        /// Gets and sets the property NoDevice. 
        /// <para>
        /// Whether to suppress the device that is included in the block device mapping of the
        /// Amazon Machine Image (AMI).
        /// </para>
        ///  
        /// <para>
        /// If <c>NoDevice</c> is <c>true</c>, then you cannot specify <c>Ebs</c>.>
        /// </para>
        /// </summary>
        public bool? NoDevice { get; set; }

        /// <summary>
        /// Checks to see if the NoDevice property is set.
        /// </summary>
        internal bool IsSetNoDevice() => this.NoDevice.HasValue;

        /// <summary>
        /// Gets and sets the property VirtualName. 
        /// <para>
        /// The name of the virtual device (for example, <c>ephemeral0</c>).
        /// </para>
        ///  
        /// <para>
        /// You can provide either <c>VirtualName</c> or <c>Ebs</c>, but not both.
        /// </para>
        /// </summary>
        public string VirtualName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualName property is set.
        /// </summary>
        internal bool IsSetVirtualName() => this.VirtualName != null;
    }
}
