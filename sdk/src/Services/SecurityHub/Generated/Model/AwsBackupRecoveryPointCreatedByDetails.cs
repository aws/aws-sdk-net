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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains information about the backup plan and rule that Backup used to initiate the
    /// recovery point backup.
    /// </summary>
    public partial class AwsBackupRecoveryPointCreatedByDetails
    {
        private string _backupPlanArn;
        private string _backupPlanId;
        private string _backupPlanVersion;
        private string _backupRuleId;

        /// <summary>
        /// Gets and sets the property BackupPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup plan. 
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
        /// Gets and sets the property BackupPlanVersion. 
        /// <para>
        /// Unique, randomly generated, Unicode, UTF-8 encoded strings that are at most 1,024
        /// bytes long. Version IDs cannot be edited. 
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
        /// Gets and sets the property BackupRuleId. 
        /// <para>
        /// Uniquely identifies a rule used to schedule the backup of a selection of resources.
        /// 
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

    }
}