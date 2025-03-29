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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Paginators for the SimpleWorkflow service
    ///</summary>
    public interface ISimpleWorkflowPaginatorFactory
    {

        /// <summary>
        /// Paginator for GetWorkflowExecutionHistory operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaximumPageSize",
            OutputToken = new[] { "History.NextPageToken" }
        )]
        IGetWorkflowExecutionHistoryPaginator GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request);

        /// <summary>
        /// Paginator for ListActivityTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaximumPageSize",
            OutputToken = new[] { "ActivityTypeInfos.NextPageToken" }
        )]
        IListActivityTypesPaginator ListActivityTypes(ListActivityTypesRequest request);

        /// <summary>
        /// Paginator for ListClosedWorkflowExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaximumPageSize",
            OutputToken = new[] { "WorkflowExecutionInfos.NextPageToken" }
        )]
        IListClosedWorkflowExecutionsPaginator ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request);

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaximumPageSize",
            OutputToken = new[] { "DomainInfos.NextPageToken" }
        )]
        IListDomainsPaginator ListDomains(ListDomainsRequest request);

        /// <summary>
        /// Paginator for ListOpenWorkflowExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaximumPageSize",
            OutputToken = new[] { "WorkflowExecutionInfos.NextPageToken" }
        )]
        IListOpenWorkflowExecutionsPaginator ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request);

        /// <summary>
        /// Paginator for ListWorkflowTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaximumPageSize",
            OutputToken = new[] { "WorkflowTypeInfos.NextPageToken" }
        )]
        IListWorkflowTypesPaginator ListWorkflowTypes(ListWorkflowTypesRequest request);

        /// <summary>
        /// Paginator for PollForDecisionTask operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextPageToken" },
            LimitKey = "MaximumPageSize",
            OutputToken = new[] { "DecisionTask.NextPageToken" }
        )]
        IPollForDecisionTaskPaginator PollForDecisionTask(PollForDecisionTaskRequest request);
    }
}