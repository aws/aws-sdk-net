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

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Paginators for the BedrockAgentCore service
    ///</summary>
    public class BedrockAgentCorePaginatorFactory : IBedrockAgentCorePaginatorFactory
    {
        private readonly IAmazonBedrockAgentCore client;

        internal BedrockAgentCorePaginatorFactory(IAmazonBedrockAgentCore client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListActors operation
        ///</summary>
        public IListActorsPaginator ListActors(ListActorsRequest request) 
        {
            return new ListActorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListEvents operation
        ///</summary>
        public IListEventsPaginator ListEvents(ListEventsRequest request) 
        {
            return new ListEventsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMemoryRecords operation
        ///</summary>
        public IListMemoryRecordsPaginator ListMemoryRecords(ListMemoryRecordsRequest request) 
        {
            return new ListMemoryRecordsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListSessions operation
        ///</summary>
        public IListSessionsPaginator ListSessions(ListSessionsRequest request) 
        {
            return new ListSessionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for RetrieveMemoryRecords operation
        ///</summary>
        public IRetrieveMemoryRecordsPaginator RetrieveMemoryRecords(RetrieveMemoryRecordsRequest request) 
        {
            return new RetrieveMemoryRecordsPaginator(this.client, request);
        }
    }
}