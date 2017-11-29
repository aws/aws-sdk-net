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
    /// This is the response object from the ListBackups operation.
    /// </summary>
    public partial class ListBackupsResponse : AmazonWebServiceResponse
    {
        private List<BackupSummary> _backupSummaries = new List<BackupSummary>();
        private string _lastEvaluatedBackupArn;

        /// <summary>
        /// Gets and sets the property BackupSummaries. 
        /// <para>
        /// List of <code>BackupSummary</code> objects.
        /// </para>
        /// </summary>
        public List<BackupSummary> BackupSummaries
        {
            get { return this._backupSummaries; }
            set { this._backupSummaries = value; }
        }

        // Check to see if BackupSummaries property is set
        internal bool IsSetBackupSummaries()
        {
            return this._backupSummaries != null && this._backupSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedBackupArn. 
        /// <para>
        /// Last evaluated BackupARN.
        /// </para>
        /// </summary>
        public string LastEvaluatedBackupArn
        {
            get { return this._lastEvaluatedBackupArn; }
            set { this._lastEvaluatedBackupArn = value; }
        }

        // Check to see if LastEvaluatedBackupArn property is set
        internal bool IsSetLastEvaluatedBackupArn()
        {
            return this._lastEvaluatedBackupArn != null;
        }

    }
}