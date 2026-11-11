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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a block device mapping, which defines the EBS volumes and instance store
    /// volumes to attach to an instance at launch.
    /// </summary>
    public partial class BlockDeviceMapping
    {
        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name. For available device names, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/device_naming.html">Device
        /// names for volumes</a>.
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
        /// Parameters used to automatically set up EBS volumes when the instance is launched.
        /// </para>
        /// </summary>
        public EbsBlockDevice Ebs { get; set; }

        /// <summary>
        /// Checks to see if the Ebs property is set.
        /// </summary>
        internal bool IsSetEbs() => this.Ebs != null;

        /// <summary>
        /// Gets and sets the property NoDevice. 
        /// <para>
        /// To omit the device from the block device mapping, specify an empty string. When this
        /// property is specified, the device is removed from the block device mapping regardless
        /// of the assigned value.
        /// </para>
        /// </summary>
        public string NoDevice { get; set; }

        /// <summary>
        /// Checks to see if the NoDevice property is set.
        /// </summary>
        internal bool IsSetNoDevice() => this.NoDevice != null;

        /// <summary>
        /// Gets and sets the property VirtualName. 
        /// <para>
        /// The virtual device name (<c>ephemeral</c>N). Instance store volumes are numbered starting
        /// from 0. An instance type with 2 available instance store volumes can specify mappings
        /// for <c>ephemeral0</c> and <c>ephemeral1</c>. The number of available instance store
        /// volumes depends on the instance type. After you connect to the instance, you must
        /// mount the volume.
        /// </para>
        ///  
        /// <para>
        /// NVMe instance store volumes are automatically enumerated and assigned a device name.
        /// Including them in your block device mapping has no effect.
        /// </para>
        ///  
        /// <para>
        /// Constraints: For M3 instances, you must specify instance store volumes in the block
        /// device mapping for the instance. When you launch an M3 instance, we ignore any instance
        /// store volumes specified in the block device mapping for the AMI.
        /// </para>
        /// </summary>
        public string VirtualName { get; set; }

        /// <summary>
        /// Checks to see if the VirtualName property is set.
        /// </summary>
        internal bool IsSetVirtualName() => this.VirtualName != null;
    }
}
