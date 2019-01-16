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
    /// Specifies a scheduled task used to back up a selection of resources.
    /// </summary>
    public partial class BackupRule
    {
        private long? _completionWindowMinutes;
        private Lifecycle _lifecycle;
        private Dictionary<string, string> _recoveryPointTags = new Dictionary<string, string>();
        private string _ruleId;
        private string _ruleName;
        private string _scheduleExpression;
        private long? _startWindowMinutes;
        private string _targetBackupVaultName;

        /// <summary>
        /// Gets and sets the property CompletionWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup job is successfully started before it must be completed
        /// or it is canceled by AWS Backup. This value is optional.
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
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. AWS Backup transitions and expires backups automatically according
        /// to the lifecycle that you define. 
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “expire after days” setting must be 90 days greater than
        /// the “transition to cold after days” setting. The “transition to cold after days” setting
        /// cannot be changed after a backup has been transitioned to cold. 
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
        /// An array of key-value pair strings that are assigned to resources that are associated
        /// with this rule when restored from backup.
        /// </para>
        /// </summary>
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
        /// An optional display name for a backup rule.
        /// </para>
        /// </summary>
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
        /// A CRON expression specifying when AWS Backup initiates a backup job.
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
        /// An optional value that specifies a period of time in minutes after a backup is scheduled
        /// before a job is canceled if it doesn't start successfully.
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
        /// by names that are unique to the account used to create them and the AWS Region where
        /// they are created. They consist of lowercase letters, numbers, and hyphens.
        /// </para>
        /// </summary>
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