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
    /// This contains metadata about a tiering configuration.
    /// </summary>
    public partial class TieringConfiguration
    {
        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the backup vault where the tiering configuration applies. Use <c>*</c>
        /// to apply to all backup vaults.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time a tiering configuration was created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087AM.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This is a unique string that identifies the request and allows failed requests to
        /// be retried without the risk of running the operation twice.
        /// </para>
        /// </summary>
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time a tiering configuration was updated, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>LastUpdatedTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087AM.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceSelection. 
        /// <para>
        /// An array of resource selection objects that specify which resources are included in
        /// the tiering configuration and their tiering settings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<ResourceSelection> ResourceSelection { get; set; } = AWSConfigs.InitializeCollections ? new List<ResourceSelection>() : null;

        /// <summary>
        /// Checks to see if the ResourceSelection property is set.
        /// </summary>
        internal bool IsSetResourceSelection() => this.ResourceSelection != null && (this.ResourceSelection.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TieringConfigurationArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies the tiering configuration.
        /// </para>
        /// </summary>
        public string TieringConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the TieringConfigurationArn property is set.
        /// </summary>
        internal bool IsSetTieringConfigurationArn() => this.TieringConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property TieringConfigurationName. 
        /// <para>
        /// The unique name of the tiering configuration. This cannot be changed after creation,
        /// and it must consist of only alphanumeric characters and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TieringConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the TieringConfigurationName property is set.
        /// </summary>
        internal bool IsSetTieringConfigurationName() => this.TieringConfigurationName != null;
    }
}
