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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// 
    ///  
    /// <para>
    /// To override a block device mapping specified in the launch template:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify the exact same <c>DeviceName</c> here as specified in the launch template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Only specify the parameters you want to change.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any parameters you don't specify here will keep their original launch template values.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To add a new block device mapping:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify a <c>DeviceName</c> that doesn't exist in the launch template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify all desired parameters here.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class FleetBlockDeviceMappingRequest
    {
        private string _deviceName;
        private FleetEbsBlockDeviceRequest _ebs;
        private string _noDevice;
        private string _virtualName;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name (for example, <c>/dev/sdh</c> or <c>xvdh</c>).
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property Ebs. 
        /// <para>
        /// Parameters used to automatically set up EBS volumes when the instance is launched.
        /// </para>
        /// </summary>
        public FleetEbsBlockDeviceRequest Ebs
        {
            get { return this._ebs; }
            set { this._ebs = value; }
        }

        // Check to see if Ebs property is set
        internal bool IsSetEbs()
        {
            return this._ebs != null;
        }

        /// <summary>
        /// Gets and sets the property NoDevice. 
        /// <para>
        /// To omit the device from the block device mapping, specify an empty string. When this
        /// property is specified, the device is removed from the block device mapping regardless
        /// of the assigned value.
        /// </para>
        /// </summary>
        public string NoDevice
        {
            get { return this._noDevice; }
            set { this._noDevice = value; }
        }

        // Check to see if NoDevice property is set
        internal bool IsSetNoDevice()
        {
            return this._noDevice != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualName. 
        /// <para>
        /// The virtual device name (<c>ephemeralN</c>). Instance store volumes are numbered starting
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
        public string VirtualName
        {
            get { return this._virtualName; }
            set { this._virtualName = value; }
        }

        // Check to see if VirtualName property is set
        internal bool IsSetVirtualName()
        {
            return this._virtualName != null;
        }

    }
}