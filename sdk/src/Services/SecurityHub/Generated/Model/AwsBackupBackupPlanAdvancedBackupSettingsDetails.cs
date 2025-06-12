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
    /// Provides a list of backup options for each resource type.
    /// </summary>
    public partial class AwsBackupBackupPlanAdvancedBackupSettingsDetails
    {
        private Dictionary<string, string> _backupOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property BackupOptions. 
        /// <para>
        /// Specifies the backup option for a selected resource. This option is only available
        /// for Windows Volume Shadow Copy Service (VSS) backup jobs. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Set to <c>WindowsVSS: enabled</c> to enable the WindowsVSS backup option and create
        /// a Windows VSS backup.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Set to <c>WindowsVSS: disabled</c> to create a regular backup. The <c>WindowsVSS</c>
        /// option is not enabled by default.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> BackupOptions
        {
            get { return this._backupOptions; }
            set { this._backupOptions = value; }
        }

        // Check to see if BackupOptions property is set
        internal bool IsSetBackupOptions()
        {
            return this._backupOptions != null && (this._backupOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The name of a resource type. The only supported resource type is Amazon EC2 instances
        /// with Windows VSS.
        /// </para>
        ///  
        /// <para>
        /// The only valid value is <c>EC2</c>.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}