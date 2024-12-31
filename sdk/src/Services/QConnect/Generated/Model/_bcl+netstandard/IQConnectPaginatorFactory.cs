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

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Paginators for the QConnect service
    ///</summary>
    public interface IQConnectPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListAIAgents operation
        ///</summary>
        IListAIAgentsPaginator ListAIAgents(ListAIAgentsRequest request);

        /// <summary>
        /// Paginator for ListAIAgentVersions operation
        ///</summary>
        IListAIAgentVersionsPaginator ListAIAgentVersions(ListAIAgentVersionsRequest request);

        /// <summary>
        /// Paginator for ListAIGuardrails operation
        ///</summary>
        IListAIGuardrailsPaginator ListAIGuardrails(ListAIGuardrailsRequest request);

        /// <summary>
        /// Paginator for ListAIGuardrailVersions operation
        ///</summary>
        IListAIGuardrailVersionsPaginator ListAIGuardrailVersions(ListAIGuardrailVersionsRequest request);

        /// <summary>
        /// Paginator for ListAIPrompts operation
        ///</summary>
        IListAIPromptsPaginator ListAIPrompts(ListAIPromptsRequest request);

        /// <summary>
        /// Paginator for ListAIPromptVersions operation
        ///</summary>
        IListAIPromptVersionsPaginator ListAIPromptVersions(ListAIPromptVersionsRequest request);

        /// <summary>
        /// Paginator for ListAssistantAssociations operation
        ///</summary>
        IListAssistantAssociationsPaginator ListAssistantAssociations(ListAssistantAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAssistants operation
        ///</summary>
        IListAssistantsPaginator ListAssistants(ListAssistantsRequest request);

        /// <summary>
        /// Paginator for ListContentAssociations operation
        ///</summary>
        IListContentAssociationsPaginator ListContentAssociations(ListContentAssociationsRequest request);

        /// <summary>
        /// Paginator for ListContents operation
        ///</summary>
        IListContentsPaginator ListContents(ListContentsRequest request);

        /// <summary>
        /// Paginator for ListImportJobs operation
        ///</summary>
        IListImportJobsPaginator ListImportJobs(ListImportJobsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        ///</summary>
        IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for ListMessages operation
        ///</summary>
        IListMessagesPaginator ListMessages(ListMessagesRequest request);

        /// <summary>
        /// Paginator for ListMessageTemplates operation
        ///</summary>
        IListMessageTemplatesPaginator ListMessageTemplates(ListMessageTemplatesRequest request);

        /// <summary>
        /// Paginator for ListMessageTemplateVersions operation
        ///</summary>
        IListMessageTemplateVersionsPaginator ListMessageTemplateVersions(ListMessageTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListQuickResponses operation
        ///</summary>
        IListQuickResponsesPaginator ListQuickResponses(ListQuickResponsesRequest request);

        /// <summary>
        /// Paginator for QueryAssistant operation
        ///</summary>
        IQueryAssistantPaginator QueryAssistant(QueryAssistantRequest request);

        /// <summary>
        /// Paginator for SearchContent operation
        ///</summary>
        ISearchContentPaginator SearchContent(SearchContentRequest request);

        /// <summary>
        /// Paginator for SearchMessageTemplates operation
        ///</summary>
        ISearchMessageTemplatesPaginator SearchMessageTemplates(SearchMessageTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchQuickResponses operation
        ///</summary>
        ISearchQuickResponsesPaginator SearchQuickResponses(SearchQuickResponsesRequest request);

        /// <summary>
        /// Paginator for SearchSessions operation
        ///</summary>
        ISearchSessionsPaginator SearchSessions(SearchSessionsRequest request);
    }
}