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
#pragma warning disable CS0612,CS0618

namespace Amazon.AgentDiscovery.Model
{
    /// <summary>
    /// Paginators for the AgentDiscovery service
    /// </summary>
    public class AgentDiscoveryPaginatorFactory : IAgentDiscoveryPaginatorFactory
    {
        private readonly IAmazonAgentDiscovery client;

        internal AgentDiscoveryPaginatorFactory(IAmazonAgentDiscovery client)
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for SearchPublicRecords operation
        /// </summary>
        public ISearchPublicRecordsPaginator SearchPublicRecords(SearchPublicRecordsRequest request)
        {
            return new SearchPublicRecordsPaginator(this.client, request);
        }
    }
}
