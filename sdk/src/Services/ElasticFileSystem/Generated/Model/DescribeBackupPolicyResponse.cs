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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// This is the response object from the DescribeBackupPolicy operation.
    /// </summary>
    public partial class DescribeBackupPolicyResponse : AmazonWebServiceResponse
    {
        private BackupPolicy _backupPolicy;

        /// <summary>
        /// Gets and sets the property BackupPolicy. 
        /// <para>
        /// Describes the file system's backup policy, indicating whether automatic backups are
        /// turned on or off..
        /// </para>
        /// </summary>
        public BackupPolicy BackupPolicy
        {
            get { return this._backupPolicy; }
            set { this._backupPolicy = value; }
        }

        // Check to see if BackupPolicy property is set
        internal bool IsSetBackupPolicy()
        {
            return this._backupPolicy != null;
        }

    }
}