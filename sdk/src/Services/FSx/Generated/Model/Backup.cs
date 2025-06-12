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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
        private string _backupId;
        private DateTime? _creationTime;
        private ActiveDirectoryBackupAttributes _directoryInformation;
        private BackupFailureDetails _failureDetails;
        private FileSystem _fileSystem;
        private string _kmsKeyId;
        private BackupLifecycle _lifecycle;
        private string _ownerId;
        private int? _progressPercent;
        private string _resourceARN;
        private ResourceType _resourceType;
        private long? _sizeInBytes;
        private string _sourceBackupId;
        private string _sourceBackupRegion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private BackupType _type;
        private Volume _volume;

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=128)]
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when a particular backup was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryInformation. 
        /// <para>
        /// The configuration of the self-managed Microsoft Active Directory directory to which
        /// the Windows File Server instance is joined.
        /// </para>
        /// </summary>
        public ActiveDirectoryBackupAttributes DirectoryInformation
        {
            get { return this._directoryInformation; }
            set { this._directoryInformation = value; }
        }

        // Check to see if DirectoryInformation property is set
        internal bool IsSetDirectoryInformation()
        {
            return this._directoryInformation != null;
        }

        /// <summary>
        /// Gets and sets the property FailureDetails. 
        /// <para>
        /// Details explaining any failures that occurred when creating a backup.
        /// </para>
        /// </summary>
        public BackupFailureDetails FailureDetails
        {
            get { return this._failureDetails; }
            set { this._failureDetails = value; }
        }

        // Check to see if FailureDetails property is set
        internal bool IsSetFailureDetails()
        {
            return this._failureDetails != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystem. 
        /// <para>
        /// The metadata of the file system associated with the backup. This metadata is persisted
        /// even if the file system is deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileSystem FileSystem
        {
            get { return this._fileSystem; }
            set { this._fileSystem = value; }
        }

        // Check to see if FileSystem property is set
        internal bool IsSetFileSystem()
        {
            return this._fileSystem != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt the backup of the Amazon
        /// FSx file system's data at rest. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

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
        [AWSProperty(Required=true)]
        public BackupLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId.
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ProgressPercent.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? ProgressPercent
        {
            get { return this._progressPercent; }
            set { this._progressPercent = value; }
        }

        // Check to see if ProgressPercent property is set
        internal bool IsSetProgressPercent()
        {
            return this._progressPercent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the backup resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=512)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Specifies the resource type that's backed up.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        ///  The size of the backup in bytes. This represents the amount of data that the file
        /// system would contain if you restore this backup. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? SizeInBytes
        {
            get { return this._sizeInBytes; }
            set { this._sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this._sizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceBackupId.
        /// </summary>
        [AWSProperty(Min=12, Max=128)]
        public string SourceBackupId
        {
            get { return this._sourceBackupId; }
            set { this._sourceBackupId = value; }
        }

        // Check to see if SourceBackupId property is set
        internal bool IsSetSourceBackupId()
        {
            return this._sourceBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBackupRegion. 
        /// <para>
        /// The source Region of the backup. Specifies the Region from where this backup is copied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string SourceBackupRegion
        {
            get { return this._sourceBackupRegion; }
            set { this._sourceBackupRegion = value; }
        }

        // Check to see if SourceBackupRegion property is set
        internal bool IsSetSourceBackupRegion()
        {
            return this._sourceBackupRegion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with a particular file system.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the file-system backup.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BackupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Volume.
        /// </summary>
        public Volume Volume
        {
            get { return this._volume; }
            set { this._volume = value; }
        }

        // Check to see if Volume property is set
        internal bool IsSetVolume()
        {
            return this._volume != null;
        }

    }
}