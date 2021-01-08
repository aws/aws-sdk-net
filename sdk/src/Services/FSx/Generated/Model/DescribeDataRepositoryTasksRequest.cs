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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDataRepositoryTasks operation.
    /// Returns the description of specific Amazon FSx for Lustre data repository tasks, if
    /// one or more <code>TaskIds</code> values are provided in the request, or if filters
    /// are used in the request. You can use filters to narrow the response to include just
    /// tasks for specific file systems, or tasks in a specific lifecycle state. Otherwise,
    /// it returns all data repository tasks owned by your AWS account in the AWS Region of
    /// the endpoint that you're calling.
    /// 
    ///  
    /// <para>
    /// When retrieving all tasks, you can paginate the response by using the optional <code>MaxResults</code>
    /// parameter to limit the number of tasks returned in a response. If more tasks remain,
    /// Amazon FSx returns a <code>NextToken</code> value in the response. In this case, send
    /// a later request with the <code>NextToken</code> request parameter set to the value
    /// of <code>NextToken</code> from the last response.
    /// </para>
    /// </summary>
    public partial class DescribeDataRepositoryTasksRequest : AmazonFSxRequest
    {
        private List<DataRepositoryTaskFilter> _filters = new List<DataRepositoryTaskFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _taskIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// (Optional) You can use filters to narrow the <code>DescribeDataRepositoryTasks</code>
        /// response to include just tasks for specific file systems, or tasks in a specific lifecycle
        /// state.
        /// </para>
        /// </summary>
        [AWSProperty(Max=3)]
        public List<DataRepositoryTaskFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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

        /// <summary>
        /// Gets and sets the property TaskIds. 
        /// <para>
        /// (Optional) IDs of the tasks whose descriptions you want to retrieve (String).
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> TaskIds
        {
            get { return this._taskIds; }
            set { this._taskIds = value; }
        }

        // Check to see if TaskIds property is set
        internal bool IsSetTaskIds()
        {
            return this._taskIds != null && this._taskIds.Count > 0; 
        }

    }
}