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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Backup backup plan and an array of <c>BackupRule</c> objects,
    /// each of which specifies a backup rule.
    /// </summary>
    public partial class AwsBackupBackupPlanBackupPlanDetails
    {
        /// <summary>
        /// Gets and sets the property AdvancedBackupSettings. 
        /// <para>
        /// A list of backup options for each resource type. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsBackupBackupPlanAdvancedBackupSettingsDetails> AdvancedBackupSettings { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsBackupBackupPlanAdvancedBackupSettingsDetails>() : null;

        /// <summary>
        /// Checks to see if the AdvancedBackupSettings property is set.
        /// </summary>
        internal bool IsSetAdvancedBackupSettings() => this.AdvancedBackupSettings != null && (this.AdvancedBackupSettings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BackupPlanName. 
        /// <para>
        /// The display name of a backup plan. 
        /// </para>
        /// </summary>
        public string BackupPlanName { get; set; }

        /// <summary>
        /// Checks to see if the BackupPlanName property is set.
        /// </summary>
        internal bool IsSetBackupPlanName() => this.BackupPlanName != null;

        /// <summary>
        /// Gets and sets the property BackupPlanRule. 
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
        public List<AwsBackupBackupPlanRuleDetails> BackupPlanRule { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsBackupBackupPlanRuleDetails>() : null;

        /// <summary>
        /// Checks to see if the BackupPlanRule property is set.
        /// </summary>
        internal bool IsSetBackupPlanRule() => this.BackupPlanRule != null && (this.BackupPlanRule.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
