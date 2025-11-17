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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.MWAAServerless.Model
{
    /// <summary>
    /// Paginators for the MWAAServerless service
    ///</summary>
    public class MWAAServerlessPaginatorFactory : IMWAAServerlessPaginatorFactory
    {
        private readonly IAmazonMWAAServerless client;

        internal MWAAServerlessPaginatorFactory(IAmazonMWAAServerless client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListTaskInstances operation
        ///</summary>
        public IListTaskInstancesPaginator ListTaskInstances(ListTaskInstancesRequest request) 
        {
            return new ListTaskInstancesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowRuns operation
        ///</summary>
        public IListWorkflowRunsPaginator ListWorkflowRuns(ListWorkflowRunsRequest request) 
        {
            return new ListWorkflowRunsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflows operation
        ///</summary>
        public IListWorkflowsPaginator ListWorkflows(ListWorkflowsRequest request) 
        {
            return new ListWorkflowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowVersions operation
        ///</summary>
        public IListWorkflowVersionsPaginator ListWorkflowVersions(ListWorkflowVersionsRequest request) 
        {
            return new ListWorkflowVersionsPaginator(this.client, request);
        }
    }
}