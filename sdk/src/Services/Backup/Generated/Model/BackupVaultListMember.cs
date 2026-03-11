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
    /// Contains metadata about a backup vault.
    /// </summary>
    public partial class BackupVaultListMember
    {
        private string _backupVaultArn;
        private string _backupVaultName;
        private DateTime? _creationDate;
        private string _creatorRequestId;
        private string _encryptionKeyArn;
        private EncryptionKeyType _encryptionKeyType;
        private DateTime? _lockDate;
        private bool? _locked;
        private long? _maxRetentionDays;
        private long? _minRetentionDays;
        private long? _numberOfRecoveryPoints;
        private VaultState _vaultState;
        private VaultType _vaultType;

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
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
        /// The date and time a resource backup is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and allows failed requests to be retried
        /// without the risk of running the operation twice. This parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// A server-side encryption key you can specify to encrypt your backups from services
        /// that support full Backup management; for example, <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// If you specify a key, you must specify its ARN, not its alias. If you do not specify
        /// a key, Backup creates a KMS key for you by default.
        /// </para>
        ///  
        /// <para>
        /// To learn which Backup services support full Backup management and how Backup handles
        /// encryption for backups from services that do not yet support full Backup, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/encryption.html">
        /// Encryption for backups in Backup</a> 
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
        /// The type of encryption key used for the backup vault. Valid values are CUSTOMER_MANAGED_KMS_KEY
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
        /// Gets and sets the property LockDate. 
        /// <para>
        /// The date and time when Backup Vault Lock configuration becomes immutable, meaning
        /// it cannot be changed or deleted.
        /// </para>
        ///  
        /// <para>
        /// If you applied Vault Lock to your vault without specifying a lock date, you can change
        /// your Vault Lock settings, or delete Vault Lock from the vault entirely, at any time.
        /// </para>
        ///  
        /// <para>
        /// This value is in Unix format, Coordinated Universal Time (UTC), and accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? LockDate
        {
            get { return this._lockDate; }
            set { this._lockDate = value; }
        }

        // Check to see if LockDate property is set
        internal bool IsSetLockDate()
        {
            return this._lockDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Locked. 
        /// <para>
        /// A Boolean value that indicates whether Backup Vault Lock applies to the selected backup
        /// vault. If <c>true</c>, Vault Lock prevents delete and update operations on the recovery
        /// points in the selected vault.
        /// </para>
        /// </summary>
        public bool? Locked
        {
            get { return this._locked; }
            set { this._locked = value; }
        }

        // Check to see if Locked property is set
        internal bool IsSetLocked()
        {
            return this._locked.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetentionDays. 
        /// <para>
        /// The Backup Vault Lock setting that specifies the maximum retention period that the
        /// vault retains its recovery points. If this parameter is not specified, Vault Lock
        /// does not enforce a maximum retention period on the recovery points in the vault (allowing
        /// indefinite storage).
        /// </para>
        ///  
        /// <para>
        /// If specified, any backup or copy job to the vault must have a lifecycle policy with
        /// a retention period equal to or shorter than the maximum retention period. If the job's
        /// retention period is longer than that maximum retention period, then the vault fails
        /// the backup or copy job, and you should either modify your lifecycle settings or use
        /// a different vault. Recovery points already stored in the vault prior to Vault Lock
        /// are not affected.
        /// </para>
        /// </summary>
        public long? MaxRetentionDays
        {
            get { return this._maxRetentionDays; }
            set { this._maxRetentionDays = value; }
        }

        // Check to see if MaxRetentionDays property is set
        internal bool IsSetMaxRetentionDays()
        {
            return this._maxRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinRetentionDays. 
        /// <para>
        /// The Backup Vault Lock setting that specifies the minimum retention period that the
        /// vault retains its recovery points. If this parameter is not specified, Vault Lock
        /// does not enforce a minimum retention period.
        /// </para>
        ///  
        /// <para>
        /// If specified, any backup or copy job to the vault must have a lifecycle policy with
        /// a retention period equal to or longer than the minimum retention period. If the job's
        /// retention period is shorter than that minimum retention period, then the vault fails
        /// the backup or copy job, and you should either modify your lifecycle settings or use
        /// a different vault. Recovery points already stored in the vault prior to Vault Lock
        /// are not affected.
        /// </para>
        /// </summary>
        public long? MinRetentionDays
        {
            get { return this._minRetentionDays; }
            set { this._minRetentionDays = value; }
        }

        // Check to see if MinRetentionDays property is set
        internal bool IsSetMinRetentionDays()
        {
            return this._minRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfRecoveryPoints. 
        /// <para>
        /// The number of recovery points that are stored in a backup vault.
        /// </para>
        /// </summary>
        public long? NumberOfRecoveryPoints
        {
            get { return this._numberOfRecoveryPoints; }
            set { this._numberOfRecoveryPoints = value; }
        }

        // Check to see if NumberOfRecoveryPoints property is set
        internal bool IsSetNumberOfRecoveryPoints()
        {
            return this._numberOfRecoveryPoints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VaultState. 
        /// <para>
        /// The current state of the vault.
        /// </para>
        /// </summary>
        public VaultState VaultState
        {
            get { return this._vaultState; }
            set { this._vaultState = value; }
        }

        // Check to see if VaultState property is set
        internal bool IsSetVaultState()
        {
            return this._vaultState != null;
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