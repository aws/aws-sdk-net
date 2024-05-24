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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
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
namespace Amazon.BackupStorage.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteObject operation.
    /// Delete Object from the incremental base Backup.
    /// </summary>
    public partial class DeleteObjectRequest : AmazonBackupStorageRequest
    {
        private string _backupJobId;
        private string _objectName;

        /// <summary>
        /// Gets and sets the property BackupJobId. Backup job Id for the in-progress backup.
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupJobId
        {
            get { return this._backupJobId; }
            set { this._backupJobId = value; }
        }

        // Check to see if BackupJobId property is set
        internal bool IsSetBackupJobId()
        {
            return this._backupJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectName. The name of the Object.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ObjectName
        {
            get { return this._objectName; }
            set { this._objectName = value; }
        }

        // Check to see if ObjectName property is set
        internal bool IsSetObjectName()
        {
            return this._objectName != null;
        }

    }
}