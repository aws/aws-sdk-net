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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentRuntime service
    ///</summary>
    public class BedrockAgentRuntimePaginatorFactory : IBedrockAgentRuntimePaginatorFactory
    {
        private readonly IAmazonBedrockAgentRuntime client;

        internal BedrockAgentRuntimePaginatorFactory(IAmazonBedrockAgentRuntime client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for GetAgentMemory operation
        ///</summary>
        public IGetAgentMemoryPaginator GetAgentMemory(GetAgentMemoryRequest request) 
        {
            return new GetAgentMemoryPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlowExecutionEvents operation
        ///</summary>
        public IListFlowExecutionEventsPaginator ListFlowExecutionEvents(ListFlowExecutionEventsRequest request) 
        {
            return new ListFlowExecutionEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlowExecutions operation
        ///</summary>
        public IListFlowExecutionsPaginator ListFlowExecutions(ListFlowExecutionsRequest request) 
        {
            return new ListFlowExecutionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvocations operation
        ///</summary>
        public IListInvocationsPaginator ListInvocations(ListInvocationsRequest request) 
        {
            return new ListInvocationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListInvocationSteps operation
        ///</summary>
        public IListInvocationStepsPaginator ListInvocationSteps(ListInvocationStepsRequest request) 
        {
            return new ListInvocationStepsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        public IListSessionsPaginator ListSessions(ListSessionsRequest request) 
        {
            return new ListSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for Rerank operation
        ///</summary>
        public IRerankPaginator Rerank(RerankRequest request) 
        {
            return new RerankPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for Retrieve operation
        ///</summary>
        public IRetrievePaginator Retrieve(RetrieveRequest request) 
        {
            return new RetrievePaginator(this.client, request);
        }
    }
}