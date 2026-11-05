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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a block device mapping.
    /// </summary>
    public partial class BlockDeviceMapping
    {
        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name assigned to the volume (for example, <c>/dev/sdh</c> or <c>xvdh</c>).
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/device_naming.html">Device
        /// naming on Linux instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To define a block device mapping, set the device name and exactly one of the following
        /// properties: <c>Ebs</c>, <c>NoDevice</c>, or <c>VirtualName</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Ebs. 
        /// <para>
        /// Information to attach an EBS volume to an instance at launch.
        /// </para>
        /// </summary>
        public Ebs Ebs { get; set; }

        /// <summary>
        /// Checks to see if the Ebs property is set.
        /// </summary>
        internal bool IsSetEbs() => this.Ebs != null;

        /// <summary>
        /// Gets and sets the property NoDevice. 
        /// <para>
        /// Setting this value to <c>true</c> prevents a volume that is included in the block
        /// device mapping of the AMI from being mapped to the specified device name at launch.
        /// </para>
        ///  
        /// <para>
        /// If <c>NoDevice</c> is <c>true</c> for the root device, instances might fail the EC2
        /// health check. In that case, Amazon EC2 Auto Scaling launches replacement instances.
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
        /// The name of the instance store volume (virtual device) to attach to an instance at
        /// launch. The name must be in the form ephemeral<i>X</i> where <i>X</i> is a number
        /// starting from zero (0), for example, <c>ephemeral0</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VirtualName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualName property is set.
        /// </summary>
        internal bool IsSetVirtualName() => this.VirtualName != null;
    }
}
