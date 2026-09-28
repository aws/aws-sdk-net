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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Specifies a scheduled task used to back up a selection of resources.
    /// </summary>
    public partial class BackupRuleInput
    {
        /// <summary>
        /// Gets and sets the property CompletionWindowMinutes. 
        /// <para>
        /// A value in minutes after a backup job is successfully started before it must be completed
        /// or it will be canceled by Backup. This value is optional.
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
        /// An array of <c>CopyAction</c> objects, which contains the details of the copy operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CopyAction> CopyActions { get; set; } = AWSConfigs.InitializeCollections ? new List<CopyAction>() : null;

        /// <summary>
        /// Checks to see if the CopyActions property is set.
        /// </summary>
        internal bool IsSetCopyActions() => this.CopyActions != null && (this.CopyActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnableContinuousBackup. 
        /// <para>
        /// Specifies whether Backup creates continuous backups. True causes Backup to create
        /// continuous backups capable of point-in-time restore (PITR). False (or not specified)
        /// causes Backup to create snapshot backups.
        /// </para>
        /// </summary>
        public bool? EnableContinuousBackup { get; set; }

        /// <summary>
        /// Checks to see if the EnableContinuousBackup property is set.
        /// </summary>
        internal bool IsSetEnableContinuousBackup() => this.EnableContinuousBackup.HasValue;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IndexAction> IndexActions { get; set; } = AWSConfigs.InitializeCollections ? new List<IndexAction>() : null;

        /// <summary>
        /// Checks to see if the IndexActions property is set.
        /// </summary>
        internal bool IsSetIndexActions() => this.IndexActions != null && (this.IndexActions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public Lifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property RecoveryPointTags. 
        /// <para>
        /// The tags to assign to the resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> RecoveryPointTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the RecoveryPointTags property is set.
        /// </summary>
        internal bool IsSetRecoveryPointTags() => this.RecoveryPointTags != null && (this.RecoveryPointTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// A display name for a backup rule. Must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property ScanActions. 
        /// <para>
        /// Contains your scanning configuration for the backup rule and includes the malware
        /// scanner, and scan mode of either full or incremental.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScanAction> ScanActions { get; set; } = AWSConfigs.InitializeCollections ? new List<ScanAction>() : null;

        /// <summary>
        /// Checks to see if the ScanActions property is set.
        /// </summary>
        internal bool IsSetScanActions() => this.ScanActions != null && (this.ScanActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A CRON expression in UTC specifying when Backup initiates a backup job. When no CRON
        /// expression is provided, Backup will use the default expression <c>cron(0 5 ? * * *)</c>.
        /// </para>
        /// </summary>
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimezone. 
        /// <para>
        /// The timezone in which the schedule expression is set. By default, ScheduleExpressions
        /// are in UTC. You can modify this to a specified timezone.
        /// </para>
        /// </summary>
        public string ScheduleExpressionTimezone { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpressionTimezone property is set.
        /// </summary>
        internal bool IsSetScheduleExpressionTimezone() => this.ScheduleExpressionTimezone != null;

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
        public long? StartWindowMinutes { get; set; }

        /// <summary>
        /// Checks to see if the StartWindowMinutes property is set.
        /// </summary>
        internal bool IsSetStartWindowMinutes() => this.StartWindowMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property TargetBackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetBackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the TargetBackupVaultName property is set.
        /// </summary>
        internal bool IsSetTargetBackupVaultName() => this.TargetBackupVaultName != null;

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
        public string TargetLogicallyAirGappedBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetLogicallyAirGappedBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetTargetLogicallyAirGappedBackupVaultArn() => this.TargetLogicallyAirGappedBackupVaultArn != null;
    }
}
