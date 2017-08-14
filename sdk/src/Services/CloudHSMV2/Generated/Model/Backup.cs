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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Contains information about a backup of an AWS CloudHSM cluster.
    /// </summary>
    public partial class Backup
    {
        private string _backupId;
        private BackupState _backupState;
        private string _clusterId;
        private DateTime? _createTimestamp;

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The identifier (ID) of the backup.
        /// </para>
        /// </summary>
        public string BackupId
        {
            get { return this._backupId; }
            set { this._backupId = value; }
        }

        // Check to see if BackupId property is set
        internal bool IsSetBackupId()
        {
            return this._backupId != null;
        }

        /// <summary>
        /// Gets and sets the property BackupState. 
        /// <para>
        /// The state of the backup.
        /// </para>
        /// </summary>
        public BackupState BackupState
        {
            get { return this._backupState; }
            set { this._backupState = value; }
        }

        // Check to see if BackupState property is set
        internal bool IsSetBackupState()
        {
            return this._backupState != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that was backed up.
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTimestamp. 
        /// <para>
        /// The date and time when the backup was created.
        /// </para>
        /// </summary>
        public DateTime CreateTimestamp
        {
            get { return this._createTimestamp.GetValueOrDefault(); }
            set { this._createTimestamp = value; }
        }

        // Check to see if CreateTimestamp property is set
        internal bool IsSetCreateTimestamp()
        {
            return this._createTimestamp.HasValue; 
        }

    }
}