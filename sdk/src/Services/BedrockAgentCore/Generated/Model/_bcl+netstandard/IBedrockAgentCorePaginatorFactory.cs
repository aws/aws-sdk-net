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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentCore service
    ///</summary>
    public interface IBedrockAgentCorePaginatorFactory
    {

        /// <summary>
        /// Paginator for ListActors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListActorsPaginator ListActors(ListActorsRequest request);

        /// <summary>
        /// Paginator for ListEvents operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventsPaginator ListEvents(ListEventsRequest request);

        /// <summary>
        /// Paginator for ListMemoryRecords operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListMemoryRecordsPaginator ListMemoryRecords(ListMemoryRecordsRequest request);

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
        /// Paginator for RetrieveMemoryRecords operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IRetrieveMemoryRecordsPaginator RetrieveMemoryRecords(RetrieveMemoryRecordsRequest request);
    }
}