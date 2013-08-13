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
    /// Volume description
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Volume
    {    
        private string volumeIdField;
        private string sizeField;
        private string snapshotIdField;
        private string availabilityZoneField;
        private string statusField;
        private string createTimeField;
        private List<Attachment> attachmentField;
        private List<Tag> tagField;
        private string volumeTypeField;
        private string iopsField;

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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithVolumeId(string volumeId)
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
        /// The size of the volume, in GiBs.
        /// </summary>
        [XmlElementAttribute(ElementName = "Size")]
        public string Size
        {
            get { return this.sizeField; }
            set { this.sizeField = value; }
        }

        /// <summary>
        /// Sets the size of the volume, in GiBs.
        /// </summary>
        /// <param name="size">The size of the volume, in GiBs.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithSize(string size)
        {
            this.sizeField = size;
            return this;
        }

        /// <summary>
        /// Checks if Size property is set
        /// </summary>
        /// <returns>true if Size property is set</returns>
        public bool IsSetSize()
        {
            return this.sizeField != null;
        }

        /// <summary>
        /// Snapshot from which the volume was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the snapshot from which the volume was created.
        /// </summary>
        /// <param name="snapshotId">Snapshot from which the volume was created (optional).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithSnapshotId(string snapshotId)
        {
            this.snapshotIdField = snapshotId;
            return this;
        }

        /// <summary>
        /// Checks if SnapshotId property is set
        /// </summary>
        /// <returns>true if SnapshotId property is set</returns>
        public bool IsSetSnapshotId()
        {
            return this.snapshotIdField != null;
        }

        /// <summary>
        /// Availability Zone in which the volume was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone in which the volume was created.
        /// </summary>
        /// <param name="availabilityZone">Availability Zone in which the volume was created.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// Volume state
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the volume state
        /// </summary>
        /// <param name="status">Volume state</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithStatus(string status)
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
        /// Time stamp when volume creation was initiated.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreateTime")]
        public string CreateTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
        }

        /// <summary>
        /// Sets the time stamp when volume creation was initiated.
        /// </summary>
        /// <param name="createTime">Time stamp when volume creation was initiated.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithCreateTime(string createTime)
        {
            this.createTimeField = createTime;
            return this;
        }

        /// <summary>
        /// Checks if CreateTime property is set
        /// </summary>
        /// <returns>true if CreateTime property is set</returns>
        public bool IsSetCreateTime()
        {
            return this.createTimeField != null;
        }

        /// <summary>
        /// List of attachments
        /// </summary>
        [XmlElementAttribute(ElementName = "Attachment")]
        public List<Attachment> Attachment
        {
            get
            {
                if (this.attachmentField == null)
                {
                    this.attachmentField = new List<Attachment>();
                }
                return this.attachmentField;
            }
            set { this.attachmentField = value; }
        }

        /// <summary>
        /// Sets the list of attachments
        /// </summary>
        /// <param name="list">List of attachments</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithAttachment(params Attachment[] list)
        {
            foreach (Attachment item in list)
            {
                Attachment.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Attachment property is set
        /// </summary>
        /// <returns>true if Attachment property is set</returns>
        public bool IsSetAttachment()
        {
            return (Attachment.Count > 0);
        }

        /// <summary>
        /// A list of tags for the Volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "Tag")]
        public List<Tag> Tag
        {
            get
            {
                if (this.tagField == null)
                {
                    this.tagField = new List<Tag>();
                }
                return this.tagField;
            }
            set { this.tagField = value; }
        }

        /// <summary>
        /// Sets a list of tags for the Volume.
        /// </summary>
        /// <param name="list">A list of tags for the Volume.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithTag(params Tag[] list)
        {
            foreach (Tag item in list)
            {
                Tag.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Tag property is set
        /// </summary>
        /// <returns>true if Tag property is set</returns>
        public bool IsSetTag()
        {
            return (Tag.Count > 0);
        }

        /// <summary>
        /// Quantity of desired throughput in IOPS.
        /// </summary>
        [XmlElementAttribute(ElementName = "IOPS")]
        public string IOPS
        {
            get { return this.iopsField; }
            set { this.iopsField = value; }
        }

        /// <summary>
        /// Sets the quantity of desired throughput in IOPS.
        /// </summary>
        /// <param name="iops">Quantity of desired throughput in IOPS</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithIOPS(string iops)
        {
            this.iopsField = iops;
            return this;
        }

        /// <summary>
        /// Checks if IOPS property is set
        /// </summary>
        /// <returns>True if IOPS property is set</returns>
        public bool IsSetIOPS()
        {
            return this.iopsField != null;
        }

        /// <summary>
        /// Volume type.
        /// May be either "io1" or "standard".
        /// If VolumeType != "io1", IOPS property cannot be set.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeType")]
        public string VolumeType
        {
            get { return this.volumeTypeField; }
            set { this.volumeTypeField = value; }
        }

        /// <summary>
        /// Sets the volume type.
        /// </summary>
        /// <param name="volumeType">Volume Type.
        /// Constraints: may be either "io1" or "standard".
        /// If VolumeType != "io1", IOPS property cannot be set.
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Volume WithVolumeType(string volumeType)
        {
            this.volumeTypeField = volumeType;
            return this;
        }

        /// <summary>
        /// Checks if VolumeType property is set
        /// </summary>
        /// <returns>True if VolumeType property is set</returns>
        public bool IsSetVolumeType()
        {
            return this.volumeTypeField != null;
        }
    }
}
