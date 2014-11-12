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
    /// The <code>BlockDeviceMapping</code> data type.
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
        ///         The name of the device within Amazon EC2 (for example, /dev/sdh or xvdh).
        ///        
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }


        /// <summary>
        /// Sets the DeviceName property
        /// </summary>
        /// <param name="deviceName">The value to set for the DeviceName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BlockDeviceMapping WithDeviceName(string deviceName)
        {
            this._deviceName = deviceName;
            return this;
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }


        /// <summary>
        /// Gets and sets the property Ebs. 
        /// <para>
        ///         The Elastic Block Storage volume information.        
        /// </para>
        /// </summary>
        public Ebs Ebs
        {
            get { return this._ebs; }
            set { this._ebs = value; }
        }


        /// <summary>
        /// Sets the Ebs property
        /// </summary>
        /// <param name="ebs">The value to set for the Ebs property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BlockDeviceMapping WithEbs(Ebs ebs)
        {
            this._ebs = ebs;
            return this;
        }

        // Check to see if Ebs property is set
        internal bool IsSetEbs()
        {
            return this._ebs != null;
        }


        /// <summary>
        /// Gets and sets the property NoDevice. 
        /// <para>
        ///             Suppresses the device mapping.                    
        /// </para>
        ///         <note>If <code>NoDevice</code> is set to <code>true</code> for the root device,
        /// the instance might fail the EC2 health check.             Auto Scaling launches a
        /// replacement instance if the instance fails the health check.</note>
        /// </summary>
        public bool NoDevice
        {
            get { return this._noDevice.GetValueOrDefault(); }
            set { this._noDevice = value; }
        }


        /// <summary>
        /// Sets the NoDevice property
        /// </summary>
        /// <param name="noDevice">The value to set for the NoDevice property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BlockDeviceMapping WithNoDevice(bool noDevice)
        {
            this._noDevice = noDevice;
            return this;
        }

        // Check to see if NoDevice property is set
        internal bool IsSetNoDevice()
        {
            return this._noDevice.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property VirtualName. 
        /// <para>
        /// The virtual name associated with the device.        
        /// </para>
        /// </summary>
        public string VirtualName
        {
            get { return this._virtualName; }
            set { this._virtualName = value; }
        }


        /// <summary>
        /// Sets the VirtualName property
        /// </summary>
        /// <param name="virtualName">The value to set for the VirtualName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BlockDeviceMapping WithVirtualName(string virtualName)
        {
            this._virtualName = virtualName;
            return this;
        }

        // Check to see if VirtualName property is set
        internal bool IsSetVirtualName()
        {
            return this._virtualName != null;
        }

    }
}