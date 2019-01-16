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
    /// This is the response object from the CreateBackupPlan operation.
    /// </summary>
    public partial class CreateBackupPlanResponse : AmazonWebServiceResponse
    {
        private string _backupPlanArn;
        private string _backupPlanId;
        private DateTime? _creationDate;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BackupPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup plan; for example,
        /// <code>arn:aws:backup:us-east-1:123456789012:plan:8F81F553-3A74-4A3F-B93D-B3360DC80C50</code>.
        /// </para>
        /// </summary>
        public string BackupPlanArn
        {
            get { return this._backupPlanArn; }
            set { this._backupPlanArn = value; }
        }

        // Check to see if BackupPlanArn property is set
        internal bool IsSetBackupPlanArn()
        {
            return this._backupPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupPlanId. 
        /// <para>
        /// Uniquely identifies a backup plan.
        /// </para>
        /// </summary>
        public string BackupPlanId
        {
            get { return this._backupPlanId; }
            set { this._backupPlanId = value; }
        }

        // Check to see if BackupPlanId property is set
        internal bool IsSetBackupPlanId()
        {
            return this._backupPlanId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that a backup plan is created, in Unix format and Coordinated Universal
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Unique, randomly generated, Unicode, UTF-8 encoded strings that are at most 1024 bytes
        /// long. They cannot be edited.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}