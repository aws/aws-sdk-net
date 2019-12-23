/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// A backup of an Amazon FSx for Windows File Server file system. You can create a new
    /// file system from a backup to protect against data loss.
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
        private int? _progressPercent;
        private string _resourceARN;
        private List<Tag> _tags = new List<Tag>();
        private BackupType _type;

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
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// The configuration of the self-managed Microsoft Active Directory (AD) to which the
        /// Windows File Server instance is joined.
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
        /// Details explaining any failures that occur when creating a backup.
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
        /// Metadata of the file system associated with the backup. This metadata is persisted
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
        /// The ID of the AWS Key Management Service (AWS KMS) key used to encrypt this backup
        /// of the Amazon FSx for Windows file system's data at rest. Amazon FSx for Lustre does
        /// not support KMS encryption.
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
        /// Gets and sets the property ProgressPercent.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int ProgressPercent
        {
            get { return this._progressPercent.GetValueOrDefault(); }
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with a particular file system.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the backup.
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

    }
}