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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Paginators for the QConnect service
    ///</summary>
    public class QConnectPaginatorFactory : IQConnectPaginatorFactory
    {
        private readonly IAmazonQConnect client;

        internal QConnectPaginatorFactory(IAmazonQConnect client) 
        {
            this.client = client;
        }

        /// <summary>
        /// Paginator for ListAIAgents operation
        ///</summary>
        public IListAIAgentsPaginator ListAIAgents(ListAIAgentsRequest request) 
        {
            return new ListAIAgentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAIAgentVersions operation
        ///</summary>
        public IListAIAgentVersionsPaginator ListAIAgentVersions(ListAIAgentVersionsRequest request) 
        {
            return new ListAIAgentVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAIGuardrails operation
        ///</summary>
        public IListAIGuardrailsPaginator ListAIGuardrails(ListAIGuardrailsRequest request) 
        {
            return new ListAIGuardrailsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAIGuardrailVersions operation
        ///</summary>
        public IListAIGuardrailVersionsPaginator ListAIGuardrailVersions(ListAIGuardrailVersionsRequest request) 
        {
            return new ListAIGuardrailVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAIPrompts operation
        ///</summary>
        public IListAIPromptsPaginator ListAIPrompts(ListAIPromptsRequest request) 
        {
            return new ListAIPromptsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAIPromptVersions operation
        ///</summary>
        public IListAIPromptVersionsPaginator ListAIPromptVersions(ListAIPromptVersionsRequest request) 
        {
            return new ListAIPromptVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssistantAssociations operation
        ///</summary>
        public IListAssistantAssociationsPaginator ListAssistantAssociations(ListAssistantAssociationsRequest request) 
        {
            return new ListAssistantAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListAssistants operation
        ///</summary>
        public IListAssistantsPaginator ListAssistants(ListAssistantsRequest request) 
        {
            return new ListAssistantsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContentAssociations operation
        ///</summary>
        public IListContentAssociationsPaginator ListContentAssociations(ListContentAssociationsRequest request) 
        {
            return new ListContentAssociationsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListContents operation
        ///</summary>
        public IListContentsPaginator ListContents(ListContentsRequest request) 
        {
            return new ListContentsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListImportJobs operation
        ///</summary>
        public IListImportJobsPaginator ListImportJobs(ListImportJobsRequest request) 
        {
            return new ListImportJobsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        ///</summary>
        public IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request) 
        {
            return new ListKnowledgeBasesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMessages operation
        ///</summary>
        public IListMessagesPaginator ListMessages(ListMessagesRequest request) 
        {
            return new ListMessagesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMessageTemplates operation
        ///</summary>
        public IListMessageTemplatesPaginator ListMessageTemplates(ListMessageTemplatesRequest request) 
        {
            return new ListMessageTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListMessageTemplateVersions operation
        ///</summary>
        public IListMessageTemplateVersionsPaginator ListMessageTemplateVersions(ListMessageTemplateVersionsRequest request) 
        {
            return new ListMessageTemplateVersionsPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for ListQuickResponses operation
        ///</summary>
        public IListQuickResponsesPaginator ListQuickResponses(ListQuickResponsesRequest request) 
        {
            return new ListQuickResponsesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for QueryAssistant operation
        ///</summary>
        public IQueryAssistantPaginator QueryAssistant(QueryAssistantRequest request) 
        {
            return new QueryAssistantPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchContent operation
        ///</summary>
        public ISearchContentPaginator SearchContent(SearchContentRequest request) 
        {
            return new SearchContentPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchMessageTemplates operation
        ///</summary>
        public ISearchMessageTemplatesPaginator SearchMessageTemplates(SearchMessageTemplatesRequest request) 
        {
            return new SearchMessageTemplatesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchQuickResponses operation
        ///</summary>
        public ISearchQuickResponsesPaginator SearchQuickResponses(SearchQuickResponsesRequest request) 
        {
            return new SearchQuickResponsesPaginator(this.client, request);
        }

        /// <summary>
        /// Paginator for SearchSessions operation
        ///</summary>
        public ISearchSessionsPaginator SearchSessions(SearchSessionsRequest request) 
        {
            return new SearchSessionsPaginator(this.client, request);
        }
    }
}