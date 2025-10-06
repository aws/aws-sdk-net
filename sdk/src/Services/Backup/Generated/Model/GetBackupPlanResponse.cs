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
    /// This is the response object from the GetBackupPlan operation.
    /// </summary>
    public partial class GetBackupPlanResponse : AmazonWebServiceResponse
    {
        private List<AdvancedBackupSetting> _advancedBackupSettings = AWSConfigs.InitializeCollections ? new List<AdvancedBackupSetting>() : null;
        private BackupPlan _backupPlan;
        private string _backupPlanArn;
        private string _backupPlanId;
        private DateTime? _creationDate;
        private string _creatorRequestId;
        private DateTime? _deletionDate;
        private DateTime? _lastExecutionDate;
        private List<ScheduledPlanExecutionMember> _scheduledRunsPreview = AWSConfigs.InitializeCollections ? new List<ScheduledPlanExecutionMember>() : null;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// Contains a list of <c>BackupOptions</c> for each resource type. The list is populated
        /// only if the advanced option is set for the backup plan.
        /// </para>
        /// </summary>
        public List<AdvancedBackupSetting> AdvancedBackupSettings
        {
            get { return this._advancedBackupSettings; }
            set { this._advancedBackupSettings = value; }
        }

        // Check to see if AdvancedBackupSettings property is set
        internal bool IsSetAdvancedBackupSettings()
        {
            return this._advancedBackupSettings != null && (this._advancedBackupSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupPlan. 
        /// <para>
        /// Specifies the body of a backup plan. Includes a <c>BackupPlanName</c> and one or more
        /// sets of <c>Rules</c>.
        /// </para>
        /// </summary>
        public BackupPlan BackupPlan
        {
            get { return this._backupPlan; }
            set { this._backupPlan = value; }
        }

        // Check to see if BackupPlan property is set
        internal bool IsSetBackupPlan()
        {
            return this._backupPlan != null;
        }

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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a backup plan is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
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
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and allows failed requests to be retried
        /// without the risk of running the operation twice. 
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property DeletionDate. 
        /// <para>
        /// The date and time that a backup plan is deleted, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>DeletionDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime DeletionDate
        {
            get { return this._deletionDate.GetValueOrDefault(); }
            set { this._deletionDate = value; }
        }

        // Check to see if DeletionDate property is set
        internal bool IsSetDeletionDate()
        {
            return this._deletionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastExecutionDate. 
        /// <para>
        /// The last time this backup plan was run. A date and time, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>LastExecutionDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime LastExecutionDate
        {
            get { return this._lastExecutionDate.GetValueOrDefault(); }
            set { this._lastExecutionDate = value; }
        }

        // Check to see if LastExecutionDate property is set
        internal bool IsSetLastExecutionDate()
        {
            return this._lastExecutionDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledRunsPreview. 
        /// <para>
        /// List of upcoming scheduled backup runs. Only included when <c>MaxScheduledRunsPreview</c>
        /// parameter is greater than 0. Contains up to 10 future backup executions with their
        /// scheduled times, execution types, and associated rule IDs.
        /// </para>
        /// </summary>
        public List<ScheduledPlanExecutionMember> ScheduledRunsPreview
        {
            get { return this._scheduledRunsPreview; }
            set { this._scheduledRunsPreview = value; }
        }

        // Check to see if ScheduledRunsPreview property is set
        internal bool IsSetScheduledRunsPreview()
        {
            return this._scheduledRunsPreview != null && (this._scheduledRunsPreview.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Unique, randomly generated, Unicode, UTF-8 encoded strings that are at most 1,024
        /// bytes long. Version IDs cannot be edited.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}