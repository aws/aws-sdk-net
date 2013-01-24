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
    /// Detaches an Amazon EBS volume from an instance.
    /// </summary>
    /// <remarks>
    /// For more information about Amazon EBS, go
    /// to the Amazon Elastic Compute Cloud Developer Guide.
    ///
    /// Important - make sure to unmount any file systems
    /// on the device within your operating system before
    /// detaching the volume.
    ///
    /// Failure to unmount file systems, or otherwise
    /// properly release the device from use, can result
    /// in lost data and will corrupt the file system.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DetachVolumeRequest
    {    
        private string volumeIdField;
        private string instanceIdField;
        private string deviceField;
        private bool? forceField;

        /// <summary>
        /// The ID of the volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the volume.
        /// </summary>
        /// <param name="volumeId">The ID of the volume.</param>
        /// <returns>this instance</returns>
        public DetachVolumeRequest WithVolumeId(string volumeId)
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
        /// The ID of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the instance.
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        /// <returns>this instance</returns>
        public DetachVolumeRequest WithInstanceId(string instanceId)
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
        /// The device name.
        /// </summary>
        [XmlElementAttribute(ElementName = "Device")]
        public string Device
        {
            get { return this.deviceField; }
            set { this.deviceField = value; }
        }

        /// <summary>
        /// Sets the device name.
        /// </summary>
        /// <param name="device">The device name.</param>
        /// <returns>this instance</returns>
        public DetachVolumeRequest WithDevice(string device)
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

        /// <summary>
        /// Whether to force detachment.
        /// </summary>
        /// <remarks>
        /// Forces detachment if the previous detachment
        /// attempt did not occur cleanly (logging into an instance,
        /// unmounting the volume, and detaching normally). This option
        /// can lead to data loss or a corrupted file system.
        ///
        /// Use this option only as a last resort to detach a volume from a
        /// failed instance. The instance will not have an opportunity
        /// to flush file system caches nor file
        /// system meta data. If you use this option, you
        /// must perform file system check and repair procedures.
        /// </remarks>
        [XmlElementAttribute(ElementName = "Force")]
        public bool Force
        {
            get { return this.forceField.GetValueOrDefault(); }
            set { this.forceField = value; }
        }

        /// <summary>
        /// Sets whether to force detachment.
        /// </summary>
        /// <param name="force">Forces detachment if the previous detachment
        /// attempt did not occur
        /// cleanly (logging into an instance,
        /// unmounting the volume, and detaching normally). This option
        /// can lead to data loss or a corrupted file system.
        ///
        /// Use this option only as a last resort to detach a volume from a
        /// failed instance. The instance will not have an opportunity
        /// to flush file system caches nor file
        /// system meta data. If you use this option, you
        /// must perform file system check and repair procedures.</param>
        /// <returns>this instance</returns>
        public DetachVolumeRequest WithForce(bool force)
        {
            this.forceField = force;
            return this;
        }

        /// <summary>
        /// Checks if Force property is set
        /// </summary>
        /// <returns>true if Force property is set</returns>
        public bool IsSetForce()
        {
            return this.forceField.HasValue;
        }

    }
}
