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
using Amazon.Runtime.Internal;

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
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxItems",
            OutputToken = new[] { "NextToken" }
        )]
        IGetAgentMemoryPaginator GetAgentMemory(GetAgentMemoryRequest request);

        /// <summary>
        /// Paginator for ListFlowExecutionEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowExecutionEventsPaginator ListFlowExecutionEvents(ListFlowExecutionEventsRequest request);

        /// <summary>
        /// Paginator for ListFlowExecutions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListFlowExecutionsPaginator ListFlowExecutions(ListFlowExecutionsRequest request);

        /// <summary>
        /// Paginator for ListInvocations operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInvocationsPaginator ListInvocations(ListInvocationsRequest request);

        /// <summary>
        /// Paginator for ListInvocationSteps operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListInvocationStepsPaginator ListInvocationSteps(ListInvocationStepsRequest request);

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListSessionsPaginator ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Paginator for Rerank operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IRerankPaginator Rerank(RerankRequest request);

        /// <summary>
        /// Paginator for Retrieve operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            
            OutputToken = new[] { "NextToken" }
        )]
        IRetrievePaginator Retrieve(RetrieveRequest request);
    }
}