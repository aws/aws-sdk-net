/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.FSx.Model
{
    /// <summary>
    /// A backup of an Amazon FSx for Windows File Server, Amazon FSx for Lustre file system,
    /// Amazon FSx for NetApp ONTAP volume, or Amazon FSx for OpenZFS file system.
    /// </summary>
    public partial class Backup
    {
        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 128)]
        public string BackupId { get; set; }

        /// <summary>
        /// Checks to see if the BackupId property is set.
        /// </summary>
        internal bool IsSetBackupId() => this.BackupId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when a particular backup was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DirectoryInformation. 
        /// <para>
        /// The configuration of the self-managed Microsoft Active Directory directory to which
        /// the Windows File Server instance is joined.
        /// </para>
        /// </summary>
        public ActiveDirectoryBackupAttributes DirectoryInformation { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryInformation property is set.
        /// </summary>
        internal bool IsSetDirectoryInformation() => this.DirectoryInformation != null;

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Details explaining any failures that occurred when creating a backup.
        /// </para>
        /// </summary>
        public BackupFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Checks to see if the FailureDetails property is set.
        /// </summary>
        internal bool IsSetFailureDetails() => this.FailureDetails != null;

        /// <summary>
        /// Gets and sets the property FileSystem. 
        /// <para>
        /// The metadata of the file system associated with the backup. This metadata is persisted
        /// even if the file system is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileSystem FileSystem { get; set; }

        /// <summary>
        /// Checks to see if the FileSystem property is set.
        /// </summary>
        internal bool IsSetFileSystem() => this.FileSystem != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt the backup of the Amazon
        /// FSx file system's data at rest. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the backup.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The backup is fully available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - For user-initiated backups on Lustre file systems only; Amazon FSx
        /// hasn't started creating the backup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> - Amazon FSx is creating the backup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSFERRING</c> - For user-initiated backups on Lustre file systems only; Amazon
        /// FSx is transferring the backup to Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COPYING</c> - Amazon FSx is copying the backup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> - Amazon FSx deleted the backup and it's no longer available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Amazon FSx couldn't finish the backup.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public BackupLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property OwnerId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ProgressPercent.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the backup resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the resource type that's backed up.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        ///  The size of the backup in bytes. This represents the amount of data that the file
        /// system would contain if you restore this backup. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the SizeInBytes property is set.
        /// </summary>
        internal bool IsSetSizeInBytes() => this.SizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBackupId.
        /// </summary>
        [AWSProperty(Min = 12, Max = 128)]
        public string SourceBackupId { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupId property is set.
        /// </summary>
        internal bool IsSetSourceBackupId() => this.SourceBackupId != null;

        /// <summary>
        /// Gets and sets the property SourceBackupRegion. 
        /// <para>
        /// The source Region of the backup. Specifies the Region from where this backup is copied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string SourceBackupRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupRegion property is set.
        /// </summary>
        internal bool IsSetSourceBackupRegion() => this.SourceBackupRegion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with a particular file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the file-system backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BackupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Volume.
        /// </summary>
        public Volume Volume { get; set; }

        /// <summary>
        /// Checks to see if the Volume property is set.
        /// </summary>
        internal bool IsSetVolume() => this.Volume != null;
    }
}
