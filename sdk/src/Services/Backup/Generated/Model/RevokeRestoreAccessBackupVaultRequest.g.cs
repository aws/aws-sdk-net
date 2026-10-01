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
    /// Container for the parameters to the RevokeRestoreAccessBackupVault operation. Revokes
    /// access to a restore access backup vault, removing the ability to restore from its
    /// recovery points and permanently deleting the vault.
    /// </summary>
    public partial class RevokeRestoreAccessBackupVaultRequest : AmazonBackupRequest
    {
        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of the source backup vault associated with the restore access backup vault
        /// to be revoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property RequesterComment. 
        /// <para>
        /// A comment explaining the reason for revoking access to the restore access backup vault.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string RequesterComment { get; set; }

        /// <summary>
        /// Checks to see if the RequesterComment property is set.
        /// </summary>
        internal bool IsSetRequesterComment() => this.RequesterComment != null;

        /// <summary>
        /// Gets and sets the property RestoreAccessBackupVaultArn. 
        /// <para>
        /// The ARN of the restore access backup vault to revoke.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreAccessBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the RestoreAccessBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetRestoreAccessBackupVaultArn() => this.RestoreAccessBackupVaultArn != null;
    }
}
