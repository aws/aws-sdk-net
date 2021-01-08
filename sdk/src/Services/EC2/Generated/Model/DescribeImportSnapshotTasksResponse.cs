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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeImportSnapshotTasks operation.
    /// </summary>
    public partial class DescribeImportSnapshotTasksResponse : AmazonWebServiceResponse
    {
        private List<ImportSnapshotTask> _importSnapshotTasks = new List<ImportSnapshotTask>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ImportSnapshotTasks. 
        /// <para>
        /// A list of zero or more import snapshot tasks that are currently active or were completed
        /// or canceled in the previous 7 days.
        /// </para>
        /// </summary>
        public List<ImportSnapshotTask> ImportSnapshotTasks
        {
            get { return this._importSnapshotTasks; }
            set { this._importSnapshotTasks = value; }
        }

        // Check to see if ImportSnapshotTasks property is set
        internal bool IsSetImportSnapshotTasks()
        {
            return this._importSnapshotTasks != null && this._importSnapshotTasks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to get the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
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