/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains metadata about a backup vault.
    /// </summary>
    public partial class BackupVaultListMember
    {
        private string _backupVaultArn;
        private string _backupVaultName;
        private DateTime? _creationDate;
        private string _creatorRequestId;
        private string _encryptionKeyArn;
        private long? _numberOfRecoveryPoints;

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault; for example,
        /// <code>arn:aws:backup:us-east-1:123456789012:vault:aBackupVault</code>.
        /// </para>
        /// </summary>
        public string BackupVaultArn
        {
            get { return this._backupVaultArn; }
            set { this._backupVaultArn = value; }
        }

        // Check to see if BackupVaultArn property is set
        internal bool IsSetBackupVaultArn()
        {
            return this._backupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the AWS Region where
        /// they are created. They consist of lowercase letters, numbers, and hyphens.
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time a resource backup is created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <code>CreationDate</code> is accurate to milliseconds. For
        /// example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
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
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The server-side encryption key that is used to protect your backups; for example,
        /// <code>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfRecoveryPoints. 
        /// <para>
        /// The number of recovery points that are stored in a backup vault.
        /// </para>
        /// </summary>
        public long NumberOfRecoveryPoints
        {
            get { return this._numberOfRecoveryPoints.GetValueOrDefault(); }
            set { this._numberOfRecoveryPoints = value; }
        }

        // Check to see if NumberOfRecoveryPoints property is set
        internal bool IsSetNumberOfRecoveryPoints()
        {
            return this._numberOfRecoveryPoints.HasValue; 
        }

    }
}