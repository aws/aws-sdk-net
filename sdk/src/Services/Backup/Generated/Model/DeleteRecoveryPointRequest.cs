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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRecoveryPoint operation.
    /// Deletes the recovery point specified by a recovery point ID.
    /// 
    ///  
    /// <para>
    /// If the recovery point ID belongs to a continuous backup, calling this endpoint deletes
    /// the existing continuous backup and stops future continuous backup.
    /// </para>
    ///  
    /// <para>
    /// When an IAM role's permissions are insufficient to call this API, the service sends
    /// back an HTTP 200 response with an empty HTTP body, but the recovery point is not deleted.
    /// Instead, it enters an <code>EXPIRED</code> state.
    /// </para>
    ///  
    /// <para>
    ///  <code>EXPIRED</code> recovery points can be deleted with this API once the IAM role
    /// has the <code>iam:CreateServiceLinkedRole</code> action. To learn more about adding
    /// this role, see <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/deleting-backups.html#deleting-backups-troubleshooting">
    /// Troubleshooting manual deletions</a>.
    /// </para>
    ///  
    /// <para>
    /// If the user or role is deleted or the permission within the role is removed, the deletion
    /// will not be successful and will enter an <code>EXPIRED</code> state.
    /// </para>
    /// </summary>
    public partial class DeleteRecoveryPointRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private string _recoveryPointArn;

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

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a recovery point; for example,
        /// <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryPointArn
        {
            get { return this._recoveryPointArn; }
            set { this._recoveryPointArn = value; }
        }

        // Check to see if RecoveryPointArn property is set
        internal bool IsSetRecoveryPointArn()
        {
            return this._recoveryPointArn != null;
        }

    }
}