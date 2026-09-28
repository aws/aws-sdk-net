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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the DescribeBackupVault operation.
    /// </summary>
    public partial class DescribeBackupVaultResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        public string BackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultArn property is set.
        /// </summary>
        internal bool IsSetBackupVaultArn() => this.BackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Region where they
        /// are created.
        /// </para>
        /// </summary>
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a backup vault is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and allows failed requests to be retried
        /// without the risk of running the operation twice. This parameter is optional. If used,
        /// this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The server-side encryption key that is used to protect your backups; for example,
        /// <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyType. 
        /// <para>
        /// The type of encryption key used for the backup vault. Valid values are CUSTOMER_MANAGED_KMS_KEY
        /// for customer-managed keys or Amazon Web Services_OWNED_KMS_KEY for Amazon Web Services-owned
        /// keys.
        /// </para>
        /// </summary>
        public EncryptionKeyType EncryptionKeyType { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyType property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyType() => this.EncryptionKeyType != null;

        /// <summary>
        /// Gets and sets the property LatestMpaApprovalTeamUpdate. 
        /// <para>
        /// Information about the latest update to the MPA approval team association for this
        /// backup vault.
        /// </para>
        /// </summary>
        public LatestMpaApprovalTeamUpdate LatestMpaApprovalTeamUpdate { get; set; }

        /// <summary>
        /// Checks to see if the LatestMpaApprovalTeamUpdate property is set.
        /// </summary>
        internal bool IsSetLatestMpaApprovalTeamUpdate() => this.LatestMpaApprovalTeamUpdate != null;

        /// <summary>
        /// Gets and sets the property LockDate. 
        /// <para>
        /// The date and time when Backup Vault Lock configuration cannot be changed or deleted.
        /// </para>
        ///  
        /// <para>
        /// If you applied Vault Lock to your vault without specifying a lock date, you can change
        /// any of your Vault Lock settings, or delete Vault Lock from the vault entirely, at
        /// any time.
        /// </para>
        ///  
        /// <para>
        /// This value is in Unix format, Coordinated Universal Time (UTC), and accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? LockDate { get; set; }

        /// <summary>
        /// Checks to see if the LockDate property is set.
        /// </summary>
        internal bool IsSetLockDate() => this.LockDate.HasValue;

        /// <summary>
        /// Gets and sets the property Locked. 
        /// <para>
        /// A Boolean that indicates whether Backup Vault Lock is currently protecting the backup
        /// vault. <c>True</c> means that Vault Lock causes delete or update operations on the
        /// recovery points stored in the vault to fail.
        /// </para>
        /// </summary>
        public bool? Locked { get; set; }

        /// <summary>
        /// Checks to see if the Locked property is set.
        /// </summary>
        internal bool IsSetLocked() => this.Locked.HasValue;

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
        public long? MaxRetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetentionDays property is set.
        /// </summary>
        internal bool IsSetMaxRetentionDays() => this.MaxRetentionDays.HasValue;

        /// <summary>
        /// Gets and sets the property MinRetentionDays. 
        /// <para>
        /// The Backup Vault Lock setting that specifies the minimum retention period that the
        /// vault retains its recovery points. If this parameter is not specified, Vault Lock
        /// will not enforce a minimum retention period.
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
        public long? MinRetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the MinRetentionDays property is set.
        /// </summary>
        internal bool IsSetMinRetentionDays() => this.MinRetentionDays.HasValue;

        /// <summary>
        /// Gets and sets the property MpaApprovalTeamArn. 
        /// <para>
        /// The ARN of the MPA approval team associated with this backup vault.
        /// </para>
        /// </summary>
        public string MpaApprovalTeamArn { get; set; }

        /// <summary>
        /// Checks to see if the MpaApprovalTeamArn property is set.
        /// </summary>
        internal bool IsSetMpaApprovalTeamArn() => this.MpaApprovalTeamArn != null;

        /// <summary>
        /// Gets and sets the property MpaSessionArn. 
        /// <para>
        /// The ARN of the MPA session associated with this backup vault.
        /// </para>
        /// </summary>
        public string MpaSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the MpaSessionArn property is set.
        /// </summary>
        internal bool IsSetMpaSessionArn() => this.MpaSessionArn != null;

        /// <summary>
        /// Gets and sets the property NumberOfRecoveryPoints. 
        /// <para>
        /// The number of recovery points that are stored in a backup vault.
        /// </para>
        ///  
        /// <para>
        /// Recovery point count value displayed in the console can be an approximation. Use <a
        /// href="https://docs.aws.amazon.com/aws-backup/latest/devguide/API_ListRecoveryPointsByBackupVault.html">
        /// <c>ListRecoveryPointsByBackupVault</c> </a> API to obtain the exact count.
        /// </para>
        /// </summary>
        public long? NumberOfRecoveryPoints { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfRecoveryPoints property is set.
        /// </summary>
        internal bool IsSetNumberOfRecoveryPoints() => this.NumberOfRecoveryPoints.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBackupVaultArn. 
        /// <para>
        /// The ARN of the source backup vault from which this restore access backup vault was
        /// created.
        /// </para>
        /// </summary>
        public string SourceBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetSourceBackupVaultArn() => this.SourceBackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property VaultState. 
        /// <para>
        /// The current state of the vault.->
        /// </para>
        /// </summary>
        public VaultState VaultState { get; set; }

        /// <summary>
        /// Checks to see if the VaultState property is set.
        /// </summary>
        internal bool IsSetVaultState() => this.VaultState != null;

        /// <summary>
        /// Gets and sets the property VaultType. 
        /// <para>
        /// The type of vault described.
        /// </para>
        /// </summary>
        public VaultType VaultType { get; set; }

        /// <summary>
        /// Checks to see if the VaultType property is set.
        /// </summary>
        internal bool IsSetVaultType() => this.VaultType != null;
    }
}
