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
    /// This is the response object from the StartBackupJob operation.
    /// </summary>
    public partial class StartBackupJobResponse : AmazonWebServiceResponse
    {
        private string _backupJobId;
        private DateTime? _creationDate;
        private bool? _isParent;
        private string _recoveryPointArn;

        /// <summary>
        /// Gets and sets the property BackupJobId. 
        /// <para>
        /// Uniquely identifies a request to Backup to back up a resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a backup job is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property IsParent. 
        /// <para>
        /// This is a returned boolean value indicating this is a parent (composite) backup job.
        /// </para>
        /// </summary>
        public bool IsParent
        {
            get { return this._isParent.GetValueOrDefault(); }
            set { this._isParent = value; }
        }

        // Check to see if IsParent property is set
        internal bool IsSetIsParent()
        {
            return this._isParent.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointArn. 
        /// <para>
        /// An ARN that uniquely identifies a recovery point; for example, <code>arn:aws:backup:us-east-1:123456789012:recovery-point:1EB3B5E7-9EB0-435A-A80B-108B488B0D45</code>.
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