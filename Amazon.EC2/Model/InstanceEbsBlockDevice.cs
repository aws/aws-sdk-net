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
    ///Information about the instance EBS block device.
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceEbsBlockDevice
    {    
        private string volumeIdField;
        private string statusField;
        private string attachTimeField;
        private bool? deleteOnTerminationField;

        /// <summary>
        /// Gets and sets the VolumeId property.
        /// The ID of the Amazon EBS volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the VolumeId property
        /// </summary>
        /// <param name="volumeId">The ID of the Amazon EBS volume.</param>
        /// <returns>this instance</returns>
        public InstanceEbsBlockDevice WithVolumeId(string volumeId)
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
        /// Gets and sets the Status property.
        /// Attachment state of the EBS volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">Attachment state of the EBS volume.</param>
        /// <returns>this instance</returns>
        public InstanceEbsBlockDevice WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }

        /// <summary>
        /// Gets and sets the AttachTime property.
        /// Time the volume was attached.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttachTime")]
        public string AttachTime
        {
            get { return this.attachTimeField; }
            set { this.attachTimeField = value; }
        }

        /// <summary>
        /// Sets the AttachTime property
        /// </summary>
        /// <param name="attachTime">Time the volume was attached.</param>
        /// <returns>this instance</returns>
        public InstanceEbsBlockDevice WithAttachTime(string attachTime)
        {
            this.attachTimeField = attachTime;
            return this;
        }

        /// <summary>
        /// Checks if AttachTime property is set
        /// </summary>
        /// <returns>true if AttachTime property is set</returns>
        public bool IsSetAttachTime()
        {
            return this.attachTimeField != null;
        }

        /// <summary>
        /// Gets and sets the DeleteOnTermination property.
        /// Whether the volume will be deleted on instance
        /// termination.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeleteOnTermination")]
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTerminationField.GetValueOrDefault(); }
            set { this.deleteOnTerminationField = value; }
        }

        /// <summary>
        /// Sets the DeleteOnTermination property
        /// </summary>
        /// <param name="deleteOnTermination">Whether the volume will be deleted on instance
        /// termination.</param>
        /// <returns>this instance</returns>
        public InstanceEbsBlockDevice WithDeleteOnTermination(bool deleteOnTermination)
        {
            this.deleteOnTerminationField = deleteOnTermination;
            return this;
        }

        /// <summary>
        /// Checks if DeleteOnTermination property is set
        /// </summary>
        /// <returns>true if DeleteOnTermination property is set</returns>
        public bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTerminationField.HasValue;
        }

    }
}
