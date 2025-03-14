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

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentRuntime service
    ///</summary>
    public interface IBedrockAgentRuntimePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetAgentMemory operation
        ///</summary>
        IGetAgentMemoryPaginator GetAgentMemory(GetAgentMemoryRequest request);

        /// <summary>
        /// Paginator for ListInvocations operation
        ///</summary>
        IListInvocationsPaginator ListInvocations(ListInvocationsRequest request);

        /// <summary>
        /// Paginator for ListInvocationSteps operation
        ///</summary>
        IListInvocationStepsPaginator ListInvocationSteps(ListInvocationStepsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for Rerank operation
        ///</summary>
        IRerankPaginator Rerank(RerankRequest request);

        /// <summary>
        /// Paginator for Retrieve operation
        ///</summary>
        IRetrievePaginator Retrieve(RetrieveRequest request);
    }
}