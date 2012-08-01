/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Block device mapping.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class BlockDeviceMapping
    {    
        private string deviceNameField;
        private string virtualNameField;
        private EbsBlockDevice ebsField;
        private string noDeviceField;

        /// <summary>
        /// Gets and sets the DeviceName property.
        /// The device name (e.g., /dev/sdh).
        /// </summary>
        [XmlElementAttribute(ElementName = "DeviceName")]
        public string DeviceName
        {
            get { return this.deviceNameField; }
            set { this.deviceNameField = value; }
        }

        /// <summary>
        /// Sets the DeviceName property
        /// </summary>
        /// <param name="deviceName">The device name (e.g., /dev/sdh).</param>
        /// <returns>this instance</returns>
        public BlockDeviceMapping WithDeviceName(string deviceName)
        {
            this.deviceNameField = deviceName;
            return this;
        }

        /// <summary>
        /// Checks if DeviceName property is set
        /// </summary>
        /// <returns>true if DeviceName property is set</returns>
        public bool IsSetDeviceName()
        {
            return this.deviceNameField != null;
        }

        /// <summary>
        /// Gets and sets the VirtualName property.
        /// The virtual name.
        /// </summary>
        [XmlElementAttribute(ElementName = "VirtualName")]
        public string VirtualName
        {
            get { return this.virtualNameField; }
            set { this.virtualNameField = value; }
        }

        /// <summary>
        /// Sets the VirtualName property
        /// </summary>
        /// <param name="virtualName">The virtual name.</param>
        /// <returns>this instance</returns>
        public BlockDeviceMapping WithVirtualName(string virtualName)
        {
            this.virtualNameField = virtualName;
            return this;
        }

        /// <summary>
        /// Checks if VirtualName property is set
        /// </summary>
        /// <returns>true if VirtualName property is set</returns>
        public bool IsSetVirtualName()
        {
            return this.virtualNameField != null;
        }

        /// <summary>
        /// Gets and sets the Ebs property.
        /// Specifies parameters used to automatically
        /// setup Amazon EBS
        /// volumes when the instance is launched.
        /// </summary>
        [XmlElementAttribute(ElementName = "Ebs")]
        public EbsBlockDevice Ebs
        {
            get { return this.ebsField; }
            set { this.ebsField = value; }
        }

        /// <summary>
        /// Sets the Ebs property
        /// </summary>
        /// <param name="ebs">Specifies parameters used to automatically
        /// setup Amazon EBS
        /// volumes when the instance is launched.</param>
        /// <returns>this instance</returns>
        public BlockDeviceMapping WithEbs(EbsBlockDevice ebs)
        {
            this.ebsField = ebs;
            return this;
        }

        /// <summary>
        /// Checks if Ebs property is set
        /// </summary>
        /// <returns>true if Ebs property is set</returns>
        public bool IsSetEbs()
        {
            return this.ebsField != null;
        }

        /// <summary>
        /// Gets and sets the NoDevice property.
        /// Specifies the device name to suppress during
        /// instance launch.
        /// </summary>
        [XmlElementAttribute(ElementName = "NoDevice")]
        public string NoDevice
        {
            get { return this.noDeviceField; }
            set { this.noDeviceField = value; }
        }

        /// <summary>
        /// Sets the NoDevice property
        /// </summary>
        /// <param name="noDevice">Specifies the device name to suppress during
        /// instance launch.</param>
        /// <returns>this instance</returns>
        public BlockDeviceMapping WithNoDevice(string noDevice)
        {
            this.noDeviceField = noDevice;
            return this;
        }

        /// <summary>
        /// Checks if NoDevice property is set
        /// </summary>
        /// <returns>true if NoDevice property is set</returns>
        public bool IsSetNoDevice()
        {
            return this.noDeviceField != null;
        }

    }
}
