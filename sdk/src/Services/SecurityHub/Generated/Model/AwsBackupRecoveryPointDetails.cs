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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains detailed information about the recovery points stored in an Backup backup
    /// vault. A backup, or recovery point, represents the content of a resource at a specified
    /// time.
    /// </summary>
    public partial class AwsBackupRecoveryPointDetails
    {
        private long? _backupSizeInBytes;
        private string _backupVaultArn;
        private string _backupVaultName;
        private AwsBackupRecoveryPointCalculatedLifecycleDetails _calculatedLifecycle;
        private string _completionDate;
        private AwsBackupRecoveryPointCreatedByDetails _createdBy;
        private string _creationDate;
        private string _encryptionKeyArn;
        private string _iamRoleArn;
        private bool? _isEncrypted;
        private string _lastRestoreTime;
        private AwsBackupRecoveryPointLifecycleDetails _lifecycle;
        private string _recoveryPointArn;
        private string _resourceArn;
        private string _resourceType;
        private string _sourceBackupVaultArn;
        private string _status;
        private string _statusMessage;
        private string _storageClass;

        /// <summary>
        /// Gets and sets the property BackupSizeInBytes. 
        /// <para>
        /// The size, in bytes, of a backup. 
        /// </para>
        /// </summary>
        public long? BackupSizeInBytes
        {
            get { return this._backupSizeInBytes; }
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
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault. 
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
        /// by names that are unique to the Amazon Web Services account used to create them and
        /// the Amazon Web Services Region where they are created. They consist of lowercase letters,
        /// numbers, and hyphens. 
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
        /// A <c>CalculatedLifecycle</c> object containing <c>DeleteAt</c> and <c>MoveToColdStorageAt</c>
        /// timestamps. 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointCalculatedLifecycleDetails CalculatedLifecycle
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
        /// and UTC. The value of <c>CompletionDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM. 
        /// </para>
        /// </summary>
        public string CompletionDate
        {
            get { return this._completionDate; }
            set { this._completionDate = value; }
        }

        // Check to see if CompletionDate property is set
        internal bool IsSetCompletionDate()
        {
            return this._completionDate != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Contains identifying information about the creation of a recovery point, including
        /// the <c>BackupPlanArn</c>, <c>BackupPlanId</c>, <c>BackupPlanVersion</c>, and <c>BackupRuleId</c>
        /// of the backup plan that is used to create it. 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointCreatedByDetails CreatedBy
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
        /// The date and time a recovery point is created, in Unix format and UTC. The value of
        /// <c>CreationDate</c> is accurate to milliseconds. For example, the value 1516925490.087
        /// represents Friday, January 26, 2018 12:11:30.087 AM. 
        /// </para>
        /// </summary>
        public string CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN for the server-side encryption key that is used to protect your backups. 
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
        /// Specifies the IAM role ARN used to create the target recovery point 
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
        /// A Boolean value that is returned as <c>TRUE</c> if the specified recovery point is
        /// encrypted, or <c>FALSE</c> if the recovery point is not encrypted. 
        /// </para>
        /// </summary>
        public bool? IsEncrypted
        {
            get { return this._isEncrypted; }
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
        /// The date and time that a recovery point was last restored, in Unix format and UTC.
        /// The value of <c>LastRestoreTime</c> is accurate to milliseconds. For example, the
        /// value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM. 
        /// </para>
        /// </summary>
        public string LastRestoreTime
        {
            get { return this._lastRestoreTime; }
            set { this._lastRestoreTime = value; }
        }

        // Check to see if LastRestoreTime property is set
        internal bool IsSetLastRestoreTime()
        {
            return this._lastRestoreTime != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. Backup transitions and expires backups automatically according to
        /// the lifecycle that you define 
        /// </para>
        /// </summary>
        public AwsBackupRecoveryPointLifecycleDetails Lifecycle
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
        /// An ARN that uniquely identifies a recovery point. 
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
        /// An ARN that uniquely identifies a resource. The format of the ARN depends on the resource
        /// type. 
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
        /// The type of Amazon Web Services resource saved as a recovery point, such as an Amazon
        /// EBS volume or an Amazon RDS database. 
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
        /// Gets and sets the property SourceBackupVaultArn. 
        /// <para>
        /// The ARN for the backup vault where the recovery point was originally copied from.
        /// If the recovery point is restored to the same account, this value will be null. 
        /// </para>
        /// </summary>
        public string SourceBackupVaultArn
        {
            get { return this._sourceBackupVaultArn; }
            set { this._sourceBackupVaultArn = value; }
        }

        // Check to see if SourceBackupVaultArn property is set
        internal bool IsSetSourceBackupVaultArn()
        {
            return this._sourceBackupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code specifying the state of the recovery point. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COMPLETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the reason of the recovery point deletion failure. 
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Specifies the storage class of the recovery point. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COLD</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARM</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageClass
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