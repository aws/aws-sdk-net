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
    /// Contains identifying information about the creation of a scan job, including the backup
    /// plan and rule that initiated the scan.
    /// </summary>
    public partial class ScanJobCreator
    {
        private string _backupPlanArn;
        private string _backupPlanId;
        private string _backupPlanVersion;
        private string _backupRuleId;

        /// <summary>
        /// Gets and sets the property BackupPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup plan; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:plan:8F81F553-3A74-4A3F-B93D-B3360DC80C50</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID of the backup plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Uniquely identifies the backup rule that initiated the scan job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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