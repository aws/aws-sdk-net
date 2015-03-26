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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a block device mapping.
    /// </summary>
    public partial class BlockDeviceMapping
    {
        private string _deviceName;
        private Ebs _ebs;
        private bool? _noDevice;
        private string _virtualName;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The device name exposed to the EC2 instance (for example, <code>/dev/sdh</code> or
        /// <code>xvdh</code>).
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
        /// The information about the Amazon EBS volume.
        /// </para>
        /// </summary>
        public Ebs Ebs
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
        /// Suppresses a device mapping.
        /// </para>
        ///  <note>If <code>NoDevice</code> is set to <code>true</code> for the root device, the
        /// instance might fail the EC2 health check. Auto Scaling launches a replacement instance
        /// if the instance fails the health check.</note>
        /// </summary>
        public bool NoDevice
        {
            get { return this._noDevice.GetValueOrDefault(); }
            set { this._noDevice = value; }
        }

        // Check to see if NoDevice property is set
        internal bool IsSetNoDevice()
        {
            return this._noDevice.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VirtualName. 
        /// <para>
        /// The name of the virtual device, <code>ephemeral0</code> to <code>ephemeral3</code>.
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