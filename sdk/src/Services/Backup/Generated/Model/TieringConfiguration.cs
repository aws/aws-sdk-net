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
    /// This contains metadata about a tiering configuration.
    /// </summary>
    public partial class TieringConfiguration
    {
        private string _backupVaultName;
        private DateTime? _creationTime;
        private string _creatorRequestId;
        private DateTime? _lastUpdatedTime;
        private List<ResourceSelection> _resourceSelection = AWSConfigs.InitializeCollections ? new List<ResourceSelection>() : null;
        private string _tieringConfigurationArn;
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time a tiering configuration was created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087AM.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This is a unique string that identifies the request and allows failed requests to
        /// be retried without the risk of running the operation twice.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time a tiering configuration was updated, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>LastUpdatedTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087AM.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
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
        /// Gets and sets the property TieringConfigurationArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies the tiering configuration.
        /// </para>
        /// </summary>
        public string TieringConfigurationArn
        {
            get { return this._tieringConfigurationArn; }
            set { this._tieringConfigurationArn = value; }
        }

        // Check to see if TieringConfigurationArn property is set
        internal bool IsSetTieringConfigurationArn()
        {
            return this._tieringConfigurationArn != null;
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