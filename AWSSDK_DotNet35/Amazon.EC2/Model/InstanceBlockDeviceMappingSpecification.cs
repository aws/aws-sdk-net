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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Specifies how an instance's block devices should be mapped on a running instance. </para>
    /// </summary>
    public class InstanceBlockDeviceMappingSpecification
    {
        
        private string deviceName;
        private EbsInstanceBlockDeviceSpecification ebs;
        private string virtualName;
        private string noDevice;


        /// <summary>
        /// The device name (e.g., <c>/dev/sdh</c>) at which the block device is exposed on the instance.
        ///  
        /// </summary>
        public string DeviceName
        {
            get { return this.deviceName; }
            set { this.deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this.deviceName != null;
        }

        /// <summary>
        /// The EBS instance block device specification describing the EBS block device to map to the specified device name on a running instance.
        ///  
        /// </summary>
        public EbsInstanceBlockDeviceSpecification Ebs
        {
            get { return this.ebs; }
            set { this.ebs = value; }
        }

        // Check to see if Ebs property is set
        internal bool IsSetEbs()
        {
            return this.ebs != null;
        }

        /// <summary>
        /// The virtual device name.
        ///  
        /// </summary>
        public string VirtualName
        {
            get { return this.virtualName; }
            set { this.virtualName = value; }
        }

        // Check to see if VirtualName property is set
        internal bool IsSetVirtualName()
        {
            return this.virtualName != null;
        }

        /// <summary>
        /// When set to the empty string, specifies that the device name in this object should not be mapped to any real device.
        ///  
        /// </summary>
        public string NoDevice
        {
            get { return this.noDevice; }
            set { this.noDevice = value; }
        }

        // Check to see if NoDevice property is set
        internal bool IsSetNoDevice()
        {
            return this.noDevice != null;
        }
    }
}
