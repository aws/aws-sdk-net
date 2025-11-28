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
    /// task and can back up a different selection of Amazon Web Services resources.
    /// </summary>
    public partial class BackupPlan
    {
        private List<AdvancedBackupSetting> _advancedBackupSettings = AWSConfigs.InitializeCollections ? new List<AdvancedBackupSetting>() : null;
        private string _backupPlanName;
        private List<BackupRule> _rules = AWSConfigs.InitializeCollections ? new List<BackupRule>() : null;
        private List<ScanSetting> _scanSettings = AWSConfigs.InitializeCollections ? new List<ScanSetting>() : null;

        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// Contains a list of <c>BackupOptions</c> for each resource type.
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
        /// Gets and sets the property BackupPlanName. 
        /// <para>
        /// The display name of a backup plan. Must contain only alphanumeric or '-_.' special
        /// characters.
        /// </para>
        ///  
        /// <para>
        /// If this is set in the console, it can contain 1 to 50 characters; if this is set through
        /// CLI or API, it can contain 1 to 200 characters.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScanSettings. 
        /// <para>
        /// Contains your scanning configuration for the backup plan and includes the Malware
        /// scanner, your selected resources, and scanner role.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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