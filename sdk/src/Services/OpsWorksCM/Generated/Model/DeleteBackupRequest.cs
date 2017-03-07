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
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorksCM.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteBackup operation.
    /// Deletes a backup. You can delete both manual and automated backups. This operation
    /// is asynchronous. 
    /// 
    ///  
    /// <para>
    ///  An <code>InvalidStateException</code> is thrown when a backup deletion is already
    /// in progress. A <code>ResourceNotFoundException</code> is thrown when the backup does
    /// not exist. A <code>ValidationException</code> is thrown when parameters of the request
    /// are not valid. 
    /// </para>
    /// </summary>
    public partial class DeleteBackupRequest : AmazonOpsWorksCMRequest
    {
        private string _backupId;

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup to delete. Run the DescribeBackups command to get a list of backup
        /// IDs. Backup IDs are in the format <code>ServerName-yyyyMMddHHmmssSSS</code>. 
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

    }
}