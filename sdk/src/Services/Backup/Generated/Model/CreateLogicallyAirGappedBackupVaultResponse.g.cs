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
    /// This is the response object from the CreateLogicallyAirGappedBackupVault operation.
    /// </summary>
    public partial class CreateLogicallyAirGappedBackupVaultResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the vault.
        /// </para>
        /// </summary>
        public string BackupVaultArn { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultArn property is set.
        /// </summary>
        internal bool IsSetBackupVaultArn() => this.BackupVaultArn != null;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Logically air-gapped backup
        /// vaults are identified by names that are unique to the account used to create them
        /// and the Region where they are created.
        /// </para>
        /// </summary>
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the vault was created.
        /// </para>
        ///  
        /// <para>
        /// This value is in Unix format, Coordinated Universal Time (UTC), and accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property VaultState. 
        /// <para>
        /// The current state of the vault.
        /// </para>
        /// </summary>
        public VaultState VaultState { get; set; }

        /// <summary>
        /// Checks to see if the VaultState property is set.
        /// </summary>
        internal bool IsSetVaultState() => this.VaultState != null;
    }
}
