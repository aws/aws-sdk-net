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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Paginators for the BedrockAgent service
    /// </summary>
    public interface IBedrockAgentPaginatorFactory
    {
        /// <summary>
        /// Paginator for ListAgentActionGroups operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentActionGroupsPaginator ListAgentActionGroups(ListAgentActionGroupsRequest request);

        /// <summary>
        /// Paginator for ListAgentAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentAliasesPaginator ListAgentAliases(ListAgentAliasesRequest request);

        /// <summary>
        /// Paginator for ListAgentCollaborators operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentCollaboratorsPaginator ListAgentCollaborators(ListAgentCollaboratorsRequest request);

        /// <summary>
        /// Paginator for ListAgentKnowledgeBases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentKnowledgeBasesPaginator ListAgentKnowledgeBases(ListAgentKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for ListAgentVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentVersionsPaginator ListAgentVersions(ListAgentVersionsRequest request);

        /// <summary>
        /// Paginator for ListAgents operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListAgentsPaginator ListAgents(ListAgentsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListFlowAliases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlowAliasesPaginator ListFlowAliases(ListFlowAliasesRequest request);

        /// <summary>
        /// Paginator for ListFlowVersions operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlowVersionsPaginator ListFlowVersions(ListFlowVersionsRequest request);

        /// <summary>
        /// Paginator for ListFlows operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListFlowsPaginator ListFlows(ListFlowsRequest request);

        /// <summary>
        /// Paginator for ListIngestionJobs operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListIngestionJobsPaginator ListIngestionJobs(ListIngestionJobsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBaseDocuments operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListKnowledgeBaseDocumentsPaginator ListKnowledgeBaseDocuments(ListKnowledgeBaseDocumentsRequest request);

        /// <summary>
        /// Paginator for ListKnowledgeBases operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListKnowledgeBasesPaginator ListKnowledgeBases(ListKnowledgeBasesRequest request);

        /// <summary>
        /// Paginator for ListPrompts operation
        /// </summary>
        [AWSPaginator(InputToken = ["NextToken"], LimitKey = "MaxResults", OutputToken = ["NextToken"])]
        IListPromptsPaginator ListPrompts(ListPromptsRequest request);
    }
}
