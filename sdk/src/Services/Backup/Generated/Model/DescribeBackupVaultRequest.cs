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
    /// Container for the parameters to the DescribeBackupVault operation.
    /// Returns metadata about a backup vault specified by its name.
    /// </summary>
    public partial class DescribeBackupVaultRequest : AmazonBackupRequest
    {
        private string _backupVaultAccountId;
        private string _backupVaultName;

        /// <summary>
        /// Gets and sets the property BackupVaultAccountId. 
        /// <para>
        /// This is the account ID of the specified backup vault.
        /// </para>
        /// </summary>
        public string BackupVaultAccountId
        {
            get { return this._backupVaultAccountId; }
            set { this._backupVaultAccountId = value; }
        }

        // Check to see if BackupVaultAccountId property is set
        internal bool IsSetBackupVaultAccountId()
        {
            return this._backupVaultAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Amazon Web Services
        /// Region where they are created. They consist of lowercase letters, numbers, and hyphens.
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

    }
}