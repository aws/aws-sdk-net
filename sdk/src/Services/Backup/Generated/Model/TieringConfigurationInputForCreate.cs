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
    /// This contains metadata about a tiering configuration for create operations.
    /// </summary>
    public partial class TieringConfigurationInputForCreate
    {
        private string _backupVaultName;
        private List<ResourceSelection> _resourceSelection = AWSConfigs.InitializeCollections ? new List<ResourceSelection>() : null;
        private string _tieringConfigurationName;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the backup vault where the tiering configuration applies. Use <c>*</c>
        /// to apply to all backup vaults.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceSelection. 
        /// <para>
        /// An array of resource selection objects that specify which resources are included in
        /// the tiering configuration and their tiering settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ResourceSelection> ResourceSelection
        {
            get { return this._resourceSelection; }
            set { this._resourceSelection = value; }
        }

        // Check to see if ResourceSelection property is set
        internal bool IsSetResourceSelection()
        {
            return this._resourceSelection != null && (this._resourceSelection.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TieringConfigurationName. 
        /// <para>
        /// The unique name of the tiering configuration. This cannot be changed after creation,
        /// and it must consist of only alphanumeric characters and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TieringConfigurationName
        {
            get { return this._tieringConfigurationName; }
            set { this._tieringConfigurationName = value; }
        }

        // Check to see if TieringConfigurationName property is set
        internal bool IsSetTieringConfigurationName()
        {
            return this._tieringConfigurationName != null;
        }

    }
}