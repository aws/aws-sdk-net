/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains metadata about a restore job.
    /// </summary>
    public partial class RestoreJobsListMember
    {
        private long? _backupSizeInBytes;
        private DateTime? _completionDate;
        private string _createdResourceArn;
        private DateTime? _creationDate;
        private long? _expectedCompletionTimeMinutes;
        private string _iamRoleArn;
        private string _percentDone;
        private string _recoveryPointArn;
        private string _restoreJobId;
        private RestoreJobStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property BackupSizeInBytes. 
        /// <para>
        /// The size, in bytes, of the restored resource.
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
        /// Gets and sets the property CompletionDate. 
        /// <para>
        /// The date and time a job to restore a recovery point is completed, in Unix format and
        /// Coordinated Universal Time (UTC). The value of <code>CompletionDate</code> is accurate
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
        /// Gets and sets the property CreatedResourceArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
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
        /// The date and time a restore job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property ExpectedCompletionTimeMinutes. 
        /// <para>
        /// The amount of time in minutes that a job restoring a recovery point is expected to
        /// take.
        /// </para>
        /// </summary>
        public long ExpectedCompletionTimeMinutes
        {
            get { return this._expectedCompletionTimeMinutes.GetValueOrDefault(); }
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
        /// <code>arn:aws:iam::123456789012:role/S3Access</code>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A status code specifying the state of the job initiated by AWS Backup to restore a
        /// recovery point.
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
        /// A detailed message explaining the status of the job to restore a recovery point.
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