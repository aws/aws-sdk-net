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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Paginators for the BedrockAgent service
    ///</summary>
    public class BedrockAgentPaginatorFactory : IBedrockAgentPaginatorFactory
    {
        private readonly IAmazonBedrockAgent client;

        internal BedrockAgentPaginatorFactory(IAmazonBedrockAgent client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAgentActionGroups operation
        ///</summary>
        public IListAgentActionGroupsPaginator ListAgentActionGroups(ListAgentActionGroupsRequest request) 
        {
            return new ListAgentActionGroupsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgentAliases operation
        ///</summary>
        public IListAgentAliasesPaginator ListAgentAliases(ListAgentAliasesRequest request) 
        {
            return new ListAgentAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgentCollaborators operation
        ///</summary>
        public IListAgentCollaboratorsPaginator ListAgentCollaborators(ListAgentCollaboratorsRequest request) 
        {
            return new ListAgentCollaboratorsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgentKnowledgeBases operation
        ///</summary>
        public IListAgentKnowledgeBasesPaginator ListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request) 
        {
            return new ListAgentKnowledgeBasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgents operation
        ///</summary>
        public IListAgentsPaginator ListAgents(ListAgentsRequest request) 
        {
            return new ListAgentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAgentVersions operation
        ///</summary>
        public IListAgentVersionsPaginator ListAgentVersions(ListAgentVersionsRequest request) 
        {
            return new ListAgentVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        public IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request) 
        {
            return new ListDataSourcesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlowAliases operation
        ///</summary>
        public IListFlowAliasesPaginator ListFlowAliases(ListFlowAliasesRequest request) 
        {
            return new ListFlowAliasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlows operation
        ///</summary>
        public IListFlowsPaginator ListFlows(ListFlowsRequest request) 
        {
            return new ListFlowsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListFlowVersions operation
        ///</summary>
        public IListFlowVersionsPaginator ListFlowVersions(ListFlowVersionsRequest request) 
        {
            return new ListFlowVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListIngestionJobs operation
        ///</summary>
        public IListIngestionJobsPaginator ListIngestionJobs(ListIngestionJobsRequest request) 
        {
            return new ListIngestionJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKnowledgeBaseDocuments operation
        ///</summary>
        public IListKnowledgeBaseDocumentsPaginator ListKnowledgeBaseDocuments(ListKnowledgeBaseDocumentsRequest request) 
        {
            return new ListKnowledgeBaseDocumentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        ///</summary>
        public IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request) 
        {
            return new ListKnowledgeBasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListPrompts operation
        ///</summary>
        public IListPromptsPaginator ListPrompts(ListPromptsRequest request) 
        {
            return new ListPromptsPaginator(this.client, request);
        }
    }
}