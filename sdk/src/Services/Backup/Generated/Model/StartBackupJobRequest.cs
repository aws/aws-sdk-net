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
    /// Container for the parameters to the StartBackupJob operation.
    /// Starts an on-demand backup job for the specified resource.
    /// </summary>
    public partial class StartBackupJobRequest : AmazonBackupRequest
    {
        private Dictionary<string, string> _backupOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _backupVaultName;
        private long? _completeWindowMinutes;
        private string _iamRoleArn;
        private string _idempotencyToken;
        private Index _index;
        private Lifecycle _lifecycle;
        private Dictionary<string, string> _recoveryPointTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _resourceArn;
        private long? _startWindowMinutes;

        /// <summary>
        /// Gets and sets the property BackupOptions. 
        /// <para>
        /// The backup option for a selected resource. This option is only available for Windows
        /// Volume Shadow Copy Service (VSS) backup jobs.
        /// </para>
        ///  
        /// <para>
        /// Valid values: Set to <c>"WindowsVSS":"enabled"</c> to enable the <c>WindowsVSS</c>
        /// backup option and create a Windows VSS backup. Set to <c>"WindowsVSS""disabled"</c>
        /// to create a regular backup. The <c>WindowsVSS</c> option is not enabled by default.
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
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property CompleteWindowMinutes. 
        /// <para>
        /// A value in minutes during which a successfully started backup must complete, or else
        /// Backup will cancel the job. This value is optional. This value begins counting down
        /// from when the backup was scheduled. It does not add additional time for <c>StartWindowMinutes</c>,
        /// or if the backup started later than scheduled.
        /// </para>
        ///  
        /// <para>
        /// Like <c>StartWindowMinutes</c>, this parameter has a maximum value of 100 years (52,560,000
        /// minutes).
        /// </para>
        /// </summary>
        public long CompleteWindowMinutes
        {
            get { return this._completeWindowMinutes.GetValueOrDefault(); }
            set { this._completeWindowMinutes = value; }
        }

        // Check to see if CompleteWindowMinutes property is set
        internal bool IsSetCompleteWindowMinutes()
        {
            return this._completeWindowMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// Specifies the IAM role ARN used to create the target recovery point; for example,
        /// <c>arn:aws:iam::123456789012:role/S3Access</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <c>StartBackupJob</c>. Retrying a successful request with the same idempotency
        /// token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// Include this parameter to enable index creation if your backup job has a resource
        /// type that supports backup indexes.
        /// </para>
        ///  
        /// <para>
        /// Resource types that support backup indexes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EBS</c> for Amazon Elastic Block Store
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>S3</c> for Amazon Simple Storage Service (Amazon S3)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Index can have 1 of 2 possible values, either <c>ENABLED</c> or <c>DISABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// To create a backup index for an eligible <c>ACTIVE</c> recovery point that does not
        /// yet have a backup index, set value to <c>ENABLED</c>.
        /// </para>
        ///  
        /// <para>
        /// To delete a backup index, set value to <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public Index Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. Backup will transition and expire backups automatically according
        /// to the lifecycle that you define. 
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “retention” setting must be 90 days greater than the “transition
        /// to cold after days” setting. The “transition to cold after days” setting cannot be
        /// changed after a backup has been transitioned to cold. 
        /// </para>
        ///  
        /// <para>
        /// Resource types that can transition to cold storage are listed in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
        /// availability by resource</a> table. Backup ignores this expression for other resource
        /// types.
        /// </para>
        ///  
        /// <para>
        /// This parameter has a maximum value of 100 years (36,500 days).
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
        /// Gets and sets the property RecoveryPointTags. 
        /// <para>
        /// The tags to assign to the resources.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> RecoveryPointTags
        {
            get { return this._recoveryPointTags; }
            set { this._recoveryPointTags = value; }
        }

        // Check to see if RecoveryPointTags property is set
        internal bool IsSetRecoveryPointTags()
        {
            return this._recoveryPointTags != null && (this._recoveryPointTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StartWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup is scheduled before a job will be canceled if it
        /// doesn't start successfully. This value is optional, and the default is 8 hours. If
        /// this value is included, it must be at least 60 minutes to avoid errors.
        /// </para>
        ///  
        /// <para>
        /// This parameter has a maximum value of 100 years (52,560,000 minutes).
        /// </para>
        ///  
        /// <para>
        /// During the start window, the backup job status remains in <c>CREATED</c> status until
        /// it has successfully begun or until the start window time has run out. If within the
        /// start window time Backup receives an error that allows the job to be retried, Backup
        /// will automatically retry to begin the job at least every 10 minutes until the backup
        /// successfully begins (the job status changes to <c>RUNNING</c>) or until the job status
        /// changes to <c>EXPIRED</c> (which is expected to occur when the start window time is
        /// over).
        /// </para>
        /// </summary>
        public long StartWindowMinutes
        {
            get { return this._startWindowMinutes.GetValueOrDefault(); }
            set { this._startWindowMinutes = value; }
        }

        // Check to see if StartWindowMinutes property is set
        internal bool IsSetStartWindowMinutes()
        {
            return this._startWindowMinutes.HasValue; 
        }

    }
}