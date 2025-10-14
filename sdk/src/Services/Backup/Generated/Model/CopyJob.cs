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
    /// Contains detailed information about a copy job.
    /// </summary>
    public partial class CopyJob
    {
        private string _accountId;
        private long? _backupSizeInBytes;
        private Dictionary<string, long> _childJobsInState = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;
        private DateTime? _completionDate;
        private string _compositeMemberIdentifier;
        private string _copyJobId;
        private RecoveryPointCreator _createdBy;
        private DateTime? _creationDate;
        private string _destinationBackupVaultArn;
        private string _destinationEncryptionKeyArn;
        private string _destinationRecoveryPointArn;
        private Lifecycle _destinationRecoveryPointLifecycle;
        private string _destinationVaultLockState;
        private string _destinationVaultType;
        private string _iamRoleArn;
        private bool? _isParent;
        private string _messageCategory;
        private long? _numberOfChildJobs;
        private string _parentJobId;
        private string _resourceArn;
        private string _resourceName;
        private string _resourceType;
        private string _sourceBackupVaultArn;
        private string _sourceRecoveryPointArn;
        private CopyJobState _state;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the copy job.
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
        /// Gets and sets the property BackupSizeInBytes. 
        /// <para>
        /// The size, in bytes, of a copy job.
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
        /// Gets and sets the property ChildJobsInState. 
        /// <para>
        /// This returns the statistics of the included child (nested) copy jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The date and time a copy job is completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate
        {
            get { return this._completionDate; }
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
        /// Gets and sets the property CopyJobId. 
        /// <para>
        /// Uniquely identifies a copy job.
        /// </para>
        /// </summary>
        public string CopyJobId
        {
            get { return this._copyJobId; }
            set { this._copyJobId = value; }
        }

        // Check to see if CopyJobId property is set
        internal bool IsSetCopyJobId()
        {
            return this._copyJobId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedBy.
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
        /// The date and time a copy job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property DestinationBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a destination copy vault; for
        /// example, <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        public string DestinationBackupVaultArn
        {
            get { return this._destinationBackupVaultArn; }
            set { this._destinationBackupVaultArn = value; }
        }

        // Check to see if DestinationBackupVaultArn property is set
        internal bool IsSetDestinationBackupVaultArn()
        {
            return this._destinationBackupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the copied backup in
        /// the destination vault. This can be a customer-managed key or an Amazon Web Services
        /// managed key.
        /// </para>
        /// </summary>
        public string DestinationEncryptionKeyArn
        {
            get { return this._destinationEncryptionKeyArn; }
            set { this._destinationEncryptionKeyArn = value; }
        }

        // Check to see if DestinationEncryptionKeyArn property is set
        internal bool IsSetDestinationEncryptionKeyArn()
        {
            return this._destinationEncryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a destination recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string DestinationRecoveryPointArn
        {
            get { return this._destinationRecoveryPointArn; }
            set { this._destinationRecoveryPointArn = value; }
        }

        // Check to see if DestinationRecoveryPointArn property is set
        internal bool IsSetDestinationRecoveryPointArn()
        {
            return this._destinationRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRecoveryPointLifecycle.
        /// </summary>
        public Lifecycle DestinationRecoveryPointLifecycle
        {
            get { return this._destinationRecoveryPointLifecycle; }
            set { this._destinationRecoveryPointLifecycle = value; }
        }

        // Check to see if DestinationRecoveryPointLifecycle property is set
        internal bool IsSetDestinationRecoveryPointLifecycle()
        {
            return this._destinationRecoveryPointLifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationVaultLockState. 
        /// <para>
        /// The lock state of the destination backup vault. For logically air-gapped vaults, this
        /// indicates whether the vault is locked in compliance mode. Valid values include <c>LOCKED</c>
        /// and <c>UNLOCKED</c>.
        /// </para>
        /// </summary>
        public string DestinationVaultLockState
        {
            get { return this._destinationVaultLockState; }
            set { this._destinationVaultLockState = value; }
        }

        // Check to see if DestinationVaultLockState property is set
        internal bool IsSetDestinationVaultLockState()
        {
            return this._destinationVaultLockState != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationVaultType. 
        /// <para>
        /// The type of destination backup vault where the copied recovery point is stored. Valid
        /// values are <c>BACKUP_VAULT</c> for standard backup vaults and <c>LOGICALLY_AIR_GAPPED_BACKUP_VAULT</c>
        /// for logically air-gapped vaults.
        /// </para>
        /// </summary>
        public string DestinationVaultType
        {
            get { return this._destinationVaultType; }
            set { this._destinationVaultType = value; }
        }

        // Check to see if DestinationVaultType property is set
        internal bool IsSetDestinationVaultType()
        {
            return this._destinationVaultType != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to copy the target recovery point; for example, <c>arn:aws:iam::123456789012:role/S3Access</c>.
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
        /// Gets and sets the property IsParent. 
        /// <para>
        /// This is a boolean value indicating this is a parent (composite) copy job.
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
        /// Gets and sets the property MessageCategory. 
        /// <para>
        /// This parameter is the job count for the specified message category.
        /// </para>
        ///  
        /// <para>
        /// Example strings may include <c>AccessDenied</c>, <c>SUCCESS</c>, <c>AGGREGATE_ALL</c>,
        /// and <c>InvalidParameters</c>. See <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">Monitoring</a>
        /// for a list of MessageCategory strings.
        /// </para>
        ///  
        /// <para>
        /// The the value ANY returns count of all message categories.
        /// </para>
        ///  
        /// <para>
        ///  <c>AGGREGATE_ALL</c> aggregates job counts for all message categories and returns
        /// the sum
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
        /// The number of child (nested) copy jobs.
        /// </para>
        /// </summary>
        public long? NumberOfChildJobs
        {
            get { return this._numberOfChildJobs; }
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
        /// This uniquely identifies a request to Backup to copy a resource. The return will be
        /// the parent (composite) job ID.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Web Services resource to be copied; for example, an Amazon Elastic Block
        /// Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS) database.
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
        /// The type of Amazon Web Services resource to be copied; for example, an Amazon Elastic
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
        /// Gets and sets the property SourceBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a source copy vault; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>. 
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
        /// Gets and sets the property SourceRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a source recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string SourceRecoveryPointArn
        {
            get { return this._sourceRecoveryPointArn; }
            set { this._sourceRecoveryPointArn = value; }
        }

        // Check to see if SourceRecoveryPointArn property is set
        internal bool IsSetSourceRecoveryPointArn()
        {
            return this._sourceRecoveryPointArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of a copy job.
        /// </para>
        /// </summary>
        public CopyJobState State
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
        /// A detailed message explaining the status of the job to copy a resource.
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

    }
}