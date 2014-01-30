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
    /// <para>Describes a block device mapping.</para>
    /// </summary>
    public class BlockDeviceMapping
    {
        
        private string virtualName;
        private string deviceName;
        private EbsBlockDevice ebs;
        private string noDevice;


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
        /// The device name exposed to the instance (for example, <c>/dev/sdh</c>).
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
        /// Parameters used to automatically set up Amazon EBS volumes when the instance is launched.
        ///  
        /// </summary>
        public EbsBlockDevice Ebs
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
        /// Suppresses the specified device included in the block device mapping of the AMI.
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
