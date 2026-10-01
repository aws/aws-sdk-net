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
    /// This is the response object from the CreateRestoreAccessBackupVault operation.
    /// </summary>
    public partial class CreateRestoreAccessBackupVaultResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// >The date and time when the restore access backup vault was created, in Unix format
        /// and Coordinated Universal Time 
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreAccessBackupVaultArn. 
        /// <para>
        /// The ARN that uniquely identifies the created restore access backup vault.
        /// </para>
        /// </summary>
        public string RestoreAccessBackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the RestoreAccessBackupVaultArn property is set.
        /// </summary>
        internal bool IsSetRestoreAccessBackupVaultArn() => this.RestoreAccessBackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property RestoreAccessBackupVaultName. 
        /// <para>
        /// The name of the created restore access backup vault.
        /// </para>
        /// </summary>
        public string RestoreAccessBackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreAccessBackupVaultName property is set.
        /// </summary>
        internal bool IsSetRestoreAccessBackupVaultName() => this.RestoreAccessBackupVaultName != null;

        /// <summary>
        /// Gets and sets the property VaultState. 
        /// <para>
        /// The current state of the restore access backup vault.
        /// </para>
        /// </summary>
        public VaultState VaultState { get; set; }

        /// <summary>
        /// Checks to see if the VaultState property is set.
        /// </summary>
        internal bool IsSetVaultState() => this.VaultState != null;
    }
}
