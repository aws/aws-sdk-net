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
    /// Container for the parameters to the DeleteBackup operation.
    /// Deletes a specified AWS CloudHSM backup. A backup can be restored up to 7 days after
    /// the DeleteBackup request. For more information on restoring a backup, see <a>RestoreBackup</a>
    /// </summary>
    public partial class DeleteBackupRequest : AmazonCloudHSMV2Request
    {
        private string _backupId;

        /// <summary>
        /// Gets and sets the property BackupId. 
        /// <para>
        /// The ID of the backup to be deleted. To find the ID of a backup, use the <a>DescribeBackups</a>
        /// operation.
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