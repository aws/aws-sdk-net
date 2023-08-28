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
    /// Container for the parameters to the CreateLogicallyAirGappedBackupVault operation.
    /// This request creates a logical container to where backups may be copied.
    /// 
    ///  
    /// <para>
    /// This request includes a name, the Region, the maximum number of retention days, the
    /// minimum number of retention days, and optionally can include tags and a creator request
    /// ID.
    /// </para>
    ///  <note> 
    /// <para>
    /// Do not include sensitive data, such as passport numbers, in the name of a backup vault.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateLogicallyAirGappedBackupVaultRequest : AmazonBackupRequest
    {
        private string _backupVaultName;
        private Dictionary<string, string> _backupVaultTags = new Dictionary<string, string>();
        private string _creatorRequestId;
        private long? _maxRetentionDays;
        private long? _minRetentionDays;

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// This is the name of the vault that is being created.
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
        /// Gets and sets the property BackupVaultTags. 
        /// <para>
        /// These are the tags that will be included in the newly-created vault.
        /// </para>
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
            return this._backupVaultTags != null && this._backupVaultTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This is the ID of the creation request.
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
        /// Gets and sets the property MaxRetentionDays. 
        /// <para>
        /// This is the setting that specifies the maximum retention period that the vault retains
        /// its recovery points. If this parameter is not specified, Backup does not enforce a
        /// maximum retention period on the recovery points in the vault (allowing indefinite
        /// storage).
        /// </para>
        ///  
        /// <para>
        /// If specified, any backup or copy job to the vault must have a lifecycle policy with
        /// a retention period equal to or shorter than the maximum retention period. If the job
        /// retention period is longer than that maximum retention period, then the vault fails
        /// the backup or copy job, and you should either modify your lifecycle settings or use
        /// a different vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// This setting specifies the minimum retention period that the vault retains its recovery
        /// points. If this parameter is not specified, no minimum retention period is enforced.
        /// </para>
        ///  
        /// <para>
        /// If specified, any backup or copy job to the vault must have a lifecycle policy with
        /// a retention period equal to or longer than the minimum retention period. If a job
        /// retention period is shorter than that minimum retention period, then the vault fails
        /// the backup or copy job, and you should either modify your lifecycle settings or use
        /// a different vault.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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