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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The backup configuration for the data store.
    /// </summary>
    public partial class BackupConfiguration
    {
        private bool? _backupTagsEnabled;
        private BackupType _backupType;
        private int? _retentionPeriodInDays;
        private BackupStatus _status;

        /// <summary>
        /// Gets and sets the property BackupTagsEnabled. 
        /// <para>
        /// Specifies whether tags are included in backups.
        /// </para>
        /// </summary>
        public bool? BackupTagsEnabled
        {
            get { return this._backupTagsEnabled; }
            set { this._backupTagsEnabled = value; }
        }

        // Check to see if BackupTagsEnabled property is set
        internal bool IsSetBackupTagsEnabled()
        {
            return this._backupTagsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BackupType. 
        /// <para>
        /// The type of backup.
        /// </para>
        /// </summary>
        public BackupType BackupType
        {
            get { return this._backupType; }
            set { this._backupType = value; }
        }

        // Check to see if BackupType property is set
        internal bool IsSetBackupType()
        {
            return this._backupType != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// The number of days backup data is retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public int? RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays; }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The backup status of the data store.
        /// </para>
        /// </summary>
        public BackupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}