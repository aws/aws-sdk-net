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
    /// This is the response object from the DescribeRecoveryPoint operation.
    /// </summary>
    public partial class DescribeRecoveryPointResponse : AmazonWebServiceResponse
    {
        private long? _backupSizeInBytes;
        private string _backupVaultArn;
        private string _backupVaultName;
        private CalculatedLifecycle _calculatedLifecycle;
        private DateTime? _completionDate;
        private string _compositeMemberIdentifier;
        private RecoveryPointCreator _createdBy;
        private DateTime? _creationDate;
        private string _encryptionKeyArn;
        private EncryptionKeyType _encryptionKeyType;
        private string _iamRoleArn;
        private IndexStatus _indexStatus;
        private string _indexStatusMessage;
        private DateTime? _initiationDate;
        private bool? _isEncrypted;
        private bool? _isParent;
        private DateTime? _lastRestoreTime;
        private Lifecycle _lifecycle;
        private string _parentRecoveryPointArn;
        private string _recoveryPointArn;
        private string _resourceArn;
        private string _resourceName;
        private string _resourceType;
        private List<ScanResult> _scanResults = AWSConfigs.InitializeCollections ? new List<ScanResult>() : null;
        private string _sourceBackupVaultArn;
        private RecoveryPointStatus _status;
        private string _statusMessage;
        private StorageClass _storageClass;
        private VaultType _vaultType;

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
        /// An ARN that uniquely identifies a backup vault; for example, <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
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
        /// are created.
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
        /// and Coordinated Universal Time (UTC). The value of <c>CompletionDate</c> is accurate
        /// to milliseconds. For example, the value 1516925490.087 represents Friday, January
        /// 26, 2018 12:11:30.087 AM.
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
        /// Gets and sets the property CompositeMemberIdentifier. 
        /// <para>
        /// The identifier of a resource within a composite group, such as nested (child) recovery
        /// point belonging to a composite (parent) stack. The ID is transferred from the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resources-section-structure.html#resources-section-structure-syntax">
        /// logical ID</a> within a stack.
        /// </para>
        /// </summary>
        public string CompositeMemberIdentifier
        {
            get { return this._compositeMemberIdentifier; }
            set { this._compositeMemberIdentifier = value; }
        }

        // Check to see if CompositeMemberIdentifier property is set
        internal bool IsSetCompositeMemberIdentifier()
        {
            return this._compositeMemberIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Contains identifying information about the creation of a recovery point, including
        /// the <c>BackupPlanArn</c>, <c>BackupPlanId</c>, <c>BackupPlanVersion</c>, and <c>BackupRuleId</c>
        /// of the backup plan used to create it.
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
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
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
        /// The server-side encryption key used to protect your backups; for example, <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to create the target recovery point; for example,
        /// <c>arn:aws:iam::123456789012:role/S3Access</c>.
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
        /// Gets and sets the property InitiationDate. 
        /// <para>
        /// The date and time when the backup job that created this recovery point was initiated,
        /// in Unix format and Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public DateTime InitiationDate
        {
            get { return this._initiationDate.GetValueOrDefault(); }
            set { this._initiationDate = value; }
        }

        // Check to see if InitiationDate property is set
        internal bool IsSetInitiationDate()
        {
            return this._initiationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsEncrypted. 
        /// <para>
        /// A Boolean value that is returned as <c>TRUE</c> if the specified recovery point is
        /// encrypted, or <c>FALSE</c> if the recovery point is not encrypted.
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
        /// Gets and sets the property IsParent. 
        /// <para>
        /// This returns the boolean value that a recovery point is a parent (composite) job.
        /// </para>
        /// </summary>
        public bool IsParent
        {
            get { return this._isParent.GetValueOrDefault(); }
            set { this._isParent = value; }
        }

        // Check to see if IsParent property is set
        internal bool IsSetIsParent()
        {
            return this._isParent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastRestoreTime. 
        /// <para>
        /// The date and time that a recovery point was last restored, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>LastRestoreTime</c> is accurate to milliseconds.
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
        /// when it expires. Backup transitions and expires backups automatically according to
        /// the lifecycle that you define.
        /// </para>
        ///  
        /// <para>
        /// Backups that are transitioned to cold storage must be stored in cold storage for a
        /// minimum of 90 days. Therefore, the “retention” setting must be 90 days greater than
        /// the “transition to cold after days” setting. The “transition to cold after days” setting
        /// cannot be changed after a backup has been transitioned to cold. 
        /// </para>
        ///  
        /// <para>
        /// Resource types that can transition to cold storage are listed in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
        /// availability by resource</a> table. Backup ignores this expression for other resource
        /// types.
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
        /// Gets and sets the property ParentRecoveryPointArn. 
        /// <para>
        /// This is an ARN that uniquely identifies a parent (composite) recovery point; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
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
        /// An ARN that uniquely identifies a recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
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
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The name of the resource that belongs to the specified backup.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource to save as a recovery point; for example,
        /// an Amazon Elastic Block Store (Amazon EBS) volume or an Amazon Relational Database
        /// Service (Amazon RDS) database.
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
        /// Gets and sets the property ScanResults. 
        /// <para>
        /// Contains the latest scanning results against the recovery point and currently include
        /// <c>MalwareScanner</c>, <c>ScanJobState</c>, <c>Findings</c>, and <c>LastScanTimestamp</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<ScanResult> ScanResults
        {
            get { return this._scanResults; }
            set { this._scanResults = value; }
        }

        // Check to see if ScanResults property is set
        internal bool IsSetScanResults()
        {
            return this._scanResults != null && (this._scanResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies the source vault where the
        /// resource was originally backed up in; for example, <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// If the recovery is restored to the same Amazon Web Services account or Region, this
        /// value will be <c>null</c>.
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
        /// A status code specifying the state of the recovery point. For more information, see
        /// <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/applicationstackbackups.html#cfnrecoverypointstatus">
        /// Recovery point status</a> in the <i>Backup Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> status indicates that an Backup job has been initiated for a resource.
        /// The backup process has started and is actively processing a backup job for the associated
        /// recovery point.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> status indicates that the backup was successfully created for the
        /// recovery point. The backup process has completed without any issues, and the recovery
        /// point is now ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL</c> status indicates a composite recovery point has one or more nested
        /// recovery points that were not in the backup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c> status indicates that the recovery point has exceeded its retention
        /// period, but Backup lacks permission or is otherwise unable to delete it. To manually
        /// delete these recovery points, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/gs-cleanup-resources.html#cleanup-backups">
        /// Step 3: Delete the recovery points</a> in the <i>Clean up resources</i> section of
        /// <i>Getting started</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> status occurs on a continuous backup where a user has taken some action
        /// that causes the continuous backup to be disabled. This can be caused by the removal
        /// of permissions, turning off versioning, turning off events being sent to EventBridge,
        /// or disabling the EventBridge rules that are put in place by Backup. For recovery points
        /// of Amazon S3, Amazon RDS, and Amazon Aurora resources, this status occurs when the
        /// retention period of a continuous backup rule is changed.
        /// </para>
        ///  
        /// <para>
        /// To resolve <c>STOPPED</c> status, ensure that all requested permissions are in place
        /// and that versioning is enabled on the S3 bucket. Once these conditions are met, the
        /// next instance of a backup rule running will result in a new continuous recovery point
        /// being created. The recovery points with STOPPED status do not need to be deleted.
        /// </para>
        ///  
        /// <para>
        /// For SAP HANA on Amazon EC2 <c>STOPPED</c> status occurs due to user action, application
        /// misconfiguration, or backup failure. To ensure that future continuous backups succeed,
        /// refer to the recovery point status and check SAP HANA for details.
        /// </para>
        ///  </li> </ul>
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
        /// A status message explaining the status of the recovery point.
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
        /// Specifies the storage class of the recovery point. Valid values are <c>WARM</c> or
        /// <c>COLD</c>.
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