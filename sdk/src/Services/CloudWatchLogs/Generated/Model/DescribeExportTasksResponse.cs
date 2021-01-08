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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the DescribeExportTasks operation.
    /// </summary>
    public partial class DescribeExportTasksResponse : AmazonWebServiceResponse
    {
        private List<ExportTask> _exportTasks = new List<ExportTask>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExportTasks. 
        /// <para>
        /// The export tasks.
        /// </para>
        /// </summary>
        public List<ExportTask> ExportTasks
        {
            get { return this._exportTasks; }
            set { this._exportTasks = value; }
        }

        // Check to see if ExportTasks property is set
        internal bool IsSetExportTasks()
        {
            return this._exportTasks != null && this._exportTasks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1)]
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