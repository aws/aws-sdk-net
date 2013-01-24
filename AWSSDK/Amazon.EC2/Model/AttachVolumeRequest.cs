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
    /// Attaches an Amazon EBS volume to a running instance and exposes it with the
    /// specified device name.
    /// </summary>
    /// <remarks>
    /// Windows instances currently support devices xvda through xvdp. Devices
    /// xvda and xvdb are reserved by the operating system, xvdc is
    /// assigned to drive C:\, and, depending on the instance type, devices xvdd through
    /// xvde might be reserved by the instance stores. Any device that is not
    /// reserved can be attached to an Amazon EBS volume. For a list of
    /// devices that are reserved by the instance stores, go to the Amazon
    /// Elastic Compute Cloud Developer Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class AttachVolumeRequest
    {    
        private string volumeIdField;
        private string instanceIdField;
        private string deviceField;

        /// <summary>
        /// The ID of the Amazon EBS volume.
        /// The volume and instance must be within the same Availability Zone and the
        /// instance must be running.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Amazon EBS volume.
        /// </summary>
        /// <param name="volumeId">The ID of the Amazon EBS volume.</param>
        /// <returns>this instance</returns>
        public AttachVolumeRequest WithVolumeId(string volumeId)
        {
            this.volumeIdField = volumeId;
            return this;
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return this.volumeIdField != null;
        }

        /// <summary>
        /// The ID of the instance to which the volume attaches.
        /// The volume and instance must be within the same Availability Zone
        /// and the instance must be running.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the instance to which the volume attaches.
        /// </summary>
        /// <param name="instanceId">The ID of the instance to which the volume
        /// attaches.</param>
        /// <returns>this instance</returns>
        public AttachVolumeRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// The device name as exposed to the instance (e.g., /dev/sdh, or xvdh).
        /// </summary>
        [XmlElementAttribute(ElementName = "Device")]
        public string Device
        {
            get { return this.deviceField; }
            set { this.deviceField = value; }
        }

        /// <summary>
        /// Sets the device name as exposed to the instance (e.g., /dev/sdh, or xvdh).
        /// </summary>
        /// <param name="device">Specifies how the device is exposed to the
        /// instance (e.g., /dev/sdh).</param>
        /// <returns>this instance</returns>
        public AttachVolumeRequest WithDevice(string device)
        {
            this.deviceField = device;
            return this;
        }

        /// <summary>
        /// Checks if Device property is set
        /// </summary>
        /// <returns>true if Device property is set</returns>
        public bool IsSetDevice()
        {
            return this.deviceField != null;
        }

    }
}
