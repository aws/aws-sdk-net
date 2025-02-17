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
    /// Specifies a scheduled task used to back up a selection of resources.
    /// </summary>
    public partial class BackupRuleInput
    {
        private long? _completionWindowMinutes;
        private List<CopyAction> _copyActions = AWSConfigs.InitializeCollections ? new List<CopyAction>() : null;
        private bool? _enableContinuousBackup;
        private List<IndexAction> _indexActions = AWSConfigs.InitializeCollections ? new List<IndexAction>() : null;
        private Lifecycle _lifecycle;
        private Dictionary<string, string> _recoveryPointTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _ruleName;
        private string _scheduleExpression;
        private string _scheduleExpressionTimezone;
        private long? _startWindowMinutes;
        private string _targetBackupVaultName;

        /// <summary>
        /// Gets and sets the property CompletionWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup job is successfully started before it must be completed
        /// or it will be canceled by Backup. This value is optional.
        /// </para>
        /// </summary>
        public long CompletionWindowMinutes
        {
            get { return this._completionWindowMinutes.GetValueOrDefault(); }
            set { this._completionWindowMinutes = value; }
        }

        // Check to see if CompletionWindowMinutes property is set
        internal bool IsSetCompletionWindowMinutes()
        {
            return this._completionWindowMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CopyActions. 
        /// <para>
        /// An array of <c>CopyAction</c> objects, which contains the details of the copy operation.
        /// </para>
        /// </summary>
        public List<CopyAction> CopyActions
        {
            get { return this._copyActions; }
            set { this._copyActions = value; }
        }

        // Check to see if CopyActions property is set
        internal bool IsSetCopyActions()
        {
            return this._copyActions != null && (this._copyActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnableContinuousBackup. 
        /// <para>
        /// Specifies whether Backup creates continuous backups. True causes Backup to create
        /// continuous backups capable of point-in-time restore (PITR). False (or not specified)
        /// causes Backup to create snapshot backups.
        /// </para>
        /// </summary>
        public bool EnableContinuousBackup
        {
            get { return this._enableContinuousBackup.GetValueOrDefault(); }
            set { this._enableContinuousBackup = value; }
        }

        // Check to see if EnableContinuousBackup property is set
        internal bool IsSetEnableContinuousBackup()
        {
            return this._enableContinuousBackup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndexActions. 
        /// <para>
        /// There can up to one IndexAction in each BackupRule, as each backup can have 0 or 1
        /// backup index associated with it.
        /// </para>
        ///  
        /// <para>
        /// Within the array is ResourceTypes. Only 1 resource type will be accepted for each
        /// BackupRule. Valid values:
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
        /// </summary>
        public List<IndexAction> IndexActions
        {
            get { return this._indexActions; }
            set { this._indexActions = value; }
        }

        // Check to see if IndexActions property is set
        internal bool IsSetIndexActions()
        {
            return this._indexActions != null && (this._indexActions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// changed after a backup has been transitioned to cold storage.
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
        /// Gets and sets the property RuleName. 
        /// <para>
        /// A display name for a backup rule. Must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A CRON expression in UTC specifying when Backup initiates a backup job.
        /// </para>
        /// </summary>
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimezone. 
        /// <para>
        /// The timezone in which the schedule expression is set. By default, ScheduleExpressions
        /// are in UTC. You can modify this to a specified timezone.
        /// </para>
        /// </summary>
        public string ScheduleExpressionTimezone
        {
            get { return this._scheduleExpressionTimezone; }
            set { this._scheduleExpressionTimezone = value; }
        }

        // Check to see if ScheduleExpressionTimezone property is set
        internal bool IsSetScheduleExpressionTimezone()
        {
            return this._scheduleExpressionTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property StartWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup is scheduled before a job will be canceled if it
        /// doesn't start successfully. This value is optional. If this value is included, it
        /// must be at least 60 minutes to avoid errors.
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

        /// <summary>
        /// Gets and sets the property TargetBackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetBackupVaultName
        {
            get { return this._targetBackupVaultName; }
            set { this._targetBackupVaultName = value; }
        }

        // Check to see if TargetBackupVaultName property is set
        internal bool IsSetTargetBackupVaultName()
        {
            return this._targetBackupVaultName != null;
        }

    }
}