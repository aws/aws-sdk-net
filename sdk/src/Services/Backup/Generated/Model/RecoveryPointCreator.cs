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
    /// Contains information about the backup plan and rule that Backup used to initiate the
    /// recovery point backup.
    /// </summary>
    public partial class RecoveryPointCreator
    {
        private string _backupPlanArn;
        private string _backupPlanId;
        private string _backupPlanName;
        private string _backupPlanVersion;
        private string _backupRuleCron;
        private string _backupRuleId;
        private string _backupRuleName;
        private string _backupRuleTimezone;

        /// <summary>
        /// Gets and sets the property BackupPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup plan; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:plan:8F81F553-3A74-4A3F-B93D-B3360DC80C50</c>.
        /// </para>
        /// </summary>
        public string BackupPlanArn
        {
            get { return this._backupPlanArn; }
            set { this._backupPlanArn = value; }
        }

        // Check to see if BackupPlanArn property is set
        internal bool IsSetBackupPlanArn()
        {
            return this._backupPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// Uniquely identifies a backup plan.
        /// </para>
        /// </summary>
        public string BackupPlanId
        {
            get { return this._backupPlanId; }
            set { this._backupPlanId = value; }
        }

        // Check to see if BackupPlanId property is set
        internal bool IsSetBackupPlanId()
        {
            return this._backupPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupPlanName. 
        /// <para>
        /// The name of the backup plan that created this recovery point. This provides human-readable
        /// context about which backup plan was responsible for the backup job.
        /// </para>
        /// </summary>
        public string BackupPlanName
        {
            get { return this._backupPlanName; }
            set { this._backupPlanName = value; }
        }

        // Check to see if BackupPlanName property is set
        internal bool IsSetBackupPlanName()
        {
            return this._backupPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property BackupPlanVersion. 
        /// <para>
        /// Version IDs are unique, randomly generated, Unicode, UTF-8 encoded strings that are
        /// at most 1,024 bytes long. They cannot be edited.
        /// </para>
        /// </summary>
        public string BackupPlanVersion
        {
            get { return this._backupPlanVersion; }
            set { this._backupPlanVersion = value; }
        }

        // Check to see if BackupPlanVersion property is set
        internal bool IsSetBackupPlanVersion()
        {
            return this._backupPlanVersion != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRuleCron. 
        /// <para>
        /// The cron expression that defines the schedule for the backup rule. This shows the
        /// frequency and timing of when backups are automatically triggered.
        /// </para>
        /// </summary>
        public string BackupRuleCron
        {
            get { return this._backupRuleCron; }
            set { this._backupRuleCron = value; }
        }

        // Check to see if BackupRuleCron property is set
        internal bool IsSetBackupRuleCron()
        {
            return this._backupRuleCron != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRuleId. 
        /// <para>
        /// Uniquely identifies a rule used to schedule the backup of a selection of resources.
        /// </para>
        /// </summary>
        public string BackupRuleId
        {
            get { return this._backupRuleId; }
            set { this._backupRuleId = value; }
        }

        // Check to see if BackupRuleId property is set
        internal bool IsSetBackupRuleId()
        {
            return this._backupRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRuleName. 
        /// <para>
        /// The name of the backup rule within the backup plan that created this recovery point.
        /// This helps identify which specific rule triggered the backup job.
        /// </para>
        /// </summary>
        public string BackupRuleName
        {
            get { return this._backupRuleName; }
            set { this._backupRuleName = value; }
        }

        // Check to see if BackupRuleName property is set
        internal bool IsSetBackupRuleName()
        {
            return this._backupRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRuleTimezone. 
        /// <para>
        /// The timezone used for the backup rule schedule. This provides context for when backups
        /// are scheduled to run in the specified timezone.
        /// </para>
        /// </summary>
        public string BackupRuleTimezone
        {
            get { return this._backupRuleTimezone; }
            set { this._backupRuleTimezone = value; }
        }

        // Check to see if BackupRuleTimezone property is set
        internal bool IsSetBackupRuleTimezone()
        {
            return this._backupRuleTimezone != null;
        }

    }
}