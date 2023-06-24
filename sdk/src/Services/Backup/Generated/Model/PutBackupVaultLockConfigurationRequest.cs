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
    /// Container for the parameters to the PutBackupVaultLockConfiguration operation.
    /// Applies Backup Vault Lock to a backup vault, preventing attempts to delete any recovery
    /// point stored in or created in a backup vault. Vault Lock also prevents attempts to
    /// update the lifecycle policy that controls the retention period of any recovery point
    /// currently stored in a backup vault. If specified, Vault Lock enforces a minimum and
    /// maximum retention period for future backup and copy jobs that target a backup vault.
    /// 
    ///  <note> 
    /// <para>
    /// Backup Vault Lock has been assessed by Cohasset Associates for use in environments
    /// that are subject to SEC 17a-4, CFTC, and FINRA regulations. For more information about
    /// how Backup Vault Lock relates to these regulations, see the <a href="samples/cohassetreport.zip">Cohasset
    /// Associates Compliance Assessment.</a> 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutBackupVaultLockConfigurationRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private long? _changeableForDays;
        private long? _maxRetentionDays;
        private long? _minRetentionDays;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The Backup Vault Lock configuration that specifies the name of the backup vault it
        /// protects.
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
        /// Gets and sets the property ChangeableForDays. 
        /// <para>
        /// The Backup Vault Lock configuration that specifies the number of days before the lock
        /// date. For example, setting <code>ChangeableForDays</code> to 30 on Jan. 1, 2022 at
        /// 8pm UTC will set the lock date to Jan. 31, 2022 at 8pm UTC.
        /// </para>
        ///  
        /// <para>
        /// Backup enforces a 72-hour cooling-off period before Vault Lock takes effect and becomes
        /// immutable. Therefore, you must set <code>ChangeableForDays</code> to 3 or greater.
        /// </para>
        ///  
        /// <para>
        /// Before the lock date, you can delete Vault Lock from the vault using <code>DeleteBackupVaultLockConfiguration</code>
        /// or change the Vault Lock configuration using <code>PutBackupVaultLockConfiguration</code>.
        /// On and after the lock date, the Vault Lock becomes immutable and cannot be changed
        /// or deleted.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is not specified, you can delete Vault Lock from the vault using
        /// <code>DeleteBackupVaultLockConfiguration</code> or change the Vault Lock configuration
        /// using <code>PutBackupVaultLockConfiguration</code> at any time.
        /// </para>
        /// </summary>
        public long ChangeableForDays
        {
            get { return this._changeableForDays.GetValueOrDefault(); }
            set { this._changeableForDays = value; }
        }

        // Check to see if ChangeableForDays property is set
        internal bool IsSetChangeableForDays()
        {
            return this._changeableForDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRetentionDays. 
        /// <para>
        /// The Backup Vault Lock configuration that specifies the maximum retention period that
        /// the vault retains its recovery points. This setting can be useful if, for example,
        /// your organization's policies require you to destroy certain data after retaining it
        /// for four years (1460 days).
        /// </para>
        ///  
        /// <para>
        /// If this parameter is not included, Vault Lock does not enforce a maximum retention
        /// period on the recovery points in the vault. If this parameter is included without
        /// a value, Vault Lock will not enforce a maximum retention period.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is specified, any backup or copy job to the vault must have a lifecycle
        /// policy with a retention period equal to or shorter than the maximum retention period.
        /// If the job's retention period is longer than that maximum retention period, then the
        /// vault fails the backup or copy job, and you should either modify your lifecycle settings
        /// or use a different vault. The longest maximum retention period you can specify is
        /// 36500 days (approximately 100 years). Recovery points already saved in the vault prior
        /// to Vault Lock are not affected.
        /// </para>
        /// </summary>
        public long MaxRetentionDays
        {
            get { return this._maxRetentionDays.GetValueOrDefault(); }
            set { this._maxRetentionDays = value; }
        }

        // Check to see if MaxRetentionDays property is set
        internal bool IsSetMaxRetentionDays()
        {
            return this._maxRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinRetentionDays. 
        /// <para>
        /// The Backup Vault Lock configuration that specifies the minimum retention period that
        /// the vault retains its recovery points. This setting can be useful if, for example,
        /// your organization's policies require you to retain certain data for at least seven
        /// years (2555 days).
        /// </para>
        ///  
        /// <para>
        /// If this parameter is not specified, Vault Lock will not enforce a minimum retention
        /// period.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is specified, any backup or copy job to the vault must have a lifecycle
        /// policy with a retention period equal to or longer than the minimum retention period.
        /// If the job's retention period is shorter than that minimum retention period, then
        /// the vault fails that backup or copy job, and you should either modify your lifecycle
        /// settings or use a different vault. The shortest minimum retention period you can specify
        /// is 1 day. Recovery points already saved in the vault prior to Vault Lock are not affected.
        /// </para>
        /// </summary>
        public long MinRetentionDays
        {
            get { return this._minRetentionDays.GetValueOrDefault(); }
            set { this._minRetentionDays = value; }
        }

        // Check to see if MinRetentionDays property is set
        internal bool IsSetMinRetentionDays()
        {
            return this._minRetentionDays.HasValue; 
        }

    }
}