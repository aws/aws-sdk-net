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
    /// A Snapshot of an EBS volume.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Snapshot
    {    
        private string snapshotIdField;
        private string volumeIdField;
        private string statusField;
        private string startTimeField;
        private string progressField;
        private string ownerIdField;
        private string volumeSizeField;
        private string descriptionField;
        private string ownerAliasField;
        private List<Tag> tagField;

        /// <summary>
        /// The ID of the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the snapshot.
        /// </summary>
        /// <param name="snapshotId">The ID of the snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithSnapshotId(string snapshotId)
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
        /// The ID of the volume from which the snapshot was created.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the volume from which the snapshot was created.
        /// </summary>
        /// <param name="volumeId">The ID of the volume from which the snapshot
        /// was created.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithVolumeId(string volumeId)
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
        /// Snapshot state.
        /// Valid values: pending | completed | error
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the snapshot state.
        /// </summary>
        /// <param name="status">Snapshot state - can be one of pending | completed | error</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithStatus(string status)
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
        /// Time stamp when the snapshot was initiated.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public string StartTime
        {
            get { return this.startTimeField; }
            set { this.startTimeField = value; }
        }

        /// <summary>
        /// Sets the time stamp when the snapshot was initiated.
        /// </summary>
        /// <param name="startTime">Time stamp when the snapshot was initiated.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithStartTime(string startTime)
        {
            this.startTimeField = startTime;
            return this;
        }

        /// <summary>
        /// Checks if StartTime property is set
        /// </summary>
        /// <returns>true if StartTime property is set</returns>
        public bool IsSetStartTime()
        {
            return this.startTimeField != null;
        }

        /// <summary>
        /// The progress of the snapshot, in percentage.
        /// </summary>
        [XmlElementAttribute(ElementName = "Progress")]
        public string Progress
        {
            get { return this.progressField; }
            set { this.progressField = value; }
        }

        /// <summary>
        /// Sets the progress of the snapshot, in percentage.
        /// </summary>
        /// <param name="progress">The progress of the snapshot, in percentage.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithProgress(string progress)
        {
            this.progressField = progress;
            return this;
        }

        /// <summary>
        /// Checks if Progress property is set
        /// </summary>
        /// <returns>true if Progress property is set</returns>
        public bool IsSetProgress()
        {
            return this.progressField != null;
        }

        /// <summary>
        /// AWS Access Key ID of the user who owns the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerId")]
        public string OwnerId
        {
            get { return this.ownerIdField; }
            set { this.ownerIdField = value; }
        }

        /// <summary>
        /// Sets the AWS Access Key ID of the user who owns the snapshot.
        /// </summary>
        /// <param name="ownerId">AWS Access Key ID of the user who owns the
        /// snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithOwnerId(string ownerId)
        {
            this.ownerIdField = ownerId;
            return this;
        }

        /// <summary>
        /// Checks if OwnerId property is set
        /// </summary>
        /// <returns>true if OwnerId property is set</returns>
        public bool IsSetOwnerId()
        {
            return this.ownerIdField != null;
        }

        /// <summary>
        /// Size of the volume
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeSize")]
        public string VolumeSize
        {
            get { return this.volumeSizeField; }
            set { this.volumeSizeField = value; }
        }

        /// <summary>
        /// Sets the size of the volume
        /// </summary>
        /// <param name="volumeSize">Size of the volume</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithVolumeSize(string volumeSize)
        {
            this.volumeSizeField = volumeSize;
            return this;
        }

        /// <summary>
        /// Checks if VolumeSize property is set
        /// </summary>
        /// <returns>true if VolumeSize property is set</returns>
        public bool IsSetVolumeSize()
        {
            return this.volumeSizeField != null;
        }

        /// <summary>
        /// Description of the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the snapshot.
        /// </summary>
        /// <param name="description">Description of the snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }

        /// <summary>
        /// The AWS account alias (amazon, self, etc.) or AWS account ID that owns the AMI.
        /// </summary>
        [XmlElementAttribute(ElementName = "OwnerAlias")]
        public string OwnerAlias
        {
            get { return this.ownerAliasField; }
            set { this.ownerAliasField = value; }
        }

        /// <summary>
        /// Sets the AWS account alias (amazon, self, etc.) or AWS account ID that owns the AMI.
        /// </summary>
        /// <param name="ownerAlias">OwnerAlias property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithOwnerAlias(string ownerAlias)
        {
            this.ownerAliasField = ownerAlias;
            return this;
        }

        /// <summary>
        /// Checks if OwnerAlias property is set
        /// </summary>
        /// <returns>true if OwnerAlias property is set</returns>
        public bool IsSetOwnerAlias()
        {
            return this.ownerAliasField != null;
        }

        /// <summary>
        /// A list of tags for the Snapshot.
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
        /// Sets the tags for the Snapshot.
        /// </summary>
        /// <param name="list">A list of tags for the Snapshot.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Snapshot WithTag(params Tag[] list)
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
