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
    /// Contains metadata about a backup plan.
    /// </summary>
    public partial class BackupPlansListMember
    {
        private List<AdvancedBackupSetting> _advancedBackupSettings = AWSConfigs.InitializeCollections ? new List<AdvancedBackupSetting>() : null;
        private string _backupPlanArn;
        private string _backupPlanId;
        private string _backupPlanName;
        private DateTime? _creationDate;
        private string _creatorRequestId;
        private DateTime? _deletionDate;
        private DateTime? _lastExecutionDate;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// Contains a list of <c>BackupOptions</c> for a resource type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The display name of a saved backup plan.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a resource backup plan is created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationDate</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
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
        /// without the risk of running the operation twice. This parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
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
        /// The date and time a backup plan is deleted, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>DeletionDate</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? DeletionDate
        {
            get { return this._deletionDate; }
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
        public DateTime? LastExecutionDate
        {
            get { return this._lastExecutionDate; }
            set { this._lastExecutionDate = value; }
        }

        // Check to see if LastExecutionDate property is set
        internal bool IsSetLastExecutionDate()
        {
            return this._lastExecutionDate.HasValue; 
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