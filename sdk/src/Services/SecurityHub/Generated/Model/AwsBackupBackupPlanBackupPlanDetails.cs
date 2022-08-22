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
    /// Provides details about an Backup backup plan and an array of <code>BackupRule</code>
    /// objects, each of which specifies a backup rule.
    /// </summary>
    public partial class AwsBackupBackupPlanBackupPlanDetails
    {
        private List<AwsBackupBackupPlanAdvancedBackupSettingsDetails> _advancedBackupSettings = new List<AwsBackupBackupPlanAdvancedBackupSettingsDetails>();
        private string _backupPlanName;
        private List<AwsBackupBackupPlanRuleDetails> _backupPlanRule = new List<AwsBackupBackupPlanRuleDetails>();

        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// A list of backup options for each resource type. 
        /// </para>
        /// </summary>
        public List<AwsBackupBackupPlanAdvancedBackupSettingsDetails> AdvancedBackupSettings
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
        /// Gets and sets the property BackupPlanRule. 
        /// <para>
        /// An array of <code>BackupRule</code> objects, each of which specifies a scheduled task
        /// that is used to back up a selection of resources. 
        /// </para>
        /// </summary>
        public List<AwsBackupBackupPlanRuleDetails> BackupPlanRule
        {
            get { return this._backupPlanRule; }
            set { this._backupPlanRule = value; }
        }

        // Check to see if BackupPlanRule property is set
        internal bool IsSetBackupPlanRule()
        {
            return this._backupPlanRule != null && this._backupPlanRule.Count > 0; 
        }

    }
}