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
    /// Contains detailed information about a copy job.
    /// </summary>
    public partial class CopyJob
    {
        private string _accountId;
        private long? _backupSizeInBytes;
        private DateTime? _completionDate;
        private string _copyJobId;
        private RecoveryPointCreator _createdBy;
        private DateTime? _creationDate;
        private string _destinationBackupVaultArn;
        private string _destinationRecoveryPointArn;
        private string _iamRoleArn;
        private string _resourceArn;
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
        /// The date and time a copy job is completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <code>CompletionDate</code> is accurate to milliseconds.
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
        /// Gets and sets the property DestinationBackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a destination copy vault; for
        /// example, <code>arn:aws:backup:us-east-1:123456789012:vault:aBackupVault</code>.
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
        /// Gets and sets the property DestinationRecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a destination recovery point; for example, <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
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
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to copy the target recovery point; for example, <code>arn:aws:iam::123456789012:role/S3Access</code>.
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
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The AWS resource to be copied; for example, an Amazon Elastic Block Store (Amazon
        /// EBS) volume or an Amazon Relational Database Service (Amazon RDS) database.
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
        /// The type of AWS resource to be copied; for example, an Amazon Elastic Block Store
        /// (Amazon EBS) volume or an Amazon Relational Database Service (Amazon RDS) database.
        /// 
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
        /// <code>arn:aws:backup:us-east-1:123456789012:vault:aBackupVault</code>. 
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
        /// An ARN that uniquely identifies a source recovery point; for example, <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
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