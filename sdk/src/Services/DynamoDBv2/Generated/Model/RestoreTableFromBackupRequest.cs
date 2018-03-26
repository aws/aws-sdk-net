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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreTableFromBackup operation.
    /// Creates a new table from an existing backup. Any number of users can execute up to
    /// 4 concurrent restores (any type of restore) in a given account. 
    /// 
    ///  
    /// <para>
    /// You can call <code>RestoreTableFromBackup</code> at a maximum rate of 10 times per
    /// second.
    /// </para>
    ///  
    /// <para>
    /// You must manually set up the following on the restored table:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Auto scaling policies
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IAM policies
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cloudwatch metrics and alarms
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tags
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stream settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Time to Live (TTL) settings
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RestoreTableFromBackupRequest : AmazonDynamoDBRequest
    {
        private string _backupArn;
        private string _targetTableName;

        /// <summary>
        /// Gets and sets the property BackupArn. 
        /// <para>
        /// The ARN associated with the backup.
        /// </para>
        /// </summary>
        public string BackupArn
        {
            get { return this._backupArn; }
            set { this._backupArn = value; }
        }

        // Check to see if BackupArn property is set
        internal bool IsSetBackupArn()
        {
            return this._backupArn != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// The name of the new table to which the backup must be restored.
        /// </para>
        /// </summary>
        public string TargetTableName
        {
            get { return this._targetTableName; }
            set { this._targetTableName = value; }
        }

        // Check to see if TargetTableName property is set
        internal bool IsSetTargetTableName()
        {
            return this._targetTableName != null;
        }

    }
}