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
    /// Contains an optional backup plan display name and an array of <code>BackupRule</code>
    /// objects, each of which specifies a backup rule. Each rule in a backup plan is a separate
    /// scheduled task and can back up a different selection of AWS resources.
    /// </summary>
    public partial class BackupPlan
    {
        private List<AdvancedBackupSetting> _advancedBackupSettings = new List<AdvancedBackupSetting>();
        private string _backupPlanName;
        private List<BackupRule> _rules = new List<BackupRule>();

        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// Contains a list of <code>BackupOptions</code> for each resource type.
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
            return this._advancedBackupSettings != null && this._advancedBackupSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BackupPlanName. 
        /// <para>
        /// The display name of a backup plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Rules. 
        /// <para>
        /// An array of <code>BackupRule</code> objects, each of which specifies a scheduled task
        /// that is used to back up a selection of resources. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BackupRule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}