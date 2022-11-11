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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an array of <code>BackupRule</code> objects, each of which
    /// specifies a scheduled task that is used to back up a selection of resources.
    /// </summary>
    public partial class AwsBackupBackupPlanRuleDetails
    {
        private long? _completionWindowMinutes;
        private List<AwsBackupBackupPlanRuleCopyActionsDetails> _copyActions = new List<AwsBackupBackupPlanRuleCopyActionsDetails>();
        private bool? _enableContinuousBackup;
        private AwsBackupBackupPlanLifecycleDetails _lifecycle;
        private string _ruleId;
        private string _ruleName;
        private string _scheduleExpression;
        private long? _startWindowMinutes;
        private string _targetBackupVault;

        /// <summary>
        /// Gets and sets the property CompletionWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup job is successfully started before it must be completed,
        /// or it is canceled by Backup. 
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
        /// An array of <code>CopyAction</code> objects, each of which contains details of the
        /// copy operation. 
        /// </para>
        /// </summary>
        public List<AwsBackupBackupPlanRuleCopyActionsDetails> CopyActions
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
        /// Specifies whether Backup creates continuous backups capable of point-in-time restore
        /// (PITR). 
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
        /// Defines when a protected resource is transitioned to cold storage and when it expires.
        /// Backup transitions and expires backups automatically according to the lifecycle that
        /// you define. If you do not specify a lifecycle, Backup applies the lifecycle policy
        /// of the source backup to the destination backup.
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days.
        /// </para>
        /// </summary>
        public AwsBackupBackupPlanLifecycleDetails Lifecycle
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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// Uniquely identifies a rule that is used to schedule the backup of a selection of resources.
        /// 
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
        /// 
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
        /// A cron expression in UTC specifying when Backup initiates a backup job. 
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
        /// doesn't start successfully. 
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
        /// Gets and sets the property TargetBackupVault. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the Amazon Web Services account used to create them and
        /// the Amazon Web Services Region where they are created. They consist of letters, numbers,
        /// and hyphens. 
        /// </para>
        /// </summary>
        public string TargetBackupVault
        {
            get { return this._targetBackupVault; }
            set { this._targetBackupVault = value; }
        }

        // Check to see if TargetBackupVault property is set
        internal bool IsSetTargetBackupVault()
        {
            return this._targetBackupVault != null;
        }

    }
}