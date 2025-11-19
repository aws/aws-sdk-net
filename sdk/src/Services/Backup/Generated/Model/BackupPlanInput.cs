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
    /// Contains an optional backup plan display name and an array of <c>BackupRule</c> objects,
    /// each of which specifies a backup rule. Each rule in a backup plan is a separate scheduled
    /// task.
    /// </summary>
    public partial class BackupPlanInput
    {
        private List<AdvancedBackupSetting> _advancedBackupSettings = AWSConfigs.InitializeCollections ? new List<AdvancedBackupSetting>() : null;
        private string _backupPlanName;
        private List<BackupRuleInput> _rules = AWSConfigs.InitializeCollections ? new List<BackupRuleInput>() : null;
        private List<ScanSetting> _scanSettings = AWSConfigs.InitializeCollections ? new List<ScanSetting>() : null;

        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// Specifies a list of <c>BackupOptions</c> for each resource type. These settings are
        /// only available for Windows Volume Shadow Copy Service (VSS) backup jobs.
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
        /// Gets and sets the property BackupPlanName. 
        /// <para>
        /// The display name of a backup plan. Must contain 1 to 50 alphanumeric or '-_.' characters.
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
        /// An array of <c>BackupRule</c> objects, each of which specifies a scheduled task that
        /// is used to back up a selection of resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BackupRuleInput> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanSettings. 
        /// <para>
        /// Contains your scanning configuration for the backup rule and includes the malware
        /// scanner, and scan mode of either full or incremental.
        /// </para>
        /// </summary>
        public List<ScanSetting> ScanSettings
        {
            get { return this._scanSettings; }
            set { this._scanSettings = value; }
        }

        // Check to see if ScanSettings property is set
        internal bool IsSetScanSettings()
        {
            return this._scanSettings != null && (this._scanSettings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}