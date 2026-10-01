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
    /// Container for the parameters to the CreateLogicallyAirGappedBackupVault operation.
    /// Creates a logical container to where backups may be copied. <para> This request includes
    /// a name, the Region, the maximum number of retention days, the minimum number of retention
    /// days, and optionally can include tags and a creator request ID. </para> <note> <para>
    /// Do not include sensitive data, such as passport numbers, in the name of a backup vault.
    /// </para> </note>
    /// </summary>
    public partial class CreateLogicallyAirGappedBackupVaultRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Logically air-gapped backup
        /// vaults are identified by names that are unique to the account used to create them
        /// and the Region where they are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property BackupVaultTags. 
        /// <para>
        /// The tags to assign to the vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> BackupVaultTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the BackupVaultTags property is set.
        /// </summary>
        internal bool IsSetBackupVaultTags() => this.BackupVaultTags != null && (this.BackupVaultTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// The ID of the creation request.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If used, this parameter must contain 1 to 50 alphanumeric
        /// or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId { get; set; }

        /// <summary>
        /// Checks to see if the CreatorRequestId property is set.
        /// </summary>
        internal bool IsSetCreatorRequestId() => this.CreatorRequestId != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The ARN of the customer-managed KMS key to use for encrypting the logically air-gapped
        /// backup vault. If not specified, the vault will be encrypted with an Amazon Web Services-owned
        /// key managed by Amazon Web Services Backup.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property MaxRetentionDays. 
        /// <para>
        /// The maximum retention period that the vault retains its recovery points.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MaxRetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetentionDays property is set.
        /// </summary>
        internal bool IsSetMaxRetentionDays() => this.MaxRetentionDays.HasValue;

        /// <summary>
        /// Gets and sets the property MinRetentionDays. 
        /// <para>
        /// This setting specifies the minimum retention period that the vault retains its recovery
        /// points.
        /// </para>
        ///  
        /// <para>
        /// The minimum value accepted is 7 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? MinRetentionDays { get; set; }

        /// <summary>
        /// Checks to see if the MinRetentionDays property is set.
        /// </summary>
        internal bool IsSetMinRetentionDays() => this.MinRetentionDays.HasValue;
    }
}
