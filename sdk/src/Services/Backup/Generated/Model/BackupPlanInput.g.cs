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
    /// Contains an optional backup plan display name and an array of <c>BackupRule</c> objects,
    /// each of which specifies a backup rule. Each rule in a backup plan is a separate scheduled
    /// task.
    /// </summary>
    public partial class BackupPlanInput
    {
        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// Specifies a list of <c>BackupOptions</c> for each resource type. These settings are
        /// only available for Windows Volume Shadow Copy Service (VSS) backup jobs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdvancedBackupSetting> AdvancedBackupSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<AdvancedBackupSetting>() : null;

        /// <summary>
        /// Checks to see if the AdvancedBackupSettings property is set.
        /// </summary>
        internal bool IsSetAdvancedBackupSettings() => this.AdvancedBackupSettings != null && (this.AdvancedBackupSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackupPlanName. 
        /// <para>
        /// The display name of a backup plan. Must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupPlanName { get; set; }

        /// <summary>
        /// Checks to see if the BackupPlanName property is set.
        /// </summary>
        internal bool IsSetBackupPlanName() => this.BackupPlanName != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// An array of <c>BackupRule</c> objects, each of which specifies a scheduled task that
        /// is used to back up a selection of resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BackupRuleInput> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<BackupRuleInput>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScanSettings. 
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
        public List<ScanSetting> ScanSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<ScanSetting>() : null;

        /// <summary>
        /// Checks to see if the ScanSettings property is set.
        /// </summary>
        internal bool IsSetScanSettings() => this.ScanSettings != null && (this.ScanSettings.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
