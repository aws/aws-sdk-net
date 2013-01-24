/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <summary>
    /// Instance block device mapping set.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceBlockDeviceMapping
    {    
        private string deviceNameField;
        private InstanceEbsBlockDevice ebsField;

        /// <summary>
        /// The device name exposed to the instance (e.g., /dev/sdh).
        /// </summary>
        [XmlElementAttribute(ElementName = "DeviceName")]
        public string DeviceName
        {
            get { return this.deviceNameField; }
            set { this.deviceNameField = value; }
        }

        /// <summary>
        /// Sets the device name exposed to the instance (e.g., /dev/sdh).
        /// </summary>
        /// <param name="deviceName">The device name (e.g., /dev/sdh).</param>
        /// <returns>this instance</returns>
        public InstanceBlockDeviceMapping WithDeviceName(string deviceName)
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
        /// Parameters used to automatically set up Amazon EBS volumes when 
        /// the instance is launched.
        /// </summary>
        [XmlElementAttribute(ElementName = "Ebs")]
        public InstanceEbsBlockDevice Ebs
        {
            get { return this.ebsField; }
            set { this.ebsField = value; }
        }

        /// <summary>
        /// Sets the parameters used to automatically set up Amazon EBS volumes when 
        /// the instance is launched.
        /// </summary>
        /// <param name="ebs">Ebs property</param>
        /// <returns>this instance</returns>
        public InstanceBlockDeviceMapping WithEbs(InstanceEbsBlockDevice ebs)
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

    }
}
