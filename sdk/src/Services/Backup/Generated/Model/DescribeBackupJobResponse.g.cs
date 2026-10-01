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
    /// This is the response object from the DescribeBackupJob operation.
    /// </summary>
    public partial class DescribeBackupJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Returns the account ID that owns the backup job.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property BackupJobId. 
        /// <para>
        /// Uniquely identifies a request to Backup to back up a resource.
        /// </para>
        /// </summary>
        public string BackupJobId { get; set; }

        /// <summary>
        /// Checks to see if the BackupJobId property is set.
        /// </summary>
        internal bool IsSetBackupJobId() => this.BackupJobId != null;

        /// <summary>
        /// Gets and sets the property BackupOptions. 
        /// <para>
        /// Represents the options specified as part of backup plan or on-demand backup job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> BackupOptions { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the BackupOptions property is set.
        /// </summary>
        internal bool IsSetBackupOptions() => this.BackupOptions != null && (this.BackupOptions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// For Amazon EKS, this value refers to the size of your nested EKS recovery point.
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
        public long? BackupSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupSizeInBytes property is set.
        /// </summary>
        internal bool IsSetBackupSizeInBytes() => this.BackupSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property BackupType. 
        /// <para>
        /// Represents the actual backup type selected for a backup job. For example, if a successful
        /// Windows Volume Shadow Copy Service (VSS) backup was taken, <c>BackupType</c> returns
        /// <c>"WindowsVSS"</c>. If <c>BackupType</c> is empty, then the backup type was a regular
        /// backup.
        /// </para>
        /// </summary>
        public string BackupType { get; set; }

        /// <summary>
        /// Checks to see if the BackupType property is set.
        /// </summary>
        internal bool IsSetBackupType() => this.BackupType != null;

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
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        /// </summary>
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property BytesTransferred. 
        /// <para>
        /// The size in bytes transferred to a backup vault at the time that the job status was
        /// queried.
        /// </para>
        /// </summary>
        public long? BytesTransferred { get; set; }

        /// <summary>
        /// Checks to see if the BytesTransferred property is set.
        /// </summary>
        internal bool IsSetBytesTransferred() => this.BytesTransferred.HasValue;

        /// <summary>
        /// Gets and sets the property ChildJobsInState. 
        /// <para>
        /// This returns the statistics of the included child (nested) backup jobs.
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
        /// The date and time that a job to create a backup job is completed, in Unix format and
        /// Coordinated Universal Time (UTC). The value of <c>CompletionDate</c> is accurate to
        /// milliseconds. For example, the value 1516925490.087 represents Friday, January 26,
        /// 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the CompletionDate property is set.
        /// </summary>
        internal bool IsSetCompletionDate() => this.CompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Contains identifying information about the creation of a backup job, including the
        /// <c>BackupPlanArn</c>, <c>BackupPlanId</c>, <c>BackupPlanVersion</c>, and <c>BackupRuleId</c>
        /// of the backup plan that is used to create it.
        /// </para>
        /// </summary>
        public RecoveryPointCreator CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a backup job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the backup. This can
        /// be a customer-managed key or an Amazon Web Services managed key, depending on the
        /// vault configuration.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property ExpectedCompletionDate. 
        /// <para>
        /// The date and time that a job to back up resources is expected to be completed, in
        /// Unix format and Coordinated Universal Time (UTC). The value of <c>ExpectedCompletionDate</c>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? ExpectedCompletionDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedCompletionDate property is set.
        /// </summary>
        internal bool IsSetExpectedCompletionDate() => this.ExpectedCompletionDate.HasValue;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to create the target recovery point; for example,
        /// <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        public string IamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleArn property is set.
        /// </summary>
        internal bool IsSetIamRoleArn() => this.IamRoleArn != null;

        /// <summary>
        /// Gets and sets the property InitiationDate. 
        /// <para>
        /// The date a backup job was initiated.
        /// </para>
        /// </summary>
        public DateTime? InitiationDate { get; set; }

        /// <summary>
        /// Checks to see if the InitiationDate property is set.
        /// </summary>
        internal bool IsSetInitiationDate() => this.InitiationDate.HasValue;

        /// <summary>
        /// Gets and sets the property IsEncrypted. 
        /// <para>
        /// A boolean value indicating whether the backup is encrypted. All backups in Backup
        /// are encrypted, but this field indicates the encryption status for transparency.
        /// </para>
        /// </summary>
        public bool? IsEncrypted { get; set; }

        /// <summary>
        /// Checks to see if the IsEncrypted property is set.
        /// </summary>
        internal bool IsSetIsEncrypted() => this.IsEncrypted.HasValue;

        /// <summary>
        /// Gets and sets the property IsParent. 
        /// <para>
        /// This returns the boolean value that a backup job is a parent (composite) job.
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
        /// The job count for the specified message category.
        /// </para>
        ///  
        /// <para>
        /// Example strings may include <c>AccessDenied</c>, <c>SUCCESS</c>, <c>AGGREGATE_ALL</c>,
        /// and <c>INVALIDPARAMETERS</c>. View <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/monitoring.html">Monitoring</a>
        /// for a list of accepted MessageCategory strings.
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
        /// This returns the number of child (nested) backup jobs.
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
        /// This returns the parent (composite) resource backup job ID.
        /// </para>
        /// </summary>
        public string ParentJobId { get; set; }

        /// <summary>
        /// Checks to see if the ParentJobId property is set.
        /// </summary>
        internal bool IsSetParentJobId() => this.ParentJobId != null;

        /// <summary>
        /// Gets and sets the property PercentDone. 
        /// <para>
        /// Contains an estimated percentage that is complete of a job at the time the job status
        /// was queried.
        /// </para>
        /// </summary>
        public string PercentDone { get; set; }

        /// <summary>
        /// Checks to see if the PercentDone property is set.
        /// </summary>
        internal bool IsSetPercentDone() => this.PercentDone != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point; for example, <c>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</c>.
        /// </para>
        /// </summary>
        public string RecoveryPointArn { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointArn property is set.
        /// </summary>
        internal bool IsSetRecoveryPointArn() => this.RecoveryPointArn != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointLifecycle.
        /// </summary>
        public Lifecycle RecoveryPointLifecycle { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointLifecycle property is set.
        /// </summary>
        internal bool IsSetRecoveryPointLifecycle() => this.RecoveryPointLifecycle != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An ARN that uniquely identifies a saved resource. The format of the ARN depends on
        /// the resource type.
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
        /// The type of Amazon Web Services resource to be backed up; for example, an Amazon Elastic
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
        public DateTime? StartBy { get; set; }

        /// <summary>
        /// Checks to see if the StartBy property is set.
        /// </summary>
        internal bool IsSetStartBy() => this.StartBy.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of a backup job.
        /// </para>
        /// </summary>
        public BackupJobState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed message explaining the status of the job to back up a resource.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property VaultLockState. 
        /// <para>
        /// The lock state of the backup vault. For logically air-gapped vaults, this indicates
        /// whether the vault is locked in compliance mode. Valid values include <c>LOCKED</c>
        /// and <c>UNLOCKED</c>.
        /// </para>
        /// </summary>
        public string VaultLockState { get; set; }

        /// <summary>
        /// Checks to see if the VaultLockState property is set.
        /// </summary>
        internal bool IsSetVaultLockState() => this.VaultLockState != null;

        /// <summary>
        /// Gets and sets the property VaultType. 
        /// <para>
        /// The type of backup vault where the recovery point is stored. Valid values are <c>BACKUP_VAULT</c>
        /// for standard backup vaults and <c>LOGICALLY_AIR_GAPPED_BACKUP_VAULT</c> for logically
        /// air-gapped vaults.
        /// </para>
        /// </summary>
        public string VaultType { get; set; }

        /// <summary>
        /// Checks to see if the VaultType property is set.
        /// </summary>
        internal bool IsSetVaultType() => this.VaultType != null;
    }
}
