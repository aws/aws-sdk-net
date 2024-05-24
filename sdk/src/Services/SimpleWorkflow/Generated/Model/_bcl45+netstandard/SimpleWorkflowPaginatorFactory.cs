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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Paginators for the SimpleWorkflow service
    ///</summary>
    public class SimpleWorkflowPaginatorFactory : ISimpleWorkflowPaginatorFactory
    {
        private readonly IAmazonSimpleWorkflow client;

        internal SimpleWorkflowPaginatorFactory(IAmazonSimpleWorkflow client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetWorkflowExecutionHistory operation
        ///</summary>
        public IGetWorkflowExecutionHistoryPaginator GetWorkflowExecutionHistory(GetWorkflowExecutionHistoryRequest request) 
        {
            return new GetWorkflowExecutionHistoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListActivityTypes operation
        ///</summary>
        public IListActivityTypesPaginator ListActivityTypes(ListActivityTypesRequest request) 
        {
            return new ListActivityTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListClosedWorkflowExecutions operation
        ///</summary>
        public IListClosedWorkflowExecutionsPaginator ListClosedWorkflowExecutions(ListClosedWorkflowExecutionsRequest request) 
        {
            return new ListClosedWorkflowExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDomains operation
        ///</summary>
        public IListDomainsPaginator ListDomains(ListDomainsRequest request) 
        {
            return new ListDomainsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListOpenWorkflowExecutions operation
        ///</summary>
        public IListOpenWorkflowExecutionsPaginator ListOpenWorkflowExecutions(ListOpenWorkflowExecutionsRequest request) 
        {
            return new ListOpenWorkflowExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowTypes operation
        ///</summary>
        public IListWorkflowTypesPaginator ListWorkflowTypes(ListWorkflowTypesRequest request) 
        {
            return new ListWorkflowTypesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for PollForDecisionTask operation
        ///</summary>
        public IPollForDecisionTaskPaginator PollForDecisionTask(PollForDecisionTaskRequest request) 
        {
            return new PollForDecisionTaskPaginator(this.client, request);
        }
    }
}