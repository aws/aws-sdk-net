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
    /// Container for the parameters to the UpdateRecoveryPointLifecycle operation.
    /// Sets the transition lifecycle of a recovery point.
    /// 
    ///  
    /// <para>
    /// The lifecycle defines when a protected resource is transitioned to cold storage and
    /// when it expires. AWS Backup transitions and expires backups automatically according
    /// to the lifecycle that you define. 
    /// </para>
    ///  
    /// <para>
    /// Backups transitioned to cold storage must be stored in cold storage for a minimum
    /// of 90 days. Therefore, the “expire after days” setting must be 90 days greater than
    /// the “transition to cold after days” setting. The “transition to cold after days” setting
    /// cannot be changed after a backup has been transitioned to cold. 
    /// </para>
    /// </summary>
    public partial class UpdateRecoveryPointLifecycleRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private Lifecycle _lifecycle;
        private string _recoveryPointArn;

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
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle defines when a protected resource is transitioned to cold storage and
        /// when it expires. AWS Backup transitions and expires backups automatically according
        /// to the lifecycle that you define. 
        /// </para>
        ///  
        /// <para>
        /// Backups transitioned to cold storage must be stored in cold storage for a minimum
        /// of 90 days. Therefore, the “expire after days” setting must be 90 days greater than
        /// the “transition to cold after days” setting. The “transition to cold after days” setting
        /// cannot be changed after a backup has been transitioned to cold. 
        /// </para>
        /// </summary>
        public Lifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a recovery point; for example,
        /// <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
        /// </para>
        /// </summary>
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