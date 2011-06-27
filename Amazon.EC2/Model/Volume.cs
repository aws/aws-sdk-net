/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Volume
    ///</summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
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

        /// <summary>
        /// Gets and sets the VolumeId property.
        /// The ID of the volume.
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
        /// <param name="volumeId">The ID of the volume.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Size property.
        /// The size of the volume, in GiBs.
        /// </summary>
        [XmlElementAttribute(ElementName = "Size")]
        public string Size
        {
            get { return this.sizeField; }
            set { this.sizeField = value; }
        }

        /// <summary>
        /// Sets the Size property
        /// </summary>
        /// <param name="size">The size of the volume, in GiBs.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the SnapshotId property.
        /// Snapshot from which the volume was created (optional).
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the SnapshotId property
        /// </summary>
        /// <param name="snapshotId">Snapshot from which the volume was created (optional).</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the AvailabilityZone property.
        /// Availability Zone in which the volume was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">Availability Zone in which the volume was created.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Status property.
        /// Volume state
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
        /// <param name="status">Volume state</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the CreateTime property.
        /// Time stamp when volume creation was initiated.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreateTime")]
        public string CreateTime
        {
            get { return this.createTimeField; }
            set { this.createTimeField = value; }
        }

        /// <summary>
        /// Sets the CreateTime property
        /// </summary>
        /// <param name="createTime">Time stamp when volume creation was initiated.</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Attachment property.
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
        /// Sets the Attachment property
        /// </summary>
        /// <param name="list">List of attachments</param>
        /// <returns>this instance</returns>
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
        /// Gets and sets the Tag property.
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
        /// Sets the Tag property
        /// </summary>
        /// <param name="list">A list of tags for the Volume.</param>
        /// <returns>this instance</returns>
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

    }
}
