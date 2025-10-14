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
    /// This is the response object from the DescribeRestoreJob operation.
    /// </summary>
    public partial class DescribeRestoreJobResponse : AmazonWebServiceResponse
    {
        private string _accountId;
        private long? _backupSizeInBytes;
        private string _backupVaultArn;
        private DateTime? _completionDate;
        private RestoreJobCreator _createdBy;
        private string _createdResourceArn;
        private DateTime? _creationDate;
        private RestoreDeletionStatus _deletionStatus;
        private string _deletionStatusMessage;
        private long? _expectedCompletionTimeMinutes;
        private string _iamRoleArn;
        private string _percentDone;
        private string _recoveryPointArn;
        private DateTime? _recoveryPointCreationDate;
        private string _resourceType;
        private string _restoreJobId;
        private string _sourceResourceArn;
        private RestoreJobStatus _status;
        private string _statusMessage;
        private RestoreValidationStatus _validationStatus;
        private string _validationStatusMessage;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// Returns the account ID that owns the restore job.
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
        /// The size, in bytes, of the restored resource.
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
        /// The Amazon Resource Name (ARN) of the backup vault containing the recovery point being
        /// restored. This helps identify vault access policies and permissions.
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
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time that a job to restore a recovery point is completed, in Unix format
        /// and Coordinated Universal Time (UTC). The value of <c>CompletionDate</c> is accurate
        /// to milliseconds. For example, the value 1516925490.087 represents Friday, January
        /// 26, 2018 12:11:30.087 AM.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Contains identifying information about the creation of a restore job.
        /// </para>
        /// </summary>
        public RestoreJobCreator CreatedBy
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
        /// Gets and sets the property CreatedResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource that was created by the restore job.
        /// </para>
        ///  
        /// <para>
        /// The format of the ARN depends on the resource type of the backed-up resource.
        /// </para>
        /// </summary>
        public string CreatedResourceArn
        {
            get { return this._createdResourceArn; }
            set { this._createdResourceArn = value; }
        }

        // Check to see if CreatedResourceArn property is set
        internal bool IsSetCreatedResourceArn()
        {
            return this._createdResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a restore job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property DeletionStatus. 
        /// <para>
        /// The status of the data generated by the restore test.
        /// </para>
        /// </summary>
        public RestoreDeletionStatus DeletionStatus
        {
            get { return this._deletionStatus; }
            set { this._deletionStatus = value; }
        }

        // Check to see if DeletionStatus property is set
        internal bool IsSetDeletionStatus()
        {
            return this._deletionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionStatusMessage. 
        /// <para>
        /// This describes the restore job deletion status.
        /// </para>
        /// </summary>
        public string DeletionStatusMessage
        {
            get { return this._deletionStatusMessage; }
            set { this._deletionStatusMessage = value; }
        }

        // Check to see if DeletionStatusMessage property is set
        internal bool IsSetDeletionStatusMessage()
        {
            return this._deletionStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedCompletionTimeMinutes. 
        /// <para>
        /// The amount of time in minutes that a job restoring a recovery point is expected to
        /// take.
        /// </para>
        /// </summary>
        public long? ExpectedCompletionTimeMinutes
        {
            get { return this._expectedCompletionTimeMinutes; }
            set { this._expectedCompletionTimeMinutes = value; }
        }

        // Check to see if ExpectedCompletionTimeMinutes property is set
        internal bool IsSetExpectedCompletionTimeMinutes()
        {
            return this._expectedCompletionTimeMinutes.HasValue; 
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
        /// Gets and sets the property RecoveryPointCreationDate. 
        /// <para>
        /// The creation date of the recovery point made by the specifed restore job.
        /// </para>
        /// </summary>
        public DateTime? RecoveryPointCreationDate
        {
            get { return this._recoveryPointCreationDate; }
            set { this._recoveryPointCreationDate = value; }
        }

        // Check to see if RecoveryPointCreationDate property is set
        internal bool IsSetRecoveryPointCreationDate()
        {
            return this._recoveryPointCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Returns metadata associated with a restore job listed by resource type.
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
        /// Gets and sets the property RestoreJobId. 
        /// <para>
        /// Uniquely identifies the job that restores a recovery point.
        /// </para>
        /// </summary>
        public string RestoreJobId
        {
            get { return this._restoreJobId; }
            set { this._restoreJobId = value; }
        }

        // Check to see if RestoreJobId property is set
        internal bool IsSetRestoreJobId()
        {
            return this._restoreJobId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the original resource that was backed up. This provides
        /// context about what resource is being restored.
        /// </para>
        /// </summary>
        public string SourceResourceArn
        {
            get { return this._sourceResourceArn; }
            set { this._sourceResourceArn = value; }
        }

        // Check to see if SourceResourceArn property is set
        internal bool IsSetSourceResourceArn()
        {
            return this._sourceResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status code specifying the state of the job that is initiated by Backup to restore
        /// a recovery point.
        /// </para>
        /// </summary>
        public RestoreJobStatus Status
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
        /// A message showing the status of a job to restore a recovery point.
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
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The status of validation run on the indicated restore job.
        /// </para>
        /// </summary>
        public RestoreValidationStatus ValidationStatus
        {
            get { return this._validationStatus; }
            set { this._validationStatus = value; }
        }

        // Check to see if ValidationStatus property is set
        internal bool IsSetValidationStatus()
        {
            return this._validationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationStatusMessage. 
        /// <para>
        /// The status message.
        /// </para>
        /// </summary>
        public string ValidationStatusMessage
        {
            get { return this._validationStatusMessage; }
            set { this._validationStatusMessage = value; }
        }

        // Check to see if ValidationStatusMessage property is set
        internal bool IsSetValidationStatusMessage()
        {
            return this._validationStatusMessage != null;
        }

    }
}