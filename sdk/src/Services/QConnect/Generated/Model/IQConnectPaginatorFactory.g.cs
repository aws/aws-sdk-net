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
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Paginators for the QConnect service
    /// </summary>
    public interface IQConnectPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAIAgentVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIAgentVersionsPaginator ListAIAgentVersions(ListAIAgentVersionsRequest request);

        /// <summary>
        /// Paginator for ListAIAgents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIAgentsPaginator ListAIAgents(ListAIAgentsRequest request);

        /// <summary>
        /// Paginator for ListAIGuardrailVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIGuardrailVersionsPaginator ListAIGuardrailVersions(ListAIGuardrailVersionsRequest request);

        /// <summary>
        /// Paginator for ListAIGuardrails operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIGuardrailsPaginator ListAIGuardrails(ListAIGuardrailsRequest request);

        /// <summary>
        /// Paginator for ListAIPromptVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIPromptVersionsPaginator ListAIPromptVersions(ListAIPromptVersionsRequest request);

        /// <summary>
        /// Paginator for ListAIPrompts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAIPromptsPaginator ListAIPrompts(ListAIPromptsRequest request);

        /// <summary>
        /// Paginator for ListAssistantAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssistantAssociationsPaginator ListAssistantAssociations(ListAssistantAssociationsRequest request);

        /// <summary>
        /// Paginator for ListAssistants operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAssistantsPaginator ListAssistants(ListAssistantsRequest request);

        /// <summary>
        /// Paginator for ListContentAssociations operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContentAssociationsPaginator ListContentAssociations(ListContentAssociationsRequest request);

        /// <summary>
        /// Paginator for ListContents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListContentsPaginator ListContents(ListContentsRequest request);

        /// <summary>
        /// Paginator for ListImportJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListImportJobsPaginator ListImportJobs(ListImportJobsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for ListMessageTemplateVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMessageTemplateVersionsPaginator ListMessageTemplateVersions(ListMessageTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListMessageTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMessageTemplatesPaginator ListMessageTemplates(ListMessageTemplatesRequest request);

        /// <summary>
        /// Paginator for ListMessages operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListMessagesPaginator ListMessages(ListMessagesRequest request);

        /// <summary>
        /// Paginator for ListModels operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListModelsPaginator ListModels(ListModelsRequest request);

        /// <summary>
        /// Paginator for ListQuickResponses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListQuickResponsesPaginator ListQuickResponses(ListQuickResponsesRequest request);

        /// <summary>
        /// Paginator for ListSpans operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListSpansPaginator ListSpans(ListSpansRequest request);

        /// <summary>
        /// Paginator for QueryAssistant operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IQueryAssistantPaginator QueryAssistant(QueryAssistantRequest request);

        /// <summary>
        /// Paginator for SearchContent operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchContentPaginator SearchContent(SearchContentRequest request);

        /// <summary>
        /// Paginator for SearchMessageTemplates operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchMessageTemplatesPaginator SearchMessageTemplates(SearchMessageTemplatesRequest request);

        /// <summary>
        /// Paginator for SearchQuickResponses operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchQuickResponsesPaginator SearchQuickResponses(SearchQuickResponsesRequest request);

        /// <summary>
        /// Paginator for SearchSessions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        ISearchSessionsPaginator SearchSessions(SearchSessionsRequest request);
    }
}
