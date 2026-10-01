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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an array of <c>BackupRule</c> objects, each of which specifies
    /// a scheduled task that is used to back up a selection of resources.
    /// </summary>
    public partial class AwsBackupBackupPlanRuleDetails
    {
        /// <summary>
        /// Gets and sets the property CompletionWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup job is successfully started before it must be completed,
        /// or it is canceled by Backup. 
        /// </para>
        /// </summary>
        public long? CompletionWindowMinutes { get; set; }

        /// <summary>
        /// Checks to see if the CompletionWindowMinutes property is set.
        /// </summary>
        internal bool IsSetCompletionWindowMinutes() => this.CompletionWindowMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property CopyActions. 
        /// <para>
        /// An array of <c>CopyAction</c> objects, each of which contains details of the copy
        /// operation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsBackupBackupPlanRuleCopyActionsDetails> CopyActions { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsBackupBackupPlanRuleCopyActionsDetails>() : null;

        /// <summary>
        /// Checks to see if the CopyActions property is set.
        /// </summary>
        internal bool IsSetCopyActions() => this.CopyActions != null && (this.CopyActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableContinuousBackup. 
        /// <para>
        /// Specifies whether Backup creates continuous backups capable of point-in-time restore
        /// (PITR). 
        /// </para>
        /// </summary>
        public bool? EnableContinuousBackup { get; set; }

        /// <summary>
        /// Checks to see if the EnableContinuousBackup property is set.
        /// </summary>
        internal bool IsSetEnableContinuousBackup() => this.EnableContinuousBackup.HasValue;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Defines when a protected resource is transitioned to cold storage and when it expires.
        /// Backup transitions and expires backups automatically according to the lifecycle that
        /// you define. If you don't specify a lifecycle, Backup applies the lifecycle policy
        /// of the source backup to the destination backup.
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days.
        /// </para>
        /// </summary>
        public AwsBackupBackupPlanLifecycleDetails Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// Uniquely identifies a rule that is used to schedule the backup of a selection of resources.
        /// 
        /// </para>
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// A display name for a backup rule. Must contain 1 to 50 alphanumeric or '-_.' characters.
        /// 
        /// </para>
        /// </summary>
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression in UTC specifying when Backup initiates a backup job. 
        /// </para>
        /// </summary>
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property StartWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup is scheduled before a job will be canceled if it
        /// doesn't start successfully. 
        /// </para>
        /// </summary>
        public long? StartWindowMinutes { get; set; }

        /// <summary>
        /// Checks to see if the StartWindowMinutes property is set.
        /// </summary>
        internal bool IsSetStartWindowMinutes() => this.StartWindowMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property TargetBackupVault. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the Amazon Web Services account used to create them and
        /// the Amazon Web Services Region where they are created. They consist of letters, numbers,
        /// and hyphens. 
        /// </para>
        /// </summary>
        public string TargetBackupVault { get; set; }

        /// <summary>
        /// Checks to see if the TargetBackupVault property is set.
        /// </summary>
        internal bool IsSetTargetBackupVault() => this.TargetBackupVault != null;
    }
}
