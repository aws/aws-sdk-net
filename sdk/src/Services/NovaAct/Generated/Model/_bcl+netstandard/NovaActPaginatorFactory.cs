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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.NovaAct.Model
{
    /// <summary>
    /// Paginators for the NovaAct service
    ///</summary>
    public partial class NovaActPaginatorFactory : INovaActPaginatorFactory
    {
        private readonly IAmazonNovaAct client;

        internal NovaActPaginatorFactory(IAmazonNovaAct client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListActs operation
        ///</summary>
        public IListActsPaginator ListActs(ListActsRequest request) 
        {
            return new ListActsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        public IListSessionsPaginator ListSessions(ListSessionsRequest request) 
        {
            return new ListSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowDefinitions operation
        ///</summary>
        public IListWorkflowDefinitionsPaginator ListWorkflowDefinitions(ListWorkflowDefinitionsRequest request) 
        {
            return new ListWorkflowDefinitionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListWorkflowRuns operation
        ///</summary>
        public IListWorkflowRunsPaginator ListWorkflowRuns(ListWorkflowRunsRequest request) 
        {
            return new ListWorkflowRunsPaginator(this.client, request);
        }
    }
}