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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains detailed information about a saved recovery point.
    /// </summary>
    public partial class RecoveryPointByResource
    {
        private long? _backupSizeBytes;
        private string _backupVaultName;
        private DateTime? _creationDate;
        private string _encryptionKeyArn;
        private EncryptionKeyType _encryptionKeyType;
        private IndexStatus _indexStatus;
        private string _indexStatusMessage;
        private bool? _isParent;
        private string _parentRecoveryPointArn;
        private string _recoveryPointArn;
        private string _resourceName;
        private RecoveryPointStatus _status;
        private string _statusMessage;
        private VaultType _vaultType;

        /// <summary>
        /// Gets and sets the property BackupSizeBytes. 
        /// <para>
        /// The size, in bytes, of a backup.
        /// </para>
        /// </summary>
        public long? BackupSizeBytes
        {
            get { return this._backupSizeBytes; }
            set { this._backupSizeBytes = value; }
        }

        // Check to see if BackupSizeBytes property is set
        internal bool IsSetBackupSizeBytes()
        {
            return this._backupSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a recovery point is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
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
        /// The server-side encryption key that is used to protect your backups; for example,
        /// <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
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
        /// Gets and sets the property EncryptionKeyType. 
        /// <para>
        /// The type of encryption key used for the recovery point. Valid values are CUSTOMER_MANAGED_KMS_KEY
        /// for customer-managed keys or Amazon Web Services_OWNED_KMS_KEY for Amazon Web Services-owned
        /// keys.
        /// </para>
        /// </summary>
        public EncryptionKeyType EncryptionKeyType
        {
            get { return this._encryptionKeyType; }
            set { this._encryptionKeyType = value; }
        }

        // Check to see if EncryptionKeyType property is set
        internal bool IsSetEncryptionKeyType()
        {
            return this._encryptionKeyType != null;
        }

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// This is the current status for the backup index associated with the specified recovery
        /// point.
        /// </para>
        ///  
        /// <para>
        /// Statuses are: <c>PENDING</c> | <c>ACTIVE</c> | <c>FAILED</c> | <c>DELETING</c> 
        /// </para>
        ///  
        /// <para>
        /// A recovery point with an index that has the status of <c>ACTIVE</c> can be included
        /// in a search.
        /// </para>
        /// </summary>
        public IndexStatus IndexStatus
        {
            get { return this._indexStatus; }
            set { this._indexStatus = value; }
        }

        // Check to see if IndexStatus property is set
        internal bool IsSetIndexStatus()
        {
            return this._indexStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IndexStatusMessage. 
        /// <para>
        /// A string in the form of a detailed message explaining the status of a backup index
        /// associated with the recovery point.
        /// </para>
        /// </summary>
        public string IndexStatusMessage
        {
            get { return this._indexStatusMessage; }
            set { this._indexStatusMessage = value; }
        }

        // Check to see if IndexStatusMessage property is set
        internal bool IsSetIndexStatusMessage()
        {
            return this._indexStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property IsParent. 
        /// <para>
        /// This is a boolean value indicating this is a parent (composite) recovery point.
        /// </para>
        /// </summary>
        public bool? IsParent
        {
            get { return this._isParent; }
            set { this._isParent = value; }
        }

        // Check to see if IsParent property is set
        internal bool IsSetIsParent()
        {
            return this._isParent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentRecoveryPointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parent (composite) recovery point.
        /// </para>
        /// </summary>
        public string ParentRecoveryPointArn
        {
            get { return this._parentRecoveryPointArn; }
            set { this._parentRecoveryPointArn = value; }
        }

        // Check to see if ParentRecoveryPointArn property is set
        internal bool IsSetParentRecoveryPointArn()
        {
            return this._parentRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a recovery point; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The non-unique name of the resource that belongs to the specified backup.
        /// </para>
        /// </summary>
        public string ResourceName
        {
            get { return this._resourceName; }
            set { this._resourceName = value; }
        }

        // Check to see if ResourceName property is set
        internal bool IsSetResourceName()
        {
            return this._resourceName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code specifying the state of the recovery point.
        /// </para>
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message explaining the current status of the recovery point.
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
        /// Gets and sets the property VaultType. 
        /// <para>
        /// The type of vault in which the described recovery point is stored.
        /// </para>
        /// </summary>
        public VaultType VaultType
        {
            get { return this._vaultType; }
            set { this._vaultType = value; }
        }

        // Check to see if VaultType property is set
        internal bool IsSetVaultType()
        {
            return this._vaultType != null;
        }

    }
}