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
    /// Contains metadata about a restore job.
    /// </summary>
    public partial class RestoreJobsListMember
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the restore job.
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
        /// The size, in bytes, of the restored resource.
        /// </para>
        /// </summary>
        public long? BackupSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the BackupSizeInBytes property is set.
        /// </summary>
        internal bool IsSetBackupSizeInBytes() => this.BackupSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the backup vault containing the recovery point being
        /// restored. This helps identify vault access policies and permissions.
        /// </para>
        /// </summary>
        public string BackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultArn property is set.
        /// </summary>
        internal bool IsSetBackupVaultArn() => this.BackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time a job to restore a recovery point is completed, in Unix format and
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
        /// Contains identifying information about the creation of a restore job.
        /// </para>
        /// </summary>
        public RestoreJobCreator CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedResourceArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string CreatedResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the CreatedResourceArn property is set.
        /// </summary>
        internal bool IsSetCreatedResourceArn() => this.CreatedResourceArn != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a restore job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property DeletionStatus. 
        /// <para>
        /// This notes the status of the data generated by the restore test. The status may be
        /// <c>Deleting</c>, <c>Failed</c>, or <c>Successful</c>.
        /// </para>
        /// </summary>
        public RestoreDeletionStatus DeletionStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeletionStatus property is set.
        /// </summary>
        internal bool IsSetDeletionStatus() => this.DeletionStatus != null;

        /// <summary>
        /// Gets and sets the property DeletionStatusMessage. 
        /// <para>
        /// This describes the restore job deletion status.
        /// </para>
        /// </summary>
        public string DeletionStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeletionStatusMessage property is set.
        /// </summary>
        internal bool IsSetDeletionStatusMessage() => this.DeletionStatusMessage != null;

        /// <summary>
        /// Gets and sets the property ExpectedCompletionTimeMinutes. 
        /// <para>
        /// The amount of time in minutes that a job restoring a recovery point is expected to
        /// take.
        /// </para>
        /// </summary>
        public long? ExpectedCompletionTimeMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedCompletionTimeMinutes property is set.
        /// </summary>
        internal bool IsSetExpectedCompletionTimeMinutes() => this.ExpectedCompletionTimeMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The IAM role ARN used to create the target recovery point; for example, <c>arn:aws:iam::123456789012:role/S3Access</c>.
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
        /// This is a boolean value indicating whether the restore job is a parent (composite)
        /// restore job.
        /// </para>
        /// </summary>
        public bool? IsParent { get; set; }

        /// <summary>
        /// Checks to see if the IsParent property is set.
        /// </summary>
        internal bool IsSetIsParent() => this.IsParent.HasValue;

        /// <summary>
        /// Gets and sets the property ParentJobId. 
        /// <para>
        /// This is the unique identifier of the parent restore job for the selected restore job.
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
        /// Contains an estimated percentage complete of a job at the time the job status was
        /// queried.
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
        /// Gets and sets the property RecoveryPointCreationDate. 
        /// <para>
        /// The date on which a recovery point was created.
        /// </para>
        /// </summary>
        public DateTime? RecoveryPointCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryPointCreationDate property is set.
        /// </summary>
        internal bool IsSetRecoveryPointCreationDate() => this.RecoveryPointCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type of the listed restore jobs; for example, an Amazon Elastic Block
        /// Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS) database.
        /// For Windows Volume Shadow Copy Service (VSS) backups, the only supported resource
        /// type is Amazon EC2.
        /// </para>
        /// </summary>
        public string ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RestoreJobId. 
        /// <para>
        /// Uniquely identifies the job that restores a recovery point.
        /// </para>
        /// </summary>
        public string RestoreJobId { get; set; }

        /// <summary>
        /// Checks to see if the RestoreJobId property is set.
        /// </summary>
        internal bool IsSetRestoreJobId() => this.RestoreJobId != null;

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the original resource that was backed up. This provides
        /// context about what resource is being restored.
        /// </para>
        /// </summary>
        public string SourceResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceResourceArn property is set.
        /// </summary>
        internal bool IsSetSourceResourceArn() => this.SourceResourceArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code specifying the state of the job initiated by Backup to restore a recovery
        /// point.
        /// </para>
        /// </summary>
        public RestoreJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A detailed message explaining the status of the job to restore a recovery point.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The status of validation run on the indicated restore job.
        /// </para>
        /// </summary>
        public RestoreValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;

        /// <summary>
        /// Gets and sets the property ValidationStatusMessage. 
        /// <para>
        /// This describes the status of validation run on the indicated restore job.
        /// </para>
        /// </summary>
        public string ValidationStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatusMessage property is set.
        /// </summary>
        internal bool IsSetValidationStatusMessage() => this.ValidationStatusMessage != null;
    }
}
