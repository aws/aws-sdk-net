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
    /// Contains detailed information about a copy job.
    /// </summary>
    public partial class CopyJob
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the copy job.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property BackupSizeInBytes. 
        /// <para>
        /// The size, in bytes, of a copy job.
        /// </para>
        /// </summary>
        public long? BackupSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupSizeInBytes property is set.
        /// </summary>
        internal bool IsSetBackupSizeInBytes() => this.BackupSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ChildJobsInState. 
        /// <para>
        /// This returns the statistics of the included child (nested) copy jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> ChildJobsInState { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Checks to see if the ChildJobsInState property is set.
        /// </summary>
        internal bool IsSetChildJobsInState() => this.ChildJobsInState != null && (this.ChildJobsInState.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time a copy job is completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property CompositeMemberIdentifier. 
        /// <para>
        /// The identifier of a resource within a composite group, such as nested (child) recovery
        /// point belonging to a composite (parent) stack. The ID is transferred from the <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resources-section-structure.html#resources-section-structure-syntax">
        /// logical ID</a> within a stack.
        /// </para>
        /// </summary>
        public string CompositeMemberIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CompositeMemberIdentifier property is set.
        /// </summary>
        internal bool IsSetCompositeMemberIdentifier() => this.CompositeMemberIdentifier != null;

        /// <summary>
        /// Gets and sets the property CopyJobId. 
        /// <para>
        /// Uniquely identifies a copy job.
        /// </para>
        /// </summary>
        public string CopyJobId { get; set; }

        /// <summary>
        /// Checks to see if the CopyJobId property is set.
        /// </summary>
        internal bool IsSetCopyJobId() => this.CopyJobId != null;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public RecoveryPointCreator CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedByBackupJobId. 
        /// <para>
        /// The backup job ID that initiated this copy job. Only applicable to scheduled copy
        /// jobs and automatic copy jobs to logically air-gapped vault.
        /// </para>
        /// </summary>
        public string CreatedByBackupJobId { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByBackupJobId property is set.
        /// </summary>
        internal bool IsSetCreatedByBackupJobId() => this.CreatedByBackupJobId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a copy job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property DestinationBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a destination copy vault; for
        /// example, <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        public string DestinationBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetDestinationBackupVaultArn() => this.DestinationBackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property DestinationEncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the copied backup in
        /// the destination vault. This can be a customer-managed key or an Amazon Web Services
        /// managed key.
        /// </para>
        /// </summary>
        public string DestinationEncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetDestinationEncryptionKeyArn() => this.DestinationEncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property DestinationRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a destination recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string DestinationRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetDestinationRecoveryPointArn() => this.DestinationRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property DestinationRecoveryPointLifecycle.
        /// </summary>
        public Lifecycle DestinationRecoveryPointLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the DestinationRecoveryPointLifecycle property is set.
        /// </summary>
        internal bool IsSetDestinationRecoveryPointLifecycle() => this.DestinationRecoveryPointLifecycle != null;

        /// <summary>
        /// Gets and sets the property DestinationVaultLockState. 
        /// <para>
        /// The lock state of the destination backup vault. For logically air-gapped vaults, this
        /// indicates whether the vault is locked in compliance mode. Valid values include <c>LOCKED</c>
        /// and <c>UNLOCKED</c>.
        /// </para>
        /// </summary>
        public string DestinationVaultLockState { get; set; }

        /// <summary>
        /// Checks to see if the DestinationVaultLockState property is set.
        /// </summary>
        internal bool IsSetDestinationVaultLockState() => this.DestinationVaultLockState != null;

        /// <summary>
        /// Gets and sets the property DestinationVaultType. 
        /// <para>
        /// The type of destination backup vault where the copied recovery point is stored. Valid
        /// values are <c>BACKUP_VAULT</c> for standard backup vaults and <c>LOGICALLY_AIR_GAPPED_BACKUP_VAULT</c>
        /// for logically air-gapped vaults.
        /// </para>
        /// </summary>
        public string DestinationVaultType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationVaultType property is set.
        /// </summary>
        internal bool IsSetDestinationVaultType() => this.DestinationVaultType != null;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to copy the target recovery point; for example, <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property IsParent. 
        /// <para>
        /// This is a boolean value indicating this is a parent (composite) copy job.
        /// </para>
        /// </summary>
        public bool? IsParent { get; set; }

        /// <summary>
        /// Checks to see if the IsParent property is set.
        /// </summary>
        internal bool IsSetIsParent() => this.IsParent.HasValue;

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
        public string MessageCategory { get; set; }

        /// <summary>
        /// Checks to see if the MessageCategory property is set.
        /// </summary>
        internal bool IsSetMessageCategory() => this.MessageCategory != null;

        /// <summary>
        /// Gets and sets the property NumberOfChildJobs. 
        /// <para>
        /// The number of child (nested) copy jobs.
        /// </para>
        /// </summary>
        public long? NumberOfChildJobs { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfChildJobs property is set.
        /// </summary>
        internal bool IsSetNumberOfChildJobs() => this.NumberOfChildJobs.HasValue;

        /// <summary>
        /// Gets and sets the property ParentJobId. 
        /// <para>
        /// This uniquely identifies a request to Backup to copy a resource. The return will be
        /// the parent (composite) job ID.
        /// </para>
        /// </summary>
        public string ParentJobId { get; set; }

        /// <summary>
        /// Checks to see if the ParentJobId property is set.
        /// </summary>
        internal bool IsSetParentJobId() => this.ParentJobId != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Web Services resource to be copied; for example, an Amazon Elastic Block
        /// Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS) database.
        /// </para>
        /// </summary>
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceName. 
        /// <para>
        /// The non-unique name of the resource that belongs to the specified backup.
        /// </para>
        /// </summary>
        public string ResourceName { get; set; }

        /// <summary>
        /// Checks to see if the ResourceName property is set.
        /// </summary>
        internal bool IsSetResourceName() => this.ResourceName != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource to be copied; for example, an Amazon Elastic
        /// Block Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS)
        /// database.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a source copy vault; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>. 
        /// </para>
        /// </summary>
        public string SourceBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetSourceBackupVaultArn() => this.SourceBackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property SourceRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a source recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string SourceRecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceRecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetSourceRecoveryPointArn() => this.SourceRecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of a copy job.
        /// </para>
        /// </summary>
        public CopyJobState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed message explaining the status of the job to copy a resource.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
