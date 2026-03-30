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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the ListBacklogTasks operation.
    /// Lists backlog tasks in the specified agent space with optional filtering and sorting
    /// </summary>
    public partial class ListBacklogTasksRequest : AmazonDevOpsAgentRequest
    {
        private string _agentSpaceId;
        private TaskFilter _filter;
        private int? _limit;
        private string _nextToken;
        private TaskSortOrder _order;
        private TaskSortField _sortField;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing the tasks
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filter criteria to apply when listing tasks
        /// </para>
        ///  
        /// <para>
        /// Filtering restrictions:
        /// </para>
        ///  <ul> <li>Each filter field list is limited to a single value</li> <li>Filtering by
        /// Priority and Status at the same time when not filtering by Type is not permitted</li>
        /// <li>Timestamp filters (createdAfter, createdBefore) can be combined with other filters
        /// when not sorting by priority</li> </ul>
        /// </summary>
        public TaskFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of tasks to return in a single response (1-1000, default: 100)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for retrieving the next page of results
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Order. 
        /// <para>
        /// Sort order for the tasks based on sortField (default: DESC)
        /// </para>
        /// </summary>
        public TaskSortOrder Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

        /// <summary>
        /// Gets and sets the property SortField. 
        /// <para>
        /// Field to sort by
        /// </para>
        ///  <pre><c>Sorting restrictions: </c></pre> <ul> <li>Only sorting on createdAt is supported
        /// when using priority or status filters alone.</li> <li>Sorting by priority is not supported
        /// when using Timestamp filters (createdAfter, createdBefore)</li> </ul>
        /// </summary>
        public TaskSortField SortField
        {
            get { return this._sortField; }
            set { this._sortField = value; }
        }

        // Check to see if SortField property is set
        internal bool IsSetSortField()
        {
            return this._sortField != null;
        }

    }
}