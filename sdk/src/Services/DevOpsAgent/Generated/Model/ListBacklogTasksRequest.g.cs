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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListBacklogTasks operation. Lists backlog tasks
    /// in the specified agent space with optional filtering and sorting
    /// </summary>
    public partial class ListBacklogTasksRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing the tasks
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Filter criteria to apply when listing tasks Filtering restrictions: - Each filter
        /// field list is limited to a single value - Filtering by Priority and Status at the
        /// same time when not filtering by Type is not permitted - Timestamp filters (createdAfter,
        /// createdBefore) can be combined with other filters when not sorting by priority
        /// </para>
        /// </summary>
        public TaskFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Maximum number of tasks to return in a single response (1-1000, default: 100)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for retrieving the next page of results
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// Sort order for the tasks based on sortField (default: DESC)
        /// </para>
        /// </summary>
        public TaskSortOrder Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order != null;

        /// <summary>
        /// Gets and sets the property SortField. 
        /// <para>
        /// Field to sort by Sorting restrictions: - Only sorting on createdAt is supported when
        /// using priority or status filters alone. - Sorting by priority is not supported when
        /// using Timestamp filters (createdAfter, createdBefore)
        /// </para>
        /// </summary>
        public TaskSortField SortField { get; set; }

        /// <summary>
        /// Checks to see if the SortField property is set.
        /// </summary>
        internal bool IsSetSortField() => this.SortField != null;
    }
}
