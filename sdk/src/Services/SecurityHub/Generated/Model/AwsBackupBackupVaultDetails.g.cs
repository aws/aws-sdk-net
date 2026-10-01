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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about an Backup backup vault. In Backup, a backup vault is a container
    /// that stores and organizes your backups.
    /// </summary>
    public partial class AwsBackupBackupVaultDetails
    {
        /// <summary>
        /// Gets and sets the property AccessPolicy. 
        /// <para>
        /// A resource-based policy that is used to manage access permissions on the target backup
        /// vault. 
        /// </para>
        /// </summary>
        public string AccessPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AccessPolicy property is set.
        /// </summary>
        internal bool IsSetAccessPolicy() => this.AccessPolicy != null;

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault. 
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
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the Amazon Web Services account used to create them and
        /// the Amazon Web Services Region where they are created. They consist of lowercase letters,
        /// numbers, and hyphens. 
        /// </para>
        /// </summary>
        public string BackupVaultName { get; set; }

        /// <summary>
        /// Checks to see if the BackupVaultName property is set.
        /// </summary>
        internal bool IsSetBackupVaultName() => this.BackupVaultName != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The unique ARN associated with the server-side encryption key. You can specify a key
        /// to encrypt your backups from services that support full Backup management. If you
        /// don't specify a key, Backup creates an KMS key for you by default. 
        /// </para>
        /// </summary>
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property Notifications. 
        /// <para>
        /// The Amazon SNS event notifications for the specified backup vault. 
        /// </para>
        /// </summary>
        public AwsBackupBackupVaultNotificationsDetails Notifications { get; set; }

        /// <summary>
        /// Checks to see if the Notifications property is set.
        /// </summary>
        internal bool IsSetNotifications() => this.Notifications != null;
    }
}
