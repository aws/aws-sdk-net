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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeRecoveryPoint operation.
    /// </summary>
    public partial class DescribeRecoveryPointResponse : AmazonWebServiceResponse
    {
        private long? _backupSizeInBytes;
        private string _backupVaultArn;
        private string _backupVaultName;
        private CalculatedLifecycle _calculatedLifecycle;
        private DateTime? _completionDate;
        private RecoveryPointCreator _createdBy;
        private DateTime? _creationDate;
        private string _encryptionKeyArn;
        private string _iamRoleArn;
        private bool? _isEncrypted;
        private DateTime? _lastRestoreTime;
        private Lifecycle _lifecycle;
        private string _recoveryPointArn;
        private string _resourceArn;
        private string _resourceType;
        private RecoveryPointStatus _status;
        private StorageClass _storageClass;

        /// <summary>
        /// Gets and sets the property BackupSizeInBytes. 
        /// <para>
        /// The size, in bytes, of a backup.
        /// </para>
        /// </summary>
        public long BackupSizeInBytes
        {
            get { return this._backupSizeInBytes.GetValueOrDefault(); }
            set { this._backupSizeInBytes = value; }
        }

        // Check to see if BackupSizeInBytes property is set
        internal bool IsSetBackupSizeInBytes()
        {
            return this._backupSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An ARN that uniquely identifies a backup vault; for example, <code>arn:aws:backup:us-east-1:123456789012:vault:aBackupVault</code>.
        /// </para>
        /// </summary>
        public string BackupVaultArn
        {
            get { return this._backupVaultArn; }
            set { this._backupVaultArn = value; }
        }

        // Check to see if BackupVaultArn property is set
        internal bool IsSetBackupVaultArn()
        {
            return this._backupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Region where they
        /// are created. They consist of lowercase letters, numbers, and hyphens.
        /// </para>
        /// </summary>
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property CalculatedLifecycle. 
        /// <para>
        /// A <code>CalculatedLifecycle</code> object containing <code>DeleteAt</code> and <code>MoveToColdStorageAt</code>
        /// timestamps.
        /// </para>
        /// </summary>
        public CalculatedLifecycle CalculatedLifecycle
        {
            get { return this._calculatedLifecycle; }
            set { this._calculatedLifecycle = value; }
        }

        // Check to see if CalculatedLifecycle property is set
        internal bool IsSetCalculatedLifecycle()
        {
            return this._calculatedLifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time that a job to create a recovery point is completed, in Unix format
        /// and Coordinated Universal Time (UTC). The value of <code>CompletionDate</code> is
        /// accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime CompletionDate
        {
            get { return this._completionDate.GetValueOrDefault(); }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Contains identifying information about the creation of a recovery point, including
        /// the <code>BackupPlanArn</code>, <code>BackupPlanId</code>, <code>BackupPlanVersion</code>,
        /// and <code>BackupRuleId</code> of the backup plan used to create it.
        /// </para>
        /// </summary>
        public RecoveryPointCreator CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a recovery point is created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <code>CreationDate</code> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The server-side encryption key used to protect your backups; for example, <code>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to create the target recovery point; for example,
        /// <code>arn:aws:iam::123456789012:role/S3Access</code>.
        /// </para>
        /// </summary>
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property IsEncrypted. 
        /// <para>
        /// A Boolean value that is returned as <code>TRUE</code> if the specified recovery point
        /// is encrypted, or <code>FALSE</code> if the recovery point is not encrypted.
        /// </para>
        /// </summary>
        public bool IsEncrypted
        {
            get { return this._isEncrypted.GetValueOrDefault(); }
            set { this._isEncrypted = value; }
        }

        // Check to see if IsEncrypted property is set
        internal bool IsSetIsEncrypted()
        {
            return this._isEncrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastRestoreTime. 
        /// <para>
        /// The date and time that a recovery point was last restored, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <code>LastRestoreTime</code> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime LastRestoreTime
        {
            get { return this._lastRestoreTime.GetValueOrDefault(); }
            set { this._lastRestoreTime = value; }
        }

        // Check to see if LastRestoreTime property is set
        internal bool IsSetLastRestoreTime()
        {
            return this._lastRestoreTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. AWS Backup transitions and expires backups automatically according
        /// to the lifecycle that you define. 
        /// </para>
        ///  
        /// <para>
        /// Backups that are transitioned to cold storage must be stored in cold storage for a
        /// minimum of 90 days. Therefore, the “expire after days” setting must be 90 days greater
        /// than the “transition to cold after days” setting. The “transition to cold after days”
        /// setting cannot be changed after a backup has been transitioned to cold. 
        /// </para>
        /// </summary>
        public Lifecycle Lifecycle
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
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point; for example, <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
        /// </para>
        /// </summary>
        public string RecoveryPointArn
        {
            get { return this._recoveryPointArn; }
            set { this._recoveryPointArn = value; }
        }

        // Check to see if RecoveryPointArn property is set
        internal bool IsSetRecoveryPointArn()
        {
            return this._recoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies a saved resource. The format of the ARN depends on
        /// the resource type.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of AWS resource to save as a recovery point; for example, an Amazon Elastic
        /// Block Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS)
        /// database.
        /// </para>
        /// </summary>
        public string ResourceType
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code specifying the state of the recovery point.
        /// </para>
        ///  <note> 
        /// <para>
        /// A partial status indicates that the recovery point was not successfully re-created
        /// and must be retried.
        /// </para>
        ///  </note>
        /// </summary>
        public RecoveryPointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Specifies the storage class of the recovery point. Valid values are <code>WARM</code>
        /// or <code>COLD</code>.
        /// </para>
        /// </summary>
        public StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

    }
}