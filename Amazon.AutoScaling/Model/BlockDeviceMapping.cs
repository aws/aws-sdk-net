/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.AutoScaling.Model
{
    ///<summary>
    ///The BlockDeviceMapping data type.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class BlockDeviceMapping
    {
        private string virtualNameField;
        private string deviceNameField;

        /// <summary>
        /// Gets and sets the VirtualName property.
        /// Virtual name associated with the device.
        /// </summary>
        [XmlElementAttribute(ElementName = "VirtualName")]
        public string VirtualName
        {
            get { return this.virtualNameField ; }
            set { this.virtualNameField= value; }
        }

        /// <summary>
        /// Sets the VirtualName property
        /// </summary>
        /// <param name="virtualName">Virtual name associated with the device.</param>
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
            return  this.virtualNameField != null;
        }

        /// <summary>
        /// Gets and sets the DeviceName property.
        /// Name of the device within Amazon EC2.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeviceName")]
        public string DeviceName
        {
            get { return this.deviceNameField ; }
            set { this.deviceNameField= value; }
        }

        /// <summary>
        /// Sets the DeviceName property
        /// </summary>
        /// <param name="deviceName">Name of the device within Amazon EC2.</param>
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
            return  this.deviceNameField != null;
        }

    }
}
