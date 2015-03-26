/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a block device mapping.
    /// </summary>
    public partial class BlockDeviceMapping
    {
        private string _deviceName;
        private EbsBlockDevice _ebs;
        private string _noDevice;
        private string _virtualName;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name exposed to the instance (for example, <code>/dev/sdh</code>).
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
        /// Parameters used to automatically set up Amazon EBS volumes when the instance is launched.
        /// </para>
        /// </summary>
        public EbsBlockDevice Ebs
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
        /// Suppresses the specified device included in the block device mapping of the AMI.
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
        /// The virtual device name (<code>ephemeral</code>N). Instance store volumes are numbered
        /// starting from 0. An instance type with 2 available instance store volumes can specify
        /// mappings for <code>ephemeral0</code> and <code>ephemeral1</code>.The number of available
        /// instance store volumes depends on the instance type. After you connect to the instance,
        /// you must mount the volume.
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