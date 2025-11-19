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
    public partial class BackupRule
    {
        private long? _completionWindowMinutes;
        private List<CopyAction> _copyActions = AWSConfigs.InitializeCollections ? new List<CopyAction>() : null;
        private bool? _enableContinuousBackup;
        private List<IndexAction> _indexActions = AWSConfigs.InitializeCollections ? new List<IndexAction>() : null;
        private Lifecycle _lifecycle;
        private Dictionary<string, string> _recoveryPointTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _ruleId;
        private string _ruleName;
        private List<ScanAction> _scanActions = AWSConfigs.InitializeCollections ? new List<ScanAction>() : null;
        private string _scheduleExpression;
        private string _scheduleExpressionTimezone;
        private long? _startWindowMinutes;
        private string _targetBackupVaultName;
        private string _targetLogicallyAirGappedBackupVaultArn;

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
        /// IndexActions is an array you use to specify how backup data should be indexed.
        /// </para>
        ///  
        /// <para>
        /// eEach BackupRule can have 0 or 1 IndexAction, as each backup can have up to one index
        /// associated with it.
        /// </para>
        ///  
        /// <para>
        /// Within the array is ResourceType. Only one will be accepted for each BackupRule.
        /// </para>
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
        /// when it expires. Backup transitions and expires backups automatically according to
        /// the lifecycle that you define. 
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
        /// The tags that are assigned to resources that are associated with this rule when restored
        /// from backup.
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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// Uniquely identifies a rule that is used to schedule the backup of a selection of resources.
        /// </para>
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
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
        /// Gets and sets the property ScanActions. 
        /// <para>
        /// Contains your scanning configuration for the backup rule and includes the malware
        /// scanner, and scan mode of either full or incremental.
        /// </para>
        /// </summary>
        public List<ScanAction> ScanActions
        {
            get { return this._scanActions; }
            set { this._scanActions = value; }
        }

        // Check to see if ScanActions property is set
        internal bool IsSetScanActions()
        {
            return this._scanActions != null && (this._scanActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression in UTC specifying when Backup initiates a backup job. When no CRON
        /// expression is provided, Backup will use the default expression <c>cron(0 5 ? * * *)</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amazon Web Services cron expressions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html">Schedule
        /// Expressions for Rules</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Two examples of Amazon Web Services cron expressions are <c> 15 * ? * * *</c> (take
        /// a backup every hour at 15 minutes past the hour) and <c>0 12 * * ? *</c> (take a backup
        /// every day at 12 noon UTC).
        /// </para>
        ///  
        /// <para>
        /// For a table of examples, click the preceding link and scroll down the page.
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

        /// <summary>
        /// Gets and sets the property TargetLogicallyAirGappedBackupVaultArn. 
        /// <para>
        /// The ARN of a logically air-gapped vault. ARN must be in the same account and Region.
        /// If provided, supported fully managed resources back up directly to logically air-gapped
        /// vault, while other supported resources create a temporary (billable) snapshot in backup
        /// vault, then copy it to logically air-gapped vault. Unsupported resources only back
        /// up to the specified backup vault.
        /// </para>
        /// </summary>
        public string TargetLogicallyAirGappedBackupVaultArn
        {
            get { return this._targetLogicallyAirGappedBackupVaultArn; }
            set { this._targetLogicallyAirGappedBackupVaultArn = value; }
        }

        // Check to see if TargetLogicallyAirGappedBackupVaultArn property is set
        internal bool IsSetTargetLogicallyAirGappedBackupVaultArn()
        {
            return this._targetLogicallyAirGappedBackupVaultArn != null;
        }

    }
}