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
    /// This is the response object from the DescribeBackupJob operation.
    /// </summary>
    public partial class DescribeBackupJobResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private string _backupJobId;
        private Dictionary<string, string> _backupOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private long? _backupSizeInBytes;
        private string _backupType;
        private string _backupVaultArn;
        private string _backupVaultName;
        private long? _bytesTransferred;
        private Dictionary<string, long> _childJobsInState = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;
        private DateTime? _completionDate;
        private RecoveryPointCreator _createdBy;
        private DateTime? _creationDate;
        private string _encryptionKeyArn;
        private DateTime? _expectedCompletionDate;
        private string _iamRoleArn;
        private DateTime? _initiationDate;
        private bool? _isEncrypted;
        private bool? _isParent;
        private string _messageCategory;
        private long? _numberOfChildJobs;
        private string _parentJobId;
        private string _percentDone;
        private string _recoveryPointArn;
        private Lifecycle _recoveryPointLifecycle;
        private string _resourceArn;
        private string _resourceName;
        private string _resourceType;
        private DateTime? _startBy;
        private BackupJobState _state;
        private string _statusMessage;
        private string _vaultLockState;
        private string _vaultType;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Returns the account ID that owns the backup job.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupJobId. 
        /// <para>
        /// Uniquely identifies a request to Backup to back up a resource.
        /// </para>
        /// </summary>
        public string BackupJobId
        {
            get { return this._backupJobId; }
            set { this._backupJobId = value; }
        }

        // Check to see if BackupJobId property is set
        internal bool IsSetBackupJobId()
        {
            return this._backupJobId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupOptions. 
        /// <para>
        /// Represents the options specified as part of backup plan or on-demand backup job.
        /// </para>
        /// </summary>
        public Dictionary<string, string> BackupOptions
        {
            get { return this._backupOptions; }
            set { this._backupOptions = value; }
        }

        // Check to see if BackupOptions property is set
        internal bool IsSetBackupOptions()
        {
            return this._backupOptions != null && (this._backupOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupSizeInBytes. 
        /// <para>
        /// The size, in bytes, of a backup (recovery point).
        /// </para>
        ///  
        /// <para>
        /// This value can render differently depending on the resource type as Backup pulls in
        /// data information from other Amazon Web Services services. For example, the value returned
        /// may show a value of <c>0</c>, which may differ from the anticipated value.
        /// </para>
        ///  
        /// <para>
        /// The expected behavior for values by resource type are described as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Aurora, Amazon DocumentDB, and Amazon Neptune do not have this value populate
        /// from the operation <c>GetBackupJobStatus</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon DynamoDB with advanced features, this value refers to the size of the recovery
        /// point (backup).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon EC2 and Amazon EBS show volume size (provisioned storage) returned as part
        /// of this value. Amazon EBS does not return backup size information; snapshot size will
        /// have the same value as the original resource that was backed up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Amazon EFS, this value refers to the delta bytes transferred during a backup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon FSx does not populate this value from the operation <c>GetBackupJobStatus</c>
        /// for FSx file systems.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon RDS instance will show as <c>0</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For virtual machines running VMware, this value is passed to Backup through an asynchronous
        /// workflow, which can mean this displayed value can under-represent the actual backup
        /// size.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property BackupType. 
        /// <para>
        /// Represents the actual backup type selected for a backup job. For example, if a successful
        /// Windows Volume Shadow Copy Service (VSS) backup was taken, <c>BackupType</c> returns
        /// <c>"WindowsVSS"</c>. If <c>BackupType</c> is empty, then the backup type was a regular
        /// backup.
        /// </para>
        /// </summary>
        public string BackupType
        {
            get { return this._backupType; }
            set { this._backupType = value; }
        }

        // Check to see if BackupType property is set
        internal bool IsSetBackupType()
        {
            return this._backupType != null;
        }

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
        /// Gets and sets the property BytesTransferred. 
        /// <para>
        /// The size in bytes transferred to a backup vault at the time that the job status was
        /// queried.
        /// </para>
        /// </summary>
        public long BytesTransferred
        {
            get { return this._bytesTransferred.GetValueOrDefault(); }
            set { this._bytesTransferred = value; }
        }

        // Check to see if BytesTransferred property is set
        internal bool IsSetBytesTransferred()
        {
            return this._bytesTransferred.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ChildJobsInState. 
        /// <para>
        /// This returns the statistics of the included child (nested) backup jobs.
        /// </para>
        /// </summary>
        public Dictionary<string, long> ChildJobsInState
        {
            get { return this._childJobsInState; }
            set { this._childJobsInState = value; }
        }

        // Check to see if ChildJobsInState property is set
        internal bool IsSetChildJobsInState()
        {
            return this._childJobsInState != null && (this._childJobsInState.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time that a job to create a backup job is completed, in Unix format and
        /// Coordinated Universal Time (UTC). The value of <c>CompletionDate</c> is accurate to
        /// milliseconds. For example, the value 1516925490.087 represents Friday, January 26,
        /// 2018 12:11:30.087 AM.
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
        /// Contains identifying information about the creation of a backup job, including the
        /// <c>BackupPlanArn</c>, <c>BackupPlanId</c>, <c>BackupPlanVersion</c>, and <c>BackupRuleId</c>
        /// of the backup plan that is used to create it.
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
        /// The date and time that a backup job is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
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
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the backup. This can
        /// be a customer-managed key or an Amazon Web Services managed key, depending on the
        /// vault configuration.
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
        /// Gets and sets the property ExpectedCompletionDate. 
        /// <para>
        /// The date and time that a job to back up resources is expected to be completed, in
        /// Unix format and Coordinated Universal Time (UTC). The value of <c>ExpectedCompletionDate</c>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime ExpectedCompletionDate
        {
            get { return this._expectedCompletionDate.GetValueOrDefault(); }
            set { this._expectedCompletionDate = value; }
        }

        // Check to see if ExpectedCompletionDate property is set
        internal bool IsSetExpectedCompletionDate()
        {
            return this._expectedCompletionDate.HasValue; 
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
        /// Gets and sets the property InitiationDate. 
        /// <para>
        /// The date a backup job was initiated.
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
        /// A boolean value indicating whether the backup is encrypted. All backups in Backup
        /// are encrypted, but this field indicates the encryption status for transparency.
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
        /// This returns the boolean value that a backup job is a parent (composite) job.
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
        /// Gets and sets the property MessageCategory. 
        /// <para>
        /// The job count for the specified message category.
        /// </para>
        ///  
        /// <para>
        /// Example strings may include <c>AccessDenied</c>, <c>SUCCESS</c>, <c>AGGREGATE_ALL</c>,
        /// and <c>INVALIDPARAMETERS</c>. View <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">Monitoring</a>
        /// for a list of accepted MessageCategory strings.
        /// </para>
        /// </summary>
        public string MessageCategory
        {
            get { return this._messageCategory; }
            set { this._messageCategory = value; }
        }

        // Check to see if MessageCategory property is set
        internal bool IsSetMessageCategory()
        {
            return this._messageCategory != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfChildJobs. 
        /// <para>
        /// This returns the number of child (nested) backup jobs.
        /// </para>
        /// </summary>
        public long NumberOfChildJobs
        {
            get { return this._numberOfChildJobs.GetValueOrDefault(); }
            set { this._numberOfChildJobs = value; }
        }

        // Check to see if NumberOfChildJobs property is set
        internal bool IsSetNumberOfChildJobs()
        {
            return this._numberOfChildJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParentJobId. 
        /// <para>
        /// This returns the parent (composite) resource backup job ID.
        /// </para>
        /// </summary>
        public string ParentJobId
        {
            get { return this._parentJobId; }
            set { this._parentJobId = value; }
        }

        // Check to see if ParentJobId property is set
        internal bool IsSetParentJobId()
        {
            return this._parentJobId != null;
        }

        /// <summary>
        /// Gets and sets the property PercentDone. 
        /// <para>
        /// Contains an estimated percentage that is complete of a job at the time the job status
        /// was queried.
        /// </para>
        /// </summary>
        public string PercentDone
        {
            get { return this._percentDone; }
            set { this._percentDone = value; }
        }

        // Check to see if PercentDone property is set
        internal bool IsSetPercentDone()
        {
            return this._percentDone != null;
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
        /// Gets and sets the property RecoveryPointLifecycle.
        /// </summary>
        public Lifecycle RecoveryPointLifecycle
        {
            get { return this._recoveryPointLifecycle; }
            set { this._recoveryPointLifecycle = value; }
        }

        // Check to see if RecoveryPointLifecycle property is set
        internal bool IsSetRecoveryPointLifecycle()
        {
            return this._recoveryPointLifecycle != null;
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource to be backed up; for example, an Amazon Elastic
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
        /// Gets and sets the property StartBy. 
        /// <para>
        /// Specifies the time in Unix format and Coordinated Universal Time (UTC) when a backup
        /// job must be started before it is canceled. The value is calculated by adding the start
        /// window to the scheduled time. So if the scheduled time were 6:00 PM and the start
        /// window is 2 hours, the <c>StartBy</c> time would be 8:00 PM on the date specified.
        /// The value of <c>StartBy</c> is accurate to milliseconds. For example, the value 1516925490.087
        /// represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime StartBy
        {
            get { return this._startBy.GetValueOrDefault(); }
            set { this._startBy = value; }
        }

        // Check to see if StartBy property is set
        internal bool IsSetStartBy()
        {
            return this._startBy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of a backup job.
        /// </para>
        /// </summary>
        public BackupJobState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed message explaining the status of the job to back up a resource.
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
        /// Gets and sets the property VaultLockState. 
        /// <para>
        /// The lock state of the backup vault. For logically air-gapped vaults, this indicates
        /// whether the vault is locked in compliance mode. Valid values include <c>LOCKED</c>
        /// and <c>UNLOCKED</c>.
        /// </para>
        /// </summary>
        public string VaultLockState
        {
            get { return this._vaultLockState; }
            set { this._vaultLockState = value; }
        }

        // Check to see if VaultLockState property is set
        internal bool IsSetVaultLockState()
        {
            return this._vaultLockState != null;
        }

        /// <summary>
        /// Gets and sets the property VaultType. 
        /// <para>
        /// The type of backup vault where the recovery point is stored. Valid values are <c>BACKUP_VAULT</c>
        /// for standard backup vaults and <c>LOGICALLY_AIR_GAPPED_BACKUP_VAULT</c> for logically
        /// air-gapped vaults.
        /// </para>
        /// </summary>
        public string VaultType
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