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
    /// Specifies a scheduled task used to back up a selection of resources.
    /// </summary>
    public partial class BackupRuleInput
    {
        private long? _completionWindowMinutes;
        private List<CopyAction> _copyActions = new List<CopyAction>();
        private bool? _enableContinuousBackup;
        private Lifecycle _lifecycle;
        private Dictionary<string, string> _recoveryPointTags = new Dictionary<string, string>();
        private string _ruleName;
        private string _scheduleExpression;
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
        /// An array of <code>CopyAction</code> objects, which contains the details of the copy
        /// operation.
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
            return this._copyActions != null && this._copyActions.Count > 0; 
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
        /// Resource types that are able to be transitioned to cold storage are listed in the
        /// "Lifecycle to cold storage" section of the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/whatisbackup.html#features-by-resource">
        /// Feature availability by resource</a> table. Backup ignores this expression for other
        /// resource types.
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
        /// To help organize your resources, you can assign your own metadata to the resources
        /// that you create. Each tag is a key-value pair.
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
            return this._recoveryPointTags != null && this._recoveryPointTags.Count > 0; 
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
        /// Gets and sets the property StartWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup is scheduled before a job will be canceled if it
        /// doesn't start successfully. This value is optional. If this value is included, it
        /// must be at least 60 minutes to avoid errors.
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
        /// Region where they are created. They consist of lowercase letters, numbers, and hyphens.
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