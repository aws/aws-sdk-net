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
    /// Container for the parameters to the CreateRestoreAccessBackupVault operation.
    /// Creates a restore access backup vault that provides temporary access to recovery points
    /// in a logically air-gapped backup vault, subject to MPA approval.
    /// </summary>
    public partial class CreateRestoreAccessBackupVaultRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private Dictionary<string, string> _backupVaultTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _creatorRequestId;
        private string _requesterComment;
        private string _sourceBackupVaultArn;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the backup vault to associate with an MPA approval team.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property BackupVaultTags. 
        /// <para>
        /// Optional tags to assign to the restore access backup vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, string> BackupVaultTags
        {
            get { return this._backupVaultTags; }
            set { this._backupVaultTags = value; }
        }

        // Check to see if BackupVaultTags property is set
        internal bool IsSetBackupVaultTags()
        {
            return this._backupVaultTags != null && (this._backupVaultTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// A unique string that identifies the request and allows failed requests to be retried
        /// without the risk of executing the operation twice.
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
        /// Gets and sets the property RequesterComment. 
        /// <para>
        /// A comment explaining the reason for requesting restore access to the backup vault.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string RequesterComment
        {
            get { return this._requesterComment; }
            set { this._requesterComment = value; }
        }

        // Check to see if RequesterComment property is set
        internal bool IsSetRequesterComment()
        {
            return this._requesterComment != null;
        }

        /// <summary>
        /// Gets and sets the property SourceBackupVaultArn. 
        /// <para>
        /// The ARN of the source backup vault containing the recovery points to which temporary
        /// access is requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceBackupVaultArn
        {
            get { return this._sourceBackupVaultArn; }
            set { this._sourceBackupVaultArn = value; }
        }

        // Check to see if SourceBackupVaultArn property is set
        internal bool IsSetSourceBackupVaultArn()
        {
            return this._sourceBackupVaultArn != null;
        }

    }
}