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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains detailed information about a backup job.
    /// </summary>
    public partial class BackupJob
    {
        private string _accountId;
        private string _backupJobId;
        private Dictionary<string, string> _backupOptions = new Dictionary<string, string>();
        private long? _backupSizeInBytes;
        private string _backupType;
        private string _backupVaultArn;
        private string _backupVaultName;
        private long? _bytesTransferred;
        private DateTime? _completionDate;
        private RecoveryPointCreator _createdBy;
        private DateTime? _creationDate;
        private DateTime? _expectedCompletionDate;
        private string _iamRoleArn;
        private bool? _isParent;
        private string _parentJobId;
        private string _percentDone;
        private string _recoveryPointArn;
        private string _resourceArn;
        private string _resourceType;
        private DateTime? _startBy;
        private BackupJobState _state;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID that owns the backup job.
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
        /// Specifies the backup option for a selected resource. This option is only available
        /// for Windows Volume Shadow Copy Service (VSS) backup jobs.
        /// </para>
        ///  
        /// <para>
        /// Valid values: Set to <code>"WindowsVSS":"enabled"</code> to enable the <code>WindowsVSS</code>
        /// backup option and create a Windows VSS backup. Set to <code>"WindowsVSS":"disabled"</code>
        /// to create a regular backup. If you specify an invalid option, you get an <code>InvalidParameterValueException</code>
        /// exception.
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
            return this._backupOptions != null && this._backupOptions.Count > 0; 
        }

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
        /// Gets and sets the property BackupType. 
        /// <para>
        /// Represents the type of backup for a backup job.
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
        /// <code>arn:aws:backup:us-east-1:123456789012:vault:aBackupVault</code>.
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
        /// Region where they are created. They consist of lowercase letters, numbers, and hyphens.
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
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time a job to create a backup job is completed, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <code>CompletionDate</code> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
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
        /// <code>BackupPlanArn</code>, <code>BackupPlanId</code>, <code>BackupPlanVersion</code>,
        /// and <code>BackupRuleId</code> of the backup plan used to create it.
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
        /// The date and time a backup job is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <code>CreationDate</code> is accurate to milliseconds. For
        /// example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
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
        /// Gets and sets the property ExpectedCompletionDate. 
        /// <para>
        /// The date and time a job to back up resources is expected to be completed, in Unix
        /// format and Coordinated Universal Time (UTC). The value of <code>ExpectedCompletionDate</code>
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
        /// Specifies the IAM role ARN used to create the target recovery point. IAM roles other
        /// than the default role must include either <code>AWSBackup</code> or <code>AwsBackup</code>
        /// in the role name. For example, <code>arn:aws:iam::123456789012:role/AWSBackupRDSAccess</code>.
        /// Role names without those strings lack permissions to perform backup jobs.
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
        /// This is a boolean value indicating this is a parent (composite) backup job.
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
        /// Gets and sets the property ParentJobId. 
        /// <para>
        /// This uniquely identifies a request to Backup to back up a resource. The return will
        /// be the parent (composite) job ID.
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
        /// Contains an estimated percentage complete of a job at the time the job status was
        /// queried.
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
        /// An ARN that uniquely identifies a recovery point; for example, <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
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
        /// An ARN that uniquely identifies a resource. The format of the ARN depends on the resource
        /// type.
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
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of Amazon Web Services resource to be backed up; for example, an Amazon Elastic
        /// Block Store (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS)
        /// database. For Windows Volume Shadow Copy Service (VSS) backups, the only supported
        /// resource type is Amazon EC2.
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
        /// window is 2 hours, the <code>StartBy</code> time would be 8:00 PM on the date specified.
        /// The value of <code>StartBy</code> is accurate to milliseconds. For example, the value
        /// 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
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
        /// The current state of a resource recovery point.
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

    }
}