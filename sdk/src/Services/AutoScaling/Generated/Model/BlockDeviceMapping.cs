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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        /// <code>xvdh</code>). For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/device_naming.html">Device
        /// Naming on Linux Instances</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Parameters used to automatically set up EBS volumes when an instance is launched.
        /// </para>
        ///  
        /// <para>
        /// You can specify either <code>VirtualName</code> or <code>Ebs</code>, but not both.
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
        /// Setting this value to <code>true</code> suppresses the specified device included in
        /// the block device mapping of the AMI.
        /// </para>
        ///  
        /// <para>
        /// If <code>NoDevice</code> is <code>true</code> for the root device, instances might
        /// fail the EC2 health check. In that case, Amazon EC2 Auto Scaling launches replacement
        /// instances.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>NoDevice</code>, you cannot specify <code>Ebs</code>.
        /// </para>
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
        /// The name of the virtual device (for example, <code>ephemeral0</code>).
        /// </para>
        ///  
        /// <para>
        /// You can specify either <code>VirtualName</code> or <code>Ebs</code>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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