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
    /// This is the response object from the ListBackupPlanVersions operation.
    /// </summary>
    public partial class ListBackupPlanVersionsResponse : AmazonWebServiceResponse
    {
        private List<BackupPlansListMember> _backupPlanVersionsList = new List<BackupPlansListMember>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property BackupPlanVersionsList. 
        /// <para>
        /// An array of version list items containing metadata about your backup plans.
        /// </para>
        /// </summary>
        public List<BackupPlansListMember> BackupPlanVersionsList
        {
            get { return this._backupPlanVersionsList; }
            set { this._backupPlanVersionsList = value; }
        }

        // Check to see if BackupPlanVersionsList property is set
        internal bool IsSetBackupPlanVersionsList()
        {
            return this._backupPlanVersionsList != null && this._backupPlanVersionsList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned items. For example, if a request
        /// is made to return <code>maxResults</code> number of items, <code>NextToken</code>
        /// allows you to return more items in your list starting at the location pointed to by
        /// the next token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}